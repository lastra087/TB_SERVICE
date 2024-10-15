Imports System.Data
Imports TB_SERVICE_AD

Public Class Taller_Frm

    Dim oDs As New DataSet
    Dim o_Taller As New Taller
    Dim precio_hora As Double


    Public Sub carga_combo_repuestos()
        oDs = o_Taller.carga_combo_repuestos()
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

    Private Sub Taller_Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        For i = 1 To 10
            cbo_horasreparacion.Items.Add(i)
        Next
        carga_combo_repuestos()
        Combo_diagnostico()
        cbo_diagnostico.SelectedIndex = -1
        cbo_diagnostico.Text = "Seleccione un diagnóstico"
        carga_combo_categorias()
        cbo_categorias.SelectedIndex = -1
        cbo_repuestos.SelectedIndex = -1
        dgv_repuestos.ColumnCount = 5
        dgv_repuestos.Columns(0).Name = "Repuesto"
        dgv_repuestos.Columns(1).Name = "ID_Repuesto"
        dgv_repuestos.Columns(2).Name = "Precio_unitario"
        dgv_repuestos.Columns(3).Name = "Stock"
        dgv_repuestos.Columns(4).Name = "Descripcion"

    End Sub

    Public Sub Combo_diagnostico()
        oDs = New DataSet
        o_Taller = New Taller
        oDs = o_Taller.Combo_diagnostico()
        With cbo_diagnostico
            .DataSource = oDs.Tables(0)
            .DisplayMember = oDs.Tables(0).Columns(1).ToString
            .ValueMember = oDs.Tables(0).Columns(0).ToString
        End With
    End Sub

    Private Sub btn_agregar_reparacion_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_agregar_reparacion.Click
        If cbo_repuestos.SelectedItem IsNot Nothing Then
            Dim drv As DataRowView = CType(cbo_repuestos.SelectedItem, DataRowView)
            Dim repuesto_nombre As String = drv("Repuesto").ToString()
            Dim repuesto_id As String = drv("ID_Repuesto").ToString()
            Dim repuesto_precio As Decimal = Convert.ToDecimal(drv("Precio_unitario"))
            Dim repuesto_stock As Integer = Convert.ToInt32(drv("Stock"))
            Dim repuesto_descripcion As String = drv("Descripcion").ToString()
            dgv_repuestos.Rows.Add(repuesto_nombre, repuesto_id, repuesto_precio, repuesto_stock, repuesto_descripcion)
            ActualizarTotalRepuestos()
        Else
            MessageBox.Show("Por favor, selecciona un repuesto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ActualizarTotalRepuestos()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgv_repuestos.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells("Precio_unitario").Value)
            End If
        Next
        txt_total_repuesto.Text = total.ToString("C")
    End Sub

    Private Sub txt_total_repuesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_total_repuesto.KeyPress
        e.Handled = True
    End Sub

    Private Sub rdb_cliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_cliente.CheckedChanged
        If rdb_cliente.Checked Then
            grb_repuestos.Visible = False
        Else
            grb_repuestos.Visible = True
        End If
    End Sub

    Private Sub cbo_categorias_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbo_categorias.SelectedIndexChanged

        If cbo_categorias.SelectedItem IsNot Nothing Then
            Dim drv As DataRowView = CType(cbo_categorias.SelectedItem, DataRowView)
            Dim precioPorHora As Decimal = Convert.ToDecimal(drv("Precio_hora"))
            txt_valor_hs.Text = precioPorHora.ToString("C")
        Else
            txt_valor_hs.Text = String.Empty
        End If

    End Sub

    Private Sub txt_valor_hs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_valor_hs.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbo_horasreparacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbo_horasreparacion.SelectedIndexChanged

        If Not String.IsNullOrEmpty(txt_valor_hs.Text) AndAlso cbo_horasreparacion.SelectedItem IsNot Nothing Then
            Dim PrecioPorHora As Decimal = Decimal.Parse(txt_valor_hs.Text, Globalization.NumberStyles.Currency)
            Dim HorasReparacion As Integer = Integer.Parse(cbo_horasreparacion.SelectedItem.ToString())
            Dim TotalReparacion As Decimal = PrecioPorHora * HorasReparacion
            txt_total_reparacion.Text = TotalReparacion.ToString("C")
        End If
    End Sub

    Private Sub txt_total_reparacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_total_reparacion.KeyPress
        e.Handled = True
    End Sub

    Private Sub btn_calcular_total_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular_total.Click
        Dim totalReparacion As Decimal = 0
        Dim totalRepuestos As Decimal = 0
        Dim totalGeneral As Decimal = 0

        If Not String.IsNullOrEmpty(txt_total_reparacion.Text) Then
            totalReparacion = Decimal.Parse(txt_total_reparacion.Text, Globalization.NumberStyles.Currency)
        End If

        If Not String.IsNullOrEmpty(txt_total_repuesto.Text) Then
            totalRepuestos = Decimal.Parse(txt_total_repuesto.Text, Globalization.NumberStyles.Currency)
        End If

        totalGeneral = totalReparacion + totalRepuestos

        txt_total_final.Text = totalGeneral.ToString("C")
    End Sub

    Private Sub txt_total_final_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_total_final.KeyPress
        e.Handled = True
    End Sub

    Private Sub lbl_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_cerrar.Click

        Me.Close()

    End Sub

End Class
