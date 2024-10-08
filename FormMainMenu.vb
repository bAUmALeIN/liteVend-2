﻿Imports System.Data.SQLite
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data.Sql

Public Class FormMainMenu






    Dim CM As New ConnectionManger
    Private appDirectory As String = AppDomain.CurrentDomain.BaseDirectory
    Public dbPath As String = Path.Combine(appDirectory, "ProduktDatenbank.db")

    Dim mouseOffset As Point

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, Panel2.MouseDown, labelStatusDB.MouseDown, Label13.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
        Me.TopLevel = True
        Me.TopMost = True
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, Panel2.MouseMove, labelStatusDB.MouseMove, Label13.MouseMove

        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Public Sub FormMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Globals.logging = True) Then
            Logger.Show()

        End If
        Logger.WriteLine("Mainmenu load....")
        If File.Exists(dbPath) Then
            Logger.WriteLine("Datenbank gefunden!")
            labelStatusDB.Text = "OK!"
            labelStatusDB.ForeColor = Color.LightGreen
            Globals.DBpath = dbPath
        Else
            If CM.createDB() Then
                CM.ExecuteQuery(Globals.insertDefaultStatsQuery)
                MsgBox("SQlite Datenbank wurde erstellt.")
                Logger.WriteLine("Datenbank wurde erstellt!")
                labelStatusDB.Text = "OK!"
                labelStatusDB.ForeColor = Color.LightGreen

            Else
                MsgBox("SQlite Datenbank konnte nicht erstellt werden.")
                Logger.WriteLine("Datenbank konnte nicht erstellt werden")
                labelStatusDB.Text = "FEHLER!"
                labelStatusDB.ForeColor = Color.Red
                Exit Sub
            End If
        End If
        'good to go
        Logger.WriteLine("Fülle Statistiken aus der Datanbank....")
        Dim stats As Globals.Stats = CM.GetStatsFromDB()
        With stats
            tbStatsGesUmsatz.Text = .GesUmsatz.ToString
            tbStatsAnzTrans.Text = .AnzVG.ToString
            tbStatsAnzProd.Text = .anzProdukte.ToString
            tbStatsAnzFlaschen.Text = .anzVerkFalschen.ToString
        End With
        tbID.Text = CM.GetNextFreeID().ToString
        Logger.WriteLine("Statistiken erfolgreich abgerufen")

        Dim Img As Image = My.Resources._6220416
        Button1.Image = Engine.ScaleImage(Img, 40, 40)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.TextAlign = ContentAlignment.MiddleRight

        Dim ImgVending As Image = My.Resources.vending_machine_821356__1_
        btnVendingMode.Image = Engine.ScaleImage(ImgVending, 40, 40)
        btnVendingMode.ImageAlign = ContentAlignment.MiddleLeft
        btnVendingMode.TextAlign = ContentAlignment.MiddleRight

        My.Settings.BasketGesPreis = 0


        CM.getNextFreeLagerNumner()

        Engine.FillControlsFromDB(Globals.queryAllProducts,, 0, ComboBoxEditID)
        Engine.cleanAppStats()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnVendingMode_Click(sender As Object, e As EventArgs) Handles btnVendingMode.Click
        Dim Vending As New FormVending
        Vending.TopMost = True
        Vending.StartPosition = FormStartPosition.CenterParent
        Logger.WriteLine("Öffne Vending Mode...")
        If Globals.logging = True Then
            Vending.Show()
        Else
            Vending.ShowDialog()
        End If
    End Sub

    Private Sub btnProduktAnlegen_Click(sender As Object, e As EventArgs)
        Dim addProdukt As New FormAddProdukt
        addProdukt.TopMost = True
        addProdukt.StartPosition = FormStartPosition.CenterParent
        addProdukt.ShowDialog()
    End Sub

    Private Sub btnProduktOverview_Click(sender As Object, e As EventArgs) Handles btnProduktOverview.Click
        Dim ov As New FormOverview
        ov.TopMost = True
        ov.StartPosition = FormStartPosition.CenterParent
        ov.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim Preis As Double = Convert.ToDouble(tbPreis.Text)
        Dim Alk As Double = Convert.ToDouble(tbAlk.Text)
        Dim V As Double = Convert.ToDouble(tbV.Text)
        If cbImage.Checked = False Then
            If CM.InsertProdukt(tbBez.Text, Preis, V, Alk, 0, 0, 0, 0, 0) Then
                Dim anz As Integer = CM.GetProductCount()
                CM.UpdateStatsAnzProd(anz + 1)
                Logger.WriteLine("Produkthinzufügen ok!")
                Dim TBs As New List(Of TextBox)
                For Each tb In PanelAdd.Controls
                    If TypeOf tb Is TextBox Then
                        TBs.Add(tb)
                    End If

                Next
                Engine.CleanTBs(TBs)
            Else
                Logger.WriteLine("Produkthinzufügen FEHLGESCHLAGEN!")
            End If
        Else
            If CM.InsertProdukt(tbBez.Text, Preis, V, Alk, 0, 0, 0, 0, 0) Then
                Dim anz As Integer = CM.GetProductCount()
                CM.UpdateStatsAnzProd(anz + 1)
                CM.SaveImageToDatabase(PictureBoxAdd.Image, CM.GetProduktIDByName(tbBez.Text))
                Logger.WriteLine("Eintrag für Produkt + Bild erfolgreich erstellt!")
                Dim TBs As New List(Of TextBox)
                For Each tb In PanelAdd.Controls
                    If TypeOf tb Is TextBox Then
                        TBs.Add(tb)
                    End If

                Next
                Engine.CleanTBs(TBs)
                cbImage.Checked = False
                PictureBoxAdd.Image = Nothing
                PictureBoxAdd.BackgroundImage = My.Resources.Dose
            Else
                Logger.WriteLine("Produkthinzufügen FEHLGESCHLAGEN!")
            End If
        End If
        CM.UpdateStatsAnzProd(CM.GetProductCount())
        tbID.Text = CM.GetNextFreeID.ToString
        tbStatsAnzProd.Text = CM.GetProductCount().ToString
        Engine.getStats()
        FormMainMenu_Load(sender, e)
    End Sub

    Private Sub ButtonAddImage_Click(sender As Object, e As EventArgs) Handles btnAddAddImage.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Bilddateien|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff|Alle Dateien|*.*"
        If ofd.ShowDialog = DialogResult.OK Then
            PictureBoxAdd.BackgroundImage = Nothing
            PictureBoxAdd.Image = Nothing
            Dim filePath As String = ofd.FileName
            PictureBoxAdd.Image = Image.FromFile(filePath)
            PictureBoxAdd.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub cbImage_CheckedChanged(sender As Object, e As EventArgs) Handles cbImage.CheckedChanged
        If cbImage.Checked = True Then
            btnAddAddImage.Enabled = True
            btnAddAddImage.BackColor = Color.WhiteSmoke
        Else
            btnAddAddImage.Enabled = False
            btnAddAddImage.BackColor = Color.LightGray
            PictureBoxAdd.Image = Nothing
            PictureBoxAdd.BackgroundImage = My.Resources.Dose
        End If
    End Sub


    Private Sub ComboBoxEditID_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxEditID.SelectedValueChanged
        Dim ID As Integer = Convert.ToInt32(ComboBoxEditID.SelectedItem)
        Dim actProdukt As New Globals.Produkt
        Dim img As Image
        actProdukt = CM.getProduktByID(ID)
        Logger.WriteLine("ComboBoxEditID_SelectedValueChanged: ID: " & ID.ToString)
        If actProdukt.Preis = 0.00 Then
            Logger.WriteLine("ComboBoxEditID_SelectedValueChanged: actProdukt.Preis : 0.00")
            Exit Sub
        End If
        With actProdukt
            tbEditBez.Text = .Bezeichnung
            tbEditPreis.Text = .Preis.ToString
            tbEditV.Text = .Volumen.ToString
            tbEditAlk.Text = .Alkoholgehalt.ToString
            img = CM.GetImageFromDatabase(ID)
            Globals.openIDinEdit = ID
            If img IsNot Nothing Then
                PictureBoxEdit.BackgroundImage = Nothing
                PictureBoxEdit.Image = img
                PictureBoxEdit.SizeMode = PictureBoxSizeMode.StretchImage
                Exit Sub
            End If
            PictureBoxEdit.Image = Nothing
            PictureBoxEdit.BackgroundImage = My.Resources.Dose
        End With

    End Sub

    Private Sub checkBoxEdit_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxEdit.CheckedChanged
        If checkBoxEdit.CheckState = CheckState.Checked AndAlso Not ComboBoxEditID.Text = "" Then
            tbEditAlk.Enabled = True
            tbEditBez.Enabled = True
            tbEditPreis.Enabled = True
            tbEditV.Enabled = True
            btnOpenImageEdit.Enabled = True
            btnSaveEdit.Enabled = True
            btnSaveEdit.BackColor = Color.Ivory
            btnOpenImageEdit.BackColor = Color.Ivory
            Exit Sub
        End If
        tbEditAlk.Enabled = False
        tbEditBez.Enabled = False
        tbEditPreis.Enabled = False
        tbEditV.Enabled = False
        btnOpenImageEdit.Enabled = False
        btnSaveEdit.Enabled = False
        btnSaveEdit.BackColor = Color.LightGray
        btnOpenImageEdit.BackColor = Color.LightGray
    End Sub

    Private Sub btnSaveEdit_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        Dim newProdukt As New Globals.Produkt
        Logger.WriteLine("Erstelle Produkt für Update....")
        With newProdukt
            .ID = Globals.openIDinEdit
            .Bezeichnung = tbEditBez.Text
            .Preis = Convert.ToDouble(tbEditPreis.Text)
            .Volumen = Convert.ToDouble(tbEditV.Text)
            .Alkoholgehalt = Convert.ToDouble(tbEditAlk.Text)
        End With
        Logger.WriteLine("Produkt erstellt : " & newProdukt.Bezeichnung & vbNewLine & "ID: " & newProdukt.ID & vbNewLine & "Preis: " & newProdukt.Preis.ToString & vbNewLine & "V: " & newProdukt.Volumen.ToString & vbNewLine & "Alk: " & newProdukt.Alkoholgehalt.ToString)
        If PictureBoxEdit.Image IsNot Nothing Then
            CM.SaveOrUpdateImageInDatabase(PictureBoxEdit.Image, Globals.openIDinEdit)
        End If
        CM.UpdateProdukt(newProdukt)
        checkBoxEdit.CheckState = False

    End Sub

    Private Sub btnOpenImageEdit_Click(sender As Object, e As EventArgs) Handles btnOpenImageEdit.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Bilddateien|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff|Alle Dateien|*.*"
        If ofd.ShowDialog = DialogResult.OK Then
            PictureBoxEdit.BackgroundImage = Nothing
            PictureBoxEdit.Image = Nothing
            Dim filePath As String = ofd.FileName
            PictureBoxEdit.Image = Image.FromFile(filePath)
            PictureBoxEdit.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub TimerCheckTBAdd_Tick(sender As Object, e As EventArgs) Handles TimerCheckTBAdd.Tick
        Dim tblist As New List(Of TextBox)
        For Each ctrl In PanelAdd.Controls
            If TypeOf ctrl Is TextBox Then
                Dim tb As TextBox = DirectCast(ctrl, TextBox)
                tblist.Add(tb)
            End If
        Next
        For Each tb As TextBox In tblist
            If tb.TextLength <= 0 Then
                btnSave.Enabled = False
                btnSave.BackColor = Color.LightGray
                Exit Sub
            End If
        Next
        btnSave.Enabled = True
        btnSave.BackColor = Color.Ivory
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbm As New FormDBManager
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is FormDBManager Then
                frm.TopLevel = True
                frm.TopMost = True
                Exit Sub

            End If
        Next
        dbm.StartPosition = FormStartPosition.CenterScreen
        dbm.Show()
    End Sub





    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.TabIndexChanged, TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 3 Then
            Logger.WriteLine("Fülle Statistiken aus der Datanbank....")
            Dim stats As Globals.Stats = CM.GetStatsFromDB()
            With stats
                tbStatsGesUmsatz.Text = .GesUmsatz.ToString
                tbStatsAnzTrans.Text = .AnzVG.ToString
                tbStatsAnzProd.Text = .anzProdukte.ToString
                tbStatsAnzFlaschen.Text = .anzVerkFalschen.ToString
            End With
        End If
    End Sub

    Private Sub btnShowLog_Click(sender As Object, e As EventArgs) Handles btnShowLog.Click
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is Logger Then
                Return

            End If
        Next
        logger.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If FormArtikelManager.ctrlList IsNot Nothing Then
            FormArtikelManager.ctrlList.Clear()
            Logger.WriteLine("ctrlList | clear")
        End If
        If FormArtikelManager.ctrlList_TB_newArticle IsNot Nothing Then
            FormArtikelManager.ctrlList_TB_newArticle.Clear()
            Logger.WriteLine("ctrlList_TB_newArticle | clear")

        End If
        Dim FAM As New FormArtikelManager
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is FormArtikelManager Then
                Return

            End If
        Next
        FAM.StartPosition = FormStartPosition.CenterScreen
        FAM.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim FLA As New FormLagerverwaltung
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is FormLagerverwaltung Then
                Return

            End If
        Next
        FLA.StartPosition = FormStartPosition.CenterScreen
        FLA.Show()
    End Sub


End Class
