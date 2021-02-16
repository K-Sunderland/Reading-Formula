<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Formula = New System.Windows.Forms.Label()
        Me.FormExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Version 1.3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2021 Kyle Sunderland" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reading Formula by Kelly Allen"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(117, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 106)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Formula
        '
        Me.Formula.AutoSize = True
        Me.Formula.Enabled = False
        Me.Formula.Font = New System.Drawing.Font("RM Typerighter medium", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Formula.ForeColor = System.Drawing.Color.Black
        Me.Formula.Location = New System.Drawing.Point(12, 109)
        Me.Formula.Name = "Formula"
        Me.Formula.Size = New System.Drawing.Size(99, 34)
        Me.Formula.TabIndex = 0
        Me.Formula.Text = "The Reading" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Formula"
        '
        'FormExit
        '
        Me.FormExit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FormExit.BackgroundImage = CType(resources.GetObject("FormExit.BackgroundImage"), System.Drawing.Image)
        Me.FormExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FormExit.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.FormExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.FormExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FormExit.ForeColor = System.Drawing.Color.Transparent
        Me.FormExit.Location = New System.Drawing.Point(188, 5)
        Me.FormExit.Name = "FormExit"
        Me.FormExit.Size = New System.Drawing.Size(57, 22)
        Me.FormExit.TabIndex = 13
        Me.FormExit.UseVisualStyleBackColor = False
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 216)
        Me.Controls.Add(Me.FormExit)
        Me.Controls.Add(Me.Formula)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(250, 216)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(250, 216)
        Me.Name = "AboutForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Formula As Label
    Friend WithEvents FormExit As Button
End Class
