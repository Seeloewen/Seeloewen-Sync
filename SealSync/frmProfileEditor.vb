Imports System.IO

Public Class frmProfileEditor

    Dim ProfileDirectory As String = frmMain.AppData + "\SealSync\Profiles"
    Dim ProfileList As String()
    Dim ProfileContent As String()
    Dim LoadFromProfile As String
    Dim SyncDirection As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(cbxProfile.SelectedItem) = False Then
            My.Computer.FileSystem.DirectoryExists(frmMain.AppData + "\SealSync\Profiles")
            My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\SealSync\Profiles\" + cbxProfile.SelectedItem + ".txt", tbFolder1.Text + vbNewLine + tbFolder2.Text + vbNewLine + SyncDirection, False)
            MsgBox("Profile was overwritten and saved.", MsgBoxStyle.Information, "Overwritten and saved")
        Else
            MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(cbxProfile.SelectedItem) = False Then
            My.Computer.FileSystem.DeleteFile(frmMain.AppData + "\SealSync\Profiles\" + cbxProfile.SelectedItem + ".txt")
            MsgBox("Profile was deleted.", MsgBoxStyle.Information, "Deleted")
            cbxProfile.Items.Remove(cbxProfile.SelectedItem)
        Else
            MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub cbxProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProfile.SelectedIndexChanged
        InitializeLoadingProfile(cbxProfile.SelectedItem, False)
    End Sub

    Private Sub frmProfileEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxProfile.Items.Clear()
        tbFolder1.Clear()
        tbFolder2.Clear()
        SyncDirection = "Down"
        btnChangeSyncDirection.BackgroundImage = My.Resources.btnSyncDown
        GetFiles(ProfileDirectory)
    End Sub

    Public Sub InitializeLoadingProfile(Profile As String, ShowMessage As Boolean)
        If String.IsNullOrEmpty(Profile) = False Then
            LoadFromProfile = frmMain.AppData + "\SealSync\Profiles\" + Profile + ".txt"
            ProfileContent = File.ReadAllLines(LoadFromProfile)
            'Set new size of array
            ReDim Preserve ProfileContent(3)
            CheckAndConvertProfile(Profile, ShowMessage)
        Else
            MsgBox("Error: No profile selected. Please select a profile to load from.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Public Sub LoadProfile(Profile As String, ShowMessage As Boolean)
        'Version 0.3.0
        tbFolder1.Text = ProfileContent(0)
        tbFolder2.Text = ProfileContent(1)
        'Version 0.4.0
        SyncDirection = ProfileContent(2)
        If SyncDirection = "Down" Then
            btnChangeSyncDirection.BackgroundImage = My.Resources.btnSyncDown
        ElseIf frmMain.SyncDirection = "Up" Then
            btnChangeSyncDirection.BackgroundImage = My.Resources.btnSyncUp
        End If

        If ShowMessage Then
            MsgBox("Loaded profile " + Profile + ".", MsgBoxStyle.Information, "Loaded profile")
        End If
    End Sub

    Public Sub CheckAndConvertProfile(Profile As String, ShowMessage As Boolean)
        If (String.IsNullOrEmpty(ProfileContent(0)) OrElse String.IsNullOrEmpty(ProfileContent(1)) OrElse String.IsNullOrEmpty(ProfileContent(2))) Then
            Select Case MsgBox("You are trying to load a profile from an older version or a corrupted profile. You need to update it in order to load it. You usually won't lose any settings. Do you want to continue?", MsgBoxStyle.YesNo, "Load old or corrupted profile")
                Case Windows.Forms.DialogResult.Yes
                    If String.IsNullOrEmpty(ProfileContent(0)) Then
                        ProfileContent(0) = "None"
                    End If
                    If String.IsNullOrEmpty(ProfileContent(1)) Then
                        ProfileContent(1) = "None"
                    End If
                    If String.IsNullOrEmpty(ProfileContent(2)) Then
                        ProfileContent(2) = "Down"
                        frmMain.btnChangeSyncDirection.BackgroundImage = My.Resources.btnSyncUp
                    End If
                    LoadProfile(Profile, False)
                    frmSaveProfileAs.UpdateProfile(Profile)
                    MsgBox("Loaded and updated profile. It should now work correctly!", MsgBoxStyle.Information, "Loaded and updated profile")
                Case Windows.Forms.DialogResult.No
                    MsgBox("Cancelled loading profile.", MsgBoxStyle.Exclamation, "Warning")
            End Select
        Else
            LoadProfile(Profile, ShowMessage)
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
                    Profile = Profile.Replace(frmMain.AppData + "\SealSync\Profiles\", "")
                    Profile = Profile.Replace(".txt", "")
                    cbxProfile.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message)
        End Try
    End Sub

    Private Sub btnBrowseSourceFolder_Click(sender As Object, e As EventArgs) Handles btnFolder1.Click
        fbdFolder1.ShowDialog()
        Dim SourceFolder As String = fbdFolder1.SelectedPath
        tbFolder1.Text = SourceFolder
    End Sub

    Private Sub btnBrowseTargetFolder_Click(sender As Object, e As EventArgs) Handles btnFolder2.Click
        fbdFolder2.ShowDialog()
        Dim TargetFolder As String = fbdFolder2.SelectedPath
        tbFolder2.Text = TargetFolder
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
End Class