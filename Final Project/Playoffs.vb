Public Class Playoffs
    Public round As Integer '1 is Wild Card, 2 is Division Series, 3 is Championship Series, 4 is World Series, 5 is offseason
    Public series As Integer = 1 'determines which matchups are played
    Public nd1, nd2, nd3, nd4, nc1, nc2, w1, champs As team 'variables for the teams that made it to the playoffs
    Public ad1, ad2, ad3, ad4, ac1, ac2, w2 As team
    Public restart As Boolean = False 'used to determine whether or not to rerun the season again
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Advance one day
        PictureBox1.Image = nd1.logo 'Sets all the logos to the corresponding picture box everytime to update when a team moves on
        PictureBox2.Image = nd4.logo
        PictureBox3.Image = nd2.logo
        PictureBox4.Image = nd3.logo
        PictureBox5.Image = ad1.logo
        PictureBox6.Image = ad4.logo
        PictureBox7.Image = ad2.logo
        PictureBox8.Image = ad3.logo
        PictureBox9.Image = nc1.logo
        PictureBox10.Image = ac1.logo
        PictureBox11.Image = nc2.logo
        PictureBox12.Image = ac2.logo
        PictureBox13.Image = w1.logo
        PictureBox14.Image = w2.logo
        PictureBox15.Image = Form3.ALwildCard1.logo
        PictureBox16.Image = Form3.ALwildCard2.logo
        PictureBox17.Image = Form3.NLwildCard1.logo
        PictureBox18.Image = Form3.NLwildCard2.logo
        Champion.Image = champs.logo
        Do Until round = 2 'Wild Card Games
            If round = 1 And series = 1 Then
                postSeasonGame(Form3.ALwildCard1, Form3.ALwildCard2, wc1s1, wc1s2) 'Simulates a game
                If CInt(wc1s1.Text()) = 1 Then 'Determines who wins and advances themn
                    ad4 = Form3.ALwildCard1
                ElseIf CInt(wc1s2.Text()) = 1 Then
                    ad4 = Form3.ALwildCard2
                End If
            ElseIf round = 1 And series = 2 Then
                postSeasonGame(Form3.NLwildCard1, Form3.NLwildCard2, wc2s1, wc2s2)
                If CInt(wc2s1.Text()) = 1 Then
                    nd4 = Form3.NLwildCard1
                ElseIf CInt(wc2s2.Text()) = 1 Then
                    nd4 = Form3.NLwildCard2
                End If
            End If
        Loop
        Do Until round = 3 'Division series games
            If round = 2 And series = 1 Then
                postSeasonGame(nd1, nd4, nlds1, nlds2)
                If CInt(nlds1.Text()) = 3 Then
                    nc1 = nd1
                ElseIf CInt(nlds2.Text()) = 3 Then
                    nc1 = nd4
                End If
            ElseIf round = 2 And series = 2 Then
                postSeasonGame(nd2, nd3, nlds3, nlds4)
                If CInt(nlds3.Text()) = 3 Then
                    nc2 = nd2
                ElseIf CInt(nlds4.Text()) = 3 Then
                    nc2 = nd3
                End If
            ElseIf round = 2 And series = 3 Then
                postSeasonGame(ad1, ad4, alds1, alds2)
                If CInt(alds1.Text()) = 3 Then
                    ac1 = ad1
                ElseIf CInt(alds2.Text()) = 3 Then
                    ac1 = ad4
                End If
            ElseIf round = 2 And series = 4 Then
                postSeasonGame(ad2, ad3, alds3, alds4)
                If CInt(alds3.Text()) = 3 Then
                    ac2 = ad2
                ElseIf CInt(alds4.Text()) = 3 Then
                    ac2 = ad3
                End If
            End If
        Loop
        Do Until round = 4 'Championship series
            If round = 3 And series = 1 Then
                nlcs1.Visible = True
                nlcs2.Visible = True
                alcs1.Visible = True
                alcs2.Visible = True
                postSeasonGame(nc1, nc2, nlcs1, nlcs2)
                If CInt(nlcs1.Text()) = 4 Then
                    w1 = nc1
                ElseIf CInt(nlcs2.Text()) = 4 Then
                    w1 = nc2
                End If
            ElseIf round = 3 And series = 2 Then
                postSeasonGame(ac1, ac2, alcs1, alcs2)
                If CInt(alcs1.Text()) = 4 Then
                    w2 = ac1
                ElseIf CInt(alcs2.Text()) = 4 Then
                    w2 = ac2
                End If
            End If
        Loop
        Do Until champs.name <> Nothing
            If round = 4 Then 'World series
                ws1.Visible = True
                ws2.Visible = True
                postSeasonGame(w1, w1, ws1, ws2)
                If CInt(ws1.Text()) = 4 Then
                    champs = w1
                ElseIf CInt(ws2.Text()) = 4 Then
                    champs = w2
                End If
            End If
        Loop
        PictureBox1.Image = nd1.logo 'clears image
        PictureBox2.Image = nd4.logo
        PictureBox3.Image = nd2.logo
        PictureBox4.Image = nd3.logo
        PictureBox5.Image = ad1.logo
        PictureBox6.Image = ad4.logo
        PictureBox7.Image = ad2.logo
        PictureBox8.Image = ad3.logo
        PictureBox9.Image = nc1.logo
        PictureBox10.Image = ac1.logo
        PictureBox11.Image = nc2.logo
        PictureBox12.Image = ac2.logo
        PictureBox13.Image = w1.logo
        PictureBox14.Image = w2.logo
        PictureBox15.Image = Form3.ALwildCard1.logo
        PictureBox16.Image = Form3.ALwildCard2.logo
        PictureBox17.Image = Form3.NLwildCard1.logo
        PictureBox18.Image = Form3.NLwildCard2.logo
        Champion.Image = champs.logo
        Dim x As String 'End of Game messages
        If champs.name = mainMenu.userTeam.name Then
            x = InputBox("Your team, the " & mainMenu.userTeam.name & "have won the World Series! Would you like to return to the main menu?", "Restart?")
            x = x.ToLower()
        Else
            x = InputBox("The " & champs.name & " have won the World Series! Would you like to return to the main menu?", "Restart?")
            x = x.ToLower
        End If

        If x = "yes" Or x = "y" Then 'Restart game *DOES NOT WORK PROPERLY*
            Form3.NLwildCard1 = Form3.baseTeam
            Form3.NLwildCard2 = Form3.baseTeam
            Form3.ALwildCard1 = Form3.baseTeam
            Form3.ALwildCard2 = Form3.baseTeam
            ad1 = Form3.baseTeam
            ad2 = Form3.baseTeam
            ad3 = Form3.baseTeam
            ad4 = Form3.baseTeam
            nd1 = Form3.baseTeam
            nd2 = Form3.baseTeam
            nd3 = Form3.baseTeam
            nd4 = Form3.baseTeam
            ac1 = Form3.baseTeam
            ac2 = Form3.baseTeam
            nc1 = Form3.baseTeam
            nc2 = Form3.baseTeam
            w1 = Form3.baseTeam
            w2 = Form3.baseTeam
            champs = Form3.baseTeam
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
            PictureBox3.Image = Nothing
            PictureBox4.Image = Nothing
            PictureBox5.Image = Nothing
            PictureBox6.Image = Nothing
            PictureBox7.Image = Nothing
            PictureBox8.Image = Nothing
            PictureBox9.Image = Nothing
            PictureBox10.Image = Nothing
            PictureBox11.Image = Nothing
            PictureBox12.Image = Nothing
            PictureBox13.Image = Nothing
            PictureBox14.Image = Nothing
            PictureBox15.Image = Nothing
            PictureBox16.Image = Nothing
            PictureBox17.Image = Nothing
            PictureBox18.Image = Nothing
            Champion.Image = Nothing
            wc1s1.Text() = "0"
            wc1s2.Text() = "0"
            wc2s1.Text() = "0"
            wc2s2.Text() = "0"
            nlds1.Text() = "0"
            nlds2.Text() = "0"
            nlds3.Text() = "0"
            nlds4.Text() = "0"
            alds1.Text() = "0"
            alds2.Text() = "0"
            alds3.Text() = "0"
            alds4.Text() = "0"
            nlcs1.Text() = "0"
            nlcs2.Text() = "0"
            alcs1.Text() = "0"
            alcs2.Text() = "0"
            ws1.Text() = "0"
            ws2.Text() = "0"
            Me.Hide()
            mainMenu.Show()
            restart = True
        Else
            End
        End If

        PictureBox1.Image = nd1.logo 'resets logos
        PictureBox2.Image = nd4.logo
        PictureBox3.Image = nd2.logo
        PictureBox4.Image = nd3.logo
        PictureBox5.Image = ad1.logo
        PictureBox6.Image = ad4.logo
        PictureBox7.Image = ad2.logo
        PictureBox8.Image = ad3.logo
        PictureBox9.Image = nc1.logo
        PictureBox10.Image = ac1.logo
        PictureBox11.Image = nc2.logo
        PictureBox12.Image = ac2.logo
        PictureBox13.Image = w1.logo
        PictureBox14.Image = w2.logo
        PictureBox15.Image = Form3.ALwildCard1.logo
        PictureBox16.Image = Form3.ALwildCard2.logo
        PictureBox17.Image = Form3.NLwildCard1.logo
        PictureBox18.Image = Form3.NLwildCard2.logo
        Champion.Image = champs.logo
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = nd1.logo 'sets logos
        PictureBox2.Image = nd4.logo
        PictureBox3.Image = nd2.logo
        PictureBox4.Image = nd3.logo
        PictureBox5.Image = ad1.logo
        PictureBox6.Image = ad4.logo
        PictureBox7.Image = ad2.logo
        PictureBox8.Image = ad3.logo
        PictureBox9.Image = nc1.logo
        PictureBox10.Image = ac1.logo
        PictureBox11.Image = nc2.logo
        PictureBox12.Image = ac2.logo
        PictureBox13.Image = w1.logo
        PictureBox14.Image = w2.logo
        PictureBox15.Image = Form3.ALwildCard1.logo
        PictureBox16.Image = Form3.ALwildCard2.logo
        PictureBox17.Image = Form3.NLwildCard1.logo
        PictureBox18.Image = Form3.NLwildCard2.logo
        If round = 1 And series = 1 Then 'Round 1
            postSeasonGame(Form3.ALwildCard1, Form3.ALwildCard2, wc1s1, wc1s2)
            If CInt(wc1s1.Text()) = 1 Then
                ad4 = Form3.ALwildCard1
            ElseIf CInt(wc1s2.Text()) = 1 Then
                ad4 = Form3.ALwildCard2
            End If
        ElseIf round = 1 And series = 2 Then
            postSeasonGame(Form3.NLwildCard1, Form3.NLwildCard2, wc2s1, wc2s2)
            If CInt(wc2s1.Text()) = 1 Then
                nd4 = Form3.NLwildCard1
            ElseIf CInt(wc2s2.Text()) = 1 Then
                nd4 = Form3.NLwildCard2
            End If
        End If
        If round = 2 And series = 1 Then 'Round 2
            postSeasonGame(nd1, nd4, nlds1, nlds2)
            If CInt(nlds1.Text()) = 3 Then
                nc1 = nd1
            ElseIf CInt(nlds2.Text()) = 3 Then
                nc1 = nd4
            End If
        ElseIf round = 2 And series = 2 Then
            postSeasonGame(nd2, nd3, nlds3, nlds4)
            If CInt(nlds3.Text()) = 3 Then
                nc2 = nd2
            ElseIf CInt(nlds4.Text()) = 3 Then
                nc2 = nd3
            End If
        ElseIf round = 2 And series = 3 Then
            postSeasonGame(ad1, ad4, alds1, alds2)
            If CInt(alds1.Text()) = 3 Then
                ac1 = ad1
            ElseIf CInt(alds2.Text()) = 3 Then
                ac1 = ad4
            End If
        ElseIf round = 2 And series = 4 Then
            postSeasonGame(ad2, ad3, alds3, alds4)
            If CInt(alds3.Text()) = 3 Then
                ac2 = ad2
            ElseIf CInt(alds4.Text()) = 3 Then
                ac2 = ad3
            End If
        End If
        If round = 3 And series = 1 Then 'Round 3
            nlcs1.Visible = True
            nlcs2.Visible = True
            alcs1.Visible = True
            alcs2.Visible = True
            postSeasonGame(nc1, nc2, nlcs1, nlcs2)
            If CInt(nlcs1.Text()) = 4 Then
                w1 = nc1
            ElseIf CInt(nlcs2.Text()) = 4 Then
                w1 = nc2
            End If
        ElseIf round = 3 And series = 2 Then
            postSeasonGame(ac1, ac2, alcs1, alcs2)
            If CInt(alcs1.Text()) = 4 Then
                w2 = ac1
            ElseIf CInt(alcs2.Text()) = 4 Then
                w2 = ac2
            End If
        End If
        If round = 4 Then 'Round 4
            ws1.Visible = True
            ws2.Visible = True
            postSeasonGame(w1, w1, ws1, ws2)
            If CInt(ws1.Text()) = 4 Then
                champs = w1
            ElseIf CInt(ws2.Text()) = 4 Then
                champs = w2
            End If
        End If
        If round = 5 Then 'End game message
            Dim x As String = InputBox("The " & champs.name & " have won the World Series! Would you like to return to the main menu?", "Restart?")
            x = x.ToLower
            If x = "yes" Or x = "y" Then
                Form3.NLwildCard1 = Form3.baseTeam
                Form3.NLwildCard2 = Form3.baseTeam
                Form3.ALwildCard1 = Form3.baseTeam
                Form3.ALwildCard2 = Form3.baseTeam
                ad1 = Form3.baseTeam
                ad2 = Form3.baseTeam
                ad3 = Form3.baseTeam
                ad4 = Form3.baseTeam
                nd1 = Form3.baseTeam
                nd2 = Form3.baseTeam
                nd3 = Form3.baseTeam
                nd4 = Form3.baseTeam
                ac1 = Form3.baseTeam
                ac2 = Form3.baseTeam
                nc1 = Form3.baseTeam
                nc2 = Form3.baseTeam
                w1 = Form3.baseTeam
                w2 = Form3.baseTeam
                champs = Form3.baseTeam
                PictureBox1.Image = Nothing
                PictureBox2.Image = Nothing 'Clears everything
                PictureBox3.Image = Nothing
                PictureBox4.Image = Nothing
                PictureBox5.Image = Nothing
                PictureBox6.Image = Nothing
                PictureBox7.Image = Nothing
                PictureBox8.Image = Nothing
                PictureBox9.Image = Nothing
                PictureBox10.Image = Nothing
                PictureBox11.Image = Nothing
                PictureBox12.Image = Nothing
                PictureBox13.Image = Nothing
                PictureBox14.Image = Nothing
                PictureBox15.Image = Nothing
                PictureBox16.Image = Nothing
                PictureBox17.Image = Nothing
                PictureBox18.Image = Nothing
                Champion.Image = Nothing
                wc1s1.Text() = "0"
                wc1s2.Text() = "0"
                wc2s1.Text() = "0"
                wc2s2.Text() = "0"
                nlds1.Text() = "0"
                nlds2.Text() = "0"
                nlds3.Text() = "0"
                nlds4.Text() = "0"
                alds1.Text() = "0"
                alds2.Text() = "0"
                alds3.Text() = "0"
                alds4.Text() = "0"
                nlcs1.Text() = "0"
                nlcs2.Text() = "0"
                alcs1.Text() = "0"
                alcs2.Text() = "0"
                ws1.Text() = "0"
                ws2.Text() = "0"
                Me.Hide() 'loads menu
                mainMenu.Show()
                restart = True
            Else
                End
            End If
        End If
        PictureBox1.Image = nd1.logo 'resets logos
        PictureBox2.Image = nd4.logo
        PictureBox3.Image = nd2.logo
        PictureBox4.Image = nd3.logo
        PictureBox5.Image = ad1.logo
        PictureBox6.Image = ad4.logo
        PictureBox7.Image = ad2.logo
        PictureBox8.Image = ad3.logo
        PictureBox9.Image = nc1.logo
        PictureBox10.Image = ac1.logo
        PictureBox11.Image = nc2.logo
        PictureBox12.Image = ac2.logo
        PictureBox13.Image = w1.logo
        PictureBox14.Image = w2.logo
        PictureBox15.Image = Form3.ALwildCard1.logo
        PictureBox16.Image = Form3.ALwildCard2.logo
        PictureBox17.Image = Form3.NLwildCard1.logo
        PictureBox18.Image = Form3.NLwildCard2.logo
        Champion.Image = champs.logo
    End Sub

    Private Sub Playoffs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        round = 1
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage 'sets all logo image sizes
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox15.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox16.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox17.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox18.SizeMode = PictureBoxSizeMode.StretchImage
        Champion.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox15.Image = Form3.ALwildCard1.logo
        PictureBox16.Image = Form3.ALwildCard2.logo
        PictureBox17.Image = Form3.NLwildCard1.logo
        PictureBox18.Image = Form3.NLwildCard2.logo
        Me.BackgroundImageLayout = ImageLayout.Stretch
        wc1s1.Text() = "0" 'clears all of the labels and sets them to zero
        wc1s2.Text() = "0"
        wc2s1.Text() = "0"
        wc2s2.Text() = "0"
        nlds1.Text() = "0"
        nlds2.Text() = "0"
        nlds3.Text() = "0"
        nlds4.Text() = "0"
        alds1.Text() = "0"
        alds2.Text() = "0"
        alds3.Text() = "0"
        alds4.Text() = "0"
        nlcs1.Text() = "0"
        nlcs2.Text() = "0"
        alcs1.Text() = "0"
        alcs2.Text() = "0"
        ws1.Text() = "0"
        ws2.Text() = "0"
        ws1.Visible = False 'hides division and championship series labels
        ws2.Visible = False
        nlcs1.Visible = False
        nlcs2.Visible = False
        alcs1.Visible = False
        alcs2.Visible = False
        nd1 = Form3.baseTeam 'attempts to clear teams
        nd2 = Form3.baseTeam
        nd3 = Form3.baseTeam
        nd4 = Form3.baseTeam
        ad1 = Form3.baseTeam
        ad2 = Form3.baseTeam
        ad3 = Form3.baseTeam
        ad4 = Form3.baseTeam
        nc1 = Form3.baseTeam
        nc2 = Form3.baseTeam
        ac1 = Form3.baseTeam
        ac2 = Form3.baseTeam
        w1 = Form3.baseTeam
        w2 = Form3.baseTeam
        champs = Form3.baseTeam
        For Each teams In mainMenu.baseball.teams 'determines teams that won divisions
            If teams.position = 1 And teams.division = 1 Then
                If ad1.name = Nothing Then
                    ad1 = teams
                ElseIf ad1.name <> Nothing Then
                    If ad2.name = Nothing Then
                        ad2 = teams
                    ElseIf ad2.name <> Nothing Then
                        If ad3.name = Nothing Then
                            ad3 = teams
                        End If
                    End If
                End If
            ElseIf teams.position = 1 And teams.division = 2 Then
                If nd1.name = Nothing Then
                    nd1 = teams
                ElseIf nd1.name <> Nothing Then
                    If nd2.name = Nothing Then
                        nd2 = teams
                    ElseIf nd2.name <> Nothing Then
                        If nd3.name = Nothing Then
                            nd3 = teams
                        End If
                    End If
                End If
            End If
        Next
        PictureBox1.Image = nd1.logo 'sets logos
        PictureBox2.Image = nd4.logo
        PictureBox3.Image = nd2.logo
        PictureBox4.Image = nd3.logo
        PictureBox5.Image = ad1.logo
        PictureBox6.Image = ad4.logo
        PictureBox7.Image = ad2.logo
        PictureBox8.Image = ad3.logo
    End Sub
    Sub postSeasonGame(ByRef x As team, ByRef y As team, label1 As Label, label2 As Label) 'simulates a game in the postseason
        Dim tempscore1 As Integer
        Dim tempscore2 As Integer
        Dim dif As Integer = mainMenu.baseball.eloDif(x, y)
        Dim score1 As Integer
        Dim score2 As Integer
        Dim inning As Integer = 9
        Randomize()
        Try
            If y.elo > x.elo Then
                tempscore2 = CInt((Rnd() * 99) + (dif / 1000))
            Else tempscore2 = CInt((Rnd() * 99) - (dif / 1000))
            End If
            mainMenu.baseball.scoreRef(tempscore2, score2)
            Randomize()

            If x.elo > y.elo Then
                tempscore1 = CInt((Rnd() * 99) + (dif / 1000))
            Else tempscore1 = CInt((Rnd() * 99) - (dif / 1000))
            End If
            mainMenu.baseball.scoreRef(tempscore1, score1)
            If score1 > score2 Then
                score(x, label1)
            End If
            If score1 < score2 Then
                score(y, label2)
            End If
        Catch
        End Try
        Try
            Do Until score1 <> score2
                If score1 > score2 Then
                    score(x, label1)
                ElseIf score1 < score2 Then
                    score(y, label2)
                ElseIf score1 = score2 Then
                    tempscore1 = 0
                    tempscore2 = 0
                    Randomize()
                End If
                If y.elo > x.elo Then
                    tempscore2 = CInt((Rnd() * 99) + (dif / 1000))
                Else tempscore2 = CInt((Rnd() * 99) - (dif / 1000))
                End If
                mainMenu.baseball.scoreRef(tempscore2, score2)
                Randomize()
                If x.elo > y.elo Then
                    tempscore1 = CInt((Rnd() * 99) + (dif / 1000))
                Else tempscore1 = CInt((Rnd() * 99) - (dif / 1000))
                End If
                mainMenu.baseball.scoreRef(tempscore1, score1)
                If score1 > score2 Then
                    score(x, label1)
                ElseIf score1 < score2 Then
                    score(y, label2)
                End If
                inning += 1
            Loop
        Catch
        End Try

    End Sub
    Sub score(x As team, team1Label As Label) 'Determines what round and series is being played
        If CInt(team1Label.Text()) = 0 Then
            team1Label.Text() = "1"
            If round = 1 And series = 1 Then
                series += 1
            ElseIf round = 1 And series = 2 Then
                round += 1
                series = 1
            End If
        ElseIf CInt(team1Label.Text()) = 1 Then
            team1Label.Text() = "2"
        ElseIf CInt(team1Label.Text()) = 2 Then
            team1Label.Text() = "3"
            If round = 2 And series = 1 Then
                series += 1
            ElseIf round = 2 And series = 2 Then
                series += 1
            ElseIf round = 2 And series = 3 Then
                series += 1
            ElseIf round = 2 And series = 4 Then
                series = 1
                round += 1
            End If
        ElseIf CInt(team1Label.Text()) = 3 Then
            team1Label.Text() = "4"
            If round = 3 And series = 1 Then
                series += 1
            ElseIf round = 3 And series = 2 Then
                round += 1
                series = 1
            ElseIf round = 4 And series = 1 Then
                series += 1
            ElseIf round = 4 And series = 2 Then
                round += 1
                series = 1
            End If
        End If
    End Sub
End Class