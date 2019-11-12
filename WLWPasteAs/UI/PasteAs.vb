Imports System.Windows.Forms
Imports System.ComponentModel
Imports RtfPipe

Public Class PasteAs
  Private _selectedText As String = String.Empty
  Private _PluginSettings As Settings
  Private _selectedTextRtf As Boolean = False

  Public Property SelectedText() As String
    Get
      Return _selectedText
    End Get
    Set(ByVal value As String)
      _selectedText = value
    End Set
  End Property
  
  Public Property SelectedTextRtf() As Boolean
    Get
      Return _selectedText
    End Get
    Set(ByVal value As Boolean)
      _selectedText = value
    End Set
  End Property

  Public Overloads Function ShowDialog(ByVal parent As Object, ByVal pluginSettings As Settings) As DialogResult
    _PluginSettings = pluginSettings
    Return Me.ShowDialog(parent)
  End Function

#Region "Form Events"

  Private Sub SelectTextTemplate_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    My.Settings.PasteAsDialogLocation = Me.Location
    My.Settings.PasteAsDialogSize = Me.Size

    My.Settings.LastUsedPasteAsType = Me.PasteAsComboBox.Text

    My.Settings.Save()

  End Sub

  Private Sub SelectTextTemplate_HelpButtonClicked(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
    Dim about As AboutBox
    about = New AboutBox
    about.ShowDialog(Me)
    about.Dispose()
    e.Cancel = True
  End Sub

  Private Sub SelectTextTemplate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    If My.Settings.PasteAsDialogLocation.Height > -1 Then
      Me.Location = My.Settings.PasteAsDialogLocation
    End If

    If My.Settings.PasteAsDialogSize.Height > -1 Then
      Me.Size = My.Settings.PasteAsDialogSize
    End If

    If My.Settings.LastUsedPasteAsType.Length > 0 Then
      Me.PasteAsComboBox.SelectedIndex = Me.PasteAsComboBox.FindStringExact(My.Settings.LastUsedPasteAsType)
    Else
      Me.PasteAsComboBox.SelectedIndex = 0
    End If

    Select Case Me._PluginSettings.LineBreakConversion
      Case Settings.LineBreakConverisonOptions.BRTag
        Me.LinefeedCheckBox.Checked = True
      Case Settings.LineBreakConverisonOptions.NoConversion
        Me.LinefeedCheckBox.Checked = False

      Case Else
        Me.LinefeedCheckBox.Checked = True
    End Select

    Try
      SelectedTextRtf = False
      If My.Computer.Clipboard.ContainsText = True Then
		Me.PasteAsTextBox.Text = My.Computer.Clipboard.GetText()
      End If
	  
	  ' If My.Computer.Clipboard.ContainsText(TextDataFormat.Html) = True Then
		' Dim myString = My.Computer.Clipboard.GetText(TextDataFormat.Html)
	    ' Dim StartOffset As Integer = InStr(myString, "<!--StartFragment-->")
        ' Dim EndOffset As Integer = InStr(myString, "<!--EndFragment-->")
        ' Me.PasteAsTextBox.Text = Mid(myString, StartOffset + 20, EndOffset - StartOffset - 20)
	  ' End If
	  
	 Catch ex As Exception
      MsgBox("Error loading templates. Error " & ex.Message)
    End Try
	
	If My.Computer.Clipboard.ContainsText(TextDataFormat.Rtf) = True Then
		SelectedTextRtf = True
		Try
			Me.PasteAsTextBox.Text = RtfPipe.Rtf.ToHtml(My.Computer.Clipboard.GetText(TextDataFormat.Rtf))
			
		Catch ex As Exception

		End Try
	End If
	
	If Me.PasteAsTextBox.Text = My.Computer.Clipboard.GetText() Then
		SelectedTextRtf = False
	End If

  End Sub

#End Region

#Region "Control Events"

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    OkClose()
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub LinefeedCheckBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinefeedCheckBox.Click
    If LinefeedCheckBox.Checked Then
      Me._PluginSettings.LineBreakConversion = Settings.LineBreakConverisonOptions.BRTag
    Else
      Me._PluginSettings.LineBreakConversion = Settings.LineBreakConverisonOptions.NoConversion
    End If

  End Sub

#End Region

#Region "Link Label Control Events"

  Private Sub AboutLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles AboutLinkLabel.LinkClicked
    Dim about As AboutBox
    about = New AboutBox
    about.ShowDialog(Me)
    about.Dispose()

  End Sub

  Private Sub PreviewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PreviewLinkLabel.LinkClicked
    Dim frm As InsertPreview

    frm = New InsertPreview
    Try
      frm.ShowDialog(Me, BuildHTML())
    Catch ex As Exception
      MsgBox("Error showing the Preview " & Err.Description)
    End Try

    frm.Dispose()

  End Sub

#End Region

#Region "Private Helpers"
  Private Sub OkClose()
    SelectedText = BuildHTML()
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()

  End Sub

  Private Function BuildHTML() As String
    Dim HTML As String

    Select Case _PluginSettings.LineBreakConversion
      Case Settings.LineBreakConverisonOptions.BRTag
		If SelectedTextRtf() Then
			HTML = Replace(PasteAsTextBox.Text, vbCrLf, "<br>", , , CompareMethod.Text)
		Else
			HTML = Replace(System.Web.HttpUtility.HtmlEncode(PasteAsTextBox.Text), vbCrLf, "<br>", , , CompareMethod.Text)
		End If

      Case Settings.LineBreakConverisonOptions.NoConversion
		If SelectedTextRtf() Then
			HTML = PasteAsTextBox.Text
		Else
			HTML = System.Web.HttpUtility.HtmlEncode(PasteAsTextBox.Text)
		End If

      Case Else
        If SelectedTextRtf() Then
			HTML = Replace(PasteAsTextBox.Text, vbCrLf, "<br>", , , CompareMethod.Text)
		Else
			HTML = Replace(System.Web.HttpUtility.HtmlEncode(PasteAsTextBox.Text), vbCrLf, "<br>", , , CompareMethod.Text)
		End If

    End Select
	
	If (Not String.IsNullOrEmpty(HTML)) Then
		Select Case Me.PasteAsComboBox.SelectedIndex
		  Case -1 'Unknown, paste as Plain test
			'HTML = PasteAsTextBox.Text
			'No Op needed
		  Case 0 'Plain test
			'HTML = PasteAsTextBox.Text
			'No Op needed

		  Case 1 'Block Quote
			HTML = "<BLOCKQUOTE>" & HTML & "</BLOCKQUOTE>"

		  Case 2
			HTML = "<PRE><CODE>" & HTML & "</CODE></PRE> "
			
		  Case 3
			HTML = "<CODE>" & HTML & "</CODE> "

		  Case Else 'Unknown, paste as Plain test
			'HTML = PasteAsTextBox.Text
			'No Op needed

		End Select
    Else
		HTML = ""
    End If
	
    Return HTML

  End Function
#End Region


End Class
