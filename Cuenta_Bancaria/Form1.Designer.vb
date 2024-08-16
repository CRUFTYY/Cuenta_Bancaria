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
        txtNumero = New TextBox()
        txtNombre = New TextBox()
        txtTipo = New TextBox()
        txtDescubierto = New TextBox()
        txtMonto = New TextBox()
        lblNumero = New Label()
        lblNombre = New Label()
        lblTipo = New Label()
        lblDescubierto = New Label()
        lblMonto = New Label()
        btnAlta = New Button()
        btnDepositar = New Button()
        btnExtraer = New Button()
        btnCerrarCuenta = New Button()
        lbl_saldo = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtNumero
        ' 
        txtNumero.Location = New Point(275, 97)
        txtNumero.Margin = New Padding(5)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(233, 33)
        txtNumero.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(275, 163)
        txtNombre.Margin = New Padding(5)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(233, 33)
        txtNombre.TabIndex = 1
        ' 
        ' txtTipo
        ' 
        txtTipo.Location = New Point(275, 230)
        txtTipo.Margin = New Padding(5)
        txtTipo.Name = "txtTipo"
        txtTipo.Size = New Size(93, 33)
        txtTipo.TabIndex = 2
        ' 
        ' txtDescubierto
        ' 
        txtDescubierto.Location = New Point(275, 297)
        txtDescubierto.Margin = New Padding(5)
        txtDescubierto.Name = "txtDescubierto"
        txtDescubierto.Size = New Size(93, 33)
        txtDescubierto.TabIndex = 3
        ' 
        ' txtMonto
        ' 
        txtMonto.Location = New Point(147, 469)
        txtMonto.Margin = New Padding(5)
        txtMonto.Multiline = True
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(112, 46)
        txtMonto.TabIndex = 4
        ' 
        ' lblNumero
        ' 
        lblNumero.AutoSize = True
        lblNumero.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblNumero.Location = New Point(71, 97)
        lblNumero.Margin = New Padding(5, 0, 5, 0)
        lblNumero.Name = "lblNumero"
        lblNumero.Size = New Size(86, 25)
        lblNumero.TabIndex = 5
        lblNumero.Text = "Número"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblNombre.Location = New Point(71, 163)
        lblNombre.Margin = New Padding(5, 0, 5, 0)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(86, 25)
        lblNombre.TabIndex = 6
        lblNombre.Text = "Nombre"
        ' 
        ' lblTipo
        ' 
        lblTipo.AutoSize = True
        lblTipo.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblTipo.Location = New Point(71, 230)
        lblTipo.Margin = New Padding(5, 0, 5, 0)
        lblTipo.Name = "lblTipo"
        lblTipo.Size = New Size(144, 25)
        lblTipo.TabIndex = 7
        lblTipo.Text = "Tipo de cuenta"
        ' 
        ' lblDescubierto
        ' 
        lblDescubierto.AutoSize = True
        lblDescubierto.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblDescubierto.Location = New Point(71, 297)
        lblDescubierto.Margin = New Padding(5, 0, 5, 0)
        lblDescubierto.Name = "lblDescubierto"
        lblDescubierto.Size = New Size(120, 25)
        lblDescubierto.TabIndex = 8
        lblDescubierto.Text = "Descubierto"
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Location = New Point(83, 476)
        lblMonto.Margin = New Padding(5, 0, 5, 0)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(23, 25)
        lblMonto.TabIndex = 9
        lblMonto.Text = "$"
        ' 
        ' btnAlta
        ' 
        btnAlta.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        btnAlta.Location = New Point(630, 97)
        btnAlta.Margin = New Padding(5)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(124, 91)
        btnAlta.TabIndex = 10
        btnAlta.Text = "ALTA"
        btnAlta.UseVisualStyleBackColor = True
        ' 
        ' btnDepositar
        ' 
        btnDepositar.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        btnDepositar.Location = New Point(377, 469)
        btnDepositar.Margin = New Padding(5)
        btnDepositar.Name = "btnDepositar"
        btnDepositar.Size = New Size(118, 38)
        btnDepositar.TabIndex = 11
        btnDepositar.Text = "Depositar"
        btnDepositar.UseVisualStyleBackColor = True
        ' 
        ' btnExtraer
        ' 
        btnExtraer.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        btnExtraer.Location = New Point(377, 410)
        btnExtraer.Margin = New Padding(5)
        btnExtraer.Name = "btnExtraer"
        btnExtraer.Size = New Size(118, 38)
        btnExtraer.TabIndex = 12
        btnExtraer.Text = "Extraer"
        btnExtraer.UseVisualStyleBackColor = True
        ' 
        ' btnCerrarCuenta
        ' 
        btnCerrarCuenta.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        btnCerrarCuenta.Location = New Point(630, 242)
        btnCerrarCuenta.Margin = New Padding(5)
        btnCerrarCuenta.Name = "btnCerrarCuenta"
        btnCerrarCuenta.Size = New Size(124, 88)
        btnCerrarCuenta.TabIndex = 13
        btnCerrarCuenta.Text = "Cerrar Cuenta"
        btnCerrarCuenta.UseVisualStyleBackColor = True
        ' 
        ' lbl_saldo
        ' 
        lbl_saldo.AutoSize = True
        lbl_saldo.Location = New Point(676, 410)
        lbl_saldo.Name = "lbl_saldo"
        lbl_saldo.Size = New Size(50, 25)
        lbl_saldo.TabIndex = 14
        lbl_saldo.Text = "0,00"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(594, 410)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 15
        Label1.Text = "Saldo"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1348, 645)
        Controls.Add(Label1)
        Controls.Add(lbl_saldo)
        Controls.Add(btnCerrarCuenta)
        Controls.Add(btnExtraer)
        Controls.Add(btnDepositar)
        Controls.Add(btnAlta)
        Controls.Add(lblMonto)
        Controls.Add(lblDescubierto)
        Controls.Add(lblTipo)
        Controls.Add(lblNombre)
        Controls.Add(lblNumero)
        Controls.Add(txtMonto)
        Controls.Add(txtDescubierto)
        Controls.Add(txtTipo)
        Controls.Add(txtNombre)
        Controls.Add(txtNumero)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Margin = New Padding(5)
        Name = "Form1"
        Text = "Gestión de Cuenta Bancaria"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents txtDescubierto As TextBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblDescubierto As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnExtraer As Button
    Friend WithEvents btnCerrarCuenta As Button
    Friend WithEvents lbl_saldo As Label
    Friend WithEvents Label1 As Label
End Class
