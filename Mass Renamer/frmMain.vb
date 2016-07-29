'========================================================================
'=This program is created by Giannis Mamalikidis=========================
'=Please do not remove any mention of my name anywhere in this programme=
'=If you improve the programme, feel free to add your name too===========
'=This comments must not be removed.=====================================
'========================================================================

Imports System.Threading.Tasks
Imports System.IO

Public Class frmMain
    Public args() As String = Environment.GetCommandLineArgs

    Dim isProgChangeSettings As Boolean = False
    Public isRenamingThings As Boolean = False

    Public RemRepetitionInt As Integer
    Public RepRepetitionInt As Integer
    Public UlkRepetitionInt As Integer
    Public DelRepetitionInt As Integer
    Public PFXRepetitionInt As Integer
    Public SFXRepetitionInt As Integer
    Public SettingsArray(99) As String
    Public HistoryItemsSwarm As Integer

    Public txtHistoryItems As New TextBox
    Public txtHistoryFiles As New TextBox

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            isReloading = True
            ReadToTextbox(strSettingsIni, txtSettings)  'Loading Settings
            If txtSettings.Lines(3).Length > 4 Then     'Loading Current Language
                CurrentLanguage = txtSettings.Lines(3).Substring(4)
                StrCurrentLanguageDir = strLanguageFolders & CurrentLanguage & "\"
            End If
            isReloading = False
            Call Language_Main(Me)
            Call ReadMainStrings()
            Call Reload(Me)
            fswSettings.Path = strSettingsPath

            If args.Length > 1 Then
                Call doReadArguments(Me)
                Reload(Me)
                fswWorkingDirectory.Path = txtDir.Text 'Here to cover any case
                Call AutoRunWork(Me)
            End If

        Catch ex As Exception
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
            MsgBox(ex.ToString)
            btnRename.Enabled = True
            gbDo.Enabled = True
            gbSettings.Enabled = True
            gbWorkWith.Enabled = True
            btnReverse.Enabled = True
            btnChangeDir.Enabled = True
            txtDir.Enabled = True
            btnExit.Enabled = True
            mniFileMenu.Enabled = True
            mniSettingsMenu.Enabled = True
            Me.TopMost = True
            isRenamingThings = False
        End Try
    End Sub

    Public Sub txtHistoryFiles_TextChanged()
        btnReverse.Text = txtLanguage.Lines(19) & " (" & txtHistoryFiles.Lines.Length & ")" 'Re&verse/Unrename
        HistoryItemsSwarm = txtHistoryFiles.Lines.Length
    End Sub

    Private Sub btnRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRename.Click
        Try

            If txtDir.Text <> "" Then
                Dim tmpText As String = String.Empty

                If rdbDelete.Checked = True Then
                    tmpText = txtLanguage.Lines(81) & WorkingWith & txtLanguage.Lines(47) & txtLanguage.Lines(29) & txtDir.Text & """ ?"
                ElseIf rdbUnlock.Checked = True Then
                    tmpText = txtLanguage.Lines(82) & WorkingWith & txtLanguage.Lines(47) & txtLanguage.Lines(29) & txtDir.Text & """ ?"
                Else
                    tmpText = txtLanguage.Lines(28) & WorkingWith & txtLanguage.Lines(47) & txtLanguage.Lines(29) & txtDir.Text & """ ?"
                End If

                Dim UserResponse As MsgBoxResult = MsgBox(tmpText, MsgBoxStyle.YesNo) '"Are you sure you want to rename/Delete/Unlock the files on: "X" ?
                If UserResponse = vbYes Then
                    Call doWork(Me)
                End If

            Else
                MsgBox(txtLanguage.Lines(31), MsgBoxStyle.Exclamation) 'Choose a directory whose files you wish to rename!
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
            btnRename.Enabled = True
            gbDo.Enabled = True
            gbSettings.Enabled = True
            gbWorkWith.Enabled = True
            btnReverse.Enabled = True
            btnChangeDir.Enabled = True
            txtDir.Enabled = True
            btnExit.Enabled = True
            mniFileMenu.Enabled = True
            mniSettingsMenu.Enabled = True
            Me.TopMost = True
            isRenamingThings = False
            Try
                TextWrite_Persistent.Flush()
                TextWrite_Persistent.Close()
            Catch excep As Exception
            End Try
        End Try
    End Sub


    Private Async Sub btnReverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReverse.Click
        Try

            If HistoryItemsSwarm > 0 Then
                Dim UserResponse As MsgBoxResult = MsgBox(txtLanguage.Lines(32), MsgBoxStyle.YesNo) 'Are you sure you want to Unrename/Reverse rename your last renaming?
                If UserResponse = vbYes Then
                    ReadToTextbox(strHistoryPath & HistoryItemsSwarm - 1 & ".txt", txtReverse)

                    btnRename.Enabled = False
                    gbDo.Enabled = False
                    gbSettings.Enabled = False
                    gbWorkWith.Enabled = False
                    btnReverse.Enabled = False
                    btnChangeDir.Enabled = False
                    txtDir.Enabled = False
                    btnExit.Enabled = False
                    Me.TopMost = False
                    isRenamingThings = True

                    Await Task.Run(
                        Sub()
                            Call doReverseRename(Me)
                        End Sub)


                    txtHistoryFiles2.Text = txtHistoryFiles.Text
                    GetFilesFolders(txtDir.Text, Me)
                    txtHistoryFiles.Lines = System.IO.Directory.GetFiles(strHistoryPath)
                    Call txtHistoryFiles_TextChanged()
                    HistoryItemsSwarm = txtHistoryFiles.Lines.Length

                    btnRename.Enabled = True
                    gbDo.Enabled = True
                    gbSettings.Enabled = True
                    gbWorkWith.Enabled = True
                    btnReverse.Enabled = True
                    btnChangeDir.Enabled = True
                    txtDir.Enabled = True
                    btnExit.Enabled = True
                    Me.TopMost = True
                    isRenamingThings = False

                End If
            Else
                MsgBox(txtLanguage.Lines(33), MsgBoxStyle.Information) 'There is no history file available to reverse rename
            End If

        Catch ex As Exception
            btnRename.Enabled = True
            gbDo.Enabled = True
            gbSettings.Enabled = True
            gbWorkWith.Enabled = True
            btnReverse.Enabled = True
            btnChangeDir.Enabled = True
            txtDir.Enabled = True
            btnExit.Enabled = True
            Me.TopMost = True
            isRenamingThings = False
            MsgBox(ex.ToString)
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
            MsgBox(txtLanguage.Lines(34) & vbCrLf & txtLanguage.Lines(35)) 'Seems like something went wrong in the renaming process, causing the reverse-rename to crash. In order to avoid future reverse problems all the history files will be deleted after you push the 'ok' button
            txtHistoryFiles.Lines = System.IO.Directory.GetFiles(strHistoryPath)
            For i As Integer = 0 To txtHistoryFiles.Lines.Length - 1
                System.IO.File.Delete(txtHistoryFiles.Lines(i))
            Next
            txtHistoryFiles.Text = ""
            txtHistoryItems.Text = ""
            HistoryItemsSwarm = 0
            Call txtHistoryFiles_TextChanged()
        End Try
    End Sub

    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click
        Reload(Me)
        GetFilesFolders(txtDir.Text, Me)
        MsgBox(txtLanguage.Lines(36), MsgBoxStyle.Information) 'Settings Reloaded!
    End Sub

    Private Sub txtDir_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDir.TextChanged
        If isReloading = False And isProgChangeSettings = False Then

            txtDir.Text = doResolveWildNames(txtDir.Text)

            If Directory.Exists(txtDir.Text) Then
                isProgChangeSettings = True
                txtDir.Text = doProperPathName(txtDir.Text)

                SettingsArray(0) = "DIR:" & txtDir.Text
                txtSettings.Lines = SettingsArray
                WriteText(strSettingsIni, txtSettings.Text)
                txtDir.SelectionStart = txtDir.Text.Length

                fswWorkingDirectory.Path = txtDir.Text
                btnRename.Enabled = True
                gbDo.Enabled = True
                gbWorkWith.Enabled = True

                GetFilesFolders(txtDir.Text, Me)

                isProgChangeSettings = False
            Else
                btnRename.Enabled = False
                gbDo.Enabled = False
                gbWorkWith.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnDirectory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDirectory.Click
        RunOpenDir(strExplorerExe, My.Application.Info.DirectoryPath, True, txtLanguage.Lines(37)) 'Cannot find Directory or Explorer.exe
    End Sub

    Private Sub rdbFile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbFile.CheckedChanged
        If isReloading = False And rdbFile.Checked = True Then
            isProgChangeSettings = True
            SettingsArray(1) = "OBJ:FILE"
            txtSettings.Lines = SettingsArray
            WriteText(strSettingsIni, txtSettings.Text)
            WorkingWith = "file"
            GetFilesFolders(txtDir.Text, Me)
            isProgChangeSettings = False
        End If
    End Sub

    Private Sub rdbFolder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbFolder.CheckedChanged
        If isReloading = False And rdbFolder.Checked = True Then
            isProgChangeSettings = True
            SettingsArray(1) = "OBJ:FOLDER"
            txtSettings.Lines = SettingsArray
            WriteText(strSettingsIni, txtSettings.Text)
            WorkingWith = "folder"
            GetFilesFolders(txtDir.Text, Me)
            isProgChangeSettings = False
        End If
    End Sub

    Private Sub rdbRem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbRem.CheckedChanged
        If isReloading = False Then
            If rdbRem.Checked = True Then
                isProgChangeSettings = True
                SettingsArray(2) = "OPT:REM"
                txtSettings.Lines = SettingsArray
                WriteText(strSettingsIni, txtSettings.Text)
                btnRename.Text = txtLanguage.Lines(20)
                isProgChangeSettings = False
            End If
        End If
    End Sub

    Private Sub rdbRep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbRep.CheckedChanged
        If isReloading = False Then
            If rdbRep.Checked = True Then
                isProgChangeSettings = True
                SettingsArray(2) = "OPT:REP"
                txtSettings.Lines = SettingsArray
                WriteText(strSettingsIni, txtSettings.Text)
                btnRename.Text = txtLanguage.Lines(20)
                isProgChangeSettings = False
            End If
        End If
    End Sub

    Private Sub rdbCapitalize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCapitalize1stWord.CheckedChanged
        If isReloading = False Then
            If rdbCapitalize1stWord.Checked = True Then
                isProgChangeSettings = True
                SettingsArray(2) = "OPT:CAP"
                txtSettings.Lines = SettingsArray
                WriteText(strSettingsIni, txtSettings.Text)
                btnRename.Text = txtLanguage.Lines(20)
                isProgChangeSettings = False
            End If
        End If
    End Sub

    Private Sub rdbCapitalizeAllWords_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbCapitalizeAllWords.CheckedChanged
        If isReloading = False Then
            If rdbCapitalizeAllWords.Checked = True Then
                isProgChangeSettings = True
                SettingsArray(2) = "OPT:CAW"
                txtSettings.Lines = SettingsArray
                WriteText(strSettingsIni, txtSettings.Text)
                btnRename.Text = txtLanguage.Lines(20)
                isProgChangeSettings = False
            End If
        End If
    End Sub

    Private Sub rdbUnlock_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbUnlock.CheckedChanged
        If isReloading = False Then
            If rdbUnlock.Checked = True Then
                isProgChangeSettings = True
                SettingsArray(2) = "OPT:ULK"
                txtSettings.Lines = SettingsArray
                WriteText(strSettingsIni, txtSettings.Text)
                btnRename.Text = txtLanguage.Lines(71)
                isProgChangeSettings = False
            End If
        End If
    End Sub

    Private Sub rdbDelete_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbDelete.CheckedChanged
        If isReloading = False Then
            If rdbDelete.Checked = True Then
                isProgChangeSettings = True
                SettingsArray(2) = "OPT:DEL"
                txtSettings.Lines = SettingsArray
                WriteText(strSettingsIni, txtSettings.Text)
                btnRename.Text = txtLanguage.Lines(72)
                isProgChangeSettings = False
            End If
        End If
    End Sub

    Private Sub rdbPrefix_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbPrefix.CheckedChanged
        If isReloading = False Then
            If rdbPrefix.Checked = True Then
                isProgChangeSettings = True
                txtPrefixText.Enabled = True
                SettingsArray(2) = "OPT:PFX"
                txtSettings.Lines = SettingsArray
                WriteText(strSettingsIni, txtSettings.Text)
                btnRename.Text = txtLanguage.Lines(20)
                isProgChangeSettings = False
            Else
                txtPrefixText.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbSuffix_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbSuffix.CheckedChanged
        If isReloading = False Then
            If rdbSuffix.Checked = True Then
                isProgChangeSettings = True
                txtSuffixText.Enabled = True
                SettingsArray(2) = "OPT:SFX"
                txtSettings.Lines = SettingsArray
                WriteText(strSettingsIni, txtSettings.Text)
                btnRename.Text = txtLanguage.Lines(20)
                isProgChangeSettings = False
            Else
                txtSuffixText.Enabled = False
            End If
        End If
    End Sub

    Private Sub rdbSingleString_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSingleString.CheckedChanged
        If isReloading = False Then
            If rdbSingleString.Checked = True Then
                isProgChangeSettings = True
                txtSingleStringText.Enabled = True
                SettingsArray(2) = "OPT:1SS"
                txtSettings.Lines = SettingsArray
                WriteText(strSettingsIni, txtSettings.Text)
                btnRename.Text = txtLanguage.Lines(20)
                isProgChangeSettings = False
            Else
                txtSingleStringText.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnChangeDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeDir.Click
        fbDirectory.ShowDialog()
        If fbDirectory.SelectedPath <> "" Then
            txtDir.Text = fbDirectory.SelectedPath & "\"
        End If
    End Sub

    Private Sub btnBrowseDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseDir.Click
        RunOpenDir(strExplorerExe, txtDir.Text, True, txtLanguage.Lines(37)) 'Cannot find Directory or Explorer.exe
    End Sub

    Private Sub btnConfigRem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigRem.Click
        Me.TopMost = False
        frmFilters.strFilter = "Remove"
        frmFilters.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub btnConfigRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigRep.Click
        Me.TopMost = False
        frmFilters.strFilter = "Replace"
        frmFilters.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub btnConfigUnlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigUnlock.Click
        Me.TopMost = False
        frmFilters.strFilter = "Unlock"
        frmFilters.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub btnConfigDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigDel.Click
        Me.TopMost = False
        frmFilters.strFilter = "Delete"
        frmFilters.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub btnDelHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelHistory.Click
        txtHistoryFiles.Lines = System.IO.Directory.GetFiles(strHistoryPath)

        If txtHistoryFiles.Lines.Length >= 1 Then
            Dim UserResponse As MsgBoxResult = MsgBox(txtLanguage.Lines(41), MsgBoxStyle.YesNo) 'Are you sure you wish to delete all history?
            If UserResponse = vbYes Then
                For i As Integer = 0 To txtHistoryFiles.Lines.Length - 1
                    System.IO.File.Delete(txtHistoryFiles.Lines(i))
                Next
                txtHistoryFiles.Lines = System.IO.Directory.GetFiles(strHistoryPath)
                HistoryItemsSwarm = txtHistoryFiles.Lines.Length
                txtHistoryItems.Text = ""
                Call txtHistoryFiles_TextChanged()
                MsgBox(txtLanguage.Lines(42), MsgBoxStyle.Information) 'History Deleted!
            End If

        Else
            MsgBox(txtLanguage.Lines(43), MsgBoxStyle.Information) 'There are no history items to delete!
        End If

    End Sub

    Private Async Sub fswSettings_Changed(sender As System.Object, e As System.IO.FileSystemEventArgs) Handles fswSettings.Changed
        If isProgChangeSettings = False Then
            Await Task.Run(Sub()
                               Threading.Thread.Sleep(100)
                           End Sub)
            Reload(Me)
        End If
    End Sub

    Private Sub txtSettings_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSettings.TextChanged
        If isReloading = False And isProgChangeSettings = False Then
            Reload(Me)
        End If
    End Sub

    Private Sub txtReplacements_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtReplacements.TextChanged
        If isReloading = False AndAlso isProgChangeSettings = False Then
            Reload(Me)
        End If
    End Sub

    Private Sub txtUnlocking_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUnlocking.TextChanged
        If isReloading = False AndAlso isProgChangeSettings = False Then
            Reload(Me)
        End If
    End Sub

    Private Sub txtDeletion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDeletion.TextChanged
        If isReloading = False AndAlso isProgChangeSettings = False Then
            Reload(Me)
        End If
    End Sub

    Private Sub fswWorkingDirectory_Changed(sender As System.Object, e As System.IO.FileSystemEventArgs) Handles fswWorkingDirectory.Created, fswWorkingDirectory.Deleted, fswWorkingDirectory.Renamed
        If Not isRenamingThings Then
            Reload(Me)
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        CloseForm(Me, txtLanguage.Lines(44)) 'Are you sure you want to quit?
    End Sub

    Private Sub btnRestoreDir_Click(sender As System.Object, e As System.EventArgs) Handles btnRestoreDir.Click
        Dim UserResponse As MsgBoxResult = MsgBox(txtLanguage.Lines(62), MsgBoxStyle.YesNoCancel) 'Are you sure you want to restore the default directory?
        If UserResponse = vbYes Then
            txtDir.Text = strTestDir
            MsgBox(txtLanguage.Lines(45), MsgBoxStyle.Information) 'Directory has been restored!
        End If
    End Sub

    Private Sub mniExit_Click(sender As System.Object, e As System.EventArgs) Handles mniExit.Click
        CloseForm(Me)
    End Sub

    Private Sub mniCredits_Click(sender As System.Object, e As System.EventArgs) Handles mniCredits.Click
        Me.TopMost = False
        frmCredits.Show()
        Me.TopMost = True
    End Sub

    Private Sub mniAbout_Click(sender As System.Object, e As System.EventArgs) Handles mniAbout.Click
        Me.TopMost = False
        frmAbout.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub mniArguments_Click(sender As System.Object, e As System.EventArgs) Handles mniArguments.Click
        Me.TopMost = False
        frmArguments.Show()
        Me.TopMost = True
    End Sub

    Private Sub mniSettingsFile_Click(sender As System.Object, e As System.EventArgs) Handles mniSettingsFile.Click
        RunOpenDir(strExplorerExe, strSettingsIni, True, txtLanguage.Lines(37)) 'Cannot find Directory or Explorer.exe
    End Sub

    Private Sub mniReplaceWithFile_Click(sender As System.Object, e As System.EventArgs) Handles mniReplaceWithFile.Click
        RunOpenDir(strExplorerExe, strReplaceIni, True, txtLanguage.Lines(37)) 'Cannot find Directory or Explorer.exe
    End Sub

    Private Sub mniUnlockFile_Click(sender As System.Object, e As System.EventArgs) Handles mniUnlockFile.Click
        RunOpenDir(strExplorerExe, strUnlockIni, True, txtLanguage.Lines(37)) 'Cannot find Directory or Explorer.exe
    End Sub

    Private Sub mniDeleteFile_Click(sender As System.Object, e As System.EventArgs) Handles mniDeleteFile.Click
        RunOpenDir(strExplorerExe, strDeleteIni, True, txtLanguage.Lines(37)) 'Cannot find Directory or Explorer.exe
    End Sub

    Private Sub mniPrefixFile_Click(sender As System.Object, e As System.EventArgs) Handles mniPrefixFile.Click
        RunOpenDir(strExplorerExe, strPrefixIni, True, txtLanguage.Lines(37)) 'Cannot find Directory or Explorer.exe
    End Sub

    Private Sub mniSuffixFile_Click(sender As System.Object, e As System.EventArgs) Handles mniSuffixFile.Click
        RunOpenDir(strExplorerExe, strSuffixIni, True, txtLanguage.Lines(37)) 'Cannot find Directory or Explorer.exe
    End Sub

    Private Sub mniProgramDir_Click(sender As System.Object, e As System.EventArgs) Handles mniProgramDir.Click
        RunOpenDir(strExplorerExe, My.Application.Info.DirectoryPath, True, txtLanguage.Lines(37)) 'Cannot find Directory or Explorer.exe
    End Sub

    Private Sub mniVisitWebsite_Click(sender As System.Object, e As System.EventArgs) Handles mniVisitWebsite.Click
        My.Computer.Clipboard.SetText(strBrowser)
        RunOpenDir(strBrowser, My.Settings.WebsiteURL, False, txtLanguage.Lines(60) & " """ & strBrowser & """") 'Cannot find
    End Sub

    Private Sub mniSettings_Click(sender As System.Object, e As System.EventArgs) Handles mniSettings.Click
        Me.TopMost = False
        frmSettings.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnConfigPfx.Click
        Me.TopMost = False
        frmFilters.strFilter = "Prefix"
        frmFilters.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnConfigSfx.Click
        Me.TopMost = False
        frmFilters.strFilter = "Suffix"
        frmFilters.ShowDialog()
        Me.TopMost = True
    End Sub

    Private Sub mniEULA_Click(sender As System.Object, e As System.EventArgs) Handles mniEULA.Click
        RunOpenDir(strEULA)
    End Sub
End Class
