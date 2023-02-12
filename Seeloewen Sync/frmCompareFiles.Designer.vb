<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompareFiles
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompareFiles))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblFileNameDesc1 = New System.Windows.Forms.Label()
        Me.rtbFileContent1 = New System.Windows.Forms.RichTextBox()
        Me.lblFileLocationDesc1 = New System.Windows.Forms.Label()
        Me.lblFileSizeDesc1 = New System.Windows.Forms.Label()
        Me.lblFileSizeDesc2 = New System.Windows.Forms.Label()
        Me.lblFileLocationDesc2 = New System.Windows.Forms.Label()
        Me.lblFileNameDesc2 = New System.Windows.Forms.Label()
        Me.lblFileName1 = New System.Windows.Forms.Label()
        Me.lblFileLocation1 = New System.Windows.Forms.Label()
        Me.lblFileSize1 = New System.Windows.Forms.Label()
        Me.lblFileSize2 = New System.Windows.Forms.Label()
        Me.lblFileLocation2 = New System.Windows.Forms.Label()
        Me.lblFileName2 = New System.Windows.Forms.Label()
        Me.pbSyncDirection = New System.Windows.Forms.PictureBox()
        Me.gbFile1 = New System.Windows.Forms.GroupBox()
        Me.gbFile2 = New System.Windows.Forms.GroupBox()
        Me.rtbFileContent2 = New System.Windows.Forms.RichTextBox()
        CType(Me.pbSyncDirection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFile1.SuspendLayout()
        Me.gbFile2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(12, 13)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(147, 25)
        Me.lblHeader.TabIndex = 15
        Me.lblHeader.Text = "File Comparer"
        '
        'lblFileNameDesc1
        '
        Me.lblFileNameDesc1.AutoSize = True
        Me.lblFileNameDesc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileNameDesc1.Location = New System.Drawing.Point(17, 63)
        Me.lblFileNameDesc1.Name = "lblFileNameDesc1"
        Me.lblFileNameDesc1.Size = New System.Drawing.Size(47, 16)
        Me.lblFileNameDesc1.TabIndex = 17
        Me.lblFileNameDesc1.Text = "Name:"
        '
        'rtbFileContent1
        '
        Me.rtbFileContent1.BackColor = System.Drawing.Color.White
        Me.rtbFileContent1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbFileContent1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbFileContent1.Location = New System.Drawing.Point(8, 19)
        Me.rtbFileContent1.Name = "rtbFileContent1"
        Me.rtbFileContent1.ReadOnly = True
        Me.rtbFileContent1.Size = New System.Drawing.Size(320, 284)
        Me.rtbFileContent1.TabIndex = 19
        Me.rtbFileContent1.Text = ""
        '
        'lblFileLocationDesc1
        '
        Me.lblFileLocationDesc1.AutoSize = True
        Me.lblFileLocationDesc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileLocationDesc1.Location = New System.Drawing.Point(17, 79)
        Me.lblFileLocationDesc1.Name = "lblFileLocationDesc1"
        Me.lblFileLocationDesc1.Size = New System.Drawing.Size(61, 16)
        Me.lblFileLocationDesc1.TabIndex = 21
        Me.lblFileLocationDesc1.Text = "Location:"
        '
        'lblFileSizeDesc1
        '
        Me.lblFileSizeDesc1.AutoSize = True
        Me.lblFileSizeDesc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileSizeDesc1.Location = New System.Drawing.Point(17, 95)
        Me.lblFileSizeDesc1.Name = "lblFileSizeDesc1"
        Me.lblFileSizeDesc1.Size = New System.Drawing.Size(36, 16)
        Me.lblFileSizeDesc1.TabIndex = 22
        Me.lblFileSizeDesc1.Text = "Size:"
        '
        'lblFileSizeDesc2
        '
        Me.lblFileSizeDesc2.AutoSize = True
        Me.lblFileSizeDesc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileSizeDesc2.Location = New System.Drawing.Point(445, 95)
        Me.lblFileSizeDesc2.Name = "lblFileSizeDesc2"
        Me.lblFileSizeDesc2.Size = New System.Drawing.Size(36, 16)
        Me.lblFileSizeDesc2.TabIndex = 25
        Me.lblFileSizeDesc2.Text = "Size:"
        '
        'lblFileLocationDesc2
        '
        Me.lblFileLocationDesc2.AutoSize = True
        Me.lblFileLocationDesc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileLocationDesc2.Location = New System.Drawing.Point(445, 79)
        Me.lblFileLocationDesc2.Name = "lblFileLocationDesc2"
        Me.lblFileLocationDesc2.Size = New System.Drawing.Size(61, 16)
        Me.lblFileLocationDesc2.TabIndex = 24
        Me.lblFileLocationDesc2.Text = "Location:"
        '
        'lblFileNameDesc2
        '
        Me.lblFileNameDesc2.AutoSize = True
        Me.lblFileNameDesc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileNameDesc2.Location = New System.Drawing.Point(445, 63)
        Me.lblFileNameDesc2.Name = "lblFileNameDesc2"
        Me.lblFileNameDesc2.Size = New System.Drawing.Size(47, 16)
        Me.lblFileNameDesc2.TabIndex = 23
        Me.lblFileNameDesc2.Text = "Name:"
        '
        'lblFileName1
        '
        Me.lblFileName1.AutoSize = True
        Me.lblFileName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName1.Location = New System.Drawing.Point(84, 63)
        Me.lblFileName1.Name = "lblFileName1"
        Me.lblFileName1.Size = New System.Drawing.Size(82, 16)
        Me.lblFileName1.TabIndex = 26
        Me.lblFileName1.Text = "%filename%"
        '
        'lblFileLocation1
        '
        Me.lblFileLocation1.AutoSize = True
        Me.lblFileLocation1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileLocation1.Location = New System.Drawing.Point(84, 79)
        Me.lblFileLocation1.Name = "lblFileLocation1"
        Me.lblFileLocation1.Size = New System.Drawing.Size(78, 16)
        Me.lblFileLocation1.TabIndex = 27
        Me.lblFileLocation1.Text = "%location%"
        '
        'lblFileSize1
        '
        Me.lblFileSize1.AutoSize = True
        Me.lblFileSize1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileSize1.Location = New System.Drawing.Point(84, 95)
        Me.lblFileSize1.Name = "lblFileSize1"
        Me.lblFileSize1.Size = New System.Drawing.Size(55, 16)
        Me.lblFileSize1.TabIndex = 28
        Me.lblFileSize1.Text = "%size%"
        '
        'lblFileSize2
        '
        Me.lblFileSize2.AutoSize = True
        Me.lblFileSize2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileSize2.Location = New System.Drawing.Point(512, 95)
        Me.lblFileSize2.Name = "lblFileSize2"
        Me.lblFileSize2.Size = New System.Drawing.Size(55, 16)
        Me.lblFileSize2.TabIndex = 31
        Me.lblFileSize2.Text = "%size%"
        '
        'lblFileLocation2
        '
        Me.lblFileLocation2.AutoSize = True
        Me.lblFileLocation2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileLocation2.Location = New System.Drawing.Point(512, 79)
        Me.lblFileLocation2.Name = "lblFileLocation2"
        Me.lblFileLocation2.Size = New System.Drawing.Size(78, 16)
        Me.lblFileLocation2.TabIndex = 30
        Me.lblFileLocation2.Text = "%location%"
        '
        'lblFileName2
        '
        Me.lblFileName2.AutoSize = True
        Me.lblFileName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName2.Location = New System.Drawing.Point(512, 63)
        Me.lblFileName2.Name = "lblFileName2"
        Me.lblFileName2.Size = New System.Drawing.Size(82, 16)
        Me.lblFileName2.TabIndex = 29
        Me.lblFileName2.Text = "%filename%"
        '
        'pbSyncDirection
        '
        Me.pbSyncDirection.BackgroundImage = Global.Seeloewen_Sync.My.Resources.Resources.SyncRight
        Me.pbSyncDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSyncDirection.Location = New System.Drawing.Point(352, 234)
        Me.pbSyncDirection.Name = "pbSyncDirection"
        Me.pbSyncDirection.Size = New System.Drawing.Size(76, 67)
        Me.pbSyncDirection.TabIndex = 32
        Me.pbSyncDirection.TabStop = False
        '
        'gbFile1
        '
        Me.gbFile1.Controls.Add(Me.rtbFileContent1)
        Me.gbFile1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFile1.Location = New System.Drawing.Point(12, 126)
        Me.gbFile1.Name = "gbFile1"
        Me.gbFile1.Size = New System.Drawing.Size(334, 309)
        Me.gbFile1.TabIndex = 33
        Me.gbFile1.TabStop = False
        Me.gbFile1.Text = "File 1"
        '
        'gbFile2
        '
        Me.gbFile2.Controls.Add(Me.rtbFileContent2)
        Me.gbFile2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFile2.Location = New System.Drawing.Point(435, 126)
        Me.gbFile2.Name = "gbFile2"
        Me.gbFile2.Size = New System.Drawing.Size(334, 309)
        Me.gbFile2.TabIndex = 34
        Me.gbFile2.TabStop = False
        Me.gbFile2.Text = "File 1"
        '
        'rtbFileContent2
        '
        Me.rtbFileContent2.BackColor = System.Drawing.Color.White
        Me.rtbFileContent2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbFileContent2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbFileContent2.Location = New System.Drawing.Point(8, 19)
        Me.rtbFileContent2.Name = "rtbFileContent2"
        Me.rtbFileContent2.ReadOnly = True
        Me.rtbFileContent2.Size = New System.Drawing.Size(320, 284)
        Me.rtbFileContent2.TabIndex = 19
        Me.rtbFileContent2.Text = ""
        '
        'frmCompareFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(781, 461)
        Me.Controls.Add(Me.gbFile2)
        Me.Controls.Add(Me.pbSyncDirection)
        Me.Controls.Add(Me.lblFileSize2)
        Me.Controls.Add(Me.lblFileLocation2)
        Me.Controls.Add(Me.lblFileName2)
        Me.Controls.Add(Me.lblFileSize1)
        Me.Controls.Add(Me.lblFileLocation1)
        Me.Controls.Add(Me.lblFileName1)
        Me.Controls.Add(Me.lblFileSizeDesc2)
        Me.Controls.Add(Me.lblFileLocationDesc2)
        Me.Controls.Add(Me.lblFileNameDesc2)
        Me.Controls.Add(Me.lblFileSizeDesc1)
        Me.Controls.Add(Me.lblFileLocationDesc1)
        Me.Controls.Add(Me.lblFileNameDesc1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.gbFile1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompareFiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Comparer"
        CType(Me.pbSyncDirection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFile1.ResumeLayout(False)
        Me.gbFile2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblFileNameDesc1 As Label
    Friend WithEvents rtbFileContent1 As RichTextBox
    Friend WithEvents lblFileLocationDesc1 As Label
    Friend WithEvents lblFileSizeDesc1 As Label
    Friend WithEvents lblFileSizeDesc2 As Label
    Friend WithEvents lblFileLocationDesc2 As Label
    Friend WithEvents lblFileNameDesc2 As Label
    Friend WithEvents lblFileName1 As Label
    Friend WithEvents lblFileLocation1 As Label
    Friend WithEvents lblFileSize1 As Label
    Friend WithEvents lblFileSize2 As Label
    Friend WithEvents lblFileLocation2 As Label
    Friend WithEvents lblFileName2 As Label
    Friend WithEvents pbSyncDirection As PictureBox
    Friend WithEvents gbFile1 As GroupBox
    Friend WithEvents gbFile2 As GroupBox
    Friend WithEvents rtbFileContent2 As RichTextBox
End Class
