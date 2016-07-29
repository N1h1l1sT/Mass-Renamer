Imports System.IO
Imports System.Threading.Tasks

Module modRename
    Public NewNamePath As String
    Public NewNameAlone As String

    Dim tmpCapital As Char

    Public Sub doRemove(ByVal frm As frmMain)
        Try

            With frm
                If .txtSettings.Lines.Length > 4 Then
                    If .txtSettings.Lines(4).ToUpper.StartsWith("REM:") Then 'If there is an actual string to be removed

                        For j = 4 To .RemRepetitionInt 'to how many thing must be removed
                            OneTimeChangesSwarm = 0
                            WriteText(strHistoryPath & .HistoryItemsSwarm.ToString & ".txt", WorkingWith, "WriteLine")

                            .txtHistoryItems.Text = ""
                            If .txtFileNames.Lines.Length > 0 Then 'if there are files to be renamed
                                For i As Integer = 0 To .txtFileNames.Lines.Length - 1 'for i=0 to all files
                                    NewNameAlone = .txtFileNames.Lines(i).Substring(.txtDir.Text.Length)
                                    NewNameAlone = NewNameAlone.Replace(.txtSettings.Lines(j).Substring(4), "")
                                    NewNamePath = .txtDir.Text & NewNameAlone

                                    If .txtFileNames.Lines(i).ToString <> NewNamePath Then 'If NewName <> OldName MsgBox(.txtFileNames.Text & vbCrLf & vbCrLf & "i=" & i)
                                        RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(i) & """ /S /R """ & NewNamePath & """", True)
                                        'for reverse renaming
                                        .txtHistoryItems.Text = .txtHistoryItems.Text & NewNamePath & vbCrLf & .txtFileNames.Lines(i) & vbCrLf
                                        WriteText("", NewNamePath, "Continue")
                                        WriteText("", .txtFileNames.Lines(i), "Continue")
                                        OneTimeChangesSwarm += 1
                                    End If
                                Next
                            End If

                            WriteText("", NewNamePath, "End")
                            If OneTimeChangesSwarm = 0 Then
                                File.Delete(strHistoryPath & .HistoryItemsSwarm.ToString & ".txt")
                            Else
                                .txtHistoryFiles.Lines = System.IO.Directory.GetFiles(strHistoryPath)
                                .HistoryItemsSwarm = .txtHistoryFiles.Lines.Length
                            End If

                            OverallChangesSwarm += OneTimeChangesSwarm
                        Next
                        If SuppressMessages = False Then
                            MsgBox(OverallChangesSwarm & .txtLanguage.Lines(46) & WorkingWith & .txtLanguage.Lines(47), MsgBoxStyle.Information) ' changes have taken place on the 
                        End If
                        OverallChangesSwarm = 0
                    Else
                        If SuppressMessages = False Then
                            MsgBox(.txtLanguage.Lines(48) & vbCrLf & .txtLanguage.Lines(49) & RemBtnHotLetter(.btnConfigRep) & .txtLanguage.Lines(50), MsgBoxStyle.Information) 'There are currently No keywords for removal.Please push the  Button to add keywords to be removed
                        End If
                    End If
                Else
                    If SuppressMessages = False Then
                        MsgBox(.txtLanguage.Lines(48) & vbCrLf & .txtLanguage.Lines(49) & RemBtnHotLetter(.btnConfigRep) & .txtLanguage.Lines(50), MsgBoxStyle.Information) 'There are currently No keywords for removal.Please push the  Button to add keywords to be removed
                    End If
                End If
            End With

        Catch ex As Exception
            If SuppressMessages = False Then
                MsgBox(ex.ToString())
            End If
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
            Try
                WriteText("", NewNamePath, "End")
            Catch exempt As Exception
            End Try

        End Try
    End Sub

    Public Sub doReplace(ByVal frm As frmMain)
        Try

            With frm
                If .txtReplacements.Lines.Length > 1 Then 'Minimum Length = 2 as both a "REP" and an "WTH" are needed.
                    For j = 0 To .RepRepetitionInt - 1 Step 2
                        OneTimeChangesSwarm = 0
                        WriteText(strHistoryPath & .HistoryItemsSwarm.ToString & ".txt", WorkingWith, "WriteLine")
                        .txtHistoryItems.Text = ""

                        If .txtFileNames.Lines.Length > 0 Then
                            For i As Integer = 0 To .txtFileNames.Lines.Length - 1
                                If .txtReplacements.Lines(j).Substring(4) = "*" Then 'If ALL files should change names

                                    Dim tmpExt As String = GetExt(.txtDir.Text & .txtFileNames.Lines(i).Substring(.txtSettings.Lines(0).Length - 4))
                                    NewNameAlone = .txtReplacements.Lines(j + 1).Substring(4) & "_" & i & tmpExt
                                    NewNamePath = .txtDir.Text & NewNameAlone

                                    RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(i) & """ /S /R """ & NewNamePath & """", True)
                                    'for reverse renaming
                                    .txtHistoryItems.Text = .txtHistoryItems.Text & NewNamePath & vbCrLf & .txtFileNames.Lines(i) & vbCrLf
                                    WriteText("", NewNamePath, "Continue")
                                    WriteText("", .txtFileNames.Lines(i), "Continue")
                                    OneTimeChangesSwarm += 1

                                Else
                                    NewNameAlone = .txtFileNames.Lines(i).Substring(.txtSettings.Lines(0).Length - 4)
                                    NewNameAlone = NewNameAlone.Replace(.txtReplacements.Lines(j).Substring(4), .txtReplacements.Lines(j + 1).Substring(4))
                                    NewNamePath = .txtDir.Text & NewNameAlone
                                    If .txtFileNames.Lines(i).ToString <> NewNamePath Then
                                        RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(i) & """ /S /R """ & NewNamePath & """", True)
                                        'for reverse renaming
                                        .txtHistoryItems.Text = .txtHistoryItems.Text & NewNamePath & vbCrLf & .txtFileNames.Lines(i) & vbCrLf
                                        WriteText("", NewNamePath, "Continue")
                                        WriteText("", .txtFileNames.Lines(i), "Continue")
                                        OneTimeChangesSwarm += 1
                                    End If
                                End If

                            Next

                        End If

                        WriteText("", NewNamePath, "End")
                        If OneTimeChangesSwarm = 0 Then
                            File.Delete(strHistoryPath & .HistoryItemsSwarm.ToString & ".txt")
                        Else
                            .txtHistoryFiles.Lines = System.IO.Directory.GetFiles(strHistoryPath)
                            .HistoryItemsSwarm = .txtHistoryFiles.Lines.Length
                        End If

                        OverallChangesSwarm += OneTimeChangesSwarm
                    Next
                    If SuppressMessages = False Then
                        MsgBox(OverallChangesSwarm & .txtLanguage.Lines(46) & WorkingWith & .txtLanguage.Lines(47), MsgBoxStyle.Information) ' changes have taken place on the 
                    End If
                    OverallChangesSwarm = 0

                Else
                    If SuppressMessages = False Then
                        MsgBox(.txtLanguage.Lines(51) & vbCrLf & .txtLanguage.Lines(52) & RemBtnHotLetter(.btnConfigRep) & .txtLanguage.Lines(53), MsgBoxStyle.Information) 'There are currently no keywords to be replaced by another string. Please push the  button to add some
                    End If
                End If
            End With

        Catch ex As Exception
            If SuppressMessages = False Then
                MsgBox(ex.ToString())
            End If
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
            Try
                WriteText("", NewNamePath, "End")
            Catch excep As Exception
            End Try
        End Try
    End Sub

    Public Sub doSingleString(ByVal frm As frmMain)
        Try
            'Path.GetInvalidPathChars() 'Should check this to be certain the path doesn't contain invalid chars '''''''''''''''''''''
            With frm
                If .txtSingleStringText.Text <> String.Empty Then
                    OneTimeChangesSwarm = 0
                    WriteText(strHistoryPath & .HistoryItemsSwarm.ToString & ".txt", WorkingWith, "WriteLine")
                    .txtHistoryItems.Text = ""

                    If .txtFileNames.Lines.Length > 0 Then
                        For i As Integer = 0 To .txtFileNames.Lines.Length - 1
                            Dim tmpExt As String = GetExt(.txtDir.Text & .txtFileNames.Lines(i).Substring(.txtSettings.Lines(0).Length - 4))
                            NewNameAlone = .txtSingleStringText.Text & "_" & i & tmpExt
                            NewNamePath = .txtDir.Text & NewNameAlone

                            RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(i) & """ /S /R """ & NewNamePath & """", True)
                            'for reverse renaming
                            .txtHistoryItems.Text = .txtHistoryItems.Text & NewNamePath & vbCrLf & .txtFileNames.Lines(i) & vbCrLf
                            WriteText("", NewNamePath, "Continue")
                            WriteText("", .txtFileNames.Lines(i), "Continue")
                            OneTimeChangesSwarm += 1

                        Next

                    End If

                    WriteText("", NewNamePath, "End")
                    If OneTimeChangesSwarm = 0 Then
                        File.Delete(strHistoryPath & .HistoryItemsSwarm.ToString & ".txt")
                    Else
                        .txtHistoryFiles.Lines = System.IO.Directory.GetFiles(strHistoryPath)
                        .HistoryItemsSwarm = .txtHistoryFiles.Lines.Length
                    End If

                    OverallChangesSwarm += OneTimeChangesSwarm
                    If SuppressMessages = False Then
                        MsgBox(OverallChangesSwarm & .txtLanguage.Lines(46) & WorkingWith & .txtLanguage.Lines(47), MsgBoxStyle.Information) ' changes have taken place on the 
                    End If
                    OverallChangesSwarm = 0

                Else
                    If SuppressMessages = False Then
                        MsgBox(.txtLanguage.Lines(51) & vbCrLf & .txtLanguage.Lines(52) & RemBtnHotLetter(.btnConfigRep) & .txtLanguage.Lines(53), MsgBoxStyle.Information) 'There are currently no keywords to be replaced by another string. Please push the  button to add some
                    End If
                End If
            End With

        Catch ex As Exception
            If SuppressMessages = False Then
                MsgBox(ex.ToString())
            End If
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
            Try
                WriteText("", NewNamePath, "End")
            Catch excep As Exception
            End Try
        End Try
    End Sub

    Public Sub doCapitalizeFirstLetter(ByVal frm As frmMain)
        Try

            With frm
                If .txtFileNames.Lines.Length > 0 Then
                    OverallChangesSwarm = 0

                    For i As Integer = 0 To .txtFileNames.Lines.Length - 1
                        NewNameAlone = .txtFileNames.Lines(i).Substring(.txtSettings.Lines(0).Length - 4)
                        tmpCapital = CChar(NewNameAlone(0).ToString.ToUpper)
                        NewNameAlone = tmpCapital & NewNameAlone.Substring(1)
                        NewNamePath = .txtDir.Text & NewNameAlone

                        If .txtFileNames.Lines(i).ToString <> NewNamePath Then
                            RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(i) & """ /S /R """ & NewNamePath & """", True)
                            OverallChangesSwarm += 1
                        End If
                    Next
                    If SuppressMessages = False Then
                        MsgBox(OverallChangesSwarm & " " & WorkingWith & .txtLanguage.Lines(54), MsgBoxStyle.Information)
                    End If
                    OverallChangesSwarm = 0
                End If
            End With

        Catch ex As Exception
            If SuppressMessages = False Then
                MsgBox(ex.ToString())
            End If
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
        End Try
    End Sub

    Public Sub doCapitalizeAllWords(ByVal frm As frmMain)
        Try

            With frm
                If .txtFileNames.Lines.Length > 0 Then
                    Dim OldNameAlone As String

                    OverallChangesSwarm = 0
                    WriteText(strHistoryPath & .HistoryItemsSwarm.ToString & ".txt", WorkingWith, "WriteLine")
                    .txtHistoryItems.Text = ""

                    For i As Integer = 0 To .txtFileNames.Lines.Length - 1
                        NewNameAlone = ""
                        OldNameAlone = .txtFileNames.Lines(i).Substring(.txtSettings.Lines(0).Length - 4)

                        Dim tmpOldNameArray() As String = OldNameAlone.Split(CChar(" "))

                        For j As Integer = 0 To tmpOldNameArray.Length - 1
                            If tmpOldNameArray(j).Length > 0 Then
                                tmpCapital = CChar(tmpOldNameArray(j)(0).ToString.ToUpper)
                                NewNameAlone = NewNameAlone & " " & tmpCapital & tmpOldNameArray(j).Substring(1)
                            End If
                        Next

                        NewNameAlone = NewNameAlone.Substring(1)
                        NewNamePath = .txtDir.Text & NewNameAlone

                        If .txtFileNames.Lines(i).ToString <> NewNamePath Then
                            RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(i) & """ /S /R """ & NewNamePath & """", True)
                            'for reverse renaming
                            .txtHistoryItems.Text = .txtHistoryItems.Text & NewNamePath & vbCrLf & .txtFileNames.Lines(i) & vbCrLf
                            WriteText("", NewNamePath, "Continue")
                            WriteText("", .txtFileNames.Lines(i), "Continue")
                            OverallChangesSwarm += 1
                        End If
                    Next

                    WriteText("", NewNamePath, "End")
                End If

                If OverallChangesSwarm = 0 Then
                    File.Delete(strHistoryPath & .HistoryItemsSwarm.ToString & ".txt")
                Else
                    .txtHistoryFiles.Lines = System.IO.Directory.GetFiles(strHistoryPath)
                    .HistoryItemsSwarm = .txtHistoryFiles.Lines.Length
                End If

                If SuppressMessages = False Then
                    MsgBox(OverallChangesSwarm & " " & WorkingWith & .txtLanguage.Lines(54), MsgBoxStyle.Information)
                End If
                OverallChangesSwarm = 0
            End With

        Catch ex As Exception
            If SuppressMessages = False Then
                MsgBox(ex.ToString())
            End If
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
            Try
                WriteText("", NewNamePath, "End")
            Catch excep As Exception
            End Try
        End Try
    End Sub

    Public Sub doUnlock(ByVal frm As frmMain)
        Try

            With frm
                If .txtUnlocking.Lines.Length > 0 Then
                    If .txtUnlocking.Lines(0).ToUpper.StartsWith("ULK:") Then 'If there is an actual string to be removed

                        OverallChangesSwarm = 0
                        For j = 0 To .UlkRepetitionInt 'to how many thing must be removed

                            If .txtFileNames.Lines.Length > 0 Then 'if there are files to be renamed
                                For i As Integer = 0 To .txtFileNames.Lines.Length - 1 'for i=0 to all files

                                    If .txtUnlocking.Lines(j).Substring(4) = "*" Then
                                        For k As Integer = 0 To .txtFileNames.Lines.Length - 1
                                            RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(k) & """ /S""", True)
                                        Next
                                        GoTo Escape

                                    Else
                                        NewNameAlone = .txtFileNames.Lines(i).Substring(.txtDir.Text.Length)
                                        If NewNameAlone.Contains(.txtUnlocking.Lines(j).Substring(4)) Then
                                            RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(i) & """ /S""", True)

                                            OverallChangesSwarm += 1
                                        End If

                                    End If

                                Next
                            End If

                        Next

                        If SuppressMessages = False Then
                            MsgBox(OverallChangesSwarm & " " & WorkingWith & .txtLanguage.Lines(47) & .txtLanguage.Lines(69), MsgBoxStyle.Information) ' have been successfully unlocked.
                        End If
                        OverallChangesSwarm = 0

                    Else

                        If SuppressMessages = False Then
                            MsgBox(.txtLanguage.Lines(70) & vbCrLf & .txtLanguage.Lines(49) & RemBtnHotLetter(.btnConfigUnlock) & .txtLanguage.Lines(50), MsgBoxStyle.Information) 'There are currently No keywords for Unlocking. Please push the  Button to add keywords
                        End If
                    End If

                Else
                    If SuppressMessages = False Then
                        MsgBox(.txtLanguage.Lines(70) & vbCrLf & .txtLanguage.Lines(49) & RemBtnHotLetter(.btnConfigUnlock) & .txtLanguage.Lines(50), MsgBoxStyle.Information) 'There are currently No keywords for Unlocking. Please push the  Button to add keywords
                    End If
                End If

                Return
Escape:

                If SuppressMessages = False Then
                    MsgBox(.txtLanguage.Lines(68) & WorkingWith & .txtLanguage.Lines(47) & .txtLanguage.Lines(69), MsgBoxStyle.Information) 'All the  have been successfully unlocked.
                End If
            End With

        Catch ex As Exception
            If SuppressMessages = False Then
                MsgBox(ex.ToString())
            End If
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
        End Try
    End Sub

    Public Sub doDelete(ByVal frm As frmMain)
        Try

            With frm
                If .txtDeletion.Lines.Length > 0 Then
                    If .txtDeletion.Lines(0).ToUpper.StartsWith("DEL:") Then 'If there is an actual string to be removed

                        OverallChangesSwarm = 0
                        For j = 0 To .DelRepetitionInt 'to how many thing must be removed

                            If .txtFileNames.Lines.Length > 0 Then 'if there are files to be renamed
                                For i As Integer = 0 To .txtFileNames.Lines.Length - 1 'for i=0 to all files

                                    If .txtDeletion.Lines(j).Substring(4) = "*" Then
                                        For k As Integer = 0 To .txtFileNames.Lines.Length - 1
                                            RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(k) & """ /S /D""", True)
                                        Next
                                        GoTo Escape

                                    Else
                                        NewNameAlone = .txtFileNames.Lines(i).Substring(.txtDir.Text.Length)
                                        If NewNameAlone.Contains(.txtDeletion.Lines(j).Substring(4)) Then
                                            File.Delete(.txtFileNames.Lines(i)) ''''''''''''''''''''
                                            'RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(i) & """ /S /D""", True)

                                            OverallChangesSwarm += 1
                                        End If

                                    End If

                                Next
                            End If

                        Next

                        If SuppressMessages = False Then
                            MsgBox(OverallChangesSwarm & " " & WorkingWith & .txtLanguage.Lines(47) & .txtLanguage.Lines(76), MsgBoxStyle.Information) ' have been successfully deleted.
                        End If
                        OverallChangesSwarm = 0

                    Else

                        If SuppressMessages = False Then
                            MsgBox(.txtLanguage.Lines(77) & vbCrLf & .txtLanguage.Lines(49) & RemBtnHotLetter(.btnConfigDel) & .txtLanguage.Lines(50), MsgBoxStyle.Information) 'There are currently No keywords for Deletion. Please push the  Button to add keywords
                        End If

                    End If
                Else
                    If SuppressMessages = False Then
                        MsgBox(.txtLanguage.Lines(77) & vbCrLf & .txtLanguage.Lines(49) & RemBtnHotLetter(.btnConfigDel) & .txtLanguage.Lines(50), MsgBoxStyle.Information) 'There are currently No keywords for Deletion. Please push the  Button to add keywords
                    End If
                End If

                Return
Escape:
                If SuppressMessages = False Then
                    MsgBox(.txtLanguage.Lines(68) & WorkingWith & .txtLanguage.Lines(47) & .txtLanguage.Lines(90), MsgBoxStyle.Information) 'All the  have been successfully deleted.
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.ToString())
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
        End Try
    End Sub

    Public Sub doPrefix(ByVal frm As frmMain)
        Try

            With frm
                If .txtPrefixText.Text <> "" Then
                    If .txtPrefix.Lines.Length > 0 Then
                        My.Settings.PrefixText = .txtPrefixText.Text
                        My.Settings.Save()
                        If .txtPrefix.Lines(0).ToUpper.StartsWith("PFX:") Then 'If there is an actual string to be added

                            For j = 0 To .PFXRepetitionInt 'to how many filters
                                OneTimeChangesSwarm = 0
                                WriteText(strHistoryPath & .HistoryItemsSwarm.ToString & ".txt", WorkingWith, "WriteLine")

                                .txtHistoryItems.Text = ""
                                If .txtFileNames.Lines.Length > 0 Then 'if there are files to be renamed
                                    For i As Integer = 0 To .txtFileNames.Lines.Length - 1 'for i=0 to all files

                                        If .txtPrefix.Lines(j).Substring(4) = "*" Then
                                            For k As Integer = 0 To .txtFileNames.Lines.Length - 1
                                                NewNameAlone = .txtPrefixText.Text & .txtFileNames.Lines(k).Substring(.txtDir.Text.Length)
                                                NewNamePath = .txtDir.Text & NewNameAlone
                                                RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(k) & """ /S /R """ & NewNamePath & """", True)
                                                'for reverse renaming
                                                .txtHistoryItems.Text = .txtHistoryItems.Text & NewNamePath & vbCrLf & .txtFileNames.Lines(k) & vbCrLf
                                                WriteText("", NewNamePath, "Continue")
                                                WriteText("", .txtFileNames.Lines(k), "Continue")
                                                OneTimeChangesSwarm += 1
                                            Next
                                            GoTo Escape

                                        Else
                                            If (.txtFileNames.Lines(i).Substring(.txtDir.Text.Length)).Contains(.txtPrefix.Lines(j).Substring(4)) Then 'If FileName matches filter
                                                NewNameAlone = .txtPrefixText.Text & .txtFileNames.Lines(i).Substring(.txtDir.Text.Length)
                                                NewNamePath = .txtDir.Text & NewNameAlone

                                                RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(i) & """ /S /R """ & NewNamePath & """", True)
                                                'for reverse renaming
                                                .txtHistoryItems.Text = .txtHistoryItems.Text & NewNamePath & vbCrLf & .txtFileNames.Lines(i) & vbCrLf
                                                WriteText("", NewNamePath, "Continue")
                                                WriteText("", .txtFileNames.Lines(i), "Continue")
                                                OneTimeChangesSwarm += 1
                                            End If

                                        End If

                                    Next
                                End If

                                WriteText("", NewNamePath, "End")
                                If OneTimeChangesSwarm = 0 Then
                                    File.Delete(strHistoryPath & .HistoryItemsSwarm.ToString & ".txt")
                                Else
                                    .txtHistoryFiles.Lines = System.IO.Directory.GetFiles(strHistoryPath)
                                    .HistoryItemsSwarm = .txtHistoryFiles.Lines.Length
                                End If

                                OverallChangesSwarm += OneTimeChangesSwarm
                            Next
                            If SuppressMessages = False Then
                                MsgBox(OverallChangesSwarm & .txtLanguage.Lines(46) & WorkingWith & .txtLanguage.Lines(47), MsgBoxStyle.Information) ' changes have taken place on the 
                            End If
                            OverallChangesSwarm = 0
                        Else
                            If SuppressMessages = False Then
                                MsgBox(.txtLanguage.Lines(88) & vbCrLf & .txtLanguage.Lines(49) & RemBtnHotLetter(.btnConfigPfx) & .txtLanguage.Lines(50), MsgBoxStyle.Information) 'There are currently No keywords for Prefixes.Please push the  Button to add keywords to be removed
                            End If
                        End If
                    Else
                        If SuppressMessages = False Then
                            MsgBox(.txtLanguage.Lines(88) & vbCrLf & .txtLanguage.Lines(49) & RemBtnHotLetter(.btnConfigPfx) & .txtLanguage.Lines(50), MsgBoxStyle.Information) 'There are currently No keywords for Prefixes.Please push the  Button to add keywords to be removed
                        End If
                    End If

                Else
                    If SuppressMessages = False Then
                        MsgBox(.txtLanguage.Lines(89)) 'You haven't specified the prefix string.
                    End If
                End If

            Return
Escape:
                WriteText("", NewNamePath, "End")
                .txtHistoryFiles.Lines = System.IO.Directory.GetFiles(strHistoryPath)
                .HistoryItemsSwarm = .txtHistoryFiles.Lines.Length
                If SuppressMessages = False Then
                    MsgBox(.txtLanguage.Lines(68) & WorkingWith & .txtLanguage.Lines(47) & .txtLanguage.Lines(91), MsgBoxStyle.Information) 'All the  have been successfully renamed.
                End If
            End With

        Catch ex As Exception
            If SuppressMessages = False Then
                MsgBox(ex.ToString())
            End If
            CreateCrashFile(ex.ToString)
            Try
                WriteText("", NewNamePath, "End")
            Catch exempt As Exception
            End Try

        End Try
    End Sub

    Public Sub doSuffix(ByVal frm As frmMain)
        Try

            With frm
                If .txtSuffixText.Text <> "" Then
                    If .txtSuffix.Lines.Length > 0 Then
                        My.Settings.SuffixText = .txtSuffixText.Text
                        My.Settings.Save()
                        If .txtSuffix.Lines(0).ToUpper.StartsWith("SFX:") Then 'If there is an actual string to be added

                            For j = 0 To .SFXRepetitionInt 'to how many filters
                                OneTimeChangesSwarm = 0
                                WriteText(strHistoryPath & .HistoryItemsSwarm.ToString & ".txt", WorkingWith, "WriteLine")

                                .txtHistoryItems.Text = ""
                                If .txtFileNames.Lines.Length > 0 Then 'if there are files to be renamed
                                    For i As Integer = 0 To .txtFileNames.Lines.Length - 1 'for i=0 to all files

                                        If .txtSuffix.Lines(j).Substring(4) = "*" Then
                                            For k As Integer = 0 To .txtFileNames.Lines.Length - 1
                                                NewNameAlone = .txtFileNames.Lines(k).Substring(.txtDir.Text.Length) 'Giving the old name in
                                                If NewNameAlone.Contains(".") Then 'If it has an extension then we have to put the suffix b4 the ext
                                                    Dim strFindingExtention() As String = NewNameAlone.Split(CChar("."))    'Breaking down the name
                                                    NewNameAlone = ""                                                       'Initializing
                                                    For m As Integer = 0 To strFindingExtention.Length - 2                  'Building up the name again
                                                        NewNameAlone = NewNameAlone & "." & strFindingExtention(m)          'Leaving the extention behind
                                                    Next
                                                    NewNameAlone = NewNameAlone.Substring(1) 'Removing the 1st "."
                                                    NewNameAlone = NewNameAlone & .txtSuffixText.Text & "." & strFindingExtention(strFindingExtention.Length - 1) 'Finishing
                                                Else 'if it hasnt got an extention 
                                                    NewNameAlone = NewNameAlone & .txtSuffixText.Text 'just put the suffix
                                                End If

                                                NewNamePath = .txtDir.Text & NewNameAlone
                                                RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(k) & """ /S /R """ & NewNamePath & """", True)
                                                'for reverse renaming
                                                .txtHistoryItems.Text = .txtHistoryItems.Text & NewNamePath & vbCrLf & .txtFileNames.Lines(k) & vbCrLf
                                                WriteText("", NewNamePath, "Continue")
                                                WriteText("", .txtFileNames.Lines(k), "Continue")
                                                OneTimeChangesSwarm += 1
                                            Next
                                            GoTo Escape

                                        Else
                                            If (.txtFileNames.Lines(i).Substring(.txtDir.Text.Length)).Contains(.txtSuffix.Lines(j).Substring(4)) Then 'If FileName matches filter
                                                NewNameAlone = .txtFileNames.Lines(i).Substring(.txtDir.Text.Length) 'Giving the old name in
                                                If NewNameAlone.Contains(".") Then 'If it has an extension then we have to put the suffix b4 the ext
                                                    Dim strFindingExtention() As String = NewNameAlone.Split(CChar("."))    'Breaking down the name
                                                    NewNameAlone = ""                                                       'Initializing
                                                    For m As Integer = 0 To strFindingExtention.Length - 2                  'Building up the name again
                                                        NewNameAlone = NewNameAlone & "." & strFindingExtention(m)          'Leaving the extention behind
                                                    Next
                                                    NewNameAlone = NewNameAlone.Substring(1) 'Removing the 1st "."
                                                    NewNameAlone = NewNameAlone & .txtSuffixText.Text & "." & strFindingExtention(strFindingExtention.Length - 1) 'Finishing
                                                Else 'if it hasnt got an extention 
                                                    NewNameAlone = NewNameAlone & .txtSuffixText.Text 'just put the suffix
                                                End If

                                                NewNamePath = .txtDir.Text & NewNameAlone

                                                RunOpenDir(strUnlocker, """" & .txtFileNames.Lines(i) & """ /S /R """ & NewNamePath & """", True)
                                                'for reverse renaming
                                                .txtHistoryItems.Text = .txtHistoryItems.Text & NewNamePath & vbCrLf & .txtFileNames.Lines(i) & vbCrLf
                                                WriteText("", NewNamePath, "Continue")
                                                WriteText("", .txtFileNames.Lines(i), "Continue")
                                                OneTimeChangesSwarm += 1
                                            End If

                                        End If

                                    Next
                                End If

                                WriteText("", NewNamePath, "End")
                                If OneTimeChangesSwarm = 0 Then
                                    File.Delete(strHistoryPath & .HistoryItemsSwarm.ToString & ".txt")
                                Else
                                    .txtHistoryFiles.Lines = System.IO.Directory.GetFiles(strHistoryPath)
                                    .HistoryItemsSwarm = .txtHistoryFiles.Lines.Length
                                End If

                                OverallChangesSwarm += OneTimeChangesSwarm
                            Next
                            If SuppressMessages = False Then
                                MsgBox(OverallChangesSwarm & .txtLanguage.Lines(46) & WorkingWith & .txtLanguage.Lines(47), MsgBoxStyle.Information) ' changes have taken place on the 
                            End If
                            OverallChangesSwarm = 0
                        Else
                            If SuppressMessages = False Then
                                MsgBox(.txtLanguage.Lines(88) & vbCrLf & .txtLanguage.Lines(49) & RemBtnHotLetter(.btnConfigSfx) & .txtLanguage.Lines(50), MsgBoxStyle.Information) 'There are currently No keywords for Prefixes.Please push the  Button to add keywords
                            End If
                        End If
                    Else
                        If SuppressMessages = False Then
                            MsgBox(.txtLanguage.Lines(88) & vbCrLf & .txtLanguage.Lines(49) & RemBtnHotLetter(.btnConfigSfx) & .txtLanguage.Lines(50), MsgBoxStyle.Information) 'There are currently No keywords for Prefixes.Please push the  Button to add keywords
                        End If
                    End If

                Else
                    If SuppressMessages = False Then
                        MsgBox(.txtLanguage.Lines(89)) 'You haven't specified the prefix string.
                    End If
                End If

                Return
Escape:
                WriteText("", NewNamePath, "End")
                .txtHistoryFiles.Lines = System.IO.Directory.GetFiles(strHistoryPath)
                .HistoryItemsSwarm = .txtHistoryFiles.Lines.Length
                If SuppressMessages = False Then
                    MsgBox(.txtLanguage.Lines(68) & WorkingWith & .txtLanguage.Lines(47) & .txtLanguage.Lines(91), MsgBoxStyle.Information) 'All the  have been successfully renamed.
                End If
            End With

        Catch ex As Exception
            If SuppressMessages = False Then
                MsgBox(ex.ToString())
            End If
            CreateCrashFile(ex.ToString)
            Try
                WriteText("", NewNamePath, "End")
            Catch exempt As Exception
            End Try

        End Try
    End Sub

    Public Sub doReverseRename(ByVal frm As frmMain)
        Try

            With frm
                If .txtReverse.Text.Length > 10 Then
                    For i As Integer = 1 To (.txtReverse.Lines.Length - 2) Step 2
                        RunOpenDir(strUnlocker, """" & .txtReverse.Lines(i) & """ /S /R """ & .txtReverse.Lines(i + 1) & """", True)
                    Next
                    System.IO.File.Delete(strHistoryPath & .HistoryItemsSwarm - 1 & ".txt")
                    If SuppressMessages = False Then
                        MsgBox(.txtLanguage.Lines(55) & ((.txtReverse.Lines.Length - 2) / 2) & .txtLanguage.Lines(61)) 'Reverse-renamed successfully all the items that were renamed the previous time
                    End If
                Else
                    System.IO.File.Delete(strHistoryPath & .HistoryItemsSwarm - 1 & ".txt")
                    If SuppressMessages = False Then
                        MsgBox(.txtLanguage.Lines(56) & vbCrLf & .txtLanguage.Lines(57)) 'Seems like last time nothing was renamed, ergo no reverse renaming is available.
                    End If
                End If
            End With

        Catch ex As Exception
            If SuppressMessages = False Then
                MsgBox(ex.ToString())
            End If
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
        End Try

    End Sub

    Public Async Sub doWork(ByVal frm As frmMain)
        With frm

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
            .gbMisc.Enabled = False
            .TopMost = False
            .isRenamingThings = True

            Await Task.Run(
                Sub()
                    If .rdbFile.Checked = True Or .rdbFolder.Checked = True Then

                        If .rdbRem.Checked = True Then
                            Call doRemove(frm)

                        ElseIf .rdbRep.Checked = True Then
                            Call doReplace(frm)

                        ElseIf .rdbSingleString.Checked = True Then
                            Call doSingleString(frm)

                        ElseIf .rdbCapitalize1stWord.Checked = True Then
                            Call doCapitalizeFirstLetter(frm)

                        ElseIf .rdbCapitalizeAllWords.Checked = True Then
                            Call doCapitalizeAllWords(frm)

                        ElseIf .rdbUnlock.Checked = True Then
                            Call doUnlock(frm)

                        ElseIf .rdbDelete.Checked = True Then
                            If SuppressMessages = False Then
                                Dim DoubleCheck As MsgBoxResult = MsgBox(.txtLanguage.Lines(73) & vbCrLf & .txtLanguage.Lines(74) & .txtDir.Text & .txtLanguage.Lines(75), MsgBoxStyle.YesNoCancel)
                                If DoubleCheck = vbYes Then
                                    Call doDelete(frm)
                                End If
                            Else
                                Call doDelete(frm)
                            End If

                        ElseIf .rdbPrefix.Checked = True Then
                            Call doPrefix(frm)

                        ElseIf .rdbSuffix.Checked = True Then
                            Call doSuffix(frm)

                        Else
                            MsgBox(.txtLanguage.Lines(30)) 'Please select one of the available options first!
                        End If

                    Else
                        MsgBox(.txtLanguage.Lines(30)) 'Please select one of the available options first!

                    End If

                End Sub)

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
            .gbMisc.Enabled = True
            .TopMost = True
            .isRenamingThings = False

        End With
    End Sub

End Module
