<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNavegacion
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
        Me.Navegacion_ListBox_Conciertos = New System.Windows.Forms.ListBox()
        Me.Navegacion_Button_VerListado = New System.Windows.Forms.Button()
        Me.Albumes_Button_Limpiar = New System.Windows.Forms.Button()
        Me.Navegacion_LabelNombreArtista = New System.Windows.Forms.Label()
        Me.Navegacion_ComboBoxArtistas = New System.Windows.Forms.ComboBox()
        Me.lblTitulo_Nav = New System.Windows.Forms.Label()
        Me.Navegacion_Label_Sitio = New System.Windows.Forms.Label()
        Me.Navegacion_ComboBox_Sitio = New System.Windows.Forms.ComboBox()
        Me.Navegacion_ListBox_setlist = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Navegacion_ListBox_Conciertos
        '
        Me.Navegacion_ListBox_Conciertos.BackColor = System.Drawing.Color.White
        Me.Navegacion_ListBox_Conciertos.FormattingEnabled = True
        Me.Navegacion_ListBox_Conciertos.ItemHeight = 16
        Me.Navegacion_ListBox_Conciertos.Location = New System.Drawing.Point(12, 139)
        Me.Navegacion_ListBox_Conciertos.Name = "Navegacion_ListBox_Conciertos"
        Me.Navegacion_ListBox_Conciertos.Size = New System.Drawing.Size(223, 308)
        Me.Navegacion_ListBox_Conciertos.TabIndex = 56
        Me.Navegacion_ListBox_Conciertos.UseWaitCursor = True
        '
        'Navegacion_Button_VerListado
        '
        Me.Navegacion_Button_VerListado.BackColor = System.Drawing.Color.MistyRose
        Me.Navegacion_Button_VerListado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Navegacion_Button_VerListado.Location = New System.Drawing.Point(12, 96)
        Me.Navegacion_Button_VerListado.Name = "Navegacion_Button_VerListado"
        Me.Navegacion_Button_VerListado.Size = New System.Drawing.Size(110, 37)
        Me.Navegacion_Button_VerListado.TabIndex = 55
        Me.Navegacion_Button_VerListado.Text = "Ver listado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Navegacion_Button_VerListado.UseVisualStyleBackColor = False
        Me.Navegacion_Button_VerListado.UseWaitCursor = True
        '
        'Albumes_Button_Limpiar
        '
        Me.Albumes_Button_Limpiar.Location = New System.Drawing.Point(584, 352)
        Me.Albumes_Button_Limpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.Albumes_Button_Limpiar.Name = "Albumes_Button_Limpiar"
        Me.Albumes_Button_Limpiar.Size = New System.Drawing.Size(106, 35)
        Me.Albumes_Button_Limpiar.TabIndex = 54
        Me.Albumes_Button_Limpiar.Text = "Limpiar"
        Me.Albumes_Button_Limpiar.UseVisualStyleBackColor = True
        '
        'Navegacion_LabelNombreArtista
        '
        Me.Navegacion_LabelNombreArtista.AutoSize = True
        Me.Navegacion_LabelNombreArtista.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Navegacion_LabelNombreArtista.Location = New System.Drawing.Point(540, 126)
        Me.Navegacion_LabelNombreArtista.Name = "Navegacion_LabelNombreArtista"
        Me.Navegacion_LabelNombreArtista.Size = New System.Drawing.Size(128, 16)
        Me.Navegacion_LabelNombreArtista.TabIndex = 53
        Me.Navegacion_LabelNombreArtista.Text = "Selecciona el artista"
        Me.Navegacion_LabelNombreArtista.UseWaitCursor = True
        '
        'Navegacion_ComboBoxArtistas
        '
        Me.Navegacion_ComboBoxArtistas.FormattingEnabled = True
        Me.Navegacion_ComboBoxArtistas.Location = New System.Drawing.Point(532, 155)
        Me.Navegacion_ComboBoxArtistas.Name = "Navegacion_ComboBoxArtistas"
        Me.Navegacion_ComboBoxArtistas.Size = New System.Drawing.Size(150, 24)
        Me.Navegacion_ComboBoxArtistas.TabIndex = 52
        Me.Navegacion_ComboBoxArtistas.UseWaitCursor = True
        '
        'lblTitulo_Nav
        '
        Me.lblTitulo_Nav.AutoSize = True
        Me.lblTitulo_Nav.Font = New System.Drawing.Font("Britannic Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo_Nav.Location = New System.Drawing.Point(327, 32)
        Me.lblTitulo_Nav.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo_Nav.Name = "lblTitulo_Nav"
        Me.lblTitulo_Nav.Size = New System.Drawing.Size(138, 26)
        Me.lblTitulo_Nav.TabIndex = 51
        Me.lblTitulo_Nav.Text = "NAVEGACION"
        '
        'Navegacion_Label_Sitio
        '
        Me.Navegacion_Label_Sitio.AutoSize = True
        Me.Navegacion_Label_Sitio.Location = New System.Drawing.Point(540, 206)
        Me.Navegacion_Label_Sitio.Name = "Navegacion_Label_Sitio"
        Me.Navegacion_Label_Sitio.Size = New System.Drawing.Size(116, 16)
        Me.Navegacion_Label_Sitio.TabIndex = 58
        Me.Navegacion_Label_Sitio.Text = "Sitio del concierto:"
        Me.Navegacion_Label_Sitio.UseWaitCursor = True
        '
        'Navegacion_ComboBox_Sitio
        '
        Me.Navegacion_ComboBox_Sitio.FormattingEnabled = True
        Me.Navegacion_ComboBox_Sitio.Location = New System.Drawing.Point(532, 225)
        Me.Navegacion_ComboBox_Sitio.Name = "Navegacion_ComboBox_Sitio"
        Me.Navegacion_ComboBox_Sitio.Size = New System.Drawing.Size(202, 24)
        Me.Navegacion_ComboBox_Sitio.TabIndex = 57
        Me.Navegacion_ComboBox_Sitio.UseWaitCursor = True
        '
        'Navegacion_ListBox_setlist
        '
        Me.Navegacion_ListBox_setlist.BackColor = System.Drawing.Color.White
        Me.Navegacion_ListBox_setlist.FormattingEnabled = True
        Me.Navegacion_ListBox_setlist.ItemHeight = 16
        Me.Navegacion_ListBox_setlist.Location = New System.Drawing.Point(259, 219)
        Me.Navegacion_ListBox_setlist.Name = "Navegacion_ListBox_setlist"
        Me.Navegacion_ListBox_setlist.Size = New System.Drawing.Size(190, 228)
        Me.Navegacion_ListBox_setlist.TabIndex = 59
        Me.Navegacion_ListBox_setlist.UseWaitCursor = True
        '
        'FormNavegacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Navegacion_ListBox_setlist)
        Me.Controls.Add(Me.Navegacion_Label_Sitio)
        Me.Controls.Add(Me.Navegacion_ComboBox_Sitio)
        Me.Controls.Add(Me.Navegacion_ListBox_Conciertos)
        Me.Controls.Add(Me.Navegacion_Button_VerListado)
        Me.Controls.Add(Me.Albumes_Button_Limpiar)
        Me.Controls.Add(Me.Navegacion_LabelNombreArtista)
        Me.Controls.Add(Me.Navegacion_ComboBoxArtistas)
        Me.Controls.Add(Me.lblTitulo_Nav)
        Me.Name = "FormNavegacion"
        Me.Text = "FormNavegacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Navegacion_ListBox_Conciertos As ListBox
    Friend WithEvents Navegacion_Button_VerListado As Button
    Friend WithEvents Albumes_Button_Limpiar As Button
    Friend WithEvents Navegacion_LabelNombreArtista As Label
    Friend WithEvents Navegacion_ComboBoxArtistas As ComboBox
    Friend WithEvents lblTitulo_Nav As Label
    Friend WithEvents Navegacion_Label_Sitio As Label
    Friend WithEvents Navegacion_ComboBox_Sitio As ComboBox
    Friend WithEvents Navegacion_ListBox_setlist As ListBox
End Class
