<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdGuest = New System.Windows.Forms.RadioButton()
        Me.rdAdministration = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRetype = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Label6"
        Me.Label6.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdGuest)
        Me.GroupBox1.Controls.Add(Me.rdAdministration)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 39)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Type"
        '
        'rdGuest
        '
        Me.rdGuest.AutoSize = True
        Me.rdGuest.Location = New System.Drawing.Point(106, 15)
        Me.rdGuest.Name = "rdGuest"
        Me.rdGuest.Size = New System.Drawing.Size(53, 17)
        Me.rdGuest.TabIndex = 14
        Me.rdGuest.TabStop = True
        Me.rdGuest.Text = "Guest"
        Me.rdGuest.UseVisualStyleBackColor = True
        '
        'rdAdministration
        '
        Me.rdAdministration.AutoSize = True
        Me.rdAdministration.Location = New System.Drawing.Point(186, 15)
        Me.rdAdministration.Name = "rdAdministration"
        Me.rdAdministration.Size = New System.Drawing.Size(54, 17)
        Me.rdAdministration.TabIndex = 13
        Me.rdAdministration.TabStop = True
        Me.rdAdministration.Text = "Admin"
        Me.rdAdministration.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(117, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Password Dismatch"
        Me.Label5.Visible = False
        '
        'txtRetype
        '
        Me.txtRetype.Location = New System.Drawing.Point(117, 109)
        Me.txtRetype.Name = "txtRetype"
        Me.txtRetype.Size = New System.Drawing.Size(221, 20)
        Me.txtRetype.TabIndex = 25
        Me.txtRetype.UseSystemPasswordChar = True
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(117, 83)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(221, 20)
        Me.txtpassword.TabIndex = 24
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(117, 52)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(221, 20)
        Me.txtName.TabIndex = 23
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(117, 21)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(221, 20)
        Me.TxtUsername.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Re-Type Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Username"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(324, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Infotech.My.Resources.Resources._27101950596
        Me.ClientSize = New System.Drawing.Size(353, 283)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRetype)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrationForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdGuest As System.Windows.Forms.RadioButton
    Friend WithEvents rdAdministration As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRetype As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
