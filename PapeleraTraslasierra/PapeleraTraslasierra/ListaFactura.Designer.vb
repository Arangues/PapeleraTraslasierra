<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListaFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaFactura))
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.usuarioBuscarTextBox = New System.Windows.Forms.TextBox()
        Me.clienteBuscarTextBox = New System.Windows.Forms.TextBox()
        Me.tipoBuscarTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buscarPorNumeroTextBox = New System.Windows.Forms.TextBox()
        Me.imprimirButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FacturaNumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourceFactura = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(22, 12)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 7
        Me.ButtonAceptar.Text = "Agregar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Location = New System.Drawing.Point(793, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(699, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Facturas"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.usuarioBuscarTextBox)
        Me.GroupBox1.Controls.Add(Me.clienteBuscarTextBox)
        Me.GroupBox1.Controls.Add(Me.tipoBuscarTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.buscarPorNumeroTextBox)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(630, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 315)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTROS"
        '
        'usuarioBuscarTextBox
        '
        Me.usuarioBuscarTextBox.Location = New System.Drawing.Point(88, 112)
        Me.usuarioBuscarTextBox.Name = "usuarioBuscarTextBox"
        Me.usuarioBuscarTextBox.Size = New System.Drawing.Size(69, 20)
        Me.usuarioBuscarTextBox.TabIndex = 67
        '
        'clienteBuscarTextBox
        '
        Me.clienteBuscarTextBox.Location = New System.Drawing.Point(88, 82)
        Me.clienteBuscarTextBox.Name = "clienteBuscarTextBox"
        Me.clienteBuscarTextBox.Size = New System.Drawing.Size(69, 20)
        Me.clienteBuscarTextBox.TabIndex = 66
        '
        'tipoBuscarTextBox
        '
        Me.tipoBuscarTextBox.Location = New System.Drawing.Point(88, 53)
        Me.tipoBuscarTextBox.Name = "tipoBuscarTextBox"
        Me.tipoBuscarTextBox.Size = New System.Drawing.Size(69, 20)
        Me.tipoBuscarTextBox.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Por usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Por cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(49, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Tipos"
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(11, 137)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(44, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Por Nº"
        '
        'buscarPorNumeroTextBox
        '
        Me.buscarPorNumeroTextBox.Location = New System.Drawing.Point(88, 19)
        Me.buscarPorNumeroTextBox.Name = "buscarPorNumeroTextBox"
        Me.buscarPorNumeroTextBox.Size = New System.Drawing.Size(69, 20)
        Me.buscarPorNumeroTextBox.TabIndex = 56
        '
        'imprimirButton
        '
        Me.imprimirButton.BackColor = System.Drawing.Color.GreenYellow
        Me.imprimirButton.ForeColor = System.Drawing.Color.Black
        Me.imprimirButton.Location = New System.Drawing.Point(771, 390)
        Me.imprimirButton.Name = "imprimirButton"
        Me.imprimirButton.Size = New System.Drawing.Size(75, 23)
        Me.imprimirButton.TabIndex = 57
        Me.imprimirButton.Text = "Imprimir"
        Me.imprimirButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FacturaNumeroDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.NombreCliente, Me.NombreUsuario})
        Me.DataGridView1.DataSource = Me.BindingSourceFactura
        Me.DataGridView1.Location = New System.Drawing.Point(22, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(582, 337)
        Me.DataGridView1.TabIndex = 58
        '
        'FacturaNumeroDataGridViewTextBoxColumn
        '
        Me.FacturaNumeroDataGridViewTextBoxColumn.DataPropertyName = "FacturaNumero"
        Me.FacturaNumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.FacturaNumeroDataGridViewTextBoxColumn.Name = "FacturaNumeroDataGridViewTextBoxColumn"
        Me.FacturaNumeroDataGridViewTextBoxColumn.ReadOnly = True
        Me.FacturaNumeroDataGridViewTextBoxColumn.Width = 70
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 60
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FacturaTotal"
        Me.DataGridViewTextBoxColumn1.HeaderText = "FacturaTotal"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NombreCliente
        '
        Me.NombreCliente.DataPropertyName = "NombreCliente"
        Me.NombreCliente.HeaderText = "NombreCliente"
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.ReadOnly = True
        '
        'NombreUsuario
        '
        Me.NombreUsuario.DataPropertyName = "NombreUsuario"
        Me.NombreUsuario.HeaderText = "NombreUsuario"
        Me.NombreUsuario.Name = "NombreUsuario"
        Me.NombreUsuario.ReadOnly = True
        '
        'BindingSourceFactura
        '
        Me.BindingSourceFactura.DataSource = GetType(Entidades.Factura)
        '
        'ListaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(873, 429)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.imprimirButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListaFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FacturatotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents buscarPorNumeroTextBox As TextBox
    Friend WithEvents imprimirButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BindingSourceFactura As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents usuarioBuscarTextBox As TextBox
    Friend WithEvents clienteBuscarTextBox As TextBox
    Friend WithEvents tipoBuscarTextBox As TextBox
    Friend WithEvents FacturaNumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents NombreUsuario As DataGridViewTextBoxColumn
End Class
