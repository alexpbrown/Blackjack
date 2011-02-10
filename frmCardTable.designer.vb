<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCardTable))
        Me.btnDealHand = New System.Windows.Forms.Button
        Me.btnQuit = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.rtbPlayersHand = New System.Windows.Forms.RichTextBox
        Me.btnHitMe = New System.Windows.Forms.Button
        Me.btnStay = New System.Windows.Forms.Button
        Me.lblOr = New System.Windows.Forms.Label
        Me.rtbDealersHand = New System.Windows.Forms.RichTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPlayerScore = New System.Windows.Forms.TextBox
        Me.txtDealerScore = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtWinnings = New System.Windows.Forms.TextBox
        Me.txtBank = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtWager = New System.Windows.Forms.TextBox
        Me.btnWager = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDealHand
        '
        Me.btnDealHand.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDealHand.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDealHand.ForeColor = System.Drawing.Color.Black
        Me.btnDealHand.Location = New System.Drawing.Point(15, 52)
        Me.btnDealHand.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDealHand.Name = "btnDealHand"
        Me.btnDealHand.Size = New System.Drawing.Size(222, 26)
        Me.btnDealHand.TabIndex = 1
        Me.btnDealHand.Text = "DEAL"
        Me.btnDealHand.UseVisualStyleBackColor = False
        Me.btnDealHand.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.RosyBrown
        Me.btnQuit.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(900, 545)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(68, 27)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "QUIT"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Viner Hand ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(263, 156)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Player Hand"
        '
        'rtbPlayersHand
        '
        Me.rtbPlayersHand.Location = New System.Drawing.Point(237, 22)
        Me.rtbPlayersHand.Margin = New System.Windows.Forms.Padding(2)
        Me.rtbPlayersHand.Name = "rtbPlayersHand"
        Me.rtbPlayersHand.ReadOnly = True
        Me.rtbPlayersHand.Size = New System.Drawing.Size(183, 125)
        Me.rtbPlayersHand.TabIndex = 5
        Me.rtbPlayersHand.Text = ""
        '
        'btnHitMe
        '
        Me.btnHitMe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnHitMe.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitMe.ForeColor = System.Drawing.Color.Black
        Me.btnHitMe.Location = New System.Drawing.Point(277, 32)
        Me.btnHitMe.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHitMe.Name = "btnHitMe"
        Me.btnHitMe.Size = New System.Drawing.Size(83, 26)
        Me.btnHitMe.TabIndex = 6
        Me.btnHitMe.Text = "HIT ME"
        Me.btnHitMe.UseVisualStyleBackColor = False
        Me.btnHitMe.Visible = False
        '
        'btnStay
        '
        Me.btnStay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStay.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStay.ForeColor = System.Drawing.Color.Black
        Me.btnStay.Location = New System.Drawing.Point(408, 32)
        Me.btnStay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStay.Name = "btnStay"
        Me.btnStay.Size = New System.Drawing.Size(83, 26)
        Me.btnStay.TabIndex = 7
        Me.btnStay.Text = "STAY"
        Me.btnStay.UseVisualStyleBackColor = False
        Me.btnStay.Visible = False
        '
        'lblOr
        '
        Me.lblOr.AutoSize = True
        Me.lblOr.BackColor = System.Drawing.Color.Transparent
        Me.lblOr.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOr.ForeColor = System.Drawing.Color.Transparent
        Me.lblOr.Location = New System.Drawing.Point(372, 37)
        Me.lblOr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(27, 15)
        Me.lblOr.TabIndex = 8
        Me.lblOr.Text = "Or"
        Me.lblOr.Visible = False
        '
        'rtbDealersHand
        '
        Me.rtbDealersHand.Location = New System.Drawing.Point(24, 22)
        Me.rtbDealersHand.Margin = New System.Windows.Forms.Padding(2)
        Me.rtbDealersHand.Name = "rtbDealersHand"
        Me.rtbDealersHand.ReadOnly = True
        Me.rtbDealersHand.Size = New System.Drawing.Size(183, 125)
        Me.rtbDealersHand.TabIndex = 9
        Me.rtbDealersHand.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Viner Hand ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 31)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dealer Hand"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(24, 517)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(155, 62)
        Me.RichTextBox1.TabIndex = 11
        Me.RichTextBox1.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 489)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Current Card Index:"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(198, 517)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(155, 62)
        Me.RichTextBox2.TabIndex = 13
        Me.RichTextBox2.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(187, 489)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Array Indexes To Swap:"
        '
        'txtPlayerScore
        '
        Me.txtPlayerScore.Location = New System.Drawing.Point(41, 43)
        Me.txtPlayerScore.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlayerScore.Name = "txtPlayerScore"
        Me.txtPlayerScore.ReadOnly = True
        Me.txtPlayerScore.Size = New System.Drawing.Size(100, 22)
        Me.txtPlayerScore.TabIndex = 15
        Me.txtPlayerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDealerScore
        '
        Me.txtDealerScore.Location = New System.Drawing.Point(156, 43)
        Me.txtDealerScore.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDealerScore.Name = "txtDealerScore"
        Me.txtDealerScore.ReadOnly = True
        Me.txtDealerScore.Size = New System.Drawing.Size(100, 22)
        Me.txtDealerScore.TabIndex = 16
        Me.txtDealerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Perpetua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(41, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "PLAYER SCORE"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(271, 24)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "WINNINGS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWinnings
        '
        Me.txtWinnings.Location = New System.Drawing.Point(271, 43)
        Me.txtWinnings.Name = "txtWinnings"
        Me.txtWinnings.ReadOnly = True
        Me.txtWinnings.Size = New System.Drawing.Size(100, 22)
        Me.txtWinnings.TabIndex = 19
        Me.txtWinnings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBank
        '
        Me.txtBank.Location = New System.Drawing.Point(386, 43)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.ReadOnly = True
        Me.txtBank.Size = New System.Drawing.Size(100, 22)
        Me.txtBank.TabIndex = 20
        Me.txtBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Perpetua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(156, 24)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "DEALER SCORE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(386, 24)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "BANK"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(14, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 15)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Wager"
        '
        'txtWager
        '
        Me.txtWager.Location = New System.Drawing.Point(77, 21)
        Me.txtWager.Name = "txtWager"
        Me.txtWager.Size = New System.Drawing.Size(77, 22)
        Me.txtWager.TabIndex = 0
        '
        'btnWager
        '
        Me.btnWager.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnWager.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWager.ForeColor = System.Drawing.Color.Black
        Me.btnWager.Location = New System.Drawing.Point(173, 18)
        Me.btnWager.Name = "btnWager"
        Me.btnWager.Size = New System.Drawing.Size(52, 26)
        Me.btnWager.TabIndex = 25
        Me.btnWager.Text = "OK"
        Me.btnWager.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtWinnings)
        Me.GroupBox1.Controls.Add(Me.txtDealerScore)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtBank)
        Me.GroupBox1.Controls.Add(Me.txtPlayerScore)
        Me.GroupBox1.Font = New System.Drawing.Font("Perpetua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(445, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 80)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Scores and Winnings"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.btnDealHand)
        Me.GroupBox2.Controls.Add(Me.btnWager)
        Me.GroupBox2.Controls.Add(Me.btnHitMe)
        Me.GroupBox2.Controls.Add(Me.txtWager)
        Me.GroupBox2.Controls.Add(Me.btnStay)
        Me.GroupBox2.Controls.Add(Me.lblOr)
        Me.GroupBox2.Font = New System.Drawing.Font("Perpetua", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(445, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(529, 89)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Game Controls"
        '
        'frmCardTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(990, 590)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rtbDealersHand)
        Me.Controls.Add(Me.rtbPlayersHand)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnQuit)
        Me.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "frmCardTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Card Table"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDealHand As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rtbPlayersHand As System.Windows.Forms.RichTextBox
    Friend WithEvents btnHitMe As System.Windows.Forms.Button
    Friend WithEvents btnStay As System.Windows.Forms.Button
    Friend WithEvents lblOr As System.Windows.Forms.Label
    Friend WithEvents rtbDealersHand As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPlayerScore As System.Windows.Forms.TextBox
    Friend WithEvents txtDealerScore As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtWinnings As System.Windows.Forms.TextBox
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtWager As System.Windows.Forms.TextBox
    Friend WithEvents btnWager As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
