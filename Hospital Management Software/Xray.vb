Imports System.Data.OleDb
Imports System.Net.NetworkInformation

Public Class Xray
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim lastSrNo As Integer


    Private Sub Xray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd = New OleDb.OleDbCommand("SELECT MAX(SerialNo) FROM Xray", conn)
        lastSrNo = cmd.ExecuteScalar()

        If IsDBNull(lastSrNo) Then
            lastSrNo = 1
        Else
            lastSrNo = CInt(lastSrNo) + 1
        End If

        txtSerial.Text = lastSrNo.ToString()


        ComboBoxpaymentmethod.SelectedItem = "CASH"
        rbtnmale.Checked = True
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtpatientname.Text.Length = 0 Or txtage.Text.Length = 0 Or
   txtaddress.Text.Length = 0 Or txtamount.Text.Length = 0 Or
   ComboBoxpaymentmethod.Text.Length = 0 Or
   txtcity.Text.Length = 0 Then

            MsgBox("All Fields are Mandatory", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Not IsNumeric(txtmobile.Text) OrElse txtmobile.Text.Length <> 10 Then
            MsgBox("Invalid Mobile No.", MsgBoxStyle.Critical)
            txtmobile.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtamount.Text) OrElse CInt(txtamount.Text) <= 0 Then
            MsgBox("Amount must be a positive numeric value", MsgBoxStyle.Critical)
            txtamount.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtage.Text) OrElse CInt(txtage.Text) > 105 Then
            MsgBox("Age must be a valid number (less than 105)", MsgBoxStyle.Critical)
            txtage.Focus()
            Exit Sub
        End If

        If (CheckedListBox1.CheckedItems.Count <> CInt(txtquantity.Text)) Then
            MsgBox("Checked Items and Quantity Must be Same")
            txtquantity.Focus()
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


        Dim xrayTypes As String = ""

        For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
            xrayTypes &= CheckedListBox1.CheckedItems(i).ToString()
            If i < CheckedListBox1.CheckedItems.Count - 1 Then
                xrayTypes &= ", "
            End If
        Next



        Dim query As String = "INSERT INTO Xray (SerialNo, PatientName, Age, Address, PaymentMethod, Xraytype, Gender, XDate, Mobile, City, Quantity, Amount) VALUES (" &
    txtSerial.Text & ", '" &
    txtpatientname.Text & "', " &
    txtage.Text & ", '" &
    txtaddress.Text & "', '" &
    ComboBoxpaymentmethod.Text & "', '" &
    xrayTypes & "', '" &
    gender & "', #" &
    xrayd.Value.ToString() & "#, '" &
    txtmobile.Text & "', '" &
    txtcity.Text & "', " &
    txtquantity.Text & ", " &
    txtamount.Text & ")"

        cmd = New OleDb.OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()



        MessageBox.Show("Entry Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        ClearFields()


        lastSrNo = CInt(lastSrNo) + 1
        txtSerial.Text = lastSrNo.ToString()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Xray_Load(sender, e)
    End Sub

    Private Sub ClearFields()
        txtpatientname.Clear()
        txtage.Clear()
        txtaddress.Clear()
        txtcity.Clear()
        txtmobile.Clear()
        txtamount.Clear()
        ComboBoxpaymentmethod.SelectedIndex = -1
        txtamount.Clear()
        txtquantity.Clear()

        rbtnmale.Checked = True
        rbtnfemale.Checked = False
        rbtnother.Checked = False
        xrayd.Value = Now

        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtpatientname.Text.Length = 0 Or txtage.Text.Length = 0 Or
   txtaddress.Text.Length = 0 Or txtamount.Text.Length = 0 Or
   ComboBoxpaymentmethod.Text.Length = 0 Or
   txtcity.Text.Length = 0 Then

            MsgBox("All Fields are Mandatory", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Not IsNumeric(txtmobile.Text) OrElse txtmobile.Text.Length <> 10 Then
            MsgBox("Invalid Mobile No.", MsgBoxStyle.Critical)
            txtmobile.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtamount.Text) OrElse CInt(txtamount.Text) <= 0 Then
            MsgBox("Amount must be a positive numeric value", MsgBoxStyle.Critical)
            txtamount.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtage.Text) OrElse CInt(txtage.Text) > 105 Then
            MsgBox("Age must be a valid number (less than 105)", MsgBoxStyle.Critical)
            txtage.Focus()
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


        Dim xrayTypes As String = ""

        For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
            xrayTypes &= CheckedListBox1.CheckedItems(i).ToString()
            If i < CheckedListBox1.CheckedItems.Count - 1 Then
                xrayTypes &= ", "
            End If
        Next



        Dim query As String = "INSERT INTO Xray (SerialNo, PatientName, Age, Address, PaymentMethod, Xraytype, Gender, XDate, Mobile, City, Quantity, Amount) VALUES (" &
    txtSerial.Text & ", '" &
    txtpatientname.Text & "', " &
    txtage.Text & ", '" &
    txtaddress.Text & "', '" &
    ComboBoxpaymentmethod.Text & "', '" &
    xrayTypes & "', '" &
    gender & "', #" &
    xrayd.Value.ToString() & "#, '" &
    txtmobile.Text & "', '" &
    txtcity.Text & "', " &
    txtquantity.Text & ", " &
    txtamount.Text & ")"
        lastSrNo = CInt(txtSerial.Text)


        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New OleDb.OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()



        MessageBox.Show("Entry Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim billForm As New xraybill(lastSrNo)
        Home.LoadForm(billForm)
    End Sub
End Class
