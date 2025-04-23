Public Class Form1
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        lblMessage.Text = "You clicked the first button."
    End Sub

    Private Sub btnSecond_Click(sender As Object, e As EventArgs) Handles btnSecond.Click
        lblMessage.Text = "You clicked the second button."
    End Sub

    Private Sub btnThird_Click(sender As Object, e As EventArgs) Handles btnThird.Click
        lblMessage.Text = "You clicked the third button."
    End Sub
End Class
