<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvance
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.cboDept = New System.Windows.Forms.ComboBox()
        Me.cboEmpId = New System.Windows.Forms.ComboBox()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpMonthYear = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(143, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 19)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "*"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Red
        Me.Label58.Location = New System.Drawing.Point(144, 19)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(17, 19)
        Me.Label58.TabIndex = 152
        Me.Label58.Text = "*"
        '
        'cboDept
        '
        Me.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDept.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.Location = New System.Drawing.Point(167, 16)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(214, 27)
        Me.cboDept.TabIndex = 151
        '
        'cboEmpId
        '
        Me.cboEmpId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpId.FormattingEnabled = True
        Me.cboEmpId.Location = New System.Drawing.Point(167, 49)
        Me.cboEmpId.Name = "cboEmpId"
        Me.cboEmpId.Size = New System.Drawing.Size(214, 27)
        Me.cboEmpId.TabIndex = 150
        '
        'txtDesignation
        '
        Me.txtDesignation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation.Location = New System.Drawing.Point(167, 114)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.ReadOnly = True
        Me.txtDesignation.Size = New System.Drawing.Size(214, 26)
        Me.txtDesignation.TabIndex = 149
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "Designation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "Department"
        '
        'txtEmpName
        '
        Me.txtEmpName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpName.Location = New System.Drawing.Point(167, 82)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.ReadOnly = True
        Me.txtEmpName.Size = New System.Drawing.Size(214, 26)
        Me.txtEmpName.TabIndex = 146
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 19)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Employee Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 19)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "Employee Id"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label58)
        Me.GroupBox1.Controls.Add(Me.cboDept)
        Me.GroupBox1.Controls.Add(Me.cboEmpId)
        Me.GroupBox1.Controls.Add(Me.txtDesignation)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEmpName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 156)
        Me.GroupBox1.TabIndex = 154
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpMonthYear)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 92)
        Me.GroupBox2.TabIndex = 155
        Me.GroupBox2.TabStop = False
        '
        'dtpMonthYear
        '
        Me.dtpMonthYear.CustomFormat = "MMMM- yyyy"
        Me.dtpMonthYear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMonthYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthYear.Location = New System.Drawing.Point(226, 25)
        Me.dtpMonthYear.Name = "dtpMonthYear"
        Me.dtpMonthYear.ShowUpDown = True
        Me.dtpMonthYear.Size = New System.Drawing.Size(144, 26)
        Me.dtpMonthYear.TabIndex = 157
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(226, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(136, 26)
        Me.TextBox1.TabIndex = 156
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 19)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "Amount Rs."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 19)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "Advance Taken From Month"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(70, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 30)
        Me.Button1.TabIndex = 156
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(219, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 30)
        Me.Button2.TabIndex = 157
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 348)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmAdvance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advance Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents cboDept As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmpId As System.Windows.Forms.ComboBox
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dtpMonthYear As System.Windows.Forms.DateTimePicker
End Class
