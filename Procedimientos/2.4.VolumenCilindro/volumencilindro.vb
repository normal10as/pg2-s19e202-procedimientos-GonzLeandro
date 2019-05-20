Imports System

Module volumencilindro
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim base, altura As Integer
        Console.WriteLine("Ingrese la base del cilindro: ")
        base = Console.ReadLine()
        Console.WriteLine("Ingrese la altura del cilindro: ")
        altura = Console.ReadLine()

        Console.WriteLine("El volumen del cilindro es: " & devolvervolumen(base, altura))

    End Sub

    Function devolvervolumen(base As Integer, altura As Integer) As Double

        Return Math.PI * base * base * altura

    End Function
End Module
