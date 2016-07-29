Module modChangeLanguage

    Public Sub Language_Main(ByVal frm As frmMain)
        With frm
            ReadToTextbox(StrCurrentLanguageDir & frm.Name.ToString & ".txt", .txtLanguage)

            .mniFileMenu.Text = .txtLanguage.Lines(0)
            .mniExit.Text = .txtLanguage.Lines(1)
            .mniSettingsMenu.Text = .txtLanguage.Lines(2)
            .mniSettings.Text = .txtLanguage.Lines(3)
            .mniHelpMenu.Text = .txtLanguage.Lines(4)
            .mniArguments.Text = .txtLanguage.Lines(5)
            .mniCredits.Text = .txtLanguage.Lines(6)
            .mniAbout.Text = .txtLanguage.Lines(7)
            .Text = .txtLanguage.Lines(8) & " by Giannis Mamalikidis"
            .btnChangeDir.Text = .txtLanguage.Lines(9)
            .btnBrowseDir.Text = .txtLanguage.Lines(10)
            .gbWorkWith.Text = .txtLanguage.Lines(11)
            .rdbFile.Text = .txtLanguage.Lines(12)
            .rdbFolder.Text = .txtLanguage.Lines(13)
            .gbDo.Text = .txtLanguage.Lines(14)
            .rdbRem.Text = .txtLanguage.Lines(15)
            .rdbRep.Text = .txtLanguage.Lines(16)
            .rdbCapitalize1stWord.Text = .txtLanguage.Lines(17)
            .btnDirectory.Text = .txtLanguage.Lines(18)
            .btnReverse.Text = .txtLanguage.Lines(19)
            .btnRename.Text = .txtLanguage.Lines(20)
            .gbSettings.Text = .txtLanguage.Lines(21)
            .btnConfigRem.Text = .txtLanguage.Lines(22)
            .btnConfigRep.Text = .txtLanguage.Lines(23)
            .btnRestoreDir.Text = .txtLanguage.Lines(24)
            .btnDelHistory.Text = .txtLanguage.Lines(25)
            .btnReload.Text = .txtLanguage.Lines(26)
            .btnExit.Text = .txtLanguage.Lines(27)
            .mniSettingsFile.Text = .txtLanguage.Lines(38)
            .mniReplaceWithFile.Text = .txtLanguage.Lines(39)
            .mniProgramDir.Text = .txtLanguage.Lines(40)
            .mniVisitWebsite.Text = .txtLanguage.Lines(59)
            .rdbCapitalizeAllWords.Text = .txtLanguage.Lines(63)
            .rdbUnlock.Text = .txtLanguage.Lines(64)
            .rdbDelete.Text = .txtLanguage.Lines(65)
            .btnConfigUnlock.Text = .txtLanguage.Lines(66)
            .btnConfigDel.Text = .txtLanguage.Lines(67)
            .rdbPrefix.Text = .txtLanguage.Lines(83)
            .rdbSuffix.Text = .txtLanguage.Lines(84)
            .btnConfigPfx.Text = .txtLanguage.Lines(85)
            .btnConfigSfx.Text = .txtLanguage.Lines(86)
            .gbMisc.Text = .txtLanguage.Lines(87)
            .mniExit.ToolTipText = .txtLanguage.Lines(92)
            .mniSettings.ToolTipText = .txtLanguage.Lines(93)
            .mniSettingsFile.ToolTipText = .txtLanguage.Lines(94)
            .mniReplaceWithFile.ToolTipText = .txtLanguage.Lines(95)
            .mniUnlockFile.Text = .txtLanguage.Lines(96)
            .mniUnlockFile.ToolTipText = .txtLanguage.Lines(97)
            .mniDeleteFile.Text = .txtLanguage.Lines(98)
            .mniDeleteFile.ToolTipText = .txtLanguage.Lines(99)
            .mniPrefixFile.Text = .txtLanguage.Lines(100)
            .mniPrefixFile.ToolTipText = .txtLanguage.Lines(101)
            .mniSuffixFile.Text = .txtLanguage.Lines(102)
            .mniSuffixFile.ToolTipText = .txtLanguage.Lines(103)
            .mniProgramDir.ToolTipText = .txtLanguage.Lines(104)
            .mniArguments.ToolTipText = .txtLanguage.Lines(105)
            .mniVisitWebsite.ToolTipText = .txtLanguage.Lines(106)
            .mniCredits.ToolTipText = .txtLanguage.Lines(107)
            .mniAbout.ToolTipText = .txtLanguage.Lines(108)
            .Tips.ToolTipTitle = .txtLanguage.Lines(141)
            .Tips.SetToolTip(.btnChangeDir, .txtLanguage.Lines(109) & vbCrLf & .txtLanguage.Lines(110))
            .Tips.SetToolTip(.btnBrowseDir, .txtLanguage.Lines(111))
            .Tips.SetToolTip(.btnRestoreDir, .txtLanguage.Lines(112) & vbCrLf & .txtLanguage.Lines(113) & strTestDir)
            .Tips.SetToolTip(.rdbFile, .txtLanguage.Lines(114))
            .Tips.SetToolTip(.rdbFolder, .txtLanguage.Lines(115))
            .Tips.SetToolTip(.btnDelHistory, .txtLanguage.Lines(116))
            .Tips.SetToolTip(.btnReload, .txtLanguage.Lines(117) & vbCrLf & .txtLanguage.Lines(118))
            .Tips.SetToolTip(.rdbRem, .txtLanguage.Lines(119))
            .Tips.SetToolTip(.rdbRep, .txtLanguage.Lines(120))
            .Tips.SetToolTip(.rdbCapitalize1stWord, .txtLanguage.Lines(121))
            .Tips.SetToolTip(.rdbCapitalizeAllWords, .txtLanguage.Lines(122))
            .Tips.SetToolTip(.rdbUnlock, .txtLanguage.Lines(123))
            .Tips.SetToolTip(.rdbDelete, .txtLanguage.Lines(124))
            .Tips.SetToolTip(.rdbPrefix, .txtLanguage.Lines(125))
            .Tips.SetToolTip(.txtPrefixText, .txtLanguage.Lines(126))
            .Tips.SetToolTip(.rdbSuffix, .txtLanguage.Lines(127))
            .Tips.SetToolTip(.txtSuffixText, .txtLanguage.Lines(128))
            .Tips.SetToolTip(.btnConfigRem, .txtLanguage.Lines(129))
            .Tips.SetToolTip(.btnConfigRep, .txtLanguage.Lines(130))
            .Tips.SetToolTip(.btnConfigUnlock, .txtLanguage.Lines(131))
            .Tips.SetToolTip(.btnConfigDel, .txtLanguage.Lines(132))
            .Tips.SetToolTip(.btnConfigPfx, .txtLanguage.Lines(133))
            .Tips.SetToolTip(.btnConfigSfx, .txtLanguage.Lines(134))
            .Tips.SetToolTip(.btnDirectory, .txtLanguage.Lines(135))
            .Tips.SetToolTip(.btnReverse, .txtLanguage.Lines(136))
            .Tips.SetToolTip(.btnRename, .txtLanguage.Lines(137) & .gbWorkWith.Text & .txtLanguage.Lines(138) & .gbDo.Text & .txtLanguage.Lines(139))
            .Tips.SetToolTip(.btnExit, .txtLanguage.Lines(140))


        End With
    End Sub

    Public Sub Language_Settings(ByVal frm As frmSettings)
        With frm
            ReadToTextbox(StrCurrentLanguageDir & frm.Name.ToString & ".txt", .txtLanguage)

            .cbLanguage.Text = .txtLanguage.Lines(6)  'i.e. Unknown 'Applies to ALL as object.text
            .gbCommands.Text = .txtLanguage.Lines(1)
            .cmdCurrent.Text = .txtLanguage.Lines(2)
            .cmdDefault.Text = .txtLanguage.Lines(3)
            .gbGlobalSettings.Text = .txtLanguage.Lines(4)
            .lblLanguage.Text = .txtLanguage.Lines(5)

        End With
    End Sub

    Public Sub Language_Filters(ByVal frm As frmFilters)
        With frm
            ReadToTextbox(StrCurrentLanguageDir & frm.Name.ToString & ".txt", .txtLanguage)

            .Text = .txtLanguage.Lines(0)
            .btnCancel.Text = .txtLanguage.Lines(2)
            .btnSave.Text = .txtLanguage.Lines(3)
            .btnAdd.Text = .txtLanguage.Lines(10)
            .btnDelete.Text = .txtLanguage.Lines(11)
            .gbReplace.Text = .txtLanguage.Lines(12)
            .lblWith.Text = .txtLanguage.Lines(13)

        End With
    End Sub

    Public Sub Language_About(ByVal frm As frmAbout)
        With frm
            ReadToTextbox(StrCurrentLanguageDir & frm.Name.ToString & ".txt", .txtLanguage)
            ReadToTextbox(StrCurrentLanguageDir & frm.Name.ToString & "_Textbox.txt", .txtCredits)

            .lblAssemblyName.Text = .txtLanguage.Lines(1)
            .lblCompanyName.Text = .txtLanguage.Lines(2)
            .lblCopyright.Text = .txtLanguage.Lines(3)
            .lblDirectoryPath.Text = .txtLanguage.Lines(4)
            .lblProductName.Text = .txtLanguage.Lines(5)
            .lblTitle.Text = .txtLanguage.Lines(6)
            .lblVersion.Text = .txtLanguage.Lines(7)
            .lblWorkingSet.Text = .txtLanguage.Lines(8)
            .lblHash.Text = .txtLanguage.Lines(9)
            .lblUSer.Text = .txtLanguage.Lines(10)
            .lblStackTrace.Text = .txtLanguage.Lines(11)
            .Text = .txtLanguage.Lines(12)
            .cmdWidth.Text = .txtLanguage.Lines(13) '"Show Stack Trace"
            .txtCredits.Text = .txtLanguage.Lines(15) & RemMniHotLetter(frmMain.mniHelpMenu) & .txtLanguage.Lines(17) & RemMniHotLetter(frmMain.mniCredits) & .txtLanguage.Lines(16) & vbCrLf & .txtCredits.Text
            .cmdExit.Text = .txtLanguage.Lines(20)
            .lblLicense.Text = .txtLanguage.Lines(21)


        End With
    End Sub
End Module
