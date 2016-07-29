<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArguments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArguments))
        Me.wbCredits = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'wbCredits
        '
        Me.wbCredits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbCredits.Location = New System.Drawing.Point(0, 0)
        Me.wbCredits.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbCredits.Name = "wbCredits"
        Me.wbCredits.Size = New System.Drawing.Size(1084, 562)
        Me.wbCredits.TabIndex = 0
        '
        'frmArguments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 562)
        Me.Controls.Add(Me.wbCredits)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArguments"
        Me.Text = "Arguments"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wbCredits As System.Windows.Forms.WebBrowser
End Class
