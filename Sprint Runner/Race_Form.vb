Public Class Race_Form

    Dim player1Name As String
    Dim player2Name As String

    Dim player1Health As Integer = 100
    Dim player1Go As Boolean = True
    Dim player2Health As Integer = 100
    Dim player3Health As Integer = 100
    Dim player4Health As Integer = 100

    Dim initMove As Integer

    Dim player1MoveA As Boolean
    Dim player1MoveD As Boolean

    Private Sub Race_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        player1Name = My.MySettings.Default.Player1Name
        player2Name = My.MySettings.Default.Player2Name

        lblPlayer1Name.Text = "Player 1: " + player1Name
        lblPlayer2Name.Text = "Player 2: " + player2Name

        progPlayer1.Value = 100

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

                player1Health = player1Health + 1

            Loop

            progPlayer1.Value = player1Health
            player1Health = player1Health
            player1Go = True

        Else

            If Asc(e.KeyChar) = 97 And player1Go = True And player1MoveA = False Then

                picPlayer1.Left = picPlayer1.Left + initMove

                Dim healthLevel As Integer
                healthLevel = player1Health - 5
                progPlayer1.Value = Int(healthLevel)
                player1Health = healthLevel

                player1MoveA = True
                player1MoveD = False

            ElseIf Asc(e.KeyChar) = 100 And player1Go = True And player1MoveD = False Then

                picPlayer1.Left = picPlayer1.Left + initMove

                Dim healthLevel As Integer
                healthLevel = player1Health - 5
                progPlayer1.Value = Int(healthLevel)
                player1Health = healthLevel

                player1MoveA = False
                player1MoveD = True

            End If

        End If

    End Sub

    Private Sub resetGame()

        ' Reset Game Settings
        tmrRace.Enabled = False

        ' Reset Player Health Values
        player1Health = 100
        player2Health = 100
        player3Health = 100
        player4Health = 100

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

End Class
