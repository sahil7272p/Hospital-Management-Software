Imports System.Data.OleDb

Public Class DeleteTest
    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim selectedSerialNo As Integer

    Private Sub DeleteTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"

        TDate.Enabled = False
        ComboBoxpaymentmethod.Enabled = False
        rbtnmale.Enabled = False
        rbtnfemale.Enabled = False
        rbtnother.Enabled = False
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            selectedSerialNo = row.Cells("SerialNo").Value
            txtserial.Text = row.Cells("SerialNo").Value.ToString()
            txtpatient.Text = row.Cells("PatientName").Value.ToString()
            txtmobile.Text = row.Cells("Mobile").Value.ToString()
            txtage.Text = row.Cells("Age").Value.ToString()
            txtselectedtest.Text = row.Cells("TestName").Value.ToString()
            txtaddress.Text = row.Cells("Address").Value.ToString()
            ComboBoxpaymentmethod.Text = row.Cells("PaymentMethod").Value.ToString()
            txtcity.Text = row.Cells("City").Value.ToString()
            txtamount.Text = row.Cells("Amount").Value.ToString()
            txtquantity.Text = row.Cells("Quantity").Value.ToString()

            Dim parsedDate As DateTime = DateTime.ParseExact(row.Cells("TestDate").Value.ToString(), "dd/MM/yyyy", Nothing)
            TDate.Value = parsedDate

            Dim gender As String = row.Cells("Gender").Value.ToString()
            If gender = "Male" Then rbtnmale.Checked = True
            If gender = "Female" Then rbtnfemale.Checked = True
            If gender = "Other" Then rbtnother.Checked = True
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If selectedSerialNo = 0 Then
            MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim sql As String = "DELETE FROM LabTest WHERE SerialNo = " & selectedSerialNo

        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim cmd As New OleDbCommand(sql, conn)
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadData()
        Else
            MessageBox.Show("Deletion failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        conn.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        ClearFields()
        Me.Close()
    End Sub

    Private Sub ClearFields()
        txtserial.Clear()
        txtpatient.Clear()
        txtmobile.Clear()
        txtage.Clear()
        txtaddress.Clear()
        ComboBoxpaymentmethod.SelectedIndex = -1
        txtcity.Clear()
        txtamount.Clear()
        txtselectedtest.Clear()
        txtquantity.Clear()
        TDate.Value = DateTime.Today
        rbtnmale.Checked = False
        rbtnfemale.Checked = False
        rbtnother.Checked = False
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT SerialNo, PatientName, Mobile, Age, Address, Gender, TestName, PaymentMethod, FORMAT(LDate, 'dd/MM/yyyy') AS LDate, City, Quantity, Amount FROM LabTest WHERE SerialNo = " & selectedSerialNo

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        da = New OleDbDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        dt = New DataTable()

        Dim query As String = "SELECT SerialNo, PatientName, Age, Address, PaymentMethod, TestName, Gender, FORMAT(LDate, 'dd/MM/yyyy') AS TestDate, Mobile, City, Amount, Quantity FROM LabTest WHERE 1=1"

        If txtserial.Text <> "" Then
            query &= " AND SerialNo = " & txtserial.Text
        End If

        If txtpatientname.Text <> "" Then
            query &= " AND PatientName LIKE '%" & txtpatientname.Text & "%'"
        End If

        If txtmobileno.Text <> "" Then
            query &= " AND Mobile = '" & txtmobileno.Text & "'"
        End If

        If query = "SELECT SerialNo, PatientName, Age, Address, PaymentMethod, TestName, Gender, FORMAT(LDate, 'dd/MM/yyyy') AS TestDate, Mobile, City, Amount, Quantity FROM LabTest WHERE 1=1" Then
            MessageBox.Show("Please enter at least one search criterion.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
End Class
