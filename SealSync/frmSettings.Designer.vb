<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblDefaultSourceFolder = New System.Windows.Forms.Label()
        Me.tbDefaultSourceFolder = New System.Windows.Forms.TextBox()
        Me.btnBrowseDefaultSourceFolder = New System.Windows.Forms.Button()
        Me.btnBrowseDefaultTargetFolder = New System.Windows.Forms.Button()
        Me.tbDefaultTargetfolder = New System.Windows.Forms.TextBox()
        Me.lblDefaultTargetFolder = New System.Windows.Forms.Label()
        Me.llblNotice = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(223, 195)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(13, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(90, 25)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Settings"
        '
        'lblDefaultSourceFolder
        '
        Me.lblDefaultSourceFolder.AutoSize = True
        Me.lblDefaultSourceFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultSourceFolder.Location = New System.Drawing.Point(15, 46)
        Me.lblDefaultSourceFolder.Name = "lblDefaultSourceFolder"
        Me.lblDefaultSourceFolder.Size = New System.Drawing.Size(140, 16)
        Me.lblDefaultSourceFolder.TabIndex = 2
        Me.lblDefaultSourceFolder.Text = "Default Source Folder:"
        '
        'tbDefaultSourceFolder
        '
        Me.tbDefaultSourceFolder.Location = New System.Drawing.Point(19, 63)
        Me.tbDefaultSourceFolder.Name = "tbDefaultSourceFolder"
        Me.tbDefaultSourceFolder.Size = New System.Drawing.Size(238, 20)
        Me.tbDefaultSourceFolder.TabIndex = 3
        '
        'btnBrowseDefaultSourceFolder
        '
        Me.btnBrowseDefaultSourceFolder.Location = New System.Drawing.Point(263, 63)
        Me.btnBrowseDefaultSourceFolder.Name = "btnBrowseDefaultSourceFolder"
        Me.btnBrowseDefaultSourceFolder.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseDefaultSourceFolder.TabIndex = 4
        Me.btnBrowseDefaultSourceFolder.Text = "Browse"
        Me.btnBrowseDefaultSourceFolder.UseVisualStyleBackColor = True
        '
        'btnBrowseDefaultTargetFolder
        '
        Me.btnBrowseDefaultTargetFolder.Location = New System.Drawing.Point(263, 114)
        Me.btnBrowseDefaultTargetFolder.Name = "btnBrowseDefaultTargetFolder"
        Me.btnBrowseDefaultTargetFolder.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseDefaultTargetFolder.TabIndex = 5
        Me.btnBrowseDefaultTargetFolder.Text = "Browse"
        Me.btnBrowseDefaultTargetFolder.UseVisualStyleBackColor = True
        '
        'tbDefaultTargetfolder
        '
        Me.tbDefaultTargetfolder.Location = New System.Drawing.Point(19, 114)
        Me.tbDefaultTargetfolder.Name = "tbDefaultTargetfolder"
        Me.tbDefaultTargetfolder.Size = New System.Drawing.Size(238, 20)
        Me.tbDefaultTargetfolder.TabIndex = 7
        '
        'lblDefaultTargetFolder
        '
        Me.lblDefaultTargetFolder.AutoSize = True
        Me.lblDefaultTargetFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultTargetFolder.Location = New System.Drawing.Point(16, 95)
        Me.lblDefaultTargetFolder.Name = "lblDefaultTargetFolder"
        Me.lblDefaultTargetFolder.Size = New System.Drawing.Size(132, 16)
        Me.lblDefaultTargetFolder.TabIndex = 6
        Me.lblDefaultTargetFolder.Text = "Default Target folder:"
        '
        'llblNotice
        '
        Me.llblNotice.AutoSize = True
        Me.llblNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblNotice.Location = New System.Drawing.Point(71, 161)
        Me.llblNotice.Name = "llblNotice"
        Me.llblNotice.Size = New System.Drawing.Size(200, 16)
        Me.llblNotice.TabIndex = 8
        Me.llblNotice.TabStop = True
        Me.llblNotice.Text = "Notice about future development"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(350, 229)
        Me.Controls.Add(Me.llblNotice)
        Me.Controls.Add(Me.tbDefaultTargetfolder)
        Me.Controls.Add(Me.lblDefaultTargetFolder)
        Me.Controls.Add(Me.btnBrowseDefaultTargetFolder)
        Me.Controls.Add(Me.btnBrowseDefaultSourceFolder)
        Me.Controls.Add(Me.tbDefaultSourceFolder)
        Me.Controls.Add(Me.lblDefaultSourceFolder)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblDefaultSourceFolder As Label
    Friend WithEvents tbDefaultSourceFolder As TextBox
    Friend WithEvents btnBrowseDefaultSourceFolder As Button
    Friend WithEvents btnBrowseDefaultTargetFolder As Button
    Friend WithEvents tbDefaultTargetfolder As TextBox
    Friend WithEvents lblDefaultTargetFolder As Label
    Friend WithEvents llblNotice As LinkLabel
End Class
