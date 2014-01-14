Public Class Home_Form

    Dim player1Name As String
    Dim player2Name As String

    Dim totalPlayers As Integer = 0
    Dim CPUMode As Boolean = False

    Private Sub Home_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtP1Name.Text = ""
        txtP2Name.Text = ""

        My.MySettings.Default.Player1Name = ""
        My.MySettings.Default.Player2Name = ""
        My.MySettings.Default.TotalPlayers = 0

        My.MySettings.Default.Save()

    End Sub

    Private Sub cmdPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlay.Click

        If (totalPlayers = 1) Then

            If (txtP1Name.Text = "") Then

                MsgBox("Please Input A Name For Player 1!")

            Else

                addNames() ' Add Names + Start Game

            End If

        ElseIf (totalPlayers = 2) Then

            If (txtP1Name.Text = "") Then

                MsgBox("Please Input A Name For Player 1!")

            ElseIf (txtP2Name.Text = "") Then

                MsgBox("Please Input A Name For Player 2!")

            Else

                If (txtP1Name.Text.Contains(txtP2Name.Text)) Then

                    MsgBox("Please enter unique names!")

                ElseIf (txtP2Name.Text.Contains(txtP1Name.Text)) Then

                    MsgBox("Please enter unique names!")

                Else

                    addNames() ' Add Names + Start Game

                End If

            End If

        ElseIf (CPUMode = True) Then

            MsgBox("CPU Mode Not Added Yet!")

        End If

    End Sub

    Private Sub addNames()

        Dim success As Boolean = False

        If (totalPlayers = 1) Then

            Try

                My.MySettings.Default.Player1Name = txtP1Name.Text
                My.MySettings.Default.TotalPlayers = 1
                My.MySettings.Default.Save()

                txtP1Name.Text = ""
                success = True

            Catch ex As Exception

                MsgBox("An Error Has Occured: " + ex.StackTrace.ToString())

            End Try

            If (success = True) Then

                Race_Form.Show()
                Me.Hide()

            End If

        ElseIf (totalPlayers = 2) Then

            Try

                My.MySettings.Default.Player1Name = txtP1Name.Text
                My.MySettings.Default.Player2Name = txtP2Name.Text
                My.MySettings.Default.TotalPlayers = 2
                My.MySettings.Default.Save()

                txtP2Name.Text = ""
                txtP2Name.Text = ""
                success = True

            Catch ex As Exception

                MsgBox("An Error Has Occured: " + ex.StackTrace.ToString())

            End Try

            If (success = True) Then

                Race_Form.Show()
                Me.Hide()

            End If

        ElseIf (CPUMode = True) Then

        End If

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click

        Application.Exit() ' Closes The Application

    End Sub

    Private Sub cmbPlayerCount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlayerCount.SelectedIndexChanged

        txtP1Name.Enabled = False
        txtP2Name.Enabled = False
        cmdPlay.Enabled = False

        If (cmbPlayerCount.Text.Contains("1")) Then

            txtP1Name.Enabled = True
            cmdPlay.Enabled = True
            totalPlayers = 1

        ElseIf (cmbPlayerCount.Text.Contains("2")) Then

            txtP1Name.Enabled = True
            txtP2Name.Enabled = True
            cmdPlay.Enabled = True
            totalPlayers = 2

        ElseIf (cmbPlayerCount.Text.Contains("CPU")) Then

            CPUMode = True
            cmdPlay.Enabled = True
            totalPlayers = 0

        End If

    End Sub

End Class