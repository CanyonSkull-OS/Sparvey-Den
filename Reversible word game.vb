Module Module1

    Sub Main()
        Dim str1, str2, str3 As String
        Dim char1 As Char
        Dim i, points As Integer


        str1 = ""
        str2 = ""
        str3 = ""
        char1 = ""
        i = 0
        points = 0

        Console.WriteLine("Can you come up with a word that can be mirrored exactly the same? ")
        str1 = Console.ReadLine

        For i = Len(str1) To 1 Step -1
            char1 = Mid(str1, i, 1)
            str2 = str2 + char1

        Next

        Do
            While points >= 0

                If str2 = str1 Then
                    Console.WriteLine("Damn, " & str1 & " " & "actually IS reversible")
                    points = points + 1
                    Console.WriteLine("Points: " & points)
                ElseIf points = 0 Then
                    Console.WriteLine("BOOHOO, YOU LOST")
                    Console.WriteLine("Do you wish to try again? ")
                    str3 = Console.ReadLine
                    If str3 = "y" Then
                        Reset()
                        Console.WriteLine("You have been given another chance, type away!! ")

                    Else : End

                    End If

                Else : Console.WriteLine("Whoops, that's not quite right, try again")
                    points = points - 1
                    Console.WriteLine("Points: " & points)


                End If

                str1 = Console.ReadLine

            End While

        Loop




        Console.ReadKey()







    End Sub

End Module
