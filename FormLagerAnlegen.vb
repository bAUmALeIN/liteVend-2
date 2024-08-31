Imports System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
Imports Getränke_Automat_V2.Globals

Public Class FormLagerAnlegen
    Private ParenForm As FormLagerverwaltung
    Dim CM As New ConnectionManger
    Dim mouseOffset As Point

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, PanelControlBr.MouseDown, label_text_am_panelbar.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
        Me.TopMost = True
        Me.TopMost = True
    End Sub

    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, PanelControlBr.MouseMove, label_text_am_panelbar.MouseMove

        If e.Button = MouseButtons.Left Then
            Dim mousePos = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLagergroesse.TextChanged


        Try

            If TextBoxLagergroesse.Text IsNot "" Then
                Dim zahl As Integer = Convert.ToInt32(TextBoxLagergroesse.Text)
                DataGridView1.Enabled = True
                Globals.newLagerCap = zahl
                fillDGVwithIDs()
                btnSaveLager.Enabled = True
            Else
                DataGridView1.Rows.Clear() ' Lösche alle bestehenden Zeilen
                DataGridView1.Enabled = False
                btnSaveLager.Enabled = False
            End If
        Catch ex As Exception
            Logger.WriteLine("Fehler Convert.ToInt32:" + ex.Message)
        End Try


    End Sub

    Private Sub fillDGVwithIDs()
        Dim ids As New List(Of Integer)
        For counter As Integer = 1 To Globals.newLagerCap
            ids.Add(counter)
        Next
        DataGridView1.Rows.Clear()
        If CheckBoxStandardBez.Checked Then
            For Each id In ids
                Dim rowIndex As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(rowIndex).Cells("PositionsID").Value = id
                DataGridView1.Rows(rowIndex).Cells("PositionsBez").Value = $"Position_00" + id.ToString
            Next

        Else


            For Each id In ids
                Dim rowIndex As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(rowIndex).Cells("PositionsID").Value = id
            Next
        End If

    End Sub

    Private Sub CheckBoxStandardBez_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxStandardBez.CheckedChanged
        If DataGridView1.RowCount > 1 Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim rowindex As Integer = row.Index
                    DataGridView1.Rows(rowindex).Cells("PositionsBez").Value = $"Position_00{(rowindex + 1).ToString}"
                End If
            Next
        Else
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim rowindex As Integer = row.Index
                    DataGridView1.Rows(rowindex).Cells("PositionsBez").Value = Nothing
                End If
            Next
        End If
        If CheckBoxStandardBez.CheckState = CheckState.Unchecked Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim rowindex As Integer = row.Index
                    DataGridView1.Rows(rowindex).Cells("PositionsBez").Value = Nothing
                End If
            Next

        End If
    End Sub

    Private Sub btnSaveLager_Click(sender As Object, e As EventArgs) Handles btnSaveLager.Click
        If TextBoxLagerBez.Text = "" Then
            If MsgBox("Es wurde keine Bezeichnung eingetragen, Soll die standard Bezeichnung verwendet werden ?", MsgBoxStyle.YesNo, "Keine Lager Bezeichnung") = MsgBoxResult.Yes Then

                Dim nextLagerNummer As Integer = CM.getNextFreeLagerNumner
                Dim newLager As New Globals.oLager
                If nextLagerNummer > 0 Then
                    newLager.Bezeichnung = $"Lager_{nextLagerNummer.ToString}"
                    newLager.belegt = 0
                    newLager.Cap = Convert.ToInt32(TextBoxLagergroesse.Text)
                    newLager.frei = Convert.ToInt32(TextBoxLagergroesse.Text)
                    newLager.ID = nextLagerNummer
                End If



                Try
                    'Create Lager Table 
                    ' Create Lager Pos Table
                    CM.CreateLagerAndPosTable(newLager)

                    'Fill Lager Table 
                    'Fill Lager Pos Table
                    Globals.newLagerPositionsListe.Clear()
                    FillLagerPositionsListeFromDGV(DataGridView1)
                    CM.InsertInto_Lager_withPos(newLager, Globals.newLagerPositionsListe)
                    Logger.WriteLine($"Lager angelegt | {newLager.Bezeichnung} | Anzahl Positionen:{Globals.newLagerPositionsListe.Count.ToString}")
                    clearAfterNewLager()
                    MsgBox("Lager Erstellt", MsgBoxStyle.OkOnly, "Erfolgreich!")
                    For Each frm As Form In Application.OpenForms
                        If TypeOf frm Is FormLagerverwaltung Then
                            Dim lagerForm As FormLagerverwaltung = DirectCast(frm, FormLagerverwaltung)
                            lagerForm.loadLagerListInComboBox()

                            Return

                        End If
                    Next


                Catch ex As Exception
                    Logger.WriteLine($"SUB btn Save: {ex.Message}")
                End Try


            End If

        Else

        End If
    End Sub

    Public Sub FillLagerPositionsListeFromDGV(dgv As DataGridView)

        newLagerPositionsListe.Clear()


        For Each row As DataGridViewRow In dgv.Rows

            If Not row.IsNewRow Then

                Dim pos As New LagerPosition()


                pos.ID = Convert.ToInt32(row.Cells("PositionsID").Value)
                pos.Bez = Convert.ToString(row.Cells("PositionsBez").Value)

                newLagerPositionsListe.Add(pos)

                Logger.WriteLine($"SUB FillLagerPositionsListeFromDGV| ADD posID: {pos.ID.ToString} & posBez{pos.Bez} ")
            End If
        Next
    End Sub

    Public Sub clearAfterNewLager()
        TextBoxLagerBez.Text = ""
        TextBoxLagergroesse.Text = ""
        CheckBoxStandardBez.Checked = False

    End Sub
End Class