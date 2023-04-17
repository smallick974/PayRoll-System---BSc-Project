<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnLeave = New System.Windows.Forms.Button()
        Me.btnSalary = New System.Windows.Forms.Button()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.btnAdvance = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(884, 26)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Thistle
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(92, 23)
        Me.ToolStripDropDownButton1.Text = "Reports"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'btnEmployee
        '
        Me.btnEmployee.BackgroundImage = CType(resources.GetObject("btnEmployee.BackgroundImage"), System.Drawing.Image)
        Me.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmployee.Location = New System.Drawing.Point(143, 110)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(100, 100)
        Me.btnEmployee.TabIndex = 1
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnAttendance
        '
        Me.btnAttendance.BackColor = System.Drawing.SystemColors.Control
        Me.btnAttendance.BackgroundImage = CType(resources.GetObject("btnAttendance.BackgroundImage"), System.Drawing.Image)
        Me.btnAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAttendance.Location = New System.Drawing.Point(396, 110)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(100, 100)
        Me.btnAttendance.TabIndex = 2
        Me.btnAttendance.UseVisualStyleBackColor = False
        '
        'btnLeave
        '
        Me.btnLeave.BackgroundImage = CType(resources.GetObject("btnLeave.BackgroundImage"), System.Drawing.Image)
        Me.btnLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLeave.Location = New System.Drawing.Point(642, 110)
        Me.btnLeave.Name = "btnLeave"
        Me.btnLeave.Size = New System.Drawing.Size(100, 100)
        Me.btnLeave.TabIndex = 3
        Me.btnLeave.UseVisualStyleBackColor = True
        '
        'btnSalary
        '
        Me.btnSalary.BackgroundImage = CType(resources.GetObject("btnSalary.BackgroundImage"), System.Drawing.Image)
        Me.btnSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalary.Location = New System.Drawing.Point(642, 357)
        Me.btnSalary.Name = "btnSalary"
        Me.btnSalary.Size = New System.Drawing.Size(100, 100)
        Me.btnSalary.TabIndex = 6
        Me.btnSalary.UseVisualStyleBackColor = True
        '
        'btnLoan
        '
        Me.btnLoan.BackgroundImage = CType(resources.GetObject("btnLoan.BackgroundImage"), System.Drawing.Image)
        Me.btnLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoan.Location = New System.Drawing.Point(396, 357)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(100, 100)
        Me.btnLoan.TabIndex = 5
        Me.btnLoan.UseVisualStyleBackColor = True
        '
        'btnAdvance
        '
        Me.btnAdvance.BackgroundImage = CType(resources.GetObject("btnAdvance.BackgroundImage"), System.Drawing.Image)
        Me.btnAdvance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdvance.Location = New System.Drawing.Point(143, 357)
        Me.btnAdvance.Name = "btnAdvance"
        Me.btnAdvance.Size = New System.Drawing.Size(100, 100)
        Me.btnAdvance.TabIndex = 4
        Me.btnAdvance.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(134, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Employee Master"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(388, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Attendance Entry"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(648, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Leave Entry"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(136, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Advance Entry"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(402, 460)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Loan Entry"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(645, 460)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Salary Entry"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 562)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalary)
        Me.Controls.Add(Me.btnLoan)
        Me.Controls.Add(Me.btnAdvance)
        Me.Controls.Add(Me.btnLeave)
        Me.Controls.Add(Me.btnAttendance)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PayRoll Management"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents btnAttendance As System.Windows.Forms.Button
    Friend WithEvents btnLeave As System.Windows.Forms.Button
    Friend WithEvents btnSalary As System.Windows.Forms.Button
    Friend WithEvents btnLoan As System.Windows.Forms.Button
    Friend WithEvents btnAdvance As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
