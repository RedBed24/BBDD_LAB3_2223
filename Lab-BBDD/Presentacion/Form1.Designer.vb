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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.cmbBoxArtistas = New System.Windows.Forms.ComboBox()
        Me.lblArtistas = New System.Windows.Forms.Label()
        Me.btnObtenerArtistas = New System.Windows.Forms.Button()
        Me.txtBoxNombreArtista = New System.Windows.Forms.TextBox()
        Me.lblNombreArtista = New System.Windows.Forms.Label()
        Me.txtBoxPaisArtista = New System.Windows.Forms.TextBox()
        Me.lblPaisArtista = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Controls.Add(Me.TabPage4)
        Me.TabControl.Controls.Add(Me.TabPage5)
        Me.TabControl.Controls.Add(Me.TabPage6)
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(635, 531)
        Me.TabControl.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblPaisArtista)
        Me.TabPage2.Controls.Add(Me.txtBoxPaisArtista)
        Me.TabPage2.Controls.Add(Me.lblNombreArtista)
        Me.TabPage2.Controls.Add(Me.txtBoxNombreArtista)
        Me.TabPage2.Controls.Add(Me.btnObtenerArtistas)
        Me.TabPage2.Controls.Add(Me.lblArtistas)
        Me.TabPage2.Controls.Add(Me.cmbBoxArtistas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(627, 502)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Artista"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(627, 502)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Paises"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(627, 502)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(627, 502)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(627, 502)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(627, 502)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "TabPage6"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'cmbBoxArtistas
        '
        Me.cmbBoxArtistas.FormattingEnabled = True
        Me.cmbBoxArtistas.Location = New System.Drawing.Point(22, 47)
        Me.cmbBoxArtistas.Name = "cmbBoxArtistas"
        Me.cmbBoxArtistas.Size = New System.Drawing.Size(256, 24)
        Me.cmbBoxArtistas.TabIndex = 0
        '
        'lblArtistas
        '
        Me.lblArtistas.AutoSize = True
        Me.lblArtistas.Location = New System.Drawing.Point(40, 16)
        Me.lblArtistas.Name = "lblArtistas"
        Me.lblArtistas.Size = New System.Drawing.Size(54, 16)
        Me.lblArtistas.TabIndex = 1
        Me.lblArtistas.Text = "Artistas:"
        '
        'btnObtenerArtistas
        '
        Me.btnObtenerArtistas.Location = New System.Drawing.Point(112, 10)
        Me.btnObtenerArtistas.Name = "btnObtenerArtistas"
        Me.btnObtenerArtistas.Size = New System.Drawing.Size(154, 28)
        Me.btnObtenerArtistas.TabIndex = 2
        Me.btnObtenerArtistas.Text = "Ver todos los Artistas"
        Me.btnObtenerArtistas.UseVisualStyleBackColor = True
        '
        'txtBoxNombreArtista
        '
        Me.txtBoxNombreArtista.Location = New System.Drawing.Point(317, 47)
        Me.txtBoxNombreArtista.Name = "txtBoxNombreArtista"
        Me.txtBoxNombreArtista.Size = New System.Drawing.Size(256, 22)
        Me.txtBoxNombreArtista.TabIndex = 3
        '
        'lblNombreArtista
        '
        Me.lblNombreArtista.AutoSize = True
        Me.lblNombreArtista.Location = New System.Drawing.Point(328, 22)
        Me.lblNombreArtista.Name = "lblNombreArtista"
        Me.lblNombreArtista.Size = New System.Drawing.Size(120, 16)
        Me.lblNombreArtista.TabIndex = 4
        Me.lblNombreArtista.Text = "Nombre del artista:"
        '
        'txtBoxPaisArtista
        '
        Me.txtBoxPaisArtista.Location = New System.Drawing.Point(317, 118)
        Me.txtBoxPaisArtista.Name = "txtBoxPaisArtista"
        Me.txtBoxPaisArtista.Size = New System.Drawing.Size(256, 22)
        Me.txtBoxPaisArtista.TabIndex = 5
        '
        'lblPaisArtista
        '
        Me.lblPaisArtista.AutoSize = True
        Me.lblPaisArtista.Location = New System.Drawing.Point(328, 88)
        Me.lblPaisArtista.Name = "lblPaisArtista"
        Me.lblPaisArtista.Size = New System.Drawing.Size(95, 16)
        Me.lblPaisArtista.TabIndex = 6
        Me.lblPaisArtista.Text = "País del artista"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 524)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents lblArtistas As Label
    Friend WithEvents cmbBoxArtistas As ComboBox
    Friend WithEvents lblNombreArtista As Label
    Friend WithEvents txtBoxNombreArtista As TextBox
    Friend WithEvents btnObtenerArtistas As Button
    Friend WithEvents lblPaisArtista As Label
    Friend WithEvents txtBoxPaisArtista As TextBox
End Class
