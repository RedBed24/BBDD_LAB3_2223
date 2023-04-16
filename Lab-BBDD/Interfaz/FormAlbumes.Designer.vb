<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlbumes
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
        Me.lblTitulo_Alb = New System.Windows.Forms.Label()
        Me.lstAlbumes = New System.Windows.Forms.ListBox()
        Me.lblId_Alb = New System.Windows.Forms.Label()
        Me.lblNombre_Alb = New System.Windows.Forms.Label()
        Me.lblAño_Alb = New System.Windows.Forms.Label()
        Me.lblArtista_Alb = New System.Windows.Forms.Label()
        Me.txtId_Alb = New System.Windows.Forms.TextBox()
        Me.txtNombre_Alb = New System.Windows.Forms.TextBox()
        Me.txtAño_Alb = New System.Windows.Forms.TextBox()
        Me.cboArtista_Alb = New System.Windows.Forms.ComboBox()
        Me.btnInsertar_Alb = New System.Windows.Forms.Button()
        Me.btnModificar_Alb = New System.Windows.Forms.Button()
        Me.btnBorrar_Alb = New System.Windows.Forms.Button()
        Me.btnLimpiar_Alb = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo_Alb
        '
        Me.lblTitulo_Alb.AutoSize = True
        Me.lblTitulo_Alb.Font = New System.Drawing.Font("Roboto Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo_Alb.Location = New System.Drawing.Point(377, 49)
        Me.lblTitulo_Alb.Name = "lblTitulo_Alb"
        Me.lblTitulo_Alb.Size = New System.Drawing.Size(127, 34)
        Me.lblTitulo_Alb.TabIndex = 26
        Me.lblTitulo_Alb.Text = "ALBUMES"
        '
        'lstAlbumes
        '
        Me.lstAlbumes.FormattingEnabled = True
        Me.lstAlbumes.ItemHeight = 25
        Me.lstAlbumes.Location = New System.Drawing.Point(82, 144)
        Me.lstAlbumes.Name = "lstAlbumes"
        Me.lstAlbumes.Size = New System.Drawing.Size(254, 279)
        Me.lstAlbumes.TabIndex = 27
        '
        'lblId_Alb
        '
        Me.lblId_Alb.AutoSize = True
        Me.lblId_Alb.Location = New System.Drawing.Point(488, 143)
        Me.lblId_Alb.Name = "lblId_Alb"
        Me.lblId_Alb.Size = New System.Drawing.Size(30, 25)
        Me.lblId_Alb.TabIndex = 28
        Me.lblId_Alb.Text = "ID"
        '
        'lblNombre_Alb
        '
        Me.lblNombre_Alb.AutoSize = True
        Me.lblNombre_Alb.Location = New System.Drawing.Point(690, 143)
        Me.lblNombre_Alb.Name = "lblNombre_Alb"
        Me.lblNombre_Alb.Size = New System.Drawing.Size(78, 25)
        Me.lblNombre_Alb.TabIndex = 29
        Me.lblNombre_Alb.Text = "Nombre"
        '
        'lblAño_Alb
        '
        Me.lblAño_Alb.AutoSize = True
        Me.lblAño_Alb.Location = New System.Drawing.Point(488, 266)
        Me.lblAño_Alb.Name = "lblAño_Alb"
        Me.lblAño_Alb.Size = New System.Drawing.Size(45, 25)
        Me.lblAño_Alb.TabIndex = 30
        Me.lblAño_Alb.Text = "Año"
        '
        'lblArtista_Alb
        '
        Me.lblArtista_Alb.AutoSize = True
        Me.lblArtista_Alb.Location = New System.Drawing.Point(705, 266)
        Me.lblArtista_Alb.Name = "lblArtista_Alb"
        Me.lblArtista_Alb.Size = New System.Drawing.Size(63, 25)
        Me.lblArtista_Alb.TabIndex = 31
        Me.lblArtista_Alb.Text = "Artista"
        '
        'txtId_Alb
        '
        Me.txtId_Alb.Location = New System.Drawing.Point(434, 185)
        Me.txtId_Alb.Name = "txtId_Alb"
        Me.txtId_Alb.Size = New System.Drawing.Size(150, 31)
        Me.txtId_Alb.TabIndex = 32
        '
        'txtNombre_Alb
        '
        Me.txtNombre_Alb.Location = New System.Drawing.Point(667, 185)
        Me.txtNombre_Alb.Name = "txtNombre_Alb"
        Me.txtNombre_Alb.Size = New System.Drawing.Size(150, 31)
        Me.txtNombre_Alb.TabIndex = 33
        '
        'txtAño_Alb
        '
        Me.txtAño_Alb.Location = New System.Drawing.Point(434, 313)
        Me.txtAño_Alb.Name = "txtAño_Alb"
        Me.txtAño_Alb.Size = New System.Drawing.Size(150, 31)
        Me.txtAño_Alb.TabIndex = 34
        '
        'cboArtista_Alb
        '
        Me.cboArtista_Alb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArtista_Alb.FormattingEnabled = True
        Me.cboArtista_Alb.Location = New System.Drawing.Point(667, 313)
        Me.cboArtista_Alb.Name = "cboArtista_Alb"
        Me.cboArtista_Alb.Size = New System.Drawing.Size(150, 33)
        Me.cboArtista_Alb.TabIndex = 35
        '
        'btnInsertar_Alb
        '
        Me.btnInsertar_Alb.Location = New System.Drawing.Point(472, 392)
        Me.btnInsertar_Alb.Name = "btnInsertar_Alb"
        Me.btnInsertar_Alb.Size = New System.Drawing.Size(112, 47)
        Me.btnInsertar_Alb.TabIndex = 36
        Me.btnInsertar_Alb.Text = "Insertar"
        Me.btnInsertar_Alb.UseVisualStyleBackColor = True
        '
        'btnModificar_Alb
        '
        Me.btnModificar_Alb.Location = New System.Drawing.Point(667, 392)
        Me.btnModificar_Alb.Name = "btnModificar_Alb"
        Me.btnModificar_Alb.Size = New System.Drawing.Size(112, 47)
        Me.btnModificar_Alb.TabIndex = 37
        Me.btnModificar_Alb.Text = "Modificar"
        Me.btnModificar_Alb.UseVisualStyleBackColor = True
        '
        'btnBorrar_Alb
        '
        Me.btnBorrar_Alb.Location = New System.Drawing.Point(472, 463)
        Me.btnBorrar_Alb.Name = "btnBorrar_Alb"
        Me.btnBorrar_Alb.Size = New System.Drawing.Size(112, 47)
        Me.btnBorrar_Alb.TabIndex = 38
        Me.btnBorrar_Alb.Text = "Borrar"
        Me.btnBorrar_Alb.UseVisualStyleBackColor = True
        '
        'btnLimpiar_Alb
        '
        Me.btnLimpiar_Alb.Location = New System.Drawing.Point(667, 463)
        Me.btnLimpiar_Alb.Name = "btnLimpiar_Alb"
        Me.btnLimpiar_Alb.Size = New System.Drawing.Size(112, 47)
        Me.btnLimpiar_Alb.TabIndex = 39
        Me.btnLimpiar_Alb.Text = "Limpiar"
        Me.btnLimpiar_Alb.UseVisualStyleBackColor = True
        '
        'FormAlbumes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 550)
        Me.Controls.Add(Me.btnLimpiar_Alb)
        Me.Controls.Add(Me.btnBorrar_Alb)
        Me.Controls.Add(Me.btnModificar_Alb)
        Me.Controls.Add(Me.btnInsertar_Alb)
        Me.Controls.Add(Me.cboArtista_Alb)
        Me.Controls.Add(Me.txtAño_Alb)
        Me.Controls.Add(Me.txtNombre_Alb)
        Me.Controls.Add(Me.txtId_Alb)
        Me.Controls.Add(Me.lblArtista_Alb)
        Me.Controls.Add(Me.lblAño_Alb)
        Me.Controls.Add(Me.lblNombre_Alb)
        Me.Controls.Add(Me.lblId_Alb)
        Me.Controls.Add(Me.lstAlbumes)
        Me.Controls.Add(Me.lblTitulo_Alb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAlbumes"
        Me.Text = "FormAlbumes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo_Alb As Label
    Friend WithEvents lstAlbumes As ListBox
    Friend WithEvents lblId_Alb As Label
    Friend WithEvents lblNombre_Alb As Label
    Friend WithEvents lblAño_Alb As Label
    Friend WithEvents lblArtista_Alb As Label
    Friend WithEvents txtId_Alb As TextBox
    Friend WithEvents txtNombre_Alb As TextBox
    Friend WithEvents txtAño_Alb As TextBox
    Friend WithEvents cboArtista_Alb As ComboBox
    Friend WithEvents btnInsertar_Alb As Button
    Friend WithEvents btnModificar_Alb As Button
    Friend WithEvents btnBorrar_Alb As Button
    Friend WithEvents btnLimpiar_Alb As Button
End Class
