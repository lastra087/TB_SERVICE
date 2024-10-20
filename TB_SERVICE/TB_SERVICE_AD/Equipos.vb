﻿Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class Equipos

    Dim o_database As Database

    Public Sub New()
        o_database = DatabaseFactory.CreateDatabase("conn")
    End Sub

    Public Function combo_marca() As DataSet
        Return o_database.ExecuteDataSet("combo_marca")
    End Function

    Public Function combo_fallas() As DataSet
        Return o_database.ExecuteDataSet("Equipos_combo_fallas")
    End Function

    Public Function combo_modelo_x_marca(ByVal idmarca As Integer) As DataSet
        Return o_database.ExecuteDataSet("combo_modelo_x_marca", idmarca)
    End Function

    Public Function cargar_equipos(ByVal idmarcas As Integer, ByVal idmodelos As Integer, ByVal idcliente As Integer, ByVal fecha_ingreso As Date, ByVal problema_reportado As Integer) As Double
        Return o_database.ExecuteScalar("cargar_equipos", idmarcas, idmodelos, idcliente, fecha_ingreso, problema_reportado)
    End Function

    Public Function grilla_sala_espera() As DataSet
        Return o_database.ExecuteDataSet("grilla_taller")
        'equipos_sala_espera procedidiemto viejo
    End Function
End Class
