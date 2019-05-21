Imports System


Module program
    Private acumular As Decimal

    Sub Main(args As String())
        Dim valor As Decimal

        Console.Write("Ingrese un valor decimal: ")
        valor = Console.ReadLine
        Acumulador(valor)
        Console.Write("Ingrese un valor decimal: ")
        valor = Console.ReadLine
        Acumulador(valor)
        Console.Write("Ingrese un valor decimal: ")
        valor = Console.ReadLine
        Acumulador(valor)

    End Sub

    Sub Acumulador(valor As Decimal)
        acumular = acumular + valor
        Console.WriteLine("Este es el total acumulado: " & acumular)
    End Sub
End Module
