Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        'If user does the wrong thing, terminate processing (what return does)
        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("Error: please type a number")
            Return
        End If

        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        'if number is negative, then error
        If num1 < 0 Or num1 < 0 Then
            MessageBox.Show("Error: please type a positive number")
        End If


        'only way to get here is if user did everything perfectly right

        If (num1 > num2) Then
            largerNum = num1
            txtResult.Text = "The larger number is " & num1
        ElseIf (num1 < num2) Then
            largerNum = num2
            txtResult.Text = "The larger number is " & num2
        Else
            txtResult.Text = "They are equal"
        End If





    End Sub
End Class
