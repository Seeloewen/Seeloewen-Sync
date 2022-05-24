Imports System.Environment
Imports System.IO

Public Class frmMain

    Public AppData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Dim ProfileDirectory As String = AppData + "\SealSync\Profiles"
    Dim ProfileList As String()

    Private Sub btnBrowseSourceFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseSourceFolder.Click
        fbdSourceFolder.ShowDialog()
        Dim SourceFolder As String = fbdSourceFolder.SelectedPath
        tbSourceFolder.Text = SourceFolder
    End Sub

    Private Sub btnBrowseTargetFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseTargetFolder.Click
        fbdTargetFolder.ShowDialog()
        Dim TargetFolder As String = fbdTargetFolder.SelectedPath
        tbTargetFolder.Text = TargetFolder
    End Sub

    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSync.Click
        If String.IsNullOrEmpty(tbSourceFolder.Text & tbTargetFolder.Text) Then
            MsgBox("Error: Source and target folder cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbTargetFolder.Text) Then
            MsgBox("Error: Target folder cannot be empty.", MsgBoxStyle.Critical, "Error")
        ElseIf String.IsNullOrEmpty(tbSourceFolder.Text) Then
            MsgBox("Error: Source folder cannot be empty.", MsgBoxStyle.Critical, "Error")
        Else
            Try
                Sync()
            Catch execptionSync As Exception
                MsgBox(execptionSync.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub Sync()
        System.IO.Directory.Delete(tbTargetFolder.Text, True)
        My.Computer.FileSystem.CreateDirectory(tbTargetFolder.Text)
        My.Computer.FileSystem.CopyDirectory(tbSourceFolder.Text, tbTargetFolder.Text)
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
                    frmLoadProfileFrom.LoadProfile(cbxDefaultProfile.SelectedItem, False)
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
End Class
