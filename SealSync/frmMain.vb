Public Class frmMain
    Private Sub btnBrowseSourceFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseSourceFolder.Click
        fbdSourceFolder.ShowDialog()
        Dim SourceFolder As String = fbdSourceFolder.SelectedPath
        tbSourceFolder.Text = SourceFolder
    End Sub

    Private Sub btnBrowseTargetFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseTargetFolder.Click
        fbdTargetFolder.ShowDialog()
        Dim TargetFolder As String = fbdTargetFolder.SelectedPath
        tbTargetFolder.Text = TargetFolder
    End Sub

    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSync.Click
        Try
            Sync()
        Catch execptionSync As Exception
            MsgBox(execptionSync.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub Sync()
        System.IO.Directory.Delete(tbTargetFolder.Text, True)
        My.Computer.FileSystem.CreateDirectory(tbTargetFolder.Text)
        My.Computer.FileSystem.CopyDirectory(tbSourceFolder.Text, tbTargetFolder.Text)
        MsgBox("Sync completed successfully!", MsgBoxStyle.Information, "Success")
    End Sub
End Class
