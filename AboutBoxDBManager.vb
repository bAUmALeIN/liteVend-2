Public NotInheritable Class AboutBoxDBManager

    Dim mouseOffset As Point

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, Panel6.MouseDown, Label26.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, Panel6.MouseMove, Label26.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub AboutBoxDBManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Legen Sie den Titel des Formulars fest.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Info {0}", ApplicationTitle)
        ' Initialisieren Sie den gesamten Text, der im Infofeld angezeigt wird.
        ' TODO: Die Assemblyinformationen der Anwendung im Bereich "Anwendung" des Dialogfelds für die 
        '    Projekteigenschaften (im Menü "Projekt") anpassen.
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub LabelVersion_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LabelCopyright_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LabelProductName_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnVendingMode_Click(sender As Object, e As EventArgs) Handles btnVendingMode.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
