'**********************************************************************************************
' Rewritten by Alex Brown and Daniel Lips
'**********************************************************************************************

'This class defines the card table.
Public Class frmCardTable

    Private picboxControl1 As New List(Of PictureBox)
    Private picboxControl2 As New List(Of PictureBox)
    Private wagerAmount As Decimal            'holds wager amount for bet
    Private myDeck As Deck
    Private dealerHand As Hand
    Private playerHands As List(Of Hand)    ' List to allow for splitting

    Private playerScore As Integer
    Private dealerScore As Integer

    Private Sub frmCardTable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        picboxControl1.AddRange({PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11})
        picboxControl2.AddRange({PictureBox12, PictureBox13, PictureBox14, PictureBox15, PictureBox16, PictureBox17, PictureBox18, PictureBox19, PictureBox20, PictureBox21, PictureBox22})

        txtWinnings.Text = frmBlackJack_Main.user.Cash.ToString
        txtBank.Text = frmBlackJack_Main.dealer.Cash.ToString
    End Sub

    Private Sub btnWager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWager.Click

        'This will try to convert the input in the wager textbox into an integer.
        'It won't be able to unless the user enters numbers.
        Try
            wagerAmount = CDec(txtWager.Text) 'conversion of text input to integer
            'accounts for wager that is higher than player or bank cash.
            If wagerAmount > frmBlackJack_Main.user.Cash Or wagerAmount > frmBlackJack_Main.dealer.Cash Then
                MessageBox.Show("Wager is too high to bet with.", "Not Enough")
                WagerReset()
                Exit Sub
            ElseIf wagerAmount < 0 Then 'accounts for negative numbers
                MessageBox.Show("Please enter only positive numbers.", "Numbers Only")
                WagerReset()
                Exit Sub
            ElseIf wagerAmount = 0 Then 'accounts for 0
                MessageBox.Show("Gotta wager something!", "Come on!")
                WagerReset()
                Exit Sub
            ElseIf wagerAmount > 25 Then 'accounts for our max bet, 25.
                MessageBox.Show("The maximum bet is 25.", "Too rich for our blood.")
                WagerReset()
                Exit Sub
            ElseIf txtWager.Text.Contains(".") Then
                MessageBox.Show("Please bet in whole amounts!", "Don't be using change.")
                WagerReset()
                Exit Sub
            End If
            ' Controls program flow.
            btnDealHand.Visible = True
            btnWager.Visible = False
            'makes sure the user cannot change the wager once input is ok
            txtWager.ReadOnly = True
        Catch 'handles both nonnumeric input and no input
            MessageBox.Show("Please enter numbers only.", "Just Numbers")
            WagerReset()
        End Try

    End Sub

    Private Sub btnDealHand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDealHand.Click

        myDeck = New Deck
        myDeck.Shuffle()

        playerHands = New List(Of Hand)
        playerHands.Add(New Hand)
        dealerHand = New Hand

        'deals two cards to both the player and the dealer
        For i = 0 To 1
            playerHands(0).AddCard(myDeck.TakeCard)
            dealerHand.AddCard(myDeck.TakeCard)

            'show the players cards in the text box
            rtbPlayersHand.AppendText(playerHands(0).Cards(i).ToString & vbCrLf)
            picboxControl1(i).Image = ImageList1.Images.Item(playerHands(0).Cards(i).ImageIndex)
            picboxControl1(i).Visible = True

        Next

        'show only the dealer's first card
        rtbDealersHand.AppendText(dealerHand.Cards(0).ToString & vbCrLf)

        RichTextBox1.AppendText(myDeck.DeckState)

        txtPlayerScore1.Text = playerHands(0).Score.ToString
        txtDealerScore.Text = dealerHand.Score.ToString

        txtPlayerScore1.Visible = True
        lblPlayerScore1.Visible = True
        btnDealHand.Visible = False
        btnHitMe1.Visible = True
        btnStay1.Visible = True
        btnDouble.Visible = True
        btnSplit.Visible = True

        Blackjack_Check(playerHands(0))
    End Sub

    Private Sub Blackjack_Check(ByRef h As Hand)
        If h.Blackjack = True And dealerHand.Blackjack = False Then
            ' insta-win at 3:2
            MessageBox.Show("Blackjack!")
            wagerAmount *= 1.5D
            AssignStats(frmBlackJack_Main.user, frmBlackJack_Main.dealer)
            Reset()
        ElseIf h.Blackjack = True And dealerHand.Blackjack = True Then
            ' push
            MessageBox.Show("Blackjack! But the dealer has it too...bummer.")
            AssignStats(frmBlackJack_Main.user, frmBlackJack_Main.dealer, True)
            Reset()
        ElseIf dealerHand.Blackjack = True Then
            'dealer wins
            MessageBox.Show("Dealer has Blackjack!")
            AssignStats(frmBlackJack_Main.dealer, frmBlackJack_Main.user)
            Reset()
        End If
    End Sub

    Private Sub btnHitMe1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitMe1.Click
        PlayerHit(playerHands(0), picboxControl1)

        ' You can't double down or split after the first hit
        btnSplit.Visible = False
        btnDouble.Visible = False


    End Sub

    Private Sub btnHitMe2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitMe2.Click
        PlayerHit(playerHands(1), picboxControl2)

    End Sub

    Private Sub PlayerHit(ByRef h As Hand, ByRef p As List(Of PictureBox))
        h.AddCard(myDeck.TakeCard)

        rtbPlayersHand.AppendText(h.Cards(h.Length - 1).ToString & vbCrLf)
        p(h.Length - 1).Image = ImageList1.Images.Item(h.Cards(h.Length - 1).ImageIndex)
        p(h.Length - 1).Visible = True

        If playerHands.Count = 2 Then
            txtPlayerScore1.Text = playerHands(0).Score.ToString
            txtPlayerScore2.Text = playerHands(1).Score.ToString
        Else
            txtPlayerScore1.Text = playerHands(0).Score.ToString
        End If

        ' if you get 21 or bust, automatically calculate outcome since no user input is required
        If h.Score = 21 Then
            PlayerStay(h)
            Reset()
        ElseIf h.Score > 21 Then
            Outcome(h)
        End If
    End Sub

    Private Sub btnStay1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStay1.Click

        If playerHands.Count = 2 Then
            PlayerStay(playerHands(0))
            If playerHands(1).Finished = True Then
                Reset()
            End If
        Else
            PlayerStay(playerHands(0))
            Reset()
        End If
    End Sub

    Private Sub btnStay2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStay2.Click
        PlayerStay(playerHands(1))
        If playerHands(0).Finished = True Then
            Reset()
        End If
    End Sub

    Private Sub PlayerStay(ByRef h As Hand)
        rtbDealersHand.AppendText(dealerHand.Cards(1).ToString & vbCrLf)
        ' The dealer hits until his score is 17 or greater
        While dealerHand.Score < 17
            dealerHand.AddCard(myDeck.TakeCard)
            rtbDealersHand.AppendText(dealerHand.Cards(dealerHand.Length - 1).ToString & vbCrLf)
            txtDealerScore.Text = dealerHand.Score.ToString
        End While

        ' Check for dealer bust
        If dealerHand.Score > 21 Then
            MessageBox.Show("Dealer bust!")
            AssignStats(frmBlackJack_Main.user, frmBlackJack_Main.dealer)
            h.Finished = True
        Else
            Outcome(h)
        End If
    End Sub

    Private Sub Outcome(ByRef h As Hand)

        If h.Score > 21 Then
            ' loss, lose wager amount
            MessageBox.Show("You lose! You get nothing!")
            AssignStats(frmBlackJack_Main.dealer, frmBlackJack_Main.user)
        ElseIf h.Score > dealerHand.Score Then
            ' beating the dealer wins you the wager amount
            MessageBox.Show("Congrats, you win!")
            AssignStats(frmBlackJack_Main.user, frmBlackJack_Main.dealer)
        ElseIf h.Score = dealerHand.Score Then
            ' push, no change to balance
            MessageBox.Show("Push")
            AssignStats(frmBlackJack_Main.dealer, frmBlackJack_Main.user, True)
        ElseIf h.Score < dealerHand.Score Then
            ' loss, lose wager amount
            MessageBox.Show("You lose! You get nothing!")
            AssignStats(frmBlackJack_Main.dealer, frmBlackJack_Main.user)
        End If
        h.Finished = True

        If playerHands.Count = 1 And playerHands(0).Finished = True Then
            Reset()
        ElseIf playerHands(0).Finished = True And playerHands(1).Finished = False Then
            btnHitMe1.Visible = False
            btnStay1.Visible = False
        ElseIf playerHands(0).Finished = False And playerHands(1).Finished = True Then
            btnHitMe2.Visible = False
            btnStay2.Visible = False
        ElseIf playerHands(0).Finished = True And playerHands(1).Finished = True Then
            Reset()
        End If
    End Sub

    Private Sub AssignStats(ByRef winner As Player, ByRef loser As Player, Optional ByVal push As Boolean = False)
        If push = False Then
            winner.Cash += wagerAmount
            winner.Winnings += wagerAmount
            winner.Won += 1
            loser.Cash -= wagerAmount
        End If

        ' check for split
        If playerHands.Count = 2 Then
            winner.Played += 0.5D
            loser.Played += 0.5D
        Else
            winner.Played += 1
            loser.Played += 1
        End If
    End Sub

    Public Sub Reset()
        'clear all text boxes, reset buttons/labels for new hand
        rtbDealersHand.Text = ""
        rtbPlayersHand.Text = ""
        txtDealerScore.Text = ""
        txtPlayerScore1.Text = ""
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        btnDealHand.Visible = False
        btnHitMe1.Visible = False
        btnHitMe2.Visible = False
        btnStay1.Visible = False
        btnStay2.Visible = False
        btnWager.Visible = True
        btnSplit.Visible = False
        btnDouble.Visible = False
        lblPlayerScore2.Visible = False
        lblPlayerScore1.Visible = False
        txtPlayerScore2.Visible = False
        txtPlayerScore1.Visible = False

        txtWinnings.Text = frmBlackJack_Main.user.Cash.ToString
        txtBank.Text = frmBlackJack_Main.dealer.Cash.ToString
        'makes sure the user can input wager for next hand
        txtWager.ReadOnly = False

        WagerReset()

        For i As Integer = picboxControl1.Count - 1 To 0 Step -1
            picboxControl1(i).Visible = False
            picboxControl2(i).Visible = False
        Next
    End Sub

    Sub WagerReset()
        txtWager.Text = String.Empty
        wagerAmount = 0
        txtWager.Focus()
    End Sub

    Private Sub btnSplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSplit.Click
        If playerHands(0).Cards(0).CardValue = playerHands(0).Cards(1).CardValue Then
            playerHands.Add(New Hand)

            ' Add 2nd card of hand 1 to hand 2, then remove that card from hand 1
            playerHands(1).AddCard(playerHands(0).Cards(1))
            playerHands(0).RemoveCard(1)

            picboxControl1(1).Visible = False
            picboxControl2(0).Image = ImageList1.Images.Item(playerHands(1).Cards(0).ImageIndex)
            picboxControl2(0).Visible = True

            ' Add a card to each hand
            PlayerHit(playerHands(0), picboxControl1)
            PlayerHit(playerHands(1), picboxControl2)

            txtPlayerScore1.Text = playerHands(0).Score.ToString
            txtPlayerScore2.Text = playerHands(1).Score.ToString

            lblPlayerScore2.Visible = True
            txtPlayerScore2.Visible = True
            btnHitMe2.Visible = True
            btnStay2.Visible = True

            btnDouble.Visible = False
            btnSplit.Visible = False

            If playerHands(0).Finished = True And playerHands(1).Finished = True Then
                Reset()
            End If
        End If
    End Sub

    Private Sub btnDouble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDouble.Click
        ' Double the wager, hit once more, and find the outcome
        wagerAmount += wagerAmount
        txtWager.Text = wagerAmount.ToString

        PlayerHit(playerHands(0), picboxControl1)
        If playerHands(0).Finished = False Then
            PlayerStay(playerHands(0))
            Reset()
        End If

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()

        frmBlackJack_Main.Show()
        frmBlackJack_Main.Focus()
    End Sub
End Class
