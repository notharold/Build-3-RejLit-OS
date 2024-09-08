Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1d.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstNum As Double
        Dim secondNum As Double
        Dim answer As Double

        firstNum = TextBox1d.Text
        secondNum = TextBox2d.Text
        answer = firstNum + secondNum

        MessageBox.Show("The answer is " & answer)

    End Sub
End Class