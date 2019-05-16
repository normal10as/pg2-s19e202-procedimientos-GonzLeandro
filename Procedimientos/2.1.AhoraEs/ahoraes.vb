Imports System
Imports System.DateTime

Module ahoraes
    Sub Main(args As String())

        ImprimirFecha()
        Console.WriteLine("La hora actual es: " & ObtenerHora())

    End Sub

    Sub ImprimirFecha()
        Console.WriteLine("La fecha es: " & Now.Date)
    End Sub

    Function ObtenerHora()
        Return Now.Hour & ":" & Now.Minute
    End Function

End Module
