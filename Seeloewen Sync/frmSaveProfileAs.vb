Public Class frmSaveProfileAs

    Dim Element1 As String
    Dim Element2 As String
    Dim SyncDirection As String
    Dim SyncType As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveProfile(tbSaveProfileAs.Text)
    End Sub

    Public Sub SaveProfile(ProfileName)
        If frmMain.tcMain.SelectedIndex = 0 Then
            If String.IsNullOrEmpty(frmMain.tbFolder1.Text) Then
                Element1 = "None"
            Else
                Element1 = frmMain.tbFolder1.Text
            End If
            If String.IsNullOrEmpty(frmMain.tbFolder2.Text) Then
                Element2 = "None"
            Else
                Element2 = frmMain.tbFolder2.Text
            End If

            SyncDirection = frmMain.folderSyncDirection

            If frmMain.tcMain.SelectedIndex = 0 Then
                SyncType = "Folder"
            ElseIf frmMain.tcMain.SelectedIndex = 1 Then
                SyncType = "File"
            Else
                SyncType = "Folder"
            End If
        ElseIf frmMain.tcMain.SelectedIndex = 1 Then
            If String.IsNullOrEmpty(frmMain.tbFile1.Text) Then
                Element1 = "None"
            Else
                Element1 = frmMain.tbFile1.Text
            End If
            If String.IsNullOrEmpty(frmMain.tbFile2.Text) Then
                Element2 = "None"
            Else
                Element2 = frmMain.tbFile2.Text
            End If

            SyncDirection = frmMain.fileSyncDirection

            If frmMain.tcMain.SelectedIndex = 0 Then
                SyncType = "Folder"
            ElseIf frmMain.tcMain.SelectedIndex = 1 Then
                SyncType = "File"
            Else
                SyncType = "Folder"
            End If
        End If

        If String.IsNullOrEmpty(ProfileName) = False Then
            If My.Computer.FileSystem.DirectoryExists(frmMain.appData + "\SealSync\Profiles") Then
                If My.Computer.FileSystem.FileExists(frmMain.appData + "\SealSync\Profiles\" + ProfileName + ".txt") Then
                    Select Case MessageBox.Show("A profile with this name already exists. Do you want to override it?", "Profile already exists", MessageBoxButtons.YesNo)
                        Case Windows.Forms.DialogResult.Yes
                            My.Computer.FileSystem.WriteAllText(frmMain.appData + "\SealSync\Profiles\" + ProfileName + ".txt", Element1 + vbNewLine + Element2 + vbNewLine + SyncDirection + vbNewLine + SyncType, False)
                            MsgBox("Profile was overwritten and saved.", MsgBoxStyle.Information, "Overwritten and saved")
                            Close()
                        Case Windows.Forms.DialogResult.No
                            MsgBox("Profile was not overwritten. Please select a different profile name.", MsgBoxStyle.Exclamation, "Profile not overwritten.")
                    End Select
                Else
                    My.Computer.FileSystem.WriteAllText(frmMain.appData + "\SealSync\Profiles\" + ProfileName + ".txt", Element1 + vbNewLine + Element2 + vbNewLine + SyncDirection + vbNewLine + SyncType, False)
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
        If frmMain.tcMain.SelectedIndex = 0 Then
            If String.IsNullOrEmpty(frmMain.tbFolder1.Text) Then
                Element1 = "None"
            Else
                Element1 = frmMain.tbFolder1.Text
            End If
            If String.IsNullOrEmpty(frmMain.tbFolder2.Text) Then
                Element2 = "None"
            Else
                Element2 = frmMain.tbFolder2.Text
            End If

            SyncDirection = frmMain.folderSyncDirection

            If frmMain.tcMain.SelectedIndex = 0 Then
                SyncType = "Folder"
            ElseIf frmMain.tcMain.SelectedIndex = 1 Then
                SyncType = "File"
            Else
                SyncType = "Folder"
            End If
        ElseIf frmMain.tcMain.SelectedIndex = 1 Then
            If String.IsNullOrEmpty(frmMain.tbFile1.Text) Then
                Element1 = "None"
            Else
                Element1 = frmMain.tbFile1.Text
            End If
            If String.IsNullOrEmpty(frmMain.tbFile2.Text) Then
                Element2 = "None"
            Else
                Element2 = frmMain.tbFile2.Text
            End If

            SyncDirection = frmMain.fileSyncDirection

            If frmMain.tcMain.SelectedIndex = 0 Then
                SyncType = "Folder"
            ElseIf frmMain.tcMain.SelectedIndex = 1 Then
                SyncType = "File"
            Else
                SyncType = "Folder"
            End If
        End If

        If String.IsNullOrEmpty(ProfileName) = False Then
            If My.Computer.FileSystem.DirectoryExists(frmMain.AppData + "\SealSync\Profiles") Then
                My.Computer.FileSystem.WriteAllText(frmMain.appData + "\SealSync\Profiles\" + ProfileName + ".txt", Element1 + vbNewLine + Element2 + vbNewLine + SyncDirection + vbNewLine + SyncType, False)
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