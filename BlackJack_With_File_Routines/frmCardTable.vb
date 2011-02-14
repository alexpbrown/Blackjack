'**********************************************************************************************
' Rewritten by Alex Brown
'**********************************************************************************************

'This class defines the card table.
Public Class frmCardTable

    Dim player As New Player
    Dim dealer As New Player

    Private wagerAmount As Integer            'holds wager amount for bet
    Dim myDeck As Deck
    Dim dealerHand As Hand
    Dim playerHand As Hand

    Dim playerScore As Integer
    Dim dealerScore As Integer

    Private Sub btnWager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWager.Click

        'This will try to convert the input in the wager textbox into an integer.
        'If won't be able to unless the user enters numbers.
        Try
            wagerAmount = CInt(txtWager.Text) 'conversion of text input to integer
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

        playerHand = New Hand
        dealerHand = New Hand

        'deals two cards to both the player and the dealer
        For i = 0 To 1
            playerHand.AddCard(myDeck.TakeCard)
            dealerHand.AddCard(myDeck.TakeCard)

            rtbPlayersHand.AppendText(playerHand.Cards(i).ToString & vbCrLf)

        Next

        rtbDealersHand.AppendText(dealerHand.Cards(0).ToString & vbCrLf)

        RichTextBox1.AppendText(myDeck.DeckState)

        txtPlayerScore.Text = Score(playerHand).ToString
        txtDealerScore.Text = Score(dealerHand).ToString

        btnDealHand.Visible = False
        btnHitMe.Visible = True
        btnStay.Visible = True
        lblOr.Visible = True

        'Console.WriteLine("Deck [{0}]", myDeck.DeckState)
        'Console.WriteLine("Hand [{0}]", dealerHand.Cards(0))
    End Sub

    'calculates the score of the hand
    Function Score(ByVal h As Hand) As Integer
        Dim aggScore As Integer = 0
        Dim numAces As Integer = 0
        Dim cValue As Integer
        For i As Integer = 0 To h.Length - 1
            cValue = h.Cards(i).CardValue
            If cValue = 11 Then
                numAces += 1
            End If
            aggScore += cValue
        Next

        'while the score is over 21, subtract 10 for each ace present in the hand
        For i As Integer = numAces To 1 Step -1
            If aggScore > 21 Then
                aggScore -= 10
            End If
        Next

        Return aggScore
    End Function

    Sub WagerReset()
        txtWager.Text = String.Empty
        wagerAmount = 0
        txtWager.Focus()
    End Sub

    Private Sub btnHitMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitMe.Click
        playerHand.AddCard(myDeck.TakeCard)
        txtPlayerScore.Text = Score(playerHand).ToString
        rtbPlayersHand.AppendText(playerHand.Cards(playerHand.Length - 1).ToString & vbCrLf)
    End Sub
End Class
