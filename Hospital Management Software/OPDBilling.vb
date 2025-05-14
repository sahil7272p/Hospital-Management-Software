Imports System.Data.OleDb

Public Class OPDBilling
    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim selectedSerialNo As Integer


    Private Sub OPDBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        ComboBoxpaymentmethod.Enabled = False
        ComboBoxopdtype.Enabled = False

        rbtnmale.Enabled = False
        rbtnfemale.Enabled = False
        rbtnother.Enabled = False
    End Sub


    Private Sub btnshowbill_Click(sender As Object, e As EventArgs) Handles btnshowbill.Click
        Dim billform As New opdbill(selectedSerialNo)
        Home.LoadForm(billform)
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
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
End Class

