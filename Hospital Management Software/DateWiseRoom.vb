Imports System.Data.OleDb

Public Class DateWiseRoom
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

    Private Sub DateWiseRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"

        Dim sqlQuery As String = "SELECT SerialNo, PatientName, RoomNo, Floar, " &
                                 "FORMAT(AdmitDate, 'dd-MM-yyyy') AS AdmitDate, " &
                                 "FORMAT(DischargeDate, 'dd-MM-yyyy') AS DischargeDate, " &
                                 "RoomRent, Address, BedNo, Gender, MobileNo " &
                                 "FROM Room WHERE DateValue(AdmitDate) >= #" & startDateFormatted & "# " &
                                 "AND DateValue(AdmitDate) <= #" & endDateFormatted & "#"

        If conn.State = ConnectionState.Closed Then conn.Open()

        da = New OleDbDataAdapter(sqlQuery, conn)
        dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt

        Dim totalCountCmd As New OleDbCommand("SELECT COUNT(*) FROM Room WHERE DateValue(AdmitDate) >= #" & startDateFormatted & "# AND DateValue(DischargeDate) <= #" & endDateFormatted & "#", conn)
        totalroomalloted.Text = CInt(totalCountCmd.ExecuteScalar()).ToString()

        Dim totalRentCmd As New OleDbCommand("SELECT SUM(RoomRent) FROM Room WHERE DateValue(AdmitDate) >= #" & startDateFormatted & "# AND DateValue(DischargeDate) <= #" & endDateFormatted & "#", conn)
        Dim totalFees As Object = totalRentCmd.ExecuteScalar()

        If IsDBNull(totalFees) Then
            totalrentamount.Text = "0"
        Else
            totalrentamount.Text = totalFees.ToString()
        End If

        conn.Close()
    End Sub
End Class
