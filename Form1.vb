Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frase As String = TextBox1.Text
        Dim contadorComas As Integer = 0
        For Each caracter As Char In frase
            If caracter = ","c Then
                contadorComas += 1
            End If
        Next
        Label1.Text = "Número de comas es: " & contadorComas
    End Sub
End Class
