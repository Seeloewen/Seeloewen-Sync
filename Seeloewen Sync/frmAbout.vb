Public Class frmAbout

    '-- Event handlers --

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Close window
        Close()
    End Sub

    Private Sub llblGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblGithub.LinkClicked
        'Open GitHub page of Seeloewen Sync in Browser
        Process.Start("https://github.com/Seeloewen/Seeloewen-Sync")
    End Sub
End Class