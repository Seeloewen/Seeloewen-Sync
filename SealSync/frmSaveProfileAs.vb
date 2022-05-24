Public Class frmSaveProfileAs

    Dim SourceFolder As String
    Dim TargetFolder As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        SourceFolder = frmMain.tbSourceFolder.Text
        TargetFolder = frmMain.tbTargetFolder.Text

        If String.IsNullOrEmpty(tbSaveProfileAs.Text) = False Then
            If My.Computer.FileSystem.DirectoryExists(frmMain.AppData + "\SealSync\Profiles") Then
                If My.Computer.FileSystem.FileExists(frmMain.AppData + "\SealSync\Profiles\" + tbSaveProfileAs.Text + ".txt") Then
                    Select Case MessageBox.Show("A profile with this name already exists. Do you want to override it?", "Profile already exists", MessageBoxButtons.YesNo)
                        Case Windows.Forms.DialogResult.Yes
                            My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\SealSync\Profiles\" + tbSaveProfileAs.Text + ".txt", SourceFolder + vbNewLine + TargetFolder, False)
                            MsgBox("Profile was overwritten and saved.", MsgBoxStyle.Information, "Overwritten and saved")
                            Close()
                        Case Windows.Forms.DialogResult.No
                            MsgBox("Profile was not overwritten. Please select a different profile name.", MsgBoxStyle.Exclamation, "Profile not overwritten.")
                    End Select
                Else
                    My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\SealSync\Profiles\" + tbSaveProfileAs.Text + ".txt", SourceFolder + vbNewLine + TargetFolder, False)
                    MsgBox("Profile was saved.", MsgBoxStyle.Information, "Saved")
                    Close()
                End If
            Else
                MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Error: Profile name is empty. Please enter a profile name.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub frmSaveProfileAs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbSaveProfileAs.Clear()
    End Sub
End Class