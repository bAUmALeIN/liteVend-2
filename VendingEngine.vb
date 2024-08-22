Module VendingEngine
    Public Const MengenOrderText = "Bitte geben Sie die gewünschte Menge ein."

    ' Umwandlung der Struktur in eine Klasse
    Public Class basketEintrag
        Public Property OrderNum As Integer
        Public Property EP As Double
        Public Property Menge As Integer
        Public Property gesPreis As Double
        Public Property ID As Integer
    End Class

    Dim CM As New ConnectionManger
    Public Basket As New List(Of basketEintrag)
    Private gesamtpreis As Double
    Private bereitsEingeworfenerBetrag As Double

    Dim gesAnzFlaschenBasket As Integer = 0

    Public Function processEingabe(panelCtrls As Control.ControlCollection, InputBox As TextBox, OutputBox As RichTextBox, flp As FlowLayoutPanel, flpNum As FlowLayoutPanel) As Boolean
        Try
            If My.Settings.isFirstOrder OrElse (My.Settings.MultiVend AndAlso Not My.Settings.needMenge) Then
                ' Kein Mengenvorgang
                Dim ID = InputBox.Text.TrimStart("0")
                Logger.WriteLine("VendingEngine.ProccesEingabe| ID Trimmed: " & ID)

                Dim produktGefunden As Boolean = False
                For Each ctrl In panelCtrls
                    If TypeOf ctrl Is Button AndAlso ctrl.Name = "btnItem" & ID Then
                        ctrl.ForeColor = Color.Red
                        Dim preis As Double = CM.GetProduktPreisByID(ID)
                        Logger.WriteLine("VendingEngine.ProccesEingabe| ermittelter Preis: " & preis)

                        Dim be As New basketEintrag With {
                            .EP = preis,
                            .OrderNum = My.Settings.OrderNum,
                            .ID = ID,
                            .Menge = 1,
                            .gesPreis = preis
                        }
                        Basket.Add(be)

                        Logger.WriteLine("VendingEngine.ProccesEingabe| Eintrag:" & Basket.Count)
                        My.Settings.ActiveMengeID = Convert.ToInt32(ID)
                        Logger.WriteLine("VendingEngine.ProccesEingabe| ActiveMengenID gesetzt: " & My.Settings.ActiveMengeID)
                        Logger.WriteLine("VendingEngine.ProccesEingabe| OrderNum BasketEintrag zugewiesen: " & My.Settings.OrderNum)

                        ' Aktualisiere den Gesamtpreis basierend auf dem Warenkorb
                        gesamtpreis += be.gesPreis

                        Logger.WriteLine($"VendingEngine.ProccesEingabe| neu: Gesamtpreis = {gesamtpreis}")

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
                If Not Integer.TryParse(Menge, intMenge) OrElse intMenge <= 0 Then
                    Logger.WriteLine("VendingEngine.ProccesEingabe| Ungültige Menge")
                    Return False
                End If

                Dim ID As Integer = 0
                gesamtpreis = 0
                InputBox.Text = ""
                Logger.WriteLine("VendingEngine.processEingabe -> Mengenvorgang. Gelesene Menge: " & Menge)

                For i As Integer = 0 To Basket.Count - 1
                    If Basket(i).OrderNum = My.Settings.OrderNum - 1 Then
                        Logger.WriteLine("VendingEngine.processEingabe -> Mengenvorgang. Suche OrderNum: " & Basket(i).OrderNum)

                        ' Aktualisierung des vorhandenen Eintrags
                        Basket(i).Menge = intMenge
                        Basket(i).gesPreis = intMenge * Basket(i).EP
                        ID = Basket(i).ID

                        Logger.WriteLine("VendingEngine.processEingabe -> Mengenvorgang. Gefunden OrderNum: " & Basket(i).OrderNum & " | GesPreis: " & Basket(i).gesPreis.ToString)

                        ' Update gesamtpreis basierend auf allen Artikeln im Basket
                        gesamtpreis = Basket.Sum(Function(be) be.gesPreis)

                        Exit For ' Schleife abbrechen, sobald der Eintrag gefunden und aktualisiert wurde
                    End If
                Next

                OutputBox.AppendText(vbNewLine & "-----------------------------------")
                OutputBox.AppendText(vbNewLine & "Ausgewähltes Produkt: " & ID & vbNewLine)
                OutputBox.AppendText("Eingegebene Menge: " & Menge & vbNewLine)
                OutputBox.AppendText("Ges. Preis: " & gesamtpreis.ToString & "€")
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
                    Logger.WriteLine($"VendingEngine.ProccesEingabe| be.OrderNum: {be.OrderNum} | be.gesPreis: {be.gesPreis} | be.menge: {be.Menge}")
                Next

                OutputBox.Text = ""
                OutputBox.AppendText("-----------------------------------" & vbNewLine)
                OutputBox.AppendText("Zahlung gestartet. Bitte Münzbetrag auswählen" & vbNewLine)
                OutputBox.AppendText($"GESAMT PREIS: {gesamtpreis.ToString}€" & vbNewLine)
                My.Settings.BasketGesPreis = gesamtpreis

                My.Settings.Save()
                flpNum.Enabled = True
                flp.Visible = True
                My.Settings.ActiveMengeID = 0
                My.Settings.needMenge = False
                My.Settings.Save()
            End If

            Return False

        Catch ex As Exception
            Logger.WriteLine("VendingEngine.processEingabe| Fehler: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ProcessZahlung(selectedAmount As Double, OutputBox As RichTextBox) As Boolean
        Try
            Dim restbetrag As Double = gesamtpreis - bereitsEingeworfenerBetrag
            bereitsEingeworfenerBetrag += selectedAmount
            restbetrag = gesamtpreis - bereitsEingeworfenerBetrag

            If restbetrag <= 0 Then
                ' Zahlung war erfolgreich
                Dim wechselgeld As Double = -restbetrag
                OutputBox.AppendText(vbNewLine & "-----------------------------------")
                OutputBox.AppendText(vbNewLine & $"Zahlung erfolgreich! Wechselgeld: {wechselgeld.ToString("F2")}€")
                OutputBox.ScrollToCaret()

                ' Update der Statistiken
                Dim stats As Globals.Stats = CM.GetStatsFromDB
                Logger.WriteLine($"ProcessZahlung| alter GesamtUmsatz = {stats.GesUmsatz}")
                Logger.WriteLine($"ProcessZahlung| Basket Preis: {gesamtpreis.ToString}")

                stats.AnzVG += 1
                stats.GesUmsatz += gesamtpreis

                For Each eintrag As basketEintrag In Basket
                    gesAnzFlaschenBasket += eintrag.Menge
                Next

                stats.anzVerkFalschen += gesAnzFlaschenBasket
                CM.UpdateStatsDB(stats)

                ' Warenkorb und Beträge zurücksetzen
                Basket.Clear()
                bereitsEingeworfenerBetrag = 0
                gesamtpreis = 0
                gesAnzFlaschenBasket = 0

                Return True
            Else
                ' Noch Restbetrag offen
                OutputBox.AppendText(vbNewLine & "-----------------------------------")
                OutputBox.AppendText(vbNewLine & $"Restbetrag: {restbetrag.ToString("F2")}€")
                OutputBox.ScrollToCaret()
                Return False
            End If
        Catch ex As Exception
            Logger.WriteLine("VendingEngine.ProcessZahlung| Fehler: " & ex.Message)
            Return False
        End Try
    End Function
End Module
