Imports System.Data.SqlClient
'Imports Microsoft.Office.Interop.Excel
Public Class Admin1120UnstablePerf
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Admin1120ProgressForm.Show()
    End Sub

    Private Sub Admin1120UnstablePerf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Admin1120UnstProject()
    End Sub

    Public Sub Admin1120UnstProject()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT * FROM FINAL_1120_COURSE where Microsoft_Word_Capstone_Project - Microsoft_PowerPoint_Capstone_Project >= '20' or Microsoft_PowerPoint_Capstone_Project - Microsoft_Word_Capstone_Project >= '20'or Microsoft_Word_Capstone_Project - Microsoft_PowerPoint_Capstone_Project >='20' or Microsoft_PowerPoint_Capstone_Project - Microsoft_Excel_Capstone_Project >='20'or Microsoft_Excel_Capstone_Project - Microsoft_PowerPoint_Capstone_Project >= '20' or Microsoft_Excel_Capstone_Project - Microsoft_Word_Capstone_Project >='20' or Microsoft_Word_Capstone_Project - Microsoft_Excel_Capstone_Project >='20';", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            dgvUnstProject.DataSource = table

        End If
    End Sub

    Private Sub btnExport2210_Click(sender As Object, e As EventArgs) Handles btnExport2210.Click

        DATAGRIDVIEW_TO_EXCEL((dgvUnstProject)) ' THIS PARAMETER IS YOUR DATAGRIDVIEW

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





    ''' <summary>
    ''' To Export Data To Excel From DataGridView
    ''' </summary>
    ''' <param name="FilePath">C:\Users\rbhandar</param>
    ''' <param name="DataGrid">dgvUnstProject As DataGridView</param>
    Public Sub ExportDataToExcel(ByVal FilePath As String, ByVal DataGrid As DataGridView)

        Dim _mFileStream As New IO.StreamWriter(FilePath, False)
        Try
            _mFileStream.WriteLine("<?xml version=""1.0""?>")
            _mFileStream.WriteLine("<?mso-application progid=""Excel.Sheet""?>")
            _mFileStream.WriteLine("<ss:Workbook xmlns:ss=""urn:schemas-microsoft-com:office:spreadsheet"">")
            _mFileStream.WriteLine("    <ss:Styles>")
            _mFileStream.WriteLine("        <ss:Style ss:ID=""1"">")
            _mFileStream.WriteLine("           <ss:Font ss:Bold=""1""/>")
            _mFileStream.WriteLine("           <ss:FontName=""Courier New""/>")
            _mFileStream.WriteLine("        </ss:Style>")
            _mFileStream.WriteLine("    </ss:Styles>")
            _mFileStream.WriteLine("    <ss:Worksheet ss:Name=""Sheet1"">")
            _mFileStream.WriteLine("        <ss:Table>")
            For x As Integer = 0 To DataGrid.Columns.Count - 1
                _mFileStream.WriteLine("            <ss:Column ss:Width=""{0}""/>", DataGrid.Columns.Item(x).Width)
            Next
            _mFileStream.WriteLine("            <ss:Row ss:StyleID=""1"">")
            For i As Integer = 0 To DataGrid.Columns.Count - 1
                _mFileStream.WriteLine("                <ss:Cell>")
                _mFileStream.WriteLine(String.Format("                   <ss:Data ss:Type=""String"">{0}</ss:Data>", DataGrid.Columns.Item(i).HeaderText))
                _mFileStream.WriteLine("</ss:Cell>")
            Next
            _mFileStream.WriteLine("            </ss:Row>")
            For intRow As Integer = 0 To DataGrid.RowCount - 2
                _mFileStream.WriteLine(String.Format("            <ss:Row ss:Height =""{0}"">", DataGrid.Rows(intRow).Height))
                For intCol As Integer = 0 To DataGrid.Columns.Count - 1
                    _mFileStream.WriteLine("                <ss:Cell>")
                    _mFileStream.WriteLine(String.Format("                   <ss:Data ss:Type=""String"">{0}</ss:Data>", DataGrid.Item(intCol, intRow).Value.ToString))
                    _mFileStream.WriteLine("                </ss:Cell>")
                Next
                _mFileStream.WriteLine("            </ss:Row>")
            Next
            _mFileStream.WriteLine("        </ss:Table>")
            _mFileStream.WriteLine("    </ss:Worksheet>")
            _mFileStream.WriteLine("</ss:Workbook>")
            _mFileStream.Close()
            _mFileStream.Dispose()
            _mFileStream = Nothing
        Catch ex As Exception
            _mFileStream.Close()
            _mFileStream.Dispose()
            _mFileStream = Nothing
            MessageBox.Show("Error While Exporting Data To Excel. Error : " & ex.Message)
        End Try
    End Sub

    Sub myExp()
        ExportDataToExcel("\\mydocs.uark.edu\mydocs\rbhandar\Documents\Fall 2018", dgvUnstProject)
    End Sub
End Class