Imports Final_Project
Imports System.Math
Public Class Form1
    Public day As Integer = 0
    Dim baseball As New baseball



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        baseball.teamCreate()
        If day = 0 Then endOfDay(day)
        If day = 1 Then 'April 3
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Royals"))
            endOfDay(day)
            'Day 2 April 4
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Randers"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Padres"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Athletics"))
            endOfDay(day)
            'Day 3 April 5
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Royals"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Padres"))
            endOfDay(day)
            'Day 4 April 6
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Padres"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Athletics"))
            endOfDay(day)
            'Day 5 April 7
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Giants"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Angels"))
            endOfDay(day)
            'Day 6 April 8 
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Royals"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Mariners"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Giants"))
            endOfDay(day)
            'Day 7 April 9
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Giants"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Royals"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Mariners"))
            endOfDay(day)
            'Day 8 April 10
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Royals"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Giants"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Mariners"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Tigers"))
            endOfDay(day)
            'Day 9 April 11
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Phillies"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("Reds"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Mariners"))
            endOfDay(day)
            'Day 10 April 12
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Dodgers"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Phillies"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Mariners"))
            endOfDay(day)
            'Day 11 April 13
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Mariners"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Phillies"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Reds"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Dodgers"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Angels"))
            endOfDay(day)
            'Day 12 April 14
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Phillies"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Reds"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Dodgers"))
            endOfDay(day)
            'Day 13 April 15
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Phillies"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Dodgers"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Reds"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Dodgers"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Padres"))
            endOfDay(day)
            'Day 14 April 16
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Reds"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Phillies"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Padres"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Dodgers"))
            endOfDay(day)
            'Day 15 April 17
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Phillies"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Reds"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Padres"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Dodgers"))
            endOfDay(day)
            'Day 16 April 18
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Phillies"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Giants"))
            endOfDay(day)
            'Day 17 April 19
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Phillies"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Royals"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Padres"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Giants"))
            endOfDay(day)
            'Day 18 April 20
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Phillies"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Royals"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Padres"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Giants"))
            endOfDay(day)
            'Day 19 April 21
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Giants"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Royals"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Padres"))
            endOfDay(day)
            'Day 20 April 22
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Royals"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Padres"))
            endOfDay(day)
            'Day 21 April 23
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Royals"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Padres"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Giants"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Giants"))
            endOfDay(day)
            'Day 22 April 24
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Royals"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Giants"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Padres"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Astros"))
            endOfDay(day)
            'Day 23 April 25
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Reds"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Mariners"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Dodgers"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Giants"))
            endOfDay(day)
            'Day 24 April 26
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Reds"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Mariners"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Dodgers"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Giants"))
            endOfDay(day)
            'Day 25 April 27
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Giants"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Reds"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Mariners"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Dodgers"))
            endOfDay(day)
            'Day 26 April 28
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Dodgers"))
            endOfDay(day)
            'Day 27 April 29
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Reds"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Phillies"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Mariners"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Dodgers"))
            endOfDay(day)
            'Day 28 April 30
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Reds"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Phillies"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Dodgers"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Mariners"))
            endOfDay(day)
            'Day 29 May 1
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Reds"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Marlins"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Phillies"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Mariners"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Dodgers"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Red Sox"))
            endOfDay(day)
            'Day 30 May 2
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Royals"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Padres"))
            endOfDay(day)
            'Day 31 May 3
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Royals"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Padres"))
            endOfDay(day)
            'Day 32 May 4
            baseball.GameSim(baseball.getTeam("Cubs"), baseball.getTeam("Pirates"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Braves"), baseball.getTeam("Mets"))
            baseball.GameSim(baseball.getTeam("Angels"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Royals"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Athletics"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Padres"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Rays"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Cardinals"))
            endOfDay(day)
            'Day 33 May 5
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Yankees"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Padres"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Giants"))
            endOfDay(day)
            'Day 34 May 6
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Giants"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Padres"))
            endOfDay(day)
            'Day 35 May 7
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Giants"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Padres"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Angels"))
            endOfDay(day)
            'Day 36 May 8
            baseball.GameSim(baseball.getTeam("Dodgers"), baseball.getTeam("Blue Jays"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Indians"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Rangers"), baseball.getTeam("Tigers"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Twins"), baseball.getTeam("White Sox"))
            baseball.GameSim(baseball.getTeam("Mariners"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Cardinals"))
            baseball.GameSim(baseball.getTeam("Nationals"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Rockies"), baseball.getTeam("Giants"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Padres"))
            baseball.GameSim(baseball.getTeam("Red Sox"), baseball.getTeam("Yankees"))
            endOfDay(day)
            'Day 37 May 9
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Dodgers"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Mariners"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Giants"))
            endOfDay(day)
            'Day 38 May 10
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Dodgers"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Mariners"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Giants"))
            endOfDay(day)
            'Day 39 May 11
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Orioles"), baseball.getTeam("Twins"))
            baseball.GameSim(baseball.getTeam("White Sox"), baseball.getTeam("Rangers"))
            baseball.GameSim(baseball.getTeam("Indians"), baseball.getTeam("Astros"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Rockies"))
            baseball.GameSim(baseball.getTeam("Rays"), baseball.getTeam("Mariners"))
            baseball.GameSim(baseball.getTeam("Blue Jays"), baseball.getTeam("Giants"))
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Nationals"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Brewers"), baseball.getTeam("Marlins"))
            baseball.GameSim(baseball.getTeam("Athletics"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Reds"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Dodgers"))
            endOfDay(day)
            'Day 40 May 12
            baseball.GameSim(baseball.getTeam("Tigers"), baseball.getTeam("Orioles"))
            baseball.GameSim(baseball.getTeam("Royals"), baseball.getTeam("Yankees"))
            baseball.GameSim(baseball.getTeam("Astros"), baseball.getTeam("Red Sox"))
            baseball.GameSim(baseball.getTeam("Phillies"), baseball.getTeam("Braves"))
            baseball.GameSim(baseball.getTeam("Padres"), baseball.getTeam("Brewers"))
            baseball.GameSim(baseball.getTeam("Giants"), baseball.getTeam("Diamondbacks"))
            baseball.GameSim(baseball.getTeam("Cardinals"), baseball.getTeam("Angels"))
            baseball.GameSim(baseball.getTeam("Mets"), baseball.getTeam("Dodgers"))
            endOfDay(day)
            'Day 41 May 13
            baseball.GameSim(baseball.getTeam("Pirates"), baseball.getTeam("Cubs"))
            baseball.GameSim(baseball.getTeam("Diamondbacks"), baseball.getTeam("Giants"))
        End If
        ListBox1.Items.Add(CStr(baseball.getTeam("Cardinals").wins) & CStr(baseball.getTeam("Tigers").wins))
    End Sub
    Sub endOfDay(ByRef day As Integer)
        Label1.Text() = CStr("Day " & day)
        day += 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class team
    Public Property name As String
    Public Property wins As Integer
    Public losses As Integer
    Public elo As Integer
    Public Const elobase As Integer = 1000

End Class

Public Class baseball
    Public teamNames As New List(Of String) From
        {"Cubs", "Cardinals", "Pirates", "Reds", "Brewers", "Marlins", "Phillies", "Mets", "Braves", "Nationals", "Dodgers", "Rockies", "Diamondbacks", "Padres", "Giants", "Yankees", "Red Sox", "Blue Jays", "Rays", "Orioles", "White Sox", "Indians", "Twins", "Tigers", "Royals", "Angels", "Astros", "Mariners", "Rangers", "Athletics"}
    Public teams As New List(Of team)
    Public Sub teamCreate()
        For Each teamName In teamNames
            Dim team As New team
            team.name = teamName
            teams.Add(team)
            team.elo = team.elobase
        Next
    End Sub

    Public Function getTeam(name As String) As team

        For Each team In teams
            If team.name = name Then Return team
        Next
        Return Nothing
    End Function
    Public Sub GameSim(ByRef x As team, ByRef y As team)
        Dim tempscore1 As Integer
        Dim tempscore2 As Integer
        Dim dif As Integer = eloDif(x, y)
        Dim score1 As Integer
        Dim score2 As Integer
        Dim inning As Integer = 9
        Randomize()
        Try
            If y.elo > x.elo Then
                tempscore2 = CInt((Rnd() * 99) + (dif / 1000))
            Else tempscore2 = CInt((Rnd() * 99) - (dif / 1000))
            End If

            scoreRef(tempscore2, score2)
            Randomize()

            If x.elo > y.elo Then
                tempscore1 = CInt((Rnd() * 99) + (dif / 1000))
            Else tempscore1 = CInt((Rnd() * 99) - (dif / 1000))
            End If
            scoreRef(tempscore1, score1)
            If score1 > score2 Then
                x.wins += 1
                y.losses += 1
            End If
            If score1 < score2 Then
                y.wins += 1
                x.losses += 1
            End If
        Catch
        End Try
        Try
            Do Until score1 <> score2
                If score1 > score2 Then
                    x.wins += 1
                    y.losses += 1
                ElseIf score1 < score2 Then
                    y.wins += 1
                    x.losses += 1
                ElseIf score1 = score2 Then
                    Randomize()
                    If y.elo > x.elo Then
                        tempscore2 = CInt((Rnd() * 99) + (dif / 1000))
                    Else tempscore2 = CInt((Rnd() * 99) - (dif / 1000))
                    End If
                    scoreRef(tempscore2, score2)
                    Randomize()
                    If x.elo > y.elo Then
                        tempscore1 = CInt((Rnd() * 99) + (dif / 1000))
                    Else tempscore1 = CInt((Rnd() * 99) - (dif / 1000))
                    End If
                    scoreRef(tempscore1, score1)
                End If
                inning += 1
            Loop
        Catch
        End Try
    End Sub
    Public Function eloDif(x As team, y As team) As Integer
        Try
            Return Math.Abs((x.elo - y.elo))
        Catch
            Return 0
        End Try
    End Function
    Public Sub scoreRef(x As Integer, ByRef score As Integer)
        If x <= 13 Then
            score = 0
        ElseIf x <= 25 Then
            score = 1
        ElseIf x <= 36 Then
            score = 2
        ElseIf x <= 46 Then
            score = 3
        ElseIf x <= 54 Then
            score = 4
        ElseIf x <= 62 Then
            score = 5
        ElseIf x <= 69 Then
            score = 6
        ElseIf x <= 75 Then
            score = 7
        ElseIf x <= 80 Then
            score = 8
        ElseIf x <= 84 Then
            score = 9
        ElseIf x <= 87 Then
            score = 10
        ElseIf x <= 89 Then
            score = 11
        ElseIf x <= 90 Then
            score = 12
        ElseIf x <= 91 Then
            score = 13
        ElseIf x <= 92 Then
            score = 14
        ElseIf x <= 93 Then
            score = 15
        ElseIf x <= 94 Then
            score = 16
        ElseIf x <= 95 Then
            score = 17
        ElseIf x <= 96 Then
            score = 18
        ElseIf x <= 97 Then
            score = 19
        ElseIf x <= 98 Then
            score = 20
        ElseIf x >= 99 Then
            score = CInt((Rnd() * 5) + 20)
        End If
    End Sub
End Class
