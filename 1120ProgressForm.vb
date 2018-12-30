Imports System.Data.SqlClient
Public Class Admin1120ProgressForm
    Private Sub Admin1120ProgressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminTotalStudent1120()
        AdminStudent1120Score60OrOverEachSubjectCount()
        AdminStudent1120ScoreLessThan60EachSubjectCount()
        AdminStudent1120ScoreOver60AllSubject()
        AdminStudent1120ScoreLessThan60AllSubject()
        AdminStudents1120UnstablePerformancesNumber()
    End Sub


    Public Sub AdminTotalStudent1120()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("Select Count(Student_ID) as Total_Students_1120 from [FINAL_1120_COURSE];", connection)

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


    Public Sub AdminStudent1120Score60OrOverEachSubjectCount()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT COUNT(Student_ID) AS count, 'Stu_Over60_Word' as type From [FINAL_1120_COURSE] Where Microsoft_Word_Capstone_Project >=60 UNION ALL SELECT COUNT(Student_ID) AS count, 'Stu_Over60_PowerPoint' as type From [FINAL_1120_COURSE] Where Microsoft_PowerPoint_Capstone_Project >=60 UNION ALL SELECT COUNT(Student_ID) AS count, 'Stu_Over60_Excel' as type From [FINAL_1120_COURSE] Where Microsoft_Excel_Capstone_Project >=60 UNION ALL SELECT COUNT(Student_ID) AS count, 'Stu_Over60_Exam1' as type From [FINAL_1120_COURSE] Where Exam_1_Windows_and_Excel >=60  UNION ALL SELECT COUNT(Student_ID) AS count, 'Stu_Over60_Exam2' as type From [FINAL_1120_COURSE] Where Exam_2_Word_and_Ppt >=60;", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lblWordO60.Text = table.Rows(0).Item(0)
            lblPPointO60.Text = table.Rows(1).Item(0)
            lblExcelO60.Text = table.Rows(2).Item(0)
            lblExam1O60.Text = table.Rows(3).Item(0)
            lblExam2O60.Text = table.Rows(4).Item(0)

        End If
    End Sub



    Public Sub AdminStudent1120ScoreLessThan60EachSubjectCount()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT COUNT(Student_ID) AS count, 'Stu_Under60_Word' as type From [FINAL_1120_COURSE] Where Microsoft_Word_Capstone_Project <60 UNION ALL SELECT COUNT(Student_ID) AS count, 'Stu_Under60_PowerPoint' as type From [FINAL_1120_COURSE] Where Microsoft_PowerPoint_Capstone_Project <60 UNION ALL SELECT COUNT(Student_ID) AS count, 'Stu_Under60_Excel' as type From [FINAL_1120_COURSE] Where Microsoft_Excel_Capstone_Project <60 UNION ALL SELECT COUNT(Student_ID) AS count, 'Stu_Under60_Exam1' as type From [FINAL_1120_COURSE] Where Exam_1_Windows_and_Excel <60  UNION ALL SELECT COUNT(Student_ID) AS count, 'Stu_Under60_Exam2' as type From [FINAL_1120_COURSE] Where Exam_2_Word_and_Ppt <60;", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lnklblStuScoreMSWordLessThan60.Text = table.Rows(0).Item(0)
            lnklblStuScoreMSPPLessThan60.Text = table.Rows(1).Item(0)
            lnklblStuScoreMSExcelLessThan60.Text = table.Rows(2).Item(0)
            lnklblStuScoreExam1LessThan60.Text = table.Rows(3).Item(0)
            lnklblStuScoreExam2LessThan60.Text = table.Rows(4).Item(0)

            Chart1.DataSource = table
            Chart1.Series("Under 60").YValueMembers = "count"
            Chart1.Series("Under 60").XValueMember = "type"

        End If
    End Sub







    Public Sub AdminStudent1120ScoreOver60AllSubject()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("Select Count(Student_ID) from [FINAL_1120_COURSE] where Microsoft_Word_Capstone_Project >=60 and Microsoft_PowerPoint_Capstone_Project >=60 and Microsoft_Excel_Capstone_Project >=60 and Exam_1_Windows_and_Excel >=60 and Exam_2_Word_and_Ppt >=60;", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lblAllO60.Text = table.Rows(0).Item(0)

        End If
    End Sub


    Public Sub AdminStudent1120ScoreLessThan60AllSubject()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("Select Count(Student_ID) from [FINAL_1120_COURSE] where Microsoft_Word_Capstone_Project <60 and Microsoft_PowerPoint_Capstone_Project <60 and Microsoft_Excel_Capstone_Project <60 and Exam_1_Windows_and_Excel <60 and Exam_2_Word_and_Ppt <60;", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lnklblStuScoreLessThan60AllSubject.Text = table.Rows(0).Item(0)

        End If
    End Sub

    Public Sub AdminStudents1120UnstablePerformancesNumber()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT Count(Student_ID) FROM FINAL_1120_COURSE where Microsoft_Word_Capstone_Project - Microsoft_PowerPoint_Capstone_Project >= '20' or Microsoft_PowerPoint_Capstone_Project - Microsoft_Word_Capstone_Project >= '20'or Microsoft_Word_Capstone_Project - Microsoft_PowerPoint_Capstone_Project >='20' or Microsoft_PowerPoint_Capstone_Project - Microsoft_Excel_Capstone_Project >='20'or Microsoft_Excel_Capstone_Project - Microsoft_PowerPoint_Capstone_Project >= '20' or Microsoft_Excel_Capstone_Project - Microsoft_Word_Capstone_Project >='20' or Microsoft_Word_Capstone_Project - Microsoft_Excel_Capstone_Project >='20';", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lnklblUnstableStuPerformance1120.Text = table.Rows(0).Item(0)


        End If
    End Sub

    Public Sub AdminStudents1120Bottom30()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT TOP 30 PERCENT * FROM FINAL_1120_COURSE order by Total Asc;", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lnklblBottom30Students.Text = table.Rows(0).Item(0)


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        AdminHomeForm.Show()
    End Sub

    Private Sub lnklblBottom30Students_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblBottom30Students.LinkClicked
        Me.Hide()
        Course1120Bottom30PercentForm.Show()
    End Sub

    Private Sub lnklblStuScoreMSWordLessThan60_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblStuScoreMSWordLessThan60.LinkClicked
        Me.Hide()
        Admin1120WordLess60.Show()
    End Sub

    Private Sub lnklblStuScoreMSPPLessThan60_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblStuScoreMSPPLessThan60.LinkClicked
        Me.Hide()
        Admin1120PPointLess60.Show()
    End Sub

    Private Sub lnklblStuScoreMSExcelLessThan60_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblStuScoreMSExcelLessThan60.LinkClicked
        Me.Hide()
        Admin1120ExcelLess60.Show()
    End Sub

    Private Sub lnklblStuScoreExam1LessThan60_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblStuScoreExam1LessThan60.LinkClicked
        Me.Hide()
        Admin1120Exam1Less60.Show()
    End Sub

    Private Sub lnklblStuScoreExam2LessThan60_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblStuScoreExam2LessThan60.LinkClicked
        Me.Hide()
        Admin1120Exam2Less60.Show()
    End Sub

    Private Sub lnklblStuScoreLessThan60AllSubject_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblStuScoreLessThan60AllSubject.LinkClicked
        Me.Hide()
        Amin1120ScoreLess60All.Show()
    End Sub

    Private Sub lnklblUnstableStuPerformance1120_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblUnstableStuPerformance1120.LinkClicked
        Me.Hide()
        Admin1120UnstablePerf.Show()
    End Sub

    Private Sub lnklblTotalStudents_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblTotalStudents.LinkClicked
        Me.Hide()
        Admin1120TotalStudents.Show()
    End Sub


End Class