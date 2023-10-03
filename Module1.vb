Module Module1
    'brooks keller
    '10/3/23
    'maths demo 1
    Sub Main()
        Dim num1, num2 As Integer
        Dim added, subtracted, multiplied As Integer
        Dim divide As Double
        Dim valid As Boolean

        Dim input As String
        Console.Write("Please enter the first number >> ")
        input = Console.ReadLine

        'the following method takes a string and tries
        'to convert it to an integer. if it cant
        'it stores 0 in the integer variable passed in
        'it returns true for a valid conversion, false otherwise
        valid = Integer.TryParse(input, num1)
        Console.WriteLine(valid & ": " & num1)

        'for number 2
        Console.Write("Please enter the second number >> ")
        input = Console.ReadLine
        valid = Integer.TryParse(input, num2)
        Console.WriteLine(valid & ": " & num2)
        added = num1 + num2
        subtracted = num1 - num2
        multiplied = num1 * num2
        divide = num1 \ num2
        Console.WriteLine("{0} + {1} = {2}", num1, num2, added)
        Console.WriteLine("{0} - {1} = {2}", num1, num2, subtracted)
        Console.WriteLine("{0} * {1} = {2}", num1, num2, multiplied)
        'how many times the number can whole go into the other number ex 4 can go into 6 wholly one time
        Console.WriteLine("{0} \ {1} = {2} << thats integer division right there", num1, num2, divide)

        divide = num1 / num2
        'format the double to be a number with 2 decimal places
        Console.WriteLine("{0} / {1} = {2} << normal division", num1, num2, divide.ToString("N2"))

        Console.ReadKey()
    End Sub

End Module
