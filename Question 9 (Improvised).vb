Module Module1

    Sub Main()
        'Given strings a and b, return a single string with a and b separated
        'by a space '<a> <b>', except swap the first 2 chars of each string.

        Dim a, b, str1, str2, a2, b2, a3, b3, c As String
        Dim char1 As Char
        Dim i As Integer

        a = ""
        b = ""
        char1 = ""
        i = 0
        a2 = ""
        b2 = ""
        str1 = ""
        str2 = ""
        a3 = ""
        b3 = ""
        c = ""



        Console.WriteLine("Enter String A: ")
        a = Console.ReadLine

        Console.WriteLine("Enter String B: ")
        b = Console.ReadLine

        str1 = Mid(a, 3, 100)
        a2 = a2 + str1
        str2 = Mid(b, 3, 100)
        b2 = b2 + str2

        a3 = Left(a, 2)
        b3 = Left(b, 2)

        Console.WriteLine(b3 & a2 & " " & a3 & b2)
        Console.ReadKey()

    End Sub

End Module