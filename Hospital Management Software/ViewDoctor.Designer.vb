<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewDoctor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtmobile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtspecialization = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtqualification = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBoxgender = New System.Windows.Forms.GroupBox()
        Me.rbtnother = New System.Windows.Forms.RadioButton()
        Me.rbtnfemale = New System.Windows.Forms.RadioButton()
        Me.rbtnmale = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtdoctorname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtexperience = New System.Windows.Forms.TextBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxgender.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeight = 50
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(-40, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 100
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(2360, 321)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 2
        Me.DataGridView1.VirtualMode = True
        '
        'txtmobile
        '
        Me.txtmobile.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobile.Location = New System.Drawing.Point(493, 711)
        Me.txtmobile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(286, 41)
        Me.txtmobile.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(261, 711)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(308, 60)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Mobile No."
        '
        'txtposition
        '
        Me.txtposition.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtposition.Location = New System.Drawing.Point(493, 510)
        Me.txtposition.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(286, 41)
        Me.txtposition.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(273, 511)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(308, 60)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Position"
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(1100, 509)
        Me.txtage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(286, 41)
        Me.txtage.TabIndex = 77
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(935, 509)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(308, 60)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Age"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(901, 422)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 60)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Experience"
        '
        'txtspecialization
        '
        Me.txtspecialization.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtspecialization.Location = New System.Drawing.Point(493, 422)
        Me.txtspecialization.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtspecialization.Name = "txtspecialization"
        Me.txtspecialization.Size = New System.Drawing.Size(286, 41)
        Me.txtspecialization.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(261, 422)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(308, 60)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Specialization"
        '
        'txtqualification
        '
        Me.txtqualification.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqualification.Location = New System.Drawing.Point(1100, 341)
        Me.txtqualification.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtqualification.Name = "txtqualification"
        Me.txtqualification.Size = New System.Drawing.Size(286, 41)
        Me.txtqualification.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(901, 342)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 60)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Qualification"
        '
        'GroupBoxgender
        '
        Me.GroupBoxgender.Controls.Add(Me.rbtnother)
        Me.GroupBoxgender.Controls.Add(Me.rbtnfemale)
        Me.GroupBoxgender.Controls.Add(Me.rbtnmale)
        Me.GroupBoxgender.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxgender.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBoxgender.Location = New System.Drawing.Point(919, 573)
        Me.GroupBoxgender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxgender.Name = "GroupBoxgender"
        Me.GroupBoxgender.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxgender.Size = New System.Drawing.Size(466, 108)
        Me.GroupBoxgender.TabIndex = 82
        Me.GroupBoxgender.TabStop = False
        Me.GroupBoxgender.Text = "Gender"
        '
        'rbtnother
        '
        Me.rbtnother.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnother.Location = New System.Drawing.Point(309, 48)
        Me.rbtnother.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbtnother.Name = "rbtnother"
        Me.rbtnother.Size = New System.Drawing.Size(135, 41)
        Me.rbtnother.TabIndex = 11
        Me.rbtnother.TabStop = True
        Me.rbtnother.Text = "Other"
        Me.rbtnother.UseVisualStyleBackColor = True
        '
        'rbtnfemale
        '
        Me.rbtnfemale.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnfemale.Location = New System.Drawing.Point(149, 48)
        Me.rbtnfemale.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbtnfemale.Name = "rbtnfemale"
        Me.rbtnfemale.Size = New System.Drawing.Size(152, 41)
        Me.rbtnfemale.TabIndex = 10
        Me.rbtnfemale.Text = "Female"
        Me.rbtnfemale.UseVisualStyleBackColor = True
        '
        'rbtnmale
        '
        Me.rbtnmale.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnmale.Location = New System.Drawing.Point(36, 48)
        Me.rbtnmale.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbtnmale.Name = "rbtnmale"
        Me.rbtnmale.Size = New System.Drawing.Size(125, 41)
        Me.rbtnmale.TabIndex = 9
        Me.rbtnmale.TabStop = True
        Me.rbtnmale.Text = "Male"
        Me.rbtnmale.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(359, 408)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 38)
        Me.Label2.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FloralWhite
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(261, 342)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 60)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Doctor Name"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(493, 583)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(286, 98)
        Me.txtaddress.TabIndex = 78
        '
        'txtdoctorname
        '
        Me.txtdoctorname.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdoctorname.Location = New System.Drawing.Point(493, 342)
        Me.txtdoctorname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtdoctorname.Name = "txtdoctorname"
        Me.txtdoctorname.Size = New System.Drawing.Size(286, 41)
        Me.txtdoctorname.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(273, 583)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(308, 60)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Address"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtexperience
        '
        Me.txtexperience.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexperience.Location = New System.Drawing.Point(1100, 422)
        Me.txtexperience.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtexperience.Name = "txtexperience"
        Me.txtexperience.Size = New System.Drawing.Size(286, 41)
        Me.txtexperience.TabIndex = 75
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncancel.Location = New System.Drawing.Point(1001, 851)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(156, 58)
        Me.btncancel.TabIndex = 93
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndelete.Location = New System.Drawing.Point(716, 851)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(156, 58)
        Me.btndelete.TabIndex = 94
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnupdate.Location = New System.Drawing.Point(453, 851)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(156, 58)
        Me.btnupdate.TabIndex = 95
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'ViewDoctor
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.txtmobile)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtposition)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtspecialization)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtqualification)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBoxgender)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtdoctorname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtexperience)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewDoctor"
        Me.Text = "ViewDoctor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxgender.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtmobile As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtposition As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtspecialization As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtqualification As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBoxgender As GroupBox
    Friend WithEvents rbtnother As RadioButton
    Friend WithEvents rbtnfemale As RadioButton
    Friend WithEvents rbtnmale As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtdoctorname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtexperience As TextBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnupdate As Button
End Class
