Imports System.Data
Imports TB_SERVICE_AD

Public Class Equipos_Frm
    Dim fechaActual As String = DateTime.Now.ToString("dd/MM/yyyy")
    Dim oDs As New DataSet
    Dim o_Equipos As New Equipos

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Equipos_Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_nombre.Text = nombre
        txt_apellido.Text = apellido
        txt_fecha_ingreso.Text = fechaActual
        equipos_combo_marca()
        cbo_marcas.SelectedIndex = -1
    End Sub

    Public Sub equipos_combo_marca()
        Dim o_Equipos As New Equipos
        oDs = o_Equipos.equipos_combo_marc
        With cbo_marcas
            .DataSource = oDs.Tables(0)
            .DisplayMember = oDs.Tables(0).Columns(1).ToString
            .ValueMember = oDs.Tables(0).Columns(0).ToString
        End With
    End Sub

    Public Sub modelos_x_marca()
        oDs = New DataSet
        o_Equipos = New Equipos
        oDs = o_Equipos.combo_modelos_x_marca(cbo_marcas.SelectedValue)
        With cbo_modelos
            .DataSource = oDs.Tables(0)
            .DisplayMember = oDs.Tables(0).Columns(0).ToString
            .ValueMember = oDs.Tables(0).Columns(0).ToString
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Marca_Modelo_Frm.ShowDialog()
    End Sub

    Private Sub cbo_marcas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_marcas.LostFocus
        cbo_modelos.SelectedIndex = -1
        modelos_x_marca()
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click

    End Sub
    Private Sub btn_taller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_taller.Click
        fecha_ingresa = txt_fecha_ingreso.Text
        marca = cbo_marcas.Text
        modelo = cbo_modelos.Text
        carga_panel_padre(New chk_cliente)
    End Sub

    Private Sub cbo_marcas_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbo_marcas.MouseClick
        equipos_combo_marca()
    End Sub

End Class