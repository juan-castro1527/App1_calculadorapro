Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer = Integer.Parse(TextBox1.Text)
        Dim y As Integer = Integer.Parse(TextBox2.Text)
        Dim r As Integer = x + y
        Label4.Text = r.ToString()
    End Sub
End Class
