Public Class gameOver
    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        main.btnSlotOne.BackgroundImage = Nothing
        main.btnSlotTwo.BackgroundImage = Nothing
        main.btnSlotThree.BackgroundImage = Nothing
        main.btnSlotFour.BackgroundImage = Nothing
        main.btnSlotFive.BackgroundImage = Nothing
        main.btnSlotSix.BackgroundImage = Nothing
        main.btnSlotSeven.BackgroundImage = Nothing
        main.btnSlotEight.BackgroundImage = Nothing
        main.btnSlotNine.BackgroundImage = Nothing
        main.btnSlotOne.Tag = ""
        main.btnSlotTwo.Tag = ""
        main.btnSlotThree.Tag = ""
        main.btnSlotFour.Tag = ""
        main.btnSlotFive.Tag = ""
        main.btnSlotSix.Tag = ""
        main.btnSlotSeven.Tag = ""
        main.btnSlotEight.Tag = ""
        main.btnSlotNine.Tag = ""
        main.btnSlotOne.Enabled = True
        main.btnSlotTwo.Enabled = True
        main.btnSlotThree.Enabled = True
        main.btnSlotFour.Enabled = True
        main.btnSlotFive.Enabled = True
        main.btnSlotSix.Enabled = True
        main.btnSlotSeven.Enabled = True
        main.btnSlotEight.Enabled = True
        main.btnSlotNine.Enabled = True
        main.tmrFindWinner.Start()
        Me.Close()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        main.quitGame()
        Me.Close()
    End Sub

    Private Sub gameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class