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

    Dim myDeck As Deck
    Dim dealerHand As Hand
    Dim playerHand As Hand




    '    ''structure to hold the deck of cards
    '    'Public Structure CardData
    '    '    Dim intCardValue As Integer 'holds value
    '    '    Dim strCardSuit As String 'holds suit
    '    '    Dim strCardName As String 'holds name, such as King
    '    'End Structure

    '    ''Declaring an array instance of my structure from this form.
    '    'Private cardsToPlay(51) As CardData

    '    ''Class Level Variables For All Methods To Use...
    '    Private intMasterIndex As Integer = 0       'will be the next index of the card to play
    '    Private intPlayerScore As Integer = 0       'will hold scores of the game players
    '    Private intDealerScore As Integer = 0
    '    Private strPlayer As String = "Player"      'will decide who is playing
    '    Private strDealer As String = "Dealer"
    '    Private intWageAmount As Integer            'holds wage amount for bet



    '    ''array in which randomization occurs
    '    'Private intDeckToDeal() As Integer = _
    '    '     {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, _
    '    '      14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, _
    '    '      26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, _
    '    '      39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51}

    '    'Button Purpose: deals the start of every hand, four cards
    '    '                it deals them: player, dealer, player, dealer
    '    '                it updates the next card to use array by index value
    '    'Returns To: this sub form, updating the game information
    '    'Private Sub btnDealHand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    '    'Handles btnDealHand.Click

    '    '    'local variables
    '    '    Dim intindex1 As Integer = 0                   'controls looping
    '    '    Dim strNextCardToPlay As String = String.Empty 'holds the next card to play

    '    '    'call to assign card values to my structure
    '    '    AssignCards(cardsToPlay)

    '    '    'show/hide buttons for program flow
    '    '    btnWager.Visible = False
    '    '    btnDealHand.Visible = False
    '    '    btnHitMe.Visible = True
    '    '    btnStay.Visible = True
    '    '    lblOr.Visible = True

    '    '    'shuffle the cards

    '    '    For index = 1 To 51
    '    '        Shuffle_The_Cards(intDeckToDeal)
    '    '    Next

    '    '    'display the cards in order of their play, the shuffled index values
    '    '    RichTextBox1.Text = ""
    '    '    intindex1 = 0
    '    '    For intindex1 = 0 To 51
    '    '        RichTextBox1.AppendText(intDeckToDeal(intindex1))
    '    '        RichTextBox1.AppendText(", ")
    '    '    Next
    '    '    MessageBox.Show("The Card Deck Is Ready For Play", "Good Luck,...not", MessageBoxButtons.OK)

    '    '    'hand out the first four cards to start the game
    '    '    'increment master card indexer of the game when a card is played
    '    '    'card one
    '    '    strNextCardToPlay = GetCard(cardsToPlay, intDeckToDeal, intMasterIndex)
    '    '    Update_A_Score(strPlayer)
    '    '    rtbPlayersHand.AppendText(strNextCardToPlay)
    '    '    'card two
    '    '    strNextCardToPlay = GetCard(cardsToPlay, intDeckToDeal, intMasterIndex)
    '    '    Update_A_Score(strDealer)
    '    '    rtbDealersHand.AppendText(strNextCardToPlay)
    '    '    'card three
    '    '    strNextCardToPlay = GetCard(cardsToPlay, intDeckToDeal, intMasterIndex)
    '    '    Update_A_Score(strPlayer)
    '    '    rtbPlayersHand.AppendText(strNextCardToPlay)
    '    '    'card four
    '    '    strNextCardToPlay = GetCard(cardsToPlay, intDeckToDeal, intMasterIndex)
    '    '    Update_A_Score(strDealer)
    '    '    rtbDealersHand.AppendText(strNextCardToPlay)

    '    '    'check for a special condition of somebody having a busted starting hand of 22 points,
    '    '    'getting two aces triggers an automatic restart
    '    '    If intPlayerScore > 21 Then
    '    '        MessageBox.Show("Why did you choose both aces to worth 11?", "Automatic bust!...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    '        DealerTakesMoney(True)
    '    '    End If
    '    '    If intDealerScore > 21 Then
    '    '        MessageBox.Show("Dealer Busted", "Lucky You!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    '        DealerTakesMoney(False)
    '    '    End If

    '    'End Sub

    '    'Button Purpose: quit the game
    '    'Returns To: the operating system
    '    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    '    Handles btnQuit.Click

    '        'reset all fields
    '        Reset_The_Game()
    '        WagerReset()

    '        ' This form can be closed, since we're keeping track of current player and bank cash in main form.
    '        Me.Close()

    '        'Show the main form
    '        frmBlackJack_Main.Show()
    '        frmBlackJack_Main.Focus()

    '    End Sub

    '    'The player must wager something before moving further in the game.
    '    Private Sub btnWager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    'Handles btnWager.Click

    '        'This will try to convert the input in the wager textbox into an integer.
    '        'If won't be able to unless the user enters numbers.
    '        Try
    '            intWageAmount = CInt(txtWager.Text) 'conversion of text input to integer
    '            'accounts for wager that is higher than player or bank cash.
    '            If intWageAmount > frmBlackJack_Main.intPlayerCash Or intWageAmount > frmBlackJack_Main.intHouseBank Then
    '                MessageBox.Show("Wager is too high to bet with.", "Not Enough")
    '                WagerReset()
    '                Exit Sub
    '            ElseIf intWageAmount < 0 Then 'accounts for negative numbers
    '                MessageBox.Show("Please enter only positive numbers.", "Numbers Only")
    '                WagerReset()
    '                Exit Sub
    '            ElseIf intWageAmount = 0 Then 'accounts for 0
    '                MessageBox.Show("Gotta wager something!", "Come on!")
    '                WagerReset()
    '                Exit Sub
    '            ElseIf intWageAmount > 25 Then 'accounts for our max bet, 25.
    '                MessageBox.Show("The maximum bet is 25.", "Too rich for our blood.")
    '                WagerReset()
    '                Exit Sub
    '            ElseIf txtWager.Text.Contains(".") Then
    '                MessageBox.Show("Please bet in whole amounts!", "Don't be using change.")
    '                WagerReset()
    '                Exit Sub
    '            End If
    '            ' Controls program flow.
    '            btnDealHand.Visible = True
    '            btnWager.Visible = False
    '            'makes sure the user cannot change the wager once input is ok
    '            txtWager.ReadOnly = True
    '        Catch 'handles both nonnumeric input and no input
    '            MessageBox.Show("Please enter numbers only.", "Just Numbers")
    '            WagerReset()
    '        End Try

    '    End Sub

    '    'Button Purpose: gives the player another card                
    '    'Returns To: this sub form
    '    Private Sub btnHitMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    '    Handles btnHitMe.Click

    '        'local variable to hold card name and suit
    '        Dim strtemp As String = String.Empty

    '        'strtemp = GetCard(cardsToPlay, intDeckToDeal, intMasterIndex)
    '        'appends card to player card area.
    '        rtbPlayersHand.Text += strtemp
    '        'remove the ability to shuffle the cards, the game has started
    '        btnDealHand.Visible = False
    '        Update_A_Score(strPlayer)
    '        'check player score, allow the ability to draw another if wanted by the player
    '        If intPlayerScore > 21 Then
    '            'player busted, game over
    '            MessageBox.Show("You Busted...", "You're a Loser!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            DealerTakesMoney(True)
    '        End If

    '    End Sub

    '    'Button Purpose: locks the players hand so dealer can play, and decides the hand winner
    '    'Returns To: this sub form
    '    Private Sub btnStay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    '    Handles btnStay.Click

    '        'local variable
    '        Dim strtemp As String = String.Empty  'will hold dealers next card when needed

    '        'The dealer MUST hit until his sum is 17 or higher.
    '        Do Until intDealerScore > 16
    '            strtemp = GetCard(cardsToPlay, intDeckToDeal, intMasterIndex)
    '            Update_A_Score(strDealer)
    '            rtbDealersHand.AppendText(strtemp)
    '        Loop

    '        'This next logic block makes the dealer hit while the 
    '        'sum is > 16 (from last loop) but less than the player sum.
    '        Do While intPlayerScore > intDealerScore
    '            strtemp = GetCard(cardsToPlay, intDeckToDeal, intMasterIndex)
    '            Update_A_Score(strDealer)
    '            rtbDealersHand.AppendText(strtemp)
    '        Loop

    '        Select Case intDealerScore
    '            Case Is > 21 'If case is 22 or higher, the player automatically wins.
    '                MessageBox.Show("YOU WON BROTHA! Dealer went over 21.", "YOU WIN!")
    '                DealerTakesMoney(False)
    '            Case Else ' Otherwise, the dealer won.
    '                MessageBox.Show("Sorry you lose! Dealer had a better hand.", "Better luck next time!")
    '                DealerTakesMoney(True)
    '        End Select

    '    End Sub

    '    '**********************************************************************************************
    '    ' MAINTAINENCE FUNCTIONS AND PROCEDURES FOR THE CARD TABLE
    '    '**********************************************************************************************

    '    'Function Purpose: generate a random number between 0 and 51
    '    'Return Value: an integer between zero and fiftyone, inclusive
    '    Private Function Get_A_Random_Value() As Integer
    '        'get a random number generator variable
    '        Dim rand As New Random
    '        Dim inttemp As Integer = -1

    '        'get a random number and return
    '        inttemp = rand.Next(0, 51)
    '        Return inttemp

    '    End Function

    '    'Function Purpose: to build a card value from multiple arrays
    '    'Return Value: a string representation of a card; ByRef, the next card in the deck
    '    Private Function GetCard(ByRef SomeDeckOfCards() As CardData, _
    '                             ByVal intnextcard() As Integer, ByRef intindex As Integer) As String
    '        'local variables
    '        Dim strCard As String = ""
    '        Dim inttempindex As Integer = -1

    '        'build a card
    '        inttempindex = intnextcard(intindex)
    '        strCard = String.Concat(cardsToPlay(inttempindex).strCardName, " Of ", cardsToPlay(inttempindex).strCardSuit, vbNewLine)
    '        'update to next card in the deck
    '        intindex += 1

    '        'exit
    '        Return strCard
    '    End Function

    '    'Purpose: resets all the game variables to a "start" state
    '    Private Sub Reset_The_Game()

    '        'clear all text boxes, reset buttons/labels for new hand
    '        rtbDealersHand.Text = ""
    '        rtbPlayersHand.Text = ""
    '        txtDealerScore.Text = ""
    '        txtPlayerScore.Text = ""
    '        RichTextBox1.Text = ""
    '        RichTextBox2.Text = ""
    '        btnDealHand.Visible = False
    '        btnHitMe.Visible = False
    '        btnStay.Visible = False
    '        btnWager.Visible = True
    '        lblOr.Visible = False

    '        'makes sure the user can input wager for next hand
    '        txtWager.ReadOnly = False

    '        'assign null values to all game calculations
    '        intDealerScore = 0
    '        intPlayerScore = 0
    '        intMasterIndex = 0

    '        'reset card deck to starting values
    '        For intindex1 = 0 To 51
    '            intDeckToDeal(intindex1) = intindex1
    '        Next

    '    End Sub

    '    'Purpose: update the score of someone who takes another card
    '    'Return: the card drawn and by who
    '    Private Sub Update_A_Score(ByVal strwho As String)

    '        Dim intpoints As Integer = 0 'added to contestents score
    '        Dim intWho As Integer 'Used to tell statistic structure what to use

    '        'determine the score
    '        If cardsToPlay(intDeckToDeal(intMasterIndex - 1)).intCardValue = 11 And strwho = "Player" Then
    '            If Windows.Forms.DialogResult.Yes = (MessageBox.Show("Would you like your ace to be worth 11?", "Question for ya..", MessageBoxButtons.YesNo)) Then
    '                intpoints = 11
    '            Else
    '                intpoints = 1
    '            End If
    '        Else
    '            'point value between 2 and 10
    '            intpoints = cardsToPlay(intDeckToDeal(intMasterIndex - 1)).intCardValue
    '        End If

    '        'determine which opponent's score to update
    '        'THE GLOBAL REFFERENCE CALL
    '        If strwho = "Player" Then
    '            intPlayerScore += intpoints
    '            txtPlayerScore.Text = intPlayerScore.ToString
    '            intWho = frmBlackJack_Main.PLAYER 'tells struct who to update
    '        End If
    '        If strwho = "Dealer" Then
    '            intDealerScore += intpoints
    '            txtDealerScore.Text = intDealerScore.ToString
    '            intWho = frmBlackJack_Main.DEALER 'tells struct who to update
    '        End If

    '        'Can't declare arrays within a struct, so I'm doing it here.
    '        ReDim Preserve frmBlackJack_Main.Statistics(intWho).intCard(13)

    '        'Updates the running count of whatever cards were dealt.
    '        Select Case cardsToPlay(intDeckToDeal(intMasterIndex - 1)).strCardName
    '            Case "2"
    '                frmBlackJack_Main.Statistics(intWho).intCard(0) += 1
    '            Case "3"
    '                frmBlackJack_Main.Statistics(intWho).intCard(1) += 1
    '            Case "4"
    '                frmBlackJack_Main.Statistics(intWho).intCard(2) += 1
    '            Case "5"
    '                frmBlackJack_Main.Statistics(intWho).intCard(3) += 1
    '            Case "6"
    '                frmBlackJack_Main.Statistics(intWho).intCard(4) += 1
    '            Case "7"
    '                frmBlackJack_Main.Statistics(intWho).intCard(5) += 1
    '            Case "8"
    '                frmBlackJack_Main.Statistics(intWho).intCard(6) += 1
    '            Case "9"
    '                frmBlackJack_Main.Statistics(intWho).intCard(7) += 1
    '            Case "10"
    '                frmBlackJack_Main.Statistics(intWho).intCard(8) += 1
    '            Case "Jack"
    '                frmBlackJack_Main.Statistics(intWho).intCard(9) += 1
    '            Case "Queen"
    '                frmBlackJack_Main.Statistics(intWho).intCard(10) += 1
    '            Case "King"
    '                frmBlackJack_Main.Statistics(intWho).intCard(11) += 1
    '            Case "Ace"
    '                frmBlackJack_Main.Statistics(intWho).intCard(12) += 1
    '        End Select

    '    End Sub

    '    'Procedure Purpose: to randomize an array of intergers 0 to 51
    '    'Return Value: "ByRef" the array with a new entries, intSomeArray()
    '    'Private Sub Shuffle_The_Cards(ByRef intSomeArray() As Integer)

    '    '    'local variables
    '    '    Dim intRandomArray(52) As Integer  'will store array index value to swap
    '    '    Dim intIndex1 As Integer = -1      'indexes to swap contents of
    '    '    Dim intSwapIndex As Integer = -1
    '    '    Dim intTempStorage As Integer = -1 'value to swap 

    '    '    'reset the text box for display
    '    '    RichTextBox2.Text = ""
    '    '    RichTextBox2.AppendText("Next Shuffle...")
    '    '    'get an array of random values
    '    '    For intIndex1 = 0 To 51
    '    '        intRandomArray(intIndex1) = Get_A_Random_Value()
    '    '        RichTextBox2.AppendText(intRandomArray(intIndex1).ToString)
    '    '        RichTextBox2.AppendText(", ")
    '    '    Next
    '    '    'use intRandomArray contents to index the swapping action in intSomeArray
    '    '    'this loop will only change the contents of the IntSomeArray
    '    '    'it uses IntRandomArray contents as the other array index to swap with
    '    '    For intIndex1 = 0 To 51
    '    '        'temp storage
    '    '        intTempStorage = intSomeArray(intIndex1)
    '    '        intSwapIndex = intRandomArray(intIndex1)
    '    '        intSomeArray(intIndex1) = intSomeArray(intSwapIndex)
    '    '        intSomeArray(intSwapIndex) = intTempStorage
    '    '    Next

    '    'End Sub

    '    'this procedure checks to see who won, and takes care of assignment of money
    '    Sub DealerTakesMoney(ByVal DealerWon As Boolean)

    '        'If the dealer won, he takes the wage amount, else he didn't and player does.
    '        If DealerWon = True Then
    '            frmBlackJack_Main.intPlayerCash -= intWageAmount
    '            frmBlackJack_Main.intHouseBank += intWageAmount
    '            frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intWon += 1 'updates statistic hand winnings
    '            frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intAggWinnings += intWageAmount 'updates aggregate winnings
    '        Else
    '            frmBlackJack_Main.intPlayerCash += intWageAmount
    '            frmBlackJack_Main.intHouseBank -= intWageAmount
    '            frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intWon += 1 'updates statistic hand winnings
    '            frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intAggWinnings += intWageAmount 'updates aggregate winnings statistic
    '        End If

    '        'assigns winnings
    '        txtBank.Text = CStr(frmBlackJack_Main.intHouseBank)
    '        txtWinnings.Text = CStr(frmBlackJack_Main.intPlayerCash)
    '        frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intTotalHands += 1 'updates total hand statistic
    '        frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intTotalHands += 1

    '        'Calls procedure to see if there's money left.
    '        NoMoreMoneys()

    '        'resets the game for next play
    '        Reset_The_Game()
    '        WagerReset()

    '    End Sub

    '    'procedure that resets the wage text.
    '    Sub WagerReset()
    '        txtWager.Text = String.Empty
    '        intWageAmount = 0
    '        txtWager.Focus()
    '    End Sub

    '    'this procedure assigns values to my structure
    '    'Sub AssignCards(ByRef assignmentCards() As CardData)

    '    '    'local variables
    '    '    Dim intAssignment = 2 'holds value
    '    '    Dim intTester = 0 'tester

    '    '    'the following 3 For loops assign values to my structure.

    '    '    'this loop assigns card values
    '    '    For index = 0 To 51
    '    '        If index > 31 And index < 48 Then
    '    '            assignmentCards(index).intCardValue = 10
    '    '        ElseIf index > 47 Then
    '    '            assignmentCards(index).intCardValue = 11
    '    '        Else
    '    '            intTester += 1
    '    '            If intTester = 1 Then
    '    '                assignmentCards(index).intCardValue = intAssignment
    '    '            ElseIf intTester = 2 Then
    '    '                assignmentCards(index).intCardValue = intAssignment
    '    '            ElseIf intTester = 3 Then
    '    '                assignmentCards(index).intCardValue = intAssignment
    '    '            Else
    '    '                intTester = 0
    '    '                assignmentCards(index).intCardValue = intAssignment
    '    '                intAssignment += 1
    '    '            End If
    '    '        End If
    '    '    Next

    '    '    'this loop gives the card a string name
    '    '    For index = 0 To 51
    '    '        Select Case index
    '    '            Case 0 To 3
    '    '                assignmentCards(index).strCardName = "2"
    '    '            Case 4 To 7
    '    '                assignmentCards(index).strCardName = "3"
    '    '            Case 8 To 11
    '    '                assignmentCards(index).strCardName = "4"
    '    '            Case 12 To 15
    '    '                assignmentCards(index).strCardName = "5"
    '    '            Case 16 To 19
    '    '                assignmentCards(index).strCardName = "6"
    '    '            Case 20 To 23
    '    '                assignmentCards(index).strCardName = "7"
    '    '            Case 24 To 27
    '    '                assignmentCards(index).strCardName = "8"
    '    '            Case 28 To 31
    '    '                assignmentCards(index).strCardName = "9"
    '    '            Case 32 To 35
    '    '                assignmentCards(index).strCardName = "10"
    '    '            Case 36 To 39
    '    '                assignmentCards(index).strCardName = "Jack"
    '    '            Case 40 To 43
    '    '                assignmentCards(index).strCardName = "Queen"
    '    '            Case 44 To 47
    '    '                assignmentCards(index).strCardName = "King"
    '    '            Case 48 To 51
    '    '                assignmentCards(index).strCardName = "Ace"
    '    '        End Select
    '    '    Next

    '    '    'this loop assigns a string suit
    '    '    For index = 0 To 51

    '    '        intTester += 1
    '    '        If intTester = 1 Then
    '    '            assignmentCards(index).strCardSuit = "Daimonds"
    '    '        ElseIf intTester = 2 Then
    '    '            assignmentCards(index).strCardSuit = "Clubs"
    '    '        ElseIf intTester = 3 Then
    '    '            assignmentCards(index).strCardSuit = "Spades"
    '    '        Else
    '    '            intTester = 0
    '    '            assignmentCards(index).strCardSuit = "Hearts"
    '    '        End If
    '    '    Next
    '    'End Sub

    '    'Upon loading the form, this event handler procedure plugs in the running player and dealer cash.
    '    Private Sub frmCardTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '        txtWinnings.Text = frmBlackJack_Main.intPlayerCash.ToString
    '        txtBank.Text = frmBlackJack_Main.intHouseBank.ToString

    '    End Sub

    '    'Checks to see if there is money left to play with, and rectifies it.
    '    Sub NoMoreMoneys()

    '        'If either the player or banker run out of cash, then they're given more.
    '        If frmBlackJack_Main.intPlayerCash <= 0 Then
    '            MessageBox.Show("You ran out of money!.. Here's more.", "No More Moneys")
    '            frmBlackJack_Main.intPlayerCash += 100
    '            txtWinnings.Text = frmBlackJack_Main.intPlayerCash.ToString
    '        End If

    '        If frmBlackJack_Main.intHouseBank <= 0 Then
    '            MessageBox.Show("You broke the bank!..Here's more for you to win.", "No More Moneys")
    '            frmBlackJack_Main.intHouseBank += 500
    '            txtBank.Text = frmBlackJack_Main.intHouseBank.ToString
    '        End If
    '    End Sub

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

        playerHand.Cards(0)


        'Console.WriteLine("Deck [{0}]", myDeck.DeckState)
        'Console.WriteLine("Hand [{0}]", dealerHand.Cards(0))
    End Sub
End Class
