Imports Mappers
Imports Entidades
Imports System.Data.SqlClient
Imports Datos

Public Class UsuarioMappers

    Public Shared Function ObtenerTodos() As List(Of Usuario)
        Dim Conexion As ConexionDB
        Dim NombreStoreProcedure As String = "ObtenerTodosUsuario"


        Dim datos As DataTable = Conexion.ObtenerDatos(NombreStoreProcedure)

        Return ConvertirRowEnUsuario(datos.Rows)
    End Function

    Private Shared Function ConvertirRowEnUsuario(row As DataRow) As Usuario

        Dim miUsuario As New Usuario(CStr(row("idUsuario")))
        miUsuario.Usuario = row("Usuario").ToString()
        miUsuario.Password = row("Contraseña").ToString()
        miUsuario.Tipo = row("Tipo").ToString()
        Return miUsuario
    End Function
    Private Shared Function ConvertirRowEnUsuario(rows As DataRowCollection) As List(Of Usuario)

        Dim misUsuario As New List(Of Usuario)()
        For Each registro As DataRow In rows

            Dim unUsuario As Usuario = Nothing

            unUsuario = ConvertirRowEnUsuario(registro)


            misUsuario.Add(unUsuario)
        Next
        Return misUsuario
    End Function

End Class
