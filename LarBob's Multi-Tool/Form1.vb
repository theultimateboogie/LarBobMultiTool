Public Class Form1

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Process.Start("cmd", "/k required\Shell.bat")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Process.Start("cmd.exe")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Process.Start("cmd", "/k required\PingVPS_batch.bat")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Process.Start("control")
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Process.Start("control.exe", "/name Microsoft.NetworkAndSharingCenter")
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Process.Start("powershell")
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Process.Start("cmd", "/k required\PingVPS_cont.bat")
    End Sub
End Class
