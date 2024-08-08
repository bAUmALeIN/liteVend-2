Imports System.Data.SQLite
Imports System.Windows.Forms

Public Class DatabaseManager
    Public Function OpenDB(path As String) As Boolean
        Try
            Dim connectionString As String = $"Data Source={path};Version=3;"
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()
                ' Optional: Führen Sie hier weitere Initialisierungen oder Überprüfungen durch
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine($"Fehler beim Öffnen der Datenbank: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function GetTableNames() As List(Of String)
        Dim tableNames As New List(Of String)

        Using connection As New SQLiteConnection(Globals.ConString)
            connection.Open()
            Dim querySelectTables As String = "SELECT name FROM sqlite_master WHERE type='table';"
            Using command As New SQLiteCommand(querySelectTables, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        tableNames.Add(reader("name").ToString())
                    End While
                End Using
            End Using
            connection.Close()
        End Using

        Return tableNames
    End Function

    Public Function GetTableData(tableName As String) As DataTable
        Dim tableData As New DataTable

        Using connection As New SQLiteConnection(Globals.ConString)
            Dim query As String = $"SELECT * FROM {tableName};"
            connection.Open()
            Using command As New SQLiteCommand(query, connection)
                Using adapter As New SQLiteDataAdapter(command)
                    adapter.Fill(tableData)
                End Using
            End Using
            connection.Close()
        End Using

        Return tableData
    End Function

    Public Shared Sub FillTreeView(tv As TreeView)
        tv.Nodes.Clear()

        Dim connectionString As String = $"Data Source={Globals.DBpath};Version=3;"

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()
            Dim tableQuery As String = "SELECT name FROM sqlite_master WHERE type='table';"
            Using tableCommand As New SQLiteCommand(tableQuery, connection)
                Using reader As SQLiteDataReader = tableCommand.ExecuteReader()
                    While reader.Read()
                        Dim tableName As String = reader("name").ToString()
                        Dim tableNode As New TreeNode(tableName)

                        Dim columnQuery As String = $"PRAGMA table_info({tableName});"
                        Using columnCommand As New SQLiteCommand(columnQuery, connection)
                            Using columnReader As SQLiteDataReader = columnCommand.ExecuteReader()
                                While columnReader.Read()
                                    Dim columnName As String = columnReader("name").ToString()
                                    Dim columnType As String = columnReader("type").ToString()
                                    Dim columnNodeText As String = $"{columnName} | {columnType}"
                                    Dim columnNode As New TreeNode(columnNodeText)
                                    tableNode.Nodes.Add(columnNode)
                                End While
                            End Using
                        End Using

                        tv.Nodes.Add(tableNode)
                    End While
                End Using
            End Using
            connection.Close()
        End Using
    End Sub

    Public Sub FillListViewWithTableData(lv As ListView, tableName As String)
        lv.Clear()
        lv.View = View.Details

        Dim query As String = $"SELECT * FROM {tableName};"

        Using connection As New SQLiteConnection(Globals.ConString)
            connection.Open()
            Using command As New SQLiteCommand(query, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    ' Spaltenüberschriften hinzufügen
                    For i As Integer = 0 To reader.FieldCount - 1
                        lv.Columns.Add(reader.GetName(i), -2, HorizontalAlignment.Left)
                    Next

                    ' Daten hinzufügen
                    While reader.Read()
                        Dim values(reader.FieldCount - 1) As String
                        For i As Integer = 0 To reader.FieldCount - 1
                            values(i) = If(reader.IsDBNull(i), "NULL", reader.GetValue(i).ToString())
                        Next
                        Dim item As New ListViewItem(values)
                        lv.Items.Add(item)
                    End While
                End Using
            End Using
            connection.Close()
        End Using

        ' Spaltenbreiten an den Inhalt anpassen
        AdjustListViewColumns(lv)
    End Sub

    Public Sub FillListViewWithColumnData(lv As ListView, tableName As String, columnName As String)
        lv.Clear()
        lv.View = View.Details

        Dim query As String = $"SELECT {columnName} FROM {tableName};"

        Using connection As New SQLiteConnection(Globals.ConString)
            connection.Open()
            Using command As New SQLiteCommand(query, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()

                    lv.Columns.Add(columnName, -2, HorizontalAlignment.Left)


                    While reader.Read()

                        Dim value As String = If(reader.IsDBNull(0), "NULL", reader.GetValue(0).ToString())

                        Dim item As New ListViewItem(value)
                        lv.Items.Add(item)
                    End While
                End Using
            End Using
            connection.Close()
        End Using


        AdjustListViewColumns(lv)
    End Sub


    Private Sub AdjustListViewColumns(lv As ListView)
        For Each column As ColumnHeader In lv.Columns
            column.Width = -2 ' 
        Next
    End Sub

    Public Sub FillControlWithQuery(control As Control, query As String)
        Try
            Using connection As New SQLiteConnection(Globals.ConString)
                connection.Open()
                Using command As New SQLiteCommand(query, connection)
                    Using adapter As New SQLiteDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        If TypeOf control Is TextBox Then
                            Dim textBox As TextBox = CType(control, TextBox)
                            If dataTable.Rows.Count > 0 Then
                                textBox.Text = dataTable.Rows(0)(0).ToString()
                            End If
                        ElseIf TypeOf control Is ComboBox Then
                            Dim comboBox As ComboBox = CType(control, ComboBox)
                            comboBox.Items.Clear()
                            For Each row As DataRow In dataTable.Rows
                                comboBox.Items.Add(row(0).ToString())
                            Next
                        ElseIf TypeOf control Is DataGridView Then
                            Dim dataGridView As DataGridView = CType(control, DataGridView)
                            dataGridView.DataSource = dataTable
                        Else
                            Console.WriteLine("dbManager.FillControlWithQuery: ControlTyp nicht unterstützt")
                        End If
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            Console.WriteLine($"dbManager.FillControlWithQuery: Fehler bei Abfrage: {ex.Message}")
        End Try
    End Sub

    Public Shared Sub FillDataGridViewWithTable(dgv As DataGridView, tableName As String)
        Try
            Using connection As New SQLiteConnection(Globals.ConString)
                connection.Open()
                Dim query As String = $"SELECT * FROM {tableName};"
                Using command As New SQLiteCommand(query, connection)
                    Using adapter As New SQLiteDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        dgv.DataSource = dataTable
                    End Using
                End Using
                connection.Close()
            End Using

            For Each column As DataGridViewColumn In dgv.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

        Catch ex As Exception
            Console.WriteLine($"dbManager.FillDataGridViewWithTable: Fehler:: {ex.Message}")
        End Try
    End Sub
End Class

