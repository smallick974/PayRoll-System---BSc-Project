<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(start))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(784, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdmin.Image = CType(resources.GetObject("btnAdmin.Image"), System.Drawing.Image)
        Me.btnAdmin.Location = New System.Drawing.Point(177, 154)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(91, 87)
        Me.btnAdmin.TabIndex = 1
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.Location = New System.Drawing.Point(495, 154)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(98, 87)
        Me.btnUser.TabIndex = 2
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(97, 468)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ARVIVA INDUSTRIES (INDIA) LTD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TEL : 27401232/33, FAX : 91-22-27412035 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E-MAIL :" & _
            " admin@harrycollection.com"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 448)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 64)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 522)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN PAGE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
