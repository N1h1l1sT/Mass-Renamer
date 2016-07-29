Public Class frmArguments

    Private Sub frmArguments_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Uri.TryCreate(StrCurrentLanguageDir & My.Application.Info.AssemblyName.ToString & " Arguments.html", UriKind.RelativeOrAbsolute, wbCredits.Url)
    End Sub
End Class