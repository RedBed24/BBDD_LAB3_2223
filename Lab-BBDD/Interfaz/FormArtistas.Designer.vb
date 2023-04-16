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
        Me.TextBox_ID_Art = New System.Windows.Forms.TextBox()
        Me.LabelID_Art = New System.Windows.Forms.Label()
        Me.ListBox_Art = New System.Windows.Forms.ListBox()
        Me.ComboBoxPais_Art = New System.Windows.Forms.ComboBox()
        Me.TextBoxNombre_Art = New System.Windows.Forms.TextBox()
        Me.LabelPais_Art = New System.Windows.Forms.Label()
        Me.LabelNombre_Art = New System.Windows.Forms.Label()
        Me.btnEliminar_Art = New System.Windows.Forms.Button()
        Me.btnLimpiar_Art = New System.Windows.Forms.Button()
        Me.btnModificar_Art = New System.Windows.Forms.Button()
        Me.btnAdd_Art = New System.Windows.Forms.Button()
        Me.lblTitulo_Art = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox_ID_Art
        '
        Me.TextBox_ID_Art.Enabled = False
        Me.TextBox_ID_Art.Location = New System.Drawing.Point(194, 108)
        Me.TextBox_ID_Art.Name = "TextBox_ID_Art"
        Me.TextBox_ID_Art.Size = New System.Drawing.Size(241, 31)
        Me.TextBox_ID_Art.TabIndex = 24
        '
        'LabelID_Art
        '
        Me.LabelID_Art.AutoSize = True
        Me.LabelID_Art.Location = New System.Drawing.Point(107, 111)
        Me.LabelID_Art.Name = "LabelID_Art"
        Me.LabelID_Art.Size = New System.Drawing.Size(30, 25)
        Me.LabelID_Art.TabIndex = 23
        Me.LabelID_Art.Text = "ID"
        '
        'ListBox_Art
        '
        Me.ListBox_Art.FormattingEnabled = True
        Me.ListBox_Art.ItemHeight = 25
        Me.ListBox_Art.Location = New System.Drawing.Point(587, 128)
        Me.ListBox_Art.Name = "ListBox_Art"
        Me.ListBox_Art.Size = New System.Drawing.Size(225, 254)
        Me.ListBox_Art.TabIndex = 22
        '
        'ComboBoxPais_Art
        '
        Me.ComboBoxPais_Art.DisplayMember = "DSFS"
        Me.ComboBoxPais_Art.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPais_Art.FormattingEnabled = True
        Me.ComboBoxPais_Art.Location = New System.Drawing.Point(194, 235)
        Me.ComboBoxPais_Art.Name = "ComboBoxPais_Art"
        Me.ComboBoxPais_Art.Size = New System.Drawing.Size(241, 33)
        Me.ComboBoxPais_Art.TabIndex = 21
        Me.ComboBoxPais_Art.Tag = ""
        '
        'TextBoxNombre_Art
        '
        Me.TextBoxNombre_Art.Location = New System.Drawing.Point(194, 166)
        Me.TextBoxNombre_Art.Name = "TextBoxNombre_Art"
        Me.TextBoxNombre_Art.Size = New System.Drawing.Size(241, 31)
        Me.TextBoxNombre_Art.TabIndex = 20
        '
        'LabelPais_Art
        '
        Me.LabelPais_Art.AutoSize = True
        Me.LabelPais_Art.Location = New System.Drawing.Point(107, 238)
        Me.LabelPais_Art.Name = "LabelPais_Art"
        Me.LabelPais_Art.Size = New System.Drawing.Size(42, 25)
        Me.LabelPais_Art.TabIndex = 19
        Me.LabelPais_Art.Text = "Pais"
        '
        'LabelNombre_Art
        '
        Me.LabelNombre_Art.AutoSize = True
        Me.LabelNombre_Art.Location = New System.Drawing.Point(107, 169)
        Me.LabelNombre_Art.Name = "LabelNombre_Art"
        Me.LabelNombre_Art.Size = New System.Drawing.Size(78, 25)
        Me.LabelNombre_Art.TabIndex = 18
        Me.LabelNombre_Art.Text = "Nombre"
        '
        'btnEliminar_Art
        '
        Me.btnEliminar_Art.Enabled = False
        Me.btnEliminar_Art.Location = New System.Drawing.Point(332, 310)
        Me.btnEliminar_Art.Name = "btnEliminar_Art"
        Me.btnEliminar_Art.Size = New System.Drawing.Size(133, 54)
        Me.btnEliminar_Art.TabIndex = 17
        Me.btnEliminar_Art.Text = "Eliminar"
        Me.btnEliminar_Art.UseVisualStyleBackColor = True
        '
        'btnLimpiar_Art
        '
        Me.btnLimpiar_Art.Location = New System.Drawing.Point(332, 393)
        Me.btnLimpiar_Art.Name = "btnLimpiar_Art"
        Me.btnLimpiar_Art.Size = New System.Drawing.Size(133, 54)
        Me.btnLimpiar_Art.TabIndex = 16
        Me.btnLimpiar_Art.Text = "Limpiar"
        Me.btnLimpiar_Art.UseVisualStyleBackColor = True
        '
        'btnModificar_Art
        '
        Me.btnModificar_Art.Enabled = False
        Me.btnModificar_Art.Location = New System.Drawing.Point(107, 393)
        Me.btnModificar_Art.Name = "btnModificar_Art"
        Me.btnModificar_Art.Size = New System.Drawing.Size(140, 54)
        Me.btnModificar_Art.TabIndex = 15
        Me.btnModificar_Art.Text = "Modificar"
        Me.btnModificar_Art.UseVisualStyleBackColor = True
        '
        'btnAdd_Art
        '
        Me.btnAdd_Art.Location = New System.Drawing.Point(107, 310)
        Me.btnAdd_Art.Name = "btnAdd_Art"
        Me.btnAdd_Art.Size = New System.Drawing.Size(140, 54)
        Me.btnAdd_Art.TabIndex = 14
        Me.btnAdd_Art.Text = "Añadir"
        Me.btnAdd_Art.UseVisualStyleBackColor = True
        '
        'lblTitulo_Art
        '
        Me.lblTitulo_Art.AutoSize = True
        Me.lblTitulo_Art.Font = New System.Drawing.Font("Roboto Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo_Art.Location = New System.Drawing.Point(395, 40)
        Me.lblTitulo_Art.Name = "lblTitulo_Art"
        Me.lblTitulo_Art.Size = New System.Drawing.Size(130, 34)
        Me.lblTitulo_Art.TabIndex = 25
        Me.lblTitulo_Art.Text = "ARTISTAS"
        '
        'FormArtistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 494)
        Me.Controls.Add(Me.lblTitulo_Art)
        Me.Controls.Add(Me.TextBox_ID_Art)
        Me.Controls.Add(Me.LabelID_Art)
        Me.Controls.Add(Me.ListBox_Art)
        Me.Controls.Add(Me.ComboBoxPais_Art)
        Me.Controls.Add(Me.TextBoxNombre_Art)
        Me.Controls.Add(Me.LabelPais_Art)
        Me.Controls.Add(Me.LabelNombre_Art)
        Me.Controls.Add(Me.btnEliminar_Art)
        Me.Controls.Add(Me.btnLimpiar_Art)
        Me.Controls.Add(Me.btnModificar_Art)
        Me.Controls.Add(Me.btnAdd_Art)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormArtistas"
        Me.Text = "FormArtistas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_ID_Art As TextBox
    Friend WithEvents LabelID_Art As Label
    Friend WithEvents ListBox_Art As ListBox
    Friend WithEvents ComboBoxPais_Art As ComboBox
    Friend WithEvents TextBoxNombre_Art As TextBox
    Friend WithEvents LabelPais_Art As Label
    Friend WithEvents LabelNombre_Art As Label
    Friend WithEvents btnEliminar_Art As Button
    Friend WithEvents btnLimpiar_Art As Button
    Friend WithEvents btnModificar_Art As Button
    Friend WithEvents btnAdd_Art As Button
    Friend WithEvents lblTitulo_Art As Label
End Class
