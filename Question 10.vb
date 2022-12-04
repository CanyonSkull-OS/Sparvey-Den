Module Module1

    Sub Main()
        'Given a string, if its length is at least 3,
        'add() 'ing' to its end.
        'Unless it already ends in 'ing', in which case
        'add() 'ly' instead.
        'If the string length is less than 3, leave it unchanged.
        'Return the resulting string.

        Dim str1 As String

        Console.WriteLine("Enter String: ")
        str1 = Console.ReadLine

        If Len(str1) >= 3 Then
            If Right(str1, 3) = "ing" Then
                Console.WriteLine(vbCrLf & str1 & "ly")
            ElseIf Right(str1, 2) = "ly" Then
                End
            Else : Console.WriteLine(str1 & "ing")

            End If
        End If

        Console.ReadKey()
    End Sub

End Module
