<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client_form
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
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDataCreated = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Address = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClientNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(110, 90)
        Me.txtContactNo.MaxLength = 11
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(364, 20)
        Me.txtContactNo.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Contact Number"
        '
        'txtDataCreated
        '
        Me.txtDataCreated.CustomFormat = "dd/MMM/yyyy"
        Me.txtDataCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDataCreated.Location = New System.Drawing.Point(110, 117)
        Me.txtDataCreated.Name = "txtDataCreated"
        Me.txtDataCreated.Size = New System.Drawing.Size(224, 20)
        Me.txtDataCreated.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Date"
        '
        'txt_Address
        '
        Me.txt_Address.Location = New System.Drawing.Point(110, 64)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(364, 20)
        Me.txt_Address.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Address"
        '
        'txtClientNo
        '
        Me.txtClientNo.Location = New System.Drawing.Point(110, 12)
        Me.txtClientNo.Name = "txtClientNo"
        Me.txtClientNo.ReadOnly = True
        Me.txtClientNo.Size = New System.Drawing.Size(364, 20)
        Me.txtClientNo.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Client_No"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(110, 38)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(364, 20)
        Me.txtName.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(399, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Add Client"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Client_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Infotech.My.Resources.Resources._27101950596
        Me.ClientSize = New System.Drawing.Size(489, 176)
        Me.Controls.Add(Me.txtContactNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDataCreated)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClientNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Client_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDataCreated As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Address As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtClientNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
