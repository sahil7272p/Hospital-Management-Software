Public Class Welcome
    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Home.Show()
        Home.Close()
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btndashboard_Click_1(sender As Object, e As EventArgs) Handles btndashboard.Click
        Home.Show()
        Home.Close()
        Start.Show()

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub


End Class