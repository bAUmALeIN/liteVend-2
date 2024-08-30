Imports System.Data.SQLite
Imports System.IO
Imports System.Runtime.Remoting.Messaging
Imports Getränke_Automat_V2.FormMainMenu
Imports Getränke_Automat_V2.Globals


Public Class ConnectionManger


    Public connectionString As String = "Data Source=ProduktDatenbank.db;Version=3;"
    Public connection As New SQLiteConnection(connectionString)
    Dim buttonTag As Object
    ' -> UpdateProdukt (ID, Bez, Volumen, Alkoholgehalt, Preis, Bild)


    Public Function createDB()
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim createTableQueries As String() = {
            Globals.createProductsTableQuery,
            Globals.createTransactionsTableQuery,
            Globals.createStatsTableQuery,
            Globals.createPictureTableQuery,
            Globals.createLagerListQuery,
            Globals.createLagerOrtListQuery
            }
            Try
                Logger.WriteLine("Versuche Datenbank Tabellen zu erstellen")
                For Each query In createTableQueries
                    Using cmd As New SQLiteCommand(query, connection)
                        cmd.ExecuteNonQuery()
                    End Using

                Next
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
            connection.Close()
        End Using
        Globals.DBpath = FormMainMenu.dbPath
        Return True
    End Function

    Public Function ExecuteQuery(query As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                Using cmd As New SQLiteCommand(query, connection)
                    Logger.WriteLine("CM.ExecuteQuery:" & query)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception

            Logger.WriteLine("Fehler beim Ausführen der Abfrage: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function GetStatsFromDB() As Globals.Stats
        Dim stats As Globals.Stats

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT Version, VGZ, anzProdukte, GesUmsatz, Flaschen FROM Stats LIMIT 1"

            Using cmd As New SQLiteCommand(query, connection)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        stats.AnzVG = reader.GetInt32(1)
                        stats.anzProdukte = reader.GetInt32(2)
                        stats.GesUmsatz = reader.GetDouble(3)
                        stats.anzVerkFalschen = reader.GetInt32(4)
                    Else

                    End If
                    Logger.WriteLine($"CM.GetStatsFromDB | GesUmsatz:{stats.GesUmsatz.ToString} | Transaktionen:{stats.AnzVG.ToString} | Anz. Produkte:{stats.anzProdukte.ToString} | Ausgegebene Flaschen:{stats.anzVerkFalschen.ToString}")
                End Using
            End Using
            connection.Close()
        End Using

        Return stats
    End Function

    Public Sub UpdateStatsDB(stats As Globals.Stats)
        Logger.WriteLine($"CM.UpdateStatsDB: GesUmsatz:{stats.GesUmsatz} | anz.Produkte:{stats.anzProdukte} | anz. verkaufte Flaschen:{stats.anzVerkFalschen} | anz.VG:{stats.AnzVG} |")
        Using connection As New SQLiteConnection(connectionString)

            Try
                connection.Open()
                Dim query As String = "UPDATE Stats SET Version = @Version, VGZ = @VGZ, anzProdukte = @anzProdukte, GesUmsatz = @GesUmsatz, Flaschen = @Flaschen"
                Using cmd As New SQLiteCommand(query, connection)

                    cmd.Parameters.AddWithValue("@Version", 1)
                    cmd.Parameters.AddWithValue("@VGZ", (Int(stats.AnzVG)))
                    cmd.Parameters.AddWithValue("@anzProdukte", (Int(stats.anzProdukte)))
                    cmd.Parameters.AddWithValue("@GesUmsatz", stats.GesUmsatz)
                    cmd.Parameters.AddWithValue("@Flaschen", stats.anzVerkFalschen)


                    cmd.ExecuteNonQuery()
                End Using

                connection.Close()
            Catch ex As Exception
                Logger.WriteLine("Fehler update stats")

            End Try

        End Using
    End Sub

    Public Function getProduktByID(ID As Integer) As Globals.Produkt
        Dim produkt As New Globals.Produkt()
        Dim query As String = "SELECT*FROM Produkte WHERE ID = @ProductID"

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Using cmd As New SQLiteCommand(query, connection)
                cmd.Parameters.AddWithValue("@ProductID", ID)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        produkt.ID = reader.GetInt32(0)
                        produkt.Bezeichnung = reader.GetString(1)
                        produkt.Preis = reader.GetDouble(2)
                        produkt.Volumen = reader.GetDouble(3)
                        produkt.Alkoholgehalt = reader.GetDouble(4)
                        produkt.Lager = reader.GetInt32(5)
                        produkt.LagerOrt = reader.GetInt32(6)
                        produkt.mindBestand = reader.GetInt32(7)
                        produkt.Preis_PL1 = reader.GetDouble(8)
                        produkt.Preis_PL2 = reader.GetDouble(9)
                        produkt.Preis_PL3 = reader.GetDouble(10)
                        produkt.Preis_PL4 = reader.GetDouble(11)
                        produkt.PLU = reader.GetInt32(12)
                        produkt.Bestand = reader.GetInt32(13)
                    End If
                End Using
            End Using
        End Using

        Return produkt
    End Function

    Public Function InsertProdukt(Bezeichnung As String, Preis As Double, volumen As Double, alkohol As Double, PLU As Integer, Lager As Integer, LagerOrt As Integer, mindBestand As Integer, Bestand As Integer, Optional PLactive As Boolean = False, Optional PL1 As Double = -1, Optional PL2 As Double = -1, Optional PL3 As Double = -1, Optional PL4 As Double = -1) As Boolean
        ' ID, Bez, Preis, Volumen,Alk, PLU,Lager,LagerOrt,OPT PL1,OPT PL2,OPT PL3,OPT PL4

        Logger.WriteLine("CM.Insert.Pordukt: Eintrag wird in die Datenbank geschrieben.....")
        Dim success As Boolean = False
        Dim nextID As Integer = GetNextFreeID()
        Logger.WriteLine("CM.InsertProdukt: Die nächste freie ID ist: " & nextID)
        Try
            Using connection As New SQLiteConnection(Globals.ConString)
                connection.Open()
                Using command As New SQLiteCommand(Globals.queryAddProduct, connection)
                    command.Parameters.AddWithValue("@ID", nextID)
                    command.Parameters.AddWithValue("@Bezeichnung", Bezeichnung)
                    command.Parameters.AddWithValue("@Preis", Preis)
                    command.Parameters.AddWithValue("@Volumen", volumen)
                    command.Parameters.AddWithValue("@Alkoholgehalt", alkohol)
                    command.Parameters.AddWithValue("@Lager", Lager)
                    command.Parameters.AddWithValue("@LagerOrt", LagerOrt)
                    command.Parameters.AddWithValue("@mindBestand", mindBestand)
                    command.Parameters.AddWithValue("@Bestand", Bestand)
                    If (PLactive) Then
                        command.Parameters.AddWithValue("@PL1_preis", PL1)
                        command.Parameters.AddWithValue("@PL2_preis", PL2)
                        command.Parameters.AddWithValue("@PL3_preis", PL3)
                        command.Parameters.AddWithValue("@PL4_preis", PL4)
                    Else
                        command.Parameters.AddWithValue("@PL1_preis", 0)
                        command.Parameters.AddWithValue("@PL2_preis", 0)
                        command.Parameters.AddWithValue("@PL3_preis", 0)
                        command.Parameters.AddWithValue("@PL4_preis", 0)
                    End If
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        Logger.WriteLine("CM.InsertProdukt: Eintrag erfolgreich eingefügt.")
                        success = True
                    Else
                        Logger.WriteLine("CM.InsertProdukt: Fehler beim schreiben des Eintrags.")
                        success = False
                    End If
                    If connection.State = ConnectionState.Open Then connection.Close()
                End Using
            End Using
        Catch ex As SQLiteException
            Logger.WriteLine("CM.InsertProdukt: SQLite-Fehler: " & ex.Message)
            success = False
            Return False
        Catch ex As Exception
            Logger.WriteLine("CM.InsertProdukt: Allgemeiner Fehler: " & ex.Message)
            success = False
            Return False
        End Try
        UpdateStatsAnzProd(GetProductCount)
        Return success
    End Function

    Public Function InsertProduktAsProdukt(produkt As Globals.Produkt, Optional PLactive As Boolean = False)
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using command As New SQLiteCommand(Globals.queryAddProduct, connection)

                    command.Parameters.AddWithValue("@ID", produkt.ID)
                    command.Parameters.AddWithValue("@Bezeichnung", produkt.Bezeichnung)
                    command.Parameters.AddWithValue("@Preis", produkt.Preis)
                    command.Parameters.AddWithValue("@Volumen", produkt.Volumen)
                    command.Parameters.AddWithValue("@Alkoholgehalt", produkt.Alkoholgehalt)
                    command.Parameters.AddWithValue("@Lager", produkt.Lager)
                    command.Parameters.AddWithValue("@LagerOrt", produkt.LagerOrt)
                    command.Parameters.AddWithValue("@mindBestand", produkt.mindBestand)
                    command.Parameters.AddWithValue("@Bestand", produkt.Bestand)
                    command.Parameters.AddWithValue("@PLU", produkt.PLU)
                    If (PLactive) Then
                        command.Parameters.AddWithValue("@PL1_preis", produkt.Preis_PL1)
                        command.Parameters.AddWithValue("@PL2_preis", produkt.Preis_PL2)
                        command.Parameters.AddWithValue("@PL3_preis", produkt.Preis_PL3)
                        command.Parameters.AddWithValue("@PL4_preis", produkt.Preis_PL4)
                    Else
                        command.Parameters.AddWithValue("@PL1_preis", 0)
                        command.Parameters.AddWithValue("@PL2_preis", 0)
                        command.Parameters.AddWithValue("@PL3_preis", 0)
                        command.Parameters.AddWithValue("@PL4_preis", 0)
                    End If
                    If produkt.Image Is Nothing Then
                        Logger.WriteLine("CM.InsertProduktAsProdukt: Kein Bild")

                    Else
                        'Insert Image 

                        Logger.WriteLine("CM.InsertProduktAsProdukt: Bild vorhanden und wird eingefügt")

                    End If
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If SaveImageToDatabase(produkt.Image, produkt.ID) Then
                    End If
                    ' Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception

            Logger.WriteLine("CM.InsertProduktAsProdukt: Fehler beim Einfügen des Produkts: " & ex.Message)
            Return False
        End Try
        Logger.WriteLine("CM.InsertProduktAsProdukt: Eintrag erfolgreich erstellt.")
        Return True
    End Function

    Public Function UpdateProdukt(produkt As Globals.Produkt) As Boolean            ' MUSS noch überarbeitet werden für V3
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using command As New SQLiteCommand(Globals.queryUpdateProduct, connection)

                    command.Parameters.AddWithValue("@ID", produkt.ID)
                    command.Parameters.AddWithValue("@Bezeichnung", produkt.Bezeichnung)
                    command.Parameters.AddWithValue("@Preis", produkt.Preis)
                    command.Parameters.AddWithValue("@Volumen", produkt.Volumen)
                    command.Parameters.AddWithValue("@Alkoholgehalt", produkt.Alkoholgehalt)


                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Logger.WriteLine("CM.UpdateProdukt: Eintrag erfolgreich aktualisiert.")
                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            Logger.WriteLine("CM.UpdateProdukt: Fehler beim Aktualisieren des Produkts: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function GetNextFreeID() As Integer

        Dim IDs As New List(Of Integer)()

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Using cmd As New SQLiteCommand(Globals.queryNextFreeID, connection)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        IDs.Add(reader.GetInt32(0))
                    End While
                End Using
            End Using
            connection.Close()
        End Using

        Dim nextID As Integer = 1
        For Each id In IDs
            If id <> nextID Then
                Exit For
            End If
            nextID += 1
            'Logger.WriteLine($"nextID = {nextID.ToString}")
        Next

        Return nextID
    End Function

    Public Function UpdateStatsAnzProd(anzProdukte As Integer) As Boolean
        Logger.WriteLine("ConnectionManager: Start Update Stats....")

        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using cmd As New SQLiteCommand(Globals.queryUpdateStatsAnzProd, connection)
                    cmd.Parameters.AddWithValue("@anzProdukte", anzProdukte)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        Logger.WriteLine("ConnectionManager: Update erfolgreich.")
                        Return True
                    Else
                        Logger.WriteLine("ConnectionManager: Update fehlgeschlagen.")
                        Return False
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            Logger.WriteLine("ConnectionManager: Fehler beim Aktualisieren der Daten: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetProductCount() As Integer

        Dim count As Integer = 0

        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using cmd As New SQLiteCommand(Globals.querySelectProductCount, connection)
                    count = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            Logger.WriteLine("CM.GetProductCount: Fehler beim Abrufen der Produktanzahl: " & ex.Message)
            count = -1
        End Try

        Return count
    End Function

    Public Function SaveImageToDatabase(image As Image, ID As Integer) As Boolean

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Using command As New SQLiteCommand(Globals.queryInsertPicture, connection)
                command.Parameters.AddWithValue("@Bild", ImageToByteArray(image))
                command.Parameters.AddWithValue("@ID", ID)
                command.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using
        Return True
    End Function

    Public Function UpdateImageInDatabase(image As Image, ID As Integer) As Boolean

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Using command As New SQLiteCommand(Globals.queryUpdatePicture, connection)
                command.Parameters.AddWithValue("@Bild", Engine.ImageToByteArray(image))
                command.Parameters.AddWithValue("@ID", ID)
                command.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using
        Return True
    End Function

    Public Function SaveOrUpdateImageInDatabase(image As Image, ID As Integer) As Boolean

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            Using checkCommand As New SQLiteCommand(Globals.queryCheckIfPictureExists, connection)
                checkCommand.Parameters.AddWithValue("@ID", ID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count = 0 Then
                    Using insertCommand As New SQLiteCommand(Globals.queryInsertPicture, connection)
                        insertCommand.Parameters.AddWithValue("@ID", ID)
                        insertCommand.Parameters.AddWithValue("@Bild", Engine.ImageToByteArray(image))
                        insertCommand.ExecuteNonQuery()
                    End Using
                Else
                    Using updateCommand As New SQLiteCommand(Globals.queryUpdatePicture, connection)
                        updateCommand.Parameters.AddWithValue("@ID", ID)
                        updateCommand.Parameters.AddWithValue("@Bild", Engine.ImageToByteArray(image))
                        updateCommand.ExecuteNonQuery()
                    End Using
                End If
            End Using

            connection.Close()
        End Using

        Return True
    End Function

    Public Function GetImageFromDatabase(id As Integer) As Image
        Dim query As String = "SELECT Image FROM Pictures WHERE ID = @ID"
        Dim image As Image = Nothing

        Using connection As New SQLiteConnection("Data Source=ProduktDatenbank.db;Version=3;")
            connection.Open()
            Using command As New SQLiteCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)
                Logger.WriteLine($"CM.GetImageFromDatabase: Suche Bild aus Datenbank | ID{id.ToString}")
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    image = ByteArrayToImage(DirectCast(result, Byte()))
                End If
            End Using
            connection.Close()
        End Using

        Return image
    End Function

    Public Function GetProduktIDByName(bezeichnung As String) As Integer
        Dim query As String = "SELECT ID FROM Produkte WHERE Bezeichnung = @Bezeichnung"
        Dim productID As Integer = -1
        Logger.WriteLine("CM.GetProduktIDByName| Suche Produkt ID mit Bezeichnung: " & bezeichnung)
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using cmd As New SQLiteCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Bezeichnung", bezeichnung)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        productID = Convert.ToInt32(result)
                        Logger.WriteLine("CM.GetProduktIDByName| found: ID: " & productID)
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            Logger.WriteLine("CM.GetProduktIDByName| Fehler beim Abrufen der ProduktID: " & ex.Message)
        End Try

        Return productID
    End Function

    Public Function loadDGV(query As String, DGV As DataGridView)
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV.ColumnHeadersVisible = True
        DGV.AutoResizeColumnHeadersHeight()
        DGV.RowHeadersVisible = False
        Logger.WriteLine("CM.loadDGV: Try Fill DGV with DataTable")
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()

                Using command As New SQLiteCommand(query, connection)
                    Using adapter As New SQLiteDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        ' Dem DataGridView die Datenquelle zuweisen
                        DGV.DataSource = table
                        Logger.WriteLine("CM.loadDGV: DataTable DGV.DataSource zugewiesen")
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As SQLiteException
            Logger.WriteLine("CM.loadDGV: SQLite-Fehler: " & ex.Message)
        Catch ex As Exception
            Logger.WriteLine("CM.loadDGV: Fehler beim Abrufen der Daten: " & ex.Message)
        End Try

    End Function

    Public Function GetProduktPreisByID(productID As Integer) As Double
        Dim preis As Double = 0.00
        Dim query As String = "SELECT Preis FROM Produkte WHERE ID = @ProductID"
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Using command As New SQLiteCommand(query, connection)

                    command.Parameters.AddWithValue("@ProductID", productID)
                    Dim result As Object = command.ExecuteScalar()

                    ' ergebnis Überprüfen und schreiben 
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        Double.TryParse(result.ToString(), preis)
                    End If
                    Logger.WriteLine("CM.GetProduktPreisByID: Produkt ID:" + productID.ToString)
                    Logger.WriteLine("CM.GetProduktPreisByID: Preis aus der Datenbank:" & preis.ToString)
                End Using
                If connection.State = ConnectionState.Open Then connection.Close()
            End Using
        Catch ex As Exception
            Logger.WriteLine("CM.GetProduktPreisByID: Produkt ID:" + productID.ToString)
            Logger.WriteLine("CM.GetProduktPreisByID: Fehler beim Abrufen des Preises aus der Datenbank: " & ex.Message)
        End Try
        Return preis
    End Function

    Public Sub PreiseInLabelsSchreiben(panelProdukte As Panel)
        Logger.WriteLine("CM.PreiseInLabelsSchreiben: Start..")
        Dim query As String = "SELECT ID, Preis FROM Produkte"
        Try
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                Logger.WriteLine("CM.PreiseInLabelsSchreiben: connection.Open OK")
                Using command As New SQLiteCommand(query, connection)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        Dim count As Integer = 1
                        While reader.Read()
                            Dim productID As Integer = reader.GetInt32(0)
                            Dim price As Double = reader.GetDouble(1)
                            Logger.WriteLine("CM.PreiseInLabelsSchreiben: Lese Preis " + price.ToString + "| schreibe Preis:" & count.ToString)
                            Globals.ActiveProductIDs.Add(productID)
                            Dim foundLabel As Label = Nothing
                            ' Suche Label in panelProdukte
                            foundLabel = panelProdukte.Controls.OfType(Of Label).FirstOrDefault(Function(lbl) lbl.Name = "PreisTag" & productID.ToString())
                            If foundLabel IsNot Nothing Then
                                foundLabel.Text = price.ToString("C2")
                            End If
                            count += 1
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Fehler beim Abrufen der Preise aus der Datenbank: " & ex.Message)
        End Try
    End Sub

    Public Function GetDataTableFromTable(tableName As String) As DataTable
        Dim dt As New DataTable()

        Using connection As New SQLiteConnection(Globals.ConString)
            connection.Open()
            Using command As New SQLiteCommand($"SELECT * FROM {tableName}", connection)
                Using adapter As New SQLiteDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function


    '##########################################################################################################
    'Lagerverwaltung


    Public Function getNextFreeLagerNumner() As Integer
        Dim nextNumber As Integer = 0

        Dim cmd As New SQLiteCommand(Globals.NextLagerNummerQuery, connection)

        Try

            Using connection
                connection.Open()
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    Dim tableNumbers As New List(Of Integer)

                    While reader.Read()
                        Dim tableName As String = reader("name").ToString()
                        Dim tableNumberStr As String = tableName.Replace("Lager_", "")

                        Dim tableNumber As Integer
                        If Integer.TryParse(tableNumberStr, tableNumber) Then
                            tableNumbers.Add(tableNumber)
                        End If
                    End While

                    ' Finde die höchste Nummer und bestimme die nächste verfügbare Nummer
                    If tableNumbers.Count > 0 Then
                        nextNumber = tableNumbers.Max() + 1
                    End If
                    If tableNumbers.Count = 0 Then
                        nextNumber = 1
                    End If
                End Using
            End Using
        Catch ex As Exception
            Logger.WriteLine($"CM.getNextFreeLagerNummer| Fehler: {ex.Message}")
            Return -1
        End Try
        Logger.WriteLine($"CM.getNextFreeLagerNummer| NextLagerNummer: {nextNumber}")
        Return nextNumber
    End Function


    Public Function CreateLagerAndPosTable(Lager As Globals.oLager)


        Dim createNewTable_LagerQuery As String = $"CREATE TABLE '{Lager.Bezeichnung}' (
	                                                'ID'	INTEGER NOT NULL,
	                                                'Name'	TEXT,
	                                                'Cap'	INTEGER NOT NULL,
	                                                'frei'	INTEGER,
	                                                'belegt'	INTEGER,
	                                                PRIMARY KEY('ID')
                                                    );"
        Dim createNewTable_Lager_PositionenQuery As String = $"CREATE TABLE '{Lager.Bezeichnung}_Positionen' (
	                                                'ID'	INTEGER NOT NULL,
	                                                'Bezeichnung'	TEXT
                                                     )"

        Using connection As New SQLiteConnection(Globals.ConString)
            connection.Open()
            Using transaction As SQLiteTransaction = connection.BeginTransaction()
                Try
                    Using cmd As New SQLiteCommand(createNewTable_LagerQuery, connection)
                        cmd.ExecuteNonQuery()
                    End Using
                    Using cmd As New SQLiteCommand(createNewTable_Lager_PositionenQuery, connection)
                        cmd.ExecuteNonQuery()
                    End Using
                    transaction.Commit()
                Catch ex As Exception
                    Logger.WriteLine($"CM.CrateLagerAndPosTable | Fehler: {ex.Message}")
                    transaction.Rollback()
                End Try

            End Using
        End Using


    End Function
    Public Function InsertInto_Lager_withPos(Lager As Globals.oLager, posListe As List(Of Globals.LagerPosition))

        Dim InsertIntoLagerQuery As String = $"INSERT INTO '{Lager.Bezeichnung}' ('ID', 'Name', 'Cap', 'frei', 'belegt') VALUES (@ID, '{Lager.Bezeichnung}', @CAP, @FREI, @BELEGT);"


        Try
            Using connection As New SQLiteConnection(Globals.ConString)
                connection.Open()

                ' Beginne eine Transaktion
                Using transaction As SQLiteTransaction = connection.BeginTransaction()
                    Try
                        ' Füge das Lager ein
                        Using cmd As New SQLiteCommand(InsertIntoLagerQuery, connection)
                            cmd.Parameters.AddWithValue("@ID", Lager.ID)
                            cmd.Parameters.AddWithValue("@CAP", Lager.Cap)
                            cmd.Parameters.AddWithValue("@FREI", Lager.frei)
                            cmd.Parameters.AddWithValue("@BELEGT", Lager.belegt)
                            cmd.ExecuteNonQuery()
                        End Using
                        ' Füge die Positionen ein
                        For Each pos In posListe

                            Dim InsertIntoLagerPositionsQuery As String = $"INSERT INTO '{Lager.Bezeichnung}_Positionen' ('ID', 'Bezeichnung') VALUES (@ID, '{pos.Bez}');"
                            Using cmd As New SQLiteCommand(InsertIntoLagerPositionsQuery, connection)
                                cmd.Parameters.AddWithValue("@ID", pos.ID)
                                cmd.Parameters.AddWithValue("@BEZ", pos.Bez)
                                cmd.ExecuteNonQuery()
                                Logger.WriteLine($"CM.createLager_withPos| Position in Lager: {Lager.Bezeichnung} erstellt - {pos.Bez} - ID: {pos.ID.ToString} ")
                            End Using
                        Next

                        ' Bestätige die Transaktion
                        transaction.Commit()
                        Logger.WriteLine($"CM.createLager_withPos| Lager erstellt - {Lager.Bezeichnung} - ID: {Lager.ID.ToString} ")
                        Return True
                    Catch ex As Exception
                        ' Bei Fehlern rollback der Transaktion
                        transaction.Rollback()
                        Logger.WriteLine("CM.createLager_withPos| Fehler: " & ex.Message)
                        Return False
                    End Try
                End Using
            End Using
        Catch ex As Exception
            Logger.WriteLine("Verbindungsfehler: " & ex.Message)
            Return False
        End Try
    End Function


End Class
