Imports System.Data.OleDb

Public Class UpdateXray
    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim selectedSerialNo As Integer = 0

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If conn.State = ConnectionState.Closed Then conn.Open()

        If txtpatient.Text.Length = 0 Or txtage.Text.Length = 0 Or
   txtaddress.Text.Length = 0 Or txtamount.Text.Length = 0 Or
   ComboBoxpaymentmethod.Text.Length = 0 Or txtcity.Text.Length = 0 Then


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
        If txtquantity.Text.Length = 0 Or Not IsNumeric(txtquantity.Text) Then
            MsgBox("Please enter a valid quantity.", MsgBoxStyle.Critical)
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
            MsgBox("Quantity Cannot Be Negative ")
            Exit Sub
        End If

        Dim gender As String = ""
        If rbtnmale.Checked Then
            gender = rbtnmale.Text
        ElseIf rbtnfemale.Checked Then
            gender = rbtnfemale.Text
        ElseIf rbtnother.Checked Then
            gender = rbtnother.Text
        Else
            gender = rbtnmale.Text
        End If

        Dim xrayTypes As String = ""
        For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
            xrayTypes &= CheckedListBox1.CheckedItems(i).ToString()
            If i < CheckedListBox1.CheckedItems.Count - 1 Then
                xrayTypes &= ", "
            End If
        Next

        Dim query As String = "UPDATE Xray SET " &
                              "PatientName = '" & txtpatient.Text & "', " &
                              "Mobile = '" & txtmobile.Text & "', " &
                              "Age = '" & txtage.Text & "', " &
                              "Address = '" & txtaddress.Text & "', " &
                              "Gender = '" & gender & "', " &
                              "XrayType = '" & xrayTypes & "', " &
                              "PaymentMethod = '" & ComboBoxpaymentmethod.Text & "', " &
                              "XDate = #" & xrayd.Value.ToString("MM/dd/yyyy") & "#, " &
                              "City = '" & txtcity.Text & "', " &
                              "Quantity = " & txtquantity.Text & ", " &
                              "Amount = " & txtamount.Text & " " &
                              "WHERE SerialNo = " & selectedSerialNo

        Dim cmd As New OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Record updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        RefreshDataGridView()
        ClearAllFields()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            selectedSerialNo = CInt(row.Cells("SerialNo").Value)

            txtserial.Text = row.Cells("SerialNo").Value.ToString()
            txtpatient.Text = row.Cells("PatientName").Value.ToString()
            txtmobile.Text = row.Cells("Mobile").Value.ToString()
            txtage.Text = row.Cells("Age").Value.ToString()
            txtaddress.Text = row.Cells("Address").Value.ToString()
            ComboBoxpaymentmethod.Text = row.Cells("PaymentMethod").Value.ToString()
            txtcity.Text = row.Cells("City").Value.ToString()
            txtquantity.Text = row.Cells("Quantity").Value.ToString()
            txtamount.Text = row.Cells("Amount").Value.ToString()

            Dim xrayTypes As String = row.Cells("XrayType").Value.ToString()
            Dim i As Integer
            For i = 0 To CheckedListBox1.Items.Count - 1
                If xrayTypes.Contains(CheckedListBox1.Items(i).ToString()) Then
                    CheckedListBox1.SetItemChecked(i, True)
                Else
                    CheckedListBox1.SetItemChecked(i, False)
                End If
            Next i

            Dim parsedDate As DateTime = DateTime.ParseExact(row.Cells("XDate").Value.ToString(), "dd/MM/yyyy", Nothing)
            xrayd.Value = parsedDate

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

    Private Sub ClearAllFields()
        txtserial.Clear()
        txtpatient.Clear()
        txtmobile.Clear()
        txtage.Clear()
        txtaddress.Clear()
        txtcity.Clear()
        txtquantity.Clear()
        txtamount.Clear()
        ComboBoxpaymentmethod.SelectedIndex = -1
        rbtnmale.Checked = False
        rbtnfemale.Checked = False
        rbtnother.Checked = False

        Dim i As Integer
        For i = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next i
    End Sub

    Private Sub RefreshDataGridView()
        If conn.State = ConnectionState.Closed Then conn.Open()

        dt = New DataTable()
        Dim query As String = "SELECT SerialNo, PatientName, Mobile, Age, Address, Gender, XrayType, PaymentMethod, FORMAT(XDate, 'dd/MM/yyyy') AS XDate, City, Quantity, Amount FROM Xray WHERE SerialNo =" & selectedSerialNo

        da = New OleDbDataAdapter(query, conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub btnsearch_Click_1(sender As Object, e As EventArgs) Handles btnsearch.Click
        If conn.State = ConnectionState.Open Then conn.Close()

        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        dt = New DataTable()

        Dim query As String = "SELECT SerialNo, PatientName, Mobile, Age, Address, Gender, XrayType, PaymentMethod, FORMAT(XDate, 'dd/MM/yyyy') AS XDate, City, Quantity, Amount FROM Xray WHERE 1=1"
        If txtserial.Text <> "" Then query &= " AND SerialNo = " & txtserial.Text
        If txtpatientname.Text <> "" Then query &= " AND PatientName LIKE '%" & txtpatientname.Text & "%'"
        If txtmobileno.Text <> "" Then query &= " AND Mobile = '" & txtmobileno.Text & "'"

        conn.Open()
        da = New OleDbDataAdapter(query, conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()

        If dt.Rows.Count = 0 Then
            MessageBox.Show("No records found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub UpdateXray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
    End Sub
End Class
