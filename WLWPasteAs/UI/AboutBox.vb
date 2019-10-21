Imports Microsoft.Win32
Imports System.Xml
Imports System.Reflection

Public NotInheritable Class AboutBox

  Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim assy As Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
    Dim attr As Attribute

    Me.LabelProductName.Text = assy.GetName().Name
    Me.LabelVersion.Text = assy.GetName().Version.ToString

    For Each attr In Attribute.GetCustomAttributes(assy)

      ' Check for the AssemblyTitle attribute.
      If TypeOf attr Is AssemblyTitleAttribute Then
        ' Convert the attribute to access its data.
        Dim attrTitle As AssemblyTitleAttribute = CType(attr, AssemblyTitleAttribute)
        Me.Text = String.Format("About {0}", attrTitle.Title)

        ' Check for the AssemblyDescription attribute.
      ElseIf TypeOf attr Is AssemblyDescriptionAttribute Then
        ' Convert the attribute to access its data.
        Dim attrDesc As AssemblyDescriptionAttribute = CType(attr, AssemblyDescriptionAttribute)
        Me.TextBoxDescription.Text = attrDesc.Description

        ' Check for the AssemblyCompany attribute.
      ElseIf TypeOf attr Is AssemblyCompanyAttribute Then
        ' Convert the attribute to access its data.
        Dim attrComp As AssemblyCompanyAttribute = CType(attr, AssemblyCompanyAttribute)
        Me.LabelCompanyName.Text = attrComp.Company

      ElseIf TypeOf attr Is AssemblyCopyrightAttribute Then
        Dim attrCopy As AssemblyCopyrightAttribute = CType(attr, AssemblyCopyrightAttribute)
        Me.LabelCopyright.Text = attrCopy.Copyright

      End If

    Next


  End Sub

  Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
    Me.Close()
  End Sub

  Private Sub BlogLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles BlogLinkLabel.LinkClicked
    Try
      Process.Start(My.Resources.BlogURL)
    Catch ex As Exception

    End Try
  End Sub

  Private Sub CodeplexLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CodeplexLinkLabel.LinkClicked
    Try
      Process.Start(My.Resources.CodeplexURL)
    Catch ex As Exception

    End Try

  End Sub

  End Class
