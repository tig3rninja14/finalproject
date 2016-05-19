Public Class Playoffs
    Public pday As Integer = 0
    Public nd1, nd2, nd3, nd4 As team
    Public ad1, ad2, ad3, ad4 As team
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Playoffs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox15.Image = Form3.ALwildCard1.logo
        PictureBox16.Image = Form3.ALwildCard2.logo
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
        ws1.Text() = "0"
        ws1.Visible = False
        ws2.Visible = False
        nlcs1.Visible = False
        nlcs2.Visible = False
        alcs1.Visible = False
        alcs2.Visible = False
    End Sub
End Class