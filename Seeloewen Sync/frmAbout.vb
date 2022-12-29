Public Class frmAbout
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Close()
    End Sub

    Private Sub llblGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblGithub.LinkClicked
        Process.Start("https://github.com/Seeloewen/SealSync")
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class