Public Class ViewAllRoom

    Dim conn As New OleDb.OleDbConnection
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim cb As OleDb.OleDbCommandBuilder

    Private Sub ViewAllRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim Sql As String = "SELECT SerialNo, PatientName, RoomNo, Floar, " &
                            "FORMAT(AdmitDate, 'dd-MM-yyyy') AS AdmitDate, " &
                            "FORMAT(DischargeDate, 'dd-MM-yyyy') AS DischargeDate, " &
                            "RoomRent, Address, BedNo, Gender, MobileNo FROM Room"

        da = New OleDb.OleDbDataAdapter(Sql, conn)
        cb = New OleDb.OleDbCommandBuilder(da)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt

        Dim totalCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM Room", conn)
        Dim totalRoomCount As Integer = CInt(totalCmd.ExecuteScalar())
        totalroomalloted.Text = totalRoomCount.ToString()

        Dim feesCmd As New OleDb.OleDbCommand("SELECT SUM(RoomRent) FROM Room", conn)
        Dim totalFees As Object = feesCmd.ExecuteScalar()

        If IsDBNull(totalFees) Then
            totalrentamount.Text = "0"
        Else
            totalrentamount.Text = totalFees.ToString()
        End If

        conn.Close()
    End Sub

End Class
