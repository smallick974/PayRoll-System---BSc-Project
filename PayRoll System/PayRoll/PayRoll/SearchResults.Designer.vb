<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchResults
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
        Me.dgvSearchResults = New System.Windows.Forms.DataGridView()
        Me.statusSearch = New System.Windows.Forms.StatusStrip()
        Me.tslMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslHelp = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSearchResults
        '
        Me.dgvSearchResults.AllowUserToAddRows = False
        Me.dgvSearchResults.AllowUserToDeleteRows = False
        Me.dgvSearchResults.AllowUserToResizeRows = False
        Me.dgvSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchResults.Location = New System.Drawing.Point(1, 2)
        Me.dgvSearchResults.Name = "dgvSearchResults"
        Me.dgvSearchResults.ReadOnly = True
        Me.dgvSearchResults.RowHeadersVisible = False
        Me.dgvSearchResults.Size = New System.Drawing.Size(927, 552)
        Me.dgvSearchResults.TabIndex = 1
        '
        'statusSearch
        '
        Me.statusSearch.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslMessage, Me.tslHelp})
        Me.statusSearch.Location = New System.Drawing.Point(0, 555)
        Me.statusSearch.Name = "statusSearch"
        Me.statusSearch.Size = New System.Drawing.Size(931, 24)
        Me.statusSearch.TabIndex = 2
        Me.statusSearch.Text = "StatusStrip1"
        '
        'tslMessage
        '
        Me.tslMessage.Name = "tslMessage"
        Me.tslMessage.Size = New System.Drawing.Size(0, 19)
        '
        'tslHelp
        '
        Me.tslHelp.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.tslHelp.Name = "tslHelp"
        Me.tslHelp.Size = New System.Drawing.Size(187, 19)
        Me.tslHelp.Text = "Double Click Row To View Details"
        '
        'frmSearchResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 579)
        Me.Controls.Add(Me.statusSearch)
        Me.Controls.Add(Me.dgvSearchResults)
        Me.MaximizeBox = False
        Me.Name = "frmSearchResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Results"
        CType(Me.dgvSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusSearch.ResumeLayout(False)
        Me.statusSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSearchResults As System.Windows.Forms.DataGridView
    Friend WithEvents statusSearch As System.Windows.Forms.StatusStrip
    Friend WithEvents tslMessage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
