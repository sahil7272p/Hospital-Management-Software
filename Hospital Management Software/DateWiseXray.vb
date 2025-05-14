Imports System.Data.OleDb

Public Class DatewiseXray
    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Private startDate As String
    Private endDate As String

    Public Sub New(ByVal date1 As String, ByVal date2 As String)
        InitializeComponent()
        Me.startDate = date1
        Me.endDate = date2
    End Sub

    Private Sub DatewiseData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then conn.Open()

        Dim sql As String = "SELECT SerialNo, PatientName, Age, Address, PaymentMethod, Xraytype, Gender, FORMAT(XDate, 'dd/MM/yyyy') AS XDate, Mobile, City, Quantity, Amount FROM Xray WHERE DateValue(XDate) >= #" & startDate & "# AND DateValue(XDate) <= #" & endDate & "#"
        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable()
        da.Fill(dt)
        DataGridViewxray.DataSource = dt

        Dim totalCmd As New OleDbCommand("SELECT COUNT(*) FROM Xray WHERE DateValue(XDate) >= #" & startDate & "# AND DateValue(XDate) <= #" & endDate & "#", conn)
        totalxray.Text = CInt(totalCmd.ExecuteScalar()).ToString()

        Dim grandCmd As New OleDbCommand("SELECT SUM(Amount) FROM Xray WHERE DateValue(XDate) >= #" & startDate & "# AND DateValue(XDate) <= #" & endDate & "#", conn)
        Dim totalFees As Object = grandCmd.ExecuteScalar()

        Dim onlineCmd As New OleDbCommand("SELECT SUM(Amount) FROM Xray WHERE PaymentMethod = 'UPI' AND DateValue(XDate) >= #" & startDate & "# AND DateValue(XDate) <= #" & endDate & "#", conn)
        Dim onlineTotal As Object = onlineCmd.ExecuteScalar()

        Dim cashCmd As New OleDbCommand("SELECT SUM(Amount) FROM Xray WHERE PaymentMethod = 'CASH' AND DateValue(XDate) >= #" & startDate & "# AND DateValue(XDate) <= #" & endDate & "#", conn)
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
