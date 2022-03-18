Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        Venta(INDICE) = Str(TextBox3.Text)
        yardas(INDICE) = Val(Val(TextBox1.Text) + Val(TextBox2.Text))
        If RadioButton1.Checked Then
            tamaño(INDICE) = "SOFA"
            If yardas(INDICE) >= 8 Then
                If RadioButton6.Checked Then
                    tela(INDICE) = "CUERO"
                    COSTO(INDICE) = sofa + Val(TextBox1.Text) * cuero
                    TOTAL(INDICE) = COSTO(INDICE) + (Val(sofa + Val(TextBox1.Text) * cuero) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(TOTAL(INDICE)))
                    INDICE = INDICE + 1
                ElseIf RadioButton5.Checked Then
                    tela(INDICE) = "CUERINA"
                    COSTO(INDICE) = sofa + Val(TextBox2.Text) * cuerina
                    TOTAL(INDICE) = COSTO(INDICE) + (Val(sofa + Val(TextBox2.Text) * cuerina) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(TOTAL(INDICE)))
                    INDICE = INDICE + 1
                ElseIf MsgBox("Seleccione Tipo de tela", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then

                End If
            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If
        If RadioButton2.Checked Then
            tamaño(INDICE) = "INDIVIDUAL"
            If yardas(INDICE) >= 3.5 Then
                If RadioButton6.Checked Then
                    tela(INDICE) = "CUERO"
                    COSTO(INDICE) = individual + Val(TextBox1.Text) * cuero
                    TOTAL(INDICE) = COSTO(INDICE) + (Val(individual + Val(TextBox1.Text) * cuero) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(TOTAL(INDICE)))
                    INDICE = INDICE + 1
                ElseIf RadioButton5.Checked Then
                    tela(INDICE) = "CUERINA"
                    COSTO(INDICE) = individual + Val(TextBox2.Text) * cuerina
                    TOTAL(INDICE) = COSTO(INDICE) + (Val(individual + Val(TextBox2.Text) * cuerina) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(TOTAL(INDICE)))
                    INDICE = INDICE + 1
                ElseIf MsgBox("Seleccione Tipo de tela", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then

                End If

            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If
        If RadioButton3.Checked Then
            tamaño(INDICE) = "DOBLE"
            If yardas(INDICE) >= 6 Then
                If RadioButton6.Checked Then
                    tela(INDICE) = "CUERO"
                    COSTO(INDICE) = doble + Val(TextBox1.Text) * cuero
                    TOTAL(INDICE) = COSTO(INDICE) + (Val(doble + Val(TextBox1.Text) * cuero) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(TOTAL(INDICE)))
                    INDICE = INDICE + 1
                ElseIf RadioButton5.Checked Then
                    tela(INDICE) = "CUERINA"
                    COSTO(INDICE) = doble + Val(TextBox2.Text) * cuerina
                    TOTAL(INDICE) = COSTO(INDICE) + (Val(doble + Val(TextBox2.Text) * cuerina) * 0.65)
                    DataGridView1.Rows.Add(Str(Venta(INDICE)), tamaño(INDICE), tela(INDICE), Str(yardas(INDICE)), Str(COSTO(INDICE)), Str(TOTAL(INDICE)))
                    INDICE = INDICE + 1
                ElseIf MsgBox("Seleccione Tipo de tela", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then

                End If

            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If
        If (INDICE = 8) Then
            MsgBox("VECTORES LLENOS")
        End If
        LIMPIAR_ENTRADAS()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub
End Class
