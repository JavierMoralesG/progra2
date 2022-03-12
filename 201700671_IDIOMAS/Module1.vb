Imports System.Math
Module Module1

    Public inscripciones(8, 9) As String

    Public carnet As Integer
    Public nombre As String
    Public idioma As String
    Public dias As String
    Public horas As Integer
    Public pago As String
    Public total As Double
    Public descuento1 As Double
    Public descuento2 As Double
    Public TOTALFINAL As Double

    Public Const efectivo = 0.02
    Public Const cheque = 0.015
    Public Const dosdias = 0.05



    Public Const ingles = 150
    Public Const Portugues = 80
    Public Const Frances = 125

    Public fila As Byte = 0
    Sub limpiar_entradas()
        Form1.TextBox2.Text = ""
        Form1.TextBox1.Text = ""

        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False

        Form1.ComboBox1.Text = "Seleccione Idioma"

        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False

    End Sub
    Sub Mostrar()
        Dim i As Byte

        For i = 0 To 7
            If inscripciones(i, 0) <> Nothing Then
                Form1.DataGridView1.Rows.Add(inscripciones(i, 0), inscripciones(i, 1), inscripciones(i, 2), inscripciones(i, 3), inscripciones(i, 4), inscripciones(i, 5), inscripciones(i, 6), inscripciones(i, 7), inscripciones(i, 8), inscripciones(i, 9))
            Else

                Exit For
            End If
        Next i
    End Sub

    Sub Salir()

        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If

    End Sub
End Module



