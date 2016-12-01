Public Class Proveedor
    Private idProveedor_ As Integer
    Private nombre_ As String
    Private direccion_ As String
    Private localidad_ As String
    Private email_ As String
    Private telefono_ As String
    Private descripcion_ As String

    Public Sub New()

    End Sub
    Public Sub New(idProveedor As Integer)
        Me.idProveedor_ = idProveedor
    End Sub

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Public Property direccion() As String
        Get
            Return direccion_
        End Get
        Set(ByVal value As String)
            direccion_ = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return email_
        End Get
        Set(ByVal value As String)
            email_ = value
        End Set
    End Property

    Public Property telefono() As String
        Get
            Return telefono_
        End Get
        Set(ByVal value As String)
            telefono_ = value
        End Set
    End Property



    Public Property Localidad As String
        Get
            Return localidad_
        End Get
        Set(value As String)
            localidad_ = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return descripcion_
        End Get
        Set(value As String)
            descripcion_ = value
        End Set
    End Property

    Public Property IdProveedor As Integer
        Get
            Return idProveedor_
        End Get
        Set(value As Integer)
            idProveedor_ = value
        End Set
    End Property

    Public Sub AsignarProveedorId(nuevoProveedorId As Integer)
        IdProveedor = nuevoProveedorId

    End Sub

    Public Sub Validador()

        If String.IsNullOrEmpty(IdProveedor) Then
            Throw New Exception("El Proveedor debe tener un id")
        End If

        If String.IsNullOrEmpty(nombre) Then
            Throw New Exception("El Proveedor debe tener un nombre ")
        End If

        If String.IsNullOrEmpty(direccion) Then
            Throw New Exception("El Proveedor debe tener una direccion")
        End If

        If String.IsNullOrEmpty(Localidad) Then
            Throw New Exception("El Proveedor debe tener una localidad")
        End If

        If String.IsNullOrEmpty(telefono) Then
            Throw New Exception("El Proveedor debe tener una Telefono")
        End If

        If String.IsNullOrEmpty(email) Then
            Throw New Exception("El Proveedor debe tener un Email")
        End If




    End Sub

End Class
Public Class ProveedoresList
    Inherits List(Of Proveedor)
End Class