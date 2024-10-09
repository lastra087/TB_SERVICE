<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Frm))
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_contraseña = New System.Windows.Forms.Label()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.chk_mostrar_contraseña = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(200, 55)
        Me.lbl_usuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(57, 17)
        Me.lbl_usuario.TabIndex = 0
        Me.lbl_usuario.Text = "Usuario"
        '
        'lbl_contraseña
        '
        Me.lbl_contraseña.AutoSize = True
        Me.lbl_contraseña.Location = New System.Drawing.Point(176, 96)
        Me.lbl_contraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_contraseña.Name = "lbl_contraseña"
        Me.lbl_contraseña.Size = New System.Drawing.Size(81, 17)
        Me.lbl_contraseña.TabIndex = 1
        Me.lbl_contraseña.Text = "Contraseña"
        '
        'btn_entrar
        '
        Me.btn_entrar.Location = New System.Drawing.Point(337, 180)
        Me.btn_entrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(100, 28)
        Me.btn_entrar.TabIndex = 4
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.UseVisualStyleBackColor = True
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(281, 52)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(155, 22)
        Me.txt_usuario.TabIndex = 1
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(281, 92)
        Me.txt_contraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(155, 22)
        Me.txt_contraseña.TabIndex = 2
        '
        'chk_mostrar_contraseña
        '
        Me.chk_mostrar_contraseña.AutoSize = True
        Me.chk_mostrar_contraseña.Location = New System.Drawing.Point(281, 124)
        Me.chk_mostrar_contraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chk_mostrar_contraseña.Name = "chk_mostrar_contraseña"
        Me.chk_mostrar_contraseña.Size = New System.Drawing.Size(153, 21)
        Me.chk_mostrar_contraseña.TabIndex = 3
        Me.chk_mostrar_contraseña.Text = "Mostrar contraseña"
        Me.chk_mostrar_contraseña.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Login_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 223)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chk_mostrar_contraseña)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.lbl_contraseña)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Login_Frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents lbl_contraseña As System.Windows.Forms.Label
    Friend WithEvents btn_entrar As System.Windows.Forms.Button
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents chk_mostrar_contraseña As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
