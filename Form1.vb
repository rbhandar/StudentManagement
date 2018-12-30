Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub lnklblStudentLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblStudentLogin.LinkClicked
        StudentLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub lnklblAdminLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblAdminLogin.LinkClicked
        AdminLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub lnklblGALogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblGALogin.LinkClicked
        AdminLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
