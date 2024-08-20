Imports Microsoft.VisualBasic
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

    Public Function equipos_combo_marc() As DataSet
        Return o_database.ExecuteDataSet("combo_marca")
    End Function

    Public Function combo_modelos_x_marca(ByVal idmarca As Integer) As DataSet
        Return o_database.ExecuteDataSet("combo_modelo_x_marca", idmarca)
    End Function

End Class
