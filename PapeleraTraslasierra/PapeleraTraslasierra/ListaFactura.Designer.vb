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
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.anularButton = New System.Windows.Forms.Button()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.TodosRadioButton = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.imprimirButton = New System.Windows.Forms.Button()
        Me.buscarPorNumeroTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv_CLIENTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_CLIENTE
        '
        Me.dgv_CLIENTE.AutoGenerateColumns = False
        Me.dgv_CLIENTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_CLIENTE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FacturaNumero, Me.TipoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
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
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(578, 67)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 39
        '
        'TodosRadioButton
        '
        Me.TodosRadioButton.AutoSize = True
        Me.TodosRadioButton.Location = New System.Drawing.Point(621, 241)
        Me.TodosRadioButton.Name = "TodosRadioButton"
        Me.TodosRadioButton.Size = New System.Drawing.Size(112, 17)
        Me.TodosRadioButton.TabIndex = 40
        Me.TodosRadioButton.TabStop = True
        Me.TodosRadioButton.Text = "Todas las facturas"
        Me.TodosRadioButton.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(623, 277)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(101, 17)
        Me.RadioButton2.TabIndex = 41
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Facturas de hoy"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'imprimirButton
        '
        Me.imprimirButton.Location = New System.Drawing.Point(695, 384)
        Me.imprimirButton.Name = "imprimirButton"
        Me.imprimirButton.Size = New System.Drawing.Size(75, 23)
        Me.imprimirButton.TabIndex = 42
        Me.imprimirButton.Text = "Imprimir"
        Me.imprimirButton.UseVisualStyleBackColor = True
        '
        'buscarPorNumeroTextBox
        '
        Me.buscarPorNumeroTextBox.Location = New System.Drawing.Point(623, 309)
        Me.buscarPorNumeroTextBox.Name = "buscarPorNumeroTextBox"
        Me.buscarPorNumeroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.buscarPorNumeroTextBox.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(572, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Por Nº"
        '
        'ListaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(790, 429)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.buscarPorNumeroTextBox)
        Me.Controls.Add(Me.imprimirButton)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.TodosRadioButton)
        Me.Controls.Add(Me.MonthCalendar2)
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
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents TodosRadioButton As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents imprimirButton As Button
    Friend WithEvents buscarPorNumeroTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FacturaNumero As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
