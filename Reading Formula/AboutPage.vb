Imports System.ComponentModel

Public Class AboutForm


    Private Sub FormExit_Click(sender As Object, e As EventArgs) Handles FormExit.Click
        Me.Close()
    End Sub

    Private Sub AboutForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        RFCalc.Enabled = True
        RFCalc.TopMost = False
    End Sub
    Private borderColor As Color = SystemColors.ControlDarkDark
    Private borderWidth As Integer = 2
    Private formRegion As Rectangle
    Private Sub AboutForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, formRegion, borderColor,
borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,
ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid,
borderColor, borderWidth, ButtonBorderStyle.Solid)
    End Sub

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        formRegion = New Rectangle(0, 0, Me.Width, Me.Height)
    End Sub
End Class