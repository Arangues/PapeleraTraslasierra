<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABMCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ABMCliente))
        Me.campo_Nombre = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.campo_Direccion = New System.Windows.Forms.TextBox()
        Me.campo_Localidad = New System.Windows.Forms.TextBox()
        Me.campo_Email = New System.Windows.Forms.TextBox()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.campo_Telefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'campo_Nombre
        '
        Me.campo_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nombre", True))
        Me.campo_Nombre.Location = New System.Drawing.Point(92, 72)
        Me.campo_Nombre.Name = "campo_Nombre"
        Me.campo_Nombre.Size = New System.Drawing.Size(211, 20)
        Me.campo_Nombre.TabIndex = 0
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataSource = GetType(Entidades.Cliente)
        '
        'campo_Direccion
        '
        Me.campo_Direccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "direccion", True))
        Me.campo_Direccion.Location = New System.Drawing.Point(92, 98)
        Me.campo_Direccion.Name = "campo_Direccion"
        Me.campo_Direccion.Size = New System.Drawing.Size(211, 20)
        Me.campo_Direccion.TabIndex = 1
        '
        'campo_Localidad
        '
        Me.campo_Localidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "localidad", True))
        Me.campo_Localidad.Location = New System.Drawing.Point(92, 124)
        Me.campo_Localidad.Name = "campo_Localidad"
        Me.campo_Localidad.Size = New System.Drawing.Size(211, 20)
        Me.campo_Localidad.TabIndex = 2
        '
        'campo_Email
        '
        Me.campo_Email.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Email", True))
        Me.campo_Email.Location = New System.Drawing.Point(92, 150)
        Me.campo_Email.Name = "campo_Email"
        Me.campo_Email.Size = New System.Drawing.Size(211, 20)
        Me.campo_Email.TabIndex = 3
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(108, 215)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 4
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(189, 215)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 5
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "IdCliente", True))
        Me.txt_id.Location = New System.Drawing.Point(92, 42)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(89, 20)
        Me.txt_id.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Localidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tel"
        '
        'campo_Telefono
        '
        Me.campo_Telefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Telefono", True))
        Me.campo_Telefono.Location = New System.Drawing.Point(92, 176)
        Me.campo_Telefono.Name = "campo_Telefono"
        Me.campo_Telefono.Size = New System.Drawing.Size(211, 20)
        Me.campo_Telefono.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(124, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 25)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Cliente"
        '
        'ABMCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(330, 255)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.campo_Telefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.campo_Email)
        Me.Controls.Add(Me.campo_Localidad)
        Me.Controls.Add(Me.campo_Direccion)
        Me.Controls.Add(Me.campo_Nombre)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(330, 255)
        Me.MinimumSize = New System.Drawing.Size(330, 255)
        Me.Name = "ABMCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CLIENTE"
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents campo_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents campo_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents campo_Localidad As System.Windows.Forms.TextBox
    Friend WithEvents campo_Email As System.Windows.Forms.TextBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents Label6 As Label
    Friend WithEvents campo_Telefono As TextBox
    Friend WithEvents Label7 As Label
End Class
