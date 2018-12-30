Imports System.Data.SqlClient
Public Class Admin1123ProgressForm
    Private Sub Admin1123ProgressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminTotalStudent1123()
        AdminTotalStudent1123GradeF()
        AdminTotalStudent1123ScoreLessThan60Percent()
        AdminTotalStudent1123EarlyGradeNumber()
    End Sub

    Public Sub AdminTotalStudent1123()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("Select Count(Student_ID) as Total_Students_1123 from [FINAL_1123_COURSE];", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lnklblTotalStudents.Text = table.Rows(0).Item(0)

        End If
    End Sub


    Public Sub AdminTotalStudent1123GradeF()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("Select Count (Student_ID) as Student_Grade_F_1123 from [FINAL_1123_COURSE] Where Early_Progress_Letter_Grades = 'F';", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lnklblTotalStudentsWithGradeF.Text = table.Rows(0).Item(0)


        End If
    End Sub

    Public Sub AdminTotalStudent1123ScoreLessThan60Percent()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("Select Count (Student_ID) as Student_Score_60Less from [FINAL_1123_COURSE] Where Percent_grade <= 0.60;", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lnklblTotalStudentsWithLessTh60Percent.Text = table.Rows(0).Item(0)


        End If
    End Sub

    Public Sub AdminTotalStudent1123EarlyGradeNumber()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT COUNT(Student_ID) AS count, 'A' as type From [FINAL_1123_COURSE] Where Early_Progress_Letter_Grades = 'F' UNION ALL SELECT COUNT(Student_ID) AS count, 'B' FROM [FINAL_1123_COURSE] Where Early_Progress_Letter_Grades = 'B' UNION ALL SELECT COUNT(Student_ID) AS count, 'C' FROM [FINAL_1123_COURSE] Where Early_Progress_Letter_Grades = 'C' UNION ALL SELECT COUNT(Student_ID) AS count, 'D' FROM [FINAL_1123_COURSE] Where Early_Progress_Letter_Grades = 'D' UNION ALL SELECT COUNT(Student_ID) AS count, 'F' FROM [FINAL_1123_COURSE] Where Early_Progress_Letter_Grades = 'F';", connection)

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
            Chart1.Series("Grade").YValueMembers = "count"
            Chart1.Series("Grade").XValueMember = "type"


        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        AdminHomeForm.Show()
    End Sub

    Private Sub lnklblTotalStudents_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblTotalStudents.LinkClicked
        Me.Hide()
        Course1123TotalStudent.Show()
    End Sub

    Private Sub lnklblTotalStudentsWithGradeF_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblTotalStudentsWithGradeF.LinkClicked
        Me.Hide()
        Course1123EarlyF.Show()
    End Sub

    Private Sub lnklblTotalStudentsWithLessTh60Percent_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblTotalStudentsWithLessTh60Percent.LinkClicked
        Me.Hide()
        Course1123ScoreLess.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Admin1123Bottom30PercentForm.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        Admin1123ExamsDiffBy30OrMoreForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Admin1123UpdateGradeForm.Show()
    End Sub
End Class