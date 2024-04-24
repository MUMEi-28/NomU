<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.TxtUserName = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtMath = New System.Windows.Forms.TextBox()
		Me.txtEnglish = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtScience = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.btnConfirm = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(340, 116)
		Me.txtPassword.Multiline = True
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(373, 44)
		Me.txtPassword.TabIndex = 9
		'
		'TxtUserName
		'
		Me.TxtUserName.Location = New System.Drawing.Point(340, 51)
		Me.TxtUserName.Multiline = True
		Me.TxtUserName.Name = "TxtUserName"
		Me.TxtUserName.Size = New System.Drawing.Size(373, 44)
		Me.TxtUserName.TabIndex = 8
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(193, 131)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(131, 29)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Password:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(176, 66)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(148, 29)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "User Name:"
		'
		'txtMath
		'
		Me.txtMath.Location = New System.Drawing.Point(340, 269)
		Me.txtMath.Multiline = True
		Me.txtMath.Name = "txtMath"
		Me.txtMath.Size = New System.Drawing.Size(373, 44)
		Me.txtMath.TabIndex = 13
		'
		'txtEnglish
		'
		Me.txtEnglish.Location = New System.Drawing.Point(340, 204)
		Me.txtEnglish.Multiline = True
		Me.txtEnglish.Name = "txtEnglish"
		Me.txtEnglish.Size = New System.Drawing.Size(373, 44)
		Me.txtEnglish.TabIndex = 12
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(172, 284)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(152, 29)
		Me.Label1.TabIndex = 11
		Me.Label1.Text = "Math Grade:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(144, 219)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(180, 29)
		Me.Label2.TabIndex = 10
		Me.Label2.Text = "English Grade:"
		'
		'txtScience
		'
		Me.txtScience.Location = New System.Drawing.Point(340, 332)
		Me.txtScience.Multiline = True
		Me.txtScience.Name = "txtScience"
		Me.txtScience.Size = New System.Drawing.Size(373, 44)
		Me.txtScience.TabIndex = 16
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(147, 347)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(187, 29)
		Me.Label6.TabIndex = 14
		Me.Label6.Text = "Science Grade:"
		'
		'btnConfirm
		'
		Me.btnConfirm.AccessibleName = ""
		Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnConfirm.Location = New System.Drawing.Point(58, 433)
		Me.btnConfirm.Name = "btnConfirm"
		Me.btnConfirm.Size = New System.Drawing.Size(363, 94)
		Me.btnConfirm.TabIndex = 17
		Me.btnConfirm.Text = "CONFIRM"
		Me.btnConfirm.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.AccessibleName = ""
		Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Location = New System.Drawing.Point(483, 433)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(385, 94)
		Me.btnCancel.TabIndex = 18
		Me.btnCancel.Text = "CANCEL"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'Form3
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.ClientSize = New System.Drawing.Size(896, 583)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnConfirm)
		Me.Controls.Add(Me.txtScience)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtMath)
		Me.Controls.Add(Me.txtEnglish)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.TxtUserName)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Name = "Form3"
		Me.Text = "Form3"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtPassword As TextBox
	Friend WithEvents TxtUserName As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtMath As TextBox
	Friend WithEvents txtEnglish As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txtScience As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents btnConfirm As Button
	Friend WithEvents btnCancel As Button
End Class
