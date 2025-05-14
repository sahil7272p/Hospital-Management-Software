Imports System.Data.OleDb

Public Class XrayBilling

    Dim conn As New OleDbConnection
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Dim selectedSerialNo As Integer

    Private Sub XrayBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"

        xrayd.Enabled = False
        ComboBoxpaymentmethod.Enabled = False
        rbtnmale.Enabled = False
        rbtnfemale.Enabled = False
        rbtnother.Enabled = False
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridView1.Rows(e.RowIndex)

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
            txtxraytype.Text = row.Cells("Xraytype").Value.ToString()

            Dim parsedDate As DateTime
            parsedDate = DateTime.ParseExact(row.Cells("XDate").Value.ToString(), "dd/MM/yyyy", Nothing)
            xrayd.Value = parsedDate

            Dim gender As String
            gender = row.Cells("Gender").Value.ToString()
            If gender = "Male" Then
                rbtnmale.Checked = True
            ElseIf gender = "Female" Then
                rbtnfemale.Checked = True
            ElseIf gender = "Other" Then
                rbtnother.Checked = True
            End If
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        ClearFields()
        Me.Close()
    End Sub

    Private Sub ClearFields()
        txtserial.Clear()
        txtpatient.Clear()
        txtmobile.Clear()
        txtage.Clear()
        txtaddress.Clear()
        ComboBoxpaymentmethod.SelectedIndex = -1
        txtcity.Clear()
        txtamount.Clear()
        txtxraytype.Clear()
        txtquantity.Clear()
        xrayd.Value = DateTime.Today
        rbtnmale.Checked = False
        rbtnfemale.Checked = False
        rbtnother.Checked = False
    End Sub

    Private Sub btnshowbill_Click(sender As Object, e As EventArgs) Handles btnshowbill.Click
        Dim billform As New xraybill(selectedSerialNo)
        Home.LoadForm(billform)
    End Sub


    Private Sub btnsearch_Click_2(sender As Object, e As EventArgs) Handles btnsearch.Click
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
End Class
