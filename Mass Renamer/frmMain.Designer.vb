<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtFileNames = New System.Windows.Forms.TextBox()
        Me.txtSettings = New System.Windows.Forms.TextBox()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.btnDirectory = New System.Windows.Forms.Button()
        Me.rdbFile = New System.Windows.Forms.RadioButton()
        Me.rdbFolder = New System.Windows.Forms.RadioButton()
        Me.gbWorkWith = New System.Windows.Forms.GroupBox()
        Me.gbDo = New System.Windows.Forms.GroupBox()
        Me.txtSuffixText = New System.Windows.Forms.TextBox()
        Me.txtPrefixText = New System.Windows.Forms.TextBox()
        Me.rdbSuffix = New System.Windows.Forms.RadioButton()
        Me.rdbPrefix = New System.Windows.Forms.RadioButton()
        Me.rdbDelete = New System.Windows.Forms.RadioButton()
        Me.rdbUnlock = New System.Windows.Forms.RadioButton()
        Me.rdbCapitalizeAllWords = New System.Windows.Forms.RadioButton()
        Me.rdbCapitalize1stWord = New System.Windows.Forms.RadioButton()
        Me.rdbRep = New System.Windows.Forms.RadioButton()
        Me.rdbRem = New System.Windows.Forms.RadioButton()
        Me.txtReplacements = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.btnChangeDir = New System.Windows.Forms.Button()
        Me.fbDirectory = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnConfigRem = New System.Windows.Forms.Button()
        Me.btnConfigRep = New System.Windows.Forms.Button()
        Me.btnBrowseDir = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnDelHistory = New System.Windows.Forms.Button()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.txtReverse = New System.Windows.Forms.TextBox()
        Me.fswSettings = New System.IO.FileSystemWatcher()
        Me.gbSettings = New System.Windows.Forms.GroupBox()
        Me.btnConfigSfx = New System.Windows.Forms.Button()
        Me.btnConfigPfx = New System.Windows.Forms.Button()
        Me.btnConfigDel = New System.Windows.Forms.Button()
        Me.btnConfigUnlock = New System.Windows.Forms.Button()
        Me.btnRestoreDir = New System.Windows.Forms.Button()
        Me.fswWorkingDirectory = New System.IO.FileSystemWatcher()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.txtHistoryFiles2 = New System.Windows.Forms.TextBox()
        Me.txtHistoryItems2 = New System.Windows.Forms.TextBox()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mniFileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSettingsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mniSettingsFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniReplaceWithFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniUnlockFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDeleteFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniPrefixFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSuffixFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mniProgramDir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniHelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniArguments = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mniVisitWebsite = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mniEULA = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mniCredits = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtLanguage = New System.Windows.Forms.TextBox()
        Me.txtUnlocking = New System.Windows.Forms.TextBox()
        Me.txtDeletion = New System.Windows.Forms.TextBox()
        Me.txtSuffix = New System.Windows.Forms.TextBox()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.gbMisc = New System.Windows.Forms.GroupBox()
        Me.Tips = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtSingleStringText = New System.Windows.Forms.TextBox()
        Me.rdbSingleString = New System.Windows.Forms.RadioButton()
        Me.gbWorkWith.SuspendLayout()
        Me.gbDo.SuspendLayout()
        CType(Me.fswSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSettings.SuspendLayout()
        CType(Me.fswWorkingDirectory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMain.SuspendLayout()
        Me.gbMisc.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFileNames
        '
        Me.txtFileNames.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileNames.Location = New System.Drawing.Point(506, 59)
        Me.txtFileNames.Multiline = True
        Me.txtFileNames.Name = "txtFileNames"
        Me.txtFileNames.ReadOnly = True
        Me.txtFileNames.Size = New System.Drawing.Size(0, 21)
        Me.txtFileNames.TabIndex = 0
        '
        'txtSettings
        '
        Me.txtSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSettings.Location = New System.Drawing.Point(11, 53)
        Me.txtSettings.Multiline = True
        Me.txtSettings.Name = "txtSettings"
        Me.txtSettings.ReadOnly = True
        Me.txtSettings.Size = New System.Drawing.Size(286, 0)
        Me.txtSettings.TabIndex = 1
        '
        'btnRename
        '
        Me.btnRename.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRename.Location = New System.Drawing.Point(183, 339)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(142, 23)
        Me.btnRename.TabIndex = 2
        Me.btnRename.Text = "&Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'btnDirectory
        '
        Me.btnDirectory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDirectory.Location = New System.Drawing.Point(9, 313)
        Me.btnDirectory.Name = "btnDirectory"
        Me.btnDirectory.Size = New System.Drawing.Size(316, 23)
        Me.btnDirectory.TabIndex = 3
        Me.btnDirectory.Text = "Go to the Program's &Directory"
        Me.btnDirectory.UseVisualStyleBackColor = True
        '
        'rdbFile
        '
        Me.rdbFile.AutoSize = True
        Me.rdbFile.Location = New System.Drawing.Point(19, 28)
        Me.rdbFile.Name = "rdbFile"
        Me.rdbFile.Size = New System.Drawing.Size(46, 17)
        Me.rdbFile.TabIndex = 4
        Me.rdbFile.TabStop = True
        Me.rdbFile.Text = "File&s"
        Me.rdbFile.UseVisualStyleBackColor = True
        '
        'rdbFolder
        '
        Me.rdbFolder.AutoSize = True
        Me.rdbFolder.Location = New System.Drawing.Point(19, 58)
        Me.rdbFolder.Name = "rdbFolder"
        Me.rdbFolder.Size = New System.Drawing.Size(59, 17)
        Me.rdbFolder.TabIndex = 5
        Me.rdbFolder.TabStop = True
        Me.rdbFolder.Text = "F&olders"
        Me.rdbFolder.UseVisualStyleBackColor = True
        '
        'gbWorkWith
        '
        Me.gbWorkWith.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbWorkWith.Controls.Add(Me.rdbFile)
        Me.gbWorkWith.Controls.Add(Me.rdbFolder)
        Me.gbWorkWith.Location = New System.Drawing.Point(9, 86)
        Me.gbWorkWith.Name = "gbWorkWith"
        Me.gbWorkWith.Size = New System.Drawing.Size(141, 113)
        Me.gbWorkWith.TabIndex = 6
        Me.gbWorkWith.TabStop = False
        Me.gbWorkWith.Text = "Work with:"
        '
        'gbDo
        '
        Me.gbDo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbDo.Controls.Add(Me.txtSingleStringText)
        Me.gbDo.Controls.Add(Me.rdbSingleString)
        Me.gbDo.Controls.Add(Me.txtSuffixText)
        Me.gbDo.Controls.Add(Me.txtPrefixText)
        Me.gbDo.Controls.Add(Me.rdbSuffix)
        Me.gbDo.Controls.Add(Me.rdbPrefix)
        Me.gbDo.Controls.Add(Me.rdbDelete)
        Me.gbDo.Controls.Add(Me.rdbUnlock)
        Me.gbDo.Controls.Add(Me.rdbCapitalizeAllWords)
        Me.gbDo.Controls.Add(Me.rdbCapitalize1stWord)
        Me.gbDo.Controls.Add(Me.rdbRep)
        Me.gbDo.Controls.Add(Me.rdbRem)
        Me.gbDo.Location = New System.Drawing.Point(156, 86)
        Me.gbDo.Name = "gbDo"
        Me.gbDo.Size = New System.Drawing.Size(169, 221)
        Me.gbDo.TabIndex = 6
        Me.gbDo.TabStop = False
        Me.gbDo.Text = "Do:"
        '
        'txtSuffixText
        '
        Me.txtSuffixText.Enabled = False
        Me.txtSuffixText.Location = New System.Drawing.Point(82, 174)
        Me.txtSuffixText.Name = "txtSuffixText"
        Me.txtSuffixText.Size = New System.Drawing.Size(81, 20)
        Me.txtSuffixText.TabIndex = 9
        '
        'txtPrefixText
        '
        Me.txtPrefixText.Enabled = False
        Me.txtPrefixText.Location = New System.Drawing.Point(82, 150)
        Me.txtPrefixText.Name = "txtPrefixText"
        Me.txtPrefixText.Size = New System.Drawing.Size(81, 20)
        Me.txtPrefixText.TabIndex = 8
        '
        'rdbSuffix
        '
        Me.rdbSuffix.AutoSize = True
        Me.rdbSuffix.Location = New System.Drawing.Point(11, 175)
        Me.rdbSuffix.Name = "rdbSuffix"
        Me.rdbSuffix.Size = New System.Drawing.Size(51, 17)
        Me.rdbSuffix.TabIndex = 7
        Me.rdbSuffix.TabStop = True
        Me.rdbSuffix.Text = "Suffix"
        Me.rdbSuffix.UseVisualStyleBackColor = True
        '
        'rdbPrefix
        '
        Me.rdbPrefix.AutoSize = True
        Me.rdbPrefix.Location = New System.Drawing.Point(11, 152)
        Me.rdbPrefix.Name = "rdbPrefix"
        Me.rdbPrefix.Size = New System.Drawing.Size(51, 17)
        Me.rdbPrefix.TabIndex = 6
        Me.rdbPrefix.TabStop = True
        Me.rdbPrefix.Text = "Prefix"
        Me.rdbPrefix.UseVisualStyleBackColor = True
        '
        'rdbDelete
        '
        Me.rdbDelete.AutoSize = True
        Me.rdbDelete.Location = New System.Drawing.Point(11, 129)
        Me.rdbDelete.Name = "rdbDelete"
        Me.rdbDelete.Size = New System.Drawing.Size(56, 17)
        Me.rdbDelete.TabIndex = 5
        Me.rdbDelete.TabStop = True
        Me.rdbDelete.Text = "Delete"
        Me.rdbDelete.UseVisualStyleBackColor = True
        '
        'rdbUnlock
        '
        Me.rdbUnlock.AutoSize = True
        Me.rdbUnlock.Location = New System.Drawing.Point(11, 106)
        Me.rdbUnlock.Name = "rdbUnlock"
        Me.rdbUnlock.Size = New System.Drawing.Size(59, 17)
        Me.rdbUnlock.TabIndex = 4
        Me.rdbUnlock.TabStop = True
        Me.rdbUnlock.Text = "Unlock"
        Me.rdbUnlock.UseVisualStyleBackColor = True
        '
        'rdbCapitalizeAllWords
        '
        Me.rdbCapitalizeAllWords.AutoSize = True
        Me.rdbCapitalizeAllWords.Location = New System.Drawing.Point(11, 83)
        Me.rdbCapitalizeAllWords.Name = "rdbCapitalizeAllWords"
        Me.rdbCapitalizeAllWords.Size = New System.Drawing.Size(118, 17)
        Me.rdbCapitalizeAllWords.TabIndex = 3
        Me.rdbCapitalizeAllWords.TabStop = True
        Me.rdbCapitalizeAllWords.Text = "Capitalize All Words"
        Me.rdbCapitalizeAllWords.UseVisualStyleBackColor = True
        '
        'rdbCapitalize1stWord
        '
        Me.rdbCapitalize1stWord.AutoSize = True
        Me.rdbCapitalize1stWord.Location = New System.Drawing.Point(11, 60)
        Me.rdbCapitalize1stWord.Name = "rdbCapitalize1stWord"
        Me.rdbCapitalize1stWord.Size = New System.Drawing.Size(113, 17)
        Me.rdbCapitalize1stWord.TabIndex = 2
        Me.rdbCapitalize1stWord.TabStop = True
        Me.rdbCapitalize1stWord.Text = "Capitalize 1st word"
        Me.rdbCapitalize1stWord.UseVisualStyleBackColor = True
        '
        'rdbRep
        '
        Me.rdbRep.AutoSize = True
        Me.rdbRep.Location = New System.Drawing.Point(11, 37)
        Me.rdbRep.Name = "rdbRep"
        Me.rdbRep.Size = New System.Drawing.Size(65, 17)
        Me.rdbRep.TabIndex = 1
        Me.rdbRep.TabStop = True
        Me.rdbRep.Text = "Replace"
        Me.rdbRep.UseVisualStyleBackColor = True
        '
        'rdbRem
        '
        Me.rdbRem.AutoSize = True
        Me.rdbRem.Location = New System.Drawing.Point(11, 14)
        Me.rdbRem.Name = "rdbRem"
        Me.rdbRem.Size = New System.Drawing.Size(65, 17)
        Me.rdbRem.TabIndex = 0
        Me.rdbRem.TabStop = True
        Me.rdbRem.Text = "Remove"
        Me.rdbRem.UseVisualStyleBackColor = True
        '
        'txtReplacements
        '
        Me.txtReplacements.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtReplacements.Location = New System.Drawing.Point(331, 339)
        Me.txtReplacements.Multiline = True
        Me.txtReplacements.Name = "txtReplacements"
        Me.txtReplacements.ReadOnly = True
        Me.txtReplacements.Size = New System.Drawing.Size(169, 0)
        Me.txtReplacements.TabIndex = 7
        '
        'txtDir
        '
        Me.txtDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDir.Location = New System.Drawing.Point(9, 30)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(490, 20)
        Me.txtDir.TabIndex = 8
        '
        'btnChangeDir
        '
        Me.btnChangeDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnChangeDir.Location = New System.Drawing.Point(8, 57)
        Me.btnChangeDir.Name = "btnChangeDir"
        Me.btnChangeDir.Size = New System.Drawing.Size(133, 23)
        Me.btnChangeDir.TabIndex = 9
        Me.btnChangeDir.Text = "&Change Directory"
        Me.btnChangeDir.UseVisualStyleBackColor = True
        '
        'btnConfigRem
        '
        Me.btnConfigRem.Location = New System.Drawing.Point(15, 27)
        Me.btnConfigRem.Name = "btnConfigRem"
        Me.btnConfigRem.Size = New System.Drawing.Size(141, 23)
        Me.btnConfigRem.TabIndex = 11
        Me.btnConfigRem.Text = "Filters for 'Re&move'"
        Me.btnConfigRem.UseVisualStyleBackColor = True
        '
        'btnConfigRep
        '
        Me.btnConfigRep.Location = New System.Drawing.Point(15, 56)
        Me.btnConfigRep.Name = "btnConfigRep"
        Me.btnConfigRep.Size = New System.Drawing.Size(141, 23)
        Me.btnConfigRep.TabIndex = 12
        Me.btnConfigRep.Text = "Filters for 'Re&place'"
        Me.btnConfigRep.UseVisualStyleBackColor = True
        '
        'btnBrowseDir
        '
        Me.btnBrowseDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseDir.Location = New System.Drawing.Point(158, 57)
        Me.btnBrowseDir.Name = "btnBrowseDir"
        Me.btnBrowseDir.Size = New System.Drawing.Size(167, 23)
        Me.btnBrowseDir.TabIndex = 13
        Me.btnBrowseDir.Text = "&Go to Directory"
        Me.btnBrowseDir.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(6, 63)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(126, 23)
        Me.btnReload.TabIndex = 14
        Me.btnReload.Text = "Re&load"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'btnDelHistory
        '
        Me.btnDelHistory.Location = New System.Drawing.Point(6, 28)
        Me.btnDelHistory.Name = "btnDelHistory"
        Me.btnDelHistory.Size = New System.Drawing.Size(126, 23)
        Me.btnDelHistory.TabIndex = 16
        Me.btnDelHistory.Text = "Delete Histor&y"
        Me.btnDelHistory.UseVisualStyleBackColor = True
        '
        'btnReverse
        '
        Me.btnReverse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReverse.Location = New System.Drawing.Point(9, 339)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(168, 23)
        Me.btnReverse.TabIndex = 18
        Me.btnReverse.Text = "Re&verse/Unrename"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'txtReverse
        '
        Me.txtReverse.Location = New System.Drawing.Point(0, 0)
        Me.txtReverse.Multiline = True
        Me.txtReverse.Name = "txtReverse"
        Me.txtReverse.Size = New System.Drawing.Size(10, 10)
        Me.txtReverse.TabIndex = 19
        Me.txtReverse.Visible = False
        '
        'fswSettings
        '
        Me.fswSettings.EnableRaisingEvents = True
        Me.fswSettings.SynchronizingObject = Me
        '
        'gbSettings
        '
        Me.gbSettings.Controls.Add(Me.btnConfigSfx)
        Me.gbSettings.Controls.Add(Me.btnConfigPfx)
        Me.gbSettings.Controls.Add(Me.btnConfigDel)
        Me.gbSettings.Controls.Add(Me.btnConfigUnlock)
        Me.gbSettings.Controls.Add(Me.btnConfigRem)
        Me.gbSettings.Controls.Add(Me.btnConfigRep)
        Me.gbSettings.Location = New System.Drawing.Point(331, 84)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Size = New System.Drawing.Size(169, 223)
        Me.gbSettings.TabIndex = 20
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "Settings:"
        '
        'btnConfigSfx
        '
        Me.btnConfigSfx.Location = New System.Drawing.Point(15, 172)
        Me.btnConfigSfx.Name = "btnConfigSfx"
        Me.btnConfigSfx.Size = New System.Drawing.Size(141, 23)
        Me.btnConfigSfx.TabIndex = 21
        Me.btnConfigSfx.Text = "Filters for 'Suf&fix'"
        Me.btnConfigSfx.UseVisualStyleBackColor = True
        '
        'btnConfigPfx
        '
        Me.btnConfigPfx.Location = New System.Drawing.Point(15, 143)
        Me.btnConfigPfx.Name = "btnConfigPfx"
        Me.btnConfigPfx.Size = New System.Drawing.Size(141, 23)
        Me.btnConfigPfx.TabIndex = 20
        Me.btnConfigPfx.Text = "Filters for 'Pref&ix'"
        Me.btnConfigPfx.UseVisualStyleBackColor = True
        '
        'btnConfigDel
        '
        Me.btnConfigDel.Location = New System.Drawing.Point(15, 114)
        Me.btnConfigDel.Name = "btnConfigDel"
        Me.btnConfigDel.Size = New System.Drawing.Size(141, 23)
        Me.btnConfigDel.TabIndex = 19
        Me.btnConfigDel.Text = "Filters for '&De&letion'"
        Me.btnConfigDel.UseVisualStyleBackColor = True
        '
        'btnConfigUnlock
        '
        Me.btnConfigUnlock.Location = New System.Drawing.Point(15, 85)
        Me.btnConfigUnlock.Name = "btnConfigUnlock"
        Me.btnConfigUnlock.Size = New System.Drawing.Size(141, 23)
        Me.btnConfigUnlock.TabIndex = 18
        Me.btnConfigUnlock.Text = "Filters for '&Unlock'"
        Me.btnConfigUnlock.UseVisualStyleBackColor = True
        '
        'btnRestoreDir
        '
        Me.btnRestoreDir.Location = New System.Drawing.Point(331, 57)
        Me.btnRestoreDir.Name = "btnRestoreDir"
        Me.btnRestoreDir.Size = New System.Drawing.Size(168, 23)
        Me.btnRestoreDir.TabIndex = 17
        Me.btnRestoreDir.Text = "R&estore Directory"
        Me.btnRestoreDir.UseVisualStyleBackColor = True
        '
        'fswWorkingDirectory
        '
        Me.fswWorkingDirectory.EnableRaisingEvents = True
        Me.fswWorkingDirectory.SynchronizingObject = Me
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(346, 339)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 23)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "&E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(8, 0)
        Me.txtTemp.Multiline = True
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(10, 10)
        Me.txtTemp.TabIndex = 22
        Me.txtTemp.Visible = False
        '
        'txtHistoryFiles2
        '
        Me.txtHistoryFiles2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHistoryFiles2.Location = New System.Drawing.Point(506, 279)
        Me.txtHistoryFiles2.Multiline = True
        Me.txtHistoryFiles2.Name = "txtHistoryFiles2"
        Me.txtHistoryFiles2.ReadOnly = True
        Me.txtHistoryFiles2.Size = New System.Drawing.Size(0, 21)
        Me.txtHistoryFiles2.TabIndex = 23
        '
        'txtHistoryItems2
        '
        Me.txtHistoryItems2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHistoryItems2.Location = New System.Drawing.Point(506, 521)
        Me.txtHistoryItems2.Multiline = True
        Me.txtHistoryItems2.Name = "txtHistoryItems2"
        Me.txtHistoryItems2.ReadOnly = True
        Me.txtHistoryItems2.Size = New System.Drawing.Size(0, 21)
        Me.txtHistoryItems2.TabIndex = 24
        '
        'mnuMain
        '
        Me.mnuMain.BackColor = System.Drawing.Color.Transparent
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniFileMenu, Me.mniSettingsMenu, Me.mniHelpMenu})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(509, 24)
        Me.mnuMain.TabIndex = 25
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mniFileMenu
        '
        Me.mniFileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniExit})
        Me.mniFileMenu.Name = "mniFileMenu"
        Me.mniFileMenu.Size = New System.Drawing.Size(37, 20)
        Me.mniFileMenu.Text = "&File"
        '
        'mniExit
        '
        Me.mniExit.Name = "mniExit"
        Me.mniExit.Size = New System.Drawing.Size(92, 22)
        Me.mniExit.Text = "E&xit"
        '
        'mniSettingsMenu
        '
        Me.mniSettingsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniSettings, Me.ToolStripMenuItem4, Me.mniSettingsFile, Me.mniReplaceWithFile, Me.mniUnlockFile, Me.mniDeleteFile, Me.mniPrefixFile, Me.mniSuffixFile, Me.ToolStripMenuItem3, Me.mniProgramDir})
        Me.mniSettingsMenu.Name = "mniSettingsMenu"
        Me.mniSettingsMenu.Size = New System.Drawing.Size(61, 20)
        Me.mniSettingsMenu.Text = "Set&tings"
        '
        'mniSettings
        '
        Me.mniSettings.Name = "mniSettings"
        Me.mniSettings.Size = New System.Drawing.Size(179, 22)
        Me.mniSettings.Text = "&Settings"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(176, 6)
        '
        'mniSettingsFile
        '
        Me.mniSettingsFile.Name = "mniSettingsFile"
        Me.mniSettingsFile.Size = New System.Drawing.Size(179, 22)
        Me.mniSettingsFile.Text = "Settings &File"
        '
        'mniReplaceWithFile
        '
        Me.mniReplaceWithFile.Name = "mniReplaceWithFile"
        Me.mniReplaceWithFile.Size = New System.Drawing.Size(179, 22)
        Me.mniReplaceWithFile.Text = "&Replace With File"
        '
        'mniUnlockFile
        '
        Me.mniUnlockFile.Name = "mniUnlockFile"
        Me.mniUnlockFile.Size = New System.Drawing.Size(179, 22)
        Me.mniUnlockFile.Text = "&Unlock File"
        '
        'mniDeleteFile
        '
        Me.mniDeleteFile.Name = "mniDeleteFile"
        Me.mniDeleteFile.Size = New System.Drawing.Size(179, 22)
        Me.mniDeleteFile.Text = "De&lete File"
        '
        'mniPrefixFile
        '
        Me.mniPrefixFile.Name = "mniPrefixFile"
        Me.mniPrefixFile.Size = New System.Drawing.Size(179, 22)
        Me.mniPrefixFile.Text = "&Prefix File"
        '
        'mniSuffixFile
        '
        Me.mniSuffixFile.Name = "mniSuffixFile"
        Me.mniSuffixFile.Size = New System.Drawing.Size(179, 22)
        Me.mniSuffixFile.Text = "&Suffix File"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(176, 6)
        '
        'mniProgramDir
        '
        Me.mniProgramDir.Name = "mniProgramDir"
        Me.mniProgramDir.Size = New System.Drawing.Size(179, 22)
        Me.mniProgramDir.Text = "Program's &Directory"
        '
        'mniHelpMenu
        '
        Me.mniHelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniArguments, Me.ToolStripMenuItem1, Me.mniVisitWebsite, Me.ToolStripMenuItem2, Me.mniEULA, Me.ToolStripMenuItem5, Me.mniCredits, Me.mniAbout})
        Me.mniHelpMenu.Name = "mniHelpMenu"
        Me.mniHelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.mniHelpMenu.Text = "&Help"
        '
        'mniArguments
        '
        Me.mniArguments.Name = "mniArguments"
        Me.mniArguments.Size = New System.Drawing.Size(141, 22)
        Me.mniArguments.Text = "&Arguements"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(138, 6)
        '
        'mniVisitWebsite
        '
        Me.mniVisitWebsite.Name = "mniVisitWebsite"
        Me.mniVisitWebsite.Size = New System.Drawing.Size(141, 22)
        Me.mniVisitWebsite.Text = "&Visit Website"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(138, 6)
        '
        'mniEULA
        '
        Me.mniEULA.Name = "mniEULA"
        Me.mniEULA.Size = New System.Drawing.Size(141, 22)
        Me.mniEULA.Text = "EULA"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(138, 6)
        '
        'mniCredits
        '
        Me.mniCredits.Name = "mniCredits"
        Me.mniCredits.Size = New System.Drawing.Size(141, 22)
        Me.mniCredits.Text = "&Credits"
        '
        'mniAbout
        '
        Me.mniAbout.Name = "mniAbout"
        Me.mniAbout.Size = New System.Drawing.Size(141, 22)
        Me.mniAbout.Text = "&About"
        '
        'txtLanguage
        '
        Me.txtLanguage.Location = New System.Drawing.Point(-7, 0)
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.Size = New System.Drawing.Size(17, 20)
        Me.txtLanguage.TabIndex = 26
        Me.txtLanguage.Visible = False
        '
        'txtUnlocking
        '
        Me.txtUnlocking.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnlocking.Location = New System.Drawing.Point(331, 450)
        Me.txtUnlocking.Multiline = True
        Me.txtUnlocking.Name = "txtUnlocking"
        Me.txtUnlocking.ReadOnly = True
        Me.txtUnlocking.Size = New System.Drawing.Size(169, 59)
        Me.txtUnlocking.TabIndex = 27
        '
        'txtDeletion
        '
        Me.txtDeletion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDeletion.Location = New System.Drawing.Point(309, 627)
        Me.txtDeletion.Multiline = True
        Me.txtDeletion.Name = "txtDeletion"
        Me.txtDeletion.ReadOnly = True
        Me.txtDeletion.Size = New System.Drawing.Size(191, 59)
        Me.txtDeletion.TabIndex = 28
        '
        'txtSuffix
        '
        Me.txtSuffix.Location = New System.Drawing.Point(238, 0)
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.Size = New System.Drawing.Size(10, 20)
        Me.txtSuffix.TabIndex = 29
        Me.txtSuffix.Visible = False
        '
        'txtPrefix
        '
        Me.txtPrefix.Location = New System.Drawing.Point(222, 0)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(10, 20)
        Me.txtPrefix.TabIndex = 30
        Me.txtPrefix.Visible = False
        '
        'gbMisc
        '
        Me.gbMisc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbMisc.Controls.Add(Me.btnDelHistory)
        Me.gbMisc.Controls.Add(Me.btnReload)
        Me.gbMisc.Location = New System.Drawing.Point(12, 205)
        Me.gbMisc.Name = "gbMisc"
        Me.gbMisc.Size = New System.Drawing.Size(138, 102)
        Me.gbMisc.TabIndex = 31
        Me.gbMisc.TabStop = False
        Me.gbMisc.Text = "Misc"
        '
        'Tips
        '
        Me.Tips.AutoPopDelay = 15000
        Me.Tips.InitialDelay = 300
        Me.Tips.ReshowDelay = 100
        Me.Tips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'txtSingleStringText
        '
        Me.txtSingleStringText.Enabled = False
        Me.txtSingleStringText.Location = New System.Drawing.Point(82, 197)
        Me.txtSingleStringText.Name = "txtSingleStringText"
        Me.txtSingleStringText.Size = New System.Drawing.Size(81, 20)
        Me.txtSingleStringText.TabIndex = 11
        '
        'rdbSingleString
        '
        Me.rdbSingleString.AutoSize = True
        Me.rdbSingleString.Location = New System.Drawing.Point(11, 197)
        Me.rdbSingleString.Name = "rdbSingleString"
        Me.rdbSingleString.Size = New System.Drawing.Size(61, 17)
        Me.rdbSingleString.TabIndex = 10
        Me.rdbSingleString.TabStop = True
        Me.rdbSingleString.Text = "1 String"
        Me.rdbSingleString.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnRename
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(509, 374)
        Me.Controls.Add(Me.gbMisc)
        Me.Controls.Add(Me.txtPrefix)
        Me.Controls.Add(Me.txtSuffix)
        Me.Controls.Add(Me.btnDirectory)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnRestoreDir)
        Me.Controls.Add(Me.txtDeletion)
        Me.Controls.Add(Me.txtUnlocking)
        Me.Controls.Add(Me.txtLanguage)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.mnuMain)
        Me.Controls.Add(Me.txtHistoryItems2)
        Me.Controls.Add(Me.txtHistoryFiles2)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbSettings)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.btnBrowseDir)
        Me.Controls.Add(Me.btnChangeDir)
        Me.Controls.Add(Me.txtReplacements)
        Me.Controls.Add(Me.gbDo)
        Me.Controls.Add(Me.gbWorkWith)
        Me.Controls.Add(Me.txtSettings)
        Me.Controls.Add(Me.txtFileNames)
        Me.Controls.Add(Me.txtReverse)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "File/Folder Mass Renamer"
        Me.TopMost = True
        Me.gbWorkWith.ResumeLayout(False)
        Me.gbWorkWith.PerformLayout()
        Me.gbDo.ResumeLayout(False)
        Me.gbDo.PerformLayout()
        CType(Me.fswSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSettings.ResumeLayout(False)
        CType(Me.fswWorkingDirectory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.gbMisc.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFileNames As System.Windows.Forms.TextBox
    Friend WithEvents txtSettings As System.Windows.Forms.TextBox
    Friend WithEvents btnRename As System.Windows.Forms.Button
    Friend WithEvents btnDirectory As System.Windows.Forms.Button
    Friend WithEvents gbDo As System.Windows.Forms.GroupBox
    Friend WithEvents rdbRep As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRem As System.Windows.Forms.RadioButton
    Friend WithEvents gbWorkWith As System.Windows.Forms.GroupBox
    Friend WithEvents rdbFile As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFolder As System.Windows.Forms.RadioButton
    Friend WithEvents txtReplacements As System.Windows.Forms.TextBox
    Friend WithEvents btnChangeDir As System.Windows.Forms.Button
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents rdbCapitalize1stWord As System.Windows.Forms.RadioButton
    Friend WithEvents fbDirectory As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnConfigRep As System.Windows.Forms.Button
    Friend WithEvents btnConfigRem As System.Windows.Forms.Button
    Friend WithEvents btnBrowseDir As System.Windows.Forms.Button
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents btnDelHistory As System.Windows.Forms.Button
    Friend WithEvents btnReverse As System.Windows.Forms.Button
    Friend WithEvents txtReverse As System.Windows.Forms.TextBox
    Friend WithEvents fswSettings As System.IO.FileSystemWatcher
    Friend WithEvents gbSettings As System.Windows.Forms.GroupBox
    Friend WithEvents fswWorkingDirectory As System.IO.FileSystemWatcher
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRestoreDir As System.Windows.Forms.Button
    Friend WithEvents txtTemp As System.Windows.Forms.TextBox
    Friend WithEvents txtHistoryFiles2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHistoryItems2 As System.Windows.Forms.TextBox
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mniFileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniHelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniCredits As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniArguments As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mniSettingsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtLanguage As System.Windows.Forms.TextBox
    Friend WithEvents mniSettingsFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniReplaceWithFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniProgramDir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniVisitWebsite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents rdbDelete As System.Windows.Forms.RadioButton
    Friend WithEvents rdbUnlock As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCapitalizeAllWords As System.Windows.Forms.RadioButton
    Friend WithEvents btnConfigDel As System.Windows.Forms.Button
    Friend WithEvents btnConfigUnlock As System.Windows.Forms.Button
    Friend WithEvents txtDeletion As System.Windows.Forms.TextBox
    Friend WithEvents txtUnlocking As System.Windows.Forms.TextBox
    Friend WithEvents txtSuffixText As System.Windows.Forms.TextBox
    Friend WithEvents txtPrefixText As System.Windows.Forms.TextBox
    Friend WithEvents rdbSuffix As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPrefix As System.Windows.Forms.RadioButton
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents txtSuffix As System.Windows.Forms.TextBox
    Friend WithEvents btnConfigSfx As System.Windows.Forms.Button
    Friend WithEvents btnConfigPfx As System.Windows.Forms.Button
    Friend WithEvents gbMisc As System.Windows.Forms.GroupBox
    Friend WithEvents Tips As System.Windows.Forms.ToolTip
    Friend WithEvents mniUnlockFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniDeleteFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniPrefixFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniSuffixFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniEULA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtSingleStringText As TextBox
    Friend WithEvents rdbSingleString As RadioButton
End Class
