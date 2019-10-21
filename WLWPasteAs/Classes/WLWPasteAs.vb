Imports OpenLiveWriter.Api
Imports System.Windows.Forms
Imports System.IO

<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased")> _
<WriterPluginAttribute("8FB9D8D1-1F80-4F06-BECA-8F29BBCC493A", _
    "Paste As", _
    ImagePath:="paste.png", HasEditableOptions:=False, _
    PublisherUrl:="http://coolthingoftheday.blogspot.com/", _
    Description:="Paste text and clipboard content as plain text, block quote or other formats")> _
<InsertableContentSourceAttribute("Paste As")> _
Public Class WLWPasteAs
  Inherits ContentSource

  Private _Settings As Settings

  Public Sub New()

  End Sub

  Public Overrides Sub Initialize(ByVal pluginOptions As OpenLiveWriter.Api.IProperties)
    MyBase.Initialize(pluginOptions)
    _Settings = New Settings(pluginOptions)
  End Sub

  Public Overrides Function CreateContent(ByVal dialogOwner As IWin32Window, ByRef newContent As String) As DialogResult
    Dim PasteAsForm As PasteAs
    Dim result As DialogResult

    PasteAsForm = New PasteAs
    result = PasteAsForm.ShowDialog(dialogOwner, _Settings)

    If result = DialogResult.OK Then

      If PasteAsForm.SelectedText.Length > 0 Then
        newContent = PasteAsForm.SelectedText
        PasteAsForm.Dispose()
        Return result

      Else
        PasteAsForm.Dispose()
        Return DialogResult.Cancel
      End If

    Else
      PasteAsForm.Dispose()
      Return result

    End If

  End Function

End Class
