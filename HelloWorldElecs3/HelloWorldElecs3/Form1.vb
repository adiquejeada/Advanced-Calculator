Public Class Form1

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        MessageBox.Show("Hello World!", "Hello World!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Application.Exit()
    End Sub
End Class
