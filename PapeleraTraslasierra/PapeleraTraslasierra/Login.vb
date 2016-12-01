Imports System.Windows.Forms
Imports Mappers
Imports Reglas
Imports Entidades
Public Class Login

    Dim _usuario As String
    Dim contador As Byte = 4
    Private Shared _cargarLista As Boolean = True

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsuarioTextBox.Hide()
        ContraseñaTexBox.Hide()
        PictureBox.Hide()


        IngresarButton.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            ' Me.Opacity -= 0.07
            '  If Me.Opacity = 0.0 Then
            Timer1.Enabled = False
            UsuarioTextBox.Show()
            ContraseñaTexBox.Show()
            PictureBox.Show()
            IngresarButton.Show()


            ProgressBar1.Hide()
            'End If
        Else
            ProgressBar1.Value += 2
            If ProgressBar1.Value = contador Then
                IniciadoLabel.Text = "INICIANDO......"
            Else
                If ProgressBar1.Value = contador + 16 Then
                    IniciadoLabel.Text = ""
                    contador += 20
                End If

            End If

        End If

    End Sub

    Public Sub a(a As Boolean)
        a = True
    End Sub

    Private Sub IngresarButton_Click(sender As Object, e As EventArgs) Handles IngresarButton.Click
        Dim menustrip As New frm_menu
        _usuario = UsuarioTextBox.Text
        If UsuarioRegla.ValidarUsuario(_usuario, ContraseñaTexBox.Text) Then
            Me.Hide()
            Dim menu = New frm_menu()
            menu.UsuarioMenu = _usuario
            menu.ShowDialog()
        Else
            MsgBox("El usuario o la contraseña son incorrectas")
        End If


    End Sub
End Class