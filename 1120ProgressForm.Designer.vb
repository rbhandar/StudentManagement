<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin1120ProgressForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblAllO60 = New System.Windows.Forms.Label()
        Me.lblExam2O60 = New System.Windows.Forms.Label()
        Me.lblExam1O60 = New System.Windows.Forms.Label()
        Me.lblExcelO60 = New System.Windows.Forms.Label()
        Me.lblPPointO60 = New System.Windows.Forms.Label()
        Me.lblWordO60 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lnklblTotalStudents = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lnklblStuScoreLessThan60AllSubject = New System.Windows.Forms.LinkLabel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lnklblStuScoreExam2LessThan60 = New System.Windows.Forms.LinkLabel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lnklblStuScoreExam1LessThan60 = New System.Windows.Forms.LinkLabel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lnklblStuScoreMSExcelLessThan60 = New System.Windows.Forms.LinkLabel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lnklblStuScoreMSPPLessThan60 = New System.Windows.Forms.LinkLabel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lnklblStuScoreMSWordLessThan60 = New System.Windows.Forms.LinkLabel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lnklblUnstableStuPerformance1120 = New System.Windows.Forms.LinkLabel()
        Me.lnklblBottom30Students = New System.Windows.Forms.LinkLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(570, 189)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Under 60"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(466, 285)
        Me.Chart1.TabIndex = 49
        Me.Chart1.Text = "Chart1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAllO60)
        Me.GroupBox2.Controls.Add(Me.lblExam2O60)
        Me.GroupBox2.Controls.Add(Me.lblExam1O60)
        Me.GroupBox2.Controls.Add(Me.lblExcelO60)
        Me.GroupBox2.Controls.Add(Me.lblPPointO60)
        Me.GroupBox2.Controls.Add(Me.lblWordO60)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(570, 479)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(466, 116)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'lblAllO60
        '
        Me.lblAllO60.AutoSize = True
        Me.lblAllO60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllO60.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblAllO60.Location = New System.Drawing.Point(317, 89)
        Me.lblAllO60.Name = "lblAllO60"
        Me.lblAllO60.Size = New System.Drawing.Size(59, 15)
        Me.lblAllO60.TabIndex = 65
        Me.lblAllO60.Text = "Label26"
        '
        'lblExam2O60
        '
        Me.lblExam2O60.AutoSize = True
        Me.lblExam2O60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExam2O60.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblExam2O60.Location = New System.Drawing.Point(317, 74)
        Me.lblExam2O60.Name = "lblExam2O60"
        Me.lblExam2O60.Size = New System.Drawing.Size(59, 15)
        Me.lblExam2O60.TabIndex = 64
        Me.lblExam2O60.Text = "Label25"
        '
        'lblExam1O60
        '
        Me.lblExam1O60.AutoSize = True
        Me.lblExam1O60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExam1O60.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblExam1O60.Location = New System.Drawing.Point(317, 59)
        Me.lblExam1O60.Name = "lblExam1O60"
        Me.lblExam1O60.Size = New System.Drawing.Size(59, 15)
        Me.lblExam1O60.TabIndex = 63
        Me.lblExam1O60.Text = "Label24"
        '
        'lblExcelO60
        '
        Me.lblExcelO60.AutoSize = True
        Me.lblExcelO60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExcelO60.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblExcelO60.Location = New System.Drawing.Point(317, 44)
        Me.lblExcelO60.Name = "lblExcelO60"
        Me.lblExcelO60.Size = New System.Drawing.Size(59, 15)
        Me.lblExcelO60.TabIndex = 62
        Me.lblExcelO60.Text = "Label23"
        '
        'lblPPointO60
        '
        Me.lblPPointO60.AutoSize = True
        Me.lblPPointO60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPPointO60.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblPPointO60.Location = New System.Drawing.Point(317, 29)
        Me.lblPPointO60.Name = "lblPPointO60"
        Me.lblPPointO60.Size = New System.Drawing.Size(59, 15)
        Me.lblPPointO60.TabIndex = 61
        Me.lblPPointO60.Text = "Label22"
        '
        'lblWordO60
        '
        Me.lblWordO60.AutoSize = True
        Me.lblWordO60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWordO60.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblWordO60.Location = New System.Drawing.Point(317, 14)
        Me.lblWordO60.Name = "lblWordO60"
        Me.lblWordO60.Size = New System.Drawing.Size(59, 15)
        Me.lblWordO60.TabIndex = 60
        Me.lblWordO60.Text = "Label21"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 15)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Additional Class Info:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(72, 89)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(231, 15)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Students Score 60 or Over On all Subject:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(107, 74)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 15)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Students score on Exam 2 over 60:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(107, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Students score on Exam 1 over 60:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(97, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Students score on MS Excel over 60:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(64, 29)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(239, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Students score on MS PowerPoint over 60:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(98, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Students score on MS Word over 60:"
        '
        'lnklblTotalStudents
        '
        Me.lnklblTotalStudents.AutoSize = True
        Me.lnklblTotalStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblTotalStudents.ForeColor = System.Drawing.Color.DarkRed
        Me.lnklblTotalStudents.LinkColor = System.Drawing.Color.OrangeRed
        Me.lnklblTotalStudents.Location = New System.Drawing.Point(406, 189)
        Me.lnklblTotalStudents.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblTotalStudents.Name = "lnklblTotalStudents"
        Me.lnklblTotalStudents.Size = New System.Drawing.Size(88, 18)
        Me.lnklblTotalStudents.TabIndex = 37
        Me.lnklblTotalStudents.TabStop = True
        Me.lnklblTotalStudents.Text = "LinkLabel1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(216, 189)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Student Fall 2018:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(266, 113)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(553, 34)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Decision Support Tool for Course 1120"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(966, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 25)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Welcome!"
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Button2.BackColor = System.Drawing.Color.SandyBrown
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkRed
        Me.Button2.Location = New System.Drawing.Point(932, 599)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 31)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.lnklblStuScoreLessThan60AllSubject)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.lnklblStuScoreExam2LessThan60)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.lnklblStuScoreExam1LessThan60)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.lnklblStuScoreMSExcelLessThan60)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.lnklblStuScoreMSPPLessThan60)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.lnklblStuScoreMSWordLessThan60)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Location = New System.Drawing.Point(26, 245)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(501, 248)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 20)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Overview"
        '
        'lnklblStuScoreLessThan60AllSubject
        '
        Me.lnklblStuScoreLessThan60AllSubject.AutoSize = True
        Me.lnklblStuScoreLessThan60AllSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblStuScoreLessThan60AllSubject.ForeColor = System.Drawing.Color.DarkRed
        Me.lnklblStuScoreLessThan60AllSubject.LinkColor = System.Drawing.Color.OrangeRed
        Me.lnklblStuScoreLessThan60AllSubject.Location = New System.Drawing.Point(380, 213)
        Me.lnklblStuScoreLessThan60AllSubject.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblStuScoreLessThan60AllSubject.Name = "lnklblStuScoreLessThan60AllSubject"
        Me.lnklblStuScoreLessThan60AllSubject.Size = New System.Drawing.Size(88, 18)
        Me.lnklblStuScoreLessThan60AllSubject.TabIndex = 47
        Me.lnklblStuScoreLessThan60AllSubject.TabStop = True
        Me.lnklblStuScoreLessThan60AllSubject.Text = "LinkLabel3"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(101, 213)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(275, 18)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Score Less Than 60 On All Subject:"
        '
        'lnklblStuScoreExam2LessThan60
        '
        Me.lnklblStuScoreExam2LessThan60.AutoSize = True
        Me.lnklblStuScoreExam2LessThan60.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblStuScoreExam2LessThan60.ForeColor = System.Drawing.Color.DarkRed
        Me.lnklblStuScoreExam2LessThan60.LinkColor = System.Drawing.Color.OrangeRed
        Me.lnklblStuScoreExam2LessThan60.Location = New System.Drawing.Point(380, 179)
        Me.lnklblStuScoreExam2LessThan60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblStuScoreExam2LessThan60.Name = "lnklblStuScoreExam2LessThan60"
        Me.lnklblStuScoreExam2LessThan60.Size = New System.Drawing.Size(88, 18)
        Me.lnklblStuScoreExam2LessThan60.TabIndex = 45
        Me.lnklblStuScoreExam2LessThan60.TabStop = True
        Me.lnklblStuScoreExam2LessThan60.Text = "LinkLabel3"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkRed
        Me.Label16.Location = New System.Drawing.Point(58, 179)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(318, 18)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Students score on Exam 2 Less Than 60:"
        '
        'lnklblStuScoreExam1LessThan60
        '
        Me.lnklblStuScoreExam1LessThan60.AutoSize = True
        Me.lnklblStuScoreExam1LessThan60.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblStuScoreExam1LessThan60.ForeColor = System.Drawing.Color.DarkRed
        Me.lnklblStuScoreExam1LessThan60.LinkColor = System.Drawing.Color.OrangeRed
        Me.lnklblStuScoreExam1LessThan60.Location = New System.Drawing.Point(380, 145)
        Me.lnklblStuScoreExam1LessThan60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblStuScoreExam1LessThan60.Name = "lnklblStuScoreExam1LessThan60"
        Me.lnklblStuScoreExam1LessThan60.Size = New System.Drawing.Size(88, 18)
        Me.lnklblStuScoreExam1LessThan60.TabIndex = 43
        Me.lnklblStuScoreExam1LessThan60.TabStop = True
        Me.lnklblStuScoreExam1LessThan60.Text = "LinkLabel3"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkRed
        Me.Label17.Location = New System.Drawing.Point(58, 145)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(318, 18)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Students score on Exam 1 Less Than 60:"
        '
        'lnklblStuScoreMSExcelLessThan60
        '
        Me.lnklblStuScoreMSExcelLessThan60.AutoSize = True
        Me.lnklblStuScoreMSExcelLessThan60.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblStuScoreMSExcelLessThan60.ForeColor = System.Drawing.Color.DarkRed
        Me.lnklblStuScoreMSExcelLessThan60.LinkColor = System.Drawing.Color.OrangeRed
        Me.lnklblStuScoreMSExcelLessThan60.Location = New System.Drawing.Point(380, 111)
        Me.lnklblStuScoreMSExcelLessThan60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblStuScoreMSExcelLessThan60.Name = "lnklblStuScoreMSExcelLessThan60"
        Me.lnklblStuScoreMSExcelLessThan60.Size = New System.Drawing.Size(88, 18)
        Me.lnklblStuScoreMSExcelLessThan60.TabIndex = 41
        Me.lnklblStuScoreMSExcelLessThan60.TabStop = True
        Me.lnklblStuScoreMSExcelLessThan60.Text = "LinkLabel3"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkRed
        Me.Label18.Location = New System.Drawing.Point(43, 111)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(333, 18)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Students score on MS Excel Less Than 60:"
        '
        'lnklblStuScoreMSPPLessThan60
        '
        Me.lnklblStuScoreMSPPLessThan60.AutoSize = True
        Me.lnklblStuScoreMSPPLessThan60.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblStuScoreMSPPLessThan60.ForeColor = System.Drawing.Color.DarkRed
        Me.lnklblStuScoreMSPPLessThan60.LinkColor = System.Drawing.Color.OrangeRed
        Me.lnklblStuScoreMSPPLessThan60.Location = New System.Drawing.Point(380, 77)
        Me.lnklblStuScoreMSPPLessThan60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblStuScoreMSPPLessThan60.Name = "lnklblStuScoreMSPPLessThan60"
        Me.lnklblStuScoreMSPPLessThan60.Size = New System.Drawing.Size(88, 18)
        Me.lnklblStuScoreMSPPLessThan60.TabIndex = 39
        Me.lnklblStuScoreMSPPLessThan60.TabStop = True
        Me.lnklblStuScoreMSPPLessThan60.Text = "LinkLabel3"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkRed
        Me.Label19.Location = New System.Drawing.Point(-3, 77)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(379, 18)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Students score on MS PowerPoint Less Than 60:"
        '
        'lnklblStuScoreMSWordLessThan60
        '
        Me.lnklblStuScoreMSWordLessThan60.AutoSize = True
        Me.lnklblStuScoreMSWordLessThan60.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblStuScoreMSWordLessThan60.ForeColor = System.Drawing.Color.DarkRed
        Me.lnklblStuScoreMSWordLessThan60.LinkColor = System.Drawing.Color.OrangeRed
        Me.lnklblStuScoreMSWordLessThan60.Location = New System.Drawing.Point(380, 43)
        Me.lnklblStuScoreMSWordLessThan60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblStuScoreMSWordLessThan60.Name = "lnklblStuScoreMSWordLessThan60"
        Me.lnklblStuScoreMSWordLessThan60.Size = New System.Drawing.Size(88, 18)
        Me.lnklblStuScoreMSWordLessThan60.TabIndex = 38
        Me.lnklblStuScoreMSWordLessThan60.TabStop = True
        Me.lnklblStuScoreMSWordLessThan60.Text = "LinkLabel2"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkRed
        Me.Label20.Location = New System.Drawing.Point(43, 43)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(333, 18)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Students score on MS Word Less Than 60:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(4, 33)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(339, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "No. of Students with Unstable Performance:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(4, 72)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 18)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Bottom 30% Students:"
        '
        'lnklblUnstableStuPerformance1120
        '
        Me.lnklblUnstableStuPerformance1120.AutoSize = True
        Me.lnklblUnstableStuPerformance1120.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblUnstableStuPerformance1120.ForeColor = System.Drawing.Color.DarkRed
        Me.lnklblUnstableStuPerformance1120.LinkColor = System.Drawing.Color.Red
        Me.lnklblUnstableStuPerformance1120.Location = New System.Drawing.Point(383, 33)
        Me.lnklblUnstableStuPerformance1120.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblUnstableStuPerformance1120.Name = "lnklblUnstableStuPerformance1120"
        Me.lnklblUnstableStuPerformance1120.Size = New System.Drawing.Size(104, 18)
        Me.lnklblUnstableStuPerformance1120.TabIndex = 38
        Me.lnklblUnstableStuPerformance1120.TabStop = True
        Me.lnklblUnstableStuPerformance1120.Text = "Unstable Stu"
        '
        'lnklblBottom30Students
        '
        Me.lnklblBottom30Students.AutoSize = True
        Me.lnklblBottom30Students.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblBottom30Students.ForeColor = System.Drawing.Color.DarkRed
        Me.lnklblBottom30Students.LinkColor = System.Drawing.Color.Red
        Me.lnklblBottom30Students.Location = New System.Drawing.Point(380, 72)
        Me.lnklblBottom30Students.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblBottom30Students.Name = "lnklblBottom30Students"
        Me.lnklblBottom30Students.Size = New System.Drawing.Size(87, 18)
        Me.lnklblBottom30Students.TabIndex = 58
        Me.lnklblBottom30Students.TabStop = True
        Me.lnklblBottom30Students.Text = "Click Here"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.lnklblBottom30Students)
        Me.GroupBox3.Controls.Add(Me.lnklblUnstableStuPerformance1120)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 493)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(501, 102)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.IndianRed
        Me.Label21.Location = New System.Drawing.Point(121, 52)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(222, 16)
        Me.Label21.TabIndex = 60
        Me.Label21.Text = "(based upon Projects' performance)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(146, 20)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "At-Risk Students"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WCOB_CCSM_and_DS_System.My.Resources.Resources.UAPic
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.IndianRed
        Me.Label22.Location = New System.Drawing.Point(501, 147)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 20)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "Fall 2018"
        '
        'Admin1120ProgressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(1084, 641)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lnklblTotalStudents)
        Me.Name = "Admin1120ProgressForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin1120ProgressForm"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lnklblTotalStudents As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lnklblStuScoreExam2LessThan60 As LinkLabel
    Friend WithEvents Label16 As Label
    Friend WithEvents lnklblStuScoreExam1LessThan60 As LinkLabel
    Friend WithEvents Label17 As Label
    Friend WithEvents lnklblStuScoreMSExcelLessThan60 As LinkLabel
    Friend WithEvents Label18 As Label
    Friend WithEvents lnklblStuScoreMSPPLessThan60 As LinkLabel
    Friend WithEvents Label19 As Label
    Friend WithEvents lnklblStuScoreMSWordLessThan60 As LinkLabel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lnklblStuScoreLessThan60AllSubject As LinkLabel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lnklblUnstableStuPerformance1120 As LinkLabel
    Friend WithEvents lnklblBottom30Students As LinkLabel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lblAllO60 As Label
    Friend WithEvents lblExam2O60 As Label
    Friend WithEvents lblExam1O60 As Label
    Friend WithEvents lblExcelO60 As Label
    Friend WithEvents lblPPointO60 As Label
    Friend WithEvents lblWordO60 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
End Class
