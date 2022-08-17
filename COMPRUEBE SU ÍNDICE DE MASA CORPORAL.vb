Public Class COMPRUEBE_SU_ÍNDICE_DE_MASA_CORPORAL
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IMC, ALTURA, PESO As Double
        PESO = TextBox2.Text
        ALTURA = TextBox1.Text
        IMC = (PESO) / (ALTURA ^ 2) * 100
        TextBox3.Text = IMC

        If IMC < 18.5 Then PictureBox1.ImageLocation = "C:\Users\Administrador\Desktop\Cristina\Imagenes\BAJO.jpg"
        If (IMC > 18.4) And (IMC < 25) Then PictureBox1.ImageLocation = "C:\Users\Administrador\Desktop\Cristina\Imagenes\NORMAL.jpg"
        If (IMC > 24.9) And (IMC < 30) Then PictureBox1.ImageLocation = "C:\Users\Administrador\Desktop\Cristina\Imagenes\SOBREPESO.jpg"
        If IMC > 30 Then PictureBox1.ImageLocation = "C:\Users\Administrador\Desktop\Cristina\Imagenes\OBESO.jpg"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class