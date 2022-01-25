Public Class frmSettings
    Private Sub llblNotice_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblNotice.LinkClicked
        MsgBox("Future versions will add a feature to save" + vbNewLine + "multiple schemes and/or multiple source/target folders.", MsgBoxStyle.Information, "Notice")
    End Sub
End Class