Public NotInheritable Class frmSplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            lblApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            lblApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        lblVersion.Text = My.Application.Info.Version.ToString

        'Copyright info
        lblCopyright.Text = My.Application.Info.Copyright
        Dim RandomClass As New Random()
        Dim RandomNumber As Integer
        'PANTA na bazo +1 sto deftero number
Randomization:
        RandomNumber = RandomClass.Next(1, 3)
        If RandomNumber = 1 Then
            lblApplicationTitle.ForeColor = Color.Azure
            lblCopyright.ForeColor = Color.Azure
            lblVersion.ForeColor = Color.Azure
            MainLayoutPanel.BackgroundImage = My.Resources.Resources.Splashscreen1
        ElseIf RandomNumber = 2 Then
            MainLayoutPanel.BackgroundImage = My.Resources.Resources.splashscreenoa0
        Else
            GoTo Randomization
        End If
    End Sub

    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub
End Class
