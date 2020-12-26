Public Class Form1

    Dim x As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = Val(TextBox1.Text)

        If x <= 45 And x >= 1 Then
            Label4.Text = ("Kaldı.")
            Label6.Text = ("FD")
            Label2.Text = ("Kaldı. | FD")
            MsgBox(Label4.Text + " | " + Label6.Text)

        ElseIf x <= 52 And x >= 46 Then
            Label4.Text = ("Kaldı.")
            Label6.Text = ("DD")
            Label2.Text = ("Kaldı. | DD")
            MsgBox(Label4.Text + " | " + Label6.Text)

        ElseIf x <= 59 And x >= 53 Then
            Label4.Text = ("Kaldı.")
            Label6.Text = ("DC")
            Label2.Text = ("Kaldı. | DC")
            MsgBox(Label4.Text + " | " + Label6.Text)

        ElseIf x <= 66 And x >= 60 Then
            Label4.Text = ("Geçti.")
            Label6.Text = ("CC")
            Label2.Text = ("Geçti. | CC")
            MsgBox(Label4.Text + " | " + Label6.Text)

        ElseIf x <= 73 And x >= 67 Then
            Label4.Text = ("Geçti.")
            Label6.Text = ("CB")
            Label2.Text = ("Geçti. | CB")
            MsgBox(Label4.Text + " | " + Label6.Text)

        ElseIf x <= 80 And x >= 74 Then
            Label4.Text = ("Geçti.")
            Label6.Text = ("BB")
            Label2.Text = ("Geçti. | BB")
            MsgBox(Label4.Text + " | " + Label6.Text)

        ElseIf x <= 87 And x >= 81 Then
            Label4.Text = ("Geçti.")
            Label6.Text = ("BA")
            Label2.Text = ("Geçti. | BA")
            MsgBox(Label4.Text + " | " + Label6.Text)

        ElseIf x <= 100 And x >= 88 Then
            Label4.Text = ("Geçti.")
            Label6.Text = ("AA")
            Label2.Text = ("Geçti. | AA")
            MsgBox(Label4.Text + " | " + Label6.Text)

        End If
    End Sub
End Class
