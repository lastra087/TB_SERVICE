<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores_Frm
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
        Me.lbl_razon_social = New System.Windows.Forms.Label()
        Me.lbl_direccion = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_cuit = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_cuit = New System.Windows.Forms.TextBox()
        Me.txt_razon_social = New System.Windows.Forms.TextBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.grl_grilla = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_mostrar_tabla = New System.Windows.Forms.Button()
        Me.lbl_cerrar = New System.Windows.Forms.Label()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.txt_buscar_proveedor = New System.Windows.Forms.TextBox()
        Me.lbl_proveedores = New System.Windows.Forms.Label()
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_razon_social
        '
        Me.lbl_razon_social.AutoSize = True
        Me.lbl_razon_social.Location = New System.Drawing.Point(67, 87)
        Me.lbl_razon_social.Name = "lbl_razon_social"
        Me.lbl_razon_social.Size = New System.Drawing.Size(73, 13)
        Me.lbl_razon_social.TabIndex = 0
        Me.lbl_razon_social.Text = "Razon Social:"
        '
        'lbl_direccion
        '
        Me.lbl_direccion.AutoSize = True
        Me.lbl_direccion.Location = New System.Drawing.Point(85, 165)
        Me.lbl_direccion.Name = "lbl_direccion"
        Me.lbl_direccion.Size = New System.Drawing.Size(55, 13)
        Me.lbl_direccion.TabIndex = 1
        Me.lbl_direccion.Text = "Direccion:"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(88, 139)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefono.TabIndex = 2
        Me.lbl_telefono.Text = "Telefono:"
        '
        'lbl_cuit
        '
        Me.lbl_cuit.AutoSize = True
        Me.lbl_cuit.Location = New System.Drawing.Point(112, 113)
        Me.lbl_cuit.Name = "lbl_cuit"
        Me.lbl_cuit.Size = New System.Drawing.Size(28, 13)
        Me.lbl_cuit.TabIndex = 3
        Me.lbl_cuit.Text = "Cuit:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(119, 61)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(21, 13)
        Me.lbl_id.TabIndex = 5
        Me.lbl_id.Text = "ID:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(146, 58)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(36, 20)
        Me.txt_id.TabIndex = 6
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(146, 162)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(212, 20)
        Me.txt_direccion.TabIndex = 7
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(146, 136)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(212, 20)
        Me.txt_telefono.TabIndex = 8
        '
        'txt_cuit
        '
        Me.txt_cuit.Location = New System.Drawing.Point(146, 110)
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(212, 20)
        Me.txt_cuit.TabIndex = 9
        '
        'txt_razon_social
        '
        Me.txt_razon_social.Location = New System.Drawing.Point(146, 84)
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(212, 20)
        Me.txt_razon_social.TabIndex = 11
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(306, 204)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(76, 24)
        Me.btn_eliminar.TabIndex = 14
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(226, 204)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(76, 24)
        Me.btn_modificar.TabIndex = 13
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(146, 204)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(76, 24)
        Me.btn_agregar.TabIndex = 12
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'grl_grilla
        '
        Me.grl_grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grl_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_grilla.Location = New System.Drawing.Point(146, 284)
        Me.grl_grilla.Margin = New System.Windows.Forms.Padding(2)
        Me.grl_grilla.Name = "grl_grilla"
        Me.grl_grilla.RowTemplate.Height = 24
        Me.grl_grilla.Size = New System.Drawing.Size(588, 164)
        Me.grl_grilla.TabIndex = 15
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(386, 253)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(76, 24)
        Me.btn_buscar.TabIndex = 16
        Me.btn_buscar.Text = "Buscar "
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_mostrar_tabla
        '
        Me.btn_mostrar_tabla.Location = New System.Drawing.Point(643, 256)
        Me.btn_mostrar_tabla.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_mostrar_tabla.Name = "btn_mostrar_tabla"
        Me.btn_mostrar_tabla.Size = New System.Drawing.Size(91, 24)
        Me.btn_mostrar_tabla.TabIndex = 17
        Me.btn_mostrar_tabla.Text = "Mostrar Todo"
        Me.btn_mostrar_tabla.UseVisualStyleBackColor = True
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
        Me.lbl_cerrar.TabIndex = 18
        Me.lbl_cerrar.Text = "X"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(386, 204)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(76, 24)
        Me.btn_limpiar.TabIndex = 19
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'txt_buscar_proveedor
        '
        Me.txt_buscar_proveedor.Location = New System.Drawing.Point(146, 256)
        Me.txt_buscar_proveedor.Name = "txt_buscar_proveedor"
        Me.txt_buscar_proveedor.Size = New System.Drawing.Size(236, 20)
        Me.txt_buscar_proveedor.TabIndex = 44
        '
        'lbl_proveedores
        '
        Me.lbl_proveedores.AutoSize = True
        Me.lbl_proveedores.Location = New System.Drawing.Point(12, 9)
        Me.lbl_proveedores.Name = "lbl_proveedores"
        Me.lbl_proveedores.Size = New System.Drawing.Size(67, 13)
        Me.lbl_proveedores.TabIndex = 49
        Me.lbl_proveedores.Text = "Proveedores"
        '
        'Proveedores_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 553)
        Me.Controls.Add(Me.lbl_proveedores)
        Me.Controls.Add(Me.txt_buscar_proveedor)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.lbl_cerrar)
        Me.Controls.Add(Me.btn_mostrar_tabla)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.grl_grilla)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.txt_razon_social)
        Me.Controls.Add(Me.txt_cuit)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_cuit)
        Me.Controls.Add(Me.lbl_telefono)
        Me.Controls.Add(Me.lbl_direccion)
        Me.Controls.Add(Me.lbl_razon_social)
        Me.Name = "Proveedores_Frm"
        Me.Text = "Proveedores"
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_razon_social As System.Windows.Forms.Label
    Friend WithEvents lbl_direccion As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_cuit As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_cuit As System.Windows.Forms.TextBox
    Friend WithEvents txt_razon_social As System.Windows.Forms.TextBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents grl_grilla As System.Windows.Forms.DataGridView
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_mostrar_tabla As System.Windows.Forms.Button
    Friend WithEvents lbl_cerrar As System.Windows.Forms.Label
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents txt_buscar_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_proveedores As System.Windows.Forms.Label
End Class
