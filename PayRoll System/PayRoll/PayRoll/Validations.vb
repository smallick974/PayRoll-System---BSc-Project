Imports System.Text.RegularExpressions

Public Class Validations
    Public Shared Function checkNames(ByVal sender As Object, ByVal temp As String)
        Dim activeTextBox As TextBox = CType(sender, TextBox)
        Try
            If activeTextBox.Text = "" Then
            ElseIf Not Regex.Match(activeTextBox.Text, "^[a-zA-Z ]*$").Success Then
                Throw New Exception
            End If
        Catch ex As Exception
            activeTextBox.Clear()
            MessageBox.Show("Invalid " & temp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Nothing
    End Function

    Public Shared Function properCase(ByVal sender As Object, ByVal e As EventArgs)
        Dim currentTextBox As TextBox = DirectCast(sender, TextBox)
        currentTextBox.Text = StrConv(currentTextBox.Text, VbStrConv.ProperCase)
        Return Nothing
    End Function
End Class
