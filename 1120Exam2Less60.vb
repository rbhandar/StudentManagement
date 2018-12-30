
Imports System.Data.SqlClient
Public Class Admin1120Exam2Less60
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Admin1120ProgressForm.Show()
    End Sub


    Private Sub Admin1120ExcelLess60_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Admin1120E2Less60()
    End Sub

    Public Sub Admin1120E2Less60()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("select * from FINAL_1120_COURSE where Exam_2_Word_and_Ppt <'60';", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            dgvExam2Less60.DataSource = table

        End If
    End Sub
End Class