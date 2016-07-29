Public Class frmAbout

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            'initialization
            Call Language_About(Me)
            '/initialization

            txtAssemblyName.Text = My.Application.Info.AssemblyName
            txtCompanyName.Text = My.Application.Info.CompanyName
            txtCopyright.Text = My.Application.Info.Copyright
            txtDirectoryPath.Text = My.Application.Info.DirectoryPath
            txtProductName.Text = My.Application.Info.ProductName
            StackTrace.Text = My.Application.Info.StackTrace
            txtTitle.Text = My.Application.Info.Title
            txtVersion.Text = System.Convert.ToString(My.Application.Info.Version)
            txtWorkingSet.Text = CStr(My.Application.Info.WorkingSet)
            txtHash.Text = CStr(My.User.GetHashCode())
            txtUser.Text = My.User.Name
            'txtLicense.Text = UserName

        Catch ex As Exception
            MsgBox(ex.ToString)
            WriteText(strExtras & "Crush ex " & My.Computer.Clock.GmtTime.Year & My.Computer.Clock.GmtTime.Month & My.Computer.Clock.GmtTime.Day & My.Computer.Clock.GmtTime.Hour & My.Computer.Clock.GmtTime.Minute & ".txt", ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWidth.Click
        If Me.Width <> 744 Then
            Me.Width = 744
            cmdWidth.Text = txtLanguage.Lines(14) '"Hide Stack Trace"
        Else
            Me.Width = 338
            cmdWidth.Text = txtLanguage.Lines(13) '"Show Stack Trace"
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
        Exit Sub
    End Sub

End Class