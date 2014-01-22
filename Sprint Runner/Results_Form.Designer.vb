<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Results_Form
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
        Me.lstPlayersFinished = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstPlayersFinished
        '
        Me.lstPlayersFinished.FormattingEnabled = True
        Me.lstPlayersFinished.Location = New System.Drawing.Point(12, 12)
        Me.lstPlayersFinished.Name = "lstPlayersFinished"
        Me.lstPlayersFinished.Size = New System.Drawing.Size(225, 108)
        Me.lstPlayersFinished.TabIndex = 0
        '
        'Results_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 133)
        Me.Controls.Add(Me.lstPlayersFinished)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Results_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sprint Runner | Results"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents lstPlayersFinished As System.Windows.Forms.ListBox
End Class
