Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer = Integer.Parse(TextBox1.Text)
        Dim y As Integer = Integer.Parse(TextBox2.Text)
        Dim r As Integer = x + y
        Label4.Text = r.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Integer = Integer.Parse(TextBox1.Text)
        Dim y As Integer = Integer.Parse(TextBox2.Text)
        Dim r As Integer = x - y
        Label4.Text = r.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As Integer = Integer.Parse(TextBox1.Text)
        Dim y As Integer = Integer.Parse(TextBox2.Text)
        Dim r As Integer = x * y
        Label4.Text = r.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As Integer = Integer.Parse(TextBox1.Text)
        Dim y As Integer = Integer.Parse(TextBox2.Text)
        Dim r As Decimal = x / y
        Label4.Text = r.ToString()
    End Sub
End Class
