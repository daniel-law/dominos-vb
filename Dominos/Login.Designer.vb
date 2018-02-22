<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRegisterName = New System.Windows.Forms.TextBox()
        Me.txtRegisterEmail = New System.Windows.Forms.TextBox()
        Me.txtRegisterPhone = New System.Windows.Forms.TextBox()
        Me.txtRegisterAddress = New System.Windows.Forms.TextBox()
        Me.txtRegisterPostcode = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtRegisterPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 19)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Hi! Login or register to get yourself some food."
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(100, 156)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(150, 27)
        Me.txtEmail.TabIndex = 21
        Me.txtEmail.Text = "asuna@yuuki.moe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Email:"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(100, 189)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(150, 27)
        Me.txtPassword.TabIndex = 24
        Me.txtPassword.Text = "password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Password:"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(267, 170)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 27)
        Me.btnLogin.TabIndex = 26
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Phone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 395)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 427)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 18)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Postcode:"
        '
        'txtRegisterName
        '
        Me.txtRegisterName.BackColor = System.Drawing.Color.White
        Me.txtRegisterName.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterName.Location = New System.Drawing.Point(100, 258)
        Me.txtRegisterName.Name = "txtRegisterName"
        Me.txtRegisterName.Size = New System.Drawing.Size(150, 27)
        Me.txtRegisterName.TabIndex = 32
        '
        'txtRegisterEmail
        '
        Me.txtRegisterEmail.BackColor = System.Drawing.Color.White
        Me.txtRegisterEmail.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterEmail.Location = New System.Drawing.Point(100, 291)
        Me.txtRegisterEmail.Name = "txtRegisterEmail"
        Me.txtRegisterEmail.Size = New System.Drawing.Size(150, 27)
        Me.txtRegisterEmail.TabIndex = 33
        '
        'txtRegisterPhone
        '
        Me.txtRegisterPhone.BackColor = System.Drawing.Color.White
        Me.txtRegisterPhone.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterPhone.Location = New System.Drawing.Point(100, 357)
        Me.txtRegisterPhone.Name = "txtRegisterPhone"
        Me.txtRegisterPhone.Size = New System.Drawing.Size(150, 27)
        Me.txtRegisterPhone.TabIndex = 34
        '
        'txtRegisterAddress
        '
        Me.txtRegisterAddress.BackColor = System.Drawing.Color.White
        Me.txtRegisterAddress.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterAddress.Location = New System.Drawing.Point(100, 390)
        Me.txtRegisterAddress.Name = "txtRegisterAddress"
        Me.txtRegisterAddress.Size = New System.Drawing.Size(150, 27)
        Me.txtRegisterAddress.TabIndex = 35
        '
        'txtRegisterPostcode
        '
        Me.txtRegisterPostcode.BackColor = System.Drawing.Color.White
        Me.txtRegisterPostcode.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterPostcode.Location = New System.Drawing.Point(100, 423)
        Me.txtRegisterPostcode.Name = "txtRegisterPostcode"
        Me.txtRegisterPostcode.Size = New System.Drawing.Size(150, 27)
        Me.txtRegisterPostcode.TabIndex = 36
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(267, 423)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 27)
        Me.btnRegister.TabIndex = 37
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'txtRegisterPassword
        '
        Me.txtRegisterPassword.BackColor = System.Drawing.Color.White
        Me.txtRegisterPassword.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterPassword.Location = New System.Drawing.Point(100, 324)
        Me.txtRegisterPassword.Name = "txtRegisterPassword"
        Me.txtRegisterPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRegisterPassword.Size = New System.Drawing.Size(150, 27)
        Me.txtRegisterPassword.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Password:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Dominos.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(310, 81)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(354, 471)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRegisterPassword)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtRegisterPostcode)
        Me.Controls.Add(Me.txtRegisterAddress)
        Me.Controls.Add(Me.txtRegisterPhone)
        Me.Controls.Add(Me.txtRegisterEmail)
        Me.Controls.Add(Me.txtRegisterName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRegisterName As TextBox
    Friend WithEvents txtRegisterEmail As TextBox
    Friend WithEvents txtRegisterPhone As TextBox
    Friend WithEvents txtRegisterAddress As TextBox
    Friend WithEvents txtRegisterPostcode As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtRegisterPassword As TextBox
    Friend WithEvents Label9 As Label
End Class
