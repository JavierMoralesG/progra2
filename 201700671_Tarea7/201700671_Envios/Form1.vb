Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("Desea Salir", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If (Indice <= 10) Then
            Cliente(Indice) = TextBox1.Text
            Valor(Indice) = Val(TextBox2.Text)
            Peso(Indice) = Val(InputBox("Ingrese Peso"))
            Tipo(Indice) = ComboBox1.Text
            Transporte(Indice) = ComboBox2.Text
            If Transporte(Indice) = "Camion" Then
                If Tipo(Indice) = "Documentos" Then
                    Impuesto(Indice) = Valor(Indice) * documentos
                ElseIf Tipo(Indice) = "Ropa" Then
                    Impuesto(Indice) = Valor(Indice) * ropa
                ElseIf Tipo(Indice) = "Articulos pedecederos" Then
                    Impuesto(Indice) = Valor(Indice) * pedecederos
                ElseIf Tipo(Indice) = "Articulos plasticos" Then
                    Impuesto(Indice) = Valor(Indice) * plastico
                ElseIf Tipo(Indice) = "Lociones" Then
                    Impuesto(Indice) = Valor(Indice) * lociones
                End If
                Parcial(Indice) = Math.Round(camion + Impuesto(Indice), 2)

            ElseIf Transporte(Indice) = "Motocicleta" Then
                If Tipo(Indice) = "Documentos" Then
                    Impuesto(Indice) = Valor(Indice) * documentos
                ElseIf Tipo(Indice) = "Ropa" Then
                    Impuesto(Indice) = Valor(Indice) * ropa
                ElseIf Tipo(Indice) = "Articulos pedecederos" Then
                    Impuesto(Indice) = Valor(Indice) * pedecederos
                ElseIf Tipo(Indice) = "Articulos plasticos" Then
                    Impuesto(Indice) = Valor(Indice) * plastico
                ElseIf Tipo(Indice) = "Lociones" Then
                    Impuesto(Indice) = Valor(Indice) * lociones
                End If
                Parcial(Indice) = Math.Round(moto + Impuesto(Indice), 2)
            End If

            Total(Indice) = Math.Round(Parcial(Indice) + Valor(Indice), 2)

            mostrar_vectores()
            Indice = Indice + 1
        End If

        If (Indice = 10) Then
            MsgBox("Vectores Llenos")
        End If
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        Indice = 0

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
    End Sub

    Private Sub EstadisticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticaToolStripMenuItem.Click
        Dim i As Byte
        Dim totlociones As Double
        Dim totdocumentos As Double
        Dim totropa As Double
        Dim totplasticos As Double
        totplasticos = 0
        totropa = 0
        totlociones = 0
        totdocumentos = 0
        For i = 0 To 10

            If (ListBox4.Text = "Documentos") Then

                totdocumentos = totdocumentos + Valor(i)

                If (ComboBox1.Text = "Lociones") Then
                    totlociones = totlociones + Valor(Indice)
                End If

                If (ComboBox1.Text = "Ropa") Then
                    totropa = totropa + 1
                End If
                If (ComboBox1.Text = "Articulos plasticos") Then
                    totplasticos = totplasticos + 1
                End If

            Else
                Exit For
            End If
        Next i
        TextBox3.Text = Str(totdocumentos)
        TextBox4.Text = Str(totlociones)
        TextBox5.Text = Str(totplasticos)
        TextBox6.Text = Str(totropa)
    End Sub
End Class
