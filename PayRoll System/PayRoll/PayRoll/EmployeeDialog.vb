Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class dlgSearch
    Dim con As New SqlConnection("Data Source=SRIJAN-PC\SQLExpress; Initial Catalog=ArvivaIndustries; Integrated Security=True")

    Private Sub dlgSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        Try
            cboDept.Items.Clear()
            Dim cmd As New SqlCommand("select * from DepartmentUpdate", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cboDept.Items.Add(dr.GetString(0) & " " & dr.GetString(1))
                End While
            End If
            dr.Close()
            cboCategory.SelectedIndex = -1
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
