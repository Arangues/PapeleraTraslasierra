Imports System.Windows.Forms
Imports Mappers
Imports Reglas
Imports Entidades
Imports AForge.Video.DirectShow
Imports BarcodeLib.BarcodeReader


Public Class Login
    Public usuariotipo_ As String

    Public Property usuarioTipo() As String
        Get
            Return usuariotipo_
        End Get
        Set(ByVal value As String)
            usuariotipo_ = value
        End Set
    End Property



    Private _usuario As String
    Private _tipo As String
    Dim contador As Byte = 4
    Private Shared _cargarLista As Boolean = True
    Private Dispositivos As FilterInfoCollection
    Private FuenteDeVideo As VideoCaptureDevice


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        IniciarVideo()
        'Timer2.Enabled = True
        UsuarioTextBox.Hide()
        ContraseñaTexBox.Hide()
        PictureBox.Hide()
        IngresarButton.Hide()




    End Sub

    Private Sub IniciarVideo()
        'Dispositivos = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        'FuenteDeVideo = New VideoCaptureDevice(Dispositivos(0).MonikerString)
        'Video.VideoSource = FuenteDeVideo
        'Video.Start()
        'Video.Show()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        'If Video.GetCurrentVideoFrame() IsNot Nothing Then
        '    Dim img As New Bitmap(Video.GetCurrentVideoFrame())

        '    Dim resultados As String() = BarcodeReader.read(img, BarcodeReader.QRCODE)

        '    If resultados Is Nothing OrElse resultados.Count() = 0 Then
        '        Return
        '    End If
        '    _usuario = resultados(0)
        '    Timer1.[Stop]()
        '    Video.SignalToStop()
        '    Video.Hide()
        ' End If
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
            UsuarioTextBox.Focus()


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
        If (_usuario = "" Or ContraseñaTexBox.Text = "") Then
            MsgBox("Los campos deben contener datos")
            Exit Sub
        End If

        If UsuarioRegla.ValidarUsuario(_usuario, ContraseñaTexBox.Text) Then
            If UsuarioRegla.EsAdmin() Then
                _tipo = "admin"
            Else
                _tipo = "Usuario"
            End If
            UsuarioTextBox.Text = ""
            ContraseñaTexBox.Text = ""
            Me.Hide()
            Dim menu = New frm_menu()
            menu.UsuarioMenu = _usuario
            menu.Tipo = _tipo
            menu.ShowDialog()

        Else
            MsgBox("El usuario o la contraseña son incorrectas")
        End If
        Me.Show()

    End Sub




End Class