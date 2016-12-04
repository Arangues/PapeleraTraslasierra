Public Class Factura
    Dim idFactura_ As Integer
    Dim tipo_ As String
    Dim fecha_ As DateTime
    Dim facturaTotal_ As Decimal

    Public Sub New()
        Me.Detalle = New DetalleFacturaList
    End Sub
    Public Sub New(idFactura As Integer)
        Me.Detalle = New DetalleFacturaList
        Me.idFactura_ = idFactura
    End Sub

    Public Property IdFactura As Integer
        Get
            Return idFactura_
        End Get
        Set(value As Integer)
            idFactura_ = value
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

    Public Property Fecha As Date
        Get
            Return fecha_
        End Get
        Set(value As Date)
            fecha_ = value
        End Set
    End Property


    Public Property Detalle As DetalleFacturaList

    Public Property FacturaTotal As Decimal
        Get
            Return facturaTotal_
        End Get
        Set(value As Decimal)
            facturaTotal_ = value
        End Set
    End Property

    Public Sub AsignarFacturaId(nuevoIdFactura As Integer)
        IdFactura = nuevoIdFactura
    End Sub
End Class
