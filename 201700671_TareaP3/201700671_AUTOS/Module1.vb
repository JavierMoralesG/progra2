﻿Module Module1
    Public Carro(7, 7) As String

    Public fila As Byte = 0

    Public I As Byte



    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True
        I = 0
        comprobar_repetido = True
        While (I <= 6) And (encontrado)
            If (Carro(I, 1) <> Nothing) Then
                If (Carro(I, 1) = Val(Form1.TextBox1.Text)) Then
                    comprobar_repetido = encontrado = False
                    Return comprobar_repetido
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If (encontrado) Then
            Return comprobar_repetido
        End If
    End Function
    Sub salir()
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            Form1.Close()
        Else
            limpiar_entradas()
        End If

    End Sub
    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.RadioButton1.Text = False
        Form1.RadioButton2.Text = False
        Form1.RadioButton3.Text = False
        Form1.RadioButton4.Text = False
        Form1.TextBox1.Focus()
    End Sub
    Sub limpiar_matriz()
        Dim J As Byte
        Form1.DataGridView1.Rows.Clear()
        fila = 0
        I = 0

        While (I <= 6)
            Carro(I, 0) = Nothing
            Carro(I, 1) = Nothing
            Carro(I, 2) = Nothing
            Carro(I, 3) = Nothing
            Carro(I, 4) = Nothing
            Carro(I, 5) = Nothing
            Carro(I, 6) = Nothing
            I = I + 1
        End While
    End Sub
    Sub Mostrar_Matriz()
        Form1.DataGridView1.Rows.Clear()
        I = 0
        While (I <= 6)
            If (Carro(I, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Carro(I, 0), Carro(I, 1), Carro(I, 2), Carro(I, 3), Carro(I, 4), Carro(I, 5), Carro(I, 6))
            Else
                Exit While
            End If
            I = I + 1
        End While
    End Sub
End Module
