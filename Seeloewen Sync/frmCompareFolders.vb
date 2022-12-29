Imports System.IO

Public Class frmCompareFolders

    Dim Directory1 As String = frmMain.tbFolder1.Text
    Dim Directory2 As String = frmMain.tbFolder2.Text

    Private Sub frmCompareFolders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddContentToLv1()
        AddContentToLv2()
    End Sub

    Private Sub AddContentToLv1()
        'Add all files
        Dim files As String() = Directory.GetFiles(Directory1)
        For Each element As String In files
            Dim filename As String = Path.GetFileName(element)

            Dim str(2) As String
            str(0) = filename
            str(1) = "File"

            If My.Computer.FileSystem.FileExists(Directory2 + "\" + filename) = False Then
                str(2) = "New"
            End If

            Dim itm As New ListViewItem(str)
            itm.Tag = element
            ListView1.Items.Add(itm)
        Next

        'Add all folders
        Dim folders As String() = Directory.GetDirectories(Directory1)
        For Each element As String In folders
            Dim foldername As String = Path.GetFullPath(element).Replace(Path.GetDirectoryName(element) + "\", "")

            Dim str(2) As String
            str(0) = foldername
            str(1) = "Folder"

            If My.Computer.FileSystem.DirectoryExists(Directory2 + "\" + foldername) = False Then
                str(2) = "New"
            End If

            Dim itm As New ListViewItem(str)
            itm.Tag = element
            ListView1.Items.Add(itm)
        Next
    End Sub

    Private Sub AddContentToLv2()
        'Add all files
        Dim files As String() = Directory.GetFiles(Directory2)
        For Each element As String In files
            Dim filename As String = Path.GetFileName(element)

            Dim str(2) As String
            str(0) = filename
            str(1) = "File"
            If My.Computer.FileSystem.FileExists(Directory1 + "\" + filename) Then

                ' Declare variables to hold the file paths
                Dim file1 As String = Directory1 + "\" + filename
                Dim file2 As String = Directory2 + "\" + filename

                ' Read the contents of each file into memory
                Dim contents1 As String = File.ReadAllText(file1)
                Dim contents2 As String = File.ReadAllText(file2)

                ' Compare the contents of the two files
                If contents1 = contents2 Then
                    str(2) = ""
                Else
                    str(2) = "Modified"
                End If
            Else
                str(2) = "Deleted"
            End If

            Dim itm As New ListViewItem(str)
            itm.Tag = element
            ListView2.Items.Add(itm)
        Next

        'Add all folders
        Dim folders As String() = Directory.GetDirectories(Directory2)
        For Each element As String In folders
            Dim foldername As String = Path.GetFullPath(element).Replace(Path.GetDirectoryName(element) + "\", "")

            Dim str(2) As String
            str(0) = foldername
            str(1) = "Folder"

            ' Get the list of files in each folder
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
                                str(2) = ""
                            Else
                                str(2) = "Modified"
                            End If
                        Next
                    Else
                        str(2) = ""
                    End If
                Else
                    str(2) = "Modified"
                End If
            Else
                str(2) = "Deleted"
            End If

            Dim itm As New ListViewItem(str)
            itm.Tag = element
            ListView2.Items.Add(itm)
        Next
    End Sub
End Class