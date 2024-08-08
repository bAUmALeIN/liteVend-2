Imports System.Drawing
Imports System.Windows.Forms

Public Class CustomTabControl
    Inherits TabControl

    Private closeImage As Image

    Public Sub New()
        MyBase.New()

        closeImage = My.Resources.icons8_delete_16
        Me.DrawMode = TabDrawMode.OwnerDrawFixed
        Me.SizeMode = TabSizeMode.Fixed
        Me.ItemSize = New Size(150, 20)
        AddHandler Me.DrawItem, AddressOf OnDrawItem
        AddHandler Me.MouseDown, AddressOf OnMouseDown
    End Sub

    Protected Sub OnDrawItem(sender As Object, e As DrawItemEventArgs)
        Dim tabPage = Me.TabPages(e.Index)
        Dim tabRect = Me.GetTabRect(e.Index)
        tabRect.Inflate(-2, -2)

        Dim textRect = New Rectangle(tabRect.Left, tabRect.Top, tabRect.Width - closeImage.Width, tabRect.Height)
        e.Graphics.DrawString(tabPage.Text, Me.Font, SystemBrushes.ControlText, textRect)


        Dim closeImageRect = New Rectangle(tabRect.Right - closeImage.Width, tabRect.Top, closeImage.Width, closeImage.Height)
        e.Graphics.DrawImage(closeImage, closeImageRect.Location)
    End Sub

    Protected Sub OnMouseDown(sender As Object, e As MouseEventArgs)
        For i As Integer = 0 To Me.TabPages.Count - 1
            Dim tabRect = Me.GetTabRect(i)
            tabRect.Inflate(-2, -2)
            Dim closeImageRect = New Rectangle(tabRect.Right - closeImage.Width, tabRect.Top, closeImage.Width, closeImage.Height)

            If closeImageRect.Contains(e.Location) Then
                Me.TabPages.RemoveAt(i)
                Exit For
            End If
        Next
    End Sub
End Class
