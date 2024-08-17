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
            Dim monto As Integer = Integer.Parse(txtMonto.Text)
            cuenta.Depositar(monto)
            MessageBox.Show("Depósito realizado exitosamente. Saldo actual: " & cuenta.Saldo)
            lbl_saldo.Text = cuenta.Saldo.ToString("N2")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExtraer_Click(sender As Object, e As EventArgs) Handles btnExtraer.Click
        Try
            Dim monto As Integer = Integer.Parse(txtMonto.Text)
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

    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged

    End Sub
End Class
