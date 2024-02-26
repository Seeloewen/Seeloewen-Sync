Imports System.Environment
Imports System.IO

Public Class frmMain

    Public appData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Public profileDirectory As String = appData + "\Seeloewen Sync\Profiles\"
    Dim profileList As String()
    Public folderSyncDirection As String = "Down"
    Public fileSyncDirection As String = "Down"

    '-- Event handlers --

    Private Sub btnBrowseFolder1_Click(sender As Object, e As EventArgs) Handles btnBrowseFolder1.Click
        'Show folder browser for folder 1
        fbdFolder1.ShowDialog()
        tbFolder1.Text = fbdFolder1.SelectedPath
    End Sub

    Private Sub btnBrowseFolder2_Click(sender As Object, e As EventArgs) Handles btnBrowseFolder2.Click
        'Show folder browser for folder 2
        fbdFolder2.ShowDialog()
        tbFolder2.Text = fbdFolder2.SelectedPath
    End Sub

    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSyncFolders.Click
        'Check if folder 1 or 2 are empty
        If String.IsNullOrEmpty(tbFolder1.Text & tbFolder2.Text) Then
            MsgBox("Error: Folder 1 and Folder 2 cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbFolder2.Text) Then
            MsgBox("Error: Folder 1 cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbFolder1.Text) Then
            MsgBox("Error: Folder 2 cannot be empty.", MsgBoxStyle.Critical, "Error")
        Else
            Try
                'Depending on the sync direction, start synchronization of folders
                If folderSyncDirection = "Down" Then
                    SyncFolder(tbFolder1.Text, tbFolder2.Text)
                    MsgBox("Synchronization completed successfully!", MsgBoxStyle.Information, "Success")
                ElseIf folderSyncDirection = "Up" Then
                    SyncFolder(tbFolder2.Text, tbFolder1.Text)
                    MsgBox("Synchronization completed successfully!", MsgBoxStyle.Information, "Success")
                End If
            Catch execptionSync As Exception
                MsgBox(execptionSync.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        'Show about window
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        'Show settings window
        frmSettings.ShowDialog()
    End Sub
    Private Sub btnLoadProfile_Click(sender As Object, e As EventArgs) Handles btnLoadProfile.Click
        'Show load profile from dialog
        frmLoadProfileFrom.ShowDialog()
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        'Show save profile as dialog
        frmSaveProfileAs.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create directory in appdata if it doesn't already exist
        If My.Computer.FileSystem.DirectoryExists(profileDirectory) = False Then
            My.Computer.FileSystem.CreateDirectory(profileDirectory)
        End If

        'Get all profiles
        GetFiles(profileDirectory)

        'Load default profile
        If My.Settings.LoadProfileByDefault = True Then
            frmSettings.cbLoadProfileByDefault.Checked = True
            If String.IsNullOrEmpty(My.Settings.DefaultProfile) = False Then
                If My.Computer.FileSystem.FileExists(profileDirectory + My.Settings.DefaultProfile + ".txt") Then
                    cbxDefaultProfile.SelectedItem = My.Settings.DefaultProfile
                    frmLoadProfileFrom.InitializeLoadingProfile(cbxDefaultProfile.SelectedItem, False)
                Else
                    MsgBox("Error: Default profile no longer exists. Option will be disabled automatically.", MsgBoxStyle.Critical, "Error")
                    frmSettings.cbLoadProfileByDefault.Checked = False
                    My.Settings.LoadProfileByDefault = False
                End If
            Else
                MsgBox("Error: Could not load default profile as it is empty. Option will be disabled automatically.", MsgBoxStyle.Critical, "Error")
                frmSettings.cbLoadProfileByDefault.Checked = False
                My.Settings.LoadProfileByDefault = False
            End If
        End If
    End Sub

    Private Sub btnChangeSyncDirectionFolders_Click(sender As Object, e As EventArgs) Handles btnChangeSyncDirectionFolders.Click
        'Change sync direction variable and image on button for folders
        If folderSyncDirection = "Down" Then
            folderSyncDirection = "Up"
            btnChangeSyncDirectionFolders.BackgroundImage = My.Resources.imgSyncUp
        ElseIf folderSyncDirection = "Up" Then
            folderSyncDirection = "Down"
            btnChangeSyncDirectionFolders.BackgroundImage = My.Resources.imgSyncDown
        End If
    End Sub

    Private Sub btnCompareFolders_Click(sender As Object, e As EventArgs) Handles btnCompareFolders.Click
        'Open folder compare window if both folder 1 and 2 exist
        If String.IsNullOrEmpty(tbFolder1.Text) Or String.IsNullOrEmpty(tbFolder2.Text) Then
            MsgBox("Please specify a folder 1 and a folder 2", MsgBoxStyle.Critical, "Error")
        Else
            If My.Computer.FileSystem.DirectoryExists(tbFolder1.Text) And My.Computer.FileSystem.DirectoryExists(tbFolder2.Text) Then
                frmCompareFolders.Show()
            Else
                MsgBox("Please ensure that the directories you entered are valid.", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub btnBrowseFile1_Click(sender As Object, e As EventArgs) Handles btnBrowseFile1.Click
        'Open file dialog for file 1
        ofdFile1.ShowDialog()
        tbFile1.Text = ofdFile1.FileName
    End Sub

    Private Sub btnBrowseFile2_Click(sender As Object, e As EventArgs) Handles btnBrowseFile2.Click
        'Open file dialog for file 2
        ofdFile2.ShowDialog()
        tbFile2.Text = ofdFile2.FileName
    End Sub

    Private Sub btnChangeSyncDirectionFiles_Click(sender As Object, e As EventArgs) Handles btnChangeSyncDirectionFiles.Click
        'Change sync direction variable and image on button for files
        If fileSyncDirection = "Down" Then
            fileSyncDirection = "Up"
            btnChangeSyncDirectionFiles.BackgroundImage = My.Resources.imgSyncUp
        ElseIf fileSyncDirection = "Up" Then
            fileSyncDirection = "Down"
            btnChangeSyncDirectionFiles.BackgroundImage = My.Resources.imgSyncDown
        End If
    End Sub

    Private Sub btnSyncFiles_Click(sender As Object, e As EventArgs) Handles btnSyncFiles.Click
        'Check if file 1 and 2 exists
        If String.IsNullOrEmpty(tbFile1.Text & tbFile2.Text) Then
            MsgBox("Error: File 1 and File 2 cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbFile2.Text) Then
            MsgBox("Error: File 1 cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbFile1.Text) Then
            MsgBox("Error: File 2 cannot be empty.", MsgBoxStyle.Critical, "Error")
        Else
            If (File.Exists(tbFile1.Text) And File.Exists(tbFile2.Text)) Then
                'Start synchronization of files depending on sync direction
                Try
                    If fileSyncDirection = "Down" Then
                        SyncFile(tbFile1.Text, tbFile2.Text)
                        MsgBox("Synchronization completed successfully!", MsgBoxStyle.Information, "Success")
                    ElseIf fileSyncDirection = "Up" Then
                        SyncFile(tbFile2.Text, tbFile1.Text)
                        MsgBox("Synchronization completed successfully!", MsgBoxStyle.Information, "Success")
                    End If
                Catch execptionSync As Exception
                    MsgBox(execptionSync.Message, MsgBoxStyle.Critical, "Error")
                End Try
            Else
                MsgBox("Error: Please ensure that both of the files exist.")
            End If
        End If
    End Sub

    Private Sub btnCompareFiles_Click(sender As Object, e As EventArgs) Handles btnCompareFiles.Click
        'Open file compare dialog if both file 1 and 2 exist
        If String.IsNullOrEmpty(tbFile1.Text) Or String.IsNullOrEmpty(tbFile2.Text) Then
            MsgBox("Please specify a file 1 and a file 2.", MsgBoxStyle.Critical, "Error")
        Else
            If My.Computer.FileSystem.FileExists(tbFile1.Text) = False Or My.Computer.FileSystem.FileExists(tbFile2.Text) = False Then
                MsgBox("Please select a valid file path for both files.", MsgBoxStyle.Critical, "Error")
            Else
                frmCompareFiles.Show()
            End If
        End If
    End Sub

    '-- Custom methods --

    Private Sub SyncFolder(sourceFolder As String, targetFolder As String)
        'Delete target folder and copy source folder to target directory
        Directory.Delete(targetFolder, True)
        My.Computer.FileSystem.CreateDirectory(targetFolder)
        My.Computer.FileSystem.CopyDirectory(sourceFolder, targetFolder)
    End Sub

    Private Sub SyncFile(sourceFile As String, targetFile As String)
        Try
            'Copy all bytes from the source file to the target file
            Using sourceStream As FileStream = File.Open(sourceFile, FileMode.Open, FileAccess.Read, FileShare.Read)
                Using targetStream As FileStream = File.Open(targetFile, FileMode.Create, FileAccess.Write, FileShare.None)
                    Dim buffer As Byte() = New Byte(4096) {}
                    Dim bytesRead As Integer
                    Do
                        bytesRead = sourceStream.Read(buffer, 0, buffer.Length)
                        If bytesRead > 0 Then
                            targetStream.Write(buffer, 0, bytesRead)
                        End If
                    Loop While bytesRead > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Sub GetFiles(path As String)
        'Get all profiles in the profile directory and list profiles in combobox for default profiles
        If path.Trim().Length = 0 Then
            Return
        End If

        profileList = Directory.GetFileSystemEntries(path)

        Try
            For Each profile As String In profileList
                If Directory.Exists(profile) Then
                    GetFiles(profile)
                Else
                    profile = profile.Replace(profileDirectory, "")
                    profile = profile.Replace(".txt", "")
                    cbxDefaultProfile.Items.Add(profile)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message)
        End Try
    End Sub
End Class
