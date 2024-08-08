<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddProdukt
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelAddProduktMain = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSearchImage = New System.Windows.Forms.Button()
        Me.cbImage = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LabelTextMunz = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SqLiteCommandBuilder1 = New System.Data.SQLite.SQLiteCommandBuilder()
        Me.TimerCheckTextBoxes = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbBez = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPreis = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbAlk = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbV = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PanelInputProdukt = New System.Windows.Forms.Panel()
        Me.PanelAddProduktMain.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.PanelInputProdukt.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelAddProduktMain
        '
        Me.PanelAddProduktMain.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelAddProduktMain.Controls.Add(Me.PanelInputProdukt)
        Me.PanelAddProduktMain.Controls.Add(Me.btnSave)
        Me.PanelAddProduktMain.Controls.Add(Me.btnSearchImage)
        Me.PanelAddProduktMain.Controls.Add(Me.cbImage)
        Me.PanelAddProduktMain.Controls.Add(Me.PictureBox1)
        Me.PanelAddProduktMain.Controls.Add(Me.Panel5)
        Me.PanelAddProduktMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAddProduktMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelAddProduktMain.Name = "PanelAddProduktMain"
        Me.PanelAddProduktMain.Size = New System.Drawing.Size(584, 329)
        Me.PanelAddProduktMain.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnSave.Location = New System.Drawing.Point(78, 254)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(186, 35)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "Speichern"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSearchImage
        '
        Me.btnSearchImage.Enabled = False
        Me.btnSearchImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchImage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchImage.Location = New System.Drawing.Point(408, 214)
        Me.btnSearchImage.Name = "btnSearchImage"
        Me.btnSearchImage.Size = New System.Drawing.Size(127, 26)
        Me.btnSearchImage.TabIndex = 26
        Me.btnSearchImage.Text = "Durchsuchen..."
        Me.btnSearchImage.UseVisualStyleBackColor = True
        '
        'cbImage
        '
        Me.cbImage.AutoSize = True
        Me.cbImage.Location = New System.Drawing.Point(278, 214)
        Me.cbImage.Name = "cbImage"
        Me.cbImage.Size = New System.Drawing.Size(97, 17)
        Me.cbImage.TabIndex = 25
        Me.cbImage.Text = "Bild auswählen"
        Me.cbImage.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Getränke_Automat_V2.My.Resources.Resources.Dose
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(399, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 147)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.LabelTextMunz)
        Me.Panel5.Controls.Add(Me.btnMinimize)
        Me.Panel5.Controls.Add(Me.btnClose)
        Me.Panel5.Location = New System.Drawing.Point(33, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(539, 30)
        Me.Panel5.TabIndex = 7
        '
        'LabelTextMunz
        '
        Me.LabelTextMunz.AutoSize = True
        Me.LabelTextMunz.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTextMunz.ForeColor = System.Drawing.Color.White
        Me.LabelTextMunz.Location = New System.Drawing.Point(3, 8)
        Me.LabelTextMunz.Name = "LabelTextMunz"
        Me.LabelTextMunz.Size = New System.Drawing.Size(328, 15)
        Me.LabelTextMunz.TabIndex = 15
        Me.LabelTextMunz.Text = "FSET23 | Getränke Automat V2  |  Produkt Anlegen"
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnMinimize.Location = New System.Drawing.Point(471, 4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 25)
        Me.btnMinimize.TabIndex = 5
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Brown
        Me.btnClose.Location = New System.Drawing.Point(504, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 25)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'SqLiteCommandBuilder1
        '
        Me.SqLiteCommandBuilder1.DataAdapter = Nothing
        Me.SqLiteCommandBuilder1.QuoteSuffix = "]"
        '
        'TimerCheckTextBoxes
        '
        Me.TimerCheckTextBoxes.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Produkt Bezeichnung:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(225, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "%"
        '
        'tbBez
        '
        Me.tbBez.Location = New System.Drawing.Point(168, 14)
        Me.tbBez.Name = "tbBez"
        Me.tbBez.Size = New System.Drawing.Size(156, 20)
        Me.tbBez.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "............."
        '
        'tbPreis
        '
        Me.tbPreis.Location = New System.Drawing.Point(169, 101)
        Me.tbPreis.Name = "tbPreis"
        Me.tbPreis.Size = New System.Drawing.Size(50, 20)
        Me.tbPreis.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Alkoholgehalt:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Produkt Preis:"
        '
        'tbAlk
        '
        Me.tbAlk.Location = New System.Drawing.Point(169, 71)
        Me.tbAlk.Name = "tbAlk"
        Me.tbAlk.Size = New System.Drawing.Size(50, 20)
        Me.tbAlk.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(109, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "............"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(225, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "(l) Liter"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(225, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "€"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(136, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "....."
        '
        'tbV
        '
        Me.tbV.Location = New System.Drawing.Point(169, 41)
        Me.tbV.Name = "tbV"
        Me.tbV.Size = New System.Drawing.Size(50, 20)
        Me.tbV.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Produkt Volumen:"
        '
        'PanelInputProdukt
        '
        Me.PanelInputProdukt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelInputProdukt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelInputProdukt.Controls.Add(Me.Label1)
        Me.PanelInputProdukt.Controls.Add(Me.Label2)
        Me.PanelInputProdukt.Controls.Add(Me.tbBez)
        Me.PanelInputProdukt.Controls.Add(Me.Label3)
        Me.PanelInputProdukt.Controls.Add(Me.tbPreis)
        Me.PanelInputProdukt.Controls.Add(Me.Label4)
        Me.PanelInputProdukt.Controls.Add(Me.Label5)
        Me.PanelInputProdukt.Controls.Add(Me.tbAlk)
        Me.PanelInputProdukt.Controls.Add(Me.Label6)
        Me.PanelInputProdukt.Controls.Add(Me.Label7)
        Me.PanelInputProdukt.Controls.Add(Me.Label8)
        Me.PanelInputProdukt.Controls.Add(Me.Label9)
        Me.PanelInputProdukt.Controls.Add(Me.tbV)
        Me.PanelInputProdukt.Controls.Add(Me.Label10)
        Me.PanelInputProdukt.Location = New System.Drawing.Point(23, 61)
        Me.PanelInputProdukt.Name = "PanelInputProdukt"
        Me.PanelInputProdukt.Size = New System.Drawing.Size(342, 147)
        Me.PanelInputProdukt.TabIndex = 23
        '
        'FormAddProdukt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 329)
        Me.Controls.Add(Me.PanelAddProduktMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAddProdukt"
        Me.Text = "FormAddProdukt"
        Me.PanelAddProduktMain.ResumeLayout(False)
        Me.PanelAddProduktMain.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PanelInputProdukt.ResumeLayout(False)
        Me.PanelInputProdukt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAddProduktMain As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LabelTextMunz As Label
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbImage As CheckBox
    Friend WithEvents SqLiteCommandBuilder1 As SQLite.SQLiteCommandBuilder
    Friend WithEvents btnSearchImage As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents TimerCheckTextBoxes As Timer
    Friend WithEvents PanelInputProdukt As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbBez As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPreis As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbAlk As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbV As TextBox
    Friend WithEvents Label10 As Label
End Class
