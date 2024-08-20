Imports System.Data
Imports TB_SERVICE_AD

Public Class Marca_Modelo_Frm
    Dim idmodelo As Integer = 0
    Dim sw As Integer = 0
    Dim marca_original As String
    Dim modelo_original As String
    Dim sw1 As Integer = 0

    Dim oDs As New DataSet
    Dim o_Marca_Modelo As New Marca_Modelo

    Private Sub Marca_Modelo_Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_marcanueva.Enabled = True
        btn_eliminar_marca.Visible = False
        btn_guardarmarca.Visible = False
        btn_cancelar.Visible = False
        txt_marca.Visible = False
        txt_modelo.Text = Nothing
        combo_marca()
        cbo_marca.SelectedIndex = -1
        cargar_grilla()
        btn_agregar.Enabled = False
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False

    End Sub

    Public Sub carga_grilla_x_marca()
        oDs = New DataSet
        o_Marca_Modelo = New Marca_Modelo
        oDs = o_Marca_Modelo.grilla_x_marca
        With grl_grilla
            .DataSource = oDs.Tables(0)
        End With

    End Sub

    Public Sub combo_marca()

        Dim o_Marca_Modelo As New Marca_Modelo
        oDs = o_Marca_Modelo.combo_marca
        If oDs.Tables(0).Rows.Count > 0 Then
            cbo_marca.DataSource = oDs.Tables(0)
            cbo_marca.DisplayMember = oDs.Tables(0).Columns(1).ToString
            cbo_marca.ValueMember = oDs.Tables(0).Columns(0).ToString
        End If

    End Sub

    Private Sub btn_guardarmarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txt_marca.Text <> Nothing Then
            oDs = New DataSet
            o_Marca_Modelo = New Marca_Modelo
            o_Marca_Modelo.nueva_marca(txt_marca.Text)
            MsgBox("Se cargo con exito.", vbInformation, "TB")
        Else
            MsgBox("Completar campos vacios.", vbInformation, "TB")
        End If
        btn_agregar.Enabled = True
        btn_eliminar.Enabled = True
        btn_modificar.Enabled = True
        txt_modelo.Enabled = True
        btn_guardarmarca.Visible = False
        txt_marca.Visible = False
        cbo_marca.Visible = True
        btn_marcanueva.Enabled = True
        btn_cancelar.Visible = False
        combo_marca()
        txt_marca.Clear()
        cbo_marca.SelectedIndex = -1

    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        btn_agregar.Enabled = True
        btn_eliminar.Enabled = True
        btn_modificar.Enabled = True
        txt_modelo.Enabled = True
        btn_guardarmarca.Visible = False
        txt_marca.Enabled = False
        cbo_marca.Enabled = True
        btn_marcanueva.Enabled = True
        btn_cancelar.Visible = False

    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click

        If txt_modelo.Text <> Nothing Then
            oDs = New DataSet
            o_Marca_Modelo = New Marca_Modelo
            o_Marca_Modelo.cargar_equipo(txt_modelo.Text, cbo_marca.SelectedValue)
            MsgBox("Carga exitosa", vbInformation, "TB")
        Else
            MsgBox("Llenar campos vacios.", vbInformation, "TB")
        End If
        limpiar()
        cargar_grilla()

    End Sub

    Private Sub cargar_grilla()

        oDs = New DataSet
        o_Marca_Modelo = New Marca_Modelo
        oDs = o_Marca_Modelo.carga_grilla
        With grl_grilla
            .DataSource = oDs.Tables(0)
        End With

    End Sub

    Private Sub limpiar()

        cbo_marca.SelectedValue = False
        txt_modelo.Text = Nothing

    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        If txt_modelo.Text <> Nothing And cbo_marca.Text <> Nothing Then
            oDs = New DataSet
            o_Marca_Modelo = New Marca_Modelo
            o_Marca_Modelo.modificar_equipo(idmodelo, txt_modelo.Text, cbo_marca.SelectedValue)
            MsgBox("Se modificaron con éxitos los datos del equipo.", vbInformation, "Clientes_TB")
            cargar_grilla()
            limpiar()
            btn_modificar.Enabled = False
        Else
            MsgBox("Completa los campos de marca y modelo.", vbInformation, "Clientes_TB")
        End If
        idmodelo = 0
    End Sub

    Private Sub grl_grilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grl_grilla.CellClick
        If sw1 = 0 Then
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = grl_grilla.Rows(e.RowIndex)
                'Asignar los valores de las celdas a los cuadros de texto
                idmodelo = row.Cells("Código de Modelo").Value.ToString()
                marca_original = row.Cells("Marca").Value.ToString()
                modelo_original = row.Cells("Modelo").Value.ToString()
                cbo_marca.Text = marca_original
                txt_modelo.Text = modelo_original
            End If
            btn_eliminar.Enabled = True
            btn_agregar.Enabled = False
            sw = 1
        Else
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = grl_grilla.Rows(e.RowIndex)
                'Asignar los valores de las celdas a los cuadros de texto
                txt_marca.Text = row.Cells("Marca").Value.ToString()
            End If

        End If
    End Sub

    Private Sub txt_modelo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_modelo.TextChanged

        If sw = 0 Then
            If txt_modelo.Text <> Nothing And cbo_marca.Text <> Nothing Then
                btn_agregar.Enabled = True
            Else
                btn_agregar.Enabled = False
            End If
        ElseIf sw = 1 Then
            If txt_modelo.Text <> modelo_original Or cbo_marca.Text <> marca_original Then
                btn_modificar.Enabled = True
                btn_eliminar.Enabled = False
            Else
                btn_modificar.Enabled = False
            End If
        End If

    End Sub

    Private Sub cbo_marca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_marca.SelectedIndexChanged
        If sw = 0 Then
            If txt_modelo.Text <> Nothing And cbo_marca.Text <> Nothing Then
                btn_agregar.Enabled = True
            Else
                btn_agregar.Enabled = False
            End If
        ElseIf sw = 1 Then
            If txt_modelo.Text <> modelo_original Or cbo_marca.Text <> marca_original Then
                btn_modificar.Enabled = True
                btn_eliminar.Enabled = False
            Else
                btn_modificar.Enabled = False
            End If
        End If

    End Sub

    Private Sub btn_marcanueva_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_marcanueva.Click
        sw1 = 1
        lbl_modelo.Visible = False
        txt_modelo.Visible = False
        btn_guardarmarca.Visible = True
        btn_eliminar_marca.Visible = True
        btn_cancelar.Visible = True
        txt_modelo.Clear()
        cbo_marca.Visible = False
        txt_marca.Visible = True
        btn_marcanueva.Enabled = False
        carga_grilla_x_marca()
        btn_agregar.Visible = False
        btn_modificar.Visible = False
        btn_eliminar.Visible = False
        btn_limpiar.Visible = False
    End Sub

    Private Sub btn_guardarmarca_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardarmarca.Click
        If txt_marca.Text <> Nothing Then
            oDs = New DataSet
            o_Marca_Modelo = New Marca_Modelo
            o_Marca_Modelo.nueva_marca(txt_marca.Text)
            MsgBox("Se agreagó marca con éxito.", vbInformation, "TB SERVICE")
            carga_grilla_x_marca()
            txt_marca.Clear()
            'equipos_combo_marca() CREO QUE DEBO DECLARARLO DESDE UN MODULO , DESDE AL ELIMINAR TAMBIEN.
        Else
            MsgBox("Completar campos vacios.", vbInformation, "TB SERVICE")
            txt_marca.Focus()
        End If
   
    End Sub

    Private Sub btn_cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        grl_grilla.DataSource = Nothing
        lbl_modelo.Visible = True
        txt_modelo.Visible = True
        combo_marca()
        cbo_marca.SelectedIndex = -1
        sw1 = 0
        txt_marca.Visible = False
        txt_marca.Clear()
        cbo_marca.Visible = True
        btn_cancelar.Visible = False
        btn_guardarmarca.Visible = False
        btn_eliminar_marca.Visible = False
        btn_marcanueva.Enabled = True
        cbo_marca.Focus()
        btn_agregar.Visible = True
        btn_modificar.Visible = True
        btn_eliminar.Visible = True
        btn_limpiar.Visible = True
        cargar_grilla()
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        cbo_marca.SelectedIndex = -1
        txt_modelo.Text = Nothing
        idmodelo = 0
        marca_original = 0
        modelo_original = 0
        sw = 0
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
    End Sub

    Private Sub btn_eliminar_marca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_marca.Click
        eliminarmarca()
        txt_marca.Text = Nothing
    End Sub

    Public Sub eliminarmarca()
        oDs = New DataSet
        o_Marca_Modelo = New Marca_Modelo
        o_Marca_Modelo.eliminar_marca(txt_marca.Text)
        MsgBox("Se eliminó marca con éxito.", vbInformation, "TB SERVICE")
        carga_grilla_x_marca()
        limpiar()

    End Sub
End Class