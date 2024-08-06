Module program
    Sub main()
        console.write("Escriba la frecuencia: ")
        Dim frecuencia As String
        frecuencia = console.readline
        console.write("Escriba L: ")
        Dim L As String
        L = console.readline
        Dim resultado As String
        resultado = 2 * 3.1415 * frecuencia * L
        console.writeline("Eñ resultado es: " & resultado)
    End Sub
End Module