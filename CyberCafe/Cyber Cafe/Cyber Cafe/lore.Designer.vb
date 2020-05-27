<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lore
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.reports = New System.Windows.Forms.Button()
        Me.close = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(579, 330)
        Me.DataGridView1.TabIndex = 0
        '
        'reports
        '
        Me.reports.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.reports.Location = New System.Drawing.Point(34, 336)
        Me.reports.Name = "reports"
        Me.reports.Size = New System.Drawing.Size(334, 49)
        Me.reports.TabIndex = 1
        Me.reports.Text = "DISPLAY USERS WHO ARE LOGGED ON PREVIOUSLY"
        Me.reports.UseVisualStyleBackColor = False
        '
        'close
        '
        Me.close.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.close.Location = New System.Drawing.Point(425, 336)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(127, 49)
        Me.close.TabIndex = 2
        Me.close.Text = "CLOSE"
        Me.close.UseVisualStyleBackColor = False
        '
        'lore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(583, 397)
        Me.Controls.Add(Me.close)
        Me.Controls.Add(Me.reports)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "lore"
        Me.Text = "lore"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents reports As Button
    Friend WithEvents close As Button
End Class
