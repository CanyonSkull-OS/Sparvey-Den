Module Module1

    Sub Main()
        ' Count and output the NUMBER of an entered character in a string. Also output separate counts for alphabets (cap & small together), digits and other characters in same entered string.
        Dim str1, str2 As String
        Dim char1, char2 As Char
        Dim i, lettercounter, digitcounter, othercounter As Integer

        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        i = 0
        lettercounter = 0
        digitcounter = 0
        othercounter = 0

        Console.WriteLine("Enter string to be processed: ")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            char1 = UCase(Mid(str1, i, 1))
            If Asc(char1) >= "65" And Asc(char1) <= "90" Then
                lettercounter = lettercounter + 1
            ElseIf Asc(char1) >= "48" And Asc(char1) <= "57" Then
                digitcounter = digitcounter + 1
            Else
                othercounter = othercounter + 1

            End If
        Next

        Console.WriteLine("Letters: " & lettercounter & vbCrLf & "Digits: " & digitcounter & vbCrLf & "Other Characters: " & othercounter)
        Console.ReadKey()

    End Sub

End Module
