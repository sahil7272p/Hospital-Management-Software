Imports Microsoft.VisualBasic.PowerPacks.Printing
Imports System.Data.OleDb

Public Class RoomBill
    Dim Serial As Integer
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Private PrintForm1 As New PrintForm(Me)

    Public Sub New(ByVal serialNo As Integer)
        InitializeComponent()
        Serial = serialNo
    End Sub

    Private Sub BillForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SAHIL\source\repos\Hospital Management Software\DataBase\Dhayal Hospital.accdb"
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim sql As String = "SELECT SerialNo, PatientName, RoomNo, Floar, FORMAT(AdmitDate, 'dd/MM/yyyy') AS AdmitDate, FORMAT(DischargeDate, 'dd/MM/yyyy') AS DischargeDate, RoomRent, Address, BedNo, Gender, MobileNo FROM Room WHERE SerialNo = " & Serial
        cmd = New OleDbCommand(sql, conn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            lblpatientname.Text = reader("PatientName").ToString()
            lbladdress.Text = reader("Address").ToString()
            lblgender.Text = reader("Gender").ToString()
            lblfloar.Text = reader("Floar").ToString()
            lblmobileno.Text = reader("MobileNo").ToString()
            lbladmitdate.Text = reader("AdmitDate").ToString()
            lbldischargedate.Text = reader("DischargeDate").ToString()
            lblroono.Text = reader("RoomNo").ToString()
            lblbedno.Text = reader("BedNo").ToString()
            lblserial.Text = reader("SerialNo").ToString()
            lblrent.Text = reader("RoomRent").ToString()
            lblfees2.Text = reader("RoomRent").ToString()
            lblfees3.Text = reader("RoomRent").ToString()
            lblpatientname2.Text = reader("PatientName").ToString()
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
