Public Class frmMain
	Private Sub btnHello_Click(sender As Object, e As EventArgs) Handles btnHello.Click
		lblHello.Text = "Hello World"
		txtHello.Text = "Hello World"

		MessageBox.Show("Hello World")
	End Sub
End Class
