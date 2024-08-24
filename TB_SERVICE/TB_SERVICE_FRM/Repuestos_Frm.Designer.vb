<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Repuestos_Frm
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
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_mostrar_todo = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscar_repuesto = New System.Windows.Forms.TextBox()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.dgv_repuestos = New System.Windows.Forms.DataGridView()
        Me.cbo_proveedor = New System.Windows.Forms.ComboBox()
        Me.txt_repuesto = New System.Windows.Forms.TextBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.lbl_repuesto = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_repuestos = New System.Windows.Forms.Label()
        Me.lbl_cerrar = New System.Windows.Forms.Label()
        CType(Me.dgv_repuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(318, 249)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(76, 24)
        Me.btn_eliminar.TabIndex = 47
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_mostrar_todo
        '
        Me.btn_mostrar_todo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mostrar_todo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_mostrar_todo.Location = New System.Drawing.Point(647, 296)
        Me.btn_mostrar_todo.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_mostrar_todo.Name = "btn_mostrar_todo"
        Me.btn_mostrar_todo.Size = New System.Drawing.Size(98, 24)
        Me.btn_mostrar_todo.TabIndex = 45
        Me.btn_mostrar_todo.Text = "Mostrar Todo"
        Me.btn_mostrar_todo.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.Location = New System.Drawing.Point(398, 298)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(76, 24)
        Me.btn_buscar.TabIndex = 44
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_buscar_repuesto
        '
        Me.txt_buscar_repuesto.Location = New System.Drawing.Point(157, 300)
        Me.txt_buscar_repuesto.Name = "txt_buscar_repuesto"
        Me.txt_buscar_repuesto.Size = New System.Drawing.Size(236, 20)
        Me.txt_buscar_repuesto.TabIndex = 43
        '
        'btn_modificar
        '
        Me.btn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.Location = New System.Drawing.Point(238, 249)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(76, 24)
        Me.btn_modificar.TabIndex = 41
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(157, 249)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(76, 24)
        Me.btn_agregar.TabIndex = 40
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'dgv_repuestos
        '
        Me.dgv_repuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_repuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_repuestos.Location = New System.Drawing.Point(157, 327)
        Me.dgv_repuestos.Name = "dgv_repuestos"
        Me.dgv_repuestos.Size = New System.Drawing.Size(588, 164)
        Me.dgv_repuestos.TabIndex = 39
        '
        'cbo_proveedor
        '
        Me.cbo_proveedor.FormattingEnabled = True
        Me.cbo_proveedor.Location = New System.Drawing.Point(157, 223)
        Me.cbo_proveedor.Name = "cbo_proveedor"
        Me.cbo_proveedor.Size = New System.Drawing.Size(212, 21)
        Me.cbo_proveedor.TabIndex = 38
        '
        'txt_repuesto
        '
        Me.txt_repuesto.Location = New System.Drawing.Point(157, 81)
        Me.txt_repuesto.Name = "txt_repuesto"
        Me.txt_repuesto.Size = New System.Drawing.Size(212, 20)
        Me.txt_repuesto.TabIndex = 37
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(157, 107)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(212, 20)
        Me.txt_stock.TabIndex = 36
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(157, 134)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(212, 20)
        Me.txt_precio.TabIndex = 35
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(157, 160)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(212, 57)
        Me.txt_descripcion.TabIndex = 34
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(157, 55)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(39, 20)
        Me.txt_id.TabIndex = 33
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.Location = New System.Drawing.Point(92, 226)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(59, 13)
        Me.lbl_proveedor.TabIndex = 32
        Me.lbl_proveedor.Text = "Proveedor:"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(88, 163)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbl_descripcion.TabIndex = 31
        Me.lbl_descripcion.Text = "Descripcion:"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New System.Drawing.Point(111, 137)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(40, 13)
        Me.lbl_precio.TabIndex = 30
        Me.lbl_precio.Text = "Precio:"
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Location = New System.Drawing.Point(113, 110)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(38, 13)
        Me.lbl_stock.TabIndex = 29
        Me.lbl_stock.Text = "Stock:"
        '
        'lbl_repuesto
        '
        Me.lbl_repuesto.AutoSize = True
        Me.lbl_repuesto.Location = New System.Drawing.Point(95, 84)
        Me.lbl_repuesto.Name = "lbl_repuesto"
        Me.lbl_repuesto.Size = New System.Drawing.Size(56, 13)
        Me.lbl_repuesto.TabIndex = 28
        Me.lbl_repuesto.Text = "Repuesto:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(130, 58)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(21, 13)
        Me.lbl_id.TabIndex = 27
        Me.lbl_id.Text = "ID:"
        '
        'lbl_repuestos
        '
        Me.lbl_repuestos.AutoSize = True
        Me.lbl_repuestos.Location = New System.Drawing.Point(12, 9)
        Me.lbl_repuestos.Name = "lbl_repuestos"
        Me.lbl_repuestos.Size = New System.Drawing.Size(58, 13)
        Me.lbl_repuestos.TabIndex = 48
        Me.lbl_repuestos.Text = "Repuestos"
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
        Me.lbl_cerrar.TabIndex = 49
        Me.lbl_cerrar.Text = "X"
        '
        'Repuestos_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 591)
        Me.Controls.Add(Me.lbl_cerrar)
        Me.Controls.Add(Me.lbl_repuestos)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_mostrar_todo)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_buscar_repuesto)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_repuestos)
        Me.Controls.Add(Me.cbo_proveedor)
        Me.Controls.Add(Me.txt_repuesto)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_proveedor)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.lbl_precio)
        Me.Controls.Add(Me.lbl_stock)
        Me.Controls.Add(Me.lbl_repuesto)
        Me.Controls.Add(Me.lbl_id)
        Me.Name = "Repuestos_Frm"
        Me.Text = "Repuestos_Frm"
        CType(Me.dgv_repuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_mostrar_todo As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_buscar_repuesto As System.Windows.Forms.TextBox
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents dgv_repuestos As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txt_repuesto As System.Windows.Forms.TextBox
    Friend WithEvents txt_stock As System.Windows.Forms.TextBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_proveedor As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_precio As System.Windows.Forms.Label
    Friend WithEvents lbl_stock As System.Windows.Forms.Label
    Friend WithEvents lbl_repuesto As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_repuestos As System.Windows.Forms.Label
    Friend WithEvents lbl_cerrar As System.Windows.Forms.Label
End Class
