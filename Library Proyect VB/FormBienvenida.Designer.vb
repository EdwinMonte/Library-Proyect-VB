<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBienvenida
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
        txtCorreo = New TextBox()
        txtNombre = New TextBox()
        lblCorreo = New Label()
        lblNombre = New Label()
        lblBienvenida = New Label()
        btnContinuar = New Button()
        SuspendLayout()
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(254, 205)
        txtCorreo.Multiline = True
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(309, 34)
        txtCorreo.TabIndex = 17
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(254, 132)
        txtNombre.Multiline = True
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(309, 34)
        txtNombre.TabIndex = 16
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCorreo.Location = New Point(161, 211)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(64, 28)
        lblCorreo.TabIndex = 15
        lblCorreo.Text = "Email"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNombre.Location = New Point(157, 138)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(68, 28)
        lblNombre.TabIndex = 14
        lblNombre.Text = "Name"
        ' 
        ' lblBienvenida
        ' 
        lblBienvenida.AutoSize = True
        lblBienvenida.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBienvenida.Location = New Point(369, 50)
        lblBienvenida.Name = "lblBienvenida"
        lblBienvenida.Size = New Size(99, 28)
        lblBienvenida.TabIndex = 13
        lblBienvenida.Text = "Welcome"
        ' 
        ' btnContinuar
        ' 
        btnContinuar.BackColor = SystemColors.InactiveCaption
        btnContinuar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnContinuar.Location = New Point(369, 270)
        btnContinuar.Name = "btnContinuar"
        btnContinuar.Size = New Size(145, 53)
        btnContinuar.TabIndex = 12
        btnContinuar.Text = "Continue"
        btnContinuar.UseVisualStyleBackColor = False
        ' 
        ' FormBienvenida
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtCorreo)
        Controls.Add(txtNombre)
        Controls.Add(lblCorreo)
        Controls.Add(lblNombre)
        Controls.Add(lblBienvenida)
        Controls.Add(btnContinuar)
        Name = "FormBienvenida"
        Text = "FormBienvenida"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents txtCorreo As TextBox
    Private WithEvents txtNombre As TextBox
    Private WithEvents lblCorreo As Label
    Private WithEvents lblNombre As Label
    Private WithEvents lblBienvenida As Label
    Private WithEvents btnContinuar As Button
End Class
