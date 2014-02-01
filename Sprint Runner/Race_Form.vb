Public Class Race_Form

#Region "Global Settings/Variables"

    Dim totalPlayers As Integer
    Dim CPUMode As Boolean
    Dim finishedPosition As Integer = 1
    Dim countDown As Integer = 10
    Dim debugMode As Boolean = False

    Dim playerHealthBars As New ArrayList

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

#End Region

#Region "Form Load Events"

    Private Sub Race_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Loads Total Players From Application Settings (Taken From Home_Form)
        totalPlayers = My.MySettings.Default.TotalPlayers
        ' Loads If CPU Mode Was Selected On Home_Form
        CPUMode = My.MySettings.Default.CPUMode
        ' Checks For Debug Mode
        If (debugMode = True) Then cmdDebug.Enabled = True
        ' Array Contaning Names For The CPU Players (Needs To Be Even Amount!)
        Dim CPUNames As New ArrayList
        CPUNames.Add("Garry")
        CPUNames.Add("John")
        CPUNames.Add("Keith")
        CPUNames.Add("Ian")
        CPUNames.Add("Smithy")
        CPUNames.Add("Kevin")
        CPUNames.Add("George")
        CPUNames.Add("Tom")
        CPUNames.Add("Gavin")
        CPUNames.Add("Steve")

        ' Array Adding The Progress Bars For Player Health
        playerHealthBars.Add(progPlayer1)
        playerHealthBars.Add(progPlayer2)
        playerHealthBars.Add(progPlayer3)
        playerHealthBars.Add(progPlayer4)

        ' Load Player Names + Game Settings
        If (totalPlayers = 1) Then

            ' Load/Set Player Names
            player1Name = My.MySettings.Default.Player1Name

            Randomize()
            player2Name = CPUNames.Item(Int(Rnd() * (CPUNames.Count - 3)))
            player3Name = CPUNames.Item(Int(Rnd() * (CPUNames.Count - 1)))
            player4Name = CPUNames.Item(Int(Rnd() * (CPUNames.Count - 2)))

            ' Set Player Names / Label Text
            lblPlayer1Name.Text = "Player 1: " + player1Name + " | Stamina:"
            lblPlayer2Name.Text = "Player 2: " + player2Name + " | Stamina:"
            lblPlayer3Name.Text = "Player 3: " + player3Name + " | Stamina:"
            lblPlayer4Name.Text = "Player 4: " + player4Name + " | Stamina:"

        ElseIf (totalPlayers = 2) Then

            ' Load/Set Player Names
            player1Name = My.MySettings.Default.Player1Name
            player2Name = My.MySettings.Default.Player2Name

            ' Set Player Names / Label Text
            lblPlayer1Name.Text = "Player 1: " + player1Name + " | Stamina:"
            lblPlayer2Name.Text = "Player 2: " + player2Name + " | Stamina:"
            lblPlayer3Name.Text = "Player 3: " + player3Name + " | Stamina:"
            lblPlayer4Name.Text = "Player 4: " + player4Name + " | Stamina:"

        ElseIf (totalPlayers = 4) Then

            ' Load/Set Player Names
            Randomize()
            player1Name = CPUNames.Item(Int(Rnd() * (CPUNames.Count - 4)))
            player2Name = CPUNames.Item(Int(Rnd() * (CPUNames.Count - 3)))
            player3Name = CPUNames.Item(Int(Rnd() * (CPUNames.Count - 1)))
            player4Name = CPUNames.Item(Int(Rnd() * (CPUNames.Count - 2)))

            ' Set Player Names / Label Text
            lblPlayer1Name.Text = "Player 1: " + player1Name + " | Stamina:"
            lblPlayer2Name.Text = "Player 2: " + player2Name + " | Stamina:"
            lblPlayer3Name.Text = "Player 3: " + player3Name + " | Stamina:"
            lblPlayer4Name.Text = "Player 4: " + player4Name + " | Stamina:"

        End If

    End Sub

#End Region

#Region "Functions/Timer"

    Private Sub tmrCountDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCountDown.Tick

        ' Set CountDown (TakeAway) + Set Label Text For The Race Status
        countDown = countDown - 1
        lblStatus.Text = "Race Status: Starting In " + countDown.ToString()

        ovalRed.Visible = True

        ' Fills Up The Progress Bars On Each Tick To Show The Players Getting Ready
        For Each ProgressBar In playerHealthBars

            ' For Each Proogress Bar In The Array + 10 Value To Fill To 100
            ProgressBar.Value = ProgressBar.Value + 10

        Next

        ' Set Player Stats Text
        lblPlayer1Stats.Text = player1Name + " : Getting Ready!"
        lblPlayer2Stats.Text = player2Name + " : Getting Ready!"
        lblPlayer3Stats.Text = player3Name + " : Getting Ready!"
        lblPlayer4Stats.Text = player4Name + " : Getting Ready!"

        ' Checks For The CountDown Stages
        If (countDown = 5) Then

            ovalAmber.Visible = True

        ElseIf (countDown = 3) Then

            lblStatus.Text = "Race Status: Get Ready!"

        ElseIf (countDown = 2) Then

            lblStatus.Text = "Race Status: On Your Marks!"

        ElseIf (countDown = 1) Then

            lblStatus.Text = "Race Status: Get Set!"

        ElseIf (countDown = 0) Then

            ovalGreen.Visible = True

            ovalRed.BackColor = Color.Green
            ovalRed.BorderColor = Color.LimeGreen
            ovalRed.FillColor = Color.LimeGreen
            ovalAmber.BackColor = Color.Green
            ovalAmber.BorderColor = Color.LimeGreen
            ovalAmber.FillColor = Color.LimeGreen

            lblStatus.Text = "Race Status: Go! (Started)"
            tmrCountDown.Stop()
            tmrCountDown.Enabled = False

            If (totalPlayers = 1) Then

                ' Sets The Player Status To Allow Them To Go
                player1Go = True
                player3Go = True
                player4Go = True

                ' Enable CPU Players
                tmrCPU3.Enabled = True
                tmrCPU3.Start()
                tmrCPU4.Enabled = True
                tmrCPU4.Start()

                ' Set Player Stats Text
                lblPlayer1Stats.Text = player1Name.ToString() + " : Ready!"
                lblPlayer2Stats.Text = player2Name.ToString() + " : Sick!"
                lblPlayer3Stats.Text = player3Name.ToString() + " : Ready!"
                lblPlayer4Stats.Text = player4Name.ToString() + " : Ready!"

            ElseIf (totalPlayers = 2) Then

                ' Sets The Player Status To Allow Them To Go
                player1Go = True
                player2Go = True
                player3Go = True
                player4Go = True

                ' Enable CPU Players
                tmrCPU3.Enabled = True
                tmrCPU3.Start()
                tmrCPU4.Enabled = True
                tmrCPU4.Start()

                ' Set Player Stats Text
                lblPlayer1Stats.Text = player1Name.ToString() + " : Ready!"
                lblPlayer2Stats.Text = player2Name.ToString() + " : Ready!"
                lblPlayer3Stats.Text = player3Name.ToString() + " : Ready!"
                lblPlayer4Stats.Text = player4Name.ToString() + " : Ready!"

            ElseIf (totalPlayers = 4) Then

                ' Sets The Player Status To Allow Them To Go
                player1Go = True
                player2Go = True
                player3Go = True
                player4Go = True

                ' Enable Players
                tmrCPU1.Enabled = True
                tmrCPU1.Start()
                tmrCPU2.Enabled = True
                tmrCPU2.Start()
                tmrCPU3.Enabled = True
                tmrCPU3.Start()
                tmrCPU4.Enabled = True
                tmrCPU4.Start()

                ' Set Player Stats Text
                lblPlayer1Stats.Text = player1Name.ToString() + " : Ready!"
                lblPlayer2Stats.Text = player2Name.ToString() + " : Ready!"
                lblPlayer3Stats.Text = player3Name.ToString() + " : Ready!"
                lblPlayer4Stats.Text = player4Name.ToString() + " : Ready!"

            End If

        End If

    End Sub

    Public Sub checkFinished(ByVal totalPlaying As Integer)

        ' Checks On How Many People Are Playing
        If (totalPlaying = 1) Then

            ' Disables Player Movement If Player Finishes Then Adds The Player Finish To The Scoreboard
            If (picPlayer1.Left >= 960 And player1Finish = False) Then

                player1Finish = True
                player1Go = False

                Results_Form.lstPlayersFinished.Items.Add(player1Name + " (Player1) " + "- " + finishedPosition.ToString())
                finishedPosition = finishedPosition + 1

                ' If All Players Have Finished Then Stop The Timers And Show The Result Form
            ElseIf (totalPlayers = 1 And player1Finish = True And player3Finish = True And player4Finish = True) Then

                ' Stops The Timers And Shows The Result Form As Dialog
                tmrCPU3.Stop()
                tmrCPU4.Stop()
                Results_Form.ShowDialog()

            End If

        ElseIf (totalPlaying = 2) Then

            ' Disables Player Movement If Player Finishes Then Adds The Player Finish To The Scoreboard
            If (picPlayer1.Left >= 960 And player1Finish = False) Then

                player1Finish = True
                player1Go = False

                Results_Form.lstPlayersFinished.Items.Add(player1Name + " (Player 1) " + "- " + finishedPosition.ToString())
                finishedPosition = finishedPosition + 1

                ' Disables Player Movement If Player Finishes Then Adds The Player Finish To The Scoreboard
            ElseIf (picPlayer2.Left >= 960 And player2Finish = False) Then

                player2Finish = True
                player2Go = False

                Results_Form.lstPlayersFinished.Items.Add(player2Name + " (Player 2) " + "- " + finishedPosition.ToString())
                finishedPosition = finishedPosition + 1

                ' If All Players Have Finished Then Stop The Timers And Show The Result Form
            ElseIf (totalPlayers = 2 And player1Finish = True And player2Finish = True And player3Finish = True And player4Finish = True) Then

                ' Stops The Timers And Shows The Result Form As Dialog
                tmrCPU3.Stop()
                tmrCPU4.Stop()
                Results_Form.ShowDialog()

            End If

        ElseIf (totalPlaying = 4 And player1Finish = True And player2Finish = True And player3Finish = True And player4Finish = True) Then

            ' Stops The Timers And Shows The Result Form As Dialog
            tmrCPU1.Stop()
            tmrCPU2.Stop()
            tmrCPU3.Stop()
            tmrCPU4.Stop()
            Results_Form.ShowDialog()

        End If

    End Sub

#End Region

#Region "CPU Player - Timer"

    Private Sub tmrCPU1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCPU1.Tick

        Dim CPU As Integer
        Dim CPULOW As Integer

        ' Randomizes And Select The Player Movements
        Randomize()
        CPU = Int(Rnd() * 6) + 1
        CPULOW = Int(Rnd() * 2) + 1

        ' Goes Through The Health And At Differant Stages Slows The Player Down, Also When The Health Reaches A Low Point Then Starts The Timer For Re-Healing
        If (player1Health = 0) Then

            ' Disables Player Movement And Enable The Re-Healing Timer
            player1Go = False
            player1Healing = True
            lblPlayer1Stats.Text = player1Name.ToString() + " : Healing..."

            tmrPlayer1.Enabled = True
            tmrPlayer1.Start()

        ElseIf (picPlayer1.Left >= 960 And player1Finish = False) Then

            ' Disables Player Movement If Player Finishes Then Adds The Player Finish To The Scoreboard
            player1Finish = True
            player1Go = False

            tmrCPU1.Stop()
            tmrCPU1.Enabled = False

            Results_Form.lstPlayersFinished.Items.Add(player1Name + " - " + finishedPosition.ToString())
            finishedPosition = finishedPosition + 1

            ' Call Function To Check If Players Have Finished
            Call checkFinished(totalPlayers)

        Else

            If player1Go = True And player1Healing = False And player1Finish = False Then

                ' Moves The Player Along The Track At Random Intervals
                If (player1Health > 50) Then

                    picPlayer1.Left = picPlayer1.Left + CPU

                Else

                    picPlayer1.Left = picPlayer1.Left + CPULOW

                End If

                Dim healthLevel As Double
                healthLevel = player1Health - 2
                progPlayer1.Value = Int(healthLevel)
                player1Health = healthLevel

            End If

        End If

    End Sub

    Private Sub tmrCPU2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCPU2.Tick

        Dim CPU As Integer
        Dim CPULOW As Integer

        ' Randomizes And Select The Player Movements
        Randomize()
        CPU = Int(Rnd() * 6) + 1
        CPULOW = Int(Rnd() * 2) + 1

        ' Goes Through The Health And At Differant Stages Slows The Player Down, Also When The Health Reaches A Low Point Then Starts The Timer For Re-Healing
        If (player2Health = 0) Then

            ' Disables Player Movement And Enable The Re-Healing Timer
            player2Go = False
            player2Healing = True
            lblPlayer2Stats.Text = player2Name.ToString() + " : Healing..."

            tmrPlayer2.Enabled = True
            tmrPlayer2.Start()

        ElseIf (picPlayer2.Left >= 960 And player2Finish = False) Then

            ' Disables Player Movement If Player Finishes Then Adds The Player Finish To The Scoreboard
            player2Finish = True
            player2Go = False

            tmrCPU2.Stop()
            tmrCPU2.Enabled = False

            Results_Form.lstPlayersFinished.Items.Add(player2Name + " - " + finishedPosition.ToString())
            finishedPosition = finishedPosition + 1

            ' Call Function To Check If Players Have Finished
            Call checkFinished(totalPlayers)

        Else

            If player2Go = True And player2Healing = False And player2Finish = False Then

                ' Moves The Player Along The Track At Random Intervals
                If (player2Health > 50) Then

                    picPlayer2.Left = picPlayer2.Left + CPU

                Else

                    picPlayer2.Left = picPlayer2.Left + CPULOW

                End If

                Dim healthLevel As Double
                healthLevel = player2Health - 2
                progPlayer2.Value = Int(healthLevel)
                player2Health = healthLevel

            End If

        End If

    End Sub

    Private Sub tmrCPU3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCPU3.Tick

        Dim CPU As Integer
        Dim CPULOW As Integer

        ' Randomizes And Select The Player Movements
        Randomize()
        CPU = Int(Rnd() * 6) + 1
        CPULOW = Int(Rnd() * 2) + 1

        ' Goes Through The Health And At Differant Stages Slows The Player Down, Also When The Health Reaches A Low Point Then Starts The Timer For Re-Healing
        If (player3Health = 0) Then

            ' Disables Player Movement And Enable The Re-Healing Timer
            player3Go = False
            player3Healing = True
            lblPlayer3Stats.Text = player3Name.ToString() + " : Healing..."

            tmrPlayer3.Enabled = True
            tmrPlayer3.Start()

        ElseIf (picPlayer3.Left >= 960 And player3Finish = False) Then

            ' Disables Player Movement If Player Finishes Then Adds The Player Finish To The Scoreboard
            player3Finish = True
            player3Go = False

            tmrCPU3.Stop()
            tmrCPU3.Enabled = False

            Results_Form.lstPlayersFinished.Items.Add(player3Name + " - " + finishedPosition.ToString())
            finishedPosition = finishedPosition + 1

            ' Call Function To Check If Players Have Finished
            Call checkFinished(totalPlayers)

        Else

            If player3Go = True And player3Healing = False And player3Finish = False Then

                ' Moves The Player Along The Track At Random Intervals
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

        ' Randomizes And Select The Player Movements
        Randomize()
        CPU = Int(Rnd() * 6) + 1
        CPULOW = Int(Rnd() * 2) + 1

        ' Goes Through The Health And At Differant Stages Slows The Player Down, Also When The Health Reaches A Low Point Then Starts The Timer For Re-Healing
        If (player4Health = 0 And player4Finish = False) Then

            ' Disables Player Movement And Enable The Re-Healing Timer
            player4Go = False
            player4Healing = True
            lblPlayer4Stats.Text = player4Name.ToString() + " : Healing..."

            tmrPlayer4.Enabled = True
            tmrPlayer4.Start()

        ElseIf (picPlayer4.Left >= 960 And player4Finish = False) Then

            ' Disables Player Movement If Player Finishes Then Adds The Player Finish To The Scoreboard
            player4Finish = True
            player4Go = False

            tmrCPU4.Stop()
            tmrCPU4.Enabled = False

            Results_Form.lstPlayersFinished.Items.Add(player4Name + " - " + finishedPosition.ToString())
            finishedPosition = finishedPosition + 1

            ' Call Function To Check If Players Have Finished
            Call checkFinished(totalPlayers)

        Else

            If player4Go = True And player4Healing = False And player4Finish = False Then

                ' Moves The Player Along The Track At Random Intervals
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

#End Region

#Region "Key Press Events"

    Private Sub Race_Form_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        ' Randomizes And Select The Player Movements
        Randomize()
        initMove = Int(Rnd() * 14) + 1
        initMoveLow = Int(Rnd() * 7) + 1

        ' Call Function To Check If Players Have Finished
        Call checkFinished(totalPlayers)

        ' Goes Through The Health And At Differant Stages Slows The Player Down, Also When The Health Reaches A Low Point Then Starts The Timer For Re-Healing
        If (player1Health = 0) Then

            ' Disables Player Movement And Enable The Re-Healing Timer
            player1Go = False
            player1Healing = True
            lblPlayer1Stats.Text = player1Name.ToString() + " : Healing..."

            tmrPlayer1.Enabled = True
            tmrPlayer1.Start()

        ElseIf (player2Health = 0) Then

            ' Disables Player Movement And Enable The Re-Healing Timer
            player2Go = False
            player2Healing = True
            lblPlayer2Stats.Text = player2Name.ToString() + " : Healing..."

            tmrPlayer2.Enabled = True
            tmrPlayer2.Start()

        Else

            ' Goes Through The IF Statments And Checks For The Key Presses And Then Runs The Code To Move The Player/s
            If Asc(e.KeyChar) = 97 And player1Go = True And player1MoveA = False And player1Healing = False Then

                ' Moves The Player Along The Track At Random Intervals
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

                ' Moves The Player Along The Track At Random Intervals
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

#End Region

#Region "Player Healths"

    Private Sub tmrPlayer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrPlayer1.Tick

        ' Checks To Make Sure That The Player Is Allowed To Heal
        If (player1Healing = True) Then

            ' Player 1 - Starts The CountUp To Re-Heal The Player Once Down Then Enables The Player To Move Again
            player1Health = player1Health + 2
            progPlayer1.Value = player1Health

            If player1Health = 100 Then

                tmrPlayer1.Enabled = False
                player1Go = True
                player1Healing = False
                lblPlayer1Stats.Text = player1Name.ToString() + " : Ready!"

            End If

            ' Sets Player Health
            player1Health = player1Health

        End If

    End Sub

    Private Sub tmrPlayer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrPlayer2.Tick

        ' Checks To Make Sure That The Player Is Allowed To Heal
        If (player2Healing = True) Then

            ' Player 2 - Starts The CountUp To Re-Heal The Player Once Down Then Enables The Player To Move Again
            player2Health = player2Health + 2
            progPlayer2.Value = player2Health

            If player2Health = 100 Then

                tmrPlayer2.Enabled = False
                player2Go = True
                player2Healing = False
                lblPlayer2Stats.Text = player2Name.ToString() + " : Ready!"

            End If

            ' Sets Player Health
            player2Health = player2Health

        End If

    End Sub

    Private Sub tmrPlayer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayer3.Tick

        ' Checks To Make Sure That The Player Is Allowed To Heal
        If (player3Healing = True) Then

            ' Player 3 - Starts The CountUp To Re-Heal The Player Once Down Then Enables The Player To Move Again
            player3Health = player3Health + 2
            progPlayer3.Value = player3Health

            If player3Health = 100 Then

                tmrPlayer3.Enabled = False
                player3Go = True
                player3Healing = False
                lblPlayer3Stats.Text = player3Name.ToString() + " : Ready!"

            End If

            ' Sets Player Health
            player3Health = player3Health

        End If

    End Sub

    Private Sub tmrPlayer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayer4.Tick

        ' Checks To Make Sure That The Player Is Allowed To Heal
        If (player4Healing = True) Then

            ' Player 4 - Starts The CountUp To Re-Heal The Player Once Down Then Enables The Player To Move Again
            player4Health = player4Health + 2
            progPlayer4.Value = player4Health

            If player4Health = 100 Then

                tmrPlayer4.Enabled = False
                player4Go = True
                player4Healing = False
                lblPlayer4Stats.Text = player4Name.ToString() + " : Ready!"

            End If

            ' Sets Player Health
            player4Health = player4Health

        End If

    End Sub

#End Region

#Region "Debug Mode"

    Private Sub cmdDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDebug.Click

        ' Debug Starts The CPU Players (Manual Testing)
        tmrCPU3.Enabled = True
        tmrCPU3.Start()

        tmrCPU4.Enabled = True
        tmrCPU4.Start()

    End Sub

#End Region

#Region "Button Events"

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click

        ' Starts The CountDown Timer (Starts The Game)
        tmrCountDown.Enabled = True
        tmrCountDown.Start()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click

        Close()

    End Sub

    Public Sub cmdReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdReset.Click

        Dim notifed As Boolean

        notifed = MsgBox("Warning! This Restarts The Game, All Progress Will Be Lost", MsgBoxStyle.YesNo)

        If (notifed = True) Then

            Application.Restart()

        End If

    End Sub

    Private Sub Race_Form_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        Dim notifed As Boolean

        notifed = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo)

        If (notifed = True) Then

            Application.Exit()

        End If

    End Sub

#End Region

End Class