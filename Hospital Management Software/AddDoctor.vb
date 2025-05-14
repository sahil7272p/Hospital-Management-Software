Imports System.Data.OleDb

Public Class AddDoctor

    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim lastSrno As Integer

    Private Sub AddDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        cmd = New OleDbCommand("SELECT MAX(SerialNo) FROM Doctor", conn)

        Dim result As Object = cmd.ExecuteScalar()

        If IsDBNull(result) OrElse result Is Nothing Then
            lastSrno = 1
        Else
            lastSrno = CInt(result) + 1
        End If

        txtSerial.Text = lastSrno.ToString()

        rbtnmale.Checked = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtdoctorname.Text.Length = 0 Or txtqualification.Text.Length = 0 Or
           txtaddress.Text.Length = 0 Or txtexperience.Text.Length = 0 Or txtspecialization.Text.Length = 0 Or
           txtposition.Text.Length = 0 Or txtmobile.Text.Length = 0 Or txtage.Text.Length = 0 Then
            MsgBox("All Fields are Mandatory")
            Exit Sub
        ElseIf Not IsNumeric(txtmobile.Text) Or txtmobile.Text.Length <> 10 Then
            MsgBox("Invalid Mobile No.")
            txtmobile.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtexperience.Text) Then
            MsgBox("Experience must be a positive numeric value")
            txtexperience.Focus()
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

        Dim gender As String
        If rbtnmale.Checked Then
            gender = "Male"
        ElseIf rbtnfemale.Checked Then
            gender = "Female"
        ElseIf rbtnother.Checked Then
            gender = "Other"
        Else
            gender = "Male"
        End If

        Dim sql As String = "INSERT INTO Doctor (DoctorName, Qualification, Specialization, Experience, [Position], [Age], Mobile, Address, Gender) " &
                            "VALUES ('" & txtdoctorname.Text & "', '" & txtqualification.Text & "', '" & txtspecialization.Text & "', " &
                            CInt(txtexperience.Text) & ", '" & txtposition.Text & "', " & CInt(txtage.Text) & ", '" & txtmobile.Text & "', '" & txtaddress.Text & "', '" & gender & "')"

        cmd = New OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Entry Saved Successfully!")

        txtdoctorname.Clear()
        txtqualification.Clear()
        txtexperience.Clear()
        txtposition.Clear()
        txtmobile.Clear()
        txtaddress.Clear()
        txtage.Clear()
        txtspecialization.Clear()

        rbtnmale.Checked = True
        rbtnfemale.Checked = False
        rbtnother.Checked = False

        lastSrno += 1
        txtSerial.Text = lastSrno.ToString()
    End Sub
End Class
