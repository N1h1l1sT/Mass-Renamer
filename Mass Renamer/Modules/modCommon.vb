'Version 4.8 2011/12/22
Option Strict On

Imports System
Imports System.IO
Imports System.Net
Imports System.Diagnostics

Module modCommon
    Public WindowsVersion As Integer = 32
    Public CurrentLanguage As String = "English"
    Public strSettingsPath As String = My.Application.Info.DirectoryPath & "\Settings\"
    Public strLanguageFolders As String = My.Application.Info.DirectoryPath & "\Language\"
    Public strExtras As String = My.Application.Info.DirectoryPath & "\Extras\"
    Public strUniversal As String = strLanguageFolders & "UniversalStrings.txt"
    Public StrCurrentLanguageDir As String = strLanguageFolders & CurrentLanguage & "\"
    Public strSettingsIni As String = strSettingsPath & "Settings.ini"
    Public strSettingsOrig As String = strSettingsPath & "Settings.orig"
    Public strExplorerExe As String = "explorer.exe"
    Public strUnlocker As String = My.Application.Info.DirectoryPath & "\Extras\Unlockerx86.exe"
    Public strBrowser As String = Environment.GetEnvironmentVariable("programfiles") & "\Internet Explorer\iexplore.exe"
    Public strEULA As String = My.Application.Info.DirectoryPath & "\Eula.rtf"

    Public TextWrite_Persistent As TextWriter

    Dim exeProcesses As New Process
    Dim numOfPercents As Integer = 0

    Public Sub ReadMainStrings()
        If Directory.Exists(Environment.GetEnvironmentVariable("windir") & "\SysWOW64") Then
            WindowsVersion = 64
            strExplorerExe = Environment.GetEnvironmentVariable("windir") & "\SysWOW64\explorer.exe"
            strUnlocker = My.Application.Info.DirectoryPath & "\Extras\Unlockerx64.exe"

        ElseIf Directory.Exists(Environment.GetEnvironmentVariable("windir") & "\system32") Then
            WindowsVersion = 32
            strExplorerExe = Environment.GetEnvironmentVariable("windir") & "\system32\explorer.exe"
            strUnlocker = My.Application.Info.DirectoryPath & "\Extras\Unlockerx86.exe"
        End If
    End Sub

    Public Function isInternetAvailable(ByVal TestUrl As String) As Boolean
        ' Returns True if connection is available
        ' is guaranteed to be online - perhaps your
        ' corporate site, or microsoft.com
        Dim objUrl As New System.Uri(TestUrl)
        ' Setup WebRequest
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objResp As System.Net.WebResponse
        Try
            ' Attempt to get response and return True
            objResp = objWebReq.GetResponse
            objResp.Close()
            objWebReq = Nothing
            Return True
        Catch ex As Exception
            ' Error, exit and return False
            objResp = Nothing
            'objResp.Close()
            objWebReq = Nothing
            Return False
        End Try
    End Function

    Public Function doProperPathName(ByVal TextToAmend As String) As String

        If TextToAmend.EndsWith("\\") Then
            TextToAmend = TextToAmend.Substring(0, TextToAmend.Length - 2)
        ElseIf Not TextToAmend.EndsWith("\") Then
            TextToAmend = TextToAmend & "\"
        End If

        Return TextToAmend
    End Function

    Public Function doResolveWildNames(ByVal TextToAmend As String) As String

        If TextToAmend.Contains("%") Then

            Dim chrNewPathName() As Char = TextToAmend.ToCharArray
            Dim intStart As Integer = 0
            Dim intEnd As Integer = 0

            For i = 0 To chrNewPathName.Length - 1
                If chrNewPathName(i) = "%" Then
                    numOfPercents += 1
                End If
            Next

            If numOfPercents > 0 Then
                If (numOfPercents Mod 2) = 0 Then
                    For i = 1 To (numOfPercents / 2)
                        Dim WildWord As String = ""

                        If chrNewPathName(intStart) <> "%" Then
                            Do While chrNewPathName(intStart) <> "%" 'Finding the first index of "%"
                                intStart += 1
                            Loop
                        End If
                        intStart += 2

                        intEnd = intStart - 1
                        If chrNewPathName(intEnd) <> "%" Then
                            Do While chrNewPathName(intEnd) <> "%"
                                intEnd += 1
                            Loop
                        End If
                        intEnd -= 1

                        WildWord = Mid(TextToAmend, intStart, intEnd)

                        If WildWord.ToUpper = "ROOT" Then
                            TextToAmend = TextToAmend.Replace("%" & WildWord & "%", My.Application.Info.DirectoryPath)
                        Else
                            TextToAmend = TextToAmend.Replace("%" & WildWord & "%", Environment.GetEnvironmentVariable(WildWord))
                        End If

                    Next i

                End If
            End If

        End If
        numOfPercents = 0

        Return TextToAmend
    End Function

    Public Sub RunOpenDir(ByRef PathName As String, Optional ByVal Arguments As String = "", Optional ByVal WaitForExit As Boolean = False, Optional ByVal ErrorMessage As String = "", Optional ByVal CannotFindFile As String = "Cannot find the specified file: ", Optional ByVal WithArguments As String = " with arguments: ", Optional ByVal WriteCrushFileAnyway As Boolean = False)
        Dim TextWrite As TextWriter
        PathName = doResolveWildNames(PathName)
        Arguments = doResolveWildNames(Arguments)

        If PathName.ToLower = "explorer" Or PathName.ToLower = "explorer.exe" Then
            PathName = strExplorerExe
        End If

        If File.Exists(PathName) Then
            exeProcesses.StartInfo.FileName = PathName
            exeProcesses.StartInfo.Arguments = Arguments
            exeProcesses.Start()

            If WaitForExit = True Then
                exeProcesses.WaitForExit()
            End If

        Else
            If ErrorMessage <> "" Or WriteCrushFileAnyway = True Then
                If ErrorMessage <> "" Then
                    MsgBox(ErrorMessage)
                End If
                TextWrite = File.CreateText(My.Computer.FileSystem.SpecialDirectories.Desktop & "\Crush " & Today.Day & "-" & Today.Month & "-" & Today.Year & " " & My.Computer.Clock.LocalTime.Minute & " " & My.Computer.Clock.LocalTime.Second & ".txt")
                TextWrite.WriteLine(My.Application.Info.AssemblyName)
                TextWrite.WriteLine(CannotFindFile & """" & PathName & """" & WithArguments & """" & Arguments & """")
                TextWrite.Flush()
                TextWrite.Close()
            End If
        End If
    End Sub

    Public Sub CloseForm(ByVal frm As Form, Optional ByVal ClosingPromptText As String = "")
        If ClosingPromptText = "" Then
            frm.Close()
        Else
            Dim UserResponse = MsgBox(ClosingPromptText, MsgBoxStyle.YesNo)
            If UserResponse = vbYes Then
                frm.Close()
            End If
        End If
    End Sub

    Public Function RemBtnHotLetter(ByVal btn As Button) As String
        Dim ResultString As String

        ResultString = "<" & btn.Text.Replace("&", "") & ">"

        Return ResultString
    End Function

    Public Function RemMniHotLetter(ByVal mni As ToolStripMenuItem) As String
        Dim ResultString As String

        ResultString = "<" & mni.Text.Replace("&", "") & ">"

        Return ResultString
    End Function

    Public Sub ReadToString(ByVal FileName As String, ByVal StringToFill As String)
        Dim TextRead As TextReader
        TextRead = File.OpenText(FileName)
        StringToFill = TextRead.ReadToEnd
        TextRead.Close()
    End Sub

    Public Sub ReadToTextbox(ByVal FileName As String, ByVal TextboxToFill As TextBox)
        Dim TextRead As TextReader
        TextRead = File.OpenText(FileName)
        TextboxToFill.Text = TextRead.ReadToEnd
        TextRead.Close()
    End Sub

    Public Sub WriteText(ByVal FileName As String, ByVal TextToWrite As String, Optional ByVal WriteMethod As String = "Write")
        'Methods: Write / WriteLine / Continue / ContEnd / End
        'TODO On WriteLine TextWrite should also be closed on the calling-sub's Catch Exception by WriteText(FileName,"","End")

        If WriteMethod.ToLower = "write" Then
            Dim TextWrite As TextWriter
            TextWrite = File.CreateText(FileName)
            TextWrite.Write(TextToWrite)
            TextWrite.Flush()
            TextWrite.Close()

        ElseIf WriteMethod.ToLower = "writeline" Then
            TextWrite_Persistent = File.CreateText(FileName)
            TextWrite_Persistent.WriteLine(TextToWrite)

        ElseIf WriteMethod.ToLower = "continue" Then
            TextWrite_Persistent.WriteLine(TextToWrite)

        ElseIf WriteMethod.ToLower = "contend" Then
            TextWrite_Persistent.WriteLine(TextToWrite)
            TextWrite_Persistent.Flush()
            TextWrite_Persistent.Close()

        ElseIf WriteMethod.ToLower = "end" Then
            TextWrite_Persistent.Flush()
            TextWrite_Persistent.Close()

        End If
    End Sub

    Public Sub CreateCrashFile(ByVal CrushStr As String)
        WriteText(strExtras & "Crash ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", CrushStr)
    End Sub

End Module
