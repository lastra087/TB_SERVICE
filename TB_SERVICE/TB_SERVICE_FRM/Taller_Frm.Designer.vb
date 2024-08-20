<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chk_cliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_diagnostico = New System.Windows.Forms.TextBox()
        Me.cbo_repuestos = New System.Windows.Forms.ComboBox()
        Me.rdb_taller = New System.Windows.Forms.RadioButton()
        Me.rdb_cliente = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_categorias = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_horasreparacion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_preciofinal = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_cantrepuestos = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_fecha_ingreso = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diagnóstico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Repuestos provisto por:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(193, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Repuesto:"
        '
        'txt_diagnostico
        '
        Me.txt_diagnostico.Location = New System.Drawing.Point(272, 201)
        Me.txt_diagnostico.Name = "txt_diagnostico"
        Me.txt_diagnostico.Size = New System.Drawing.Size(421, 22)
        Me.txt_diagnostico.TabIndex = 7
        '
        'cbo_repuestos
        '
        Me.cbo_repuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_repuestos.FormattingEnabled = True
        Me.cbo_repuestos.Location = New System.Drawing.Point(272, 259)
        Me.cbo_repuestos.Name = "cbo_repuestos"
        Me.cbo_repuestos.Size = New System.Drawing.Size(421, 24)
        Me.cbo_repuestos.TabIndex = 11
        '
        'rdb_taller
        '
        Me.rdb_taller.AutoSize = True
        Me.rdb_taller.Checked = True
        Me.rdb_taller.Location = New System.Drawing.Point(272, 326)
        Me.rdb_taller.Name = "rdb_taller"
        Me.rdb_taller.Size = New System.Drawing.Size(98, 21)
        Me.rdb_taller.TabIndex = 12
        Me.rdb_taller.TabStop = True
        Me.rdb_taller.Text = "TB Service"
        Me.rdb_taller.UseVisualStyleBackColor = True
        '
        'rdb_cliente
        '
        Me.rdb_cliente.AutoSize = True
        Me.rdb_cliente.Location = New System.Drawing.Point(422, 326)
        Me.rdb_cliente.Name = "rdb_cliente"
        Me.rdb_cliente.Size = New System.Drawing.Size(72, 21)
        Me.rdb_cliente.TabIndex = 13
        Me.rdb_cliente.Text = "Cliente"
        Me.rdb_cliente.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(699, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Categoría de reparación:"
        '
        'cbo_categorias
        '
        Me.cbo_categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_categorias.FormattingEnabled = True
        Me.cbo_categorias.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cbo_categorias.Location = New System.Drawing.Point(272, 229)
        Me.cbo_categorias.Name = "cbo_categorias"
        Me.cbo_categorias.Size = New System.Drawing.Size(121, 24)
        Me.cbo_categorias.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Tiempo de reparación(hs):"
        '
        'cbo_horasreparacion
        '
        Me.cbo_horasreparacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_horasreparacion.FormattingEnabled = True
        Me.cbo_horasreparacion.Location = New System.Drawing.Point(272, 356)
        Me.cbo_horasreparacion.Name = "cbo_horasreparacion"
        Me.cbo_horasreparacion.Size = New System.Drawing.Size(121, 24)
        Me.cbo_horasreparacion.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(191, 585)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Valor final:"
        '
        'txt_preciofinal
        '
        Me.txt_preciofinal.Location = New System.Drawing.Point(272, 582)
        Me.txt_preciofinal.Name = "txt_preciofinal"
        Me.txt_preciofinal.Size = New System.Drawing.Size(421, 22)
        Me.txt_preciofinal.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(699, 582)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "PDF "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(699, 226)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 23)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(272, 110)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(421, 22)
        Me.txt_marca.TabIndex = 24
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(272, 138)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(421, 22)
        Me.txt_modelo.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(138, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Modelo del equipo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(145, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Marca del equipo:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(183, 426)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 35)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = "Calcular"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(360, 426)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 35)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(536, 426)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(144, 35)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(198, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Cantidad:"
        '
        'cbo_cantrepuestos
        '
        Me.cbo_cantrepuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cantrepuestos.FormattingEnabled = True
        Me.cbo_cantrepuestos.Location = New System.Drawing.Point(272, 290)
        Me.cbo_cantrepuestos.Name = "cbo_cantrepuestos"
        Me.cbo_cantrepuestos.Size = New System.Drawing.Size(121, 24)
        Me.cbo_cantrepuestos.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(144, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 17)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Fecha de ingreso:"
        '
        'txt_fecha_ingreso
        '
        Me.txt_fecha_ingreso.Location = New System.Drawing.Point(272, 168)
        Me.txt_fecha_ingreso.Name = "txt_fecha_ingreso"
        Me.txt_fecha_ingreso.Size = New System.Drawing.Size(98, 22)
        Me.txt_fecha_ingreso.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(465, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 17)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Fecha de entrega:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(595, 168)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 22)
        Me.DateTimePicker1.TabIndex = 39
        '
        'chk_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 726)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_fecha_ingreso)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbo_cantrepuestos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_modelo)
        Me.Controls.Add(Me.txt_marca)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_preciofinal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbo_horasreparacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbo_categorias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rdb_cliente)
        Me.Controls.Add(Me.rdb_taller)
        Me.Controls.Add(Me.cbo_repuestos)
        Me.Controls.Add(Me.txt_diagnostico)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "chk_cliente"
        Me.Text = "Taller_Frm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_diagnostico As System.Windows.Forms.TextBox
    Friend WithEvents cbo_repuestos As System.Windows.Forms.ComboBox
    Friend WithEvents rdb_taller As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_cliente As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_categorias As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbo_horasreparacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_preciofinal As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt_marca As System.Windows.Forms.TextBox
    Friend WithEvents txt_modelo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbo_cantrepuestos As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_ingreso As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
