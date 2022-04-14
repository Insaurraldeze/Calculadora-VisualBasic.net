Public Class Form1
    Dim num1, num2 As Double
    Dim total As Double
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        If RadioButton1.Checked Then
            total = num1 + num2
            TextBox3.Text = total
        ElseIf RadioButton2.Checked Then
            total = num1 - num2
            TextBox3.Text = total
        ElseIf RadioButton3.Checked Then
            total = num1 * num2
            TextBox3.Text = total
        ElseIf RadioButton4.Checked Then
            total = num1 / num2
            TextBox3.Text = total
        Else
            total = num1 Mod num2
            TextBox3.Text = total


        End If
    End Sub
End Class
