Imports System.Data
Imports TB_SERVICE_AD

Public Class Login_Frm
    Dim oDs As New DataSet
    Dim o_Login As New Login

    Private Sub Login_Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txt_contraseña.PasswordChar = "•"c

    End Sub

    Private Sub btn_entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_entrar.Click

        If String.IsNullOrEmpty(txt_usuario.Text) OrElse String.IsNullOrEmpty(txt_contraseña.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Exit Sub
        End If
        Dim username As String = txt_usuario.Text
        Dim password As String = txt_contraseña.Text
        Dim userRole As String = o_Login.inicio_sesion(username, password)

        If Not String.IsNullOrEmpty(userRole) Then
            frmPadre = New Menu_Frm
            frmPadre.UserRole = userRole ' Pasar el rol de usuario al menú principal
            frmPadre.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos")
            txt_usuario.Clear()
            txt_contraseña.Clear()
            txt_usuario.Focus()
        End If

    End Sub


    Private Sub chk_mostrar_contraseña_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_mostrar_contraseña.CheckedChanged

        If chk_mostrar_contraseña.Checked Then
            txt_contraseña.PasswordChar = ControlChars.NullChar
        Else
            txt_contraseña.PasswordChar = "•"c
        End If

    End Sub
End Class


