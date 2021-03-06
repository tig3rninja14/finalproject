﻿Public Class Form3
    Public baseTeam As New team
    Dim pos As Integer
    Public NLwildCard1, NLwildCard2, ALwildCard1, ALwildCard2 As New team
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        americanEast()
        americanCentral()
        americanWest()
        nationalEast()
        nationalCentral()
        nationalWest()
        wildCard(ALwildCard1, ALwildCard2, NLwildCard1, NLwildCard2, mainMenu.baseball)
        posCheck(mainMenu.userTeam, NLwildCard1, NLwildCard2, ALwildCard1, ALwildCard2)
    End Sub

    Sub posCheck(user As team, nl1 As team, nl2 As team, al1 As team, al2 As team) 'Determines if you have advanced to the postseason
        If user.position = 1 Then
            MsgBox("The " & mainMenu.userTeam.name & " have reached the playoffs! Congratulations!")
        ElseIf nl1.name = user.name Or nl2.name = user.name Or al1.name = user.name Or al2.name = user.name Then
            MsgBox("The " & mainMenu.userTeam.name & " are going to participate in the Wild Card Game!")
        Else
            MsgBox("Sorry, the " & mainMenu.userTeam.name & " have not made the playoffs. Better luck next year!")
        End If
    End Sub
    Sub americanEast() 'determines division winner
        Dim first, second, third, fourth, fifth As team
        first = baseTeam
        second = baseTeam
        third = baseTeam
        fourth = baseTeam
        fifth = baseTeam
        Do Until fifth.wins <> 0 And fourth.wins <> 0 And third.wins <> 0 And second.wins <> 0 And first.wins <> 0
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Yankees"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Blue Jays"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Red Sox"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Rays"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Orioles"))
        Loop
        tieCheck(first, second, third, fourth, fifth)
        Display(ALEast, first, second, third, fourth, fifth)
    End Sub
    Sub americanCentral() 'division winner
        Dim first, second, third, fourth, fifth As team
        first = baseTeam
        second = baseTeam
        third = baseTeam
        fourth = baseTeam
        fifth = baseTeam
        Do Until fifth.wins <> 0 And fourth.wins <> 0 And third.wins <> 0 And second.wins <> 0 And first.wins <> 0
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Royals"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("White Sox"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Twins"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Tigers"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Indians"))
        Loop
        tieCheck(first, second, third, fourth, fifth)
        Display(ALCentral, first, second, third, fourth, fifth)
    End Sub
    Sub americanWest() 'division winner
        Dim first, second, third, fourth, fifth As team
        first = baseTeam
        second = baseTeam
        third = baseTeam
        fourth = baseTeam
        fifth = baseTeam
        Do Until fifth.wins <> 0 And fourth.wins <> 0 And third.wins <> 0 And second.wins <> 0 And first.wins <> 0
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Rangers"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Angels"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Astros"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Athletics"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Mariners"))
        Loop
        tieCheck(first, second, third, fourth, fifth)
        Display(ALWest, first, second, third, fourth, fifth)
    End Sub
    Sub nationalEast() 'division winner
        Dim first, second, third, fourth, fifth As team
        first = baseTeam
        second = baseTeam
        third = baseTeam
        fourth = baseTeam
        fifth = baseTeam
        Do Until fifth.wins <> 0 And fourth.wins <> 0 And third.wins <> 0 And second.wins <> 0 And first.wins <> 0
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Braves"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Nationals"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Mets"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Marlins"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Phillies"))
        Loop
        tieCheck(first, second, third, fourth, fifth)
        Display(NLEast, first, second, third, fourth, fifth)
    End Sub
    Sub nationalCentral() 'division winner
        Dim first, second, third, fourth, fifth As team
        first = baseTeam
        second = baseTeam
        third = baseTeam
        fourth = baseTeam
        fifth = baseTeam
        Do Until fifth.wins <> 0 And fourth.wins <> 0 And third.wins <> 0 And second.wins <> 0 And first.wins <> 0
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Cardinals"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Pirates"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Reds"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Cubs"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Brewers"))
        Loop
        tieCheck(first, second, third, fourth, fifth)
        Display(NLCentral, first, second, third, fourth, fifth)
    End Sub
    Sub nationalWest() 'division winner
        Dim first, second, third, fourth, fifth As team
        first = baseTeam
        second = baseTeam
        third = baseTeam
        fourth = baseTeam
        fifth = baseTeam
        Do Until fifth.wins <> 0 And fourth.wins <> 0 And third.wins <> 0 And second.wins <> 0 And first.wins <> 0
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Padres"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Dodgers"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Giants"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Diamondbacks"))
            Check(first, second, third, fourth, fifth, mainMenu.baseball.getTeam("Rockies"))
        Loop
        tieCheck(first, second, third, fourth, fifth)
        Display(NLWest, first, second, third, fourth, fifth)
    End Sub
    Sub Check(ByRef first As team, ByRef second As team, ByRef third As team, ByRef fourth As team, ByRef fifth As team, team As team) 'Determines position in the division
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
    Sub tieCheck(first As team, second As team, third As team, fourth As team, fifth As team) 'Checks for ties and simulates extra games to compensate
        If first.wins = second.wins Then
            mainMenu.baseball.GameSim(first, second)
        ElseIf second.wins = third.wins Then
            mainMenu.baseball.GameSim(second, third)
        End If
    End Sub
    Public Sub wildCard(ByRef al1 As team, ByRef al2 As team, ByRef nl1 As team, ByRef nl2 As team, ByRef baseball As baseball) 'Determines winner of wildcards
        Dim al As New Division
        Dim nl As New Division
        baseball.getTeam("Angels").division = 1
        baseball.getTeam("Astros").division = 1
        baseball.getTeam("Athletics").division = 1
        baseball.getTeam("Blue Jays").division = 1
        baseball.getTeam("Braves").division = 2
        baseball.getTeam("Brewers").division = 2
        baseball.getTeam("Cardinals").division = 2
        baseball.getTeam("Cubs").division = 2
        baseball.getTeam("Diamondbacks").division = 2
        baseball.getTeam("Dodgers").division = 2
        baseball.getTeam("Giants").division = 2
        baseball.getTeam("Indians").division = 1
        baseball.getTeam("Mariners").division = 1
        baseball.getTeam("Marlins").division = 2
        baseball.getTeam("Mets").division = 2
        baseball.getTeam("Nationals").division = 2
        baseball.getTeam("Orioles").division = 1
        baseball.getTeam("Padres").division = 2
        baseball.getTeam("Phillies").division = 2
        baseball.getTeam("Pirates").division = 2
        baseball.getTeam("Rangers").division = 1
        baseball.getTeam("Rays").division = 1
        baseball.getTeam("Red Sox").division = 1
        baseball.getTeam("Reds").division = 2
        baseball.getTeam("Rockies").division = 2
        baseball.getTeam("Royals").division = 1
        baseball.getTeam("Tigers").division = 1
        baseball.getTeam("Twins").division = 1
        baseball.getTeam("White Sox").division = 1
        baseball.getTeam("Yankees").division = 1

        nl.first = baseTeam
        nl.second = baseTeam
        nl.third = baseTeam
        nl.fourth = baseTeam
        nl.fifth = baseTeam
        nl.sixth = baseTeam
        nl.seventh = baseTeam
        nl.eigth = baseTeam
        nl.ninth = baseTeam
        nl.tenth = baseTeam
        nl.eleventh = baseTeam
        nl.twelvth = baseTeam
        nl.thirteenth = baseTeam
        nl.fourteenth = baseTeam
        nl.fifteenth = baseTeam

        al.first = baseTeam
        al.second = baseTeam
        al.third = baseTeam
        al.fourth = baseTeam
        al.fifth = baseTeam
        al.sixth = baseTeam
        al.seventh = baseTeam
        al.eigth = baseTeam
        al.ninth = baseTeam
        al.tenth = baseTeam
        al.eleventh = baseTeam
        al.twelvth = baseTeam
        al.thirteenth = baseTeam
        al.fourteenth = baseTeam
        al.fifteenth = baseTeam
        Do Until nl.first.name <> nl.second.name And nl.second.name <> nl.third.name And nl.fourth.name <> nl.fifth.name And al.first.name <> al.second.name And al.second.name <> al.third.name And al.third.name <> al.fourth.name And al.fourth.name <> al.fifth.name
            For Each teams In baseball.teams

                Select Case teams.division
                    Case = 1  'American league
                        If teams.wins >= al.first.wins And teams.wins > al.second.wins And teams.wins > al.third.wins And teams.wins > al.fourth.wins And teams.wins > al.fifth.wins And teams.wins > al.sixth.wins And teams.wins > al.seventh.wins And teams.wins > al.eigth.wins And teams.wins > al.ninth.wins And teams.wins > al.tenth.wins And teams.wins > al.eleventh.wins And teams.wins > al.twelvth.wins And teams.wins > al.thirteenth.wins And teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = al.thirteenth
                            al.thirteenth = al.twelvth
                            al.twelvth = al.eleventh
                            al.eleventh = al.tenth
                            al.tenth = al.ninth
                            al.ninth = al.eigth
                            al.eigth = al.seventh
                            al.seventh = al.sixth
                            al.sixth = al.fifth
                            al.fifth = al.fourth
                            al.fourth = al.third
                            al.third = al.second
                            al.second = al.first
                            al.first = teams
                        ElseIf teams.wins > al.second.wins And teams.wins > al.third.wins And teams.wins > al.fourth.wins And teams.wins > al.fifth.wins And teams.wins > al.sixth.wins And teams.wins > al.seventh.wins And teams.wins > al.eigth.wins And teams.wins > al.ninth.wins And teams.wins > al.tenth.wins And teams.wins > al.eleventh.wins And teams.wins > al.twelvth.wins And teams.wins > al.thirteenth.wins And teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = al.thirteenth
                            al.thirteenth = al.twelvth
                            al.twelvth = al.eleventh
                            al.eleventh = al.tenth
                            al.tenth = al.ninth
                            al.ninth = al.eigth
                            al.eigth = al.seventh
                            al.seventh = al.sixth
                            al.sixth = al.fifth
                            al.fifth = al.fourth
                            al.fourth = al.third
                            al.third = al.second
                            al.second = teams
                        ElseIf teams.wins > al.third.wins And teams.wins > al.fourth.wins And teams.wins > al.fifth.wins And teams.wins > al.sixth.wins And teams.wins > al.seventh.wins And teams.wins > al.eigth.wins And teams.wins > al.ninth.wins And teams.wins > al.tenth.wins And teams.wins > al.eleventh.wins And teams.wins > al.twelvth.wins And teams.wins > al.thirteenth.wins And teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = al.thirteenth
                            al.thirteenth = al.twelvth
                            al.twelvth = al.eleventh
                            al.eleventh = al.tenth
                            al.tenth = al.ninth
                            al.ninth = al.eigth
                            al.eigth = al.seventh
                            al.seventh = al.sixth
                            al.sixth = al.fifth
                            al.fifth = al.fourth
                            al.fourth = al.third
                            al.third = teams
                        ElseIf teams.wins > al.fourth.wins And teams.wins > al.fifth.wins And teams.wins > al.sixth.wins And teams.wins > al.seventh.wins And teams.wins > al.eigth.wins And teams.wins > al.ninth.wins And teams.wins > al.tenth.wins And teams.wins > al.eleventh.wins And teams.wins > al.twelvth.wins And teams.wins > al.thirteenth.wins And teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = al.thirteenth
                            al.thirteenth = al.twelvth
                            al.twelvth = al.eleventh
                            al.eleventh = al.tenth
                            al.tenth = al.ninth
                            al.ninth = al.eigth
                            al.eigth = al.seventh
                            al.seventh = al.sixth
                            al.sixth = al.fifth
                            al.fifth = al.fourth
                            al.fourth = teams
                        ElseIf teams.wins > al.fifth.wins And teams.wins > al.sixth.wins And teams.wins > al.seventh.wins And teams.wins > al.eigth.wins And teams.wins > al.ninth.wins And teams.wins > al.tenth.wins And teams.wins > al.eleventh.wins And teams.wins > al.twelvth.wins And teams.wins > al.thirteenth.wins And teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = al.thirteenth
                            al.thirteenth = al.twelvth
                            al.twelvth = al.eleventh
                            al.eleventh = al.tenth
                            al.tenth = al.ninth
                            al.ninth = al.eigth
                            al.eigth = al.seventh
                            al.seventh = al.sixth
                            al.sixth = al.fifth
                            al.fifth = teams
                        ElseIf teams.wins > al.sixth.wins And teams.wins > al.seventh.wins And teams.wins > al.eigth.wins And teams.wins > al.ninth.wins And teams.wins > al.tenth.wins And teams.wins > al.eleventh.wins And teams.wins > al.twelvth.wins And teams.wins > al.thirteenth.wins And teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = al.thirteenth
                            al.thirteenth = al.twelvth
                            al.twelvth = al.eleventh
                            al.eleventh = al.tenth
                            al.tenth = al.ninth
                            al.ninth = al.eigth
                            al.eigth = al.seventh
                            al.seventh = al.sixth
                            al.sixth = teams
                        ElseIf teams.wins > al.seventh.wins And teams.wins > al.eigth.wins And teams.wins > al.ninth.wins And teams.wins > al.tenth.wins And teams.wins > al.eleventh.wins And teams.wins > al.twelvth.wins And teams.wins > al.thirteenth.wins And teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = al.thirteenth
                            al.thirteenth = al.twelvth
                            al.twelvth = al.eleventh
                            al.eleventh = al.tenth
                            al.tenth = al.ninth
                            al.ninth = al.eigth
                            al.eigth = al.seventh
                            al.seventh = teams
                        ElseIf teams.wins > al.eigth.wins And teams.wins > al.ninth.wins And teams.wins > al.tenth.wins And teams.wins > al.eleventh.wins And teams.wins > al.twelvth.wins And teams.wins > al.thirteenth.wins And teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = al.thirteenth
                            al.thirteenth = al.twelvth
                            al.twelvth = al.eleventh
                            al.eleventh = al.tenth
                            al.tenth = al.ninth
                            al.ninth = al.eigth
                            al.eigth = teams
                        ElseIf teams.wins > al.ninth.wins And teams.wins > al.tenth.wins And teams.wins > al.eleventh.wins And teams.wins > al.twelvth.wins And teams.wins > al.thirteenth.wins And teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = al.thirteenth
                            al.thirteenth = al.twelvth
                            al.twelvth = al.eleventh
                            al.eleventh = al.tenth
                            al.tenth = al.ninth
                            al.ninth = teams
                        ElseIf teams.wins > al.tenth.wins And teams.wins > al.eleventh.wins And teams.wins > al.twelvth.wins And teams.wins > al.thirteenth.wins And teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = al.thirteenth
                            al.thirteenth = al.twelvth
                            al.twelvth = al.eleventh
                            al.eleventh = al.tenth
                            al.tenth = teams
                        ElseIf teams.wins > al.eleventh.wins And teams.wins > al.twelvth.wins And teams.wins > al.thirteenth.wins And teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = al.thirteenth
                            al.thirteenth = al.twelvth
                            al.twelvth = al.eleventh
                            al.eleventh = teams
                        ElseIf teams.wins > al.twelvth.wins And teams.wins > al.thirteenth.wins And teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = al.thirteenth
                            al.thirteenth = al.twelvth
                            al.twelvth = teams
                        ElseIf teams.wins > al.thirteenth.wins And teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = al.thirteenth
                            al.thirteenth = teams
                        ElseIf teams.wins > al.fourteenth.wins And teams.wins > al.fifteenth.wins Then
                            al.fifteenth = al.fourteenth
                            al.fourteenth = teams
                        ElseIf teams.wins < al.fifteenth.wins Then
                            al.fourteenth = al.fifteenth
                            al.fifteenth = teams
                        End If
                        If al.second.position <> 1 Then
                            al1 = al.second
                        End If
                        If al.third.position <> 1 Then
                            al1 = al.third
                        End If
                        If al.fourth.position <> 1 Then
                            al1 = al.fourth
                        End If
                        If al.fifth.position <> 1 Then
                            al2 = al.fifth
                        End If
                    Case = 2
                        'National League
                        If teams.wins >= nl.first.wins And teams.wins > nl.second.wins And teams.wins > nl.third.wins And teams.wins > nl.fourth.wins And teams.wins > nl.fifth.wins And teams.wins > nl.sixth.wins And teams.wins > nl.seventh.wins And teams.wins > nl.eigth.wins And teams.wins > nl.ninth.wins And teams.wins > nl.tenth.wins And teams.wins > nl.eleventh.wins And teams.wins > nl.twelvth.wins And teams.wins > nl.thirteenth.wins And teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = nl.thirteenth
                            nl.thirteenth = nl.twelvth
                            nl.twelvth = nl.eleventh
                            nl.eleventh = nl.tenth
                            nl.tenth = nl.ninth
                            nl.ninth = nl.eigth
                            nl.eigth = nl.seventh
                            nl.seventh = nl.sixth
                            nl.sixth = nl.fifth
                            nl.fifth = nl.fourth
                            nl.fourth = nl.third
                            nl.third = nl.second
                            nl.second = nl.first
                            nl.first = teams
                        ElseIf teams.wins > nl.second.wins And teams.wins > nl.third.wins And teams.wins > nl.fourth.wins And teams.wins > nl.fifth.wins And teams.wins > nl.sixth.wins And teams.wins > nl.seventh.wins And teams.wins > nl.eigth.wins And teams.wins > nl.ninth.wins And teams.wins > nl.tenth.wins And teams.wins > nl.eleventh.wins And teams.wins > nl.twelvth.wins And teams.wins > nl.thirteenth.wins And teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = nl.thirteenth
                            nl.thirteenth = nl.twelvth
                            nl.twelvth = nl.eleventh
                            nl.eleventh = nl.tenth
                            nl.tenth = nl.ninth
                            nl.ninth = nl.eigth
                            nl.eigth = nl.seventh
                            nl.seventh = nl.sixth
                            nl.sixth = nl.fifth
                            nl.fifth = nl.fourth
                            nl.fourth = nl.third
                            nl.third = nl.second
                            nl.second = teams
                        ElseIf teams.wins > nl.third.wins And teams.wins > nl.fourth.wins And teams.wins > nl.fifth.wins And teams.wins > nl.sixth.wins And teams.wins > nl.seventh.wins And teams.wins > nl.eigth.wins And teams.wins > nl.ninth.wins And teams.wins > nl.tenth.wins And teams.wins > nl.eleventh.wins And teams.wins > nl.twelvth.wins And teams.wins > nl.thirteenth.wins And teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = nl.thirteenth
                            nl.thirteenth = nl.twelvth
                            nl.twelvth = nl.eleventh
                            nl.eleventh = nl.tenth
                            nl.tenth = nl.ninth
                            nl.ninth = nl.eigth
                            nl.eigth = nl.seventh
                            nl.seventh = nl.sixth
                            nl.sixth = nl.fifth
                            nl.fifth = nl.fourth
                            nl.fourth = nl.third
                            nl.third = teams
                        ElseIf teams.wins > nl.fourth.wins And teams.wins > nl.fifth.wins And teams.wins > nl.sixth.wins And teams.wins > nl.seventh.wins And teams.wins > nl.eigth.wins And teams.wins > nl.ninth.wins And teams.wins > nl.tenth.wins And teams.wins > nl.eleventh.wins And teams.wins > nl.twelvth.wins And teams.wins > nl.thirteenth.wins And teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = nl.thirteenth
                            nl.thirteenth = nl.twelvth
                            nl.twelvth = nl.eleventh
                            nl.eleventh = nl.tenth
                            nl.tenth = nl.ninth
                            nl.ninth = nl.eigth
                            nl.eigth = nl.seventh
                            nl.seventh = nl.sixth
                            nl.sixth = nl.fifth
                            nl.fifth = nl.fourth
                            nl.fourth = teams
                        ElseIf teams.wins > nl.fifth.wins And teams.wins > nl.sixth.wins And teams.wins > nl.seventh.wins And teams.wins > nl.eigth.wins And teams.wins > nl.ninth.wins And teams.wins > nl.tenth.wins And teams.wins > nl.eleventh.wins And teams.wins > nl.twelvth.wins And teams.wins > nl.thirteenth.wins And teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = nl.thirteenth
                            nl.thirteenth = nl.twelvth
                            nl.twelvth = nl.eleventh
                            nl.eleventh = nl.tenth
                            nl.tenth = nl.ninth
                            nl.ninth = nl.eigth
                            nl.eigth = nl.seventh
                            nl.seventh = nl.sixth
                            nl.sixth = nl.fifth
                            nl.fifth = teams
                        ElseIf teams.wins > nl.sixth.wins And teams.wins > nl.seventh.wins And teams.wins > nl.eigth.wins And teams.wins > nl.ninth.wins And teams.wins > nl.tenth.wins And teams.wins > nl.eleventh.wins And teams.wins > nl.twelvth.wins And teams.wins > nl.thirteenth.wins And teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = nl.thirteenth
                            nl.thirteenth = nl.twelvth
                            nl.twelvth = nl.eleventh
                            nl.eleventh = nl.tenth
                            nl.tenth = nl.ninth
                            nl.ninth = nl.eigth
                            nl.eigth = nl.seventh
                            nl.seventh = nl.sixth
                            nl.sixth = teams
                        ElseIf teams.wins > nl.seventh.wins And teams.wins > nl.eigth.wins And teams.wins > nl.ninth.wins And teams.wins > nl.tenth.wins And teams.wins > nl.eleventh.wins And teams.wins > nl.twelvth.wins And teams.wins > nl.thirteenth.wins And teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = nl.thirteenth
                            nl.thirteenth = nl.twelvth
                            nl.twelvth = nl.eleventh
                            nl.eleventh = nl.tenth
                            nl.tenth = nl.ninth
                            nl.ninth = nl.eigth
                            nl.eigth = nl.seventh
                            nl.seventh = teams
                        ElseIf teams.wins > nl.eigth.wins And teams.wins > nl.ninth.wins And teams.wins > nl.tenth.wins And teams.wins > nl.eleventh.wins And teams.wins > nl.twelvth.wins And teams.wins > nl.thirteenth.wins And teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = nl.thirteenth
                            nl.thirteenth = nl.twelvth
                            nl.twelvth = nl.eleventh
                            nl.eleventh = nl.tenth
                            nl.tenth = nl.ninth
                            nl.ninth = nl.eigth
                            nl.eigth = teams
                        ElseIf teams.wins > nl.ninth.wins And teams.wins > nl.tenth.wins And teams.wins > nl.eleventh.wins And teams.wins > nl.twelvth.wins And teams.wins > nl.thirteenth.wins And teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = nl.thirteenth
                            nl.thirteenth = nl.twelvth
                            nl.twelvth = nl.eleventh
                            nl.eleventh = nl.tenth
                            nl.tenth = nl.ninth
                            nl.ninth = teams
                        ElseIf teams.wins > nl.tenth.wins And teams.wins > nl.eleventh.wins And teams.wins > nl.twelvth.wins And teams.wins > nl.thirteenth.wins And teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = nl.thirteenth
                            nl.thirteenth = nl.twelvth
                            nl.twelvth = nl.eleventh
                            nl.eleventh = nl.tenth
                            nl.tenth = teams
                        ElseIf teams.wins > nl.eleventh.wins And teams.wins > nl.twelvth.wins And teams.wins > nl.thirteenth.wins And teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = nl.thirteenth
                            nl.thirteenth = nl.twelvth
                            nl.twelvth = nl.eleventh
                            nl.eleventh = teams
                        ElseIf teams.wins > nl.twelvth.wins And teams.wins > nl.thirteenth.wins And teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = nl.thirteenth
                            nl.thirteenth = nl.twelvth
                            nl.twelvth = teams
                        ElseIf teams.wins > nl.thirteenth.wins And teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = nl.thirteenth
                            nl.thirteenth = teams
                        ElseIf teams.wins > nl.fourteenth.wins And teams.wins > nl.fifteenth.wins Then
                            nl.fifteenth = nl.fourteenth
                            nl.fourteenth = teams
                        ElseIf teams.wins < nl.fourteenth.wins Then
                            nl.fifteenth = teams
                        End If
                        If nl.second.position <> 1 Then
                            nl1 = nl.second
                        End If
                        If nl.third.position <> 1 Then
                            nl1 = nl.third
                        End If
                        If nl.fourth.position <> 1 Then
                            nl1 = nl.fourth
                        End If
                        If nl.fifth.position <> 1 Then
                            nl2 = nl.fifth
                        End If
                End Select
            Next
        Loop



    End Sub
    Public Sub Display(data As DataGridView, ByRef first As team, ByRef second As team, ByRef third As team, ByRef fourth As team, ByRef fifth As team) 'Displays the scores in datagridview
        data.Rows.Insert(0, New String() {first.name, CStr(first.wins), CStr(first.losses)})
        data.Rows.Insert(1, New String() {second.name, CStr(second.wins), CStr(second.losses)})
        data.Rows.Insert(2, New String() {third.name, CStr(third.wins), CStr(third.losses)})
        data.Rows.Insert(3, New String() {fourth.name, CStr(fourth.wins), CStr(fourth.losses)})
        data.Rows.Insert(4, New String() {fifth.name, CStr(fifth.wins), CStr(fifth.losses)})
        first.position = 1
        second.position = 2
        third.position = 3
        fourth.position = 4
        fifth.position = 5
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide() ' go to playoffs
        Playoffs.Show()
    End Sub
    Public Sub LogoGen(baseball As baseball) 'Sets all team logos
        baseball.getTeam("Angels").logo = Final_Project.My.Resources.angels
        baseball.getTeam("Astros").logo = Final_Project.My.Resources.astros
        baseball.getTeam("Athletics").logo = Final_Project.My.Resources.athletics
        baseball.getTeam("Blue Jays").logo = Final_Project.My.Resources.bluejays
        baseball.getTeam("Braves").logo = Final_Project.My.Resources.braves
        baseball.getTeam("Brewers").logo = Final_Project.My.Resources.brewers
        baseball.getTeam("Cardinals").logo = Final_Project.My.Resources.cardinals
        baseball.getTeam("Cubs").logo = Final_Project.My.Resources.cubs
        baseball.getTeam("Diamondbacks").logo = Final_Project.My.Resources.diamondbacks
        baseball.getTeam("Dodgers").logo = Final_Project.My.Resources.dodgers
        baseball.getTeam("Giants").logo = Final_Project.My.Resources.giantspng
        baseball.getTeam("Indians").logo = Final_Project.My.Resources.indians
        baseball.getTeam("Mariners").logo = Final_Project.My.Resources.mariners
        baseball.getTeam("Marlins").logo = Final_Project.My.Resources.marlins
        baseball.getTeam("Mets").logo = Final_Project.My.Resources.mets
        baseball.getTeam("Nationals").logo = Final_Project.My.Resources.nationals
        baseball.getTeam("Orioles").logo = Final_Project.My.Resources.orioles
        baseball.getTeam("Padres").logo = Final_Project.My.Resources.padres
        baseball.getTeam("Phillies").logo = Final_Project.My.Resources.phillies
        baseball.getTeam("Pirates").logo = Final_Project.My.Resources.pirates
        baseball.getTeam("Rangers").logo = Final_Project.My.Resources.rangers
        baseball.getTeam("Rays").logo = Final_Project.My.Resources.rays
        baseball.getTeam("Reds").logo = Final_Project.My.Resources.reds
        baseball.getTeam("Red Sox").logo = Final_Project.My.Resources.redsox
        baseball.getTeam("Rockies").logo = Final_Project.My.Resources.rockies
        baseball.getTeam("Royals").logo = Final_Project.My.Resources.royals
        baseball.getTeam("Tigers").logo = Final_Project.My.Resources.tigers
        baseball.getTeam("Twins").logo = Final_Project.My.Resources.twins
        baseball.getTeam("White Sox").logo = Final_Project.My.Resources.whitesox
        baseball.getTeam("Yankees").logo = Final_Project.My.Resources.yankees
    End Sub
End Class
Public Class Division
    Public first, second, third, fourth, fifth, sixth, seventh, eigth, ninth, tenth, eleventh, twelvth, thirteenth, fourteenth, fifteenth As team
End Class