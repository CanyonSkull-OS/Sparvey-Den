Module Module1

    Sub Main()
        'INPUT an INT count of a number of donuts, OUTPUT a string
        'of the form 'Number of donuts: <count>', where <count> is the number
        'input. However, if the count is 10 or more, then use the word 'many'
        'instead of the actual count.
        'So donuts(5) outputs 'Number of donuts: 5'
        'and donuts(23) outputs 'Number of donuts: many

        Dim str1 As String
        Dim char1 As Char
        Dim i, donuts As Integer

        str1 = ""
        char1 = ""
        i = 0
        donuts = 0

        Console.WriteLine("How many donuts are there? ")
        donuts = Console.ReadLine

        If donuts >= 10 Then
            Console.WriteLine("Number of donuts: Many")
        Else
            Console.WriteLine("Number of donuts: " & donuts)
        End If

        Console.ReadKey()



    End Sub

End Module
