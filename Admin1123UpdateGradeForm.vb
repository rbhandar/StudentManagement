Imports System.Data.SqlClient
Public Class Admin1123UpdateGradeForm
    Protected Db As db = New db
    Private Sub btnShowGrade_Click(sender As Object, e As EventArgs) Handles btnShowGrade.Click
        ShowCurrentGrade()
    End Sub

    Public Sub ShowCurrentGrade()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT Early_Progress_Letter_Grades FROM [PROJECTF1809].[dbo].[FINAL_1123_COURSE] Where Student_ID = @Student_ID;", connection)

        command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = txt1123StudentID.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lblCurrentGrade.Text = table.Rows(0).Item(0)

        End If
    End Sub

    Private Sub btnUpdateGrade_Click(sender As Object, e As EventArgs) Handles btnUpdateGrade.Click
        UpdateCurrentGrade()
    End Sub

    Public Sub UpdateCurrentGrade()
        If txt1123StudentID.Text = "" Then
            MsgBox("Please enter student ID first", MsgBoxStyle.Critical, "Invalid data")
        Else
            Try
                Db.sql = "UPDATE FINAL_1123_COURSE SET Early_Progress_Letter_Grades = @Early_Progress_Letter_Grades WHERE Student_ID = @Student_ID;"
                Db.bind("@Early_Progress_Letter_Grades", cmbbGrade.Text)
                Db.bind("@Student_ID", txt1123StudentID.Text)
                Db.execute()
                'Me.Dispose()

                MsgBox("Grade Update succeeded", MsgBoxStyle.Information, "Congratulations")

            Catch ex As Exception
                MsgBox("Please make sure you enter valid Student ID", MsgBoxStyle.Critical, "Failed")
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Admin1123ProgressForm.Show()
    End Sub
End Class