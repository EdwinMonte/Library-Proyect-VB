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
        txtSucursal = New TextBox()
        lblSucursal = New Label()
        txtPrice = New TextBox()
        lblPrecio = New Label()
        lblPages = New Label()
        lblAuthor = New Label()
        lbltitle = New Label()
        lstvLibros = New ListView()
        btnSavetxt = New Button()
        btnChargingtxt = New Button()
        btnExportExcel = New Button()
        btnExportWord = New Button()
        btnExportJSON = New Button()
        btnaddbook = New Button()
        txtPaginas = New TextBox()
        txtAutor = New TextBox()
        txtTitulo = New TextBox()
        btnVerUsuario = New Button()
        lblCorreoUsuario = New Label()
        lblNombreUsuario = New Label()
        btnEliminarLibro = New Button()
        SuspendLayout()
        ' 
        ' txtSucursal
        ' 
        txtSucursal.Location = New Point(127, 282)
        txtSucursal.Multiline = True
        txtSucursal.Name = "txtSucursal"
        txtSucursal.Size = New Size(125, 34)
        txtSucursal.TabIndex = 66
        ' 
        ' lblSucursal
        ' 
        lblSucursal.AutoSize = True
        lblSucursal.Location = New Point(38, 296)
        lblSucursal.Name = "lblSucursal"
        lblSucursal.Size = New Size(63, 20)
        lblSucursal.TabIndex = 65
        lblSucursal.Text = "Sucursal"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(127, 228)
        txtPrice.Multiline = True
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(137, 34)
        txtPrice.TabIndex = 64
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPrecio.Location = New Point(47, 237)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(54, 25)
        lblPrecio.TabIndex = 63
        lblPrecio.Text = "Price"
        ' 
        ' lblPages
        ' 
        lblPages.AutoSize = True
        lblPages.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPages.Location = New Point(39, 177)
        lblPages.Name = "lblPages"
        lblPages.Size = New Size(62, 25)
        lblPages.TabIndex = 62
        lblPages.Text = "Pages"
        ' 
        ' lblAuthor
        ' 
        lblAuthor.AutoSize = True
        lblAuthor.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAuthor.Location = New Point(39, 124)
        lblAuthor.Name = "lblAuthor"
        lblAuthor.Size = New Size(72, 25)
        lblAuthor.TabIndex = 61
        lblAuthor.Text = "Author"
        ' 
        ' lbltitle
        ' 
        lbltitle.AutoSize = True
        lbltitle.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltitle.Location = New Point(58, 72)
        lbltitle.Name = "lbltitle"
        lbltitle.Size = New Size(50, 25)
        lbltitle.TabIndex = 59
        lbltitle.Text = "Title"
        ' 
        ' lstvLibros
        ' 
        lstvLibros.Font = New Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstvLibros.Location = New Point(293, 25)
        lstvLibros.Name = "lstvLibros"
        lstvLibros.Size = New Size(851, 632)
        lstvLibros.TabIndex = 60
        lstvLibros.UseCompatibleStateImageBehavior = False
        lstvLibros.View = View.Details
        ' 
        ' btnSavetxt
        ' 
        btnSavetxt.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSavetxt.Location = New Point(11, 403)
        btnSavetxt.Name = "btnSavetxt"
        btnSavetxt.Size = New Size(125, 38)
        btnSavetxt.TabIndex = 58
        btnSavetxt.Text = "Save txt"
        btnSavetxt.UseVisualStyleBackColor = True
        ' 
        ' btnChargingtxt
        ' 
        btnChargingtxt.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnChargingtxt.Location = New Point(11, 456)
        btnChargingtxt.Name = "btnChargingtxt"
        btnChargingtxt.Size = New Size(125, 42)
        btnChargingtxt.TabIndex = 57
        btnChargingtxt.Text = "Charging txt"
        btnChargingtxt.UseVisualStyleBackColor = True
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.BackColor = Color.Lime
        btnExportExcel.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportExcel.Location = New Point(142, 403)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(122, 38)
        btnExportExcel.TabIndex = 56
        btnExportExcel.Text = "Export Excel"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' btnExportWord
        ' 
        btnExportWord.BackColor = SystemColors.Highlight
        btnExportWord.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportWord.Location = New Point(58, 504)
        btnExportWord.Name = "btnExportWord"
        btnExportWord.Size = New Size(122, 44)
        btnExportWord.TabIndex = 55
        btnExportWord.Text = "Export Word"
        btnExportWord.UseVisualStyleBackColor = False
        ' 
        ' btnExportJSON
        ' 
        btnExportJSON.BackColor = SystemColors.GrayText
        btnExportJSON.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExportJSON.Location = New Point(142, 456)
        btnExportJSON.Name = "btnExportJSON"
        btnExportJSON.Size = New Size(122, 42)
        btnExportJSON.TabIndex = 54
        btnExportJSON.Text = "Export JSON"
        btnExportJSON.UseVisualStyleBackColor = False
        ' 
        ' btnaddbook
        ' 
        btnaddbook.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnaddbook.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnaddbook.ForeColor = Color.Black
        btnaddbook.Location = New Point(33, 349)
        btnaddbook.Name = "btnaddbook"
        btnaddbook.Size = New Size(219, 34)
        btnaddbook.TabIndex = 53
        btnaddbook.Text = "Add book"
        btnaddbook.UseVisualStyleBackColor = False
        ' 
        ' txtPaginas
        ' 
        txtPaginas.Location = New Point(127, 165)
        txtPaginas.Multiline = True
        txtPaginas.Name = "txtPaginas"
        txtPaginas.Size = New Size(137, 37)
        txtPaginas.TabIndex = 52
        ' 
        ' txtAutor
        ' 
        txtAutor.Location = New Point(127, 113)
        txtAutor.Multiline = True
        txtAutor.Name = "txtAutor"
        txtAutor.Size = New Size(137, 36)
        txtAutor.TabIndex = 51
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(127, 63)
        txtTitulo.Multiline = True
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(151, 34)
        txtTitulo.TabIndex = 50
        ' 
        ' btnVerUsuario
        ' 
        btnVerUsuario.Location = New Point(1150, 206)
        btnVerUsuario.Name = "btnVerUsuario"
        btnVerUsuario.Size = New Size(135, 34)
        btnVerUsuario.TabIndex = 70
        btnVerUsuario.Text = "Ver Usuario"
        btnVerUsuario.UseVisualStyleBackColor = True
        ' 
        ' lblCorreoUsuario
        ' 
        lblCorreoUsuario.AutoSize = True
        lblCorreoUsuario.Location = New Point(1158, 148)
        lblCorreoUsuario.Name = "lblCorreoUsuario"
        lblCorreoUsuario.Size = New Size(50, 20)
        lblCorreoUsuario.TabIndex = 69
        lblCorreoUsuario.Text = "label2"
        ' 
        ' lblNombreUsuario
        ' 
        lblNombreUsuario.AutoSize = True
        lblNombreUsuario.Location = New Point(1158, 101)
        lblNombreUsuario.Name = "lblNombreUsuario"
        lblNombreUsuario.Size = New Size(50, 20)
        lblNombreUsuario.TabIndex = 68
        lblNombreUsuario.Text = "label1"
        ' 
        ' btnEliminarLibro
        ' 
        btnEliminarLibro.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminarLibro.Location = New Point(1150, 25)
        btnEliminarLibro.Name = "btnEliminarLibro"
        btnEliminarLibro.Size = New Size(131, 42)
        btnEliminarLibro.TabIndex = 67
        btnEliminarLibro.Text = "Delete book"
        btnEliminarLibro.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1305, 742)
        Controls.Add(btnVerUsuario)
        Controls.Add(lblCorreoUsuario)
        Controls.Add(lblNombreUsuario)
        Controls.Add(btnEliminarLibro)
        Controls.Add(txtSucursal)
        Controls.Add(lblSucursal)
        Controls.Add(txtPrice)
        Controls.Add(lblPrecio)
        Controls.Add(lblPages)
        Controls.Add(lblAuthor)
        Controls.Add(lbltitle)
        Controls.Add(lstvLibros)
        Controls.Add(btnSavetxt)
        Controls.Add(btnChargingtxt)
        Controls.Add(btnExportExcel)
        Controls.Add(btnExportWord)
        Controls.Add(btnExportJSON)
        Controls.Add(btnaddbook)
        Controls.Add(txtPaginas)
        Controls.Add(txtAutor)
        Controls.Add(txtTitulo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents txtSucursal As TextBox
    Private WithEvents lblSucursal As Label
    Private WithEvents txtPrice As TextBox
    Private WithEvents lblPrecio As Label
    Private WithEvents lblPages As Label
    Private WithEvents lblAuthor As Label
    Private WithEvents lbltitle As Label
    Private WithEvents lstvLibros As ListView
    Private WithEvents btnSavetxt As Button
    Private WithEvents btnChargingtxt As Button
    Private WithEvents btnExportExcel As Button
    Private WithEvents btnExportWord As Button
    Private WithEvents btnExportJSON As Button
    Private WithEvents btnaddbook As Button
    Private WithEvents txtPaginas As TextBox
    Private WithEvents txtAutor As TextBox
    Private WithEvents txtTitulo As TextBox
    Private WithEvents btnVerUsuario As Button
    Private WithEvents lblCorreoUsuario As Label
    Private WithEvents lblNombreUsuario As Label
    Private WithEvents btnEliminarLibro As Button

End Class
