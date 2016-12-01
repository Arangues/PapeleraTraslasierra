Imports Entidades
Public Class ABMProveedores
    Public Property Proveedores As Proveedor
        Get
            Return ProveedorBindingSource.Current
        End Get
        Set(value As Proveedor)
            ProveedorBindingSource.DataSource = value
        End Set
    End Property
    Private Sub ABMProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        ProveedorBindingSource.EndEdit()
        DialogResult = DialogResult.OK
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class