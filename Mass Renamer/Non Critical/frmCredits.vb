Public Class frmCredits

    Private Sub frmCredits_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Uri.TryCreate(StrCurrentLanguageDir & My.Application.Info.AssemblyName.ToString & " Credits.html", UriKind.RelativeOrAbsolute, wbCredits.Url)
    End Sub
End Class