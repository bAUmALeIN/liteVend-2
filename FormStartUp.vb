Public NotInheritable Class FormStartUp


    Private Sub FormStartUp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim v As Version = Environment.Version
        LabelDotNetVersion.Text = v.ToString
        splashTimer.Interval = 3000
        splashTimer.Start()
        FormMainMenu.Icon = My.Resources.icons8_datenkonfiguration_941
        FormArtikelManager.Icon = My.Resources.icons8_datenkonfiguration_941
        FormDBManager.Icon = My.Resources.icons8_datenkonfiguration_941
        FormLagerAnlegen.Icon = My.Resources.icons8_datenkonfiguration_941
        FormLagerverwaltung.Icon = My.Resources.icons8_datenkonfiguration_941


    End Sub

    Private Sub splashTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles splashTimer.Tick
        Dim main As New FormMainMenu
        main.Show()
        Me.Close()
    End Sub

End Class
