Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class ProveedoresMappers


    Public Shared Function ObtenerTodos() As ProveedoresList
        Dim Conexion As ConexionDB
        Dim NombreStoreProcedure As String = "ObtenerTodosProveedores"
        Dim datos As DataTable = Conexion.ObtenerDatos(NombreStoreProcedure)

        Return ConvertirRowEnProveedor(datos.Rows)
    End Function



    Public Shared Sub InsertarProveedor(nuevoProveedor As Proveedor)

        If nuevoProveedor Is Nothing Then
            Throw New Exception("Debe especificar un proveedor a dar de alta")
        End If

        nuevoProveedor.Validador()

        Dim NombreStoreProcedure As String = "InsertarProveedor"

        Dim misParametros As New List(Of SqlParameter)()


        Dim parametroRetorno As New SqlParameter("@idProveedor", SqlDbType.Int)
        parametroRetorno.Direction = ParameterDirection.Output

        misParametros.Add(parametroRetorno)

        misParametros.Add(New SqlParameter("@Nombre", nuevoProveedor.nombre))
        misParametros.Add(New SqlParameter("@Direccion", nuevoProveedor.direccion))
        misParametros.Add(New SqlParameter("@Localidad", nuevoProveedor.localidad))
        misParametros.Add(New SqlParameter("@Email", nuevoProveedor.email))
        misParametros.Add(New SqlParameter("@Telefono", nuevoProveedor.telefono))
        misParametros.Add(New SqlParameter("@Descripcion", nuevoProveedor.Descripcion))

        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)


        Dim ProveedorId As Integer = CInt(parametroRetorno.Value)

        nuevoProveedor.AsignarProveedorId(ProveedorId)
    End Sub

    Public Shared Sub InsertarProveedor(nuevosProveedores As List(Of Proveedor))

        For Each c As Proveedor In nuevosProveedores
            InsertarProveedor(c)
        Next
    End Sub

    Public Shared Sub EliminaProveedor(nuevoProveedor As Proveedor)

        If nuevoProveedor Is Nothing Then
            Throw New Exception("Debe especificar un Proveedor a eliminar")
        End If

        nuevoProveedor.Validador()

        Dim NombreStoreProcedure As String = "EliminarProveedor"

        Dim misParametros As New List(Of SqlParameter)()




        misParametros.Add(New SqlParameter("@idProveedor", nuevoProveedor.IdProveedor))

        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)


    End Sub


    Public Shared Sub ModificarProveedor(nuevoProveedor As Proveedor)

        If nuevoProveedor Is Nothing Then
            Throw New Exception("Debe especificar que Proveedor desea modificar")
        End If
        nuevoProveedor.Validador()

        Dim NombreStoreProcedure As String = "ModificarProveedor"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@idProveedor", nuevoProveedor.IdProveedor))
        misParametros.Add(New SqlParameter("@Nombre", nuevoProveedor.nombre))
        misParametros.Add(New SqlParameter("@Direccion", nuevoProveedor.direccion))
        misParametros.Add(New SqlParameter("@Localidad", nuevoProveedor.Localidad))
        misParametros.Add(New SqlParameter("@Email", nuevoProveedor.email))
        misParametros.Add(New SqlParameter("@Telefono", nuevoProveedor.telefono))
        misParametros.Add(New SqlParameter("@Descripcion", nuevoProveedor.Descripcion))



        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)

    End Sub



    Private Shared Function ConvertirRowEnProveedor(row As DataRow) As Proveedor

        Dim miProveedor As New Proveedor(CInt(row("idProveedor")))

        miProveedor.IdProveedor = CInt(row("idProveedor"))
        miProveedor.nombre = row("Nombre").ToString()
        miProveedor.direccion = row("Direccion").ToString()
        miProveedor.Localidad = row("Localidad")
        miProveedor.email = row("Email").ToString()
        miProveedor.telefono = row("Telefono").ToString()
        miProveedor.Descripcion = row("Descripcion").ToString()


        Return miProveedor
    End Function

    Private Shared Function ConvertirRowEnProveedor(rows As DataRowCollection) As ProveedoresList

        Dim misProveedores As New ProveedoresList()
        For Each registro As DataRow In rows

            Dim unProveedor As Proveedor = Nothing

            unProveedor = ConvertirRowEnProveedor(registro)

            misProveedores.Add(unProveedor)
        Next
        Return misProveedores
    End Function




    Public Shared Function ObtenerProveedor(Nombre As String) As List(Of Proveedor)

        If String.IsNullOrEmpty(Nombre) OrElse Nombre.Length < 4 Then
            Throw New Exception("Debe ingresar al menos 4 caracteres para realizar esta búsqueda.")
        End If

        Dim NombreStoreProcedure As String = "ObtenerProveedorPorNombre"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@Nombre", Nombre.Trim()))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnProveedor(datos.Rows)
    End Function



    Public Shared Function ObtenerProovedorPorId(id As Integer) As Proveedor
        If id < 0 Then
            Throw New Exception("el numero de documento no es valido.")
        End If

        Dim NombreStoreProcedure As String = "ObtenerProveedorPorId"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@idProveedor", id))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnProveedor(datos.Rows(0))
    End Function

End Class


