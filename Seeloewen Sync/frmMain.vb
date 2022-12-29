Imports System.Environment
Imports System.IO

Public Class frmMain

    Public AppData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Dim ProfileDirectory As String = AppData + "\SealSync\Profiles"
    Dim ProfileList As String()
    Public SyncDirection As String = "Down"

    Private Sub btnBrowseFolder1_Click(sender As Object, e As EventArgs) Handles btnBrowseFolder1.Click
        fbdFolder1.ShowDialog()
        tbFolder1.Text = fbdFolder1.SelectedPath
    End Sub

    Private Sub btnBrowseFolder2_Click(sender As Object, e As EventArgs) Handles btnBrowseFolder2.Click
        fbdFolder2.ShowDialog()
        tbFolder2.Text = fbdFolder2.SelectedPath
    End Sub

    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSync.Click
        If String.IsNullOrEmpty(tbFolder1.Text & tbFolder2.Text) Then
            MsgBox("Error: Folder 1 and Folder 2 cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbFolder2.Text) Then
            MsgBox("Error: Folder 1 cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbFolder1.Text) Then
            MsgBox("Error: Folder 2 cannot be empty.", MsgBoxStyle.Critical, "Error")
        Else
            Try
                If SyncDirection = "Down" Then
                    Sync(tbFolder1.Text, tbFolder2.Text)
                ElseIf SyncDirection = "Up" Then
                    Sync(tbFolder2.Text, tbFolder1.Text)
                End If
            Catch execptionSync As Exception
                MsgBox(execptionSync.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub Sync(SourceFolder As String, TargetFolder As String)
        System.IO.Directory.Delete(TargetFolder, True)
        My.Computer.FileSystem.CreateDirectory(TargetFolder)
        My.Computer.FileSystem.CopyDirectory(SourceFolder, TargetFolder)
        MsgBox("Sync completed successfully!", MsgBoxStyle.Information, "Success")
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

    Private Sub btnChangeSyncDirection_Click(sender As Object, e As EventArgs) Handles btnChangeSyncDirection.Click
        If SyncDirection = "Down" Then
            SyncDirection = "Up"
            btnChangeSyncDirection.BackgroundImage = My.Resources.btnSyncUp
        ElseIf SyncDirection = "Up" Then
            SyncDirection = "Down"
            btnChangeSyncDirection.BackgroundImage = My.Resources.btnSyncDown
        End If
    End Sub

    Private Sub btnCompareFolders_Click(sender As Object, e As EventArgs) Handles btnCompareFolders.Click
        frmCompareFolders.Show()
    End Sub
End Class
