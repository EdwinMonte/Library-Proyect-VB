<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActionBook
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
        lblSucursal = New Label()
        btnToLend = New Button()
        btnPrice = New Button()
        lblPrice = New Label()
        lblTitle = New Label()
        SuspendLayout()
        ' 
        ' lblSucursal
        ' 
        lblSucursal.AutoSize = True
        lblSucursal.Location = New Point(127, 177)
        lblSucursal.Name = "lblSucursal"
        lblSucursal.Size = New Size(50, 20)
        lblSucursal.TabIndex = 13
        lblSucursal.Text = "label1"
        ' 
        ' btnToLend
        ' 
        btnToLend.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnToLend.Location = New Point(74, 308)
        btnToLend.Name = "btnToLend"
        btnToLend.Size = New Size(129, 42)
        btnToLend.TabIndex = 12
        btnToLend.Text = "To Lend"
        btnToLend.UseVisualStyleBackColor = True
        ' 
        ' btnPrice
        ' 
        btnPrice.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrice.Location = New Point(74, 244)
        btnPrice.Name = "btnPrice"
        btnPrice.Size = New Size(129, 38)
        btnPrice.TabIndex = 11
        btnPrice.Text = "To Buy"
        btnPrice.UseVisualStyleBackColor = True
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPrice.Location = New Point(119, 116)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(64, 21)
        lblPrice.TabIndex = 10
        lblPrice.Text = "label2"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(119, 48)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(64, 21)
        lblTitle.TabIndex = 9
        lblTitle.Text = "label1"
        ' 
        ' FormActionBook
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblSucursal)
        Controls.Add(btnToLend)
        Controls.Add(btnPrice)
        Controls.Add(lblPrice)
        Controls.Add(lblTitle)
        Name = "FormActionBook"
        Text = "FormActionBook"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents lblSucursal As Label
    Private WithEvents btnToLend As Button
    Private WithEvents btnPrice As Button
    Private WithEvents lblPrice As Label
    Private WithEvents lblTitle As Label
End Class
