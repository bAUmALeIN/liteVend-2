Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundButton
    Inherits Button

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)

        Dim graphicsPath As New GraphicsPath()
        graphicsPath.AddEllipse(0, 0, Me.Width, Me.Height)
        Me.Region = New Region(graphicsPath)
        MyBase.OnPaint(pevent)
    End Sub
End Class
