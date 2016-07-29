Imports System.IO

Module modReload
    Dim TextRead As System.IO.TextReader
    Dim TextWrite As System.IO.TextWriter

    Public isReloading As Boolean = False

    Public Sub GetFilesFolders(ByVal Path As String, ByVal frm As frmMain)
        With frm
            If WorkingWith.ToLower = "file" Then
                .txtFileNames.Lines = System.IO.Directory.GetFiles(Path)
            ElseIf WorkingWith.ToLower = "folder" Then
                .txtFileNames.Lines = System.IO.Directory.GetDirectories(Path)
            End If
        End With

    End Sub

    Sub Reload(ByVal frm As frmMain)
        With frm
            isReloading = True

            ReadToTextbox(strSettingsIni, .txtSettings)  'Loading Settings

            Call doCountRemRepetition(frm)

            .SettingsArray = .txtSettings.Lines 'Load Settings Array

            If .txtSettings.Lines(0).Length > 4 Then 'If there is a directory to load
                .SettingsArray(0) = doResolveWildNames(.SettingsArray(0))   'Resolve %STH%
                .SettingsArray(0) = doProperPathName(.SettingsArray(0))   'Make it proper
                .txtSettings.Lines = .SettingsArray                         'And load it to txtSettings
            End If

            If Directory.Exists(.txtSettings.Lines(0).Substring(4)) Then    'If it exists, load path
                .txtDir.Text = .txtSettings.Lines(0).Substring(4)
            Else                                                            'Else put the default
                Directory.CreateDirectory(strTestDir)
                .txtDir.Text = strTestDir
                .SettingsArray(0) = "DIR:" & .txtDir.Text
                .txtSettings.Lines = .SettingsArray
                TextWrite = File.CreateText(strSettingsIni)
                TextWrite.Write(.txtSettings.Text)
                TextWrite.Flush()
                TextWrite.Close()
            End If

            Call doCountRepRepetition(frm)

            Call doCountUlkRepetition(frm)

            Call doCountDelRepetition(frm)

            Call doCountPFXRepetition(frm)

            Call doCountSFXRepetition(frm)

            If .txtSettings.Lines(1).Substring(4).ToLower = "file" Then
                .rdbFile.Checked = True
                WorkingWith = "file"
            ElseIf .txtSettings.Lines(1).Substring(4).ToLower = "folder" Then
                .rdbFolder.Checked = True
                WorkingWith = "folder"
            Else
                MsgBox(.txtLanguage.Lines(58)) 'The settings file has been tampered with
            End If
            GetFilesFolders(.txtDir.Text, frm) 'This is needed because on reloading it isnt automated by the rdb.Checked

            If .txtSettings.Lines(2).Substring(4).ToLower = "rem" Or .txtSettings.Lines(2).Substring(4).ToLower = "remove" Then
                .rdbRem.Checked = True
                .btnRename.Text = .txtLanguage.Lines(20)

            ElseIf .txtSettings.Lines(2).Substring(4).ToLower = "rep" Or .txtSettings.Lines(2).Substring(4).ToLower = "replace" Then
                .rdbRep.Checked = True
                .btnRename.Text = .txtLanguage.Lines(20)

            ElseIf .txtSettings.Lines(2).Substring(4).ToLower = "cap" Or .txtSettings.Lines(2).Substring(4).ToLower = "capitalize" Then
                .rdbCapitalize1stWord.Checked = True
                .btnRename.Text = .txtLanguage.Lines(20)

            ElseIf .txtSettings.Lines(2).Substring(4).ToLower = "caw" Or .txtSettings.Lines(2).Substring(4).ToLower = "capitalize all words" Then
                .rdbCapitalizeAllWords.Checked = True
                .btnRename.Text = .txtLanguage.Lines(20)

            ElseIf .txtSettings.Lines(2).Substring(4).ToLower = "ulk" Or .txtSettings.Lines(2).Substring(4).ToLower = "unlock" Then
                .rdbUnlock.Checked = True
                .btnRename.Text = .txtLanguage.Lines(71)

            ElseIf .txtSettings.Lines(2).Substring(4).ToLower = "del" Or .txtSettings.Lines(2).Substring(4).ToLower = "delete" Then
                .rdbDelete.Checked = True
                .btnRename.Text = .txtLanguage.Lines(72)

            ElseIf .txtSettings.Lines(2).Substring(4).ToLower = "pfx" Or .txtSettings.Lines(2).Substring(4).ToLower = "prefix" Then
                .rdbPrefix.Checked = True
                .txtPrefixText.Enabled = True
                .btnRename.Text = .txtLanguage.Lines(20)

            ElseIf .txtSettings.Lines(2).Substring(4).ToLower = "sfx" Or .txtSettings.Lines(2).Substring(4).ToLower = "suffix" Then
                .rdbSuffix.Checked = True
                .txtSuffixText.Enabled = True
                .btnRename.Text = .txtLanguage.Lines(20)

            ElseIf .txtSettings.Lines(2).Substring(4).ToLower = "1ss" Or .txtSettings.Lines(2).Substring(4).ToLower = "1singlestring" Then
                .rdbSingleString.Checked = True
                .txtSingleStringText.Enabled = True
                .btnRename.Text = .txtLanguage.Lines(20)

            Else
                MsgBox(.txtLanguage.Lines(58)) 'The settings file has been tampered with
            End If

            .txtHistoryFiles.Lines = System.IO.Directory.GetFiles(strHistoryPath)
            Call .txtHistoryFiles_TextChanged()

            .txtPrefixText.Text = My.Settings.PrefixText
            .txtSuffixText.Text = My.Settings.SuffixText

            'Dim tmpLanguageFolders As New TextBox
            'tmpLanguageFolders.Lines = Directory.GetDirectories(strLanguageFolders)
            'For i As Integer = 0 To tmpLanguageFolders.Lines.Length - 1
            '    .mniLanguage.DropDownItems.Add(tmpLanguageFolders.Lines(i).Substring(strLanguageFolders.Length))
            'Next i

            isReloading = False
        End With
    End Sub

    Public Sub doCountRemRepetition(ByVal frm As frmMain)
        With frm
            .RemRepetitionInt = 0
            For i As Integer = 0 To .txtSettings.Lines.Length - 1
                If .txtSettings.Lines(i).ToUpper.StartsWith("REM:") Then
                    .RemRepetitionInt += 1 'Finding how many REM lines exist
                End If
            Next i

            .RemRepetitionInt += 3 'Adding the indexes of settings (dir/obj/opt/LNG : 0 to 3 = 4)

        End With
    End Sub

    Public Sub doCountRepRepetition(ByVal frm As frmMain)
        With frm
            ReadToTextbox(strReplaceIni, .txtReplacements)

            .RepRepetitionInt = .txtReplacements.Lines.Length
        End With
    End Sub

    Public Sub doCountUlkRepetition(ByVal frm As frmMain)
        With frm
            ReadToTextbox(strUnlockIni, .txtUnlocking)

            .UlkRepetitionInt = .txtUnlocking.Lines.Length - 1
        End With
    End Sub

    Public Sub doCountDelRepetition(ByVal frm As frmMain)
        With frm
            ReadToTextbox(strDeleteIni, .txtDeletion)

            .DelRepetitionInt = .txtDeletion.Lines.Length - 1
        End With
    End Sub

    Public Sub doCountPFXRepetition(ByVal frm As frmMain)
        With frm
            ReadToTextbox(strPrefixIni, .txtPrefix)

            .PFXRepetitionInt = .txtPrefix.Lines.Length - 1
        End With
    End Sub

    Public Sub doCountSFXRepetition(ByVal frm As frmMain)
        With frm
            ReadToTextbox(strSuffixIni, .txtSuffix)

            .SFXRepetitionInt = .txtSuffix.Lines.Length - 1
        End With
    End Sub

End Module
