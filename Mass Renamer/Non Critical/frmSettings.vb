Public Class frmSettings
    Dim strSettings() As String
    Dim UserResponse As MsgBoxResult
    Dim LanguageName As String
    Dim AlreadyRun As Boolean = False
    Dim cbLanguageLastIndex As Integer
    Dim Initializing As Boolean = False
    Dim ChangingLanguage As Boolean = False

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        Try

            'Disabling the program until the search sequence is finished
            Me.Enabled = False
            'Disabling the program until the search sequence is finished

            'Language
            If CStr(cbLanguage.Tag) = "1" Then
                strSettings(3) = "LNG:" & cbLanguage.Items(cbLanguageLastIndex).ToString
                CurrentLanguage = CStr(cbLanguage.Items(cbLanguageLastIndex))
                StrCurrentLanguageDir = strLanguageFolders & CurrentLanguage & "\"
                Call Language_Main(frmMain)
            End If
            '/language


            '<Ending>
            txtSettings.Lines = strSettings
            WriteText(strSettingsIni, txtSettings.Text)
            frmMain.txtSettings.Text = txtSettings.Text

            'Changing to Default        <+1 cuz of the chkbox>
            cbLanguage.Text = ""
            cbLanguage.Tag = 0
            '/Changing to default           <+1 cuz of the chkbox>

            'Re-Enabling the program when search sequence is finished
            Me.Enabled = True
            cmdApply.Enabled = False
            Me.Close()
            'Re-Enabling the program when search sequence is finished


        Catch ex As Exception
            MsgBox(ex.ToString)
            UserResponse = MsgBox(txtLanguage.Lines(16), MsgBoxStyle.YesNo)
            If UserResponse = vbYes Then
                System.IO.File.Copy(strSettingsOrig, strSettingsIni)
            End If
            Me.Close()
        End Try
    End Sub

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'initialization
            Initializing = True

            'Changing Language
            Call Language_Settings(Me)
            '/Changing Language

            '/initialization

            'Reading Settings
            ReadToTextbox(strSettingsIni, txtSettings)
            strSettings = txtSettings.Lines
            '/Reading Settings

            'Getting available languages 
            If AlreadyRun = False Then
                txtDirectories.Lines = System.IO.Directory.GetDirectories(strLanguageFolders)
                For i = 0 To txtDirectories.Lines.Length - 1
                    LanguageName = txtDirectories.Lines(i).Substring(strLanguageFolders.Length)
                    cbLanguage.Items.Add(LanguageName)
                Next
                AlreadyRun = True
            End If

            Initializing = False

            'Changing to Default
            cmdApply.Enabled = False
            cbLanguage.Tag = 0
            '/Changing to default

        Catch ex As Exception
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmdDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDefault.Click
        Try


            Dim YesNoMsgbox = MsgBox(txtLanguage.Lines(8) & vbCrLf & txtLanguage.Lines(9), MsgBoxStyle.YesNo)
            If YesNoMsgbox = MsgBoxResult.Yes Then
                System.IO.File.Delete(strSettingsIni)
                System.IO.File.Copy(strSettingsOrig, strSettingsIni)
                MsgBox(txtLanguage.Lines(14)) 'Original settings applied
            End If

            Exit Sub

        Catch ex As Exception
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmdCurrent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCurrent.Click
        Try

            'Disabling the program until the search sequence is finished
            Me.Enabled = False
            'Disabling the program until the search sequence is finished

            'Language
            If txtSettings.Lines(3).Length > 4 Then
                cbLanguage.Text = txtSettings.Lines(3).Substring(4)
            Else
                cbLanguage.Text = txtLanguage.Lines(10) '*Error*
            End If
            '/Language

            'Re-Enabling the program when search sequence is finished
            Me.Enabled = True
            cmdApply.Enabled = False
            'Re-Enabling the program when search sequence is finished

            'Changing to Default
            cbLanguage.Tag = 0
            '/Changing to default

        Catch ex As Exception
            WriteText(My.Application.Info.DirectoryPath & "\Extras\Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cbLanguage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLanguage.SelectedIndexChanged
        If Initializing = False Then
            cmdApply.Enabled = True
            cbLanguageLastIndex = cbLanguage.SelectedIndex
            cbLanguage.Tag = "1"
        End If
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

End Class