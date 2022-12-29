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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.gbProfiles = New System.Windows.Forms.GroupBox()
        Me.cbxDefaultProfile = New System.Windows.Forms.ComboBox()
        Me.cbLoadProfileByDefault = New System.Windows.Forms.CheckBox()
        Me.btnOpenProfileEditor = New System.Windows.Forms.Button()
        Me.lblProfiles = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbProfiles.SuspendLayout()
        Me.SuspendLayout()
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
        'gbProfiles
        '
        Me.gbProfiles.Controls.Add(Me.cbxDefaultProfile)
        Me.gbProfiles.Controls.Add(Me.cbLoadProfileByDefault)
        Me.gbProfiles.Controls.Add(Me.btnOpenProfileEditor)
        Me.gbProfiles.Controls.Add(Me.lblProfiles)
        Me.gbProfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProfiles.Location = New System.Drawing.Point(18, 40)
        Me.gbProfiles.Name = "gbProfiles"
        Me.gbProfiles.Size = New System.Drawing.Size(320, 181)
        Me.gbProfiles.TabIndex = 2
        Me.gbProfiles.TabStop = False
        Me.gbProfiles.Text = "Profiles"
        '
        'cbxDefaultProfile
        '
        Me.cbxDefaultProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDefaultProfile.FormattingEnabled = True
        Me.cbxDefaultProfile.Location = New System.Drawing.Point(19, 137)
        Me.cbxDefaultProfile.Name = "cbxDefaultProfile"
        Me.cbxDefaultProfile.Size = New System.Drawing.Size(276, 24)
        Me.cbxDefaultProfile.TabIndex = 12
        '
        'cbLoadProfileByDefault
        '
        Me.cbLoadProfileByDefault.AutoSize = True
        Me.cbLoadProfileByDefault.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoadProfileByDefault.Location = New System.Drawing.Point(19, 111)
        Me.cbLoadProfileByDefault.Name = "cbLoadProfileByDefault"
        Me.cbLoadProfileByDefault.Size = New System.Drawing.Size(161, 20)
        Me.cbLoadProfileByDefault.TabIndex = 11
        Me.cbLoadProfileByDefault.Text = "Load profile by default:"
        Me.cbLoadProfileByDefault.UseVisualStyleBackColor = True
        '
        'btnOpenProfileEditor
        '
        Me.btnOpenProfileEditor.Location = New System.Drawing.Point(19, 71)
        Me.btnOpenProfileEditor.Name = "btnOpenProfileEditor"
        Me.btnOpenProfileEditor.Size = New System.Drawing.Size(276, 23)
        Me.btnOpenProfileEditor.TabIndex = 9
        Me.btnOpenProfileEditor.Text = "Open Profile Editor"
        Me.btnOpenProfileEditor.UseVisualStyleBackColor = True
        '
        'lblProfiles
        '
        Me.lblProfiles.AutoSize = True
        Me.lblProfiles.Location = New System.Drawing.Point(16, 27)
        Me.lblProfiles.Name = "lblProfiles"
        Me.lblProfiles.Size = New System.Drawing.Size(279, 32)
        Me.lblProfiles.TabIndex = 0
        Me.lblProfiles.Text = "Profiles allow you to save multiple schemes of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "source and target folders."
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(184, 230)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(154, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(18, 230)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(149, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(350, 265)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbProfiles)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.gbProfiles.ResumeLayout(False)
        Me.gbProfiles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As Label
    Friend WithEvents gbProfiles As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents cbxDefaultProfile As ComboBox
    Friend WithEvents cbLoadProfileByDefault As CheckBox
    Friend WithEvents btnOpenProfileEditor As Button
    Friend WithEvents lblProfiles As Label
End Class
