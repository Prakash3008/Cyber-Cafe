<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Existing_User_Form
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents uname As System.Windows.Forms.TextBox
    Friend WithEvents pwd As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Existing_User_Form))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(165, 67)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(147, 45)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(160, 141)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(152, 50)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(400, 82)
        Me.uname.Margin = New System.Windows.Forms.Padding(2)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(184, 20)
        Me.uname.TabIndex = 1
        '
        'pwd
        '
        Me.pwd.Location = New System.Drawing.Point(400, 159)
        Me.pwd.Margin = New System.Windows.Forms.Padding(2)
        Me.pwd.Name = "pwd"
        Me.pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwd.Size = New System.Drawing.Size(184, 20)
        Me.pwd.TabIndex = 3
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.SystemColors.ControlText
        Me.OK.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OK.Location = New System.Drawing.Point(176, 244)
        Me.OK.Margin = New System.Windows.Forms.Padding(2)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(121, 54)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Login"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.SystemColors.ControlText
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cancel.Location = New System.Drawing.Point(368, 244)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(2)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(116, 54)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(-1, 1)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(146, 178)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Welcome Back to iCafe"
        '
        'Existing_User_Form
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(665, 341)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.pwd)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Existing_User_Form"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Existing_User_Form"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents Label1 As Label
End Class
