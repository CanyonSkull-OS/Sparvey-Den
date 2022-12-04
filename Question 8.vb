Module Module1

    Sub Main()
        'Given a string s, return a string
        'where all occurences of its first char have
        'been changed to '*', except do not change
        'the first char itself.
        'e.g., 'babble' yields 'ba*le' or 'alpha' outputs 'alph'
        'Assume that the string is length 1 or more

        Dim s, s2, s3 As String
        Dim char1, char2, char3, char4 As Char
        Dim i As Integer

        s = ""
        s2 = ""
        s3 = ""
        char1 = ""
        i = 0
        char2 = ""
        char3 = ""
        char4 = "*"

        Console.WriteLine("Enter String: ")
        s = Console.ReadLine

        char1 = Left(s, 1)
        s3 = s3 + char1

        For i = 1 To Len(s)
            char2 = Mid(s, i + 1, 1)
            If char2 <> char1 Then
                s3 = s3 + char2
            Else
                s3 = s3 + char4
            End If

        Next


        Console.WriteLine(s3)
        Console.ReadKey()
    End Sub

End Module
