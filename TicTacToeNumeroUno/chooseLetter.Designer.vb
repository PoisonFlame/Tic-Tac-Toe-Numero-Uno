<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chooseLetter
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
        Me.lblChooseLetter = New System.Windows.Forms.Label()
        Me.picX = New System.Windows.Forms.PictureBox()
        Me.picO = New System.Windows.Forms.PictureBox()
        Me.btnOk = New System.Windows.Forms.Button()
        CType(Me.picX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChooseLetter
        '
        Me.lblChooseLetter.AutoSize = True
        Me.lblChooseLetter.BackColor = System.Drawing.Color.Transparent
        Me.lblChooseLetter.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseLetter.ForeColor = System.Drawing.Color.White
        Me.lblChooseLetter.Location = New System.Drawing.Point(17, 20)
        Me.lblChooseLetter.Name = "lblChooseLetter"
        Me.lblChooseLetter.Size = New System.Drawing.Size(217, 33)
        Me.lblChooseLetter.TabIndex = 0
        Me.lblChooseLetter.Text = "Choose Your Letter"
        '
        'picX
        '
        Me.picX.BackgroundImage = Global.TicTacToeNumeroUno.My.Resources.Resources.X
        Me.picX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picX.Location = New System.Drawing.Point(126, 56)
        Me.picX.Name = "picX"
        Me.picX.Size = New System.Drawing.Size(50, 50)
        Me.picX.TabIndex = 1
        Me.picX.TabStop = False
        '
        'picO
        '
        Me.picO.BackgroundImage = Global.TicTacToeNumeroUno.My.Resources.Resources.O
        Me.picO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picO.Location = New System.Drawing.Point(70, 56)
        Me.picO.Name = "picO"
        Me.picO.Size = New System.Drawing.Size(50, 50)
        Me.picO.TabIndex = 2
        Me.picO.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.BackgroundImage = Global.TicTacToeNumeroUno.My.Resources.Resources.box
        Me.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.ForeColor = System.Drawing.Color.Red
        Me.btnOk.Location = New System.Drawing.Point(86, 108)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'chooseLetter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TicTacToeNumeroUno.My.Resources.Resources.box
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(250, 143)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.picO)
        Me.Controls.Add(Me.picX)
        Me.Controls.Add(Me.lblChooseLetter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "chooseLetter"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Choose Letter"
        CType(Me.picX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChooseLetter As Label
    Friend WithEvents picX As PictureBox
    Friend WithEvents picO As PictureBox
    Friend WithEvents btnOk As Button
End Class
