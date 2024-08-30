<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLagerverwaltung
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PanelControlBr = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.label_text_am_panelbar = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PanelBackground = New System.Windows.Forms.Panel()
        Me.btnLagerAnlegen = New System.Windows.Forms.Button()
        Me.label_LagerGroesseWert = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelText_Suche = New System.Windows.Forms.Label()
        Me.cbSearchBEZ = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChartLagerAuslastung = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewLagerPositionen = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControlBr.SuspendLayout()
        Me.PanelBackground.SuspendLayout()
        CType(Me.ChartLagerAuslastung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewLagerPositionen, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelBackground.Controls.Add(Me.btnLagerAnlegen)
        Me.PanelBackground.Controls.Add(Me.label_LagerGroesseWert)
        Me.PanelBackground.Controls.Add(Me.Label3)
        Me.PanelBackground.Controls.Add(Me.labelText_Suche)
        Me.PanelBackground.Controls.Add(Me.cbSearchBEZ)
        Me.PanelBackground.Controls.Add(Me.Label2)
        Me.PanelBackground.Controls.Add(Me.ChartLagerAuslastung)
        Me.PanelBackground.Controls.Add(Me.Label1)
        Me.PanelBackground.Controls.Add(Me.DataGridViewLagerPositionen)
        Me.PanelBackground.Controls.Add(Me.Panel1)
        Me.PanelBackground.Location = New System.Drawing.Point(6, 33)
        Me.PanelBackground.Name = "PanelBackground"
        Me.PanelBackground.Size = New System.Drawing.Size(796, 478)
        Me.PanelBackground.TabIndex = 83
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
        'label_LagerGroesseWert
        '
        Me.label_LagerGroesseWert.AutoSize = True
        Me.label_LagerGroesseWert.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_LagerGroesseWert.Location = New System.Drawing.Point(94, 113)
        Me.label_LagerGroesseWert.Name = "label_LagerGroesseWert"
        Me.label_LagerGroesseWert.Size = New System.Drawing.Size(23, 22)
        Me.label_LagerGroesseWert.TabIndex = 88
        Me.label_LagerGroesseWert.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 22)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Größe:"
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
        'cbSearchBEZ
        '
        Me.cbSearchBEZ.FormattingEnabled = True
        Me.cbSearchBEZ.Location = New System.Drawing.Point(178, 12)
        Me.cbSearchBEZ.Name = "cbSearchBEZ"
        Me.cbSearchBEZ.Size = New System.Drawing.Size(175, 21)
        Me.cbSearchBEZ.TabIndex = 86
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(550, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 22)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Auslastung:"
        '
        'ChartLagerAuslastung
        '
        Me.ChartLagerAuslastung.BackColor = System.Drawing.Color.Silver
        Me.ChartLagerAuslastung.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.ChartLagerAuslastung.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ChartLagerAuslastung.Legends.Add(Legend2)
        Me.ChartLagerAuslastung.Location = New System.Drawing.Point(453, 113)
        Me.ChartLagerAuslastung.Name = "ChartLagerAuslastung"
        Me.ChartLagerAuslastung.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.ChartLagerAuslastung.Series.Add(Series2)
        Me.ChartLagerAuslastung.Size = New System.Drawing.Size(308, 272)
        Me.ChartLagerAuslastung.TabIndex = 83
        Me.ChartLagerAuslastung.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 22)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Positionen:"
        '
        'DataGridViewLagerPositionen
        '
        Me.DataGridViewLagerPositionen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLagerPositionen.Location = New System.Drawing.Point(204, 113)
        Me.DataGridViewLagerPositionen.Name = "DataGridViewLagerPositionen"
        Me.DataGridViewLagerPositionen.Size = New System.Drawing.Size(190, 272)
        Me.DataGridViewLagerPositionen.TabIndex = 80
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
        CType(Me.ChartLagerAuslastung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewLagerPositionen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControlBr As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents label_text_am_panelbar As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents PanelBackground As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewLagerPositionen As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ChartLagerAuslastung As DataVisualization.Charting.Chart
    Friend WithEvents label_LagerGroesseWert As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labelText_Suche As Label
    Friend WithEvents cbSearchBEZ As ComboBox
    Friend WithEvents btnLagerAnlegen As Button
End Class
