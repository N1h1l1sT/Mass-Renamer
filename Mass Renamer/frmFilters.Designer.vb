<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilters
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFilters))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lstReplace = New System.Windows.Forms.ListBox()
        Me.lstWith = New System.Windows.Forms.ListBox()
        Me.lblWith = New System.Windows.Forms.Label()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.txtWith = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.gbReplace = New System.Windows.Forms.GroupBox()
        Me.gbRemove = New System.Windows.Forms.GroupBox()
        Me.txtFilters = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtLanguage = New System.Windows.Forms.TextBox()
        Me.gbReplace.SuspendLayout()
        Me.gbRemove.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(532, 418)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save and E&xit"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lstReplace
        '
        Me.lstReplace.FormattingEnabled = True
        Me.lstReplace.Location = New System.Drawing.Point(21, 18)
        Me.lstReplace.Name = "lstReplace"
        Me.lstReplace.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstReplace.Size = New System.Drawing.Size(280, 290)
        Me.lstReplace.TabIndex = 2
        '
        'lstWith
        '
        Me.lstWith.FormattingEnabled = True
        Me.lstWith.Location = New System.Drawing.Point(321, 18)
        Me.lstWith.Name = "lstWith"
        Me.lstWith.Size = New System.Drawing.Size(280, 290)
        Me.lstWith.TabIndex = 3
        '
        'lblWith
        '
        Me.lblWith.AutoSize = True
        Me.lblWith.Location = New System.Drawing.Point(318, 2)
        Me.lblWith.Name = "lblWith"
        Me.lblWith.Size = New System.Drawing.Size(32, 13)
        Me.lblWith.TabIndex = 5
        Me.lblWith.Text = "With:"
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(21, 315)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(280, 20)
        Me.txtReplace.TabIndex = 6
        '
        'txtWith
        '
        Me.txtWith.Location = New System.Drawing.Point(321, 314)
        Me.txtWith.Name = "txtWith"
        Me.txtWith.Size = New System.Drawing.Size(280, 20)
        Me.txtWith.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(321, 340)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(280, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "&Add the new filter"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(21, 341)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(280, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "&Delete selected filters"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'gbReplace
        '
        Me.gbReplace.BackColor = System.Drawing.Color.Transparent
        Me.gbReplace.Controls.Add(Me.lstReplace)
        Me.gbReplace.Controls.Add(Me.lstWith)
        Me.gbReplace.Controls.Add(Me.btnDelete)
        Me.gbReplace.Controls.Add(Me.lblWith)
        Me.gbReplace.Controls.Add(Me.btnAdd)
        Me.gbReplace.Controls.Add(Me.txtReplace)
        Me.gbReplace.Controls.Add(Me.txtWith)
        Me.gbReplace.Location = New System.Drawing.Point(25, 13)
        Me.gbReplace.Name = "gbReplace"
        Me.gbReplace.Size = New System.Drawing.Size(622, 384)
        Me.gbReplace.TabIndex = 11
        Me.gbReplace.TabStop = False
        Me.gbReplace.Text = "Replace:"
        '
        'gbRemove
        '
        Me.gbRemove.Controls.Add(Me.txtFilters)
        Me.gbRemove.Location = New System.Drawing.Point(25, 13)
        Me.gbRemove.Name = "gbRemove"
        Me.gbRemove.Size = New System.Drawing.Size(622, 384)
        Me.gbRemove.TabIndex = 10
        Me.gbRemove.TabStop = False
        Me.gbRemove.Text = "Add words you wish to be removed, one on each line!"
        '
        'txtFilters
        '
        Me.txtFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFilters.Location = New System.Drawing.Point(3, 16)
        Me.txtFilters.Multiline = True
        Me.txtFilters.Name = "txtFilters"
        Me.txtFilters.Size = New System.Drawing.Size(616, 365)
        Me.txtFilters.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(28, 418)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(115, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtLanguage
        '
        Me.txtLanguage.Location = New System.Drawing.Point(-6, 3)
        Me.txtLanguage.Multiline = True
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.Size = New System.Drawing.Size(25, 20)
        Me.txtLanguage.TabIndex = 12
        Me.txtLanguage.Visible = False
        '
        'frmFilters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 453)
        Me.Controls.Add(Me.txtLanguage)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gbReplace)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbRemove)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFilters"
        Me.Text = "Filters"
        Me.gbReplace.ResumeLayout(False)
        Me.gbReplace.PerformLayout()
        Me.gbRemove.ResumeLayout(False)
        Me.gbRemove.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lstReplace As System.Windows.Forms.ListBox
    Friend WithEvents lstWith As System.Windows.Forms.ListBox
    Friend WithEvents lblWith As System.Windows.Forms.Label
    Friend WithEvents txtReplace As System.Windows.Forms.TextBox
    Friend WithEvents txtWith As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents gbReplace As System.Windows.Forms.GroupBox
    Friend WithEvents gbRemove As System.Windows.Forms.GroupBox
    Friend WithEvents txtFilters As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtLanguage As System.Windows.Forms.TextBox
End Class
