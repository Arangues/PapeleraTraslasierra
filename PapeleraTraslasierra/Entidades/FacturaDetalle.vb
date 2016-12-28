Public Class FacturaDetalle
    Dim idFacturaDetalle_ As Integer
    Dim idFactura_ As Integer
    Dim Articulo_ As Articulo
    Dim precio_ As Decimal
    Dim cantidad_ As Integer


    Public Sub New()
    End Sub
    Public Sub New(idFacturaDetalle As Integer)
        Me.idFacturaDetalle_ = idFacturaDetalle
    End Sub

    Public Property IdFacturaDetalle As Integer
        Get
            Return idFacturaDetalle_
        End Get
        Set(value As Integer)
            idFacturaDetalle_ = value
        End Set
    End Property

    Public Property IdFactura As Integer
        Get
            Return idFactura_
        End Get
        Set(value As Integer)
            idFactura_ = value
        End Set
    End Property

    Public Property Articulo As Articulo
        Get
            Return Articulo_
        End Get
        Set(value As Articulo)
            Articulo_ = value
        End Set
    End Property

    Public ReadOnly Property NombreArticulo
        Get
            Return IIf(Articulo_ Is Nothing, "", Articulo_.Nombre)
        End Get

    End Property

    Public Property Precio As Decimal
        Get
            Return precio_
        End Get
        Set(value As Decimal)
            precio_ = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return cantidad_
        End Get
        Set(value As Integer)
            cantidad_ = value
        End Set
    End Property

    Public ReadOnly Property Total As Decimal
        Get
            Return cantidad_ * precio_
        End Get


    End Property

    Public Sub AsignarFacturaDetalleId(nuevoIdFacturaDtalle As Integer)
        IdFacturaDetalle = nuevoIdFacturaDtalle
    End Sub

End Class

Public Class FacturaDetalleList
    Inherits List(Of FacturaDetalle)
End Class
