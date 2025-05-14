Public Class ViewDate
    Public Sub btnshow_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click

        Dim date1 As String = DateTimePicker1.Value.ToString("MM/dd/yyyy")
        Dim date2 As String = DateTimePicker2.Value.ToString("MM/dd/yyyy")


        Dim Datewise As New DatewiseOPD(date1, date2)
        Home.LoadForm(Datewise)
    End Sub
End Class
