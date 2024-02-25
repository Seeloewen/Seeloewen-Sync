Imports System.IO

Public Class frmCompareFolders

    'Directories from main window
    Dim directory1 As String = frmMain.tbFolder1.Text
    Dim directory2 As String = frmMain.tbFolder2.Text

    'Sync direction when toggled in the current window, overwrites the main one
    Dim syncDirectionOverwrite As String

    ' -- Event handlers --

    Private Sub frmCompareFolders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display name of folders
        lblSubHeader1.Text = frmMain.tbFolder1.Text
        lblSubHeader2.Text = frmMain.tbFolder2.Text

        'Sets up the window based on the sync direction in frmMain
        syncDirectionOverwrite = frmMain.folderSyncDirection
        SetSyncDirection(frmMain.folderSyncDirection)
        AddContentToLv1(frmMain.folderSyncDirection)
        AddContentToLv2(frmMain.folderSyncDirection)
    End Sub

    Private Sub btnToggleSyncDirection_Click(sender As Object, e As EventArgs) Handles btnToggleSyncDirection.Click
        'Sets up the window based on the overwritten sync direction
        If syncDirectionOverwrite = "Down" Then
            syncDirectionOverwrite = "Up"
        ElseIf syncDirectionOverwrite = "Up" Then
            syncDirectionOverwrite = "Down"
        End If

        SetSyncDirection(syncDirectionOverwrite)
        AddContentToLv1(syncDirectionOverwrite)
        AddContentToLv2(syncDirectionOverwrite)
    End Sub

    '-- Custom methods --

    Private Sub SetSyncDirection(syncDirection)
        'Based on sync direction, change the controls and swap Folder 1 and 2
        If syncDirection = "Down" Then
            pbSyncDirection.BackgroundImage = My.Resources.SyncRight
        ElseIf syncDirection = "Up" Then
            pbSyncDirection.BackgroundImage = My.Resources.SyncLeft
        End If
    End Sub

    Private Sub AddContentToLv1(syncDirection As String)
        Try
            'Clear existing entries
            lv1.Items.Clear()

            'Get all files
            Dim files As String() = Directory.GetFiles(directory1)

            'Go through each file
            For Each element As String In files

                Dim str(2) As String
                Dim filename As String = Path.GetFileName(element)
                str(0) = filename
                str(1) = "File"

                'Sets the filesize and calculates the unit (Greatest unit: Petabyte, I hope noone has a file bigger than 999 PB lying around...)
                Dim filesize As Long = FileLen(element)
                Dim unit As String
                If filesize > 1000 Then
                    filesize = filesize / 1000
                    unit = "KB"
                    If filesize > 1000 Then
                        filesize = filesize / 1000
                        unit = "MB"
                        If filesize > 1000 Then
                            filesize = filesize / 1000
                            unit = "GB"
                            If filesize > 1000 Then
                                filesize = filesize / 1000
                                unit = "TB"
                                If filesize > 1000 Then
                                    filesize = filesize / 1000
                                    unit = "PB"
                                End If
                            End If
                        End If
                    End If
                Else
                    unit = "B"
                End If
                str(2) = filesize.ToString + " " + unit

                'Determine what would happen to the file if it was synced based on the sync direction
                Dim itm As New ListViewItem(str)
                If syncDirection = "Up" Then
                    If My.Computer.FileSystem.FileExists(directory2 + "\" + filename) Then

                        'Declare variables to hold the file paths
                        Dim file1 As String = directory1 + "\" + filename
                        Dim file2 As String = directory2 + "\" + filename

                        'Read the contents of each file
                        Dim contents1 As String = File.ReadAllText(file1)
                        Dim contents2 As String = File.ReadAllText(file2)

                        'Compare the contents of the two files
                        If contents1 = contents2 Then
                            itm.Tag = "unchanged"
                        Else
                            itm.Tag = "modified"
                        End If
                    Else
                        itm.Tag = "deleted"
                    End If
                ElseIf syncDirection = "Down" Then
                    If My.Computer.FileSystem.FileExists(directory2 + "\" + filename) = False Then
                        itm.Tag = "new"
                    End If
                End If

                If itm.Tag = "new" Then
                    itm.ForeColor = Color.Green
                ElseIf itm.Tag = "unchanged" Then
                    itm.ForeColor = Color.Black
                ElseIf itm.Tag = "modified" Then
                    itm.ForeColor = Color.Blue
                ElseIf itm.Tag = "deleted" Then
                    itm.ForeColor = Color.Red
                End If
                lv1.Items.Add(itm)

            Next

            'Add all folders
            Dim folders As String() = Directory.GetDirectories(directory1)
            For Each element As String In folders
                Dim str(1) As String
                Dim foldername As String = Path.GetFullPath(element).Replace(Path.GetDirectoryName(element) + "\", "")

                str(0) = foldername
                str(1) = "Folder"

                'Determine what would happen to the folder if it was synced based on the sync direction
                Dim itm As New ListViewItem(str)
                If syncDirection = "Up" Then
                    If My.Computer.FileSystem.DirectoryExists(directory2 + "\" + foldername) Then
                        Dim files1 As String() = Directory.GetFiles(directory1 + "\" + foldername)
                        Dim files2 As String() = Directory.GetFiles(directory2 + "\" + foldername)

                        'Compare the lists of files
                        If files1.Length = files2.Length Then
                            If files1.Length > 0 Then
                                For i As Integer = 0 To files1.Length - 1
                                    'Read the contents of each file
                                    Dim contents1 As String = File.ReadAllText(files1(i))
                                    Dim contents2 As String = File.ReadAllText(files2(i))

                                    'Compare the contents of the two files
                                    If contents1 = contents2 Then
                                        itm.Tag = "unchanged"
                                    Else
                                        itm.Tag = "modified"
                                    End If
                                Next
                            Else
                                itm.Tag = "unchanged"
                            End If
                        Else
                            itm.Tag = "modified"
                        End If
                    Else
                        itm.Tag = "deleted"
                    End If
                ElseIf syncDirection = "Down" Then
                    If My.Computer.FileSystem.DirectoryExists(directory2 + "\" + foldername) = False Then
                        itm.Tag = "new"
                    End If
                End If

                'Set colors of the folder content
                If itm.Tag = "new" Then
                    itm.ForeColor = Color.Green
                ElseIf itm.Tag = "unchanged" Then
                    itm.ForeColor = Color.Black
                ElseIf itm.Tag = "modified" Then
                    itm.ForeColor = Color.Blue
                ElseIf itm.Tag = "deleted" Then
                    itm.ForeColor = Color.Red
                End If
                lv1.Items.Add(itm)
            Next
        Catch ex As Exception
            MsgBox(String.Format("Could not add content to listView1. {0}", ex.Message), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AddContentToLv2(syncDirection As String)
        Try
            'Clear existing entries
            lv2.Items.Clear()

            'Add all files
            Dim files As String() = Directory.GetFiles(directory2)
            For Each element As String In files
                Dim str(2) As String
                Dim filename As String = Path.GetFileName(element)

                str(0) = filename
                str(1) = "File"

                'Sets the filesize and calculates the unit (Greatest unit: Petabyte. Again: I hope noone has a file bigger than 999 PB lying around...)
                Dim filesize As Long = FileLen(element)
                Dim unit As String
                If filesize > 1000 Then
                    filesize = filesize / 1000
                    unit = "KB"
                    If filesize > 1000 Then
                        filesize = filesize / 1000
                        unit = "MB"
                        If filesize > 1000 Then
                            filesize = filesize / 1000
                            unit = "GB"
                            If filesize > 1000 Then
                                filesize = filesize / 1000
                                unit = "TB"
                                If filesize > 1000 Then
                                    filesize = filesize / 1000
                                    unit = "PB"
                                End If
                            End If
                        End If
                    End If
                Else
                    unit = "B"
                End If
                str(2) = filesize.ToString + " " + unit

                Dim itm As New ListViewItem(str)
                'Determine what would happen to the file if it was synced based on the sync direction
                If syncDirection = "Down" Then
                    If My.Computer.FileSystem.FileExists(directory1 + "\" + filename) Then

                        'Declare variables to hold the file paths
                        Dim file1 As String = directory1 + "\" + filename
                        Dim file2 As String = directory2 + "\" + filename

                        'Read the contents of each file
                        Dim contents1 As String = File.ReadAllText(file1)
                        Dim contents2 As String = File.ReadAllText(file2)

                        'Compare the contents of the two files
                        If contents1 = contents2 Then
                            itm.Tag = "unchanged"
                        Else
                            itm.Tag = "modified"
                        End If
                    Else
                        itm.Tag = "deleted"
                    End If
                ElseIf syncDirection = "Up" Then
                    If My.Computer.FileSystem.FileExists(directory1 + "\" + filename) = False Then
                        itm.Tag = "new"
                    End If
                End If

                If itm.Tag = "new" Then
                    itm.ForeColor = Color.Green
                ElseIf itm.Tag = "unchanged" Then
                    itm.ForeColor = Color.Black
                ElseIf itm.Tag = "modified" Then
                    itm.ForeColor = Color.Blue
                ElseIf itm.Tag = "deleted" Then
                    itm.ForeColor = Color.Red
                End If

                lv2.Items.Add(itm)
            Next

            'Add all folders
            Dim folders As String() = Directory.GetDirectories(directory2)
            For Each element As String In folders
                Dim str(1) As String
                Dim foldername As String = Path.GetFullPath(element).Replace(Path.GetDirectoryName(element) + "\", "")

                str(0) = foldername
                str(1) = "Folder"

                Dim itm As New ListViewItem(str)

                'Determine what would happen to the folder if it was synced based on the sync direction
                If syncDirection = "Down" Then
                    If My.Computer.FileSystem.DirectoryExists(directory1 + "\" + foldername) Then
                        Dim files1 As String() = Directory.GetFiles(directory1 + "\" + foldername)
                        Dim files2 As String() = Directory.GetFiles(directory2 + "\" + foldername)

                        'Compare the lists of files
                        If files1.Length = files2.Length Then
                            If files1.Length > 0 Then
                                For i As Integer = 0 To files1.Length - 1
                                    'Read the contents of each file
                                    Dim contents1 As String = File.ReadAllText(files1(i))
                                    Dim contents2 As String = File.ReadAllText(files2(i))

                                    'Compare the contents of the two files
                                    If contents1 = contents2 Then
                                        itm.Tag = "unchanged"
                                    Else
                                        itm.Tag = "modified"
                                    End If
                                Next
                            Else
                                itm.Tag = "unchanged"
                            End If
                        Else
                            itm.Tag = "modified"
                        End If
                    Else
                        itm.Tag = "deleted"
                    End If
                ElseIf syncDirection = "Up" Then
                    If My.Computer.FileSystem.DirectoryExists(directory1 + "\" + foldername) = False Then
                        itm.Tag = "new"
                    End If
                End If

                'Set colors of the folder content
                If itm.Tag = "new" Then
                    itm.ForeColor = Color.Green
                ElseIf itm.Tag = "unchanged" Then
                    itm.ForeColor = Color.Black
                ElseIf itm.Tag = "modified" Then
                    itm.ForeColor = Color.Blue
                ElseIf itm.Tag = "deleted" Then
                    itm.ForeColor = Color.Red
                End If
                lv2.Items.Add(itm)
            Next
        Catch ex As Exception
            MsgBox(String.Format("Could not add content to listView2. {0}", ex.Message), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class