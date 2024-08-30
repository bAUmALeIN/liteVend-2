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
        Me.labelBestand = New System.Windows.Forms.Label()
        Me.tbBestand = New System.Windows.Forms.TextBox()
        Me.labelMindBestand = New System.Windows.Forms.Label()
        Me.tbMindBestand = New System.Windows.Forms.TextBox()
        Me.labelTextNeu2 = New System.Windows.Forms.Label()
        Me.labelTextNeu3 = New System.Windows.Forms.Label()
        Me.labelTextNeu1 = New System.Windows.Forms.Label()
        Me.checkboxEdit = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbBez = New System.Windows.Forms.TextBox()
        Me.labelText_Suche = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbPLU = New System.Windows.Forms.TextBox()
        Me.cbSearchBEZ = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.labelTextSucheBez = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbSearchID = New System.Windows.Forms.ComboBox()
        Me.labelTextSucheID = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbLagerOrt = New System.Windows.Forms.ComboBox()
        Me.cbLager = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.labelTextNeu6 = New System.Windows.Forms.Label()
        Me.labelTextNeu7 = New System.Windows.Forms.Label()
        Me.labelTextNeu5 = New System.Windows.Forms.Label()
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
        Me.tbPL4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbPL3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPL2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPL1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbALK = New System.Windows.Forms.TextBox()
        Me.tbInhalt = New System.Windows.Forms.TextBox()
        Me.tbPreis = New System.Windows.Forms.TextBox()
        Me.PictureBoxAM = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.label_text_am_panelbar = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PanelBackground.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxAM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBackground
        '
        Me.PanelBackground.BackColor = System.Drawing.Color.Silver
        Me.PanelBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelBackground.Controls.Add(Me.labelBestand)
        Me.PanelBackground.Controls.Add(Me.tbBestand)
        Me.PanelBackground.Controls.Add(Me.labelMindBestand)
        Me.PanelBackground.Controls.Add(Me.tbMindBestand)
        Me.PanelBackground.Controls.Add(Me.labelTextNeu2)
        Me.PanelBackground.Controls.Add(Me.labelTextNeu3)
        Me.PanelBackground.Controls.Add(Me.labelTextNeu1)
        Me.PanelBackground.Controls.Add(Me.checkboxEdit)
        Me.PanelBackground.Controls.Add(Me.CheckBox1)
        Me.PanelBackground.Controls.Add(Me.Label14)
        Me.PanelBackground.Controls.Add(Me.Label13)
        Me.PanelBackground.Controls.Add(Me.Label1)
        Me.PanelBackground.Controls.Add(Me.Label18)
        Me.PanelBackground.Controls.Add(Me.tbBez)
        Me.PanelBackground.Controls.Add(Me.labelText_Suche)
        Me.PanelBackground.Controls.Add(Me.tbID)
        Me.PanelBackground.Controls.Add(Me.tbPLU)
        Me.PanelBackground.Controls.Add(Me.cbSearchBEZ)
        Me.PanelBackground.Controls.Add(Me.Label12)
        Me.PanelBackground.Controls.Add(Me.labelTextSucheBez)
        Me.PanelBackground.Controls.Add(Me.Label11)
        Me.PanelBackground.Controls.Add(Me.cbSearchID)
        Me.PanelBackground.Controls.Add(Me.labelTextSucheID)
        Me.PanelBackground.Controls.Add(Me.Panel7)
        Me.PanelBackground.Controls.Add(Me.Panel6)
        Me.PanelBackground.Controls.Add(Me.cbLagerOrt)
        Me.PanelBackground.Controls.Add(Me.cbLager)
        Me.PanelBackground.Controls.Add(Me.Label20)
        Me.PanelBackground.Controls.Add(Me.Label22)
        Me.PanelBackground.Controls.Add(Me.Panel5)
        Me.PanelBackground.Controls.Add(Me.Panel4)
        Me.PanelBackground.Controls.Add(Me.Panel3)
        Me.PanelBackground.Controls.Add(Me.labelTextNeu6)
        Me.PanelBackground.Controls.Add(Me.labelTextNeu7)
        Me.PanelBackground.Controls.Add(Me.labelTextNeu5)
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
        Me.PanelBackground.Location = New System.Drawing.Point(6, 33)
        Me.PanelBackground.Name = "PanelBackground"
        Me.PanelBackground.Size = New System.Drawing.Size(796, 478)
        Me.PanelBackground.TabIndex = 0
        '
        'labelBestand
        '
        Me.labelBestand.AutoSize = True
        Me.labelBestand.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBestand.Location = New System.Drawing.Point(266, 230)
        Me.labelBestand.Name = "labelBestand"
        Me.labelBestand.Size = New System.Drawing.Size(69, 17)
        Me.labelBestand.TabIndex = 88
        Me.labelBestand.Text = "Bestand:"
        '
        'tbBestand
        '
        Me.tbBestand.Enabled = False
        Me.tbBestand.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBestand.Location = New System.Drawing.Point(353, 228)
        Me.tbBestand.Name = "tbBestand"
        Me.tbBestand.Size = New System.Drawing.Size(83, 25)
        Me.tbBestand.TabIndex = 87
        Me.tbBestand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelMindBestand
        '
        Me.labelMindBestand.AutoSize = True
        Me.labelMindBestand.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMindBestand.Location = New System.Drawing.Point(200, 202)
        Me.labelMindBestand.Name = "labelMindBestand"
        Me.labelMindBestand.Size = New System.Drawing.Size(131, 17)
        Me.labelMindBestand.TabIndex = 86
        Me.labelMindBestand.Text = "Mindest Bestand:"
        '
        'tbMindBestand
        '
        Me.tbMindBestand.Enabled = False
        Me.tbMindBestand.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMindBestand.Location = New System.Drawing.Point(353, 200)
        Me.tbMindBestand.Name = "tbMindBestand"
        Me.tbMindBestand.Size = New System.Drawing.Size(83, 25)
        Me.tbMindBestand.TabIndex = 85
        Me.tbMindBestand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelTextNeu2
        '
        Me.labelTextNeu2.AutoSize = True
        Me.labelTextNeu2.CausesValidation = False
        Me.labelTextNeu2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTextNeu2.ForeColor = System.Drawing.Color.Red
        Me.labelTextNeu2.Location = New System.Drawing.Point(41, 79)
        Me.labelTextNeu2.Name = "labelTextNeu2"
        Me.labelTextNeu2.Size = New System.Drawing.Size(11, 16)
        Me.labelTextNeu2.TabIndex = 84
        Me.labelTextNeu2.Text = "*"
        Me.labelTextNeu2.Visible = False
        '
        'labelTextNeu3
        '
        Me.labelTextNeu3.AutoSize = True
        Me.labelTextNeu3.CausesValidation = False
        Me.labelTextNeu3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTextNeu3.ForeColor = System.Drawing.Color.Red
        Me.labelTextNeu3.Location = New System.Drawing.Point(108, 145)
        Me.labelTextNeu3.Name = "labelTextNeu3"
        Me.labelTextNeu3.Size = New System.Drawing.Size(11, 16)
        Me.labelTextNeu3.TabIndex = 83
        Me.labelTextNeu3.Text = "*"
        Me.labelTextNeu3.Visible = False
        '
        'labelTextNeu1
        '
        Me.labelTextNeu1.AutoSize = True
        Me.labelTextNeu1.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTextNeu1.ForeColor = System.Drawing.Color.Red
        Me.labelTextNeu1.Location = New System.Drawing.Point(331, 50)
        Me.labelTextNeu1.Name = "labelTextNeu1"
        Me.labelTextNeu1.Size = New System.Drawing.Size(40, 17)
        Me.labelTextNeu1.TabIndex = 57
        Me.labelTextNeu1.Text = "NEU"
        Me.labelTextNeu1.Visible = False
        '
        'checkboxEdit
        '
        Me.checkboxEdit.AutoSize = True
        Me.checkboxEdit.Location = New System.Drawing.Point(450, 449)
        Me.checkboxEdit.Name = "checkboxEdit"
        Me.checkboxEdit.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEdit.TabIndex = 82
        Me.checkboxEdit.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(450, 419)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 80
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(331, 417)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 17)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Artikel anlegen"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(-1, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(207, 22)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Basisinformationen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Bezeichnung:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(312, 447)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(139, 17)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "Artikel bearbeiten"
        '
        'tbBez
        '
        Me.tbBez.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBez.Location = New System.Drawing.Point(174, 81)
        Me.tbBez.Name = "tbBez"
        Me.tbBez.Size = New System.Drawing.Size(228, 25)
        Me.tbBez.TabIndex = 0
        '
        'labelText_Suche
        '
        Me.labelText_Suche.AutoSize = True
        Me.labelText_Suche.Font = New System.Drawing.Font("Lucida Sans", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelText_Suche.Location = New System.Drawing.Point(-1, 2)
        Me.labelText_Suche.Name = "labelText_Suche"
        Me.labelText_Suche.Size = New System.Drawing.Size(68, 22)
        Me.labelText_Suche.TabIndex = 56
        Me.labelText_Suche.Text = "Suche"
        '
        'tbID
        '
        Me.tbID.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbID.Location = New System.Drawing.Point(175, 113)
        Me.tbID.Name = "tbID"
        Me.tbID.ReadOnly = True
        Me.tbID.Size = New System.Drawing.Size(47, 25)
        Me.tbID.TabIndex = 5
        '
        'tbPLU
        '
        Me.tbPLU.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPLU.Location = New System.Drawing.Point(175, 144)
        Me.tbPLU.Name = "tbPLU"
        Me.tbPLU.Size = New System.Drawing.Size(47, 25)
        Me.tbPLU.TabIndex = 48
        Me.tbPLU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbSearchBEZ
        '
        Me.cbSearchBEZ.FormattingEnabled = True
        Me.cbSearchBEZ.Location = New System.Drawing.Point(300, 6)
        Me.cbSearchBEZ.Name = "cbSearchBEZ"
        Me.cbSearchBEZ.Size = New System.Drawing.Size(175, 21)
        Me.cbSearchBEZ.TabIndex = 77
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(116, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 17)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "PLU:"
        '
        'labelTextSucheBez
        '
        Me.labelTextSucheBez.AutoSize = True
        Me.labelTextSucheBez.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTextSucheBez.Location = New System.Drawing.Point(180, 6)
        Me.labelTextSucheBez.Name = "labelTextSucheBez"
        Me.labelTextSucheBez.Size = New System.Drawing.Size(107, 17)
        Me.labelTextSucheBez.TabIndex = 76
        Me.labelTextSucheBez.Text = "Bezeichnung:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(75, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Artikel ID:"
        '
        'cbSearchID
        '
        Me.cbSearchID.FormattingEnabled = True
        Me.cbSearchID.Location = New System.Drawing.Point(105, 6)
        Me.cbSearchID.Name = "cbSearchID"
        Me.cbSearchID.Size = New System.Drawing.Size(43, 21)
        Me.cbSearchID.TabIndex = 74
        '
        'labelTextSucheID
        '
        Me.labelTextSucheID.AutoSize = True
        Me.labelTextSucheID.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTextSucheID.Location = New System.Drawing.Point(66, 6)
        Me.labelTextSucheID.Name = "labelTextSucheID"
        Me.labelTextSucheID.Size = New System.Drawing.Size(28, 17)
        Me.labelTextSucheID.TabIndex = 73
        Me.labelTextSucheID.Text = "ID:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SlateGray
        Me.Panel7.Location = New System.Drawing.Point(0, 33)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(483, 8)
        Me.Panel7.TabIndex = 71
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SlateGray
        Me.Panel6.Location = New System.Drawing.Point(0, 397)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(483, 8)
        Me.Panel6.TabIndex = 69
        '
        'cbLagerOrt
        '
        Me.cbLagerOrt.Enabled = False
        Me.cbLagerOrt.FormattingEnabled = True
        Me.cbLagerOrt.Location = New System.Drawing.Point(116, 230)
        Me.cbLagerOrt.Name = "cbLagerOrt"
        Me.cbLagerOrt.Size = New System.Drawing.Size(78, 21)
        Me.cbLagerOrt.TabIndex = 68
        '
        'cbLager
        '
        Me.cbLager.Enabled = False
        Me.cbLager.FormattingEnabled = True
        Me.cbLager.Location = New System.Drawing.Point(116, 201)
        Me.cbLager.Name = "cbLager"
        Me.cbLager.Size = New System.Drawing.Size(78, 21)
        Me.cbLager.TabIndex = 67
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(22, 233)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 17)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "Lager Ort:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(50, 202)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 17)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "Lager:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SlateGray
        Me.Panel5.Location = New System.Drawing.Point(0, 188)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(483, 8)
        Me.Panel5.TabIndex = 61
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SlateGray
        Me.Panel4.Location = New System.Drawing.Point(0, 258)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(483, 8)
        Me.Panel4.TabIndex = 60
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SlateGray
        Me.Panel3.Location = New System.Drawing.Point(481, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 480)
        Me.Panel3.TabIndex = 59
        '
        'labelTextNeu6
        '
        Me.labelTextNeu6.AutoSize = True
        Me.labelTextNeu6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTextNeu6.Location = New System.Drawing.Point(33, 427)
        Me.labelTextNeu6.Name = "labelTextNeu6"
        Me.labelTextNeu6.Size = New System.Drawing.Size(64, 16)
        Me.labelTextNeu6.TabIndex = 58
        Me.labelTextNeu6.Text = "Pflichtfeld"
        Me.labelTextNeu6.Visible = False
        '
        'labelTextNeu7
        '
        Me.labelTextNeu7.AutoSize = True
        Me.labelTextNeu7.CausesValidation = False
        Me.labelTextNeu7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTextNeu7.ForeColor = System.Drawing.Color.Red
        Me.labelTextNeu7.Location = New System.Drawing.Point(26, 421)
        Me.labelTextNeu7.Name = "labelTextNeu7"
        Me.labelTextNeu7.Size = New System.Drawing.Size(11, 16)
        Me.labelTextNeu7.TabIndex = 57
        Me.labelTextNeu7.Text = "*"
        Me.labelTextNeu7.Visible = False
        '
        'labelTextNeu5
        '
        Me.labelTextNeu5.AutoSize = True
        Me.labelTextNeu5.CausesValidation = False
        Me.labelTextNeu5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTextNeu5.ForeColor = System.Drawing.Color.Red
        Me.labelTextNeu5.Location = New System.Drawing.Point(57, 272)
        Me.labelTextNeu5.Name = "labelTextNeu5"
        Me.labelTextNeu5.Size = New System.Drawing.Size(11, 16)
        Me.labelTextNeu5.TabIndex = 56
        Me.labelTextNeu5.Text = "*"
        Me.labelTextNeu5.Visible = False
        '
        'btnSaveArticle
        '
        Me.btnSaveArticle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSaveArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveArticle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveArticle.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnSaveArticle.Location = New System.Drawing.Point(143, 419)
        Me.btnSaveArticle.Name = "btnSaveArticle"
        Me.btnSaveArticle.Size = New System.Drawing.Size(136, 40)
        Me.btnSaveArticle.TabIndex = 53
        Me.btnSaveArticle.Text = "Speichern"
        Me.btnSaveArticle.UseVisualStyleBackColor = False
        Me.btnSaveArticle.Visible = False
        '
        'checkboxSetPicture
        '
        Me.checkboxSetPicture.AutoSize = True
        Me.checkboxSetPicture.Enabled = False
        Me.checkboxSetPicture.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkboxSetPicture.Location = New System.Drawing.Point(520, 412)
        Me.checkboxSetPicture.Name = "checkboxSetPicture"
        Me.checkboxSetPicture.Size = New System.Drawing.Size(110, 21)
        Me.checkboxSetPicture.TabIndex = 52
        Me.checkboxSetPicture.Text = "Bild ändern"
        Me.checkboxSetPicture.UseVisualStyleBackColor = True
        '
        'btnAddAddImage
        '
        Me.btnAddAddImage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddAddImage.Enabled = False
        Me.btnAddAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAddImage.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAddImage.Location = New System.Drawing.Point(641, 404)
        Me.btnAddAddImage.Name = "btnAddAddImage"
        Me.btnAddAddImage.Size = New System.Drawing.Size(123, 34)
        Me.btnAddAddImage.TabIndex = 51
        Me.btnAddAddImage.Text = "Durchsuchen"
        Me.btnAddAddImage.UseVisualStyleBackColor = False
        Me.btnAddAddImage.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.CausesValidation = False
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(408, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(228, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 17)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Alkoholgehalt:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.CausesValidation = False
        Me.Label29.Font = New System.Drawing.Font("Segoe Script", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(407, 117)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 20)
        Me.Label29.TabIndex = 45
        Me.Label29.Text = "l"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(228, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 17)
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
        Me.checkboxActivatePL.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkboxActivatePL.Location = New System.Drawing.Point(217, 272)
        Me.checkboxActivatePL.Name = "checkboxActivatePL"
        Me.checkboxActivatePL.Size = New System.Drawing.Size(180, 21)
        Me.checkboxActivatePL.TabIndex = 9
        Me.checkboxActivatePL.Text = "Preislisten aktivieren"
        Me.checkboxActivatePL.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tbPL4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tbPL3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tbPL2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tbPL1)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(62, 302)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 89)
        Me.Panel1.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(113, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Preislisten:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(178, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "PL4:"
        '
        'tbPL4
        '
        Me.tbPL4.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPL4.Location = New System.Drawing.Point(238, 52)
        Me.tbPL4.Name = "tbPL4"
        Me.tbPL4.Size = New System.Drawing.Size(83, 25)
        Me.tbPL4.TabIndex = 15
        Me.tbPL4.Text = "0,00"
        Me.tbPL4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(178, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "PL3:"
        '
        'tbPL3
        '
        Me.tbPL3.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPL3.Location = New System.Drawing.Point(238, 25)
        Me.tbPL3.Name = "tbPL3"
        Me.tbPL3.Size = New System.Drawing.Size(83, 25)
        Me.tbPL3.TabIndex = 13
        Me.tbPL3.Text = "0,00"
        Me.tbPL3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "PL2:"
        '
        'tbPL2
        '
        Me.tbPL2.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPL2.Location = New System.Drawing.Point(79, 52)
        Me.tbPL2.Name = "tbPL2"
        Me.tbPL2.Size = New System.Drawing.Size(83, 25)
        Me.tbPL2.TabIndex = 11
        Me.tbPL2.Text = "0,00"
        Me.tbPL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "PL1:"
        '
        'tbPL1
        '
        Me.tbPL1.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPL1.Location = New System.Drawing.Point(79, 25)
        Me.tbPL1.Name = "tbPL1"
        Me.tbPL1.Size = New System.Drawing.Size(83, 25)
        Me.tbPL1.TabIndex = 9
        Me.tbPL1.Text = "0,00"
        Me.tbPL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Preis:"
        '
        'tbALK
        '
        Me.tbALK.Enabled = False
        Me.tbALK.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbALK.Location = New System.Drawing.Point(355, 148)
        Me.tbALK.Name = "tbALK"
        Me.tbALK.Size = New System.Drawing.Size(47, 25)
        Me.tbALK.TabIndex = 4
        Me.tbALK.Text = "0,00"
        Me.tbALK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbInhalt
        '
        Me.tbInhalt.Enabled = False
        Me.tbInhalt.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInhalt.Location = New System.Drawing.Point(355, 114)
        Me.tbInhalt.Name = "tbInhalt"
        Me.tbInhalt.Size = New System.Drawing.Size(47, 25)
        Me.tbInhalt.TabIndex = 3
        Me.tbInhalt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbPreis
        '
        Me.tbPreis.Enabled = False
        Me.tbPreis.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPreis.Location = New System.Drawing.Point(125, 272)
        Me.tbPreis.Name = "tbPreis"
        Me.tbPreis.Size = New System.Drawing.Size(67, 25)
        Me.tbPreis.TabIndex = 2
        Me.tbPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBoxAM
        '
        Me.PictureBoxAM.BackColor = System.Drawing.Color.LightGray
        Me.PictureBoxAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBoxAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBoxAM.Location = New System.Drawing.Point(520, 32)
        Me.PictureBoxAM.Name = "PictureBoxAM"
        Me.PictureBoxAM.Size = New System.Drawing.Size(248, 351)
        Me.PictureBoxAM.TabIndex = 1
        Me.PictureBoxAM.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel9.Controls.Add(Me.btnMinimize)
        Me.Panel9.Controls.Add(Me.label_text_am_panelbar)
        Me.Panel9.Controls.Add(Me.btnClose)
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(809, 33)
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
        Me.label_text_am_panelbar.Size = New System.Drawing.Size(169, 24)
        Me.label_text_am_panelbar.TabIndex = 57
        Me.label_text_am_panelbar.Text = "Artikelverwaltung"
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
        'FormArtikelManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(809, 517)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.PanelBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormArtikelManager"
        Me.Text = "FormArtikelManager"
        Me.PanelBackground.ResumeLayout(False)
        Me.PanelBackground.PerformLayout()
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
    Friend WithEvents tbPL4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbPL3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbPL2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPL1 As TextBox
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
    Friend WithEvents Label13 As Label
    Friend WithEvents cbLager As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents labelTextNeu6 As Label
    Friend WithEvents labelTextNeu7 As Label
    Friend WithEvents labelTextNeu5 As Label
    Friend WithEvents cbLagerOrt As ComboBox
    Friend WithEvents labelTextSucheID As Label
    Friend WithEvents labelTextSucheBez As Label
    Friend WithEvents cbSearchID As ComboBox
    Friend WithEvents cbSearchBEZ As ComboBox
    Friend WithEvents labelText_Suche As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents label_text_am_panelbar As Label
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents checkboxEdit As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents labelTextNeu1 As Label
    Friend WithEvents labelTextNeu2 As Label
    Friend WithEvents labelTextNeu3 As Label
    Friend WithEvents labelBestand As Label
    Friend WithEvents tbBestand As TextBox
    Friend WithEvents labelMindBestand As Label
    Friend WithEvents tbMindBestand As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
End Class
