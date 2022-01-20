Option Explicit On
Option Strict On

Module ConsoleExamples

    Sub Main()
        Dim input1 As String
        Dim input2 As String
        Dim number1 As Integer = 4
        Dim number2 As Integer
        Dim answer As Integer
        Dim math As String

        'Console.WriteLine("Please type and press enter...")
        'input = Console.ReadLine()
        'Console.WriteLine("You entered: " & input)

        Console.WriteLine("Please enter a number: ")
        input1 = Console.ReadLine()
        number1 = CInt(input1) 'Converts a String into an Integer
        Console.WriteLine("Please enter a second number: ")
        input2 = Console.ReadLine()
        number2 = CInt(input2)
        Console.WriteLine("sum or product?")
        math = Console.ReadLine()
        'answer = number1 + number2
        'Console.WriteLine(CStr(number1) & " + " & Cstr(number2) & " = " & Cstr(answer))
        'Console.WriteLine($"{number1} + {number2} = {answer}") 'Auto converts to string

        If math = "sum" Then
            answer = number1 + number2
            Console.WriteLine($"{number1} + {number2} = {answer}")
        ElseIf math = "product" Then
            answer = number1 * number2
            Console.WriteLine($"{number1} * {number2} = {answer}")
        Else
            Console.WriteLine("ERROR")
        End If

        Console.ReadLine()
    End Sub

End Module
