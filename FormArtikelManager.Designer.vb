<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArtikelManager
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelBackground = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cbSearchBEZ = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbSearchID = New System.Windows.Forms.ComboBox()
        Me.Label_ArticleID = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbLagerOrt = New System.Windows.Forms.ComboBox()
        Me.cbLager = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelPflicht4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LabelPflicht3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelPflicht2 = New System.Windows.Forms.Label()
        Me.LabelPflicht1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbBez = New System.Windows.Forms.TextBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbPLU = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSaveArticle = New System.Windows.Forms.Button()
        Me.checkboxSetPicture = New System.Windows.Forms.CheckBox()
        Me.btnAddAddImage = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.checkboxActivatePL = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbALK = New System.Windows.Forms.TextBox()
        Me.tbInhalt = New System.Windows.Forms.TextBox()
        Me.tbPreis = New System.Windows.Forms.TextBox()
        Me.PictureBoxAM = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.label_text_am_panelbar = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PanelBackground.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxAM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBackground
        '
        Me.PanelBackground.BackColor = System.Drawing.Color.Silver
        Me.PanelBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelBackground.Controls.Add(Me.CheckBox2)
        Me.PanelBackground.Controls.Add(Me.CheckBox1)
        Me.PanelBackground.Controls.Add(Me.Label14)
        Me.PanelBackground.Controls.Add(Me.Label18)
        Me.PanelBackground.Controls.Add(Me.Label16)
        Me.PanelBackground.Controls.Add(Me.Panel8)
        Me.PanelBackground.Controls.Add(Me.cbSearchBEZ)
        Me.PanelBackground.Controls.Add(Me.Label15)
        Me.PanelBackground.Controls.Add(Me.cbSearchID)
        Me.PanelBackground.Controls.Add(Me.Label_ArticleID)
        Me.PanelBackground.Controls.Add(Me.Panel7)
        Me.PanelBackground.Controls.Add(Me.btnCancel)
        Me.PanelBackground.Controls.Add(Me.Panel6)
        Me.PanelBackground.Controls.Add(Me.cbLagerOrt)
        Me.PanelBackground.Controls.Add(Me.cbLager)
        Me.PanelBackground.Controls.Add(Me.Label20)
        Me.PanelBackground.Controls.Add(Me.Label22)
        Me.PanelBackground.Controls.Add(Me.Panel5)
        Me.PanelBackground.Controls.Add(Me.Panel4)
        Me.PanelBackground.Controls.Add(Me.Panel3)
        Me.PanelBackground.Controls.Add(Me.LabelPflicht4)
        Me.PanelBackground.Controls.Add(Me.Label17)
        Me.PanelBackground.Controls.Add(Me.LabelPflicht3)
        Me.PanelBackground.Controls.Add(Me.Panel2)
        Me.PanelBackground.Controls.Add(Me.btnSaveArticle)
        Me.PanelBackground.Controls.Add(Me.checkboxSetPicture)
        Me.PanelBackground.Controls.Add(Me.btnAddAddImage)
        Me.PanelBackground.Controls.Add(Me.Label10)
        Me.PanelBackground.Controls.Add(Me.Label9)
        Me.PanelBackground.Controls.Add(Me.Label29)
        Me.PanelBackground.Controls.Add(Me.Label8)
        Me.PanelBackground.Controls.Add(Me.Label30)
        Me.PanelBackground.Controls.Add(Me.checkboxActivatePL)
        Me.PanelBackground.Controls.Add(Me.Panel1)
        Me.PanelBackground.Controls.Add(Me.Label2)
        Me.PanelBackground.Controls.Add(Me.tbALK)
        Me.PanelBackground.Controls.Add(Me.tbInhalt)
        Me.PanelBackground.Controls.Add(Me.tbPreis)
        Me.PanelBackground.Controls.Add(Me.PictureBoxAM)
        Me.PanelBackground.Location = New System.Drawing.Point(0, 29)
        Me.PanelBackground.Name = "PanelBackground"
        Me.PanelBackground.Size = New System.Drawing.Size(796, 478)
        Me.PanelBackground.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(723, 23)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 80
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(569, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 24)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Artikel anlegen"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(164, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 24)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "Artikel Suche"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel8.Location = New System.Drawing.Point(490, 53)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(309, 8)
        Me.Panel8.TabIndex = 78
        '
        'cbSearchBEZ
        '
        Me.cbSearchBEZ.FormattingEnabled = True
        Me.cbSearchBEZ.Location = New System.Drawing.Point(246, 28)
        Me.cbSearchBEZ.Name = "cbSearchBEZ"
        Me.cbSearchBEZ.Size = New System.Drawing.Size(183, 21)
        Me.cbSearchBEZ.TabIndex = 77
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(126, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 20)
        Me.Label15.TabIndex = 76
        Me.Label15.Text = "Bezeichnung:"
        '
        'cbSearchID
        '
        Me.cbSearchID.FormattingEnabled = True
        Me.cbSearchID.Location = New System.Drawing.Point(51, 28)
        Me.cbSearchID.Name = "cbSearchID"
        Me.cbSearchID.Size = New System.Drawing.Size(51, 21)
        Me.cbSearchID.TabIndex = 74
        '
        'Label_ArticleID
        '
        Me.Label_ArticleID.AutoSize = True
        Me.Label_ArticleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ArticleID.Location = New System.Drawing.Point(12, 28)
        Me.Label_ArticleID.Name = "Label_ArticleID"
        Me.Label_ArticleID.Size = New System.Drawing.Size(33, 20)
        Me.Label_ArticleID.TabIndex = 73
        Me.Label_ArticleID.Text = "ID:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel7.Location = New System.Drawing.Point(0, 53)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(483, 8)
        Me.Panel7.TabIndex = 71
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Firebrick
        Me.btnCancel.Location = New System.Drawing.Point(320, 416)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(151, 51)
        Me.btnCancel.TabIndex = 70
        Me.btnCancel.Text = "Abbrechen"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel6.Location = New System.Drawing.Point(0, 397)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(483, 8)
        Me.Panel6.TabIndex = 69
        '
        'cbLagerOrt
        '
        Me.cbLagerOrt.Enabled = False
        Me.cbLagerOrt.FormattingEnabled = True
        Me.cbLagerOrt.Location = New System.Drawing.Point(299, 232)
        Me.cbLagerOrt.Name = "cbLagerOrt"
        Me.cbLagerOrt.Size = New System.Drawing.Size(78, 21)
        Me.cbLagerOrt.TabIndex = 68
        '
        'cbLager
        '
        Me.cbLager.Enabled = False
        Me.cbLager.FormattingEnabled = True
        Me.cbLager.Location = New System.Drawing.Point(297, 201)
        Me.cbLager.Name = "cbLager"
        Me.cbLager.Size = New System.Drawing.Size(78, 21)
        Me.cbLager.TabIndex = 67
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(203, 233)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 20)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "Lager Ort:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(231, 202)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 20)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "Lager:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel5.Location = New System.Drawing.Point(0, 189)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(483, 8)
        Me.Panel5.TabIndex = 61
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel4.Location = New System.Drawing.Point(0, 258)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(483, 8)
        Me.Panel4.TabIndex = 60
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Location = New System.Drawing.Point(481, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 480)
        Me.Panel3.TabIndex = 59
        '
        'LabelPflicht4
        '
        Me.LabelPflicht4.AutoSize = True
        Me.LabelPflicht4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPflicht4.Location = New System.Drawing.Point(722, 447)
        Me.LabelPflicht4.Name = "LabelPflicht4"
        Me.LabelPflicht4.Size = New System.Drawing.Size(64, 16)
        Me.LabelPflicht4.TabIndex = 58
        Me.LabelPflicht4.Text = "Pflichtfeld"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.CausesValidation = False
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(712, 447)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(11, 16)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "*"
        '
        'LabelPflicht3
        '
        Me.LabelPflicht3.AutoSize = True
        Me.LabelPflicht3.CausesValidation = False
        Me.LabelPflicht3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPflicht3.ForeColor = System.Drawing.Color.Red
        Me.LabelPflicht3.Location = New System.Drawing.Point(58, 272)
        Me.LabelPflicht3.Name = "LabelPflicht3"
        Me.LabelPflicht3.Size = New System.Drawing.Size(11, 16)
        Me.LabelPflicht3.TabIndex = 56
        Me.LabelPflicht3.Text = "*"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.LabelPflicht2)
        Me.Panel2.Controls.Add(Me.LabelPflicht1)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.tbBez)
        Me.Panel2.Controls.Add(Me.tbID)
        Me.Panel2.Controls.Add(Me.tbPLU)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(5, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 120)
        Me.Panel2.TabIndex = 54
        '
        'LabelPflicht2
        '
        Me.LabelPflicht2.AutoSize = True
        Me.LabelPflicht2.CausesValidation = False
        Me.LabelPflicht2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPflicht2.ForeColor = System.Drawing.Color.Red
        Me.LabelPflicht2.Location = New System.Drawing.Point(83, 88)
        Me.LabelPflicht2.Name = "LabelPflicht2"
        Me.LabelPflicht2.Size = New System.Drawing.Size(11, 16)
        Me.LabelPflicht2.TabIndex = 56
        Me.LabelPflicht2.Text = "*"
        '
        'LabelPflicht1
        '
        Me.LabelPflicht1.AutoSize = True
        Me.LabelPflicht1.CausesValidation = False
        Me.LabelPflicht1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPflicht1.ForeColor = System.Drawing.Color.Red
        Me.LabelPflicht1.Location = New System.Drawing.Point(13, 29)
        Me.LabelPflicht1.Name = "LabelPflicht1"
        Me.LabelPflicht1.Size = New System.Drawing.Size(11, 16)
        Me.LabelPflicht1.TabIndex = 55
        Me.LabelPflicht1.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(150, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 20)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Basisinformationen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Bezeichnung:"
        '
        'tbBez
        '
        Me.tbBez.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBez.Location = New System.Drawing.Point(143, 29)
        Me.tbBez.Name = "tbBez"
        Me.tbBez.Size = New System.Drawing.Size(184, 24)
        Me.tbBez.TabIndex = 0
        '
        'tbID
        '
        Me.tbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbID.Location = New System.Drawing.Point(143, 59)
        Me.tbID.Name = "tbID"
        Me.tbID.ReadOnly = True
        Me.tbID.Size = New System.Drawing.Size(47, 24)
        Me.tbID.TabIndex = 5
        '
        'tbPLU
        '
        Me.tbPLU.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPLU.Location = New System.Drawing.Point(143, 88)
        Me.tbPLU.Name = "tbPLU"
        Me.tbPLU.Size = New System.Drawing.Size(47, 24)
        Me.tbPLU.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(89, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 20)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "PLU:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(48, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 20)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Artikel ID:"
        '
        'btnSaveArticle
        '
        Me.btnSaveArticle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSaveArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveArticle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveArticle.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnSaveArticle.Location = New System.Drawing.Point(148, 416)
        Me.btnSaveArticle.Name = "btnSaveArticle"
        Me.btnSaveArticle.Size = New System.Drawing.Size(151, 51)
        Me.btnSaveArticle.TabIndex = 53
        Me.btnSaveArticle.Text = "Speichern"
        Me.btnSaveArticle.UseVisualStyleBackColor = False
        Me.btnSaveArticle.Visible = False
        '
        'checkboxSetPicture
        '
        Me.checkboxSetPicture.AutoSize = True
        Me.checkboxSetPicture.Enabled = False
        Me.checkboxSetPicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkboxSetPicture.Location = New System.Drawing.Point(521, 407)
        Me.checkboxSetPicture.Name = "checkboxSetPicture"
        Me.checkboxSetPicture.Size = New System.Drawing.Size(111, 22)
        Me.checkboxSetPicture.TabIndex = 52
        Me.checkboxSetPicture.Text = "Bild ändern"
        Me.checkboxSetPicture.UseVisualStyleBackColor = True
        '
        'btnAddAddImage
        '
        Me.btnAddAddImage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddAddImage.Enabled = False
        Me.btnAddAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAddImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAddImage.Location = New System.Drawing.Point(652, 400)
        Me.btnAddAddImage.Name = "btnAddAddImage"
        Me.btnAddAddImage.Size = New System.Drawing.Size(123, 34)
        Me.btnAddAddImage.TabIndex = 51
        Me.btnAddAddImage.Text = "Durchsuchen"
        Me.btnAddAddImage.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.CausesValidation = False
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(183, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 20)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Alkoholgehalt:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.CausesValidation = False
        Me.Label29.Font = New System.Drawing.Font("Segoe Script", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(182, 203)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 20)
        Me.Label29.TabIndex = 45
        Me.Label29.Text = "l"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 20)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Inhaltsmenge:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(195, 276)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(15, 16)
        Me.Label30.TabIndex = 43
        Me.Label30.Text = "€"
        '
        'checkboxActivatePL
        '
        Me.checkboxActivatePL.AutoSize = True
        Me.checkboxActivatePL.Enabled = False
        Me.checkboxActivatePL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkboxActivatePL.Location = New System.Drawing.Point(217, 272)
        Me.checkboxActivatePL.Name = "checkboxActivatePL"
        Me.checkboxActivatePL.Size = New System.Drawing.Size(183, 22)
        Me.checkboxActivatePL.TabIndex = 9
        Me.checkboxActivatePL.Text = "Preislisten aktivieren"
        Me.checkboxActivatePL.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBox9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(62, 302)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 89)
        Me.Panel1.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(113, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Preislisten:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(178, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "PL4:"
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(238, 52)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(83, 24)
        Me.TextBox8.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(178, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "PL3:"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(238, 25)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(83, 24)
        Me.TextBox9.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "PL2:"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(79, 52)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(83, 24)
        Me.TextBox7.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "PL1:"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(79, 25)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(83, 24)
        Me.TextBox6.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Preis:"
        '
        'tbALK
        '
        Me.tbALK.Enabled = False
        Me.tbALK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbALK.Location = New System.Drawing.Point(130, 232)
        Me.tbALK.Name = "tbALK"
        Me.tbALK.Size = New System.Drawing.Size(47, 24)
        Me.tbALK.TabIndex = 4
        Me.tbALK.Text = "0,00"
        '
        'tbInhalt
        '
        Me.tbInhalt.Enabled = False
        Me.tbInhalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInhalt.Location = New System.Drawing.Point(130, 200)
        Me.tbInhalt.Name = "tbInhalt"
        Me.tbInhalt.Size = New System.Drawing.Size(47, 24)
        Me.tbInhalt.TabIndex = 3
        '
        'tbPreis
        '
        Me.tbPreis.Enabled = False
        Me.tbPreis.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPreis.Location = New System.Drawing.Point(125, 272)
        Me.tbPreis.Name = "tbPreis"
        Me.tbPreis.Size = New System.Drawing.Size(67, 24)
        Me.tbPreis.TabIndex = 2
        '
        'PictureBoxAM
        '
        Me.PictureBoxAM.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxAM.Location = New System.Drawing.Point(512, 84)
        Me.PictureBoxAM.Name = "PictureBoxAM"
        Me.PictureBoxAM.Size = New System.Drawing.Size(263, 307)
        Me.PictureBoxAM.TabIndex = 1
        Me.PictureBoxAM.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel9.Controls.Add(Me.btnMinimize)
        Me.Panel9.Controls.Add(Me.label_text_am_panelbar)
        Me.Panel9.Controls.Add(Me.btnClose)
        Me.Panel9.Location = New System.Drawing.Point(0, -1)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(796, 30)
        Me.Panel9.TabIndex = 81
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnMinimize.Location = New System.Drawing.Point(744, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(24, 24)
        Me.btnMinimize.TabIndex = 82
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'label_text_am_panelbar
        '
        Me.label_text_am_panelbar.AutoSize = True
        Me.label_text_am_panelbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_text_am_panelbar.ForeColor = System.Drawing.SystemColors.Control
        Me.label_text_am_panelbar.Location = New System.Drawing.Point(3, 3)
        Me.label_text_am_panelbar.Name = "label_text_am_panelbar"
        Me.label_text_am_panelbar.Size = New System.Drawing.Size(179, 24)
        Me.label_text_am_panelbar.TabIndex = 57
        Me.label_text_am_panelbar.Text = "Artikel Verwaltung"
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Brown
        Me.btnClose.Location = New System.Drawing.Point(769, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 24)
        Me.btnClose.TabIndex = 81
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(129, 438)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 82
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 435)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 15)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "Artikel bearbeiten"
        '
        'FormArtikelManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 506)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.PanelBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormArtikelManager"
        Me.Text = "FormArtikelManager"
        Me.PanelBackground.ResumeLayout(False)
        Me.PanelBackground.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxAM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBackground As Panel
    Friend WithEvents PictureBoxAM As PictureBox
    Friend WithEvents tbBez As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents tbALK As TextBox
    Friend WithEvents tbInhalt As TextBox
    Friend WithEvents tbPreis As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents checkboxActivatePL As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbPLU As TextBox
    Friend WithEvents btnAddAddImage As Button
    Friend WithEvents checkboxSetPicture As CheckBox
    Friend WithEvents btnSaveArticle As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelPflicht2 As Label
    Friend WithEvents LabelPflicht1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbLager As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelPflicht4 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents LabelPflicht3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cbLagerOrt As ComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label_ArticleID As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbSearchID As ComboBox
    Friend WithEvents cbSearchBEZ As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents label_text_am_panelbar As Label
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label18 As Label
End Class
