Imports System.Data
Imports TB_SERVICE_AD

Public Class Clientes_Frm

    Dim sw As Integer = 0
    Dim idcliente As Integer = 0

    Dim oDs As New DataSet
    Dim o_Clientes As New Clientes

    Private Sub Clientes_Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carga_grilla()
        txt_nombre.Focus()
        btn_agregar.Enabled = False
        btn_modificar.Enabled = False
        btn_equipos.Enabled = False
    End Sub

    Public Sub limpiar_campos()

        txt_nombre.Clear()
        txt_apellido.Clear()
        txt_telefono.Clear()
        txt_correo.Clear()
        txt_cuil.Clear()
        txt_nombre.Focus()

    End Sub

    Public Sub carga_grilla()

        oDs = New DataSet
        o_Clientes = New Clientes
        oDs = o_Clientes.carga_grilla
        With grl_grilla
            .DataSource = oDs.Tables(0)
        End With

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

        Me.Close()

    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click

        If txt_nombre.Text <> Nothing Then
            Dim oDs As New DataSet
            Dim o_Clientes As New Clientes
            oDs = o_Clientes.buscar_x_nombre(txt_nombre.Text)
            With grl_grilla
                .DataSource = oDs.Tables(0)
            End With
        Else
            MsgBox("Ingrese un nombre para realizar la búsqueda.", vbInformation, "Clientes_TB")
        End If

    End Sub

    Private Sub grl_grilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grl_grilla.CellClick

        If e.RowIndex >= 0 Then
            sw = 1
            Dim row As DataGridViewRow = grl_grilla.Rows(e.RowIndex)
            'Asignar los valores de las celdas a los cuadros de texto
            idcliente = row.Cells("Código del Cliente").Value.ToString()
            txt_nombre.Text = row.Cells("Nombre").Value.ToString()
            txt_apellido.Text = row.Cells("Apellido").Value.ToString()
            txt_telefono.Text = row.Cells("Teléfono").Value.ToString()
            txt_correo.Text = row.Cells("Correo").Value.ToString()
            txt_cuil.Text = row.Cells("Cuil").Value.ToString()
        End If

        sw = 2
        btn_agregar.Enabled = False
        btn_equipos.Enabled = True
        btn_buscar.Enabled = False

    End Sub

    Public Sub campos_llenos()

        If sw = 0 Then
            If txt_nombre.Text <> Nothing And txt_apellido.Text <> Nothing And txt_telefono.Text <> Nothing And txt_correo.Text <> Nothing And txt_cuil.Text <> Nothing Then
                btn_agregar.Enabled = True
                btn_buscar.Enabled = False
            Else
                btn_agregar.Enabled = False
                btn_buscar.Enabled = True
            End If
        ElseIf sw = 2 Then
            If txt_nombre.Text <> Nothing And txt_apellido.Text <> Nothing And txt_telefono.Text <> Nothing And txt_correo.Text <> Nothing And txt_cuil.Text <> Nothing Then
                btn_modificar.Enabled = True
                btn_equipos.Enabled = False
            Else
                btn_modificar.Enabled = False
            End If
        End If

    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged

        campos_llenos()

    End Sub

    Private Sub txt_apellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_apellido.TextChanged

        campos_llenos()

    End Sub

    Private Sub txt_telefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_telefono.TextChanged

        campos_llenos()

    End Sub

    Private Sub txt_correo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_correo.TextChanged

        campos_llenos()

    End Sub

    Private Sub txt_cuil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cuil.TextChanged

        campos_llenos()

    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click

        oDs = New DataSet
        o_Clientes = New Clientes
        o_Clientes.nuevo_cliente(txt_nombre.Text, txt_apellido.Text, txt_telefono.Text, txt_correo.Text, txt_cuil.Text)
        MsgBox("Se cargaron con éxitos los datos de nuevo cliente.", vbInformation, "Clientes_TB")
        carga_grilla()
        limpiar_campos()
        txt_nombre.Focus()

    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click

        sw = 0
        limpiar_campos()
        btn_modificar.Enabled = False
        carga_grilla()
        btn_equipos.Enabled = False
        btn_buscar.Enabled = True

    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click

        oDs = New DataSet
        o_Clientes = New Clientes
        o_Clientes.modificar_cliente(idcliente, txt_nombre.Text, txt_apellido.Text, txt_telefono.Text, txt_correo.Text, txt_cuil.Text)
        MsgBox("Se modificaron con éxitos los datos del cliente.", vbInformation, "Clientes_TB")
        carga_grilla()
        limpiar_campos()
        txt_nombre.Focus()
        'btn_modificar.Enabled = False
        sw = 0
        btn_buscar.Enabled = True

    End Sub

    Private Sub btn_taller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_equipos.Click
        nombre = txt_nombre.Text
        apellido = txt_apellido.Text
        telefono = txt_telefono.Text
        correo = txt_correo.Text
        cuil = txt_cuil.Text
        carga_panel_padre(New Equipos_Frm)

    End Sub

End Class