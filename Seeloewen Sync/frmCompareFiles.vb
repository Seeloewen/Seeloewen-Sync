Imports System.IO

Public Class frmCompareFiles

    '-- Event handlers --

    Private Sub frmCompareFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display arrow based on sync direction in main window
        If frmMain.fileSyncDirection = "Down" Then
            pbSyncDirection.BackgroundImage = My.Resources.imgSyncRight
        ElseIf frmMain.fileSyncDirection = "Up" Then
            pbSyncDirection.BackgroundImage = My.Resources.imgSyncLeft
        End If

        Try
            'Get file infos
            GetFileInfo1()
            GetFileInfo2()

            'Load file content
            rtbFileContent1.Text = File.ReadAllText(frmMain.tbFile1.Text)
            rtbFileContent2.Text = File.ReadAllText(frmMain.tbFile2.Text)
        Catch ex As Exception
            MsgBox(String.Format("Error while loading files. {0}", ex.Message), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '-- Custom methods --

    Private Sub GetFileInfo1()
        'Get file name
        lblFileName1.Text = Path.GetFileName(frmMain.tbFile1.Text)

        'Get file location
        lblFileLocation1.Text = Path.GetDirectoryName(frmMain.tbFile1.Text)

        'Get file size and calculates the unit (Greatest unit: Petabyte, I hope noone has a file bigger than 999 PB lying around...)
        Dim filesize As Long = FileLen(frmMain.tbFile1.Text)
        Dim unit As String
        If filesize > 1000 Then
            filesize = filesize / 1000
            unit = "Kilobyte(s)"
            If filesize > 1000 Then
                filesize = filesize / 1000
                unit = "Megabyte(s)"
                If filesize > 1000 Then
                    filesize = filesize / 1000
                    unit = "Gigabyte(s)"
                    If filesize > 1000 Then
                        filesize = filesize / 1000
                        unit = "Terabyte(s)"
                        If filesize > 1000 Then
                            filesize = filesize / 1000
                            unit = "Petabyte(s)"
                        End If
                    End If
                End If
            End If
        Else
            unit = "Byte(s)"
        End If

        lblFileSize1.Text = filesize.ToString + " " + unit.ToString
    End Sub

    Private Sub GetFileInfo2()
        'Get file name
        lblFileName2.Text = Path.GetFileName(frmMain.tbFile2.Text)

        'Get file location
        lblFileLocation2.Text = Path.GetDirectoryName(frmMain.tbFile2.Text)

        'Get file size and calculates the unit (Greatest unit: Petabyte, I hope noone has a file bigger than 999 PB lying around...)
        Dim filesize As Long = FileLen(frmMain.tbFile2.Text)
        Dim unit As String
        If filesize > 1000 Then
            filesize = filesize / 1000
            unit = "Kilobyte(s)"
            If filesize > 1000 Then
                filesize = filesize / 1000
                unit = "Megabyte(s)"
                If filesize > 1000 Then
                    filesize = filesize / 1000
                    unit = "Gigabyte(s)"
                    If filesize > 1000 Then
                        filesize = filesize / 1000
                        unit = "Terabyte(s)"
                        If filesize > 1000 Then
                            filesize = filesize / 1000
                            unit = "Petabyte(s)"
                        End If
                    End If
                End If
            End If
        Else
            unit = "Byte(s)"
        End If

        lblFileSize2.Text = filesize.ToString + " " + unit.ToString
    End Sub
End Class