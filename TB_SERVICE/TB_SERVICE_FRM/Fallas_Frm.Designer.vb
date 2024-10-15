<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fallas_Frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fallas_Frm))
        Me.btn_mostrar_tabla = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.btn_elimina_cat = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guarda_cat = New System.Windows.Forms.Button()
        Me.btn_categorias = New System.Windows.Forms.Button()
        Me.grl_grilla = New System.Windows.Forms.DataGridView()
        Me.cbo_categorias = New System.Windows.Forms.ComboBox()
        Me.txt_categorias = New System.Windows.Forms.TextBox()
        Me.txt_falla = New System.Windows.Forms.TextBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lbl_modelo = New System.Windows.Forms.Label()
        Me.lbl_falla = New System.Windows.Forms.Label()
        Me.btn_modifica_cat = New System.Windows.Forms.Button()
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_mostrar_tabla
        '
        Me.btn_mostrar_tabla.Location = New System.Drawing.Point(783, 267)
        Me.btn_mostrar_tabla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_mostrar_tabla.Name = "btn_mostrar_tabla"
        Me.btn_mostrar_tabla.Size = New System.Drawing.Size(121, 30)
        Me.btn_mostrar_tabla.TabIndex = 38
        Me.btn_mostrar_tabla.Text = "Mostrar Todo"
        Me.btn_mostrar_tabla.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(493, 267)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(101, 30)
        Me.btn_buscar.TabIndex = 37
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(205, 271)
        Me.txt_buscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(281, 22)
        Me.txt_buscar.TabIndex = 36
        '
        'btn_elimina_cat
        '
        Me.btn_elimina_cat.Location = New System.Drawing.Point(419, 108)
        Me.btn_elimina_cat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_elimina_cat.Name = "btn_elimina_cat"
        Me.btn_elimina_cat.Size = New System.Drawing.Size(101, 30)
        Me.btn_elimina_cat.TabIndex = 35
        Me.btn_elimina_cat.Text = "Eliminar"
        Me.btn_elimina_cat.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(526, 198)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(101, 30)
        Me.btn_limpiar.TabIndex = 34
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(740, 64)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(101, 30)
        Me.btn_cancelar.TabIndex = 33
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guarda_cat
        '
        Me.btn_guarda_cat.Location = New System.Drawing.Point(205, 108)
        Me.btn_guarda_cat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_guarda_cat.Name = "btn_guarda_cat"
        Me.btn_guarda_cat.Size = New System.Drawing.Size(101, 30)
        Me.btn_guarda_cat.TabIndex = 32
        Me.btn_guarda_cat.Text = "Guardar"
        Me.btn_guarda_cat.UseVisualStyleBackColor = True
        '
        'btn_categorias
        '
        Me.btn_categorias.Location = New System.Drawing.Point(526, 64)
        Me.btn_categorias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_categorias.Name = "btn_categorias"
        Me.btn_categorias.Size = New System.Drawing.Size(208, 30)
        Me.btn_categorias.TabIndex = 26
        Me.btn_categorias.Text = "Categorías..."
        Me.btn_categorias.UseVisualStyleBackColor = True
        '
        'grl_grilla
        '
        Me.grl_grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grl_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_grilla.Location = New System.Drawing.Point(205, 300)
        Me.grl_grilla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grl_grilla.Name = "grl_grilla"
        Me.grl_grilla.ReadOnly = True
        Me.grl_grilla.RowTemplate.Height = 24
        Me.grl_grilla.Size = New System.Drawing.Size(699, 302)
        Me.grl_grilla.TabIndex = 28
        '
        'cbo_categorias
        '
        Me.cbo_categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_categorias.FormattingEnabled = True
        Me.cbo_categorias.Location = New System.Drawing.Point(205, 68)
        Me.cbo_categorias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_categorias.Name = "cbo_categorias"
        Me.cbo_categorias.Size = New System.Drawing.Size(315, 24)
        Me.cbo_categorias.TabIndex = 25
        '
        'txt_categorias
        '
        Me.txt_categorias.Location = New System.Drawing.Point(205, 68)
        Me.txt_categorias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_categorias.Name = "txt_categorias"
        Me.txt_categorias.Size = New System.Drawing.Size(315, 22)
        Me.txt_categorias.TabIndex = 27
        '
        'txt_falla
        '
        Me.txt_falla.Location = New System.Drawing.Point(205, 156)
        Me.txt_falla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_falla.Name = "txt_falla"
        Me.txt_falla.Size = New System.Drawing.Size(315, 22)
        Me.txt_falla.TabIndex = 24
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(419, 198)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(101, 30)
        Me.btn_eliminar.TabIndex = 31
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(312, 198)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(101, 30)
        Me.btn_modificar.TabIndex = 30
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(205, 198)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(101, 30)
        Me.btn_agregar.TabIndex = 29
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lbl_modelo
        '
        Me.lbl_modelo.AutoSize = True
        Me.lbl_modelo.Location = New System.Drawing.Point(126, 71)
        Me.lbl_modelo.Name = "lbl_modelo"
        Me.lbl_modelo.Size = New System.Drawing.Size(73, 17)
        Me.lbl_modelo.TabIndex = 23
        Me.lbl_modelo.Text = "Categoría:"
        '
        'lbl_falla
        '
        Me.lbl_falla.AutoSize = True
        Me.lbl_falla.Location = New System.Drawing.Point(157, 159)
        Me.lbl_falla.Name = "lbl_falla"
        Me.lbl_falla.Size = New System.Drawing.Size(42, 17)
        Me.lbl_falla.TabIndex = 22
        Me.lbl_falla.Text = "Falla:"
        '
        'btn_modifica_cat
        '
        Me.btn_modifica_cat.Location = New System.Drawing.Point(312, 108)
        Me.btn_modifica_cat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_modifica_cat.Name = "btn_modifica_cat"
        Me.btn_modifica_cat.Size = New System.Drawing.Size(101, 30)
        Me.btn_modifica_cat.TabIndex = 39
        Me.btn_modifica_cat.Text = "Modificar"
        Me.btn_modifica_cat.UseVisualStyleBackColor = True
        '
        'Fallas_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 733)
        Me.Controls.Add(Me.btn_modifica_cat)
        Me.Controls.Add(Me.btn_mostrar_tabla)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.btn_elimina_cat)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guarda_cat)
        Me.Controls.Add(Me.btn_categorias)
        Me.Controls.Add(Me.grl_grilla)
        Me.Controls.Add(Me.cbo_categorias)
        Me.Controls.Add(Me.txt_categorias)
        Me.Controls.Add(Me.txt_falla)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.lbl_modelo)
        Me.Controls.Add(Me.lbl_falla)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fallas_Frm"
        Me.Text = "Fallas"
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_mostrar_tabla As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents btn_elimina_cat As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_guarda_cat As System.Windows.Forms.Button
    Friend WithEvents btn_categorias As System.Windows.Forms.Button
    Friend WithEvents grl_grilla As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_categorias As System.Windows.Forms.ComboBox
    Friend WithEvents txt_categorias As System.Windows.Forms.TextBox
    Friend WithEvents txt_falla As System.Windows.Forms.TextBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_modelo As System.Windows.Forms.Label
    Friend WithEvents lbl_falla As System.Windows.Forms.Label
    Friend WithEvents btn_modifica_cat As System.Windows.Forms.Button
End Class
