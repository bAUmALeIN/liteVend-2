Imports System.IO

Public Class Globals

    Public Class Produkt
        Public Property ID As Integer
        Public Property Preis As Double
        Public Property Preis_PL1 As Double
        Public Property Preis_PL2 As Double
        Public Property Preis_PL3 As Double
        Public Property Preis_PL4 As Double
        Public Property Bezeichnung As String
        Public Property Alkoholgehalt As Double
        Public Property Volumen As Double
        Public Property Image As Image
        Public Property PLU As String
        Public Property LagerOrt_name As String
        Public Property Lager_name As String
        Public Property LagerID As Integer
        Public Property mindBestand As Integer

    End Class



    Public Structure Stats
        Public AnzVG As Integer
        Public anzProdukte As Integer
        Public anzVerkFalschen As Integer
        Public GesUmsatz As Double
    End Structure

    ' Monster   X
    ' diet zuckerfrei   X
    ' Vilsa X   
    ' Schwipp Schwapp   X
    ' Mezzo Mix X
    ' Paulaner Spezi    X
    ' Eistee    X
    ' Augustiner Edelstoff, Münchner Hell,  X
    ' SevenUP X
    ' DrPepper X
    ' Mountain Dew  X
    ' Powerade X
    ' Durstlöscher versch. Sorten
    ' Jägermeister
    ' Schwepps
    ' Vodka 
    ' Kippen
    ' Orangensaft
    ' Radler


    Public Shared logger As Logger

    '################ LOGGING ####################
    Public Shared logging = False
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
    Public Shared queryUpdateStatsVGZ As String = "UPDATE Stats SET  = @VGZ"
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

    Public Shared createProductsTableQuery As String = "CREATE TABLE 'Produkte' (
	                                                    'ID'	INTEGER,
	                                                    'Bezeichnung'	TEXT NOT NULL,
	                                                    'Preis'	REAL NOT NULL,
	                                                    'Volumen'	REAL NOT NULL,
	                                                    'Alkoholgehalt'	REAL NOT NULL,
	                                                    'Lager'	TEXT,
	                                                    'LagerOrt'	TEXT,
	                                                    'mindBestand'	INTEGER,
	                                                    'PL1_preis'	REAL,
	                                                    'PL2_preis'	REAL,
	                                                    'PL3_preis'	REAL,
	                                                    'PL4_preis'	REAL,
                                                        'PLU' INTEGER,
	                                                    PRIMARY KEY('ID' AUTOINCREMENT)
                                                    )"

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
    Public Shared insertDefaultStatsQuery As String = "INSERT INTO Stats (Version, VGZ, anzProdukte, GesUmsatz, Flaschen)
                                                       VALUES ('2.00', 0, 0, 0.0, 0);"

    Public Shared createLagerListQuery As String = "CREATE TABLE 'LagerList' (
	                                                'Lager_ID'	INTEGER NOT NULL,
	                                                'Lager_Name'	TEXT NOT NULL,
	                                                'Lager_cap'	INTEGER NOT NULL,
	                                                'Lager_frei'	INTEGER NOT NULL,
	                                                'lager_belegt'	INTEGER NOT NULL
                                                    )"

    Public Shared createLagerOrtListQuery As String = "CREATE TABLE 'LagerOrtList' (
	                                                'Lager_ID_Parent'	INTEGER,
	                                                'LagerOrt_Name'	TEXT,
	                                                'LagerOrt_size'	INTEGER,
	                                                'LagerOrt_frei'	INTEGER,
	                                                'LagerOrt_belegt'	INTEGER
                                                    )"




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
