Public Class Cuenta
    ' Atributos privados de la clase
    Private numero As Integer
    Private nombre As String
    Private tipo As String
    Private descubierto As Decimal
    Private saldo As Decimal

    ' Constructor de la clase
    Public Sub New(ByVal numero As Integer, ByVal nombre As String, ByVal tipo As String, ByVal descubierto As Decimal)
        Me.numero = numero
        Me.nombre = nombre
        Me.tipo = tipo
        Me.descubierto = descubierto
        Me.saldo = 0
    End Sub

    ' Propiedades para acceder a los atributos
    Public Property NumeroCuenta() As Integer
        Get
            Return numero
        End Get
        Set(ByVal value As Integer)
            numero = value
        End Set
    End Property

    Public Property NombreTitular() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public Property TipoCuenta() As String
        Get
            Return tipo
        End Get
        Set(ByVal value As String)
            tipo = value
        End Set
    End Property

    Public Property DescubiertoPermitido() As Decimal
        Get
            Return descubierto
        End Get
        Set(ByVal value As Decimal)
            descubierto = value
        End Set
    End Property

    Public ReadOnly Property SaldoActual() As Decimal
        Get
            Return saldo
        End Get
    End Property

    ' Métodos de la clase
    Public Sub Depositar(ByVal monto As Decimal)
        If monto > 0 Then
            saldo += monto
        Else
            Throw New ArgumentException("El monto a depositar debe ser positivo.")
        End If
    End Sub

    Public Function Extraer(ByVal monto As Decimal) As Boolean
        If monto > 0 Then
            If saldo + descubierto >= monto Then
                saldo -= monto
                Return True
            Else
                Return False
            End If
        Else
            Throw New ArgumentException("El monto a extraer debe ser positivo.")
        End If
    End Function

    Public Sub CerrarCuenta()
        saldo = 0
    End Sub

    Public Overrides Function ToString() As String
        Return $"Cuenta Nº: {numero}, Titular: {nombre}, Tipo: {tipo}, Saldo: {saldo:C}, Descubierto: {descubierto:C}"
    End Function
End Class
