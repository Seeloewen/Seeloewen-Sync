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
        Me.btnBrowseSourceFolder = New System.Windows.Forms.Button()
        Me.btnBrowseTargetFolder = New System.Windows.Forms.Button()
        Me.tbTargetFolder = New System.Windows.Forms.TextBox()
        Me.tbSourceFolder = New System.Windows.Forms.TextBox()
        Me.lblTargetFolder = New System.Windows.Forms.Label()
        Me.lblSourceFolder = New System.Windows.Forms.Label()
        Me.fbdSourceFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbdTargetFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.settings = New System.Windows.Forms.RichTextBox()
        Me.gbEditProfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(325, 206)
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
        Me.btnDelete.Location = New System.Drawing.Point(164, 206)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(155, 23)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete profile"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(11, 206)
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
        Me.cbxProfile.Size = New System.Drawing.Size(266, 21)
        Me.cbxProfile.TabIndex = 13
        '
        'gbEditProfile
        '
        Me.gbEditProfile.Controls.Add(Me.btnBrowseSourceFolder)
        Me.gbEditProfile.Controls.Add(Me.btnBrowseTargetFolder)
        Me.gbEditProfile.Controls.Add(Me.tbTargetFolder)
        Me.gbEditProfile.Controls.Add(Me.tbSourceFolder)
        Me.gbEditProfile.Controls.Add(Me.lblTargetFolder)
        Me.gbEditProfile.Controls.Add(Me.lblSourceFolder)
        Me.gbEditProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEditProfile.Location = New System.Drawing.Point(11, 55)
        Me.gbEditProfile.Name = "gbEditProfile"
        Me.gbEditProfile.Size = New System.Drawing.Size(453, 145)
        Me.gbEditProfile.TabIndex = 12
        Me.gbEditProfile.TabStop = False
        Me.gbEditProfile.Text = "Edit profile"
        '
        'btnBrowseSourceFolder
        '
        Me.btnBrowseSourceFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseSourceFolder.Location = New System.Drawing.Point(343, 46)
        Me.btnBrowseSourceFolder.Name = "btnBrowseSourceFolder"
        Me.btnBrowseSourceFolder.Size = New System.Drawing.Size(97, 23)
        Me.btnBrowseSourceFolder.TabIndex = 19
        Me.btnBrowseSourceFolder.Text = "Browse"
        Me.btnBrowseSourceFolder.UseVisualStyleBackColor = True
        '
        'btnBrowseTargetFolder
        '
        Me.btnBrowseTargetFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseTargetFolder.Location = New System.Drawing.Point(343, 104)
        Me.btnBrowseTargetFolder.Name = "btnBrowseTargetFolder"
        Me.btnBrowseTargetFolder.Size = New System.Drawing.Size(97, 23)
        Me.btnBrowseTargetFolder.TabIndex = 18
        Me.btnBrowseTargetFolder.Text = "Browse"
        Me.btnBrowseTargetFolder.UseVisualStyleBackColor = True
        '
        'tbTargetFolder
        '
        Me.tbTargetFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTargetFolder.Location = New System.Drawing.Point(19, 104)
        Me.tbTargetFolder.Name = "tbTargetFolder"
        Me.tbTargetFolder.Size = New System.Drawing.Size(312, 22)
        Me.tbTargetFolder.TabIndex = 8
        '
        'tbSourceFolder
        '
        Me.tbSourceFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSourceFolder.Location = New System.Drawing.Point(19, 46)
        Me.tbSourceFolder.Name = "tbSourceFolder"
        Me.tbSourceFolder.Size = New System.Drawing.Size(312, 22)
        Me.tbSourceFolder.TabIndex = 7
        '
        'lblTargetFolder
        '
        Me.lblTargetFolder.AutoSize = True
        Me.lblTargetFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetFolder.Location = New System.Drawing.Point(16, 85)
        Me.lblTargetFolder.Name = "lblTargetFolder"
        Me.lblTargetFolder.Size = New System.Drawing.Size(87, 16)
        Me.lblTargetFolder.TabIndex = 6
        Me.lblTargetFolder.Text = "Target folder:"
        '
        'lblSourceFolder
        '
        Me.lblSourceFolder.AutoSize = True
        Me.lblSourceFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSourceFolder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSourceFolder.Location = New System.Drawing.Point(16, 27)
        Me.lblSourceFolder.Name = "lblSourceFolder"
        Me.lblSourceFolder.Size = New System.Drawing.Size(90, 16)
        Me.lblSourceFolder.TabIndex = 5
        Me.lblSourceFolder.Text = "Source folder:"
        '
        'fbdSourceFolder
        '
        Me.fbdSourceFolder.Description = "Select the source folder for the profile you're editing."
        '
        'fbdTargetFolder
        '
        Me.fbdTargetFolder.Description = "Select the target folder for the profile you're editing."
        '
        'settings
        '
        Me.settings.Location = New System.Drawing.Point(30, 295)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(100, 96)
        Me.settings.TabIndex = 18
        Me.settings.Text = ""
        '
        'frmProfileEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(476, 242)
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
        Me.Text = "frmProfileEditor"
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
    Friend WithEvents tbTargetFolder As TextBox
    Friend WithEvents tbSourceFolder As TextBox
    Friend WithEvents lblTargetFolder As Label
    Friend WithEvents lblSourceFolder As Label
    Friend WithEvents btnBrowseSourceFolder As Button
    Friend WithEvents btnBrowseTargetFolder As Button
    Friend WithEvents fbdSourceFolder As FolderBrowserDialog
    Friend WithEvents fbdTargetFolder As FolderBrowserDialog
    Friend WithEvents settings As RichTextBox
End Class
