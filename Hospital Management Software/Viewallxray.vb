Imports System.Data.OleDb

Public Class Viewallxray
    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dt As DataTable

    Private Sub Viewallxray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then conn.Open()

        Dim Sql As String = "SELECT SerialNo, PatientName, Age, Address, PaymentMethod, Xraytype, Gender, FORMAT(XDate, 'dd/MM/yyyy') AS XDate, Mobile, City, Quantity, Amount FROM Xray ORDER BY SerialNo ASC"
        da = New OleDbDataAdapter(Sql, conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridViewXray.DataSource = dt

        Dim totalCmd As New OleDbCommand("SELECT COUNT(*) FROM Xray", conn)
        totalxray.Text = CInt(totalCmd.ExecuteScalar()).ToString()

        Dim amountCmd As New OleDbCommand("SELECT SUM(Amount) FROM Xray", conn)
        Dim totalamount As Object = amountCmd.ExecuteScalar()

        Dim onlineCmd As New OleDbCommand("SELECT SUM(Amount) FROM Xray WHERE PaymentMethod = 'UPI'", conn)
        Dim onlineTotal As Object = onlineCmd.ExecuteScalar()

        Dim cashCmd As New OleDbCommand("SELECT SUM(Amount) FROM Xray WHERE PaymentMethod = 'CASH'", conn)
        Dim cashTotal As Object = cashCmd.ExecuteScalar()

        If IsDBNull(totalamount) Then
            grandtotal.Text = "0"
        Else
            grandtotal.Text = totalamount.ToString()
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
