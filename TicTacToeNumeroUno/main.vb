Imports NetSockets
Public Class main
    Dim singlePlayerTurn As Integer '0 = player,1 = comp
    Dim rand As New Random
    Dim xWins As Integer
    Dim oWins As Integer
    Dim testVar As Integer
    Dim mode As Integer ' 1 = Single, 2 = TwoP, 3 = Multi
    Dim turn As Integer ' 1 = X, 2 = O
    Dim playerOne As String = "Player 1"
    Dim playerTwo As String = "Player 2"
    'Multiplayer Variables
    Shared ReadOnly client As New NetObjectClient()
    Dim serverIP As String = "127.0.0.1"
    Dim registerClientCounter As Integer = 0
    Dim roomPrefix As String = "[Lobby]"
    Dim inviteSpamNum As Integer = 0
    Dim myLetter As String
    Dim opponentName As String
    Dim clientUsername As String
    Dim inGame As Boolean
    ' Dim my.settings.spletterchoice As Integer = My.Settings.spLetterChoice '0=O,1=X
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'gameOver.MdiParent = Me
        'chooseLetter.MdiParent = Me
        Control.CheckForIllegalCrossThreadCalls = False
        clientUsername = My.Settings.clientUsername
        AddHandler client.OnConnected, AddressOf client_OnConnected
        AddHandler client.OnDisconnected, AddressOf client_OnDisconnected
        AddHandler client.OnReceived, AddressOf client_OnReceived
        loadMainMenu()

        If My.Settings.clientUsername = Nothing Then
            My.Settings.clientUsername = "Client" & randomNum(1, 10000)
            My.Settings.Save()
            clientUsername = My.Settings.clientUsername
        End If

    End Sub
    Function randomNum(ByVal firstNum, secondNum)
        Randomize()
        Dim random As New Random
        Dim num As Integer = random.Next(firstNum, secondNum)
        Return num
    End Function
    Sub loadMainMenu()
        lblTitle.Visible = True
        picLogo.Visible = True
        lblSinglePlayer.Visible = True
        lblTwoPlayer.Visible = True
        lblMultiplayer.Visible = True
        lblOptions.Visible = True
    End Sub
    Function endTurn()
        btnSlotOne.Enabled = False
        btnSlotTwo.Enabled = False
        btnSlotThree.Enabled = False
        btnSlotFour.Enabled = False
        btnSlotFive.Enabled = False
        btnSlotSix.Enabled = False
        btnSlotSeven.Enabled = False
        btnSlotEight.Enabled = False
        btnSlotNine.Enabled = False
        Return True
    End Function
    Function resumeTurn()
        If btnSlotOne.Text = Nothing Then
            btnSlotOne.Enabled = True
        Else
            btnSlotOne.Enabled = False
        End If

        If btnSlotTwo.Text = Nothing Then
            btnSlotTwo.Enabled = True
        Else
            btnSlotTwo.Enabled = False
        End If

        If btnSlotThree.Text = Nothing Then
            btnSlotThree.Enabled = True
        Else
            btnSlotThree.Enabled = False
        End If

        If btnSlotFour.Text = Nothing Then
            btnSlotFour.Enabled = True
        Else
            btnSlotFour.Enabled = False
        End If

        If btnSlotFive.Text = Nothing Then
            btnSlotFive.Enabled = True
        Else
            btnSlotFive.Enabled = False
        End If

        If btnSlotSix.Text = Nothing Then
            btnSlotSix.Enabled = True
        Else
            btnSlotSix.Enabled = False
        End If

        If btnSlotSeven.Text = Nothing Then
            btnSlotSeven.Enabled = True
        Else
            btnSlotSeven.Enabled = False
        End If

        If btnSlotEight.Text = Nothing Then
            btnSlotEight.Enabled = True
        Else
            btnSlotEight.Enabled = False
        End If

        If btnSlotNine.Text = Nothing Then
            btnSlotNine.Enabled = True
        Else
            btnSlotNine.Enabled = False
        End If
        Return True
    End Function
    Sub hideMainMenu()
        lblTitle.Visible = False
        picLogo.Visible = False
        lblSinglePlayer.Visible = False
        lblTwoPlayer.Visible = False
        lblMultiplayer.Visible = False
        lblOptions.Visible = False
    End Sub
    Sub loadSinglePlayer()
        picBoard.Visible = True
        btnSlotOne.Visible = True
        btnSlotTwo.Visible = True
        btnSlotThree.Visible = True
        btnSlotFour.Visible = True
        btnSlotFive.Visible = True
        btnSlotSix.Visible = True
        btnSlotSeven.Visible = True
        btnSlotEight.Visible = True
        btnSlotNine.Visible = True
        picBox.Visible = True
        lblDash1.Visible = True
        lblDash2.Visible = True
        picX.Visible = True
        picO.Visible = True
        lblOWins.Visible = True
        lblXWins.Visible = True
        btnUndo.Visible = True
        btnQuit.Visible = True
        lblPlayerO.Visible = True
        lblPlayerX.Visible = True
        xWins = 0
        oWins = 0
        lblXWins.Text = "0"
        lblOWins.Text = "0"
        btnUndo.Enabled = False
        btnUndo.Text = "Undo"
        mode = 1
    End Sub
    Sub chooseTurn()
        Randomize()
        Dim r As New Random
        Dim x As Integer = r.Next(1, 100)

        If x > 1 And x <= 50 Then
            'X gets his turn
            turn = 1
            lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Bold)
            lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Regular)
        Else
            'O gets his turn
            turn = 2
            lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Bold)
            lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Regular)
        End If

    End Sub
    Sub hideSinglePlayer()
        picBoard.Visible = False
        btnSlotOne.Visible = False
        btnSlotTwo.Visible = False
        btnSlotThree.Visible = False
        btnSlotFour.Visible = False
        btnSlotFive.Visible = False
        btnSlotSix.Visible = False
        btnSlotSeven.Visible = False
        btnSlotEight.Visible = False
        btnSlotNine.Visible = False
        picBox.Visible = False
        lblDash1.Visible = False
        lblDash2.Visible = False
        picX.Visible = False
        picO.Visible = False
        lblOWins.Visible = False
        lblXWins.Visible = False
        btnUndo.Visible = False
        btnQuit.Visible = False
        lblPlayerX.Visible = False
        lblPlayerO.Visible = False
    End Sub
    Sub loadTwoPlayer()
        picBoard.Visible = True
        btnSlotOne.Visible = True
        btnSlotTwo.Visible = True
        btnSlotThree.Visible = True
        btnSlotFour.Visible = True
        btnSlotFive.Visible = True
        btnSlotSix.Visible = True
        btnSlotSeven.Visible = True
        btnSlotEight.Visible = True
        btnSlotNine.Visible = True
        picBox.Visible = True
        lblDash1.Visible = True
        lblDash2.Visible = True
        picX.Visible = True
        picO.Visible = True
        lblOWins.Visible = True
        lblXWins.Visible = True
        btnUndo.Visible = True
        btnQuit.Visible = True
        lblPlayerO.Visible = True
        lblPlayerX.Visible = True
        xWins = 0
        oWins = 0
        lblXWins.Text = "0"
        lblOWins.Text = "0"
        btnUndo.Enabled = False
        mode = 2
        'lblPlayerO.Visible = True
        chooseTurn()
        btnUndo.Enabled = True
        btnUndo.Text = "Whose Turn?"
        If playerOne = Nothing Then
            lblPlayerX.Text = "Player 1"
        Else
            lblPlayerX.Text = playerOne
        End If
        If playerTwo = Nothing Then
            lblPlayerO.Text = "Player 2"
        Else
            lblPlayerO.Text = playerTwo
        End If
    End Sub
    Sub loadMultiplayerLobby()
        'client.TryConnect(serverIP, 20675)
        'pnlMultiplayerLobby.Visible = True
        'hideMainMenu()
        'btnExit.Visible = True
        'Label1.Visible = True
        'Label2.Visible = True
        'Label3.Visible = True
        'lstClients.Visible = True
        'rtbChatLog.Visible = True
        'txtMessage.Visible = True
        'stsStatus.Visible = True
        'tmrRegClient.Start()
        'mode = 3
        If client.TryConnect(serverIP, 20675) Then
            'pnlMultiplayerLobby.Visible = True
            hideMainMenu()
            btnExit.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            lstClients.Visible = True
            rtbChatLog.Visible = True
            txtMessage.Visible = True
            stsStatus.Visible = True
            tmrRegClient.Start()
            mode = 3
        Else
            MsgBox("Failed to Connect. Server may be offline.", MsgBoxStyle.Critical, "Error")

        End If
    End Sub
    Sub hideMultiplayerLobby()
        'client.Disconnect()
        ' pnlMultiplayerLobby.Visible = False
        'pnlMultiplayerLobby.SendToBack()
        'pnlMultiplayerLobby.SendToBack()
        btnExit.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        lstClients.Visible = False
        rtbChatLog.Visible = False
        txtMessage.Visible = False
        stsStatus.Visible = False
        'pnlMultiplayerLobby.Location = New Point(344, 444)
    End Sub
    Sub loadMultiplayer()
        bw_Help.RunWorkerAsync()
    End Sub
    Sub quitGame()
        hideSinglePlayer()
        loadMainMenu()
        btnSlotOne.BackgroundImage = Nothing
        btnSlotTwo.BackgroundImage = Nothing
        btnSlotThree.BackgroundImage = Nothing
        btnSlotFour.BackgroundImage = Nothing
        btnSlotFive.BackgroundImage = Nothing
        btnSlotSix.BackgroundImage = Nothing
        btnSlotSeven.BackgroundImage = Nothing
        btnSlotEight.BackgroundImage = Nothing
        btnSlotNine.BackgroundImage = Nothing
        btnSlotOne.Tag = ""
        btnSlotTwo.Tag = ""
        btnSlotThree.Tag = ""
        btnSlotFour.Tag = ""
        btnSlotFive.Tag = ""
        btnSlotSix.Tag = ""
        btnSlotSeven.Tag = ""
        btnSlotEight.Tag = ""
        btnSlotNine.Tag = ""
        btnSlotOne.Enabled = True
        btnSlotTwo.Enabled = True
        btnSlotThree.Enabled = True
        btnSlotFour.Enabled = True
        btnSlotFive.Enabled = True
        btnSlotSix.Enabled = True
        btnSlotSeven.Enabled = True
        btnSlotEight.Enabled = True
        btnSlotNine.Enabled = True
        xWins = 0
        oWins = 0
    End Sub
    Sub loadGameOptions()
        MsgBox("Due to insufficient funding, game options cease to exist.", MsgBoxStyle.Critical, "RiP Funding")
    End Sub
    Sub computerTurn()
        Randomize()
        Dim compBox As Integer = rand.Next(1, 9)
        Dim computerLetterChoice As Integer
        Dim letterImage As Image
        If My.Settings.spLetterChoice = 0 Then
            computerLetterChoice = 1
            letterImage = My.Resources.X
        Else
            computerLetterChoice = 0
            letterImage = My.Resources.O
        End If

        If Not btnSlotOne.BackgroundImage Is Nothing And Not btnSlotTwo.BackgroundImage Is Nothing And Not btnSlotThree Is Nothing _
            And Not btnSlotFour.BackgroundImage Is Nothing And Not btnSlotFive.BackgroundImage Is Nothing And Not btnSlotSix.BackgroundImage Is Nothing _
            And Not btnSlotSeven.BackgroundImage Is Nothing And Not btnSlotEight.BackgroundImage Is Nothing And Not btnSlotNine.BackgroundImage Is Nothing Then

            '  tmrFindWinner.Stop()
            '  gameOver.lblWinner.Text = "It was a tie :)"
            '  gameOver.ShowDialog()
            '
        Else



            If compBox = 1 Then
                'check if box 1 is taken
                If btnSlotOne.BackgroundImage Is Nothing Then
                    btnSlotOne.BackgroundImage = letterImage
                    btnSlotOne.Enabled = False
                    btnSlotOne.Tag = "Computer"
                    undoMove(1, "Computer")
                Else
                    computerTurn()
                End If
            ElseIf compBox = 2 Then
                If btnSlotTwo.BackgroundImage Is Nothing Then
                    btnSlotTwo.BackgroundImage = letterImage
                    btnSlotTwo.Enabled = False
                    btnSlotTwo.Tag = "Computer"
                    undoMove(2, "Computer")
                Else
                    computerTurn()
                End If
            ElseIf compBox = 3 Then
                If btnSlotThree.BackgroundImage Is Nothing Then
                    btnSlotThree.BackgroundImage = letterImage
                    btnSlotThree.Enabled = False
                    btnSlotThree.Tag = "Computer"
                    undoMove(3, "Computer")
                Else
                    computerTurn()
                End If
            ElseIf compBox = 4 Then
                If btnSlotFour.BackgroundImage Is Nothing Then
                    btnSlotFour.BackgroundImage = letterImage
                    btnSlotFour.Enabled = False
                    btnSlotFour.Tag = "Computer"
                    undoMove(4, "Computer")
                Else
                    computerTurn()
                End If
            ElseIf compBox = 5 Then
                If btnSlotFive.BackgroundImage Is Nothing Then
                    btnSlotFive.BackgroundImage = letterImage
                    btnSlotFive.Enabled = False
                    btnSlotFive.Tag = "Computer"
                    undoMove(5, "Computer")
                Else
                    computerTurn()
                End If
            ElseIf compBox = 6 Then
                If btnSlotSix.BackgroundImage Is Nothing Then
                    btnSlotSix.BackgroundImage = letterImage
                    btnSlotSix.Enabled = False
                    btnSlotSix.Tag = "Computer"
                    undoMove(6, "Computer")
                Else
                    computerTurn()
                End If
            ElseIf compBox = 7 Then
                If btnSlotSeven.BackgroundImage Is Nothing Then
                    btnSlotSeven.BackgroundImage = letterImage
                    btnSlotSeven.Enabled = False
                    btnSlotSeven.Tag = "Computer"
                    undoMove(7, "Computer")
                Else
                    computerTurn()
                End If
            ElseIf compBox = 8 Then
                If btnSlotEight.BackgroundImage Is Nothing Then
                    btnSlotEight.BackgroundImage = letterImage
                    btnSlotEight.Enabled = False
                    btnSlotEight.Tag = "Computer"
                    undoMove(8, "Computer")
                Else
                    computerTurn()
                End If
            ElseIf compBox = 9 Then
                If btnSlotNine.BackgroundImage Is Nothing Then
                    btnSlotNine.BackgroundImage = letterImage
                    btnSlotNine.Enabled = False
                    btnSlotNine.Tag = "Computer"
                    undoMove(9, "Computer")
                Else
                    computerTurn()
                End If
            Else
                'Rip
            End If
        End If

    End Sub
    Sub undoMove(slot As Integer, typeOfPlayer As String)
        If typeOfPlayer = "Player" Then
            My.Settings.lastPlayerMove = slot
            Console.WriteLine("Set Player Slot as " & slot)
        ElseIf typeOfPlayer = "Computer" Then
            My.Settings.lastComputerMove = slot
            Console.WriteLine("Set Computer Slot as " & slot)
        End If
    End Sub
    Private Sub lblSinglePlayer_Click(sender As Object, e As EventArgs) Handles lblSinglePlayer.Click
        loadSinglePlayer()
        hideMainMenu()
        chooseLetter.ShowDialog()
    End Sub

    Private Sub lblHighScores_Click(sender As Object, e As EventArgs) Handles lblMultiplayer.Click
        loadMultiplayerLobby()

    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        quitGame()
    End Sub

    Private Sub btnSlotOne_Click(sender As Object, e As EventArgs) Handles btnSlotOne.Click
        If mode = 1 Then
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 0 Then
                btnSlotOne.BackgroundImage = My.Resources.O
            End If
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 1 Then
                btnSlotOne.BackgroundImage = My.Resources.X
            End If
            btnSlotOne.Enabled = False
            btnSlotOne.Tag = "Player"
            undoMove(1, "Player")
            btnUndo.Enabled = True
            computerTurn()
            tmrFindWinner.Start()
        ElseIf mode = 2 Then
            If turn = 1 Then
                btnSlotOne.BackgroundImage = My.Resources.X
                turn = 2
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Bold)
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Regular)
                btnSlotOne.Tag = "Player1"
                btnSlotOne.Enabled = False
                tmrFindWinner.Start()
            Else
                btnSlotOne.BackgroundImage = My.Resources.O
                turn = 1
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Bold)
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Regular)
                btnSlotOne.Tag = "Player2"
                btnSlotOne.Enabled = False
                tmrFindWinner.Start()
            End If
        ElseIf mode = 3 Then
            client.Send(roomPrefix & myLetter, "1")
            endTurn()
            client.Send(clientUsername, "@yourTurn")
        End If
    End Sub

    Private Sub btnSlotTwo_Click(sender As Object, e As EventArgs) Handles btnSlotTwo.Click
        If mode = 1 Then
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 0 Then
                btnSlotTwo.BackgroundImage = My.Resources.O
            End If
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 1 Then
                btnSlotTwo.BackgroundImage = My.Resources.X
            End If
            btnSlotTwo.Enabled = False
            btnSlotTwo.Tag = "Player"
            undoMove(2, "Player")
            btnUndo.Enabled = True
            computerTurn()
            tmrFindWinner.Start()
        ElseIf mode = 2 Then
            If turn = 1 Then
                btnSlotTwo.BackgroundImage = My.Resources.X
                turn = 2
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Bold)
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Regular)
                btnSlotTwo.Tag = "Player1"
                btnSlotTwo.Enabled = False
                tmrFindWinner.Start()
            Else
                btnSlotTwo.BackgroundImage = My.Resources.O
                turn = 1
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Bold)
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Regular)
                btnSlotTwo.Tag = "Player2"
                btnSlotTwo.Enabled = False
                tmrFindWinner.Start()
            End If
        ElseIf mode = 3 Then
            client.Send(roomPrefix & myLetter, "2")
            endTurn()
            client.Send(clientUsername, "@yourTurn")
        End If
    End Sub

    Private Sub btnSlotThree_Click(sender As Object, e As EventArgs) Handles btnSlotThree.Click
        If mode = 1 Then
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 0 Then
                btnSlotThree.BackgroundImage = My.Resources.O
            End If
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 1 Then
                btnSlotThree.BackgroundImage = My.Resources.X
            End If
            btnSlotThree.Enabled = False
            btnSlotThree.Tag = "Player"
            undoMove(3, "Player")
            btnUndo.Enabled = True
            computerTurn()
            tmrFindWinner.Start()
        ElseIf mode = 2 Then
            If turn = 1 Then
                btnSlotThree.BackgroundImage = My.Resources.X
                turn = 2
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Bold)
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Regular)
                btnSlotThree.Tag = "Player1"
                btnSlotThree.Enabled = False
                tmrFindWinner.Start()
            Else
                btnSlotThree.BackgroundImage = My.Resources.O
                turn = 1
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Bold)
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Regular)
                btnSlotThree.Tag = "Player2"
                btnSlotThree.Enabled = False
                tmrFindWinner.Start()
            End If
        ElseIf mode = 3 Then
            client.Send(roomPrefix & myLetter, "3")
            endTurn()
            client.Send(clientUsername, "@yourTurn")
        End If
    End Sub

    Private Sub btnSlotFour_Click(sender As Object, e As EventArgs) Handles btnSlotFour.Click
        If mode = 1 Then
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 0 Then
                btnSlotFour.BackgroundImage = My.Resources.O
            End If
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 1 Then
                btnSlotFour.BackgroundImage = My.Resources.X
            End If
            btnSlotFour.Enabled = False
            btnSlotFour.Tag = "Player"
            undoMove(4, "Player")
            btnUndo.Enabled = True
            computerTurn()
            tmrFindWinner.Start()
        ElseIf mode = 2 Then
            If turn = 1 Then
                btnSlotFour.BackgroundImage = My.Resources.X
                turn = 2
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Bold)
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Regular)
                btnSlotFour.Tag = "Player1"
                btnSlotFour.Enabled = False
                tmrFindWinner.Start()
            Else
                btnSlotFour.BackgroundImage = My.Resources.O
                turn = 1
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Bold)
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Regular)
                btnSlotFour.Tag = "Player2"
                btnSlotFour.Enabled = False
                tmrFindWinner.Start()
            End If
        ElseIf mode = 3 Then
            client.Send(roomPrefix & myLetter, "4")
            endTurn()
            client.Send(clientUsername, "@yourTurn")
        End If
    End Sub

    Private Sub btnSlotFive_Click(sender As Object, e As EventArgs) Handles btnSlotFive.Click
        If mode = 1 Then
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 0 Then
                btnSlotFive.BackgroundImage = My.Resources.O
            End If
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 1 Then
                btnSlotFive.BackgroundImage = My.Resources.X
            End If
            btnSlotFive.Enabled = False
            btnSlotFive.Tag = "Player"
            undoMove(5, "Player")
            btnUndo.Enabled = True
            computerTurn()
            tmrFindWinner.Start()
        ElseIf mode = 2 Then
            If turn = 1 Then
                btnSlotFive.BackgroundImage = My.Resources.X
                turn = 2
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Bold)
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Regular)
                btnSlotFive.Tag = "Player1"
                btnSlotFive.Enabled = False
                tmrFindWinner.Start()
            Else
                btnSlotFive.BackgroundImage = My.Resources.O
                turn = 1
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Bold)
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Regular)
                btnSlotFive.Tag = "Player2"
                btnSlotFive.Enabled = False
                tmrFindWinner.Start()
            End If
        ElseIf mode = 3 Then
            client.Send(roomPrefix & myLetter, "5")
            endTurn()
            client.Send(clientUsername, "@yourTurn")
        End If
    End Sub

    Private Sub btnSlotSix_Click(sender As Object, e As EventArgs) Handles btnSlotSix.Click
        If mode = 1 Then
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 0 Then
                btnSlotSix.BackgroundImage = My.Resources.O
            End If
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 1 Then
                btnSlotSix.BackgroundImage = My.Resources.X
            End If
            btnSlotSix.Enabled = False
            btnSlotSix.Tag = "Player"
            undoMove(6, "Player")
            btnUndo.Enabled = True
            computerTurn()
            tmrFindWinner.Start()
        ElseIf mode = 2 Then
            If turn = 1 Then
                btnSlotSix.BackgroundImage = My.Resources.X
                turn = 2
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Bold)
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Regular)
                btnSlotSix.Tag = "Player1"
                btnSlotSix.Enabled = False
                tmrFindWinner.Start()
            Else
                btnSlotSix.BackgroundImage = My.Resources.O
                turn = 1
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Bold)
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Regular)
                btnSlotSix.Tag = "Player2"
                btnSlotSix.Enabled = False
                tmrFindWinner.Start()
            End If
        ElseIf mode = 3 Then
            client.Send(roomPrefix & myLetter, "6")
            endTurn()
            client.Send(clientUsername, "@yourTurn")
        End If
    End Sub

    Private Sub btnSlotSeven_Click(sender As Object, e As EventArgs) Handles btnSlotSeven.Click
        If mode = 1 Then
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 0 Then
                btnSlotSeven.BackgroundImage = My.Resources.O
            End If
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 1 Then
                btnSlotSeven.BackgroundImage = My.Resources.X
            End If
            btnSlotSeven.Enabled = False
            btnSlotSeven.Tag = "Player"
            undoMove(7, "Player")
            btnUndo.Enabled = True
            computerTurn()
            tmrFindWinner.Start()
        ElseIf mode = 2 Then
            If turn = 1 Then
                btnSlotSeven.BackgroundImage = My.Resources.X
                turn = 2
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Bold)
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Regular)
                btnSlotSeven.Tag = "Player1"
                btnSlotSeven.Enabled = False
                tmrFindWinner.Start()
            Else
                btnSlotSeven.BackgroundImage = My.Resources.O
                turn = 1
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Bold)
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Regular)
                btnSlotSeven.Tag = "Player2"
                btnSlotSeven.Enabled = False
                tmrFindWinner.Start()
            End If
        ElseIf mode = 3 Then
            client.Send(roomPrefix & myLetter, "7")
            endTurn()
            client.Send(clientUsername, "@yourTurn")
        End If
    End Sub

    Private Sub btnSlotEight_Click(sender As Object, e As EventArgs) Handles btnSlotEight.Click
        If mode = 1 Then
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 0 Then
                btnSlotEight.BackgroundImage = My.Resources.O
            End If
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 1 Then
                btnSlotEight.BackgroundImage = My.Resources.X
            End If
            btnSlotEight.Enabled = False
            btnSlotEight.Tag = "Player"
            undoMove(8, "Player")
            btnUndo.Enabled = True
            computerTurn()
            tmrFindWinner.Start()
        ElseIf mode = 2 Then
            If turn = 1 Then
                btnSlotEight.BackgroundImage = My.Resources.X
                turn = 2
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Bold)
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Regular)
                btnSlotEight.Tag = "Player1"
                btnSlotEight.Enabled = False
                tmrFindWinner.Start()
            Else
                btnSlotEight.BackgroundImage = My.Resources.O
                turn = 1
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Bold)
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Regular)
                btnSlotEight.Tag = "Player2"
                btnSlotEight.Enabled = False
                tmrFindWinner.Start()
            End If
        ElseIf mode = 3 Then
            client.Send(roomPrefix & myLetter, "8")
            endTurn()
            client.Send(clientUsername, "@yourTurn")
        End If
    End Sub

    Private Sub btnSlotNine_Click(sender As Object, e As EventArgs) Handles btnSlotNine.Click
        If mode = 1 Then
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 0 Then
                btnSlotNine.BackgroundImage = My.Resources.O
            End If
            If singlePlayerTurn = 0 And My.Settings.spLetterChoice = 1 Then
                btnSlotNine.BackgroundImage = My.Resources.X
            End If
            btnSlotNine.Enabled = False
            btnSlotNine.Tag = "Player"
            undoMove(9, "Player")
            btnUndo.Enabled = True
            computerTurn()
            tmrFindWinner.Start()
        ElseIf mode = 2 Then
            If turn = 1 Then
                btnSlotNine.BackgroundImage = My.Resources.X
                turn = 2
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Bold)
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Regular)
                btnSlotNine.Tag = "Player1"
                btnSlotNine.Enabled = False
                tmrFindWinner.Start()
            Else
                btnSlotNine.BackgroundImage = My.Resources.O
                turn = 1
                lblPlayerX.Font = New Font(lblPlayerX.Font, FontStyle.Bold)
                lblPlayerO.Font = New Font(lblPlayerO.Font, FontStyle.Regular)
                btnSlotNine.Tag = "Player2"
                btnSlotNine.Enabled = False
                tmrFindWinner.Start()
            End If
        ElseIf mode = 3 Then
            client.Send(roomPrefix & myLetter, "9")
            endTurn()
            client.Send(clientUsername, "@yourTurn")
        End If
    End Sub

    Private Sub tmrFindWinner_Tick(sender As Object, e As EventArgs) Handles tmrFindWinner.Tick

        If mode = 1 Then

            Dim letterChoice As Integer '0 = O and 1 = X
            If My.Settings.spLetterChoice = 0 Then
                lblPlayerO.Text = "You"
                letterChoice = 0
                lblPlayerX.Text = "Computer"
            ElseIf My.Settings.spLetterChoice = 1 Then
                lblPlayerX.Text = "You"
                letterChoice = 1
                lblPlayerO.Text = "Computer"
            Else
                lblPlayerO.Text = ""
                lblPlayerX.Text = ""
            End If

            lblXWins.Text = xWins
            lblOWins.Text = oWins

            If btnSlotOne.Tag = "Player" And btnSlotTwo.Tag = "Player" And btnSlotThree.Tag = "Player" Then
                If letterChoice = 0 Then
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                Else
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "You Win!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotFour.Tag = "Player" And btnSlotFive.Tag = "Player" And btnSlotSix.Tag = "Player" Then
                If letterChoice = 0 Then
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                Else
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "You Win!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotSeven.Tag = "Player" And btnSlotEight.Tag = "Player" And btnSlotNine.Tag = "Player" Then
                If letterChoice = 0 Then
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                Else
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "You Win!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotOne.Tag = "Player" And btnSlotFour.Tag = "Player" And btnSlotSeven.Tag = "Player" Then
                If letterChoice = 0 Then
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                Else
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "You Win!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotTwo.Tag = "Player" And btnSlotFive.Tag = "Player" And btnSlotEight.Tag = "Player" Then
                If letterChoice = 0 Then
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                Else
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "You Win!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotThree.Tag = "Player" And btnSlotSix.Tag = "Player" And btnSlotNine.Tag = "Player" Then
                If letterChoice = 0 Then
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                Else
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "You Win!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotThree.Tag = "Player" And btnSlotFive.Tag = "Player" And btnSlotSeven.Tag = "Player" Then
                If letterChoice = 0 Then
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                Else
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "You Win!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotOne.Tag = "Player" And btnSlotFive.Tag = "Player" And btnSlotNine.Tag = "Player" Then
                If letterChoice = 0 Then
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                Else
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "You Win!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotOne.Tag = "Computer" And btnSlotTwo.Tag = "Computer" And btnSlotThree.Tag = "Computer" Then
                If letterChoice = 0 Then
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                Else
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "Computer Wins!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotFour.Tag = "Computer" And btnSlotFive.Tag = "Computer" And btnSlotSix.Tag = "Computer" Then
                If letterChoice = 0 Then
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                Else
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "Computer Wins!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotSeven.Tag = "Computer" And btnSlotEight.Tag = "Computer" And btnSlotNine.Tag = "Computer" Then

                If letterChoice = 0 Then
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                    Console.WriteLine("Stopped")
                Else
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "Computer Wins!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotOne.Tag = "Computer" And btnSlotFour.Tag = "Computer" And btnSlotSeven.Tag = "Computer" Then
                If letterChoice = 0 Then
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                Else
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "Computer Wins!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotTwo.Tag = "Computer" And btnSlotFive.Tag = "Computer" And btnSlotEight.Tag = "Computer" Then
                If letterChoice = 0 Then
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                Else
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "Computer Wins!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotThree.Tag = "Computer" And btnSlotSix.Tag = "Computer" And btnSlotNine.Tag = "Computer" Then
                If letterChoice = 0 Then
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                Else
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "Computer Wins!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotThree.Tag = "Computer" And btnSlotFive.Tag = "Computer" And btnSlotSeven.Tag = "Computer" Then
                If letterChoice = 0 Then
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                Else
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "Computer Wins!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotOne.Tag = "Computer" And btnSlotFive.Tag = "Computer" And btnSlotNine.Tag = "Computer" Then
                If letterChoice = 0 Then
                    xWins += 1
                    lblXWins.Text = xWins
                    tmrFindWinner.Stop()
                Else
                    oWins += 1
                    lblOWins.Text = oWins
                    tmrFindWinner.Stop()
                End If
                gameOver.lblWinner.Text = "Computer Wins!"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf Not btnSlotOne.BackgroundImage Is Nothing And Not btnSlotTwo.BackgroundImage Is Nothing And Not btnSlotThree Is Nothing _
                And Not btnSlotFour.BackgroundImage Is Nothing And Not btnSlotFive.BackgroundImage Is Nothing And Not btnSlotSix.BackgroundImage Is Nothing _
                And Not btnSlotSeven.BackgroundImage Is Nothing And Not btnSlotEight.BackgroundImage Is Nothing And Not btnSlotNine.BackgroundImage Is Nothing Then

                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = "It was a tie :)"
                gameOver.ShowDialog()
            End If

            'testVar += 1
            'Console.WriteLine(testVar)
        ElseIf mode = 2 Then
            lblXWins.Text = xWins
            lblOWins.Text = oWins

            If btnSlotOne.Tag = "Player1" And btnSlotTwo.Tag = "Player1" And btnSlotThree.Tag = "Player1" Then
                xWins += 1
                lblXWins.Text = xWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerOne & "(X) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotFour.Tag = "Player1" And btnSlotFive.Tag = "Player1" And btnSlotSix.Tag = "Player1" Then
                xWins += 1
                lblXWins.Text = xWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerOne & "(X) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotSeven.Tag = "Player1" And btnSlotEight.Tag = "Player1" And btnSlotNine.Tag = "Player1" Then
                xWins += 1
                lblXWins.Text = xWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerOne & "(X) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotOne.Tag = "Player1" And btnSlotFour.Tag = "Player1" And btnSlotSeven.Tag = "Player1" Then
                xWins += 1
                lblXWins.Text = xWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerOne & "(X) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotTwo.Tag = "Player1" And btnSlotFive.Tag = "Player1" And btnSlotEight.Tag = "Player1" Then
                xWins += 1
                lblXWins.Text = xWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerOne & "(X) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotThree.Tag = "Player1" And btnSlotSix.Tag = "Player1" And btnSlotNine.Tag = "Player1" Then
                xWins += 1
                lblXWins.Text = xWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerOne & "(X) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotThree.Tag = "Player1" And btnSlotFive.Tag = "Player1" And btnSlotSeven.Tag = "Player1" Then
                xWins += 1
                lblXWins.Text = xWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerOne & "(X) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotOne.Tag = "Player1" And btnSlotFive.Tag = "Player1" And btnSlotNine.Tag = "Player1" Then
                xWins += 1
                lblXWins.Text = xWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerOne & "(X) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotOne.Tag = "Player2" And btnSlotTwo.Tag = "Player2" And btnSlotThree.Tag = "Player2" Then
                oWins += 1
                lblOWins.Text = oWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerTwo & "(O) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotFour.Tag = "Player2" And btnSlotFive.Tag = "Player2" And btnSlotSix.Tag = "Player2" Then
                oWins += 1
                lblOWins.Text = oWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerTwo & "(O) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotSeven.Tag = "Player2" And btnSlotEight.Tag = "Player2" And btnSlotNine.Tag = "Player2" Then
                oWins += 1
                lblOWins.Text = oWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerTwo & "(O) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotOne.Tag = "Player2" And btnSlotFour.Tag = "Player2" And btnSlotSeven.Tag = "Player2" Then
                oWins += 1
                lblOWins.Text = oWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerTwo & "(O) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotTwo.Tag = "Player2" And btnSlotFive.Tag = "Player2" And btnSlotEight.Tag = "Player2" Then
                oWins += 1
                lblOWins.Text = oWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerTwo & "(O) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotThree.Tag = "Player2" And btnSlotSix.Tag = "Player2" And btnSlotNine.Tag = "Player2" Then
                oWins += 1
                lblOWins.Text = oWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerTwo & "(O) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotThree.Tag = "Player2" And btnSlotFive.Tag = "Player2" And btnSlotSeven.Tag = "Player2" Then
                oWins += 1
                lblOWins.Text = oWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerTwo & "(O) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf btnSlotOne.Tag = "Player2" And btnSlotFive.Tag = "Player2" And btnSlotNine.Tag = "Player2" Then
                oWins += 1
                lblOWins.Text = oWins
                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = playerTwo & "(O) Wins"
                gameOver.ShowDialog()
                tmrFindWinner.Stop()
                Console.WriteLine("Stopped")
            ElseIf Not btnSlotOne.BackgroundImage Is Nothing And Not btnSlotTwo.BackgroundImage Is Nothing And Not btnSlotThree Is Nothing _
                And Not btnSlotFour.BackgroundImage Is Nothing And Not btnSlotFive.BackgroundImage Is Nothing And Not btnSlotSix.BackgroundImage Is Nothing _
                And Not btnSlotSeven.BackgroundImage Is Nothing And Not btnSlotEight.BackgroundImage Is Nothing And Not btnSlotNine.BackgroundImage Is Nothing Then

                tmrFindWinner.Stop()
                gameOver.lblWinner.Text = "It was a tie :)"
                gameOver.ShowDialog()
            End If
        ElseIf mode = 3 Then

        End If

    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        If mode = 1 Then
            If My.Settings.lastPlayerMove = 1 Then
                btnSlotOne.BackgroundImage = Nothing
                btnSlotOne.Tag = ""
                btnSlotOne.Enabled = True
            ElseIf My.Settings.lastPlayerMove = 2 Then
                btnSlotTwo.BackgroundImage = Nothing
                btnSlotTwo.Tag = ""
                btnSlotTwo.Enabled = True
            ElseIf My.Settings.lastPlayerMove = 3 Then
                btnSlotThree.BackgroundImage = Nothing
                btnSlotThree.Tag = ""
                btnSlotThree.Enabled = True
            ElseIf My.Settings.lastPlayerMove = 4 Then
                btnSlotFour.BackgroundImage = Nothing
                btnSlotFour.Tag = ""
                btnSlotFour.Enabled = True
            ElseIf My.Settings.lastPlayerMove = 5 Then
                btnSlotFive.BackgroundImage = Nothing
                btnSlotFive.Tag = ""
                btnSlotFive.Enabled = True
            ElseIf My.Settings.lastPlayerMove = 6 Then
                btnSlotSix.BackgroundImage = Nothing
                btnSlotSix.Tag = ""
                btnSlotSix.Enabled = True
            ElseIf My.Settings.lastPlayerMove = 7 Then
                btnSlotSeven.BackgroundImage = Nothing
                btnSlotSeven.Tag = ""
                btnSlotSeven.Enabled = True
            ElseIf My.Settings.lastPlayerMove = 8 Then
                btnSlotEight.BackgroundImage = Nothing
                btnSlotEight.Tag = ""
                btnSlotEight.Enabled = True
            ElseIf My.Settings.lastPlayerMove = 9 Then
                btnSlotNine.BackgroundImage = Nothing
                btnSlotNine.Tag = ""
                btnSlotNine.Enabled = True
            End If

            '  MsgBox("Player: " & My.Settings.lastPlayerMove & ", Comp: " & My.Settings.lastComputerMove)

            If My.Settings.lastComputerMove = 1 Then
                btnSlotOne.BackgroundImage = Nothing
                btnSlotOne.Tag = ""
                btnSlotOne.Enabled = True
            ElseIf My.Settings.lastComputerMove = 2 Then
                btnSlotTwo.BackgroundImage = Nothing
                btnSlotTwo.Tag = ""
                btnSlotTwo.Enabled = True
            ElseIf My.Settings.lastComputerMove = 3 Then
                btnSlotThree.BackgroundImage = Nothing
                btnSlotThree.Tag = ""
                btnSlotThree.Enabled = True
            ElseIf My.Settings.lastComputerMove = 4 Then
                btnSlotFour.BackgroundImage = Nothing
                btnSlotFour.Tag = ""
                btnSlotFour.Enabled = True
            ElseIf My.Settings.lastComputerMove = 5 Then
                btnSlotFive.BackgroundImage = Nothing
                btnSlotFive.Tag = ""
                btnSlotFive.Enabled = True
            ElseIf My.Settings.lastComputerMove = 6 Then
                btnSlotSix.BackgroundImage = Nothing
                btnSlotSix.Tag = ""
                btnSlotSix.Enabled = True
            ElseIf My.Settings.lastComputerMove = 7 Then
                btnSlotSeven.BackgroundImage = Nothing
                btnSlotSeven.Tag = ""
                btnSlotSeven.Enabled = True
            ElseIf My.Settings.lastComputerMove = 8 Then
                btnSlotEight.BackgroundImage = Nothing
                btnSlotEight.Tag = ""
                btnSlotEight.Enabled = True
            ElseIf My.Settings.lastComputerMove = 9 Then
                btnSlotNine.BackgroundImage = Nothing
                btnSlotNine.Tag = ""
                btnSlotNine.Enabled = True
            End If
            btnUndo.Enabled = False
        ElseIf mode = 2 Then
            If turn = 1 Then
                message.lblMsg.Text = "It Is Currently Player1's Turn(X)"
                message.ShowDialog()
            Else
                message.lblMsg.Text = "It Is Currently Player2's Turn(O)"
                message.ShowDialog()
            End If
        ElseIf mode = 3 Then
        End If
    End Sub

    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click
        Randomize()
        Dim x As Integer = rand.Next(1, 4)

        Select Case x
            Case 1
                picLogo.Image = My.Resources.TTTOne
            ' Me.BackColor = Color.Orange
            ' Me.ForeColor = Color.LightBlue
            ' lblDash1.BackColor = Color.Black
            ' lblDash2.BackColor = Color.Black
            ' '' lblXWins.BackColor = Color.Black
            '  lblOWins.BackColor = Color.Black
            Case 2
                picLogo.Image = My.Resources.TTTTwo
            ' Me.BackColor = Color.Gray
            '' Me.BackColor = Color.White
            'lblDash1.BackColor = Color.Black
            'lblDash2.BackColor = Color.Black
            'lblXWins.BackColor = Color.Black
            'lblOWins.BackColor = Color.Black
            Case 3
                picLogo.Image = My.Resources.TTTThree
                ' Me.BackColor = Color.Lime
                'Me.ForeColor = Color.Red
                'lblDash1.BackColor = Color.Black
                'lblDash2.BackColor = Color.Black
                'lblXWins.BackColor = Color.Black
                'lblOWins.BackColor = Color.Black
        End Select

    End Sub

    Private Sub lblOptions_Click(sender As Object, e As EventArgs) Handles lblOptions.Click
        loadGameOptions()
    End Sub

    Private Sub lblTwoPlayer_Click(sender As Object, e As EventArgs) Handles lblTwoPlayer.Click
        ' Double Player
        loadTwoPlayer()
        hideMainMenu()
    End Sub

    Private Sub lblPlayerX_Click(sender As Object, e As EventArgs) Handles lblPlayerX.Click
        If mode = 2 Then
            lblPlayerX.Visible = False
            txtX.Visible = True
            txtX.Text = lblPlayerX.Text
            txtX.SelectAll()
            txtX.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtX_KeyDown(sender As Object, e As KeyEventArgs) Handles txtX.KeyDown
        If e.KeyCode = Keys.Enter Then
            lblPlayerX.Text = txtX.Text
            lblPlayerX.Visible = True
            txtX.Visible = False
            playerOne = txtX.Text
        End If
    End Sub

    Private Sub lblPlayerO_Click(sender As Object, e As EventArgs) Handles lblPlayerO.Click
        If mode = 2 Then
            lblPlayerO.Visible = False
            txtO.Visible = True
            txtO.Text = lblPlayerO.Text
            txtO.SelectAll()
            txtO.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtO.KeyDown
        If e.KeyCode = Keys.Enter Then
            lblPlayerO.Text = txtO.Text
            lblPlayerO.Visible = True
            txtO.Visible = False
            playerTwo = txtO.Text
        End If
    End Sub
    Private Sub client_OnReceived(sender As Object, e As NetReceivedEventArgs(Of NetObject))
        'Label1.Text = "Client received - Name: " + e.Data + " Message: "

        If e.Data.Object.ToString.StartsWith("[@clients]") Then
            Dim clients As String() = e.Data.Object.ToString.Substring(e.Data.Object.ToString.IndexOf("[@clients]") + 10).Split(",")
            'If clients.Count > 1 Then
            lstClients.Items.Clear()
            'Else
            ' If lstClients.Items(0).ToString = Nothing Or lstClients.Items(0).ToString = "" Then
            'lstClients.Items.Add("It's a little lonely in here...")
            'lstClients.Items.Add("Waiting for a user to connect.")
            'End If
            'End If

            lstClients.Enabled = True
                For Each client As String In clients
                    If String.IsNullOrWhiteSpace(client) = False And Not client = clientUsername Then
                        lstClients.Items.Add(client)
                    End If
                Next
            ElseIf e.Data.Object.ToString.StartsWith("[@rooms]") Then
                Dim rooms As String() = e.Data.Object.ToString.Substring(e.Data.Object.ToString.IndexOf("@[rooms]") + 9).Split(",")
                lstRooms.Items.Clear()
                For Each room As String In rooms
                    If String.IsNullOrWhiteSpace(room) = False Then
                        lstRooms.Items.Add(room)
                    End If
                Next
                lstRooms.SetSelected(0, True)
            ElseIf e.Data.Object.ToString.StartsWith("[@invite]") Then
                Dim ToUser As String = e.Data.Object.ToString.Substring(e.Data.Object.ToString.IndexOf("[@invite]") + 12)
                Dim fromUser As String = e.Data.Name.ToString
                'MsgBox(ToUser)

                If clientUsername = ToUser Then
                Dim response = MsgBox(fromUser & " has invited you to a game. Accept?", MsgBoxStyle.YesNo, "Invitation from " & fromUser)
                If response = MsgBoxResult.Yes Then
                        client.Send(clientUsername, "[@acceptInvite]To=" & e.Data.Name.ToString)
                    MsgBox("Invitation Accepted. Game will start soon", MsgBoxStyle.Exclamation, "Accepted")
                    'loadTwoPlayer()
                    hideMultiplayerLobby()
                    loadMultiplayer()
                Else
                        client.Send(clientUsername, "[@declineInvite]To=" & e.Data.Name.ToString)
                    End If

                End If
            ElseIf e.Data.Object.ToString.StartsWith("[@acceptInvite]") Then
                Dim invitationSender As String = e.Data.Object.ToString.Substring(e.Data.Object.ToString.IndexOf("[@acceptInvite]") + 18)
                Dim invitedUser As String = e.Data.Name.ToString
                'MsgBox(invitationSender)
                If invitationSender = clientUsername Then
                MsgBox(invitedUser & " has accepted. Game will start soon", MsgBoxStyle.Exclamation, "Accepted")
                ' loadTwoPlayer()
                hideMultiplayerLobby()
                loadMultiplayer()
                lblOpponent.Text = invitedUser
                opponentName = invitedUser
                    lblClient.Text = "You(" & clientUsername & ")"
                    client.Send(clientUsername, "@createRoom=" & clientUsername & "xxx" & e.Data.Name.ToString)
                    roomPrefix = "[" & clientUsername & "xxx" & e.Data.Name.ToString & "]"

                    Dim letterChooser As Integer = randomNum(1, 100)
                    If letterChooser <= 50 Then '0 = O, 1=X
                    'Owner gets letter O, Opponent gets X
                    'btnClientLetter.Text = "O"
                    'btnOpponentLetter.Text = "X"
                    lblPlayerO.Text = clientUsername
                    lblPlayerX.Text = opponentName
                    myLetter = "O"
                    client.Send(clientUsername, "@OpponentLetter=X")
                Else
                    'Owner gets letter X, Opponent gets O
                    'btnClientLetter.Text = "X"
                    'btnOpponentLetter.Text = "O"
                    lblPlayerX.Text = clientUsername
                    lblPlayerO.Text = opponentName
                    myLetter = "X"
                    client.Send(clientUsername, "@OpponentLetter=O")
                    End If


                    ' While True
                    'Dim indexOfRoomName As Integer = lstRooms.FindString(invitationSender & "xxx" & clientusername)
                    '    If Not indexOfRoomName = -1 Then
                    '        lstRooms.SetSelected(indexOfRoomName, True)
                    '    '    Exit While
                    'End If
                    ' End While
                Else
                    lblOpponent.Text = invitationSender
                    opponentName = invitationSender
                    lblClient.Text = "You(" & clientUsername & ")"
                    roomPrefix = "[" & invitationSender & "xxx" & clientUsername & "]"
                    ' While True
                    'Dim indexOfRoomName As Integer = lstRooms.FindString(invitationSender & "xxx" & clientusername)
                    '    If Not indexOfRoomName = -1 Then
                    '        lstRooms.SetSelected(indexOfRoomName, True)
                    '    '        Exit While
                    'End If
                    '  End While
                End If
            ElseIf e.Data.Object.ToString.StartsWith("[@declineInvite]") Then
                Dim invitationSender As String = e.Data.Object.ToString.Substring(e.Data.Object.ToString.IndexOf("[@declineInvite]") + 19)
                Dim invitedUser As String = e.Data.Name.ToString
                If invitationSender = clientUsername Then
                MsgBox(invitedUser & " has declined your invite", MsgBoxStyle.Exclamation, invitedUser & " has declined")
            End If
            ElseIf e.Data.Object.ToString.StartsWith("@OpponentLetter") Then
                Dim getLetter As String = e.Data.Object.ToString.Substring(e.Data.Object.ToString.IndexOf("@OpponentLetter") + 16)
                If e.Data.Name = opponentName Then
                    myLetter = getLetter
                    btnClientLetter.Text = getLetter
                    If getLetter = "O" Then
                    'btnOpponentLetter.Text = "X"
                    lblPlayerO.Text = clientUsername
                    lblPlayerX.Text = opponentName
                Else
                    'btnOpponentLetter.Text = "O"
                    lblPlayerO.Text = opponentName
                    lblPlayerX.Text = clientUsername
                End If
                End If

            ElseIf e.Data.Object.ToString.StartsWith("@yourTurn") Then
                If Not e.Data.Name = clientUsername Then
                    resumeTurn()
                End If
                'new fork
            Else

                If Not e.Data.Object.ToString.StartsWith("@regClient") And Not e.Data.Object.ToString.StartsWith("@disconnectClient") And Not e.Data.Object.ToString.StartsWith("@createRoom") Then
                If e.Data.Name.ToString.Equals("[Server]") Then


                    rtbChatLog.Text += e.Data.Name.ToString() & ": " & e.Data.Object.ToString() & vbNewLine
                    rtbChatLog.Find(e.Data.Name.ToString() & ": " & e.Data.Object.ToString())
                    rtbChatLog.SelectionColor = Color.Red
                Else
                    ' rtbChatLog.SelectionColor = Color.Lime
                    If e.Data.Name.StartsWith(roomPrefix) Or e.Data.Name.ToString.StartsWith("Server") Then

                        Dim player As String = e.Data.Name.ToString().Replace(roomPrefix, "")
                        Dim move As String = e.Data.Object.ToString()
                        'MsgBox(player)
                        If player = "O" Then
                            If move = "1" Then
                                btnSlotOne.Text = "O"
                                btnSlotOne.Enabled = False
                            ElseIf move = "2" Then
                                btnSlotTwo.Text = "O"
                                btnSlotTwo.Enabled = False
                            ElseIf move = "3" Then
                                btnSlotThree.Text = "O"
                                btnSlotThree.Enabled = False
                            ElseIf move = "4" Then
                                btnSlotFour.Text = "O"
                                btnSlotFour.Enabled = False
                            ElseIf move = "5" Then
                                btnSlotFive.Text = "O"
                                btnSlotFive.Enabled = False
                            ElseIf move = "6" Then
                                btnSlotSix.Text = "O"
                                btnSlotSix.Enabled = False
                            ElseIf move = "7" Then
                                btnSlotSeven.Text = "O"
                                btnSlotSeven.Enabled = False
                            ElseIf move = "8" Then
                                btnSlotEight.Text = "O"
                                btnSlotEight.Enabled = False
                            ElseIf move = "9" Then
                                btnSlotNine.Text = "O"
                                btnSlotNine.Enabled = False
                            End If
                        ElseIf player = "X" Then
                            If move = "1" Then
                                btnSlotOne.Text = "X"
                                btnSlotOne.Enabled = False
                            ElseIf move = "2" Then
                                btnSlotTwo.Text = "X"
                                btnSlotTwo.Enabled = False
                            ElseIf move = "3" Then
                                btnSlotThree.Text = "X"
                                btnSlotThree.Enabled = False
                            ElseIf move = "4" Then
                                btnSlotFour.Text = "X"
                                btnSlotFour.Enabled = False
                            ElseIf move = "5" Then
                                btnSlotFive.Text = "X"
                                btnSlotFive.Enabled = False
                            ElseIf move = "6" Then
                                btnSlotSix.Text = "X"
                                btnSlotSix.Enabled = False
                            ElseIf move = "7" Then
                                btnSlotSeven.Text = "X"
                                btnSlotSeven.Enabled = False
                            ElseIf move = "8" Then
                                btnSlotEight.Text = "X"
                                btnSlotEight.Enabled = False
                            ElseIf move = "9" Then
                                btnSlotNine.Text = "X"
                                btnSlotNine.Enabled = False
                            End If
                        Else
                            rtbChatLog.Text += e.Data.Name.ToString().Replace(roomPrefix, "") & ": " & e.Data.Object.ToString() & vbNewLine
                            rtbChatLog.Find(e.Data.Name.ToString().Replace(roomPrefix, "") & ": " & e.Data.Object.ToString())
                            rtbChatLog.SelectionColor = Color.Red
                        End If

                    End If
                End If
            End If


        End If
    End Sub

    Private Sub client_OnDisconnected(sender As Object, e As NetDisconnectedEventArgs)
        lblConnectionStatus.Text = "Disconnected from Server"
    End Sub

    Private Sub client_OnConnected(sender As Object, e As NetConnectedEventArgs)
        lblConnectionStatus.Text = "Connected to Server"
        '   System.Threading.Thread.Sleep(1000)
        '  client.Send(clientusername, "@regClient")
        ' btnRegClient.PerformClick()
        'client.Send("#infoSetter", "@regClient")
    End Sub

    Private Sub tmrRegClient_Tick(sender As Object, e As EventArgs) Handles tmrRegClient.Tick
        If client.IsConnected = True Then
            registerClientCounter += 1
            If registerClientCounter = 5 Then
                client.Send(clientUsername, "@regClient")
                lblConnectionStatus.Text += " as " & clientUsername
                registerClientCounter = 0
                tmrRegClient.Stop()
            End If
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If client.IsConnected = True Then
            client.Send(clientUsername, "@disconnectClient")
            client.Disconnect()
            Application.Exit()
        End If

        'Create Room
        'If Not lstRooms.Items.Contains(txtRoomName.Text) And String.IsNullOrWhiteSpace(txtRoomName.Text) = False Then
        '    client.Send(txtUsername.Text, "@createRoom=" & txtRoomName.Text)
        '    txtRoomName.Text = Nothing
        'Else
        '    txtRoomName.Text = Nothing
        '    MsgBox("Invalid Name. Please check if room already exists.")
        'End If

    End Sub
    Private Sub rtbChatLog_TextChanged(sender As Object, e As EventArgs) Handles rtbChatLog.TextChanged
        rtbChatLog.SelectionStart = rtbChatLog.Text.Length
        rtbChatLog.ScrollToCaret()
    End Sub
    Private Sub lstClients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClients.SelectedIndexChanged

        If lstClients.Items(0).ToString = Nothing Then
            lstClients.Items.Add("It's a little lonely in here...")
            lstClients.Items.Add("Waiting for a user to connect.")
        End If

        If Not lstClients.SelectedItem = Nothing And Not lstClients.SelectedItem = clientUsername Then
            If Not lstClients.SelectedItem.ToString = "It's a little lonely in here..." And Not lstClients.SelectedItem.ToString = "Waiting for a user to connect." Then
                client.Send(clientUsername, "[@invite]To=" & lstClients.SelectedItem.ToString)
                tmrStopInviteSpam.Start()
                lstClients.Enabled = False
                MsgBox("Invite Sent To " & lstClients.SelectedItem.ToString)
            Else
                lstClients.ClearSelected()
            End If
        Else
            ' If Not lstClients.SelectedItem.ToString = "It's a little lonely in here..." And Not lstClients.SelectedItem.ToString = "Waiting for a user to connect." Then
            MsgBox("Error Occured. To invite someone click on there name.", MsgBoxStyle.Information, "Error")
            ' End If
        End If
    End Sub

    Private Sub tmrStopInviteSpam_Tick(sender As Object, e As EventArgs) Handles tmrStopInviteSpam.Tick
        inviteSpamNum += 1
        If inviteSpamNum = 3 Then
            lstClients.Enabled = True
            inviteSpamNum = 0
            tmrStopInviteSpam.Stop()
        End If
    End Sub
    Private Sub txtMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMessage.KeyDown
        If Not txtMessage.Text = Nothing Then
            If e.KeyCode = Keys.Enter Then
                client.Send(roomPrefix & clientUsername, txtMessage.Text)
                txtMessage.Text = Nothing
            End If
        End If
    End Sub

    Private Sub btnClientLetter_Click(sender As Object, e As EventArgs) Handles btnClientLetter.Click
        lstClients.Items.Add("s")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'pnlMultiplayerLobby.Visible = False
        client.Send(clientUsername, "@disconnectClient")
        client.Disconnect()
        txtMessage.Text = ""
        rtbChatLog.Text = ""
        lstClients.Items.Clear()
        lstClients.Items.Add("It's a little lonely in here...")
        lstClients.Items.Add("Waiting for a user to connect.")
        lstClients.Enabled = False
        loadMainMenu()
    End Sub

    Private Sub bw_Help_DoWork_1(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_Help.DoWork
        picBoard.Visible = True
        btnSlotOne.Visible = True
        btnSlotTwo.Visible = True
        btnSlotThree.Visible = True
        btnSlotFour.Visible = True
        btnSlotFive.Visible = True
        btnSlotSix.Visible = True
        btnSlotSeven.Visible = True
        btnSlotEight.Visible = True
        btnSlotNine.Visible = True
        picBox.Visible = True
        lblDash1.Visible = True
        lblDash2.Visible = True
        picX.Visible = True
        picO.Visible = True
        lblOWins.Visible = True
        lblXWins.Visible = True
        'btnUndo.Visible = True
        btnQuit.Visible = True
        lblPlayerO.Visible = True
        lblPlayerX.Visible = True
        xWins = 0
        oWins = 0
        lblXWins.Text = "0"
        lblOWins.Text = "0"
        'btnUndo.Enabled = False
        mode = 3
        'lblPlayerO.Visible = True
    End Sub
End Class
