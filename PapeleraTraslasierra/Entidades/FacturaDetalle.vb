Public Class FacturaDetalle
    Dim idFacturaDetalle_ As Integer
    Dim idFactura_ As Integer
    Dim idArticulo_ As Integer
    Dim nombre_ As String
    Dim precio_ As Decimal
    Dim cantidad_ As Integer
    Dim total_ As Decimal

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

    Public Property IdArticulo As Integer
        Get
            Return idArticulo_
        End Get
        Set(value As Integer)
            idArticulo_ = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return nombre_
        End Get
        Set(value As String)
            nombre_ = value
        End Set
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

    Public Property Total As Decimal
        Get
            Return total_
        End Get
        Set(value As Decimal)
            total_ = value
        End Set
    End Property

    Public Sub AsignarFacturaDetalleId(nuevoIdFacturaDtalle As Integer)
        IdFacturaDetalle = nuevoIdFacturaDtalle
    End Sub

End Class

Public Class DetalleFacturaList
    Inherits List(Of FacturaDetalle)
End Class
