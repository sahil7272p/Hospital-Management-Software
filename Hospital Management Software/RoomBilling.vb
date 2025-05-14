Imports System.Data.OleDb

Public Class RoomBilling
    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
        Dim dt As DataTable
        Dim selectedSerialNo As Integer


    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        dt = New DataTable()

        Dim query As String = "SELECT SerialNo, PatientName, RoomNo, Floar, FORMAT(AdmitDate, 'dd/MM/yyyy') AS AdmitDate, FORMAT(DischargeDate, 'dd/MM/yyyy') AS DischargeDate, RoomRent, Address, BedNo, Gender, MobileNo FROM Room WHERE 1 = 1"
        If txtroomno.Text <> "" Then
            query &= " And RoomNo = " & txtroomno.Text
        End If
        If txtpatientname.Text <> "" Then
            query &= " And PatientName Like '%" & txtpatientname.Text & "%'"
        End If
        If txtmobileno.Text <> "" Then
            query &= " AND MobileNo = '" & txtmobileno.Text & "'"
        End If

        If query = "SELECT SerialNo, PatientName, RoomNo, Floar, FORMAT(AdmitDate, 'dd/MM/yyyy') AS AdmitDate, FORMAT(DischargeDate, 'dd/MM/yyyy') AS DischargeDate, RoomRent, Address, BedNo, Gender, MobileNo FROM Room WHERE 1 = 1" Then
            MessageBox.Show("Please enter at least one search criterion.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()
            Exit Sub
        End If

        da = New OleDbDataAdapter(query, conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt

        If dt.Rows.Count = 0 Then
            MessageBox.Show("No records found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        conn.Close()
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            selectedSerialNo = CInt(row.Cells("SerialNo").Value)

            txtpatientname1.Text = row.Cells("PatientName").Value.ToString()
            txtmobile.Text = row.Cells("MobileNo").Value.ToString()
            txtaddress.Text = row.Cells("Address").Value.ToString()
            txtroomrent.Text = row.Cells("RoomRent").Value.ToString()
            ComboBoxfloar.Text = row.Cells("Floar").Value.ToString()
            ComboBoxroomno.Text = row.Cells("RoomNo").Value.ToString()
            ComboBoxbedno.Text = row.Cells("BedNo").Value.ToString()

            Dim parsedDate As DateTime = DateTime.ParseExact(row.Cells("AdmitDate").Value.ToString(), "dd/MM/yyyy", Nothing)
            admitdate.Value = parsedDate

            Dim parsedDate1 As DateTime = DateTime.ParseExact(row.Cells("DischargeDate").Value.ToString(), "dd/MM/yyyy", Nothing)
            dischargedate.Value = parsedDate1

            Dim gender As String = row.Cells("Gender").Value.ToString()
            If gender = "Male" Then
                rbtnmale.Checked = True
            ElseIf gender = "Female" Then
                rbtnfemale.Checked = True
            ElseIf gender = "Other" Then
                rbtnother.Checked = True
            End If
        End If

        txtpatientname.Clear()
        txtmobileno.Clear()
        txtroomno.Clear()
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Dim billform As New RoomBill(selectedSerialNo)
        Home.LoadForm(billform)
    End Sub

    Private Sub RoomBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"

        ComboBoxfloar.Enabled = False
        ComboBoxroomno.Enabled = False
        ComboBoxbedno.Enabled = False
        admitdate.Enabled = False
        dischargedate.Enabled = False
        rbtnmale.Checked = False
        rbtnfemale.Checked = False
        rbtnother.Checked = False
    End Sub
End Class
