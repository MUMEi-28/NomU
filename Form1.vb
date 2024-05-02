Public Class Form1
	Public ListStudent As New List(Of Student)
	Public strCurrentUser As Student

	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		Dim stud1 As New Student("Jose", "1234", 74, 75, 80)
		Dim stud2 As New Student("Juana", "abcd", 90, 95, 90)
		Dim stud3 As New Student("Cardo", "juana", 75, 75, 75)


		ListStudent.Add(stud1)
		ListStudent.Add(stud2)
		ListStudent.Add(stud3)

		'stud1.setusercredentials("jose", "1234")
		'stud2.setusercredentials("juana", "abcd")
		'stud3.setusercredentials("cardo", "juana")

		'stud1.setgrade(74, 75, 80)
		'stud2.setgrade(90, 95, 90)
		'stud3.setgrade(75, 75, 75)
	End Sub

	Class Student
		Private strName As String
		Private strPass As String
		Private dblEGrade As Double ' ENGLISH
		Private dblMGrade As Double ' MATH
		Private dblSGrade As Double ' SCIENCE

		Public Sub New()

		End Sub

		Public Sub New(ByVal strTempName As String, ByVal strTempPass As String, ByVal dblEnglish As Double, ByVal dblMath As Double, ByVal dblScience As Double)
			strName = strTempName
			strPass = strTempPass
			dblEGrade = dblEnglish
			dblMGrade = dblMath
			dblSGrade = dblScience
		End Sub

		Public Sub SetUserCredentials(ByVal strTempName As String, ByVal strTempPass As String)
			strName = strTempName
			strPass = strTempPass
		End Sub
		Public Sub Setgrade(ByVal dblEnglish As Double, ByVal dblMath As Double, ByVal dblScience As Double)
			dblEGrade = dblEnglish
			dblMGrade = dblMath
			dblSGrade = dblScience
		End Sub

		Public Function GetName() As String
			Return strName
		End Function

		Public Function GetPass() As String
			Return strPass
		End Function

		Public Function GetGrades() As Array
			Dim arrayGrades(3) As Double
			arrayGrades(0) = dblEGrade
			arrayGrades(1) = dblMGrade
			arrayGrades(2) = dblSGrade
			Return arrayGrades
		End Function
	End Class

	Private Sub BtnLogIn_Click(sender As Object, e As EventArgs) Handles BtnLogIn.Click
		'Dim stud1 As New Student("Jose", "1234", 74, 75, 80)
		'Dim stud2 As New Student("Juana", "abcd", 90, 95, 90)
		'Dim stud3 As New Student("Cardo", "juana", 75, 75, 75)

		'If TxtUserName.Text = stud1.GetName() And txtPassword.Text = stud1.GetPass() Then
		'	MsgBox("log in succesful")
		'ElseIf TxtUserName.Text = stud1.GetName() And txtPassword.Text = stud1.GetPass() Then
		'	MsgBox("log in succesful")
		'ElseIf TxtUserName.Text = stud1.GetName() And txtPassword.Text = stud1.GetPass() Then
		'	MsgBox("log in succesful")
		'Else
		'	MsgBox("log in failed")
		'End If


		'For Each student In ListStudent
		'	If TxtUserName.Text = student.GetName() And txtPassword.Text = student.GetPass() Then
		'		MsgBox("log in succesful")
		'	End If

		'Next


		Dim intCounter = 0
		Do While intCounter < ListStudent.Count
			If TxtUserName.Text = ListStudent(intCounter).GetName() And txtPassword.Text = ListStudent(intCounter).GetPass() Then
				MsgBox("log in succesful")

				Form2.Show()
				Me.Hide()
				strCurrentUser = ListStudent(intCounter)
			End If
			intCounter += 1
		Loop

		TxtUserName.Clear()
		txtPassword.Clear()
	End Sub

	Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
		Form3.Show()
		Me.Hide()
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
