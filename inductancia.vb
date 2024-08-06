Module Module1
    Sub Main()
        Dim frecuencia As Double
        Dim inductancia As Double
        Dim impedancia As Double


        Console.Write("Ingrese la frecuencia (Hz): ")
        frecuencia = Console.ReadLine()
        Console.Write("Ingrese el valor de la inductancia (H): ")
        inductancia = Console.ReadLine()
        impedancia = 2 * Math.PI * frecuencia * inductancia

        Console.WriteLine("La impedancia inductiva es: " & impedancia & " ohmios")

    End Sub
End Module
