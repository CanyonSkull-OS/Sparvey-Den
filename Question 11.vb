Module Module1

    Sub Main()
        'Given a string, find the first appearance of the
        'substring() 'not' and 'bad'. If the 'bad' follows
        'the() 'not', replace the whole 'not'...'bad' substring
        'with 'good'.
        'Return the resulting string.
        'Input:  'This dinner is not that bad!' 
        'Outputs: This(dinner Is good!)

        Dim str1, str2, str3, str4 As String
        Dim char1 As Char
        Dim i, pos, pos2 As Integer

        str1 = ""
        str2 = ""
        str3 = ""
        str4 = ""
        char1 = ""
        i = 0
        pos = 0

        Console.WriteLine("Enter String: ")
        str1 = Console.ReadLine

        pos = InStr(str1, "not")
        pos2 = InStr(str1, "bad")

        If pos < pos2 Then
            str2 = Mid(str1, pos, pos2)
            str3 = Mid(str1, 1, pos - 1)
            str4 = Replace(str1, str2, "Good")
            Console.WriteLine(str4)
        End If




        Console.ReadKey()

    End Sub

End Module
