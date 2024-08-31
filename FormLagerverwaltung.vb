Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormLagerverwaltung
    Dim activelager As New Globals.oLager
    Dim CM As New ConnectionManger
    Dim mouseOffset As Point
    Dim activeLagerID As Integer = -1
    Private ParentForm As FormMainMenu

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, PanelControlBr.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
        Me.TopMost = True
        Me.TopLevel = True
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, PanelControlBr.MouseMove

        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub FormLagerverwaltung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Combobox lager load
        loadLagerListInComboBox()



    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLagerAnlegen_Click(sender As Object, e As EventArgs) Handles btnLagerAnlegen.Click
        Dim FLA As New FormLagerAnlegen
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is FormLagerAnlegen Then
                frm.TopMost = True
                frm.TopLevel = True

                Return

            End If
        Next
        FLA.StartPosition = FormStartPosition.CenterScreen
        FLA.Show()

    End Sub

    Public Function loadLagerListInComboBox()
        Dim dt As New DataTable
        dt = CM.GetDataTableFromTable("LagerList")
        cbLagerAuswahl.DataSource = dt
        cbLagerAuswahl.DisplayMember = "Lager_Name"
        cbLagerAuswahl.ValueMember = "Lager_ID"
        cbLagerAuswahl.SelectedIndex = -1


    End Function

    Private Sub loadLagerDataInForm()
        If activeLagerID > 0 Then
            Try
                Dim dt_pos As New DataTable
                Dim dt_lager As New DataTable
                dt_lager = CM.GetDataTableFromTable($"Lager_{activeLagerID.ToString}")
                Logger.WriteLine($"loadLagerDataInForm | Lager ID: {activeLagerID.ToString}")
                dt_pos = CM.GetDataTableFromTable($"Lager_{activeLagerID.ToString}_Positionen")
                Logger.WriteLine($"loadLagerDataInForm | Positionen von Lager: {activeLagerID.ToString}")
                DataGridViewLagerPositionen.DataSource = dt_pos

                activelager = CM.getLagerAsLager(activeLagerID)
                If activelager IsNot Nothing Then
                    Label_LagerBez.Text = activelager.Bezeichnung
                    Label_LagerCap.Text = activelager.Cap.ToString
                    Label_LagerID.Text = activelager.ID.ToString

                End If

                Dim series As New Series("Lagerauslastung")
                series.ChartType = SeriesChartType.Pie

                ' Datenpunkte für belegte und freie Plätze hinzufügen
                series.Points.AddXY("Belegt", activelager.belegt)
                series.Points.AddXY("Frei", activelager.frei)
                series.IsValueShownAsLabel = False

                series.IsValueShownAsLabel = False
                Chart1.Series.Clear()
                Chart1.Series.Add(series)






            Catch ex As Exception

            End Try


        Else

            Logger.WriteLine($"activeLagerID > 1")

        End If
    End Sub

    Private Sub cbLagerAuswahl_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbLagerAuswahl.SelectionChangeCommitted
        activeLagerID = cbLagerAuswahl.SelectedValue
        Logger.WriteLine($"Selected Value Changed | Lager ID: {activeLagerID.ToString}")
        loadLagerDataInForm()


    End Sub


End Class