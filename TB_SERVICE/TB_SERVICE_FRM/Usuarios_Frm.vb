Imports System.Data
Imports TB_SERVICE_AD
'Imports Twilio
'Imports Twilio.Rest.Api.V2010.Account
'Imports Twilio.Types

Public Class Usuarios_Frm

    Dim oDs As New DataSet
    Dim o_Usuarios As New Usuarios

    Private Sub Usuarios_Frm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbo_cargo.DropDownStyle = ComboBoxStyle.DropDownList

        cbo_cargo.Items.Add("Seleccione un cargo")
        cbo_cargo.Items.Add("Administrador")
        cbo_cargo.Items.Add("Tecnico")
        cbo_cargo.Items.Add("Recepcionista")


        cbo_cargo.SelectedIndex = 0

        Cargar_Grilla()
    End Sub

    Private Sub Limpiar()

        txt_id.Text = Nothing
        txt_usuario.Text = Nothing
        txt_contraseña.Text = Nothing
        cbo_cargo.SelectedIndex = 0

    End Sub

    Private Sub Cargar_Grilla()
        oDs = New DataSet
        o_Usuarios = New Usuarios
        oDs = o_Usuarios.cargar_grilla_usuarios
        With dgv_usuarios
            .DataSource = oDs.Tables(0)
        End With
    End Sub

    Private Sub lbl_cerrar_Click(sender As System.Object, e As System.EventArgs) Handles lbl_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar.Click
        If txt_usuario.Text <> String.Empty AndAlso txt_contraseña.Text <> String.Empty AndAlso cbo_cargo.SelectedIndex > 0 Then
            oDs = New DataSet
            o_Usuarios = New Usuarios
            o_Usuarios.agregar_usuario(txt_usuario.Text, txt_contraseña.Text, cbo_cargo.SelectedItem.ToString())
            MsgBox("Se cargaron con éxito los datos del nuevo usuario.", vbInformation, "Usuarios")
            Cargar_Grilla()
            Limpiar()
        Else
            MsgBox("Complete todos los campos.", vbInformation, "Usuarios")
        End If
    End Sub


    Private Sub btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles btn_modificar.Click
        If txt_id.Text <> Nothing And txt_usuario.Text <> String.Empty AndAlso txt_contraseña.Text <> String.Empty AndAlso cbo_cargo.SelectedIndex > 0 Then
            oDs = New DataSet
            o_Usuarios = New Usuarios
            o_Usuarios.modificar_usuario(txt_id.Text, txt_usuario.Text, txt_contraseña.Text, cbo_cargo.SelectedItem.ToString())
            MsgBox("Se modifico con exito", vbInformation, "Usuarios")
            Cargar_Grilla()
            Limpiar()
        Else
            MsgBox("Complete los datos", vbInformation, "Usuarios")
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click

        If txt_id.Text <> Nothing Then
            oDs = New DataSet
            o_Usuarios = New Usuarios
            o_Usuarios.eliminar_usuario(txt_id.Text)
            MsgBox("se elimino con exito", vbInformation, "Usuarios")
            Cargar_Grilla()
            Limpiar()
        Else
            MsgBox("Ingrese un ID", vbInformation, "Usuarios")
        End If

    End Sub

    Private Sub btn_buscar_Click(sender As System.Object, e As System.EventArgs) Handles btn_buscar.Click

        If txt_buscar.Text <> Nothing Then
            oDs = New DataSet
            o_Usuarios = New Usuarios
            oDs = o_Usuarios.buscar_usuario(txt_buscar.Text)
            With dgv_usuarios
                .DataSource = oDs.Tables(0)
            End With
            Limpiar()
        Else
            MsgBox("Ingrese un usaurio", vbInformation, "Consultar datos")
        End If

    End Sub

    Private Sub btn_mostrar_todo_Click(sender As System.Object, e As System.EventArgs) Handles btn_mostrar_todo.Click

        Cargar_Grilla()

    End Sub

    Private Sub dgv_usuarios_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_usuarios.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv_usuarios.Rows(e.RowIndex)
            txt_id.Text = row.Cells("Codigo").Value.ToString()
            txt_usuario.Text = row.Cells("Usuario").Value.ToString()
            txt_contraseña.Text = row.Cells("Contraseña").Value.ToString()
            cbo_cargo.Text = row.Cells("Cargo").Value.ToString()
        End If
    End Sub

    Private Sub txt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_limpiar.Click
        txt_id.Clear()
        txt_usuario.Clear()
        txt_contraseña.Clear()
        cbo_cargo.SelectedIndex = 0
    End Sub
End Class