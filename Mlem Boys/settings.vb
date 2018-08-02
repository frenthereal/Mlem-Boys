Imports System.Globalization
Imports nUpdate.Updating
Imports nUpdate.Core
Imports DiscordRPC
Imports DiscordRPC.Logging
Imports DiscordRPC.Events
Imports DiscordRPC.Message
Public Class settings
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

        My.Computer.Audio.Stop()

    End Sub

    Private Sub MetroNavigationButton1_Click(sender As Object, e As EventArgs) Handles MetroNavigationButton1.Click

        Me.Close()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        MsgBox("You are a bad boii, you cannot remove Mlem Boys!")
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        mainmenu.Hide()
        pccheck.Show()
        Me.Close()
    End Sub
End Class