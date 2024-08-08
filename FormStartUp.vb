Public NotInheritable Class FormStartUp


    Private Sub FormStartUp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim v As Version = Environment.Version
        LabelDotNetVersion.Text = v.ToString
        splashTimer.Interval = 3000
        splashTimer.Start()
    End Sub

    Private Sub splashTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles splashTimer.Tick
        Dim main As New FormMainMenu
        main.Show()
        Me.Close()
    End Sub

End Class
