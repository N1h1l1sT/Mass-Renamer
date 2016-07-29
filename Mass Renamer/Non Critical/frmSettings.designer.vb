<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.cmdCurrent = New System.Windows.Forms.Button()
        Me.cmdDefault = New System.Windows.Forms.Button()
        Me.gbCommands = New System.Windows.Forms.GroupBox()
        Me.gbGlobalSettings = New System.Windows.Forms.GroupBox()
        Me.cbLanguage = New System.Windows.Forms.ComboBox()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.txtDirectories = New System.Windows.Forms.TextBox()
        Me.txtLanguage = New System.Windows.Forms.TextBox()
        Me.txtSettings = New System.Windows.Forms.TextBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.fbdDBPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.gbCommands.SuspendLayout()
        Me.gbGlobalSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCurrent
        '
        Me.cmdCurrent.Location = New System.Drawing.Point(29, 17)
        Me.cmdCurrent.Name = "cmdCurrent"
        Me.cmdCurrent.Size = New System.Drawing.Size(154, 23)
        Me.cmdCurrent.TabIndex = 3
        Me.cmdCurrent.Text = "Read Current Settings"
        Me.cmdCurrent.UseVisualStyleBackColor = True
        '
        'cmdDefault
        '
        Me.cmdDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDefault.Location = New System.Drawing.Point(205, 17)
        Me.cmdDefault.Name = "cmdDefault"
        Me.cmdDefault.Size = New System.Drawing.Size(161, 23)
        Me.cmdDefault.TabIndex = 4
        Me.cmdDefault.Text = "Reset Default Settings"
        Me.cmdDefault.UseVisualStyleBackColor = True
        '
        'gbCommands
        '
        Me.gbCommands.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCommands.Controls.Add(Me.cmdCurrent)
        Me.gbCommands.Controls.Add(Me.cmdDefault)
        Me.gbCommands.Location = New System.Drawing.Point(12, 12)
        Me.gbCommands.Name = "gbCommands"
        Me.gbCommands.Size = New System.Drawing.Size(389, 54)
        Me.gbCommands.TabIndex = 5
        Me.gbCommands.TabStop = False
        Me.gbCommands.Text = "Commands:"
        '
        'gbGlobalSettings
        '
        Me.gbGlobalSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbGlobalSettings.Controls.Add(Me.cbLanguage)
        Me.gbGlobalSettings.Controls.Add(Me.lblLanguage)
        Me.gbGlobalSettings.Location = New System.Drawing.Point(12, 88)
        Me.gbGlobalSettings.Name = "gbGlobalSettings"
        Me.gbGlobalSettings.Size = New System.Drawing.Size(386, 62)
        Me.gbGlobalSettings.TabIndex = 6
        Me.gbGlobalSettings.TabStop = False
        Me.gbGlobalSettings.Text = "Global Settings:"
        '
        'cbLanguage
        '
        Me.cbLanguage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLanguage.FormattingEnabled = True
        Me.cbLanguage.Location = New System.Drawing.Point(184, 24)
        Me.cbLanguage.Name = "cbLanguage"
        Me.cbLanguage.Size = New System.Drawing.Size(196, 21)
        Me.cbLanguage.TabIndex = 15
        Me.cbLanguage.Tag = "0"
        Me.cbLanguage.Text = "Unknown"
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.BackColor = System.Drawing.Color.Black
        Me.lblLanguage.ForeColor = System.Drawing.Color.Gold
        Me.lblLanguage.Location = New System.Drawing.Point(8, 27)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(58, 13)
        Me.lblLanguage.TabIndex = 15
        Me.lblLanguage.Text = "Language:"
        '
        'txtDirectories
        '
        Me.txtDirectories.Location = New System.Drawing.Point(22, -2)
        Me.txtDirectories.Multiline = True
        Me.txtDirectories.Name = "txtDirectories"
        Me.txtDirectories.Size = New System.Drawing.Size(16, 17)
        Me.txtDirectories.TabIndex = 19
        Me.txtDirectories.Visible = False
        '
        'txtLanguage
        '
        Me.txtLanguage.Location = New System.Drawing.Point(0, -2)
        Me.txtLanguage.Multiline = True
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.Size = New System.Drawing.Size(18, 19)
        Me.txtLanguage.TabIndex = 20
        Me.txtLanguage.Visible = False
        '
        'txtSettings
        '
        Me.txtSettings.Location = New System.Drawing.Point(44, -2)
        Me.txtSettings.Multiline = True
        Me.txtSettings.Name = "txtSettings"
        Me.txtSettings.Size = New System.Drawing.Size(13, 16)
        Me.txtSettings.TabIndex = 6
        Me.txtSettings.Visible = False
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(41, 156)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(133, 23)
        Me.cmdExit.TabIndex = 17
        Me.cmdExit.Text = "Cancel"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdApply
        '
        Me.cmdApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdApply.Enabled = False
        Me.cmdApply.Location = New System.Drawing.Point(245, 156)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(133, 23)
        Me.cmdApply.TabIndex = 16
        Me.cmdApply.Text = "Apply And Close"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Black
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Gold
        Me.lblInfo.Location = New System.Drawing.Point(18, 68)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(272, 15)
        Me.lblInfo.TabIndex = 5
        Me.lblInfo.Text = "You may Change the language from here."
        '
        'frmSettings
        '
        Me.AcceptButton = Me.cmdApply
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(409, 191)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.gbGlobalSettings)
        Me.Controls.Add(Me.gbCommands)
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtLanguage)
        Me.Controls.Add(Me.txtDirectories)
        Me.Controls.Add(Me.txtSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.gbCommands.ResumeLayout(False)
        Me.gbGlobalSettings.ResumeLayout(False)
        Me.gbGlobalSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCurrent As System.Windows.Forms.Button
    Friend WithEvents cmdDefault As System.Windows.Forms.Button
    Friend WithEvents gbCommands As System.Windows.Forms.GroupBox
    Friend WithEvents gbGlobalSettings As System.Windows.Forms.GroupBox
    Friend WithEvents txtSettings As System.Windows.Forms.TextBox
    Friend WithEvents lblLanguage As System.Windows.Forms.Label
    Friend WithEvents cbLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtLanguage As System.Windows.Forms.TextBox
    Friend WithEvents txtDirectories As System.Windows.Forms.TextBox
    Friend WithEvents fbdDBPath As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblInfo As System.Windows.Forms.Label
End Class
