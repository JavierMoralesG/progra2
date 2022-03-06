Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        ComboBox1.Text = ""

        ListBox1.ClearSelected()
        ListBox2.ClearSelected()


        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text <> "") Then
            Nombre = TextBox2.Text
        Else
            MsgBox("Error no ingreso datos")
            TextBox1.Focus() : Exit Sub
        End If
        If (TextBox2.Text <> "") Then
            Nit = TextBox2.Text
        Else
            MsgBox("Debe ingresar número de NIT")
            TextBox2.Focus() : Exit Sub
        End If
        If (TextBox3.Text <> "") Then
            numerodedias = TextBox3.Text
        Else
            MsgBox("Debe ingresar el saldo anterior")
            TextBox3.Focus() : Exit Sub
        End If
        If (TextBox4.Text <> "") Then
            Honorarios = TextBox4.Text
        Else
            MsgBox("Debe ingresar honorarios")
            TextBox4.Focus() : Exit Sub
        End If
        If (tipodedehabitacion(ComboBox1.Text) And Val(ComboBox1.Text) > 0) Then
            ComboBox1 = Val(ListBox3.Text)
        Else
            MsgBox("Elija una habitacion")
            ComboBox1.Focus() : Exit Sub

        End If
    End Sub
End Class
