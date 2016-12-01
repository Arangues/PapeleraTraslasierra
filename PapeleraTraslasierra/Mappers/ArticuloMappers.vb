Imports System.Data.SqlClient
Imports Datos
Imports Entidades

Public Class ArticuloMappers


    Public Shared Function ObtenerTodos() As List(Of Articulo)
        Dim Conexion As ConexionDB
        Dim NombreStoreProcedure As String = "ObtenerTodosArticulos"


        Dim datos As DataTable = Conexion.ObtenerDatos(NombreStoreProcedure)

        Return ConvertirRowEnArticulo(datos.Rows)
    End Function



    Public Shared Sub InsertarArticulo(nuevoArticulo As Articulo)

        If nuevoArticulo Is Nothing Then
            Throw New Exception("Debe especificar un articulo a dar de alta")
        End If

        nuevoArticulo.Validador()

        Dim NombreStoreProcedure As String = "InsertarArticulo"

        Dim misParametros As New List(Of SqlParameter)()


        Dim parametroRetorno As New SqlParameter("@idArticulo", SqlDbType.Int)
        parametroRetorno.Direction = ParameterDirection.Output

        misParametros.Add(parametroRetorno)

        misParametros.Add(New SqlParameter("@Nombre", nuevoArticulo.Nombre))
        misParametros.Add(New SqlParameter("@Categoria", nuevoArticulo.Categoria))
        misParametros.Add(New SqlParameter("@PrecioUnitario", nuevoArticulo.PrecioUnitario))
        misParametros.Add(New SqlParameter("@precioVenta", nuevoArticulo.PrecioVenta))
        misParametros.Add(New SqlParameter("@Stock", nuevoArticulo.Stock))
        misParametros.Add(New SqlParameter("@StockMin", nuevoArticulo.StockMin))
        misParametros.Add(New SqlParameter("@StockMax", nuevoArticulo.StockMax))
        misParametros.Add(New SqlParameter("@Descripcion", nuevoArticulo.Descripcion))
        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)


        Dim ArticuloId As Integer = CInt(parametroRetorno.Value)

        nuevoArticulo.AsignarArticuloId(ArticuloId)
    End Sub

    Public Shared Sub InsertarArticulo(nuevosArticulo As List(Of Articulo))

        For Each c As Articulo In nuevosArticulo
            InsertarArticulo(c)
        Next
    End Sub



    Public Shared Sub ModificarArticulo(nuevoArticulo As Articulo)

        If nuevoArticulo Is Nothing Then
            Throw New Exception("Debe especificar que articulo desea modificar")
        End If
        nuevoArticulo.Validador()

        Dim NombreStoreProcedure As String = "ModificarArticulo"

        Dim misParametros As New List(Of SqlParameter)()
        misParametros.Add(New SqlParameter("@idArticulo", nuevoArticulo.idArticulo))
        misParametros.Add(New SqlParameter("@Nombre", nuevoArticulo.Nombre))
        misParametros.Add(New SqlParameter("@Categoria", nuevoArticulo.Categoria))
        misParametros.Add(New SqlParameter("@PrecioUnitario", nuevoArticulo.PrecioUnitario))
        misParametros.Add(New SqlParameter("@precioVenta", nuevoArticulo.PrecioVenta))
        misParametros.Add(New SqlParameter("@Stock", nuevoArticulo.Stock))
        misParametros.Add(New SqlParameter("@StockMin", nuevoArticulo.StockMin))
        misParametros.Add(New SqlParameter("@StockMax", nuevoArticulo.StockMax))
        misParametros.Add(New SqlParameter("@Descripcion", nuevoArticulo.Descripcion))



        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)

    End Sub

    Public Shared Sub EliminaArticulo(nuevoArticulo As Articulo)

        If nuevoArticulo Is Nothing Then
            Throw New Exception("Debe especificar un Articulo a eliminar")
        End If

        nuevoArticulo.Validador()

        Dim NombreStoreProcedure As String = "EliminarArticulo"

        Dim misParametros As New List(Of SqlParameter)()




        misParametros.Add(New SqlParameter("@idArticulo", nuevoArticulo.idArticulo))

        ConexionDB.EjecutarProcedimientoAlmacenado(NombreStoreProcedure, misParametros)


    End Sub



    Private Shared Function ConvertirRowEnArticulo(row As DataRow) As Articulo

        Dim miArticulo As New Articulo(CInt(row("idArticulo")))

        miArticulo.idArticulo = CInt(row("idArticulo"))
        miArticulo.Nombre = row("Nombre").ToString()
        miArticulo.Categoria = row("Categoria").ToString()
        miArticulo.PrecioUnitario = row("PrecioUnitario")
        miArticulo.PrecioVenta = row("precioVenta").ToString()
        miArticulo.StockMin = row("StockMin").ToString()
        miArticulo.StockMax = row("StockMax").ToString()
        miArticulo.Descripcion = row("Descripcion").ToString()


        Return miArticulo
    End Function

    Private Shared Function ConvertirRowEnArticulo(rows As DataRowCollection) As List(Of Articulo)

        Dim misArticulos As New List(Of Articulo)()
        For Each registro As DataRow In rows

            Dim unArticulo As Articulo = Nothing

            unArticulo = ConvertirRowEnArticulo(registro)

            misArticulos.Add(unArticulo)
        Next
        Return misArticulos
    End Function




    Public Shared Function ObtenerArticulos(Nombre As String) As List(Of Articulo)

        If String.IsNullOrEmpty(Nombre) OrElse Nombre.Length < 4 Then
            Throw New Exception("Debe ingresar al menos 4 caracteres para realizar esta búsqueda.")
        End If

        Dim NombreStoreProcedure As String = "ObtenerArticuloPorNombre"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@Nombre", Nombre.Trim()))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnArticulo(datos.Rows)
    End Function

    Public Shared Function ObtenerArticuloCategoria(categoria As String) As Articulo
        If categoria.Length > 8 Or categoria.Length < 7 Then
            Throw New Exception("la categoria no es valida.")
        End If

        Dim NombreStoreProcedure As String = "ObtenerArticuloPorCategoria"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@numeroDocumento", categoria))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnArticulo(datos.Rows(0))
    End Function

    Public Shared Function ObtenerArticuloPorId(id As Integer) As Articulo
        If id < 0 Then
            Throw New Exception("el numero de documento no es valido.")
        End If

        Dim NombreStoreProcedure As String = "ObtenerArticuloPorId"

        Dim misParametros As New List(Of SqlParameter)()

        misParametros.Add(New SqlParameter("@ArticuloId", id))



        Dim datos As DataTable = ConexionDB.ObtenerDatos(NombreStoreProcedure, misParametros)


        Return ConvertirRowEnArticulo(datos.Rows(0))
    End Function

End Class



