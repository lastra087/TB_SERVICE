Imports System.Data
Imports TB_SERVICE_AD

Public Class Sala_espera_Frm
    Dim oDs As New DataSet
    Dim o_Sala_espera As New Sala_espera

    Private Sub btn_taller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        carga_panel_padre(New Taller_Frm)
    End Sub

    Private Sub Sala_espera_Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grilla_taller()
    End Sub

    Public Sub grilla_taller()
        oDs = New DataSet
        o_Sala_espera = New Sala_espera
        oDs = o_Sala_espera.grilla_taller
        With grl_grilla
            .DataSource = oDs.Tables(0)
        End With
    End Sub

    Private Sub grl_grilla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grl_grilla.CellClick

        If e.RowIndex >= 0 Then

            Dim selectedRow As DataGridViewRow = grl_grilla.Rows(e.RowIndex)

            Dim marca As String = selectedRow.Cells("Marca").Value.ToString()
            Dim modelo As String = selectedRow.Cells("Modelo").Value.ToString()
            Dim fechaIngreso As String = selectedRow.Cells("Fecha_Ingreso").Value.ToString()
            Dim problemaReportado As String = selectedRow.Cells("Problema Reportado").Value.ToString()


            Dim Taller As New Taller_Frm()

            Taller.txt_marca.Text = marca
            Taller.txt_modelo.Text = modelo
            Taller.txt_fecha_ingreso.Text = fechaIngreso
            Taller.txt_problema_reportado.Text = problemaReportado

            carga_panel_padre(Taller)

        End If

    End Sub

    Private Sub lbl_cerrar_Click(sender As System.Object, e As System.EventArgs) Handles lbl_cerrar.Click

        Me.Close()

    End Sub
End Class