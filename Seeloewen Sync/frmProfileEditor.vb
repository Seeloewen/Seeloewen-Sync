Imports System.IO

Public Class frmProfileEditor

    Dim profileList As String()
    Dim profileContent As String()
    Dim loadFromProfile As String
    Dim syncDirection As String
    Dim syncType As String

    '-- Event handlers --

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'Set SyncType depending on radiobutton selection
            If rbtnFolder.Checked = True Then
                syncType = "Folder"
            ElseIf rbtnFile.Checked = True Then
                syncType = "File"
            End If

            'Write the settings to the profile file
            If String.IsNullOrEmpty(cbxProfile.SelectedItem) = False Then
                My.Computer.FileSystem.DirectoryExists(frmMain.profileDirectory)
                My.Computer.FileSystem.WriteAllText(frmMain.profileDirectory + cbxProfile.SelectedItem + ".txt", tbElement1.Text + vbNewLine + tbElement2.Text + vbNewLine + syncDirection + vbNewLine + syncType, False)
                MsgBox("Profile was overwritten and saved.", MsgBoxStyle.Information, "Overwritten and saved")
            Else
                MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox(String.Format("Could not save the profile. {0}", ex.Message), MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close the window
        Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Delete profile file and remove entry in combobox
        If String.IsNullOrEmpty(cbxProfile.SelectedItem) = False Then
            My.Computer.FileSystem.DeleteFile(frmMain.profileDirectory + cbxProfile.SelectedItem + ".txt")
            MsgBox("Profile was deleted.", MsgBoxStyle.Information, "Deleted")
            cbxProfile.Items.Remove(cbxProfile.SelectedItem)
        Else
            MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub cbxProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProfile.SelectedIndexChanged
        'Load profile when selected index changes
        Try
            InitializeLoadingProfile(cbxProfile.SelectedItem, False)
        Catch ex As Exception
            MsgBox(String.Format("Could not load profile. {0}", ex.Message), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmProfileEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Reset controls and variables to default state
        cbxProfile.Items.Clear()
        tbElement1.Clear()
        tbElement2.Clear()
        syncDirection = "Down"
        syncType = "Folder"
        btnChangeSyncDirection.BackgroundImage = My.Resources.btnSyncDown
        rbtnFolder.Checked = True
        lblElement1.Text = "Folder 1:"
        lblElement2.Text = "Folder 2:"

        'Load profiles
        GetFiles(frmMain.profileDirectory)
    End Sub

    Private Sub btnBrowseElement1_Click(sender As Object, e As EventArgs) Handles btnBrowseElement1.Click
        'Open either file browser 1 of folder browser 1
        If rbtnFile.Checked = True Then
            ofdFile1.ShowDialog()
            tbElement1.Text = ofdFile1.FileName
        ElseIf rbtnFolder.Checked = True Then
            fbdFolder1.ShowDialog()
            tbElement1.Text = fbdFolder1.SelectedPath
        End If
    End Sub

    Private Sub btnBrowseElement2_Click(sender As Object, e As EventArgs) Handles btnBrowseElement2.Click
        'Open either file browser 2 of folder browser 2
        If rbtnFile.Checked = True Then
            ofdFile2.ShowDialog()
            tbElement2.Text = ofdFile2.FileName
        ElseIf rbtnFolder.Checked = True Then
            fbdFolder2.ShowDialog()
            tbElement2.Text = fbdFolder2.SelectedPath
        End If
    End Sub

    Private Sub btnChangeSyncDirection_Click(sender As Object, e As EventArgs) Handles btnChangeSyncDirection.Click
        'Change sync direction variable and image on button
        If syncDirection = "Down" Then
            syncDirection = "Up"
            btnChangeSyncDirection.BackgroundImage = My.Resources.btnSyncUp
        ElseIf syncDirection = "Up" Then
            syncDirection = "Down"
            btnChangeSyncDirection.BackgroundImage = My.Resources.btnSyncDown
        End If
    End Sub

    '-- Custom methods --

    Public Sub InitializeLoadingProfile(Profile As String, ShowMessage As Boolean)
        'Checks if a profile is selected. It then reads the content of the profile file into the array. To avoid errors with the array being too small, it gets resized. The number represents the amount of settings.
        'It then starts to convert and load the profile, see the the method below.
        If String.IsNullOrEmpty(Profile) = False Then
            loadFromProfile = frmMain.profileDirectory + Profile + ".txt"
            profileContent = File.ReadAllLines(loadFromProfile)
            'Set new size of array = number of settings
            ReDim Preserve profileContent(4)
            CheckAndConvertProfile(Profile, ShowMessage)
        Else
            MsgBox("Error: No profile selected. Please select a profile to load from.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Public Sub LoadProfile(Profile As String, ShowMessage As Boolean)
        'Load the settings from the array
        'Version 0.3.0
        tbElement1.Text = profileContent(0)
        tbElement2.Text = profileContent(1)
        'Version 0.4.0
        syncDirection = profileContent(2)
        If syncDirection = "Down" Then
            btnChangeSyncDirection.BackgroundImage = My.Resources.btnSyncDown
        ElseIf syncDirection = "Up" Then
            btnChangeSyncDirection.BackgroundImage = My.Resources.btnSyncUp
        End If
        syncType = profileContent(3)
        If syncType = "Folder" Then
            rbtnFolder.Checked = True
        ElseIf syncType = "File" Then
            rbtnFile.Checked = True
        End If

        If ShowMessage Then
            MsgBox("Loaded profile " + Profile + ".", MsgBoxStyle.Information, "Loaded profile")
        End If
    End Sub

    Public Sub CheckAndConvertProfile(Profile As String, ShowMessage As Boolean)
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
                        rbtnFolder.Checked = True
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

        profileList = Directory.GetFileSystemEntries(Path)

        Try
            For Each Profile As String In profileList
                If Directory.Exists(Profile) Then
                    GetFiles(Profile)
                Else
                    Profile = Profile.Replace(frmMain.profileDirectory, "")
                    Profile = Profile.Replace(".txt", "")
                    cbxProfile.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message)
        End Try
    End Sub

    Private Sub rbtnFile_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFile.CheckedChanged
        If rbtnFile.Checked = True Then
            lblElement1.Text = "File 1:"
            lblElement2.Text = "File 2:"
        ElseIf rbtnFolder.Checked = True Then
            lblElement1.Text = "Folder 1:"
            lblElement2.Text = "Folder 2:"
        End If
    End Sub
End Class