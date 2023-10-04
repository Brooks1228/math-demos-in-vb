Module demo2
    'bkeller
    '10/3/23
    'fahrenheit to celsius calculator
    Sub main()
        'accept input from the user.
        'convert it into a double (Double.TryParse(str, double)
        'convert the int from an F temp to a C temp
        'formula is F - 32 * 5/9

        Dim F As Double
        Dim C As Double
        Dim input As String
        Console.Write("please enter your temperature in fahrenheit >> ")
        input = Console.ReadLine
        Double.TryParse(input, F)
        C = (F - 32) * (5 / 9)
        Console.WriteLine(C.ToString("N3"))
        Console.ReadKey()
    End Sub
End Module
