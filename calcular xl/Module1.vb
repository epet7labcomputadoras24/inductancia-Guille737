Module Module1

    Sub Main()
        Console.Write("Ingrese el valor de frecuencia: ")
        Dim Frecuencia As String
        Frecuencia = Console.ReadLine
        Console.Write("Ingrese el valor de inductancia: ")
        Dim Inductor As String
        Inductor = Console.ReadLine
        Dim resultado As String
        resultado = (2 * 3.1415 * Frecuencia * Inductor)
        Console.WriteLine("su resultado es: " & resultado)
    End Sub

End Module
