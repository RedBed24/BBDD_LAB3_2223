<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCanciones
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
        Me.lblTitulo_Can = New System.Windows.Forms.Label()
        Me.lstCanciones = New System.Windows.Forms.ListBox()
        Me.lblID_Can = New System.Windows.Forms.Label()
        Me.txtID_Can = New System.Windows.Forms.TextBox()
        Me.cboAlbum_Can = New System.Windows.Forms.ComboBox()
        Me.txtNombre_Can = New System.Windows.Forms.TextBox()
        Me.lblAlbum_Can = New System.Windows.Forms.Label()
        Me.lblNombre_Can = New System.Windows.Forms.Label()
        Me.lblDuracion_Can = New System.Windows.Forms.Label()
        Me.NumericUpDownMin_Can = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownSeg_Can = New System.Windows.Forms.NumericUpDown()
        Me.lblOrden_Can = New System.Windows.Forms.Label()
        Me.txtOrden_Can = New System.Windows.Forms.TextBox()
        Me.btnLimpiar_Can = New System.Windows.Forms.Button()
        Me.btnBorrar_Can = New System.Windows.Forms.Button()
        Me.btnModificar_Can = New System.Windows.Forms.Button()
        Me.btnInsertar_Can = New System.Windows.Forms.Button()
        CType(Me.NumericUpDownMin_Can, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownSeg_Can, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo_Can
        '
        Me.lblTitulo_Can.AutoSize = True
        Me.lblTitulo_Can.Font = New System.Drawing.Font("Roboto Condensed", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo_Can.Location = New System.Drawing.Point(398, 69)
        Me.lblTitulo_Can.Name = "lblTitulo_Can"
        Me.lblTitulo_Can.Size = New System.Drawing.Size(151, 38)
        Me.lblTitulo_Can.TabIndex = 0
        Me.lblTitulo_Can.Text = "Canciones"
        '
        'lstCanciones
        '
        Me.lstCanciones.FormattingEnabled = True
        Me.lstCanciones.ItemHeight = 25
        Me.lstCanciones.Location = New System.Drawing.Point(98, 153)
        Me.lstCanciones.Name = "lstCanciones"
        Me.lstCanciones.Size = New System.Drawing.Size(218, 279)
        Me.lstCanciones.TabIndex = 1
        '
        'lblID_Can
        '
        Me.lblID_Can.AutoSize = True
        Me.lblID_Can.Location = New System.Drawing.Point(438, 153)
        Me.lblID_Can.Name = "lblID_Can"
        Me.lblID_Can.Size = New System.Drawing.Size(30, 25)
        Me.lblID_Can.TabIndex = 2
        Me.lblID_Can.Text = "ID"
        '
        'txtID_Can
        '
        Me.txtID_Can.Enabled = False
        Me.txtID_Can.Location = New System.Drawing.Point(373, 181)
        Me.txtID_Can.Name = "txtID_Can"
        Me.txtID_Can.Size = New System.Drawing.Size(150, 31)
        Me.txtID_Can.TabIndex = 3
        '
        'cboAlbum_Can
        '
        Me.cboAlbum_Can.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlbum_Can.FormattingEnabled = True
        Me.cboAlbum_Can.Location = New System.Drawing.Point(635, 266)
        Me.cboAlbum_Can.Name = "cboAlbum_Can"
        Me.cboAlbum_Can.Size = New System.Drawing.Size(150, 33)
        Me.cboAlbum_Can.TabIndex = 39
        '
        'txtNombre_Can
        '
        Me.txtNombre_Can.Location = New System.Drawing.Point(635, 176)
        Me.txtNombre_Can.Name = "txtNombre_Can"
        Me.txtNombre_Can.Size = New System.Drawing.Size(150, 31)
        Me.txtNombre_Can.TabIndex = 38
        '
        'lblAlbum_Can
        '
        Me.lblAlbum_Can.AutoSize = True
        Me.lblAlbum_Can.Location = New System.Drawing.Point(671, 238)
        Me.lblAlbum_Can.Name = "lblAlbum_Can"
        Me.lblAlbum_Can.Size = New System.Drawing.Size(65, 25)
        Me.lblAlbum_Can.TabIndex = 37
        Me.lblAlbum_Can.Text = "Album"
        '
        'lblNombre_Can
        '
        Me.lblNombre_Can.AutoSize = True
        Me.lblNombre_Can.Location = New System.Drawing.Point(658, 148)
        Me.lblNombre_Can.Name = "lblNombre_Can"
        Me.lblNombre_Can.Size = New System.Drawing.Size(78, 25)
        Me.lblNombre_Can.TabIndex = 36
        Me.lblNombre_Can.Text = "Nombre"
        '
        'lblDuracion_Can
        '
        Me.lblDuracion_Can.AutoSize = True
        Me.lblDuracion_Can.Location = New System.Drawing.Point(421, 256)
        Me.lblDuracion_Can.Name = "lblDuracion_Can"
        Me.lblDuracion_Can.Size = New System.Drawing.Size(83, 25)
        Me.lblDuracion_Can.TabIndex = 40
        Me.lblDuracion_Can.Text = "Duración"
        '
        'NumericUpDownMin_Can
        '
        Me.NumericUpDownMin_Can.Location = New System.Drawing.Point(373, 305)
        Me.NumericUpDownMin_Can.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDownMin_Can.Name = "NumericUpDownMin_Can"
        Me.NumericUpDownMin_Can.Size = New System.Drawing.Size(83, 31)
        Me.NumericUpDownMin_Can.TabIndex = 41
        '
        'NumericUpDownSeg_Can
        '
        Me.NumericUpDownSeg_Can.Location = New System.Drawing.Point(373, 355)
        Me.NumericUpDownSeg_Can.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDownSeg_Can.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.NumericUpDownSeg_Can.Name = "NumericUpDownSeg_Can"
        Me.NumericUpDownSeg_Can.Size = New System.Drawing.Size(83, 31)
        Me.NumericUpDownSeg_Can.TabIndex = 42
        '
        'lblOrden_Can
        '
        Me.lblOrden_Can.AutoSize = True
        Me.lblOrden_Can.Location = New System.Drawing.Point(671, 320)
        Me.lblOrden_Can.Name = "lblOrden_Can"
        Me.lblOrden_Can.Size = New System.Drawing.Size(62, 25)
        Me.lblOrden_Can.TabIndex = 43
        Me.lblOrden_Can.Text = "Orden"
        '
        'txtOrden_Can
        '
        Me.txtOrden_Can.Location = New System.Drawing.Point(635, 348)
        Me.txtOrden_Can.Name = "txtOrden_Can"
        Me.txtOrden_Can.Size = New System.Drawing.Size(150, 31)
        Me.txtOrden_Can.TabIndex = 44
        '
        'btnLimpiar_Can
        '
        Me.btnLimpiar_Can.Location = New System.Drawing.Point(624, 480)
        Me.btnLimpiar_Can.Name = "btnLimpiar_Can"
        Me.btnLimpiar_Can.Size = New System.Drawing.Size(112, 47)
        Me.btnLimpiar_Can.TabIndex = 48
        Me.btnLimpiar_Can.Text = "Limpiar"
        Me.btnLimpiar_Can.UseVisualStyleBackColor = True
        '
        'btnBorrar_Can
        '
        Me.btnBorrar_Can.Location = New System.Drawing.Point(429, 480)
        Me.btnBorrar_Can.Name = "btnBorrar_Can"
        Me.btnBorrar_Can.Size = New System.Drawing.Size(112, 47)
        Me.btnBorrar_Can.TabIndex = 47
        Me.btnBorrar_Can.Text = "Borrar"
        Me.btnBorrar_Can.UseVisualStyleBackColor = True
        '
        'btnModificar_Can
        '
        Me.btnModificar_Can.Location = New System.Drawing.Point(624, 409)
        Me.btnModificar_Can.Name = "btnModificar_Can"
        Me.btnModificar_Can.Size = New System.Drawing.Size(112, 47)
        Me.btnModificar_Can.TabIndex = 46
        Me.btnModificar_Can.Text = "Modificar"
        Me.btnModificar_Can.UseVisualStyleBackColor = True
        '
        'btnInsertar_Can
        '
        Me.btnInsertar_Can.Location = New System.Drawing.Point(429, 409)
        Me.btnInsertar_Can.Name = "btnInsertar_Can"
        Me.btnInsertar_Can.Size = New System.Drawing.Size(112, 47)
        Me.btnInsertar_Can.TabIndex = 45
        Me.btnInsertar_Can.Text = "Insertar"
        Me.btnInsertar_Can.UseVisualStyleBackColor = True
        '
        'FormCanciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 550)
        Me.Controls.Add(Me.btnLimpiar_Can)
        Me.Controls.Add(Me.btnBorrar_Can)
        Me.Controls.Add(Me.btnModificar_Can)
        Me.Controls.Add(Me.btnInsertar_Can)
        Me.Controls.Add(Me.txtOrden_Can)
        Me.Controls.Add(Me.lblOrden_Can)
        Me.Controls.Add(Me.NumericUpDownSeg_Can)
        Me.Controls.Add(Me.NumericUpDownMin_Can)
        Me.Controls.Add(Me.lblDuracion_Can)
        Me.Controls.Add(Me.cboAlbum_Can)
        Me.Controls.Add(Me.txtNombre_Can)
        Me.Controls.Add(Me.lblAlbum_Can)
        Me.Controls.Add(Me.lblNombre_Can)
        Me.Controls.Add(Me.txtID_Can)
        Me.Controls.Add(Me.lblID_Can)
        Me.Controls.Add(Me.lstCanciones)
        Me.Controls.Add(Me.lblTitulo_Can)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCanciones"
        Me.Text = "FormCanciones"
        CType(Me.NumericUpDownMin_Can, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownSeg_Can, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo_Can As Label
    Friend WithEvents lstCanciones As ListBox
    Friend WithEvents lblID_Can As Label
    Friend WithEvents txtID_Can As TextBox
    Friend WithEvents cboArtista_Alb As ComboBox
    Friend WithEvents txtNombre_Can As TextBox
    Friend WithEvents lblAlbum_Can As Label
    Friend WithEvents lblNombre_Can As Label
    Friend WithEvents lblDuracion_Can As Label
    Friend WithEvents NumericUpDownMin_Can As NumericUpDown
    Friend WithEvents NumericUpDownSeg_Can As NumericUpDown
    Friend WithEvents lblOrden_Can As Label
    Friend WithEvents txtOrden_Can As TextBox
    Friend WithEvents btnLimpiar_Can As Button
    Friend WithEvents btnBorrar_Can As Button
    Friend WithEvents btnModificar_Can As Button
    Friend WithEvents btnInsertar_Can As Button
    Friend WithEvents cboAlbum_Can As ComboBox
End Class
