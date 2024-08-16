Public Class Form1
    Private cuenta As Cuenta

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Try
            Dim numero As Integer = Integer.Parse(txtNumero.Text)
            Dim nombre As String = txtNombre.Text
            Dim tipo As String = txtTipo.Text.ToUpper()
            Dim descubierto As Integer = Integer.Parse(txtDescubierto.Text)

            cuenta = New Cuenta(numero, nombre, tipo, descubierto)
            MessageBox.Show("Cuenta creada exitosamente.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Try
            Dim monto As Integer = Integer.Parse(txtMonto.Text)
            cuenta.Depositar(monto)
            MessageBox.Show("Depósito realizado exitosamente. Saldo actual: " & cuenta.SaldoActual)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExtraer_Click(sender As Object, e As EventArgs) Handles btnExtraer.Click
        Try
            Dim monto As Integer = Integer.Parse(txtMonto.Text)
            If cuenta.Extraer(monto) Then
                MessageBox.Show("Extracción realizada exitosamente. Saldo actual: " & cuenta.SaldoActual)
            Else
                MessageBox.Show("Fondos insuficientes para la extracción.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCerrarCuenta_Click(sender As Object, e As EventArgs) Handles btnCerrarCuenta.Click
        Try
            ' Verificar si el saldo es mayor o igual a 0 antes de cerrar la cuenta
            If cuenta.SaldoActual >= 0 Then
                cuenta.CerrarCuenta()
                MessageBox.Show("Cuenta cerrada exitosamente.")
            Else
                MessageBox.Show("No se puede cerrar la cuenta con saldo negativo.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
