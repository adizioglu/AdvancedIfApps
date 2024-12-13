Imports System

Module Program
    Sub Main()
        Console.Write("What is your first name: ")
        Dim firstName As String = Console.ReadLine()

        Console.Write("What is your last name: ")
        Dim lastName As String = Console.ReadLine()

        If firstName.ToLower() = "tim" AndAlso lastName.ToLower() = "corey" Then
            Console.WriteLine("Hello Professor Corey")
        ElseIf firstName.ToLower() = "tim" OrElse lastName.ToLower() = "corey" Then
            Console.WriteLine("You have a great part in your name.")
        Else
            Console.WriteLine("Hello Student")
        End If

        'If firstName.ToLower() = "tim" AndAlso lastName.ToLower() = "corey" Then
        '    Console.WriteLine("Hello Mr. Corey")
        'ElseIf firstName.ToLower() = "tim" Then
        '    Console.WriteLine("Hello, you have a cool first name.")
        'ElseIf lastName.ToLower() = "corey" Then
        '    Console.WriteLine("You have a great last name.")
        'Else
        '    Console.WriteLine("Sorry you don't have a cooler name!")
        'End If

        'If firstName.ToLower() = "tim" Then
        '    Console.WriteLine("You have a cool first name.")
        'End If

        'If lastName.ToLower() = "corey" Then
        '    Console.WriteLine("You have a great last name.")
        'Else
        '    Console.WriteLine("Sorry your name isn't cooler.")
        'End If

        Dim age As Integer = 73

        ' ==, >, >=, <, <=, !=
        'If age <> 43 Then
        '    Console.WriteLine("Sorry, you aren't a great age.")
        'End If

        If (age >= 40 AndAlso age < 50) OrElse (age >= 70 AndAlso age < 80) Then
            Console.WriteLine("You are in your 40's or 70's")
        End If
    End Sub
End Module

