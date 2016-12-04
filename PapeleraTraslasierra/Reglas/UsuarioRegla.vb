
Imports datos
Imports Entidades
Imports Mappers

Public Class UsuarioRegla
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
                Return True
            End If
            If Resultado.Usuario.Equals(Usuario) AndAlso Resultado.Password.Equals(Contraseña) Then
                Return True
            End If
        Next

        Return False
    End Function

End Class
