Imports System.IO

Public Class frmSettings

    Dim profileList As String()

    '-- Event handlers --

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Ask for confirmation before closing
        Select Case MessageBox.Show("Are you sure you want to close without saving?", "Close without saving", MessageBoxButtons.YesNo)
            Case Windows.Forms.DialogResult.Yes
                Close()
        End Select
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load default settings
        If My.Settings.LoadProfileByDefault Then
            cbLoadProfileByDefault.Checked = True
        ElseIf My.Settings.LoadProfileByDefault = False Then
            cbLoadProfileByDefault.Checked = False
        End If

        'Clear existing profiles, load profiles and select default profile in combobox
        cbxDefaultProfile.Items.Clear()
        GetFiles(frmMain.profileDirectory)
        cbxDefaultProfile.SelectedItem = My.Settings.DefaultProfile
    End Sub

    Sub GetFiles(path As String)
        'Get all files in selected folder and put their names into combobox
        If path.Trim().Length = 0 Then
            Return
        End If

        ProfileList = Directory.GetFileSystemEntries(path)

        Try
            For Each Profile As String In ProfileList
                If Directory.Exists(Profile) Then
                    GetFiles(Profile)
                Else
                    Profile = Profile.Replace(frmMain.profileDirectory, "")
                    Profile = Profile.Replace(".txt", "")
                    cbxDefaultProfile.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message)
        End Try

    End Sub

    Private Sub btnOpenProfileEditor_Click(sender As Object, e As EventArgs) Handles btnOpenProfileEditor.Click
        'Open profile editor dialog
        frmProfileEditor.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Save selection for whether to load default profile or not
        If cbLoadProfileByDefault.Checked Then
            My.Settings.LoadProfileByDefault = True
        ElseIf cbLoadProfileByDefault.Checked = False Then
            My.Settings.LoadProfileByDefault = False
        End If

        'Save default profile
        My.Settings.DefaultProfile = cbxDefaultProfile.SelectedItem

        'Show confirmation and close window
        MsgBox("Settings were successfully saved!", MsgBoxStyle.Information, "Saved settings")
        Close()
    End Sub
End Class