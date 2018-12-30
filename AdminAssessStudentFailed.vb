
Imports System.Data.SqlClient
Public Class AdminAssessStudentFailed
    Public Sub AdminAssessStudentFailed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminAssessmentStudentFailed()
    End Sub

    Public Sub AdminAssessmentStudentFailed()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("Select * from [FINAL_Course_Asessment_TestRB] Where Score_Excel_Percent < 80 and Score_PowerPoint_Percent <80 and Score_Word_Percent <80;", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            'lnklblTotalPassedStudents.Text = table.Rows(0).Item(0)
            dgvAdminAssessmentStudentFailed.DataSource = table

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        AdminAssessmentTestForm.Show()
    End Sub
End Class
