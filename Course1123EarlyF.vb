
Imports System.Data.SqlClient
Public Class Course1123EarlyF
    Private Sub Course1123TotaCourse1123EarlyF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Course1123EarlygradeF()
    End Sub

    Public Sub Course1123EarlygradeF()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("Select * from [FINAL_1123_COURSE] Where Early_Progress_Letter_Grades = 'F' ;", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            'lnklblTotalPassedStudents.Text = table.Rows(0).Item(0)
            dgvCourse1123EarlyF.DataSource = table

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Admin1123ProgressForm.Show()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        DATAGRIDVIEW_TO_EXCEL((dgvCourse1123EarlyF)) ' THIS PARAMETER IS YOUR DATAGRIDVIEW
    End Sub




    Private Sub DATAGRIDVIEW_TO_EXCEL(ByVal DGV As DataGridView)
        Try
            Dim DTB = New DataTable, RWS As Integer, CLS As Integer

            For CLS = 0 To DGV.ColumnCount - 1 ' COLUMNS OF DTB
                DTB.Columns.Add(DGV.Columns(CLS).Name.ToString)
            Next

            Dim DRW As DataRow

            For RWS = 0 To DGV.Rows.Count - 1 ' FILL DTB WITH DATAGRIDVIEW
                DRW = DTB.NewRow

                For CLS = 0 To DGV.ColumnCount - 1
                    Try
                        DRW(DTB.Columns(CLS).ColumnName.ToString) = DGV.Rows(RWS).Cells(CLS).Value.ToString
                    Catch ex As Exception

                    End Try
                Next

                DTB.Rows.Add(DRW)
            Next

            DTB.AcceptChanges()

            Dim DST As New DataSet
            DST.Tables.Add(DTB)
            Dim FLE As String = "C:\temp\XML.xml" ' PATH AND FILE NAME WHERE THE XML WIL BE CREATED (EXEMPLE: C:\REPS\XML.xml)
            DTB.WriteXml(FLE)
            Dim EXL As String = "C:\Program Files\Microsoft Office\Office16\EXCEL.EXE" ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
            Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        Course1123EarlyFDashboard.Show()
    End Sub
End Class