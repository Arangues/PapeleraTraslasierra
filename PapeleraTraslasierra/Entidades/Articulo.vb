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

        If String.IsNullOrEmpty(Nombre) Then
            Throw New Exception("El articulo debe tener un nombre ")
        End If

        If String.IsNullOrEmpty(Categoria) Then
            Throw New Exception("El articulo debe tener un nombre y apellido")
        End If

        If String.IsNullOrEmpty(PrecioUnitario) Then
            Throw New Exception("El articulo debe tener un precio unitario")
        End If
        If String.IsNullOrEmpty(PrecioVenta) Then
            Throw New Exception("El articulo debe tener un precio venta")
        End If
        If String.IsNullOrEmpty(Stock) Then
            Throw New Exception("El articulo debe tener un stock")
        End If
        If String.IsNullOrEmpty(StockMin) Then
            Throw New Exception("El articulo debe tener un stockMin")
        End If
        If String.IsNullOrEmpty(StockMax) Then
            Throw New Exception("El articulo debe tener un stockMax")
        End If
        If String.IsNullOrEmpty(Descripcion) Then
            Throw New Exception("El articulo debe tener una descripcion")
        End If

    End Sub


End Class
