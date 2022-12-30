Imports System.IO

Public Class frmCompareFolders

    Dim Directory1 As String
    Dim Directory2 As String

    Private Sub frmCompareFolders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmMain.SyncDirection = "Down" Then
            Directory1 = frmMain.tbFolder1.Text
            Directory2 = frmMain.tbFolder2.Text
            lblSubHeader1.Text = "Folder 1"
            lblSubHeader2.Text = "Folder 2"
            PictureBox1.BackgroundImage = My.Resources.SyncRight
        ElseIf frmMain.SyncDirection = "Up" Then
            Directory1 = frmMain.tbFolder2.Text
            Directory2 = frmMain.tbFolder1.Text
            lblSubHeader1.Text = "Folder 2"
            lblSubHeader2.Text = "Folder 1"
            PictureBox1.BackgroundImage = My.Resources.SyncLeft
        End If

        AddContentToLv1()
        AddContentToLv2()
    End Sub

    Private Sub AddContentToLv1()
        'Add all files
        Dim files As String() = Directory.GetFiles(Directory1)
        For Each element As String In files
            Dim str(2) As String
            Dim filename As String = Path.GetFileName(element)

            str(0) = filename
            str(1) = "File"

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

            If frmMain.SyncDirection = "Up" Then
                If My.Computer.FileSystem.FileExists(Directory2 + "\" + filename) Then

                    ' Declare variables to hold the file paths
                    Dim file1 As String = Directory1 + "\" + filename
                    Dim file2 As String = Directory2 + "\" + filename

                    ' Read the contents of each file into memory
                    Dim contents1 As String = File.ReadAllText(file1)
                    Dim contents2 As String = File.ReadAllText(file2)

                    ' Compare the contents of the two files
                    If contents1 = contents2 Then
                        itm.Tag = "unchanged"
                    Else
                        itm.Tag = "modified"
                    End If
                Else
                    itm.Tag = "deleted"
                End If
            ElseIf frmMain.SyncDirection = "Down" Then
                If My.Computer.FileSystem.FileExists(Directory2 + "\" + filename) = False Then
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

            ListView1.Items.Add(itm)
        Next

        'Add all folders
        Dim folders As String() = Directory.GetDirectories(Directory1)
        For Each element As String In folders
            Dim str(1) As String
            Dim foldername As String = Path.GetFullPath(element).Replace(Path.GetDirectoryName(element) + "\", "")

            str(0) = foldername
            str(1) = "Folder"

            Dim itm As New ListViewItem(str)
            If frmMain.SyncDirection = "Up" Then
                If My.Computer.FileSystem.DirectoryExists(Directory2 + "\" + foldername) Then
                    Dim files1 As String() = Directory.GetFiles(Directory1 + "\" + foldername)
                    Dim files2 As String() = Directory.GetFiles(Directory2 + "\" + foldername)

                    ' Compare the lists of files
                    If files1.Length = files2.Length Then
                        ' The folders have the same number of files
                        If files1.Length > 0 Then
                            For i As Integer = 0 To files1.Length - 1
                                ' Read the contents of each file into memory
                                Dim contents1 As String = File.ReadAllText(files1(i))
                                Dim contents2 As String = File.ReadAllText(files2(i))

                                ' Compare the contents of the two files
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
            ElseIf frmMain.SyncDirection = "Down" Then
                If My.Computer.FileSystem.DirectoryExists(Directory2 + "\" + foldername) = False Then
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

            ListView1.Items.Add(itm)
        Next
    End Sub

    Private Sub AddContentToLv2()
        'Add all files
        Dim files As String() = Directory.GetFiles(Directory2)
        For Each element As String In files
            Dim str(2) As String
            Dim filename As String = Path.GetFileName(element)

            str(0) = filename
            str(1) = "File"

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

            If frmMain.SyncDirection = "Down" Then
                If My.Computer.FileSystem.FileExists(Directory1 + "\" + filename) Then

                    ' Declare variables to hold the file paths
                    Dim file1 As String = Directory1 + "\" + filename
                    Dim file2 As String = Directory2 + "\" + filename

                    ' Read the contents of each file into memory
                    Dim contents1 As String = File.ReadAllText(file1)
                    Dim contents2 As String = File.ReadAllText(file2)

                    ' Compare the contents of the two files
                    If contents1 = contents2 Then
                        itm.Tag = "unchanged"
                    Else
                        itm.Tag = "modified"
                    End If
                Else
                    itm.Tag = "deleted"
                End If
            ElseIf frmMain.SyncDirection = "Up" Then
                If My.Computer.FileSystem.FileExists(Directory1 + "\" + filename) = False Then
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

            ListView2.Items.Add(itm)
        Next

        'Add all folders
        Dim folders As String() = Directory.GetDirectories(Directory2)
        For Each element As String In folders
            Dim str(1) As String
            Dim foldername As String = Path.GetFullPath(element).Replace(Path.GetDirectoryName(element) + "\", "")

            str(0) = foldername
            str(1) = "Folder"

            Dim itm As New ListViewItem(str)

            ' Get the list of files in each folder
            If frmMain.SyncDirection = "Down" Then
                If My.Computer.FileSystem.DirectoryExists(Directory1 + "\" + foldername) Then
                    Dim files1 As String() = Directory.GetFiles(Directory1 + "\" + foldername)
                    Dim files2 As String() = Directory.GetFiles(Directory2 + "\" + foldername)

                    ' Compare the lists of files
                    If files1.Length = files2.Length Then
                        ' The folders have the same number of files
                        If files1.Length > 0 Then
                            For i As Integer = 0 To files1.Length - 1
                                ' Read the contents of each file into memory
                                Dim contents1 As String = File.ReadAllText(files1(i))
                                Dim contents2 As String = File.ReadAllText(files2(i))

                                ' Compare the contents of the two files
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
            ElseIf frmMain.SyncDirection = "Up" Then
                If My.Computer.FileSystem.DirectoryExists(Directory1 + "\" + foldername) = False Then
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

            ListView2.Items.Add(itm)
        Next
    End Sub
End Class