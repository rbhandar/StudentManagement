Imports System.Data.SqlClient
Public Class AdminAssessmentTestForm
    Private Sub AdminAssessmentTestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminAssessmentTestScoreTotalCount()
        AdminAssessmentTestScorePassedStudents()
        AdminAssessmentTestScoreFailedStudents()
        AdminAssessmentTestScorePassAndFailedStudents()
    End Sub


    Public Sub AdminAssessmentTestScoreTotalCount()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT Count(Student_ID) as Passed FROM [PROJECTF1809].[dbo].[FINAL_Course_Asessment_TestRB] ", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else

            lnklblTotalStudents.Text = table.Rows(0).Item(0)

            'Chart1.Series("Series1").Points.AddY(table.Rows(0).Item(0))
            'Chart1.DataSource = table
            'Chart1.Series("Series1").YValueMembers = "Passed"
            'Chart1.Series("Series1").YValueMembers = "1"

        End If
    End Sub

    Public Sub AdminAssessmentTestScorePassedStudents()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("Select Count(Student_ID) from [FINAL_Course_Asessment_TestRB] Where Score_Excel_Percent >= 80 and Score_PowerPoint_Percent >=80 and Score_Word_Percent >=80;", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lnklblTotalPassedStudents.Text = table.Rows(0).Item(0)

        End If
    End Sub

    Public Sub AdminAssessmentTestScoreFailedStudents()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("Select Count(Student_ID) from [FINAL_Course_Asessment_TestRB] Where Score_Excel_Percent <80 and Score_PowerPoint_Percent <80 and Score_Word_Percent <80;", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lnklblTotalFailedStudents.Text = table.Rows(0).Item(0)

        End If
    End Sub

    Public Sub AdminAssessmentTestScorePassAndFailedStudents()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT COUNT(Student_ID) AS count, 'Passed' as type From [FINAL_Course_Asessment_TestRB] Where Score_Excel_Percent >= 80 and Score_PowerPoint_Percent >=80 and Score_Word_Percent >=80 UNION ALL SELECT COUNT(Student_ID) AS count, 'Failed' FROM [FINAL_Course_Asessment_TestRB] Where Score_Excel_Percent < 80 and Score_PowerPoint_Percent <80 and Score_Word_Percent <80;", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            'lnklblTotalFailedStudents.Text = table.Rows(0).Item(0)
            'Chart1.Series("Series1").Points.AddY(table.Rows(0).Item(0))
            Chart1.DataSource = table
            Chart1.Series("Series1").YValueMembers = "count"
            Chart1.Series("Series1").XValueMember = "type"



        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblTotalStudents.LinkClicked
        Me.Hide()
        AdminAssessStudentTotal.Show()
    End Sub

    Private Sub lnklblTotalPassedStudents_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblTotalPassedStudents.LinkClicked
        Me.Hide()
        AdminAssessStudentPassed.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        AdminHomeForm.Show()
    End Sub

    Private Sub lnklblTotalFailedStudents_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblTotalFailedStudents.LinkClicked
        Me.Hide()
        AdminAssessStudentFailed.Show()
    End Sub
End Class