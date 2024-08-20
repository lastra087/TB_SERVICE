Imports System.Data
Imports TB_SERVICE_AD

Public Class chk_cliente
    Dim oDs As New DataSet
    Dim o_Taller As New Taller
    Dim precio_hora As Double


    Public Sub carga_combo_repuestos()
        Dim o_Taller As New Taller
        oDs = o_Taller.carga_combo_repuestos
        With cbo_repuestos
            .DataSource = oDs.Tables(0)
            .DisplayMember = oDs.Tables(0).Columns(1).ToString
            .ValueMember = oDs.Tables(0).Columns(0).ToString
        End With
    End Sub

    Public Sub carga_combo_categorias()
        Dim o_Taller As New Taller
        oDs = o_Taller.carga_combo_categorias
        With cbo_categorias
            .DataSource = oDs.Tables(0)
            .DisplayMember = oDs.Tables(0).Columns(1).ToString
            .ValueMember = oDs.Tables(0).Columns(0).ToString
        End With
    End Sub
    

    Private Sub chk_cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_fecha_ingreso.Text = fecha_ingresa
        txt_marca.Text = marca
        txt_modelo.Text = modelo
        For i = 1 To 48
            cbo_horasreparacion.Items.Add(i)
        Next
        For i = 1 To 5
            cbo_cantrepuestos.Items.Add(i)
        Next
        carga_combo_repuestos()
        carga_combo_categorias()
        cbo_categorias.SelectedIndex = -1
        cbo_repuestos.SelectedIndex = -1
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'si Repuestos provisto por el taller
        '(valor_dategoria*canthoras) + valor de repuesto
        'casocontrario()
        '(valor_dategoria*canthoras)
    End Sub
End Class