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


    Public Shared Sub InsertarUsuario(nuevoUsuario As Usuario)

        If nuevoUsuario Is Nothing Then
            Throw New Exception("Debe especificar un Usuario a dar de alta")
        End If

        Dim NombreStoreProcedure As String = "InsertarUsuario"

        Dim misParametros As New List(Of SqlParameter)()


        Dim parametroRetorno As New SqlParameter("@idUsuario", SqlDbType.Int)
        parametroRetorno.Direction = ParameterDirection.Output

        misParametros.Add(parametroRetorno)

        misParametros.Add(New SqlParameter("@Usuario", nuevoUsuario.Usuario))
        misParametros.Add(New SqlParameter("@Contraseña", nuevoUsuario.Password))
        misParametros.Add(New SqlParameter("@Tipo", nuevoUsuario.Tipo))


        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)


        Dim UsuarioId As Integer = CInt(parametroRetorno.Value)

        nuevoUsuario.AsignarUsuarioId(UsuarioId)
    End Sub

    Public Shared Sub InsertarUsuario(nuevosUsuarios As List(Of Usuario))

        For Each c As Usuario In nuevosUsuarios
            InsertarUsuario(c)
        Next
    End Sub


    Public Shared Sub EliminaUsuario(nuevoUsuario As Usuario)

        If nuevoUsuario Is Nothing Then
            Throw New Exception("Debe especificar un Usuario a eliminar")
        End If



        Dim NombreStoreProcedure As String = "EliminarUsuario"

        Dim misParametros As New List(Of SqlParameter)()




        misParametros.Add(New SqlParameter("@idUsuario", nuevoUsuario.IdUsuario))

        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)


    End Sub


    Public Shared Sub ModificarUsuario(nuevoUsuario As Usuario)

        If nuevoUsuario Is Nothing Then
            Throw New Exception("Debe especificar que Usuario desea modificar")
        End If
        Dim NombreStoreProcedure As String = "ModificarUsuario"

        Dim misParametros As New List(Of SqlParameter)()
        misParametros.Add(New SqlParameter("@idUsuario", nuevoUsuario.IdUsuario))
        misParametros.Add(New SqlParameter("@Usuario", nuevoUsuario.Usuario))
        misParametros.Add(New SqlParameter("@Contraseña", nuevoUsuario.Password))
        misParametros.Add(New SqlParameter("@Tipo", nuevoUsuario.Tipo))





        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)

    End Sub

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
