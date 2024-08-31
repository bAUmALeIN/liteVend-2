<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLagerverwaltung
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.PanelControlBr = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.label_text_am_panelbar = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PanelBackground = New System.Windows.Forms.Panel()
        Me.Label_LagerCap = New System.Windows.Forms.Label()
        Me.Label_LagerBez = New System.Windows.Forms.Label()
        Me.Label_LagerID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridViewLagerPositionen = New System.Windows.Forms.DataGridView()
        Me.btnLagerAnlegen = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelText_Suche = New System.Windows.Forms.Label()
        Me.cbLagerAuswahl = New System.Windows.Forms.ComboBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControlBr.SuspendLayout()
        Me.PanelBackground.SuspendLayout()
        CType(Me.DataGridViewLagerPositionen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControlBr
        '
        Me.PanelControlBr.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelControlBr.Controls.Add(Me.btnMinimize)
        Me.PanelControlBr.Controls.Add(Me.label_text_am_panelbar)
        Me.PanelControlBr.Controls.Add(Me.btnClose)
        Me.PanelControlBr.Location = New System.Drawing.Point(-1, 0)
        Me.PanelControlBr.Name = "PanelControlBr"
        Me.PanelControlBr.Size = New System.Drawing.Size(795, 33)
        Me.PanelControlBr.TabIndex = 82
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
        Me.label_text_am_panelbar.Size = New System.Drawing.Size(164, 24)
        Me.label_text_am_panelbar.TabIndex = 57
        Me.label_text_am_panelbar.Text = "Lagerverwaltung"
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Brown
        Me.btnClose.Location = New System.Drawing.Point(769, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 27)
        Me.btnClose.TabIndex = 81
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PanelBackground
        '
        Me.PanelBackground.BackColor = System.Drawing.Color.Silver
        Me.PanelBackground.Controls.Add(Me.Label_LagerCap)
        Me.PanelBackground.Controls.Add(Me.Label_LagerBez)
        Me.PanelBackground.Controls.Add(Me.Label_LagerID)
        Me.PanelBackground.Controls.Add(Me.Label5)
        Me.PanelBackground.Controls.Add(Me.Label4)
        Me.PanelBackground.Controls.Add(Me.DataGridViewLagerPositionen)
        Me.PanelBackground.Controls.Add(Me.btnLagerAnlegen)
        Me.PanelBackground.Controls.Add(Me.Label3)
        Me.PanelBackground.Controls.Add(Me.labelText_Suche)
        Me.PanelBackground.Controls.Add(Me.cbLagerAuswahl)
        Me.PanelBackground.Controls.Add(Me.Chart1)
        Me.PanelBackground.Controls.Add(Me.Label1)
        Me.PanelBackground.Controls.Add(Me.Panel1)
        Me.PanelBackground.Location = New System.Drawing.Point(6, 33)
        Me.PanelBackground.Name = "PanelBackground"
        Me.PanelBackground.Size = New System.Drawing.Size(796, 478)
        Me.PanelBackground.TabIndex = 83
        '
        'Label_LagerCap
        '
        Me.Label_LagerCap.AutoSize = True
        Me.Label_LagerCap.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_LagerCap.Location = New System.Drawing.Point(189, 193)
        Me.Label_LagerCap.Name = "Label_LagerCap"
        Me.Label_LagerCap.Size = New System.Drawing.Size(32, 22)
        Me.Label_LagerCap.TabIndex = 95
        Me.Label_LagerCap.Text = "-/-"
        '
        'Label_LagerBez
        '
        Me.Label_LagerBez.AutoSize = True
        Me.Label_LagerBez.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_LagerBez.Location = New System.Drawing.Point(189, 153)
        Me.Label_LagerBez.Name = "Label_LagerBez"
        Me.Label_LagerBez.Size = New System.Drawing.Size(32, 22)
        Me.Label_LagerBez.TabIndex = 94
        Me.Label_LagerBez.Text = "-/-"
        '
        'Label_LagerID
        '
        Me.Label_LagerID.AutoSize = True
        Me.Label_LagerID.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_LagerID.Location = New System.Drawing.Point(189, 113)
        Me.Label_LagerID.Name = "Label_LagerID"
        Me.Label_LagerID.Size = New System.Drawing.Size(32, 22)
        Me.Label_LagerID.TabIndex = 93
        Me.Label_LagerID.Text = "-/-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 22)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Lager Größe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 22)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Lager Name"
        '
        'DataGridViewLagerPositionen
        '
        Me.DataGridViewLagerPositionen.AllowUserToAddRows = False
        Me.DataGridViewLagerPositionen.AllowUserToDeleteRows = False
        Me.DataGridViewLagerPositionen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewLagerPositionen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewLagerPositionen.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewLagerPositionen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewLagerPositionen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewLagerPositionen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLagerPositionen.Location = New System.Drawing.Point(7, 305)
        Me.DataGridViewLagerPositionen.Name = "DataGridViewLagerPositionen"
        Me.DataGridViewLagerPositionen.RowHeadersVisible = False
        Me.DataGridViewLagerPositionen.Size = New System.Drawing.Size(784, 167)
        Me.DataGridViewLagerPositionen.TabIndex = 90
        '
        'btnLagerAnlegen
        '
        Me.btnLagerAnlegen.BackColor = System.Drawing.Color.White
        Me.btnLagerAnlegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLagerAnlegen.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLagerAnlegen.Location = New System.Drawing.Point(637, 6)
        Me.btnLagerAnlegen.Name = "btnLagerAnlegen"
        Me.btnLagerAnlegen.Size = New System.Drawing.Size(142, 34)
        Me.btnLagerAnlegen.TabIndex = 89
        Me.btnLagerAnlegen.Text = "Lager anlegen"
        Me.btnLagerAnlegen.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 22)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Lager ID"
        '
        'labelText_Suche
        '
        Me.labelText_Suche.AutoSize = True
        Me.labelText_Suche.Font = New System.Drawing.Font("Lucida Sans", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelText_Suche.Location = New System.Drawing.Point(13, 11)
        Me.labelText_Suche.Name = "labelText_Suche"
        Me.labelText_Suche.Size = New System.Drawing.Size(161, 22)
        Me.labelText_Suche.TabIndex = 85
        Me.labelText_Suche.Text = "Auswahl Lager:"
        '
        'cbLagerAuswahl
        '
        Me.cbLagerAuswahl.FormattingEnabled = True
        Me.cbLagerAuswahl.Location = New System.Drawing.Point(178, 12)
        Me.cbLagerAuswahl.Name = "cbLagerAuswahl"
        Me.cbLagerAuswahl.Size = New System.Drawing.Size(175, 21)
        Me.cbLagerAuswahl.TabIndex = 86
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        Me.Chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.IndianRed
        Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.Silver
        Me.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.BorderColor = System.Drawing.Color.Transparent
        ChartArea2.BorderWidth = 0
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.Transparent
        Legend2.BackSecondaryColor = System.Drawing.Color.Transparent
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(511, 93)
        Me.Chart1.MaximumSize = New System.Drawing.Size(268, 191)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.LabelForeColor = System.Drawing.Color.Transparent
        Series2.Legend = "Legend1"
        Series2.Name = "Lagerauslastung"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(268, 191)
        Me.Chart1.TabIndex = 83
        Me.Chart1.Text = "Chart1"
        Title2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.ForeColor = System.Drawing.Color.WhiteSmoke
        Title2.Name = "Title1"
        Title2.Text = "Lagerauslastung"
        Me.Chart1.Titles.Add(Title2)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 22)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Positionen:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 5)
        Me.Panel1.TabIndex = 53
        '
        'FormLagerverwaltung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(809, 517)
        Me.Controls.Add(Me.PanelBackground)
        Me.Controls.Add(Me.PanelControlBr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLagerverwaltung"
        Me.Text = "FormLagerverwaltung"
        Me.PanelControlBr.ResumeLayout(False)
        Me.PanelControlBr.PerformLayout()
        Me.PanelBackground.ResumeLayout(False)
        Me.PanelBackground.PerformLayout()
        CType(Me.DataGridViewLagerPositionen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControlBr As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents label_text_am_panelbar As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents PanelBackground As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label3 As Label
    Friend WithEvents labelText_Suche As Label
    Friend WithEvents cbLagerAuswahl As ComboBox
    Friend WithEvents btnLagerAnlegen As Button
    Friend WithEvents DataGridViewLagerPositionen As DataGridView
    Friend WithEvents Label_LagerCap As Label
    Friend WithEvents Label_LagerBez As Label
    Friend WithEvents Label_LagerID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
