<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estadisticas_Frm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.lbl_estadisticas = New System.Windows.Forms.Label()
        Me.lbl_cerrar = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_estadisticas
        '
        Me.lbl_estadisticas.AutoSize = True
        Me.lbl_estadisticas.Location = New System.Drawing.Point(16, 11)
        Me.lbl_estadisticas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_estadisticas.Name = "lbl_estadisticas"
        Me.lbl_estadisticas.Size = New System.Drawing.Size(83, 17)
        Me.lbl_estadisticas.TabIndex = 103
        Me.lbl_estadisticas.Text = "Estadisticas"
        '
        'lbl_cerrar
        '
        Me.lbl_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_cerrar.AutoSize = True
        Me.lbl_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cerrar.Location = New System.Drawing.Point(1163, 11)
        Me.lbl_cerrar.Name = "lbl_cerrar"
        Me.lbl_cerrar.Size = New System.Drawing.Size(27, 25)
        Me.lbl_cerrar.TabIndex = 120
        Me.lbl_cerrar.Text = "X"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(63, 72)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Marcas de Equipos"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(306, 255)
        Me.Chart1.TabIndex = 121
        Me.Chart1.Text = "Chart1"
        Title1.Name = "Ranck Marcas Rotas"
        Me.Chart1.Titles.Add(Title1)
        '
        'Estadisticas_Frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 727)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.lbl_cerrar)
        Me.Controls.Add(Me.lbl_estadisticas)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Estadisticas_Frm"
        Me.Text = "Estadisticas"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_estadisticas As System.Windows.Forms.Label
    Friend WithEvents lbl_cerrar As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
