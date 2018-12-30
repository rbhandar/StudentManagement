Imports System.Data.SqlClient
Public Class Course1120Bottom30PercentDashboard
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Course1120Bottom30PercentForm.Show()
    End Sub

    Private Sub Course1120Bottom30PercentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CourseStudent1120Bottom30PercentCount()
    End Sub
    Public Sub CourseStudent1120Bottom30PercentCount()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT COUNT(Student_ID) AS count, '0-100' as type FROM [FINAL_1120_COURSE] Where Total <= '100'UNION ALL SELECT COUNT(Student_ID) AS count, '100-200' as type FROM [FINAL_1120_COURSE] Where Total > '100' and Total <= '200'UNION ALL SELECT COUNT(Student_ID) AS count, '200-300' as type FROM [FINAL_1120_COURSE] Where Total > '200' and  Total <='300'UNION ALL SELECT COUNT(Student_ID) AS count, '200-300' as type FROM [FINAL_1120_COURSE] Where Total > '200' and  Total <='300'UNION ALL SELECT COUNT(Student_ID) AS count, '300-400' as type FROM [FINAL_1120_COURSE] Where Total > '300' and  Total <='400' UNION ALL SELECT COUNT(Student_ID) AS count, '400-438' as type FROM [FINAL_1120_COURSE] Where Total > '400' and  Total <='438';", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            Chart1.DataSource = table
            Chart1.Series("Bottom 30%").YValueMembers = "count"
            Chart1.Series("Bottom 30%").XValueMember = "type"

        End If
    End Sub

End Class