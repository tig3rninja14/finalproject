Public Class Form2
    Public seasonlength As Integer
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            seasonlength = 162
        ElseIf ComboBox1.SelectedIndex = 1 Then
            seasonlength = 81
        ElseIf ComboBox1.SelectedIndex = 2 Then
            seasonlength = 60
        ElseIf ComboBox1.SelectedIndex = 3 Then
            seasonlength = 30
        ElseIf ComboBox1.SelectedIndex = 4 Then
            seasonlength = 9
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class