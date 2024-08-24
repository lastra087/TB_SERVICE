<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipos_Frm
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
        Me.btn_sala_espera = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_cerrar = New System.Windows.Forms.Label()
        Me.cbo_marcas = New System.Windows.Forms.ComboBox()
        Me.cbo_modelos = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_fecha_ingreso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_problema_equipo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_id_cliente = New System.Windows.Forms.Label()
        Me.txt_idcliente = New System.Windows.Forms.TextBox()
        Me.grl_grilla = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_sala_espera
        '
        Me.btn_sala_espera.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sala_espera.Location = New System.Drawing.Point(584, 266)
        Me.btn_sala_espera.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sala_espera.Name = "btn_sala_espera"
        Me.btn_sala_espera.Size = New System.Drawing.Size(98, 24)
        Me.btn_sala_espera.TabIndex = 46
        Me.btn_sala_espera.Text = "Sala de espera"
        Me.btn_sala_espera.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 190)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Modelo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 167)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Marca:"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(164, 91)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.ReadOnly = True
        Me.txt_apellido.Size = New System.Drawing.Size(212, 20)
        Me.txt_apellido.TabIndex = 24
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(164, 67)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(212, 20)
        Me.txt_nombre.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nombre:"
        '
        'lbl_cerrar
        '
        Me.lbl_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_cerrar.AutoSize = True
        Me.lbl_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cerrar.Location = New System.Drawing.Point(872, 9)
        Me.lbl_cerrar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_cerrar.Name = "lbl_cerrar"
        Me.lbl_cerrar.Size = New System.Drawing.Size(21, 20)
        Me.lbl_cerrar.TabIndex = 20
        Me.lbl_cerrar.Text = "X"
        '
        'cbo_marcas
        '
        Me.cbo_marcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_marcas.FormattingEnabled = True
        Me.cbo_marcas.Location = New System.Drawing.Point(164, 162)
        Me.cbo_marcas.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_marcas.Name = "cbo_marcas"
        Me.cbo_marcas.Size = New System.Drawing.Size(212, 21)
        Me.cbo_marcas.TabIndex = 44
        '
        'cbo_modelos
        '
        Me.cbo_modelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_modelos.FormattingEnabled = True
        Me.cbo_modelos.Location = New System.Drawing.Point(164, 187)
        Me.cbo_modelos.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_modelos.Name = "cbo_modelos"
        Me.cbo_modelos.Size = New System.Drawing.Size(212, 21)
        Me.cbo_modelos.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(387, 163)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 20)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_fecha_ingreso
        '
        Me.txt_fecha_ingreso.Location = New System.Drawing.Point(164, 114)
        Me.txt_fecha_ingreso.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fecha_ingreso.Name = "txt_fecha_ingreso"
        Me.txt_fecha_ingreso.Size = New System.Drawing.Size(212, 20)
        Me.txt_fecha_ingreso.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 117)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Fecha de ingreso:"
        '
        'txt_problema_equipo
        '
        Me.txt_problema_equipo.Location = New System.Drawing.Point(164, 137)
        Me.txt_problema_equipo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_problema_equipo.Name = "txt_problema_equipo"
        Me.txt_problema_equipo.Size = New System.Drawing.Size(212, 20)
        Me.txt_problema_equipo.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 140)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Problema reportado:"
        '
        'lbl_id_cliente
        '
        Me.lbl_id_cliente.AutoSize = True
        Me.lbl_id_cliente.Location = New System.Drawing.Point(106, 46)
        Me.lbl_id_cliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id_cliente.Name = "lbl_id_cliente"
        Me.lbl_id_cliente.Size = New System.Drawing.Size(54, 13)
        Me.lbl_id_cliente.TabIndex = 47
        Me.lbl_id_cliente.Text = "Id Cliente:"
        '
        'txt_idcliente
        '
        Me.txt_idcliente.Location = New System.Drawing.Point(164, 43)
        Me.txt_idcliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_idcliente.Name = "txt_idcliente"
        Me.txt_idcliente.ReadOnly = True
        Me.txt_idcliente.Size = New System.Drawing.Size(213, 20)
        Me.txt_idcliente.TabIndex = 48
        '
        'grl_grilla
        '
        Me.grl_grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grl_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_grilla.Location = New System.Drawing.Point(164, 294)
        Me.grl_grilla.Margin = New System.Windows.Forms.Padding(2)
        Me.grl_grilla.Name = "grl_grilla"
        Me.grl_grilla.RowTemplate.Height = 24
        Me.grl_grilla.Size = New System.Drawing.Size(518, 171)
        Me.grl_grilla.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(162, 274)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 18)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Sala de Espera"
        '
        'Equipos_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 591)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grl_grilla)
        Me.Controls.Add(Me.txt_idcliente)
        Me.Controls.Add(Me.lbl_id_cliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_problema_equipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_fecha_ingreso)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbo_modelos)
        Me.Controls.Add(Me.cbo_marcas)
        Me.Controls.Add(Me.btn_sala_espera)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_cerrar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Equipos_Frm"
        Me.Text = "Equipos_Frm"
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_sala_espera As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_cerrar As System.Windows.Forms.Label
    Friend WithEvents cbo_marcas As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_modelos As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_fecha_ingreso As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_problema_equipo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_id_cliente As System.Windows.Forms.Label
    Friend WithEvents txt_idcliente As System.Windows.Forms.TextBox
    Friend WithEvents grl_grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
