Public Class OPD
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim lastSrNo As Integer

    Private Sub OPD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New OleDb.OleDbCommand("SELECT MAX(SerialNo) FROM OPD", conn)

        Dim result As Object = cmd.ExecuteScalar()

        If IsDBNull(result) OrElse result Is Nothing Then
            lastSrNo = 1
        Else
            lastSrNo = CInt(result) + 1
        End If

        txtSerial.Text = lastSrNo.ToString()


        ComboBoxopdtype.SelectedItem = "Normal OPD"
        ComboBoxpaymentmethod.SelectedItem = "CASH"
        rbtnmale.Checked = True
        txtfees.Text = "300"
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

        If txtpatientname.Text.Length = 0 Or txtage.TextLength = 0 Or
       txtaddress.Text.Length = 0 Or txtfees.Text.Length = 0 Or ComboBoxpaymentmethod.Text.Length = 0 Or
       ComboBoxopdtype.Text.Length = 0 Or txtcity.Text.Length = 0 Or txtstate.Text.Length = 0 Then
            MsgBox("All Fields are Mandatory")
            Exit Sub
        ElseIf Not IsNumeric(txtmobile.Text) Or txtmobile.Text.Length <> 10 Then
            MsgBox("Invalid Mobile No.")
            txtmobile.Focus()
            Exit Sub
        End If

        If IsNumeric(txtpatientname.Text) Then
            MsgBox("Patient Name Must be in Alphabets")
        End If

        If Not IsNumeric(txtfees.Text) Then
            MsgBox("Fees must be a positive numeric value")
            txtfees.Focus()
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


        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim odate As String = OPDDate.Value.ToString()



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


        Dim sql As String = "INSERT INTO OPD (SerialNo, PatientName, Age, Address, Fees, PaymentMethod, OPDtype, Gender, ODate, Mobile, City, State, Doctor) " &
                    "VALUES (" & lastSrNo & ", '" & txtpatientname.Text & "'," & CInt(txtage.Text) & ", '" & txtaddress.Text & "', " & CInt(txtfees.Text) & ", '" &
                    ComboBoxpaymentmethod.Text & "', '" & ComboBoxopdtype.Text & "', '" & gender & "', #" & odate & "#, '" &
                    txtmobile.Text & "', '" & txtcity.Text & "', '" & txtstate.Text & "', '" & txtdoctor.Text & "')"




        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Entry Saved Successfully!")


        txtpatientname.Clear()
        txtage.Clear()
        txtaddress.Clear()
        txtcity.Clear()
        txtmobile.Clear()
        txtstate.Clear()
        txtfees.Clear()
        ComboBoxopdtype.SelectedIndex = -1
        ComboBoxpaymentmethod.SelectedIndex = -1
        rbtnmale.Checked = True
        rbtnfemale.Checked = False
        rbtnother.Checked = False


        lastSrNo = CInt(lastSrNo) + 1
        txtSerial.Text = lastSrNo.ToString()


        ComboBoxopdtype.SelectedItem = "Normal OPD"
        ComboBoxpaymentmethod.SelectedItem = "CASH"
        rbtnmale.Checked = True
        txtfees.Text = "300"

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        OPD_Load(sender, e)
    End Sub


    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtpatientname.Clear()

        txtage.Clear()
        txtaddress.Clear()
        txtcity.Clear()
        txtmobile.Clear()
        txtstate.Clear()
        txtfees.Clear()
        ComboBoxopdtype.SelectedIndex = -1
        ComboBoxpaymentmethod.SelectedIndex = -1
        rbtnmale.Checked = True
        rbtnfemale.Checked = False
        rbtnother.Checked = False

        Me.Close()
    End Sub

    Private Sub btnsaveprint_Click(sender As Object, e As EventArgs) Handles btnsaveprint.Click
        If txtpatientname.Text.Length = 0 Or txtage.TextLength = 0 Or
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


        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim odate As String = OPDDate.Value.ToString()



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


        Dim sql As String = "INSERT INTO OPD (SerialNo, PatientName, Age, Address, Fees, PaymentMethod, OPDtype, Gender, ODate, Mobile, City, State, Doctor) " &
                    "VALUES (" & lastSrNo & ", '" & txtpatientname.Text & "'," & CInt(txtage.Text) & ", '" & txtaddress.Text & "', " & CInt(txtfees.Text) & ", '" &
                    ComboBoxpaymentmethod.Text & "', '" & ComboBoxopdtype.Text & "', '" & gender & "', #" & odate & "#, '" &
                    txtmobile.Text & "', '" & txtcity.Text & "', '" & txtstate.Text & "', '" & txtdoctor.Text & "')"




        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Entry Saved Successfully!")

        Dim billForm As New opdbill(lastSrNo)
        Home.LoadForm(billForm)
    End Sub
End Class