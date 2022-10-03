Public Class frmSaveProfileAs

    Dim Folder1 As String
    Dim Folder2 As String
    Dim SyncDirection As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveProfile(tbSaveProfileAs.Text)
    End Sub

    Public Sub SaveProfile(ProfileName)
        Folder1 = frmMain.tbFolder1.Text
        Folder2 = frmMain.tbFolder2.Text
        SyncDirection = frmMain.SyncDirection

        If String.IsNullOrEmpty(ProfileName) = False Then
            If My.Computer.FileSystem.DirectoryExists(frmMain.AppData + "\SealSync\Profiles") Then
                If My.Computer.FileSystem.FileExists(frmMain.AppData + "\SealSync\Profiles\" + ProfileName + ".txt") Then
                    Select Case MessageBox.Show("A profile with this name already exists. Do you want to override it?", "Profile already exists", MessageBoxButtons.YesNo)
                        Case Windows.Forms.DialogResult.Yes
                            My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\SealSync\Profiles\" + ProfileName + ".txt", Folder1 + vbNewLine + Folder2 + vbNewLine + SyncDirection, False)
                            MsgBox("Profile was overwritten and saved.", MsgBoxStyle.Information, "Overwritten and saved")
                            Close()
                        Case Windows.Forms.DialogResult.No
                            MsgBox("Profile was not overwritten. Please select a different profile name.", MsgBoxStyle.Exclamation, "Profile not overwritten.")
                    End Select
                Else
                    My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\SealSync\Profiles\" + ProfileName + ".txt", Folder1 + vbNewLine + Folder2 + vbNewLine + SyncDirection, False)
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

    Public Sub UpdateProfile(ProfileName)
        If String.IsNullOrEmpty(ProfileName) = False Then
            If My.Computer.FileSystem.DirectoryExists(frmMain.AppData + "\SealSync\Profiles") Then
                My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\SealSync\Profiles\" + ProfileName + ".txt", Folder1 + vbNewLine + Folder2 + vbNewLine + SyncDirection, False)
            Else
                MsgBox("Error: Couldn't update profile. Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Error: Couldn't update profile as the name is empty.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub frmSaveProfileAs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbSaveProfileAs.Clear()
    End Sub
End Class