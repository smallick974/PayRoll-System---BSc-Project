<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeave
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLeave))
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalLeave = New System.Windows.Forms.Label()
        Me.lblLeaveCurrentYear = New System.Windows.Forms.Label()
        Me.lblLastYearBal = New System.Windows.Forms.Label()
        Me.dgvLeaveStatus = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.cboDept = New System.Windows.Forms.ComboBox()
        Me.txtSanctionedBy = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.txtNoOfDays = New System.Windows.Forms.TextBox()
        Me.cboLeaveType = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboEmpId = New System.Windows.Forms.ComboBox()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BalanceLeave = New System.Windows.Forms.GroupBox()
        Me.dgvBalanceLeave = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvLeaveStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.BalanceLeave.SuspendLayout()
        CType(Me.dgvBalanceLeave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Enabled = False
        Me.btnOk.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(654, 412)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(90, 30)
        Me.btnOk.TabIndex = 19
        Me.btnOk.Text = "Save"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Enabled = False
        Me.btnNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(529, 412)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(90, 30)
        Me.btnNew.TabIndex = 20
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblTotalLeave)
        Me.GroupBox1.Controls.Add(Me.lblLeaveCurrentYear)
        Me.GroupBox1.Controls.Add(Me.lblLastYearBal)
        Me.GroupBox1.Controls.Add(Me.dgvLeaveStatus)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(451, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 176)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Leave Status"
        '
        'lblTotalLeave
        '
        Me.lblTotalLeave.AutoSize = True
        Me.lblTotalLeave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLeave.Location = New System.Drawing.Point(5, 122)
        Me.lblTotalLeave.Name = "lblTotalLeave"
        Me.lblTotalLeave.Size = New System.Drawing.Size(62, 19)
        Me.lblTotalLeave.TabIndex = 3
        Me.lblTotalLeave.Text = "monkey"
        '
        'lblLeaveCurrentYear
        '
        Me.lblLeaveCurrentYear.AutoSize = True
        Me.lblLeaveCurrentYear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaveCurrentYear.Location = New System.Drawing.Point(6, 70)
        Me.lblLeaveCurrentYear.Name = "lblLeaveCurrentYear"
        Me.lblLeaveCurrentYear.Size = New System.Drawing.Size(21, 19)
        Me.lblLeaveCurrentYear.TabIndex = 2
        Me.lblLeaveCurrentYear.Text = "hi"
        '
        'lblLastYearBal
        '
        Me.lblLastYearBal.AutoSize = True
        Me.lblLastYearBal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastYearBal.Location = New System.Drawing.Point(6, 25)
        Me.lblLastYearBal.Name = "lblLastYearBal"
        Me.lblLastYearBal.Size = New System.Drawing.Size(32, 19)
        Me.lblLastYearBal.TabIndex = 1
        Me.lblLastYearBal.Text = "abc"
        '
        'dgvLeaveStatus
        '
        Me.dgvLeaveStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeaveStatus.Location = New System.Drawing.Point(162, 25)
        Me.dgvLeaveStatus.Name = "dgvLeaveStatus"
        Me.dgvLeaveStatus.Size = New System.Drawing.Size(172, 139)
        Me.dgvLeaveStatus.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label58)
        Me.GroupBox2.Controls.Add(Me.dtpToDate)
        Me.GroupBox2.Controls.Add(Me.dtpFromDate)
        Me.GroupBox2.Controls.Add(Me.cboDept)
        Me.GroupBox2.Controls.Add(Me.txtSanctionedBy)
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.txtReason)
        Me.GroupBox2.Controls.Add(Me.txtNoOfDays)
        Me.GroupBox2.Controls.Add(Me.cboLeaveType)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboEmpId)
        Me.GroupBox2.Controls.Add(Me.txtDesignation)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtEmpName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 500)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Leave Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(135, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 19)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(135, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 19)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "*"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Red
        Me.Label58.Location = New System.Drawing.Point(135, 38)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(17, 19)
        Me.Label58.TabIndex = 142
        Me.Label58.Text = "*"
        '
        'dtpToDate
        '
        Me.dtpToDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpToDate.Enabled = False
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(273, 295)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(120, 26)
        Me.dtpToDate.TabIndex = 38
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpFromDate.Enabled = False
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromDate.Location = New System.Drawing.Point(72, 295)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(120, 26)
        Me.dtpFromDate.TabIndex = 37
        '
        'cboDept
        '
        Me.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDept.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.Location = New System.Drawing.Point(158, 35)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(214, 27)
        Me.cboDept.TabIndex = 36
        '
        'txtSanctionedBy
        '
        Me.txtSanctionedBy.Enabled = False
        Me.txtSanctionedBy.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSanctionedBy.Location = New System.Drawing.Point(297, 442)
        Me.txtSanctionedBy.Name = "txtSanctionedBy"
        Me.txtSanctionedBy.Size = New System.Drawing.Size(142, 26)
        Me.txtSanctionedBy.TabIndex = 35
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(82, 408)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAddress.Size = New System.Drawing.Size(206, 83)
        Me.txtAddress.TabIndex = 34
        '
        'txtReason
        '
        Me.txtReason.Enabled = False
        Me.txtReason.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.Location = New System.Drawing.Point(254, 358)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(185, 26)
        Me.txtReason.TabIndex = 33
        '
        'txtNoOfDays
        '
        Me.txtNoOfDays.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfDays.Location = New System.Drawing.Point(103, 355)
        Me.txtNoOfDays.Name = "txtNoOfDays"
        Me.txtNoOfDays.Size = New System.Drawing.Size(63, 26)
        Me.txtNoOfDays.TabIndex = 32
        '
        'cboLeaveType
        '
        Me.cboLeaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLeaveType.Enabled = False
        Me.cboLeaveType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLeaveType.FormattingEnabled = True
        Me.cboLeaveType.Items.AddRange(New Object() {"", "CL", "SL", "OH", "PL", "LWP"})
        Me.cboLeaveType.Location = New System.Drawing.Point(158, 243)
        Me.cboLeaveType.Name = "cboLeaveType"
        Me.cboLeaveType.Size = New System.Drawing.Size(105, 27)
        Me.cboLeaveType.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(291, 411)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 19)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Sanctioned by"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 411)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 19)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Address"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(188, 358)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 19)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Reason"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 358)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 19)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "No. of days"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 19)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(222, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "To"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Leave Type"
        '
        'cboEmpId
        '
        Me.cboEmpId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpId.FormattingEnabled = True
        Me.cboEmpId.Location = New System.Drawing.Point(159, 86)
        Me.cboEmpId.Name = "cboEmpId"
        Me.cboEmpId.Size = New System.Drawing.Size(214, 27)
        Me.cboEmpId.TabIndex = 21
        '
        'txtDesignation
        '
        Me.txtDesignation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation.Location = New System.Drawing.Point(158, 187)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.ReadOnly = True
        Me.txtDesignation.Size = New System.Drawing.Size(214, 26)
        Me.txtDesignation.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Designation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Department"
        '
        'txtEmpName
        '
        Me.txtEmpName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpName.Location = New System.Drawing.Point(159, 138)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.ReadOnly = True
        Me.txtEmpName.Size = New System.Drawing.Size(214, 26)
        Me.txtEmpName.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Employee Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Employee Id"
        '
        'BalanceLeave
        '
        Me.BalanceLeave.Controls.Add(Me.dgvBalanceLeave)
        Me.BalanceLeave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceLeave.Location = New System.Drawing.Point(451, 234)
        Me.BalanceLeave.Name = "BalanceLeave"
        Me.BalanceLeave.Size = New System.Drawing.Size(340, 74)
        Me.BalanceLeave.TabIndex = 28
        Me.BalanceLeave.TabStop = False
        Me.BalanceLeave.Text = "BalanceLeave"
        '
        'dgvBalanceLeave
        '
        Me.dgvBalanceLeave.AllowUserToAddRows = False
        Me.dgvBalanceLeave.AllowUserToDeleteRows = False
        Me.dgvBalanceLeave.AllowUserToOrderColumns = True
        Me.dgvBalanceLeave.AllowUserToResizeColumns = False
        Me.dgvBalanceLeave.AllowUserToResizeRows = False
        Me.dgvBalanceLeave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBalanceLeave.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvBalanceLeave.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvBalanceLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBalanceLeave.Enabled = False
        Me.dgvBalanceLeave.Location = New System.Drawing.Point(3, 23)
        Me.dgvBalanceLeave.MultiSelect = False
        Me.dgvBalanceLeave.Name = "dgvBalanceLeave"
        Me.dgvBalanceLeave.ReadOnly = True
        Me.dgvBalanceLeave.RowHeadersVisible = False
        Me.dgvBalanceLeave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvBalanceLeave.Size = New System.Drawing.Size(334, 51)
        Me.dgvBalanceLeave.TabIndex = 0
        '
        'frmLeave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(795, 515)
        Me.Controls.Add(Me.BalanceLeave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLeave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leave Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvLeaveStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.BalanceLeave.ResumeLayout(False)
        CType(Me.dgvBalanceLeave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLeaveCurrentYear As System.Windows.Forms.Label
    Friend WithEvents lblLastYearBal As System.Windows.Forms.Label
    Friend WithEvents dgvLeaveStatus As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboLeaveType As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboEmpId As System.Windows.Forms.ComboBox
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSanctionedBy As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents txtNoOfDays As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalLeave As System.Windows.Forms.Label
    Friend WithEvents cboDept As System.Windows.Forms.ComboBox
    Friend WithEvents BalanceLeave As System.Windows.Forms.GroupBox
    Friend WithEvents dgvBalanceLeave As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label

End Class
