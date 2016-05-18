Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        americanEast()
        nationalCentral()
    End Sub

    Sub americanEast()
        Dim first, second, third, fourth, fifth As team
        first = Form1.baseball.getTeam("Yankees")
        second = Form1.baseball.getTeam("Blue Jays")
        third = Form1.baseball.getTeam("Orioles")
        fourth = Form1.baseball.getTeam("Rays")
        fifth = Form1.baseball.getTeam("Red Sox")
        Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Yankees"))
        Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Blue Jays"))
        Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Red Sox"))
        Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Rays"))
        Check(first, second, third, fourth, fifth, Form1.baseball.getTeam("Orioles"))
        Form1.Display(ALEast, first, second, third, fourth, fifth)
    End Sub
    Sub americanCentral()
        Dim first, second, third, fourth, fifth As team
    End Sub
    Sub americanWest()
        Dim first, second, third, fourth, fifth As team
    End Sub
    Sub nationalEast()
        Dim first, second, third, fourth, fifth As team
    End Sub
    Sub nationalCentral()
        Dim first, second, third, fourth, fifth As team
        first = Form1.baseball.getTeam("Cardinals")
    End Sub
    Sub nationalWest()
        Dim first, second, third, fourth, fifth As team
    End Sub
    Sub Check(ByRef first As team, ByRef second As team, ByRef third As team, ByRef fourth As team, ByRef fifth As team, team As team)
        If team.wins > first.wins Then
            first = team
        ElseIf team.wins > second.wins Then
            second = team
        ElseIf team.wins > third.wins Then
            third = team
        ElseIf team.wins > fourth.wins Then
            fourth = team
        ElseIf team.wins > fifth.wins Then
            fifth = team
        End If
    End Sub

End Class