Module Module1

    Sub Main()
        'Find the count of vowels characters in an entered string separately. 

        Dim str1, str2 As String
        Dim char1, char2 As Char
        Dim i, c, vowelcounter As Integer

        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        i = 0

        Console.WriteLine("Enter String to be processed: ")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            char1 = UCase(Mid(str1, i, 1))
            If char1 = "A" Or char1 = "E" Or char1 = "I" Or char1 = "O" Or char1 = "U" Then
                vowelcounter = vowelcounter + 1
            End If
        Next

        Console.WriteLine("Vowels: " & vbCrLf & vowelcounter)
        Console.ReadKey()


    End Sub

End Module
