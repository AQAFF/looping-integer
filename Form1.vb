Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        For n = 6 To 36 Step 6
            TextBox1.Text = TextBox1.Text & n & vbCr
        Next n
    End Sub
End Class
