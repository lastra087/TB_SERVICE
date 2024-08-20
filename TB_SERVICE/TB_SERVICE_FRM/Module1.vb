Module Module1
    Public fr As Form
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
        'Dim fr As Form
        fr = TryCast(frmhijo, Form)
        fr.TopLevel = False
        fr.FormBorderStyle = Windows.Forms.BorderStyle.None
        fr.Dock = DockStyle.Fill
        Menu_Frm.pnl_padre.Controls.Add(fr)
        Menu_Frm.pnl_padre.Tag = fr
        fr.Show()
    End Sub
End Module
