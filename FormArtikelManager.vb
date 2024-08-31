Imports System.Runtime.InteropServices
Imports Getränke_Automat_V2.FormMainMenu

Public Class FormArtikelManager
    Dim AM As New EngineArtikelManager
    Dim CM As New ConnectionManger
    Dim actProdukt As New Globals.Produkt
    Dim editProduct As Boolean = False
    Dim newProduct As Boolean = False

    Public Shared ctrlList As New List(Of Control)
    Public Shared ctrlList_TB_newArticle As New List(Of Control)

    Dim mouseOffset As Point

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, Panel9.MouseDown, label_text_am_panelbar.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
        Me.TopMost = True
        Me.TopLevel = True
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
            checkCtrlForList(ctrl)
        Next
        Logger.WriteLine($"ALL Ctrl.Count: {ctrlList.Count.ToString} ")
        Logger.WriteLine($"CtrlNewArticle.Count: {ctrlList_TB_newArticle.Count.ToString} ")


        Engine.FillControlsFromDB(Globals.queryAllProducts,, 0, cbSearchID)
        Engine.FillControlsFromDB(Globals.queryAllProducts,, 1, cbSearchBEZ)
    End Sub

    Private Sub cbSearchBEZ_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbSearchBEZ.SelectedValueChanged
        cbSearchID.Text = ""
        Dim img As Image
        With actProdukt
            Logger.WriteLine($"cbSearchBez_SelectedValueChanged | Produkt ID: {actProdukt.ID.ToString} | Produkt Bez: {actProdukt.Bezeichnung} | Produkt Lager: {actProdukt.Lager} | Produkt LagerOrt: {actProdukt.LagerOrt} | Produkt Bestand: {actProdukt.Bestand} | Produkt mindbestand: {actProdukt.mindBestand}")
            tbPreis.Text = .Preis.ToString
            tbALK.Text = .Alkoholgehalt.ToString
            tbBez.Text = .Bezeichnung
            tbID.Text = .ID.ToString
            tbInhalt.Text = .Volumen.ToString
            tbBestand.Text = .Bestand.ToString
            tbMindBestand.Text = .mindBestand.ToString
            cbLager.Text = .Lager.ToString
            cbLagerOrt.Text = .LagerOrt.ToString
            tbPLU.Text = .PLU.ToString

            img = CM.GetImageFromDatabase(.ID)
            If img IsNot Nothing Then
                PictureBoxAM.BackgroundImage = Nothing
                PictureBoxAM.Image = img
                PictureBoxAM.SizeMode = PictureBoxSizeMode.StretchImage

            End If

        End With

    End Sub

    Private Sub cbSearchID_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbSearchID.SelectedValueChanged
        cbSearchBEZ.Text = ""
        Dim img As Image
        With actProdukt
            Logger.WriteLine($"cbSearchID_SelectedValueChanged | Produkt ID: {actProdukt.ID.ToString} | Produkt Bez: {actProdukt.Bezeichnung}")
            tbPreis.Text = .Preis.ToString
            tbALK.Text = .Alkoholgehalt.ToString
            tbBez.Text = .Bezeichnung
            tbID.Text = .ID.ToString
            tbInhalt.Text = .Volumen.ToString
            tbBestand.Text = .Bestand.ToString
            tbMindBestand.Text = .mindBestand.ToString
            cbLager.Text = .Lager.ToString
            cbLagerOrt.Text = .LagerOrt.ToString
            tbPLU.Text = .PLU.ToString
            img = CM.GetImageFromDatabase(.ID)
            If img IsNot Nothing Then
                PictureBoxAM.BackgroundImage = Nothing
                PictureBoxAM.Image = img
                PictureBoxAM.SizeMode = PictureBoxSizeMode.StretchImage
                Exit Sub
            End If

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

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxEdit.CheckedChanged
        Select Case checkboxEdit.CheckState
            Case CheckState.Checked
                btnSaveArticle.Visible = True
                editProduct = True
                Logger.WriteLine("editProdct = true")
            Case CheckState.Unchecked
                btnSaveArticle.Visible = False
                editProduct = False
                Logger.WriteLine("editProdct = false")

        End Select
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.CheckState = CheckState.Checked) Then
            newProduct = True
            Logger.WriteLine("newProdct = true")
            cbSearchBEZ.SelectedItem = Nothing
            cbSearchID.SelectedItem = Nothing
            cbSearchBEZ.Enabled = False
            cbSearchID.Enabled = False


            labelText_Suche.Enabled = False
            labelTextSucheID.Enabled = False
            labelTextSucheBez.Enabled = False
            For Each ctrl As Control In ctrlList_TB_newArticle
                If TypeOf ctrl Is TextBox Then
                    ctrl.Enabled = True
                    ctrl.Text = ""
                End If
                If TypeOf ctrl Is ComboBox Then
                    ctrl.Enabled = True
                    ctrl.ResetText()
                End If
                If TypeOf ctrl Is Label Then
                    ctrl.Visible = True
                End If
                If TypeOf ctrl Is CheckBox Then
                    If ctrl.Name = checkboxActivatePL.Name Then
                        ctrl.Enabled = True
                    End If
                End If
                If TypeOf ctrl Is Button Then
                    If ctrl.Name = "btnSaveArticle" Then
                        ctrl.Visible = True

                    End If

                End If
            Next

            tbID.Text = CM.GetNextFreeID.ToString
            PictureBoxAM.Image = Nothing
            Exit Sub
        End If


        newProduct = False
        Logger.WriteLine("newProdct = false")
        For Each ctrl As Control In ctrlList_TB_newArticle
            If TypeOf ctrl Is TextBox Then
                ctrl.Enabled = False
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Enabled = False
                ctrl.ResetText()
            End If
            If TypeOf ctrl Is Label Then
                ctrl.Visible = False
            End If
            If TypeOf ctrl Is CheckBox Then
                If ctrl.Name = checkboxActivatePL.Name Then
                    ctrl.Enabled = False
                End If
            End If
            If TypeOf ctrl Is Button Then
                If ctrl.Name = "btnSaveArticle" Then
                    ctrl.Visible = False

                End If

            End If
        Next

        cbSearchBEZ.Enabled = True
        cbSearchID.Enabled = True
        labelText_Suche.Enabled = True
        labelTextSucheID.Enabled = True
        labelTextSucheBez.Enabled = True

        labelTextNeu1.Visible = False
        labelTextNeu2.Visible = False
        labelTextNeu3.Visible = False
        labelTextNeu5.Visible = False
        labelTextNeu6.Visible = False
        labelTextNeu7.Visible = False
        tbID.Text = ""
    End Sub

    Private Sub checkCtrlForList(ctrl As Control)
        Select Case (ctrl.Name)
            Case "tbBez"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case "tbALK"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case "tbInhalt"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case "tbPLU"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case "tbPreis"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case "cbLager"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case "cbLagerOrt"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case $"labelTextNeu1"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case $"labelTextNeu2"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case $"labelTextNeu3"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case $"labelTextNeu4"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case $"labelTextNeu5"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case $"labelTextNeu6"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case $"labelTextNeu7"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case $"checkboxActivatePL"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case $"btnSaveArticle"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case $"tbMindBestand"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case $"tbBestand"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case $"tbID"
                ctrlList_TB_newArticle.Add(ctrl)
                Logger.WriteLine($"checkCtrlForList | {ctrl.Name} in ctrlList_TB_newArticle hinzugefügt")
                Exit Select
            Case Else
        End Select

    End Sub

    Private Sub btnSaveArticle_Click(sender As Object, e As EventArgs) Handles btnSaveArticle.Click

        If newProduct Then
            Dim nullpreis = 0.00
            Dim newProdukt As New Globals.Produkt
            Dim plActive As Boolean


            Try
                Dim preis = Convert.ToDouble(tbPreis.Text)
                Dim volumen = Convert.ToDouble(tbInhalt.Text)
                Dim alk = Convert.ToDouble(tbALK.Text)
                newProdukt.ID = CM.GetNextFreeID
                newProdukt.Alkoholgehalt = alk
                newProdukt.Bestand = Int(tbBestand.Text)
                newProdukt.mindBestand = Int(tbMindBestand.Text)
                newProdukt.Bezeichnung = tbBez.Text
                newProdukt.Lager = Int(cbLager.Text)
                newProdukt.LagerOrt = Int(cbLagerOrt.Text)
                newProdukt.PLU = Int(tbPLU.Text)
                newProdukt.Volumen = volumen
                newProdukt.Preis = preis


                If checkboxActivatePL.CheckState = CheckState.Checked Then
                    newProdukt.Preis_PL1 = Convert.ToDouble(tbPL1.Text)
                    newProdukt.Preis_PL2 = Convert.ToDouble(tbPL2.Text)
                    newProdukt.Preis_PL3 = Convert.ToDouble(tbPL3.Text)
                    newProdukt.Preis_PL4 = Convert.ToDouble(tbPL4.Text)
                    plActive = True
                Else
                    newProdukt.Preis_PL1 = Convert.ToDouble(nullpreis)
                    newProdukt.Preis_PL2 = Convert.ToDouble(nullpreis)
                    newProdukt.Preis_PL3 = Convert.ToDouble(nullpreis)
                    newProdukt.Preis_PL4 = Convert.ToDouble(nullpreis)
                    plActive = False
                End If
                If checkboxSetPicture.CheckState = CheckState.Checked Then
                    newProdukt.Image = PictureBoxAM.Image

                End If

                Logger.printProdukt(newProdukt)



                If newProdukt IsNot Nothing Then
                    If CM.InsertProduktAsProdukt(newProdukt, plActive) Then
                        Logger.WriteLine($"FormArtikelManager| Eintrag erstellt | ID:{newProdukt.ID.ToString}|ALK:{newProdukt.Alkoholgehalt.ToString}|Bestand: {newProdukt.Bestand.ToString}|
                        mindBestand: {newProdukt.mindBestand.ToString}|Bez: {newProdukt.Bezeichnung.ToString}|Lager: {newProdukt.Lager.ToString}|LagerOrt: {newProdukt.LagerOrt.ToString}|PLU: {newProdukt.PLU.ToString}|
                        Volumen: {newProdukt.Volumen.ToString}|Preis: {newProdukt.Preis.ToString}| PL1: {newProdukt.Preis_PL1.ToString}| PL2: {newProdukt.Preis_PL2.ToString} PL13: {newProdukt.Preis_PL3.ToString} | PL4: {newProdukt.Preis_PL4.ToString}")

                        clearAfterInsert()
                        Exit Sub
                    End If

                End If



            Catch ex As Exception
                Logger.WriteLine(ex.Message)
            End Try

        Else
            'update
            Logger.WriteLine("Update Produkt...")

        End If




    End Sub

    Private Sub clearAfterInsert()
        For Each ctrl As Control In ctrlList_TB_newArticle
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then
                    cb.CheckState = CheckState.Unchecked
                End If
            End If
        Next
        Engine.FillControlsFromDB(Globals.queryAllProducts,, 0, cbSearchID)
        Engine.FillControlsFromDB(Globals.queryAllProducts,, 1, cbSearchBEZ)
    End Sub


End Class