Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the TextBox controls.
        txtName.Text = String.Empty
        txtAddress.Text = String.Empty
        txtCity.Text = String.Empty
        txtState.Text = String.Empty
        txtZip.Text = String.Empty

        ' Set the focus to txtName.
        txtName.Focus()
    End Sub
End Class
