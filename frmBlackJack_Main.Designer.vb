<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlackJack_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlackJack_Main))
        Me.lblPlay_frmMain = New System.Windows.Forms.Label
        Me.lblViewStats_frmMain = New System.Windows.Forms.Label
        Me.lblQuit_frmMain = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblPlay_frmMain
        '
        Me.lblPlay_frmMain.BackColor = System.Drawing.Color.Transparent
        Me.lblPlay_frmMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPlay_frmMain.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlay_frmMain.Location = New System.Drawing.Point(129, 187)
        Me.lblPlay_frmMain.Name = "lblPlay_frmMain"
        Me.lblPlay_frmMain.Size = New System.Drawing.Size(81, 31)
        Me.lblPlay_frmMain.TabIndex = 3
        Me.lblPlay_frmMain.Text = "Play"
        Me.lblPlay_frmMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblViewStats_frmMain
        '
        Me.lblViewStats_frmMain.BackColor = System.Drawing.Color.Transparent
        Me.lblViewStats_frmMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblViewStats_frmMain.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewStats_frmMain.Location = New System.Drawing.Point(312, 148)
        Me.lblViewStats_frmMain.Name = "lblViewStats_frmMain"
        Me.lblViewStats_frmMain.Size = New System.Drawing.Size(193, 31)
        Me.lblViewStats_frmMain.TabIndex = 4
        Me.lblViewStats_frmMain.Text = "Statistics"
        Me.lblViewStats_frmMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQuit_frmMain
        '
        Me.lblQuit_frmMain.BackColor = System.Drawing.Color.Transparent
        Me.lblQuit_frmMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblQuit_frmMain.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuit_frmMain.Location = New System.Drawing.Point(582, 138)
        Me.lblQuit_frmMain.Name = "lblQuit_frmMain"
        Me.lblQuit_frmMain.Size = New System.Drawing.Size(81, 31)
        Me.lblQuit_frmMain.TabIndex = 5
        Me.lblQuit_frmMain.Text = "Quit"
        Me.lblQuit_frmMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBlackJack_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(790, 345)
        Me.Controls.Add(Me.lblQuit_frmMain)
        Me.Controls.Add(Me.lblViewStats_frmMain)
        Me.Controls.Add(Me.lblPlay_frmMain)
        Me.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "frmBlackJack_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome To Blackjack"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPlay_frmMain As System.Windows.Forms.Label
    Friend WithEvents lblViewStats_frmMain As System.Windows.Forms.Label
    Friend WithEvents lblQuit_frmMain As System.Windows.Forms.Label

End Class
