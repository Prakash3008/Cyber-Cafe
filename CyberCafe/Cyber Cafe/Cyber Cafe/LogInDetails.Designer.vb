<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInDetails))
        Me.nam = New System.Windows.Forms.TextBox()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.phno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.login = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nam
        '
        Me.nam.Location = New System.Drawing.Point(660, 136)
        Me.nam.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.nam.Name = "nam"
        Me.nam.Size = New System.Drawing.Size(288, 29)
        Me.nam.TabIndex = 0
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(660, 346)
        Me.uname.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(288, 29)
        Me.uname.TabIndex = 1
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(660, 458)
        Me.pass.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(288, 29)
        Me.pass.TabIndex = 2
        '
        'phno
        '
        Me.phno.Location = New System.Drawing.Point(660, 240)
        Me.phno.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.phno.MaxLength = 10
        Me.phno.Name = "phno"
        Me.phno.Size = New System.Drawing.Size(288, 29)
        Me.phno.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(366, 145)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(366, 356)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(366, 244)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(366, 469)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.Black
        Me.login.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.login.Location = New System.Drawing.Point(412, 592)
        Me.login.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(236, 77)
        Me.login.TabIndex = 8
        Me.login.Text = "Sign Up"
        Me.login.UseVisualStyleBackColor = False
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.Black
        Me.clear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.clear.Location = New System.Drawing.Point(736, 592)
        Me.clear.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(232, 77)
        Me.clear.TabIndex = 9
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(513, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(310, 37)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Subscription  Form"
        '
        'LogInDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1306, 744)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.phno)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.nam)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "LogInDetails"
        Me.Text = "LogInDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nam As TextBox
    Friend WithEvents uname As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents phno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents login As Button
    Friend WithEvents clear As Button
    Friend WithEvents Label5 As Label
End Class
