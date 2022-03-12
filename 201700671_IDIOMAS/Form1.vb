Public Class Form1
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub LlimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LlimpiarMatrizToolStripMenuItem.Click

    End Sub
    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        Mostrar()
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        carnet = TextBox2.Text
        nombre = TextBox1.Text
        horas = Val(InputBox("Ingrese cantidad horas a estudiar:"))
        inscripciones(fila, 0) = carnet
        inscripciones(fila, 1) = nombre
        inscripciones(fila, 4) = horas

        pago = 0

        If fila <= 7 Then

            inscripciones(fila, 2) = ComboBox1.Text

            If ComboBox1.SelectedIndex = 0 Then
                pago = Val(horas * ingles)
                inscripciones(fila, 6) = pago
            ElseIf ComboBox1.SelectedIndex = 1 Then
                pago = Val(horas * Portugues)
                inscripciones(fila, 6) = pago
            ElseIf ComboBox1.SelectedIndex = 2 Then
                pago = Val(horas * Frances)
                inscripciones(fila, 6) = pago
            Else
                MsgBox("Error, no seleccionó idioma")
                Exit Sub
            End If
            If (CheckBox1.Checked) And (CheckBox2.Checked) Then
                inscripciones(fila, 3) = "V & S"
                descuento2 = Val(pago * dosdias)
                inscripciones(fila, 8) = descuento2
            ElseIf (CheckBox1.Checked) Then
                inscripciones(fila, 3) = "VIERNES"
            ElseIf (CheckBox2.Checked) Then
                inscripciones(fila, 3) = "SABADO"
            Else
                MsgBox("Error, no seleccionó ningun dia")
                Exit Sub
            End If
            If (RadioButton1.Checked) Then
                inscripciones(fila, 5) = RadioButton1.Text
                descuento1 = Val(pago * efectivo)
                inscripciones(fila, 7) = descuento1
            ElseIf (RadioButton2.Checked) Then
                inscripciones(fila, 5) = RadioButton2.Text
                descuento1 = Val(pago * efectivo)
                inscripciones(fila, 7) = descuento1
            Else
                MsgBox("Error, no seleccionó tipo de pago")
                Exit Sub
            End If
            TOTALFINAL = Val(pago - descuento1 - descuento2)
            inscripciones(fila, 9) = TOTALFINAL
            fila = fila + 1
        End If
        If (fila = 8) Then
            MsgBox("Matriz llena")
        End If
        limpiar_entradas()
    End Sub

    Private Sub MenuStrip1_ItemClicked_1(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
