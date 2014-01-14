<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Form
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
        Me.txtP1Name = New System.Windows.Forms.TextBox()
        Me.txtP2Name = New System.Windows.Forms.TextBox()
        Me.lblP1Name = New System.Windows.Forms.Label()
        Me.lblP2Name = New System.Windows.Forms.Label()
        Me.MenuHome = New System.Windows.Forms.MenuStrip()
        Me.cmdFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPlay = New System.Windows.Forms.Button()
        Me.cmbPlayerCount = New System.Windows.Forms.ComboBox()
        Me.lblPlayerCount = New System.Windows.Forms.Label()
        Me.MenuHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtP1Name
        '
        Me.txtP1Name.Enabled = False
        Me.txtP1Name.Location = New System.Drawing.Point(97, 116)
        Me.txtP1Name.Name = "txtP1Name"
        Me.txtP1Name.Size = New System.Drawing.Size(100, 20)
        Me.txtP1Name.TabIndex = 0
        '
        'txtP2Name
        '
        Me.txtP2Name.Enabled = False
        Me.txtP2Name.Location = New System.Drawing.Point(97, 142)
        Me.txtP2Name.Name = "txtP2Name"
        Me.txtP2Name.Size = New System.Drawing.Size(100, 20)
        Me.txtP2Name.TabIndex = 1
        '
        'lblP1Name
        '
        Me.lblP1Name.AutoSize = True
        Me.lblP1Name.Location = New System.Drawing.Point(12, 119)
        Me.lblP1Name.Name = "lblP1Name"
        Me.lblP1Name.Size = New System.Drawing.Size(79, 13)
        Me.lblP1Name.TabIndex = 2
        Me.lblP1Name.Text = "Player 1 Name:"
        '
        'lblP2Name
        '
        Me.lblP2Name.AutoSize = True
        Me.lblP2Name.Location = New System.Drawing.Point(12, 145)
        Me.lblP2Name.Name = "lblP2Name"
        Me.lblP2Name.Size = New System.Drawing.Size(79, 13)
        Me.lblP2Name.TabIndex = 3
        Me.lblP2Name.Text = "Player 2 Name:"
        '
        'MenuHome
        '
        Me.MenuHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFile, Me.cmdHelp})
        Me.MenuHome.Location = New System.Drawing.Point(0, 0)
        Me.MenuHome.Name = "MenuHome"
        Me.MenuHome.Size = New System.Drawing.Size(302, 24)
        Me.MenuHome.TabIndex = 4
        Me.MenuHome.Text = "MenuStrip1"
        '
        'cmdFile
        '
        Me.cmdFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClose})
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(37, 20)
        Me.cmdFile.Text = "File"
        '
        'cmdClose
        '
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(103, 22)
        Me.cmdClose.Text = "Close"
        '
        'cmdHelp
        '
        Me.cmdHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAbout})
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(44, 20)
        Me.cmdHelp.Text = "Help"
        '
        'cmdAbout
        '
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(107, 22)
        Me.cmdAbout.Text = "About"
        '
        'cmdPlay
        '
        Me.cmdPlay.Enabled = False
        Me.cmdPlay.Location = New System.Drawing.Point(215, 148)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(75, 23)
        Me.cmdPlay.TabIndex = 5
        Me.cmdPlay.Text = "Play"
        Me.cmdPlay.UseVisualStyleBackColor = True
        '
        'cmbPlayerCount
        '
        Me.cmbPlayerCount.FormattingEnabled = True
        Me.cmbPlayerCount.Items.AddRange(New Object() {"1 (Single)", "2 (Multiplayer)", "3 (CPU Only)"})
        Me.cmbPlayerCount.Location = New System.Drawing.Point(97, 72)
        Me.cmbPlayerCount.Name = "cmbPlayerCount"
        Me.cmbPlayerCount.Size = New System.Drawing.Size(100, 21)
        Me.cmbPlayerCount.TabIndex = 6
        '
        'lblPlayerCount
        '
        Me.lblPlayerCount.AutoSize = True
        Me.lblPlayerCount.Location = New System.Drawing.Point(21, 75)
        Me.lblPlayerCount.Name = "lblPlayerCount"
        Me.lblPlayerCount.Size = New System.Drawing.Size(70, 13)
        Me.lblPlayerCount.TabIndex = 7
        Me.lblPlayerCount.Text = "Player Count:"
        '
        'Home_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 183)
        Me.Controls.Add(Me.lblPlayerCount)
        Me.Controls.Add(Me.cmbPlayerCount)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.lblP2Name)
        Me.Controls.Add(Me.lblP1Name)
        Me.Controls.Add(Me.txtP2Name)
        Me.Controls.Add(Me.txtP1Name)
        Me.Controls.Add(Me.MenuHome)
        Me.MainMenuStrip = Me.MenuHome
        Me.Name = "Home_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Sprint Runner | Home"
        Me.MenuHome.ResumeLayout(False)
        Me.MenuHome.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtP1Name As System.Windows.Forms.TextBox
    Friend WithEvents txtP2Name As System.Windows.Forms.TextBox
    Friend WithEvents lblP1Name As System.Windows.Forms.Label
    Friend WithEvents lblP2Name As System.Windows.Forms.Label
    Friend WithEvents MenuHome As System.Windows.Forms.MenuStrip
    Friend WithEvents cmdFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPlay As System.Windows.Forms.Button
    Friend WithEvents cmbPlayerCount As System.Windows.Forms.ComboBox
    Friend WithEvents lblPlayerCount As System.Windows.Forms.Label
End Class
