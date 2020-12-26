Public Class Form1
    Dim a As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        If RadioButton1.Checked = True And a = 20 Then
            MsgBox("Askere Gidebilir.")

        ElseIf RadioButton1.Checked = True And a < 20 Then
            MsgBox("Askerlik Yaşı Gelmemiş.")

        ElseIf RadioButton1.Checked = True And a > 20 Then
            MsgBox("Askerlik Yaşı Geçmiş.")

        ElseIf RadioButton2.Checked = True Then
            MsgBox("Kadınların Askerlik Yapması Zorunlu Değildir.")
        End If
    End Sub
End Class
