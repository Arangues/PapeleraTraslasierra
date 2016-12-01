Imports System.Data.SqlClient
Imports Datos
Imports Entidades
Public Class ABMCliente

    Public Property Cliente As Cliente
        Get
            Return ClienteBindingSource.Current
        End Get
        Set(value As Cliente)
            ClienteBindingSource.DataSource = value
        End Set
    End Property
    Private Sub ABMCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        ClienteBindingSource.EndEdit()
        DialogResult = DialogResult.OK
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class

