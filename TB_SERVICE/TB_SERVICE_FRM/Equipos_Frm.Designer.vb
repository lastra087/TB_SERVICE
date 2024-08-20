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
        Me.btn_taller = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grl_grilla = New System.Windows.Forms.DataGridView()
        Me.cbo_marcas = New System.Windows.Forms.ComboBox()
        Me.cbo_modelos = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_fecha_ingreso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_prblema_equipo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_taller
        '
        Me.btn_taller.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_taller.Location = New System.Drawing.Point(460, 69)
        Me.btn_taller.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_taller.Name = "btn_taller"
        Me.btn_taller.Size = New System.Drawing.Size(101, 30)
        Me.btn_taller.TabIndex = 46
        Me.btn_taller.Text = "Ir al Taller.."
        Me.btn_taller.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Location = New System.Drawing.Point(712, 628)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(101, 30)
        Me.btn_limpiar.TabIndex = 34
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.Location = New System.Drawing.Point(604, 628)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(101, 30)
        Me.btn_modificar.TabIndex = 32
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(496, 628)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(101, 30)
        Me.btn_agregar.TabIndex = 30
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Modelo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Marca:"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(163, 97)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.ReadOnly = True
        Me.txt_apellido.Size = New System.Drawing.Size(281, 22)
        Me.txt_apellido.TabIndex = 24
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(163, 69)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.ReadOnly = True
        Me.txt_nombre.Size = New System.Drawing.Size(281, 22)
        Me.txt_nombre.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1177, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "X"
        '
        'grl_grilla
        '
        Me.grl_grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grl_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_grilla.Location = New System.Drawing.Point(116, 662)
        Me.grl_grilla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grl_grilla.Name = "grl_grilla"
        Me.grl_grilla.RowTemplate.Height = 24
        Me.grl_grilla.Size = New System.Drawing.Size(1029, 38)
        Me.grl_grilla.TabIndex = 19
        '
        'cbo_marcas
        '
        Me.cbo_marcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_marcas.FormattingEnabled = True
        Me.cbo_marcas.Location = New System.Drawing.Point(164, 175)
        Me.cbo_marcas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_marcas.Name = "cbo_marcas"
        Me.cbo_marcas.Size = New System.Drawing.Size(281, 24)
        Me.cbo_marcas.TabIndex = 44
        '
        'cbo_modelos
        '
        Me.cbo_modelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_modelos.FormattingEnabled = True
        Me.cbo_modelos.Location = New System.Drawing.Point(164, 204)
        Me.cbo_modelos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_modelos.Name = "cbo_modelos"
        Me.cbo_modelos.Size = New System.Drawing.Size(281, 24)
        Me.cbo_modelos.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(460, 175)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 25)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_fecha_ingreso
        '
        Me.txt_fecha_ingreso.Location = New System.Drawing.Point(164, 123)
        Me.txt_fecha_ingreso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_fecha_ingreso.Name = "txt_fecha_ingreso"
        Me.txt_fecha_ingreso.Size = New System.Drawing.Size(281, 22)
        Me.txt_fecha_ingreso.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Fecha de ingreso:"
        '
        'txt_prblema_equipo
        '
        Me.txt_prblema_equipo.Location = New System.Drawing.Point(164, 149)
        Me.txt_prblema_equipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_prblema_equipo.Name = "txt_prblema_equipo"
        Me.txt_prblema_equipo.Size = New System.Drawing.Size(281, 22)
        Me.txt_prblema_equipo.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 17)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Problema reportado:"
        '
        'Equipos_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 727)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_prblema_equipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_fecha_ingreso)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbo_modelos)
        Me.Controls.Add(Me.cbo_marcas)
        Me.Controls.Add(Me.btn_taller)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grl_grilla)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Equipos_Frm"
        Me.Text = "Equipos_Frm"
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_taller As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grl_grilla As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_marcas As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_modelos As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_fecha_ingreso As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_prblema_equipo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
