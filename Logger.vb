Public Class Logger


    Dim mouseOffset As Point

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, Panel1.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, Panel1.MouseMove

        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Public Sub WriteLine(text As String)
        RichTextBox1.AppendText(text)
        RichTextBox1.AppendText(vbNewLine)
        RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text Files (*.txt)|*.txt"
        sfd.Title = "Log speichern unter"
        sfd.FileName = $"LOG_{System.DateTime.Now.ToString}"
        sfd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory
        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                System.IO.File.WriteAllText(sfd.FileName, RichTextBox1.Text)
            Catch ex As Exception
                WriteLine(ex.Message)

            End Try

        End If
    End Sub

    Private Sub Logger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim img = My.Resources.icons8_speichern_50
        btnSave.Image = Engine.ScaleImage(img, 50, 15)
        btnSave.ImageAlign = ContentAlignment.MiddleLeft
        btnSave.TextAlign = ContentAlignment.MiddleRight
    End Sub


    Public Sub printProdukt(produkt As Globals.Produkt)
        Dim Text = $"ID:{produkt.ID.ToString}| Bez:{produkt.Bezeichnung}| PLU:{produkt.PLU.ToString}| Preis:{produkt.Preis.ToString}| Lager:{produkt.Lager.ToString}| LagerOrt:{produkt.LagerOrt.ToString}| mindBestand:{produkt.Bestand.ToString}| ALK:{produkt.Alkoholgehalt.ToString}| Inhalt:{produkt.Volumen.ToString}| "
        RichTextBox1.AppendText(Text)
        RichTextBox1.AppendText(vbNewLine)
        RichTextBox1.ScrollToCaret()
    End Sub
End Class