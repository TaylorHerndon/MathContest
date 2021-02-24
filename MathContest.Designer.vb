<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContest
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonSummary = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDivision = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMultiplication = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSubtraction = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAddition = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.Number2 = New System.Windows.Forms.TextBox()
        Me.Number1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GradeListBox = New System.Windows.Forms.ListBox()
        Me.AgeListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GeneralToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonExit)
        Me.Panel1.Controls.Add(Me.ButtonSummary)
        Me.Panel1.Controls.Add(Me.ButtonClear)
        Me.Panel1.Controls.Add(Me.ButtonSubmit)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 456)
        Me.Panel1.TabIndex = 1
        '
        'ButtonExit
        '
        Me.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonExit.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(527, 344)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(190, 77)
        Me.ButtonExit.TabIndex = 14
        Me.ButtonExit.Text = "Exit"
        Me.GeneralToolTips.SetToolTip(Me.ButtonExit, "Click here to exit the program")
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonSummary
        '
        Me.ButtonSummary.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonSummary.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSummary.Location = New System.Drawing.Point(527, 247)
        Me.ButtonSummary.Name = "ButtonSummary"
        Me.ButtonSummary.Size = New System.Drawing.Size(190, 77)
        Me.ButtonSummary.TabIndex = 13
        Me.ButtonSummary.Text = "Summary"
        Me.GeneralToolTips.SetToolTip(Me.ButtonSummary, "Click here to view your results")
        Me.ButtonSummary.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonClear.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(527, 142)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(190, 77)
        Me.ButtonClear.TabIndex = 12
        Me.ButtonClear.Text = "Clear"
        Me.GeneralToolTips.SetToolTip(Me.ButtonClear, "Click here or press ESC to clear your information and score")
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonSubmit.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSubmit.Location = New System.Drawing.Point(527, 44)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(190, 77)
        Me.ButtonSubmit.TabIndex = 11
        Me.ButtonSubmit.Text = "Submit"
        Me.GeneralToolTips.SetToolTip(Me.ButtonSubmit, "Click here or press Enter to submit your information / answer")
        Me.ButtonSubmit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButtonDivision)
        Me.GroupBox3.Controls.Add(Me.RadioButtonMultiplication)
        Me.GroupBox3.Controls.Add(Me.RadioButtonSubtraction)
        Me.GroupBox3.Controls.Add(Me.RadioButtonAddition)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(291, 156)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(211, 278)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operation"
        '
        'RadioButtonDivision
        '
        Me.RadioButtonDivision.AutoSize = True
        Me.RadioButtonDivision.Location = New System.Drawing.Point(6, 139)
        Me.RadioButtonDivision.Name = "RadioButtonDivision"
        Me.RadioButtonDivision.Size = New System.Drawing.Size(105, 29)
        Me.RadioButtonDivision.TabIndex = 10
        Me.RadioButtonDivision.Text = "Division"
        Me.RadioButtonDivision.UseVisualStyleBackColor = True
        '
        'RadioButtonMultiplication
        '
        Me.RadioButtonMultiplication.AutoSize = True
        Me.RadioButtonMultiplication.Location = New System.Drawing.Point(6, 104)
        Me.RadioButtonMultiplication.Name = "RadioButtonMultiplication"
        Me.RadioButtonMultiplication.Size = New System.Drawing.Size(149, 29)
        Me.RadioButtonMultiplication.TabIndex = 9
        Me.RadioButtonMultiplication.Text = "Multiplication"
        Me.RadioButtonMultiplication.UseVisualStyleBackColor = True
        '
        'RadioButtonSubtraction
        '
        Me.RadioButtonSubtraction.AutoSize = True
        Me.RadioButtonSubtraction.Location = New System.Drawing.Point(6, 69)
        Me.RadioButtonSubtraction.Name = "RadioButtonSubtraction"
        Me.RadioButtonSubtraction.Size = New System.Drawing.Size(136, 29)
        Me.RadioButtonSubtraction.TabIndex = 8
        Me.RadioButtonSubtraction.Text = "Subtraction"
        Me.RadioButtonSubtraction.UseVisualStyleBackColor = True
        '
        'RadioButtonAddition
        '
        Me.RadioButtonAddition.AutoSize = True
        Me.RadioButtonAddition.Checked = True
        Me.RadioButtonAddition.Location = New System.Drawing.Point(6, 34)
        Me.RadioButtonAddition.Name = "RadioButtonAddition"
        Me.RadioButtonAddition.Size = New System.Drawing.Size(108, 29)
        Me.RadioButtonAddition.TabIndex = 7
        Me.RadioButtonAddition.TabStop = True
        Me.RadioButtonAddition.Text = "Addition"
        Me.RadioButtonAddition.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.StudentAnswerTextBox)
        Me.GroupBox2.Controls.Add(Me.Number2)
        Me.GroupBox2.Controls.Add(Me.Number1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 278)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Math Problem"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Student Answer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "2nd Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "1st Number"
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(11, 235)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(192, 30)
        Me.StudentAnswerTextBox.TabIndex = 6
        Me.GeneralToolTips.SetToolTip(Me.StudentAnswerTextBox, "Type your answer here" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Preform the function shown on the right" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with the two numb" &
        "ers above." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ex: 1st Number = 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     2nd Number = 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Operation = Addition" &
        "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Result = 2 + 3")
        '
        'Number2
        '
        Me.Number2.Enabled = False
        Me.Number2.Location = New System.Drawing.Point(11, 151)
        Me.Number2.Name = "Number2"
        Me.Number2.Size = New System.Drawing.Size(114, 30)
        Me.Number2.TabIndex = 5
        '
        'Number1
        '
        Me.Number1.Enabled = False
        Me.Number1.Location = New System.Drawing.Point(11, 79)
        Me.Number1.Name = "Number1"
        Me.Number1.Size = New System.Drawing.Size(114, 30)
        Me.Number1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GradeListBox)
        Me.GroupBox1.Controls.Add(Me.AgeListBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 106)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'GradeListBox
        '
        Me.GradeListBox.FormattingEnabled = True
        Me.GradeListBox.ItemHeight = 25
        Me.GradeListBox.Items.AddRange(New Object() {"4", "3", "2", "1"})
        Me.GradeListBox.Location = New System.Drawing.Point(370, 63)
        Me.GradeListBox.Name = "GradeListBox"
        Me.GradeListBox.Size = New System.Drawing.Size(86, 29)
        Me.GradeListBox.TabIndex = 3
        Me.GeneralToolTips.SetToolTip(Me.GradeListBox, "Select Grade" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If your grade is not listed here, you are not" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "eligiable to compete" &
        ".")
        '
        'AgeListBox
        '
        Me.AgeListBox.FormattingEnabled = True
        Me.AgeListBox.ItemHeight = 25
        Me.AgeListBox.Items.AddRange(New Object() {"11", "10", "9", "8", "7"})
        Me.AgeListBox.Location = New System.Drawing.Point(253, 63)
        Me.AgeListBox.Name = "AgeListBox"
        Me.AgeListBox.Size = New System.Drawing.Size(86, 29)
        Me.AgeListBox.TabIndex = 2
        Me.GeneralToolTips.SetToolTip(Me.AgeListBox, "Select Age" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If your age is not listed here, you are not" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "eligable to compete.")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(365, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Age"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(20, 63)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(183, 30)
        Me.NameTextBox.TabIndex = 1
        Me.GeneralToolTips.SetToolTip(Me.NameTextBox, "Enter Name")
        '
        'GeneralToolTips
        '
        Me.GeneralToolTips.AutoPopDelay = 4000
        Me.GeneralToolTips.InitialDelay = 500
        Me.GeneralToolTips.ReshowDelay = 100
        '
        'MathContest
        '
        Me.AcceptButton = Me.ButtonSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonClear
        Me.ClientSize = New System.Drawing.Size(770, 483)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MathContest"
        Me.Text = "Math Contest "
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Number2 As TextBox
    Friend WithEvents Number1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents AgeListBox As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButtonAddition As RadioButton
    Friend WithEvents GradeListBox As ListBox
    Friend WithEvents RadioButtonDivision As RadioButton
    Friend WithEvents RadioButtonMultiplication As RadioButton
    Friend WithEvents RadioButtonSubtraction As RadioButton
    Friend WithEvents ButtonExit As Button
    Friend WithEvents ButtonSummary As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonSubmit As Button
    Friend WithEvents GeneralToolTips As ToolTip
End Class
