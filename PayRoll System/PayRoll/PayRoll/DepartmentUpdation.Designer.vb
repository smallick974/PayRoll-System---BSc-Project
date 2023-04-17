<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartmentUpdate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDeptCode = New System.Windows.Forms.TextBox()
        Me.txtDeptName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDept = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department Name"
        '
        'txtDeptCode
        '
        Me.txtDeptCode.Location = New System.Drawing.Point(187, 24)
        Me.txtDeptCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeptCode.Name = "txtDeptCode"
        Me.txtDeptCode.ReadOnly = True
        Me.txtDeptCode.Size = New System.Drawing.Size(208, 26)
        Me.txtDeptCode.TabIndex = 2
        Me.txtDeptCode.TabStop = False
        '
        'txtDeptName
        '
        Me.txtDeptName.Location = New System.Drawing.Point(187, 67)
        Me.txtDeptName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeptName.Name = "txtDeptName"
        Me.txtDeptName.Size = New System.Drawing.Size(208, 26)
        Me.txtDeptName.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(117, 118)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(69, 35)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dgvDept)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 161)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(368, 217)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DEPARTMENT DETAILS"
        '
        'dgvDept
        '
        Me.dgvDept.AllowUserToAddRows = False
        Me.dgvDept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDept.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDept.Location = New System.Drawing.Point(0, 29)
        Me.dgvDept.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDept.MultiSelect = False
        Me.dgvDept.Name = "dgvDept"
        Me.dgvDept.ReadOnly = True
        Me.dgvDept.RowHeadersVisible = False
        Me.dgvDept.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDept.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDept.Size = New System.Drawing.Size(368, 192)
        Me.dgvDept.TabIndex = 4
        Me.dgvDept.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(219, 118)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(69, 35)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'frmDepartmentUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 394)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtDeptName)
        Me.Controls.Add(Me.txtDeptCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmDepartmentUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Department Updation Form"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDeptCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDeptName As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDept As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
