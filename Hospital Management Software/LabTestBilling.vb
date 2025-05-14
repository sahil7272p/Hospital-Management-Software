Imports System.Data.OleDb

Public Class LabTestBilling
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


    Private Sub btnshowbill_Click(sender As Object, e As EventArgs) Handles btnshowbill.Click
        Dim billform As New labtestbill(selectedSerialNo)
        Home.LoadForm(billform)
    End Sub

    Private Sub LabTestBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"

        TDate.Enabled = False
        ComboBoxpaymentmethod.Enabled = False
        rbtnmale.Enabled = False
        rbtnfemale.Enabled = False
        rbtnother.Enabled = False
    End Sub
End Class