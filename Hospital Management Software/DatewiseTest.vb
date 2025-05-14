Imports System.Data.OleDb

Public Class DatewiseTest

    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Private startDateFormatted As String
    Private endDateFormatted As String

    Public Sub New(ByVal date1 As String, ByVal date2 As String)
        InitializeComponent()
        startDateFormatted = date1
        endDateFormatted = date2
    End Sub

    Private Sub DatewiseData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim sql As String = "SELECT SerialNo, PatientName, Age, Address, PaymentMethod, TestName, Gender, " &
                            "Format(LDate, 'dd/MM/yyyy') As Test_Date, Mobile, City, Amount, Quantity " &
                            "FROM LabTest WHERE DateValue(LDate) >= #" & startDateFormatted & "# AND DateValue(LDate) <= #" & endDateFormatted & "#"

        da = New OleDbDataAdapter(sql, conn)
        dt = New DataTable()
        da.Fill(dt)
        DataGridViewopd.DataSource = dt

        If dt.Rows.Count = 0 Then
            MessageBox.Show("No records found for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Dim totalCmd As New OleDbCommand("SELECT COUNT(*) FROM LabTest WHERE DateValue(LDate) >= #" & startDateFormatted & "# AND DateValue(LDate) <= #" & endDateFormatted & "#", conn)
        totaltest.Text = totalCmd.ExecuteScalar()

        Dim feesCmd As New OleDbCommand("SELECT SUM(Amount) FROM LabTest WHERE DateValue(LDate) >= #" & startDateFormatted & "# AND DateValue(LDate) <= #" & endDateFormatted & "#", conn)
        Dim totalFees As Object = feesCmd.ExecuteScalar()

        Dim onlineCmd As New OleDbCommand("SELECT SUM(Amount) FROM LabTest WHERE PaymentMethod = 'UPI' AND DateValue(LDate) >= #" & startDateFormatted & "# AND DateValue(LDate) <= #" & endDateFormatted & "#", conn)
        Dim onlineTotal As Object = onlineCmd.ExecuteScalar()

        Dim cashCmd As New OleDbCommand("SELECT SUM(Amount) FROM LabTest WHERE PaymentMethod = 'CASH' AND DateValue(LDate) >= #" & startDateFormatted & "# AND DateValue(LDate) <= #" & endDateFormatted & "#", conn)
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
