Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "0"
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TOTALMATERIALES = Val(TextBox1.Text)
        If RadioButton1.Checked Then
            If TOTALMATERIALES > 0 Then
                SUMA = ChumpaSmall + (Val(TextBox1.Text) * PMatAlgodon) + (Val(TextBox1.Text) * PMatSeda) + (Val(Cantidad.Text) * PMatLona)
                TextBox3.Text = Val(ChumpaSmall) * TextBox1.Text
                TextBox4.Text = Math.Round((Val(TextBox1.Text) * PMatAlgodon) + (Val(TextBox1.Text) * PMatSeda) + (Val(Cantidad.Text) * PMatLona), 2)
                preciocosto.Text = Math.Round(Val(SUMA) + Val(TextBox2.Text), 2)
                TextBox5.Text = Math.Round(Val(preciocosto.Text) * 0.65 + Val(preciocosto.Text), 2)
            Else
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                RadioButton6.Checked = False
                RadioButton5.Checked = False
                RadioButton4.Checked = False


                SUMA = 0
                TOTALMATERIALES = 0
            End If
        End If


        TOTALMATERIALES = Val(TextBox1.Text)
        If RadioButton2.Checked Then
            If TOTALMATERIALES > 0 Then
                SUMA = ChumpaSmall + (Val(TextBox1.Text) * PMatAlgodon) + (Val(TextBox1.Text) * PMatSeda) + (Val(Cantidad.Text) * PMatLona)
                TextBox3.Text = Val(ChumpaSmall) * TextBox1.Text
                TextBox4.Text = Math.Round((Val(TextBox1.Text) * PMatAlgodon) + (Val(TextBox1.Text) * PMatSeda) + (Val(Cantidad.Text) * PMatLona), 2)
                preciocosto.Text = Math.Round(Val(SUMA) + Val(TextBox2.Text), 2)
                TextBox5.Text = Math.Round(Val(preciocosto.Text) * 0.65 + Val(preciocosto.Text), 2)
            Else
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                RadioButton6.Checked = False
                RadioButton5.Checked = False
                RadioButton4.Checked = False


                SUMA = 0
                TOTALMATERIALES = 0
            End If
        End If

        TOTALMATERIALES = Val(TextBox1.Text)
        If RadioButton1.Checked Then
            If TOTALMATERIALES > 0 Then
                SUMA = ChumpaSmall + (Val(TextBox1.Text) * PMatAlgodon) + (Val(TextBox1.Text) * PMatSeda) + (Val(Cantidad.Text) * PMatLona)
                TextBox3.Text = Val(ChumpaSmall) * TextBox1.Text
                TextBox4.Text = Math.Round((Val(TextBox1.Text) * PMatAlgodon) + (Val(TextBox1.Text) * PMatSeda) + (Val(Cantidad.Text) * PMatLona), 2)
                preciocosto.Text = Math.Round(Val(SUMA) + Val(TextBox2.Text), 2)
                TextBox5.Text = Math.Round(Val(preciocosto.Text) * 0.65 + Val(preciocosto.Text), 2)
            Else
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                RadioButton6.Checked = False
                RadioButton5.Checked = False
                RadioButton4.Checked = False


                SUMA = 0
                TOTALMATERIALES = 0
            End If
        End If


        Dim tamaño As String
        Dim material As String

        If RadioButton1.Checked Then
            tamaño = "small"
        ElseIf RadioButton2.Checked Then
            tamaño = "medium"
        Else
            tamaño = "large"
        End If


        If RadioButton4.Checked Then
            material = "algodon"
        ElseIf RadioButton5.Checked Then
            material = "seda"
        Else
            material = "lona"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class