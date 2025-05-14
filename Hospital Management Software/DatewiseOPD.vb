Imports System.Data.OleDb

Public Class DatewiseOPD
    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim startDateFormatted As String
    Dim endDateFormatted As String

    Public Sub New(ByVal date1 As String, ByVal date2 As String)
        InitializeComponent()
        startDateFormatted = date1
        endDateFormatted = date2
    End Sub

    Private Sub DatewiseOPD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim sql As String = "SELECT SerialNo, PatientName, Age, Address, Fees, PaymentMethod, OPDtype, Gender, FORMAT(ODate, 'dd/MM/yyyy') AS ODate, Mobile, City, State, Doctor FROM OPD WHERE DateValue(ODate) >= #" & startDateFormatted & "# AND DateValue(ODate) <= #" & endDateFormatted & "# ORDER BY SerialNo ASC"

        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable()
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            DataGridViewopd.DataSource = dt
        Else
            MsgBox("No records found for the selected date range.", MsgBoxStyle.Information)
        End If

        Dim totalCmd As New OleDbCommand("SELECT COUNT(*) FROM OPD WHERE DateValue(ODate) >= #" & startDateFormatted & "# AND DateValue(ODate) <= #" & endDateFormatted & "#", conn)
        totalopd.Text = totalCmd.ExecuteScalar().ToString()


        Dim feesCmd As New OleDbCommand("SELECT SUM(Fees) FROM OPD WHERE DateValue(ODate) >= #" & startDateFormatted & "# AND DateValue(ODate) <= #" & endDateFormatted & "#", conn)
        Dim totalFees As Object = feesCmd.ExecuteScalar()

        Dim onlineCmd As New OleDbCommand("SELECT SUM(Fees) FROM OPD WHERE PaymentMethod = 'UPI' AND DateValue(ODate) >= #" & startDateFormatted & "# AND DateValue(ODate) <= #" & endDateFormatted & "#", conn)
        Dim onlineTotal As Object = onlineCmd.ExecuteScalar()

        Dim cashCmd As New OleDbCommand("SELECT SUM(Fees) FROM OPD WHERE PaymentMethod = 'CASH' AND DateValue(ODate) >= #" & startDateFormatted & "# AND DateValue(ODate) <= #" & endDateFormatted & "#", conn)
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
