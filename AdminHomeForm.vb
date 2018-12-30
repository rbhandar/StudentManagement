Imports System.Data.SqlClient
Public Class AdminHomeForm
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.Hide()
        AdminAssessmentTestForm.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Admin1123ProgressForm.Show()
    End Sub

    Private Sub AdminHomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminAssessmentTestScoreTotalCount()
        AdminTotalStudent1120()
        AdminTotalStudent1123()
        lblUser.Text = AdminLoginForm.getFirstname
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        Admin1120ProgressForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub


    Public Sub AdminAssessmentTestScoreTotalCount()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("SELECT Count(Student_ID) as Passed FROM [PROJECTF1809].[dbo].[FINAL_Course_Asessment_TestRB] ", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else

            lnklblTotalStudentsAssessment.Text = table.Rows(0).Item(0)

            'Chart1.Series("Series1").Points.AddY(table.Rows(0).Item(0))
            'Chart1.DataSource = table
            'Chart1.Series("Series1").YValueMembers = "Passed"
            'Chart1.Series("Series1").YValueMembers = "1"

        End If
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
            lnklblTotalStudents1120.Text = table.Rows(0).Item(0)


        End If
    End Sub


    Public Sub AdminTotalStudent1123()
        Dim connection As New SqlConnection("Server=essql1.walton.uark.edu;Database=PROJECTF1809;User Id=PROJECTF1809;Password=KP32epv$;")
        Dim command As New SqlCommand("Select Count(Student_ID) as Total_Students_1123 from [FINAL_1123_COURSE];", connection)

        'command.Parameters.Add("@Student_ID", SqlDbType.VarChar).Value = StudentLoginForm.thisStuID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Student does not exist. Please try another ID", MsgBoxStyle.Critical, "Student Search Failed")

        Else
            lnklblTotalStudents1123.Text = table.Rows(0).Item(0)

        End If
    End Sub

    'Private Sub lnklblTotalStudentsAssessment_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblTotalStudentsAssessment.LinkClicked
    '    Me.Hide()
    '    AdminAssessStudentTotal.Show()
    'End Sub

    'Private Sub lnklblTotalStudents1120_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblTotalStudents1120.LinkClicked
    '    Me.Hide()
    '    Admin1120TotalStudents.Show()
    'End Sub

    'Private Sub lnklblTotalStudents1123_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblTotalStudents1123.LinkClicked
    '    Me.Hide()
    '    Course1123TotalStudent.Show()
    'End Sub
End Class