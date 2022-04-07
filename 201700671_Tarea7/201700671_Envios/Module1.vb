Module Module1
    Public Indice As Byte = 0

    Public Cliente(10) As String
    Public Valor(10) As Integer
    Public Peso(10) As Integer
    Public Tipo(10) As String
    Public Transporte(10) As String
    Public Impuesto(10) As Double
    Public Parcial(10) As Double
    Public Total(10) As Double

    Public Const camion = 50
    Public Const moto = 15

    Public Const documentos = 0.015
    Public Const ropa = 0.06
    Public Const pedecederos = 0.055
    Public Const plastico = 0.045
    Public Const lociones = 0.02

    Sub mostrar_vectores()

        Form1.ListBox1.Items.Add(Cliente(Indice))
        Form1.ListBox2.Items.Add(Valor(Indice))
        Form1.ListBox3.Items.Add(Impuesto(Indice))
        Form1.ListBox4.Items.Add(Tipo(Indice))
        Form1.ListBox5.Items.Add(Parcial(Indice))
        Form1.ListBox6.Items.Add(Total(Indice))
    End Sub
    Sub LIMPIAR_ENTRADAS()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.TextBox1.Focus()
    End Sub
End Module
