Imports OpenLiveWriter.Api

Public Class Settings
  Private _Settings As IProperties
  Private _LineBreakConversion As LineBreakConverisonOptions = LineBreakConverisonOptions.BRTag

  Private Const PROPERTYKEY_NEWLINE = "PasteAsNewLine"

  Public Enum LineBreakConverisonOptions
    NoConversion
    BRTag
  End Enum

  Public Sub New(ByVal settings As IProperties)
    _Settings = Settings

  End Sub

  Public Property LineBreakConversion() As LineBreakConverisonOptions
    Get
      Return _Settings.GetInt(PROPERTYKEY_NEWLINE, _LineBreakConversion)
    End Get
    Set(ByVal value As LineBreakConverisonOptions)
      _Settings.SetInt(PROPERTYKEY_NEWLINE, value)
    End Set
  End Property


End Class
