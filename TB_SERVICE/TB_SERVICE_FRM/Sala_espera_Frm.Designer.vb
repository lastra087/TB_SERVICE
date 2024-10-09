<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sala_espera_Frm
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
        Me.grl_grilla = New System.Windows.Forms.DataGridView()
        Me.lbl_cerrar = New System.Windows.Forms.Label()
        Me.lbl_sala_de_espera = New System.Windows.Forms.Label()
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grl_grilla
        '
        Me.grl_grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grl_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_grilla.Location = New System.Drawing.Point(173, 153)
        Me.grl_grilla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grl_grilla.Name = "grl_grilla"
        Me.grl_grilla.RowTemplate.Height = 24
        Me.grl_grilla.Size = New System.Drawing.Size(919, 422)
        Me.grl_grilla.TabIndex = 1
        '
        'lbl_cerrar
        '
        Me.lbl_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_cerrar.AutoSize = True
        Me.lbl_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cerrar.Location = New System.Drawing.Point(1163, 11)
        Me.lbl_cerrar.Name = "lbl_cerrar"
        Me.lbl_cerrar.Size = New System.Drawing.Size(27, 25)
        Me.lbl_cerrar.TabIndex = 52
        Me.lbl_cerrar.Text = "X"
        '
        'lbl_sala_de_espera
        '
        Me.lbl_sala_de_espera.AutoSize = True
        Me.lbl_sala_de_espera.Location = New System.Drawing.Point(16, 11)
        Me.lbl_sala_de_espera.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sala_de_espera.Name = "lbl_sala_de_espera"
        Me.lbl_sala_de_espera.Size = New System.Drawing.Size(104, 17)
        Me.lbl_sala_de_espera.TabIndex = 53
        Me.lbl_sala_de_espera.Text = "Sala de espera"
        '
        'Sala_espera_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 727)
        Me.Controls.Add(Me.lbl_sala_de_espera)
        Me.Controls.Add(Me.lbl_cerrar)
        Me.Controls.Add(Me.grl_grilla)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Sala_espera_Frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sala de espera"
        CType(Me.grl_grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grl_grilla As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_cerrar As System.Windows.Forms.Label
    Friend WithEvents lbl_sala_de_espera As System.Windows.Forms.Label
End Class
