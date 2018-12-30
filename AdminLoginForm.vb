Imports System.Data.SqlClient
Imports WCOB_CCSM_and_DS_System.StudentTestScoreHomeForm
Public Class AdminLoginForm
    Protected Db As db = New db
    Public getFirstname As String
    Public getUserID As String
    Public thisAdminType As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        loginAdmin()
    End Sub

    Public Sub loginAdmin()
        Try

            Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User ID=PROJECTF1809;Password=KP32epv$;")
            Dim command As New SqlCommand("SELECT * FROM FINAL_Admin_login WHERE Email = @Email and Password = @Password;", connection)

            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtbUserID.Text
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtbPassword.Text

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then
                MsgBox("User ID or Password Incorect!", MsgBoxStyle.Critical, "Login Failed")
            Else
                getFirstname = table.Rows(0).Item(2).ToString()
                getUserID = table.Rows(0).Item(2)
                thisAdminType = table.Rows(0).Item(2)
                MsgBox("Login successful!", MsgBoxStyle.Information, "Congratulations, " & "" & getFirstname)
                'AdminHomeForm.lblStudentID.Text = "Student ID " & getFirstname
                Me.Hide()
                AdminHomeForm.Show()

            End If


        Catch ex As Exception
            MsgBox("User ID or Password Incorect!", MsgBoxStyle.Critical, "Login Failed")
        End Try
    End Sub

    Private Sub AdminLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class