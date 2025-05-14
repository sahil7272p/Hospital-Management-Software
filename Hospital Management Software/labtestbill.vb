Imports Microsoft.VisualBasic.PowerPacks.Printing
Imports System.Data.OleDb

Public Class labtestbill
    Dim Serial As Integer
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Private PrintForm1 As New PrintForm(Me)

    Public Sub New(ByVal serialNo As Integer)
        InitializeComponent()
        Serial = serialNo
    End Sub

    Private Sub labtestbill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim Sql As String = "SELECT SerialNo, PatientName, Age, Address, PaymentMethod, TestName, Gender, FORMAT(LDate, 'dd/MM/yyyy') AS TestDate, Mobile, City, Amount, Quantity FROM LabTest WHERE SerialNo = " & Serial
        cmd = New OleDbCommand(Sql, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            lblpatientname.Text = reader("PatientName").ToString()
            lblage.Text = reader("Age").ToString()
            lblgender.Text = reader("Gender").ToString()
            lblpaymentmethod.Text = reader("PaymentMethod").ToString()
            lblmobileno.Text = reader("Mobile").ToString()
            lbldate.Text = reader("TestDate").ToString()
            lblfees.Text = reader("Amount").ToString()
            lbladdress.Text = reader("Address").ToString()
            lbltestname.Text = reader("TestName").ToString()
            lblserial.Text = reader("SerialNo").ToString()
            lblfees2.Text = reader("Amount").ToString()
            lblcity.Text = reader("City").ToString()
            lblquantity.Text = reader("Quantity").ToString()
            lblfees3.Text = reader("Amount").ToString
            lblpatientname2.Text = reader("PatientName").ToString

        Else
            MessageBox.Show("Patient not found.")
        End If

        reader.Close()
        conn.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        btnprint.Visible = False
        Me.Refresh()
        PrintForm1.Print()
        btnprint.Visible = True
    End Sub

End Class
