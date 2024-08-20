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
        Me.lbl_buscar_repuesto = New System.Windows.Forms.Label()
        Me.btn_mostrar_todo = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscar_repuesto = New System.Windows.Forms.TextBox()
        Me.btn_limpiar = New System.Windows.Forms.Button()
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
        CType(Me.dgv_repuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(424, 316)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(101, 30)
        Me.btn_eliminar.TabIndex = 47
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'lbl_buscar_repuesto
        '
        Me.lbl_buscar_repuesto.AutoSize = True
        Me.lbl_buscar_repuesto.Location = New System.Drawing.Point(117, 373)
        Me.lbl_buscar_repuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_buscar_repuesto.Name = "lbl_buscar_repuesto"
        Me.lbl_buscar_repuesto.Size = New System.Drawing.Size(117, 17)
        Me.lbl_buscar_repuesto.TabIndex = 46
        Me.lbl_buscar_repuesto.Text = "Buscar Repuesto"
        '
        'btn_mostrar_todo
        '
        Me.btn_mostrar_todo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mostrar_todo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_mostrar_todo.Location = New System.Drawing.Point(863, 366)
        Me.btn_mostrar_todo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_mostrar_todo.Name = "btn_mostrar_todo"
        Me.btn_mostrar_todo.Size = New System.Drawing.Size(131, 30)
        Me.btn_mostrar_todo.TabIndex = 45
        Me.btn_mostrar_todo.Text = "Mostrar Todo"
        Me.btn_mostrar_todo.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.Location = New System.Drawing.Point(756, 364)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(101, 30)
        Me.btn_buscar.TabIndex = 44
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_buscar_repuesto
        '
        Me.txt_buscar_repuesto.Location = New System.Drawing.Point(244, 369)
        Me.txt_buscar_repuesto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_buscar_repuesto.Name = "txt_buscar_repuesto"
        Me.txt_buscar_repuesto.Size = New System.Drawing.Size(445, 22)
        Me.txt_buscar_repuesto.TabIndex = 43
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Location = New System.Drawing.Point(531, 316)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(101, 30)
        Me.btn_limpiar.TabIndex = 42
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.Location = New System.Drawing.Point(317, 316)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(101, 30)
        Me.btn_modificar.TabIndex = 41
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(209, 316)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(101, 30)
        Me.btn_agregar.TabIndex = 40
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'dgv_repuestos
        '
        Me.dgv_repuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_repuestos.Location = New System.Drawing.Point(209, 402)
        Me.dgv_repuestos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_repuestos.Name = "dgv_repuestos"
        Me.dgv_repuestos.Size = New System.Drawing.Size(784, 230)
        Me.dgv_repuestos.TabIndex = 39
        '
        'cbo_proveedor
        '
        Me.cbo_proveedor.FormattingEnabled = True
        Me.cbo_proveedor.Location = New System.Drawing.Point(209, 284)
        Me.cbo_proveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbo_proveedor.Name = "cbo_proveedor"
        Me.cbo_proveedor.Size = New System.Drawing.Size(200, 24)
        Me.cbo_proveedor.TabIndex = 38
        '
        'txt_repuesto
        '
        Me.txt_repuesto.Location = New System.Drawing.Point(209, 110)
        Me.txt_repuesto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_repuesto.Name = "txt_repuesto"
        Me.txt_repuesto.Size = New System.Drawing.Size(200, 22)
        Me.txt_repuesto.TabIndex = 37
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(209, 142)
        Me.txt_stock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(200, 22)
        Me.txt_stock.TabIndex = 36
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(209, 175)
        Me.txt_precio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(200, 22)
        Me.txt_precio.TabIndex = 35
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(209, 207)
        Me.txt_descripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(200, 69)
        Me.txt_descripcion.TabIndex = 34
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(209, 78)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(200, 22)
        Me.txt_id.TabIndex = 33
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.Location = New System.Drawing.Point(117, 284)
        Me.lbl_proveedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(78, 17)
        Me.lbl_proveedor.TabIndex = 32
        Me.lbl_proveedor.Text = "Proveedor:"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(117, 210)
        Me.lbl_descripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(86, 17)
        Me.lbl_descripcion.TabIndex = 31
        Me.lbl_descripcion.Text = "Descripcion:"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New System.Drawing.Point(117, 178)
        Me.lbl_precio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(52, 17)
        Me.lbl_precio.TabIndex = 30
        Me.lbl_precio.Text = "Precio:"
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Location = New System.Drawing.Point(117, 145)
        Me.lbl_stock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(47, 17)
        Me.lbl_stock.TabIndex = 29
        Me.lbl_stock.Text = "Stock:"
        '
        'lbl_repuesto
        '
        Me.lbl_repuesto.AutoSize = True
        Me.lbl_repuesto.Location = New System.Drawing.Point(117, 113)
        Me.lbl_repuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_repuesto.Name = "lbl_repuesto"
        Me.lbl_repuesto.Size = New System.Drawing.Size(73, 17)
        Me.lbl_repuesto.TabIndex = 28
        Me.lbl_repuesto.Text = "Repuesto:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(117, 81)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(25, 17)
        Me.lbl_id.TabIndex = 27
        Me.lbl_id.Text = "ID:"
        '
        'Repuestos_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 727)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.lbl_buscar_repuesto)
        Me.Controls.Add(Me.btn_mostrar_todo)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_buscar_repuesto)
        Me.Controls.Add(Me.btn_limpiar)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Repuestos_Frm"
        Me.Text = "Repuestos_Frm"
        CType(Me.dgv_repuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents lbl_buscar_repuesto As System.Windows.Forms.Label
    Friend WithEvents btn_mostrar_todo As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_buscar_repuesto As System.Windows.Forms.TextBox
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
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
End Class
