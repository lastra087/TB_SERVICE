<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Taller_Frm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_categorias = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_horasreparacion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_total_final = New System.Windows.Forms.TextBox()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_calcular_total = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_fecha_ingreso = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dgv_repuestos = New System.Windows.Forms.DataGridView()
        Me.btn_agregar_reparacion = New System.Windows.Forms.Button()
        Me.txt_total_repuesto = New System.Windows.Forms.TextBox()
        Me.lbl_total_repuesto = New System.Windows.Forms.Label()
        Me.grb_repuestos = New System.Windows.Forms.GroupBox()
        Me.lbl_precio_hora = New System.Windows.Forms.Label()
        Me.txt_valor_hs = New System.Windows.Forms.TextBox()
        Me.lbl_total_reparacion = New System.Windows.Forms.Label()
        Me.txt_total_reparacion = New System.Windows.Forms.TextBox()
        Me.lbl_problemareportado = New System.Windows.Forms.Label()
        Me.txt_problema_reportado = New System.Windows.Forms.TextBox()
        Me.lbl_cerrar = New System.Windows.Forms.Label()
        Me.lbl_taller = New System.Windows.Forms.Label()
        CType(Me.dgv_repuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_repuestos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diagnóstico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Repuestos provisto por:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Repuesto:"
        '
        'txt_diagnostico
        '
        Me.txt_diagnostico.Location = New System.Drawing.Point(272, 183)
        Me.txt_diagnostico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_diagnostico.Name = "txt_diagnostico"
        Me.txt_diagnostico.Size = New System.Drawing.Size(421, 22)
        Me.txt_diagnostico.TabIndex = 7
        '
        'cbo_repuestos
        '
        Me.cbo_repuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_repuestos.FormattingEnabled = True
        Me.cbo_repuestos.Location = New System.Drawing.Point(91, 22)
        Me.cbo_repuestos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_repuestos.Name = "cbo_repuestos"
        Me.cbo_repuestos.Size = New System.Drawing.Size(463, 24)
        Me.cbo_repuestos.TabIndex = 11
        '
        'rdb_taller
        '
        Me.rdb_taller.AutoSize = True
        Me.rdb_taller.Checked = True
        Me.rdb_taller.Location = New System.Drawing.Point(273, 274)
        Me.rdb_taller.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.rdb_cliente.Location = New System.Drawing.Point(423, 274)
        Me.rdb_cliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdb_cliente.Name = "rdb_cliente"
        Me.rdb_cliente.Size = New System.Drawing.Size(72, 21)
        Me.rdb_cliente.TabIndex = 13
        Me.rdb_cliente.Text = "Cliente"
        Me.rdb_cliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 214)
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
        Me.cbo_categorias.Location = New System.Drawing.Point(272, 212)
        Me.cbo_categorias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_categorias.Name = "cbo_categorias"
        Me.cbo_categorias.Size = New System.Drawing.Size(121, 24)
        Me.cbo_categorias.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Tiempo de reparación(hs):"
        '
        'cbo_horasreparacion
        '
        Me.cbo_horasreparacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_horasreparacion.FormattingEnabled = True
        Me.cbo_horasreparacion.Location = New System.Drawing.Point(272, 244)
        Me.cbo_horasreparacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_horasreparacion.Name = "cbo_horasreparacion"
        Me.cbo_horasreparacion.Size = New System.Drawing.Size(121, 24)
        Me.cbo_horasreparacion.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(193, 588)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Total final:"
        '
        'txt_total_final
        '
        Me.txt_total_final.Location = New System.Drawing.Point(273, 584)
        Me.txt_total_final.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_total_final.Name = "txt_total_final"
        Me.txt_total_final.Size = New System.Drawing.Size(421, 22)
        Me.txt_total_final.TabIndex = 21
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(271, 58)
        Me.txt_marca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(421, 22)
        Me.txt_marca.TabIndex = 24
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(271, 86)
        Me.txt_modelo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(421, 22)
        Me.txt_modelo.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(137, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Modelo del equipo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(144, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Marca del equipo:"
        '
        'btn_calcular_total
        '
        Me.btn_calcular_total.Location = New System.Drawing.Point(273, 544)
        Me.btn_calcular_total.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_calcular_total.Name = "btn_calcular_total"
        Me.btn_calcular_total.Size = New System.Drawing.Size(144, 34)
        Me.btn_calcular_total.TabIndex = 29
        Me.btn_calcular_total.Text = "Calcular"
        Me.btn_calcular_total.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(144, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 17)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Fecha de ingreso:"
        '
        'txt_fecha_ingreso
        '
        Me.txt_fecha_ingreso.Location = New System.Drawing.Point(272, 150)
        Me.txt_fecha_ingreso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_fecha_ingreso.Name = "txt_fecha_ingreso"
        Me.txt_fecha_ingreso.Size = New System.Drawing.Size(97, 22)
        Me.txt_fecha_ingreso.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(465, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 17)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Fecha de entrega:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(595, 150)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 22)
        Me.DateTimePicker1.TabIndex = 39
        '
        'dgv_repuestos
        '
        Me.dgv_repuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_repuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_repuestos.Location = New System.Drawing.Point(91, 54)
        Me.dgv_repuestos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_repuestos.Name = "dgv_repuestos"
        Me.dgv_repuestos.Size = New System.Drawing.Size(572, 124)
        Me.dgv_repuestos.TabIndex = 40
        '
        'btn_agregar_reparacion
        '
        Me.btn_agregar_reparacion.Location = New System.Drawing.Point(563, 22)
        Me.btn_agregar_reparacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_agregar_reparacion.Name = "btn_agregar_reparacion"
        Me.btn_agregar_reparacion.Size = New System.Drawing.Size(100, 26)
        Me.btn_agregar_reparacion.TabIndex = 42
        Me.btn_agregar_reparacion.Text = "Agregar"
        Me.btn_agregar_reparacion.UseVisualStyleBackColor = True
        '
        'txt_total_repuesto
        '
        Me.txt_total_repuesto.Location = New System.Drawing.Point(91, 186)
        Me.txt_total_repuesto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_total_repuesto.Name = "txt_total_repuesto"
        Me.txt_total_repuesto.Size = New System.Drawing.Size(93, 22)
        Me.txt_total_repuesto.TabIndex = 43
        '
        'lbl_total_repuesto
        '
        Me.lbl_total_repuesto.AutoSize = True
        Me.lbl_total_repuesto.Location = New System.Drawing.Point(41, 190)
        Me.lbl_total_repuesto.Name = "lbl_total_repuesto"
        Me.lbl_total_repuesto.Size = New System.Drawing.Size(44, 17)
        Me.lbl_total_repuesto.TabIndex = 44
        Me.lbl_total_repuesto.Text = "Total:"
        '
        'grb_repuestos
        '
        Me.grb_repuestos.Controls.Add(Me.dgv_repuestos)
        Me.grb_repuestos.Controls.Add(Me.lbl_total_repuesto)
        Me.grb_repuestos.Controls.Add(Me.Label4)
        Me.grb_repuestos.Controls.Add(Me.txt_total_repuesto)
        Me.grb_repuestos.Controls.Add(Me.cbo_repuestos)
        Me.grb_repuestos.Controls.Add(Me.btn_agregar_reparacion)
        Me.grb_repuestos.Location = New System.Drawing.Point(272, 314)
        Me.grb_repuestos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grb_repuestos.Name = "grb_repuestos"
        Me.grb_repuestos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grb_repuestos.Size = New System.Drawing.Size(704, 224)
        Me.grb_repuestos.TabIndex = 45
        Me.grb_repuestos.TabStop = False
        Me.grb_repuestos.Text = "Seleccione un repuesto "
        '
        'lbl_precio_hora
        '
        Me.lbl_precio_hora.AutoSize = True
        Me.lbl_precio_hora.Location = New System.Drawing.Point(400, 215)
        Me.lbl_precio_hora.Name = "lbl_precio_hora"
        Me.lbl_precio_hora.Size = New System.Drawing.Size(74, 17)
        Me.lbl_precio_hora.TabIndex = 46
        Me.lbl_precio_hora.Text = "Valor (hs):"
        '
        'txt_valor_hs
        '
        Me.txt_valor_hs.Location = New System.Drawing.Point(479, 212)
        Me.txt_valor_hs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_valor_hs.Name = "txt_valor_hs"
        Me.txt_valor_hs.Size = New System.Drawing.Size(93, 22)
        Me.txt_valor_hs.TabIndex = 45
        '
        'lbl_total_reparacion
        '
        Me.lbl_total_reparacion.AutoSize = True
        Me.lbl_total_reparacion.Location = New System.Drawing.Point(400, 247)
        Me.lbl_total_reparacion.Name = "lbl_total_reparacion"
        Me.lbl_total_reparacion.Size = New System.Drawing.Size(44, 17)
        Me.lbl_total_reparacion.TabIndex = 47
        Me.lbl_total_reparacion.Text = "Total:"
        '
        'txt_total_reparacion
        '
        Me.txt_total_reparacion.Location = New System.Drawing.Point(479, 244)
        Me.txt_total_reparacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_total_reparacion.Name = "txt_total_reparacion"
        Me.txt_total_reparacion.Size = New System.Drawing.Size(93, 22)
        Me.txt_total_reparacion.TabIndex = 48
        '
        'lbl_problemareportado
        '
        Me.lbl_problemareportado.AutoSize = True
        Me.lbl_problemareportado.Location = New System.Drawing.Point(127, 119)
        Me.lbl_problemareportado.Name = "lbl_problemareportado"
        Me.lbl_problemareportado.Size = New System.Drawing.Size(143, 17)
        Me.lbl_problemareportado.TabIndex = 50
        Me.lbl_problemareportado.Text = "Problema Reportado:"
        '
        'txt_problema_reportado
        '
        Me.txt_problema_reportado.Location = New System.Drawing.Point(271, 116)
        Me.txt_problema_reportado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_problema_reportado.Name = "txt_problema_reportado"
        Me.txt_problema_reportado.Size = New System.Drawing.Size(421, 22)
        Me.txt_problema_reportado.TabIndex = 49
        '
        'lbl_cerrar
        '
        Me.lbl_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_cerrar.AutoSize = True
        Me.lbl_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cerrar.Location = New System.Drawing.Point(1163, 11)
        Me.lbl_cerrar.Name = "lbl_cerrar"
        Me.lbl_cerrar.Size = New System.Drawing.Size(27, 25)
        Me.lbl_cerrar.TabIndex = 51
        Me.lbl_cerrar.Text = "X"
        '
        'lbl_taller
        '
        Me.lbl_taller.AutoSize = True
        Me.lbl_taller.Location = New System.Drawing.Point(16, 11)
        Me.lbl_taller.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_taller.Name = "lbl_taller"
        Me.lbl_taller.Size = New System.Drawing.Size(44, 17)
        Me.lbl_taller.TabIndex = 54
        Me.lbl_taller.Text = "Taller"
        '
        'Taller_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 727)
        Me.Controls.Add(Me.lbl_taller)
        Me.Controls.Add(Me.lbl_cerrar)
        Me.Controls.Add(Me.lbl_problemareportado)
        Me.Controls.Add(Me.txt_problema_reportado)
        Me.Controls.Add(Me.txt_total_reparacion)
        Me.Controls.Add(Me.lbl_total_reparacion)
        Me.Controls.Add(Me.txt_valor_hs)
        Me.Controls.Add(Me.lbl_precio_hora)
        Me.Controls.Add(Me.grb_repuestos)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_fecha_ingreso)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_calcular_total)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_modelo)
        Me.Controls.Add(Me.txt_marca)
        Me.Controls.Add(Me.txt_total_final)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbo_horasreparacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbo_categorias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdb_cliente)
        Me.Controls.Add(Me.rdb_taller)
        Me.Controls.Add(Me.txt_diagnostico)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Taller_Frm"
        Me.Text = "Taller_Frm"
        CType(Me.dgv_repuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_repuestos.ResumeLayout(False)
        Me.grb_repuestos.PerformLayout()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_categorias As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbo_horasreparacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_total_final As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_calcular_total As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv_repuestos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_agregar_reparacion As System.Windows.Forms.Button
    Friend WithEvents txt_total_repuesto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_total_repuesto As System.Windows.Forms.Label
    Friend WithEvents grb_repuestos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_precio_hora As System.Windows.Forms.Label
    Friend WithEvents txt_valor_hs As System.Windows.Forms.TextBox
    Friend WithEvents lbl_total_reparacion As System.Windows.Forms.Label
    Friend WithEvents txt_total_reparacion As System.Windows.Forms.TextBox
    Public WithEvents txt_marca As System.Windows.Forms.TextBox
    Public WithEvents txt_modelo As System.Windows.Forms.TextBox
    Public WithEvents txt_fecha_ingreso As System.Windows.Forms.TextBox
    Friend WithEvents lbl_problemareportado As System.Windows.Forms.Label
    Public WithEvents txt_problema_reportado As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cerrar As System.Windows.Forms.Label
    Friend WithEvents lbl_taller As System.Windows.Forms.Label
End Class
