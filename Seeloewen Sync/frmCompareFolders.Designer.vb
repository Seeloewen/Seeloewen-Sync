<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompareFolders
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompareFolders))
        Me.lv1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblSubHeader1 = New System.Windows.Forms.Label()
        Me.lblSubHeader2 = New System.Windows.Forms.Label()
        Me.pbSyncDirection = New System.Windows.Forms.PictureBox()
        Me.gbExplanations = New System.Windows.Forms.GroupBox()
        Me.lblExplanationNote = New System.Windows.Forms.Label()
        Me.lblExplanationUnchanged = New System.Windows.Forms.Label()
        Me.lblExplanationModified = New System.Windows.Forms.Label()
        Me.lblExplanationDeleted = New System.Windows.Forms.Label()
        Me.lblExplanationNew = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnToggleSyncDirection = New System.Windows.Forms.Button()
        CType(Me.pbSyncDirection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbExplanations.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv1
        '
        Me.lv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5})
        Me.lv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv1.HideSelection = False
        Me.lv1.Location = New System.Drawing.Point(14, 76)
        Me.lv1.Name = "lv1"
        Me.lv1.Size = New System.Drawing.Size(284, 302)
        Me.lv1.TabIndex = 0
        Me.lv1.UseCompatibleStateImageBehavior = False
        Me.lv1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 158
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Size"
        '
        'lv2
        '
        Me.lv2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.lv2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv2.HideSelection = False
        Me.lv2.Location = New System.Drawing.Point(387, 76)
        Me.lv2.Name = "lv2"
        Me.lv2.Size = New System.Drawing.Size(284, 302)
        Me.lv2.TabIndex = 1
        Me.lv2.UseCompatibleStateImageBehavior = False
        Me.lv2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 158
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Type"
        Me.ColumnHeader4.Width = 61
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Size"
        '
        'lblSubHeader1
        '
        Me.lblSubHeader1.AutoSize = True
        Me.lblSubHeader1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHeader1.Location = New System.Drawing.Point(14, 51)
        Me.lblSubHeader1.Name = "lblSubHeader1"
        Me.lblSubHeader1.Size = New System.Drawing.Size(56, 16)
        Me.lblSubHeader1.TabIndex = 9
        Me.lblSubHeader1.Text = "Folder 1"
        '
        'lblSubHeader2
        '
        Me.lblSubHeader2.AutoSize = True
        Me.lblSubHeader2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHeader2.Location = New System.Drawing.Point(384, 51)
        Me.lblSubHeader2.Name = "lblSubHeader2"
        Me.lblSubHeader2.Size = New System.Drawing.Size(56, 16)
        Me.lblSubHeader2.TabIndex = 10
        Me.lblSubHeader2.Text = "Folder 2"
        '
        'pbSyncDirection
        '
        Me.pbSyncDirection.BackgroundImage = Global.Seeloewen_Sync.My.Resources.Resources.SyncRight
        Me.pbSyncDirection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSyncDirection.Location = New System.Drawing.Point(305, 175)
        Me.pbSyncDirection.Name = "pbSyncDirection"
        Me.pbSyncDirection.Size = New System.Drawing.Size(76, 67)
        Me.pbSyncDirection.TabIndex = 12
        Me.pbSyncDirection.TabStop = False
        '
        'gbExplanations
        '
        Me.gbExplanations.Controls.Add(Me.lblExplanationNote)
        Me.gbExplanations.Controls.Add(Me.lblExplanationUnchanged)
        Me.gbExplanations.Controls.Add(Me.lblExplanationModified)
        Me.gbExplanations.Controls.Add(Me.lblExplanationDeleted)
        Me.gbExplanations.Controls.Add(Me.lblExplanationNew)
        Me.gbExplanations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbExplanations.Location = New System.Drawing.Point(14, 402)
        Me.gbExplanations.Name = "gbExplanations"
        Me.gbExplanations.Size = New System.Drawing.Size(657, 146)
        Me.gbExplanations.TabIndex = 13
        Me.gbExplanations.TabStop = False
        Me.gbExplanations.Text = "Color explanations - What happens to the files?"
        '
        'lblExplanationNote
        '
        Me.lblExplanationNote.AutoSize = True
        Me.lblExplanationNote.Location = New System.Drawing.Point(492, 40)
        Me.lblExplanationNote.Name = "lblExplanationNote"
        Me.lblExplanationNote.Size = New System.Drawing.Size(154, 80)
        Me.lblExplanationNote.TabIndex = 4
        Me.lblExplanationNote.Text = "Note:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Files in source folder" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will always remain " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "unchanged!"
        '
        'lblExplanationUnchanged
        '
        Me.lblExplanationUnchanged.AutoSize = True
        Me.lblExplanationUnchanged.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplanationUnchanged.Location = New System.Drawing.Point(16, 33)
        Me.lblExplanationUnchanged.Name = "lblExplanationUnchanged"
        Me.lblExplanationUnchanged.Size = New System.Drawing.Size(208, 16)
        Me.lblExplanationUnchanged.TabIndex = 3
        Me.lblExplanationUnchanged.Text = "Black - File will remain unchanged"
        '
        'lblExplanationModified
        '
        Me.lblExplanationModified.AutoSize = True
        Me.lblExplanationModified.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplanationModified.ForeColor = System.Drawing.Color.Blue
        Me.lblExplanationModified.Location = New System.Drawing.Point(16, 108)
        Me.lblExplanationModified.Name = "lblExplanationModified"
        Me.lblExplanationModified.Size = New System.Drawing.Size(161, 16)
        Me.lblExplanationModified.TabIndex = 2
        Me.lblExplanationModified.Text = "Blue - File will be modified"
        '
        'lblExplanationDeleted
        '
        Me.lblExplanationDeleted.AutoSize = True
        Me.lblExplanationDeleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplanationDeleted.ForeColor = System.Drawing.Color.Red
        Me.lblExplanationDeleted.Location = New System.Drawing.Point(16, 83)
        Me.lblExplanationDeleted.Name = "lblExplanationDeleted"
        Me.lblExplanationDeleted.Size = New System.Drawing.Size(154, 16)
        Me.lblExplanationDeleted.TabIndex = 1
        Me.lblExplanationDeleted.Text = "Red - File will be deleted"
        '
        'lblExplanationNew
        '
        Me.lblExplanationNew.AutoSize = True
        Me.lblExplanationNew.BackColor = System.Drawing.Color.White
        Me.lblExplanationNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplanationNew.ForeColor = System.Drawing.Color.Green
        Me.lblExplanationNew.Location = New System.Drawing.Point(16, 58)
        Me.lblExplanationNew.Name = "lblExplanationNew"
        Me.lblExplanationNew.Size = New System.Drawing.Size(230, 16)
        Me.lblExplanationNew.TabIndex = 0
        Me.lblExplanationNew.Text = "Green - File will be new in target folder"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(12, 13)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(173, 25)
        Me.lblHeader.TabIndex = 14
        Me.lblHeader.Text = "Folder Comparer"
        '
        'btnToggleSyncDirection
        '
        Me.btnToggleSyncDirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleSyncDirection.Location = New System.Drawing.Point(510, 15)
        Me.btnToggleSyncDirection.Name = "btnToggleSyncDirection"
        Me.btnToggleSyncDirection.Size = New System.Drawing.Size(161, 27)
        Me.btnToggleSyncDirection.TabIndex = 15
        Me.btnToggleSyncDirection.Text = "Toggle sync direction"
        Me.btnToggleSyncDirection.UseVisualStyleBackColor = True
        '
        'frmCompareFolders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(688, 560)
        Me.Controls.Add(Me.btnToggleSyncDirection)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.gbExplanations)
        Me.Controls.Add(Me.pbSyncDirection)
        Me.Controls.Add(Me.lblSubHeader2)
        Me.Controls.Add(Me.lblSubHeader1)
        Me.Controls.Add(Me.lv2)
        Me.Controls.Add(Me.lv1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompareFolders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Folder Comparer"
        CType(Me.pbSyncDirection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbExplanations.ResumeLayout(False)
        Me.gbExplanations.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lv1 As ListView
    Friend WithEvents lv2 As ListView
    Friend WithEvents lblSubHeader1 As Label
    Friend WithEvents lblSubHeader2 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents pbSyncDirection As PictureBox
    Friend WithEvents gbExplanations As GroupBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblExplanationUnchanged As Label
    Friend WithEvents lblExplanationModified As Label
    Friend WithEvents lblExplanationDeleted As Label
    Friend WithEvents lblExplanationNew As Label
    Friend WithEvents lblExplanationNote As Label
    Friend WithEvents btnToggleSyncDirection As Button
End Class
