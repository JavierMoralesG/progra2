Public Class Form1


    Const precioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagoSinIVA As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoConIVA As Double = 0
    Dim descuento As Double = 0
    Dim pagoFinal As Double = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Libra_Arroz As Integer
        Dim Libra_Frijol As Integer
        Dim Libra_Azucar As Integer
        Dim Total As Double

        Libra_Arroz = TextBox1.Text
        Libra_Frijol = TextBox2.Text
        Libra_Azucar = TextBox3.Text

        Total = (Libra_Arroz + Libra_Frijol + Libra_Azucar)


        pagoSinIVA = (Val(TextBox1.Text) * precioArroz) + (Val(TextBox2.Text) * precioFrijol) + (Val(TextBox3.Text) * precioAzucar)
        valorIVA = pagoSinIVA * IVA
        pagoConIVA = pagoSinIVA + valorIVA
        descuento = pagoConIVA * 0.025
        pagoFinal = pagoConIVA - descuento

        TextBox5.Text = pagoSinIVA
        TextBox4.Text = valorIVA
        TextBox6.Text = pagoConIVA
        TextBox7.Text = descuento
        TextBox8.Text = pagoFinal


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox8.Clear()
        TextBox1.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
