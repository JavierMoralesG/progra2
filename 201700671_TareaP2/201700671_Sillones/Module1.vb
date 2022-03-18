Module Module1

    Public Total(8) As Double
    Public COSTO(8) As Double
    Public Venta(8) As Double
    Public tamaño(8) As String
    Public tela(8) As String
    Public yardas(8) As Double
    Public Const sofa = 250.99
    Public Const individual = 150.99
    Public Const doble = 200.99
    Public Const cuero = 75.0
    Public Const cuerina = 45.99
    Public PrecioVenta As Double
    Public INDICE As Byte = 0
    Sub LIMPIAR_ENTRADAS()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.RadioButton1.Checked = False
        Form1.RadioButton2.Checked = False
        Form1.RadioButton3.Checked = False
        Form1.RadioButton5.Checked = False
        Form1.RadioButton6.Checked = False
        Form1.RadioButton1.Focus()
    End Sub
    Sub limpiar_vectores()
        INDICE = 0
        Form1.DataGridView1.Rows.Clear()
    End Sub
End Module
