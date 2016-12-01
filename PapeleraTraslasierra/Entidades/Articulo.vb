Imports Entidades

Public Class Articulo
    Dim idArticulo_ As Integer
    Dim nombre_ As String
    Dim categoria_ As String
    Dim precio_unitario_ As Decimal
    Dim precio_venta_ As Decimal
    Dim stock_ As Integer
    Dim stock_min_ As Integer
    Dim stock_max_ As Integer
    Dim descripcion_ As String

    Public Sub New()

    End Sub
    Public Sub New(idArticulo As Integer)
        Me.idArticulo_ = idArticulo
    End Sub

    Public Property idArticulo() As Integer
        Get
            Return idArticulo_
        End Get
        Set(ByVal value As Integer)
            idArticulo_ = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return nombre_
        End Get
        Set(value As String)
            nombre_ = value
        End Set
    End Property

    Public Property Categoria() As String
        Get
            Return categoria_
        End Get
        Set(value As String)
            categoria_ = value
        End Set
    End Property

    Public Property PrecioUnitario() As Decimal
        Get
            Return precio_unitario_
        End Get
        Set(value As Decimal)
            precio_unitario_ = value
        End Set
    End Property

    Public Property PrecioVenta() As Decimal
        Get
            Return precio_venta_
        End Get
        Set(value As Decimal)
            precio_venta_ = value
        End Set
    End Property

    Public Property Stock() As Integer
        Get
            Return stock_
        End Get
        Set(value As Integer)
            stock_ = value
        End Set
    End Property

    Public Property StockMin() As Integer
        Get
            Return stock_min_
        End Get
        Set(value As Integer)
            stock_min_ = value
        End Set
    End Property

    Public Property StockMax() As Integer
        Get
            Return stock_max_
        End Get
        Set(value As Integer)
            stock_max_ = value
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

    Public Sub AsignarArticuloId(nuevoArticuloId As Integer)
        idArticulo = nuevoArticuloId

    End Sub

    Public Sub Validador()

        '    If String.IsNullOrEmpty(Nombre) Then
        '        Throw New Exception("El cliente debe tener un nombre y apellido")
        '    End If

        '    If DNI.Length > 8 Or DNI.Length < 7 Then
        '        Throw New Exception("El número de documento no es valido")
        '    End If

        '    If String.IsNullOrEmpty(NumeroTarjeta) Then
        '        Throw New Exception("Ingrese direccion")
        '    End If

        '    If Clave.ToString().Length > 8 Then
        '        Throw New Exception("Ingrese Localidad")
        '    End If

    End Sub


End Class
