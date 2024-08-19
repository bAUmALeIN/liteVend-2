<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMainMenu))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPageMain = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.btnVendingMode = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.labelStatusDB = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TabPageAdd = New System.Windows.Forms.TabPage()
        Me.PanelAdd = New System.Windows.Forms.Panel()
        Me.cbImage = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tbBez = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnAddAddImage = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tbV = New System.Windows.Forms.TextBox()
        Me.tbAlk = New System.Windows.Forms.TextBox()
        Me.tbPreis = New System.Windows.Forms.TextBox()
        Me.PictureBoxAdd = New System.Windows.Forms.PictureBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TabPageEdit = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelEdit = New System.Windows.Forms.Panel()
        Me.checkBoxEdit = New System.Windows.Forms.CheckBox()
        Me.ComboBoxEditID = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbEditBez = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnOpenImageEdit = New System.Windows.Forms.Button()
        Me.btnSaveEdit = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbEditV = New System.Windows.Forms.TextBox()
        Me.tbEditAlk = New System.Windows.Forms.TextBox()
        Me.tbEditPreis = New System.Windows.Forms.TextBox()
        Me.PictureBoxEdit = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPageDatabase = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PanelTabPageDatabaseTrenner1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelTabPageDatabase = New System.Windows.Forms.Panel()
        Me.btnProduktOverview = New System.Windows.Forms.Button()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbStatsGesUmsatz = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbStatsAnzFlaschen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbStatsAnzTrans = New System.Windows.Forms.TextBox()
        Me.LabelAnzProd = New System.Windows.Forms.Label()
        Me.tbStatsAnzProd = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TimerCheckTBAdd = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnShowLog = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabPageMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabPageAdd.SuspendLayout()
        Me.PanelAdd.SuspendLayout()
        CType(Me.PictureBoxAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.TabPageEdit.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelEdit.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBoxEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDatabase.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelTabPageDatabaseTrenner1.SuspendLayout()
        Me.PanelTabPageDatabase.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPageMain)
        Me.TabControl1.Controls.Add(Me.TabPageAdd)
        Me.TabControl1.Controls.Add(Me.TabPageEdit)
        Me.TabControl1.Controls.Add(Me.TabPageDatabase)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(323, 346)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 3
        '
        'tabPageMain
        '
        Me.tabPageMain.BackColor = System.Drawing.Color.Gainsboro
        Me.tabPageMain.Controls.Add(Me.btnShowLog)
        Me.tabPageMain.Controls.Add(Me.Panel1)
        Me.tabPageMain.Controls.Add(Me.btnVendingMode)
        Me.tabPageMain.Controls.Add(Me.Label13)
        Me.tabPageMain.Controls.Add(Me.Button1)
        Me.tabPageMain.Controls.Add(Me.labelStatusDB)
        Me.tabPageMain.Controls.Add(Me.Panel7)
        Me.tabPageMain.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tabPageMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPageMain.Location = New System.Drawing.Point(4, 24)
        Me.tabPageMain.Name = "tabPageMain"
        Me.tabPageMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageMain.Size = New System.Drawing.Size(315, 318)
        Me.tabPageMain.TabIndex = 0
        Me.tabPageMain.Text = "Start"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label35)
        Me.Panel1.Location = New System.Drawing.Point(0, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 31)
        Me.Panel1.TabIndex = 34
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(21, 1)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(254, 29)
        Me.Label35.TabIndex = 32
        Me.Label35.Text = "Datenbank Verwaltung"
        '
        'btnVendingMode
        '
        Me.btnVendingMode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnVendingMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVendingMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendingMode.Location = New System.Drawing.Point(87, 48)
        Me.btnVendingMode.Name = "btnVendingMode"
        Me.btnVendingMode.Size = New System.Drawing.Size(152, 50)
        Me.btnVendingMode.TabIndex = 1
        Me.btnVendingMode.Text = "Automat"
        Me.btnVendingMode.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(94, 286)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 16)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Status Datenbank:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(77, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Controller"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'labelStatusDB
        '
        Me.labelStatusDB.AutoSize = True
        Me.labelStatusDB.BackColor = System.Drawing.Color.Silver
        Me.labelStatusDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStatusDB.ForeColor = System.Drawing.Color.Red
        Me.labelStatusDB.Location = New System.Drawing.Point(218, 287)
        Me.labelStatusDB.Name = "labelStatusDB"
        Me.labelStatusDB.Size = New System.Drawing.Size(11, 16)
        Me.labelStatusDB.TabIndex = 17
        Me.labelStatusDB.Text = "-"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gray
        Me.Panel7.Controls.Add(Me.Label43)
        Me.Panel7.Location = New System.Drawing.Point(0, 1)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(323, 31)
        Me.Panel7.TabIndex = 24
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.White
        Me.Label43.Location = New System.Drawing.Point(132, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(62, 29)
        Me.Label43.TabIndex = 32
        Me.Label43.Text = "Start"
        '
        'TabPageAdd
        '
        Me.TabPageAdd.Controls.Add(Me.PanelAdd)
        Me.TabPageAdd.Location = New System.Drawing.Point(4, 24)
        Me.TabPageAdd.Name = "TabPageAdd"
        Me.TabPageAdd.Size = New System.Drawing.Size(315, 318)
        Me.TabPageAdd.TabIndex = 3
        Me.TabPageAdd.Text = "Anlegen"
        Me.TabPageAdd.UseVisualStyleBackColor = True
        '
        'PanelAdd
        '
        Me.PanelAdd.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelAdd.Controls.Add(Me.cbImage)
        Me.PanelAdd.Controls.Add(Me.btnSave)
        Me.PanelAdd.Controls.Add(Me.Label34)
        Me.PanelAdd.Controls.Add(Me.tbID)
        Me.PanelAdd.Controls.Add(Me.Label27)
        Me.PanelAdd.Controls.Add(Me.tbBez)
        Me.PanelAdd.Controls.Add(Me.Label28)
        Me.PanelAdd.Controls.Add(Me.Label29)
        Me.PanelAdd.Controls.Add(Me.Label30)
        Me.PanelAdd.Controls.Add(Me.btnAddAddImage)
        Me.PanelAdd.Controls.Add(Me.Label31)
        Me.PanelAdd.Controls.Add(Me.Label32)
        Me.PanelAdd.Controls.Add(Me.Label33)
        Me.PanelAdd.Controls.Add(Me.tbV)
        Me.PanelAdd.Controls.Add(Me.tbAlk)
        Me.PanelAdd.Controls.Add(Me.tbPreis)
        Me.PanelAdd.Controls.Add(Me.PictureBoxAdd)
        Me.PanelAdd.Controls.Add(Me.Label38)
        Me.PanelAdd.Controls.Add(Me.Panel5)
        Me.PanelAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAdd.Location = New System.Drawing.Point(0, 0)
        Me.PanelAdd.Name = "PanelAdd"
        Me.PanelAdd.Size = New System.Drawing.Size(315, 318)
        Me.PanelAdd.TabIndex = 24
        '
        'cbImage
        '
        Me.cbImage.AutoSize = True
        Me.cbImage.Location = New System.Drawing.Point(129, 240)
        Me.cbImage.Name = "cbImage"
        Me.cbImage.Size = New System.Drawing.Size(47, 19)
        Me.cbImage.TabIndex = 6
        Me.cbImage.Text = "Bild"
        Me.cbImage.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(28, 262)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 29)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Speichern"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(78, 212)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(23, 16)
        Me.Label34.TabIndex = 48
        Me.Label34.Text = "ID:"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(109, 211)
        Me.tbID.Name = "tbID"
        Me.tbID.ReadOnly = True
        Me.tbID.Size = New System.Drawing.Size(36, 21)
        Me.tbID.TabIndex = 5
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(65, 85)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(36, 16)
        Me.Label27.TabIndex = 46
        Me.Label27.Text = "Bez.:"
        '
        'tbBez
        '
        Me.tbBez.Location = New System.Drawing.Point(13, 103)
        Me.tbBez.Name = "tbBez"
        Me.tbBez.Size = New System.Drawing.Size(133, 21)
        Me.tbBez.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(149, 188)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(19, 16)
        Me.Label28.TabIndex = 44
        Me.Label28.Text = "%"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(148, 164)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(27, 16)
        Me.Label29.TabIndex = 43
        Me.Label29.Text = "in L"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(151, 137)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(14, 16)
        Me.Label30.TabIndex = 42
        Me.Label30.Text = "€"
        '
        'btnAddAddImage
        '
        Me.btnAddAddImage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddAddImage.Enabled = False
        Me.btnAddAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAddImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAddImage.Location = New System.Drawing.Point(192, 296)
        Me.btnAddAddImage.Name = "btnAddAddImage"
        Me.btnAddAddImage.Size = New System.Drawing.Size(105, 21)
        Me.btnAddAddImage.TabIndex = 8
        Me.btnAddAddImage.Text = "Durchsuchen"
        Me.btnAddAddImage.UseVisualStyleBackColor = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(5, 186)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(92, 16)
        Me.Label31.TabIndex = 40
        Me.Label31.Text = "Alkoholgehalt:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(35, 160)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(63, 16)
        Me.Label32.TabIndex = 39
        Me.Label32.Text = "Volumen:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(58, 135)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(41, 16)
        Me.Label33.TabIndex = 38
        Me.Label33.Text = "Preis:"
        '
        'tbV
        '
        Me.tbV.Location = New System.Drawing.Point(109, 159)
        Me.tbV.Name = "tbV"
        Me.tbV.Size = New System.Drawing.Size(36, 21)
        Me.tbV.TabIndex = 3
        '
        'tbAlk
        '
        Me.tbAlk.Location = New System.Drawing.Point(109, 185)
        Me.tbAlk.Name = "tbAlk"
        Me.tbAlk.Size = New System.Drawing.Size(36, 21)
        Me.tbAlk.TabIndex = 4
        '
        'tbPreis
        '
        Me.tbPreis.Location = New System.Drawing.Point(109, 134)
        Me.tbPreis.Name = "tbPreis"
        Me.tbPreis.Size = New System.Drawing.Size(36, 21)
        Me.tbPreis.TabIndex = 2
        '
        'PictureBoxAdd
        '
        Me.PictureBoxAdd.BackgroundImage = Global.Getränke_Automat_V2.My.Resources.Resources.Dose
        Me.PictureBoxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxAdd.Location = New System.Drawing.Point(180, 86)
        Me.PictureBoxAdd.Name = "PictureBoxAdd"
        Me.PictureBoxAdd.Size = New System.Drawing.Size(127, 204)
        Me.PictureBoxAdd.TabIndex = 34
        Me.PictureBoxAdd.TabStop = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(9, 9)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(223, 29)
        Me.Label38.TabIndex = 31
        Me.Label38.Text = "Stammsatz anlegen"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gray
        Me.Panel5.Controls.Add(Me.Label37)
        Me.Panel5.Location = New System.Drawing.Point(-4, 52)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(323, 31)
        Me.Panel5.TabIndex = 23
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(11, 1)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(242, 29)
        Me.Label37.TabIndex = 32
        Me.Label37.Text = "Produktinformationen"
        '
        'TabPageEdit
        '
        Me.TabPageEdit.Controls.Add(Me.Panel4)
        Me.TabPageEdit.Location = New System.Drawing.Point(4, 24)
        Me.TabPageEdit.Name = "TabPageEdit"
        Me.TabPageEdit.Size = New System.Drawing.Size(315, 318)
        Me.TabPageEdit.TabIndex = 2
        Me.TabPageEdit.Text = "Bearbeiten"
        Me.TabPageEdit.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.PanelEdit)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.ComboBox2)
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(315, 318)
        Me.Panel4.TabIndex = 1
        '
        'PanelEdit
        '
        Me.PanelEdit.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelEdit.Controls.Add(Me.checkBoxEdit)
        Me.PanelEdit.Controls.Add(Me.ComboBoxEditID)
        Me.PanelEdit.Controls.Add(Me.Label20)
        Me.PanelEdit.Controls.Add(Me.Panel6)
        Me.PanelEdit.Controls.Add(Me.Label25)
        Me.PanelEdit.Controls.Add(Me.Label19)
        Me.PanelEdit.Controls.Add(Me.tbEditBez)
        Me.PanelEdit.Controls.Add(Me.Label24)
        Me.PanelEdit.Controls.Add(Me.Label23)
        Me.PanelEdit.Controls.Add(Me.Label22)
        Me.PanelEdit.Controls.Add(Me.btnOpenImageEdit)
        Me.PanelEdit.Controls.Add(Me.btnSaveEdit)
        Me.PanelEdit.Controls.Add(Me.Label21)
        Me.PanelEdit.Controls.Add(Me.Label17)
        Me.PanelEdit.Controls.Add(Me.Label18)
        Me.PanelEdit.Controls.Add(Me.tbEditV)
        Me.PanelEdit.Controls.Add(Me.tbEditAlk)
        Me.PanelEdit.Controls.Add(Me.tbEditPreis)
        Me.PanelEdit.Controls.Add(Me.PictureBoxEdit)
        Me.PanelEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEdit.Location = New System.Drawing.Point(0, 0)
        Me.PanelEdit.Name = "PanelEdit"
        Me.PanelEdit.Size = New System.Drawing.Size(315, 318)
        Me.PanelEdit.TabIndex = 20
        '
        'checkBoxEdit
        '
        Me.checkBoxEdit.AutoSize = True
        Me.checkBoxEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBoxEdit.ForeColor = System.Drawing.Color.Black
        Me.checkBoxEdit.Location = New System.Drawing.Point(129, 240)
        Me.checkBoxEdit.Name = "checkBoxEdit"
        Me.checkBoxEdit.Size = New System.Drawing.Size(44, 17)
        Me.checkBoxEdit.TabIndex = 6
        Me.checkBoxEdit.Text = "Edit"
        Me.checkBoxEdit.UseVisualStyleBackColor = True
        '
        'ComboBoxEditID
        '
        Me.ComboBoxEditID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEditID.FormattingEnabled = True
        Me.ComboBoxEditID.Location = New System.Drawing.Point(82, 86)
        Me.ComboBoxEditID.Name = "ComboBoxEditID"
        Me.ComboBoxEditID.Size = New System.Drawing.Size(64, 23)
        Me.ComboBoxEditID.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(49, 87)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(26, 18)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "ID:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gray
        Me.Panel6.Controls.Add(Me.Label26)
        Me.Panel6.Location = New System.Drawing.Point(0, 52)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(317, 31)
        Me.Panel6.TabIndex = 31
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(7, 1)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(242, 29)
        Me.Label26.TabIndex = 32
        Me.Label26.Text = "Produktinformationen"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(9, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(252, 29)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "Stammsatz bearbeiten"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(64, 197)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 16)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Bez.:"
        '
        'tbEditBez
        '
        Me.tbEditBez.Enabled = False
        Me.tbEditBez.Location = New System.Drawing.Point(12, 215)
        Me.tbEditBez.Name = "tbEditBez"
        Me.tbEditBez.Size = New System.Drawing.Size(133, 21)
        Me.tbEditBez.TabIndex = 5
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(149, 171)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(19, 16)
        Me.Label24.TabIndex = 26
        Me.Label24.Text = "%"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(148, 147)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 16)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "in L"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(151, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 16)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "€"
        '
        'btnOpenImageEdit
        '
        Me.btnOpenImageEdit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOpenImageEdit.Enabled = False
        Me.btnOpenImageEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenImageEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenImageEdit.Location = New System.Drawing.Point(192, 296)
        Me.btnOpenImageEdit.Name = "btnOpenImageEdit"
        Me.btnOpenImageEdit.Size = New System.Drawing.Size(105, 21)
        Me.btnOpenImageEdit.TabIndex = 8
        Me.btnOpenImageEdit.Text = "Durchsuchen"
        Me.btnOpenImageEdit.UseVisualStyleBackColor = False
        '
        'btnSaveEdit
        '
        Me.btnSaveEdit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSaveEdit.Enabled = False
        Me.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveEdit.Location = New System.Drawing.Point(28, 262)
        Me.btnSaveEdit.Name = "btnSaveEdit"
        Me.btnSaveEdit.Size = New System.Drawing.Size(105, 29)
        Me.btnSaveEdit.TabIndex = 7
        Me.btnSaveEdit.Text = "Speichern"
        Me.btnSaveEdit.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 169)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 16)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "Alkoholgehalt:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(35, 143)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 16)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Volumen:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(58, 118)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 16)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Preis:"
        '
        'tbEditV
        '
        Me.tbEditV.Enabled = False
        Me.tbEditV.Location = New System.Drawing.Point(109, 142)
        Me.tbEditV.Name = "tbEditV"
        Me.tbEditV.Size = New System.Drawing.Size(36, 21)
        Me.tbEditV.TabIndex = 3
        '
        'tbEditAlk
        '
        Me.tbEditAlk.Enabled = False
        Me.tbEditAlk.Location = New System.Drawing.Point(109, 168)
        Me.tbEditAlk.Name = "tbEditAlk"
        Me.tbEditAlk.Size = New System.Drawing.Size(36, 21)
        Me.tbEditAlk.TabIndex = 4
        '
        'tbEditPreis
        '
        Me.tbEditPreis.Enabled = False
        Me.tbEditPreis.Location = New System.Drawing.Point(109, 117)
        Me.tbEditPreis.Name = "tbEditPreis"
        Me.tbEditPreis.Size = New System.Drawing.Size(36, 21)
        Me.tbEditPreis.TabIndex = 2
        '
        'PictureBoxEdit
        '
        Me.PictureBoxEdit.BackgroundImage = Global.Getränke_Automat_V2.My.Resources.Resources.Dose
        Me.PictureBoxEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxEdit.Location = New System.Drawing.Point(180, 86)
        Me.PictureBoxEdit.Name = "PictureBoxEdit"
        Me.PictureBoxEdit.Size = New System.Drawing.Size(127, 204)
        Me.PictureBoxEdit.TabIndex = 0
        Me.PictureBoxEdit.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 111)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 16)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Volumen:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(29, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 16)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Preis:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(128, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 16)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Bez.:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 16)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "ID:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(80, 110)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(57, 21)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(80, 136)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(57, 21)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(80, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(57, 21)
        Me.TextBox1.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(173, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(109, 23)
        Me.ComboBox2.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(36, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(50, 23)
        Me.ComboBox1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(152, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 141)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPageDatabase
        '
        Me.TabPageDatabase.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPageDatabase.Controls.Add(Me.Panel3)
        Me.TabPageDatabase.Controls.Add(Me.PanelTabPageDatabaseTrenner1)
        Me.TabPageDatabase.Controls.Add(Me.PanelTabPageDatabase)
        Me.TabPageDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageDatabase.Location = New System.Drawing.Point(4, 24)
        Me.TabPageDatabase.Name = "TabPageDatabase"
        Me.TabPageDatabase.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDatabase.Size = New System.Drawing.Size(315, 318)
        Me.TabPageDatabase.TabIndex = 1
        Me.TabPageDatabase.Text = "Übersicht"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(-4, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(317, 31)
        Me.Panel3.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(96, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 24)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Artikelstatistik"
        '
        'PanelTabPageDatabaseTrenner1
        '
        Me.PanelTabPageDatabaseTrenner1.BackColor = System.Drawing.Color.Gray
        Me.PanelTabPageDatabaseTrenner1.Controls.Add(Me.Label6)
        Me.PanelTabPageDatabaseTrenner1.Location = New System.Drawing.Point(2, 166)
        Me.PanelTabPageDatabaseTrenner1.Name = "PanelTabPageDatabaseTrenner1"
        Me.PanelTabPageDatabaseTrenner1.Size = New System.Drawing.Size(317, 31)
        Me.PanelTabPageDatabaseTrenner1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(67, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Umsatz Statistiken"
        '
        'PanelTabPageDatabase
        '
        Me.PanelTabPageDatabase.Controls.Add(Me.btnProduktOverview)
        Me.PanelTabPageDatabase.Controls.Add(Me.Label42)
        Me.PanelTabPageDatabase.Controls.Add(Me.Label41)
        Me.PanelTabPageDatabase.Controls.Add(Me.Label9)
        Me.PanelTabPageDatabase.Controls.Add(Me.Label7)
        Me.PanelTabPageDatabase.Controls.Add(Me.Label8)
        Me.PanelTabPageDatabase.Controls.Add(Me.tbStatsGesUmsatz)
        Me.PanelTabPageDatabase.Controls.Add(Me.Label4)
        Me.PanelTabPageDatabase.Controls.Add(Me.Label5)
        Me.PanelTabPageDatabase.Controls.Add(Me.tbStatsAnzFlaschen)
        Me.PanelTabPageDatabase.Controls.Add(Me.Label3)
        Me.PanelTabPageDatabase.Controls.Add(Me.Label2)
        Me.PanelTabPageDatabase.Controls.Add(Me.Label1)
        Me.PanelTabPageDatabase.Controls.Add(Me.tbStatsAnzTrans)
        Me.PanelTabPageDatabase.Controls.Add(Me.LabelAnzProd)
        Me.PanelTabPageDatabase.Controls.Add(Me.tbStatsAnzProd)
        Me.PanelTabPageDatabase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTabPageDatabase.Location = New System.Drawing.Point(3, 3)
        Me.PanelTabPageDatabase.Name = "PanelTabPageDatabase"
        Me.PanelTabPageDatabase.Size = New System.Drawing.Size(309, 312)
        Me.PanelTabPageDatabase.TabIndex = 0
        '
        'btnProduktOverview
        '
        Me.btnProduktOverview.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnProduktOverview.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnProduktOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduktOverview.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduktOverview.Location = New System.Drawing.Point(74, 258)
        Me.btnProduktOverview.Name = "btnProduktOverview"
        Me.btnProduktOverview.Size = New System.Drawing.Size(151, 29)
        Me.btnProduktOverview.TabIndex = 1
        Me.btnProduktOverview.Text = "Produktübersicht"
        Me.btnProduktOverview.UseVisualStyleBackColor = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(10, 296)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(276, 14)
        Me.Label42.TabIndex = 32
        Me.Label42.Text = "Statistiken können im Datenbank-Manager zurückgesetzt werden"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(9, 9)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(269, 25)
        Me.Label41.TabIndex = 31
        Me.Label41.Text = "Umsatz / Artikel-Statistiken"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(284, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "€"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(94, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "..............................."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Gesamterlös:"
        '
        'tbStatsGesUmsatz
        '
        Me.tbStatsGesUmsatz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStatsGesUmsatz.Location = New System.Drawing.Point(225, 229)
        Me.tbStatsGesUmsatz.Name = "tbStatsGesUmsatz"
        Me.tbStatsGesUmsatz.ReadOnly = True
        Me.tbStatsGesUmsatz.Size = New System.Drawing.Size(58, 20)
        Me.tbStatsGesUmsatz.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(176, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = ".............."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ausgegebene Flaschen:"
        '
        'tbStatsAnzFlaschen
        '
        Me.tbStatsAnzFlaschen.Location = New System.Drawing.Point(225, 128)
        Me.tbStatsAnzFlaschen.Name = "tbStatsAnzFlaschen"
        Me.tbStatsAnzFlaschen.ReadOnly = True
        Me.tbStatsAnzFlaschen.Size = New System.Drawing.Size(56, 20)
        Me.tbStatsAnzFlaschen.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(202, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "...."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = ".........................."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Durchgeführte Transaktionen:"
        '
        'tbStatsAnzTrans
        '
        Me.tbStatsAnzTrans.Location = New System.Drawing.Point(225, 202)
        Me.tbStatsAnzTrans.Name = "tbStatsAnzTrans"
        Me.tbStatsAnzTrans.ReadOnly = True
        Me.tbStatsAnzTrans.Size = New System.Drawing.Size(58, 20)
        Me.tbStatsAnzTrans.TabIndex = 2
        '
        'LabelAnzProd
        '
        Me.LabelAnzProd.AutoSize = True
        Me.LabelAnzProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAnzProd.Location = New System.Drawing.Point(25, 97)
        Me.LabelAnzProd.Name = "LabelAnzProd"
        Me.LabelAnzProd.Size = New System.Drawing.Size(107, 16)
        Me.LabelAnzProd.TabIndex = 1
        Me.LabelAnzProd.Text = "Anzahl Produkte:"
        '
        'tbStatsAnzProd
        '
        Me.tbStatsAnzProd.Location = New System.Drawing.Point(225, 96)
        Me.tbStatsAnzProd.Name = "tbStatsAnzProd"
        Me.tbStatsAnzProd.ReadOnly = True
        Me.tbStatsAnzProd.Size = New System.Drawing.Size(56, 20)
        Me.tbStatsAnzProd.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.btnMinimize)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(323, 25)
        Me.Panel2.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(3, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "liteVend "
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnMinimize.Location = New System.Drawing.Point(274, 1)
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
        Me.btnClose.Location = New System.Drawing.Point(299, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 24)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TimerCheckTBAdd
        '
        Me.TimerCheckTBAdd.Enabled = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnShowLog
        '
        Me.btnShowLog.Location = New System.Drawing.Point(133, 109)
        Me.btnShowLog.Name = "btnShowLog"
        Me.btnShowLog.Size = New System.Drawing.Size(61, 23)
        Me.btnShowLog.TabIndex = 35
        Me.btnShowLog.Text = "Open log"
        Me.btnShowLog.UseVisualStyleBackColor = True
        '
        'FormMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 367)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hauptmenü "
        Me.TabControl1.ResumeLayout(False)
        Me.tabPageMain.ResumeLayout(False)
        Me.tabPageMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabPageAdd.ResumeLayout(False)
        Me.PanelAdd.ResumeLayout(False)
        Me.PanelAdd.PerformLayout()
        CType(Me.PictureBoxAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPageEdit.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelEdit.ResumeLayout(False)
        Me.PanelEdit.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBoxEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDatabase.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PanelTabPageDatabaseTrenner1.ResumeLayout(False)
        Me.PanelTabPageDatabaseTrenner1.PerformLayout()
        Me.PanelTabPageDatabase.ResumeLayout(False)
        Me.PanelTabPageDatabase.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabPageMain As TabPage
    Friend WithEvents btnVendingMode As Button
    Friend WithEvents btnProduktOverview As Button
    Friend WithEvents TabPageDatabase As TabPage
    Friend WithEvents PanelTabPageDatabase As Panel
    Friend WithEvents LabelAnzProd As Label
    Friend WithEvents tbStatsAnzProd As TextBox
    Friend WithEvents PanelTabPageDatabaseTrenner1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tbStatsAnzTrans As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbStatsAnzFlaschen As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents labelStatusDB As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TabPageEdit As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PanelEdit As Panel
    Friend WithEvents btnSaveEdit As Button
    Friend WithEvents checkBoxEdit As CheckBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents tbEditV As TextBox
    Friend WithEvents tbEditAlk As TextBox
    Friend WithEvents tbEditPreis As TextBox
    Friend WithEvents ComboBoxEditID As ComboBox
    Friend WithEvents PictureBoxEdit As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents tbEditBez As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btnOpenImageEdit As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents TabPageAdd As TabPage
    Friend WithEvents PanelAdd As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents Label38 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label37 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents tbBez As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents btnAddAddImage As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents tbV As TextBox
    Friend WithEvents tbAlk As TextBox
    Friend WithEvents tbPreis As TextBox
    Friend WithEvents PictureBoxAdd As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents cbImage As CheckBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TimerCheckTBAdd As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label35 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbStatsGesUmsatz As TextBox
    Friend WithEvents btnShowLog As Button
End Class
