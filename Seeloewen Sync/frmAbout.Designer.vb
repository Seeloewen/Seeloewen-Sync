<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.llblGithub = New System.Windows.Forms.LinkLabel()
        Me.gbLicense = New System.Windows.Forms.GroupBox()
        Me.rbtLicense = New System.Windows.Forms.RichTextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.tcAbout = New System.Windows.Forms.TabControl()
        Me.tpLicense = New System.Windows.Forms.TabPage()
        Me.tpChangelog = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.gbLicense.SuspendLayout()
        Me.tcAbout.SuspendLayout()
        Me.tpLicense.SuspendLayout()
        Me.tpChangelog.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(13, 13)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(273, 29)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "Seeloewen Sync 0.4.0-b"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(14, 42)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(383, 20)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Simple folder synchronization software by Seeloewen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'llblGithub
        '
        Me.llblGithub.AutoSize = True
        Me.llblGithub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblGithub.Location = New System.Drawing.Point(18, 392)
        Me.llblGithub.Name = "llblGithub"
        Me.llblGithub.Size = New System.Drawing.Size(188, 20)
        Me.llblGithub.TabIndex = 2
        Me.llblGithub.TabStop = True
        Me.llblGithub.Text = "Seeloewen Sync - Github"
        '
        'gbLicense
        '
        Me.gbLicense.Controls.Add(Me.rbtLicense)
        Me.gbLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLicense.Location = New System.Drawing.Point(6, 6)
        Me.gbLicense.Name = "gbLicense"
        Me.gbLicense.Size = New System.Drawing.Size(465, 273)
        Me.gbLicense.TabIndex = 3
        Me.gbLicense.TabStop = False
        Me.gbLicense.Text = "GNU GPL v3"
        '
        'rbtLicense
        '
        Me.rbtLicense.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rbtLicense.Location = New System.Drawing.Point(6, 21)
        Me.rbtLicense.Name = "rbtLicense"
        Me.rbtLicense.Size = New System.Drawing.Size(453, 248)
        Me.rbtLicense.TabIndex = 4
        Me.rbtLicense.Text = resources.GetString("rbtLicense.Text")
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(418, 389)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(85, 26)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'tcAbout
        '
        Me.tcAbout.Controls.Add(Me.tpLicense)
        Me.tcAbout.Controls.Add(Me.tpChangelog)
        Me.tcAbout.Location = New System.Drawing.Point(18, 74)
        Me.tcAbout.Name = "tcAbout"
        Me.tcAbout.SelectedIndex = 0
        Me.tcAbout.Size = New System.Drawing.Size(485, 308)
        Me.tcAbout.TabIndex = 5
        '
        'tpLicense
        '
        Me.tpLicense.BackColor = System.Drawing.Color.White
        Me.tpLicense.Controls.Add(Me.gbLicense)
        Me.tpLicense.Location = New System.Drawing.Point(4, 22)
        Me.tpLicense.Name = "tpLicense"
        Me.tpLicense.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLicense.Size = New System.Drawing.Size(477, 282)
        Me.tpLicense.TabIndex = 0
        Me.tpLicense.Text = "License"
        '
        'tpChangelog
        '
        Me.tpChangelog.BackColor = System.Drawing.Color.White
        Me.tpChangelog.Controls.Add(Me.RichTextBox1)
        Me.tpChangelog.Location = New System.Drawing.Point(4, 22)
        Me.tpChangelog.Name = "tpChangelog"
        Me.tpChangelog.Padding = New System.Windows.Forms.Padding(3)
        Me.tpChangelog.Size = New System.Drawing.Size(477, 282)
        Me.tpChangelog.TabIndex = 1
        Me.tpChangelog.Text = "Changelog"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(7, 7)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(464, 267)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(515, 425)
        Me.Controls.Add(Me.llblGithub)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.tcAbout)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblVersion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.gbLicense.ResumeLayout(False)
        Me.tcAbout.ResumeLayout(False)
        Me.tpLicense.ResumeLayout(False)
        Me.tpChangelog.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVersion As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents llblGithub As LinkLabel
    Friend WithEvents gbLicense As GroupBox
    Friend WithEvents rbtLicense As RichTextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents tcAbout As TabControl
    Friend WithEvents tpLicense As TabPage
    Friend WithEvents tpChangelog As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
