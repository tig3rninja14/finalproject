Public Class Form3
    Dim baseTeam As New team
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        americanEast()
        americanCentral()
        americanWest()
        nationalEast()
        nationalCentral()
        nationalWest()
    End Sub

    Sub americanEast()
        Dim first, second, third, fourth, fifth As team
        first = baseTeam
        second = baseTeam
        third = baseTeam
        fourth = baseTeam
        fifth = baseTeam
        Do Until fifth.wins <> 0 And fourth.wins <> 0 And third.wins <> 0 And second.wins <> 0 And first.wins <> 0
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Yankees"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Blue Jays"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Red Sox"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Rays"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Orioles"))
        Loop
        Form1.Display(ALEast, first, second, third, fourth, fifth)
    End Sub
    Sub americanCentral()
        Dim first, second, third, fourth, fifth As team
        first = baseTeam
        second = baseTeam
        third = baseTeam
        fourth = baseTeam
        fifth = baseTeam
        Do Until fifth.wins <> 0 And fourth.wins <> 0 And third.wins <> 0 And second.wins <> 0 And first.wins <> 0
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Royals"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("White Sox"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Twins"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Tigers"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Indians"))
        Loop
        Form1.Display(ALCentral, first, second, third, fourth, fifth)
    End Sub
    Sub americanWest()
        Dim first, second, third, fourth, fifth As team
        first = baseTeam
        second = baseTeam
        third = baseTeam
        fourth = baseTeam
        fifth = baseTeam
        Do Until fifth.wins <> 0 And fourth.wins <> 0 And third.wins <> 0 And second.wins <> 0 And first.wins <> 0
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Rangers"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Angels"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Astros"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Athletics"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Mariners"))
        Loop
        Form1.Display(ALWest, first, second, third, fourth, fifth)
    End Sub
    Sub nationalEast()
        Dim first, second, third, fourth, fifth As team
        first = baseTeam
        second = baseTeam
        third = baseTeam
        fourth = baseTeam
        fifth = baseTeam
        Do Until fifth.wins <> 0 And fourth.wins <> 0 And third.wins <> 0 And second.wins <> 0 And first.wins <> 0
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Braves"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Nationals"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Mets"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Marlins"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Mariners"))
        Loop
        Form1.Display(NLEast, first, second, third, fourth, fifth)
    End Sub
    Sub nationalCentral()
        Dim first, second, third, fourth, fifth As team
        first = baseTeam
        second = baseTeam
        third = baseTeam
        fourth = baseTeam
        fifth = baseTeam
        Do Until fifth.wins <> 0 And fourth.wins <> 0 And third.wins <> 0 And second.wins <> 0 And first.wins <> 0
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Cardinals"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Pirates"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Reds"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Cubs"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Brewers"))
        Loop
        Form1.Display(NLCentral, first, second, third, fourth, fifth)
    End Sub
    Sub nationalWest()
        Dim first, second, third, fourth, fifth As team
        first = baseTeam
        second = baseTeam
        third = baseTeam
        fourth = baseTeam
        fifth = baseTeam
        Do Until fifth.wins <> 0 And fourth.wins <> 0 And third.wins <> 0 And second.wins <> 0 And first.wins <> 0
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Padres"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Dodgers"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Giants"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Diamondbacks"))
            Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Rockies"))
        Loop
        Form1.Display(NLWest, first, second, third, fourth, fifth)
    End Sub
    Sub Check(ByRef first As team, ByRef second As team, ByRef third As team, ByRef fourth As team, ByRef fifth As team, team As team)
        If team.wins >= first.wins And team.wins > second.wins And team.wins > third.wins And team.wins > fourth.wins And team.wins > fifth.wins Then
            fifth = fourth
            fourth = third
            third = second
            second = first
            first = team
        ElseIf team.wins >= second.wins And team.wins > third.wins And team.wins > fourth.wins And team.wins > fifth.wins Then
            fifth = fourth
            fourth = third
            third = second
            second = team
        ElseIf team.wins > third.wins And team.wins > fourth.wins And team.wins > fifth.wins Then
            fifth = fourth
            fourth = third
            third = team
        ElseIf team.wins > fourth.wins And team.wins > fifth.wins Then
            fifth = fourth
            fourth = team
        ElseIf team.wins < fourth.wins Then
            fifth = team
        End If
    End Sub
End Class