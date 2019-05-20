Imports System

Module sumas
    Sub Main(args As String())
        Dim a, b, c, d As Integer
        Console.WriteLine("Ingrese valor a: ")
        a = Console.ReadLine
        Console.WriteLine("Ingrese valor b: ")
        b = Console.ReadLine
        Console.WriteLine("Ingrese valor c: ")
        c = Console.ReadLine
        Console.WriteLine("Ingrese valor d: ")
        d = Console.ReadLine


        Console.WriteLine("A + B: " & sobrecargada(a, b))
        Console.WriteLine("A + B + C: " & sobrecargada(a, b, c))
        Console.WriteLine("A + B + C + D: " & sobrecargada(a, b, c, d))


    End Sub
    Function sobrecargada(a, b) As Integer
        Return a + b
    End Function
    Function sobrecargada(a, b, c) As Integer
        Return a + b + c
    End Function
    Function sobrecargada(a, b, c, d) As Integer
        Return a + b + c + d
    End Function


End Module
