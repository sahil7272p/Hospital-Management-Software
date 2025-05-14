Imports System.Data.OleDb

Public Class UpdateOPD
    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim selectedSerialNo As Integer

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If


        dt = New DataTable()

        Dim query As String = "SELECT SerialNo, PatientName, Mobile, Age, Address, Gender, OPDtype, Fees, PaymentMethod, FORMAT(ODate, 'dd/MM/yyyy') AS ODate, City, State, Doctor FROM OPD WHERE 1=1"
        If txtserial.Text.Trim() <> "" Then
            query &= " AND SerialNo = " & txtserial.Text.Trim()
        End If
        If txtpatientname.Text.Trim() <> "" Then
            query &= " AND PatientName LIKE '%" & txtpatientname.Text.Trim() & "%'"
        End If
        If txtmobileno.Text.Trim() <> "" Then
            query &= " AND Mobile = '" & txtmobileno.Text.Trim() & "'"
        End If

        If query = "SELECT SerialNo, PatientName, Age, Address, Fees, PaymentMethod, OPDtype, Gender, ODate, Mobile, City, State, Doctor FROM OPD WHERE 1 = 1" Then
            MessageBox.Show("Please enter at least one search criterion.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        da = New OleDbDataAdapter(query, conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No records found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtserial.Text = row.Cells("SerialNo").Value.ToString()
            txtpatientnamedgv.Text = row.Cells("PatientName").Value.ToString()
            txtmobile.Text = row.Cells("Mobile").Value.ToString()
            txtage.Text = row.Cells("Age").Value.ToString()
            txtaddress.Text = row.Cells("Address").Value.ToString()
            ComboBoxopdtype.Text = row.Cells("OPDtype").Value.ToString()
            txtfees.Text = row.Cells("Fees").Value.ToString()
            ComboBoxpaymentmethod.Text = row.Cells("PaymentMethod").Value.ToString()
            txtcity.Text = row.Cells("City").Value.ToString()
            txtstate.Text = row.Cells("State").Value.ToString()
            selectedSerialNo = CInt(row.Cells("SerialNo").Value)

            Dim parsedDate As DateTime = DateTime.ParseExact(row.Cells("ODate").Value.ToString(), "dd/MM/yyyy", Nothing)
            OPDDate.Value = parsedDate


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
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        If txtpatientnamedgv.Text.Length = 0 Or txtage.TextLength = 0 Or
       txtaddress.Text.Length = 0 Or txtfees.Text.Length = 0 Or ComboBoxpaymentmethod.Text.Length = 0 Or
       ComboBoxopdtype.Text.Length = 0 Or txtcity.Text.Length = 0 Or txtstate.Text.Length = 0 Then
            MsgBox("All Fields are Mandatory")
            Exit Sub
        ElseIf Not IsNumeric(txtmobile.Text) Or txtmobile.Text.Length <> 10 Then
            MsgBox("Invalid Mobile No.")
            txtmobile.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtfees.Text) Then
            MsgBox("Fees must be a positive numeric value")
            txtfees.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtage.Text) Then
            MsgBox("Age must be a numeric value.")
            txtage.Focus()
            Exit Sub
        End If

        If CInt(txtage.Text) > 105 Then
            MsgBox("Age must be less than or equal to 105.")
            txtage.Focus()
            Exit Sub
        End If

        If Not Val(txtfees.Text) > 0 Then
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

        Dim query As String = "UPDATE OPD SET PatientName='" & txtpatientnamedgv.Text &
                      "', Mobile='" & txtmobile.Text &
                      "', Age=" & txtage.Text &
                      ", Address='" & txtaddress.Text &
                      "', Gender='" & gender &
                      "', OPDtype='" & ComboBoxopdtype.Text &
                      "', Fees=" & txtfees.Text &
                      ", PaymentMethod='" & ComboBoxpaymentmethod.Text &
                      "', ODate=#" & OPDDate.Value.ToString("MM/dd/yyyy") &
                      "#, City='" & txtcity.Text &
                      "', State='" & txtstate.Text &
                      "' WHERE SerialNo=" & selectedSerialNo



        Dim cmd As New OleDbCommand(query, conn)
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MsgBox("Record updated successfully.")
            RefreshDataGrid(selectedSerialNo)
        Else
            MsgBox("Update failed.")
        End If

        txtserial.Clear()
        txtpatientnamedgv.Clear()
        txtmobile.Clear()
        txtage.Clear()
        txtaddress.Clear()
        ComboBoxopdtype.Text = ""
        txtfees.Clear()
        ComboBoxpaymentmethod.Text = ""
        OPDDate.Value = Date.Today
        txtcity.Clear()
        txtstate.Clear()
        rbtnmale.Checked = False
        rbtnfemale.Checked = False
        rbtnother.Checked = False
    End Sub



    Private Sub RefreshDataGrid(serialNo As Integer)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim query As String = "SELECT SerialNo, PatientName, Mobile, Age, Address, Gender, OPDtype, Fees, PaymentMethod, FORMAT(ODate, 'dd/MM/yyyy') AS ODate, City, State, Doctor FROM OPD WHERE SerialNo = " & serialNo
        da = New OleDbDataAdapter(query, conn)
        dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt

        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If
    End Sub


    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    Private Sub UpdateOPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
    End Sub


End Class
