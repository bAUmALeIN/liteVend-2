Public Class FormLagerverwaltung


    Dim mouseOffset As Point

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, PanelControlBr.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
        Me.TopMost = True
        Me.TopLevel = True
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, PanelControlBr.MouseMove

        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub


    Private Sub FormLagerverwaltung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLagerAnlegen_Click(sender As Object, e As EventArgs) Handles btnLagerAnlegen.Click
        Dim FLA As New FormLagerAnlegen
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is FormLagerAnlegen Then
                frm.TopMost = True
                frm.TopLevel = True
                Return

            End If
        Next
        FLA.StartPosition = FormStartPosition.CenterScreen
        FLA.Show()

    End Sub
End Class