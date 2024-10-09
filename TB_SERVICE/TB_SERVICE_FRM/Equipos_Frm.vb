Imports System.Data
Imports TB_SERVICE_AD

Public Class Equipos_Frm
    'Public frmPadre = New Menu_Frm
    Dim fechaActual As String = DateTime.Now.ToString("dd/MM/yyyy")
    Dim oDs As New DataSet
    Dim o_Equipos As New Equipos

    Private Sub Equipos_Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_idcliente.Text = id_cliente
        txt_nombre.Text = nombre
        txt_apellido.Text = apellido
        txt_fecha_ingreso.Text = fechaActual
        grilla_sala_espera()
        combo_marca()
        cbo_marcas.SelectedIndex = -1
        capos_llenos()
    End Sub

    Public Sub capos_llenos()

        If txt_nombre.Text <> Nothing And txt_apellido.Text <> Nothing And txt_fecha_ingreso.Text <> Nothing And txt_problema_equipo.Text <> Nothing And cbo_marcas.Text <> Nothing And cbo_modelos.Text <> Nothing Then

            btn_sala_espera.Enabled = True
        Else
            btn_sala_espera.Enabled = False

        End If

    End Sub

    Public Sub combo_marca()
        Dim o_Equipos As New Equipos
        oDs = o_Equipos.combo_marca
        With cbo_marcas
            .DataSource = oDs.Tables(0)
            .DisplayMember = oDs.Tables(0).Columns(1).ToString
            .ValueMember = oDs.Tables(0).Columns(0).ToString
        End With
    End Sub

    Public Sub combo_modelo_x_marca()
        oDs = New DataSet
        o_Equipos = New Equipos
        oDs = o_Equipos.combo_modelo_x_marca(cbo_marcas.SelectedValue)
        With cbo_modelos
            .DataSource = oDs.Tables(0)
            .DisplayMember = "Modelo"
            .ValueMember = "idModelo"
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Marca_Modelo_Frm.ShowDialog()
    End Sub

    Private Sub cbo_marcas_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_marcas.LostFocus
        combo_modelo_x_marca()
    End Sub

    Private Sub cbo_marcas_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbo_marcas.MouseClick
        combo_marca()
    End Sub

    Private Sub btn_sala_espera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sala_espera.Click
        If txt_nombre.Text <> Nothing And txt_apellido.Text <> Nothing And txt_fecha_ingreso.Text <> Nothing And txt_problema_equipo.Text <> Nothing Then
            oDs = New DataSet
            o_Equipos = New Equipos
            o_Equipos.cargar_equipos(cbo_marcas.SelectedValue, cbo_modelos.SelectedValue, txt_idcliente.Text, txt_fecha_ingreso.Text, txt_problema_equipo.Text)
            MsgBox("Equipo en espera", vbInformation, "Carga exitosa")
            carga_panel_padre(New Clientes_Frm, Menu_Frm)
        Else
            MsgBox("Complete los datos", vbInformation, "Campos vacios")
        End If
    End Sub



    Private Sub grilla_sala_espera()
        oDs = New DataSet
        o_Equipos = New Equipos
        oDs = o_Equipos.grilla_sala_espera
        With grl_grilla
            .DataSource = oDs.Tables(0)
        End With
    End Sub

    Private Sub lbl_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_cerrar.Click

        Me.Close()

    End Sub

    Private Sub txt_fecha_ingreso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_fecha_ingreso.TextChanged

        capos_llenos()

    End Sub

    Private Sub txt_problema_equipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_problema_equipo.TextChanged

        capos_llenos()

    End Sub

    Private Sub cbo_marcas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_marcas.SelectedIndexChanged

        capos_llenos()

    End Sub

    Private Sub cbo_modelos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_modelos.SelectedIndexChanged

        capos_llenos()

    End Sub

End Class