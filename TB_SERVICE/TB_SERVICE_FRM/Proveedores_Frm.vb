Imports System.Data
Imports TB_SERVICE_AD

Public Class Proveedores_Frm
    Dim oDs As New DataSet
    Dim o_Proveedores As New Proveedores

    Private Sub Proveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        cargar_grilla()
        btn_agregar.Enabled = False
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
        btn_mostrar_tabla.Enabled = False
        btn_limpiar.Enabled = False

    End Sub

    Private Sub cargar_grilla()

        oDs = New DataSet
        o_Proveedores = New Proveedores
        oDs = o_Proveedores.carga_grilla_proveedor
        With grl_grilla
            .DataSource = oDs.Tables(0)
        End With

    End Sub

    Private Sub grl_grilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grl_grilla.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = grl_grilla.Rows(e.RowIndex)

            txt_id.Text = row.Cells("Codigo de Proveedor").Value.ToString()
            txt_razon_social.Text = row.Cells("Razon Social").Value.ToString()
            txt_cuit.Text = row.Cells("Cuit").Value.ToString()
            txt_telefono.Text = row.Cells("Telefono").Value.ToString()
            txt_direccion.Text = row.Cells("Direccion").Value.ToString()

        End If
    End Sub

    Public Sub Limpiar()

        txt_id.Text = Nothing
        txt_razon_social.Text = Nothing
        txt_cuit.Text = Nothing
        txt_telefono.Text = Nothing
        txt_direccion.Text = Nothing

    End Sub

    Private Sub btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar.Click

        If txt_razon_social.Text <> Nothing And txt_cuit.Text <> Nothing And txt_telefono.Text <> Nothing And txt_direccion.Text <> Nothing Then
            oDs = New DataSet
            o_Proveedores = New Proveedores
            o_Proveedores.cargar_proveedor(txt_razon_social.Text, txt_cuit.Text, txt_telefono.Text, txt_direccion.Text)
            MsgBox("Carga exitosa", vbInformation, "TB")
        Else
            MsgBox("Llenar campos vacios.", vbInformation, "TB")
        End If

        Limpiar()
        cargar_grilla()

    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click

        If txt_id.Text <> Nothing And txt_razon_social.Text <> Nothing And txt_cuit.Text <> Nothing And txt_telefono.Text <> Nothing And txt_direccion.Text <> Nothing Then

            oDs = New DataSet
            o_Proveedores = New Proveedores
            o_Proveedores.modificar_proveedor(txt_id.Text, txt_razon_social.Text, txt_cuit.Text, txt_telefono.Text, txt_direccion.Text)

            MsgBox("Se modificaron con éxitos los datos del equipo.", vbInformation, "Clientes_TB")

        Else
            MsgBox("Completa los campos de proveedor", vbInformation, "Clientes_TB")

        End If

        cargar_grilla()
        Limpiar()

    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click

        If txt_id.Text <> Nothing Then

            oDs = New DataSet
            o_Proveedores = New Proveedores

            o_Proveedores.Eliminar_Proveedor(txt_id.Text)

            MsgBox("Proveedor eliminado con exito", vbInformation, "Eliminacion exitosa")

            cargar_grilla()
            Limpiar()

        Else
            MsgBox("Ingrese un ID", vbInformation, "Campos vacios")

        End If

    End Sub

    Private Sub btn_consultar_razon_social_Click(sender As System.Object, e As System.EventArgs) Handles btn_consultar_razon_social.Click

        If txt_razon_social.Text <> Nothing Then
            oDs = New DataSet
            o_Proveedores = New Proveedores
            oDs = o_Proveedores.Consultar_Razon_Social(txt_razon_social.Text)
            With grl_grilla
                .DataSource = oDs.Tables(0)
            End With

            Limpiar()
            btn_mostrar_tabla.Enabled = True

        Else
            MsgBox("Ingrese una Razon Social", vbInformation, "Consultar datos")

        End If
    End Sub

    Private Sub btn_mostrar_tabla_Click(sender As System.Object, e As System.EventArgs) Handles btn_mostrar_tabla.Click

        cargar_grilla()
        btn_mostrar_tabla.Enabled = False

    End Sub

    Private Sub lbl_cerrar_Click(sender As System.Object, e As System.EventArgs) Handles lbl_cerrar.Click

        Me.Close()

    End Sub

    Public Sub campos_llenos()

        If txt_razon_social.Text <> Nothing And txt_cuit.Text <> Nothing And txt_telefono.Text <> Nothing And txt_direccion.Text <> Nothing Then

            btn_agregar.Enabled = True
            btn_consultar_razon_social.Enabled = False

        Else

            btn_agregar.Enabled = False
            btn_consultar_razon_social.Enabled = True

        End If


        If txt_razon_social.Text <> Nothing And txt_cuit.Text <> Nothing And txt_telefono.Text <> Nothing And txt_direccion.Text <> Nothing Then

            btn_modificar.Enabled = True
            btn_consultar_razon_social.Enabled = False

        Else

            btn_modificar.Enabled = False
            btn_consultar_razon_social.Enabled = True

        End If

        If txt_id.Text <> Nothing Then

            btn_eliminar.Enabled = True
            btn_consultar_razon_social.Enabled = False

        Else

            btn_eliminar.Enabled = False
            btn_consultar_razon_social.Enabled = True

        End If

        If txt_id.Text <> Nothing Or txt_razon_social.Text <> Nothing Or txt_cuit.Text <> Nothing Or txt_telefono.Text <> Nothing Or txt_direccion.Text <> Nothing Then

            btn_limpiar.Enabled = True
            btn_consultar_razon_social.Enabled = True

        Else

            btn_limpiar.Enabled = False
            btn_consultar_razon_social.Enabled = True

        End If

    End Sub


    Private Sub txt_razon_social_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_razon_social.TextChanged

        campos_llenos()

    End Sub

    Private Sub txt_cuit_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_cuit.TextChanged

        campos_llenos()

    End Sub

    Private Sub txt_telefono_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_telefono.TextChanged

        campos_llenos()

    End Sub

    Private Sub txt_direccion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_direccion.TextChanged

        campos_llenos()

    End Sub

    Private Sub btn_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles btn_limpiar.Click

        Limpiar()

    End Sub
End Class