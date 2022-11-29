Module Module1

    Sub Main()
        'Replace selected character with another in entered string'
        Dim str1, str2 As String
        Dim char1, char2, char3 As Char
        Dim i As Integer

        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        i = 0

        Console.WriteLine("Enter Sentence: ")
        str1 = Console.ReadLine

        Console.WriteLine("Enter Character to be replaced: ")
        char1 = Console.ReadLine

        Console.WriteLine("Enter Character to replace it with: ")
        char3 = Console.ReadLine

        For i = 1 To Len(str1)
            char2 = Mid(str1, i, 1)
            If char1 <> char2 Then
                str2 = str2 + char2
            Else : str2 = str2 + char3
            End If

        Next

        Console.WriteLine("The processed sentence is: ")
        Console.WriteLine(str2)
        Console.ReadKey()

    End Sub

End Module
