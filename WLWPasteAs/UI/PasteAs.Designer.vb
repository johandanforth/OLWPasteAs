<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasteAs
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId:="System.Windows.Forms.Label.set_Text(System.String)")> <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:DoNotPassLiteralsAsLocalizedParameters", MessageId:="System.Windows.Forms.Control.set_Text(System.String)")> <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasteAs))
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.OK_Button = New System.Windows.Forms.Button
    Me.Cancel_Button = New System.Windows.Forms.Button
    Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
    Me.PreviewLinkLabel = New System.Windows.Forms.LinkLabel
    Me.AboutLinkLabel = New System.Windows.Forms.LinkLabel
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
    Me.LinefeedCheckBox = New System.Windows.Forms.CheckBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
    Me.Label2 = New System.Windows.Forms.Label
    Me.PasteAsComboBox = New System.Windows.Forms.ComboBox
    Me.PasteAsTextBox = New System.Windows.Forms.TextBox
    Me.TableLayoutPanel1.SuspendLayout()
    Me.FlowLayoutPanel1.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(388, 304)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
    Me.TableLayoutPanel1.TabIndex = 1
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(67, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'FlowLayoutPanel1
    '
    Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.FlowLayoutPanel1.Controls.Add(Me.PreviewLinkLabel)
    Me.FlowLayoutPanel1.Controls.Add(Me.AboutLinkLabel)
    Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 304)
    Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
    Me.FlowLayoutPanel1.Size = New System.Drawing.Size(375, 29)
    Me.FlowLayoutPanel1.TabIndex = 2
    '
    'PreviewLinkLabel
    '
    Me.PreviewLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.PreviewLinkLabel.AutoSize = True
    Me.PreviewLinkLabel.Location = New System.Drawing.Point(3, 0)
    Me.PreviewLinkLabel.Name = "PreviewLinkLabel"
    Me.PreviewLinkLabel.Size = New System.Drawing.Size(99, 13)
    Me.PreviewLinkLabel.TabIndex = 3
    Me.PreviewLinkLabel.TabStop = True
    Me.PreviewLinkLabel.Text = "Preview Paste As..."
    '
    'AboutLinkLabel
    '
    Me.AboutLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.AboutLinkLabel.AutoSize = True
    Me.AboutLinkLabel.Location = New System.Drawing.Point(108, 0)
    Me.AboutLinkLabel.Name = "AboutLinkLabel"
    Me.AboutLinkLabel.Size = New System.Drawing.Size(90, 13)
    Me.AboutLinkLabel.TabIndex = 5
    Me.AboutLinkLabel.TabStop = True
    Me.AboutLinkLabel.Text = "About This Plugin"
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel2.ColumnCount = 1
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel2.Controls.Add(Me.LinefeedCheckBox, 0, 3)
    Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.PasteAsTextBox, 0, 2)
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 12)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 4
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.69231!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.30769!))
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(522, 286)
    Me.TableLayoutPanel2.TabIndex = 0
    '
    'LinefeedCheckBox
    '
    Me.LinefeedCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.LinefeedCheckBox.AutoSize = True
    Me.LinefeedCheckBox.Location = New System.Drawing.Point(3, 268)
    Me.LinefeedCheckBox.Name = "LinefeedCheckBox"
    Me.LinefeedCheckBox.Size = New System.Drawing.Size(197, 15)
    Me.LinefeedCheckBox.TabIndex = 11
    Me.LinefeedCheckBox.Text = "Convert Line Feeds into <BR> tags?"
    Me.LinefeedCheckBox.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Location = New System.Drawing.Point(3, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(497, 26)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "The Text below is from current contents of the Clipboard. Select a ""Paste As"" opt" & _
        "ion and click on OK to Paste it into the current post. "
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.ColumnCount = 2
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.75969!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.24031!))
    Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.PasteAsComboBox, 1, 0)
    Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 29)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 1
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(516, 24)
    Me.TableLayoutPanel3.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Location = New System.Drawing.Point(3, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(52, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Paste As:"
    '
    'PasteAsComboBox
    '
    Me.PasteAsComboBox.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PasteAsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.PasteAsComboBox.FormattingEnabled = True
    Me.PasteAsComboBox.Items.AddRange(New Object() {"Plain Text", "Plain Text with Block Quote <BLOCKQUOTE>...</BLOCKQUOTE>", "Plain Text with Preformated <PRE>...</PRE>", "Plain Text with Code <CODE>...</CODE>"})
    Me.PasteAsComboBox.Location = New System.Drawing.Point(74, 3)
    Me.PasteAsComboBox.Name = "PasteAsComboBox"
    Me.PasteAsComboBox.Size = New System.Drawing.Size(439, 21)
    Me.PasteAsComboBox.TabIndex = 3
    '
    'PasteAsTextBox
    '
    Me.PasteAsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PasteAsTextBox.Location = New System.Drawing.Point(3, 59)
    Me.PasteAsTextBox.Multiline = True
    Me.PasteAsTextBox.Name = "PasteAsTextBox"
    Me.PasteAsTextBox.Size = New System.Drawing.Size(516, 203)
    Me.PasteAsTextBox.TabIndex = 4
    '
    'PasteAs
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(545, 343)
    Me.Controls.Add(Me.TableLayoutPanel2)
    Me.Controls.Add(Me.FlowLayoutPanel1)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.HelpButton = True
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.MinimumSize = New System.Drawing.Size(515, 354)
    Me.Name = "PasteAs"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Paste As..."
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.FlowLayoutPanel1.ResumeLayout(False)
    Me.FlowLayoutPanel1.PerformLayout()
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel2.PerformLayout()
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents PreviewLinkLabel As System.Windows.Forms.LinkLabel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents AboutLinkLabel As System.Windows.Forms.LinkLabel
  Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents PasteAsComboBox As System.Windows.Forms.ComboBox
  Friend WithEvents PasteAsTextBox As System.Windows.Forms.TextBox
  Friend WithEvents LinefeedCheckBox As System.Windows.Forms.CheckBox

End Class
