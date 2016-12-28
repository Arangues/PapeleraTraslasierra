Imports Entidades
Imports Mappers
Imports Reglas

Public Class FacturaRegla

    Public Shared Sub GenerarFactura(factura As Factura)

        If (Not UsuarioRegla.EsUsuario) Then
            Throw New Exception("Usted no tiene permisos para esta operacion")
        End If

        'Aqui agregariamos el numero de la factura

        factura.FacturaNumero = FacturaMappers.ObtenerUltimmoNumeroFactura() + 1

        factura.Usuario = UsuarioRegla.UsuarioLogin
        factura.Fecha = DateTime.Today


        'Guardamos la factura
        FacturaMappers.InsertarFactura(factura)

        'Ahora actualizariamos el stock
        For Each d As FacturaDetalle In factura.Detalle
            'Recupero el material al que descontar el stock
            Dim material As Articulo = ArticuloMappers.ObtenerArticuloPorId(d.Articulo.idArticulo)

            If material.Stock < d.Cantidad Then

                Throw New Exception($"El articulo {material.Nombre} no tiene stock suficiente para esta venta.")
            End If

            material.Stock -= d.Cantidad
            ArticuloMappers.ModificarArticulo(material)
        Next


    End Sub
End Class








'FacturaMappers.EliminarFactura(factura)