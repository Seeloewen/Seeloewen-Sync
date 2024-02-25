Public Class frmSaveProfileAs

    Dim element1 As String
    Dim element2 As String
    Dim syncDirection As String
    Dim syncType As String

    '-- Event handlers --

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Begin saving the profile
        SaveProfile(tbSaveProfileAs.Text)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close window
        Close()
    End Sub

    Private Sub frmSaveProfileAs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear existing text when form opens
        tbSaveProfileAs.Clear()
    End Sub

    '-- Custom methods --

    Public Sub SaveProfile(profileName)
        'If tab page "folder" is selected
        If frmMain.tcMain.SelectedIndex = 0 Then
            'Save folder 1 and folder 2
            If String.IsNullOrEmpty(frmMain.tbFolder1.Text) Then
                element1 = "None"
            Else
                element1 = frmMain.tbFolder1.Text
            End If
            If String.IsNullOrEmpty(frmMain.tbFolder2.Text) Then
                element2 = "None"
            Else
                element2 = frmMain.tbFolder2.Text
            End If

            'Save folder sync direction
            syncDirection = frmMain.folderSyncDirection

            'Save sync type
            syncType = "Folder"

            'If tab page "file" is selected
        ElseIf frmMain.tcMain.SelectedIndex = 1 Then

            'Save file 1 and file 2
            If String.IsNullOrEmpty(frmMain.tbFile1.Text) Then
                element1 = "None"
            Else
                element1 = frmMain.tbFile1.Text
            End If
            If String.IsNullOrEmpty(frmMain.tbFile2.Text) Then
                element2 = "None"
            Else
                element2 = frmMain.tbFile2.Text
            End If

            'Save file sync direction
            syncDirection = frmMain.fileSyncDirection

            'Save sync type
            syncType = "File"
        End If

        'Saves the profile. It checks if the profile already exists or not. If it exists, it will show a warning, otherwise it will not.
        'It will then create a text file with the name set in ProfileName and write the content of the variable to the file.
        'It will show an error if ProfileName is empty or ProfileDirectory doesn't exist.
        Try
            If String.IsNullOrEmpty(profileName) = False Then
                If My.Computer.FileSystem.DirectoryExists(frmMain.profileDirectory) Then
                    If My.Computer.FileSystem.FileExists(frmMain.profileDirectory + profileName + ".txt") Then
                        Select Case MessageBox.Show("A profile with this name already exists. Do you want to override it?", "Profile already exists", MessageBoxButtons.YesNo)
                            Case Windows.Forms.DialogResult.Yes
                                My.Computer.FileSystem.WriteAllText(frmMain.profileDirectory + profileName + ".txt", element1 + vbNewLine + element2 + vbNewLine + syncDirection + vbNewLine + syncType, False)
                                MsgBox("Profile was overwritten and saved.", MsgBoxStyle.Information, "Overwritten and saved")
                                Close()
                            Case Windows.Forms.DialogResult.No
                                MsgBox("Profile was not overwritten. Please select a different profile name.", MsgBoxStyle.Exclamation, "Profile not overwritten.")
                        End Select
                    Else
                        My.Computer.FileSystem.WriteAllText(frmMain.profileDirectory + profileName + ".txt", element1 + vbNewLine + element2 + vbNewLine + syncDirection + vbNewLine + syncType, False)
                        MsgBox("Profile was saved.", MsgBoxStyle.Information, "Saved")
                        Close()
                    End If
                Else
                    MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("Error: Profile name is empty. Please enter a profile name.", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox(String.Format("Could not save the profile. {0}", ex.Message), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub UpdateProfile(ProfileName)
        'If tab page "folder" is selected
        If frmMain.tcMain.SelectedIndex = 0 Then
            'Save folder 1 and folder 2
            If String.IsNullOrEmpty(frmMain.tbFolder1.Text) Then
                element1 = "None"
            Else
                element1 = frmMain.tbFolder1.Text
            End If
            If String.IsNullOrEmpty(frmMain.tbFolder2.Text) Then
                element2 = "None"
            Else
                element2 = frmMain.tbFolder2.Text
            End If

            'Save folder sync direction
            syncDirection = frmMain.folderSyncDirection

            'Save sync type
            syncType = "Folder"

            'If tab page "file" is selected
        ElseIf frmMain.tcMain.SelectedIndex = 1 Then

            'Save file 1 and file 2
            If String.IsNullOrEmpty(frmMain.tbFile1.Text) Then
                element1 = "None"
            Else
                element1 = frmMain.tbFile1.Text
            End If
            If String.IsNullOrEmpty(frmMain.tbFile2.Text) Then
                element2 = "None"
            Else
                element2 = frmMain.tbFile2.Text
            End If

            'Save file sync direction
            syncDirection = frmMain.fileSyncDirection

            'Save sync type
            syncType = "File"
        End If

        Try
            'Update the selected profile. This will save and overwrite the selected profile without showing any warning or message. Used if a profile is old or corrupted.
            If String.IsNullOrEmpty(ProfileName) = False Then
                If My.Computer.FileSystem.DirectoryExists(frmMain.profileDirectory) Then
                    My.Computer.FileSystem.WriteAllText(frmMain.profileDirectory + ProfileName + ".txt", element1 + vbNewLine + element2 + vbNewLine + syncDirection + vbNewLine + syncType, False)
                Else
                    MsgBox("Error: Couldn't update profile. Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("Error: Couldn't update profile as the name is empty.", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox(String.Format("Could not update the profile. {0}", ex.Message), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class