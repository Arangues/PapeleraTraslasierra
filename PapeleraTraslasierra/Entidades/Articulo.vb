Imports Entidades

Public Class Articulo
    Dim idArticulo_ As Integer
    Private nombre_ As String
    Private categoria_ As Categoria
    Private precio_venta_ As Decimal
    Private stock_ As Integer
    Private proveedor_ As Proveedor
    Private descripcion_ As String

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



    Public Property Descripcion As String
        Get
            Return descripcion_
        End Get
        Set(value As String)
            descripcion_ = value
        End Set
    End Property
    Public Property Proveedor As Proveedor
        Get
            Return proveedor_
        End Get
        Set(value As Proveedor)
            proveedor_ = value
        End Set
    End Property

    Public Property Categoria As Categoria
        Get
            Return categoria_
        End Get
        Set(value As Categoria)
            categoria_ = value
        End Set
    End Property

    Public Sub AsignarArticuloId(nuevoArticuloId As Integer)
        idArticulo = nuevoArticuloId

    End Sub






End Class
