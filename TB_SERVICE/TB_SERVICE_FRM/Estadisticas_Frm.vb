Imports System.Data
Imports TB_SERVICE_AD
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Estadisticas_Frm

    Dim oDs As New DataSet
    Dim o_Estadisticas As New Estadisticas

    Private Sub lbl_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_cerrar.Click
        Me.Close()
    End Sub

    Public Sub CargarDatosEnChart()
        Dim o_Estadisticas As New Estadisticas()
        oDs = o_Estadisticas.Marcas_sala_espera()
        Chart1.Series.Clear()
        Dim serie As New Series
        serie.ChartType = SeriesChartType.Pie
        ' Puedes cambiarlo a otro tipo de gráfico si lo deseas
        ' Añadir los datos de la consulta al Chart
        For Each fila As DataRow In oDs.Tables(0).Rows
            serie.Points.AddXY(fila("Marca").ToString(), Convert.ToInt32(fila("Cant.")))
        Next
        ' Añadir la serie al Chart
        Chart1.Titles.Clear() ' Limpiar títulos anteriores
        Chart1.Titles.Add("Marcas en Taller")
        Chart1.Series.Add(serie)
        ' Configurar otras propiedades del Chart si es necesario
        Chart1.ChartAreas(0).AxisX.Title = "Marca"
        Chart1.ChartAreas(0).AxisY.Title = "Cantidad"
    End Sub

    Private Sub Estadisticas_Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatosEnChart()
    End Sub

End Class