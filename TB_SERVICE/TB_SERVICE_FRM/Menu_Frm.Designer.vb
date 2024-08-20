<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Frm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Frm))
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.pnl_barra = New System.Windows.Forms.Panel()
        Me.pnl_menu = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_usuarios = New System.Windows.Forms.Button()
        Me.btn_estadistico = New System.Windows.Forms.Button()
        Me.btn_taller = New System.Windows.Forms.Button()
        Me.btn_equipos = New System.Windows.Forms.Button()
        Me.btn_proveedores = New System.Windows.Forms.Button()
        Me.btn_repuestos = New System.Windows.Forms.Button()
        Me.lbl_logo = New System.Windows.Forms.Label()
        Me.pcb_menu = New System.Windows.Forms.PictureBox()
        Me.pnl_padre = New System.Windows.Forms.Panel()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.tm_ver = New System.Windows.Forms.Timer(Me.components)
        Me.tm_ocultar = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_menu.SuspendLayout()
        CType(Me.pcb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_padre.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_clientes
        '
        Me.btn_clientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_clientes.FlatAppearance.BorderSize = 0
        Me.btn_clientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clientes.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clientes.ForeColor = System.Drawing.Color.White
        Me.btn_clientes.Image = CType(resources.GetObject("btn_clientes.Image"), System.Drawing.Image)
        Me.btn_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clientes.Location = New System.Drawing.Point(0, 181)
        Me.btn_clientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(219, 74)
        Me.btn_clientes.TabIndex = 0
        Me.btn_clientes.Text = "Clientes"
        Me.btn_clientes.UseVisualStyleBackColor = False
        '
        'pnl_barra
        '
        Me.pnl_barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.pnl_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_barra.Location = New System.Drawing.Point(0, 0)
        Me.pnl_barra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_barra.Name = "pnl_barra"
        Me.pnl_barra.Size = New System.Drawing.Size(1164, 71)
        Me.pnl_barra.TabIndex = 1
        '
        'pnl_menu
        '
        Me.pnl_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.pnl_menu.Controls.Add(Me.Panel2)
        Me.pnl_menu.Controls.Add(Me.Panel3)
        Me.pnl_menu.Controls.Add(Me.Panel4)
        Me.pnl_menu.Controls.Add(Me.Panel5)
        Me.pnl_menu.Controls.Add(Me.Panel6)
        Me.pnl_menu.Controls.Add(Me.Panel7)
        Me.pnl_menu.Controls.Add(Me.Panel1)
        Me.pnl_menu.Controls.Add(Me.btn_usuarios)
        Me.pnl_menu.Controls.Add(Me.btn_estadistico)
        Me.pnl_menu.Controls.Add(Me.btn_taller)
        Me.pnl_menu.Controls.Add(Me.btn_equipos)
        Me.pnl_menu.Controls.Add(Me.btn_proveedores)
        Me.pnl_menu.Controls.Add(Me.btn_repuestos)
        Me.pnl_menu.Controls.Add(Me.lbl_logo)
        Me.pnl_menu.Controls.Add(Me.pcb_menu)
        Me.pnl_menu.Controls.Add(Me.btn_clientes)
        Me.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_menu.Location = New System.Drawing.Point(0, 71)
        Me.pnl_menu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_menu.Name = "pnl_menu"
        Me.pnl_menu.Size = New System.Drawing.Size(220, 749)
        Me.pnl_menu.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(2, 658)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 74)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(2, 578)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 74)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(2, 498)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 74)
        Me.Panel4.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(2, 421)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 74)
        Me.Panel5.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(2, 341)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 74)
        Me.Panel6.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(2, 261)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 74)
        Me.Panel7.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(2, 181)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 74)
        Me.Panel1.TabIndex = 0
        '
        'btn_usuarios
        '
        Me.btn_usuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_usuarios.FlatAppearance.BorderSize = 0
        Me.btn_usuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_usuarios.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_usuarios.ForeColor = System.Drawing.Color.White
        Me.btn_usuarios.Image = CType(resources.GetObject("btn_usuarios.Image"), System.Drawing.Image)
        Me.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_usuarios.Location = New System.Drawing.Point(-1, 658)
        Me.btn_usuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_usuarios.Name = "btn_usuarios"
        Me.btn_usuarios.Size = New System.Drawing.Size(219, 74)
        Me.btn_usuarios.TabIndex = 8
        Me.btn_usuarios.Text = "  Usuarios"
        Me.btn_usuarios.UseVisualStyleBackColor = False
        '
        'btn_estadistico
        '
        Me.btn_estadistico.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_estadistico.FlatAppearance.BorderSize = 0
        Me.btn_estadistico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btn_estadistico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_estadistico.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_estadistico.ForeColor = System.Drawing.Color.White
        Me.btn_estadistico.Image = CType(resources.GetObject("btn_estadistico.Image"), System.Drawing.Image)
        Me.btn_estadistico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_estadistico.Location = New System.Drawing.Point(-1, 578)
        Me.btn_estadistico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_estadistico.Name = "btn_estadistico"
        Me.btn_estadistico.Size = New System.Drawing.Size(219, 74)
        Me.btn_estadistico.TabIndex = 7
        Me.btn_estadistico.Text = "  Estadísticas"
        Me.btn_estadistico.UseVisualStyleBackColor = False
        '
        'btn_taller
        '
        Me.btn_taller.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_taller.FlatAppearance.BorderSize = 0
        Me.btn_taller.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btn_taller.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_taller.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_taller.ForeColor = System.Drawing.Color.White
        Me.btn_taller.Image = CType(resources.GetObject("btn_taller.Image"), System.Drawing.Image)
        Me.btn_taller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_taller.Location = New System.Drawing.Point(5, 421)
        Me.btn_taller.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_taller.Name = "btn_taller"
        Me.btn_taller.Size = New System.Drawing.Size(219, 74)
        Me.btn_taller.TabIndex = 5
        Me.btn_taller.Text = "   Taller"
        Me.btn_taller.UseVisualStyleBackColor = False
        '
        'btn_equipos
        '
        Me.btn_equipos.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_equipos.FlatAppearance.BorderSize = 0
        Me.btn_equipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btn_equipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_equipos.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_equipos.ForeColor = System.Drawing.Color.White
        Me.btn_equipos.Image = CType(resources.GetObject("btn_equipos.Image"), System.Drawing.Image)
        Me.btn_equipos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_equipos.Location = New System.Drawing.Point(5, 498)
        Me.btn_equipos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_equipos.Name = "btn_equipos"
        Me.btn_equipos.Size = New System.Drawing.Size(219, 74)
        Me.btn_equipos.TabIndex = 6
        Me.btn_equipos.Text = "   Equipos"
        Me.btn_equipos.UseVisualStyleBackColor = False
        '
        'btn_proveedores
        '
        Me.btn_proveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_proveedores.FlatAppearance.BorderSize = 0
        Me.btn_proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btn_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_proveedores.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proveedores.ForeColor = System.Drawing.Color.White
        Me.btn_proveedores.Image = CType(resources.GetObject("btn_proveedores.Image"), System.Drawing.Image)
        Me.btn_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_proveedores.Location = New System.Drawing.Point(5, 341)
        Me.btn_proveedores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_proveedores.Name = "btn_proveedores"
        Me.btn_proveedores.Size = New System.Drawing.Size(219, 74)
        Me.btn_proveedores.TabIndex = 4
        Me.btn_proveedores.Text = "     Proveedores"
        Me.btn_proveedores.UseVisualStyleBackColor = False
        '
        'btn_repuestos
        '
        Me.btn_repuestos.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_repuestos.FlatAppearance.BorderSize = 0
        Me.btn_repuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btn_repuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_repuestos.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_repuestos.ForeColor = System.Drawing.Color.White
        Me.btn_repuestos.Image = CType(resources.GetObject("btn_repuestos.Image"), System.Drawing.Image)
        Me.btn_repuestos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_repuestos.Location = New System.Drawing.Point(5, 261)
        Me.btn_repuestos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_repuestos.Name = "btn_repuestos"
        Me.btn_repuestos.Size = New System.Drawing.Size(219, 74)
        Me.btn_repuestos.TabIndex = 3
        Me.btn_repuestos.Text = "   Repuestos"
        Me.btn_repuestos.UseVisualStyleBackColor = False
        '
        'lbl_logo
        '
        Me.lbl_logo.AutoSize = True
        Me.lbl_logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lbl_logo.Font = New System.Drawing.Font("Modern No. 20", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logo.ForeColor = System.Drawing.Color.White
        Me.lbl_logo.Location = New System.Drawing.Point(-8, 124)
        Me.lbl_logo.Name = "lbl_logo"
        Me.lbl_logo.Size = New System.Drawing.Size(265, 44)
        Me.lbl_logo.TabIndex = 2
        Me.lbl_logo.Text = "TB SERVICE"
        '
        'pcb_menu
        '
        Me.pcb_menu.Cursor = System.Windows.Forms.Cursors.Default
        Me.pcb_menu.Image = CType(resources.GetObject("pcb_menu.Image"), System.Drawing.Image)
        Me.pcb_menu.Location = New System.Drawing.Point(12, 15)
        Me.pcb_menu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pcb_menu.Name = "pcb_menu"
        Me.pcb_menu.Size = New System.Drawing.Size(35, 39)
        Me.pcb_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcb_menu.TabIndex = 1
        Me.pcb_menu.TabStop = False
        '
        'pnl_padre
        '
        Me.pnl_padre.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.pnl_padre.Controls.Add(Me.HScrollBar1)
        Me.pnl_padre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_padre.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnl_padre.Location = New System.Drawing.Point(220, 71)
        Me.pnl_padre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnl_padre.Name = "pnl_padre"
        Me.pnl_padre.Size = New System.Drawing.Size(944, 749)
        Me.pnl_padre.TabIndex = 3
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(600, 613)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(8, 8)
        Me.HScrollBar1.TabIndex = 0
        '
        'tm_ver
        '
        Me.tm_ver.Interval = 20
        '
        'tm_ocultar
        '
        Me.tm_ocultar.Interval = 20
        '
        'Menu_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 820)
        Me.Controls.Add(Me.pnl_padre)
        Me.Controls.Add(Me.pnl_menu)
        Me.Controls.Add(Me.pnl_barra)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Menu_Frm"
        Me.Text = "TB SERVICE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_menu.ResumeLayout(False)
        Me.pnl_menu.PerformLayout()
        CType(Me.pcb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_padre.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_clientes As System.Windows.Forms.Button
    Friend WithEvents pnl_barra As System.Windows.Forms.Panel
    Friend WithEvents pnl_menu As System.Windows.Forms.Panel
    Friend WithEvents pnl_padre As System.Windows.Forms.Panel
    Friend WithEvents pcb_menu As System.Windows.Forms.PictureBox
    Friend WithEvents tm_ver As System.Windows.Forms.Timer
    Friend WithEvents tm_ocultar As System.Windows.Forms.Timer
    Friend WithEvents lbl_logo As System.Windows.Forms.Label
    Friend WithEvents btn_taller As System.Windows.Forms.Button
    Friend WithEvents btn_proveedores As System.Windows.Forms.Button
    Friend WithEvents btn_repuestos As System.Windows.Forms.Button
    Friend WithEvents btn_estadistico As System.Windows.Forms.Button
    Friend WithEvents btn_equipos As System.Windows.Forms.Button
    Friend WithEvents btn_usuarios As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar

End Class
