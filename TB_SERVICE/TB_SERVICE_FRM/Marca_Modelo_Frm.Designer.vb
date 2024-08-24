<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marca_Modelo_Frm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_modelo = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.cbo_marca = New System.Windows.Forms.ComboBox()
        Me.grl_grilla = New System.Windows.Forms.DataGridView()
        Me.btn_marcanueva = New System.Windows.Forms.Button()
        Me.btn_guardarmarca = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_eliminar_marca = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_mostrar_tabla = New System.Windows.Forms.Button()
        Me.lbl_equipos = New System.Windows.Forms.Label()
        Me.lbl_cerrar = New System.Windows.Forms.Label()
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marca:"
        '
        'lbl_modelo
        '
        Me.lbl_modelo.AutoSize = True
        Me.lbl_modelo.Location = New System.Drawing.Point(105, 129)
        Me.lbl_modelo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_modelo.Name = "lbl_modelo"
        Me.lbl_modelo.Size = New System.Drawing.Size(45, 13)
        Me.lbl_modelo.TabIndex = 1
        Me.lbl_modelo.Text = "Modelo:"
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(154, 161)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(76, 24)
        Me.btn_agregar.TabIndex = 12
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(234, 161)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(76, 24)
        Me.btn_modificar.TabIndex = 13
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(314, 161)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(76, 24)
        Me.btn_eliminar.TabIndex = 14
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(154, 55)
        Me.txt_marca.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(212, 20)
        Me.txt_marca.TabIndex = 8
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(154, 126)
        Me.txt_modelo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(212, 20)
        Me.txt_modelo.TabIndex = 11
        '
        'cbo_marca
        '
        Me.cbo_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_marca.FormattingEnabled = True
        Me.cbo_marca.Location = New System.Drawing.Point(154, 54)
        Me.cbo_marca.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_marca.Name = "cbo_marca"
        Me.cbo_marca.Size = New System.Drawing.Size(212, 21)
        Me.cbo_marca.TabIndex = 9
        '
        'grl_grilla
        '
        Me.grl_grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grl_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_grilla.Location = New System.Drawing.Point(154, 244)
        Me.grl_grilla.Margin = New System.Windows.Forms.Padding(2)
        Me.grl_grilla.Name = "grl_grilla"
        Me.grl_grilla.ReadOnly = True
        Me.grl_grilla.RowTemplate.Height = 24
        Me.grl_grilla.Size = New System.Drawing.Size(524, 245)
        Me.grl_grilla.TabIndex = 11
        '
        'btn_marcanueva
        '
        Me.btn_marcanueva.Location = New System.Drawing.Point(403, 52)
        Me.btn_marcanueva.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_marcanueva.Name = "btn_marcanueva"
        Me.btn_marcanueva.Size = New System.Drawing.Size(76, 24)
        Me.btn_marcanueva.TabIndex = 10
        Me.btn_marcanueva.Text = "Marcas..."
        Me.btn_marcanueva.UseVisualStyleBackColor = True
        '
        'btn_guardarmarca
        '
        Me.btn_guardarmarca.Location = New System.Drawing.Point(154, 88)
        Me.btn_guardarmarca.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_guardarmarca.Name = "btn_guardarmarca"
        Me.btn_guardarmarca.Size = New System.Drawing.Size(76, 24)
        Me.btn_guardarmarca.TabIndex = 15
        Me.btn_guardarmarca.Text = "Guardar"
        Me.btn_guardarmarca.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(312, 88)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(76, 24)
        Me.btn_cancelar.TabIndex = 16
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(394, 161)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(76, 24)
        Me.btn_limpiar.TabIndex = 17
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_eliminar_marca
        '
        Me.btn_eliminar_marca.Location = New System.Drawing.Point(232, 88)
        Me.btn_eliminar_marca.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_eliminar_marca.Name = "btn_eliminar_marca"
        Me.btn_eliminar_marca.Size = New System.Drawing.Size(76, 24)
        Me.btn_eliminar_marca.TabIndex = 18
        Me.btn_eliminar_marca.Text = "Eliminar"
        Me.btn_eliminar_marca.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(154, 220)
        Me.txt_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(212, 20)
        Me.txt_buscar.TabIndex = 19
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(370, 217)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(76, 24)
        Me.btn_buscar.TabIndex = 20
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_mostrar_tabla
        '
        Me.btn_mostrar_tabla.Location = New System.Drawing.Point(587, 217)
        Me.btn_mostrar_tabla.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_mostrar_tabla.Name = "btn_mostrar_tabla"
        Me.btn_mostrar_tabla.Size = New System.Drawing.Size(91, 24)
        Me.btn_mostrar_tabla.TabIndex = 21
        Me.btn_mostrar_tabla.Text = "Mostrar Todo"
        Me.btn_mostrar_tabla.UseVisualStyleBackColor = True
        '
        'lbl_equipos
        '
        Me.lbl_equipos.AutoSize = True
        Me.lbl_equipos.Location = New System.Drawing.Point(12, 9)
        Me.lbl_equipos.Name = "lbl_equipos"
        Me.lbl_equipos.Size = New System.Drawing.Size(45, 13)
        Me.lbl_equipos.TabIndex = 50
        Me.lbl_equipos.Text = "Equipos"
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
        Me.lbl_cerrar.TabIndex = 55
        Me.lbl_cerrar.Text = "X"
        '
        'Marca_Modelo_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 553)
        Me.Controls.Add(Me.lbl_cerrar)
        Me.Controls.Add(Me.lbl_equipos)
        Me.Controls.Add(Me.btn_mostrar_tabla)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.btn_eliminar_marca)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardarmarca)
        Me.Controls.Add(Me.btn_marcanueva)
        Me.Controls.Add(Me.grl_grilla)
        Me.Controls.Add(Me.cbo_marca)
        Me.Controls.Add(Me.txt_modelo)
        Me.Controls.Add(Me.txt_marca)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.lbl_modelo)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Marca_Modelo_Frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marca x Modelo"
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_modelo As System.Windows.Forms.Label
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents txt_marca As System.Windows.Forms.TextBox
    Friend WithEvents txt_modelo As System.Windows.Forms.TextBox
    Friend WithEvents cbo_marca As System.Windows.Forms.ComboBox
    Friend WithEvents grl_grilla As System.Windows.Forms.DataGridView
    Friend WithEvents btn_marcanueva As System.Windows.Forms.Button
    Friend WithEvents btn_guardarmarca As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar_marca As System.Windows.Forms.Button
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_mostrar_tabla As System.Windows.Forms.Button
    Friend WithEvents lbl_equipos As System.Windows.Forms.Label
    Friend WithEvents lbl_cerrar As System.Windows.Forms.Label
End Class
