Imports Final_Project

Public Class Form1
    Public day As Integer = 0
    Dim baseball As New baseball



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If day = 0 Then day += 1
        If day = 1 Then
            baseball.GameSim(baseball.Cardinals, baseball.Pirates)
        End If
        ListBox1.Items.Add(baseball.Cardinals.wins)
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
Public Class team
    Public wins As Integer
    Public losses As Integer
    Public elo As Integer = elobase
    Public Const elobase As Integer = 1000
End Class

Public Class baseball
    Public Cubs As New team
    Public Cardinals As New team
    Public Pirates As New team
    Public Red As New team
    Public Brewers As New team
    Public Phillies As New team
    Public Marlins As New team
    Public Mets As New team
    Public Nationals As New team
    Public Braves As New team
    Public Giants As New team
    Public Padres As New team
    Public Dodgers As New team
    Public Rockies As New team
    Public Diamondbacks As New team
    Public Yankees As New team
    Public RedSox As New team
    Public Rays As New team
    Public Orioles As New team
    Public BlueJays As New team
    Public WhiteSox As New team
    Public Indians As New team
    Public Royals As New team
    Public Twins As New team
    Public Tigers As New team
    Public Astros As New team
    Public Angels As New team
    Public Athletics As New team
    Public Mariners As New team
    Public Rangers As New team
    Public Sub GameSim(ByRef x As team, ByRef y As team)
        Dim score1 As Integer
        Dim score2 As Integer
        Dim inning As Integer = 9
        Randomize()
        score1 = CInt(Math.Floor((20 - 1) * Rnd()))
        Randomize()
        score2 = CInt(Math.Floor((20 - 1) * Rnd()))
        Do Until score1 <> score2
            If score1 > score2 Then
                x.wins += 1
                y.losses += 1
            End If
            If score1 < score2 Then
                y.wins += 1
                x.losses += 1
            End If
            If score1 = score2 Then
                Randomize()
                score1 += CInt(Math.Floor((1 - 0 + 1) * Rnd())) + 0
                Randomize()
                score2 += CInt(Math.Floor((1 - 0 + 1) * Rnd())) + 0
            End If
            inning += 1
        Loop
    End Sub
End Class
