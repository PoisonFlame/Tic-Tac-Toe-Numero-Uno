<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSinglePlayer = New System.Windows.Forms.Label()
        Me.lblMultiplayer = New System.Windows.Forms.Label()
        Me.lblTwoPlayer = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.btnSlotOne = New System.Windows.Forms.Button()
        Me.btnSlotTwo = New System.Windows.Forms.Button()
        Me.btnSlotThree = New System.Windows.Forms.Button()
        Me.btnSlotFour = New System.Windows.Forms.Button()
        Me.btnSlotFive = New System.Windows.Forms.Button()
        Me.btnSlotSix = New System.Windows.Forms.Button()
        Me.btnSlotSeven = New System.Windows.Forms.Button()
        Me.btnSlotEight = New System.Windows.Forms.Button()
        Me.btnSlotNine = New System.Windows.Forms.Button()
        Me.lblDash1 = New System.Windows.Forms.Label()
        Me.lblDash2 = New System.Windows.Forms.Label()
        Me.lblXWins = New System.Windows.Forms.Label()
        Me.lblOWins = New System.Windows.Forms.Label()
        Me.tmrFindWinner = New System.Windows.Forms.Timer(Me.components)
        Me.lblPlayerX = New System.Windows.Forms.Label()
        Me.lblPlayerO = New System.Windows.Forms.Label()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.picO = New System.Windows.Forms.PictureBox()
        Me.picX = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.picBoard = New System.Windows.Forms.PictureBox()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtO = New System.Windows.Forms.TextBox()
        Me.tmrRegClient = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStopInviteSpam = New System.Windows.Forms.Timer(Me.components)
        Me.bw_Help = New System.ComponentModel.BackgroundWorker()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.stsStatus = New System.Windows.Forms.StatusStrip()
        Me.lblConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnClientLetter = New System.Windows.Forms.Button()
        Me.btnOpponentLetter = New System.Windows.Forms.Button()
        Me.lblOpponent = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.rtbChatLog = New System.Windows.Forms.RichTextBox()
        Me.lstClients = New System.Windows.Forms.ListBox()
        Me.lstRooms = New System.Windows.Forms.ListBox()
        CType(Me.picO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stsStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(2, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(285, 39)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "TIC TAC TOE"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitle.Visible = False
        '
        'lblSinglePlayer
        '
        Me.lblSinglePlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinglePlayer.Location = New System.Drawing.Point(1, 260)
        Me.lblSinglePlayer.Name = "lblSinglePlayer"
        Me.lblSinglePlayer.Size = New System.Drawing.Size(285, 39)
        Me.lblSinglePlayer.TabIndex = 0
        Me.lblSinglePlayer.Text = "Single Player"
        Me.lblSinglePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSinglePlayer.Visible = False
        '
        'lblMultiplayer
        '
        Me.lblMultiplayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiplayer.Location = New System.Drawing.Point(2, 342)
        Me.lblMultiplayer.Name = "lblMultiplayer"
        Me.lblMultiplayer.Size = New System.Drawing.Size(285, 39)
        Me.lblMultiplayer.TabIndex = 4
        Me.lblMultiplayer.Text = "Multiplayer"
        Me.lblMultiplayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMultiplayer.Visible = False
        '
        'lblTwoPlayer
        '
        Me.lblTwoPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwoPlayer.Location = New System.Drawing.Point(1, 302)
        Me.lblTwoPlayer.Name = "lblTwoPlayer"
        Me.lblTwoPlayer.Size = New System.Drawing.Size(285, 39)
        Me.lblTwoPlayer.TabIndex = 2
        Me.lblTwoPlayer.Text = "Two Player"
        Me.lblTwoPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTwoPlayer.Visible = False
        '
        'lblOptions
        '
        Me.lblOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.Location = New System.Drawing.Point(2, 382)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(285, 39)
        Me.lblOptions.TabIndex = 3
        Me.lblOptions.Text = "Options"
        Me.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOptions.Visible = False
        '
        'btnSlotOne
        '
        Me.btnSlotOne.BackColor = System.Drawing.Color.Black
        Me.btnSlotOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSlotOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSlotOne.ForeColor = System.Drawing.Color.Black
        Me.btnSlotOne.Location = New System.Drawing.Point(3, 0)
        Me.btnSlotOne.Name = "btnSlotOne"
        Me.btnSlotOne.Size = New System.Drawing.Size(90, 114)
        Me.btnSlotOne.TabIndex = 7
        Me.btnSlotOne.UseVisualStyleBackColor = False
        Me.btnSlotOne.Visible = False
        '
        'btnSlotTwo
        '
        Me.btnSlotTwo.BackColor = System.Drawing.Color.Black
        Me.btnSlotTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSlotTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSlotTwo.ForeColor = System.Drawing.Color.Black
        Me.btnSlotTwo.Location = New System.Drawing.Point(102, 0)
        Me.btnSlotTwo.Name = "btnSlotTwo"
        Me.btnSlotTwo.Size = New System.Drawing.Size(86, 114)
        Me.btnSlotTwo.TabIndex = 8
        Me.btnSlotTwo.UseVisualStyleBackColor = False
        Me.btnSlotTwo.Visible = False
        '
        'btnSlotThree
        '
        Me.btnSlotThree.BackColor = System.Drawing.Color.Black
        Me.btnSlotThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSlotThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSlotThree.ForeColor = System.Drawing.Color.Black
        Me.btnSlotThree.Location = New System.Drawing.Point(197, -2)
        Me.btnSlotThree.Name = "btnSlotThree"
        Me.btnSlotThree.Size = New System.Drawing.Size(90, 114)
        Me.btnSlotThree.TabIndex = 9
        Me.btnSlotThree.UseVisualStyleBackColor = False
        Me.btnSlotThree.Visible = False
        '
        'btnSlotFour
        '
        Me.btnSlotFour.BackColor = System.Drawing.Color.Black
        Me.btnSlotFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSlotFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSlotFour.ForeColor = System.Drawing.Color.Black
        Me.btnSlotFour.Location = New System.Drawing.Point(2, 122)
        Me.btnSlotFour.Name = "btnSlotFour"
        Me.btnSlotFour.Size = New System.Drawing.Size(90, 102)
        Me.btnSlotFour.TabIndex = 10
        Me.btnSlotFour.UseVisualStyleBackColor = False
        Me.btnSlotFour.Visible = False
        '
        'btnSlotFive
        '
        Me.btnSlotFive.BackColor = System.Drawing.Color.Black
        Me.btnSlotFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSlotFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSlotFive.ForeColor = System.Drawing.Color.Black
        Me.btnSlotFive.Location = New System.Drawing.Point(103, 122)
        Me.btnSlotFive.Name = "btnSlotFive"
        Me.btnSlotFive.Size = New System.Drawing.Size(85, 102)
        Me.btnSlotFive.TabIndex = 11
        Me.btnSlotFive.UseVisualStyleBackColor = False
        Me.btnSlotFive.Visible = False
        '
        'btnSlotSix
        '
        Me.btnSlotSix.BackColor = System.Drawing.Color.Black
        Me.btnSlotSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSlotSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSlotSix.ForeColor = System.Drawing.Color.Black
        Me.btnSlotSix.Location = New System.Drawing.Point(196, 122)
        Me.btnSlotSix.Name = "btnSlotSix"
        Me.btnSlotSix.Size = New System.Drawing.Size(90, 102)
        Me.btnSlotSix.TabIndex = 12
        Me.btnSlotSix.UseVisualStyleBackColor = False
        Me.btnSlotSix.Visible = False
        '
        'btnSlotSeven
        '
        Me.btnSlotSeven.BackColor = System.Drawing.Color.Black
        Me.btnSlotSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSlotSeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSlotSeven.ForeColor = System.Drawing.Color.Black
        Me.btnSlotSeven.Location = New System.Drawing.Point(1, 233)
        Me.btnSlotSeven.Name = "btnSlotSeven"
        Me.btnSlotSeven.Size = New System.Drawing.Size(90, 108)
        Me.btnSlotSeven.TabIndex = 13
        Me.btnSlotSeven.UseVisualStyleBackColor = False
        Me.btnSlotSeven.Visible = False
        '
        'btnSlotEight
        '
        Me.btnSlotEight.BackColor = System.Drawing.Color.Black
        Me.btnSlotEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSlotEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSlotEight.ForeColor = System.Drawing.Color.Black
        Me.btnSlotEight.Location = New System.Drawing.Point(103, 233)
        Me.btnSlotEight.Name = "btnSlotEight"
        Me.btnSlotEight.Size = New System.Drawing.Size(85, 108)
        Me.btnSlotEight.TabIndex = 14
        Me.btnSlotEight.UseVisualStyleBackColor = False
        Me.btnSlotEight.Visible = False
        '
        'btnSlotNine
        '
        Me.btnSlotNine.BackColor = System.Drawing.Color.Black
        Me.btnSlotNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSlotNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSlotNine.ForeColor = System.Drawing.Color.Black
        Me.btnSlotNine.Location = New System.Drawing.Point(197, 232)
        Me.btnSlotNine.Name = "btnSlotNine"
        Me.btnSlotNine.Size = New System.Drawing.Size(90, 109)
        Me.btnSlotNine.TabIndex = 15
        Me.btnSlotNine.UseVisualStyleBackColor = False
        Me.btnSlotNine.Visible = False
        '
        'lblDash1
        '
        Me.lblDash1.AutoSize = True
        Me.lblDash1.Location = New System.Drawing.Point(152, 382)
        Me.lblDash1.Name = "lblDash1"
        Me.lblDash1.Size = New System.Drawing.Size(10, 13)
        Me.lblDash1.TabIndex = 21
        Me.lblDash1.Text = "-"
        Me.lblDash1.Visible = False
        '
        'lblDash2
        '
        Me.lblDash2.AutoSize = True
        Me.lblDash2.Location = New System.Drawing.Point(240, 382)
        Me.lblDash2.Name = "lblDash2"
        Me.lblDash2.Size = New System.Drawing.Size(10, 13)
        Me.lblDash2.TabIndex = 22
        Me.lblDash2.Text = "-"
        Me.lblDash2.Visible = False
        '
        'lblXWins
        '
        Me.lblXWins.AutoSize = True
        Me.lblXWins.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXWins.Location = New System.Drawing.Point(160, 379)
        Me.lblXWins.Name = "lblXWins"
        Me.lblXWins.Size = New System.Drawing.Size(19, 20)
        Me.lblXWins.TabIndex = 23
        Me.lblXWins.Text = "0"
        Me.lblXWins.Visible = False
        '
        'lblOWins
        '
        Me.lblOWins.AutoSize = True
        Me.lblOWins.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOWins.Location = New System.Drawing.Point(248, 378)
        Me.lblOWins.Name = "lblOWins"
        Me.lblOWins.Size = New System.Drawing.Size(19, 20)
        Me.lblOWins.TabIndex = 24
        Me.lblOWins.Text = "0"
        Me.lblOWins.Visible = False
        '
        'tmrFindWinner
        '
        Me.tmrFindWinner.Enabled = True
        '
        'lblPlayerX
        '
        Me.lblPlayerX.AutoSize = True
        Me.lblPlayerX.Location = New System.Drawing.Point(103, 349)
        Me.lblPlayerX.Name = "lblPlayerX"
        Me.lblPlayerX.Size = New System.Drawing.Size(0, 13)
        Me.lblPlayerX.TabIndex = 25
        Me.lblPlayerX.Visible = False
        '
        'lblPlayerO
        '
        Me.lblPlayerO.AutoSize = True
        Me.lblPlayerO.Location = New System.Drawing.Point(190, 349)
        Me.lblPlayerO.Name = "lblPlayerO"
        Me.lblPlayerO.Size = New System.Drawing.Size(0, 13)
        Me.lblPlayerO.TabIndex = 26
        Me.lblPlayerO.Visible = False
        '
        'btnUndo
        '
        Me.btnUndo.BackgroundImage = CType(resources.GetObject("btnUndo.BackgroundImage"), System.Drawing.Image)
        Me.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUndo.ForeColor = System.Drawing.Color.Red
        Me.btnUndo.Location = New System.Drawing.Point(12, 352)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(85, 29)
        Me.btnUndo.TabIndex = 20
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        Me.btnUndo.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.BackgroundImage = CType(resources.GetObject("btnQuit.BackgroundImage"), System.Drawing.Image)
        Me.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuit.ForeColor = System.Drawing.Color.Red
        Me.btnQuit.Location = New System.Drawing.Point(12, 382)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(85, 29)
        Me.btnQuit.TabIndex = 19
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        Me.btnQuit.Visible = False
        '
        'picO
        '
        Me.picO.Image = CType(resources.GetObject("picO.Image"), System.Drawing.Image)
        Me.picO.Location = New System.Drawing.Point(193, 361)
        Me.picO.Name = "picO"
        Me.picO.Size = New System.Drawing.Size(43, 50)
        Me.picO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picO.TabIndex = 18
        Me.picO.TabStop = False
        Me.picO.Visible = False
        '
        'picX
        '
        Me.picX.Image = CType(resources.GetObject("picX.Image"), System.Drawing.Image)
        Me.picX.Location = New System.Drawing.Point(103, 361)
        Me.picX.Name = "picX"
        Me.picX.Size = New System.Drawing.Size(43, 50)
        Me.picX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picX.TabIndex = 17
        Me.picX.TabStop = False
        Me.picX.Visible = False
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(35, 44)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(215, 215)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        Me.picLogo.Visible = False
        '
        'picBox
        '
        Me.picBox.Image = CType(resources.GetObject("picBox.Image"), System.Drawing.Image)
        Me.picBox.Location = New System.Drawing.Point(2, 341)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(283, 80)
        Me.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox.TabIndex = 16
        Me.picBox.TabStop = False
        Me.picBox.Visible = False
        '
        'picBoard
        '
        Me.picBoard.Image = CType(resources.GetObject("picBoard.Image"), System.Drawing.Image)
        Me.picBoard.Location = New System.Drawing.Point(0, 0)
        Me.picBoard.Name = "picBoard"
        Me.picBoard.Size = New System.Drawing.Size(285, 341)
        Me.picBoard.TabIndex = 6
        Me.picBoard.TabStop = False
        Me.picBoard.Visible = False
        '
        'txtX
        '
        Me.txtX.BackColor = System.Drawing.Color.Black
        Me.txtX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtX.Location = New System.Drawing.Point(103, 349)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(63, 13)
        Me.txtX.TabIndex = 27
        Me.txtX.Visible = False
        '
        'txtO
        '
        Me.txtO.BackColor = System.Drawing.Color.Black
        Me.txtO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtO.ForeColor = System.Drawing.Color.White
        Me.txtO.Location = New System.Drawing.Point(187, 349)
        Me.txtO.Name = "txtO"
        Me.txtO.Size = New System.Drawing.Size(63, 13)
        Me.txtO.TabIndex = 28
        Me.txtO.Visible = False
        '
        'tmrRegClient
        '
        '
        'tmrStopInviteSpam
        '
        '
        'bw_Help
        '
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(5, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 23)
        Me.btnExit.TabIndex = 55
        Me.btnExit.Text = "Exit Multiplayer"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'stsStatus
        '
        Me.stsStatus.BackColor = System.Drawing.Color.Black
        Me.stsStatus.BackgroundImage = Global.TicTacToeNumeroUno.My.Resources.Resources.box
        Me.stsStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.stsStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblConnectionStatus})
        Me.stsStatus.Location = New System.Drawing.Point(0, 401)
        Me.stsStatus.Name = "stsStatus"
        Me.stsStatus.Size = New System.Drawing.Size(284, 22)
        Me.stsStatus.TabIndex = 54
        Me.stsStatus.Text = "Status Info"
        Me.stsStatus.Visible = False
        '
        'lblConnectionStatus
        '
        Me.lblConnectionStatus.Name = "lblConnectionStatus"
        Me.lblConnectionStatus.Size = New System.Drawing.Size(93, 17)
        Me.lblConnectionStatus.Text = "Connecting........"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-1, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 23)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "OR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 23)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Wait for an Invite..."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 23)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Invite a Player to Play"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'txtMessage
        '
        Me.txtMessage.BackColor = System.Drawing.Color.Black
        Me.txtMessage.ForeColor = System.Drawing.Color.White
        Me.txtMessage.Location = New System.Drawing.Point(2, 372)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(281, 20)
        Me.txtMessage.TabIndex = 50
        Me.txtMessage.Visible = False
        '
        'btnClientLetter
        '
        Me.btnClientLetter.Location = New System.Drawing.Point(2, 22)
        Me.btnClientLetter.Name = "btnClientLetter"
        Me.btnClientLetter.Size = New System.Drawing.Size(75, 23)
        Me.btnClientLetter.TabIndex = 49
        Me.btnClientLetter.Text = "Button2"
        Me.btnClientLetter.UseVisualStyleBackColor = True
        Me.btnClientLetter.Visible = False
        '
        'btnOpponentLetter
        '
        Me.btnOpponentLetter.Location = New System.Drawing.Point(2, 49)
        Me.btnOpponentLetter.Name = "btnOpponentLetter"
        Me.btnOpponentLetter.Size = New System.Drawing.Size(75, 23)
        Me.btnOpponentLetter.TabIndex = 48
        Me.btnOpponentLetter.Text = "Button1"
        Me.btnOpponentLetter.UseVisualStyleBackColor = True
        Me.btnOpponentLetter.Visible = False
        '
        'lblOpponent
        '
        Me.lblOpponent.AutoSize = True
        Me.lblOpponent.Location = New System.Drawing.Point(5, 33)
        Me.lblOpponent.Name = "lblOpponent"
        Me.lblOpponent.Size = New System.Drawing.Size(39, 13)
        Me.lblOpponent.TabIndex = 47
        Me.lblOpponent.Text = "Label2"
        Me.lblOpponent.Visible = False
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Location = New System.Drawing.Point(5, 20)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(39, 13)
        Me.lblClient.TabIndex = 46
        Me.lblClient.Text = "Label1"
        Me.lblClient.Visible = False
        '
        'rtbChatLog
        '
        Me.rtbChatLog.BackColor = System.Drawing.Color.Black
        Me.rtbChatLog.ForeColor = System.Drawing.Color.White
        Me.rtbChatLog.Location = New System.Drawing.Point(4, 250)
        Me.rtbChatLog.Name = "rtbChatLog"
        Me.rtbChatLog.ReadOnly = True
        Me.rtbChatLog.Size = New System.Drawing.Size(279, 119)
        Me.rtbChatLog.TabIndex = 43
        Me.rtbChatLog.Text = ""
        Me.rtbChatLog.Visible = False
        '
        'lstClients
        '
        Me.lstClients.BackColor = System.Drawing.Color.Black
        Me.lstClients.Enabled = False
        Me.lstClients.ForeColor = System.Drawing.Color.White
        Me.lstClients.FormattingEnabled = True
        Me.lstClients.Items.AddRange(New Object() {"It's a little lonely in here...", "Waiting for a user to connect."})
        Me.lstClients.Location = New System.Drawing.Point(6, 97)
        Me.lstClients.Name = "lstClients"
        Me.lstClients.Size = New System.Drawing.Size(277, 147)
        Me.lstClients.TabIndex = 44
        Me.lstClients.Visible = False
        '
        'lstRooms
        '
        Me.lstRooms.FormattingEnabled = True
        Me.lstRooms.Location = New System.Drawing.Point(154, 88)
        Me.lstRooms.Name = "lstRooms"
        Me.lstRooms.Size = New System.Drawing.Size(120, 95)
        Me.lstRooms.TabIndex = 45
        Me.lstRooms.Visible = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(284, 423)
        Me.Controls.Add(Me.rtbChatLog)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.stsStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnClientLetter)
        Me.Controls.Add(Me.btnOpponentLetter)
        Me.Controls.Add(Me.lblOpponent)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.lstClients)
        Me.Controls.Add(Me.lstRooms)
        Me.Controls.Add(Me.txtO)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.lblPlayerO)
        Me.Controls.Add(Me.lblPlayerX)
        Me.Controls.Add(Me.lblOWins)
        Me.Controls.Add(Me.lblXWins)
        Me.Controls.Add(Me.lblDash2)
        Me.Controls.Add(Me.lblDash1)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.picO)
        Me.Controls.Add(Me.picX)
        Me.Controls.Add(Me.btnSlotNine)
        Me.Controls.Add(Me.btnSlotEight)
        Me.Controls.Add(Me.btnSlotSeven)
        Me.Controls.Add(Me.btnSlotSix)
        Me.Controls.Add(Me.btnSlotFive)
        Me.Controls.Add(Me.btnSlotFour)
        Me.Controls.Add(Me.btnSlotThree)
        Me.Controls.Add(Me.btnSlotTwo)
        Me.Controls.Add(Me.btnSlotOne)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.lblMultiplayer)
        Me.Controls.Add(Me.lblSinglePlayer)
        Me.Controls.Add(Me.lblTwoPlayer)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.picBox)
        Me.Controls.Add(Me.picBoard)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ze Tic Tac Toe"
        CType(Me.picO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stsStatus.ResumeLayout(False)
        Me.stsStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSinglePlayer As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblMultiplayer As Label
    Friend WithEvents lblTwoPlayer As Label
    Friend WithEvents lblOptions As Label
    Friend WithEvents picBoard As PictureBox
    Friend WithEvents btnSlotOne As Button
    Friend WithEvents btnSlotTwo As Button
    Friend WithEvents btnSlotThree As Button
    Friend WithEvents btnSlotFour As Button
    Friend WithEvents btnSlotFive As Button
    Friend WithEvents btnSlotSix As Button
    Friend WithEvents btnSlotSeven As Button
    Friend WithEvents btnSlotEight As Button
    Friend WithEvents btnSlotNine As Button
    Friend WithEvents picBox As PictureBox
    Friend WithEvents picX As PictureBox
    Friend WithEvents picO As PictureBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents lblDash1 As Label
    Friend WithEvents lblDash2 As Label
    Friend WithEvents lblXWins As Label
    Friend WithEvents lblOWins As Label
    Friend WithEvents lblPlayerX As Label
    Friend WithEvents lblPlayerO As Label
    Friend WithEvents tmrFindWinner As Timer
    Friend WithEvents txtX As TextBox
    Friend WithEvents txtO As TextBox
    Friend WithEvents tmrRegClient As Timer
    Friend WithEvents tmrStopInviteSpam As Timer
    Friend WithEvents bw_Help As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnExit As Button
    Friend WithEvents stsStatus As StatusStrip
    Friend WithEvents lblConnectionStatus As ToolStripStatusLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnClientLetter As Button
    Friend WithEvents btnOpponentLetter As Button
    Friend WithEvents lblOpponent As Label
    Friend WithEvents lblClient As Label
    Friend WithEvents rtbChatLog As RichTextBox
    Friend WithEvents lstClients As ListBox
    Friend WithEvents lstRooms As ListBox
End Class
