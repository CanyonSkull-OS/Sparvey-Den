Module Module1

    Sub Main()
        'Input a string s, output a string made of the first 2
        'and the last 2 chars of the original string,
        'so() 'spring' yields 'spng'. However, if the string length
        'is less than 2, return string s instead the empty string.

        Dim s, s2, sword, s2word As String
        Dim i As Integer

        s = ""
        s2 = ""
        sword = ""
        s2word = ""
        i = 0

        Console.WriteLine("Enter String: ")
        s = Console.ReadLine
        sword = Left(s, 2)
        s2word = Right(s, 2)
        If Len(s) < 2 Then
            Console.WriteLine(s)
        Else
            s2 = sword & s2word
        End If

        Console.WriteLine(s2)
        Console.ReadKey()


    End Sub

End Module
