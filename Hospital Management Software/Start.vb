Public Class Start
    Public Sub LoginToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles LoginToolStripMenuItem1.Click
        Dim login As New Login()
        login.Show()
    End Sub


    Private Sub About_Click(sender As System.Object, e As System.EventArgs) Handles About.Click
        Dim about As New About()
        about.Show()
    End Sub

End Class

