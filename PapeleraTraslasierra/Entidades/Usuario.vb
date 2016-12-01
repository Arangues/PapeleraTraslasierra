Public Class Usuario
    Dim usuario_ As String
    Dim Password_ As String
    Dim tipo_ As String

    Public Sub New()

    End Sub
    Public Sub New(Usuario As Integer)
        Me.usuario_ = Usuario
    End Sub

    Public Property Usuario As String
        Get
            Return usuario_
        End Get
        Set(value As String)
            usuario_ = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return Password_
        End Get
        Set(value As String)
            Password_ = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return tipo_
        End Get
        Set(value As String)
            tipo_ = value
        End Set
    End Property
End Class
