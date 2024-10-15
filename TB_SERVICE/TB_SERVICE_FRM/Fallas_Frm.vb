Imports System.Data
Imports TB_SERVICE_AD

Public Class Fallas_Frm

    Dim oDs As New DataSet
    Dim o_Fallas As New Fallas
    Private dv As DataView
    Dim cat_original As String
    Dim falla_original As String
    Dim id_cat As Integer = 0
    Dim sw As Integer = 0
    Dim sw1 As Integer = 0
    Dim sw2 As Integer = 0

   
    Private Sub Fallas_Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_guarda_cat.Visible = False
        btn_modifica_cat.Visible = False
        btn_elimina_cat.Visible = False
        btn_cancelar.Visible = False
        txt_categorias.Visible = False
        Carga_combofallas()
        cbo_categorias.SelectedIndex = -1
        Carga_grilla()
        btn_agregar.Enabled = False
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False

    End Sub

    Public Sub Carga_combofallas()
        oDs = New DataSet
        o_Fallas = New Fallas
        oDs = o_Fallas.Carga_combofallas
        With cbo_categorias
            .DataSource = oDs.Tables(0)
            .DisplayMember = oDs.Tables(0).Columns(1).ToString
            .ValueMember = oDs.Tables(0).Columns(0).ToString
        End With
    End Sub


    Public Sub Carga_grilla()
        oDs = New DataSet
        o_Fallas = New Fallas
        oDs = o_Fallas.Carga_grilla
        dv = New DataView(oDs.Tables(0))
        With grl_grilla
            .DataSource = dv
        End With
    End Sub

    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        If dv IsNot Nothing Then
            dv.RowFilter = "[Falla del equipo] LIKE '%" & txt_buscar.Text & "%'"
        End If
    End Sub

    Public Sub Carga_grilla_X_fallo()

        oDs = New DataSet
        o_Fallas = New Fallas
        oDs = o_Fallas.Carga_grilla_X_fallo
        With grl_grilla
            .DataSource = oDs.Tables(0)
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Marca_Modelo_Frm.Show()
    End Sub

    Private Sub grl_grilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grl_grilla.CellClick
        If sw1 = 0 Then
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = grl_grilla.Rows(e.RowIndex)
                'Asignar los valores de las celdas a los cuadros de texto
                id_cat = row.Cells("Código de falla").Value.ToString()
                cat_original = row.Cells("Categoría del fallo").Value.ToString()
                falla_original = row.Cells("Falla del equipo").Value.ToString()
                cbo_categorias.Text = cat_original
                txt_falla.Text = falla_original
            End If
            btn_eliminar.Enabled = True
            btn_agregar.Enabled = False
            sw = 1
        Else
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = grl_grilla.Rows(e.RowIndex)
                id_cat = row.Cells("Código de fallo").Value.ToString()
                cat_original = row.Cells("Categoría").Value.ToString()
                sw2 = 1
                txt_categorias.Text = cat_original
            End If
        End If
    End Sub

    Private Sub txt_falla_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_falla.TextChanged
        If sw = 0 Then
            If txt_falla.Text <> Nothing And cbo_categorias.Text <> Nothing Then
                btn_agregar.Enabled = True
            Else
                btn_agregar.Enabled = False
            End If
        ElseIf sw = 1 Then
            If txt_falla.Text <> falla_original Or cbo_categorias.Text <> cat_original Then
                btn_modificar.Enabled = True
                btn_eliminar.Enabled = False
            Else
                btn_modificar.Enabled = False
                btn_eliminar.Enabled = True
            End If
        End If
    End Sub

    Private Sub cbo_categorias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_categorias.SelectedIndexChanged
        If sw = 0 Then
            If txt_falla.Text <> Nothing And cbo_categorias.Text <> Nothing Then
                btn_agregar.Enabled = True
            Else
                btn_agregar.Enabled = False
            End If
        ElseIf sw = 1 Then
            If txt_falla.Text <> falla_original Or cbo_categorias.Text <> cat_original Then
                btn_modificar.Enabled = True
                btn_eliminar.Enabled = False
            Else
                btn_modificar.Enabled = False
            End If
        End If
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        If sw1 = 0 Then
            cbo_categorias.SelectedIndex = -1
            txt_falla.Text = Nothing
            id_cat = 0
            cat_original = 0
            falla_original = 0
            sw = 0
            btn_modificar.Enabled = False
            btn_eliminar.Enabled = False
        Else
            sw2 = 0
            txt_categorias.Clear()
            btn_modifica_cat.Enabled = False
            btn_elimina_cat.Enabled = False
        End If
    End Sub

    Private Sub btn_categorias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_categorias.Click
        btn_categorias.Enabled = False
        Carga_grilla_X_fallo()
        sw1 = 1
        btn_limpiar.Location = New Point(390, 88)
        btn_agregar.Visible = False
        btn_modificar.Visible = False
        btn_eliminar.Visible = False
        lbl_falla.Visible = False
        txt_falla.Visible = False
        txt_categorias.Visible = True
        cbo_categorias.Visible = False
        btn_guarda_cat.Visible = True
        btn_modifica_cat.Visible = True
        btn_elimina_cat.Visible = True
        btn_cancelar.Visible = True
        btn_guarda_cat.Enabled = False
        btn_modifica_cat.Enabled = False
        btn_elimina_cat.Enabled = False
        btn_guarda_cat.Enabled = False
        btn_modifica_cat.Enabled = False
        btn_elimina_cat.Enabled = False


    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        btn_categorias.Enabled = True
        Carga_grilla()
        Carga_combofallas()
        btn_limpiar.Location = New Point(390, 161)
        cbo_categorias.SelectedIndex = -1
        sw1 = 0
        btn_agregar.Visible = True
        btn_modificar.Visible = True
        btn_eliminar.Visible = True
        lbl_falla.Visible = True
        txt_falla.Visible = True
        txt_categorias.Visible = False
        txt_categorias.Clear()
        cbo_categorias.Visible = True
        btn_guarda_cat.Visible = False
        txt_falla.Clear()
        btn_modifica_cat.Visible = False
        btn_elimina_cat.Visible = False
        btn_cancelar.Visible = False
    End Sub

    Private Sub txt_categorias_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_categorias.TextChanged
        If sw2 = 0 Then
            If txt_categorias.Text = Nothing Then
                btn_guarda_cat.Enabled = False
            Else
                btn_guarda_cat.Enabled = True
            End If
        Else
            If txt_categorias.Text <> cat_original Then
                btn_modifica_cat.Enabled = True
                btn_elimina_cat.Enabled = False
            Else
                btn_modifica_cat.Enabled = False
                btn_elimina_cat.Enabled = True
            End If
        End If
       
    End Sub

    Private Sub btn_guarda_cat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guarda_cat.Click
        o_Fallas = New Fallas
        o_Fallas.Guardar_cat(txt_categorias.Text)
        MsgBox("Categoría guardada con éxito.", vbInformation, "Fallas")
        txt_categorias.Clear()
        Carga_grilla_X_fallo()

    End Sub

    Private Sub btn_modifica_cat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modifica_cat.Click
        o_Fallas = New Fallas
        o_Fallas.Modificar_categoria(id_cat, txt_categorias.Text)
        MsgBox("Categoría modificada con éxito.", vbInformation, "Fallas")
        txt_categorias.Clear()
        Carga_grilla_X_fallo()
    End Sub

    Private Sub btn_elimina_cat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_elimina_cat.Click
        o_Fallas = New Fallas
        o_Fallas.Eliminar_categoria(id_cat)
        MsgBox("Categoría eliminada con éxito.", vbInformation, "Fallas")
        txt_categorias.Clear()
        Carga_grilla_X_fallo()
        btn_modifica_cat.Enabled = False
        id_cat = 0
        sw2 = 0
    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        o_Fallas = New Fallas
        o_Fallas.Guardar_fallo(txt_falla.Text, cbo_categorias.SelectedValue)
        MsgBox("Fallo guardado con éxito.", vbInformation, "Fallas")
        txt_falla.Clear()
        cbo_categorias.SelectedIndex = -1
        Carga_grilla()
    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        o_Fallas = New Fallas
        o_Fallas.Modificar_fallo(id_cat, txt_falla.Text, cbo_categorias.SelectedValue)
        MsgBox("Fallo modificado con éxito.", vbInformation, "Fallas")
        txt_falla.Clear()
        cbo_categorias.SelectedIndex = -1
        Carga_grilla()
        btn_modificar.Enabled = False
        sw = 0
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        o_Fallas = New Fallas
        o_Fallas.Eliminar_fallo(id_cat)
        MsgBox("Falla eliminada con éxito.", vbInformation, "Fallas")
        txt_falla.Clear()
        cbo_categorias.SelectedIndex = -1
        Carga_grilla()
        btn_modificar.Enabled = False
        sw = 0
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Marca_Modelo_Frm.Show()
    End Sub

    Private Sub cbo_categorias_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_categorias.TextChanged
        'If dv IsNot Nothing Then
        '    dv.RowFilter = "[Falla del equipo] LIKE '%" & cbo_categorias.Text & "%'"
        'End If
    End Sub
End Class