﻿Public Class Race_Form

    Dim totalPlayers As Integer
    Dim CPUMode As Boolean
    Dim finishedPosition As Integer

    Dim player1Name As String
    Dim player1Healing As Boolean = False
    Dim player1Health As Double = 100
    Dim player1Go As Boolean = False
    Dim player1Finish As Boolean = False

    Dim player2Name As String
    Dim player2Healing As Boolean = False
    Dim player2Health As Double = 100
    Dim player2Go As Boolean = False
    Dim player2Finish As Boolean = False

    Dim player3Name As String
    Dim player3Healing As Boolean = False
    Dim player3Health As Double = 100
    Dim player3Go As Boolean = False
    Dim player3Finish As Boolean = False

    Dim player4Name As String
    Dim player4Healing As Boolean = False
    Dim player4Health As Double = 100
    Dim player4Go As Boolean = False
    Dim player4Finish As Boolean = False

    Dim initMove As Integer
    Dim initMoveLow As Integer

    Dim player1MoveA As Boolean
    Dim player1MoveD As Boolean
    Dim player2MoveR As Boolean
    Dim player2MoveL As Boolean

    Private Sub Race_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim CPUNames As New ArrayList
        totalPlayers = My.MySettings.Default.TotalPlayers
        CPUMode = My.MySettings.Default.CPUMode

        CPUNames.Add("Garry")
        CPUNames.Add("John")
        CPUNames.Add("Keith")
        CPUNames.Add("Ian")

        Randomize()
        player3Name = CPUNames.Item(Int(Rnd() * (CPUNames.Count - 1)))
        player4Name = CPUNames.Item(Int(Rnd() * (CPUNames.Count - 1)))

        finishedPosition = 1

        ' Load Player Names + Game Settings
        If (totalPlayers = 1) Then

            player1Name = My.MySettings.Default.Player1Name
            player1Go = True

            player3Go = True
            player4Go = True

            lblPlayer1Name.Text = "Player 1: " + player1Name + " | Stamina:"
            lblPlayer2Name.Text = "Player 2: " + "(On Sick Leave)" + " | Stamina:"
            lblPlayer3Name.Text = "Player 3: " + player3Name + " | Stamina:"
            lblPlayer4Name.Text = "Player 4: " + player4Name + " | Stamina:"
            progPlayer1.Value = 100

        ElseIf (totalPlayers = 2) Then

            player1Name = My.MySettings.Default.Player1Name
            player2Name = My.MySettings.Default.Player2Name
            player1Go = True
            player2Go = True
            player3Go = True
            player4Go = True

            lblPlayer1Name.Text = "Player 1: " + player1Name + " | Stamina:"
            lblPlayer2Name.Text = "Player 2: " + player2Name + " | Stamina:"
            lblPlayer3Name.Text = "Player 3: " + player3Name + " | Stamina:"
            lblPlayer4Name.Text = "Player 4: " + player4Name + " | Stamina:"

            progPlayer1.Value = 100
            progPlayer2.Value = 100
            progPlayer3.Value = 100
            progPlayer4.Value = 100

        ElseIf (CPUMode = True) Then

            ' Do Stuff

        End If

    End Sub

    Private Sub tmrCPU3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCPU3.Tick

        Dim CPU As Integer
        Dim CPULOW As Integer

        Randomize()
        CPU = Int(Rnd() * 6) + 1
        CPULOW = Int(Rnd() * 2) + 1

        If (player3Health = 0) Then

            player3Go = False
            player3Healing = True

            tmrPlayer3.Enabled = True
            tmrPlayer3.Start()

        ElseIf (picPlayer3.Left >= 960 And player3Finish = False) Then

            player3Finish = True
            player3Go = False

            tmrCPU3.Stop()
            tmrCPU3.Enabled = False

            Results_Form.lstPlayersFinished.Items.Add(player3Name + " - " + finishedPosition.ToString())
            finishedPosition = finishedPosition + 1

            Call checkFinished(totalPlayers)

        Else

            If player3Go = True And player3Healing = False And player3Finish = False Then

                If (player3Health > 50) Then

                    picPlayer3.Left = picPlayer3.Left + CPU

                Else

                    picPlayer3.Left = picPlayer3.Left + CPULOW

                End If

                Dim healthLevel As Double
                healthLevel = player3Health - 2
                progPlayer3.Value = Int(healthLevel)
                player3Health = healthLevel

            End If

        End If

    End Sub

    Private Sub tmrCPU4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCPU4.Tick

        Dim CPU As Integer
        Dim CPULOW As Integer

        Randomize()
        CPU = Int(Rnd() * 6) + 1
        CPULOW = Int(Rnd() * 2) + 1

        If (player4Health = 0 And player4Finish = False) Then

            player4Go = False
            player4Healing = True

            tmrPlayer4.Enabled = True
            tmrPlayer4.Start()

        ElseIf (picPlayer4.Left >= 960 And player4Finish = False) Then

            player4Finish = True
            player4Go = False

            tmrCPU4.Stop()
            tmrCPU4.Enabled = False

            Results_Form.lstPlayersFinished.Items.Add(player4Name + " - " + finishedPosition.ToString())
            finishedPosition = finishedPosition + 1

            Call checkFinished(totalPlayers)

        Else

            If player4Go = True And player4Healing = False And player4Finish = False Then

                If (player4Health > 50) Then

                    picPlayer4.Left = picPlayer4.Left + CPU

                Else

                    picPlayer4.Left = picPlayer4.Left + CPULOW

                End If

                Dim healthLevel As Double
                healthLevel = player4Health - 2
                progPlayer4.Value = Int(healthLevel)
                player4Health = healthLevel

            End If

        End If

    End Sub


    Private Sub Race_Form_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        Randomize()
        initMove = Int(Rnd() * 12) + 1
        initMoveLow = Int(Rnd() * 6) + 1

        Call checkFinished(totalPlayers)

        If (player1Health = 0) Then

            player1Go = False
            player1Healing = True

            tmrPlayer1.Enabled = True
            tmrPlayer1.Start()

        ElseIf (player2Health = 0) Then

            player2Go = False
            player2Healing = True

            tmrPlayer2.Enabled = True
            tmrPlayer2.Start()

        Else

            If Asc(e.KeyChar) = 97 And player1Go = True And player1MoveA = False And player1Healing = False Then

                If (player1Health > 50) Then

                    picPlayer1.Left = picPlayer1.Left + initMove

                Else

                    picPlayer1.Left = picPlayer1.Left + initMoveLow

                End If

                Dim healthLevel As Double
                healthLevel = player1Health - 2
                progPlayer1.Value = Int(healthLevel)
                player1Health = healthLevel

                player1MoveA = True
                player1MoveD = False

            ElseIf Asc(e.KeyChar) = 100 And player1Go = True And player1MoveD = False And player1Healing = False Then

                If (player1Health > 50) Then

                    picPlayer1.Left = picPlayer1.Left + initMove

                Else

                    picPlayer1.Left = picPlayer1.Left + initMoveLow

                End If

                Dim healthLevel As Double
                healthLevel = player1Health - 2
                progPlayer1.Value = Int(healthLevel)
                player1Health = healthLevel

                player1MoveA = False
                player1MoveD = True

            ElseIf Asc(e.KeyChar) = 111 And player2Go = True And player2MoveL = False And player2Healing = False Then

                picPlayer2.Left = picPlayer2.Left + initMove

                Dim healthLevel As Double
                healthLevel = player2Health - 2
                progPlayer2.Value = Int(healthLevel)
                player2Health = healthLevel

                player2MoveL = True
                player2MoveR = False

            ElseIf Asc(e.KeyChar) = 112 And player2Go = True And player2MoveR = False And player2Healing = False Then

                picPlayer2.Left = picPlayer2.Left + initMove

                Dim healthLevel As Double
                healthLevel = player2Health - 2
                progPlayer2.Value = Int(healthLevel)
                player2Health = healthLevel

                player2MoveL = False
                player2MoveR = True

            End If

        End If

    End Sub

    Public Sub checkFinished(ByVal totalPlaying As Integer)

        If (totalPlaying = 1) Then

            If (picPlayer1.Left >= 960 And player1Finish = False) Then

                player1Finish = True
                player1Go = False

                Results_Form.lstPlayersFinished.Items.Add(player1Name + " - " + finishedPosition.ToString())
                finishedPosition = finishedPosition + 1

            ElseIf (totalPlayers = 1 And player1Finish = True And player3Finish = True And player4Finish = True) Then

                tmrCPU3.Stop()
                tmrCPU4.Stop()

                Results_Form.ShowDialog()

            End If

        ElseIf (totalPlaying = 2) Then

            If (picPlayer1.Left >= 960 And player1Finish = False) Then

                player1Finish = True
                player1Go = False

                Results_Form.lstPlayersFinished.Items.Add(player1Name + " - " + finishedPosition.ToString())
                finishedPosition = finishedPosition + 1

            ElseIf (picPlayer2.Left >= 960 And player2Finish = False) Then

                player2Finish = True
                player2Go = False

                Results_Form.lstPlayersFinished.Items.Add(player2Name + " - " + finishedPosition.ToString())
                finishedPosition = finishedPosition + 1

            ElseIf (totalPlayers = 2 And player1Finish = True And player2Finish = True And player3Finish = True And player4Finish = True) Then

                tmrCPU3.Stop()
                tmrCPU4.Stop()

                Results_Form.Show()

            End If

        End If

    End Sub

    Private Sub tmrPlayer1_Tick(sender As Object, e As EventArgs) Handles tmrPlayer1.Tick

        If (player1Healing = True) Then

            ' Player 1
            player1Health = player1Health + 2
            progPlayer1.Value = player1Health

            player1Health = player1Health

            If player1Health = 100 Then

                tmrPlayer1.Enabled = False
                player1Go = True
                player1Healing = False

            End If

        End If

    End Sub

    Private Sub tmrPlayer2_Tick(sender As Object, e As EventArgs) Handles tmrPlayer2.Tick

        If (player2Healing = True) Then

            ' Player 2
            player2Health = player2Health + 2
            progPlayer2.Value = player2Health

            player2Health = player2Health

            If player2Health = 100 Then

                tmrPlayer2.Enabled = False
                player2Go = True
                player2Healing = False

            End If

        End If

    End Sub

    Private Sub tmrPlayer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayer3.Tick

        If (player3Healing = True) Then

            ' Player 3
            player3Health = player3Health + 2
            progPlayer3.Value = player3Health

            If player3Health = 100 Then

                tmrPlayer3.Enabled = False
                player3Go = True
                player3Healing = False

            End If

            player3Health = player3Health

        End If

    End Sub

    Private Sub tmrPlayer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayer4.Tick

        If (player4Healing = True) Then

            ' Player 4
            player4Health = player4Health + 2
            progPlayer4.Value = player4Health

            If player4Health = 100 Then

                tmrPlayer4.Enabled = False
                player4Go = True
                player4Healing = False

            End If

            player4Health = player4Health

        End If

    End Sub


    Private Sub Race_Form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click

        Application.Exit()

    End Sub

    Private Sub DebugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DebugToolStripMenuItem.Click

        tmrCPU3.Enabled = True
        tmrCPU3.Start()

        tmrCPU4.Enabled = True
        tmrCPU4.Start()

    End Sub

    Public Sub cmdReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdReset.Click

        If (totalPlayers = 1) Then

            ' Player 1
            player1Health = 100
            player1Go = True
            progPlayer1.Value = player1Health

            ' Player 1
            player1Health = 100

            ' Reset Player Locations
            picPlayer1.Location = New Point(12, 27) ' Player 1
            picPlayer3.Location = New Point(12, 213) ' Player 3
            picPlayer4.Location = New Point(12, 306) ' Player 4

        ElseIf (totalPlayers = 2) Then

            ' Player 1
            player1Health = 100
            player1Go = True
            progPlayer1.Value = player1Health

            ' Player 2
            player2Health = 100
            player2Go = True
            progPlayer2.Value = player2Health

            ' Player 3
            player3Health = 100

            ' Player 4
            player4Health = 100

            ' Reset Player Locations
            picPlayer1.Location = New Point(12, 27) ' Player 1
            picPlayer2.Location = New Point(12, 120) ' Player 2
            picPlayer3.Location = New Point(12, 213) ' Player 3
            picPlayer4.Location = New Point(12, 306) ' Player 4

        End If

    End Sub

    Function closeEvent()

        Dim closing As Boolean

        closing = MsgBox("", MsgBoxStyle.YesNo)

        If (closing = True) Then

            ' Do Stuff

        End If

        Return ""

    End Function

End Class
