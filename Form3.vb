Public Class Form3
	Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
		Dim newStudent As New Form1.Student()
		newStudent.SetUserCredentials(TxtUserName.Text, txtPassword.Text)
		newStudent.Setgrade(Val(txtEnglish.Text), Val(txtMath.Text), Val(txtScience.Text))
		Form1.ListStudent.Add(newStudent)
		TxtUserName.Clear()
		txtPassword.Clear()
		txtEnglish.Clear()
		txtMath.Clear()
		txtScience.Clear()

		Form1.Show()
		Me.Close()
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Form1.Show()
		Me.Close()
	End Sub
End Class