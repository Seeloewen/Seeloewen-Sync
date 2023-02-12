<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfileEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfileEditor))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbxProfile = New System.Windows.Forms.ComboBox()
        Me.gbEditProfile = New System.Windows.Forms.GroupBox()
        Me.btnChangeSyncDirection = New System.Windows.Forms.Button()
        Me.btnBrowseElement1 = New System.Windows.Forms.Button()
        Me.btnBrowseElement2 = New System.Windows.Forms.Button()
        Me.tbElement2 = New System.Windows.Forms.TextBox()
        Me.tbElement1 = New System.Windows.Forms.TextBox()
        Me.lblElement2 = New System.Windows.Forms.Label()
        Me.lblElement1 = New System.Windows.Forms.Label()
        Me.fbdFolder1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbdFolder2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.settings = New System.Windows.Forms.RichTextBox()
        Me.rbtnFolder = New System.Windows.Forms.RadioButton()
        Me.rbtnFile = New System.Windows.Forms.RadioButton()
        Me.ofdFile1 = New System.Windows.Forms.OpenFileDialog()
        Me.ofdFile2 = New System.Windows.Forms.OpenFileDialog()
        Me.gbEditProfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(325, 244)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(139, 23)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Choose the profile you want to edit:"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(164, 244)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(155, 23)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete profile"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(11, 244)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(147, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cbxProfile
        '
        Me.cbxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProfile.FormattingEnabled = True
        Me.cbxProfile.Location = New System.Drawing.Point(12, 28)
        Me.cbxProfile.Name = "cbxProfile"
        Me.cbxProfile.Size = New System.Drawing.Size(240, 21)
        Me.cbxProfile.TabIndex = 13
        '
        'gbEditProfile
        '
        Me.gbEditProfile.Controls.Add(Me.btnChangeSyncDirection)
        Me.gbEditProfile.Controls.Add(Me.btnBrowseElement1)
        Me.gbEditProfile.Controls.Add(Me.btnBrowseElement2)
        Me.gbEditProfile.Controls.Add(Me.tbElement2)
        Me.gbEditProfile.Controls.Add(Me.tbElement1)
        Me.gbEditProfile.Controls.Add(Me.lblElement2)
        Me.gbEditProfile.Controls.Add(Me.lblElement1)
        Me.gbEditProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEditProfile.Location = New System.Drawing.Point(11, 55)
        Me.gbEditProfile.Name = "gbEditProfile"
        Me.gbEditProfile.Size = New System.Drawing.Size(453, 181)
        Me.gbEditProfile.TabIndex = 12
        Me.gbEditProfile.TabStop = False
        Me.gbEditProfile.Text = "Edit profile"
        '
        'btnChangeSyncDirection
        '
        Me.btnChangeSyncDirection.BackgroundImage = Global.Seeloewen_Sync.My.Resources.Resources.btnSyncDown
        Me.btnChangeSyncDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangeSyncDirection.Location = New System.Drawing.Point(198, 82)
        Me.btnChangeSyncDirection.Name = "btnChangeSyncDirection"
        Me.btnChangeSyncDirection.Size = New System.Drawing.Size(53, 42)
        Me.btnChangeSyncDirection.TabIndex = 19
        Me.btnChangeSyncDirection.UseVisualStyleBackColor = True
        '
        'btnBrowseElement1
        '
        Me.btnBrowseElement1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseElement1.Location = New System.Drawing.Point(343, 46)
        Me.btnBrowseElement1.Name = "btnBrowseElement1"
        Me.btnBrowseElement1.Size = New System.Drawing.Size(97, 23)
        Me.btnBrowseElement1.TabIndex = 19
        Me.btnBrowseElement1.Text = "Browse"
        Me.btnBrowseElement1.UseVisualStyleBackColor = True
        '
        'btnBrowseElement2
        '
        Me.btnBrowseElement2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseElement2.Location = New System.Drawing.Point(343, 145)
        Me.btnBrowseElement2.Name = "btnBrowseElement2"
        Me.btnBrowseElement2.Size = New System.Drawing.Size(97, 23)
        Me.btnBrowseElement2.TabIndex = 18
        Me.btnBrowseElement2.Text = "Browse"
        Me.btnBrowseElement2.UseVisualStyleBackColor = True
        '
        'tbElement2
        '
        Me.tbElement2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbElement2.Location = New System.Drawing.Point(19, 145)
        Me.tbElement2.Name = "tbElement2"
        Me.tbElement2.Size = New System.Drawing.Size(312, 22)
        Me.tbElement2.TabIndex = 8
        '
        'tbElement1
        '
        Me.tbElement1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbElement1.Location = New System.Drawing.Point(19, 46)
        Me.tbElement1.Name = "tbElement1"
        Me.tbElement1.Size = New System.Drawing.Size(312, 22)
        Me.tbElement1.TabIndex = 7
        '
        'lblElement2
        '
        Me.lblElement2.AutoSize = True
        Me.lblElement2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElement2.Location = New System.Drawing.Point(16, 126)
        Me.lblElement2.Name = "lblElement2"
        Me.lblElement2.Size = New System.Drawing.Size(69, 16)
        Me.lblElement2.TabIndex = 6
        Me.lblElement2.Text = "Element 2:"
        '
        'lblElement1
        '
        Me.lblElement1.AutoSize = True
        Me.lblElement1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElement1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblElement1.Location = New System.Drawing.Point(16, 27)
        Me.lblElement1.Name = "lblElement1"
        Me.lblElement1.Size = New System.Drawing.Size(69, 16)
        Me.lblElement1.TabIndex = 5
        Me.lblElement1.Text = "Element 1:"
        '
        'fbdFolder1
        '
        Me.fbdFolder1.Description = "Select folder 1..."
        Me.fbdFolder1.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'fbdFolder2
        '
        Me.fbdFolder2.Description = "Select folder 2..."
        Me.fbdFolder2.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'settings
        '
        Me.settings.Location = New System.Drawing.Point(30, 295)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(100, 96)
        Me.settings.TabIndex = 18
        Me.settings.Text = ""
        '
        'rbtnFolder
        '
        Me.rbtnFolder.AutoSize = True
        Me.rbtnFolder.Checked = True
        Me.rbtnFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFolder.Location = New System.Drawing.Point(330, 27)
        Me.rbtnFolder.Name = "rbtnFolder"
        Me.rbtnFolder.Size = New System.Drawing.Size(64, 20)
        Me.rbtnFolder.TabIndex = 19
        Me.rbtnFolder.TabStop = True
        Me.rbtnFolder.Text = "Folder"
        Me.rbtnFolder.UseVisualStyleBackColor = True
        '
        'rbtnFile
        '
        Me.rbtnFile.AutoSize = True
        Me.rbtnFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFile.Location = New System.Drawing.Point(400, 27)
        Me.rbtnFile.Name = "rbtnFile"
        Me.rbtnFile.Size = New System.Drawing.Size(47, 20)
        Me.rbtnFile.TabIndex = 20
        Me.rbtnFile.Text = "File"
        Me.rbtnFile.UseVisualStyleBackColor = True
        '
        'ofdFile1
        '
        Me.ofdFile1.FileName = "OpenFileDialog1"
        '
        'ofdFile2
        '
        Me.ofdFile2.FileName = "OpenFileDialog2"
        '
        'frmProfileEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(476, 276)
        Me.Controls.Add(Me.rbtnFile)
        Me.Controls.Add(Me.rbtnFolder)
        Me.Controls.Add(Me.settings)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbxProfile)
        Me.Controls.Add(Me.gbEditProfile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProfileEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile Editor"
        Me.gbEditProfile.ResumeLayout(False)
        Me.gbEditProfile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cbxProfile As ComboBox
    Friend WithEvents gbEditProfile As GroupBox
    Friend WithEvents tbElement2 As TextBox
    Friend WithEvents tbElement1 As TextBox
    Friend WithEvents lblElement2 As Label
    Friend WithEvents lblElement1 As Label
    Friend WithEvents btnBrowseElement1 As Button
    Friend WithEvents btnBrowseElement2 As Button
    Friend WithEvents fbdFolder1 As FolderBrowserDialog
    Friend WithEvents fbdFolder2 As FolderBrowserDialog
    Friend WithEvents settings As RichTextBox
    Friend WithEvents btnChangeSyncDirection As Button
    Friend WithEvents rbtnFolder As RadioButton
    Friend WithEvents rbtnFile As RadioButton
    Friend WithEvents ofdFile1 As OpenFileDialog
    Friend WithEvents ofdFile2 As OpenFileDialog
End Class
