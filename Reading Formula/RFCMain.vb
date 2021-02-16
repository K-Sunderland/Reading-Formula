Imports System.Runtime.InteropServices


Public Class RFCalc
    ' copied from stackoverflow ;)
    ' handles window movement for borderless form
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr,
      ByVal Msg As Integer, ByVal wParam As Integer,
      ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Private borderColor As Color = Color.DarkGray
    Private borderWidth As Integer = 2
    Private formRegion As Rectangle
    Private Sub Form1_MouseDown(ByVal sender As Object,
      ByVal e As System.Windows.Forms.MouseEventArgs) _
      Handles Me.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN,
            HT_CAPTION, 0)
        End If
    End Sub

    Private Sub RFCalc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main_Title.Focus()
        formRegion = New Rectangle(0, 0, 327, 456)




    End Sub


    'Border styling
    Private Sub RFCalc_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        ControlPaint.DrawBorder(e.Graphics, formRegion, borderColor,
    borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,
    ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid,
    borderColor, borderWidth, ButtonBorderStyle.Solid)
    End Sub


    ' tabstops from enter key and data sanitization 
    Private Sub BookPages_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Book_Pages.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Book_Pages.Text.Trim() <> "" Then
                Book_Level.Focus()
            End If
        End If
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub Book_Talk_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Book_Talk.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Book_Talk.Text.Trim() <> "" Then
                Book_Pages.Focus()
                Output.Text = "000"
            End If
        End If
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub BookLevel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Book_Level.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Book_Level.Text.Trim() <> "" Then
                Student_Level.Focus()
            End If
            Select Case e.KeyChar
                Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", vbBack
                    e.Handled = False
                Case Else
                    e.Handled = True
            End Select
        End If
    End Sub

    Private Sub StudentLevel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Student_Level.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Student_Level.Text.Trim() <> "" Then
                Pre_Points.Focus()
            End If
        End If
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub Pre_Points_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Pre_Points.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Pre_Points.Text.Trim() <> "" Then
                calculate()
            End If
        End If
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select

    End Sub
    Function calculate()
        Dim BT = Book_Talk.Text
        Dim BP = Book_Pages.Text
        Dim BL = Book_Level.Text
        Dim SL = Student_Level.Text
        Dim PP = Pre_Points.Text
        ' checks for unchanged values
        If Book_Talk.Text = "Book Talk" Or Book_Pages.Text = "Book Pages" Or Book_Level.Text = "Book Level" Or Student_Level.Text = "Student Level" Or Pre_Points.Text = "Pre Points" Then
            MsgBox("Please fill in all boxes")
            Return Nothing

        Else
            ' calculator
            Output.Text = Math.Round(BT * BP * BL / SL / 50) + Pre_Points.Text
            ' reset
            Book_Talk.Text = "Book Talk"
            Book_Talk.ForeColor = SystemColors.ControlDark
            Book_Pages.Text = "Book Pages"
            Book_Pages.ForeColor = SystemColors.ControlDark
            Book_Level.Text = "Book Level"
            Book_Level.ForeColor = SystemColors.ControlDark
            Student_Level.Text = "Student Level"
            Student_Level.ForeColor = SystemColors.ControlDark
            Pre_Points.Text = "Pre Points"
            Pre_Points.ForeColor = SystemColors.ControlDark
            Book_Talk.Focus()
            Return Nothing
            Book_Talk.Focus()
            Return Nothing
        End If
    End Function

    ' checks for change in docked state & applies topMost
    Private Sub Dock_CheckedChanged(sender As Object, e As EventArgs) Handles Dock.CheckedChanged
        Select Case Dock.Checked
            Case True
                Dock.FlatAppearance.BorderColor = Color.Black
                Dock.FlatAppearance.BorderSize = 1.5
                TopMost = True
            Case False
                TopMost = False
                Dock.FlatAppearance.BorderSize = 1
                Dock.FlatAppearance.BorderColor = Color.Silver
        End Select
    End Sub

    Function PlaceHolder(activeObj As TextBox, focus As Boolean)
        Select Case focus
            Case True
                ' verify if placeholder is present on gotfocus event
                If activeObj.Text = activeObj.Name.Replace("_", " ") Then
                    'blank box if true
                    activeObj.Text = ""
                    activeObj.ForeColor = Color.Black

                End If
            Case False
                'verify if textbox was left empty on lostfocus
                If activeObj.Text = "" Then
                    'fill placeholder
                    activeObj.Text = activeObj.Name.Replace("_", " ")
                    activeObj.ForeColor = SystemColors.ControlDark
                End If
        End Select
        Return Nothing
    End Function

    Private Sub EnterBtn_Click(sender As Object, e As EventArgs)
        calculate()
    End Sub
    Private Sub FormExitClick(sender As Object, e As EventArgs) Handles FormExit.Click
        Me.Close()
    End Sub
    Private Sub FormMinimize_Click(sender As Object, e As EventArgs) Handles FormMinimize.Click
        Me.WindowState = 1
    End Sub
    '
    ' Book Talk Placeholder
    '
    Private Sub BookTalk_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Book_Talk.GotFocus
        PlaceHolder(Book_Talk, True)
    End Sub
    Private Sub BookTalk_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Book_Talk.LostFocus
        PlaceHolder(Book_Talk, False)
    End Sub

    '
    ' Book Pages Placeholder
    '
    Private Sub BookPages_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Book_Pages.GotFocus
        PlaceHolder(Book_Pages, True)
    End Sub
    Private Sub BookPages_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Book_Pages.LostFocus
        PlaceHolder(Book_Pages, False)
    End Sub

    '
    ' Book Level Placeholder
    '
    Private Sub BookLevel_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Book_Level.GotFocus
        PlaceHolder(Book_Level, True)
    End Sub
    Private Sub BookLevel_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Book_Level.LostFocus
        PlaceHolder(Book_Level, False)
    End Sub

    '
    ' Student Level Placeholder
    '
    Private Sub StudentLevel_GotFocus(sender As System.Object, e As System.EventArgs) Handles Student_Level.GotFocus
        PlaceHolder(Student_Level, True)
    End Sub
    Private Sub StudentLevel_LostFocus(sender As System.Object, e As System.EventArgs) Handles Student_Level.LostFocus
        PlaceHolder(Student_Level, False)
    End Sub
    '
    ' Pre Points Placeholder
    '
    Private Sub Pre_Points_GotFocus(sender As Object, e As EventArgs) Handles Pre_Points.GotFocus
        PlaceHolder(Pre_Points, True)
    End Sub
    Private Sub Pre_Points_LostFocus(sender As Object, e As EventArgs) Handles Pre_Points.LostFocus
        PlaceHolder(Pre_Points, False)
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        Dim aboutElement As New AboutForm
        Dim mePos As Point = Me.Location
        Me.TopMost = True
        aboutElement.TopMost = True
        aboutElement.StartPosition = FormStartPosition.Manual
        aboutElement.Location = New Point((mePos.X + Me.Width) - Me.Width / 2 - aboutElement.Width / 2, (mePos.Y + Me.Height) - Me.Height / 2 - aboutElement.Height / 2)
        Me.Enabled = False
        Dim checkState As Boolean = Dock.CheckState
        aboutElement.Show()


    End Sub
    Function ReturnCheckState() As Boolean
        Return Dock.CheckState
    End Function
End Class