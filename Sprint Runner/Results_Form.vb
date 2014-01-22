Public Class Results_Form

    Private Sub Results_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Results_Form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        MsgBox("Thank You For Playing! | The Application Will Close When You Press 'OK'", MessageBoxButtons.OK)
        Application.Exit()

    End Sub

End Class