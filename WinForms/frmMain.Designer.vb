<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Me.btnHello = New System.Windows.Forms.Button()
		Me.lblHello = New System.Windows.Forms.Label()
		Me.txtHello = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'btnHello
		'
		Me.btnHello.Location = New System.Drawing.Point(13, 13)
		Me.btnHello.Name = "btnHello"
		Me.btnHello.Size = New System.Drawing.Size(75, 39)
		Me.btnHello.TabIndex = 0
		Me.btnHello.Text = "Hello"
		Me.btnHello.UseVisualStyleBackColor = True
		'
		'lblHello
		'
		Me.lblHello.AutoSize = True
		Me.lblHello.Location = New System.Drawing.Point(95, 25)
		Me.lblHello.Name = "lblHello"
		Me.lblHello.Size = New System.Drawing.Size(31, 13)
		Me.lblHello.TabIndex = 1
		Me.lblHello.Text = "Hello"
		'
		'txtHello
		'
		Me.txtHello.Location = New System.Drawing.Point(13, 59)
		Me.txtHello.Name = "txtHello"
		Me.txtHello.Size = New System.Drawing.Size(100, 20)
		Me.txtHello.TabIndex = 2
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(624, 441)
		Me.Controls.Add(Me.txtHello)
		Me.Controls.Add(Me.lblHello)
		Me.Controls.Add(Me.btnHello)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Hello Raspberry Pi"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Private WithEvents btnHello As Button
	Private WithEvents lblHello As Label
	Private WithEvents txtHello As TextBox
End Class
