Public Class Form1

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Arroz As Byte, Frijo As Byte, Azucar As Byte
        Dim Desuento As Double, iva As Double, parcial As Double, Total As Double
        Const precioArroz As Double = 2.0
        Const precioFrijol As Double = 1.75
        Const precioAzucar As Double = 2.5
        Const desc = 0.025

        Dim pagoSinIva As Double = 0
        Dim ValorDelIva As Double = 0
        Dim PagoConIva As Double = 0
        Dim Descuento As Double = 0
        Dim PagoFinal As Double = 0

        pagoSinIva = Val(TextBox1.Text) * precioArroz + Val(TextBox2.Text) * precioFrijol + Val(TextBox3.Text) * precioAzucar
        ValorDelIva = pagoSinIva * 0.12
        PagoConIva = pagoSinIva + ValorDelIva
        Descuento = PagoConIva * 0.025
        PagoFinal = PagoConIva - Descuento


        R1.Text = pagoSinIva
        R2.Text = ValorDelIva
        R3.Text = PagoConIva
        R4.Text = Descuento
        R5.Text = PagoFinal
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Focus()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class
