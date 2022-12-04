Module Module1

    Sub Main()
        'Find if the input string has all the alphabets; capital or small alike'
        Dim str1, str2 As String
        Dim char1 As Char
        Dim i As Integer
        Dim bool As Boolean

        bool = True
        str1 = ""
        str2 = ""
        char1 = ""
        i = 0

        Const alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

        Console.WriteLine("Enter String to be checked: ")
        str1 = Console.ReadLine
        str1 = UCase(str1)

        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1) '
            If InStr(alphabets, char1) = True Then
                bool = False

            End If

        Next


        Console.WriteLine(bool)
        Console.ReadKey()
    End Sub

End Module
