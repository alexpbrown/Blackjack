
'This class controls the flow of the program- they can either play, go to statistics, or exit program.
Public Class frmBlackJack_Main

    'These are declared in main form so main can pass them to both subforms as needed.
    Public intPlayerCash As Integer = 100      'declares and makes sure beginning cash for player is 100
    Public intHouseBank As Integer = 500       'declares and makes sure beginning cash for dealer is 500

    'Structure for statistics
    Public Structure Stats
        Dim intWon As Integer 'number of times player won
        Dim intTotalHands As Integer 'total number of hands
        Dim intAggWinnings As Integer 'holds total amount won
        Dim intCard() As Integer 'holds the number of times the a card name comes up
    End Structure

    'Instance of my statistical structure
    Public Statistics(1) As Stats

    'The following constants act as metadata for reference of structure index
    Public Const DEALER As Integer = 0
    Public Const PLAYER As Integer = 1

    'Go to the card table.
    Private Sub lblPlay_frmMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPlay_frmMain.Click

        'set main program into background
        Me.Visible = False

        'show the table
        frmCardTable.Show()
        frmCardTable.Focus()

    End Sub

    'Go to the statistics form.
    Private Sub lblViewStats_frmMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblViewStats_frmMain.Click

        'set main program into background
        Me.Hide()

        'show the statistics form
        frmStatistics.Show()
        frmStatistics.Focus()

    End Sub

    'Quit the application.
    Private Sub lblQuit_frmMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblQuit_frmMain.Click

        'exit the program
        Me.Close()

    End Sub

    'event handler procedure to make label "grow"
    Private Sub lblPlay_frmMain_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblPlay_frmMain.MouseMove

        'When mouse hovers over this control, font size increases and is underlined.
        lblPlay_frmMain.Font = New Font(lblPlay_frmMain.Font.FontFamily, 16, FontStyle.Underline)

    End Sub

    'event handler procedure to make label go back to it's initial format state.
    Private Sub lblPlay_frmMain_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPlay_frmMain.MouseLeave

        'When mouse hovers away from this control, original font size and style are restored.
        lblPlay_frmMain.Font = New Font(lblPlay_frmMain.Font.FontFamily, 14, FontStyle.Regular)

    End Sub

    'event handler procedure to make label "grow"
    Private Sub lblViewStats_frmMain_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblViewStats_frmMain.MouseMove

        'When mouse hovers over this control, font size increases and is underlined.
        lblViewStats_frmMain.Font = New Font(lblViewStats_frmMain.Font.FontFamily, 16, FontStyle.Underline)

    End Sub

    'event handler procedure to make label go back to it's initial format state.
    Private Sub lblViewStats_frmMain_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblViewStats_frmMain.MouseLeave

        'When mouse hovers away from this control, original font size and style are restored.
        lblViewStats_frmMain.Font = New Font(lblViewStats_frmMain.Font.FontFamily, 14, FontStyle.Regular)

    End Sub

    'event handler procedure to make label "grow"
    Private Sub lblQuit_frmMain_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblQuit_frmMain.MouseMove

        'When mouse hovers over this control, font size increases and is underlined.
        lblQuit_frmMain.Font = New Font(lblQuit_frmMain.Font.FontFamily, 16, FontStyle.Underline)

    End Sub

    'event handler procedure to make label go back to it's initial format state.
    Private Sub lblQuit_frmMain_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblQuit_frmMain.MouseLeave

        'When mouse hovers away from this control, original font size and style are restored.
        lblQuit_frmMain.Font = New Font(lblQuit_frmMain.Font.FontFamily, 14, FontStyle.Regular)

    End Sub
End Class
