Imports Getränke_Automat_V2.FormMainMenu

Public Class FormArtikelManager
    Dim AM As New EngineArtikelManager
    Dim CM As New ConnectionManger
    Dim actProdukt As New Globals.Produkt

    Dim ctrlList As New List(Of Control)


    Dim mouseOffset As Point

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, Panel9.MouseDown, label_text_am_panelbar.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, Panel9.MouseMove, label_text_am_panelbar.MouseMove

        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub


    Private Sub FormArtikelManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In PanelBackground.Controls
            ctrlList.Add(ctrl)
            Logger.WriteLine($".Load | {ctrl.Name} in ctrlList hinzugefügt")
        Next

        Engine.FillControlsFromDB(Globals.queryAllProducts,, 0, cbSearchID)
        Engine.FillControlsFromDB(Globals.queryAllProducts,, 1, cbSearchBEZ)
    End Sub

    Private Sub cbSearchBEZ_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbSearchBEZ.SelectedValueChanged
        Dim img As Image
        With actProdukt
            Logger.WriteLine($"cbSearchBez_SelectedValueChanged | Produkt ID: {actProdukt.ID.ToString} | Produkt Bez: {actProdukt.Bezeichnung}")
            tbPreis.Text = .Preis.ToString
            tbALK.Text = .Alkoholgehalt.ToString
            tbBez.Text = .Bezeichnung
            tbID.Text = .ID.ToString
            tbInhalt.Text = .Volumen.ToString

            img = CM.GetImageFromDatabase(.ID)
            If img IsNot Nothing Then
                PictureBoxAM.BackgroundImage = Nothing
                PictureBoxAM.Image = img
                PictureBoxAM.SizeMode = PictureBoxSizeMode.StretchImage
                Exit Sub
            End If

        End With

    End Sub

    Private Sub cbSearchID_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbSearchID.SelectedValueChanged
        Dim img As Image
        With actProdukt
            Logger.WriteLine($"cbSearchID_SelectedValueChanged | Produkt ID: {actProdukt.ID.ToString} | Produkt Bez: {actProdukt.Bezeichnung}")
            tbPreis.Text = .Preis.ToString
            tbALK.Text = .Alkoholgehalt.ToString
            tbBez.Text = .Bezeichnung
            tbID.Text = .ID.ToString
            tbInhalt.Text = .Volumen.ToString
            img = CM.GetImageFromDatabase(.ID)
            If img IsNot Nothing Then
                PictureBoxAM.BackgroundImage = Nothing
                PictureBoxAM.Image = img
                PictureBoxAM.SizeMode = PictureBoxSizeMode.StretchImage
                Exit Sub
            End If
            ' PictureBoxAM.Image = Nothing
            'PictureBoxAM.BackgroundImage = My.Resources.Dose
        End With

    End Sub

    Private Sub cbSearch_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbSearchID.SelectionChangeCommitted, cbSearchBEZ.SelectionChangeCommitted

        Select Case (sender.name)
            Case "cbSearchID"
                Logger.WriteLine("-----------Suche nach ID-----------.")
                Dim ID As Integer
                ID = Int(cbSearchID.SelectedItem)
                actProdukt = CM.getProduktByID(ID)
                Logger.WriteLine($"{cbSearchID.Name.ToString} | Produkt ID: {actProdukt.ID.ToString} | Produkt Bez: {actProdukt.Bezeichnung}")
                Exit Select

            Case "cbSearchBEZ"
                Logger.WriteLine("-----------Suche nach Bezeichnung-----------")
                Dim ID As Integer
                Dim img As Image
                ID = CM.GetProduktIDByName(cbSearchBEZ.SelectedItem)
                actProdukt = CM.getProduktByID(ID)
                Logger.WriteLine($"{cbSearchID.Name.ToString} | Produkt ID: {actProdukt.ID.ToString} | Produkt Bez: {actProdukt.Bezeichnung}")
                Exit Select

            Case Else
                Logger.WriteLine("cbSearch_SelectionChangeComitted | Fehler, konnte keine Checkbox zugeordnet werden")
                Exit Select
        End Select



    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Select Case CheckBox2.CheckState
            Case CheckState.Checked
                btnSaveArticle.Visible = True
                btnCancel.Visible = True
            Case CheckState.Unchecked
                btnSaveArticle.Visible = False
                btnCancel.Visible = False
        End Select
    End Sub
End Class