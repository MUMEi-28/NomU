<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.btnShowGrade = New System.Windows.Forms.Button()
		Me.btnLogOut = New System.Windows.Forms.Button()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.txtEnglish = New System.Windows.Forms.TextBox()
		Me.txtMath = New System.Windows.Forms.TextBox()
		Me.txtScience = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(160, 66)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(88, 29)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Name:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(75, 106)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(180, 29)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "English Grade:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(96, 156)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(152, 29)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Math Grade:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(68, 221)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(20, 29)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = " "
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(61, 212)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(187, 29)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "Science Grade:"
		'
		'btnShowGrade
		'
		Me.btnShowGrade.Location = New System.Drawing.Point(185, 362)
		Me.btnShowGrade.Name = "btnShowGrade"
		Me.btnShowGrade.Size = New System.Drawing.Size(198, 77)
		Me.btnShowGrade.TabIndex = 8
		Me.btnShowGrade.Text = "Show Grade"
		Me.btnShowGrade.UseVisualStyleBackColor = True
		'
		'btnLogOut
		'
		Me.btnLogOut.Location = New System.Drawing.Point(185, 462)
		Me.btnLogOut.Name = "btnLogOut"
		Me.btnLogOut.Size = New System.Drawing.Size(198, 77)
		Me.btnLogOut.TabIndex = 9
		Me.btnLogOut.Text = "LOG OUT"
		Me.btnLogOut.UseVisualStyleBackColor = True
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(267, 66)
		Me.txtName.Multiline = True
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(92, 29)
		Me.txtName.TabIndex = 10
		'
		'txtEnglish
		'
		Me.txtEnglish.Location = New System.Drawing.Point(267, 106)
		Me.txtEnglish.Multiline = True
		Me.txtEnglish.Name = "txtEnglish"
		Me.txtEnglish.Size = New System.Drawing.Size(92, 29)
		Me.txtEnglish.TabIndex = 11
		'
		'txtMath
		'
		Me.txtMath.Location = New System.Drawing.Point(267, 156)
		Me.txtMath.Multiline = True
		Me.txtMath.Name = "txtMath"
		Me.txtMath.Size = New System.Drawing.Size(92, 29)
		Me.txtMath.TabIndex = 12
		'
		'txtScience
		'
		Me.txtScience.Location = New System.Drawing.Point(267, 212)
		Me.txtScience.Multiline = True
		Me.txtScience.Name = "txtScience"
		Me.txtScience.Size = New System.Drawing.Size(92, 29)
		Me.txtScience.TabIndex = 13
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.ClientSize = New System.Drawing.Size(628, 602)
		Me.Controls.Add(Me.txtScience)
		Me.Controls.Add(Me.txtMath)
		Me.Controls.Add(Me.txtEnglish)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.btnLogOut)
		Me.Controls.Add(Me.btnShowGrade)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label3)
		Me.Name = "Form2"
		Me.Text = "English Grade:"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label3 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents btnShowGrade As Button
	Friend WithEvents btnLogOut As Button
	Friend WithEvents txtName As TextBox
	Friend WithEvents txtEnglish As TextBox
	Friend WithEvents txtMath As TextBox
	Friend WithEvents txtScience As TextBox
End Class
