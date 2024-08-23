Imports System.IO
Imports Getränke_Automat_V2.FormMainMenu

Module Engine
    Dim CM As New ConnectionManger


    Public Sub CleanTBs(TBs As List(Of TextBox))
        For Each tb In TBs
            tb.Text = ""
        Next
    End Sub

    Public Function ImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    Public Function ByteArrayToImage(byteArray As Byte()) As Image
        Using ms As New MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    Public Sub getStats()

        Dim stats As Globals.Stats = CM.GetStatsFromDB()
        With stats
            FormMainMenu.tbStatsGesUmsatz.Text = .GesUmsatz.ToString
            FormMainMenu.tbStatsAnzTrans.Text = .AnzVG.ToString
            FormMainMenu.tbStatsAnzProd.Text = .anzProdukte.ToString
            FormMainMenu.tbStatsAnzFlaschen.Text = .anzVerkFalschen.ToString
        End With



    End Sub

    Public Sub cleanButtons(pctrl As Panel.ControlCollection)
        For Each ctrl As Control In pctrl
            If TypeOf ctrl Is Button Then
                '  Dim btn As Button = CType(ctrl, Button)                          Nicht nötig aber schöner :D
                ctrl.ForeColor = Color.Black

            End If

        Next
    End Sub

    Public Sub cleanAppStats()
        My.Settings.OrderNum = 1
        My.Settings.ActiveMengeID = 0
        My.Settings.MultiVend = False
        My.Settings.isFirstOrder = True
        My.Settings.Save()
        Logger.WriteLine("Engine.cleanAppStats: Vending Parameter RESET")
    End Sub

    Public Function FillControlsFromDB(query As String, Optional produktID As Integer = -1, Optional paraCB As Integer = -1, Optional cb As ComboBox = Nothing, Optional paraTextBox As Integer = -1, Optional tb As TextBox = Nothing, Optional InputStringTextBox As String = Nothing, Optional image As Image = Nothing, Optional pb As PictureBox = Nothing) As Boolean
        Dim tbcolumID As String = ""
        Dim cbcolumID As String = ""

        ' Parameter zum füllen der Controls ( Spalten Index ) oder freie eingabe = paraTextBox
        ' 0 -> ID
        ' 1 -> Bez
        ' 2 -> Preis
        ' 3 -> Volumen
        ' 4 -> Alk
        ' 5 -> Freie Eingabe
        If paraTextBox > -1 Then

            Select Case paraTextBox
                Case 0
                    tbcolumID = "ID"
                    Logger.WriteLine("Engine.FillControls: TextBox Parameter ID")
                    Exit Select
                Case 1
                    tbcolumID = "Bezeichnung"
                    Logger.WriteLine("Engine.FillControls: TextBox Parameter Bezeichnung")
                    Exit Select
                Case 2
                    tbcolumID = "Preis"
                    Logger.WriteLine("Engine.FillControls: TextBox Parameter Preis")
                    Exit Select
                Case 3
                    tbcolumID = "Volumen"
                    Logger.WriteLine("Engine.FillControls: TextBox Parameter Volumen")
                    Exit Select
                Case 4
                    tbcolumID = "Alkoholgehalt"
                    Logger.WriteLine("Engine.FillControls: TextBox Parameter Alkoholgehalt")
                    Exit Select
                Case 5

                Case Else
                    Logger.WriteLine("Engine.FillControls: TextBox Parameter ungültig")
                    Exit Select
            End Select
        End If
        If paraCB > -1 Then
            Select Case paraCB
                Case 0
                    cbcolumID = "ID"
                    Logger.WriteLine("Engine.FillControls: paraCB Parameter ID")
                    Exit Select
                Case 1
                    cbcolumID = "Bezeichnung"
                    Logger.WriteLine("Engine.FillControls: paraCB Parameter Bezeichnung")
                    Exit Select
                Case 2
                    cbcolumID = "Preis"
                    Logger.WriteLine("Engine.FillControls: paraCB Parameter Preis")
                    Exit Select
                Case 3
                    cbcolumID = "Volumen"
                    Logger.WriteLine("Engine.FillControls: paraCB Parameter Volumen")
                    Exit Select
                Case 4
                    cbcolumID = "Alkoholgehalt"
                    Logger.WriteLine("Engine.FillControls: paraCB Parameter Alkoholgehalt")
                    Exit Select

                Case Else
                    Logger.WriteLine("Engine.FillControls: paraCB Parameter ungültig")
                    Exit Select
            End Select

        End If

        Dim ergebnis As DataTable = CM.ExecuteQuery(query)

        If cb IsNot Nothing Then
            cb.Items.Clear()
            For Each row As DataRow In ergebnis.Rows
                cb.Items.Add(row(paraCB).ToString())
                Logger.WriteLine("Engine.FillControls: Eintrag erstellt in ComboBox." & cb.Name & "| Parameter " & paraCB.ToString)
            Next
        End If

        If tb IsNot Nothing Then
            If ergebnis.Rows.Count > 0 Then
                tb.Text = ergebnis.Rows(0)(paraTextBox).ToString()
                Logger.WriteLine("Engine.FillControls: TextBox." & tb.Name & ": " & ergebnis.ToString)
            End If
        End If
        If pb IsNot Nothing Then
            If image IsNot Nothing Then
                Logger.WriteLine("Engine.FillControls: PictureBox." & pb.Name)
                pb.Image = image
                pb.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End If





        Return True
    End Function

    Public Function ScaleImage(image As Image, maxWidth As Integer, maxHeight As Integer) As Image
        Dim ratioX As Double = maxWidth / image.Width
        Dim ratioY As Double = maxHeight / image.Height
        Dim ratio As Double = Math.Min(ratioX, ratioY)

        Dim newWidth As Integer = CInt(image.Width * ratio)
        Dim newHeight As Integer = CInt(image.Height * ratio)

        Dim newImage As New Bitmap(newWidth, newHeight)

        Using graphics As Graphics = Graphics.FromImage(newImage)
            graphics.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using

        Return newImage
    End Function

End Module

