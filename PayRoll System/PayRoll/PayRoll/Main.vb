Public Class frmMain

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployee.Click
        frmEmployeeMaster.Show()
    End Sub

    Private Sub btnAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAttendance.Click
        frmAttendance.Show()
    End Sub

    Private Sub btnLeave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeave.Click
        frmLeave.Show()
    End Sub

    Private Sub btnAdvance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvance.Click
        frmAdvance.Show()
    End Sub

    Private Sub btnLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoan.Click
        frmLoan.Show()
    End Sub

    Private Sub btnSalary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalary.Click
        frmSalaryDetails.Show()
    End Sub
End Class