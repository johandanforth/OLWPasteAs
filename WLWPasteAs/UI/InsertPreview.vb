Imports System.Windows.Forms

Friend Class InsertPreview

  Public Overloads Function ShowDialog(ByVal parent As Object, ByVal insert As String) As DialogResult

    Me.WebBrowser1.DocumentText = "<html><body>" & insert & "</body></html>"
    Return Me.ShowDialog(parent)

  End Function

  Private Sub InsertPreview_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    My.Settings.PreviewDialogLocation = Me.Location
    My.Settings.PreviewDialogSize = Me.Size
    My.Settings.Save()

  End Sub

  Private Sub frmPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    If My.Settings.PreviewDialogLocation.Height > -1 Then
      Me.Location = My.Settings.PreviewDialogLocation
    End If

    If My.Settings.PreviewDialogSize.Height > -1 Then
      Me.Size = My.Settings.PreviewDialogSize
    End If

  End Sub

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

  End Sub
End Class