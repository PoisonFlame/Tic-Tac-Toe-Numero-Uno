<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class message
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.BackgroundImage = Global.TicTacToeNumeroUno.My.Resources.Resources.box
        Me.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Red
        Me.btnOk.Location = New System.Drawing.Point(65, 83)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(112, 45)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.White
        Me.lblMsg.Location = New System.Drawing.Point(3, 14)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(242, 66)
        Me.lblMsg.TabIndex = 3
        Me.lblMsg.Text = "Message Here"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TicTacToeNumeroUno.My.Resources.Resources.box
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(250, 143)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblMsg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "message"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Msgbox"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents lblMsg As Label
End Class
