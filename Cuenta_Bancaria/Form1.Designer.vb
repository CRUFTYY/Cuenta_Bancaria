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
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtNumero
        ' 
        txtNumero.BackColor = SystemColors.ActiveCaptionText
        txtNumero.ForeColor = SystemColors.Info
        txtNumero.Location = New Point(275, 97)
        txtNumero.Margin = New Padding(5)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(233, 33)
        txtNumero.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        txtNombre.BackColor = SystemColors.ActiveCaptionText
        txtNombre.ForeColor = SystemColors.Info
        txtNombre.Location = New Point(275, 163)
        txtNombre.Margin = New Padding(5)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(233, 33)
        txtNombre.TabIndex = 1
        ' 
        ' txtTipo
        ' 
        txtTipo.BackColor = SystemColors.ActiveCaptionText
        txtTipo.ForeColor = SystemColors.Info
        txtTipo.Location = New Point(275, 230)
        txtTipo.Margin = New Padding(5)
        txtTipo.Name = "txtTipo"
        txtTipo.Size = New Size(93, 33)
        txtTipo.TabIndex = 2
        ' 
        ' txtDescubierto
        ' 
        txtDescubierto.BackColor = SystemColors.ActiveCaptionText
        txtDescubierto.ForeColor = SystemColors.Info
        txtDescubierto.Location = New Point(275, 297)
        txtDescubierto.Margin = New Padding(5)
        txtDescubierto.Name = "txtDescubierto"
        txtDescubierto.Size = New Size(93, 33)
        txtDescubierto.TabIndex = 3
        ' 
        ' txtMonto
        ' 
        txtMonto.BackColor = SystemColors.ActiveCaptionText
        txtMonto.ForeColor = SystemColors.Info
        txtMonto.Location = New Point(116, 469)
        txtMonto.Margin = New Padding(5)
        txtMonto.Multiline = True
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(112, 46)
        txtMonto.TabIndex = 4
        ' 
        ' lblNumero
        ' 
        lblNumero.AutoSize = True
        lblNumero.BackColor = SystemColors.ActiveCaptionText
        lblNumero.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold)
        lblNumero.Location = New Point(82, 100)
        lblNumero.Margin = New Padding(5, 0, 5, 0)
        lblNumero.Name = "lblNumero"
        lblNumero.Size = New Size(95, 26)
        lblNumero.TabIndex = 5
        lblNumero.Text = "Número"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.BackColor = SystemColors.ActiveCaptionText
        lblNombre.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold)
        lblNombre.Location = New Point(82, 166)
        lblNombre.Margin = New Padding(5, 0, 5, 0)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(95, 26)
        lblNombre.TabIndex = 6
        lblNombre.Text = "Nombre"
        ' 
        ' lblTipo
        ' 
        lblTipo.AutoSize = True
        lblTipo.BackColor = SystemColors.ActiveCaptionText
        lblTipo.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold)
        lblTipo.Location = New Point(82, 233)
        lblTipo.Margin = New Padding(5, 0, 5, 0)
        lblTipo.Name = "lblTipo"
        lblTipo.Size = New Size(163, 26)
        lblTipo.TabIndex = 7
        lblTipo.Text = "Tipo de cuenta"
        ' 
        ' lblDescubierto
        ' 
        lblDescubierto.AutoSize = True
        lblDescubierto.BackColor = SystemColors.ActiveCaptionText
        lblDescubierto.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold)
        lblDescubierto.Location = New Point(82, 300)
        lblDescubierto.Margin = New Padding(5, 0, 5, 0)
        lblDescubierto.Name = "lblDescubierto"
        lblDescubierto.Size = New Size(135, 26)
        lblDescubierto.TabIndex = 8
        lblDescubierto.Text = "Descubierto"
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.BackColor = SystemColors.ActiveCaptionText
        lblMonto.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold)
        lblMonto.Location = New Point(82, 478)
        lblMonto.Margin = New Padding(5, 0, 5, 0)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(24, 26)
        lblMonto.TabIndex = 9
        lblMonto.Text = "$"
        ' 
        ' btnAlta
        ' 
        btnAlta.BackColor = SystemColors.ActiveCaptionText
        btnAlta.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold)
        btnAlta.Location = New Point(641, 100)
        btnAlta.Margin = New Padding(5)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(124, 91)
        btnAlta.TabIndex = 10
        btnAlta.Text = "ALTA"
        btnAlta.UseVisualStyleBackColor = False
        ' 
        ' btnDepositar
        ' 
        btnDepositar.BackColor = SystemColors.ActiveCaptionText
        btnDepositar.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold)
        btnDepositar.Location = New Point(388, 472)
        btnDepositar.Margin = New Padding(5)
        btnDepositar.Name = "btnDepositar"
        btnDepositar.Size = New Size(118, 38)
        btnDepositar.TabIndex = 11
        btnDepositar.Text = "Depositar"
        btnDepositar.UseVisualStyleBackColor = False
        ' 
        ' btnExtraer
        ' 
        btnExtraer.BackColor = SystemColors.ActiveCaptionText
        btnExtraer.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold)
        btnExtraer.Location = New Point(388, 413)
        btnExtraer.Margin = New Padding(5)
        btnExtraer.Name = "btnExtraer"
        btnExtraer.Size = New Size(118, 38)
        btnExtraer.TabIndex = 12
        btnExtraer.Text = "Extraer"
        btnExtraer.UseVisualStyleBackColor = False
        ' 
        ' btnCerrarCuenta
        ' 
        btnCerrarCuenta.BackColor = SystemColors.ActiveCaptionText
        btnCerrarCuenta.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold)
        btnCerrarCuenta.ForeColor = SystemColors.Control
        btnCerrarCuenta.Location = New Point(641, 245)
        btnCerrarCuenta.Margin = New Padding(5)
        btnCerrarCuenta.Name = "btnCerrarCuenta"
        btnCerrarCuenta.Size = New Size(124, 88)
        btnCerrarCuenta.TabIndex = 13
        btnCerrarCuenta.Text = "Cerrar Cuenta"
        btnCerrarCuenta.UseVisualStyleBackColor = False
        ' 
        ' lbl_saldo
        ' 
        lbl_saldo.AutoSize = True
        lbl_saldo.BackColor = SystemColors.ActiveCaptionText
        lbl_saldo.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold)
        lbl_saldo.Location = New Point(734, 413)
        lbl_saldo.Name = "lbl_saldo"
        lbl_saldo.Size = New Size(54, 26)
        lbl_saldo.TabIndex = 14
        lbl_saldo.Text = "0,00"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold)
        Label1.Location = New Point(613, 414)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 26)
        Label1.TabIndex = 15
        Label1.Text = "Saldo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Font = New Font("Times New Roman", 18.0F, FontStyle.Bold)
        Label2.Location = New Point(702, 413)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 26)
        Label2.TabIndex = 16
        Label2.Text = "$"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(1348, 645)
        Controls.Add(Label2)
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
        ForeColor = SystemColors.ControlLightLight
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
    Friend WithEvents Label2 As Label
End Class
