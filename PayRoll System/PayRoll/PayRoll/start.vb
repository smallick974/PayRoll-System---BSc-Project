Public Class start
    Dim tooltip As New ToolTip

    Private Sub btnAdmin_onMousehover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.MouseHover
        tooltip.UseAnimation = True
        tooltip.SetToolTip(btnAdmin, "Admin")
    End Sub

    Private Sub btnUser_onMousehover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.MouseHover
        tooltip.UseAnimation = True
        tooltip.SetToolTip(btnUser, "User")
    End Sub

    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        Dim frmadmin As New frmLogin
        frmadmin.Visible = True
    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        Dim frmuser As New frmLogin
        frmuser.Visible = True
    End Sub
End Class