Imports System.Data.SqlClient

Public Class frmLogin
    Dim con As New SqlConnection("Data Source=ADMIN-PC; Initial Catalog=PayRollSystem; Integrated Security=True")

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim MyException As New Exception
        Dim adminlogin, adminpass As String

        Try
            adminlogin = UsernameTextBox.Text
            adminpass = PasswordTextBox.Text

            If adminlogin = String.Empty Or adminpass = String.Empty Then
                Throw New NullReferenceException
            Else
                Try
                    con.Open()
                    Dim cmd As New SqlCommand("select AdminLogin,AdminPass from Login where AdminLogin = @al and AdminPass = @ap", con)
                    cmd.Parameters.AddWithValue("@al", adminlogin)
                    cmd.Parameters.AddWithValue("@ap", adminpass)

                    Dim reader As SqlDataReader
                    reader = cmd.ExecuteReader

                    Try
                        If reader.HasRows = True Then
                            Dim main As New frmMain
                            main.Visible = True
                            Me.Close()
                        Else
                            Throw MyException
                        End If
                    Catch MyException
                        MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        UsernameTextBox.Clear()
                        PasswordTextBox.Clear()
                    End Try
                    con.Close()
                Catch ex As SqlException
                    MessageBox.Show("Cannot connect to the database", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Catch ex As NullReferenceException
            MessageBox.Show("Empty Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
