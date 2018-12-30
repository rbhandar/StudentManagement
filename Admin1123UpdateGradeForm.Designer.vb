<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin1123UpdateGradeForm
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
        Me.txt1123StudentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnShowGrade = New System.Windows.Forms.Button()
        Me.btnUpdateGrade = New System.Windows.Forms.Button()
        Me.cmbbGrade = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCurrentGrade = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt1123StudentID
        '
        Me.txt1123StudentID.Location = New System.Drawing.Point(454, 260)
        Me.txt1123StudentID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt1123StudentID.Name = "txt1123StudentID"
        Me.txt1123StudentID.Size = New System.Drawing.Size(179, 20)
        Me.txt1123StudentID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(451, 238)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Student ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(451, 330)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select New Grade:"
        '
        'btnShowGrade
        '
        Me.btnShowGrade.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.btnShowGrade.BackColor = System.Drawing.Color.SandyBrown
        Me.btnShowGrade.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnShowGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowGrade.ForeColor = System.Drawing.Color.DarkRed
        Me.btnShowGrade.Location = New System.Drawing.Point(454, 280)
        Me.btnShowGrade.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnShowGrade.Name = "btnShowGrade"
        Me.btnShowGrade.Size = New System.Drawing.Size(177, 31)
        Me.btnShowGrade.TabIndex = 57
        Me.btnShowGrade.Text = "Show Current Grade"
        Me.btnShowGrade.UseVisualStyleBackColor = False
        '
        'btnUpdateGrade
        '
        Me.btnUpdateGrade.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.btnUpdateGrade.BackColor = System.Drawing.Color.SandyBrown
        Me.btnUpdateGrade.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnUpdateGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateGrade.ForeColor = System.Drawing.Color.DarkRed
        Me.btnUpdateGrade.Location = New System.Drawing.Point(454, 372)
        Me.btnUpdateGrade.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpdateGrade.Name = "btnUpdateGrade"
        Me.btnUpdateGrade.Size = New System.Drawing.Size(177, 31)
        Me.btnUpdateGrade.TabIndex = 58
        Me.btnUpdateGrade.Text = "Update  Grade"
        Me.btnUpdateGrade.UseVisualStyleBackColor = False
        '
        'cmbbGrade
        '
        Me.cmbbGrade.FormattingEnabled = True
        Me.cmbbGrade.Items.AddRange(New Object() {"A", "B", "C", "D", "F", "W"})
        Me.cmbbGrade.Location = New System.Drawing.Point(454, 350)
        Me.cmbbGrade.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbbGrade.Name = "cmbbGrade"
        Me.cmbbGrade.Size = New System.Drawing.Size(173, 21)
        Me.cmbbGrade.TabIndex = 59
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WCOB_CCSM_and_DS_System.My.Resources.Resources.UAPic
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(670, 267)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Student's Current Grade is: "
        '
        'lblCurrentGrade
        '
        Me.lblCurrentGrade.AutoSize = True
        Me.lblCurrentGrade.Location = New System.Drawing.Point(812, 267)
        Me.lblCurrentGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCurrentGrade.Name = "lblCurrentGrade"
        Me.lblCurrentGrade.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrentGrade.TabIndex = 62
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Button1.BackColor = System.Drawing.Color.SandyBrown
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(880, 590)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 31)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(266, 92)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(553, 34)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Decision Support Tool for Course 1123"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(966, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 25)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Welcome!"
        '
        'Admin1123UpdateGradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(1084, 641)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblCurrentGrade)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbbGrade)
        Me.Controls.Add(Me.btnUpdateGrade)
        Me.Controls.Add(Me.btnShowGrade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt1123StudentID)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Admin1123UpdateGradeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin1123UpdateGradeForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1123StudentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnShowGrade As Button
    Friend WithEvents btnUpdateGrade As Button
    Friend WithEvents cmbbGrade As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCurrentGrade As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
