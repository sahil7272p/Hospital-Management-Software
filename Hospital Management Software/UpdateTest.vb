Imports System.Data.OleDb

Public Class UpdateTest

    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim selectedSerialNo As Integer

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

        If query = "SELECT SerialNo, PatientName, Age, Address, PaymentMethod, TestName, Gender, FORMAT(LDate, 'dd/MM/yyyy') AS TestDate, Mobile, City, Amount, Quantity FROM LabTest WHERE 1 = 1" Then
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            selectedSerialNo = row.Cells("SerialNo").Value
            txtserial.Text = row.Cells("SerialNo").Value.ToString()
            txtpatient.Text = row.Cells("PatientName").Value.ToString()
            txtmobile.Text = row.Cells("Mobile").Value.ToString()
            txtage.Text = row.Cells("Age").Value.ToString()
            txtaddress.Text = row.Cells("Address").Value.ToString()
            ComboBoxpaymentmethod.Text = row.Cells("PaymentMethod").Value.ToString()
            txtcity.Text = row.Cells("City").Value.ToString()
            txtamount.Text = row.Cells("Amount").Value.ToString()
            txtquantity.Text = row.Cells("Quantity").Value.ToString()


            Dim parsedDate As DateTime = DateTime.ParseExact(row.Cells("TestDate").Value.ToString(), "dd/MM/yyyy", Nothing)
            TDate.Value = parsedDate

            Dim testTypes As String = row.Cells("TestName").Value.ToString()
            Dim i As Integer
            For i = 0 To CheckedListBox1.Items.Count - 1
                If testTypes.Contains(CheckedListBox1.Items(i).ToString()) Then
                    CheckedListBox1.SetItemChecked(i, True)
                Else
                    CheckedListBox1.SetItemChecked(i, False)
                End If
            Next i

            Dim gender As String = row.Cells("Gender").Value.ToString()
            If gender = "Male" Then
                rbtnmale.Checked = True
            ElseIf gender = "Female" Then
                rbtnfemale.Checked = True
            ElseIf gender = "Other" Then
                rbtnother.Checked = True
            End If
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtpatient.Text = "" Or txtage.Text = "" Or txtaddress.Text = "" Or txtamount.Text = "" Or ComboBoxpaymentmethod.Text = "" Or txtcity.Text = "" Then
            MsgBox("All Fields are Mandatory", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Not IsNumeric(txtmobile.Text) Or txtmobile.Text.Length <> 10 Then
            MsgBox("Invalid Mobile No.", MsgBoxStyle.Critical)
            txtmobile.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtamount.Text) Or CInt(txtamount.Text) <= 0 Then
            MsgBox("Amount must be a positive numeric value", MsgBoxStyle.Critical)
            txtamount.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtage.Text) Or CInt(txtage.Text) > 105 Then
            MsgBox("Age must be a valid number (less than 105)", MsgBoxStyle.Critical)
            txtage.Focus()
            Exit Sub
        End If

        If CheckedListBox1.CheckedItems.Count <> CInt(txtquantity.Text) Then
            MsgBox("Checked Items and Quantity Must be Same")
            txtquantity.Focus()
            Exit Sub
        End If
        If Not Val(txtamount.Text) > 0 Then
            MsgBox("Negative Amount is Not Valid")
            Exit Sub
        End If
        If Not Val(txtmobile.Text) > 0 Then
            MsgBox("Invalid Mobile Number")
            Exit Sub
        End If
        If Not Val(txtage.Text) > 0 Then
            MsgBox("Age Cannot Be Negative ")
            Exit Sub
        End If

        If Not Val(txtquantity.Text) > 0 Then
            MsgBox("Quantity Cannot  Be Negative ")
            Exit Sub
        End If

        Dim gender As String
        If rbtnmale.Checked Then
            gender = "Male"
        ElseIf rbtnfemale.Checked Then
            gender = "Female"
        ElseIf rbtnother.Checked Then
            gender = "Other"
        Else
            gender = ""
        End If

        Dim testTypes As String = ""
        Dim i As Integer
        For i = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(i) Then
                If testTypes <> "" Then
                    testTypes &= ", "
                End If
                testTypes &= CheckedListBox1.Items(i).ToString()
            End If
        Next i

        Dim query As String = "UPDATE LabTest SET PatientName='" & txtpatient.Text & "', " &
                              "Mobile='" & txtmobile.Text & "', Age=" & txtage.Text & ", " &
                              "Address='" & txtaddress.Text & "', Gender='" & gender & "', " &
                              "PaymentMethod='" & ComboBoxpaymentmethod.Text & "', " &
                              "LDate=#" & TDate.Value.ToString() & "#, City='" & txtcity.Text & "', " &
                              "Quantity=" & txtquantity.Text & ", Amount=" & txtamount.Text & ", " &
                              "TestName='" & testTypes & "' WHERE SerialNo=" & selectedSerialNo

        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim cmd As New OleDbCommand(query, conn)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Record updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshDataGrid(selectedSerialNo)
            ClearAllFields()
        Else
            MessageBox.Show("Update failed!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conn.Close()
    End Sub

    Private Sub RefreshDataGrid(serialNo As Integer)
        If conn.State = ConnectionState.Closed Then conn.Open()

        Dim query As String = "SELECT SerialNo, PatientName, Age, Address, PaymentMethod, TestName, Gender, FORMAT(LDate, 'dd/MM/yyyy') AS TestDate, Mobile, City, Quantity, Amount FROM LabTest WHERE SerialNo =" & selectedSerialNo

        da = New OleDbDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt

        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If

        conn.Close()
    End Sub

    Private Sub ClearAllFields()
        txtserial.Clear()
        txtpatient.Clear()
        txtmobile.Clear()
        txtage.Clear()
        txtaddress.Clear()
        txtcity.Clear()
        txtamount.Clear()
        txtquantity.Clear()
        txtpatientname.Clear()
        txtmobileno.Clear()
        ComboBoxpaymentmethod.SelectedIndex = -1
        TDate.Value = DateTime.Today
        rbtnmale.Checked = False
        rbtnfemale.Checked = False
        rbtnother.Checked = False

        Dim i As Integer
        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next i

        DataGridView1.Refresh()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub UpdateTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"

    End Sub
End Class
