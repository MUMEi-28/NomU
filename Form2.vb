Public Class Form2
	Private Sub btnShowGrade_Click(sender As Object, e As EventArgs) Handles btnShowGrade.Click
		Dim tempGrade() As Double = Form1.strCurrentUser.GetGrades()
		txtName.Text = Form1.strCurrentUser.GetName()

		txtEnglish.Text = tempGrade(0)
		txtMath.Text = tempGrade(1)
		txtScience.Text = tempGrade(2)

		txtName.Visible = True
		txtEnglish.Visible = True
		txtMath.Visible = True
		txtScience.Visible = True
	End Sub

	Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click

		txtName.Clear()
		txtMath.Clear()
		txtEnglish.Clear()
		txtScience.Clear()


		Form1.Show()
		Me.Close()
	End Sub
End Class