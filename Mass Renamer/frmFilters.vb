Option Strict On

Public Class frmFilters
    Public strFilter As String

    Dim IsLoading As Boolean = False
    Dim ChangesDone As Integer

    Private Sub frmFilters_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            With frmMain

                IsLoading = True
                Call Language_Filters(Me)
                ChangesDone = 0

                If strFilter.ToLower = "replace" Then
                    lstReplace.Items.Clear()
                    lstWith.Items.Clear()
                    gbReplace.Visible = True
                    gbRemove.Visible = False
                    AcceptButton = btnAdd

                    If .txtReplacements.Lines.Length > 1 Then
                        If .txtReplacements.Lines(1).ToUpper.StartsWith("WTH:") Then
                            For i = 0 To .txtReplacements.Lines.Length - 1 Step 2
                                lstReplace.Items.Add(String.Format("{0:000}", (i + 1) / 2) & ": """ & .txtReplacements.Lines(i).Substring(4) & """")
                                lstWith.Items.Add(String.Format("{0:000}", (i + 1) / 2) & ": """ & .txtReplacements.Lines(i + 1).Substring(4) & """")
                            Next
                        End If
                    End If

                ElseIf strFilter.ToLower = "remove" Then
                    gbRemove.Text = txtLanguage.Lines(1)
                    gbRemove.Visible = True
                    gbReplace.Visible = False
                    txtFilters.Text = ""
                    If .txtSettings.Lines.Length > 4 Then
                        If .txtSettings.Lines(4).ToUpper.StartsWith("REM:") Then
                            For i As Integer = 4 To (.txtSettings.Lines.Length - 1)
                                If .txtSettings.Lines(i).ToUpper.StartsWith("REM:") Then
                                    txtFilters.Text = txtFilters.Text & vbCrLf & .txtSettings.Lines(i).Substring(4)
                                End If
                            Next
                            txtFilters.Text = txtFilters.Text.Substring(2)
                        End If
                    End If

                ElseIf strFilter.ToLower = "unlock" Then
                    gbRemove.Text = txtLanguage.Lines(15)
                    gbRemove.Visible = True
                    gbReplace.Visible = False
                    txtFilters.Text = ""
                    If .txtUnlocking.Lines.Length > 0 Then
                        If .txtUnlocking.Lines(0).ToUpper.StartsWith("ULK:") Then
                            For i As Integer = 0 To (.txtUnlocking.Lines.Length - 1)
                                If .txtUnlocking.Lines(i).ToUpper.StartsWith("ULK:") Then
                                    txtFilters.Text = txtFilters.Text & vbCrLf & .txtUnlocking.Lines(i).Substring(4)
                                End If
                            Next
                            txtFilters.Text = txtFilters.Text.Substring(2)
                        End If
                    End If

                ElseIf strFilter.ToLower = "delete" Then
                    gbRemove.Text = txtLanguage.Lines(14)
                    gbRemove.Visible = True
                    gbReplace.Visible = False
                    txtFilters.Text = ""
                    If .txtDeletion.Lines.Length > 0 Then
                        If .txtDeletion.Lines(0).ToUpper.StartsWith("DEL:") Then
                            For i As Integer = 0 To (.txtDeletion.Lines.Length - 1)
                                If .txtDeletion.Lines(i).ToUpper.StartsWith("DEL:") Then
                                    txtFilters.Text = txtFilters.Text & vbCrLf & .txtDeletion.Lines(i).Substring(4)
                                End If
                            Next
                            txtFilters.Text = txtFilters.Text.Substring(2)
                        End If
                    End If

                ElseIf strFilter.ToLower = "prefix" Then
                    gbRemove.Text = txtLanguage.Lines(1)
                    gbRemove.Visible = True
                    gbReplace.Visible = False
                    txtFilters.Text = ""
                    If .txtPrefix.Lines.Length > 0 Then
                        If .txtPrefix.Lines(0).ToUpper.StartsWith("PFX:") Then
                            For i As Integer = 0 To (.txtPrefix.Lines.Length - 1)
                                If .txtPrefix.Lines(i).ToUpper.StartsWith("PFX:") Then
                                    txtFilters.Text = txtFilters.Text & vbCrLf & .txtPrefix.Lines(i).Substring(4)
                                End If
                            Next
                            txtFilters.Text = txtFilters.Text.Substring(2)
                        End If
                    End If

                ElseIf strFilter.ToLower = "suffix" Then
                    gbRemove.Text = txtLanguage.Lines(1)
                    gbRemove.Visible = True
                    gbReplace.Visible = False
                    txtFilters.Text = ""
                    If .txtSuffix.Lines.Length > 0 Then
                        If .txtSuffix.Lines(0).ToUpper.StartsWith("SFX:") Then
                            For i As Integer = 0 To (.txtSuffix.Lines.Length - 1)
                                If .txtSuffix.Lines(i).ToUpper.StartsWith("SFX") Then
                                    txtFilters.Text = txtFilters.Text & vbCrLf & .txtSuffix.Lines(i).Substring(4)
                                End If
                            Next
                            txtFilters.Text = txtFilters.Text.Substring(2)
                        End If
                    End If


                End If
                IsLoading = False

            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If txtReplace.Text <> "" Then
            If txtWith.Text <> "" Then
                lstReplace.Items.Add(String.Format("{0:000}", lstReplace.Items.Count + 1) & ": """ & txtReplace.Text & """")
                lstWith.Items.Add(String.Format("{0:000}", lstWith.Items.Count + 1) & ": """ & txtWith.Text & """")
                txtReplace.Text = ""
                txtWith.Text = ""
                ChangesDone += 1
                txtReplace.Focus()

            Else
                MsgBox(txtLanguage.Lines(4) & txtReplace.Text & txtLanguage.Lines(5), MsgBoxStyle.Information) 'Please specify what you want to replace " <txt> " with.
            End If
        Else
            MsgBox(txtLanguage.Lines(6), MsgBoxStyle.Information) 'Please specify the text that need be replaced
        End If
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        For i As Integer = (lstReplace.SelectedIndices.Count - 1) To 0 Step -1
            lstWith.Items.RemoveAt(lstReplace.SelectedIndices(i))
            lstReplace.Items.RemoveAt(lstReplace.SelectedIndices(i))
            ChangesDone += 1
        Next
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try

            If strFilter.ToLower = "replace" Then
                Dim REPText As String = doProperSaveRepStr(Me)
                WriteText(strReplaceIni, REPText)

            ElseIf strFilter.ToLower = "remove" Then
                Dim REMText As String = doProperSaveRemStr(Me)
                WriteText(strSettingsIni, REMText)

            ElseIf strFilter.ToLower = "unlock" Then
                Dim ULKText As String = doProperSaveUlkDelPfxSfxStr(Me, "ULK:")
                WriteText(strUnlockIni, ULKText)

            ElseIf strFilter.ToLower = "delete" Then
                Dim DELText As String = doProperSaveUlkDelPfxSfxStr(Me, "DEL:")
                WriteText(strDeleteIni, DELText)

            ElseIf strFilter.ToLower = "prefix" Then
                Dim PFXText As String = doProperSaveUlkDelPfxSfxStr(Me, "PFX:")
                WriteText(strPrefixIni, PFXText)

            ElseIf strFilter.ToLower = "suffix" Then
                Dim SFXText As String = doProperSaveUlkDelPfxSfxStr(Me, "SFX:")
                WriteText(strSuffixIni, SFXText)

            End If

            CloseForm(Me)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtRemoveFilter_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFilters.TextChanged
        If Not IsLoading Then
            ChangesDone = 1
        End If
        txtFilters.AcceptsReturn = True

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Dim ClosingPromptText As String = ""

        If strFilter.ToLower = "replace" Then
            If ChangesDone > 0 Then
                ClosingPromptText = txtLanguage.Lines(7) & ChangesDone & txtLanguage.Lines(8) 'You've made ( X ) changes, are you sure you want to cancel?
            End If

        ElseIf strFilter.ToLower = "remove" Or strFilter.ToLower = "unlock" Or strFilter.ToLower = "delete" Then
            If ChangesDone > 0 Then
                ClosingPromptText = txtLanguage.Lines(9) 'You've made changes to the filters, are you sure you want to cancel?
            End If
        End If

        CloseForm(Me, ClosingPromptText)
    End Sub

    Private Sub lstWith_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstWith.SelectedIndexChanged
        If lstWith.SelectedIndex >= 0 Then
            lstReplace.SelectedIndex = lstWith.SelectedIndex
            lstWith.ClearSelected()
        End If
    End Sub
End Class