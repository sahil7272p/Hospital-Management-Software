Public Class ViewDate2
    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("MM/dd/yyyy")
        Dim date2 As String = DateTimePicker2.Value.ToString("MM/dd/yyyy")

        Dim Datewise As New DatewiseXray(date1, date2)

        Home.LoadForm(Datewise)

    End Sub
End Class