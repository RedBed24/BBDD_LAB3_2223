<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnArtistas = New System.Windows.Forms.Button()
        Me.btnSitios = New System.Windows.Forms.Button()
        Me.btnAlbum = New System.Windows.Forms.Button()
        Me.btnPaises = New System.Windows.Forms.Button()
        Me.btnCanciones = New System.Windows.Forms.Button()
        Me.PanelMenuSuperior = New System.Windows.Forms.Panel()
        Me.PanelFormulario = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnArtistas)
        Me.PanelMenu.Controls.Add(Me.btnSitios)
        Me.PanelMenu.Controls.Add(Me.btnAlbum)
        Me.PanelMenu.Controls.Add(Me.btnPaises)
        Me.PanelMenu.Controls.Add(Me.btnCanciones)
        Me.PanelMenu.ForeColor = System.Drawing.Color.Black
        Me.PanelMenu.Location = New System.Drawing.Point(-1, -1)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(300, 601)
        Me.PanelMenu.TabIndex = 0
        '
        'btnArtistas
        '
        Me.btnArtistas.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnArtistas.FlatAppearance.BorderSize = 0
        Me.btnArtistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArtistas.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnArtistas.ForeColor = System.Drawing.Color.White
        Me.btnArtistas.Location = New System.Drawing.Point(0, 163)
        Me.btnArtistas.Name = "btnArtistas"
        Me.btnArtistas.Size = New System.Drawing.Size(300, 80)
        Me.btnArtistas.TabIndex = 2
        Me.btnArtistas.Text = "ARTISTAS"
        Me.btnArtistas.UseVisualStyleBackColor = False
        '
        'btnSitios
        '
        Me.btnSitios.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnSitios.FlatAppearance.BorderSize = 0
        Me.btnSitios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSitios.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSitios.ForeColor = System.Drawing.Color.White
        Me.btnSitios.Location = New System.Drawing.Point(-1, 418)
        Me.btnSitios.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSitios.Name = "btnSitios"
        Me.btnSitios.Size = New System.Drawing.Size(300, 80)
        Me.btnSitios.TabIndex = 3
        Me.btnSitios.Text = "Sitios"
        Me.btnSitios.UseVisualStyleBackColor = False
        '
        'btnAlbum
        '
        Me.btnAlbum.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAlbum.FlatAppearance.BorderSize = 0
        Me.btnAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlbum.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAlbum.ForeColor = System.Drawing.Color.White
        Me.btnAlbum.Location = New System.Drawing.Point(3, 335)
        Me.btnAlbum.Name = "btnAlbum"
        Me.btnAlbum.Size = New System.Drawing.Size(300, 80)
        Me.btnAlbum.TabIndex = 3
        Me.btnAlbum.Text = "ALBUM"
        Me.btnAlbum.UseVisualStyleBackColor = False
        '
        'btnPaises
        '
        Me.btnPaises.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnPaises.FlatAppearance.BorderSize = 0
        Me.btnPaises.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaises.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPaises.ForeColor = System.Drawing.Color.White
        Me.btnPaises.Location = New System.Drawing.Point(-1, 80)
        Me.btnPaises.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPaises.Name = "btnPaises"
        Me.btnPaises.Size = New System.Drawing.Size(300, 80)
        Me.btnPaises.TabIndex = 0
        Me.btnPaises.Text = "PAISES"
        Me.btnPaises.UseVisualStyleBackColor = False
        '
        'btnCanciones
        '
        Me.btnCanciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnCanciones.FlatAppearance.BorderSize = 0
        Me.btnCanciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanciones.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCanciones.ForeColor = System.Drawing.Color.White
        Me.btnCanciones.Location = New System.Drawing.Point(0, 249)
        Me.btnCanciones.Name = "btnCanciones"
        Me.btnCanciones.Size = New System.Drawing.Size(300, 80)
        Me.btnCanciones.TabIndex = 1
        Me.btnCanciones.Text = "CANCIONES"
        Me.btnCanciones.UseVisualStyleBackColor = False
        '
        'PanelMenuSuperior
        '
        Me.PanelMenuSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.PanelMenuSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuSuperior.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelMenuSuperior.Name = "PanelMenuSuperior"
        Me.PanelMenuSuperior.Size = New System.Drawing.Size(298, 80)
        Me.PanelMenuSuperior.TabIndex = 2
        '
        'PanelFormulario
        '
        Me.PanelFormulario.Location = New System.Drawing.Point(300, 0)
        Me.PanelFormulario.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelFormulario.Name = "PanelFormulario"
        Me.PanelFormulario.Size = New System.Drawing.Size(950, 600)
        Me.PanelFormulario.TabIndex = 3
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 594)
        Me.Controls.Add(Me.PanelFormulario)
        Me.Controls.Add(Me.PanelMenuSuperior)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "FormInicio"
        Me.Text = "Form1"
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelMenuSuperior As Panel
    Friend WithEvents btnPaises As Button
    Friend WithEvents btnSitios As Button
    Friend WithEvents btnAlbum As Button
    Friend WithEvents btnArtistas As Button
    Friend WithEvents btnCanciones As Button
    Friend WithEvents PanelFormulario As Panel
End Class
