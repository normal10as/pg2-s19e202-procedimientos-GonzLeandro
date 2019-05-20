Imports System


Module program
    Private acumular As Decimal

    Sub Main(args As String())
        Dim valor As Decimal

        For i = 1 To 3
            Console.WriteLine("Ingrese un valor decimal: ")
            valor = Console.ReadLine
            Acumulador(valor)

        Next
    End Sub

    Sub Acumulador(valor As Decimal)
        acumular = acumular + valor
        Console.WriteLine("Este es el total acumulado: " & acumular)
    End Sub
End Module
