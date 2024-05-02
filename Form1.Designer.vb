<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TxtUserName = New System.Windows.Forms.TextBox()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.BtnLogIn = New System.Windows.Forms.Button()
		Me.btnAddStudent = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(238, 7)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(153, 46)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "NOM U"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(218, 63)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(186, 31)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Student Portal"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(69, 150)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(116, 25)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "User Name:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(82, 190)
		Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(104, 25)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Password:"
		'
		'TxtUserName
		'
		Me.TxtUserName.Location = New System.Drawing.Point(192, 137)
		Me.TxtUserName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.TxtUserName.Multiline = True
		Me.TxtUserName.Name = "TxtUserName"
		Me.TxtUserName.Size = New System.Drawing.Size(281, 36)
		Me.TxtUserName.TabIndex = 4
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(192, 190)
		Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.txtPassword.Multiline = True
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(281, 36)
		Me.txtPassword.TabIndex = 5
		'
		'BtnLogIn
		'
		Me.BtnLogIn.AccessibleName = ""
		Me.BtnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnLogIn.Location = New System.Drawing.Point(62, 329)
		Me.BtnLogIn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.BtnLogIn.Name = "BtnLogIn"
		Me.BtnLogIn.Size = New System.Drawing.Size(162, 76)
		Me.BtnLogIn.TabIndex = 6
		Me.BtnLogIn.Text = "LOG IN"
		Me.BtnLogIn.UseVisualStyleBackColor = True
		'
		'btnAddStudent
		'
		Me.btnAddStudent.AccessibleName = ""
		Me.btnAddStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAddStudent.Location = New System.Drawing.Point(245, 329)
		Me.btnAddStudent.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.btnAddStudent.Name = "btnAddStudent"
		Me.btnAddStudent.Size = New System.Drawing.Size(292, 76)
		Me.btnAddStudent.TabIndex = 11
		Me.btnAddStudent.Text = "ADD STUDENT"
		Me.btnAddStudent.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.ClientSize = New System.Drawing.Size(605, 493)
		Me.Controls.Add(Me.btnAddStudent)
		Me.Controls.Add(Me.BtnLogIn)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.TxtUserName)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents TxtUserName As TextBox
	Friend WithEvents txtPassword As TextBox
	Friend WithEvents BtnLogIn As Button
	Friend WithEvents btnAddStudent As Button
End Class
