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
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtDescubierto = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblDescubierto = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.btnExtraer = New System.Windows.Forms.Button()
        Me.btnCerrarCuenta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        ' 
        ' txtNumero
        ' 
        Me.txtNumero.Location = New System.Drawing.Point(120, 20)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(150, 23)
        Me.txtNumero.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        Me.txtNombre.Location = New System.Drawing.Point(120, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(150, 23)
        Me.txtNombre.TabIndex = 1
        ' 
        ' txtTipo
        ' 
        Me.txtTipo.Location = New System.Drawing.Point(120, 100)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(150, 23)
        Me.txtTipo.TabIndex = 2
        ' 
        ' txtDescubierto
        ' 
        Me.txtDescubierto.Location = New System.Drawing.Point(120, 140)
        Me.txtDescubierto.Name = "txtDescubierto"
        Me.txtDescubierto.Size = New System.Drawing.Size(150, 23)
        Me.txtDescubierto.TabIndex = 3
        ' 
        ' txtMonto
        ' 
        Me.txtMonto.Location = New System.Drawing.Point(120, 180)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(150, 23)
        Me.txtMonto.TabIndex = 4
        ' 
        ' lblNumero
        ' 
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(20, 23)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(52, 15)
        Me.lblNumero.TabIndex = 5
        Me.lblNumero.Text = "Número"
        ' 
        ' lblNombre
        ' 
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(20, 63)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(51, 15)
        Me.lblNombre.TabIndex = 6
        Me.lblNombre.Text = "Nombre"
        ' 
        ' lblTipo
        ' 
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(20, 103)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(30, 15)
        Me.lblTipo.TabIndex = 7
        Me.lblTipo.Text = "Tipo"
        ' 
        ' lblDescubierto
        ' 
        Me.lblDescubierto.AutoSize = True
        Me.lblDescubierto.Location = New System.Drawing.Point(20, 143)
        Me.lblDescubierto.Name = "lblDescubierto"
        Me.lblDescubierto.Size = New System.Drawing.Size(69, 15)
        Me.lblDescubierto.TabIndex = 8
        Me.lblDescubierto.Text = "Descubierto"
        ' 
        ' lblMonto
        ' 
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(20, 183)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(43, 15)
        Me.lblMonto.TabIndex = 9
        Me.lblMonto.Text = "Monto"
        ' 
        ' btnAlta
        ' 
        Me.btnAlta.Location = New System.Drawing.Point(20, 220)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnAlta.TabIndex = 10
        Me.btnAlta.Text = "ALTA"
        Me.btnAlta.UseVisualStyleBackColor = True
        ' 
        ' btnDepositar
        ' 
        Me.btnDepositar.Location = New System.Drawing.Point(120, 220)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(75, 23)
        Me.btnDepositar.TabIndex = 11
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        ' 
        ' btnExtraer
        ' 
        Me.btnExtraer.Location = New System.Drawing.Point(220, 220)
        Me.btnExtraer.Name = "btnExtraer"
        Me.btnExtraer.Size = New System.Drawing.Size(75, 23)
        Me.btnExtraer.TabIndex = 12
        Me.btnExtraer.Text = "Extraer"
        Me.btnExtraer.UseVisualStyleBackColor = True
        ' 
        ' btnCerrarCuenta
        ' 
        Me.btnCerrarCuenta.Location = New System.Drawing.Point(320, 220)
        Me.btnCerrarCuenta.Name = "btnCerrarCuenta"
        Me.btnCerrarCuenta.Size = New System.Drawing.Size(100, 23)
        Me.btnCerrarCuenta.TabIndex = 13
        Me.btnCerrarCuenta.Text = "Cerrar Cuenta"
        Me.btnCerrarCuenta.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(450, 270)
        Controls.Add(Me.btnCerrarCuenta)
        Controls.Add(Me.btnExtraer)
        Controls.Add(Me.btnDepositar)
        Controls.Add(Me.btnAlta)
        Controls.Add(Me.lblMonto)
        Controls.Add(Me.lblDescubierto)
        Controls.Add(Me.lblTipo)
        Controls.Add(Me.lblNombre)
        Controls.Add(Me.lblNumero)
        Controls.Add(Me.txtMonto)
        Controls.Add(Me.txtDescubierto)
        Controls.Add(Me.txtTipo)
        Controls.Add(Me.txtNombre)
        Controls.Add(Me.txtNumero)
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
End Class
