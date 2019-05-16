Imports System

Module hipotenusa
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim ValorA, ValorB As Integer

        Console.WriteLine("Ingrese Lado A: ")
        ValorA = Console.ReadLine()
        Console.WriteLine("Ingrese Lado B: ")
        ValorB = Console.ReadLine()

        Console.WriteLine("El Valor de la hipotenusa es: " & hipotenusa(ValorA, ValorB))

    End Sub

    Function hipotenusa(ValorA As Integer, ValorB As Integer) As Integer
        Return Math.Sqrt(ValorA * ValorA + ValorB * ValorB)
    End Function


End Module
