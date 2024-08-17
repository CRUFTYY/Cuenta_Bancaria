Public Class Cuenta
    ' Constante de descubierto máximo
    Private Const DescMaximo As Double = 50000

    ' Atributos privados de la clase
    Private AP_Numero As Double
    Private AP_Nombre As String
    Private AP_Tipo As String
    Private AP_Saldo As Double
    Private AP_Descubierto As Double

    ' Constructor de la clase
    Public Sub New(ByVal numero As Double, ByVal nombre As String, ByVal tipo As String, ByVal descubierto As Double)
        Me.AP_Numero = numero
        Me.AP_Nombre = Left(nombre, 15) ' Limitar a 15 caracteres
        Me.AP_Tipo = tipo

        ' Validación del descubierto según el tipo de cuenta
        If tipo = "CA" Then
            Me.AP_Descubierto = 0
        ElseIf tipo = "CC" Then
            If descubierto > DescMaximo Then
                Me.AP_Descubierto = DescMaximo
            Else
                Me.AP_Descubierto = descubierto
            End If
        Else
            Throw New ArgumentException("Tipo de cuenta inválido. Solo se permite 'CC' o 'CA'.")
        End If

        Me.AP_Saldo = 0 ' Saldo inicial en 0
    End Sub

    ' Propiedades para acceder a los atributos
    Public Property Numero() As Double
        Get
            Return AP_Numero
        End Get
        Set(ByVal value As Double)
            AP_Numero = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return AP_Nombre
        End Get
        Set(ByVal value As String)
            AP_Nombre = Left(value, 15)
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return AP_Tipo
        End Get
        Set(ByVal value As String)
            AP_Tipo = value
        End Set
    End Property

    Public ReadOnly Property Saldo() As Double
        Get
            Return AP_Saldo
        End Get
    End Property

    Public Property Descubierto() As Double
        Get
            Return AP_Descubierto
        End Get
        Set(ByVal value As Double)
            If AP_Tipo = "CC" Then
                AP_Descubierto = Math.Min(value, DescMaximo)
            ElseIf AP_Tipo = "CA" Then
                AP_Descubierto = 0
            End If
        End Set
    End Property

    ' Métodos de la clase
    Public Sub Depositar(ByVal valor As Double)
        If valor > 0 Then
            AP_Saldo += valor
        Else
            Throw New ArgumentException("El valor a depositar debe ser positivo.")
        End If
    End Sub

    Public Function Extraer(ByVal valor As Double) As Boolean
        If valor > 0 Then
            If AP_Saldo + AP_Descubierto >= valor Then
                AP_Saldo -= valor
                Return True
            Else
                Return False
            End If
        Else
            Throw New ArgumentException("El valor a extraer debe ser positivo.")
        End If
    End Function

    ' Sobrecarga del método Extraer
    Public Function Extraer() As Boolean
        If AP_Saldo >= 0 Then
            AP_Saldo = 0
            Return True
        Else
            Return False
        End If
    End Function
End Class
