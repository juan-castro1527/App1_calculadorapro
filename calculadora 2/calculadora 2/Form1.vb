Public Class Form1
    Dim activo

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim x As Double = Double.Parse(TextBox1.Text)
        Dim y As Double = Double.Parse(TextBox2.Text)
        Dim r As Double = x + y
        Label4.Text = r.ToString()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim x As Double = Double.Parse(TextBox1.Text)
        Dim y As Double = Double.Parse(TextBox2.Text)
        Dim r As Double = x - y
        Label4.Text = r.ToString()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim r

        Dim x As Double = Double.Parse(Me.TextBox1.Text)
        Dim y As Double = Double.Parse(Me.TextBox2.Text)

        If y > 0 Then
            r = x / y
        Else
            r = "No se puede"
        End If

        Label4.Text = r.ToString()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim x As Double = Double.Parse(TextBox1.Text)
        Dim y As Double = Double.Parse(TextBox2.Text)
        Dim r As Double = x * y
        Label4.Text = r.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        activo.Text = activo.Text & "1"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        activo = TextBox1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        activo = TextBox2
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        activo.Text = activo.Text & "2"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        activo.Text = activo.Text & "3"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        activo.Text = activo.Text & "4"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        activo.Text = activo.Text & "5"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        activo.Text = activo.Text & "6"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        activo.Text = activo.Text & "7"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        activo.Text = activo.Text & "8"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        activo.Text = activo.Text & "9"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        activo.Text = activo.Text & "0"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        activo.Text = activo.Text & "."
    End Sub
End Class
