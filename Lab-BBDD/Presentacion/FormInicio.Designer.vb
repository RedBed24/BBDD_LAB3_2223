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
        Me.btnConciertos = New System.Windows.Forms.Button()
        Me.btnArtistas = New System.Windows.Forms.Button()
        Me.btnSitios = New System.Windows.Forms.Button()
        Me.btnAlbum = New System.Windows.Forms.Button()
        Me.btnPaises = New System.Windows.Forms.Button()
        Me.btnCanciones = New System.Windows.Forms.Button()
        Me.PanelMenuSuperior = New System.Windows.Forms.Panel()
        Me.Inicio_LabelMenu = New System.Windows.Forms.Label()
        Me.PanelFormulario = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnNavegaciones = New System.Windows.Forms.Button()
        Me.BtnListados = New System.Windows.Forms.Button()
        Me.PanelMenu.SuspendLayout()
        Me.PanelMenuSuperior.SuspendLayout()
        Me.PanelFormulario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BtnListados)
        Me.PanelMenu.Controls.Add(Me.BtnNavegaciones)
        Me.PanelMenu.Controls.Add(Me.btnConciertos)
        Me.PanelMenu.Controls.Add(Me.btnArtistas)
        Me.PanelMenu.Controls.Add(Me.btnSitios)
        Me.PanelMenu.Controls.Add(Me.btnAlbum)
        Me.PanelMenu.Controls.Add(Me.btnPaises)
        Me.PanelMenu.Controls.Add(Me.btnCanciones)
        Me.PanelMenu.ForeColor = System.Drawing.Color.Black
        Me.PanelMenu.Location = New System.Drawing.Point(-1, -1)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(180, 313)
        Me.PanelMenu.TabIndex = 0
        '
        'btnConciertos
        '
        Me.btnConciertos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnConciertos.FlatAppearance.BorderSize = 0
        Me.btnConciertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConciertos.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnConciertos.ForeColor = System.Drawing.Color.White
        Me.btnConciertos.Location = New System.Drawing.Point(-1, 203)
        Me.btnConciertos.Margin = New System.Windows.Forms.Padding(0)
        Me.btnConciertos.Name = "btnConciertos"
        Me.btnConciertos.Size = New System.Drawing.Size(180, 30)
        Me.btnConciertos.TabIndex = 4
        Me.btnConciertos.Text = "CONCIERTOS"
        Me.btnConciertos.UseVisualStyleBackColor = False
        '
        'btnArtistas
        '
        Me.btnArtistas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnArtistas.FlatAppearance.BorderSize = 0
        Me.btnArtistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArtistas.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnArtistas.ForeColor = System.Drawing.Color.White
        Me.btnArtistas.Location = New System.Drawing.Point(2, 73)
        Me.btnArtistas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnArtistas.Name = "btnArtistas"
        Me.btnArtistas.Size = New System.Drawing.Size(180, 30)
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
        Me.btnSitios.Location = New System.Drawing.Point(-1, 173)
        Me.btnSitios.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSitios.Name = "btnSitios"
        Me.btnSitios.Size = New System.Drawing.Size(180, 30)
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
        Me.btnAlbum.Location = New System.Drawing.Point(2, 141)
        Me.btnAlbum.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAlbum.Name = "btnAlbum"
        Me.btnAlbum.Size = New System.Drawing.Size(180, 30)
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
        Me.btnPaises.Location = New System.Drawing.Point(-1, 41)
        Me.btnPaises.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPaises.Name = "btnPaises"
        Me.btnPaises.Size = New System.Drawing.Size(180, 30)
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
        Me.btnCanciones.Location = New System.Drawing.Point(0, 107)
        Me.btnCanciones.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCanciones.Name = "btnCanciones"
        Me.btnCanciones.Size = New System.Drawing.Size(180, 30)
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
        Me.PanelMenuSuperior.Size = New System.Drawing.Size(178, 41)
        Me.PanelMenuSuperior.TabIndex = 2
        '
        'Inicio_LabelMenu
        '
        Me.Inicio_LabelMenu.AutoSize = True
        Me.Inicio_LabelMenu.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio_LabelMenu.ForeColor = System.Drawing.Color.White
        Me.Inicio_LabelMenu.Location = New System.Drawing.Point(16, 7)
        Me.Inicio_LabelMenu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Inicio_LabelMenu.Name = "Inicio_LabelMenu"
        Me.Inicio_LabelMenu.Size = New System.Drawing.Size(154, 28)
        Me.Inicio_LabelMenu.TabIndex = 0
        Me.Inicio_LabelMenu.Text = "Menú de opciones"
        '
        'PanelFormulario
        '
        Me.PanelFormulario.Controls.Add(Me.PictureBox1)
        Me.PanelFormulario.Location = New System.Drawing.Point(180, 0)
        Me.PanelFormulario.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelFormulario.Name = "PanelFormulario"
        Me.PanelFormulario.Size = New System.Drawing.Size(570, 312)
        Me.PanelFormulario.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(570, 310)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnNavegaciones
        '
        Me.BtnNavegaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnNavegaciones.FlatAppearance.BorderSize = 0
        Me.BtnNavegaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNavegaciones.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNavegaciones.ForeColor = System.Drawing.Color.White
        Me.BtnNavegaciones.Location = New System.Drawing.Point(1, 233)
        Me.BtnNavegaciones.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnNavegaciones.Name = "BtnNavegaciones"
        Me.BtnNavegaciones.Size = New System.Drawing.Size(180, 30)
        Me.BtnNavegaciones.TabIndex = 5
        Me.BtnNavegaciones.Text = "NAVEGACIONES"
        Me.BtnNavegaciones.UseVisualStyleBackColor = False
        '
        'BtnListados
        '
        Me.BtnListados.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnListados.FlatAppearance.BorderSize = 0
        Me.BtnListados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListados.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnListados.ForeColor = System.Drawing.Color.White
        Me.BtnListados.Location = New System.Drawing.Point(-1, 263)
        Me.BtnListados.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnListados.Name = "BtnListados"
        Me.BtnListados.Size = New System.Drawing.Size(180, 30)
        Me.BtnListados.TabIndex = 6
        Me.BtnListados.Text = "LISTADOS"
        Me.BtnListados.UseVisualStyleBackColor = False
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 309)
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
    Friend WithEvents btnConciertos As Button
    Friend WithEvents BtnListados As Button
    Friend WithEvents BtnNavegaciones As Button
End Class
