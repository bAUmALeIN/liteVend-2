Imports System.Net.WebRequestMethods

Public Class FormVending
    Dim CM As New ConnectionManger
    Dim WelcomeText As String = "Bitte wählen Sie ein Produkt aus." & vbNewLine & "Durch eingabe der Produkt ID."
    Dim mouseOffset As Point
    Dim checkedCB As Boolean = False
    Dim BlinkOn As Boolean = False
    Dim Abort = False
    Dim lastText As String
    Dim durchlauf As Integer = 0




    '############################################### Mause Move/Down #################################################
    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, Panel5.MouseDown, LabelTextMunz.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, Panel5.MouseMove, LabelTextMunz.MouseMove

        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    '#################################################################################################################



    Private Sub FormVending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtfAusgabe.Text = WelcomeText
        CM.PreiseInLabelsSchreiben(PanelProdukte)
        LoadImagesInButtons()
        Logger.WriteLine("Anz. Produkte :" + Globals.ActiveProductIDs.Count.ToString)
        Logger.WriteLine("------------------------------------------------- START VENDING -----------------------------------------------------------")
    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Globals.ActiveProductIDs.Clear()
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '####################################### PRODUKT-BUTTON ###############################################


    Private Sub btnProdukt_Click(sender As Object, e As EventArgs) Handles btnItem1.Click, btnItem9.Click, btnItem8.Click, btnItem7.Click, btnItem6.Click, btnItem5.Click, btnItem4.Click, btnItem30.Click, btnItem3.Click, btnItem29.Click, btnItem28.Click, btnItem27.Click, btnItem26.Click, btnItem25.Click, btnItem24.Click, btnItem23.Click, btnItem22.Click, btnItem21.Click, btnItem20.Click, btnItem2.Click, btnItem19.Click, btnItem18.Click, btnItem17.Click, btnItem16.Click, btnItem15.Click, btnItem14.Click, btnItem13.Click, btnItem12.Click, btnItem11.Click, btnItem10.Click
        lastText = rtfAusgabe.Text
        Dim clickedbtn As Button = TryCast(sender, Button)
        If clickedbtn IsNot Nothing Then
            For Each btn As Button In Globals.ProduktBtnList
                If clickedbtn.Tag.ToString() = btn.Tag.ToString Then
                    Logger.WriteLine($" Produkt-Button mit Tag gefunden: {btn.Name}")
                    rtfAusgabe.Text = Nothing
                    Dim prodausgabe As FormMainMenu.Produkt = CM.getProduktByID(Int(btn.Tag))
                    If prodausgabe.Preis <> 0 Then

                        Logger.WriteLine($" Produkt mit Bez.:{prodausgabe.Bezeichnung} gefunden")
                        rtfAusgabe.Text = "--------------------------------------" & vbNewLine & $" --> {prodausgabe.Bezeichnung}" & vbNewLine & $" --> Preis: {prodausgabe.Preis.ToString} €" & vbNewLine & $" --> Volumen: {prodausgabe.Volumen.ToString} Liter" & vbNewLine & $" --> Alkoholgehalt: {prodausgabe.Alkoholgehalt.ToString} %" & vbNewLine & "--------------------------------------"
                        TimerProduktInfo.Enabled = True
                        TimerProduktInfo.Start()
                        Exit Sub
                    End If
                    rtfAusgabe.Text = ""    ' Fehler text
                    ' WAIT
                    rtfAusgabe.Text = lastText
                    Logger.WriteLine("Start Timer Panel Blinken...")
                    Globals.BlinkenPanelFarbe = 1
                    TimerPanelBlinken.Start()
                End If
            Next
        End If
    End Sub



    '########################################## NUMPAD ####################################################

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        VendingEngine.processEingabe(PanelProdukte.Controls, tbEingabe, rtfAusgabe, FlowLayoutPanelCoinValues, FlowLayoutPanelNumBlock)
    End Sub

    Private Sub btnNUM0_Click(sender As Object, e As EventArgs) Handles btnNUM0.Click
        tbEingabe.AppendText(0)
    End Sub

    Private Sub btnNUM1_Click(sender As Object, e As EventArgs) Handles btnNUM1.Click
        tbEingabe.AppendText(1)
    End Sub

    Private Sub btnNUM2_Click(sender As Object, e As EventArgs) Handles btnNUM2.Click
        tbEingabe.AppendText(2)
    End Sub

    Private Sub btnNUM3_Click(sender As Object, e As EventArgs) Handles btnNUM3.Click
        tbEingabe.AppendText(3)
    End Sub

    Private Sub btnNUM4_Click(sender As Object, e As EventArgs) Handles btnNUM4.Click
        tbEingabe.AppendText(4)
    End Sub

    Private Sub btnNUM5_Click(sender As Object, e As EventArgs) Handles btnNUM5.Click
        tbEingabe.AppendText(5)
    End Sub

    Private Sub btnNUM6_Click(sender As Object, e As EventArgs) Handles btnNUM6.Click
        tbEingabe.AppendText(6)
    End Sub

    Private Sub btnNUM7_Click(sender As Object, e As EventArgs) Handles btnNUM7.Click
        tbEingabe.AppendText(7)
    End Sub

    Private Sub btnNUM8_Click(sender As Object, e As EventArgs) Handles btnNUM8.Click
        tbEingabe.AppendText(8)
    End Sub

    Private Sub btnNUM9_Click(sender As Object, e As EventArgs) Handles btnNUM9.Click
        tbEingabe.AppendText(9)
    End Sub

    Private Sub btnCLS_Click(sender As Object, e As EventArgs) Handles btnCLS.Click
        tbEingabe.Text = ""
        ' Engine.cleanButtons(PanelProdukte.Controls)
    End Sub

    Private Sub btnClearVG_Click(sender As Object, e As EventArgs) Handles btnClearVG.Click
        Logger.WriteLine("ButtonClearVG: Start clearing Vorgang")
        TimerCBCoins.Enabled = False
        BlinkCoinInsert.Enabled = False
        PanelCoinInsert.BackColor = Color.Silver
        cbMultiVend.Checked = False
        My.Settings.ActiveMengeID = 0
        My.Settings.BasketGesPreis = 0
        My.Settings.MultiVend = False
        My.Settings.OrderNum = 1
        My.Settings.needMenge = False
        My.Settings.isFirstOrder = True
        My.Settings.Save()
        rtfAusgabe.Text = WelcomeText
        FlowLayoutPanelNumBlock.Enabled = True
        Basket.Clear()

        If FlowLayoutPanelCoinValues.Visible Then

            Abort = True
            AbortTimer.Enabled = True
            AbortTimer.Start()
            Engine.cleanButtons(PanelProdukte.Controls)
            For Each ctrl As Control In FlowLayoutPanelCoinValues.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim cb As CheckBox = TryCast(ctrl, CheckBox)
                    cb.CheckState = False
                End If

            Next
            FlowLayoutPanelCoinValues.Visible = False
            Exit Sub
        Else
            TimerPanelBlinken.Enabled = True
            TimerPanelBlinken.Start()
        End If
        Engine.cleanButtons(PanelProdukte.Controls)
        FlowLayoutPanelCoinValues.Visible = False
        BlinkOn = False

    End Sub

    '################################### COMBOBOXEN MÜNZEN #############################################
    Private Sub cb20Cent_CheckedChanged(sender As Object, e As EventArgs) Handles cb20Cent.CheckedChanged
        cb50Cent.Enabled = False
        cb1Euro.Enabled = False
        cb2Euro.Enabled = False
        Logger.WriteLine("Checked 20 Cent")
        Globals.Zahlung = True
        Globals.CoinValue = 0.2
        Logger.WriteLine($"--> Globals | Zahlung:{Globals.Zahlung.ToString} | CoinValue: {Globals.CoinValue.ToString}")
        TimerCBCoins.Enabled = True

    End Sub

    Private Sub cb1Euro_CheckedChanged(sender As Object, e As EventArgs) Handles cb1Euro.CheckedChanged
        cb20Cent.Enabled = False
        cb50Cent.Enabled = False
        cb2Euro.Enabled = False
        Globals.Zahlung = True
        Globals.CoinValue = 1.0
        Logger.WriteLine("Checked 1 Euro")
        Logger.WriteLine($"--> Globals | Zahlung:{Globals.Zahlung.ToString} | CoinValue: {Globals.CoinValue.ToString}")
        TimerCBCoins.Enabled = True

    End Sub

    Private Sub cb50Cent_CheckedChanged(sender As Object, e As EventArgs) Handles cb50Cent.CheckedChanged
        cb20Cent.Enabled = False
        cb1Euro.Enabled = False
        cb2Euro.Enabled = False
        Globals.Zahlung = True
        Globals.CoinValue = 0.5
        Logger.WriteLine("Checked 50 Cent")
        Logger.WriteLine($"--> Globals | Zahlung:{Globals.Zahlung.ToString} | CoinValue: {Globals.CoinValue.ToString}")
        TimerCBCoins.Enabled = True

    End Sub

    Private Sub cb2Euro_CheckedChanged(sender As Object, e As EventArgs) Handles cb2Euro.CheckedChanged
        cb20Cent.Enabled = False
        cb1Euro.Enabled = False
        cb50Cent.Enabled = False
        Globals.Zahlung = True
        Globals.CoinValue = 2.0
        Logger.WriteLine("Checked 2 Euro")
        Logger.WriteLine($"--> Globals | Zahlung:{Globals.Zahlung.ToString} | CoinValue: {Globals.CoinValue.ToString}")
        TimerCBCoins.Enabled = True

    End Sub
    '######################################## TIMER ####################################################
    Private Sub TimerCBCoins_Tick(sender As Object, e As EventArgs) Handles TimerCBCoins.Tick
        Dim cblist As List(Of CheckBox)
        For Each ctrl In FlowLayoutPanelCoinValues.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                If cb.Checked Then
                    If checkedCB = True Then
                        Exit Sub
                    End If
                    checkedCB = True
                    BlinkCoinInsert.Enabled = True
                    BlinkCoinInsert.Start()
                    Exit Sub
                End If

            End If
        Next
        BlinkCoinInsert.Enabled = False
        cb50Cent.Enabled = True
        cb1Euro.Enabled = True
        cb2Euro.Enabled = True
        cb20Cent.Enabled = True
        TimerCBCoins.Enabled = False
        checkedCB = False
        PanelCoinInsert.BackColor = Color.Silver
        Globals.Zahlung = False
        Globals.CoinValue = 0.00
    End Sub

    Private Sub BlinkCoinInsert_Tick(sender As Object, e As EventArgs) Handles BlinkCoinInsert.Tick
        If BlinkOn = False Then
            PanelCoinInsert.BackColor = Color.GreenYellow
            ' Logger.WriteLine("BlinkCoinInsert: Farbe Grün")
            BlinkOn = True
            Exit Sub
        Else
            PanelCoinInsert.BackColor = Color.Silver
            'Logger.WriteLine("BlinkCoinInsert: Farbe Silber")
            BlinkOn = False
            Exit Sub
        End If
    End Sub

    Private Sub AbortTimer_Tick(sender As Object, e As EventArgs) Handles AbortTimer.Tick
        If Abort Then

            'Logger.WriteLine("ABortTimer: Farbe ROT")
            PanelCoinInsert.BackColor = Color.Red
            Abort = False
            Exit Sub

        End If
        'Logger.WriteLine("ABortTimer: Farbe Silber")
        PanelCoinInsert.BackColor = Color.Silver
        AbortTimer.Enabled = False
        AbortTimer.Stop()
        'Logger.WriteLine("ABortTimer: STOP")
    End Sub


    '####################################### CHECKBOXEN ################################################

    Private Sub cbMultiVend_CheckedChanged(sender As Object, e As EventArgs) Handles cbMultiVend.CheckedChanged
        If cbMultiVend.Checked = True Then
            btnCheckout.Visible = True
            My.Settings.MultiVend = True
            My.Settings.Save()
            Logger.WriteLine("Engine.cbMultiVend_changed: " & My.Settings.MultiVend.ToString)
            Exit Sub
        End If
        btnCheckout.Visible = False
        My.Settings.MultiVend = False
        My.Settings.Save()
        Logger.WriteLine("Engine.cbMultiVend_changed: " & My.Settings.MultiVend.ToString)
    End Sub

    Private Sub TimerProduktInfo_Tick(sender As Object, e As EventArgs) Handles TimerProduktInfo.Tick
        rtfAusgabe.Text = lastText
        TimerProduktInfo.Enabled = False
        TimerProduktInfo.Stop()
    End Sub

    Private Sub TimerPanelBlinken_Tick(sender As Object, e As EventArgs) Handles TimerPanelBlinken.Tick
        'Logger.WriteLine("Start Timer Panel Blinken Farbe...")
        TimerPanelBlinkenFarbe.Enabled = True
        TimerPanelBlinkenFarbe.Start()
    End Sub

    Private Sub TimerPanelBlinkenFarbe_Tick(sender As Object, e As EventArgs) Handles TimerPanelBlinkenFarbe.Tick
        'Logger.WriteLine($"TimerPanelBlinkenFarbe_Tick: BlinkOn: {BlinkOn.ToString} | Durchlauf: {durchlauf.ToString} | ")
        If BlinkOn = False And durchlauf < 2 Then
            Select Case Globals.BlinkenPanelFarbe
                Case 1
                    PanelAusgabeText.BackColor = Color.Red
                    BlinkOn = True
                    durchlauf += 1
                    Exit Sub
                Case 2
                    PanelAusgabeText.BackColor = Color.OrangeRed
                    BlinkOn = True
                    durchlauf += 1
                    Exit Sub
                Case 3
                    PanelAusgabeText.BackColor = Color.Green
                    BlinkOn = True
                    durchlauf += 1
                    Exit Sub
                Case Else
                    PanelAusgabeText.BackColor = Color.Red
                    BlinkOn = True
                    durchlauf += 1
                    Exit Sub
            End Select

        ElseIf BlinkOn = True And durchlauf < 2 Then
            PanelAusgabeText.BackColor = Color.DarkGray
            BlinkOn = False
            durchlauf += 1
            Exit Sub
        End If
        TimerPanelBlinkenFarbe.Stop()
        TimerPanelBlinken.Stop()
        Globals.BlinkenPanelFarbe = 0
        durchlauf = 0
        BlinkOn = False             'Änderung 22:57

    End Sub

    Private Sub btnCoinInsert_Click(sender As Object, e As EventArgs) Handles btnCoinInsert.Click
        Dim selectedAmount As Double = 0

        ' Überprüfen, welche Checkbox ausgewählt ist
        If cb20Cent.Checked Then
            selectedAmount += 0.2
        End If
        If cb50Cent.Checked Then
            selectedAmount += 0.5
        End If
        If cb1Euro.Checked Then
            selectedAmount += 1.0
        End If
        If cb2Euro.Checked Then
            selectedAmount += 2.0
        End If


        If VendingEngine.ProcessZahlung(selectedAmount, rtfAusgabe) Then
            MessageBox.Show("Zahlung erfolgreich!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Globals.Zahlung = False
            btnClearVG_Click(sender, e)


        Else
            'MessageBox.Show("Zahlung fehlgeschlagen. Bitte versuchen Sie es erneut.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        cb20Cent.Checked = False
        cb50Cent.Checked = False
        cb1Euro.Checked = False
        cb2Euro.Checked = False
    End Sub


    Private Sub TimerZahlung_Tick(sender As Object, e As EventArgs) Handles TimerZahlung.Tick
        If Globals.Zahlung Then
            btnCoinInsert.Enabled = True
            Exit Sub
        End If
        btnCoinInsert.Enabled = False
    End Sub


    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If My.Settings.MultiVend Then
            Logger.WriteLine("VendingEngine.btnCheckout_Click: MULTIVEND -> Start Zahlung")

            Dim gesamtpreis As Double = Basket.Sum(Function(be) be.gesPreis)

            rtfAusgabe.Text = ""
            rtfAusgabe.AppendText("-----------------------------------" & vbNewLine)
            rtfAusgabe.AppendText("Zahlung gestartet. Bitte Münzbetrag auswählen" & vbNewLine)

            FlowLayoutPanelNumBlock.Enabled = False
            FlowLayoutPanelCoinValues.Visible = True

            My.Settings.ActiveMengeID = 0
            My.Settings.needMenge = False
            My.Settings.isFirstOrder = True
            My.Settings.Save()


            Globals.Zahlung = True
            Dim gespreis As Double = 0
            For Each be As basketEintrag In Basket
                Logger.WriteLine($"OrderNum: {be.OrderNum} | be.gesPreis: {be.gesPreis} | be.menge: {be.Menge}")
                gespreis *= be.gesPreis

            Next
            My.Settings.BasketGesPreis = gespreis
            My.Settings.Save()
            rtfAusgabe.AppendText($"GESAMT PREIS: {gesamtpreis.ToString}€" & vbNewLine)
        Else
            Logger.WriteLine("VendingEngine.btnCheckout_Click: MULTIVEND not enabled")

        End If
    End Sub

    Private Sub LoadImagesInButtons()
        For Each id As Integer In Globals.ActiveProductIDs
            Logger.WriteLine("LoadImagesInButtons: ID in Globals.ActiveProductIDs : " + id.ToString)
            For Each button As Button In PanelProdukte.Controls.OfType(Of Button)

                If button.Tag.ToString() = id.ToString() Then
                    Logger.WriteLine("LoadImagesInButtons: BTN.TAG:" + button.Tag.ToString() + "| ID:" + id.ToString)
                    Dim img As Image = CM.GetImageFromDatabase(id)

                    If img IsNot Nothing Then
                        ' Bitmap erstellen und skalieren
                        Dim bitmap As New Bitmap(img)
                        Dim newBitmap As New Bitmap(bitmap, button.Width, button.Height)
                        button.Image = newBitmap
                    Else
                        Logger.WriteLine("LoadImagesInButtons: Bild für ID " + id.ToString() + " ist nicht vorhanden.")
                    End If
                End If

            Next

        Next
    End Sub



End Class