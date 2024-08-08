Imports System.Drawing
Imports System.Windows.Forms

Public Class GradientLabel
    Inherits Control

    Public Sub New()
        Me.DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        MyBase.OnPaint(pe)

        Dim g As Graphics = pe.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim text As String = Me.Text
        Dim font As Font = Me.Font
        Dim textSize As SizeF = g.MeasureString(text, font)

        ' Berechne den Farbverlauf
        Dim startColor As Color = Color.Red
        Dim endColor As Color = Color.Blue
        Dim colorBlend As New Drawing2D.ColorBlend()
        colorBlend.Colors = New Color() {startColor, endColor}
        colorBlend.Positions = New Single() {0.0F, 1.0F}

        ' Erstelle einen Farbverlauf für jeden Buchstaben
        Dim xPos As Single = 0
        For i As Integer = 0 To text.Length - 1
            Dim charSize As SizeF = g.MeasureString(text(i), font)
            Dim rect As New RectangleF(xPos, 0, charSize.Width, Me.Height)
            Using charBrush As New Drawing2D.LinearGradientBrush(rect, startColor, endColor, 0.0F)
                charBrush.InterpolationColors = colorBlend
                g.DrawString(text(i), font, charBrush, xPos, (Me.Height - charSize.Height) / 2)
            End Using
            xPos += charSize.Width
        Next
    End Sub
End Class
