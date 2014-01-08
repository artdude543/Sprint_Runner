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
        Me.cmdHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer3 = New System.Windows.Forms.PictureBox()
        Me.picPlayer4 = New System.Windows.Forms.PictureBox()
        Me.tmrRace = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStripRace.SuspendLayout()
        Me.MenuStripRace.SuspendLayout()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStripRace
        '
        Me.StatusStripRace.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPlayer1Name, Me.progPlayer1, Me.lblPlayer2Name, Me.progPlayer2, Me.lblPlayer3Name, Me.progPlayer3, Me.lblPlayer4Name, Me.progPlayer4})
        Me.StatusStripRace.Location = New System.Drawing.Point(0, 464)
        Me.StatusStripRace.Name = "StatusStripRace"
        Me.StatusStripRace.Size = New System.Drawing.Size(857, 22)
        Me.StatusStripRace.TabIndex = 0
        '
        'lblPlayer1Name
        '
        Me.lblPlayer1Name.Name = "lblPlayer1Name"
        Me.lblPlayer1Name.Size = New System.Drawing.Size(51, 17)
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
        Me.lblPlayer2Name.Size = New System.Drawing.Size(51, 17)
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
        Me.lblPlayer3Name.Size = New System.Drawing.Size(51, 17)
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
        Me.lblPlayer4Name.Size = New System.Drawing.Size(51, 17)
        Me.lblPlayer4Name.Text = "Player 4:"
        '
        'progPlayer4
        '
        Me.progPlayer4.Name = "progPlayer4"
        Me.progPlayer4.Size = New System.Drawing.Size(100, 16)
        '
        'MenuStripRace
        '
        Me.MenuStripRace.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdFile, Me.cmdHelp})
        Me.MenuStripRace.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripRace.Name = "MenuStripRace"
        Me.MenuStripRace.Size = New System.Drawing.Size(857, 24)
        Me.MenuStripRace.TabIndex = 1
        Me.MenuStripRace.Text = "MenuStripRace"
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
        'tmrRace
        '
        Me.tmrRace.Interval = 1000
        '
        'Race_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 486)
        Me.Controls.Add(Me.picPlayer4)
        Me.Controls.Add(Me.picPlayer3)
        Me.Controls.Add(Me.picPlayer2)
        Me.Controls.Add(Me.picPlayer1)
        Me.Controls.Add(Me.StatusStripRace)
        Me.Controls.Add(Me.MenuStripRace)
        Me.MainMenuStrip = Me.MenuStripRace
        Me.Name = "Race_Form"
        Me.Text = " Sprint Runner | The Race"
        Me.StatusStripRace.ResumeLayout(False)
        Me.StatusStripRace.PerformLayout()
        Me.MenuStripRace.ResumeLayout(False)
        Me.MenuStripRace.PerformLayout()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
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

End Class
