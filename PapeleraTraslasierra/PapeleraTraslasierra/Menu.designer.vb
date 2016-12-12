<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.salirButton = New System.Windows.Forms.Button()
        Me.UsuarioLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioMenuStrinp = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripPapelera = New System.Windows.Forms.MenuStrip()
        Me.minimizarButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripPapelera.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(577, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Usuario:"
        '
        'salirButton
        '
        Me.salirButton.BackColor = System.Drawing.Color.SkyBlue
        Me.salirButton.Location = New System.Drawing.Point(670, 3)
        Me.salirButton.Name = "salirButton"
        Me.salirButton.Size = New System.Drawing.Size(31, 18)
        Me.salirButton.TabIndex = 37
        Me.salirButton.Text = "X"
        Me.salirButton.UseVisualStyleBackColor = False
        '
        'UsuarioLabel
        '
        Me.UsuarioLabel.AutoSize = True
        Me.UsuarioLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsuarioLabel.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioLabel.ForeColor = System.Drawing.Color.White
        Me.UsuarioLabel.Location = New System.Drawing.Point(645, 0)
        Me.UsuarioLabel.Name = "UsuarioLabel"
        Me.UsuarioLabel.Size = New System.Drawing.Size(56, 17)
        Me.UsuarioLabel.TabIndex = 5
        Me.UsuarioLabel.Text = "Usuario"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.UsuarioLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 348.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(709, 372)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ClienteToolStripMenuItem.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.ClienteToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClienteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(73, 23)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FacturasToolStripMenuItem.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.FacturasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FacturasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(84, 23)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ProveedoresToolStripMenuItem.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.ProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProveedoresToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(115, 23)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(85, 23)
        Me.ToolStripMenuItem2.Text = "Articulos"
        '
        'UsuarioMenuStrinp
        '
        Me.UsuarioMenuStrinp.BackColor = System.Drawing.Color.Transparent
        Me.UsuarioMenuStrinp.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.UsuarioMenuStrinp.ForeColor = System.Drawing.Color.White
        Me.UsuarioMenuStrinp.ImageTransparentColor = System.Drawing.Color.Black
        Me.UsuarioMenuStrinp.Name = "UsuarioMenuStrinp"
        Me.UsuarioMenuStrinp.Size = New System.Drawing.Size(77, 23)
        Me.UsuarioMenuStrinp.Text = "Usuario"
        '
        'CambiarUsuarioToolStripMenuItem
        '
        Me.CambiarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.CambiarUsuarioToolStripMenuItem.Font = New System.Drawing.Font("Rockwell", 12.0!)
        Me.CambiarUsuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CambiarUsuarioToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.CambiarUsuarioToolStripMenuItem.Name = "CambiarUsuarioToolStripMenuItem"
        Me.CambiarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(146, 23)
        Me.CambiarUsuarioToolStripMenuItem.Text = "Cambiar Usuario"
        '
        'MenuStripPapelera
        '
        Me.MenuStripPapelera.BackColor = System.Drawing.Color.Brown
        Me.MenuStripPapelera.BackgroundImage = CType(resources.GetObject("MenuStripPapelera.BackgroundImage"), System.Drawing.Image)
        Me.MenuStripPapelera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStripPapelera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStripPapelera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.FacturasToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ToolStripMenuItem2, Me.UsuarioMenuStrinp, Me.CambiarUsuarioToolStripMenuItem})
        Me.MenuStripPapelera.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripPapelera.Name = "MenuStripPapelera"
        Me.MenuStripPapelera.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStripPapelera.Size = New System.Drawing.Size(709, 27)
        Me.MenuStripPapelera.TabIndex = 0
        Me.MenuStripPapelera.Text = "MenuStrip"
        '
        'minimizarButton
        '
        Me.minimizarButton.BackColor = System.Drawing.Color.SkyBlue
        Me.minimizarButton.Location = New System.Drawing.Point(630, 3)
        Me.minimizarButton.Name = "minimizarButton"
        Me.minimizarButton.Size = New System.Drawing.Size(34, 18)
        Me.minimizarButton.TabIndex = 38
        Me.minimizarButton.Text = "---"
        Me.minimizarButton.UseVisualStyleBackColor = False
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(709, 399)
        Me.Controls.Add(Me.minimizarButton)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.salirButton)
        Me.Controls.Add(Me.MenuStripPapelera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStripPapelera
        Me.Name = "frm_menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripPapelera.ResumeLayout(False)
        Me.MenuStripPapelera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents salirButton As Button
    Friend WithEvents UsuarioLabel As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents UsuarioMenuStrinp As ToolStripMenuItem
    Friend WithEvents CambiarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStripPapelera As MenuStrip
    Friend WithEvents minimizarButton As Button
End Class
