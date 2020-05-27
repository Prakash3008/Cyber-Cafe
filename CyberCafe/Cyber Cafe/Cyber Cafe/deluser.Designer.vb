<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class deluser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deluser))
        Me.delete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameu = New System.Windows.Forms.TextBox()
        Me.close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Black
        Me.delete.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.delete.Location = New System.Drawing.Point(117, 200)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(140, 56)
        Me.delete.TabIndex = 0
        Me.delete.Text = "Delete User"
        Me.delete.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(95, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(152, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Delete A Particular User"
        '
        'nameu
        '
        Me.nameu.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameu.Location = New System.Drawing.Point(264, 117)
        Me.nameu.Name = "nameu"
        Me.nameu.Size = New System.Drawing.Size(209, 31)
        Me.nameu.TabIndex = 3
        '
        'close
        '
        Me.close.BackColor = System.Drawing.Color.Black
        Me.close.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.close.Location = New System.Drawing.Point(292, 200)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(140, 56)
        Me.close.TabIndex = 4
        Me.close.Text = "Close"
        Me.close.UseVisualStyleBackColor = False
        '
        'deluser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(557, 352)
        Me.Controls.Add(Me.close)
        Me.Controls.Add(Me.nameu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.delete)
        Me.Name = "deluser"
        Me.Text = "deluser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents delete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nameu As TextBox
    Friend WithEvents close As Button
End Class
