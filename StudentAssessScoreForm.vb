Imports System.Data.SqlClient
Public Class StudentAssessScoreForm
    Private Sub StudentAssessScoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudentAssessmentTestScore()
    End Sub

    Public Sub StudentAssessmentTestScore()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT * FROM [PROJECTF1809].[dbo].[FINAL_Course_Asessment_TestRB] Where Student_ID = @Student_ID", connection)

        command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lblStudentIDValue.Text = table.Rows(0).Item(0)
            lblTermValue.Text = table.Rows(0).Item(2)
            lblYearValue.Text = table.Rows(0).Item(3)

            lblDateTakenValue.Text = table.Rows(0).Item(4).Substring(0, 10)

            'lblDateTakenValue.Text = table.Rows(0).Item(4)


            lblScoreWord.Text = table.Rows(0).Item(5)
            lblNoCorrectOutOfWord.Text = table.Rows(0).Item(6)
            lblScorePowerPoint.Text = table.Rows(0).Item(11)
            lblNoCorrectOutOfPP.Text = table.Rows(0).Item(12)
            lblScoreExcel.Text = table.Rows(0).Item(8)
            lblNoCorrectOutOfExcel.Text = table.Rows(0).Item(9)

        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        StudentTestScoreHomeForm.Show()
    End Sub
End Class