<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatistics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatistics))
        Me.grpBinomial = New System.Windows.Forms.GroupBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblAtMost = New System.Windows.Forms.Label
        Me.label01 = New System.Windows.Forms.Label
        Me.label02 = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.lblExactly = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtWin = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblMacroPlayer = New System.Windows.Forms.Label
        Me.lblMacroDealer = New System.Windows.Forms.Label
        Me.lstGeneralDealer = New System.Windows.Forms.ListBox
        Me.lstGeneralPlayer = New System.Windows.Forms.ListBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lstCardPlayer = New System.Windows.Forms.ListBox
        Me.lstCardDealer = New System.Windows.Forms.ListBox
        Me.lblMicroPlayer = New System.Windows.Forms.Label
        Me.lblMicroDealer = New System.Windows.Forms.Label
        Me.btnToMain = New System.Windows.Forms.Button
        Me.grpBinomial.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBinomial
        '
        Me.grpBinomial.BackColor = System.Drawing.Color.Transparent
        Me.grpBinomial.Controls.Add(Me.btnClear)
        Me.grpBinomial.Controls.Add(Me.Label3)
        Me.grpBinomial.Controls.Add(Me.Label1)
        Me.grpBinomial.Controls.Add(Me.lblAtMost)
        Me.grpBinomial.Controls.Add(Me.label01)
        Me.grpBinomial.Controls.Add(Me.label02)
        Me.grpBinomial.Controls.Add(Me.btnOk)
        Me.grpBinomial.Controls.Add(Me.lblExactly)
        Me.grpBinomial.Controls.Add(Me.Label4)
        Me.grpBinomial.Controls.Add(Me.Label2)
        Me.grpBinomial.Controls.Add(Me.txtTotal)
        Me.grpBinomial.Controls.Add(Me.txtWin)
        Me.grpBinomial.Enabled = False
        Me.grpBinomial.ForeColor = System.Drawing.Color.White
        Me.grpBinomial.Location = New System.Drawing.Point(419, 26)
        Me.grpBinomial.Name = "grpBinomial"
        Me.grpBinomial.Size = New System.Drawing.Size(446, 273)
        Me.grpBinomial.TabIndex = 0
        Me.grpBinomial.TabStop = False
        Me.grpBinomial.Text = "Binomial Probability Distribution"
        '
        'btnClear
        '
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(294, 129)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(398, 76)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 13
        '
        'lblAtMost
        '
        Me.lblAtMost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAtMost.Location = New System.Drawing.Point(230, 219)
        Me.lblAtMost.Name = "lblAtMost"
        Me.lblAtMost.Size = New System.Drawing.Size(163, 23)
        Me.lblAtMost.TabIndex = 12
        Me.lblAtMost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label01
        '
        Me.label01.Location = New System.Drawing.Point(29, 184)
        Me.label01.Name = "label01"
        Me.label01.Size = New System.Drawing.Size(201, 23)
        Me.label01.TabIndex = 11
        Me.label01.Text = "Probability of winning EXACTLY x of n"
        Me.label01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label02
        '
        Me.label02.Location = New System.Drawing.Point(29, 219)
        Me.label02.Name = "label02"
        Me.label02.Size = New System.Drawing.Size(198, 23)
        Me.label02.TabIndex = 10
        Me.label02.Text = "Probability of winning AT MOST x of n"
        Me.label02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOk
        '
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.Location = New System.Drawing.Point(204, 129)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblExactly
        '
        Me.lblExactly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblExactly.Location = New System.Drawing.Point(230, 184)
        Me.lblExactly.Name = "lblExactly"
        Me.lblExactly.Size = New System.Drawing.Size(163, 23)
        Me.lblExactly.TabIndex = 8
        Me.lblExactly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "How many more games were you planning on winning?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "out of"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(158, 131)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(30, 20)
        Me.txtTotal.TabIndex = 2
        '
        'txtWin
        '
        Me.txtWin.Location = New System.Drawing.Point(74, 131)
        Me.txtWin.Name = "txtWin"
        Me.txtWin.Size = New System.Drawing.Size(30, 20)
        Me.txtWin.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblMacroPlayer)
        Me.GroupBox2.Controls.Add(Me.lblMacroDealer)
        Me.GroupBox2.Controls.Add(Me.lstGeneralDealer)
        Me.GroupBox2.Controls.Add(Me.lstGeneralPlayer)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(22, 305)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(482, 139)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "General Data"
        '
        'lblMacroPlayer
        '
        Me.lblMacroPlayer.AutoSize = True
        Me.lblMacroPlayer.Location = New System.Drawing.Point(335, 17)
        Me.lblMacroPlayer.Name = "lblMacroPlayer"
        Me.lblMacroPlayer.Size = New System.Drawing.Size(36, 13)
        Me.lblMacroPlayer.TabIndex = 3
        Me.lblMacroPlayer.Text = "Player"
        '
        'lblMacroDealer
        '
        Me.lblMacroDealer.AutoSize = True
        Me.lblMacroDealer.Location = New System.Drawing.Point(99, 17)
        Me.lblMacroDealer.Name = "lblMacroDealer"
        Me.lblMacroDealer.Size = New System.Drawing.Size(38, 13)
        Me.lblMacroDealer.TabIndex = 2
        Me.lblMacroDealer.Text = "Dealer"
        '
        'lstGeneralDealer
        '
        Me.lstGeneralDealer.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGeneralDealer.FormattingEnabled = True
        Me.lstGeneralDealer.Location = New System.Drawing.Point(14, 44)
        Me.lstGeneralDealer.Name = "lstGeneralDealer"
        Me.lstGeneralDealer.Size = New System.Drawing.Size(223, 82)
        Me.lstGeneralDealer.TabIndex = 0
        '
        'lstGeneralPlayer
        '
        Me.lstGeneralPlayer.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGeneralPlayer.FormattingEnabled = True
        Me.lstGeneralPlayer.Location = New System.Drawing.Point(245, 44)
        Me.lstGeneralPlayer.Name = "lstGeneralPlayer"
        Me.lstGeneralPlayer.Size = New System.Drawing.Size(223, 82)
        Me.lstGeneralPlayer.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lstCardPlayer)
        Me.GroupBox3.Controls.Add(Me.lstCardDealer)
        Me.GroupBox3.Controls.Add(Me.lblMicroPlayer)
        Me.GroupBox3.Controls.Add(Me.lblMicroDealer)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(22, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(371, 277)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Card data"
        '
        'lstCardPlayer
        '
        Me.lstCardPlayer.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCardPlayer.FormattingEnabled = True
        Me.lstCardPlayer.Location = New System.Drawing.Point(190, 45)
        Me.lstCardPlayer.Name = "lstCardPlayer"
        Me.lstCardPlayer.Size = New System.Drawing.Size(130, 199)
        Me.lstCardPlayer.TabIndex = 4
        '
        'lstCardDealer
        '
        Me.lstCardDealer.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCardDealer.FormattingEnabled = True
        Me.lstCardDealer.Location = New System.Drawing.Point(44, 45)
        Me.lstCardDealer.Name = "lstCardDealer"
        Me.lstCardDealer.Size = New System.Drawing.Size(130, 199)
        Me.lstCardDealer.TabIndex = 5
        '
        'lblMicroPlayer
        '
        Me.lblMicroPlayer.AutoSize = True
        Me.lblMicroPlayer.Location = New System.Drawing.Point(231, 29)
        Me.lblMicroPlayer.Name = "lblMicroPlayer"
        Me.lblMicroPlayer.Size = New System.Drawing.Size(36, 13)
        Me.lblMicroPlayer.TabIndex = 4
        Me.lblMicroPlayer.Text = "Player"
        '
        'lblMicroDealer
        '
        Me.lblMicroDealer.AutoSize = True
        Me.lblMicroDealer.Location = New System.Drawing.Point(88, 28)
        Me.lblMicroDealer.Name = "lblMicroDealer"
        Me.lblMicroDealer.Size = New System.Drawing.Size(38, 13)
        Me.lblMicroDealer.TabIndex = 4
        Me.lblMicroDealer.Text = "Dealer"
        '
        'btnToMain
        '
        Me.btnToMain.Location = New System.Drawing.Point(759, 421)
        Me.btnToMain.Name = "btnToMain"
        Me.btnToMain.Size = New System.Drawing.Size(106, 23)
        Me.btnToMain.TabIndex = 4
        Me.btnToMain.Text = "Back To Main"
        Me.btnToMain.UseVisualStyleBackColor = True
        '
        'frmStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(883, 463)
        Me.Controls.Add(Me.btnToMain)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpBinomial)
        Me.Name = "frmStatistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistics"
        Me.grpBinomial.ResumeLayout(False)
        Me.grpBinomial.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBinomial As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtWin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblExactly As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMacroPlayer As System.Windows.Forms.Label
    Friend WithEvents lblMacroDealer As System.Windows.Forms.Label
    Friend WithEvents lstGeneralDealer As System.Windows.Forms.ListBox
    Friend WithEvents lstGeneralPlayer As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lstCardPlayer As System.Windows.Forms.ListBox
    Friend WithEvents lstCardDealer As System.Windows.Forms.ListBox
    Friend WithEvents lblMicroPlayer As System.Windows.Forms.Label
    Friend WithEvents lblMicroDealer As System.Windows.Forms.Label
    Friend WithEvents btnToMain As System.Windows.Forms.Button
    Friend WithEvents lblAtMost As System.Windows.Forms.Label
    Friend WithEvents label01 As System.Windows.Forms.Label
    Friend WithEvents label02 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
