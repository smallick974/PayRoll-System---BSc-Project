Public Class frmSalaryDetails

    Private Sub frmSalaryDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim thisDate As Date
        Dim thisYear As Integer
        Dim thismonth As String
        thisDate = DateTime.Today
        thismonth = MonthName(Month(thisDate), False)
        thisYear = Year(thisDate)
        'lblMonthYear.Text = thismonth & "-" & thisYear
        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class