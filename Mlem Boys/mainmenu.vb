Imports System.Globalization
Imports nUpdate.Updating
Imports nUpdate.Core
Imports DiscordRPC
Imports DiscordRPC.Logging
Imports DiscordRPC.Events
Imports DiscordRPC.Message
Imports ComputerInfo

Public Class mainmenu

    Private WithEvents RPCClient As New DiscordRpcClient("437369594869579776")

    Private Sub MetroNavigationButton1_Click(sender As Object, e As EventArgs) Handles MetroNavigationButton1.Click
        Application.Exit()
    End Sub

    Private Sub OnPresenseUpdated(sender As Object, e As PresenceMessage) Handles RPCClient.OnPresenceUpdate
        Console.WriteLine("Received Update! {0}", e.Presence)
    End Sub


    Private Function DateTimeToTimestamp(datetime As DateTime)
        Return (datetime.Ticks - 621355968000000000) / 10000000
    End Function

    Private Sub mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Buttonpressed = 10 Then
            My.Settings.Level = +1
            My.Settings.Buttonpressed = 0
            My.Settings.Save()
        End If
        MetroLabel8.Text = My.Settings.Level
        MetroLabel6.Text = ComputerInfo.Info.User.get_CurrentUser
        Me.DateTimeToTimestamp(DateTime.UtcNow).ToString()
        RPCClient.Logger = New ConsoleLogger With {
            .Level = LogLevel.Warning
        }

        RPCClient.Initialize()
        RPCClient.SetPresence(New RichPresence() With {
            .Details = "Version 1.8",
            .Assets = New Assets() With {
                .LargeImageKey = "image_large",
                .LargeImageText = "Mlem Boys: Multiplayer",
                .SmallImageKey = "asap"
            }
        })
        RPCClient.SetPresence(New RichPresence() With {
    .Timestamps = New Timestamps() With {
        .Start = DateTime.UtcNow,
        .End = DateTime.UtcNow.AddHours(1)
    }
})
        REM My.Computer.Audio.Play(My.Resources.maintheme,
        REM AudioPlayMode.BackgroundLoop)REM 
        Dim manager As New UpdateManager(New Uri("https://mlemboys.lima-city.de/updates.json"), "<RSAKeyValue><Modulus>sbpGTVrws+ctp5BK8xbADN+mg45tBgF2v/R1Agp8tl9Her0cSgj1+YqsmcLP0+k96EN0YSsxLGVPLcEgLFjxO1z628bVKpLPB4aH/i24zfSBD6KF9qRqUgOscAKr1pezVjd/wv4WfHAAUnaDRdCUdkY7o+IyaGIyficrfSWln2yUdppLKPglDuNQgL/IAitP16NSlzfIyFBWzNrDRpC38P3qaRxKlKCsYry496vcksI4mkSyd/dxD/NIQJxa3dXp+FeyJVusWgnsd1VHDfs5aUbQBzAaCNu5XT/mi5ajca0gDpiKRDYwTEEF4ASJtp3cDv5gKTn0HhxgvTWie7/2D5yQ4bn0HpxjEyrxeSFhdm7YCnkn88nyMOwt87tuzio+E1bp5Is4nlHt2jZZab/oROfwT368oF3LtOpiOTvEmp8mdsVwGvTargkWYACwqdnPk9eNzRzqcpYwP1e92qOq435MQm7koeHUlc4pl8MhxWdtYHevMz0p6i/iT92LVlbtxFdO2WLGsVnTCP0w2VrCmmySqGTJN9Z6By053ZA79Qwitd4KcaZAJzDBA637Z2/plAvKPNM3TwvCmlswCpaO57+UZmhftT4NcrzzYbyKpD6OfDFQnaYuZ5JRnXEnTz/nUXmMLNN8zD1T1CEaxZuJT2xY+7nDJ83wrS0NjeFv6zvF6esblNU0lcNjnxZY4gR8U3ua9IOhP1BKhbyUabhCniSd2GjMgd4ayGGBMsjJv6knC1Li8CSPzVHuxZt1n3vkxy35OW7o//IuN06qoaH2yReIKZuBxy4u0hSznTbQ6SrSlYeghdc2mrZ+XTtBdLYBXC+St2pTioxHUDkmJE45d5NQ5jP41nlIz8t1W4ntw/KMhAPvY7pqFi6H2f9RBktpI2ieZPpCwL900TlvgXp5ZshUIIiQihTN3t7rYu/SnEm00osGwU7VAs3rlVjYPkTb2utu6zxSGM68GsAZkeARQ88xZKdUceq+fuVf2p8xLfLgGRumc4tdu/Z9RxUdW3J2fS/f3U8+CSSGzmttzWCuvmqnCs9JsDlEY8Qj95+r6zGPR+KM48EwyH3vhnzcMd1ngU89huo+kMuEZ8VFJzxyvviTIGEWB8ehjDjQ8hiseVuvZGwq1z+CTHBlX8eoB0y51hR3B5wffP5lIknvWAePR0Ud4Gv+zZ1ASu2fuLyLdqwlhE9MwqoN0vvLAJuTrfwYy0QFJpw65xnD72eAQqnDFb7/k760N1zd97TbUK36MWa8Ts2GbPTQhDxLNJ1T8LA52ae7WT4GoRYMWXMxrXmXWEVRAQ4wfE1geBIhMUPw5Z+7Ow6xPjVi3QUT6alZuFs8N1tn2JIvPYogrLmny8u93Q==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", New CultureInfo("en"))
        Dim updaterUI As New UpdaterUI(manager, WindowsFormsSynchronizationContext.Current)
        updaterUI.ShowUserInterface()
        updaterUI.UseHiddenSearch = True
        manager.CloseHostApplication = True
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim manager As New UpdateManager(New Uri("https://mlemboys.lima-city.de/updates.json"), "<RSAKeyValue><Modulus>sbpGTVrws+ctp5BK8xbADN+mg45tBgF2v/R1Agp8tl9Her0cSgj1+YqsmcLP0+k96EN0YSsxLGVPLcEgLFjxO1z628bVKpLPB4aH/i24zfSBD6KF9qRqUgOscAKr1pezVjd/wv4WfHAAUnaDRdCUdkY7o+IyaGIyficrfSWln2yUdppLKPglDuNQgL/IAitP16NSlzfIyFBWzNrDRpC38P3qaRxKlKCsYry496vcksI4mkSyd/dxD/NIQJxa3dXp+FeyJVusWgnsd1VHDfs5aUbQBzAaCNu5XT/mi5ajca0gDpiKRDYwTEEF4ASJtp3cDv5gKTn0HhxgvTWie7/2D5yQ4bn0HpxjEyrxeSFhdm7YCnkn88nyMOwt87tuzio+E1bp5Is4nlHt2jZZab/oROfwT368oF3LtOpiOTvEmp8mdsVwGvTargkWYACwqdnPk9eNzRzqcpYwP1e92qOq435MQm7koeHUlc4pl8MhxWdtYHevMz0p6i/iT92LVlbtxFdO2WLGsVnTCP0w2VrCmmySqGTJN9Z6By053ZA79Qwitd4KcaZAJzDBA637Z2/plAvKPNM3TwvCmlswCpaO57+UZmhftT4NcrzzYbyKpD6OfDFQnaYuZ5JRnXEnTz/nUXmMLNN8zD1T1CEaxZuJT2xY+7nDJ83wrS0NjeFv6zvF6esblNU0lcNjnxZY4gR8U3ua9IOhP1BKhbyUabhCniSd2GjMgd4ayGGBMsjJv6knC1Li8CSPzVHuxZt1n3vkxy35OW7o//IuN06qoaH2yReIKZuBxy4u0hSznTbQ6SrSlYeghdc2mrZ+XTtBdLYBXC+St2pTioxHUDkmJE45d5NQ5jP41nlIz8t1W4ntw/KMhAPvY7pqFi6H2f9RBktpI2ieZPpCwL900TlvgXp5ZshUIIiQihTN3t7rYu/SnEm00osGwU7VAs3rlVjYPkTb2utu6zxSGM68GsAZkeARQ88xZKdUceq+fuVf2p8xLfLgGRumc4tdu/Z9RxUdW3J2fS/f3U8+CSSGzmttzWCuvmqnCs9JsDlEY8Qj95+r6zGPR+KM48EwyH3vhnzcMd1ngU89huo+kMuEZ8VFJzxyvviTIGEWB8ehjDjQ8hiseVuvZGwq1z+CTHBlX8eoB0y51hR3B5wffP5lIknvWAePR0Ud4Gv+zZ1ASu2fuLyLdqwlhE9MwqoN0vvLAJuTrfwYy0QFJpw65xnD72eAQqnDFb7/k760N1zd97TbUK36MWa8Ts2GbPTQhDxLNJ1T8LA52ae7WT4GoRYMWXMxrXmXWEVRAQ4wfE1geBIhMUPw5Z+7Ow6xPjVi3QUT6alZuFs8N1tn2JIvPYogrLmny8u93Q==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", New CultureInfo("en"))
        Dim updaterUI As New UpdaterUI(manager, WindowsFormsSynchronizationContext.Current)
        updaterUI.ShowUserInterface()
        updaterUI.UseHiddenSearch = True
        manager.CloseHostApplication = True
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        settings.Show()
    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton2.Enabled = True
        RadioButton1.Enabled = False
        My.Computer.Audio.Stop()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        My.Computer.Audio.Play(My.Resources.maintheme,
        AudioPlayMode.BackgroundLoop)
        RadioButton1.Enabled = True
        RadioButton2.Enabled = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Play(My.Resources.dogbrk,
        AudioPlayMode.Background)
        My.Computer.Audio.Play(My.Resources.maintheme,
AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Process.Start("https://discord.gg/ZmFmFzn")
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        My.Settings.Buttonpressed = +1
        My.Settings.Save()
        My.Computer.Audio.Stop()
        RPCClient.SetPresence(New RichPresence() With {
        .Details = "Version 1.8",
        .Timestamps = New Timestamps() With {
            .Start = DateTime.UtcNow
        },
        .Assets = New Assets() With {
            .LargeImageKey = "image_large",
            .LargeImageText = "Mlem Boys: Multiplayer",
            .SmallImageKey = "asap",
            .SmallImageText = "Inin´s Game Studio"
        }
})
        Dim ProcessProperties As New ProcessStartInfo
        ProcessProperties.FileName = "Mlem"
        ProcessProperties.Arguments = "mlem.exe"
        ProcessProperties.WindowStyle = ProcessWindowStyle.Normal
        Dim myProcess As Process = Process.Start(ProcessProperties)
        Me.Hide()
        myProcess.WaitForExit()
        Application.Exit()
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        RPCClient.SetPresence(New RichPresence() With {
        .Details = "Mlemflix",
        .Timestamps = New Timestamps() With {
            .Start = DateTime.UtcNow
        },
        .Assets = New Assets() With {
            .LargeImageKey = "image_large",
            .LargeImageText = "Mlem Boys: Multiplayer",
            .SmallImageKey = "asap",
            .SmallImageText = "Inin´s Game Studio"
        }
})
        mlemflix.Show()
        Me.Hide()
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Process.Start("https://www.youtube.com/channel/UCKE0slIdktgNqoO-gRqI5jQ")
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Process.Start("https://www.youtube.com/channel/UC38r7_x7oMPAZweB2fvGDXQ")
    End Sub

    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) 
        My.Settings.Level = My.Settings.Level + 1
        MetroLabel8.Refresh()
    End Sub
End Class
