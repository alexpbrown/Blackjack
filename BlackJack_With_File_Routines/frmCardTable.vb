'**********************************************************************************************
'THIS SUBFORM SIMULATES PLAYING A CARD GAME.
'THE GAME IS BLACKJACK.
'
'WE CREATE A STRUCTURE THAT IS MADE UP OF 3 DATATYPES:
'ONE STRING DATATYPE TO HOLD CARD NAME
'ONE STRING DATATYPE TO HOLD CARD SUIT
'ONE INTEGER DATATYPE TO HOLD CARD VALUES
'
'ONE DYNAMIC ARRAY USED TO SIMULATE A SHUFFLED DECK OF CARDS (CONTENTS WILL BE CHANGED)
'INTDECKTODEAL(), THE ORDER IN WHICH THE CARDS ARE DEALT.
'
'THE DECK IS RE-SHUFFLED AFTER EVERY HAND.
'
'COURSE: CSIT205 VBII, FALL 2010, SUNY FREDONIA
'INSTRUCTOR: MR. G.C. KRICHELDORF
'MODIFIED BY: DANIEL LIPS
'**********************************************************************************************

'This class defines the card table.
Public Class frmCardTable

    Private intWageAmount As Integer            'holds wage amount for bet
    Dim myDeck As Deck
    Dim dealerHand As Hand
    Dim playerHand As Hand

    Private Sub btnWager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWager.Click

        'This will try to convert the input in the wager textbox into an integer.
        'If won't be able to unless the user enters numbers.
        Try
            intWageAmount = CInt(txtWager.Text) 'conversion of text input to integer
            'accounts for wager that is higher than player or bank cash.
            If intWageAmount > frmBlackJack_Main.intPlayerCash Or intWageAmount > frmBlackJack_Main.intHouseBank Then
                MessageBox.Show("Wager is too high to bet with.", "Not Enough")
                WagerReset()
                Exit Sub
            ElseIf intWageAmount < 0 Then 'accounts for negative numbers
                MessageBox.Show("Please enter only positive numbers.", "Numbers Only")
                WagerReset()
                Exit Sub
            ElseIf intWageAmount = 0 Then 'accounts for 0
                MessageBox.Show("Gotta wager something!", "Come on!")
                WagerReset()
                Exit Sub
            ElseIf intWageAmount > 25 Then 'accounts for our max bet, 25.
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
            dealerHand.AddCard(myDeck.TakeCard)
            playerHand.AddCard(myDeck.TakeCard)
        Next

        rtbDealersHand.AppendText(dealerHand.Cards(0).ToString & vbCrLf)
        rtbDealersHand.AppendText(dealerHand.Cards(1).ToString & vbCrLf)

        rtbPlayersHand.AppendText(playerHand.Cards(0).ToString & vbCrLf)
        rtbPlayersHand.AppendText(playerHand.Cards(1).ToString & vbCrLf)

        RichTextBox1.AppendText(myDeck.DeckState)

        ' Calls score function and places it in score txt boxes
        txtPlayerScore.Text = Score(playerHand).ToString
        txtDealerScore.Text = Score(dealerHand).ToString

        btnDealHand.Visible = False

        'Console.WriteLine("Deck [{0}]", myDeck.DeckState)
        'Console.WriteLine("Hand [{0}]", dealerHand.Cards(0))
    End Sub

    'calculates the score of the hand
    Function Score(ByVal h As Hand) As Integer
        Dim aggScore As Integer = 0
        Dim cValue As Integer
        For i As Integer = 0 To h.Length - 1
            cValue = h.Cards(i).CardValue
            If cValue = 11 Then
                If Windows.Forms.DialogResult.Yes = MessageBox.Show("Count Ace as 11? Answering ""No"" will make it count as 1.", "Ace!", MessageBoxButtons.YesNo) Then
                    aggScore += 11
                Else
                    aggScore += 1
                End If
            Else
                aggScore += cValue
            End If
        Next

        Return aggScore
    End Function

    Sub WagerReset()
        txtWager.Text = String.Empty
        intWageAmount = 0
        txtWager.Focus()
    End Sub

End Class
