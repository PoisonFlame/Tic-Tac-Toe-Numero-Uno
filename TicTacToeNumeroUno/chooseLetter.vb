Imports System
Imports System.Runtime.InteropServices

Public Class chooseLetter
    Private Sub picO_Click(sender As Object, e As EventArgs) Handles picO.Click
        picO.BorderStyle = BorderStyle.FixedSingle
        picX.BorderStyle = BorderStyle.None
    End Sub

    Private Sub picX_Click(sender As Object, e As EventArgs) Handles picX.Click
        picX.BorderStyle = BorderStyle.FixedSingle
        picO.BorderStyle = BorderStyle.None
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If picO.BorderStyle = BorderStyle.FixedSingle Then
            My.Settings.spLetterChoice = 0
            main.tmrFindWinner.Start()
            Me.Close()
        ElseIf picX.BorderStyle = BorderStyle.FixedSingle Then
            My.Settings.spLetterChoice = 1
            main.tmrFindWinner.Start()
            Me.Close()
        Else
            MsgBox("Please choose a letter above")
        End If
    End Sub

    Private Sub chooseLetter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class