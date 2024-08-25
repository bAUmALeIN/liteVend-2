Public Class FormAddProdukt
    Dim CM As New ConnectionManger
    Dim mouseOffset As Point

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, PanelAddProduktMain.MouseDown, Panel5.MouseDown, LabelTextMunz.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, PanelAddProduktMain.MouseMove, Panel5.MouseMove, LabelTextMunz.MouseMove

        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub


    Private Sub FormAddProdukt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub TimerCheckTextBoxes_Tick(sender As Object, e As EventArgs) Handles TimerCheckTextBoxes.Tick
        For Each tb As Control In PanelInputProdukt.Controls
            If TypeOf tb Is TextBox Then
                If tb.Text = "" Then
                    btnSave.Enabled = False
                    Exit Sub
                End If
                btnSave.Enabled = True
            End If

        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim Preis As Double = Convert.ToDouble(tbPreis.Text)
        Dim Alk As Double = Convert.ToDouble(tbAlk.Text)
        Dim V As Double = Convert.ToDouble(tbV.Text)
        If cbImage.Checked = False Then
            If CM.InsertProdukt(tbBez.Text, Preis, V, Alk, 0, 0, 0, 0, 0) Then
                Dim anz As Integer = CM.GetProductCount()
                CM.UpdateStatsAnzProd(anz + 1)
                Logger.WriteLine("FRONTEND: Produkthinzufügen ok!")
                Dim TBs As New List(Of TextBox)
                For Each tb In PanelInputProdukt.Controls
                    If TypeOf tb Is TextBox Then
                        TBs.Add(tb)
                    End If

                Next
                Engine.CleanTBs(TBs)
            Else
                Logger.WriteLine("FRONTEND: Produkthinzufügen FEHLGESCHLAGEN!")
            End If
        Else
            If CM.InsertProdukt(tbBez.Text, Preis, V, Alk, 0, 0, 0, 0, 0) Then
                Dim anz As Integer = CM.GetProductCount()
                CM.UpdateStatsAnzProd(anz + 1)
                CM.SaveImageToDatabase(PictureBox1.Image, CM.GetProduktIDByName(tbBez.Text))
                Logger.WriteLine("FRONTEND: Eintrag für Produkt + Bild erfolgreich erstellt!")
                Dim TBs As New List(Of TextBox)
                For Each tb In PanelInputProdukt.Controls
                    If TypeOf tb Is TextBox Then
                        TBs.Add(tb)
                    End If

                Next
                Engine.CleanTBs(TBs)
                cbImage.Checked = False
                PictureBox1.Image = Nothing
                PictureBox1.BackgroundImage = My.Resources.Dose
            Else
                Logger.WriteLine("FRONTEND: Produkthinzufügen FEHLGESCHLAGEN!")
            End If
        End If
        'Engine.updateStats()



    End Sub

    Private Sub cbImage_CheckedChanged(sender As Object, e As EventArgs) Handles cbImage.CheckedChanged
        If cbImage.Checked = True Then
            btnSearchImage.Enabled = True
        Else
            btnSearchImage.Enabled = False
            PictureBox1.Image = Nothing
            PictureBox1.BackgroundImage = My.Resources.Dose
        End If
    End Sub

    Private Sub btnSearchImage_Click(sender As Object, e As EventArgs) Handles btnSearchImage.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Bilddateien|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff|Alle Dateien|*.*"
        If ofd.ShowDialog = DialogResult.OK Then
            PictureBox1.BackgroundImage = Nothing
            PictureBox1.Image = Nothing
            Dim filePath As String = ofd.FileName
            PictureBox1.Image = Image.FromFile(filePath)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class