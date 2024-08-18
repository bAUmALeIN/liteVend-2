Imports System.IO

Public Class Globals


    Public Shared logger As Logger

    '################ LOGGING ####################
    Public Shared logging = True
    '#############################################

    '############################################## SQL STATEMENTS ###########################################################################
    '-----------------------> AUTOMAT
    Public Shared queryAllProducts As String = "SELECT * FROM Produkte"
    Public Shared queryIDProducts As String = "SELECT * FROM Produkte where ID = @ID"
    Public Shared queryAddProduct As String = "INSERT INTO Produkte (ID, Bezeichnung, Preis, Volumen, Alkoholgehalt) VALUES (@ID, @Bezeichnung, @Preis, @Volumen, @Alkoholgehalt)"
    Public Shared queryUpdateProduct As String = "UPDATE Produkte SET Bezeichnung = @Bezeichnung, Preis = @Preis, Volumen = @Volumen, Alkoholgehalt = @Alkoholgehalt WHERE ID = @ID"
    Public Shared queryCheckIfPictureExists As String = "SELECT COUNT(*) FROM Pictures WHERE ID = @ID"
    Public Shared queryUpdatePicture As String = "UPDATE Pictures SET Image = @Bild WHERE ID = @ID"
    Public Shared queryInsertPicture As String = "INSERT INTO Pictures (ID, Image) VALUES (@ID, @Bild)"
    Public Shared queryNextFreeID As String = "SELECT ID FROM Produkte ORDER BY ID"
    Public Shared queryUpdateStatsAnzProd As String = "UPDATE Stats SET anzProdukte = @anzProdukte"
    Public Shared queryUpdateStatsGesUmsatz As String = "UPDATE Stats SET  = @GesUmsatz"
    Public Shared queryGetStatsGesUmsatz As String = "Select GesUmatz from Transaktionen"
    Public Shared querySelectProductCount = "SELECT COUNT(*) FROM Produkte"

    '-----------------------> Database Manager
    Public Shared querySelectTables As String = "SELECT name FROM sqlite_master WHERE type='table'"
    Public Const SelectAll As String = "SELECT * FROM {TableName};"
    Public Const SelectWhere As String = "SELECT {Columns} FROM {TableName} WHERE {Condition};"
    Public Const Insert As String = "INSERT INTO {TableName} ({Columns}) VALUES ({Values});"
    Public Const Update As String = "UPDATE {TableName} SET {ColumnValuePairs} WHERE {Condition};"
    Public Const Delete As String = "DELETE FROM {TableName} WHERE {Condition};"


    '################################# CREATE TABLE #############################################

    Public Shared createProductsTableQuery As String = "CREATE TABLE IF NOT EXISTS Produkte (" &
                                                     "ID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                                                     "Bezeichnung TEXT NOT NULL, " &
                                                     "Preis REAL NOT NULL, " &
                                                     "Volumen REAL NOT NULL, " &
                                                     "Alkoholgehalt REAL NOT NULL)"

    Public Shared createTransactionsTableQuery As String = "CREATE TABLE IF NOT EXISTS Transaktionen (" &
                                                         "ID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                                                         "Uhrzeit TEXT NOT NULL, " &
                                                         "Datum TEXT NOT NULL, " &
                                                         "Gesamtpreis REAL NOT NULL)"

    Public Shared createPictureTableQuery As String = "CREATE TABLE IF NOT EXISTS Pictures (" &
                                                         "ID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                                                         "Image BLOB NOT NULL)"

    Public Shared createStatsTableQuery As String = "CREATE TABLE IF NOT EXISTS Stats (" &
                                                         "Version REAL," &
                                                         "VGZ INTEGER NOT NULL, " &
                                                         "anzProdukte INTEGER NOT NULL, " &
                                                         "GesUmsatz REAL NOT NULL," &
                                                         "Flaschen INTEGER NOT NULL)"
    Public Shared insertDefaultStatsQuery As String = "
                    INSERT INTO Stats (Version, VGZ, anzProdukte, GesUmsatz, Flaschen)
                    VALUES ('1.00', 0, 0, 0.0, 0);
                "





    '################################################## Variablen #############################################################################

    Public Shared openIDinEdit As Integer = 0

    Public Shared FehlerTextNoProdukt As String = ""

    Public Shared BlinkenPanelFarbe As Integer = 0      ' 1 -> rot 2 -> gelb 3-> grün

    Public Shared DBpath As String

    Public Shared ConString As String = "Data Source=ProduktDatenbank.db;Version=3;"

    Public Shared Zahlung = False
    Public Shared CoinValue As Double = 0.00


    '#################################################### Listen ##############################################################################

    Public Shared ProduktBtnList As New List(Of Button) From {
    FormVending.btnItem1,
    FormVending.btnItem2,
    FormVending.btnItem3,
    FormVending.btnItem4,
    FormVending.btnItem5,
    FormVending.btnItem6,
    FormVending.btnItem7,
    FormVending.btnItem8,
    FormVending.btnItem9,
    FormVending.btnItem10,
    FormVending.btnItem11,
    FormVending.btnItem12,
    FormVending.btnItem13,
    FormVending.btnItem14,
    FormVending.btnItem15,
    FormVending.btnItem16,
    FormVending.btnItem17,
    FormVending.btnItem18,
    FormVending.btnItem19,
    FormVending.btnItem20,
    FormVending.btnItem21,
    FormVending.btnItem22,
    FormVending.btnItem23,
    FormVending.btnItem24,
    FormVending.btnItem25,
    FormVending.btnItem26,
    FormVending.btnItem27,
    FormVending.btnItem28,
    FormVending.btnItem29,
    FormVending.btnItem30
    }

    Public Shared ActiveProductIDs As New List(Of Integer)

End Class
