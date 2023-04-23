<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArtistas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Artistas_Button_Eliminar = New System.Windows.Forms.Button()
        Me.Artistas_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Artistas_Button_Actualizar = New System.Windows.Forms.Button()
        Me.Artistas_Button_Agregar = New System.Windows.Forms.Button()
        Me.lblTitulo_Art = New System.Windows.Forms.Label()
        Me.Artistas_ListBox_Artistas = New System.Windows.Forms.ListBox()
        Me.Artistas_Button_VerTodosArtistas = New System.Windows.Forms.Button()
        Me.Artistas_ComboBox_PaisArtista = New System.Windows.Forms.ComboBox()
        Me.Artistas_Label_PaisArtista = New System.Windows.Forms.Label()
        Me.Artistas_Label_NombreArtista = New System.Windows.Forms.Label()
        Me.Artistas_TextBox_NombreArtista = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Artistas_Button_Eliminar
        '
        Me.Artistas_Button_Eliminar.Enabled = False
        Me.Artistas_Button_Eliminar.Location = New System.Drawing.Point(252, 219)
        Me.Artistas_Button_Eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.Artistas_Button_Eliminar.Name = "Artistas_Button_Eliminar"
        Me.Artistas_Button_Eliminar.Size = New System.Drawing.Size(106, 35)
        Me.Artistas_Button_Eliminar.TabIndex = 17
        Me.Artistas_Button_Eliminar.Text = "Eliminar"
        Me.Artistas_Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Artistas_Button_Limpiar
        '
        Me.Artistas_Button_Limpiar.Location = New System.Drawing.Point(252, 273)
        Me.Artistas_Button_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Artistas_Button_Limpiar.Name = "Artistas_Button_Limpiar"
        Me.Artistas_Button_Limpiar.Size = New System.Drawing.Size(106, 35)
        Me.Artistas_Button_Limpiar.TabIndex = 16
        Me.Artistas_Button_Limpiar.Text = "Limpiar"
        Me.Artistas_Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Artistas_Button_Actualizar
        '
        Me.Artistas_Button_Actualizar.Enabled = False
        Me.Artistas_Button_Actualizar.Location = New System.Drawing.Point(72, 273)
        Me.Artistas_Button_Actualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.Artistas_Button_Actualizar.Name = "Artistas_Button_Actualizar"
        Me.Artistas_Button_Actualizar.Size = New System.Drawing.Size(112, 35)
        Me.Artistas_Button_Actualizar.TabIndex = 15
        Me.Artistas_Button_Actualizar.Text = "Actualizar"
        Me.Artistas_Button_Actualizar.UseVisualStyleBackColor = True
        '
        'Artistas_Button_Agregar
        '
        Me.Artistas_Button_Agregar.Location = New System.Drawing.Point(72, 219)
        Me.Artistas_Button_Agregar.Margin = New System.Windows.Forms.Padding(2)
        Me.Artistas_Button_Agregar.Name = "Artistas_Button_Agregar"
        Me.Artistas_Button_Agregar.Size = New System.Drawing.Size(112, 35)
        Me.Artistas_Button_Agregar.TabIndex = 14
        Me.Artistas_Button_Agregar.Text = "Agregar"
        Me.Artistas_Button_Agregar.UseVisualStyleBackColor = True
        '
        'lblTitulo_Art
        '
        Me.lblTitulo_Art.AutoSize = True
        Me.lblTitulo_Art.Font = New System.Drawing.Font("Britannic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo_Art.Location = New System.Drawing.Point(284, 9)
        Me.lblTitulo_Art.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo_Art.Name = "lblTitulo_Art"
        Me.lblTitulo_Art.Size = New System.Drawing.Size(131, 31)
        Me.lblTitulo_Art.TabIndex = 25
        Me.lblTitulo_Art.Text = "ARTISTAS"
        '
        'Artistas_ListBox_Artistas
        '
        Me.Artistas_ListBox_Artistas.BackColor = System.Drawing.Color.White
        Me.Artistas_ListBox_Artistas.FormattingEnabled = True
        Me.Artistas_ListBox_Artistas.ItemHeight = 16
        Me.Artistas_ListBox_Artistas.Location = New System.Drawing.Point(428, 105)
        Me.Artistas_ListBox_Artistas.Name = "Artistas_ListBox_Artistas"
        Me.Artistas_ListBox_Artistas.Size = New System.Drawing.Size(267, 228)
        Me.Artistas_ListBox_Artistas.TabIndex = 27
        Me.Artistas_ListBox_Artistas.UseWaitCursor = True
        '
        'Artistas_Button_VerTodosArtistas
        '
        Me.Artistas_Button_VerTodosArtistas.BackColor = System.Drawing.Color.MistyRose
        Me.Artistas_Button_VerTodosArtistas.Location = New System.Drawing.Point(428, 69)
        Me.Artistas_Button_VerTodosArtistas.Name = "Artistas_Button_VerTodosArtistas"
        Me.Artistas_Button_VerTodosArtistas.Size = New System.Drawing.Size(154, 28)
        Me.Artistas_Button_VerTodosArtistas.TabIndex = 26
        Me.Artistas_Button_VerTodosArtistas.Text = "Ver todos los Artistas"
        Me.Artistas_Button_VerTodosArtistas.UseVisualStyleBackColor = False
        Me.Artistas_Button_VerTodosArtistas.UseWaitCursor = True
        '
        'Artistas_ComboBox_PaisArtista
        '
        Me.Artistas_ComboBox_PaisArtista.FormattingEnabled = True
        Me.Artistas_ComboBox_PaisArtista.Location = New System.Drawing.Point(56, 148)
        Me.Artistas_ComboBox_PaisArtista.Name = "Artistas_ComboBox_PaisArtista"
        Me.Artistas_ComboBox_PaisArtista.Size = New System.Drawing.Size(256, 24)
        Me.Artistas_ComboBox_PaisArtista.TabIndex = 31
        Me.Artistas_ComboBox_PaisArtista.UseWaitCursor = True
        '
        'Artistas_Label_PaisArtista
        '
        Me.Artistas_Label_PaisArtista.AutoSize = True
        Me.Artistas_Label_PaisArtista.Location = New System.Drawing.Point(70, 129)
        Me.Artistas_Label_PaisArtista.Name = "Artistas_Label_PaisArtista"
        Me.Artistas_Label_PaisArtista.Size = New System.Drawing.Size(98, 16)
        Me.Artistas_Label_PaisArtista.TabIndex = 30
        Me.Artistas_Label_PaisArtista.Text = "País del artista:"
        Me.Artistas_Label_PaisArtista.UseWaitCursor = True
        '
        'Artistas_Label_NombreArtista
        '
        Me.Artistas_Label_NombreArtista.AutoSize = True
        Me.Artistas_Label_NombreArtista.Location = New System.Drawing.Point(70, 63)
        Me.Artistas_Label_NombreArtista.Name = "Artistas_Label_NombreArtista"
        Me.Artistas_Label_NombreArtista.Size = New System.Drawing.Size(120, 16)
        Me.Artistas_Label_NombreArtista.TabIndex = 29
        Me.Artistas_Label_NombreArtista.Text = "Nombre del artista:"
        Me.Artistas_Label_NombreArtista.UseWaitCursor = True
        '
        'Artistas_TextBox_NombreArtista
        '
        Me.Artistas_TextBox_NombreArtista.Location = New System.Drawing.Point(56, 85)
        Me.Artistas_TextBox_NombreArtista.Name = "Artistas_TextBox_NombreArtista"
        Me.Artistas_TextBox_NombreArtista.Size = New System.Drawing.Size(256, 22)
        Me.Artistas_TextBox_NombreArtista.TabIndex = 28
        Me.Artistas_TextBox_NombreArtista.UseWaitCursor = True
        '
        'FormArtistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 375)
        Me.Controls.Add(Me.Artistas_ComboBox_PaisArtista)
        Me.Controls.Add(Me.Artistas_Label_PaisArtista)
        Me.Controls.Add(Me.Artistas_Label_NombreArtista)
        Me.Controls.Add(Me.Artistas_TextBox_NombreArtista)
        Me.Controls.Add(Me.Artistas_ListBox_Artistas)
        Me.Controls.Add(Me.Artistas_Button_VerTodosArtistas)
        Me.Controls.Add(Me.lblTitulo_Art)
        Me.Controls.Add(Me.Artistas_Button_Eliminar)
        Me.Controls.Add(Me.Artistas_Button_Limpiar)
        Me.Controls.Add(Me.Artistas_Button_Actualizar)
        Me.Controls.Add(Me.Artistas_Button_Agregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormArtistas"
        Me.Text = "FormArtistas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Artistas_Button_Eliminar As Button
    Friend WithEvents Artistas_Button_Limpiar As Button
    Friend WithEvents Artistas_Button_Actualizar As Button
    Friend WithEvents Artistas_Button_Agregar As Button
    Friend WithEvents lblTitulo_Art As Label
    Friend WithEvents Artistas_ListBox_Artistas As ListBox
    Friend WithEvents Artistas_Button_VerTodosArtistas As Button
    Friend WithEvents Artistas_ComboBox_PaisArtista As ComboBox
    Friend WithEvents Artistas_Label_PaisArtista As Label
    Friend WithEvents Artistas_Label_NombreArtista As Label
    Friend WithEvents Artistas_TextBox_NombreArtista As TextBox
End Class
