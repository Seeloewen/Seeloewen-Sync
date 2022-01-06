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
        Me.gbLicense.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(13, 13)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(371, 29)
        Me.lblVersion.TabIndex = 0
        Me.lblVersion.Text = "SealSync 0.1-b Build 2201062341"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(14, 42)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(372, 20)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Simple folder syncronization program by Seeloewen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'llblGithub
        '
        Me.llblGithub.AutoSize = True
        Me.llblGithub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblGithub.Location = New System.Drawing.Point(20, 306)
        Me.llblGithub.Name = "llblGithub"
        Me.llblGithub.Size = New System.Drawing.Size(137, 20)
        Me.llblGithub.TabIndex = 2
        Me.llblGithub.TabStop = True
        Me.llblGithub.Text = "SealSync - Github"
        '
        'gbLicense
        '
        Me.gbLicense.Controls.Add(Me.rbtLicense)
        Me.gbLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLicense.Location = New System.Drawing.Point(18, 77)
        Me.gbLicense.Name = "gbLicense"
        Me.gbLicense.Size = New System.Drawing.Size(366, 221)
        Me.gbLicense.TabIndex = 3
        Me.gbLicense.TabStop = False
        Me.gbLicense.Text = "GNU GPL v3"
        '
        'rbtLicense
        '
        Me.rbtLicense.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rbtLicense.Location = New System.Drawing.Point(6, 21)
        Me.rbtLicense.Name = "rbtLicense"
        Me.rbtLicense.Size = New System.Drawing.Size(354, 193)
        Me.rbtLicense.TabIndex = 4
        Me.rbtLicense.Text = resources.GetString("rbtLicense.Text")
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(299, 304)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(85, 26)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(404, 341)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.gbLicense)
        Me.Controls.Add(Me.llblGithub)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVersion As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents llblGithub As LinkLabel
    Friend WithEvents gbLicense As GroupBox
    Friend WithEvents rbtLicense As RichTextBox
    Friend WithEvents btnOK As Button
End Class
