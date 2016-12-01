<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IniciadoLabel = New System.Windows.Forms.Label()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.ContraseñaTexBox = New System.Windows.Forms.TextBox()
        Me.IngresarButton = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(125, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Papelera traslasierra"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'IniciadoLabel
        '
        Me.IniciadoLabel.AutoSize = True
        Me.IniciadoLabel.BackColor = System.Drawing.Color.Transparent
        Me.IniciadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IniciadoLabel.ForeColor = System.Drawing.Color.White
        Me.IniciadoLabel.Location = New System.Drawing.Point(185, 93)
        Me.IniciadoLabel.Name = "IniciadoLabel"
        Me.IniciadoLabel.Size = New System.Drawing.Size(83, 18)
        Me.IniciadoLabel.TabIndex = 9
        Me.IniciadoLabel.Text = "---------------"
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.BackColor = System.Drawing.Color.SkyBlue
        Me.UsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsuarioTextBox.Location = New System.Drawing.Point(140, 98)
        Me.UsuarioTextBox.Multiline = True
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(145, 14)
        Me.UsuarioTextBox.TabIndex = 11
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(451, 294)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 12
        Me.PictureBox.TabStop = False
        '
        'ContraseñaTexBox
        '
        Me.ContraseñaTexBox.BackColor = System.Drawing.Color.SkyBlue
        Me.ContraseñaTexBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContraseñaTexBox.Location = New System.Drawing.Point(138, 133)
        Me.ContraseñaTexBox.Multiline = True
        Me.ContraseñaTexBox.Name = "ContraseñaTexBox"
        Me.ContraseñaTexBox.Size = New System.Drawing.Size(155, 10)
        Me.ContraseñaTexBox.TabIndex = 13
        '
        'IngresarButton
        '
        Me.IngresarButton.BackColor = System.Drawing.Color.SkyBlue
        Me.IngresarButton.Location = New System.Drawing.Point(317, 101)
        Me.IngresarButton.Name = "IngresarButton"
        Me.IngresarButton.Size = New System.Drawing.Size(75, 58)
        Me.IngresarButton.TabIndex = 4
        Me.IngresarButton.Text = "Ingresar"
        Me.IngresarButton.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(77, 52)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(298, 23)
        Me.ProgressBar1.Step = 2
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 8
        '
        'Timer2
        '
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(454, 230)
        Me.Controls.Add(Me.ContraseñaTexBox)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(Me.IniciadoLabel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IngresarButton)
        Me.Controls.Add(Me.PictureBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IniciadoLabel As Label
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents ContraseñaTexBox As TextBox
    Friend WithEvents IngresarButton As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer2 As Timer
End Class
