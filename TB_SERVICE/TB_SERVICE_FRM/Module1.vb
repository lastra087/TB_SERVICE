Module Module1

    Public fr As Form
    Public id_cliente As Integer
    Public nombre As String
    Public apellido As String
    Public telefono As Long
    Public correo As String
    Public cuil As Long
    Public marca As String
    Public modelo As String
    Public fecha_ingresa As String

    Public Sub carga_panel_padre(ByVal frmhijo As Object)

        If Menu_Frm.pnl_padre.Controls.Count > 0 Then
            Menu_Frm.pnl_padre.Controls.RemoveAt(0)
        End If

        fr = TryCast(frmhijo, Form)
        fr.TopLevel = False
        fr.FormBorderStyle = FormBorderStyle.None ' Corrección aquí
        fr.Dock = DockStyle.Fill
        Menu_Frm.pnl_padre.Controls.Add(fr)
        Menu_Frm.pnl_padre.Tag = fr
        fr.Show()

    End Sub

End Module
