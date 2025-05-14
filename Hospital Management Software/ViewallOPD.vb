Public Class ViewallOPD
    Dim conn As New OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable

    Private Sub Viewall_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim Sql As String = "SELECT SerialNo, PatientName, Age, Address, Fees, PaymentMethod, OPDtype, Gender, FORMAT(ODate, 'dd/MM/yyyy') AS OPD_Date, Mobile, City, State, Doctor FROM OPD ORDER BY SerialNo ASC"
        da = New OleDb.OleDbDataAdapter(Sql, conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt

        Dim totalCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM OPD", conn)
        Dim totalOPDCount As Integer = CInt(totalCmd.ExecuteScalar())
        totalopd.Text = totalOPDCount.ToString()

        Dim feesCmd As New OleDb.OleDbCommand("SELECT SUM(Fees) FROM OPD", conn)
        Dim totalFees As Object = feesCmd.ExecuteScalar()

        Dim onlineCmd As New OleDb.OleDbCommand("SELECT SUM(Fees) FROM OPD WHERE PaymentMethod IN ('UPI')", conn)
        Dim onlineTotal As Object = onlineCmd.ExecuteScalar()

        Dim cashCmd As New OleDb.OleDbCommand("SELECT SUM(Fees) FROM OPD WHERE PaymentMethod = 'CASH'", conn)
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
    End Sub
End Class
