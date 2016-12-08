
Imports datos
Imports Entidades
Imports Mappers

Public Class UsuarioRegla
    Shared usuarioLogeado As Usuario
    Public Shared listUsuario As New List(Of Usuario)()
    Private Shared _cargarLista As Boolean = True


    Private Shared Sub Listar()

        listUsuario = UsuarioMappers.ObtenerTodos()

    End Sub
    Public Shared Function ValidarUsuario(Usuario As String, Contraseña As String) As Boolean
        If String.IsNullOrEmpty(Usuario) AndAlso String.IsNullOrEmpty(Contraseña) Then
            Throw New Exception("No existe la cuenta o la clave es incorrecta ")
        End If

        If _cargarLista Then
            Listar()
            _cargarLista = False
        End If

        For Each Resultado As Usuario In listUsuario
            If Resultado.Usuario.Equals(Usuario) AndAlso Resultado.Password.Equals(Contraseña) Then
                usuarioLogeado = Resultado
                Return True
            End If

        Next

        Return False
    End Function

    Public Shared Function EsAdmin()
        If usuarioLogeado Is Nothing Then
            Throw New Exception("No existe usuario logueado")
        End If
        If usuarioLogeado.Tipo = "admin" Then
            Return True
        End If
        Return False
    End Function


    Public Shared Function EsUsuario()
        If usuarioLogeado Is Nothing Then
            Throw New Exception("No existe usuario logueado")
        End If
        If usuarioLogeado.Tipo = "admin" Or usuarioLogeado.Tipo = "usuario" Then
            Return True
        End If
        Return False
    End Function

End Class
