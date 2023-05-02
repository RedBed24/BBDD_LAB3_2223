<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNavegacion
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
        Me.Navegacion_Label_TituloForm = New System.Windows.Forms.Label()
        Me.Navegacion_ListBox_ConciertosNav1 = New System.Windows.Forms.ListBox()
        Me.Navegacion_ListBox_CancionesConcierto = New System.Windows.Forms.ListBox()
        Me.Navegacion_ComboBox_Artista = New System.Windows.Forms.ComboBox()
        Me.Navegacion_ComboBox_Pais = New System.Windows.Forms.ComboBox()
        Me.Navegacion_ComboBox_Sitio = New System.Windows.Forms.ComboBox()
        Me.Navegaciones_CheckBox_FiltrarPais = New System.Windows.Forms.CheckBox()
        Me.Navegacion_ListBox_ConciertosNav2 = New System.Windows.Forms.ListBox()
        Me.Navegacion_Label_Artista = New System.Windows.Forms.Label()
        Me.Navegaciones_Label_ConciertosNav1 = New System.Windows.Forms.Label()
        Me.Navegaciones_Label_ConciertosNav2 = New System.Windows.Forms.Label()
        Me.Navegacion_Label_CancionesConcierto = New System.Windows.Forms.Label()
        Me.Navegacion_Label_Sitio = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Navegacion_Label_TituloForm
        '
        Me.Navegacion_Label_TituloForm.AutoSize = True
        Me.Navegacion_Label_TituloForm.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Navegacion_Label_TituloForm.Location = New System.Drawing.Point(231, 65)
        Me.Navegacion_Label_TituloForm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Navegacion_Label_TituloForm.Name = "Navegacion_Label_TituloForm"
        Me.Navegacion_Label_TituloForm.Size = New System.Drawing.Size(113, 21)
        Me.Navegacion_Label_TituloForm.TabIndex = 0
        Me.Navegacion_Label_TituloForm.Text = "NAVEGACION"
        '
        'Navegacion_ListBox_ConciertosNav1
        '
        Me.Navegacion_ListBox_ConciertosNav1.FormattingEnabled = True
        Me.Navegacion_ListBox_ConciertosNav1.Location = New System.Drawing.Point(12, 140)
        Me.Navegacion_ListBox_ConciertosNav1.Name = "Navegacion_ListBox_ConciertosNav1"
        Me.Navegacion_ListBox_ConciertosNav1.Size = New System.Drawing.Size(162, 147)
        Me.Navegacion_ListBox_ConciertosNav1.TabIndex = 1
        '
        'Navegacion_ListBox_CancionesConcierto
        '
        Me.Navegacion_ListBox_CancionesConcierto.FormattingEnabled = True
        Me.Navegacion_ListBox_CancionesConcierto.Location = New System.Drawing.Point(205, 140)
        Me.Navegacion_ListBox_CancionesConcierto.Name = "Navegacion_ListBox_CancionesConcierto"
        Me.Navegacion_ListBox_CancionesConcierto.Size = New System.Drawing.Size(162, 147)
        Me.Navegacion_ListBox_CancionesConcierto.TabIndex = 2
        '
        'Navegacion_ComboBox_Artista
        '
        Me.Navegacion_ComboBox_Artista.FormattingEnabled = True
        Me.Navegacion_ComboBox_Artista.Location = New System.Drawing.Point(12, 31)
        Me.Navegacion_ComboBox_Artista.Name = "Navegacion_ComboBox_Artista"
        Me.Navegacion_ComboBox_Artista.Size = New System.Drawing.Size(162, 21)
        Me.Navegacion_ComboBox_Artista.TabIndex = 3
        '
        'Navegacion_ComboBox_Pais
        '
        Me.Navegacion_ComboBox_Pais.FormattingEnabled = True
        Me.Navegacion_ComboBox_Pais.Location = New System.Drawing.Point(12, 92)
        Me.Navegacion_ComboBox_Pais.Name = "Navegacion_ComboBox_Pais"
        Me.Navegacion_ComboBox_Pais.Size = New System.Drawing.Size(162, 21)
        Me.Navegacion_ComboBox_Pais.TabIndex = 4
        '
        'Navegacion_ComboBox_Sitio
        '
        Me.Navegacion_ComboBox_Sitio.FormattingEnabled = True
        Me.Navegacion_ComboBox_Sitio.Location = New System.Drawing.Point(396, 31)
        Me.Navegacion_ComboBox_Sitio.Name = "Navegacion_ComboBox_Sitio"
        Me.Navegacion_ComboBox_Sitio.Size = New System.Drawing.Size(162, 21)
        Me.Navegacion_ComboBox_Sitio.TabIndex = 5
        '
        'Navegaciones_CheckBox_FiltrarPais
        '
        Me.Navegaciones_CheckBox_FiltrarPais.AutoSize = True
        Me.Navegaciones_CheckBox_FiltrarPais.Location = New System.Drawing.Point(12, 69)
        Me.Navegaciones_CheckBox_FiltrarPais.Name = "Navegaciones_CheckBox_FiltrarPais"
        Me.Navegaciones_CheckBox_FiltrarPais.Size = New System.Drawing.Size(133, 17)
        Me.Navegaciones_CheckBox_FiltrarPais.TabIndex = 6
        Me.Navegaciones_CheckBox_FiltrarPais.Text = "Filtrar también por país"
        Me.Navegaciones_CheckBox_FiltrarPais.UseVisualStyleBackColor = True
        '
        'Navegacion_ListBox_ConciertosNav2
        '
        Me.Navegacion_ListBox_ConciertosNav2.FormattingEnabled = True
        Me.Navegacion_ListBox_ConciertosNav2.Location = New System.Drawing.Point(396, 140)
        Me.Navegacion_ListBox_ConciertosNav2.Name = "Navegacion_ListBox_ConciertosNav2"
        Me.Navegacion_ListBox_ConciertosNav2.Size = New System.Drawing.Size(162, 147)
        Me.Navegacion_ListBox_ConciertosNav2.TabIndex = 7
        '
        'Navegacion_Label_Artista
        '
        Me.Navegacion_Label_Artista.AutoSize = True
        Me.Navegacion_Label_Artista.Location = New System.Drawing.Point(12, 15)
        Me.Navegacion_Label_Artista.Name = "Navegacion_Label_Artista"
        Me.Navegacion_Label_Artista.Size = New System.Drawing.Size(36, 13)
        Me.Navegacion_Label_Artista.TabIndex = 8
        Me.Navegacion_Label_Artista.Text = "Artista"
        '
        'Navegaciones_Label_ConciertosNav1
        '
        Me.Navegaciones_Label_ConciertosNav1.AutoSize = True
        Me.Navegaciones_Label_ConciertosNav1.Location = New System.Drawing.Point(12, 124)
        Me.Navegaciones_Label_ConciertosNav1.Name = "Navegaciones_Label_ConciertosNav1"
        Me.Navegaciones_Label_ConciertosNav1.Size = New System.Drawing.Size(127, 13)
        Me.Navegaciones_Label_ConciertosNav1.TabIndex = 9
        Me.Navegaciones_Label_ConciertosNav1.Text = "Conciertos Navegación 1"
        '
        'Navegaciones_Label_ConciertosNav2
        '
        Me.Navegaciones_Label_ConciertosNav2.AutoSize = True
        Me.Navegaciones_Label_ConciertosNav2.Location = New System.Drawing.Point(393, 124)
        Me.Navegaciones_Label_ConciertosNav2.Name = "Navegaciones_Label_ConciertosNav2"
        Me.Navegaciones_Label_ConciertosNav2.Size = New System.Drawing.Size(127, 13)
        Me.Navegaciones_Label_ConciertosNav2.TabIndex = 10
        Me.Navegaciones_Label_ConciertosNav2.Text = "Conciertos Navegación 2"
        '
        'Navegacion_Label_CancionesConcierto
        '
        Me.Navegacion_Label_CancionesConcierto.AutoSize = True
        Me.Navegacion_Label_CancionesConcierto.Location = New System.Drawing.Point(202, 124)
        Me.Navegacion_Label_CancionesConcierto.Name = "Navegacion_Label_CancionesConcierto"
        Me.Navegacion_Label_CancionesConcierto.Size = New System.Drawing.Size(121, 13)
        Me.Navegacion_Label_CancionesConcierto.TabIndex = 11
        Me.Navegacion_Label_CancionesConcierto.Text = "Canciones del concierto"
        '
        'Navegacion_Label_Sitio
        '
        Me.Navegacion_Label_Sitio.AutoSize = True
        Me.Navegacion_Label_Sitio.Location = New System.Drawing.Point(393, 15)
        Me.Navegacion_Label_Sitio.Name = "Navegacion_Label_Sitio"
        Me.Navegacion_Label_Sitio.Size = New System.Drawing.Size(27, 13)
        Me.Navegacion_Label_Sitio.TabIndex = 12
        Me.Navegacion_Label_Sitio.Text = "Sitio"
        '
        'FormNavegacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 299)
        Me.Controls.Add(Me.Navegacion_Label_Sitio)
        Me.Controls.Add(Me.Navegacion_Label_CancionesConcierto)
        Me.Controls.Add(Me.Navegaciones_Label_ConciertosNav2)
        Me.Controls.Add(Me.Navegaciones_Label_ConciertosNav1)
        Me.Controls.Add(Me.Navegacion_Label_Artista)
        Me.Controls.Add(Me.Navegacion_ListBox_ConciertosNav2)
        Me.Controls.Add(Me.Navegaciones_CheckBox_FiltrarPais)
        Me.Controls.Add(Me.Navegacion_ComboBox_Sitio)
        Me.Controls.Add(Me.Navegacion_ComboBox_Pais)
        Me.Controls.Add(Me.Navegacion_ComboBox_Artista)
        Me.Controls.Add(Me.Navegacion_ListBox_CancionesConcierto)
        Me.Controls.Add(Me.Navegacion_ListBox_ConciertosNav1)
        Me.Controls.Add(Me.Navegacion_Label_TituloForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormNavegacion"
        Me.Text = "FormNavegacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Navegacion_Label_TituloForm As Label
    Friend WithEvents Navegacion_ListBox_ConciertosNav1 As ListBox
    Friend WithEvents Navegacion_ListBox_CancionesConcierto As ListBox
    Friend WithEvents Navegacion_ComboBox_Artista As ComboBox
    Friend WithEvents Navegacion_ComboBox_Pais As ComboBox
    Friend WithEvents Navegacion_ComboBox_Sitio As ComboBox
    Friend WithEvents Navegaciones_CheckBox_FiltrarPais As CheckBox
    Friend WithEvents Navegacion_ListBox_ConciertosNav2 As ListBox
    Friend WithEvents Navegacion_Label_Artista As Label
    Friend WithEvents Navegaciones_Label_ConciertosNav1 As Label
    Friend WithEvents Navegaciones_Label_ConciertosNav2 As Label
    Friend WithEvents Navegacion_Label_CancionesConcierto As Label
    Friend WithEvents Navegacion_Label_Sitio As Label
End Class
