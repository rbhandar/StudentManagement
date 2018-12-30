Imports System.Data.SqlClient
Public Class Course1123EarlyFDashboard
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Course1123EarlyF.Show()
    End Sub


    Public Sub CourseStudent1123Bottom30PercentCount()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT COUNT(Student_ID) AS count, '0-100' as type FROM [FINAL_1123_COURSE] Where Point_Total <= '100'UNION ALL SELECT COUNT(Student_ID) AS count, '100-200' as type FROM [FINAL_1123_COURSE] Where Point_Total > '100' and Point_Total <= '200'UNION ALL SELECT COUNT(Student_ID) AS count, '200-300' as type FROM [FINAL_1123_COURSE] Where Point_Total > '200' and  Point_Total <='300'UNION ALL SELECT COUNT(Student_ID) AS count, '300-400' as type FROM [FINAL_1123_COURSE] Where Point_Total > '300' and  Point_Total <='400'UNION ALL SELECT COUNT(Student_ID) AS count, '400-471' as type FROM [FINAL_1123_COURSE] Where Point_Total > '400' and  Point_Total <='471';", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            Chart1.DataSource = table
            Chart1.Series("Early Grade F").YValueMembers = "count"
            Chart1.Series("Early Grade F").XValueMember = "type"

        End If
    End Sub

    Private Sub Course1123EarlyFDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CourseStudent1123Bottom30PercentCount()
    End Sub
End Class