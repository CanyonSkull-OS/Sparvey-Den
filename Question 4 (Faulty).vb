Module Module1

    Sub Main()
        'Find the character that appears most number of times in an entered string and output it.
        Dim str1, str2 As String
        Dim char1, char2 As Char
        Dim i, charcount As Integer

        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        i = 0
        charcount = 0

        Console.WriteLine("Enter String to be processed: ")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            If InStr(str1, char1) = True Then
                charcount = charcount + 1
            End If




        Next

        Console.WriteLine(charcount)
        Console.ReadKey()
    End Sub

End Module
