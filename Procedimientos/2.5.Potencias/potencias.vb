Imports System

Module potencias
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim valor, x As Integer
        Console.WriteLine("Ingrese un valor a elevar: ")
        valor = Console.ReadLine

        'For x = 2 To 5
        '    If x = 4 Then
        '        x = 5
        '    End If
        '    Console.WriteLine("Los valores elevados son: " & elevar(valor, x))
        'Next
        Console.WriteLine(elevar(valor))


    End Sub

    'Function elevar(Valor As Integer, x As Integer) As Integer
    '    Return Math.Pow(Valor, x)
    'End Function

    Function elevar(Valor As Integer) As Integer
        Console.WriteLine("{0}^2={1} {0}^3={2} {0}^5={3}", Valor, Valor ^ 2, Valor ^ 3, Valor ^ 5)
        Return elevar
    End Function

End Module

