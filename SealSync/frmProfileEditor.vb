Imports System.IO

Public Class frmProfileEditor

    Dim ProfileDirectory As String = frmMain.AppData + "\SealSync\Profiles"
    Dim ProfileList As String()
    Dim LoadFromProfile As String
    Dim SourceFolder As String
    Dim TargetFolder As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrEmpty(cbxProfile.SelectedItem) = False Then
            My.Computer.FileSystem.DirectoryExists(frmMain.AppData + "\SealSync\Profiles")
            My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\SealSync\Profiles\" + cbxProfile.SelectedItem + ".txt", tbSourceFolder.Text + vbNewLine + tbTargetFolder.Text, False)
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
        LoadProfile(cbxProfile.SelectedItem)
    End Sub

    Private Sub frmProfileEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxProfile.Items.Clear()
        tbSourceFolder.Clear()
        tbTargetFolder.Clear()
        GetFiles(ProfileDirectory)
    End Sub

    Private Sub LoadProfile(Profile)
        If String.IsNullOrEmpty(Profile) = False Then
            LoadFromProfile = frmMain.AppData + "\SealSync\Profiles\" + Profile + ".txt"
            settings.Text = My.Computer.FileSystem.ReadAllText(LoadFromProfile)

            tbSourceFolder.Text = settings.Lines(0)
            tbTargetFolder.Text = settings.Lines(1)
        Else
            MsgBox("Error: Unknown error when loading profile.", MsgBoxStyle.Exclamation, "Error")
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
End Class