<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbVentas = New System.Windows.Forms.CheckBox()
        Me.cbCompras = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVentas = New System.Windows.Forms.TextBox()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CompCC = New System.Windows.Forms.RadioButton()
        Me.compEuro = New System.Windows.Forms.RadioButton()
        Me.ComPM = New System.Windows.Forms.RadioButton()
        Me.CompDolar = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.VentaCC = New System.Windows.Forms.RadioButton()
        Me.VentaEuro = New System.Windows.Forms.RadioButton()
        Me.VentaPM = New System.Windows.Forms.RadioButton()
        Me.VentaDolar = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbVentas)
        Me.GroupBox2.Controls.Add(Me.cbCompras)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(53, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 103)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaccion"
        '
        'cbVentas
        '
        Me.cbVentas.AutoSize = True
        Me.cbVentas.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.cbVentas.Location = New System.Drawing.Point(26, 66)
        Me.cbVentas.Name = "cbVentas"
        Me.cbVentas.Size = New System.Drawing.Size(69, 24)
        Me.cbVentas.TabIndex = 1
        Me.cbVentas.Text = "Venta"
        Me.cbVentas.UseVisualStyleBackColor = True
        '
        'cbCompras
        '
        Me.cbCompras.AutoSize = True
        Me.cbCompras.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.cbCompras.Location = New System.Drawing.Point(26, 31)
        Me.cbCompras.Name = "cbCompras"
        Me.cbCompras.Size = New System.Drawing.Size(83, 24)
        Me.cbCompras.TabIndex = 0
        Me.cbCompras.Text = "Compra"
        Me.cbCompras.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtVentas)
        Me.GroupBox1.Controls.Add(Me.txtCompra)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 134)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(32, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(22, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Compra"
        '
        'txtVentas
        '
        Me.txtVentas.BackColor = System.Drawing.Color.White
        Me.txtVentas.Enabled = False
        Me.txtVentas.Location = New System.Drawing.Point(96, 85)
        Me.txtVentas.Name = "txtVentas"
        Me.txtVentas.Size = New System.Drawing.Size(100, 29)
        Me.txtVentas.TabIndex = 1
        '
        'txtCompra
        '
        Me.txtCompra.BackColor = System.Drawing.Color.White
        Me.txtCompra.Enabled = False
        Me.txtCompra.Location = New System.Drawing.Point(96, 40)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(100, 29)
        Me.txtCompra.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CompCC)
        Me.GroupBox3.Controls.Add(Me.compEuro)
        Me.GroupBox3.Controls.Add(Me.ComPM)
        Me.GroupBox3.Controls.Add(Me.CompDolar)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(279, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 145)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Compra"
        '
        'CompCC
        '
        Me.CompCC.AutoSize = True
        Me.CompCC.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.CompCC.Location = New System.Drawing.Point(33, 106)
        Me.CompCC.Name = "CompCC"
        Me.CompCC.Size = New System.Drawing.Size(182, 24)
        Me.CompCC.TabIndex = 3
        Me.CompCC.TabStop = True
        Me.CompCC.Text = "Colones Costarricenses"
        Me.CompCC.UseVisualStyleBackColor = True
        '
        'compEuro
        '
        Me.compEuro.AutoSize = True
        Me.compEuro.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.compEuro.Location = New System.Drawing.Point(33, 81)
        Me.compEuro.Name = "compEuro"
        Me.compEuro.Size = New System.Drawing.Size(58, 24)
        Me.compEuro.TabIndex = 2
        Me.compEuro.TabStop = True
        Me.compEuro.Text = "Euro"
        Me.compEuro.UseVisualStyleBackColor = True
        '
        'ComPM
        '
        Me.ComPM.AutoSize = True
        Me.ComPM.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ComPM.Location = New System.Drawing.Point(33, 56)
        Me.ComPM.Name = "ComPM"
        Me.ComPM.Size = New System.Drawing.Size(140, 24)
        Me.ComPM.TabIndex = 1
        Me.ComPM.TabStop = True
        Me.ComPM.Text = "Pesos Mexicanos"
        Me.ComPM.UseVisualStyleBackColor = True
        '
        'CompDolar
        '
        Me.CompDolar.AutoSize = True
        Me.CompDolar.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.CompDolar.Location = New System.Drawing.Point(33, 31)
        Me.CompDolar.Name = "CompDolar"
        Me.CompDolar.Size = New System.Drawing.Size(65, 24)
        Me.CompDolar.TabIndex = 0
        Me.CompDolar.TabStop = True
        Me.CompDolar.Text = "Dolar"
        Me.CompDolar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.VentaCC)
        Me.GroupBox4.Controls.Add(Me.VentaEuro)
        Me.GroupBox4.Controls.Add(Me.VentaPM)
        Me.GroupBox4.Controls.Add(Me.VentaDolar)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.Location = New System.Drawing.Point(516, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 138)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Venta"
        '
        'VentaCC
        '
        Me.VentaCC.AutoSize = True
        Me.VentaCC.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.VentaCC.Location = New System.Drawing.Point(33, 106)
        Me.VentaCC.Name = "VentaCC"
        Me.VentaCC.Size = New System.Drawing.Size(182, 24)
        Me.VentaCC.TabIndex = 3
        Me.VentaCC.TabStop = True
        Me.VentaCC.Text = "Colones Costarricenses"
        Me.VentaCC.UseVisualStyleBackColor = True
        '
        'VentaEuro
        '
        Me.VentaEuro.AutoSize = True
        Me.VentaEuro.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.VentaEuro.Location = New System.Drawing.Point(33, 81)
        Me.VentaEuro.Name = "VentaEuro"
        Me.VentaEuro.Size = New System.Drawing.Size(58, 24)
        Me.VentaEuro.TabIndex = 2
        Me.VentaEuro.TabStop = True
        Me.VentaEuro.Text = "Euro"
        Me.VentaEuro.UseVisualStyleBackColor = True
        '
        'VentaPM
        '
        Me.VentaPM.AutoSize = True
        Me.VentaPM.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.VentaPM.Location = New System.Drawing.Point(33, 56)
        Me.VentaPM.Name = "VentaPM"
        Me.VentaPM.Size = New System.Drawing.Size(140, 24)
        Me.VentaPM.TabIndex = 1
        Me.VentaPM.TabStop = True
        Me.VentaPM.Text = "Pesos Mexicanos"
        Me.VentaPM.UseVisualStyleBackColor = True
        '
        'VentaDolar
        '
        Me.VentaDolar.AutoSize = True
        Me.VentaDolar.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.VentaDolar.Location = New System.Drawing.Point(33, 31)
        Me.VentaDolar.Name = "VentaDolar"
        Me.VentaDolar.Size = New System.Drawing.Size(65, 24)
        Me.VentaDolar.TabIndex = 0
        Me.VentaDolar.TabStop = True
        Me.VentaDolar.Text = "Dolar"
        Me.VentaDolar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(404, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(295, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(353, 262)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(744, 325)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbVentas As CheckBox
    Friend WithEvents cbCompras As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVentas As TextBox
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CompCC As RadioButton
    Friend WithEvents compEuro As RadioButton
    Friend WithEvents ComPM As RadioButton
    Friend WithEvents CompDolar As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents VentaCC As RadioButton
    Friend WithEvents VentaEuro As RadioButton
    Friend WithEvents VentaPM As RadioButton
    Friend WithEvents VentaDolar As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
