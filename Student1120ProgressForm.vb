Imports System.Data.SqlClient
Public Class Student1120ProgressForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Student1120ProgressScore()
        Student1120ProgressScoreTotal()
    End Sub

    Public Sub Student1120ProgressScore()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT * FROM [PROJECTF1809].[dbo].[FINAL_1120_COURSE] Where Student_ID = @Student_ID", connection)

        command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        'Me.ListView1.View = View.Details
        ' Me.ListView1.GridLines = True
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. You are not enrolled in this Course", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lblStudentId.Text = table.Rows(0).Item(0)
            lblLastAccess.Text = table.Rows(0).Item(1)
            lblCourseId.Text = table.Rows(0).Item(3)
            lblMSWordScoreValue.Text = table.Rows(0).Item(4)
            lblMSExcelScoreValue.Text = table.Rows(0).Item(5)
            lblMSPowerPointScoreValue.Text = table.Rows(0).Item(6)
            lblWindowExcelExam1.Text = table.Rows(0).Item(7)
            lblWordPowerPointExam2.Text = table.Rows(0).Item(8)

            Label2.Hide()
            Label10.Hide()
            '    Dim itemcoll(100) As String
            '    Dim i As Integer = 0
            '    Dim j As Integer = 0
            '    ' adding the columns in ListView
            '    For i = 0 To table.Columns.Count - 1
            '        Me.ListView1.Columns.Add(table.Columns(i).ToString())
            '    Next
            '    'Now adding the Items in Listview
            '    For i = 0 To table.Rows.Count - 1
            '        For j = 0 To table.Columns.Count - 1
            '            itemcoll(j) = table.Rows(i)(j).ToString()
            '        Next
            '        Dim lvi As New ListViewItem(itemcoll)
            '        Me.ListView1.Items.Add(lvi)
            '    Next
        End If
    End Sub

    Public Sub Student1120ProgressScoreTotal()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT Microsoft_Word_Capstone_Project, Microsoft_PowerPoint_Capstone_Project, Microsoft_Excel_Capstone_Project, Exam_1_Windows_and_Excel, Exam_2_Word_and_Ppt  From  [PROJECTF1809].[dbo].[FINAL_1120_COURSE] Where Student_ID = @Student_ID", connection)

        command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        ' Me.ListView1.View = View.Details
        ' Me.ListView1.GridLines = True
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. You are not enrolled in this Course", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            Dim msWordProject As Integer = table.Rows(0).Item(0)
            Dim msPPProject As Integer = table.Rows(0).Item(1)
            Dim msExcelProject As Integer = table.Rows(0).Item(2)
            Dim msExam1 As Integer = table.Rows(0).Item(3)
            Dim msExam2 As Integer = table.Rows(0).Item(4)


            lblTotalScore.Text = msWordProject + msPPProject + msExcelProject + msExam1 + msExam2

        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Hide()
        StudentTestScoreHomeForm.Show()
    End Sub


End Class