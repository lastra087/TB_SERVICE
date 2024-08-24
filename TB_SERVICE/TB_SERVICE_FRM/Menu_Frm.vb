Public Class Menu_Frm
    Dim sw As Integer = 0
    Private Sub tm_ver_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm_ver.Tick

        If pnl_menu.Width >= 200 Then
            tm_ver.Enabled = False
        Else
            pnl_menu.Width = pnl_menu.Width + 10
        End If

    End Sub

    Private Sub tm_ocultar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tm_ocultar.Tick

        If pnl_menu.Width <= 50 Then
            tm_ocultar.Enabled = False
        Else
            pnl_menu.Width = pnl_menu.Width - 10
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcb_menu.Click

        If pnl_menu.Width = 200 Then
            tm_ocultar.Enabled = True
        ElseIf pnl_menu.Width = 50 Then
            tm_ver.Enabled = True
        End If

    End Sub

    Private Sub Menu_Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        pnl_menu.Width = 50
        lbl_logo.Width = 200
        btn_clientes.Width = 220
        btn_equipos.Width = 220
        btn_estadistico.Width = 220
        btn_proveedores.Width = 220
        btn_taller.Width = 220
        btn_repuestos.Width = 220
        btn_usuarios.Width = 220

    End Sub
    Public Sub resetea_colores()
        btn_clientes.BackColor = Color.FromArgb(7, 25, 82)
        btn_proveedores.BackColor = Color.FromArgb(7, 25, 82)
        btn_repuestos.BackColor = Color.FromArgb(7, 25, 82)
        btn_taller.BackColor = Color.FromArgb(7, 25, 82)
        btn_equipos.BackColor = Color.FromArgb(7, 25, 82)
        btn_estadistico.BackColor = Color.FromArgb(7, 25, 82)
        btn_usuarios.BackColor = Color.FromArgb(7, 25, 82)
    End Sub

    Public Sub pinta_boton_clickeado(ByVal btn As Button)
        If btn.BackColor = Color.FromArgb(7, 25, 82) Then
            resetea_colores()
            btn.BackColor = Color.FromArgb(55, 183, 195)
        Else
            btn.BackColor = Color.FromArgb(55, 183, 195)
        End If
    End Sub

    Private Sub btn_clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clientes.Click
        pinta_boton_clickeado(btn_clientes)
        carga_panel_padre(New Clientes_Frm)

    End Sub

    Private Sub btn_equipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_equipos.Click
        pinta_boton_clickeado(btn_equipos)
        carga_panel_padre(New Marca_Modelo_Frm)
    End Sub


    Private Sub btn_proveedores_Click(sender As System.Object, e As System.EventArgs) Handles btn_proveedores.Click
        pinta_boton_clickeado(btn_proveedores)
        carga_panel_padre(New Proveedores_Frm)

    End Sub

    Private Sub btn_repuestos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_repuestos.Click
        pinta_boton_clickeado(btn_repuestos)
        carga_panel_padre(New Repuestos_Frm)
    End Sub

    Private Sub btn_taller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_taller.Click
        pinta_boton_clickeado(btn_taller)
        carga_panel_padre(New Sala_espera_Frm)
    End Sub

    Private Sub btn_estadistico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_estadistico.Click
        pinta_boton_clickeado(btn_estadistico)
        carga_panel_padre(New Estadisticas_Frm)
    End Sub

    Private Sub btn_usuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_usuarios.Click
        pinta_boton_clickeado(btn_usuarios)
        carga_panel_padre(New Usuarios_Frm)
    End Sub

    Private Sub pnl_padre_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnl_padre.Paint

    End Sub

End Class
