Imports System.Environment
Imports System.IO

Public Class frmSettings

    Public AppData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Dim ProfileDirectory As String = AppData + "\SealSync\Profiles"
    Dim ProfileList As String()

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Select Case MessageBox.Show("Are you sure you want to close without saving?", "Close without saving", MessageBoxButtons.YesNo)
            Case Windows.Forms.DialogResult.Yes
                Close()
        End Select
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.LoadProfileByDefault Then
            cbLoadProfileByDefault.Checked = True
        ElseIf My.Settings.LoadProfileByDefault = False Then
            cbLoadProfileByDefault.Checked = False
        End If
        cbxDefaultProfile.Items.Clear()
        GetFiles(ProfileDirectory)
        cbxDefaultProfile.SelectedItem = My.Settings.DefaultProfile
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

    Private Sub btnOpenProfileEditor_Click(sender As Object, e As EventArgs) Handles btnOpenProfileEditor.Click
        frmProfileEditor.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cbLoadProfileByDefault.Checked Then
            My.Settings.LoadProfileByDefault = True
        ElseIf cbLoadProfileByDefault.Checked = False Then
            My.Settings.LoadProfileByDefault = False
        End If
        My.Settings.DefaultProfile = cbxDefaultProfile.SelectedItem
        Close()
        MsgBox("Settings were successfully saved!", MsgBoxStyle.Information, "Saved settings")
    End Sub
End Class