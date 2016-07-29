Option Strict On

Imports System.IO
Imports System.Threading.Tasks

Module modGlobal
    Public strReplaceIni As String = strSettingsPath & "ReplaceWith.ini"
    Public strUnlockIni As String = strSettingsPath & "Unlock.ini"
    Public strDeleteIni As String = strSettingsPath & "Delete.ini"
    Public strPrefixIni As String = strSettingsPath & "Prefix.ini"
    Public strSuffixIni As String = strSettingsPath & "Suffix.ini"
    Public strHistoryPath As String = My.Application.Info.DirectoryPath & "\History\"
    Public strTestDir As String = My.Application.Info.DirectoryPath & "\TestDir\"

    Public AutorunMode As String = "None"
    Public WorkingWith As String = "File"
    Public DontCloseAfterAutorun As Boolean = False
    Public SuppressMessages As Boolean = False

    Dim TextRead As System.IO.TextReader
    Dim TextWrite As System.IO.TextWriter

    Public OneTimeChangesSwarm As Integer
    Public OverallChangesSwarm As Integer

    Public Function doProperSaveRepStr(ByVal frm As frmFilters) As String
        Dim txtTemp As New TextBox

        With frm
            If .lstReplace.Items.Count > 0 Then
                For i As Integer = 0 To (.lstReplace.Items.Count - 1)
                    Dim ProperReplace As String = "REP:" & Mid(CStr(.lstReplace.Items(i)), 7, (.lstReplace.Items(i).ToString.Length - 7))
                    Dim ProperWith As String = "WTH:" & Mid(CStr(.lstWith.Items(i)), 7, (.lstWith.Items(i).ToString.Length - 7))

                    txtTemp.Text = txtTemp.Text & vbCrLf & ProperReplace & vbCrLf & ProperWith
                Next

                txtTemp.Text = txtTemp.Text.Substring(2)
            End If
        End With

        Return txtTemp.Text
    End Function

    Public Function doProperSaveRemStr(ByVal frm As frmFilters) As String
        Dim txtTemp As New TextBox

        With frm
            If .txtFilters.Lines.Length > 0 Then
                For i As Integer = 0 To (.txtFilters.Lines.Length - 1)
                    If .txtFilters.Lines(i) <> "" Then
                        Dim ProperRemove As String = "REM:" & .txtFilters.Lines(i)
                        'Creating the REM filters first, but we also need the first 3 settings, '(and a "NextLine" for it to work)
                        txtTemp.Text = txtTemp.Text & vbCrLf & ProperRemove
                    End If
                Next

                txtTemp.Text = txtTemp.Text.Substring(2) 'Removing the first VbCrLf
            End If
        End With

        '                                   Importing                   the                  first                4                Settings                                 (and the vbCrLf)
        txtTemp.Text = frmMain.txtSettings.Lines(0) & vbCrLf & frmMain.txtSettings.Lines(1) & vbCrLf & frmMain.txtSettings.Lines(2) & vbCrLf & frmMain.txtSettings.Lines(3) & vbCrLf & txtTemp.Text '(& vbCrLf)

        Return txtTemp.Text
    End Function

    Public Function doProperSaveUlkDelPfxSfxStr(ByVal frm As frmFilters, ByVal Prefix As String) As String
        Dim txtTemp As New TextBox

        With frm
            If .txtFilters.Lines.Length > 0 Then
                For i As Integer = 0 To (.txtFilters.Lines.Length - 1)
                    If .txtFilters.Lines(i) <> "" Then
                        Dim ProperText As String = Prefix & .txtFilters.Lines(i)
                        txtTemp.Text = txtTemp.Text & vbCrLf & ProperText
                    End If
                Next

                txtTemp.Text = txtTemp.Text.Substring(2) 'Removing the first VbCrLf
            End If
        End With

        Return txtTemp.Text
    End Function

    Public Function doProperRepArgument(ByVal strRep As String, ByVal strWth As String) As String
        Dim txtTemp As New TextBox

        Dim ProperReplace As String = "REP:" & strRep
        Dim ProperWith As String = "WTH:" & strWth

        txtTemp.Text = ProperReplace & vbCrLf & ProperWith

        Return txtTemp.Text
    End Function

    Public Function doProperRemArgument(ByVal strRem As String) As String
        Dim ProperRemove As String = "REM:" & strRem
        Return ProperRemove
    End Function

    Public Function doProperUlkArgument(ByVal strUlk As String) As String
        Dim ProperUnlock As String = "ULK:" & strUlk
        Return ProperUnlock
    End Function

    Public Function doProperDelArgument(ByVal strDel As String) As String
        Dim ProperDelete As String = "DEL:" & strDel
        Return ProperDelete
    End Function

    Public Function doProperPfxArgument(ByVal strPfx As String) As String
        Dim ProperPrefix As String = "PFX:" & strPfx
        Return ProperPrefix
    End Function

    Public Function doProperSfxArgument(ByVal strSfx As String) As String
        Dim ProperSuffix As String = "SFX:" & strSfx
        Return ProperSuffix
    End Function

    Public Sub doReadArguments(ByVal frm As frmMain)
        With frm

            'Dim tmpText As String = ""
            'For i As Integer = 0 To .args.Length - 1
            '    tmpText = tmpText & vbCrLf & i & ": " & .args(i)
            'Next
            'MsgBox(tmpText)

            For i As Integer = 1 To .args.Length - 1
                Select Case .args(i).ToLower

                    Case "-p", "-path", "\path", "/path"
                        If .args.Length > i + 1 Then
                            .args(i + 1) = doResolveWildNames(.args(i + 1))
                            If Directory.Exists(.args(i + 1)) Then
                                .txtDir.Text = doProperPathName(.args(i + 1))
                            Else
                                MsgBox(.txtLanguage.Lines(78) & .args(i + 1) & .txtLanguage.Lines(79) & vbCrLf & vbCrLf & .txtLanguage.Lines(80))
                                For j As Integer = 0 To .args.Length - 1
                                    .args(j) = ""
                                    AutorunMode = "None"
                                Next
                            End If
                            i += 1

                        Else
                            Exit Select
                        End If

                    Case "-f", "-file", "/file", "\file"
                        .rdbFile.Checked = True

                    Case "-d", "-folder", "/folder", "\folder", "/dir", "\dir", "-dir", "/directory", "\directory", "-directory"
                        .rdbFolder.Checked = True

                    Case "-rm", "-rem", "-remove", "/rem", "/remove", "\rem", "\remove"
                        If .args.Length > i + 2 Then
                            If .args(i + 1).ToLower = "-k" Or .args(i + 1).ToLower = "-preserve" Or .args(i + 1).ToLower = "/preserve" Or .args(i + 1).ToLower = "\preserve" Or .args(i + 1).ToLower = "-preserve" Or .args(i + 1).ToLower = "-keep" Or .args(i + 1).ToLower = "/keep" Or .args(i + 1).ToLower = "\keep" Or .args(i + 1).ToLower = "-keep" Then
                                TextWrite = File.AppendText(strSettingsIni)
                                TextWrite.Write(vbCrLf & doProperRemArgument(.args(i + 2)))
                                TextWrite.Flush()
                                TextWrite.Close()
                                AutorunMode = "Remove"
                                .rdbRem.Checked = True
                            ElseIf .args(i + 1).ToLower = "-o" Or .args(i + 1).ToLower = "-only" Or .args(i + 1).ToLower = "/only" Or .args(i + 1).ToLower = "\only" Or .args(i + 1).ToLower = "-nopreserve" Or .args(i + 1).ToLower = "\nopreserve" Or .args(i + 1).ToLower = "/nopreserve" Then
                                File.Delete(strSettingsIni)
                                TextWrite = File.CreateText(strSettingsIni)
                                TextWrite.WriteLine(.txtSettings.Lines(0))
                                TextWrite.WriteLine(.txtSettings.Lines(1))
                                TextWrite.WriteLine(.txtSettings.Lines(2))
                                TextWrite.WriteLine(.txtSettings.Lines(3))
                                'MsgBox(.args(i + 2))
                                TextWrite.Write(doProperRemArgument(.args(i + 2)))
                                'MsgBox(.args(i + 2))
                                TextWrite.Flush()
                                TextWrite.Close()
                                AutorunMode = "Remove"
                                .rdbRem.Checked = True
                            Else
                                Exit Select
                            End If
                            i += 2

                        End If

                    Case "-rp", "-rep", "-replace", "/rep", "/replace", "\rep", "\replace"
                        If .args.Length > i + 3 Then
                            If .args(i + 1).ToLower = "-k" Or .args(i + 1).ToLower = "-preserve" Or .args(i + 1).ToLower = "/preserve" Or .args(i + 1).ToLower = "\preserve" Or .args(i + 1).ToLower = "-keep" Or .args(i + 1).ToLower = "/keep" Or .args(i + 1).ToLower = "\keep" Then
                                TextWrite = File.AppendText(strReplaceIni)
                                TextWrite.Write(vbCrLf & doProperRepArgument(.args(i + 2), .args(i + 3)))
                                TextWrite.Flush()
                                TextWrite.Close()
                                AutorunMode = "Replace"
                                .rdbRep.Checked = True

                            ElseIf .args(i + 1).ToLower = "-o" Or .args(i + 1).ToLower = "-only" Or .args(i + 1).ToLower = "/only" Or .args(i + 1).ToLower = "\only" Or .args(i + 1).ToLower = "-nopreserve" Or .args(i + 1).ToLower = "\nopreserve" Or .args(i + 1).ToLower = "/nopreserve" Then
                                File.Delete(strReplaceIni)
                                TextWrite = File.CreateText(strReplaceIni)
                                TextWrite.Write(doProperRepArgument(.args(i + 2), .args(i + 3)))
                                TextWrite.Flush()
                                TextWrite.Close()
                                AutorunMode = "Replace"
                                .rdbRep.Checked = True

                            Else
                                Exit Select
                            End If
                            i += 3

                        End If

                    Case "-c", "-c1", "-cap", "/cap", "\cap", "-capitalize", "/capitalize", "\capitalize"
                        AutorunMode = "Capitalize"
                        .rdbCapitalize1stWord.Checked = True

                    Case "-ca", "-capall", "/capall", "\capall", "-capitalizeall", "/capitalizeall", "\capitalizeall"
                        AutorunMode = "CapitalizeAll"
                        .rdbCapitalizeAllWords.Checked = True

                    Case "-u", "-ulk", "-unlock", "/ulk", "/unlock", "\ulk", "\unlock"
                        If .args.Length > i + 2 Then
                            If .args(i + 1).ToLower = "-k" Or .args(i + 1).ToLower = "-preserve" Or .args(i + 1).ToLower = "/preserve" Or .args(i + 1).ToLower = "\preserve" Or .args(i + 1).ToLower = "-preserve" Or .args(i + 1).ToLower = "-keep" Or .args(i + 1).ToLower = "/keep" Or .args(i + 1).ToLower = "\keep" Or .args(i + 1).ToLower = "-keep" Then
                                TextWrite = File.AppendText(strUnlockIni)
                                TextWrite.Write(vbCrLf & doProperUlkArgument(.args(i + 2)))
                                TextWrite.Flush()
                                TextWrite.Close()
                                AutorunMode = "Unlock"
                                .rdbUnlock.Checked = True

                            ElseIf .args(i + 1).ToLower = "-o" Or .args(i + 1).ToLower = "-only" Or .args(i + 1).ToLower = "/only" Or .args(i + 1).ToLower = "\only" Or .args(i + 1).ToLower = "-nopreserve" Or .args(i + 1).ToLower = "\nopreserve" Or .args(i + 1).ToLower = "/nopreserve" Then
                                File.Delete(strUnlockIni)
                                TextWrite = File.CreateText(strUnlockIni)
                                TextWrite.Write(doProperUlkArgument(.args(i + 2)))
                                TextWrite.Flush()
                                TextWrite.Close()
                                AutorunMode = "Unlock"
                                .rdbUnlock.Checked = True

                            Else
                                Exit Select
                            End If
                            i += 2

                        End If

                    Case "-dl", "-del", "-delete", "/del", "/delete", "\del", "\delete"
                        If .args.Length > i + 2 Then
                            If .args(i + 1).ToLower = "-k" Or .args(i + 1).ToLower = "-preserve" Or .args(i + 1).ToLower = "/preserve" Or .args(i + 1).ToLower = "\preserve" Or .args(i + 1).ToLower = "-preserve" Or .args(i + 1).ToLower = "-keep" Or .args(i + 1).ToLower = "/keep" Or .args(i + 1).ToLower = "\keep" Or .args(i + 1).ToLower = "-keep" Then
                                TextWrite = File.AppendText(strDeleteIni)
                                TextWrite.Write(vbCrLf & doProperDelArgument(.args(i + 2)))
                                TextWrite.Flush()
                                TextWrite.Close()
                                AutorunMode = "Delete"
                                .rdbDelete.Checked = True
                            ElseIf .args(i + 1).ToLower = "-o" Or .args(i + 1).ToLower = "-only" Or .args(i + 1).ToLower = "/only" Or .args(i + 1).ToLower = "\only" Or .args(i + 1).ToLower = "-nopreserve" Or .args(i + 1).ToLower = "\nopreserve" Or .args(i + 1).ToLower = "/nopreserve" Then
                                File.Delete(strDeleteIni)
                                TextWrite = File.CreateText(strDeleteIni)
                                TextWrite.Write(doProperDelArgument(.args(i + 2)))
                                TextWrite.Flush()
                                TextWrite.Close()
                                AutorunMode = "Delete"
                                .rdbDelete.Checked = True
                            Else
                                Exit Select
                            End If

                        End If
                        i += 2

                    Case "-pf", "-pfx", "-prefix", "/pfx", "/prefix", "\pfx", "\prefix"
                        If .args.Length > i + 3 Then
                            If .args(i + 2).ToLower = "-k" Or .args(i + 2).ToLower = "-preserve" Or .args(i + 2).ToLower = "/preserve" Or .args(i + 2).ToLower = "\preserve" Or .args(i + 2).ToLower = "-preserve" Or .args(i + 2).ToLower = "-keep" Or .args(i + 2).ToLower = "/keep" Or .args(i + 2).ToLower = "\keep" Or .args(i + 2).ToLower = "-keep" Then
                                TextWrite = File.AppendText(strPrefixIni)
                                TextWrite.Write(vbCrLf & doProperPfxArgument(.args(i + 3)))
                                TextWrite.Flush()
                                TextWrite.Close()
                                .txtPrefixText.Text = .args(i + 1)
                                My.Settings.PrefixText = .args(i + 1)
                                My.Settings.Save()
                                AutorunMode = "Prefix"
                                .rdbDelete.Checked = True
                            ElseIf .args(i + 2).ToLower = "-o" Or .args(i + 2).ToLower = "-only" Or .args(i + 2).ToLower = "/only" Or .args(i + 2).ToLower = "\only" Or .args(i + 2).ToLower = "-nopreserve" Or .args(i + 2).ToLower = "\nopreserve" Or .args(i + 2).ToLower = "/nopreserve" Then
                                File.Delete(strPrefixIni)
                                TextWrite = File.CreateText(strPrefixIni)
                                TextWrite.Write(doProperPfxArgument(.args(i + 3)))
                                TextWrite.Flush()
                                TextWrite.Close()
                                .txtPrefixText.Text = .args(i + 1)
                                My.Settings.PrefixText = .args(i + 1)
                                My.Settings.Save()
                                AutorunMode = "Prefix"
                                .rdbDelete.Checked = True
                            Else
                                Exit Select
                            End If

                        End If
                        i += 3

                    Case "-sf", "-sfx", "-suffix", "/sfx", "/suffix", "\sfx", "\suffix"
                        If .args.Length > i + 3 Then
                            If .args(i + 2).ToLower = "-k" Or .args(i + 2).ToLower = "-preserve" Or .args(i + 2).ToLower = "/preserve" Or .args(i + 2).ToLower = "\preserve" Or .args(i + 2).ToLower = "-preserve" Or .args(i + 2).ToLower = "-keep" Or .args(i + 2).ToLower = "/keep" Or .args(i + 2).ToLower = "\keep" Or .args(i + 2).ToLower = "-keep" Then
                                TextWrite = File.AppendText(strSuffixIni)
                                TextWrite.Write(vbCrLf & doProperSfxArgument(.args(i + 3)))
                                TextWrite.Flush()
                                TextWrite.Close()
                                .txtSuffixText.Text = .args(i + 1)
                                My.Settings.SuffixText = .args(i + 1)
                                My.Settings.Save()
                                AutorunMode = "Suffix"
                                .rdbDelete.Checked = True
                            ElseIf .args(i + 2).ToLower = "-o" Or .args(i + 2).ToLower = "-only" Or .args(i + 2).ToLower = "/only" Or .args(i + 2).ToLower = "\only" Or .args(i + 2).ToLower = "-nopreserve" Or .args(i + 2).ToLower = "\nopreserve" Or .args(i + 2).ToLower = "/nopreserve" Then
                                File.Delete(strSuffixIni)
                                TextWrite = File.CreateText(strSuffixIni)
                                TextWrite.Write(doProperSfxArgument(.args(i + 3)))
                                TextWrite.Flush()
                                TextWrite.Close()
                                .txtSuffixText.Text = .args(i + 1)
                                My.Settings.SuffixText = .args(i + 1)
                                My.Settings.Save()
                                AutorunMode = "Suffix"
                                .rdbDelete.Checked = True
                            Else
                                Exit Select
                            End If

                        End If
                        i += 3

                    Case "-na", "-noautorun", "/noautorun", "\noautorun", "-dontautostart", "/dontautostart", "\dontautostart"
                        AutorunMode = "None"

                    Case "-dc", "-dontclose", "/dontclose", "\dontclose", "-stay", "/stay", "\stay", "-stay", "/stay", "\stay"
                        DontCloseAfterAutorun = True

                End Select
            Next

        End With
    End Sub

    Public Async Sub AutoRunWork(ByVal frm As frmMain)
        With frm
            If AutorunMode <> "" AndAlso AutorunMode.ToLower <> "none" Then
                .btnRename.Enabled = False
                .gbDo.Enabled = False
                .gbSettings.Enabled = False
                .gbWorkWith.Enabled = False
                .btnReverse.Enabled = False
                .btnChangeDir.Enabled = False
                .txtDir.Enabled = False
                .btnExit.Enabled = False
                .mniFileMenu.Enabled = False
                .mniSettingsMenu.Enabled = False
                frm.TopMost = False
                .isRenamingThings = True

                SuppressMessages = True
                Await Task.Run(
                                Sub()
                                    If AutorunMode.ToLower = "remove" Then
                                        Call doRemove(frm)

                                    ElseIf AutorunMode.ToLower = "replace" Then
                                        Call doReplace(frm)

                                    ElseIf AutorunMode.ToLower = "capitalize" Then
                                        Call doCapitalizeFirstLetter(frm)

                                    ElseIf AutorunMode.ToLower = "capitalizeall" Then
                                        Call doCapitalizeAllWords(frm)

                                    ElseIf AutorunMode.ToLower = "unlock" Then
                                        Call doUnlock(frm)

                                    ElseIf AutorunMode.ToLower = "delete" Then
                                        Call doDelete(frm)

                                    ElseIf AutorunMode.ToLower = "prefix" Then
                                        Call doPrefix(frm)

                                    ElseIf AutorunMode.ToLower = "suffix" Then
                                        Call doSuffix(frm)

                                    End If
                                End Sub)

                SuppressMessages = False

                .txtHistoryFiles2.Text = .txtHistoryFiles.Text
                .txtHistoryItems2.Text = .txtHistoryItems.Text

                Call .txtHistoryFiles_TextChanged()
                GetFilesFolders(.txtDir.Text, frm)

                .btnRename.Enabled = True
                .gbDo.Enabled = True
                .gbSettings.Enabled = True
                .gbWorkWith.Enabled = True
                .btnReverse.Enabled = True
                .btnChangeDir.Enabled = True
                .txtDir.Enabled = True
                .btnExit.Enabled = True
                .mniFileMenu.Enabled = True
                .mniSettingsMenu.Enabled = True
                frm.TopMost = True
                .isRenamingThings = False

                If DontCloseAfterAutorun = False Then
                    Application.Exit()
                End If

            End If
        End With
    End Sub


#Region "GetSubstrAfterString String/List"

    Public Function GetSubStr(ByVal Str As String, ByVal Length As Integer, Optional ByVal LeftMidRight As String = "Left", Optional ByVal EndingIndex As Integer = -1, Optional ByVal AppendSpacesTillEndingIndex As Boolean = False) As String
        'This is used by non-module subs that do not have access to "right" and "left" functions
        Dim Result As String = Str

        If LeftMidRight.ToLower = "left" Then
            If Str.Length > Length Then
                Result = Left(Result, Length)
            End If

        ElseIf LeftMidRight.ToLower = "mid" Then
            Result = Mid(Result, Length, EndingIndex)

        ElseIf LeftMidRight.ToLower = "right" Then
            If Str.Length > Length Then
                Result = Right(Result, Length)
            End If
        End If

        If AppendSpacesTillEndingIndex AndAlso Result.Length < Length Then
            For i As Integer = Result.Length To Length
                Result &= " "
            Next
        End If

        Return Result
    End Function
    Public Function AntiSubString(ByVal str As String, ByVal Length As Integer) As String
        Try
            Return str.Substring(0, str.Length - Length)

        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Function GetSubstrAfterString(ByVal StrToBeSearched() As String, ByVal StrToGetSubstrAfter As String, Optional ByVal ResultIfStrNotFound As String = "", Optional ByVal StartsWith As Boolean = False, Optional ByVal LastIndexOfInsteadOfFirst As Boolean = False) As String
        Dim strResult As String = ResultIfStrNotFound

        For i = 0 To StrToBeSearched.Length - 1
            If StrToBeSearched(i).Contains(StrToGetSubstrAfter) Then
                Dim Index As Integer = -1

                If Not StartsWith AndAlso Not LastIndexOfInsteadOfFirst Then '                                                              Anywhere in the string, first occurance
                    Index = StrToBeSearched(i).IndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length

                ElseIf StartsWith AndAlso StrToBeSearched(i).StartsWith(StrToGetSubstrAfter) AndAlso Not LastIndexOfInsteadOfFirst Then '   Start of the string, first occurance
                    Index = StrToGetSubstrAfter.Length

                ElseIf Not StartsWith AndAlso LastIndexOfInsteadOfFirst Then '                                                              Anywhere in the string, Last occurance
                    Index = StrToBeSearched(i).LastIndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length

                ElseIf StartsWith AndAlso StrToBeSearched(i).StartsWith(StrToGetSubstrAfter) AndAlso LastIndexOfInsteadOfFirst Then '       Start of the string, Last occurance
                    Index = StrToBeSearched(i).LastIndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length
                End If

                If Index <> -1 Then
                    strResult = StrToBeSearched(i).Substring(Index)
                    Exit For
                End If
            End If
        Next

        Return strResult
    End Function
    Public Function GetSubstrAfterString(ByVal StrToBeSearched As String, ByVal StrToGetSubstrAfter As String, Optional ByVal ResultIfStrNotFound As String = "", Optional ByVal StartsWith As Boolean = False, Optional ByVal LastIndexOfInsteadOfFirst As Boolean = False) As String
        Dim strResult As String = ResultIfStrNotFound

        If StrToBeSearched.Contains(StrToGetSubstrAfter) Then
            Dim Index As Integer = -1

            If Not StartsWith AndAlso Not LastIndexOfInsteadOfFirst Then '                                                              Anywhere in the string, first occurance
                Index = StrToBeSearched.IndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length

            ElseIf StartsWith AndAlso StrToBeSearched.StartsWith(StrToGetSubstrAfter) AndAlso Not LastIndexOfInsteadOfFirst Then '   Start of the string, first occurance
                Index = StrToGetSubstrAfter.Length

            ElseIf Not StartsWith AndAlso LastIndexOfInsteadOfFirst Then '                                                              Anywhere in the string, Last occurance
                Index = StrToBeSearched.LastIndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length

            ElseIf StartsWith AndAlso StrToBeSearched.StartsWith(StrToGetSubstrAfter) AndAlso LastIndexOfInsteadOfFirst Then '       Start of the string, Last occurance
                Index = StrToBeSearched.LastIndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length
            End If

            If Index <> -1 Then strResult = StrToBeSearched.Substring(Index)
        End If

        Return strResult
    End Function
    Public Function GetMultipleSubstrAfterString(ByVal StrToBeSearched() As String, ByVal StrToGetSubstrAfter As String, Optional ByVal ResultIfStrNotFound As String = "", Optional ByVal StartsWith As Boolean = False, Optional ByVal LastIndexOfInsteadOfFirst As Boolean = False) As String()
        Dim strResult(0) As String
        strResult(0) = ResultIfStrNotFound

        For i = 0 To StrToBeSearched.Length - 1
            If StrToBeSearched(i).Contains(StrToGetSubstrAfter) Then
                Dim Index As Integer = -1

                If Not StartsWith AndAlso Not LastIndexOfInsteadOfFirst Then '                                                              Anywhere in the string, first occurance
                    Index = StrToBeSearched(i).IndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length

                ElseIf StartsWith AndAlso StrToBeSearched(i).StartsWith(StrToGetSubstrAfter) AndAlso Not LastIndexOfInsteadOfFirst Then '   Start of the string, first occurance
                    Index = StrToGetSubstrAfter.Length

                ElseIf Not StartsWith AndAlso LastIndexOfInsteadOfFirst Then '                                                              Anywhere in the string, Last occurance
                    Index = StrToBeSearched(i).LastIndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length

                ElseIf StartsWith AndAlso StrToBeSearched(i).StartsWith(StrToGetSubstrAfter) AndAlso LastIndexOfInsteadOfFirst Then '       Start of the string, Last occurance
                    Index = StrToBeSearched(i).LastIndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length
                End If

                If Index <> -1 Then
                    If strResult.Length > 1 Then ReDim Preserve strResult(strResult.Length)
                    strResult(strResult.Length - 1) = StrToBeSearched(i).Substring(Index)
                End If
            End If
        Next

        Return strResult
    End Function
    Public Function GetSubstrAfterString(ByVal LstToBeSearched As List(Of String), ByVal StrToGetSubstrAfter As String, Optional ByVal ResultIfStrNotFound As String = "", Optional ByVal StartsWith As Boolean = True, Optional ByVal LastIndexOfInsteadOfFirst As Boolean = False) As String
        Dim strResult As String = ResultIfStrNotFound

        For i As Integer = 0 To LstToBeSearched.Count - 1
            If LstToBeSearched(i).Contains(StrToGetSubstrAfter) Then
                Dim Index As Integer = -1

                If Not StartsWith AndAlso Not LastIndexOfInsteadOfFirst Then '                                                                  Anywhere in the string, first occurance
                    Index = LstToBeSearched.Item(i).IndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length

                ElseIf StartsWith AndAlso LstToBeSearched.Item(i).StartsWith(StrToGetSubstrAfter) AndAlso Not LastIndexOfInsteadOfFirst Then '  Start of the string, first occurance
                    Index = StrToGetSubstrAfter.Length

                ElseIf Not StartsWith AndAlso LastIndexOfInsteadOfFirst Then '                                                                  Anywhere in the string, Last occurance
                    Index = LstToBeSearched.Item(i).LastIndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length

                ElseIf StartsWith AndAlso LstToBeSearched.Item(i).StartsWith(StrToGetSubstrAfter) AndAlso LastIndexOfInsteadOfFirst Then '      Start of the string, Last occurance
                    Index = LstToBeSearched.Item(i).LastIndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length
                End If

                If Index <> -1 Then
                    strResult = LstToBeSearched(i).Substring(Index)
                    Exit For
                End If
            End If
        Next

        Return strResult
    End Function
    Public Function GetMultipleSubstrAfterString(ByVal LstToBeSearched As List(Of String), ByVal StrToGetSubstrAfter As String, Optional ByVal ResultIfStrNotFound As String = "", Optional ByVal StartsWith As Boolean = False, Optional ByVal LastIndexOfInsteadOfFirst As Boolean = False) As String()
        Dim strResult(0) As String
        strResult(0) = ResultIfStrNotFound

        For i = 0 To LstToBeSearched.Count - 1
            If LstToBeSearched(i).Contains(StrToGetSubstrAfter) Then
                Dim Index As Integer = -1

                If Not StartsWith AndAlso Not LastIndexOfInsteadOfFirst Then '                                                                  Anywhere in the string, first occurance
                    Index = LstToBeSearched.Item(i).IndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length

                ElseIf StartsWith AndAlso LstToBeSearched.Item(i).StartsWith(StrToGetSubstrAfter) AndAlso Not LastIndexOfInsteadOfFirst Then '  Start of the string, first occurance
                    Index = StrToGetSubstrAfter.Length

                ElseIf Not StartsWith AndAlso LastIndexOfInsteadOfFirst Then '                                                                  Anywhere in the string, Last occurance
                    Index = LstToBeSearched.Item(i).LastIndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length

                ElseIf StartsWith AndAlso LstToBeSearched.Item(i).StartsWith(StrToGetSubstrAfter) AndAlso LastIndexOfInsteadOfFirst Then '      Start of the string, Last occurance
                    Index = LstToBeSearched.Item(i).LastIndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length
                End If

                If Index <> -1 Then
                    If strResult.Length > 1 Then ReDim Preserve strResult(strResult.Length)
                    strResult(strResult.Length - 1) = LstToBeSearched(i).Substring(Index)
                End If
            End If
        Next

        Return strResult
    End Function
    Public Function GetMultipleSubstrAfterString(ByVal LstToBeSearched As List(Of String), ByVal StrToGetSubstrAfter As String, ByVal ReturnNullListOnStrNotFound As Boolean, Optional ByVal StartsWith As Boolean = False, Optional ByVal LastIndexOfInsteadOfFirst As Boolean = False) As List(Of String)
        Dim strResult As New List(Of String)
        If Not ReturnNullListOnStrNotFound Then
            strResult.Add("")
        End If

        For i = 0 To LstToBeSearched.Count - 1
            If LstToBeSearched(i).Contains(StrToGetSubstrAfter) Then
                Dim Index As Integer = -1

                If Not StartsWith AndAlso Not LastIndexOfInsteadOfFirst Then '                                                                  Anywhere in the string, first occurance
                    Index = LstToBeSearched.Item(i).IndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length

                ElseIf StartsWith AndAlso LstToBeSearched.Item(i).StartsWith(StrToGetSubstrAfter) AndAlso Not LastIndexOfInsteadOfFirst Then '  Start of the string, first occurance
                    Index = StrToGetSubstrAfter.Length

                ElseIf Not StartsWith AndAlso LastIndexOfInsteadOfFirst Then '                                                                  Anywhere in the string, Last occurance
                    Index = LstToBeSearched.Item(i).LastIndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length

                ElseIf StartsWith AndAlso LstToBeSearched.Item(i).StartsWith(StrToGetSubstrAfter) AndAlso LastIndexOfInsteadOfFirst Then '      Start of the string, Last occurance
                    Index = LstToBeSearched.Item(i).LastIndexOf(StrToGetSubstrAfter) + StrToGetSubstrAfter.Length
                End If

                If Index <> -1 Then strResult.Add(LstToBeSearched(i).Substring(Index))
            End If
        Next

        Return strResult
    End Function
#End Region


    Public Function GetExt(ByVal FilePath As String, Optional ByVal WithoutTheDot As Boolean = False) As String
        Dim Extension As String = String.Empty

        If File.Exists(FilePath) Then
            If Not WithoutTheDot Then Extension = Path.GetExtension(FilePath) Else Extension = GetSubstrAfterString(Path.GetExtension(FilePath), ".", Path.GetExtension(FilePath), True)
        End If

        Return Extension
    End Function


End Module
