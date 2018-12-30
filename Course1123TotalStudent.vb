Imports System.Data.SqlClient
Public Class Course1123TotalStudent
    Private Sub Course1123TotalStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Course1123TtStudent()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Admin1123ProgressForm.Show()
    End Sub

    Public Sub Course1123TtStudent()
    Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
    Dim command As New SqlCommand("Select * from [FINAL_1123_COURSE];", connection)

    'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

    Dim adapter As New SqlDataAdapter(command)
    Dim table As New DataTable()
    adapter.Fill(table)
    If table.Rows.Count() <= 0 Then
        MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

    Else
        'lnklblTotalPassedStudents.Text = table.Rows(0).Item(0)
        dgv1123TotalStudent.DataSource = table

    End If
End Sub

End Class