<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDBManager
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDBManager))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.CheckBoxResetDB = New System.Windows.Forms.CheckBox()
        Me.btnResetDB = New System.Windows.Forms.Button()
        Me.PanelCreateTable = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.labelNode = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TreeViewDatabase = New System.Windows.Forms.TreeView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnResetTable = New System.Windows.Forms.Button()
        Me.btnEditTable = New System.Windows.Forms.Button()
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.ComboBoxTables = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBoxSqlStatements = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSaveSQL = New System.Windows.Forms.Button()
        Me.btnOpenSQL = New System.Windows.Forms.Button()
        Me.btnNewSQL = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridViewSQL = New System.Windows.Forms.DataGridView()
        Me.btnRunSQL = New System.Windows.Forms.Button()
        Me.rtfSQLAusgabe = New System.Windows.Forms.RichTextBox()
        Me.labelDBPath = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RoundButton1 = New Getränke_Automat_V2.RoundButton()
        Me.TabControlSQL = New Getränke_Automat_V2.CustomTabControl()
        Me.SQL1 = New System.Windows.Forms.TabPage()
        Me.rtfRunSQL = New System.Windows.Forms.RichTextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.PanelCreateTable.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridViewSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlSQL.SuspendLayout()
        Me.SQL1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(7, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(782, 457)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.RoundButton1)
        Me.TabPage1.Controls.Add(Me.btnRefresh)
        Me.TabPage1.Controls.Add(Me.Panel7)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Panel8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(774, 431)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datenbankstruktur"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(414, 34)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(126, 31)
        Me.btnRefresh.TabIndex = 33
        Me.btnRefresh.Text = "Aktualisieren"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.CheckBoxResetDB)
        Me.Panel7.Controls.Add(Me.btnResetDB)
        Me.Panel7.Controls.Add(Me.PanelCreateTable)
        Me.Panel7.Location = New System.Drawing.Point(203, 66)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(570, 366)
        Me.Panel7.TabIndex = 42
        '
        'CheckBoxResetDB
        '
        Me.CheckBoxResetDB.AutoSize = True
        Me.CheckBoxResetDB.Location = New System.Drawing.Point(399, 319)
        Me.CheckBoxResetDB.Name = "CheckBoxResetDB"
        Me.CheckBoxResetDB.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxResetDB.TabIndex = 36
        Me.CheckBoxResetDB.UseVisualStyleBackColor = True
        '
        'btnResetDB
        '
        Me.btnResetDB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnResetDB.Enabled = False
        Me.btnResetDB.FlatAppearance.BorderColor = System.Drawing.Color.Brown
        Me.btnResetDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetDB.ForeColor = System.Drawing.Color.Brown
        Me.btnResetDB.Location = New System.Drawing.Point(178, 306)
        Me.btnResetDB.Name = "btnResetDB"
        Me.btnResetDB.Size = New System.Drawing.Size(215, 37)
        Me.btnResetDB.TabIndex = 35
        Me.btnResetDB.Text = "Datenbank zurücksetzten"
        Me.btnResetDB.UseVisualStyleBackColor = False
        '
        'PanelCreateTable
        '
        Me.PanelCreateTable.Controls.Add(Me.ListView1)
        Me.PanelCreateTable.Controls.Add(Me.labelNode)
        Me.PanelCreateTable.Location = New System.Drawing.Point(14, 4)
        Me.PanelCreateTable.Name = "PanelCreateTable"
        Me.PanelCreateTable.Size = New System.Drawing.Size(545, 296)
        Me.PanelCreateTable.TabIndex = 34
        '
        'ListView1
        '
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 33)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(545, 263)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'labelNode
        '
        Me.labelNode.AutoSize = True
        Me.labelNode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNode.ForeColor = System.Drawing.Color.Black
        Me.labelNode.Location = New System.Drawing.Point(3, 6)
        Me.labelNode.Name = "labelNode"
        Me.labelNode.Size = New System.Drawing.Size(59, 24)
        Me.labelNode.TabIndex = 32
        Me.labelNode.Text = "Inhalt:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(352, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(325, 29)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Datenbank Controller | SQlite"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(187, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(17, 433)
        Me.Panel1.TabIndex = 35
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.TreeViewDatabase)
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(190, 426)
        Me.Panel8.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(34, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 29)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Tabellen"
        '
        'TreeViewDatabase
        '
        Me.TreeViewDatabase.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TreeViewDatabase.Location = New System.Drawing.Point(15, 52)
        Me.TreeViewDatabase.Name = "TreeViewDatabase"
        Me.TreeViewDatabase.Size = New System.Drawing.Size(154, 359)
        Me.TreeViewDatabase.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.btnResetTable)
        Me.TabPage2.Controls.Add(Me.btnEditTable)
        Me.TabPage2.Controls.Add(Me.DataGridViewTable)
        Me.TabPage2.Controls.Add(Me.ComboBoxTables)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(774, 431)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Daten bearbeiten"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(499, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 22)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nur Änderungen möglich"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(-2, 49)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(778, 17)
        Me.Panel4.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Tabelle:"
        '
        'btnResetTable
        '
        Me.btnResetTable.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnResetTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetTable.Location = New System.Drawing.Point(248, 378)
        Me.btnResetTable.Name = "btnResetTable"
        Me.btnResetTable.Size = New System.Drawing.Size(178, 36)
        Me.btnResetTable.TabIndex = 4
        Me.btnResetTable.Text = "Änderungen verwerfen"
        Me.btnResetTable.UseVisualStyleBackColor = False
        '
        'btnEditTable
        '
        Me.btnEditTable.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditTable.Location = New System.Drawing.Point(26, 378)
        Me.btnEditTable.Name = "btnEditTable"
        Me.btnEditTable.Size = New System.Drawing.Size(178, 36)
        Me.btnEditTable.TabIndex = 3
        Me.btnEditTable.Text = "Änderungen schreiben"
        Me.btnEditTable.UseVisualStyleBackColor = False
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.Location = New System.Drawing.Point(21, 82)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.Size = New System.Drawing.Size(730, 286)
        Me.DataGridViewTable.TabIndex = 2
        '
        'ComboBoxTables
        '
        Me.ComboBoxTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTables.FormattingEnabled = True
        Me.ComboBoxTables.Location = New System.Drawing.Point(111, 16)
        Me.ComboBoxTables.Name = "ComboBoxTables"
        Me.ComboBoxTables.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTables.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Controls.Add(Me.ComboBoxSqlStatements)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.btnSaveSQL)
        Me.TabPage3.Controls.Add(Me.btnOpenSQL)
        Me.TabPage3.Controls.Add(Me.btnNewSQL)
        Me.TabPage3.Controls.Add(Me.Panel5)
        Me.TabPage3.Controls.Add(Me.DataGridViewSQL)
        Me.TabPage3.Controls.Add(Me.btnRunSQL)
        Me.TabPage3.Controls.Add(Me.rtfSQLAusgabe)
        Me.TabPage3.Controls.Add(Me.TabControlSQL)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(774, 431)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "SQL ausführen"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(-1, 239)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(778, 17)
        Me.Panel3.TabIndex = 42
        '
        'ComboBoxSqlStatements
        '
        Me.ComboBoxSqlStatements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSqlStatements.FormattingEnabled = True
        Me.ComboBoxSqlStatements.Items.AddRange(New Object() {"-", "SelectAll", "SelectWhere", "Insert", "Update", "Delete"})
        Me.ComboBoxSqlStatements.Location = New System.Drawing.Point(144, 15)
        Me.ComboBoxSqlStatements.Name = "ComboBoxSqlStatements"
        Me.ComboBoxSqlStatements.Size = New System.Drawing.Size(96, 21)
        Me.ComboBoxSqlStatements.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 18)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "SQL-Statements"
        '
        'btnSaveSQL
        '
        Me.btnSaveSQL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSaveSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveSQL.Location = New System.Drawing.Point(691, 9)
        Me.btnSaveSQL.Name = "btnSaveSQL"
        Me.btnSaveSQL.Size = New System.Drawing.Size(69, 32)
        Me.btnSaveSQL.TabIndex = 38
        Me.btnSaveSQL.Text = "Save"
        Me.btnSaveSQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveSQL.UseVisualStyleBackColor = False
        '
        'btnOpenSQL
        '
        Me.btnOpenSQL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOpenSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpenSQL.Location = New System.Drawing.Point(572, 9)
        Me.btnOpenSQL.Name = "btnOpenSQL"
        Me.btnOpenSQL.Size = New System.Drawing.Size(69, 32)
        Me.btnOpenSQL.TabIndex = 39
        Me.btnOpenSQL.Text = "Open"
        Me.btnOpenSQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOpenSQL.UseVisualStyleBackColor = False
        '
        'btnNewSQL
        '
        Me.btnNewSQL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNewSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewSQL.Location = New System.Drawing.Point(497, 9)
        Me.btnNewSQL.Name = "btnNewSQL"
        Me.btnNewSQL.Size = New System.Drawing.Size(69, 32)
        Me.btnNewSQL.TabIndex = 41
        Me.btnNewSQL.Text = "Neu"
        Me.btnNewSQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNewSQL.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(-2, 49)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(778, 17)
        Me.Panel5.TabIndex = 37
        '
        'DataGridViewSQL
        '
        Me.DataGridViewSQL.AllowUserToAddRows = False
        Me.DataGridViewSQL.AllowUserToDeleteRows = False
        Me.DataGridViewSQL.AllowUserToResizeColumns = False
        Me.DataGridViewSQL.AllowUserToResizeRows = False
        Me.DataGridViewSQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewSQL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewSQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewSQL.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridViewSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSQL.Location = New System.Drawing.Point(11, 265)
        Me.DataGridViewSQL.Name = "DataGridViewSQL"
        Me.DataGridViewSQL.RowHeadersVisible = False
        Me.DataGridViewSQL.Size = New System.Drawing.Size(749, 82)
        Me.DataGridViewSQL.TabIndex = 36
        '
        'btnRunSQL
        '
        Me.btnRunSQL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRunSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRunSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunSQL.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnRunSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRunSQL.Location = New System.Drawing.Point(292, 9)
        Me.btnRunSQL.Name = "btnRunSQL"
        Me.btnRunSQL.Size = New System.Drawing.Size(95, 32)
        Me.btnRunSQL.TabIndex = 34
        Me.btnRunSQL.Text = "Run SQL"
        Me.btnRunSQL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRunSQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRunSQL.UseVisualStyleBackColor = False
        '
        'rtfSQLAusgabe
        '
        Me.rtfSQLAusgabe.Location = New System.Drawing.Point(11, 350)
        Me.rtfSQLAusgabe.Name = "rtfSQLAusgabe"
        Me.rtfSQLAusgabe.Size = New System.Drawing.Size(749, 52)
        Me.rtfSQLAusgabe.TabIndex = 6
        Me.rtfSQLAusgabe.Text = ""
        '
        'labelDBPath
        '
        Me.labelDBPath.AutoSize = True
        Me.labelDBPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDBPath.ForeColor = System.Drawing.Color.Black
        Me.labelDBPath.Location = New System.Drawing.Point(112, 6)
        Me.labelDBPath.Name = "labelDBPath"
        Me.labelDBPath.Size = New System.Drawing.Size(11, 15)
        Me.labelDBPath.TabIndex = 40
        Me.labelDBPath.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(33, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Datenbank: "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.labelDBPath)
        Me.Panel2.Controls.Add(Me.btnMinimize)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(801, 25)
        Me.Panel2.TabIndex = 5
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnMinimize.Location = New System.Drawing.Point(751, 1)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(24, 24)
        Me.btnMinimize.TabIndex = 5
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Brown
        Me.btnClose.Location = New System.Drawing.Point(776, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 24)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Getränke_Automat_V2.My.Resources.Resources._6220416
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(4, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 21)
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'RoundButton1
        '
        Me.RoundButton1.BackgroundImage = Global.Getränke_Automat_V2.My.Resources.Resources.icons8_info_16
        Me.RoundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RoundButton1.FlatAppearance.BorderSize = 0
        Me.RoundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoundButton1.Location = New System.Drawing.Point(738, 10)
        Me.RoundButton1.Name = "RoundButton1"
        Me.RoundButton1.Size = New System.Drawing.Size(23, 23)
        Me.RoundButton1.TabIndex = 44
        Me.RoundButton1.UseVisualStyleBackColor = True
        '
        'TabControlSQL
        '
        Me.TabControlSQL.Controls.Add(Me.SQL1)
        Me.TabControlSQL.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControlSQL.ItemSize = New System.Drawing.Size(150, 20)
        Me.TabControlSQL.Location = New System.Drawing.Point(3, 72)
        Me.TabControlSQL.Name = "TabControlSQL"
        Me.TabControlSQL.SelectedIndex = 0
        Me.TabControlSQL.Size = New System.Drawing.Size(763, 161)
        Me.TabControlSQL.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControlSQL.TabIndex = 40
        '
        'SQL1
        '
        Me.SQL1.BackColor = System.Drawing.Color.Gainsboro
        Me.SQL1.Controls.Add(Me.rtfRunSQL)
        Me.SQL1.Location = New System.Drawing.Point(4, 24)
        Me.SQL1.Name = "SQL1"
        Me.SQL1.Padding = New System.Windows.Forms.Padding(3)
        Me.SQL1.Size = New System.Drawing.Size(755, 133)
        Me.SQL1.TabIndex = 0
        Me.SQL1.Text = "SQL 1"
        '
        'rtfRunSQL
        '
        Me.rtfRunSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtfRunSQL.Location = New System.Drawing.Point(3, 3)
        Me.rtfRunSQL.Name = "rtfRunSQL"
        Me.rtfRunSQL.Size = New System.Drawing.Size(749, 127)
        Me.rtfRunSQL.TabIndex = 4
        Me.rtfRunSQL.Text = ""
        '
        'FormDBManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDBManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datenbank-Manager KolaKonnect"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.PanelCreateTable.ResumeLayout(False)
        Me.PanelCreateTable.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridViewSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlSQL.ResumeLayout(False)
        Me.SQL1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TreeViewDatabase As TreeView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents ComboBoxTables As ComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents rtfRunSQL As RichTextBox
    Friend WithEvents rtfSQLAusgabe As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnMinimize As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents labelNode As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PanelCreateTable As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnResetTable As Button
    Friend WithEvents btnEditTable As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxSqlStatements As ComboBox
    Friend WithEvents btnRunSQL As Button
    Friend WithEvents DataGridViewSQL As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents labelDBPath As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnOpenSQL As Button
    Friend WithEvents btnSaveSQL As Button
    Friend WithEvents TabControlSQL As CustomTabControl
    Friend WithEvents SQL1 As TabPage
    Friend WithEvents btnNewSQL As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnResetDB As Button
    Friend WithEvents CheckBoxResetDB As CheckBox
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
End Class
