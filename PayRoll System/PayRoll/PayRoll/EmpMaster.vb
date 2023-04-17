Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmEmployeeMaster
    Dim con As New SqlConnection("Data Source=SRIJAN-PC\SQLExpress; Initial Catalog=ArvivaIndustries; Integrated Security=True")
    Dim id As String
    Dim Eid, Rid, Sid As Integer
   
    Public Function idGenerator()
        Try
            If cboCatCode.SelectedIndex = 0 Then
                Dim cmd As New SqlCommand("SELECT max(substring(EmpId,3,4)) from EmpDetails where EmpId like 'E%'", con)
                If IsDBNull(cmd.ExecuteScalar) Then
                    id = "E-1000"
                    txtEmpNo.Text = id
                Else
                    Eid = cmd.ExecuteScalar
                    Eid += 1
                    txtEmpNo.Text = "E-" & Eid
                End If
            End If

            If cboCatCode.SelectedIndex = 1 Then
                Dim cmd As New SqlCommand("Select max(substring(EmpId,3,4)) from EmpDetails where EmpId like 'R%'", con)
                If IsDBNull(cmd.ExecuteScalar) Then
                    id = "R-1000"
                    txtEmpNo.Text = id
                Else
                    Rid = cmd.ExecuteScalar
                    Rid += 1
                    txtEmpNo.Text = "R-" & Rid
                End If
            End If

            If cboCatCode.SelectedIndex = 2 Then
                Dim cmd As New SqlCommand("Select max(substring(EmpId,3,4)) from EmpDetails where EmpId like 'S%'", con)
                If IsDBNull(cmd.ExecuteScalar) Then
                    id = "S-1000"
                    txtEmpNo.Text = id
                Else
                    Sid = cmd.ExecuteScalar
                    Sid += 1
                    txtEmpNo.Text = "S-" & Sid
                End If
            End If

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Nothing
    End Function

    Public Function allClear()
        cboBankName.SelectedIndex = -1
        cboBloodGrp.SelectedIndex = -1
        cboCategory.SelectedIndex = -1
        cboConfirm.SelectedIndex = -1
        cboDeptCode.SelectedIndex = -1
        cboEduQualification.SelectedIndex = -1
        cboGender.SelectedIndex = -1
        cboMaritalStatus.SelectedIndex = -1
        cboReligion.SelectedIndex = -1

        txtACNo.Clear()
        txtAddr.Clear()
        txtAge.Clear()
        txtBranchName.Clear()
        txtCaste.Clear()
        txtContact.Clear()
        txtDesign.Clear()
        txtEmailId.Clear()
        txtEmpName.Clear()
        txtESICNo.Clear()
        txtExperiences.Clear()
        txtFatherName.Clear()
        txtIFSCCode.Clear()
        txtMotherName.Clear()
        txtNationality.Clear()
        txtPerAddr.Clear()
        txtPerPhone.Clear()
        txtPFNo.Clear()
        txtSpouseName.Clear()
        dtpDateOfJoining.Clear()
        dtpDateOfConfirmation.Clear()
        dtpDateOfLeaving.Clear()
        txtAadhar.Clear()
        txtPan.Clear()
        txtBasic.Clear()
        txtHRA.Clear()
        txtConveyance.Clear()
        txtCityConveyance.Clear()
        txtWAll.Clear()
        txtOtherAllowance.Clear()
        txtTotalWage.Clear()
        rdoNo.Checked = True
        Return Nothing
    End Function

    Private Sub txtNamesValidation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCaste.TextChanged, txtDesign.TextChanged, txtEmpName.TextChanged, txtFatherName.TextChanged, txtMotherName.TextChanged, txtNationality.TextChanged, txtSpouseName.TextChanged, txtBranchName.TextChanged
        Dim activeTextBox As TextBox = CType(sender, TextBox)
        Validations.checkNames(activeTextBox, "Text")
    End Sub

    Private Sub makeProperCase(ByVal sender As Object, ByVal e As EventArgs) Handles _
    txtEmpName.LostFocus, txtFatherName.LostFocus, txtMotherName.LostFocus, txtSpouseName.LostFocus, txtCaste.LostFocus, txtNationality.LostFocus, txtExperiences.LostFocus, txtAddr.LostFocus, txtPerAddr.LostFocus, txtDesign.LostFocus
        Validations.properCase(sender, e)
    End Sub
    Private Sub cursorPosition(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPFNo.MouseClick, txtContact.MouseClick, txtPerPhone.MouseClick, txtESICNo.MouseClick, dtpDateOfConfirmation.MouseClick, dtpDateOfLeaving.MouseClick, txtAadhar.MouseClick, txtPan.MouseClick, dtpDateOfJoining.MouseClick
        Try
            Dim currMaskedTextBox As MaskedTextBox = sender
            currMaskedTextBox.SelectionStart = 0
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmEmployeeMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            btnPrint.Enabled = False
            btnUpdate.Enabled = False

            txtBasic.Text = 0
            txtHRA.Text = 0
            txtConveyance.Text = 0
            txtCityConveyance.Text = 0
            txtWAll.Text = 0
            txtOtherAllowance.Text = 0
            txtTotalWage.Text = 0

            cboReligion.SelectedIndex = 0
            cboCategory.SelectedIndex = 0
            cboBloodGrp.SelectedIndex = 0
            cboBankName.SelectedIndex = 0

            txtSpouseName.Enabled = False

            txtBranchName.Enabled = False
            txtACNo.Enabled = False
            txtIFSCCode.Enabled = False
            txtPerAddr.ReadOnly = True

            con.Open()
            Dim cmd As New SqlCommand("select * from DepartmentUpdate", con)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cboDeptCode.Items.Add(dr.GetString(0) & " " & dr.GetString(1))
                End While
            End If
            dr.Close()
            con.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub cboCatCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCatCode.SelectedIndexChanged
        con.Open()
        idGenerator()
        con.Close()
    End Sub

    Private Sub rdoYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoYes.CheckedChanged
        txtPerAddr.Text = txtAddr.Text
        txtPerAddr.ReadOnly = True
    End Sub

    Private Sub rdoNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoNo.CheckedChanged
        txtPerAddr.Clear()
        txtPerAddr.ReadOnly = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If cboCatCode.SelectedIndex = -1 Or cboDeptCode.SelectedIndex = -1 Or txtDesign.Text = Nothing Or cboConfirm.SelectedIndex = -1 _
                 Or txtEmpName.Text = Nothing _
                Or txtFatherName.Text = Nothing Or txtMotherName.Text = Nothing _
                Or cboGender.SelectedIndex = -1 Or cboMaritalStatus.SelectedIndex = -1 Or txtNationality.Text = Nothing Or cboEduQualification.SelectedIndex = -1 Or txtAddr.Text = Nothing Or txtContact.Text = Nothing _
                Or txtPerAddr.Text = Nothing Or txtPerPhone.Text = Nothing Or dtpDateOfJoining.Text = "  /  /" Then
                Throw New Exception("Fields Cannot Be Empty")
            End If

            con.Open()
            Dim cmd As New SqlCommand("insert into EmpDetails values(@EmpId,@EmpCategoryCode,@DepartmentCode,@Designation,@JoiningDate,@Confirmation,@LeavingDate,@ConfirmationDate,@BankName,@BranchName,@AccountNo,@IFSCCode,@Aadhar,@PFNo,@Pan,@ESICNo,@Name,@FathersName,@MothersName,@Gender,@DOB,@BloodGroup,@MaritalStatus,@SpouseName,@Category,@Caste,@Religion,@Nationality,@EduQualification,@Experiences,@Address,@ContactNo,@Email,@PermanentAddress,@PermanentContact)", con)
            cmd.Parameters.AddWithValue("@EmpId", txtEmpNo.Text)
            cmd.Parameters.AddWithValue("@EmpCategoryCode", cboCatCode.Text)
            cmd.Parameters.AddWithValue("@DepartmentCode", cboDeptCode.Text)
            cmd.Parameters.AddWithValue("@Designation", txtDesign.Text)
            cmd.Parameters.AddWithValue("@JoiningDate", Convert.ToDateTime(dtpDateOfJoining.Text))
            MsgBox(Convert.ToDateTime(dtpDateOfJoining.Text))
            cmd.Parameters.AddWithValue("@Confirmation", cboConfirm.Text)

            If dtpDateOfLeaving.Text = "  /  /" Then
                cmd.Parameters.AddWithValue("@LeavingDate", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@LeavingDate", Convert.ToDateTime(dtpDateOfLeaving.Text))
            End If

            If dtpDateOfConfirmation.Text = "  /  /" Then
                cmd.Parameters.AddWithValue("@ConfirmationDate", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@ConfirmationDate", Convert.ToDateTime(dtpDateOfConfirmation.Text))
            End If
            cmd.Parameters.AddWithValue("@BankName", cboBankName.Text)
            cmd.Parameters.AddWithValue("@BranchName", txtBranchName.Text)
            cmd.Parameters.AddWithValue("@AccountNo", txtACNo.Text)
            cmd.Parameters.AddWithValue("@IFSCCode", txtIFSCCode.Text)
            cmd.Parameters.AddWithValue("@Aadhar", txtAadhar.Text)
            cmd.Parameters.AddWithValue("@PFNo", txtPFNo.Text)
            cmd.Parameters.AddWithValue("@Pan", txtPan.Text)
            cmd.Parameters.AddWithValue("@ESICNo", txtESICNo.Text)
            cmd.Parameters.AddWithValue("@Name", txtEmpName.Text)
            cmd.Parameters.AddWithValue("@FathersName", txtFatherName.Text)
            cmd.Parameters.AddWithValue("@MothersName", txtMotherName.Text)
            cmd.Parameters.AddWithValue("@Gender", cboGender.Text)
            cmd.Parameters.AddWithValue("@DOB", dtpDateOfBirth.Value)
            cmd.Parameters.AddWithValue("@BloodGroup", cboBloodGrp.Text)
            cmd.Parameters.AddWithValue("@MaritalStatus", cboMaritalStatus.Text)
            cmd.Parameters.AddWithValue("@SpouseName", txtSpouseName.Text)
            cmd.Parameters.AddWithValue("@Category", cboCategory.Text)
            cmd.Parameters.AddWithValue("@Caste", txtCaste.Text)
            cmd.Parameters.AddWithValue("@Religion", cboReligion.Text)
            cmd.Parameters.AddWithValue("@Nationality", txtNationality.Text)
            cmd.Parameters.AddWithValue("@EduQualification", cboEduQualification.Text)
            cmd.Parameters.AddWithValue("@Experiences", txtExperiences.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddr.Text)
            cmd.Parameters.AddWithValue("@ContactNo", txtContact.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmailId.Text)
            cmd.Parameters.AddWithValue("@PermanentAddress", txtPerAddr.Text)
            cmd.Parameters.AddWithValue("@PermanentContact", txtPerPhone.Text)

            Dim cmd1 As New SqlCommand("insert into EmployeeLeave(EmpId,CL,SL,OH,PL,LWP)values(@EmpId,@CL,@SL,@OH,@PL,@LWP)", con)
            Dim cmd2 As New SqlCommand("select * from LeaveMaster", con)
            cmd1.Parameters.AddWithValue("@EmpId", txtEmpNo.Text)
            Dim dr As SqlDataReader = cmd2.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    cmd1.Parameters.AddWithValue("@CL", dr.GetValue(0).ToString)
                    cmd1.Parameters.AddWithValue("@SL", dr.GetValue(1).ToString)
                    cmd1.Parameters.AddWithValue("@OH", dr.GetValue(2).ToString)

                    Dim pl As Integer = dr.GetInt32(3)
                    pl = pl / 12
                    Dim mnth As Integer = Month(dtpDateOfJoining.Text)
                    pl = pl * (12 - (mnth - 1))
                    cmd1.Parameters.AddWithValue("@PL", pl)
                End While
            End If
            dr.Close()
            cmd1.Parameters.AddWithValue("@LWP", 0)

            Dim cmd3 As New SqlCommand("insert into EmpSalary values(@EmpId,@Basic,@HRA,@Conveyance,@CityConveyance,@WAllowance,@OtherAllowance)", con)
            cmd3.Parameters.AddWithValue("@EmpId", txtEmpNo.Text)
            cmd3.Parameters.AddWithValue("@Basic", txtBasic.Text)
            cmd3.Parameters.AddWithValue("@HRA", txtHRA.Text)
            cmd3.Parameters.AddWithValue("@Conveyance", txtConveyance.Text)
            cmd3.Parameters.AddWithValue("@CityConveyance", txtCityConveyance.Text)
            cmd3.Parameters.AddWithValue("@WAllowance", txtWAll.Text)
            cmd3.Parameters.AddWithValue("@OtherAllowance", txtOtherAllowance.Text)

            Dim msg As String = MessageBox.Show("Do you want to save..???", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msg = DialogResult.Yes Then
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                cmd3.ExecuteNonQuery()
                MessageBox.Show("Record Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            idGenerator()
            allClear()

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
    End Sub

    Private Sub dtpDateOfBirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateOfBirth.ValueChanged
        Dim age As Integer
        dtpDateOfBirth.CustomFormat = "dd/MM/yyyy"
        age = DateDiff("yyyy", dtpDateOfBirth.Value, Date.Today)
        Try
            If dtpDateOfBirth.Value >= Date.Today Then
                dtpDateOfBirth.CustomFormat = " "
                Throw New Exception
            ElseIf age < 18 Then
                dtpDateOfBirth.CustomFormat = " "
                txtAge.Clear()
                Throw New ArithmeticException
            Else
                txtAge.Text = age
            End If
        Catch ex As ArithmeticException
            MessageBox.Show("Invalid Age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            dtpDateOfBirth.CustomFormat = " "
            MessageBox.Show("Invalid Date Of Birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub cboConfirm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConfirm.SelectedIndexChanged
        If cboConfirm.SelectedIndex = 0 Then
            dtpDateOfConfirmation.Enabled = True
        Else
            dtpDateOfConfirmation.Enabled = False
            dtpDateOfConfirmation.Text = "  /  /"
        End If
    End Sub

    Private Sub cboMaritalStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMaritalStatus.SelectedIndexChanged
        If cboMaritalStatus.SelectedIndex = 0 Then
            txtSpouseName.Enabled = False
        Else
            txtSpouseName.Enabled = True
        End If
    End Sub

    Private Sub cboBankName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBankName.SelectedIndexChanged
        If cboBankName.SelectedIndex = 0 Then
            txtBranchName.Enabled = False
            txtACNo.Enabled = False
            txtIFSCCode.Enabled = False
        Else
            txtBranchName.Enabled = True
            txtACNo.Enabled = True
            txtIFSCCode.Enabled = True
        End If
    End Sub

    Private Sub txtEmailId_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmailId.LostFocus
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If txtEmailId.Text = "" Then
        ElseIf Not email.IsMatch(txtEmailId.Text) = True Then
            MessageBox.Show("Invalid EmailId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmailId.Clear()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim strCls As String = MessageBox.Show("Do You Want To Clear?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If strCls = DialogResult.OK Then
            allClear()
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        con.Open()
        Dim strcat As String
        Dim strDept As String
        dlgSearch.ShowDialog()
        Dim frmresult As New frmSearchResults
        frmresult.MdiParent = Me
        Try
            If dlgSearch.DialogResult = System.Windows.Forms.DialogResult.OK Then
                If dlgSearch.cboDept.SelectedIndex >= 0 And dlgSearch.cboCategory.SelectedIndex >= 0 Then
                    strDept = dlgSearch.cboDept.SelectedItem
                    strcat = dlgSearch.cboCategory.SelectedItem
                    Dim da As New SqlDataAdapter("select EmpId,Name,EmpCategoryCode,DepartmentCode,Designation from EmpDetails where EmpCategoryCode=@cat and DepartmentCode=@dept", con)
                    da.SelectCommand.Parameters.Add("@cat", SqlDbType.VarChar, 40).Value = strcat
                    da.SelectCommand.Parameters.Add("@dept", SqlDbType.VarChar, 40).Value = strDept
                    Dim ds As New DataSet
                    da.Fill(ds, "s")
                    frmSearchResults.dgvSearchResults.DataSource = ds.Tables(0)
                    frmSearchResults.Show()

                ElseIf dlgSearch.cboDept.SelectedIndex >= 0 Then
                    strDept = dlgSearch.cboDept.SelectedItem
                    Dim da As New SqlDataAdapter("select EmpId,Name,EmpCategoryCode,DepartmentCode,Designation from EmpDetails where DepartmentCode=@dept", con)
                    da.SelectCommand.Parameters.Add("@dept", SqlDbType.VarChar, 80).Value = strDept
                    Dim ds As New DataSet
                    da.Fill(ds, "s")
                    frmSearchResults.dgvSearchResults.DataSource = ds.Tables(0)
                    frmSearchResults.Show()

                ElseIf dlgSearch.cboCategory.SelectedIndex >= 0 Then
                    strcat = dlgSearch.cboCategory.SelectedItem
                    Dim da As New SqlDataAdapter("select EmpId,Name,EmpCategoryCode,DepartmentCode,Designation from EmpDetails where EmpCategoryCode=@cat", con)
                    da.SelectCommand.Parameters.Add("@cat", SqlDbType.VarChar, 40).Value = strcat
                    Dim ds As New DataSet
                    da.Fill(ds, "s")
                    frmSearchResults.dgvSearchResults.DataSource = ds.Tables(0)
                    frmSearchResults.Show()
                End If
                frmSearchResults.statusSearch.Items.Add("Total Number Of Employees: " & frmSearchResults.dgvSearchResults.RowCount)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Me.Close()
        con.Close()
    End Sub

    Private Sub dtpDateOfJoining_Check(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateOfJoining.LostFocus
        Try
            Convert.ToDateTime(dtpDateOfJoining.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpDateOfJoining.Clear()
        End Try
    End Sub

    Private Sub dtpDateOfConfirmation_Check(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateOfConfirmation.LostFocus
        Try
            If dtpDateOfConfirmation.Text = "  /  /" Then
            ElseIf Convert.ToDateTime(dtpDateOfConfirmation.Text) < Convert.ToDateTime(dtpDateOfJoining.Text) Then
                Throw New Exception
            Else
                Convert.ToDateTime(dtpDateOfConfirmation.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpDateOfConfirmation.Clear()
        End Try
    End Sub

    Private Sub dtpDateOfLeaving_Check(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateOfLeaving.LostFocus
        Try
            If dtpDateOfLeaving.Text = "  /  /" Then
            ElseIf Convert.ToDateTime(dtpDateOfLeaving.Text) < Convert.ToDateTime(dtpDateOfConfirmation.Text) Then
                Throw New Exception
            Else
                Convert.ToDateTime(dtpDateOfLeaving.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpDateOfLeaving.Clear()
        End Try
    End Sub

    Function total()
            Dim basic As Double = 0
            Dim hra As Double = 0
            Dim conveyance As Double = 0
            Dim cityConveyance As Double = 0
            Dim washingAll As Double = 0
            Dim others As Double = 0
            Dim totalSal As Double = 0

            If txtBasic.Text = "" Then
            Else
                basic = Convert.ToDouble(txtBasic.Text)
                totalSal = totalSal + basic
                txtTotalWage.Text = totalSal
            End If

            If txtHRA.Text = "" Then
            Else
                hra = Convert.ToDouble(txtHRA.Text)
                totalSal = totalSal + hra
                txtTotalWage.Text = totalSal
            End If

            If txtConveyance.Text = "" Then
            Else
                conveyance = Convert.ToDouble(txtConveyance.Text)
                totalSal = totalSal + conveyance
                txtTotalWage.Text = totalSal
            End If

            If txtCityConveyance.Text = "" Then
            Else
                cityConveyance = Convert.ToDouble(txtCityConveyance.Text)
                totalSal = totalSal + cityConveyance
                txtTotalWage.Text = totalSal
            End If

            If txtWAll.Text = "" Then
            Else
                washingAll = Convert.ToDouble(txtWAll.Text)
                totalSal = totalSal + washingAll
                txtTotalWage.Text = totalSal
            End If

            If txtOtherAllowance.Text = "" Then
            Else
                others = Convert.ToDouble(txtOtherAllowance.Text)
                totalSal = totalSal + others
                txtTotalWage.Text = totalSal
            End If

        Return Nothing
    End Function

    Private Sub txtSal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBasic.TextChanged, txtHRA.TextChanged, txtConveyance.TextChanged, txtCityConveyance.TextChanged, txtWAll.TextChanged, txtOtherAllowance.TextChanged
        Dim currentTextBox As TextBox = DirectCast(sender, TextBox)
        Try
            total()
        Catch ex As FormatException
            currentTextBox.Clear()
        End Try
    End Sub

    Private Sub txtSal_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBasic.LostFocus, txtHRA.LostFocus, txtConveyance.LostFocus, txtCityConveyance.LostFocus, txtWAll.LostFocus, txtOtherAllowance.LostFocus
        Dim currentTextBox As TextBox = DirectCast(sender, TextBox)
        If currentTextBox.Text = Nothing Then
            currentTextBox.Text = 0
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            btnAdd.Enabled = False
            btnPrint.Enabled = False
            btnClear.Enabled = False
            btnView.Enabled = False

            If btnUpdate.Text = "Update" Then
                cboDeptCode.Enabled = True
                txtDesign.Enabled = True
                dtpDateOfJoining.Enabled = True
                dtpDateOfLeaving.Enabled = True
                dtpDateOfConfirmation.Enabled = True
                cboBankName.Enabled = True
                txtBranchName.Enabled = True
                txtACNo.Enabled = True
                txtIFSCCode.Enabled = True
                txtPFNo.Enabled = True
                txtESICNo.Enabled = True
                txtEmpName.Enabled = True
                txtFatherName.Enabled = True
                txtMotherName.Enabled = True
                cboGender.Enabled = True
                dtpDateOfBirth.Enabled = True
                txtAge.Enabled = True
                cboBloodGrp.Enabled = True
                cboMaritalStatus.Enabled = True
                txtSpouseName.Enabled = True
                cboCategory.Enabled = True
                txtCaste.Enabled = True
                cboReligion.Enabled = True
                txtNationality.Enabled = True
                cboEduQualification.Enabled = True
                txtExperiences.Enabled = True
                txtAddr.Enabled = True
                txtContact.Enabled = True
                txtEmailId.Enabled = True
                txtPerAddr.Enabled = True
                txtPerPhone.Enabled = True
                cboConfirm.Enabled = True
                txtAadhar.Enabled = True
                txtPan.Enabled = True
                txtBasic.Enabled = True
                txtHRA.Enabled = True
                txtConveyance.Enabled = True
                txtCityConveyance.Enabled = True
                txtWAll.Enabled = True
                txtOtherAllowance.Enabled = True
                txtTotalWage.Enabled = True
                btnUpdate.Text = "Save"

            ElseIf btnUpdate.Text = "Save" Then
                con.Open()
                Dim cmd As New SqlCommand("update EmpDetails set DepartmentCode=@dc,Designation=@desg,JoiningDate=@jd,Confirmation=@cfm,LeavingDate=@ld,ConfirmationDate=@cfmd,BankName=@bn,BranchName=@brn,AccountNo=@acn,IFSCCode=@ifsc,Aadhar=@adh,PFNo=@pf,Pan=@pan,ESICNo=@esic,Name=@nme,FathersName=@fnme,MothersName=@mnme,Gender=@gen,DOB=@dob,BloodGroup=@bg,MaritalStatus=@ms,SpouseName=@sn,Category=@ct,Caste=@cst,Religion=@rel,Nationality=@nat,EduQualification=@eq,Experiences=@ex,Address=@addr,ContactNo=@cnt,Email=@email,PermanentAddress=@paddr,PermanentContact=@pcnt where EmpId=@id", con)
                cmd.Parameters.AddWithValue("@dc", cboDeptCode.Text)
                cmd.Parameters.AddWithValue("@Desg", txtDesign.Text)
                cmd.Parameters.AddWithValue("@jd", Convert.ToDateTime(dtpDateOfJoining.Text))
                cmd.Parameters.AddWithValue("@cfm", cboConfirm.Text)

                If dtpDateOfLeaving.Text = "  /  /" Then
                    cmd.Parameters.AddWithValue("@ld", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@ld", Convert.ToDateTime(dtpDateOfLeaving.Text))
                End If

                If dtpDateOfConfirmation.Text = "  /  /" Then
                    cmd.Parameters.AddWithValue("@cfmd", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@cfmd", Convert.ToDateTime(dtpDateOfConfirmation.Text))
                End If
                cmd.Parameters.AddWithValue("@bn", cboBankName.Text)
                cmd.Parameters.AddWithValue("@brn", txtBranchName.Text)
                cmd.Parameters.AddWithValue("@acn", txtACNo.Text)
                cmd.Parameters.AddWithValue("@ifsc", txtIFSCCode.Text)
                cmd.Parameters.AddWithValue("@adh", txtAadhar.Text)
                cmd.Parameters.AddWithValue("@pf", txtPFNo.Text)
                cmd.Parameters.AddWithValue("@pan", txtPan.Text)
                cmd.Parameters.AddWithValue("@esic", txtESICNo.Text)
                cmd.Parameters.AddWithValue("@nme", txtEmpName.Text)
                cmd.Parameters.AddWithValue("@fnme", txtFatherName.Text)
                cmd.Parameters.AddWithValue("@mnme", txtMotherName.Text)
                cmd.Parameters.AddWithValue("@gen", cboGender.Text)
                cmd.Parameters.AddWithValue("@dob", dtpDateOfBirth.Value)
                cmd.Parameters.AddWithValue("@bg", cboBloodGrp.Text)
                cmd.Parameters.AddWithValue("@ms", cboMaritalStatus.Text)
                cmd.Parameters.AddWithValue("@sn", txtSpouseName.Text)
                cmd.Parameters.AddWithValue("@ct", cboCategory.Text)
                cmd.Parameters.AddWithValue("@cst", txtCaste.Text)
                cmd.Parameters.AddWithValue("@rel", cboReligion.Text)
                cmd.Parameters.AddWithValue("@nat", txtNationality.Text)
                cmd.Parameters.AddWithValue("@eq", cboEduQualification.Text)
                cmd.Parameters.AddWithValue("@ex", txtExperiences.Text)
                cmd.Parameters.AddWithValue("@addr", txtAddr.Text)
                cmd.Parameters.AddWithValue("@cnt", txtContact.Text)
                cmd.Parameters.AddWithValue("@email", txtEmailId.Text)
                cmd.Parameters.AddWithValue("@paddr", txtPerAddr.Text)
                cmd.Parameters.AddWithValue("@pcnt", txtPerPhone.Text)
                cmd.Parameters.AddWithValue("@id", frmSearchResults.id1)

                Dim cmd3 As New SqlCommand("update EmpSalary set Basic=@bs,HRA=@hra,Conveyance=@convy,CityConveyance=@cityconvy,WAllowance=@wall,OtherAllowance=@oall where EmpId=@id", con)
                cmd3.Parameters.AddWithValue("@bs", txtBasic.Text)
                cmd3.Parameters.AddWithValue("@hra", txtHRA.Text)
                cmd3.Parameters.AddWithValue("@convy", txtConveyance.Text)
                cmd3.Parameters.AddWithValue("@cityconvy", txtCityConveyance.Text)
                cmd3.Parameters.AddWithValue("@wall", txtWAll.Text)
                cmd3.Parameters.AddWithValue("@oall", txtOtherAllowance.Text)
                cmd3.Parameters.AddWithValue("@id", frmSearchResults.id1)

                Dim msg As String = MessageBox.Show("Do you want to save..???", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msg = DialogResult.Yes Then
                    cmd.ExecuteNonQuery()
                    cmd3.ExecuteNonQuery()
                    MessageBox.Show("Record Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnAdd.Enabled = True
                    btnPrint.Enabled = True
                    btnView.Enabled = True
                    btnClear.Enabled = True
                    btnUpdate.Text = "Update"
                    btnUpdate.Enabled = False
                    btnPrint.Enabled = False
                    allClear()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
    End Sub
End Class