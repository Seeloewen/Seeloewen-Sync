Imports System.IO

Public Class frmLoadProfileFrom

    Dim ProfileDirectory As String = frmMain.AppData + "\SealSync\Profiles"
    Dim ProfileList As String()
    Dim ProfileContent As String()
    Dim LoadFromProfile As String
    Dim Element1 As String
    Dim Element2 As String

    Private Sub frmLoadProfileFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(frmMain.AppData + "\SealSync\Profiles") Then
            cbxProfiles.Items.Clear()
            GetFiles(ProfileDirectory)
        Else
            MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
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
                    cbxProfiles.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        InitializeLoadingProfile(cbxProfiles.SelectedItem, True)
    End Sub

    Public Sub InitializeLoadingProfile(Profile As String, ShowMessage As Boolean)
        If String.IsNullOrEmpty(Profile) = False Then
            LoadFromProfile = frmMain.AppData + "\SealSync\Profiles\" + Profile + ".txt"
            ProfileContent = File.ReadAllLines(LoadFromProfile)
            'Set new size of array
            ReDim Preserve ProfileContent(4)
            CheckAndConvertProfile(Profile, ShowMessage)
            Close()
        Else
            MsgBox("Error: No profile selected. Please select a profile to load from.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Public Sub LoadProfile(Profile As String, ShowMessage As Boolean)
        If ProfileContent(3) = "Folder" Then
            frmMain.tbFolder1.Text = ProfileContent(0)
            frmMain.tbFolder2.Text = ProfileContent(1)

            frmMain.folderSyncDirection = ProfileContent(2)

            If frmMain.folderSyncDirection = "Down" Then
                frmMain.btnChangeSyncDirectionFolders.BackgroundImage = My.Resources.btnSyncDown
            ElseIf frmMain.folderSyncDirection = "Up" Then
                frmMain.btnChangeSyncDirectionFolders.BackgroundImage = My.Resources.btnSyncUp
            End If

            frmMain.tcMain.SelectedIndex = 0

        ElseIf ProfileContent(3) = "File" Then
            frmMain.tbFile1.Text = ProfileContent(0)
            frmMain.tbFile2.Text = ProfileContent(1)

            frmMain.fileSyncDirection = ProfileContent(2)

            If frmMain.fileSyncDirection = "Down" Then
                frmMain.btnChangeSyncDirectionFiles.BackgroundImage = My.Resources.btnSyncDown
            ElseIf frmMain.fileSyncDirection = "Up" Then
                frmMain.btnChangeSyncDirectionFiles.BackgroundImage = My.Resources.btnSyncUp
            End If

            frmMain.tcMain.SelectedIndex = 1
        End If

        If ShowMessage Then
            MsgBox("Loaded profile " + Profile + ".", MsgBoxStyle.Information, "Loaded profile")
        End If
    End Sub

    Public Sub CheckAndConvertProfile(Profile As String, ShowMessage As Boolean)
        If (String.IsNullOrEmpty(ProfileContent(0)) OrElse String.IsNullOrEmpty(ProfileContent(1)) OrElse String.IsNullOrEmpty(ProfileContent(2)) OrElse String.IsNullOrEmpty(ProfileContent(3))) Then
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
                        frmMain.btnChangeSyncDirectionFolders.BackgroundImage = My.Resources.btnSyncUp
                    End If
                    If String.IsNullOrEmpty(ProfileContent(3)) Then
                        ProfileContent(3) = "Folder"
                        frmMain.tcMain.SelectedIndex = 0
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
    Public Function ReturnArrayAsString(SourceArray As String())
        Dim FullString As String = ""
        For Each line As String In SourceArray
            FullString = FullString + line + vbNewLine
        Next
        FullString = FullString.Remove(FullString.Length - 2)
        Return FullString
    End Function
End Class