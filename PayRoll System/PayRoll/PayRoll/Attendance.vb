Imports System.Data.SqlClient

Public Class frmAttendance
    Dim con As New SqlConnection("Data Source=SRIJAN-PC\SQLExpress; Initial Catalog=ArvivaIndustries; Integrated Security=True")

    Function addDepartment()
        cboDept.Items.Clear()
        Dim cmd As New SqlCommand("select * from DepartmentUpdate", con)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cboDept.Items.Add(dr.GetString(0) & " " & dr.GetString(1))
            End While
        End If
        dr.Close()
        Return Nothing
    End Function

    Function removeDepartment()
        Dim a As Integer = cboDept.Items.Count - 1
        Dim dr As SqlDataReader
        Dim cmd1 As New SqlCommand("select DepartmentCode from EmpDetails,Attendance where Date=@date and EmpDetails.EmpId=Attendance.EmpId", con)
        cmd1.Parameters.AddWithValue("@date", dtpDate.Value)
        dr = cmd1.ExecuteReader

        If dr.HasRows Then
            While dr.Read
                For i As Integer = cboDept.Items.Count - 1 To 0 Step -1
                    If cboDept.Items.Item(i) = dr.GetString(0) Then
                        cboDept.Items.Remove(cboDept.Items.Item(i))
                    End If
                Next
            End While
        End If
        dr.Close()
        Return Nothing
    End Function

    Private Sub frmAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con.Open()
            addDepartment()
            removeDepartment()
            btnSave.Enabled = False
            ' dtpDate.Enabled = False
            'Dim cmd1 As New SqlCommand("delete from Attendance ", con)
            'cmd1.ExecuteScalar()

            con.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub cboDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDept.SelectedIndexChanged
        Try
            con.Open()
            Try
                btnSave.Enabled = True
                Dim da As New SqlDataAdapter("select EmpId, Name from EmpDetails where DepartmentCode=@dept", con)
                da.SelectCommand.Parameters.Add("@dept", SqlDbType.VarChar, 40).Value = cboDept.Text
                Dim ds As New DataSet
                da.Fill(ds, "s")
                dgvAttendance.DataSource = ds.Tables(0)
                For i As Integer = 0 To dgvAttendance.RowCount - 1
                    dgvAttendance.Rows(i).Cells(0).Value = "Present"
                    dgvAttendance.Rows(i).Cells(1).Value = Convert.ToDateTime(dtpDate.Value).AddHours(9)
                    dgvAttendance.Rows(i).Cells(2).Value = Convert.ToDateTime(dgvAttendance.Rows(i).Cells(1).Value).AddHours(8)
                Next
            Catch ex As SqlException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            btnSave.Enabled = False
            con.Open()
            Dim count1 As Integer
            For i As Integer = 0 To dgvAttendance.RowCount - 1
                Dim cmd As New SqlCommand("insert into Attendance values(@EmpId,@Date,@Status,@CheckIn,@CheckOut)", con)
                cmd.Parameters.AddWithValue("@EmpId", dgvAttendance.Rows(i).Cells(3).Value.ToString())
                cmd.Parameters.AddWithValue("@Date", dtpDate.Value)
                cmd.Parameters.AddWithValue("@Status", dgvAttendance.Rows(i).Cells(0).Value.ToString)

                If dgvAttendance.Rows(i).Cells(1).Value = "" Then
                    cmd.Parameters.AddWithValue("@CheckIn", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@CheckIn", Convert.ToDateTime(dgvAttendance.Rows(i).Cells(1).Value))
                End If

                If dgvAttendance.Rows(i).Cells(2).Value = "" Then
                    cmd.Parameters.AddWithValue("@CheckOut", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@CheckOut", Convert.ToDateTime(dgvAttendance.Rows(i).Cells(2).Value))
                End If
                count1 += cmd.ExecuteNonQuery()
            Next

            If count1 = dgvAttendance.Rows.Count Then
                MessageBox.Show("Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'For i As Integer = 0 To dgvAttendance.RowCount - 1
                '    MsgBox(DateDiff(DateInterval.Hour, Convert.ToDateTime(dgvAttendance.Rows(i).Cells(1).Value), Convert.ToDateTime(dgvAttendance.Rows(i).Cells(2).Value)))
                '    If DateDiff(DateInterval.Hour, dgvAttendance.Rows(i).Cells(1).Value, dgvAttendance.Rows(i).Cells(2).Value) > 8 Then
                '        Dim cmd2 As New SqlCommand("insert into OverTIme values(@EmpId,@Date,@FromTime,@ToTime)", con)
                '        cmd2.Parameters.AddWithValue("@EmpId", dgvAttendance.Rows(i).Cells(3).Value.ToString())
                '        cmd2.Parameters.AddWithValue("@Date", dtpDate.Value)
                '        cmd2.Parameters.AddWithValue("@FromTime", dgvAttendance.Rows(i).Cells(1).Value)
                '        cmd2.Parameters.AddWithValue("@ToTime", dgvAttendance.Rows(i).Cells(2).Value)
                '        cmd2.ExecuteNonQuery()
                '    End If
                'Next
                removeDepartment()
                dgvAttendance.DataSource.Rows.Clear()
                btnSave.Enabled = False
            Else
                Throw New Exception
            End If
        Catch ex As Exception
            MessageBox.Show("hi" & ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
    End Sub

    Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged
        Try
            con.Open()
            While dgvAttendance.RowCount > 0
                dgvAttendance.Rows.RemoveAt(0)
            End While

            addDepartment()
            removeDepartment()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()

    End Sub

    Private Sub dgvAttendance_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAttendance.CellValueChanged
        For i As Integer = 0 To dgvAttendance.RowCount - 1
            If dgvAttendance.Rows(i).Cells(0).Value = "Absent" Then
                dgvAttendance.Rows(i).Cells(1).ReadOnly = True
                dgvAttendance.Rows(i).Cells(1).Value = ""
                dgvAttendance.Rows(i).Cells(2).ReadOnly = True
                dgvAttendance.Rows(i).Cells(2).Value = ""
            ElseIf dgvAttendance.Rows(i).Cells(0).Value = "Present" Then
                dgvAttendance.Rows(i).Cells(1).ReadOnly = False
                dgvAttendance.Rows(i).Cells(1).Value = Convert.ToDateTime(dtpDate.Value).AddHours(9)
                dgvAttendance.Rows(i).Cells(2).ReadOnly = False
                dgvAttendance.Rows(i).Cells(2).Value = Convert.ToDateTime(dgvAttendance.Rows(i).Cells(1).Value).AddHours(8)
            End If
        Next
    End Sub
End Class