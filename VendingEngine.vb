Module VendingEngine
#Const BASKET_MAX = 30
    Public Const MengenOrderText = "Bitte geben Sie die gewünschte Menge ein."
    Public Structure basketEintrag
        Public OrderNum As Integer
        Public EP As Double
        Public Menge As Integer
        Public gesPreis As Double
        Public ID As Integer
    End Structure

    Dim CM As New ConnectionManger
    Public Basket As New List(Of basketEintrag)
    Private gesamtpreis As Double
    Private bereitsEingeworfenerBetrag As Double

    Dim gesAnzFlaschenBasket As Integer = 0

    Public Function processEingabe(panelCtrls As Control.ControlCollection, InputBox As TextBox, OutputBox As RichTextBox, flp As FlowLayoutPanel, flpNum As FlowLayoutPanel) As Boolean
        If My.Settings.isFirstOrder OrElse (My.Settings.MultiVend AndAlso Not My.Settings.needMenge) Then
            ' Kein Mengenvorgang
            Dim ID = InputBox.Text.TrimStart("0")
            Logger.WriteLine("VendingEngine.ProccesEingabe| ID Trimmed: " & ID)

            Dim produktGefunden As Boolean = False
            For Each ctrl In panelCtrls
                If TypeOf ctrl Is Button AndAlso ctrl.Name = "btnItem" & ID Then
                    ctrl.ForeColor = Color.Red
                    Dim preis As Double = CM.GetProduktPreisByID(ID)
                    Logger.WriteLine("VendingEngine.ProccesEingabe|ermittelter Preis: " & preis)

                    Dim be As New basketEintrag With {
                    .EP = preis,
                    .OrderNum = My.Settings.OrderNum,
                    .ID = ID,
                    .Menge = 1,
                    .gesPreis = preis
                }
                    Basket.Add(be)

                    Logger.WriteLine("VendingEngine.ProccesEingabe| Anzahl Basket:" & Basket.Count)
                    My.Settings.ActiveMengeID = Convert.ToInt32(ID)
                    Logger.WriteLine("VendingEngine.ProccesEingabe| ActiveMengenID gesetzt: " & My.Settings.ActiveMengeID)
                    Logger.WriteLine("VendingEngine.ProccesEingabe| OrderNum BasketEintrag zugewiesen: " & My.Settings.OrderNum)

                    My.Settings.OrderNum += 1
                    My.Settings.Save()

                    InputBox.Text = ""
                    OutputBox.AppendText(vbNewLine & "Ausgewähltes Produkt: " & ID)
                    OutputBox.AppendText(vbNewLine & "-------------------------------------")
                    OutputBox.AppendText(MengenOrderText)
                    OutputBox.ScrollToCaret()

                    My.Settings.isFirstOrder = False
                    If My.Settings.MultiVend Then
                        My.Settings.needMenge = True
                    End If
                    My.Settings.Save()

                    produktGefunden = True
                    Return True
                End If
            Next

            If Not produktGefunden Then
                ' Produkt nicht gefunden
                Logger.WriteLine("VendingEngine.ProccesEingabe| Produkt nicht gefunden")
            End If
        Else
            ' Mengenvorgang
            If InputBox.TextLength = 0 Then
                Logger.WriteLine("VendingEngine.ProccesEingabe| InputBox Leer")
                Return False
            End If

            Dim Menge As String = InputBox.Text
            Dim intMenge As Integer
            If Not Integer.TryParse(Menge, intMenge) Then
                Logger.WriteLine("VendingEngine.ProccesEingabe| Ungültige Menge")
                Return False
            End If

            Dim ID As Integer = 0
            gesamtpreis = 0
            InputBox.Text = ""
            Logger.WriteLine("VendingEngine.processEingabe -> Mengenvorgang.geleseneMenge: " & Menge)

            For i As Integer = 0 To Basket.Count - 1
                If Basket(i).OrderNum = My.Settings.OrderNum - 1 Then
                    Logger.WriteLine("VendingEngine.processEingabe -> Mengenvorgang.SucheOrderNum: " & Basket(i).OrderNum)
                    Basket(i) = New basketEintrag With {
                    .EP = Basket(i).EP,
                    .OrderNum = Basket(i).OrderNum,
                    .ID = Basket(i).ID,
                    .Menge = intMenge,
                    .gesPreis = intMenge * Basket(i).EP
                }
                    Logger.WriteLine("VendingEngine.processEingabe -> Mengenvorgang.gefundenOrderNum: " & Basket(i).OrderNum & " | gesPreis: " & Basket(i).gesPreis)
                    ID = Basket(i).ID
                    gesamtpreis = Basket(i).gesPreis
                End If
            Next

            OutputBox.AppendText(vbNewLine & "-----------------------------------")
            OutputBox.AppendText(vbNewLine & "Ausgewähltes Produkt: " & ID & vbNewLine)
            OutputBox.AppendText("Eingegebene Menge: " & Menge & vbNewLine)
            OutputBox.AppendText("Ges. Preis: " & gesamtpreis.ToString("F2") & "€")
            OutputBox.ScrollToCaret()

            If My.Settings.MultiVend Then
                Logger.WriteLine("VendingEngine.ProccesEingabe| MULTIVEND 1")
                My.Settings.ActiveMengeID = 0
                My.Settings.needMenge = False
                My.Settings.Save()
                Return True
            End If

            Logger.WriteLine("VendingEngine.ProccesEingabe| MULTIVEND 0")
            Logger.WriteLine("VendingEngine.ProccesEingabe| Start Zahlung")
            Globals.Zahlung = True
            bereitsEingeworfenerBetrag = 0

            For Each be As basketEintrag In Basket
                Logger.WriteLine($"VendingEngine.ProccesEingabe| Basket Eintrag: {be.OrderNum} | Basket GesPreis: {be.gesPreis} | Basket Anz. {be.Menge}")
            Next

            OutputBox.Text = ""
            OutputBox.AppendText("-----------------------------------" & vbNewLine)
            OutputBox.AppendText("Zahlung gestartet. Bitte Münzbetrag auswählen" & vbNewLine)
            OutputBox.AppendText($"GESAMT PREIS: {gesamtpreis.ToString("F2")}€" & vbNewLine)
            My.Settings.BasketGesPreis = gesamtpreis
            My.Settings.Save()
            flpNum.Enabled = True
            flp.Visible = True
            My.Settings.ActiveMengeID = 0
            My.Settings.needMenge = False
            My.Settings.Save()
        End If
        Return False
    End Function

    Public Function ProcessZahlung(selectedAmount As Double, OutputBox As RichTextBox) As Boolean
        Dim restbetrag As Double = gesamtpreis - bereitsEingeworfenerBetrag
        bereitsEingeworfenerBetrag += selectedAmount
        restbetrag = gesamtpreis - bereitsEingeworfenerBetrag

        If restbetrag <= 0 Then
            ' Zahlung war erfolgreich
            Dim wechselgeld As Double = -restbetrag
            OutputBox.AppendText(vbNewLine & "-----------------------------------")
            OutputBox.AppendText(vbNewLine & $"Zahlung erfolgreich! Wechselgeld: {wechselgeld.ToString("F2")}€")
            OutputBox.ScrollToCaret()
            Dim stats As Globals.Stats = CM.GetStatsFromDB
            Logger.WriteLine($"ProcessZahlung| alter GesamtUmsatz = {stats.GesUmsatz}")
            Logger.WriteLine($"ProcessZahlung| Basket Preis:{My.Settings.BasketGesPreis.ToString}")
            stats.AnzVG += 1
            stats.GesUmsatz = stats.GesUmsatz + My.Settings.BasketGesPreis

            For Each eintrag As basketEintrag In Basket
                gesAnzFlaschenBasket += eintrag.Menge

            Next
            stats.anzVerkFalschen = stats.anzVerkFalschen + gesAnzFlaschenBasket
            CM.UpdateStatsDB(stats)
            My.Settings.BasketGesPreis = 0
            My.Settings.Save()
            Basket.Clear()
            bereitsEingeworfenerBetrag = 0
            gesamtpreis = 0
            gesAnzFlaschenBasket = 0





            Return True
        Else

            OutputBox.AppendText(vbNewLine & "-----------------------------------")
            OutputBox.AppendText(vbNewLine & $"Restbetrag: {restbetrag.ToString("F2")}€")
            OutputBox.ScrollToCaret()
            Return False
        End If
    End Function

End Module
