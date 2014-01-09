Public Class Race_Form

    Dim player1Name As String
    Dim player2Name As String
    Dim player3Name As String
    Dim player4Name As String

    Dim player1Health As Double = 100
    Dim player1Go As Boolean = True
    Dim player2Health As Double = 100
    Dim player2Go As Boolean = True
    Dim player3Health As Double = 100
    Dim player4Health As Double = 100

    Dim initMove As Integer

    Dim player1MoveA As Boolean
    Dim player1MoveD As Boolean
    Dim player2MoveR As Boolean
    Dim player2MoveL As Boolean

    Private Sub Race_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim CPUNames As New ArrayList
        Dim randomInt As New Random

        CPUNames.Add("Garry")
        CPUNames.Add("John")
        CPUNames.Add("Keith")
        CPUNames.Add("Ian")

        player3Name = CPUNames.Item(Int(Rnd() * (CPUNames.Count - 1)))
        player4Name = CPUNames.Item(Int(Rnd() * (CPUNames.Count - 1)))


        player1Name = My.MySettings.Default.Player1Name
        player2Name = My.MySettings.Default.Player2Name

        lblPlayer1Name.Text = "Player 1: " + player1Name + " | Stamina:"
        lblPlayer2Name.Text = "Player 2: " + player2Name + " | Stamina:"
        lblPlayer3Name.Text = "Player 3: " + player3Name + " | Stamina:"
        lblPlayer4Name.Text = "Player 4: " + player4Name + " | Stamina:"

        progPlayer1.Value = 100
        progPlayer2.Value = 100
        progPlayer3.Value = 100
        progPlayer4.Value = 100

    End Sub

    Private Sub tmrRace_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRace.Tick

        ' CPU Players


    End Sub

    Private Sub Race_Form_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        Randomize()
        initMove = Int(Rnd() * 10) + 1

        If (player1Health = 0) Then

            player1Go = False

            Do Until player1Health = 100

                player1Health = player1Health + 0.5

            Loop

            progPlayer1.Value = player1Health
            player1Health = player1Health
            player1Go = True

        ElseIf (player2Health = 0) Then

            player2Go = False

            Do Until player2Health = 100

                player2Health = player2Health + 0.5

            Loop

            progPlayer2.Value = player1Health
            player2Health = player2Health
            player2Go = True

        Else

            If Asc(e.KeyChar) = 97 And player1Go = True And player1MoveA = False Then

                picPlayer1.Left = picPlayer1.Left + initMove

                Dim healthLevel As Double
                healthLevel = player1Health - 4
                progPlayer1.Value = Int(healthLevel)
                player1Health = healthLevel

                player1MoveA = True
                player1MoveD = False

            ElseIf Asc(e.KeyChar) = 100 And player1Go = True And player1MoveD = False Then

                picPlayer1.Left = picPlayer1.Left + initMove

                Dim healthLevel As Double
                healthLevel = player1Health - 4
                progPlayer1.Value = Int(healthLevel)
                player1Health = healthLevel

                player1MoveA = False
                player1MoveD = True

            ElseIf Asc(e.KeyChar) = 111 And player2Go = True And player2MoveL = False Then

                picPlayer2.Left = picPlayer2.Left + initMove

                Dim healthLevel As Double
                healthLevel = player2Health - 4
                progPlayer2.Value = Int(healthLevel)
                player2Health = healthLevel

                player2MoveL = True
                player2MoveR = False

            ElseIf Asc(e.KeyChar) = 112 And player2Go = True And player2MoveR = False Then

                picPlayer2.Left = picPlayer2.Left + initMove

                Dim healthLevel As Double
                healthLevel = player2Health - 4
                progPlayer2.Value = Int(healthLevel)
                player2Health = healthLevel

                player2MoveL = False
                player2MoveR = True

            End If

        End If

    End Sub

    Private Sub Race_Form_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Call closeApplication()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click

        Call closeApplication()

    End Sub

    Private Sub closeApplication()

        Application.Exit()

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click

        ' Reset Game Settings
        tmrRace.Enabled = False

        ' Reset Player Settings / Variables
        player1Health = 100
        player1Go = True
        progPlayer1.Value = player1Health
        player2Health = 100
        player2Go = True
        progPlayer2.Value = player2Health
        player3Health = 100
        player4Health = 100

        ' Reset Player Locations
        picPlayer1.Location = New Point(12, 27)
        picPlayer2.Location = New Point(12, 120)
        picPlayer3.Location = New Point(12, 213)
        picPlayer4.Location = New Point(12, 306)

    End Sub

End Class
