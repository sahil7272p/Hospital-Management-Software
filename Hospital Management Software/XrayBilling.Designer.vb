<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XrayBilling
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtxraytype = New System.Windows.Forms.TextBox()
        Me.rbtnother = New System.Windows.Forms.RadioButton()
        Me.rbtnfemale = New System.Windows.Forms.RadioButton()
        Me.rbtnmale = New System.Windows.Forms.RadioButton()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpatient = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxpaymentmethod = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtmobileno = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtserial = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtpatientname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtmobile = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xrayd = New System.Windows.Forms.DateTimePicker()
        Me.GroupBoxgender = New System.Windows.Forms.GroupBox()
        Me.btnshowbill = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxgender.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtxraytype
        '
        Me.txtxraytype.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtxraytype.Location = New System.Drawing.Point(450, 641)
        Me.txtxraytype.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtxraytype.Multiline = True
        Me.txtxraytype.Name = "txtxraytype"
        Me.txtxraytype.ReadOnly = True
        Me.txtxraytype.Size = New System.Drawing.Size(286, 118)
        Me.txtxraytype.TabIndex = 185
        '
        'rbtnother
        '
        Me.rbtnother.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnother.Location = New System.Drawing.Point(305, 67)
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
        Me.rbtnfemale.Location = New System.Drawing.Point(157, 67)
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
        Me.rbtnmale.Location = New System.Drawing.Point(35, 67)
        Me.rbtnmale.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbtnmale.Name = "rbtnmale"
        Me.rbtnmale.Size = New System.Drawing.Size(125, 41)
        Me.rbtnmale.TabIndex = 9
        Me.rbtnmale.TabStop = True
        Me.rbtnmale.Text = "Male"
        Me.rbtnmale.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncancel.Location = New System.Drawing.Point(845, 913)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(145, 58)
        Me.btncancel.TabIndex = 187
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'txtquantity
        '
        Me.txtquantity.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(1042, 780)
        Me.txtquantity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.ReadOnly = True
        Me.txtquantity.Size = New System.Drawing.Size(286, 41)
        Me.txtquantity.TabIndex = 184
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FloralWhite
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(866, 780)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 60)
        Me.Label9.TabIndex = 183
        Me.Label9.Text = "Quantity"
        '
        'txtpatient
        '
        Me.txtpatient.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatient.Location = New System.Drawing.Point(452, 395)
        Me.txtpatient.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtpatient.Name = "txtpatient"
        Me.txtpatient.ReadOnly = True
        Me.txtpatient.Size = New System.Drawing.Size(286, 41)
        Me.txtpatient.TabIndex = 182
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FloralWhite
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(220, 395)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 60)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "Patient Name"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(220, 639)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(199, 60)
        Me.Label11.TabIndex = 176
        Me.Label11.Text = "X-Ray Type"
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(1042, 395)
        Me.txtage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(286, 41)
        Me.txtage.TabIndex = 172
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(866, 395)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 60)
        Me.Label10.TabIndex = 175
        Me.Label10.Text = "Age"
        '
        'txtcity
        '
        Me.txtcity.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.Location = New System.Drawing.Point(450, 519)
        Me.txtcity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.ReadOnly = True
        Me.txtcity.Size = New System.Drawing.Size(286, 41)
        Me.txtcity.TabIndex = 169
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(262, 519)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(308, 60)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "City"
        '
        'ComboBoxpaymentmethod
        '
        Me.ComboBoxpaymentmethod.AllowDrop = True
        Me.ComboBoxpaymentmethod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBoxpaymentmethod.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxpaymentmethod.FormattingEnabled = True
        Me.ComboBoxpaymentmethod.Items.AddRange(New Object() {"CASH", "UPI"})
        Me.ComboBoxpaymentmethod.Location = New System.Drawing.Point(452, 784)
        Me.ComboBoxpaymentmethod.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBoxpaymentmethod.Name = "ComboBoxpaymentmethod"
        Me.ComboBoxpaymentmethod.Size = New System.Drawing.Size(276, 38)
        Me.ComboBoxpaymentmethod.TabIndex = 179
        Me.ComboBoxpaymentmethod.Text = "Select Payment Method"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(191, 781)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(308, 60)
        Me.Label13.TabIndex = 180
        Me.Label13.Text = "Payment Method"
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(1042, 699)
        Me.txtamount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.ReadOnly = True
        Me.txtamount.Size = New System.Drawing.Size(286, 41)
        Me.txtamount.TabIndex = 178
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FloralWhite
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(866, 699)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 60)
        Me.Label3.TabIndex = 177
        Me.Label3.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(220, 455)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 60)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Mobile No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(318, 450)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 38)
        Me.Label6.TabIndex = 164
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(262, 579)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 60)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnsearch)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtmobileno)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtserial)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txtpatientname)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(17, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1580, 267)
        Me.GroupBox1.TabIndex = 163
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Patient "
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.Blue
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsearch.Location = New System.Drawing.Point(1338, 43)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(129, 45)
        Me.btnsearch.TabIndex = 93
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(471, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(170, 51)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "Patient Name"
        '
        'txtmobileno
        '
        Me.txtmobileno.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobileno.Location = New System.Drawing.Point(1078, 47)
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.Size = New System.Drawing.Size(219, 38)
        Me.txtmobileno.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkRed
        Me.Label15.Location = New System.Drawing.Point(107, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 38)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Serial No. "
        '
        'txtserial
        '
        Me.txtserial.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserial.Location = New System.Drawing.Point(245, 46)
        Me.txtserial.Name = "txtserial"
        Me.txtserial.Size = New System.Drawing.Size(194, 38)
        Me.txtserial.TabIndex = 1
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(18, 109)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.RowHeadersWidth = 80
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1516, 149)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 5
        Me.DataGridView1.VirtualMode = True
        '
        'txtpatientname
        '
        Me.txtpatientname.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatientname.Location = New System.Drawing.Point(661, 47)
        Me.txtpatientname.Name = "txtpatientname"
        Me.txtpatientname.Size = New System.Drawing.Size(219, 38)
        Me.txtpatientname.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkRed
        Me.Label14.Location = New System.Drawing.Point(934, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(153, 51)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "Mobile No. "
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(734, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 45)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = " X-Ray Billing"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(1042, 458)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.Size = New System.Drawing.Size(286, 98)
        Me.txtaddress.TabIndex = 168
        '
        'txtmobile
        '
        Me.txtmobile.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobile.Location = New System.Drawing.Point(452, 458)
        Me.txtmobile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.ReadOnly = True
        Me.txtmobile.Size = New System.Drawing.Size(286, 41)
        Me.txtmobile.TabIndex = 166
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(866, 455)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(308, 60)
        Me.Label8.TabIndex = 173
        Me.Label8.Text = "Address"
        '
        'xrayd
        '
        Me.xrayd.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrayd.Location = New System.Drawing.Point(409, 582)
        Me.xrayd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.xrayd.Name = "xrayd"
        Me.xrayd.Size = New System.Drawing.Size(327, 34)
        Me.xrayd.TabIndex = 171
        '
        'GroupBoxgender
        '
        Me.GroupBoxgender.Controls.Add(Me.rbtnother)
        Me.GroupBoxgender.Controls.Add(Me.rbtnfemale)
        Me.GroupBoxgender.Controls.Add(Me.rbtnmale)
        Me.GroupBoxgender.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxgender.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBoxgender.Location = New System.Drawing.Point(859, 563)
        Me.GroupBoxgender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxgender.Name = "GroupBoxgender"
        Me.GroupBoxgender.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxgender.Size = New System.Drawing.Size(469, 120)
        Me.GroupBoxgender.TabIndex = 174
        Me.GroupBoxgender.TabStop = False
        Me.GroupBoxgender.Text = "Gender"
        '
        'btnshowbill
        '
        Me.btnshowbill.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnshowbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnshowbill.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshowbill.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnshowbill.Location = New System.Drawing.Point(606, 913)
        Me.btnshowbill.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnshowbill.Name = "btnshowbill"
        Me.btnshowbill.Size = New System.Drawing.Size(183, 58)
        Me.btnshowbill.TabIndex = 188
        Me.btnshowbill.Text = "Show Bill"
        Me.btnshowbill.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Hospital_Management_Software.My.Resources.Resources._11596392
        Me.PictureBox1.Location = New System.Drawing.Point(1345, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'XrayBilling
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1902, 1055)
        Me.Controls.Add(Me.btnshowbill)
        Me.Controls.Add(Me.txtxraytype)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtpatient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxpaymentmethod)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtmobile)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.xrayd)
        Me.Controls.Add(Me.GroupBoxgender)
        Me.Name = "XrayBilling"
        Me.Text = "XrayBilling"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxgender.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtxraytype As TextBox
    Friend WithEvents rbtnother As RadioButton
    Friend WithEvents rbtnfemale As RadioButton
    Friend WithEvents rbtnmale As RadioButton
    Friend WithEvents btncancel As Button
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtpatient As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtcity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxpaymentmethod As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtamount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtmobileno As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtserial As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtpatientname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtmobile As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents xrayd As DateTimePicker
    Friend WithEvents GroupBoxgender As GroupBox
    Friend WithEvents btnshowbill As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
