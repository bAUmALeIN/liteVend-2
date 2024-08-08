<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOverview
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
        Me.PanelAddProduktMain = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnMini = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PanelOverview = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PanelAddProduktMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelOverview.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelAddProduktMain
        '
        Me.PanelAddProduktMain.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelAddProduktMain.Controls.Add(Me.Panel3)
        Me.PanelAddProduktMain.Controls.Add(Me.Label1)
        Me.PanelAddProduktMain.Controls.Add(Me.Panel2)
        Me.PanelAddProduktMain.Controls.Add(Me.PanelOverview)
        Me.PanelAddProduktMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAddProduktMain.Location = New System.Drawing.Point(0, 0)
        Me.PanelAddProduktMain.Name = "PanelAddProduktMain"
        Me.PanelAddProduktMain.Size = New System.Drawing.Size(586, 331)
        Me.PanelAddProduktMain.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Location = New System.Drawing.Point(-2, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(588, 17)
        Me.Panel3.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(198, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 22)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Produktübersicht"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.btnMini)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(585, 25)
        Me.Panel2.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "liteVend"
        '
        'btnMini
        '
        Me.btnMini.FlatAppearance.BorderSize = 0
        Me.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMini.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMini.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnMini.Location = New System.Drawing.Point(533, 0)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(24, 24)
        Me.btnMini.TabIndex = 5
        Me.btnMini.Text = "-"
        Me.btnMini.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMini.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Brown
        Me.btnClose.Location = New System.Drawing.Point(558, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 24)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PanelOverview
        '
        Me.PanelOverview.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelOverview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelOverview.Controls.Add(Me.DataGridView1)
        Me.PanelOverview.Location = New System.Drawing.Point(10, 72)
        Me.PanelOverview.Name = "PanelOverview"
        Me.PanelOverview.Size = New System.Drawing.Size(564, 236)
        Me.PanelOverview.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(549, 226)
        Me.DataGridView1.TabIndex = 0
        '
        'FormOverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 331)
        Me.Controls.Add(Me.PanelAddProduktMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormOverview"
        Me.Text = "FormOverview"
        Me.PanelAddProduktMain.ResumeLayout(False)
        Me.PanelAddProduktMain.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelOverview.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAddProduktMain As Panel
    Friend WithEvents PanelOverview As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnMini As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
End Class
