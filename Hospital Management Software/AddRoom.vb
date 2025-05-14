Imports System.Net.NetworkInformation

Public Class AddRoom
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim lastSrNo As Integer

    Private Sub AddRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New OleDb.OleDbCommand("SELECT MAX(SerialNo) FROM Room", conn)

        Dim result = cmd.ExecuteScalar()

        If IsDBNull(result) OrElse result Is Nothing Then
            lastSrNo = 1
        Else
            lastSrNo = CInt(result) + 1
        End If

        txtSerial.Text = lastSrNo.ToString()
        rbtnmale.Checked = True
        admitdate.Value = DateTime.Today
        dischargedate.Value = DateTime.Today

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtpatientname.Text.Length = 0 Or txtaddress.Text.Length = 0 Or txtmobileno.Text.Length = 0 Or ComboBoxfloar.Text.Length = 0 Or
           ComboBoxbedno.Text.Length = 0 Or ComboBoxroomno.Text.Length = 0 Or txtroomrent.Text.Length = 0 Then
            MsgBox("All Fields are Mandatory")
            Exit Sub
        ElseIf Not IsNumeric(txtmobileno.Text) Or txtmobileno.Text.Length <> 10 Then
            MsgBox("Invalid Mobile No.")
            txtmobileno.Focus()
            Exit Sub
        End If


        If Not IsNumeric(txtroomrent.Text) Then
            MsgBox("Room Rent. must be a numeric value.")
            txtroomrent.Focus()
            Exit Sub
        End If
        If Not Val(txtroomrent.Text) > 0 Then
            MsgBox("Room Rent. must be a Positive.")
            txtroomrent.Focus()
            Exit Sub
        End If

        If Not Val(txtmobileno.Text) > 0 Then
            MsgBox("Invalid Mobile Number")
            Exit Sub
        End If



        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim admitd As String = admitdate.Value.ToString()
        Dim discharged As String = dischargedate.Value.ToString()

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

        Dim sql As String = "INSERT INTO Room (SerialNo, PatientName, RoomNo, Floar, AdmitDate, DischargeDate, RoomRent, Address, BedNo, Gender, MobileNo) " &
                    "VALUES (" & lastSrNo & ", '" & txtpatientname.Text & "', " & CInt(ComboBoxroomno.Text) & ", '" & ComboBoxfloar.Text & "', #" & admitd & "#, #" &
                    discharged & "#, " & CInt(txtroomrent.Text) & ", '" & txtaddress.Text & "', " & CInt(ComboBoxbedno.Text) & ", '" &
                    gender & "', '" & txtmobileno.Text & "')"

        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Entry Saved Successfully!")

        txtpatientname.Clear()
        ComboBoxroomno.SelectedIndex = -1
        txtaddress.Clear()
        txtmobileno.Clear()
        ComboBoxbedno.SelectedIndex = -1
        txtroomrent.Clear()
        ComboBoxfloar.SelectedIndex = -1
        rbtnmale.Checked = True
        rbtnfemale.Checked = False
        rbtnother.Checked = False


        lastSrNo = CInt(lastSrNo) + 1
        txtSerial.Text = lastSrNo.ToString()

        ComboBoxfloar.SelectedItem = "Ground Floar"

        rbtnmale.Checked = True


        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        AddRoom_Load(sender, e)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        txtpatientname.Clear()
        ComboBoxroomno.SelectedIndex = -1
        txtaddress.Clear()
        txtmobileno.Clear()
        ComboBoxbedno.SelectedIndex = -1
        txtroomrent.Clear()
        ComboBoxfloar.SelectedIndex = -1
        rbtnmale.Checked = True
        rbtnfemale.Checked = False
        rbtnother.Checked = False


        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtpatientname.Text.Length = 0 Or txtaddress.Text.Length = 0 Or txtmobileno.Text.Length = 0 Or ComboBoxfloar.Text.Length = 0 Or
           ComboBoxbedno.Text.Length = 0 Or ComboBoxroomno.Text.Length = 0 Or CInt(txtroomrent.Text.Length) = 0 Then
            MsgBox("All Fields are Mandatory")
            Exit Sub
        ElseIf Not IsNumeric(txtmobileno.Text) Or txtmobileno.Text.Length <> 10 Then
            MsgBox("Invalid Mobile No.")
            txtmobileno.Focus()
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
            MsgBox("Room Rent. must be a numeric value.")
            txtroomrent.Focus()
            Exit Sub
        End If

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim admitd As String = admitdate.Value.ToString()
        Dim discharged As String = dischargedate.Value.ToString()

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

        Dim sql As String = "INSERT INTO Room (SerialNo, PatientName, RoomNo, Floar, AdmitDate, DischargeDate, RoomRent, Address, BedNo, Gender, MobileNo) " &
                    "VALUES (" & lastSrNo & ", '" & txtpatientname.Text & "', " & CInt(ComboBoxroomno.Text) & ", '" & ComboBoxfloar.Text & "', #" & admitd & "#, #" &
                    discharged & "#, " & CInt(txtroomrent.Text) & ", '" & txtaddress.Text & "', " & CInt(ComboBoxbedno.Text) & ", '" &
                    gender & "', '" & txtmobileno.Text & "')"

        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Entry Saved Successfully!")

        Dim billForm As New RoomBill(lastSrNo)
        Home.LoadForm(billForm)

    End Sub
End Class
