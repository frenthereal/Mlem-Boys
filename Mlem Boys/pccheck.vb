Public Class pccheck
    Private Sub pccheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MetroLabel5.Text = "CPU: " & ComputerInfo.Info.CPU.get_Name
        MetroLabel4.Text = "Graphiccard: " & ComputerInfo.Info.Graphiccard.get_Name
        MetroLabel1.Text = "RAM: " & ComputerInfo.Info.RAM.TotalPhysicalMemory
        If ComputerInfo.Info.RAM.TotalPhysicalMemory >= 25600 Then
            MetroLabel2.Visible = True
        ElseIf ComputerInfo.Info.RAM.TotalPhysicalMemory >= 25600 Then

        End If
    End Sub

    Private Sub MetroNavigationButton1_Click(sender As Object, e As EventArgs) Handles MetroNavigationButton1.Click
        Me.Close()
        mainmenu.Show()
    End Sub
End Class