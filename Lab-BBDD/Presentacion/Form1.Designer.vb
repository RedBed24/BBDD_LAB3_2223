<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TabSitio = New System.Windows.Forms.TabControl()
        Me.TabArtista = New System.Windows.Forms.TabPage()
        Me.TabPaises = New System.Windows.Forms.TabPage()
        Me.Albumes = New System.Windows.Forms.TabPage()
        Me.TabConciertos = New System.Windows.Forms.TabPage()
        Me.TabCanciones = New System.Windows.Forms.TabPage()
        Me.TabPais = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabSitio.SuspendLayout()
        Me.TabPaises.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabSitio
        '
        Me.TabSitio.Controls.Add(Me.TabArtista)
        Me.TabSitio.Controls.Add(Me.TabPaises)
        Me.TabSitio.Controls.Add(Me.Albumes)
        Me.TabSitio.Controls.Add(Me.TabConciertos)
        Me.TabSitio.Controls.Add(Me.TabCanciones)
        Me.TabSitio.Controls.Add(Me.TabPais)
        Me.TabSitio.Location = New System.Drawing.Point(0, 0)
        Me.TabSitio.Name = "TabSitio"
        Me.TabSitio.SelectedIndex = 0
        Me.TabSitio.Size = New System.Drawing.Size(635, 531)
        Me.TabSitio.TabIndex = 0
        '
        'TabArtista
        '
        Me.TabArtista.Location = New System.Drawing.Point(4, 25)
        Me.TabArtista.Name = "TabArtista"
        Me.TabArtista.Padding = New System.Windows.Forms.Padding(3)
        Me.TabArtista.Size = New System.Drawing.Size(627, 502)
        Me.TabArtista.TabIndex = 1
        Me.TabArtista.Text = "Artista"
        Me.TabArtista.UseVisualStyleBackColor = True
        '
        'TabPaises
        '
        Me.TabPaises.Controls.Add(Me.Label3)
        Me.TabPaises.Controls.Add(Me.TextBox1)
        Me.TabPaises.Controls.Add(Me.Label2)
        Me.TabPaises.Controls.Add(Me.ComboBox1)
        Me.TabPaises.Controls.Add(Me.Label1)
        Me.TabPaises.Location = New System.Drawing.Point(4, 25)
        Me.TabPaises.Name = "TabPaises"
        Me.TabPaises.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPaises.Size = New System.Drawing.Size(627, 502)
        Me.TabPaises.TabIndex = 0
        Me.TabPaises.Text = "Paises"
        Me.TabPaises.UseVisualStyleBackColor = True
        '
        'Albumes
        '
        Me.Albumes.Location = New System.Drawing.Point(4, 25)
        Me.Albumes.Name = "Albumes"
        Me.Albumes.Padding = New System.Windows.Forms.Padding(3)
        Me.Albumes.Size = New System.Drawing.Size(627, 502)
        Me.Albumes.TabIndex = 2
        Me.Albumes.Text = "Albumes"
        Me.Albumes.UseVisualStyleBackColor = True
        '
        'TabConciertos
        '
        Me.TabConciertos.Location = New System.Drawing.Point(4, 25)
        Me.TabConciertos.Name = "TabConciertos"
        Me.TabConciertos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConciertos.Size = New System.Drawing.Size(627, 502)
        Me.TabConciertos.TabIndex = 3
        Me.TabConciertos.Text = "Conciertos"
        Me.TabConciertos.UseVisualStyleBackColor = True
        '
        'TabCanciones
        '
        Me.TabCanciones.Location = New System.Drawing.Point(4, 25)
        Me.TabCanciones.Name = "TabCanciones"
        Me.TabCanciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCanciones.Size = New System.Drawing.Size(627, 502)
        Me.TabCanciones.TabIndex = 4
        Me.TabCanciones.Text = "Canciones"
        Me.TabCanciones.UseVisualStyleBackColor = True
        '
        'TabPais
        '
        Me.TabPais.Location = New System.Drawing.Point(4, 25)
        Me.TabPais.Name = "TabPais"
        Me.TabPais.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPais.Size = New System.Drawing.Size(627, 502)
        Me.TabPais.TabIndex = 5
        Me.TabPais.Text = "Sitio"
        Me.TabPais.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecciones el pais en el cual va a buscar artistas:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(321, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "¿Desea agregar algún pais?"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(192, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(548, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 524)
        Me.Controls.Add(Me.TabSitio)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabSitio.ResumeLayout(False)
        Me.TabPaises.ResumeLayout(False)
        Me.TabPaises.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabSitio As TabControl
    Friend WithEvents TabPaises As TabPage
    Friend WithEvents TabArtista As TabPage
    Friend WithEvents Albumes As TabPage
    Friend WithEvents TabConciertos As TabPage
    Friend WithEvents TabCanciones As TabPage
    Friend WithEvents TabPais As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
End Class
