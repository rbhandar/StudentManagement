Imports System.Data.SqlClient
Public Class Student1123ProgressForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Student1123ProgressScore()
    End Sub

    Public Sub Student1123ProgressScore()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT * FROM [PROJECTF1809].[dbo].[FINAL_1123_COURSE] Where Student_ID = @Student_ID", connection)

        command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. You are not enrolled on this Course", MsgBoxStyle.Critical, "Student Search Failed")

        Else

            Dim itemcoll(100) As String
            Dim i As Integer = 0
            Dim j As Integer = 0
            ' adding the columns in ListView
            For i = 0 To table.Columns.Count - 1
                Me.ListView1.Columns.Add(table.Columns(i).ToString())
            Next
            'Now adding the Items in Listview
            For i = 0 To table.Rows.Count - 1
                For j = 0 To table.Columns.Count - 1
                    itemcoll(j) = table.Rows(i)(j).ToString()
                Next
                Dim lvi As New ListViewItem(itemcoll)
                Me.ListView1.Items.Add(lvi)
            Next
        End If
    End Sub

    Private Sub Student1123ProgressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Hide()
        StudentTestScoreHomeForm.Show()
    End Sub
End Class