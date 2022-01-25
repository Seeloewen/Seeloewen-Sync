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
        If String.IsNullOrEmpty(tbSourceFolder.Text & tbTargetFolder.Text) Then
            MsgBox("Error: Source and target folder cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbTargetFolder.Text) Then
            MsgBox("Error: Target folder cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbSourceFolder.Text) Then
            MsgBox("Error: Source folder cannot be empty.", MsgBoxStyle.Critical, "Error")
        Else
            Try
                Sync()
            Catch execptionSync As Exception
                MsgBox(execptionSync.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub Sync()
        System.IO.Directory.Delete(tbTargetFolder.Text, True)
        My.Computer.FileSystem.CreateDirectory(tbTargetFolder.Text)
        My.Computer.FileSystem.CopyDirectory(tbSourceFolder.Text, tbTargetFolder.Text)
        MsgBox("Sync completed successfully!", MsgBoxStyle.Information, "Success")
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmSettings.ShowDialog()
    End Sub
End Class
