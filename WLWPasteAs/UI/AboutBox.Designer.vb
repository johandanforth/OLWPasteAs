<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox))
    Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel
    Me.LogoPictureBox = New System.Windows.Forms.PictureBox
    Me.LabelProductName = New System.Windows.Forms.Label
    Me.LabelVersion = New System.Windows.Forms.Label
    Me.LabelCopyright = New System.Windows.Forms.Label
    Me.LabelCompanyName = New System.Windows.Forms.Label
    Me.TextBoxDescription = New System.Windows.Forms.TextBox
    Me.BlogLinkLabel = New System.Windows.Forms.LinkLabel
    Me.CodeplexLinkLabel = New System.Windows.Forms.LinkLabel
    Me.OKButton = New System.Windows.Forms.Button
    Me.TableLayoutPanel.SuspendLayout()
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel
    '
    Me.TableLayoutPanel.ColumnCount = 2
    Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
    Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
    Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
    Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 1, 0)
    Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 1, 1)
    Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 1, 2)
    Me.TableLayoutPanel.Controls.Add(Me.LabelCompanyName, 1, 3)
    Me.TableLayoutPanel.Controls.Add(Me.TextBoxDescription, 1, 6)
    Me.TableLayoutPanel.Controls.Add(Me.BlogLinkLabel, 1, 5)
    Me.TableLayoutPanel.Controls.Add(Me.CodeplexLinkLabel, 1, 4)
    Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 7)
    Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel.Location = New System.Drawing.Point(9, 9)
    Me.TableLayoutPanel.Name = "TableLayoutPanel"
    Me.TableLayoutPanel.RowCount = 7
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.330278!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333611!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00167!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel.Size = New System.Drawing.Size(469, 354)
    Me.TableLayoutPanel.TabIndex = 0
    '
    'LogoPictureBox
    '
    Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
    Me.LogoPictureBox.Location = New System.Drawing.Point(3, 3)
    Me.LogoPictureBox.Name = "LogoPictureBox"
    Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 7)
    Me.LogoPictureBox.Size = New System.Drawing.Size(148, 323)
    Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.LogoPictureBox.TabIndex = 0
    Me.LogoPictureBox.TabStop = False
    '
    'LabelProductName
    '
    Me.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelProductName.Location = New System.Drawing.Point(160, 0)
    Me.LabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelProductName.MaximumSize = New System.Drawing.Size(0, 17)
    Me.LabelProductName.Name = "LabelProductName"
    Me.LabelProductName.Size = New System.Drawing.Size(306, 17)
    Me.LabelProductName.TabIndex = 0
    Me.LabelProductName.Text = "Product Name"
    Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'LabelVersion
    '
    Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelVersion.Location = New System.Drawing.Point(160, 27)
    Me.LabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelVersion.MaximumSize = New System.Drawing.Size(0, 17)
    Me.LabelVersion.Name = "LabelVersion"
    Me.LabelVersion.Size = New System.Drawing.Size(306, 17)
    Me.LabelVersion.TabIndex = 0
    Me.LabelVersion.Text = "Version"
    Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'LabelCopyright
    '
    Me.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelCopyright.Location = New System.Drawing.Point(160, 54)
    Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelCopyright.MaximumSize = New System.Drawing.Size(0, 17)
    Me.LabelCopyright.Name = "LabelCopyright"
    Me.LabelCopyright.Size = New System.Drawing.Size(306, 17)
    Me.LabelCopyright.TabIndex = 0
    Me.LabelCopyright.Text = "Copyright"
    Me.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'LabelCompanyName
    '
    Me.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelCompanyName.Location = New System.Drawing.Point(160, 81)
    Me.LabelCompanyName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelCompanyName.MaximumSize = New System.Drawing.Size(0, 17)
    Me.LabelCompanyName.Name = "LabelCompanyName"
    Me.LabelCompanyName.Size = New System.Drawing.Size(306, 17)
    Me.LabelCompanyName.TabIndex = 0
    Me.LabelCompanyName.Text = "Company Name"
    Me.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TextBoxDescription
    '
    Me.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxDescription.Location = New System.Drawing.Point(160, 165)
    Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
    Me.TextBoxDescription.Multiline = True
    Me.TextBoxDescription.Name = "TextBoxDescription"
    Me.TextBoxDescription.ReadOnly = True
    Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.TextBoxDescription.Size = New System.Drawing.Size(306, 161)
    Me.TextBoxDescription.TabIndex = 0
    Me.TextBoxDescription.TabStop = False
    Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
    '
    'BlogLinkLabel
    '
    Me.BlogLinkLabel.AutoSize = True
    Me.BlogLinkLabel.Location = New System.Drawing.Point(157, 135)
    Me.BlogLinkLabel.Name = "BlogLinkLabel"
    Me.BlogLinkLabel.Size = New System.Drawing.Size(235, 13)
    Me.BlogLinkLabel.TabIndex = 2
    Me.BlogLinkLabel.TabStop = True
    Me.BlogLinkLabel.Text = "Greg's Cool [Insert Clever Name] of the Day blog"
    '
    'CodeplexLinkLabel
    '
    Me.CodeplexLinkLabel.AutoSize = True
    Me.CodeplexLinkLabel.Location = New System.Drawing.Point(157, 108)
    Me.CodeplexLinkLabel.Name = "CodeplexLinkLabel"
    Me.CodeplexLinkLabel.Size = New System.Drawing.Size(109, 13)
    Me.CodeplexLinkLabel.TabIndex = 3
    Me.CodeplexLinkLabel.TabStop = True
    Me.CodeplexLinkLabel.Text = "GitHub Project Site"
    '
    'OKButton
    '
    Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.OKButton.Location = New System.Drawing.Point(391, 332)
    Me.OKButton.Name = "OKButton"
    Me.OKButton.Size = New System.Drawing.Size(75, 19)
    Me.OKButton.TabIndex = 0
    Me.OKButton.Text = "&OK"
    '
    'AboutBox
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(487, 372)
    Me.Controls.Add(Me.TableLayoutPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "AboutBox"
    Me.Padding = New System.Windows.Forms.Padding(9)
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "About Text Template"
    Me.TableLayoutPanel.ResumeLayout(False)
    Me.TableLayoutPanel.PerformLayout()
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents BlogLinkLabel As System.Windows.Forms.LinkLabel
  Friend WithEvents CodeplexLinkLabel As System.Windows.Forms.LinkLabel

End Class
