Public Class ViewallTest

    Dim conn As New OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim cb As OleDb.OleDbCommandBuilder

    Private Sub Viewall_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim Sql As String = "SELECT SerialNo, PatientName, Age, Address, PaymentMethod, TestName, Gender, FORMAT(LDate, 'dd/MM/yyyy') AS TestDate, Mobile, City, Amount, Quantity FROM LabTest"
        da = New OleDb.OleDbDataAdapter(Sql, conn)
        cb = New OleDb.OleDbCommandBuilder(da)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt

        Dim totalCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM LabTest", conn)
        Dim totalTestCount As Integer = CInt(totalCmd.ExecuteScalar())
        totaltest.Text = totalTestCount.ToString()

        Dim feesCmd As New OleDb.OleDbCommand("SELECT SUM(Amount) FROM LabTest", conn)
        Dim totalFees As Object = feesCmd.ExecuteScalar()

        Dim onlineCmd As New OleDb.OleDbCommand("SELECT SUM(Amount) FROM LabTest WHERE PaymentMethod IN ('UPI')", conn)
        Dim onlineTotal As Object = onlineCmd.ExecuteScalar()

        Dim cashCmd As New OleDb.OleDbCommand("SELECT SUM(Amount) FROM LabTest WHERE PaymentMethod = 'CASH'", conn)
        Dim cashTotal As Object = cashCmd.ExecuteScalar()

        If IsDBNull(totalFees) Then
            grandtotal.Text = "0"
        Else
            grandtotal.Text = totalFees.ToString()
        End If

        If IsDBNull(onlineTotal) Then
            totalonline.Text = "0"
        Else
            totalonline.Text = onlineTotal.ToString()
        End If

        If IsDBNull(cashTotal) Then
            totalcash.Text = "0"
        Else
            totalcash.Text = cashTotal.ToString()
        End If

        conn.Close()
    End Sub

End Class
