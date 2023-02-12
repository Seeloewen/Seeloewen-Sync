Imports System.IO

Public Class frmLoadProfileFrom
    Dim profileList As String()
    Dim profileContent As String()
    Dim loadFromProfile As String
    Dim element1 As String
    Dim element2 As String

    '-- Event handlers --

    Private Sub frmLoadProfileFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get all profiles if direcotry exists
        If My.Computer.FileSystem.DirectoryExists(frmMain.profileDirectory) Then
            cbxProfiles.Items.Clear()
            GetFiles(frmMain.profileDirectory)
        Else
            MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    '-- Custom methods --

    Sub GetFiles(path As String)
        'Get all profile files in the profile directory and list their names in the combobox
        If path.Trim().Length = 0 Then
            Return
        End If

        profileList = Directory.GetFileSystemEntries(path)

        Try
            For Each Profile As String In profileList
                If Directory.Exists(Profile) Then
                    GetFiles(Profile)
                Else
                    Profile = Profile.Replace(frmMain.profileDirectory, "")
                    Profile = Profile.Replace(".txt", "")
                    cbxProfiles.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close window
        Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'Begin loading profiles
        InitializeLoadingProfile(cbxProfiles.SelectedItem, True)
    End Sub

    Public Sub InitializeLoadingProfile(profile As String, showMessage As Boolean)
        'Begin loading profiles, part II
        If String.IsNullOrEmpty(profile) = False Then
            loadFromProfile = frmMain.profileDirectory + profile + ".txt"
            profileContent = File.ReadAllLines(loadFromProfile)
            'Set new size of array
            ReDim Preserve profileContent(4)
            CheckAndConvertProfile(profile, showMessage)
            Close()
        Else
            MsgBox("Error: No profile selected. Please select a profile to load from.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Public Sub LoadProfile(profile As String, showMessage As Boolean)
        'Load content of profile into main window
        If profileContent(3) = "Folder" Then
            'Load file/folder 1 and 2
            frmMain.tbFolder1.Text = profileContent(0)
            frmMain.tbFolder2.Text = profileContent(1)

            'Load sync direction into variable and load it in main window
            frmMain.folderSyncDirection = profileContent(2)
            If frmMain.folderSyncDirection = "Down" Then
                frmMain.btnChangeSyncDirectionFolders.BackgroundImage = My.Resources.btnSyncDown
            ElseIf frmMain.folderSyncDirection = "Up" Then
                frmMain.btnChangeSyncDirectionFolders.BackgroundImage = My.Resources.btnSyncUp
            End If

            'Set selected tab page to "folder"
            frmMain.tcMain.SelectedIndex = 0

        ElseIf profileContent(3) = "File" Then
            'Load file/folder 1 and 2
            frmMain.tbFile1.Text = profileContent(0)
            frmMain.tbFile2.Text = profileContent(1)

            'Load sync direction into variable and load it in main window
            frmMain.fileSyncDirection = profileContent(2)
            If frmMain.fileSyncDirection = "Down" Then
                frmMain.btnChangeSyncDirectionFiles.BackgroundImage = My.Resources.btnSyncDown
            ElseIf frmMain.fileSyncDirection = "Up" Then
                frmMain.btnChangeSyncDirectionFiles.BackgroundImage = My.Resources.btnSyncUp
            End If

            'Set selected tab page to "file"
            frmMain.tcMain.SelectedIndex = 1
        End If

        'Show confirmation message
        If showMessage Then
            MsgBox("Loaded profile " + profile + ".", MsgBoxStyle.Information, "Loaded profile")
        End If
    End Sub

    Public Sub CheckAndConvertProfile(profile As String, showMessage As Boolean)
        'This checks if the profile file that was loaded has enough lines, too few lines would mean that settings are missing, meaning the file is either too old or corrupted.
        'It will check for each required line if it is empty (required lines = the length of a healthy, normal profile file). Make sure that the line amount it checks matches the amount of settings that are being saved.
        'If a line is empty, it will fill that line with a placeholder in the array so the profile can get loaded without errors. After loading the profile, it gets automatically saved so the corrupted/old settings file gets fixed.
        'If no required line is empty and the file is fine, it will just load the profile like normal.
        If (String.IsNullOrEmpty(profileContent(0)) OrElse String.IsNullOrEmpty(profileContent(1)) OrElse String.IsNullOrEmpty(profileContent(2)) OrElse String.IsNullOrEmpty(profileContent(3))) Then
            Select Case MsgBox("You are trying to load a profile from an older version or a corrupted profile. You need to update it in order to load it. You usually won't lose any settings. Do you want to continue?", MsgBoxStyle.YesNo, "Load old or corrupted profile")
                Case Windows.Forms.DialogResult.Yes
                    If String.IsNullOrEmpty(profileContent(0)) Then
                        profileContent(0) = "None"
                    End If
                    If String.IsNullOrEmpty(profileContent(1)) Then
                        profileContent(1) = "None"
                    End If
                    If String.IsNullOrEmpty(profileContent(2)) Then
                        profileContent(2) = "Down"
                        frmMain.btnChangeSyncDirectionFolders.BackgroundImage = My.Resources.btnSyncUp
                    End If
                    If String.IsNullOrEmpty(profileContent(3)) Then
                        profileContent(3) = "Folder"
                        frmMain.tcMain.SelectedIndex = 0
                    End If
                    LoadProfile(profile, False)
                    frmSaveProfileAs.UpdateProfile(profile)
                    MsgBox("Loaded and updated profile. It should now work correctly!", MsgBoxStyle.Information, "Loaded and updated profile")
                Case Windows.Forms.DialogResult.No
                    MsgBox("Cancelled loading profile.", MsgBoxStyle.Exclamation, "Warning")
            End Select
        Else
            LoadProfile(profile, showMessage)
        End If
    End Sub

    'This is just a debugging function, not used in the software. Takes an array as input and returns a string.
    Public Function ReturnArrayAsString(sourceArray As String())
        Dim fullString As String = ""
        For Each line As String In sourceArray
            fullString = fullString + line + vbNewLine
        Next
        fullString = fullString.Remove(fullString.Length - 2)
        Return fullString
    End Function
End Class