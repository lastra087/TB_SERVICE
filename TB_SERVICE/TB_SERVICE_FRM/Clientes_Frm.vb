Imports System.Data
Imports TB_SERVICE_AD
Imports System.Diagnostics
Imports System.Net
Imports System.IO

Public Class Clientes_Frm

    Dim sw As Integer = 0
    Dim idcliente As Integer = 0
    Dim oDs As New DataSet
    Dim o_Clientes As New Clientes
    Private dv As DataView

    Private Sub Clientes_Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carga_grilla()
        txt_nombre.Focus()
        btn_agregar.Enabled = False
        btn_modificar.Enabled = False
        btn_equipos.Enabled = False
        btn_buscar.Visible = False

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
        dv = New DataView(oDs.Tables(0))
        With grl_grilla
            .DataSource = dv
        End With

    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click

        If txt_buscar.Text <> Nothing Then
            Dim oDs As New DataSet
            Dim o_Clientes As New Clientes
            oDs = o_Clientes.buscar_x_nombre(txt_buscar.Text)
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

    Private Sub txt_telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_telefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub txt_correo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_correo.TextChanged

        campos_llenos()

    End Sub

    Private Sub txt_cuil_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        campos_llenos()

    End Sub

    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        Dim tel_sin As String = txt_telefono.Text
        Dim cuil_sin As String = txt_cuil.Text
        tel_sin = tel_sin.Replace("-", "")
        cuil_sin = cuil_sin.Replace("-", "")
        oDs = New DataSet
        o_Clientes = New Clientes
        o_Clientes.nuevo_cliente(txt_nombre.Text, txt_apellido.Text, tel_sin, txt_correo.Text, cuil_sin)
        MsgBox("Se cargaron con éxitos los datos de nuevo cliente.", vbInformation, "Clientes_TB")
        carga_grilla()
        limpiar_campos()
        txt_nombre.Focus()

    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        sw = 0
        txt_buscar.Clear()
        limpiar_campos()
        btn_modificar.Enabled = False
        carga_grilla()
        btn_equipos.Enabled = False
        btn_buscar.Enabled = True

    End Sub

    Private Sub btn_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_modificar.Click
        Dim tel_sin As String = txt_telefono.Text
        Dim cuil_sin As String = txt_cuil.Text
        tel_sin = tel_sin.Replace("-", "")
        cuil_sin = cuil_sin.Replace("-", "")
        oDs = New DataSet
        o_Clientes = New Clientes
        o_Clientes.modificar_cliente(idcliente, txt_nombre.Text, txt_apellido.Text, tel_sin, txt_correo.Text, cuil_sin)
        MsgBox("Se modificaron con éxitos los datos del cliente.", vbInformation, "Clientes_TB")
        carga_grilla()
        limpiar_campos()
        txt_nombre.Focus()
        sw = 0
        btn_buscar.Enabled = True

    End Sub

    Private Sub btn_taller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_equipos.Click
        id_cliente = idcliente
        nombre = txt_nombre.Text
        apellido = txt_apellido.Text
        telefono = txt_telefono.Text
        correo = txt_correo.Text
        cuil = txt_cuil.Text
        carga_panel_padre(New Equipos_Frm, frmPadre)
    End Sub

    Private Sub lbl_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_cerrar.Click

        Me.Close()

    End Sub

    Private Sub txt_telefono_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_telefono.GotFocus
        txt_telefono.SelectionStart = 3
    End Sub

    Private Sub txt_telefono_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txt_telefono.MaskInputRejected
        campos_llenos()
    End Sub

    Private Sub txt_cuil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cuil.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cuil_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txt_cuil.MaskInputRejected
        campos_llenos()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim message As String = "Hola, este es un mensaje enviado desde mi aplicación."
        Dim phoneNumber As String = "5493573500528"
        Dim encodedMessage As String = Uri.EscapeDataString(message)
        Dim wsapurl As String = "https://wa.me/" & phoneNumber & "?text=" & encodedMessage
        Process.Start(wsapurl)

        'Dim mensaje As String = "Hola"
        'enviarwsap(mensaje)
    End Sub

    'Private Sub enviarwsap(ByVal mensaje As String)
    '    Dim url As String = "https://tu-api-de-whatsapp.com/sendMessage"
    '    Dim numero As String = "+5493573500528"
    '    Dim data As String = "{ ""phone"":""" & numero & """,""mesasge"":""" & mensaje & """}"
    '    Using Client As New WebClient()
    '        Try
    '            Client.Headers(HttpRequestHeader.ContentType) = "application/json "
    '            Dim response As String = Client.UploadString(url, "POST", data)
    '            MessageBox.Show("Mensaje enviado correctamente. Respuesta: " & response)
    '        Catch ex As Exception
    '            MessageBox.Show("Error al enviar mensaje: " & ex.Message)
    '        End Try
    '    End Using
    'End Sub

    Private Sub txt_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar.TextChanged
        If dv IsNot Nothing Then
            dv.RowFilter = "[Nombre] LIKE '%" & txt_buscar.Text & "%'"
        End If
    End Sub

End Class



