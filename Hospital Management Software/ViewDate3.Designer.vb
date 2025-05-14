<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewDate3
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
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncancel.Location = New System.Drawing.Point(426, 352)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(139, 58)
        Me.btncancel.TabIndex = 17
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnshow
        '
        Me.btnshow.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnshow.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnshow.Location = New System.Drawing.Point(227, 352)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(139, 58)
        Me.btnshow.TabIndex = 16
        Me.btnshow.Text = "Show"
        Me.btnshow.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(210, 227)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(436, 38)
        Me.DateTimePicker2.TabIndex = 15
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(210, 120)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(436, 38)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(102, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 41)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "To "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(85, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 41)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "From "
        '
        'ViewDate3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(731, 526)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewDate3"
        Me.Text = "ViewDate3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncancel As Button
    Friend WithEvents btnshow As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
