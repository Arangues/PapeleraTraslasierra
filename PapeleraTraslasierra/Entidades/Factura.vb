﻿Public Class Factura
    Dim idFactura_ As Integer
    Dim facturaNumero_ As Integer
    Dim tipo_ As String
    Dim fecha_ As DateTime
    Dim facturaTotal_ As Decimal
    Dim usuario_ As String
    Dim cliente_ As String

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

    Public Property FacturaNumero As Integer
        Get
            Return facturaNumero_
        End Get
        Set(value As Integer)
            facturaNumero_ = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return usuario_
        End Get
        Set(value As String)
            usuario_ = value
        End Set
    End Property

    Public Property Cliente As String
        Get
            Return cliente_
        End Get
        Set(value As String)
            cliente_ = value
        End Set
    End Property

    Public Sub AsignarFacturaId(nuevoIdFactura As Integer)
        nuevoIdFactura = IdFactura
    End Sub
End Class
