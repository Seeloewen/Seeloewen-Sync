<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblFolder1 = New System.Windows.Forms.Label()
        Me.lblFolder2 = New System.Windows.Forms.Label()
        Me.tbFolder1 = New System.Windows.Forms.TextBox()
        Me.tbFolder2 = New System.Windows.Forms.TextBox()
        Me.btnBrowseFolder2 = New System.Windows.Forms.Button()
        Me.btnBrowseFolder1 = New System.Windows.Forms.Button()
        Me.btnSync = New System.Windows.Forms.Button()
        Me.fbdFolder1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbdFolder2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.cbxDefaultProfile = New System.Windows.Forms.ComboBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnSaveProfile = New System.Windows.Forms.Button()
        Me.btnLoadProfile = New System.Windows.Forms.Button()
        Me.btnChangeSyncDirection = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(13, 13)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(111, 25)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "SealSync"
        '
        'lblFolder1
        '
        Me.lblFolder1.AutoSize = True
        Me.lblFolder1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolder1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFolder1.Location = New System.Drawing.Point(15, 54)
        Me.lblFolder1.Name = "lblFolder1"
        Me.lblFolder1.Size = New System.Drawing.Size(59, 16)
        Me.lblFolder1.TabIndex = 1
        Me.lblFolder1.Text = "Folder 1:"
        '
        'lblFolder2
        '
        Me.lblFolder2.AutoSize = True
        Me.lblFolder2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolder2.Location = New System.Drawing.Point(15, 143)
        Me.lblFolder2.Name = "lblFolder2"
        Me.lblFolder2.Size = New System.Drawing.Size(59, 16)
        Me.lblFolder2.TabIndex = 2
        Me.lblFolder2.Text = "Folder 2:"
        '
        'tbFolder1
        '
        Me.tbFolder1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFolder1.Location = New System.Drawing.Point(18, 73)
        Me.tbFolder1.Name = "tbFolder1"
        Me.tbFolder1.Size = New System.Drawing.Size(362, 22)
        Me.tbFolder1.TabIndex = 3
        '
        'tbFolder2
        '
        Me.tbFolder2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFolder2.Location = New System.Drawing.Point(18, 162)
        Me.tbFolder2.Name = "tbFolder2"
        Me.tbFolder2.Size = New System.Drawing.Size(362, 22)
        Me.tbFolder2.TabIndex = 4
        '
        'btnBrowseFolder2
        '
        Me.btnBrowseFolder2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseFolder2.Location = New System.Drawing.Point(386, 162)
        Me.btnBrowseFolder2.Name = "btnBrowseFolder2"
        Me.btnBrowseFolder2.Size = New System.Drawing.Size(97, 23)
        Me.btnBrowseFolder2.TabIndex = 5
        Me.btnBrowseFolder2.Text = "Browse"
        Me.btnBrowseFolder2.UseVisualStyleBackColor = True
        '
        'btnBrowseFolder1
        '
        Me.btnBrowseFolder1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseFolder1.Location = New System.Drawing.Point(386, 73)
        Me.btnBrowseFolder1.Name = "btnBrowseFolder1"
        Me.btnBrowseFolder1.Size = New System.Drawing.Size(97, 23)
        Me.btnBrowseFolder1.TabIndex = 6
        Me.btnBrowseFolder1.Text = "Browse"
        Me.btnBrowseFolder1.UseVisualStyleBackColor = True
        '
        'btnSync
        '
        Me.btnSync.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSync.Location = New System.Drawing.Point(18, 209)
        Me.btnSync.Name = "btnSync"
        Me.btnSync.Size = New System.Drawing.Size(362, 35)
        Me.btnSync.TabIndex = 7
        Me.btnSync.Text = "Sync now"
        Me.btnSync.UseVisualStyleBackColor = True
        '
        'fbdFolder1
        '
        Me.fbdFolder1.Description = "Select folder 1..."
        '
        'fbdFolder2
        '
        Me.fbdFolder2.Description = "Select folder 2..."
        '
        'cbxDefaultProfile
        '
        Me.cbxDefaultProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDefaultProfile.FormattingEnabled = True
        Me.cbxDefaultProfile.Location = New System.Drawing.Point(18, 258)
        Me.cbxDefaultProfile.Name = "cbxDefaultProfile"
        Me.cbxDefaultProfile.Size = New System.Drawing.Size(121, 21)
        Me.cbxDefaultProfile.TabIndex = 10
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(439, 209)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(45, 35)
        Me.btnAbout.TabIndex = 8
        Me.btnAbout.Text = "?"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnSaveProfile
        '
        Me.btnSaveProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveProfile.Location = New System.Drawing.Point(386, 17)
        Me.btnSaveProfile.Name = "btnSaveProfile"
        Me.btnSaveProfile.Size = New System.Drawing.Size(97, 23)
        Me.btnSaveProfile.TabIndex = 11
        Me.btnSaveProfile.Text = "Save profile"
        Me.btnSaveProfile.UseVisualStyleBackColor = True
        '
        'btnLoadProfile
        '
        Me.btnLoadProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadProfile.Location = New System.Drawing.Point(282, 17)
        Me.btnLoadProfile.Name = "btnLoadProfile"
        Me.btnLoadProfile.Size = New System.Drawing.Size(98, 23)
        Me.btnLoadProfile.TabIndex = 12
        Me.btnLoadProfile.Text = "Load profile"
        Me.btnLoadProfile.UseVisualStyleBackColor = True
        '
        'btnChangeSyncDirection
        '
        Me.btnChangeSyncDirection.BackgroundImage = Global.SealSync.My.Resources.Resources.btnSyncDown
        Me.btnChangeSyncDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangeSyncDirection.Location = New System.Drawing.Point(215, 107)
        Me.btnChangeSyncDirection.Name = "btnChangeSyncDirection"
        Me.btnChangeSyncDirection.Size = New System.Drawing.Size(53, 42)
        Me.btnChangeSyncDirection.TabIndex = 13
        Me.btnChangeSyncDirection.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.BackgroundImage = Global.SealSync.My.Resources.Resources.btnSettings
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(388, 209)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(45, 35)
        Me.btnSettings.TabIndex = 9
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(496, 256)
        Me.Controls.Add(Me.btnChangeSyncDirection)
        Me.Controls.Add(Me.btnLoadProfile)
        Me.Controls.Add(Me.btnSaveProfile)
        Me.Controls.Add(Me.cbxDefaultProfile)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnSync)
        Me.Controls.Add(Me.btnBrowseFolder1)
        Me.Controls.Add(Me.btnBrowseFolder2)
        Me.Controls.Add(Me.tbFolder2)
        Me.Controls.Add(Me.tbFolder1)
        Me.Controls.Add(Me.lblFolder2)
        Me.Controls.Add(Me.lblFolder1)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SealSync"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblFolder1 As Label
    Friend WithEvents lblFolder2 As Label
    Friend WithEvents tbFolder1 As TextBox
    Friend WithEvents tbFolder2 As TextBox
    Friend WithEvents btnBrowseFolder2 As Button
    Friend WithEvents btnBrowseFolder1 As Button
    Friend WithEvents btnSync As Button
    Friend WithEvents fbdFolder1 As FolderBrowserDialog
    Friend WithEvents fbdFolder2 As FolderBrowserDialog
    Friend WithEvents btnSettings As Button
    Friend WithEvents cbxDefaultProfile As ComboBox
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnSaveProfile As Button
    Friend WithEvents btnLoadProfile As Button
    Friend WithEvents btnChangeSyncDirection As Button
End Class
