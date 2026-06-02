<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pntClases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pntClases))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cbClases = New System.Windows.Forms.ComboBox()
        Me.btnBuscarClases = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dgvEstudiantes = New System.Windows.Forms.DataGridView()
        Me.btnRegresarComp = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEstudiantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(121, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Clases"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(58, 287)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'cbClases
        '
        Me.cbClases.FormattingEnabled = True
        Me.cbClases.Location = New System.Drawing.Point(126, 95)
        Me.cbClases.Margin = New System.Windows.Forms.Padding(2)
        Me.cbClases.Name = "cbClases"
        Me.cbClases.Size = New System.Drawing.Size(123, 21)
        Me.cbClases.TabIndex = 7
        '
        'btnBuscarClases
        '
        Me.btnBuscarClases.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarClases.Image = CType(resources.GetObject("btnBuscarClases.Image"), System.Drawing.Image)
        Me.btnBuscarClases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarClases.Location = New System.Drawing.Point(379, 56)
        Me.btnBuscarClases.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarClases.Name = "btnBuscarClases"
        Me.btnBuscarClases.Size = New System.Drawing.Size(70, 30)
        Me.btnBuscarClases.TabIndex = 22
        Me.btnBuscarClases.Text = "Buscar"
        Me.btnBuscarClases.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarClases.UseVisualStyleBackColor = True
        '
        'dgvEstudiantes
        '
        Me.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstudiantes.Location = New System.Drawing.Point(289, 168)
        Me.dgvEstudiantes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvEstudiantes.Name = "dgvEstudiantes"
        Me.dgvEstudiantes.RowHeadersWidth = 72
        Me.dgvEstudiantes.RowTemplate.Height = 31
        Me.dgvEstudiantes.Size = New System.Drawing.Size(329, 142)
        Me.dgvEstudiantes.TabIndex = 23
        '
        'btnRegresarComp
        '
        Me.btnRegresarComp.Font = New System.Drawing.Font("Mongolian Baiti", 8.142858!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresarComp.Image = CType(resources.GetObject("btnRegresarComp.Image"), System.Drawing.Image)
        Me.btnRegresarComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegresarComp.Location = New System.Drawing.Point(379, 90)
        Me.btnRegresarComp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegresarComp.Name = "btnRegresarComp"
        Me.btnRegresarComp.Size = New System.Drawing.Size(71, 30)
        Me.btnRegresarComp.TabIndex = 24
        Me.btnRegresarComp.Text = "Regresar"
        Me.btnRegresarComp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresarComp.UseVisualStyleBackColor = True
        '
        'pntClases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 406)
        Me.Controls.Add(Me.btnRegresarComp)
        Me.Controls.Add(Me.dgvEstudiantes)
        Me.Controls.Add(Me.btnBuscarClases)
        Me.Controls.Add(Me.cbClases)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "pntClases"
        Me.Text = "pntClases"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEstudiantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cbClases As ComboBox
    Friend WithEvents btnBuscarClases As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvEstudiantes As DataGridView
    Friend WithEvents btnRegresarComp As Button
End Class
