'This class shows various data from the card table. 

Public Class frmStatistics

    'Class level variable for sub and functions to use for error checking.
    Private blnTester As Boolean

    'Calls function to extrapolate values and formats them into appropiate labels.
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        'A place holder for the function is needed in order to relieve
        'some overhead when I assign it to my 2 labels.
        Dim decPlaceHolder As Decimal

        'Try burrows way down and will go off if factorial is greater than 27 (see factorial
        'function). If it does go off, this procedure terminates. Also if blnTester if found to be false,
        'the procedure also terminates.
        Try
            decPlaceHolder = decBinDist()
            If blnTester = False Then
                ClearAll()
                Exit Sub
            End If
        Catch
            MessageBox.Show("Please enter 27 or lower in either box.", "Too many.")
            ClearAll()
            Exit Sub
        End Try

        'Assigns probabilities to labels.
        lblExactly.Text = (100 * decPlaceHolder).ToString & "%"
        lblAtMost.Text = (100 * (1 - decPlaceHolder)).ToString & "%"

    End Sub

    'Calls procedure to clear groupbox contents and sets the focus.
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearAll()
    End Sub

    'Goes back to main form.
    Private Sub btnToMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToMain.Click

        'Clears fields.
        ClearAll()

        'Form is not needed in background, so it is released from memory.
        Me.Close()

        'Shows the main form and sets the focus to it.
        frmBlackJack_Main.Show()
        frmBlackJack_Main.Focus()

    End Sub
    '**********************************************************************************************
    ' MAINTAINENCE FUNCTIONS AND PROCEDURES FOR STATISTICS
    '**********************************************************************************************

    'Event handler that loads the statistical data and binomial groupbox upon loading the form.
    Private Sub frmStatistics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Keeps track of total cards per player and dealer.
        'Dim intDealerSum As Integer
        'Dim intPlayerSum As Integer
        'The player would have 0 chance of winning if they have not won at least 1 hand.
        'Therefore, groupbox is disabled until condition is met.
        If frmBlackJack_Main.user.Won >= 1 Then
            grpBinomial.Enabled = True
        End If

        'Dealer general data.
        'NOTE: public variables from main form for cash amounts are not used to calculate
        'Up/Down since those variables may be "reset" on the card table when money runs out.
        lstGeneralDealer.Items.Add("Current Cash..................." & vbTab & frmBlackJack_Main.dealer.Cash.ToString)
        lstGeneralDealer.Items.Add("Up/Down........................" & vbTab & (frmBlackJack_Main.dealer.Winnings - frmBlackJack_Main.user.Winnings).ToString())
        lstGeneralDealer.Items.Add("Aggregate Cash Losses.........." & vbTab & frmBlackJack_Main.user.Winnings.ToString)
        lstGeneralDealer.Items.Add("Aggregate Cash Winnings........" & vbTab & frmBlackJack_Main.dealer.Winnings.ToString)
        lstGeneralDealer.Items.Add("Hands Won......................" & vbTab & frmBlackJack_Main.dealer.Won.ToString)
        lstGeneralDealer.Items.Add("Total Hands...................." & vbTab & frmBlackJack_Main.dealer.Played.ToString)

        'Player general data.
        lstGeneralPlayer.Items.Add("Current Cash..................." & vbTab & frmBlackJack_Main.user.Cash.ToString)
        lstGeneralPlayer.Items.Add("Up/Down........................" & vbTab & (frmBlackJack_Main.user.Winnings - frmBlackJack_Main.dealer.Winnings).ToString())
        lstGeneralPlayer.Items.Add("Aggregate Cash Losses.........." & vbTab & frmBlackJack_Main.dealer.Winnings.ToString)
        lstGeneralPlayer.Items.Add("Aggregate Cash Winnings........" & vbTab & frmBlackJack_Main.user.Winnings.ToString)
        lstGeneralPlayer.Items.Add("Hands Won......................" & vbTab & frmBlackJack_Main.user.Won.ToString)
        lstGeneralPlayer.Items.Add("Total Hands...................." & vbTab & frmBlackJack_Main.user.Played.ToString)

        ''Adds up total amount of cards per player or dealer.
        'For index = 0 To 12
        '    intDealerSum += frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(index)
        '    intPlayerSum += frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(index)
        'Next

        ''Dealer card data.
        'lstCardDealer.Items.Add("2.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(0).ToString)
        'lstCardDealer.Items.Add("3.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(1).ToString)
        'lstCardDealer.Items.Add("4.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(2).ToString)
        'lstCardDealer.Items.Add("5.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(3).ToString)
        'lstCardDealer.Items.Add("6.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(4).ToString)
        'lstCardDealer.Items.Add("7.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(5).ToString)
        'lstCardDealer.Items.Add("8.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(6).ToString)
        'lstCardDealer.Items.Add("9.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(7).ToString)
        'lstCardDealer.Items.Add("10............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(8).ToString)
        'lstCardDealer.Items.Add("Jack..........." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(9).ToString)
        'lstCardDealer.Items.Add("Queen.........." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(10).ToString)
        'lstCardDealer.Items.Add("King..........." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(11).ToString)
        'lstCardDealer.Items.Add("Ace............" & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.DEALER).intCard(12).ToString)
        'lstCardDealer.Items.Add(vbNewLine)
        'lstCardDealer.Items.Add("Total.........." & vbTab & intDealerSum)

        ''Player card data
        'lstCardPlayer.Items.Add("2.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(0).ToString)
        'lstCardPlayer.Items.Add("3.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(1).ToString)
        'lstCardPlayer.Items.Add("4.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(2).ToString)
        'lstCardPlayer.Items.Add("5.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(3).ToString)
        'lstCardPlayer.Items.Add("6.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(4).ToString)
        'lstCardPlayer.Items.Add("7.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(5).ToString)
        'lstCardPlayer.Items.Add("8.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(6).ToString)
        'lstCardPlayer.Items.Add("9.............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(7).ToString)
        'lstCardPlayer.Items.Add("10............." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(8).ToString)
        'lstCardPlayer.Items.Add("Jack..........." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(9).ToString)
        'lstCardPlayer.Items.Add("Queen.........." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(10).ToString)
        'lstCardPlayer.Items.Add("King..........." & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(11).ToString)
        'lstCardPlayer.Items.Add("Ace............" & vbTab & frmBlackJack_Main.Statistics(frmBlackJack_Main.PLAYER).intCard(12).ToString)
        'lstCardPlayer.Items.Add(vbNewLine)
        'lstCardPlayer.Items.Add("Total.........." & vbTab & intPlayerSum)

    End Sub

    'Factorial function - uses decimal datatype to encompass the largest possible data type
    'in visual basic. Limit is the factorial of 27. This limitation could be taken care of if
    'I were to develop the algorithm to cancel out numbers from the function that calls
    'this function.
    Function decFactorial(ByVal n As Integer) As Decimal

        decFactorial = 1

        For a = 1 To n
            decFactorial = decFactorial * a
        Next
        Return decFactorial

    End Function

    'This function encompasses the algorithm for Binomial Probability Distribution. It returns the probability
    'of x successes in n trials based on previous x successes in n trials.
    Function decBinDist() As Decimal

        'Number of wanted trials
        Dim n As Integer
        'Number of wanted successes
        Dim x As Integer

        'Variable to hold probability success so far
        Dim P As Decimal = CDec(frmBlackJack_Main.user.Won / frmBlackJack_Main.user.Played)
        'Variable to hold probability failure so far
        Dim Q As Decimal = 1 - P



        'Validates input is correct.
        blnTester = ValidateInput(txtWin.Text.ToString, x)
        'If not, exits this function.
        If blnTester = False Then
            Exit Function
        End If
        blnTester = ValidateInput(txtTotal.Text.ToString, n)
        If blnTester = False Then
            Exit Function
        End If

        'Binomial Probability Distribution Algorithm. Calls factorial function.
        decBinDist = CDec(decFactorial(n) / (decFactorial(x) * decFactorial(n - x)) * (P ^ x) * (Q ^ (n - x)))

        Return decBinDist
    End Function

    'Validates proper input. Only returns true on valid flow.
    Function ValidateInput(ByVal input As String, ByRef variable As Integer) As Boolean
        Try
            variable = CInt(input)
            If input.Contains(".") Then
                MessageBox.Show("Please enter integers only.", "No Decimals")
                Return False
            ElseIf variable < 1 Then
                MessageBox.Show("Input cannot be less than 1.", "Positive Numbers Only")
                Return False
            End If
        Catch
            MessageBox.Show("Please enter numbers only.", "Numbers Only")
            Return False
            Exit Function
        End Try
        Return True
    End Function
    'Clears the groupbox textboxes and labels and sets the focus.
    Sub ClearAll()
        txtTotal.Text = String.Empty
        txtWin.Text = String.Empty
        lblAtMost.Text = String.Empty
        lblExactly.Text = String.Empty
        txtWin.Focus()
    End Sub
End Class
