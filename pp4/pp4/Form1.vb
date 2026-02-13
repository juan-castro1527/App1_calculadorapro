Public Class Form1
    Private Sub suma_Click(sender As Object, e As EventArgs) Handles suma.Click
        Dim x As Integer = Integer.Parse(TextBox1.Text)
        Dim y As Integer = Integer.Parse(TextBox2.Text)
        Dim r As Integer = x + y
        Label4.Text = r.ToString()
    End Sub

    Private Sub resta_Click(sender As Object, e As EventArgs) Handles resta.Click
        Dim x As Integer = Integer.Parse(TextBox1.Text)
        Dim y As Integer = Integer.Parse(TextBox2.Text)
        Dim r As Integer = x - y
        Label4.Text = r.ToString()
    End Sub

    Private Sub multi_Click(sender As Object, e As EventArgs) Handles multi.Click
        Dim x As Integer = Integer.Parse(TextBox1.Text)
        Dim y As Integer = Integer.Parse(TextBox2.Text)
        Dim r As Integer = x * y
        Label4.Text = r.ToString()
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        Dim x As Integer = Integer.Parse(TextBox1.Text)
        Dim y As Integer = Integer.Parse(TextBox2.Text)
        Dim r As Decimal = x / y
        Label4.Text = r.ToString()
    End Sub

    Private Sub cero_Click(sender As Object, e As EventArgs) Handles cero.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub uno_Click(sender As Object, e As EventArgs) Handles uno.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub dos_Click(sender As Object, e As EventArgs) Handles dos.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub trs_Click(sender As Object, e As EventArgs) Handles trs.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub cuatro_Click(sender As Object, e As EventArgs) Handles cuatro.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub cinco_Click(sender As Object, e As EventArgs) Handles cinco.Click
        TextBox1.Text = TextBox1.Text & "5"

    End Sub

    Private Sub seis_Click(sender As Object, e As EventArgs) Handles seis.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub siete_Click(sender As Object, e As EventArgs) Handles siete.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub ocho_Click(sender As Object, e As EventArgs) Handles ocho.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub nueve_Click(sender As Object, e As EventArgs) Handles nueve.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
