Module Module1
    Public frmPadre As Menu_Frm
    Public id_cliente As Integer
    Public nombre As String
    Public apellido As String
    Public telefono As String
    Public correo As String
    Public cuil As String
    Public marca As String
    Public modelo As String
    Public fecha_ingresa As String

    Public Sub carga_panel_padre(ByVal frmhijo As Form, ByVal frmPadre As Menu_Frm)

        If frmPadre Is Nothing Then
            MessageBox.Show("El formulario principal no está inicializado.")
            Return
        End If

        If frmPadre.pnl_padre Is Nothing Then
            MessageBox.Show("El panel contenedor no está inicializado.")
            Return
        End If

        If frmPadre.pnl_padre.Controls.Count > 0 Then
            frmPadre.pnl_padre.Controls.RemoveAt(0)
        End If

        frmhijo.TopLevel = False
        frmhijo.FormBorderStyle = FormBorderStyle.None
        frmhijo.Dock = DockStyle.Fill
        frmPadre.pnl_padre.Controls.Add(frmhijo)
        frmPadre.pnl_padre.Tag = frmhijo
        frmhijo.Show()
    End Sub

End Module
'If Menu_Frm.pnl_padre.Controls.Count > 0 Then
'    Menu_Frm.pnl_padre.Controls.RemoveAt(0)
'End If
'fr = TryCast(frmhijo, Form)
'fr.TopLevel = False
'fr.FormBorderStyle = FormBorderStyle.None ' Corrección aquí
'fr.Dock = DockStyle.Fill
'Menu_Frm.pnl_padre.Controls.Add(fr)
'Menu_Frm.pnl_padre.Tag = fr
'fr.Show()
