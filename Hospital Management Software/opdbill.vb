Imports System.Data.OleDb
Imports Microsoft.VisualBasic.PowerPacks
Imports Microsoft.VisualBasic.PowerPacks.Printing

Public Class opdbill
    Dim Serial As Integer
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Private PrintForm1 As New PrintForm(Me)

    Public Sub New(ByVal serialNo As Integer)
        InitializeComponent()
        Serial = serialNo
    End Sub

    Private Sub opdbill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim sql As String = "SELECT SerialNo, PatientName, Age, Address, Fees, PaymentMethod, OPDtype, Gender, FORMAT(ODate, 'dd/MM/yyyy') AS OPD_Date, Mobile, City, State, Doctor FROM OPD WHERE SerialNo = " & Serial
        cmd = New OleDbCommand(sql, conn)

        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            lblpatientname.Text = reader("PatientName").ToString()
            lblage.Text = reader("Age").ToString()
            lblgender.Text = reader("Gender").ToString()
            lblpaymentmethod.Text = reader("PaymentMethod").ToString()
            lblfees3.Text = reader("Fees").ToString()
            lblpatientname2.Text = reader("PatientName").ToString()
            lblmobileno.Text = reader("Mobile").ToString()
            lbldate.Text = reader("OPD_Date").ToString()
            lblfees.Text = reader("Fees").ToString()
            lbladdress.Text = reader("Address").ToString()
            lblopdtype.Text = reader("OPDType").ToString()
            lblserial.Text = reader("SerialNo").ToString()
            lblfees2.Text = reader("Fees").ToString()
            lbldoctor.Text = reader("Doctor").ToString()
            lblcity.Text = reader("City").ToString()
        Else
            MessageBox.Show("Patient not found.")
        End If

        reader.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        btnprint.Visible = False
        Me.Refresh()
        PrintForm1.Print()
        btnprint.Visible = True
    End Sub


End Class
