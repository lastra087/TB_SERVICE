Imports System.Data
Imports TB_SERVICE_AD

Public Class Repuestos_Frm

    Dim oDs As New DataSet
    Dim o_Repuesto As New Repuestos

    Private Sub Repuestos_Frm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        combo_proveedor()
        Cargar_Grilla()
    End Sub

    Private Sub Cargar_Grilla()

        oDs = New DataSet
        o_Repuesto = New Repuestos
        oDs = o_Repuesto.cargar_grilla_repuestos
        With dgv_repuestos
            .DataSource = oDs.Tables(0)
        End With

    End Sub

    Private Sub Limpiar()

        txt_id.Text = Nothing
        txt_repuesto.Text = Nothing
        txt_precio.Text = Nothing
        txt_stock.Text = Nothing
        txt_descripcion.Text = Nothing


    End Sub

    Public Sub combo_proveedor()

        Dim o_Repuesto As New Repuestos
        oDs = o_Repuesto.combo_proveedor
        With cbo_proveedor
            .DataSource = oDs.Tables(0)
            .DisplayMember = oDs.Tables(0).Columns(1).ToString
            .ValueMember = oDs.Tables(0).Columns(0).ToString
        End With

    End Sub

    Private Sub btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar.Click

        If txt_repuesto.Text <> Nothing And txt_precio.Text <> Nothing And txt_stock.Text <> Nothing And txt_descripcion.Text <> Nothing Then

            oDs = New DataSet
            o_Repuesto = New Repuestos

            o_Repuesto.agregar_repuesto(txt_repuesto.Text, txt_stock.Text, txt_precio.Text, txt_descripcion.Text, cbo_proveedor.SelectedValue)

            MsgBox("Se cargaron con éxitos los datos del nuevo repuesto.", vbInformation, "Repuestos_TB")

            Cargar_Grilla()
            Limpiar()

        Else

            MsgBox("Complete todos los campos.", vbInformation, "Repuestos_TB")

        End If

    End Sub

    Private Sub btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles btn_modificar.Click

        If txt_id.Text <> Nothing And txt_repuesto.Text <> Nothing And txt_precio.Text <> Nothing And txt_stock.Text <> Nothing And txt_descripcion.Text <> Nothing Then

            oDs = New DataSet
            o_Repuesto = New Repuestos

            o_Repuesto.modificar_repuesto(txt_id.Text, txt_repuesto.Text, txt_precio.Text, txt_stock.Text, txt_descripcion.Text, cbo_proveedor.SelectedValue)

            MsgBox("Se modifico con exito", vbInformation, "Repuestos_TB")

            Cargar_Grilla()
            Limpiar()

        Else
            MsgBox("Complete los datos", vbInformation, "Repuestos_TB")

        End If



    End Sub

    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click

        If txt_id.Text <> Nothing Then

            oDs = New DataSet
            o_Repuesto = New Repuestos

            o_Repuesto.eliminar_repuestos(txt_id.Text)

            MsgBox("Repuesto eliminado con exito", vbInformation, "Repuestos_TB")

            Cargar_Grilla()
            Limpiar()

        Else
            MsgBox("Ingrese un ID", vbInformation, "Repuestos_TB")

        End If

    End Sub

    Private Sub btn_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles btn_limpiar.Click

        Limpiar()

    End Sub

    Private Sub btn_mostrar_todo_Click(sender As System.Object, e As System.EventArgs) Handles btn_mostrar_todo.Click

        Cargar_Grilla()

    End Sub


    Private Sub btn_buscar_Click(sender As System.Object, e As System.EventArgs) Handles btn_buscar.Click

        If txt_buscar_repuesto.Text <> Nothing Then

            oDs = New DataSet
            o_Repuesto = New Repuestos
            oDs = o_Repuesto.buscar_repuesto(txt_buscar_repuesto.Text)
            With dgv_repuestos
                .DataSource = oDs.Tables(0)
            End With

            Limpiar()

        Else
            MsgBox("Ingrese una Ciudad", vbInformation, "Consultar datos")

        End If

    End Sub
End Class