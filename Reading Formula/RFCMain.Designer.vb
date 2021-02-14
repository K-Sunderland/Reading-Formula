<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RFCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RFCalc))
        Me.Main_Title = New System.Windows.Forms.Label()
        Me.Book_Level = New System.Windows.Forms.TextBox()
        Me.Book_Pages = New System.Windows.Forms.TextBox()
        Me.Book_Talk = New System.Windows.Forms.TextBox()
        Me.Student_Level = New System.Windows.Forms.TextBox()
        Me.EnterBtn = New System.Windows.Forms.Button()
        Me.Output = New System.Windows.Forms.Label()
        Me.FormExit = New System.Windows.Forms.Button()
        Me.FormMinimize = New System.Windows.Forms.Button()
        Me.Dock = New System.Windows.Forms.CheckBox()
        Me.About = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Main_Title
        '
        Me.Main_Title.AutoSize = True
        Me.Main_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Main_Title.Font = New System.Drawing.Font("Mechanical", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_Title.ForeColor = System.Drawing.Color.Black
        Me.Main_Title.Location = New System.Drawing.Point(2, 43)
        Me.Main_Title.Name = "Main_Title"
        Me.Main_Title.Size = New System.Drawing.Size(225, 70)
        Me.Main_Title.TabIndex = 0
        Me.Main_Title.Text = "Reading Formula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Calculator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Book_Level
        '
        Me.Book_Level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Book_Level.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Book_Level.Location = New System.Drawing.Point(10, 218)
        Me.Book_Level.Name = "Book_Level"
        Me.Book_Level.Size = New System.Drawing.Size(124, 20)
        Me.Book_Level.TabIndex = 3
        Me.Book_Level.Text = "Book Level"
        '
        'Book_Pages
        '
        Me.Book_Pages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Book_Pages.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Book_Pages.Location = New System.Drawing.Point(10, 169)
        Me.Book_Pages.Name = "Book_Pages"
        Me.Book_Pages.Size = New System.Drawing.Size(124, 20)
        Me.Book_Pages.TabIndex = 2
        Me.Book_Pages.Text = "Book Pages"
        '
        'Book_Talk
        '
        Me.Book_Talk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Book_Talk.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Book_Talk.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Book_Talk.Location = New System.Drawing.Point(10, 121)
        Me.Book_Talk.Name = "Book_Talk"
        Me.Book_Talk.Size = New System.Drawing.Size(124, 22)
        Me.Book_Talk.TabIndex = 1
        Me.Book_Talk.Text = "Book Talk"
        '
        'Student_Level
        '
        Me.Student_Level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Student_Level.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Student_Level.Location = New System.Drawing.Point(10, 267)
        Me.Student_Level.Name = "Student_Level"
        Me.Student_Level.Size = New System.Drawing.Size(124, 20)
        Me.Student_Level.TabIndex = 4
        Me.Student_Level.Text = "Student Level"
        '
        'EnterBtn
        '
        Me.EnterBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EnterBtn.Cursor = System.Windows.Forms.Cursors.Default
        Me.EnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EnterBtn.Font = New System.Drawing.Font("Mechanical", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterBtn.Location = New System.Drawing.Point(26, 340)
        Me.EnterBtn.Name = "EnterBtn"
        Me.EnterBtn.Size = New System.Drawing.Size(80, 30)
        Me.EnterBtn.TabIndex = 5
        Me.EnterBtn.Text = "Calculate!"
        Me.EnterBtn.UseVisualStyleBackColor = False
        '
        'Output
        '
        Me.Output.Font = New System.Drawing.Font("Mechanical", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output.ForeColor = System.Drawing.Color.Black
        Me.Output.Location = New System.Drawing.Point(10, 300)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(124, 37)
        Me.Output.TabIndex = 11
        Me.Output.Text = "000"
        Me.Output.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.FormExit.Location = New System.Drawing.Point(281, 2)
        Me.FormExit.Name = "FormExit"
        Me.FormExit.Size = New System.Drawing.Size(44, 21)
        Me.FormExit.TabIndex = 12
        Me.FormExit.UseVisualStyleBackColor = False
        '
        'FormMinimize
        '
        Me.FormMinimize.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FormMinimize.BackgroundImage = CType(resources.GetObject("FormMinimize.BackgroundImage"), System.Drawing.Image)
        Me.FormMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FormMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.FormMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.FormMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FormMinimize.ForeColor = System.Drawing.Color.Transparent
        Me.FormMinimize.Location = New System.Drawing.Point(252, 2)
        Me.FormMinimize.Name = "FormMinimize"
        Me.FormMinimize.Size = New System.Drawing.Size(33, 21)
        Me.FormMinimize.TabIndex = 13
        Me.FormMinimize.UseVisualStyleBackColor = False
        '
        'Dock
        '
        Me.Dock.Appearance = System.Windows.Forms.Appearance.Button
        Me.Dock.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Dock.BackgroundImage = CType(resources.GetObject("Dock.BackgroundImage"), System.Drawing.Image)
        Me.Dock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Dock.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Dock.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark
        Me.Dock.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark
        Me.Dock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dock.Location = New System.Drawing.Point(222, 2)
        Me.Dock.Name = "Dock"
        Me.Dock.Size = New System.Drawing.Size(33, 21)
        Me.Dock.TabIndex = 16
        Me.Dock.UseVisualStyleBackColor = False
        '
        'About
        '
        Me.About.Font = New System.Drawing.Font("Mechanical", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.About.ForeColor = System.Drawing.Color.Black
        Me.About.Location = New System.Drawing.Point(6, 1)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(75, 23)
        Me.About.TabIndex = 17
        Me.About.Text = "About"
        Me.About.UseVisualStyleBackColor = True
        '
        'RFCalc
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(327, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.About)
        Me.Controls.Add(Me.Dock)
        Me.Controls.Add(Me.FormMinimize)
        Me.Controls.Add(Me.FormExit)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.EnterBtn)
        Me.Controls.Add(Me.Student_Level)
        Me.Controls.Add(Me.Book_Pages)
        Me.Controls.Add(Me.Book_Level)
        Me.Controls.Add(Me.Main_Title)
        Me.Controls.Add(Me.Book_Talk)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(327, 456)
        Me.MinimumSize = New System.Drawing.Size(327, 456)
        Me.Name = "RFCalc"
        Me.Text = "The Reading Formula Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Main_Title As Label
    Friend WithEvents Book_Level As TextBox
    Friend WithEvents Book_Pages As TextBox
    Friend WithEvents Book_Talk As TextBox
    Friend WithEvents Student_Level As TextBox
    Friend WithEvents EnterBtn As Button
    Friend WithEvents Output As Label
    Friend WithEvents FormExit As Button
    Friend WithEvents FormMinimize As Button
    Friend WithEvents Dock As CheckBox
    Friend WithEvents About As Button
End Class
