Imports System.Data.OleDb

Public Class ViewDoctor
    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim Serial As Integer

    Private Sub ViewDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If


        Dim Sql As String = "SELECT * FROM Doctor"
        da = New OleDbDataAdapter(Sql, conn)
        dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt

        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtdoctorname.Text = row.Cells("DoctorName").Value.ToString()
            txtqualification.Text = row.Cells("Qualification").Value.ToString()
            txtspecialization.Text = row.Cells("Specialization").Value.ToString()
            txtexperience.Text = row.Cells("Experience").Value.ToString()
            txtposition.Text = row.Cells("Position").Value.ToString()
            txtage.Text = row.Cells("Age").Value.ToString()
            txtaddress.Text = row.Cells("Address").Value.ToString()
            txtmobile.Text = row.Cells("Mobile").Value.ToString()
            Serial = CInt(row.Cells("SerialNo").Value)


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

        Dim Sql As String = "UPDATE Doctor SET " &
                        "DoctorName = '" & txtdoctorname.Text & "', " &
                        "Qualification = '" & txtqualification.Text & "', " &
                        "Specialization = '" & txtspecialization.Text & "', " &
                        "Experience = " & CInt(txtexperience.Text) & ", " &
                        "[Position] = '" & txtposition.Text & "', " &
                        "Age = " & CInt(txtage.Text) & ", " &
                        "Mobile = '" & txtmobile.Text & "', " &
                        "Address = '" & txtaddress.Text & "', " &
                        "Gender = '" & gender & "' " &
                        "WHERE SerialNo = " & Serial

        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim cmd As New OleDbCommand(Sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Record Updated Successfully")
        ClearFields()
        ViewDoctor_Load(sender, e)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If Serial = 0 Then
            MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim Sql As String = "DELETE FROM Doctor WHERE SerialNo = " & Serial

        If conn.State = ConnectionState.Closed Then conn.Open()
        Dim cmd As New OleDbCommand(Sql, conn)
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Record Deleted Successfully")
        ClearFields()
        ViewDoctor_Load(sender, e)
    End Sub

    Private Sub ClearFields()
        txtdoctorname.Clear()
        txtqualification.Clear()
        txtspecialization.Clear()
        txtexperience.Clear()
        txtposition.Clear()
        txtage.Clear()
        txtaddress.Clear()
        txtmobile.Clear()
        rbtnmale.Checked = False
        rbtnfemale.Checked = False
        rbtnother.Checked = False
        Serial = 0
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class
