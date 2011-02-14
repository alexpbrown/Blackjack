
'This class controls the flow of the program- they can either play, go to statistics, or exit program.
Public Class frmBlackJack_Main
    Public user As New Player
    Public dealer As New Player


    'Go to the card table.
    Private Sub lblPlay_frmMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPlay_frmMain.Click
        user.Cash = 100
        dealer.Cash = 500
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
