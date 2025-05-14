<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Xray
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBoxpaymentmethod = New System.Windows.Forms.ComboBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBoxgender = New System.Windows.Forms.GroupBox()
        Me.rbtnother = New System.Windows.Forms.RadioButton()
        Me.rbtnfemale = New System.Windows.Forms.RadioButton()
        Me.rbtnmale = New System.Windows.Forms.RadioButton()
        Me.xrayd = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtmobile = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.txtpatientname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBoxgender.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FloralWhite
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(564, 14)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(620, 80)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "X-Ray Patient Details"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(227, 463)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(308, 60)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Payment Method"
        '
        'ComboBoxpaymentmethod
        '
        Me.ComboBoxpaymentmethod.AllowDrop = True
        Me.ComboBoxpaymentmethod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBoxpaymentmethod.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxpaymentmethod.FormattingEnabled = True
        Me.ComboBoxpaymentmethod.Items.AddRange(New Object() {"CASH", "UPI"})
        Me.ComboBoxpaymentmethod.Location = New System.Drawing.Point(493, 463)
        Me.ComboBoxpaymentmethod.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBoxpaymentmethod.Name = "ComboBoxpaymentmethod"
        Me.ComboBoxpaymentmethod.Size = New System.Drawing.Size(276, 38)
        Me.ComboBoxpaymentmethod.TabIndex = 9
        Me.ComboBoxpaymentmethod.Text = "Select Payment Method"
        '
        'txtamount
        '
        Me.txtamount.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(1075, 646)
        Me.txtamount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(286, 41)
        Me.txtamount.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FloralWhite
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(911, 647)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 60)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(351, 213)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 38)
        Me.Label2.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(253, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(308, 60)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Mobile No."
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(295, 301)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(308, 60)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "City"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(295, 377)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 60)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Date"
        '
        'GroupBoxgender
        '
        Me.GroupBoxgender.Controls.Add(Me.rbtnother)
        Me.GroupBoxgender.Controls.Add(Me.rbtnfemale)
        Me.GroupBoxgender.Controls.Add(Me.rbtnmale)
        Me.GroupBoxgender.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxgender.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBoxgender.Location = New System.Drawing.Point(892, 356)
        Me.GroupBoxgender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxgender.Name = "GroupBoxgender"
        Me.GroupBoxgender.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBoxgender.Size = New System.Drawing.Size(469, 134)
        Me.GroupBoxgender.TabIndex = 45
        Me.GroupBoxgender.TabStop = False
        Me.GroupBoxgender.Text = "Gender"
        '
        'rbtnother
        '
        Me.rbtnother.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnother.Location = New System.Drawing.Point(305, 51)
        Me.rbtnother.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbtnother.Name = "rbtnother"
        Me.rbtnother.Size = New System.Drawing.Size(135, 41)
        Me.rbtnother.TabIndex = 9
        Me.rbtnother.TabStop = True
        Me.rbtnother.Text = "Other"
        Me.rbtnother.UseVisualStyleBackColor = True
        '
        'rbtnfemale
        '
        Me.rbtnfemale.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnfemale.Location = New System.Drawing.Point(157, 51)
        Me.rbtnfemale.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbtnfemale.Name = "rbtnfemale"
        Me.rbtnfemale.Size = New System.Drawing.Size(152, 41)
        Me.rbtnfemale.TabIndex = 8
        Me.rbtnfemale.Text = "Female"
        Me.rbtnfemale.UseVisualStyleBackColor = True
        '
        'rbtnmale
        '
        Me.rbtnmale.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnmale.Location = New System.Drawing.Point(35, 51)
        Me.rbtnmale.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rbtnmale.Name = "rbtnmale"
        Me.rbtnmale.Size = New System.Drawing.Size(125, 41)
        Me.rbtnmale.TabIndex = 7
        Me.rbtnmale.TabStop = True
        Me.rbtnmale.Text = "Male"
        Me.rbtnmale.UseVisualStyleBackColor = True
        '
        'xrayd
        '
        Me.xrayd.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrayd.Location = New System.Drawing.Point(442, 379)
        Me.xrayd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.xrayd.Name = "xrayd"
        Me.xrayd.Size = New System.Drawing.Size(327, 34)
        Me.xrayd.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(899, 229)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(308, 60)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Address"
        '
        'txtmobile
        '
        Me.txtmobile.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobile.Location = New System.Drawing.Point(485, 229)
        Me.txtmobile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtmobile.Name = "txtmobile"
        Me.txtmobile.Size = New System.Drawing.Size(286, 41)
        Me.txtmobile.TabIndex = 3
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(1075, 228)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(286, 98)
        Me.txtaddress.TabIndex = 4
        '
        'txtcity
        '
        Me.txtcity.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.Location = New System.Drawing.Point(483, 301)
        Me.txtcity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(286, 41)
        Me.txtcity.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(899, 158)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 60)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Age"
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(1075, 158)
        Me.txtage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(286, 41)
        Me.txtage.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(253, 545)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(199, 60)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "X-Ray Type"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsave.Location = New System.Drawing.Point(539, 869)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(156, 58)
        Me.btnsave.TabIndex = 13
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncancel.Location = New System.Drawing.Point(936, 869)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(156, 58)
        Me.btncancel.TabIndex = 15
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FloralWhite
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkRed
        Me.Label14.Location = New System.Drawing.Point(295, 101)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(182, 44)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Sr. No."
        '
        'txtSerial
        '
        Me.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSerial.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerial.Location = New System.Drawing.Point(489, 102)
        Me.txtSerial.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.ReadOnly = True
        Me.txtSerial.Size = New System.Drawing.Size(117, 36)
        Me.txtSerial.TabIndex = 57
        '
        'txtpatientname
        '
        Me.txtpatientname.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatientname.Location = New System.Drawing.Point(485, 158)
        Me.txtpatientname.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtpatientname.Name = "txtpatientname"
        Me.txtpatientname.Size = New System.Drawing.Size(286, 41)
        Me.txtpatientname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FloralWhite
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(253, 158)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 60)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Patient Name"
        '
        'txtquantity
        '
        Me.txtquantity.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(1075, 545)
        Me.txtquantity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(286, 41)
        Me.txtquantity.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FloralWhite
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(911, 545)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 60)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Quantity"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.AllowDrop = True
        Me.CheckedListBox1.BackColor = System.Drawing.Color.FloralWhite
        Me.CheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.ColumnWidth = 50
        Me.CheckedListBox1.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.CheckedListBox1.ForeColor = System.Drawing.Color.Blue
        Me.CheckedListBox1.HorizontalExtent = 50
        Me.CheckedListBox1.HorizontalScrollbar = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"HEAD", "NECK", "CHEST", "SPINE", "PELVIS", "ABDOMEN", "THORACIC CAGE", "PELVIS", "UPPER EXTREMITY", "LOWER EXTREMITY", "PORTABLE ", "TOMOGRAPHY", "CONTRAST", "SOFT TISSUE", "QC/TEST", "LINAC GRAPHY", "ROUTINE"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(455, 545)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(336, 234)
        Me.CheckedListBox1.TabIndex = 10
        Me.CheckedListBox1.ThreeDCheckBoxes = True
        Me.CheckedListBox1.UseCompatibleTextRendering = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(745, 869)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 58)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Save && Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Xray
        '
        Me.AcceptButton = Me.btnsave
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.CancelButton = Me.btncancel
        Me.ClientSize = New System.Drawing.Size(1494, 1055)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpatientname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxpaymentmethod)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcity)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtmobile)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.xrayd)
        Me.Controls.Add(Me.GroupBoxgender)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Xray"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xray"
        Me.GroupBoxgender.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBoxpaymentmethod As ComboBox
    Friend WithEvents txtamount As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBoxgender As GroupBox
    Friend WithEvents rbtnother As RadioButton
    Friend WithEvents rbtnfemale As RadioButton
    Friend WithEvents rbtnmale As RadioButton
    Friend WithEvents xrayd As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtmobile As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtcity As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents txtpatientname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button1 As Button
End Class
