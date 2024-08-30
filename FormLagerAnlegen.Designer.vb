<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLagerAnlegen
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBoxStandardBez = New System.Windows.Forms.CheckBox()
        Me.btnSaveLager = New System.Windows.Forms.Button()
        Me.labelText_Suche = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PositionsID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionsBez = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxLagergroesse = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxLagerBez = New System.Windows.Forms.TextBox()
        Me.PanelControlBr = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.label_text_am_panelbar = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControlBr.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.CheckBoxStandardBez)
        Me.Panel1.Controls.Add(Me.btnSaveLager)
        Me.Panel1.Controls.Add(Me.labelText_Suche)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBoxLagergroesse)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBoxLagerBez)
        Me.Panel1.Location = New System.Drawing.Point(4, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 270)
        Me.Panel1.TabIndex = 67
        '
        'CheckBoxStandardBez
        '
        Me.CheckBoxStandardBez.AutoSize = True
        Me.CheckBoxStandardBez.Location = New System.Drawing.Point(393, 10)
        Me.CheckBoxStandardBez.Name = "CheckBoxStandardBez"
        Me.CheckBoxStandardBez.Size = New System.Drawing.Size(93, 17)
        Me.CheckBoxStandardBez.TabIndex = 88
        Me.CheckBoxStandardBez.Text = "Standard Bez."
        Me.CheckBoxStandardBez.UseVisualStyleBackColor = True
        '
        'btnSaveLager
        '
        Me.btnSaveLager.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSaveLager.Enabled = False
        Me.btnSaveLager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveLager.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveLager.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnSaveLager.Location = New System.Drawing.Point(388, 240)
        Me.btnSaveLager.Name = "btnSaveLager"
        Me.btnSaveLager.Size = New System.Drawing.Size(96, 27)
        Me.btnSaveLager.TabIndex = 87
        Me.btnSaveLager.Text = "Speichern"
        Me.btnSaveLager.UseVisualStyleBackColor = False
        '
        'labelText_Suche
        '
        Me.labelText_Suche.AutoSize = True
        Me.labelText_Suche.Font = New System.Drawing.Font("Lucida Sans", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelText_Suche.Location = New System.Drawing.Point(11, 45)
        Me.labelText_Suche.Name = "labelText_Suche"
        Me.labelText_Suche.Size = New System.Drawing.Size(122, 22)
        Me.labelText_Suche.TabIndex = 86
        Me.labelText_Suche.Text = "Positionen:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PositionsID, Me.PositionsBez})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(9, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(475, 167)
        Me.DataGridView1.TabIndex = 55
        '
        'PositionsID
        '
        Me.PositionsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PositionsID.HeaderText = "ID"
        Me.PositionsID.Name = "PositionsID"
        Me.PositionsID.ReadOnly = True
        Me.PositionsID.Width = 46
        '
        'PositionsBez
        '
        Me.PositionsBez.HeaderText = "Bezeichnung"
        Me.PositionsBez.Name = "PositionsBez"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Location = New System.Drawing.Point(3, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(492, 10)
        Me.Panel2.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Größe:"
        '
        'TextBoxLagergroesse
        '
        Me.TextBoxLagergroesse.Location = New System.Drawing.Point(320, 8)
        Me.TextBoxLagergroesse.Name = "TextBoxLagergroesse"
        Me.TextBoxLagergroesse.Size = New System.Drawing.Size(67, 20)
        Me.TextBoxLagergroesse.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Bezeichnung:"
        '
        'TextBoxLagerBez
        '
        Me.TextBoxLagerBez.Location = New System.Drawing.Point(125, 8)
        Me.TextBoxLagerBez.Name = "TextBoxLagerBez"
        Me.TextBoxLagerBez.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxLagerBez.TabIndex = 0
        '
        'PanelControlBr
        '
        Me.PanelControlBr.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PanelControlBr.Controls.Add(Me.Button1)
        Me.PanelControlBr.Controls.Add(Me.btnMinimize)
        Me.PanelControlBr.Controls.Add(Me.Button2)
        Me.PanelControlBr.Controls.Add(Me.label_text_am_panelbar)
        Me.PanelControlBr.Controls.Add(Me.btnClose)
        Me.PanelControlBr.Location = New System.Drawing.Point(4, 0)
        Me.PanelControlBr.Name = "PanelControlBr"
        Me.PanelControlBr.Size = New System.Drawing.Size(495, 33)
        Me.PanelControlBr.TabIndex = 83
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Button1.Location = New System.Drawing.Point(443, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "-"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Brown
        Me.Button2.Location = New System.Drawing.Point(468, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 24)
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "X"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'label_text_am_panelbar
        '
        Me.label_text_am_panelbar.AutoSize = True
        Me.label_text_am_panelbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_text_am_panelbar.ForeColor = System.Drawing.SystemColors.Control
        Me.label_text_am_panelbar.Location = New System.Drawing.Point(3, 3)
        Me.label_text_am_panelbar.Name = "label_text_am_panelbar"
        Me.label_text_am_panelbar.Size = New System.Drawing.Size(149, 24)
        Me.label_text_am_panelbar.TabIndex = 57
        Me.label_text_am_panelbar.Text = "Lager erstellen"
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
        'FormLagerAnlegen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(503, 303)
        Me.Controls.Add(Me.PanelControlBr)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLagerAnlegen"
        Me.Text = "FormLagerauslastung"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControlBr.ResumeLayout(False)
        Me.PanelControlBr.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxLagerBez As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxLagergroesse As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelControlBr As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents label_text_am_panelbar As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents labelText_Suche As Label
    Friend WithEvents btnSaveLager As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PositionsID As DataGridViewTextBoxColumn
    Friend WithEvents PositionsBez As DataGridViewTextBoxColumn
    Friend WithEvents CheckBoxStandardBez As CheckBox
End Class
