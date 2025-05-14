<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabTestBilling
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtmobileno = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtserial = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtpatientname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtselectedtest = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.GroupBoxgender = New System.Windows.Forms.GroupBox()
        Me.rbtnother = New System.Windows.Forms.RadioButton()
        Me.rbtnfemale = New System.Windows.Forms.RadioButton()
        Me.rbtnmale = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TDate = New System.Windows.Forms.DateTimePicker()
        Me.txtpatient = New System.Windows.Forms.TextBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBoxpaymentmethod = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtmobile = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnshowbill = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxgender.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtmobileno
        '
        Me.txtmobileno.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobileno.Location = New System.Drawing.Point(1089, 38)
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.Size = New System.Drawing.Size(219, 38)
        Me.txtmobileno.TabIndex = 88
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(482, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(170, 51)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Patient Name"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(660, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(368, 45)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Lab Test Billing"
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.Blue
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsearch.Location = New System.Drawing.Point(1359, 38)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(129, 45)
        Me.btnsearch.TabIndex = 89
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkRed
        Me.Label15.Location = New System.Drawing.Point(118, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 38)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Serial No. "
        '
        'txtserial
        '
        Me.txtserial.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserial.Location = New System.Drawing.Point(256, 37)
        Me.txtserial.Name = "txtserial"
        Me.txtserial.Size = New System.Drawing.Size(194, 38)
        Me.txtserial.TabIndex = 84
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
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(29, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 80
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1516, 139)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 82
        Me.DataGridView1.VirtualMode = True
        '
        'txtpatientname
        '
        Me.txtpatientname.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatientname.Location = New System.Drawing.Point(672, 38)
        Me.txtpatientname.Name = "txtpatientname"
        Me.txtpatientname.Size = New System.Drawing.Size(219, 38)
        Me.txtpatientname.TabIndex = 86
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkRed
        Me.Label14.Location = New System.Drawing.Point(945, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(153, 51)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "Mobile No. "
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncancel.Location = New System.Drawing.Point(825, 911)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(145, 58)
        Me.btncancel.TabIndex = 167
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.btnsearch)
        Me.GroupBox1.Controls.Add(Me.txtmobileno)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtserial)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txtpatientname)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(11, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1580, 243)
        Me.GroupBox1.TabIndex = 168
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Patient "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Hospital_Management_Software.My.Resources.Resources._11596392
        Me.PictureBox1.Location = New System.Drawing.Point(1365, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'txtselectedtest
        '
        Me.txtselectedtest.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtselectedtest.Location = New System.Drawing.Point(369, 638)
        Me.txtselectedtest.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtselectedtest.Multiline = True
        Me.txtselectedtest.Name = "txtselectedtest"
        Me.txtselectedtest.ReadOnly = True
        Me.txtselectedtest.Size = New System.Drawing.Size(310, 129)
        Me.txtselectedtest.TabIndex = 227
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(985, 413)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.Size = New System.Drawing.Size(286, 98)
        Me.txtaddress.TabIndex = 213
        '
        'GroupBoxgender
        '
        Me.GroupBoxgender.Controls.Add(Me.rbtnother)
        Me.GroupBoxgender.Controls.Add(Me.rbtnfemale)
        Me.GroupBoxgender.Controls.Add(Me.rbtnmale)
        Me.GroupBoxgender.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxgender.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBoxgender.Location = New System.Drawing.Point(805, 525)
        Me.GroupBoxgender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxgender.Name = "GroupBoxgender"
        Me.GroupBoxgender.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxgender.Size = New System.Drawing.Size(466, 108)
        Me.GroupBoxgender.TabIndex = 219
        Me.GroupBoxgender.TabStop = False
        Me.GroupBoxgender.Text = "Gender"
        '
        'rbtnother
        '
        Me.rbtnother.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnother.Location = New System.Drawing.Point(307, 47)
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
        Me.rbtnfemale.Location = New System.Drawing.Point(159, 47)
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
        Me.rbtnmale.Location = New System.Drawing.Point(37, 47)
        Me.rbtnmale.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbtnmale.Name = "rbtnmale"
        Me.rbtnmale.Size = New System.Drawing.Size(125, 41)
        Me.rbtnmale.TabIndex = 9
        Me.rbtnmale.TabStop = True
        Me.rbtnmale.Text = "Male"
        Me.rbtnmale.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(204, 561)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 60)
        Me.Label7.TabIndex = 216
        Me.Label7.Text = "Date"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(205, 487)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 60)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "City"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(163, 414)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 60)
        Me.Label4.TabIndex = 212
        Me.Label4.Text = "Mobile No."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(261, 388)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 38)
        Me.Label1.TabIndex = 209
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FloralWhite
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(163, 339)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 60)
        Me.Label3.TabIndex = 208
        Me.Label3.Text = "Patient Name"
        '
        'TDate
        '
        Me.TDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TDate.Location = New System.Drawing.Point(354, 563)
        Me.TDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TDate.Name = "TDate"
        Me.TDate.Size = New System.Drawing.Size(327, 34)
        Me.TDate.TabIndex = 217
        '
        'txtpatient
        '
        Me.txtpatient.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatient.Location = New System.Drawing.Point(395, 338)
        Me.txtpatient.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtpatient.Name = "txtpatient"
        Me.txtpatient.ReadOnly = True
        Me.txtpatient.Size = New System.Drawing.Size(286, 41)
        Me.txtpatient.TabIndex = 210
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(985, 748)
        Me.txtamount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.ReadOnly = True
        Me.txtamount.Size = New System.Drawing.Size(286, 41)
        Me.txtamount.TabIndex = 221
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(801, 748)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(308, 60)
        Me.Label13.TabIndex = 226
        Me.Label13.Text = "Amount"
        '
        'ComboBoxpaymentmethod
        '
        Me.ComboBoxpaymentmethod.AllowDrop = True
        Me.ComboBoxpaymentmethod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBoxpaymentmethod.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxpaymentmethod.FormattingEnabled = True
        Me.ComboBoxpaymentmethod.Items.AddRange(New Object() {"CASH", "UPI"})
        Me.ComboBoxpaymentmethod.Location = New System.Drawing.Point(405, 801)
        Me.ComboBoxpaymentmethod.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBoxpaymentmethod.Name = "ComboBoxpaymentmethod"
        Me.ComboBoxpaymentmethod.Size = New System.Drawing.Size(276, 38)
        Me.ComboBoxpaymentmethod.TabIndex = 222
        Me.ComboBoxpaymentmethod.Text = "Select Payment Method"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(163, 801)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(308, 60)
        Me.Label6.TabIndex = 225
        Me.Label6.Text = "Payment Method"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(163, 635)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(308, 60)
        Me.Label11.TabIndex = 224
        Me.Label11.Text = "Selected Test "
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(985, 334)
        Me.txtage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(286, 41)
        Me.txtage.TabIndex = 218
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(818, 335)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(308, 60)
        Me.Label10.TabIndex = 223
        Me.Label10.Text = "Age"
        '
        'txtcity
        '
        Me.txtcity.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.Location = New System.Drawing.Point(393, 486)
        Me.txtcity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.ReadOnly = True
        Me.txtcity.Size = New System.Drawing.Size(286, 41)
        Me.txtcity.TabIndex = 215
        '
        'txtmobile
        '
        Me.txtmobile.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobile.Location = New System.Drawing.Point(395, 414)
        Me.txtmobile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.ReadOnly = True
        Me.txtmobile.Size = New System.Drawing.Size(286, 41)
        Me.txtmobile.TabIndex = 211
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(798, 414)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 60)
        Me.Label8.TabIndex = 220
        Me.Label8.Text = "Address"
        '
        'txtquantity
        '
        Me.txtquantity.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(985, 661)
        Me.txtquantity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.ReadOnly = True
        Me.txtquantity.Size = New System.Drawing.Size(286, 41)
        Me.txtquantity.TabIndex = 229
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FloralWhite
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(801, 662)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 60)
        Me.Label9.TabIndex = 228
        Me.Label9.Text = "Quantity"
        '
        'btnshowbill
        '
        Me.btnshowbill.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnshowbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnshowbill.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshowbill.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnshowbill.Location = New System.Drawing.Point(596, 911)
        Me.btnshowbill.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnshowbill.Name = "btnshowbill"
        Me.btnshowbill.Size = New System.Drawing.Size(183, 58)
        Me.btnshowbill.TabIndex = 230
        Me.btnshowbill.Text = "Show Bill"
        Me.btnshowbill.UseVisualStyleBackColor = False
        '
        'LabTestBilling
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1902, 1055)
        Me.Controls.Add(Me.btnshowbill)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtselectedtest)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.GroupBoxgender)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TDate)
        Me.Controls.Add(Me.txtpatient)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ComboBoxpaymentmethod)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.txtmobile)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LabTestBilling"
        Me.Text = "LabTestBilling"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxgender.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmobileno As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtserial As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtpatientname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtselectedtest As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents GroupBoxgender As GroupBox
    Friend WithEvents rbtnother As RadioButton
    Friend WithEvents rbtnfemale As RadioButton
    Friend WithEvents rbtnmale As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TDate As DateTimePicker
    Friend WithEvents txtpatient As TextBox
    Friend WithEvents txtamount As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBoxpaymentmethod As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtcity As TextBox
    Friend WithEvents txtmobile As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnshowbill As Button
End Class
