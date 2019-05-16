Imports System
Imports System.DateTime

Module nueva_fecha
    Sub Main(args As String())
        Dim fecha As Date
        Dim valor As Integer

        Console.WriteLine("Ingresar una fecha: ")
        fecha = Console.ReadLine()
        Console.WriteLine("Ingrese la cantidad de dias que quiere sumar: ")
        valor = Console.ReadLine()

        Console.WriteLine("La nueva fecha es: " & RecibirValor(fecha, valor))

    End Sub

    Function RecibirValor(fecha As Date, valor As Integer) As Date
        Return fecha.AddDays(valor)
    End Function
End Module
