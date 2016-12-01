Public Class Cliente

    Private idCliente_ As Integer
    Private nombre_ As String
    Private direccion_ As String
    Private localidad_ As String
    Private email_ As String
    Private telefono_ As String

    Public Sub New()

    End Sub
    Public Sub New(idCliente As Integer)
        Me.idCliente_ = idCliente
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
    Public Property localidad As String
        Get
            Return localidad_
        End Get
        Set(ByVal value As String)
            localidad_ = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return email_
        End Get
        Set(value As String)
            email_ = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return telefono_
        End Get
        Set(value As String)
            telefono_ = value
        End Set
    End Property

    Public Property IdCliente As Integer
        Get
            Return idCliente_
        End Get
        Set(value As Integer)
            idCliente_ = value
        End Set
    End Property

    Public Sub Validadorafrm()

        If String.IsNullOrEmpty(IdCliente) Or String.IsNullOrEmpty(nombre) Or String.IsNullOrEmpty(direccion) Or String.IsNullOrEmpty(localidad) Or String.IsNullOrEmpty(Telefono) Or String.IsNullOrEmpty(Email) Then
            MsgBox("El cliente no puede tener ningun campo vacio")
            Exit Sub
        End If

    End Sub
    Public Sub Validador()

        If String.IsNullOrEmpty(IdCliente) Or String.IsNullOrEmpty(nombre) Or String.IsNullOrEmpty(direccion) Or String.IsNullOrEmpty(localidad) Or String.IsNullOrEmpty(Telefono) Or String.IsNullOrEmpty(Email) Then
            MsgBox("El cliente no puede tener ningun campo vacio")
            Exit Sub
        End If

        If String.IsNullOrEmpty(IdCliente) Then
            Throw New Exception("El cliente debe tener un id")
        End If

        If String.IsNullOrEmpty(nombre) Then
            Throw New Exception("El cliente debe tener un nombre y apellido")
        End If

        If String.IsNullOrEmpty(direccion) Then
            Throw New Exception("El cliente debe tener una direccion")
        End If

        If String.IsNullOrEmpty(localidad) Then
            Throw New Exception("El cliente debe tener una localidad")
        End If

        If String.IsNullOrEmpty(Telefono) Then
            Throw New Exception("El cliente debe tener una Telefono")
        End If

        If String.IsNullOrEmpty(Email) Then
            Throw New Exception("El cliente debe tener un Email")
        End If



    End Sub
    Public Sub AsignarClienteId(nuevoClienteId As Integer)
        IdCliente = nuevoClienteId

    End Sub


End Class
