Module DEMO3
    'bkeller
    '10/3/23
    'pay calculator
    Sub main()
        Dim payRate, hoursWorked As Double 'these are values we will get from the user
        Dim input As String 'just used to get input from the user
        Dim grossPay As Double
        Dim valid As Boolean

        Console.Write("what is your pay per hour? >> ")
        input = Console.ReadLine
        valid = Double.TryParse(input, payRate)
        Console.Write("how many hours did you work? >> ")
        input = Console.ReadLine
        valid = Double.TryParse(input, hoursWorked)

        grossPay = (payRate * hoursWorked)
        Console.WriteLine(grossPay.ToString("C2"))

    End Sub
End Module
