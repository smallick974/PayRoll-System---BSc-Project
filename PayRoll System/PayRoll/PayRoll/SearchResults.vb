Imports System.Data.SqlClient
Public Class frmSearchResults
    Dim con As New SqlConnection("Data Source=SRIJAN-PC\SQLExpress; Initial Catalog=ArvivaIndustries; Integrated Security=True")
    Public Shared id1 As String

    Private Sub dgvSearchResults_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvSearchResults.CellMouseDoubleClick
        con.Open()
        Try
            Dim cmd1 As New SqlCommand("Select LeavingDate from EmpDetails where EmpId=@id and LeavingDate is not null", con)
            cmd1.Parameters.AddWithValue("@id", dgvSearchResults.CurrentRow.Cells(0).Value.ToString)

            If cmd1.ExecuteNonQuery = Nothing Then
                frmEmployeeMaster.dtpDateOfLeaving.Text = "  /  /"
            Else
                frmEmployeeMaster.dtpDateOfLeaving.Text = cmd1.ExecuteScalar
            End If

            Dim cmd2 As New SqlCommand("Select ConfirmationDate from EmpDetails where EmpId=@id and ConfirmationDate is not null", con)
            cmd2.Parameters.AddWithValue("@id", dgvSearchResults.CurrentRow.Cells(0).Value.ToString)
            If cmd2.ExecuteNonQuery = Nothing Then
                frmEmployeeMaster.dtpDateOfConfirmation.Text = "  /  /"
            Else
                frmEmployeeMaster.dtpDateOfConfirmation.Text = cmd2.ExecuteScalar
            End If

            Dim cmd As New SqlCommand("select * from EmpDetails where EmpId=@id", con)
            cmd.Parameters.AddWithValue("@id", dgvSearchResults.CurrentRow.Cells(0).Value.ToString)
            id1 = dgvSearchResults.CurrentRow.Cells(0).Value.ToString
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    frmEmployeeMaster.Show()
                    frmEmployeeMaster.txtEmpNo.Text = dr.GetString(0)
                    frmEmployeeMaster.cboDeptCode.Text = dr.GetString(2)
                    frmEmployeeMaster.txtDesign.Text = dr.GetString(3)
                    frmEmployeeMaster.dtpDateOfJoining.Text = dr.GetDateTime(4)
                    frmEmployeeMaster.cboConfirm.Text = dr.GetString(5)
                    frmEmployeeMaster.cboBankName.Text = dr.GetString(8)
                    frmEmployeeMaster.txtBranchName.Text = dr.GetString(9)
                    frmEmployeeMaster.txtACNo.Text = dr.GetString(10)
                    frmEmployeeMaster.txtIFSCCode.Text = dr.GetString(11)
                    frmEmployeeMaster.txtAadhar.Text = dr.GetString(12)
                    frmEmployeeMaster.txtPFNo.Text = dr.GetString(13)
                    frmEmployeeMaster.txtPan.Text = dr.GetString(14)
                    frmEmployeeMaster.txtESICNo.Text = dr.GetString(15)
                    frmEmployeeMaster.txtEmpName.Text = dr.GetString(16)
                    frmEmployeeMaster.txtFatherName.Text = dr.GetString(17)
                    frmEmployeeMaster.txtMotherName.Text = dr.GetString(18)
                    frmEmployeeMaster.cboGender.Text = dr.GetString(19)
                    frmEmployeeMaster.dtpDateOfBirth.Text = dr.GetDateTime(20)
                    frmEmployeeMaster.cboBloodGrp.Text = dr.GetString(21)
                    frmEmployeeMaster.cboMaritalStatus.Text = dr.GetString(22)
                    frmEmployeeMaster.txtSpouseName.Text = dr.GetString(23)
                    frmEmployeeMaster.cboCategory.Text = dr.GetString(24)
                    frmEmployeeMaster.txtCaste.Text = dr.GetString(25)
                    frmEmployeeMaster.cboReligion.Text = dr.GetString(26)
                    frmEmployeeMaster.txtNationality.Text = dr.GetString(27)
                    frmEmployeeMaster.cboEduQualification.Text = dr.GetString(28)
                    frmEmployeeMaster.txtExperiences.Text = dr.GetString(29)
                    frmEmployeeMaster.txtAddr.Text = dr.GetString(30)
                    frmEmployeeMaster.txtContact.Text = dr.GetValue(31)
                    frmEmployeeMaster.txtEmailId.Text = dr.GetValue(32)
                    frmEmployeeMaster.txtPerAddr.Text = dr.GetString(33)
                    frmEmployeeMaster.txtPerPhone.Text = dr.GetValue(34)
                End While
            End If
            dr.Close()

            Dim cmd3 As New SqlCommand("select * from EmpSalary where EmpId=@id", con)
            cmd3.Parameters.AddWithValue("@id", dgvSearchResults.CurrentRow.Cells(0).Value.ToString)
            dr = cmd3.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    frmEmployeeMaster.txtBasic.Text = dr.GetValue(1)
                    frmEmployeeMaster.txtHRA.Text = dr.GetValue(2)
                    frmEmployeeMaster.txtConveyance.Text = dr.GetValue(3)
                    frmEmployeeMaster.txtCityConveyance.Text = dr.GetValue(4)
                    frmEmployeeMaster.txtWAll.Text = dr.GetValue(5)
                    frmEmployeeMaster.txtOtherAllowance.Text = dr.GetValue(6)
                End While
            End If
            dr.Close()

            frmEmployeeMaster.txtEmpNo.Enabled = False
            frmEmployeeMaster.cboCatCode.Enabled = False
            frmEmployeeMaster.cboDeptCode.Enabled = False
            frmEmployeeMaster.txtDesign.Enabled = False
            frmEmployeeMaster.dtpDateOfJoining.Enabled = False
            frmEmployeeMaster.dtpDateOfLeaving.Enabled = False
            frmEmployeeMaster.dtpDateOfConfirmation.Enabled = False
            frmEmployeeMaster.cboBankName.Enabled = False
            frmEmployeeMaster.txtBranchName.Enabled = False
            frmEmployeeMaster.txtACNo.Enabled = False
            frmEmployeeMaster.txtIFSCCode.Enabled = False
            frmEmployeeMaster.txtPFNo.Enabled = False
            frmEmployeeMaster.txtESICNo.Enabled = False
            frmEmployeeMaster.txtEmpName.Enabled = False
            frmEmployeeMaster.txtFatherName.Enabled = False
            frmEmployeeMaster.txtMotherName.Enabled = False
            frmEmployeeMaster.cboGender.Enabled = False
            frmEmployeeMaster.dtpDateOfBirth.Enabled = False
            frmEmployeeMaster.txtAge.Enabled = False
            frmEmployeeMaster.cboBloodGrp.Enabled = False
            frmEmployeeMaster.cboMaritalStatus.Enabled = False
            frmEmployeeMaster.txtSpouseName.Enabled = False
            frmEmployeeMaster.cboCategory.Enabled = False
            frmEmployeeMaster.txtCaste.Enabled = False
            frmEmployeeMaster.cboReligion.Enabled = False
            frmEmployeeMaster.txtNationality.Enabled = False
            frmEmployeeMaster.cboEduQualification.Enabled = False
            frmEmployeeMaster.txtExperiences.Enabled = False
            frmEmployeeMaster.txtAddr.Enabled = False
            frmEmployeeMaster.txtContact.Enabled = False
            frmEmployeeMaster.txtEmailId.Enabled = False
            frmEmployeeMaster.txtPerAddr.Enabled = False
            frmEmployeeMaster.txtPerPhone.Enabled = False
            frmEmployeeMaster.cboConfirm.Enabled = False
            frmEmployeeMaster.txtAadhar.Enabled = False
            frmEmployeeMaster.txtPan.Enabled = False
            frmEmployeeMaster.txtBasic.Enabled = False
            frmEmployeeMaster.txtHRA.Enabled = False
            frmEmployeeMaster.txtConveyance.Enabled = False
            frmEmployeeMaster.txtCityConveyance.Enabled = False
            frmEmployeeMaster.txtWAll.Enabled = False
            frmEmployeeMaster.txtOtherAllowance.Enabled = False
            frmEmployeeMaster.txtTotalWage.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
        frmEmployeeMaster.btnPrint.Enabled = True
        frmEmployeeMaster.btnUpdate.Enabled = True
        Me.Close()
    End Sub
End Class