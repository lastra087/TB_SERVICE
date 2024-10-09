<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios_Frm
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
        Me.btn_mostrar_todo = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.cbo_cargo = New System.Windows.Forms.ComboBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.lbl_cargo = New System.Windows.Forms.Label()
        Me.lbl_contraseña = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_usuarios = New System.Windows.Forms.Label()
        Me.lbl_cerrar = New System.Windows.Forms.Label()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_mostrar_todo
        '
        Me.btn_mostrar_todo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mostrar_todo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_mostrar_todo.Location = New System.Drawing.Point(872, 270)
        Me.btn_mostrar_todo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_mostrar_todo.Name = "btn_mostrar_todo"
        Me.btn_mostrar_todo.Size = New System.Drawing.Size(131, 30)
        Me.btn_mostrar_todo.TabIndex = 118
        Me.btn_mostrar_todo.Text = "Mostrar Todo"
        Me.btn_mostrar_todo.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.Location = New System.Drawing.Point(540, 272)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(101, 30)
        Me.btn_buscar.TabIndex = 117
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(219, 274)
        Me.txt_buscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(313, 22)
        Me.txt_buscar.TabIndex = 116
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuarios.Location = New System.Drawing.Point(219, 308)
        Me.dgv_usuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        Me.dgv_usuarios.Size = New System.Drawing.Size(784, 202)
        Me.dgv_usuarios.TabIndex = 115
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(433, 193)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(101, 30)
        Me.btn_eliminar.TabIndex = 114
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.Location = New System.Drawing.Point(327, 193)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(101, 30)
        Me.btn_modificar.TabIndex = 112
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.Location = New System.Drawing.Point(219, 193)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(101, 30)
        Me.btn_agregar.TabIndex = 111
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'cbo_cargo
        '
        Me.cbo_cargo.FormattingEnabled = True
        Me.cbo_cargo.Location = New System.Drawing.Point(219, 161)
        Me.cbo_cargo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbo_cargo.Name = "cbo_cargo"
        Me.cbo_cargo.Size = New System.Drawing.Size(281, 24)
        Me.cbo_cargo.TabIndex = 110
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(219, 97)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(281, 22)
        Me.txt_usuario.TabIndex = 109
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(219, 129)
        Me.txt_contraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(281, 22)
        Me.txt_contraseña.TabIndex = 108
        '
        'lbl_cargo
        '
        Me.lbl_cargo.AutoSize = True
        Me.lbl_cargo.Location = New System.Drawing.Point(160, 165)
        Me.lbl_cargo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_cargo.Name = "lbl_cargo"
        Me.lbl_cargo.Size = New System.Drawing.Size(50, 17)
        Me.lbl_cargo.TabIndex = 107
        Me.lbl_cargo.Text = "Cargo:"
        '
        'lbl_contraseña
        '
        Me.lbl_contraseña.AutoSize = True
        Me.lbl_contraseña.Location = New System.Drawing.Point(125, 133)
        Me.lbl_contraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_contraseña.Name = "lbl_contraseña"
        Me.lbl_contraseña.Size = New System.Drawing.Size(85, 17)
        Me.lbl_contraseña.TabIndex = 106
        Me.lbl_contraseña.Text = "Contraseña:"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(149, 101)
        Me.lbl_usuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(61, 17)
        Me.lbl_usuario.TabIndex = 105
        Me.lbl_usuario.Text = "Usuario:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(219, 65)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(51, 22)
        Me.txt_id.TabIndex = 104
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(183, 69)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(25, 17)
        Me.lbl_id.TabIndex = 103
        Me.lbl_id.Text = "ID:"
        '
        'lbl_usuarios
        '
        Me.lbl_usuarios.AutoSize = True
        Me.lbl_usuarios.Location = New System.Drawing.Point(16, 11)
        Me.lbl_usuarios.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_usuarios.Name = "lbl_usuarios"
        Me.lbl_usuarios.Size = New System.Drawing.Size(64, 17)
        Me.lbl_usuarios.TabIndex = 102
        Me.lbl_usuarios.Text = "Usuarios"
        '
        'lbl_cerrar
        '
        Me.lbl_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_cerrar.AutoSize = True
        Me.lbl_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cerrar.Location = New System.Drawing.Point(1163, 11)
        Me.lbl_cerrar.Name = "lbl_cerrar"
        Me.lbl_cerrar.Size = New System.Drawing.Size(27, 25)
        Me.lbl_cerrar.TabIndex = 119
        Me.lbl_cerrar.Text = "X"
        '
        'Usuarios_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 727)
        Me.Controls.Add(Me.lbl_cerrar)
        Me.Controls.Add(Me.btn_mostrar_todo)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.dgv_usuarios)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.cbo_cargo)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.lbl_cargo)
        Me.Controls.Add(Me.lbl_contraseña)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_usuarios)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Usuarios_Frm"
        Me.Text = "Usuarios"
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_mostrar_todo As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents dgv_usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents cbo_cargo As System.Windows.Forms.ComboBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cargo As System.Windows.Forms.Label
    Friend WithEvents lbl_contraseña As System.Windows.Forms.Label
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents lbl_usuarios As System.Windows.Forms.Label
    Friend WithEvents lbl_cerrar As System.Windows.Forms.Label
End Class
