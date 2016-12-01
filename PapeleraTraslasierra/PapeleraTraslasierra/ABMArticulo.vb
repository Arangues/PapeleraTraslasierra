Imports Entidades
Public Class ABMArticulo
    Public Property Articulo As Articulo
        Get
            Return ArticuloBindingSource.Current
        End Get
        Set(value As Articulo)
            ArticuloBindingSource.DataSource = value
        End Set
    End Property

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        ArticuloBindingSource.EndEdit()
        DialogResult = DialogResult.OK
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class