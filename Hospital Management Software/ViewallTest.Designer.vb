<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewallTest
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
        Me.grandtotal = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.totalonline = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalcash = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.totaltest = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grandtotal
        '
        Me.grandtotal.AutoSize = True
        Me.grandtotal.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grandtotal.ForeColor = System.Drawing.Color.DarkRed
        Me.grandtotal.Location = New System.Drawing.Point(1813, 1120)
        Me.grandtotal.Name = "grandtotal"
        Me.grandtotal.Size = New System.Drawing.Size(28, 45)
        Me.grandtotal.TabIndex = 18
        Me.grandtotal.Text = "."
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.DarkRed
        Me.label4.Location = New System.Drawing.Point(729, 1060)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(265, 45)
        Me.label4.TabIndex = 17
        Me.label4.Text = "Total Cash"
        '
        'totalonline
        '
        Me.totalonline.AutoSize = True
        Me.totalonline.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalonline.ForeColor = System.Drawing.Color.DarkRed
        Me.totalonline.Location = New System.Drawing.Point(1277, 1120)
        Me.totalonline.Name = "totalonline"
        Me.totalonline.Size = New System.Drawing.Size(28, 45)
        Me.totalonline.TabIndex = 16
        Me.totalonline.Text = "."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(1257, 1060)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 45)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Total Online"
        '
        'totalcash
        '
        Me.totalcash.AutoSize = True
        Me.totalcash.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalcash.ForeColor = System.Drawing.Color.DarkRed
        Me.totalcash.Location = New System.Drawing.Point(746, 1120)
        Me.totalcash.Name = "totalcash"
        Me.totalcash.Size = New System.Drawing.Size(28, 45)
        Me.totalcash.TabIndex = 14
        Me.totalcash.Text = "."
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.DarkRed
        Me.label2.Location = New System.Drawing.Point(1791, 1067)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(299, 45)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Grand Total"
        '
        'totaltest
        '
        Me.totaltest.AutoSize = True
        Me.totaltest.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaltest.ForeColor = System.Drawing.Color.DarkRed
        Me.totaltest.Location = New System.Drawing.Point(288, 1122)
        Me.totaltest.Name = "totaltest"
        Me.totaltest.Size = New System.Drawing.Size(28, 45)
        Me.totaltest.TabIndex = 12
        Me.totaltest.Text = "."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(267, 1060)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 45)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Total Test"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 50
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(-135, -4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 100
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(2360, 1049)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 10
        Me.DataGridView1.VirtualMode = True
        '
        'ViewallTest
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.grandtotal)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.totalonline)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.totalcash)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.totaltest)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewallTest"
        Me.Text = "ViewallTest"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grandtotal As Label
    Friend WithEvents label4 As Label
    Friend WithEvents totalonline As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents totalcash As Label
    Friend WithEvents label2 As Label
    Friend WithEvents totaltest As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
