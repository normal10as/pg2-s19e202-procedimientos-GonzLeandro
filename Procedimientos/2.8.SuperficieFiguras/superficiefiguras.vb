Imports System

Module superficiefiguras
    Sub Main(args As String())
        Console.WriteLine("-Superficie de Figuras-")

        Console.WriteLine("Cuadrado_ 2x2
                AREA: " & resolverarea(2))
        Console.WriteLine("Rectangulo_ 2x4 
                AREA: " & resolverarea(2, 4))
        Console.WriteLine("Trapecio_ BaseM=4 Basem=2 Altura=3 
                AREA: " & resolverarea(4, 2, 3))

    End Sub
    Function resolverarea(lado) As Integer
        Return lado * lado
    End Function
    Function resolverarea(base, altura) As Integer
        Return base * altura
    End Function
    Function resolverarea(basemayor, basemenor, altura) As Integer
        Return ((basemayor + basemenor) / 2) * altura
    End Function

End Module
