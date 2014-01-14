<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Race_Form
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStripRace = New System.Windows.Forms.StatusStrip()
        Me.lblPlayer1Name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progPlayer1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblPlayer2Name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progPlayer2 = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblPlayer3Name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progPlayer3 = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblPlayer4Name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progPlayer4 = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStripRace = New System.Windows.Forms.MenuStrip()
        Me.cmdFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrRace = New System.Windows.Forms.Timer(Me.components)
        Me.gbRaceStats = New System.Windows.Forms.GroupBox()
        Me.picPlayer4 = New System.Windows.Forms.PictureBox()
        Me.picPlayer3 = New System.Windows.Forms.PictureBox()
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.picFinishLine = New System.Windows.Forms.PictureBox()
        Me.tmrHealth = New System.Windows.Forms.Timer(Me.components)
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStripRace.SuspendLayout()
        Me.MenuStripRace.SuspendLayout()
        CType(Me.picPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFinishLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStripRace
        '
        Me.StatusStripRace.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPlayer1Name, Me.progPlayer1, Me.lblPlayer2Name, Me.progPlayer2, Me.lblPlayer3Name, Me.progPlayer3, Me.lblPlayer4Name, Me.progPlayer4})
        Me.StatusStripRace.Location = New System.Drawing.Point(0, 505)
        Me.StatusStripRace.Name = "StatusStripRace"
        Me.StatusStripRace.Size = New System.Drawing.Size(1038, 22)
        Me.StatusStripRace.TabIndex = 0
        '
        'lblPlayer1Name
        '
        Me.lblPlayer1Name.Name = "lblPlayer1Name"
        Me.lblPlayer1Name.Size = New System.Drawing.Size(50, 17)
        Me.lblPlayer1Name.Text = "Player 1:"
        '
        'progPlayer1
        '
        Me.progPlayer1.Name = "progPlayer1"
        Me.progPlayer1.Size = New System.Drawing.Size(100, 16)
        '
        'lblPlayer2Name
        '
        Me.lblPlayer2Name.Name = "lblPlayer2Name"
        Me.lblPlayer2Name.Size = New System.Drawing.Size(50, 17)
        Me.lblPlayer2Name.Text = "Player 2:"
        '
        'progPlayer2
        '
        Me.progPlayer2.Name = "progPlayer2"
        Me.progPlayer2.Size = New System.Drawing.Size(100, 16)
        '
        'lblPlayer3Name
        '
        Me.lblPlayer3Name.Name = "lblPlayer3Name"
        Me.lblPlayer3Name.Size = New System.Drawing.Size(50, 17)
        Me.lblPlayer3Name.Text = "Player 3:"
        '
        'progPlayer3
        '
        Me.progPlayer3.Name = "progPlayer3"
        Me.progPlayer3.Size = New System.Drawing.Size(100, 16)
        '
        'lblPlayer4Name
        '
        Me.lblPlayer4Name.Name = "lblPlayer4Name"
        Me.lblPlayer4Name.Size = New System.Drawing.Size(50, 17)
        Me.lblPlayer4Name.Text = "Player 4:"
        '
        'progPlayer4
        '
        Me.progPlayer4.Name = "progPlayer4"
        Me.progPlayer4.Size = New System.Drawing.Size(100, 16)
        '
        'MenuStripRace
        '
        Me.MenuStripRace.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFile, Me.cmdReset, Me.cmdHelp, Me.DebugToolStripMenuItem})
        Me.MenuStripRace.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripRace.Name = "MenuStripRace"
        Me.MenuStripRace.Size = New System.Drawing.Size(1038, 24)
        Me.MenuStripRace.TabIndex = 1
        Me.MenuStripRace.Text = "MenuStripRace"
        '
        'cmdFile
        '
        Me.cmdFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdClose})
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(35, 20)
        Me.cmdFile.Text = "File"
        '
        'cmdClose
        '
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(111, 22)
        Me.cmdClose.Text = "Close"
        '
        'cmdReset
        '
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(77, 20)
        Me.cmdReset.Text = "Reset Game"
        '
        'cmdHelp
        '
        Me.cmdHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAbout})
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(40, 20)
        Me.cmdHelp.Text = "Help"
        '
        'cmdAbout
        '
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(114, 22)
        Me.cmdAbout.Text = "About"
        '
        'tmrRace
        '
        Me.tmrRace.Interval = 6
        '
        'gbRaceStats
        '
        Me.gbRaceStats.Location = New System.Drawing.Point(760, 399)
        Me.gbRaceStats.Name = "gbRaceStats"
        Me.gbRaceStats.Size = New System.Drawing.Size(266, 103)
        Me.gbRaceStats.TabIndex = 6
        Me.gbRaceStats.TabStop = False
        Me.gbRaceStats.Text = "Race Stats"
        '
        'picPlayer4
        '
        Me.picPlayer4.Image = Global.Sprint_Runner.My.Resources.Resources.runnerRunning
        Me.picPlayer4.Location = New System.Drawing.Point(12, 306)
        Me.picPlayer4.Name = "picPlayer4"
        Me.picPlayer4.Size = New System.Drawing.Size(68, 87)
        Me.picPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer4.TabIndex = 5
        Me.picPlayer4.TabStop = False
        '
        'picPlayer3
        '
        Me.picPlayer3.Image = Global.Sprint_Runner.My.Resources.Resources.runnerRunning
        Me.picPlayer3.Location = New System.Drawing.Point(12, 213)
        Me.picPlayer3.Name = "picPlayer3"
        Me.picPlayer3.Size = New System.Drawing.Size(68, 87)
        Me.picPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer3.TabIndex = 4
        Me.picPlayer3.TabStop = False
        '
        'picPlayer2
        '
        Me.picPlayer2.Image = Global.Sprint_Runner.My.Resources.Resources.runnerRunning
        Me.picPlayer2.Location = New System.Drawing.Point(12, 120)
        Me.picPlayer2.Name = "picPlayer2"
        Me.picPlayer2.Size = New System.Drawing.Size(68, 87)
        Me.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer2.TabIndex = 3
        Me.picPlayer2.TabStop = False
        '
        'picPlayer1
        '
        Me.picPlayer1.Image = Global.Sprint_Runner.My.Resources.Resources.runnerRunning
        Me.picPlayer1.Location = New System.Drawing.Point(12, 27)
        Me.picPlayer1.Name = "picPlayer1"
        Me.picPlayer1.Size = New System.Drawing.Size(68, 87)
        Me.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer1.TabIndex = 2
        Me.picPlayer1.TabStop = False
        '
        'picFinishLine
        '
        Me.picFinishLine.Image = Global.Sprint_Runner.My.Resources.Resources.finishLine
        Me.picFinishLine.Location = New System.Drawing.Point(958, 27)
        Me.picFinishLine.Name = "picFinishLine"
        Me.picFinishLine.Size = New System.Drawing.Size(68, 366)
        Me.picFinishLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFinishLine.TabIndex = 7
        Me.picFinishLine.TabStop = False
        '
        'tmrHealth
        '
        Me.tmrHealth.Interval = 5
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'Race_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1038, 527)
        Me.Controls.Add(Me.gbRaceStats)
        Me.Controls.Add(Me.picPlayer4)
        Me.Controls.Add(Me.picPlayer3)
        Me.Controls.Add(Me.picPlayer2)
        Me.Controls.Add(Me.picPlayer1)
        Me.Controls.Add(Me.StatusStripRace)
        Me.Controls.Add(Me.MenuStripRace)
        Me.Controls.Add(Me.picFinishLine)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStripRace
        Me.MaximizeBox = False
        Me.Name = "Race_Form"
        Me.Text = "Timer"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.StatusStripRace.ResumeLayout(False)
        Me.StatusStripRace.PerformLayout()
        Me.MenuStripRace.ResumeLayout(False)
        Me.MenuStripRace.PerformLayout()
        CType(Me.picPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFinishLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStripRace As System.Windows.Forms.StatusStrip
    Friend WithEvents lblPlayer1Name As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblPlayer2Name As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStripRace As System.Windows.Forms.MenuStrip
    Friend WithEvents cmdFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picPlayer1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer3 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer4 As System.Windows.Forms.PictureBox
    Friend WithEvents progPlayer1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents progPlayer2 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblPlayer3Name As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents progPlayer3 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblPlayer4Name As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents progPlayer4 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tmrRace As System.Windows.Forms.Timer
    Friend WithEvents cmdReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbRaceStats As System.Windows.Forms.GroupBox
    Friend WithEvents picFinishLine As System.Windows.Forms.PictureBox
    Friend WithEvents tmrHealth As System.Windows.Forms.Timer
    Friend WithEvents DebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
