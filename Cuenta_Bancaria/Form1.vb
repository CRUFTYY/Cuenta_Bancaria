Public Class Form1
    Private cuenta As Cuenta

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Try
            Dim numero As Double = Double.Parse(txtNumero.Text)
            Dim nombre As String = txtNombre.Text
            Dim tipo As String = txtTipo.Text.ToUpper()
            Dim descubierto As Double = Double.Parse(txtDescubierto.Text)

            cuenta = New Cuenta(numero, nombre, tipo, descubierto)
            MessageBox.Show($"Cuenta creada exitosamente.{vbCrLf} 
            Numero: {cuenta.Numero}           {vbCrLf} 
            nombre: {cuenta.Nombre}           {vbCrLf}
            Tipo de cuenta: {cuenta.Tipo}     {vbCrLf} 
            descubierto: {cuenta.Descubierto} {vbCrLf} ")

            txtMonto.Enabled = True
            btnExtraer.Enabled = True
            btnDepositar.Enabled = True
            btnCerrarCuenta.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Try
            Dim monto As Double = Double.Parse(txtMonto.Text)
            cuenta.Depositar(monto)
            MessageBox.Show("Depósito realizado exitosamente. Saldo actual: " & cuenta.Saldo)
            lbl_saldo.Text = cuenta.Saldo.ToString("N2")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExtraer_Click(sender As Object, e As EventArgs) Handles btnExtraer.Click
        Try
            Dim monto As Double = Double.Parse(txtMonto.Text)
            If cuenta.Extraer(monto) Then
                MessageBox.Show("Extracción realizada exitosamente. Saldo actual: " & cuenta.Saldo)
                lbl_saldo.Text = cuenta.Saldo.ToString("N2")
            Else
                MessageBox.Show("Fondos insuficientes para la extracción.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCerrarCuenta_Click(sender As Object, e As EventArgs) Handles btnCerrarCuenta.Click
        Try
            If cuenta.Extraer() Then

                MessageBox.Show("Cuenta cerrada exitosamente.")

                System.Threading.Thread.Sleep(1500)
                Application.Exit() ' Cierra el programa al cerrar la cuenta
            Else
                MessageBox.Show("No se puede cerrar la cuenta con saldo negativo.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMonto.Enabled = False
        btnExtraer.Enabled = False
        btnDepositar.Enabled = False
        btnCerrarCuenta.Enabled = False


    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        ' Permitir solo números, comas, puntos y el carácter de control (como backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> ","c AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        ' Verificar si el carácter presionado es un número o la tecla de retroceso (para permitir borrar)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un número ni una tecla de control (como la tecla de borrar), cancelar el evento
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescubierto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescubierto.KeyPress
        ' Permitir solo números, la tecla de retroceso y un único punto o coma decimal
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If

        ' Asegurarse de que solo se permita un único punto o coma decimal
        If (e.KeyChar = "." OrElse e.KeyChar = ",") AndAlso (CType(sender, TextBox).Text.Contains(".") OrElse CType(sender, TextBox).Text.Contains(",")) Then
            e.Handled = True
        End If
    End Sub

End Class
