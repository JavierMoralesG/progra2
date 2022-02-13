Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub cbCompras_CheckedChanged(sender As Object, e As EventArgs) Handles cbCompras.CheckedChanged
        If cbCompras.Checked = True Then
            txtCompra.Enabled = True
        Else
            txtCompra.Enabled = False
        End If
    End Sub

    Private Sub cbVentas_CheckedChanged(sender As Object, e As EventArgs) Handles cbVentas.CheckedChanged
        If cbVentas.Checked = True Then
            txtVentas.Enabled = True
        Else
            txtVentas.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtCompra.Clear()
        txtCompra.Focus()
    End Sub
End Class
