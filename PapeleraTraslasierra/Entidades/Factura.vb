Imports Entidades

Public Class Factura
    Dim idFactura_ As Integer
    Dim facturaNumero_ As Integer
    Dim tipo_ As String
    Dim fecha_ As DateTime
    Public Property Detalle As FacturaDetalleList
    Dim usuario_ As Usuario
    Dim cliente_ As Cliente

    Public Sub New()
        Me.Detalle = New FacturaDetalleList
    End Sub
    Public Sub New(idFactura As Integer)
        Me.Detalle = New FacturaDetalleList
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
    Public ReadOnly Property NombreCliente As String
        Get
            Return Cliente.nombre
        End Get

    End Property

    Public ReadOnly Property NombreUsuario As String
        Get
            Return Usuario.Usuario
        End Get

    End Property

    Public ReadOnly Property FacturaTotal As Decimal
        Get
            Return Detalle.Sum(Function(d) d.Total)
        End Get

    End Property

    Public Property FacturaNumero As Integer
        Get
            Return facturaNumero_
        End Get
        Set(value As Integer)
            facturaNumero_ = value
        End Set
    End Property

    Public Property Usuario As Usuario
        Get
            Return usuario_
        End Get
        Set(value As Usuario)
            usuario_ = value
        End Set
    End Property

    Public Property Cliente As Cliente
        Get
            Return cliente_
        End Get
        Set(value As Cliente)
            cliente_ = value
        End Set
    End Property



    Public Sub AsignarFacturaId(nuevoIdFactura As Integer)
        nuevoIdFactura = IdFactura
    End Sub
End Class
