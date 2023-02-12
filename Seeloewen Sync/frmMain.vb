Imports System.Environment
Imports System.IO

Public Class frmMain

    Public appData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Dim profileDirectory As String = AppData + "\SealSync\Profiles"
    Dim profileList As String()
    Public folderSyncDirection As String = "Down"
    Public fileSyncDirection As String = "Down"


    Private Sub btnBrowseFolder1_Click(sender As Object, e As EventArgs) Handles btnBrowseFolder1.Click
        fbdFolder1.ShowDialog()
        tbFolder1.Text = fbdFolder1.SelectedPath
    End Sub

    Private Sub btnBrowseFolder2_Click(sender As Object, e As EventArgs) Handles btnBrowseFolder2.Click
        fbdFolder2.ShowDialog()
        tbFolder2.Text = fbdFolder2.SelectedPath
    End Sub

    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSyncFolders.Click
        If String.IsNullOrEmpty(tbFolder1.Text & tbFolder2.Text) Then
            MsgBox("Error: Folder 1 and Folder 2 cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbFolder2.Text) Then
            MsgBox("Error: Folder 1 cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbFolder1.Text) Then
            MsgBox("Error: Folder 2 cannot be empty.", MsgBoxStyle.Critical, "Error")
        Else
            Try
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

    Private Sub SyncFolder(sourceFolder As String, targetFolder As String)
        System.IO.Directory.Delete(targetFolder, True)
        My.Computer.FileSystem.CreateDirectory(targetFolder)
        My.Computer.FileSystem.CopyDirectory(sourceFolder, targetFolder)
        MsgBox("Sync completed successfully!", MsgBoxStyle.Information, "Success")
    End Sub

    Private Sub SyncFile(SourceFile As String, targetFile As String)
        File.Delete(targetFile)
        File.Copy(SourceFile, Path.Combine(Path.GetDirectoryName(targetFile), Path.GetFileName(SourceFile)), True)
        MsgBox("Synchronization completed successfully!", MsgBoxStyle.Information, "Success")
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(AppData + "\SealSync\Profiles") = False Then
            My.Computer.FileSystem.CreateDirectory(AppData + "\SealSync\Profiles")
        End If

        GetFiles(ProfileDirectory)

        If My.Settings.LoadProfileByDefault = True Then
            frmSettings.cbLoadProfileByDefault.Checked = True
            If String.IsNullOrEmpty(My.Settings.DefaultProfile) = False Then
                If My.Computer.FileSystem.FileExists(AppData + "\SealSync\Profiles\" + My.Settings.DefaultProfile + ".txt") Then
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

    Sub GetFiles(Path As String)
        If Path.Trim().Length = 0 Then
            Return
        End If

        ProfileList = Directory.GetFileSystemEntries(Path)

        Try
            For Each Profile As String In ProfileList
                If Directory.Exists(Profile) Then
                    GetFiles(Profile)
                Else
                    Profile = Profile.Replace(AppData + "\SealSync\Profiles\", "")
                    Profile = Profile.Replace(".txt", "")
                    cbxDefaultProfile.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message)
        End Try

    End Sub

    Private Sub btnLoadProfile_Click(sender As Object, e As EventArgs) Handles btnLoadProfile.Click
        frmLoadProfileFrom.ShowDialog()
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        frmSaveProfileAs.ShowDialog()
    End Sub

    Private Sub btnChangeSyncDirection_Click(sender As Object, e As EventArgs) Handles btnChangeSyncDirectionFolders.Click
        If folderSyncDirection = "Down" Then
            folderSyncDirection = "Up"
            btnChangeSyncDirectionFolders.BackgroundImage = My.Resources.btnSyncUp
        ElseIf folderSyncDirection = "Up" Then
            folderSyncDirection = "Down"
            btnChangeSyncDirectionFolders.BackgroundImage = My.Resources.btnSyncDown
        End If
    End Sub

    Private Sub btnCompareFolders_Click(sender As Object, e As EventArgs) Handles btnCompareFolders.Click
        If String.IsNullOrEmpty(tbFolder1.Text) Or String.IsNullOrEmpty(tbFolder2.Text) Then
            MsgBox("Please specify a folder 1 and a folder 2", MsgBoxStyle.Critical, "Error")
        Else
            If My.Computer.FileSystem.DirectoryExists(tbFolder1.Text) = False Or My.Computer.FileSystem.DirectoryExists(tbFolder2.Text) = False Then
                frmCompareFolders.Show()
            End If
        End If
    End Sub

    Private Sub btnBrowseFile1_Click(sender As Object, e As EventArgs) Handles btnBrowseFile1.Click
        ofdFile1.ShowDialog()
        tbFile1.Text = ofdFile1.FileName
    End Sub

    Private Sub btnBrowseFile2_Click(sender As Object, e As EventArgs) Handles btnBrowseFile2.Click
        ofdFile2.ShowDialog()
        tbFile2.Text = ofdFile2.FileName
    End Sub

    Private Sub btnChangeSyncDirectionFiles_Click(sender As Object, e As EventArgs) Handles btnChangeSyncDirectionFiles.Click
        If fileSyncDirection = "Down" Then
            fileSyncDirection = "Up"
            btnChangeSyncDirectionFiles.BackgroundImage = My.Resources.btnSyncUp
        ElseIf fileSyncDirection = "Up" Then
            fileSyncDirection = "Down"
            btnChangeSyncDirectionFiles.BackgroundImage = My.Resources.btnSyncDown
        End If
    End Sub

    Private Sub btnSyncFiles_Click(sender As Object, e As EventArgs) Handles btnSyncFiles.Click
        If String.IsNullOrEmpty(tbFile1.Text & tbFile2.Text) Then
            MsgBox("Error: File 1 and File 2 cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbFile2.Text) Then
            MsgBox("Error: File 1 cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbFile1.Text) Then
            MsgBox("Error: File 2 cannot be empty.", MsgBoxStyle.Critical, "Error")
        Else
            Try
                If fileSyncDirection = "Down" Then
                    SyncFile(tbFile1.Text, tbFile2.Text)
                ElseIf fileSyncDirection = "Up" Then
                    SyncFile(tbFile2.Text, tbFile1.Text)
                End If
            Catch execptionSync As Exception
                MsgBox(execptionSync.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btnCompareFiles_Click(sender As Object, e As EventArgs) Handles btnCompareFiles.Click
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
End Class
