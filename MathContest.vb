Option Strict On
Option Explicit On

'Taylor Herndon
'RCET0265
'Spring 2021
'Math Contest
'https://github.com/TaylorHerndon/MathContest

Public Class MathContest

    Sub SubmitButtonPress() Handles ButtonSubmit.Click

        Randomize()
        Dim OperationIndex As Integer = 0

        'Check if the name text box is filled out and contains only numbers, if not store a message
        CheckString(NameTextBox.Text, "Name")

        'If any stored messages are found prompt the user and abort the sub
        If StoreMessage("", False) <> "" Then

            MsgBox("The follwing fields require attention:" & StoreMessage("", False))
            StoreMessage("", True)
            NameTextBox.Focus()
            Exit Sub

        End If

        'If no number is provided yet generate two new numbers
        If Number1.Text = "" Or Number2.Text = "" Then

            Number1.Text = CStr(Math.Floor(VBMath.Rnd * 11))
            Number2.Text = CStr(Math.Floor(VBMath.Rnd * 11))
            Exit Sub

        End If

        'Find and set the operation
        If RadioButtonSubtraction.Checked Then
            OperationIndex = 1
        End If

        If RadioButtonMultiplication.Checked Then
            OperationIndex = 2
        End If

        If RadioButtonDivision.Checked Then
            OperationIndex = 3
        End If

        'Create the computed result
        Dim ComputedResult As Integer

        Select Case OperationIndex
            Case 0
                ComputedResult = CInt(Number1.Text) + CInt(Number2.Text)
            Case 1
                ComputedResult = CInt(Number1.Text) - CInt(Number2.Text)
            Case 2
                ComputedResult = CInt(Number1.Text) * CInt(Number2.Text)
            Case 3
                ComputedResult = CInt(CInt(Number1.Text) / CInt(Number2.Text))
        End Select

        'Compare the computed result with the student's result and display the coresponding msg box
        If ComputedResult = CInt(StudentAnswerTextBox.Text) Then

            MsgBox("Correct!")
            StoreResults("Correct", False)

        Else

            MsgBox("Sorry, that was incorrect." & vbNewLine & "Correct Answer: " & ComputedResult & vbNewLine & "Your Answer:  " & StudentAnswerTextBox.Text)
            StoreResults("Incorrect", False)

        End If

        'Set new numbers
        Number1.Text = CStr(Math.Floor(VBMath.Rnd * 11))
        Number2.Text = CStr(Math.Floor(VBMath.Rnd * 11))

        'Reset Student Answer
        StudentAnswerTextBox.Text = ""

    End Sub

    Sub ClearButtonPress() Handles ButtonClear.Click

        'Reset all fields to default values
        NameTextBox.Text = ""
        AgeListBox.SelectedIndex = 0
        GradeListBox.SelectedIndex = 0

        RadioButtonAddition.Checked = True

        Number1.Text = ""
        Number2.Text = ""
        StudentAnswerTextBox.Text = ""

        StoreResults("", True)

    End Sub
    Sub SummaryButtonPress() Handles ButtonSummary.MouseDown

        MsgBox(StoreResults("", False)) 'Display recorded results in a msg box

    End Sub

    Sub ExitButtonPress() Handles ButtonExit.Click

        End 'End the program

    End Sub

    Function StoreResults(Correct As String, Clear As Boolean) As String

        Static NumberOfRuns As Integer
        Static TotalCorrect As Integer
        Static Results As String

        'If clear is true reset everything and exit the program
        If Clear Then

            Results = ""
            NumberOfRuns = 0
            TotalCorrect = 0
            Return Results

        End If

        'If no result is given return the currently recorded results
        If Correct = "" Then

            Return Results

        End If

        'If correct is stated then add one to the correct count
        If Correct = "Correct" Then

            TotalCorrect += 1

        End If

        'Increase the number of runs by one and edit the current results
        NumberOfRuns += 1
        Results = NameTextBox.Text & " got " & CStr(TotalCorrect) & " out of " & CStr(NumberOfRuns) & vbNewLine & "For a total of " & CStr(CInt(TotalCorrect / NumberOfRuns * 100)) & "%"

        Return Results

    End Function

    Function CheckString(CheckThisString As String, TestedField As String) As String

        Dim StringLength As Integer
        Dim HasNumber As String = "False"

        'Gets the length of the string in question
        StringLength = Len(CheckThisString)

        'If the string is empty then return "Empty"
        If CheckThisString = "" Then

            StoreMessage(TestedField & " is empty.", False)
            Return "Empty"

        Else

            'If the string is not empty test if each character is a number
            For i = 0 To StringLength - 1

                Try

                    Convert.ToInt32(CheckThisString.Substring(i, 1)) 'Test the character
                    HasNumber = "True" 'If the code continues then the tested character is a number
                    StoreMessage(TestedField, False) 'Store what field has a problem

                Catch ex As Exception

                End Try

            Next

        End If

        'Return whether or not the tested string has a number in it
        Return HasNumber

    End Function

    Function StoreMessage(Message As String, Clear As Boolean) As String

        Static StoredMessages As String

        'If clear is true reset stored messages
        If Clear Then

            StoredMessages = ""
            Return StoredMessages

        End If

        'If message is empty then return the stored messages and continue
        If Message = "" Then

            Return StoredMessages

        End If

        'Add the new message to the StoredMessages String
        StoredMessages = StoredMessages & vbNewLine & Message

        Return StoredMessages

    End Function

End Class
