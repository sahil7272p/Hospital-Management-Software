Imports System.Data.OleDb
Imports System.Net.NetworkInformation

Public Class Updateroom
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
            selectedSerialNo = Convert.ToInt32(row.Cells("SerialNo").Value)

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

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If selectedSerialNo = 0 Then
            MessageBox.Show("Please select a record from the table to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtpatientname1.Text.Length = 0 Or txtaddress.Text.Length = 0 Or txtmobile.Text.Length = 0 Or ComboBoxfloar.Text.Length = 0 Or
           ComboBoxbedno.Text.Length = 0 Or ComboBoxroomno.Text.Length = 0 Or txtroomrent.Text.Length = 0 Then
            MsgBox("All Fields are Mandatory")
            Exit Sub
        ElseIf Not IsNumeric(txtmobile.Text) Or txtmobile.Text.Length <> 10 Then
            MsgBox("Invalid Mobile No.")
            txtmobile.Focus()
            Exit Sub
        End If

        If Not IsNumeric(ComboBoxbedno.Text) Then
            MsgBox("Bed No. must be a positive numeric value")
            ComboBoxbedno.Focus()
            Exit Sub
        End If

        If Not IsNumeric(ComboBoxroomno.Text) Then
            MsgBox("Room No. must be a numeric value.")
            ComboBoxroomno.Focus()
            Exit Sub
        End If
        If Not IsNumeric(txtroomrent.Text) Then
            MsgBox("Room Rent must be a numeric value.")
            txtroomrent.Focus()
            Exit Sub
        End If

        Dim gender As String
        If rbtnmale.Checked Then
            gender = rbtnmale.Text
        ElseIf rbtnfemale.Checked Then
            gender = rbtnfemale.Text
        ElseIf rbtnother.Checked Then
            gender = rbtnother.Text
        Else
            gender = rbtnmale.Text
        End If

        Dim query As String = "UPDATE Room SET " &
                          "PatientName = '" & txtpatientname1.Text & "', " &
                          "RoomNo = '" & ComboBoxroomno.Text & "', " &
                          "Floar = '" & ComboBoxfloar.Text & "', " &
                          "AdmitDate = #" & admitdate.Value.ToString() & "#, " &
                          "DischargeDate = #" & dischargedate.Value.ToString() & "#, " &
                          "RoomRent = '" & txtroomrent.Text & "', " &
                          "Address = '" & txtaddress.Text & "', " &
                          "BedNo = '" & ComboBoxbedno.Text & "', " &
                          "Gender = '" & gender & "', " &
                          "MobileNo = '" & txtmobile.Text & "' " &
                          "WHERE SerialNo = " & selectedSerialNo

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim cmd As New OleDbCommand(query, conn)
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MessageBox.Show("Record updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshDataGrid(selectedSerialNo)
        Else
            MessageBox.Show("Update failed!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conn.Close()

        txtpatientname1.Clear()
        txtmobile.Clear()
        txtaddress.Clear()
        txtroomrent.Clear()
        ComboBoxfloar.SelectedIndex = -1
        ComboBoxroomno.SelectedIndex = -1
        ComboBoxbedno.SelectedIndex = -1
        admitdate.Value = DateTime.Today
        dischargedate.Value = DateTime.Today
        rbtnmale.Checked = False
        rbtnfemale.Checked = False
        rbtnother.Checked = False
    End Sub

    Private Sub RefreshDataGrid(serialNo As Integer)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim query As String = "SELECT SerialNo, PatientName, RoomNo, Floar, FORMAT(AdmitDate, 'dd/MM/yyyy') AS AdmitDate, FORMAT(DischargeDate, 'dd/MM/yyyy') AS DischargeDate, RoomRent, Address, BedNo, Gender, MobileNo FROM Room WHERE SerialNo = " & serialNo
        da = New OleDbDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt

        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If
        conn.Close()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub Updateroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
    End Sub
End Class
