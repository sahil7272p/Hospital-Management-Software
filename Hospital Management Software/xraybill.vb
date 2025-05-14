Imports System.Data.OleDb
Imports Microsoft.VisualBasic.PowerPacks.Printing

Public Class xraybill
    Dim Serial As Integer
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Private PrintForm1 As New PrintForm(Me)

    Public Sub New(ByVal serialNo As Integer)
        InitializeComponent()
        Serial = serialNo
    End Sub

    Private Sub xraybill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim sql As String = "SELECT SerialNo, PatientName, Age, Address, PaymentMethod, Xraytype, Gender, FORMAT(XDate, 'dd/MM/yyyy') AS XDate, Mobile, City, Quantity, Amount FROM Xray WHERE SerialNo = " & Serial
            cmd = New OleDbCommand(sql, conn)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                lblpatientname.Text = reader("PatientName").ToString()
                lblage.Text = reader("Age").ToString()
                lblgender.Text = reader("Gender").ToString()
                lblpaymentmethod.Text = reader("PaymentMethod").ToString()
                lblmobileno.Text = reader("Mobile").ToString()
                lbldate.Text = reader("XDate").ToString()
                lblfees.Text = reader("Amount").ToString()
                lbladdress.Text = reader("Address").ToString()
                lblxraytype.Text = reader("Xraytype").ToString()
                lblserial.Text = reader("SerialNo").ToString()
                lblfees2.Text = reader("Amount").ToString()
                lblcity.Text = reader("City").ToString()
                lblfees3.Text = reader("Amount").ToString()
                lblpatientname2.Text = reader("PatientName").ToString()
                lblqty.Text = reader("Quantity").ToString()
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

    Private Sub lblfees2_Click(sender As Object, e As EventArgs) Handles lblfees2.Click

    End Sub
End Class
