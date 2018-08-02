Imports DiscordRPC
Public Class mlemflix

    Private WithEvents RPCClient As New DiscordRpcClient("437369594869579776")
    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        RPCClient.Initialize()
        RPCClient.SetPresence(New RichPresence() With {
            .Details = "Version 1.8",
            .Assets = New Assets() With {
                .LargeImageKey = "image_large",
                .LargeImageText = "Mlem Boys: Multiplayer",
                .SmallImageKey = "asap"
            }
        })
        Me.Close()
        mainmenu.Show()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class