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
        Dim operationIndex As Integer = 0
        Dim computedResult As Integer

        'Check if the name text box is filled out and contains only numbers, if not store a message
        CheckString(NameTextBox.Text, "Name") 'If the string contains a number it is stored in StoreMessage()

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
            operationIndex = 1
        ElseIf RadioButtonMultiplication.Checked Then
            operationIndex = 2
        ElseIf RadioButtonDivision.Checked Then
            operationIndex = 3
        End If

        'Create the computed result
        Select Case operationIndex
            Case 0
                computedResult = CInt(Number1.Text) + CInt(Number2.Text)
            Case 1
                computedResult = CInt(Number1.Text) - CInt(Number2.Text)
            Case 2
                computedResult = CInt(Number1.Text) * CInt(Number2.Text)
            Case 3
                computedResult = CInt(CInt(Number1.Text) / CInt(Number2.Text))
        End Select

        'If no answer is given messgage the user and exit the sub
        If StudentAnswerTextBox.Text = "" Then
            MsgBox("Please Enter an Answer")
            Exit Sub
        End If

        'Compare the computed result with the student's result and display the coresponding msg box
        Try
            If computedResult = CInt(StudentAnswerTextBox.Text) Then
                MsgBox("Correct!")
                StoreResults("Correct", False)
            Else
                MsgBox("Sorry, that was incorrect." & vbNewLine & "Correct Answer: " & computedResult & vbNewLine & "Your Answer:  " & StudentAnswerTextBox.Text)
                StoreResults("Incorrect", False)
            End If
        Catch ex As Exception
            MsgBox("Please check your answer for letters and try again.")
            Exit Sub
        End Try

        'Set new numbers
        Number1.Text = CStr(Math.Ceiling(VBMath.Rnd * 10))
        Number2.Text = CStr(Math.Ceiling(VBMath.Rnd * 10))

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

        If StoreResults("", False) = "" Then
            'Display nothing
        Else
            MsgBox(StoreResults("", False)) 'Display recorded results in a msg box
        End If

    End Sub

    Sub ExitButtonPress() Handles ButtonExit.Click

        End 'End the program

    End Sub

    Function StoreResults(correct As String, clear As Boolean) As String

        Static numberOfRuns As Integer
        Static totalCorrect As Integer
        Static results As String

        'If clear is true reset everything and exit the program
        If clear Then
            results = ""
            numberOfRuns = 0
            totalCorrect = 0
            Return results
        End If

        'If no result is given return the currently recorded results
        If correct = "" Then
            Return results 'Functionalitty for me to easily grab the stored results
        End If

        'If correct is stated then add one to the correct count
        If correct = "Correct" Then
            totalCorrect += 1
        End If

        'Increase the number of runs by one and edit the current results
        numberOfRuns += 1
        results = NameTextBox.Text & " got " & CStr(totalCorrect) & " out of " & CStr(numberOfRuns) &
                  vbNewLine & "For a total of " & CStr(CInt(totalCorrect / numberOfRuns * 100)) & "%"

        Return results

    End Function

    Function CheckString(checkThisString As String, testedField As String) As String

        Dim stringLength As Integer
        Dim hasNumber As String = "False"

        'Gets the length of the string in question
        stringLength = Len(checkThisString)

        'IsNumeric() cannot be used because I need to know if any of the charcters are numbers not the whole string.
        'If the string is empty then return "Empty"
        If checkThisString = "" Then
            StoreMessage(testedField & " is empty.", False)
            Return "Empty"
        Else
            'If the string is not empty test if each character is a number
            For i = 0 To stringLength - 1

                Try
                    Convert.ToInt32(checkThisString.Substring(i, 1)) 'Test the character
                    hasNumber = "True" 'If the code continues then the tested character is a number
                    StoreMessage(testedField, False) 'Store what field has a problem
                Catch ex As Exception

                End Try

            Next

        End If

        'Return whether or not the tested string has a number in it
        Return hasNumber

    End Function

    Function StoreMessage(message As String, clear As Boolean) As String

        Static storedMessages As String

        'If clear is true reset stored messages
        If clear Then
            storedMessages = ""
        End If

        'If message is empty then return the stored messages and continue
        If message = "" Then
            Return storedMessages 'Returning here to make sure the stored message does not have a unecessary new line
        End If

        'Add the new message to the StoredMessages String
        storedMessages = storedMessages & vbNewLine & message
        Return storedMessages

    End Function

End Class