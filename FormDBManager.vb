Imports System.Data.SQLite
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Public Class FormDBManager


    Dim lastTable As DataTable
    Dim mouseOffset As Point
    Dim DBM As New DatabaseManager
    Dim CM As New ConnectionManger
    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox2.MouseDown, Panel2.MouseDown, Label10.MouseDown, Label6.MouseDown, labelDBPath.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox2.MouseMove, Panel2.MouseMove, Label10.MouseMove, Label6.MouseMove, labelDBPath.MouseMove

        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub FormDBManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Logger.WriteLine(Globals.DBpath)
        DBM.FillTreeView(TreeViewDatabase)
        DBM.FillControlWithQuery(ComboBoxTables, Globals.querySelectTables)
        Dim Img As Image = My.Resources.RunCode
        btnRunSQL.Image = Engine.ScaleImage(Img, 84, 20)
        btnRunSQL.ImageAlign = ContentAlignment.TopLeft
        btnRunSQL.TextAlign = ContentAlignment.MiddleRight
        Img = My.Resources.icons8_datei_hinzufuegen_50
        btnCreateTable.Image = Engine.ScaleImage(Img, 20, 20)
        btnCreateTable.ImageAlign = ContentAlignment.TopLeft
        btnCreateTable.TextAlign = ContentAlignment.MiddleRight
        Img = My.Resources.icons8_ordner_öffnen_50
        btnOpenSQL.Image = Engine.ScaleImage(Img, 20, 20)
        btnOpenSQL.ImageAlign = ContentAlignment.TopLeft
        btnOpenSQL.TextAlign = ContentAlignment.MiddleCenter
        Img = My.Resources.icons8_speichern_50
        btnSaveSQL.Image = Engine.ScaleImage(Img, 20, 20)
        btnSaveSQL.ImageAlign = ContentAlignment.TopLeft
        btnSaveSQL.TextAlign = ContentAlignment.MiddleCenter
        Img = My.Resources.icons8_neue_datei_50
        btnNewSQL.Image = Engine.ScaleImage(Img, 20, 20)
        btnNewSQL.ImageAlign = ContentAlignment.TopLeft
        btnNewSQL.TextAlign = ContentAlignment.MiddleCenter
        Img = My.Resources.icons8_datei_loeschen_50
        btnTableDelete.Image = Engine.ScaleImage(Img, 20, 20)
        btnTableDelete.ImageAlign = ContentAlignment.TopLeft
        btnTableDelete.TextAlign = ContentAlignment.MiddleRight
        Img = My.Resources.refresh
        btnRefresh.Image = Engine.ScaleImage(Img, 22, 22)
        btnRefresh.ImageAlign = ContentAlignment.TopLeft
        btnRefresh.TextAlign = ContentAlignment.MiddleCenter
        Img = My.Resources.icons8_speichern_50
        btnEditTable.Image = Engine.ScaleImage(Img, 22, 22)
        btnEditTable.ImageAlign = ContentAlignment.TopLeft
        btnEditTable.TextAlign = ContentAlignment.MiddleRight




        labelDBPath.Text = Globals.DBpath


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TreeViewDatabase_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewDatabase.AfterSelect
        Dim selectedNode As TreeNode = e.Node

        If selectedNode.Parent IsNot Nothing Then
            ' Unterknoten (Spalte) wurde ausgewählt
            Dim selectedTable As String = selectedNode.Parent.Text
            Dim selectedColumn As String = selectedNode.Text.Split("|"c)(0).Trim() ' Spaltenname extrahieren
            labelNode.Text = $"{selectedColumn}:"

            DBM.FillListViewWithColumnData(ListView1, selectedTable, selectedColumn)
        ElseIf selectedNode.Parent Is Nothing Then
            ' Hauptknoten (Tabellenname) wurde ausgewählt
            Dim selectedTable As String = selectedNode.Text
            labelNode.Text = $"{selectedNode.Text}:"

            DBM.FillListViewWithTableData(ListView1, selectedTable)
        Else
            ' Wurzelknoten oder ungültiger Knoten wurde ausgewählt
            ' 
            labelNode.Text = $"Inhalt:"
        End If
    End Sub


    Private Sub HighlightSyntax(rtfBox As RichTextBox)
        Dim keywords As String = "\b(SELECT|FROM|WHERE|JOIN|INNER|LEFT|RIGHT|ON|AND|OR|ORDER BY|GROUP BY|HAVING|INSERT INTO|VALUES|UPDATE|SET|DELETE FROM|CREATE TABLE|ALTER TABLE|DROP TABLE|PRIMARY KEY|FOREIGN KEY|REFERENCES|INDEX)\b"
        Dim stringLiterals As String = "'(?:[^'\\]|\\.)*'"

        Dim keywordRegex As New Regex(keywords, RegexOptions.IgnoreCase)            ' regular expressions -> Textmuster suchen, validieren, manipulieren 
        Dim stringRegex As New Regex(stringLiterals)

        Dim currentPosition As Integer = rtfBox.SelectionStart
        Dim originalColor As Color = Color.Black

        rtfBox.SelectAll()
        rtfBox.SelectionColor = originalColor

        ' SQL-Schlüsselwörter
        For Each match As Match In keywordRegex.Matches(rtfBox.Text)
            rtfBox.Select(match.Index, match.Length)
            rtfBox.SelectionColor = Color.Blue
        Next

        ' Zeichenfolgen 
        For Each match As Match In stringRegex.Matches(rtfBox.Text)
            rtfBox.Select(match.Index, match.Length)
            rtfBox.SelectionColor = Color.Green
        Next

        ' ursprüngliche Cursorposition und Farbe
        rtfBox.Select(currentPosition, 0)
        rtfBox.SelectionColor = originalColor
    End Sub

    Private Sub rtfRunSQL_TextChanged(sender As Object, e As EventArgs) Handles rtfRunSQL.TextChanged
        Dim rtfBox As RichTextBox = CType(sender, RichTextBox)
        HighlightSyntax(rtfBox)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DBM.FillTreeView(TreeViewDatabase)
        ListView1.Clear()
        labelNode.Text = "Inhalt:"
    End Sub

    Private Sub ComboBoxTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTables.SelectedIndexChanged
        Dim selectedTable As String = ComboBoxTables.SelectedItem.ToString()
        DBM.FillDataGridViewWithTable(DataGridViewTable, selectedTable)
        lastTable = CM.GetDataTableFromTable(ComboBoxTables.SelectedItem.ToString())
    End Sub

    Private Sub ComboBoxSqlStatements_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSqlStatements.SelectedIndexChanged
        ' Ermitteln der aktuell ausgewählten TabPage
        Dim selectedTab As TabPage = TabControlSQL.SelectedTab

        If selectedTab IsNot Nothing Then

            Dim rtfRunSQL As RichTextBox = selectedTab.Controls.OfType(Of RichTextBox)().FirstOrDefault()

            If rtfRunSQL IsNot Nothing Then

                Select Case ComboBoxSqlStatements.SelectedItem
                    Case "SelectAll"
                        rtfRunSQL.Text = Globals.SelectAll
                    Case "SelectWhere"
                        rtfRunSQL.Text = Globals.SelectWhere
                    Case "Insert"
                        rtfRunSQL.Text = Globals.Insert
                    Case "Update"
                        rtfRunSQL.Text = Globals.Update
                    Case "Delete"
                        rtfRunSQL.Text = Globals.Delete
                    Case Else
                        rtfRunSQL.Text = ""
                End Select
            End If
        End If
    End Sub


    Private Sub btnRunSQL_Click(sender As Object, e As EventArgs) Handles btnRunSQL.Click
        Try
            ' Extrahiere den Text aus der aktuell ausgewählten TabPage
            Dim selectedTab As TabPage = TabControlSQL.SelectedTab
            Dim rtfSQL As RichTextBox = TryCast(selectedTab.Controls.OfType(Of RichTextBox).FirstOrDefault(), RichTextBox)

            If rtfSQL Is Nothing Then
                Logger.WriteLine("FormDBManager: Run SQL clicked")
                Return
            End If

            Dim sqlQuery As String = rtfSQL.Text

            ' Führe die SQL-Abfrage aus
            Using connection As New SQLiteConnection(Globals.ConString)
                connection.Open()
                Using command As New SQLiteCommand(sqlQuery, connection)
                    Using adapter As New SQLiteDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        Logger.WriteLine("DataAdapter gefüllt..  zeige im DGV an")
                        DataGridViewSQL.DataSource = dataTable
                        rtfSQLAusgabe.Clear()
                        rtfSQLAusgabe.AppendText(dataTable.Rows.Count & " Zeile(n) betroffen.")
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            ' Zeige die Fehlermeldung in der rtfAusgabe RichTextBox an
            rtfSQLAusgabe.Clear()
            rtfSQLAusgabe.AppendText("Error executing SQL: " & ex.Message)
        End Try
    End Sub

    Private Sub btnNewSQL_Click(sender As Object, e As EventArgs) Handles btnNewSQL.Click
        Dim tabIndex As Integer = TabControlSQL.TabPages.Cast(Of TabPage)().Count(Function(tp) tp.Text.StartsWith("SQL"))
        Dim newTab As New TabPage($"SQL {tabIndex + 1}") With {
        .BorderStyle = BorderStyle.Fixed3D
        }

        Dim newRichTextBox As New RichTextBox With {
        .Dock = DockStyle.Fill,
        .BorderStyle = BorderStyle.Fixed3D
    }


        newTab.Controls.Add(newRichTextBox)
        AddHandler newRichTextBox.TextChanged, AddressOf rtfRunSQL_TextChanged
        TabControlSQL.TabPages.Add(newTab)

        TabControlSQL.SelectedTab = newTab
    End Sub

    Private Sub btnResetDB_Click(sender As Object, e As EventArgs) Handles btnResetDB.Click

    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click
        Dim about As New AboutBoxDBManager
        about.StartPosition = FormStartPosition.CenterParent
        about.ShowDialog()
    End Sub

    Private Sub CheckBoxResetDB_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxResetDB.CheckedChanged
        If CheckBoxResetDB.CheckState Then
            btnResetDB.Enabled = True
            Exit Sub
        End If
        btnResetDB.Enabled = False
    End Sub

    Private Sub btnSaveSQL_Click(sender As Object, e As EventArgs) Handles btnSaveSQL.Click

        Dim selectedTab As TabPage = TabControlSQL.SelectedTab

        If selectedTab IsNot Nothing Then

            Dim rtfRunSQL As RichTextBox = selectedTab.Controls.OfType(Of RichTextBox)().FirstOrDefault()

            If rtfRunSQL IsNot Nothing Then
                ' Erstellen des Dateinamens
                Dim currentDate As String = DateTime.Now.ToString("dd_MM_yy")
                Dim tabPageName As String = selectedTab.Text.Replace(" ", "_")
                Dim fileName As String = $"{currentDate}-{tabPageName}-liteVend.txt"

                ' Öffnen des Speichern-Dialogs
                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Text Dateien (*.txt)|*.txt"
                saveFileDialog.FileName = fileName

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    ' Speichern des Inhalts der RichTextBox in die Textdatei
                    Using writer As New StreamWriter(saveFileDialog.FileName)
                        writer.Write(rtfRunSQL.Text)
                    End Using

                    MessageBox.Show("Datei erfolgreich gespeichert.", "Speichern erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Es wurde keine RichTextBox in der aktiven TabPage gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Es wurde keine aktive TabPage ausgewählt.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnOpenSQL_Click(sender As Object, e As EventArgs) Handles btnOpenSQL.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text Dateien (*.txt)|*.txt"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName

            Dim selectedTab As TabPage = TabControlSQL.SelectedTab

            Dim rtfRunSQL As RichTextBox = Nothing

            Dim createNewTab As Boolean = False

            If selectedTab IsNot Nothing Then
                Dim result As DialogResult = MessageBox.Show("Möchten Sie die aktuelle Seite überschreiben?", "Öffnen", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then

                    rtfRunSQL = selectedTab.Controls.OfType(Of RichTextBox)().FirstOrDefault()
                    If rtfRunSQL Is Nothing Then
                        createNewTab = True
                    End If
                ElseIf result = DialogResult.No Then
                    createNewTab = True
                ElseIf result = DialogResult.Cancel Then
                    Return
                End If
            Else
                createNewTab = True
            End If

            If createNewTab Then

                Dim newTab As New TabPage("SQL " & (TabControlSQL.TabCount + 1))
                rtfRunSQL = New RichTextBox() With {
                    .Dock = DockStyle.Fill,
                    .BorderStyle = BorderStyle.Fixed3D
                }
                AddHandler rtfRunSQL.TextChanged, AddressOf rtfRunSQL_TextChanged
                newTab.Controls.Add(rtfRunSQL)
                TabControlSQL.TabPages.Add(newTab)
                TabControlSQL.SelectedTab = newTab
            End If


            Try
                rtfRunSQL.LoadFile(filePath, RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                MessageBox.Show($"Fehler beim Öffnen der Datei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnEditTable_Click(sender As Object, e As EventArgs) Handles btnEditTable.Click

        If ComboBoxTables.SelectedItem IsNot Nothing Then
            Dim tableName As String = ComboBoxTables.SelectedItem.ToString()


            Dim dgv As DataGridView = DataGridViewTable

            ' Überprüfen, ob das DataGridViewTable bearbeitet wurde
            If dgv.DataSource IsNot Nothing AndAlso TypeOf dgv.DataSource Is DataTable Then
                Dim dt As DataTable = DirectCast(dgv.DataSource, DataTable)

                Try

                    Using connection As New SQLiteConnection(Globals.ConString)
                        connection.Open()

                        ' Prüfen 'ID'-Spalte vorhanden
                        Dim hasIDColumn As Boolean = dt.Columns.Contains("ID")

                        ' Für jede Zeile UPDATE-Befehl ausführen
                        For Each row As DataRow In dt.Rows
                            If row.RowState = DataRowState.Modified Then
                                ' UPDATE-Befehl dynamisch erstellen
                                Dim updateCommand As New StringBuilder()
                                updateCommand.AppendFormat("UPDATE [{0}] SET ", tableName)

                                ' Spaltennamen und Parameter hinzufügen
                                Dim isFirstColumn As Boolean = True
                                For Each column As DataColumn In dt.Columns
                                    Dim columnName As String = column.ColumnName

                                    ' ID-Spalte ausschließen, falls vorhanden
                                    If Not columnName.Equals("ID", StringComparison.OrdinalIgnoreCase) Then
                                        If Not isFirstColumn Then
                                            updateCommand.Append(", ")
                                        Else
                                            isFirstColumn = False
                                        End If
                                        updateCommand.AppendFormat("[{0}] = @{0}", columnName)
                                    End If
                                Next

                                ' WHERE-Bedingung hinzufügen, wenn ID-Spalte vorhanden ist
                                If hasIDColumn Then
                                    updateCommand.AppendFormat(" WHERE [ID] = @ID")
                                End If


                                Using command As New SQLiteCommand(updateCommand.ToString(), connection)

                                    For Each column As DataColumn In dt.Columns
                                        If Not column.ColumnName.Equals("ID", StringComparison.OrdinalIgnoreCase) Then
                                            command.Parameters.AddWithValue($"@{column.ColumnName}", row(column.ColumnName))
                                        End If
                                    Next

                                    ' ID-Parameter hinzufügen, wenn ID-Spalte vorhanden ist
                                    If hasIDColumn Then
                                        command.Parameters.AddWithValue("@ID", row("ID"))
                                    End If

                                    ' Befehl ausführen
                                    command.ExecuteNonQuery()
                                End Using
                            End If
                        Next

                        ' Erfolgsmeldung anzeigen
                        MessageBox.Show($"Daten wurden erfolgreich in die Tabelle '{tableName}' aktualisiert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Catch ex As Exception
                    MessageBox.Show($"Fehler beim Aktualisieren der Daten in der Tabelle '{tableName}': {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Das DataGridViewTable ist nicht mit einer DataTable verbunden oder wurde nicht bearbeitet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Bitte wählen Sie eine Tabelle aus der ComboBox aus.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub btnResetTable_Click(sender As Object, e As EventArgs) Handles btnResetTable.Click
        If ComboBoxTables.SelectedIndex < 0 Then
            Exit Sub
        End If
        DataGridViewTable.DataSource = lastTable.Copy()
    End Sub

    Private Sub FormDBManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    End Sub
End Class
