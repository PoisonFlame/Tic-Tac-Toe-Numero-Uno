<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gameOver
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
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWinner
        '
        Me.lblWinner.BackColor = System.Drawing.Color.Transparent
        Me.lblWinner.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.ForeColor = System.Drawing.Color.White
        Me.lblWinner.Location = New System.Drawing.Point(6, 16)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(242, 33)
        Me.lblWinner.TabIndex = 1
        Me.lblWinner.Text = "Dummy Wins"
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.BackColor = System.Drawing.Color.Transparent
        Me.btnPlayAgain.BackgroundImage = Global.TicTacToeNumeroUno.My.Resources.Resources.box
        Me.btnPlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayAgain.ForeColor = System.Drawing.Color.Red
        Me.btnPlayAgain.Location = New System.Drawing.Point(12, 76)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(112, 45)
        Me.btnPlayAgain.TabIndex = 2
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Transparent
        Me.btnQuit.BackgroundImage = Global.TicTacToeNumeroUno.My.Resources.Resources.box
        Me.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.ForeColor = System.Drawing.Color.Red
        Me.btnQuit.Location = New System.Drawing.Point(130, 76)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(108, 45)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Main Menu"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'gameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TicTacToeNumeroUno.My.Resources.Resources.box
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(250, 143)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.lblWinner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "gameOver"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Game Over"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWinner As Label
    Friend WithEvents btnPlayAgain As Button
    Friend WithEvents btnQuit As Button
End Class
