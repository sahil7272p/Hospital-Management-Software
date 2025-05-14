<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewallOPD
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalopd = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.totalcash = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalonline = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.grandtotal = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(263, 1055)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total OPD"
        '
        'totalopd
        '
        Me.totalopd.AutoSize = True
        Me.totalopd.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalopd.ForeColor = System.Drawing.Color.DarkRed
        Me.totalopd.Location = New System.Drawing.Point(284, 1117)
        Me.totalopd.Name = "totalopd"
        Me.totalopd.Size = New System.Drawing.Size(28, 45)
        Me.totalopd.TabIndex = 3
        Me.totalopd.Text = "."
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.DarkRed
        Me.label2.Location = New System.Drawing.Point(1787, 1062)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(299, 45)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Grand Total"
        '
        'totalcash
        '
        Me.totalcash.AutoSize = True
        Me.totalcash.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalcash.ForeColor = System.Drawing.Color.DarkRed
        Me.totalcash.Location = New System.Drawing.Point(742, 1115)
        Me.totalcash.Name = "totalcash"
        Me.totalcash.Size = New System.Drawing.Size(28, 45)
        Me.totalcash.TabIndex = 5
        Me.totalcash.Text = "."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(1253, 1055)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 45)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Online"
        '
        'totalonline
        '
        Me.totalonline.AutoSize = True
        Me.totalonline.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalonline.ForeColor = System.Drawing.Color.DarkRed
        Me.totalonline.Location = New System.Drawing.Point(1273, 1115)
        Me.totalonline.Name = "totalonline"
        Me.totalonline.Size = New System.Drawing.Size(28, 45)
        Me.totalonline.TabIndex = 7
        Me.totalonline.Text = "."
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.DarkRed
        Me.label4.Location = New System.Drawing.Point(725, 1055)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(265, 45)
        Me.label4.TabIndex = 8
        Me.label4.Text = "Total Cash"
        '
        'grandtotal
        '
        Me.grandtotal.AutoSize = True
        Me.grandtotal.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grandtotal.ForeColor = System.Drawing.Color.DarkRed
        Me.grandtotal.Location = New System.Drawing.Point(1809, 1115)
        Me.grandtotal.Name = "grandtotal"
        Me.grandtotal.Size = New System.Drawing.Size(28, 45)
        Me.grandtotal.TabIndex = 9
        Me.grandtotal.Text = "."
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
        Me.DataGridView1.Location = New System.Drawing.Point(-139, -9)
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
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.VirtualMode = True
        '
        'ViewallOPD
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.grandtotal)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.totalonline)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.totalcash)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.totalopd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewallOPD"
        Me.Text = "Viewall"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents totalopd As Label
    Friend WithEvents label2 As Label
    Friend WithEvents totalcash As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents totalonline As Label
    Friend WithEvents label4 As Label
    Friend WithEvents grandtotal As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
