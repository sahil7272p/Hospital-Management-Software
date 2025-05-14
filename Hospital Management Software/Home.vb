Public Class Home

    Public Sub LoadForm(form As Form)
        Panel2.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.None
        Panel2.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub OPDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPDToolStripMenuItem.Click
        LoadForm(New OPD)
    End Sub

    Private Sub ViewAllOPDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllOPDToolStripMenuItem.Click
        LoadForm(New ViewallOPD)
    End Sub

    Private Sub ViewDateWiseOPDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDateWiseOPDToolStripMenuItem.Click
        LoadForm(New ViewDate)
    End Sub

    Private Sub UpdateOPDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateOPDToolStripMenuItem.Click
        LoadForm(New UpdateOPD)
    End Sub

    Private Sub DeleteOPDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteOPDToolStripMenuItem.Click
        LoadForm(New DeleteOPD)
    End Sub

    Private Sub AddXRayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddXRayToolStripMenuItem.Click
        LoadForm(New Xray)
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm(New OPD)
        Start.WindowState = FormWindowState.Maximized
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnopd_Click(sender As Object, e As EventArgs) Handles btnopd.Click
        LoadForm(New OPD)
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        End
    End Sub

    Private Sub btnxray_Click_1(sender As Object, e As EventArgs) Handles btnxray.Click
        LoadForm(New Xray)
    End Sub

    Private Sub ViewAllXRayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllXRayToolStripMenuItem.Click
        LoadForm(New Viewallxray)
    End Sub

    Private Sub ViewDateWiseXRayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDateWiseXRayToolStripMenuItem.Click
        LoadForm(New ViewDate2)
    End Sub

    Private Sub UpdateXRayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateXRayToolStripMenuItem.Click
        LoadForm(New UpdateXray)
    End Sub

    Private Sub DeleteXRayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteXRayToolStripMenuItem.Click
        LoadForm(New DeleteXray)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        LoadForm(New OPD)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        LoadForm(New Xray)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Start.Close()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub AddTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTestToolStripMenuItem.Click
        LoadForm(New labtest)
    End Sub

    Private Sub ViewAllTestReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllTestReportToolStripMenuItem.Click
        LoadForm(New ViewallTest)
    End Sub

    Private Sub ViewDateWiseTestReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDateWiseTestReportToolStripMenuItem.Click
        LoadForm(New ViewDate3)
    End Sub

    Private Sub UpdateTestReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateTestReportToolStripMenuItem.Click
        LoadForm(New UpdateTest)
    End Sub

    Private Sub RemoveTestReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTestReportToolStripMenuItem.Click
        LoadForm(New DeleteTest)
    End Sub

    Private Sub btnlaboratory_Click(sender As Object, e As EventArgs) Handles btnlaboratory.Click
        LoadForm(New labtest)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        LoadForm(New labtest)
    End Sub

    Private Sub AddDoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDoctorToolStripMenuItem.Click
        LoadForm(New AddDoctor)
    End Sub

    Private Sub RemoveDoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveDoctorToolStripMenuItem.Click
        LoadForm(New ViewDoctor)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadForm(New AddDoctor)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        LoadForm(New AddDoctor)
    End Sub

    Private Sub OPDBillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPDBillingToolStripMenuItem.Click
        LoadForm(New OPDBilling)
    End Sub

    Private Sub XRayBillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XRayBillingToolStripMenuItem.Click
        LoadForm(New XrayBilling)
    End Sub

    Private Sub LabTestBillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabTestBillingToolStripMenuItem.Click
        LoadForm(New LabTestBilling)
    End Sub

    Private Sub AddRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRoomToolStripMenuItem.Click
        LoadForm(New AddRoom)
    End Sub

    Private Sub VIewAllRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllRoomToolStripMenuItem.Click
        LoadForm(New ViewAllRoom)
    End Sub

    Private Sub ViewDateWiseRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDateWiseRoomToolStripMenuItem.Click
        LoadForm(New ViewDate4)
    End Sub

    Private Sub UpdateRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRoomToolStripMenuItem.Click
        LoadForm(New Updateroom)
    End Sub

    Private Sub DeleteRoomToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteRoomToolStripMenuItem1.Click
        LoadForm(New DeleteRoom)
    End Sub

    Private Sub RoomBillingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomBillingToolStripMenuItem.Click
        LoadForm(New RoomBilling)
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Panel2.Controls.Clear()
        Me.Refresh()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        LoadForm(New AddRoom)
    End Sub

    Private Sub AddRoom_Click(sender As Object, e As EventArgs) Handles AddRoom.Click
        LoadForm(New AddRoom)
    End Sub
End Class
