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
        Me.dgv_CLIENTE = New System.Windows.Forms.DataGridView()
        Me.FacturaNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.anularButton = New System.Windows.Forms.Button()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.FiltrarFacturaComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buscarPorNumeroTextBox = New System.Windows.Forms.TextBox()
        Me.imprimirButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UsuarioComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_CLIENTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_CLIENTE
        '
        Me.dgv_CLIENTE.AutoGenerateColumns = False
        Me.dgv_CLIENTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CLIENTE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FacturaNumero, Me.TipoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.Cliente, Me.Usuario})
        Me.dgv_CLIENTE.DataSource = Me.FacturasBindingSource
        Me.dgv_CLIENTE.Location = New System.Drawing.Point(22, 67)
        Me.dgv_CLIENTE.Name = "dgv_CLIENTE"
        Me.dgv_CLIENTE.ReadOnly = True
        Me.dgv_CLIENTE.Size = New System.Drawing.Size(544, 340)
        Me.dgv_CLIENTE.TabIndex = 0
        '
        'FacturaNumero
        '
        Me.FacturaNumero.DataPropertyName = "FacturaNumero"
        Me.FacturaNumero.HeaderText = "FacturaNumero"
        Me.FacturaNumero.Name = "FacturaNumero"
        Me.FacturaNumero.ReadOnly = True
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataSource = GetType(Entidades.Factura)
        '
        'anularButton
        '
        Me.anularButton.Enabled = False
        Me.anularButton.Location = New System.Drawing.Point(103, 12)
        Me.anularButton.Name = "anularButton"
        Me.anularButton.Size = New System.Drawing.Size(75, 23)
        Me.anularButton.TabIndex = 8
        Me.anularButton.Text = "Anular"
        Me.anularButton.UseVisualStyleBackColor = True
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
        Me.Button1.Location = New System.Drawing.Point(720, 16)
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
        Me.Label1.Location = New System.Drawing.Point(626, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Facturas"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.UsuarioComboBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ClienteComboBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar2)
        Me.GroupBox1.Controls.Add(Me.FiltrarFacturaComboBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.buscarPorNumeroTextBox)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(567, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 311)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTROS"
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
        'FiltrarFacturaComboBox
        '
        Me.FiltrarFacturaComboBox.FormattingEnabled = True
        Me.FiltrarFacturaComboBox.Location = New System.Drawing.Point(88, 50)
        Me.FiltrarFacturaComboBox.Name = "FiltrarFacturaComboBox"
        Me.FiltrarFacturaComboBox.Size = New System.Drawing.Size(69, 21)
        Me.FiltrarFacturaComboBox.TabIndex = 58
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
        Me.imprimirButton.ForeColor = System.Drawing.Color.Black
        Me.imprimirButton.Location = New System.Drawing.Point(695, 384)
        Me.imprimirButton.Name = "imprimirButton"
        Me.imprimirButton.Size = New System.Drawing.Size(75, 23)
        Me.imprimirButton.TabIndex = 57
        Me.imprimirButton.Text = "Imprimir"
        Me.imprimirButton.UseVisualStyleBackColor = True
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
        'ClienteComboBox
        '
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(88, 82)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(115, 21)
        Me.ClienteComboBox.TabIndex = 61
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
        'UsuarioComboBox
        '
        Me.UsuarioComboBox.FormattingEnabled = True
        Me.UsuarioComboBox.Location = New System.Drawing.Point(88, 109)
        Me.UsuarioComboBox.Name = "UsuarioComboBox"
        Me.UsuarioComboBox.Size = New System.Drawing.Size(115, 21)
        Me.UsuarioComboBox.TabIndex = 63
        '
        'ListaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(790, 429)
        Me.Controls.Add(Me.imprimirButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.anularButton)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.dgv_CLIENTE)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListaFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURAS"
        CType(Me.dgv_CLIENTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_CLIENTE As System.Windows.Forms.DataGridView
    Friend WithEvents anularButton As Button
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FacturatotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents FacturaNumero As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents FiltrarFacturaComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents buscarPorNumeroTextBox As TextBox
    Friend WithEvents imprimirButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents UsuarioComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ClienteComboBox As ComboBox
End Class
