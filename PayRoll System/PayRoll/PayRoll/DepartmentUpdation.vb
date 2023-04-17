Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmDepartmentUpdate
    Dim con As New SqlConnection("Data Source=SRIJAN-PC\SQLExpress; Initial Catalog=ArvivaIndustries; Integrated Security=True")
    Dim deptId As Integer
    Dim deptName, id As String
    
    Function ViewDepartment()
        Try
            Dim da As New SqlDataAdapter("select * from DepartmentUpdate", con)
            Dim ds As New DataSet
            da.Fill(ds, "s")
            dgvDept.DataSource = ds.Tables(0)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Nothing
    End Function

    Public Function deptIdGenerator()
        Try
            Dim cmd As New SqlCommand("SELECT max(substring(DepartmentId,3,3)) from DepartmentUpdate", con)
            If IsDBNull(cmd.ExecuteScalar) Then
                id = "D-100"
                txtDeptCode.Text = id
            Else
                deptId = cmd.ExecuteScalar
                deptId += 1
                txtDeptCode.Text = "D-" & deptId
            End If
            ViewDepartment()
        Catch ex As NullReferenceException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Nothing
    End Function

    Private Sub frmDepartmentUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        deptIdGenerator()
        con.Close()
    End Sub

    Private Sub txtDeptName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeptName.TextChanged
        Dim activeTextBox As TextBox = CType(sender, TextBox)
        Validations.checkNames(activeTextBox, "Department")
    End Sub

    Private Sub MakeProperCase(ByVal sender As Object, ByVal e As EventArgs) Handles txtDeptName.LostFocus
        Validations.properCase(sender, e)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If txtDeptName.Text = Nothing Then
                Throw New NullReferenceException
            ElseIf Not Regex.Match(txtDeptName.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
                Throw New InvalidConstraintException
            Else
                deptName = txtDeptName.Text
            End If

            con.Open()
            Dim cmd As New SqlCommand("insert into DepartmentUpdate values(@DepartmentId,@DepartmentName)", con)
            cmd.Parameters.AddWithValue("@DepartmentId", txtDeptCode.Text)
            cmd.Parameters.AddWithValue("@DepartmentName", deptName)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDeptName.Clear()
            deptIdGenerator()
            con.Close()
        Catch ex As NullReferenceException
            MessageBox.Show("Please Enter Department Name")
        Catch myException As InvalidConstraintException
            MessageBox.Show("Enter valid department name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDeptName.Clear()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub updateDepartment(ByVal sender As Object, ByVal e As EventArgs) Handles dgvDept.CellMouseDoubleClick
        Dim num As String = dgvDept.CurrentRow.Cells(0).Value.ToString
        Dim name As String = dgvDept.CurrentRow.Cells(1).Value.ToString
        txtDeptCode.Text = num
        txtDeptName.Text = name
        btnAdd.Enabled = False
        btnSave.Visible = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand("update DepartmentUpdate set DepartmentName=@DeptName where DepartmentId=@DeptId", con)
            cmd.Parameters.AddWithValue("@DeptName", txtDeptName.Text)
            cmd.Parameters.AddWithValue("@DeptId", txtDeptCode.Text)
            Dim msg As String = MessageBox.Show("Do you want to save..???", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msg = DialogResult.Yes Then
                cmd.ExecuteNonQuery()
                ViewDepartment()
                btnSave.Visible = False
                txtDeptName.Clear()
                btnAdd.Enabled = True
                deptIdGenerator()
            ElseIf msg = DialogResult.No Then
                btnSave.Visible = False
                btnAdd.Enabled = True
                txtDeptName.Clear()
                deptIdGenerator()
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
    End Sub
End Class