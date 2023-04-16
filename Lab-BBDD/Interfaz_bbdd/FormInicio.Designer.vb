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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInicio))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnArtistas = New System.Windows.Forms.Button()
        Me.btnSitios = New System.Windows.Forms.Button()
        Me.btnAlbum = New System.Windows.Forms.Button()
        Me.btnPaises = New System.Windows.Forms.Button()
        Me.btnCanciones = New System.Windows.Forms.Button()
        Me.PanelMenuSuperior = New System.Windows.Forms.Panel()
        Me.Inicio_LabelMenu = New System.Windows.Forms.Label()
        Me.PanelFormulario = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelMenuSuperior.SuspendLayout()
        Me.PanelFormulario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnArtistas)
        Me.PanelMenu.Controls.Add(Me.btnSitios)
        Me.PanelMenu.Controls.Add(Me.btnAlbum)
        Me.PanelMenu.Controls.Add(Me.btnPaises)
        Me.PanelMenu.Controls.Add(Me.btnCanciones)
        Me.PanelMenu.ForeColor = System.Drawing.Color.Black
        Me.PanelMenu.Location = New System.Drawing.Point(-1, -1)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(240, 385)
        Me.PanelMenu.TabIndex = 0
        '
        'btnArtistas
        '
        Me.btnArtistas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnArtistas.FlatAppearance.BorderSize = 0
        Me.btnArtistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArtistas.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnArtistas.ForeColor = System.Drawing.Color.White
        Me.btnArtistas.Location = New System.Drawing.Point(0, 104)
        Me.btnArtistas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnArtistas.Name = "btnArtistas"
        Me.btnArtistas.Size = New System.Drawing.Size(240, 51)
        Me.btnArtistas.TabIndex = 2
        Me.btnArtistas.Text = "ARTISTAS"
        Me.btnArtistas.UseVisualStyleBackColor = False
        '
        'btnSitios
        '
        Me.btnSitios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSitios.FlatAppearance.BorderSize = 0
        Me.btnSitios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSitios.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSitios.ForeColor = System.Drawing.Color.White
        Me.btnSitios.Location = New System.Drawing.Point(-1, 268)
        Me.btnSitios.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSitios.Name = "btnSitios"
        Me.btnSitios.Size = New System.Drawing.Size(240, 51)
        Me.btnSitios.TabIndex = 3
        Me.btnSitios.Text = "SITIOS"
        Me.btnSitios.UseVisualStyleBackColor = False
        '
        'btnAlbum
        '
        Me.btnAlbum.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAlbum.FlatAppearance.BorderSize = 0
        Me.btnAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlbum.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAlbum.ForeColor = System.Drawing.Color.White
        Me.btnAlbum.Location = New System.Drawing.Point(2, 214)
        Me.btnAlbum.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAlbum.Name = "btnAlbum"
        Me.btnAlbum.Size = New System.Drawing.Size(240, 51)
        Me.btnAlbum.TabIndex = 3
        Me.btnAlbum.Text = "ALBUM"
        Me.btnAlbum.UseVisualStyleBackColor = False
        '
        'btnPaises
        '
        Me.btnPaises.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPaises.FlatAppearance.BorderSize = 0
        Me.btnPaises.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaises.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPaises.ForeColor = System.Drawing.Color.White
        Me.btnPaises.Location = New System.Drawing.Point(-1, 51)
        Me.btnPaises.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPaises.Name = "btnPaises"
        Me.btnPaises.Size = New System.Drawing.Size(240, 51)
        Me.btnPaises.TabIndex = 0
        Me.btnPaises.Text = "PAISES"
        Me.btnPaises.UseVisualStyleBackColor = False
        '
        'btnCanciones
        '
        Me.btnCanciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCanciones.FlatAppearance.BorderSize = 0
        Me.btnCanciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanciones.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCanciones.ForeColor = System.Drawing.Color.White
        Me.btnCanciones.Location = New System.Drawing.Point(0, 159)
        Me.btnCanciones.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCanciones.Name = "btnCanciones"
        Me.btnCanciones.Size = New System.Drawing.Size(240, 51)
        Me.btnCanciones.TabIndex = 1
        Me.btnCanciones.Text = "CANCIONES"
        Me.btnCanciones.UseVisualStyleBackColor = False
        '
        'PanelMenuSuperior
        '
        Me.PanelMenuSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelMenuSuperior.Controls.Add(Me.Inicio_LabelMenu)
        Me.PanelMenuSuperior.ForeColor = System.Drawing.Color.Transparent
        Me.PanelMenuSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuSuperior.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelMenuSuperior.Name = "PanelMenuSuperior"
        Me.PanelMenuSuperior.Size = New System.Drawing.Size(238, 51)
        Me.PanelMenuSuperior.TabIndex = 2
        '
        'Inicio_LabelMenu
        '
        Me.Inicio_LabelMenu.AutoSize = True
        Me.Inicio_LabelMenu.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio_LabelMenu.ForeColor = System.Drawing.Color.White
        Me.Inicio_LabelMenu.Location = New System.Drawing.Point(22, 9)
        Me.Inicio_LabelMenu.Name = "Inicio_LabelMenu"
        Me.Inicio_LabelMenu.Size = New System.Drawing.Size(190, 35)
        Me.Inicio_LabelMenu.TabIndex = 0
        Me.Inicio_LabelMenu.Text = "Menú de opciones"
        '
        'PanelFormulario
        '
        Me.PanelFormulario.Controls.Add(Me.PictureBox1)
        Me.PanelFormulario.Location = New System.Drawing.Point(240, 0)
        Me.PanelFormulario.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelFormulario.Name = "PanelFormulario"
        Me.PanelFormulario.Size = New System.Drawing.Size(760, 384)
        Me.PanelFormulario.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(760, 382)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 380)
        Me.Controls.Add(Me.PanelFormulario)
        Me.Controls.Add(Me.PanelMenuSuperior)
        Me.Controls.Add(Me.PanelMenu)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormInicio"
        Me.Text = "Form1"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenuSuperior.ResumeLayout(False)
        Me.PanelMenuSuperior.PerformLayout()
        Me.PanelFormulario.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Inicio_LabelMenu As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
