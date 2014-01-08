Public Class Home_Form

    Dim player1Name As String
    Dim player2Name As String

    Private Sub Home_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtP1Name.Text = ""
        txtP2Name.Text = ""

        My.MySettings.Default.Player1Name = ""
        My.MySettings.Default.Player2Name = ""

        My.MySettings.Default.Save()

    End Sub

    Private Sub cmdPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlay.Click

        If (txtP1Name.Text = "") Then

            MsgBox("Please Input A Name For Player 1!")

        ElseIf (txtP2Name.Text = "") Then

            MsgBox("Please Input A Name For Player 2!")

        Else

            Call addNames()

        End If

    End Sub

    Private Sub addNames()

        Dim sucess As Boolean = False

        Try

            player1Name = txtP1Name.Text
            player2Name = txtP2Name.Text

            My.MySettings.Default.Player1Name = player1Name
            My.MySettings.Default.Player2Name = player2Name

            My.MySettings.Default.Save()

            sucess = True

        Catch ex As Exception



        End Try

        If (sucess = True) Then

            Race_Form.Show()
            Me.Hide()

        End If
        
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click

        Application.Exit()

    End Sub

End Class