Imports System.Data.SqlClient

Public Class frmLeave
    Dim con As New SqlConnection("Data Source=SRIJAN-PC\SQLExpress; Initial Catalog=ArvivaIndustries; Integrated Security=True")
    Dim num As Int32

    Public Function resetDate()
        dtpFromDate.Value = Date.Today
        dtpToDate.Value = Date.Today
        Return Nothing
    End Function

    Private Sub Validation_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReason.KeyUp, txtSanctionedBy.KeyUp
        Dim activeTextBox As TextBox = CType(sender, TextBox)
        If ((Validations.checkNames(activeTextBox.Text, "Text")) = 0) Then
            activeTextBox.Clear()
        End If
    End Sub

    Private Sub properCase_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReason.LostFocus, txtSanctionedBy.LostFocus, txtAddress.LostFocus
        Validations.properCase(sender, e)
    End Sub

    Private Sub frmLeave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblLastYearBal.Text = "Bal leave as on" & vbNewLine & New Date(Date.Today.Year - 1, 12, 31)
        lblLeaveCurrentYear.Text = "Leave earned during " & vbNewLine & "the year " & Date.Today.Year
        lblTotalLeave.Text = "Total leave due" & vbNewLine & "as on " & New Date(Date.Today.Year, 1, 1)
        dtpToDate.Enabled = False

        Try
            con.Open()
            Dim cmd As New SqlCommand("select * from DepartmentUpdate", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cboDept.Items.Add(dr.GetString(0) & " " & dr.GetString(1))
                End While
            End If
            dr.Close()

            'cmd.CommandText = "delete from EmployeeLeave"
            'cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub

  Private Sub cboDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDept.SelectedIndexChanged
        Try
            con.Open()
            cboEmpId.Items.Clear()
            Dim cmd As New SqlCommand("select EmpId from EmpDetails where DepartmentCode=@dept", con)
            cmd.Parameters.AddWithValue("@dept", cboDept.Text)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cboEmpId.Items.Add(dr.GetString(0))
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub

    Private Sub cboEmpId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmpId.SelectedIndexChanged
        Try
            con.Open()
            cboLeaveType.SelectedIndex = -1
            cboLeaveType.Enabled = True
            dtpFromDate.Enabled = True
            txtReason.Enabled = True
            txtAddress.Enabled = True
            txtSanctionedBy.Enabled = True
            btnOk.Enabled = True
            btnNew.Enabled = True

            Dim cmd As New SqlCommand("select Name, Designation from EmpDetails where EmpId=@id", con)
            cmd.Parameters.AddWithValue("@id", cboEmpId.Text)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    txtEmpName.Text = dr.GetString(0)
                    txtDesignation.Text = dr.GetString(1)
                End While
            End If
            dr.Close()

            Dim da As New SqlDataAdapter("select CL,SL,OH,PL,LWP from EmployeeLeave where EmpId=@id", con)
            da.SelectCommand.Parameters.Add("@id", SqlDbType.VarChar, 40).Value = cboEmpId.Text
            Dim ds As New DataSet
            da.Fill(ds, "s")
            dgvBalanceLeave.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub

    Private Sub cboLeaveType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLeaveType.SelectedIndexChanged
        Try
            If cboLeaveType.SelectedIndex = 1 Then
                num = dgvBalanceLeave.CurrentRow.Cells(0).Value.ToString
                dtpToDate.Value = dtpFromDate.Value
                txtNoOfDays.Text = DateDiff("d", dtpFromDate.Value, dtpToDate.Value) + 1

            ElseIf cboLeaveType.SelectedIndex = 2 Then
                num = dgvBalanceLeave.CurrentRow.Cells(1).Value.ToString
                dtpToDate.Value = dtpFromDate.Value
                txtNoOfDays.Text = DateDiff("d", dtpFromDate.Value, dtpToDate.Value) + 1

            ElseIf cboLeaveType.SelectedIndex = 3 Then
                num = dgvBalanceLeave.CurrentRow.Cells(2).Value.ToString
                dtpToDate.Value = dtpFromDate.Value
                txtNoOfDays.Text = DateDiff("d", dtpFromDate.Value, dtpToDate.Value) + 1

            ElseIf cboLeaveType.SelectedIndex = 4 Then
                Try
                    Dim count As Integer
                    con.Open()
                    Dim cmd As New SqlCommand("select count(EmpId) from Leave where FromDate between @fd and @td and EmpId=@id and TypeOfLeave='PL'", con)
                    cmd.Parameters.AddWithValue("@id", cboEmpId.Text)
                    cmd.Parameters.AddWithValue("@fd", New Date(Date.Today.Year, 1, 1))
                    cmd.Parameters.AddWithValue("@td", New Date(Date.Today.Year, 12, 31))
                    count = cmd.ExecuteScalar
                    MsgBox(count)
                    con.Close()
                    If count = 3 Then
                        Throw New Exception("PL Can't be granted as 3 PL is already given for the current year.")
                    Else
                        num = dgvBalanceLeave.CurrentRow.Cells(3).Value.ToString
                        dtpToDate.Value = DateAdd("d", 2, dtpFromDate.Value)
                        txtNoOfDays.Text = DateDiff("d", dtpFromDate.Value, dtpToDate.Value) + 1
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If

        Catch ex As NullReferenceException
            MessageBox.Show("Select Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboLeaveType.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboLeaveType.SelectedIndex = 0
        End Try
    End Sub

    Private Sub dtpFromDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFromDate.ValueChanged
        Try
            dtpToDate.Enabled = True
            If cboLeaveType.SelectedIndex = 4 Then
                dtpToDate.Value = DateAdd("d", 2, dtpFromDate.Value)
            Else
                dtpToDate.Value = dtpFromDate.Value
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtpToDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpToDate.ValueChanged
        Try
            If cboLeaveType.SelectedIndex = 4 Then
                If DateDiff("d", dtpFromDate.Value, dtpToDate.Value) + 1 < 3 Then
                    dtpToDate.Value = DateAdd("d", 2, dtpFromDate.Value)
                    Throw New Exception("PL Can't Be Less Than 3 Days")
                Else
                    txtNoOfDays.Text = DateDiff("d", dtpFromDate.Value, dtpToDate.Value) + 1
                End If

            Else
                If DateDiff("d", dtpFromDate.Value, dtpToDate.Value) + 1 < 1 Then
                    dtpToDate.Value = dtpFromDate.Value
                    Throw New Exception(cboLeaveType.SelectedItem & " Cannot Be  less Than 1 Day")
                Else
                    txtNoOfDays.Text = DateDiff("d", dtpFromDate.Value, dtpToDate.Value) + 1
                End If
            End If

            If Convert.ToInt32(txtNoOfDays.Text) > num Then
                If cboLeaveType.SelectedIndex = 4 Then
                    dtpToDate.Value = DateAdd("d", 2, dtpFromDate.Value)
                Else
                    dtpToDate.Value = dtpFromDate.Value
                End If
                Throw New Exception(cboLeaveType.SelectedItem & " Exceeds Maximum Limit")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If cboLeaveType.SelectedIndex = 1 Then
            dgvBalanceLeave.CurrentRow.Cells(0).Value = dgvBalanceLeave.CurrentRow.Cells(0).Value - txtNoOfDays.Text

        ElseIf cboLeaveType.SelectedIndex = 2 Then
            dgvBalanceLeave.CurrentRow.Cells(1).Value = dgvBalanceLeave.CurrentRow.Cells(1).Value - txtNoOfDays.Text

        ElseIf cboLeaveType.SelectedIndex = 3 Then
            dgvBalanceLeave.CurrentRow.Cells(2).Value = dgvBalanceLeave.CurrentRow.Cells(2).Value - txtNoOfDays.Text

        ElseIf cboLeaveType.SelectedIndex = 4 Then
            dgvBalanceLeave.CurrentRow.Cells(3).Value = dgvBalanceLeave.CurrentRow.Cells(3).Value - txtNoOfDays.Text

        ElseIf cboLeaveType.SelectedIndex = 5 Then
            dgvBalanceLeave.CurrentRow.Cells(4).Value = dgvBalanceLeave.CurrentRow.Cells(4).Value - txtNoOfDays.Text

        End If

        Try
            If cboLeaveType.SelectedIndex = 0 Or cboLeaveType.SelectedIndex = -1 Then
                Throw New Exception
            Else
                con.Open()
                Dim cmd As New SqlCommand("insert into Leave values(@EmpId,@TypeOfLeave,@FromDate,@ToDate,@NoOfDays,@Reason,@Address,@SanctionedBy)", con)
                cmd.Parameters.AddWithValue("@EmpId", cboEmpId.Text)
                cmd.Parameters.AddWithValue("@TypeOfLeave", cboLeaveType.Text)
                cmd.Parameters.AddWithValue("@FromDate", dtpFromDate.Value)
                cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value)
                cmd.Parameters.AddWithValue("@NoOfDays", txtNoOfDays.Text)
                cmd.Parameters.AddWithValue("@Reason", txtReason.Text)
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@SanctionedBy", txtSanctionedBy.Text)

                Dim cmd1 As New SqlCommand("update EmployeeLeave set LeaveDate=@ld,CL=@cl,SL=@sl,OH=@oh,PL=@pl,LWP=@lwp where EmpId=@id", con)
                cmd1.Parameters.AddWithValue("@id", cboEmpId.Text)
                cmd1.Parameters.AddWithValue("@ld", Date.Today)
                cmd1.Parameters.AddWithValue("@cl", dgvBalanceLeave.CurrentRow.Cells(0).Value.ToString)
                cmd1.Parameters.AddWithValue("@sl", dgvBalanceLeave.CurrentRow.Cells(1).Value.ToString)
                cmd1.Parameters.AddWithValue("@oh", dgvBalanceLeave.CurrentRow.Cells(2).Value.ToString)
                cmd1.Parameters.AddWithValue("@pl", dgvBalanceLeave.CurrentRow.Cells(3).Value.ToString)
                cmd1.Parameters.AddWithValue("@lwp", dgvBalanceLeave.CurrentRow.Cells(4).Value.ToString)

                Dim msg As String = MessageBox.Show("Do you want to save..???", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msg = DialogResult.Yes Then
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    MessageBox.Show("Record Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnOk.Enabled = False
                End If
            End If
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Select Leave Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            cboLeaveType.SelectedIndex = -1
            cboEmpId.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvLeaveStatus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLeaveStatus.CellContentClick

    End Sub
End Class
