<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblAssemblyName = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblDirectoryPath = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblStackTrace = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblWorkingSet = New System.Windows.Forms.Label()
        Me.txtAssemblyName = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtCopyright = New System.Windows.Forms.TextBox()
        Me.txtDirectoryPath = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.StackTrace = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.txtWorkingSet = New System.Windows.Forms.TextBox()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.lblHash = New System.Windows.Forms.Label()
        Me.txtHash = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUSer = New System.Windows.Forms.Label()
        Me.cmdWidth = New System.Windows.Forms.Button()
        Me.txtLanguage = New System.Windows.Forms.TextBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblLicense = New System.Windows.Forms.Label()
        Me.txtLicense = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAssemblyName
        '
        Me.lblAssemblyName.AutoSize = True
        Me.lblAssemblyName.Location = New System.Drawing.Point(9, 12)
        Me.lblAssemblyName.Name = "lblAssemblyName"
        Me.lblAssemblyName.Size = New System.Drawing.Size(85, 13)
        Me.lblAssemblyName.TabIndex = 0
        Me.lblAssemblyName.Text = "Assembly Name:"
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(9, 35)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(85, 13)
        Me.lblCompanyName.TabIndex = 1
        Me.lblCompanyName.Text = "Company Name:"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(11, 61)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(54, 13)
        Me.lblCopyright.TabIndex = 2
        Me.lblCopyright.Text = "Copyright:"
        '
        'lblDirectoryPath
        '
        Me.lblDirectoryPath.AutoSize = True
        Me.lblDirectoryPath.Location = New System.Drawing.Point(11, 87)
        Me.lblDirectoryPath.Name = "lblDirectoryPath"
        Me.lblDirectoryPath.Size = New System.Drawing.Size(77, 13)
        Me.lblDirectoryPath.TabIndex = 3
        Me.lblDirectoryPath.Text = "Directory Path:"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(12, 113)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(78, 13)
        Me.lblProductName.TabIndex = 4
        Me.lblProductName.Text = "Product Name:"
        '
        'lblStackTrace
        '
        Me.lblStackTrace.AutoSize = True
        Me.lblStackTrace.Location = New System.Drawing.Point(451, 9)
        Me.lblStackTrace.Name = "lblStackTrace"
        Me.lblStackTrace.Size = New System.Drawing.Size(66, 13)
        Me.lblStackTrace.TabIndex = 5
        Me.lblStackTrace.Text = "Stack Trace"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 139)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Title:"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(12, 165)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(45, 13)
        Me.lblVersion.TabIndex = 7
        Me.lblVersion.Text = "Version:"
        '
        'lblWorkingSet
        '
        Me.lblWorkingSet.AutoSize = True
        Me.lblWorkingSet.Location = New System.Drawing.Point(12, 191)
        Me.lblWorkingSet.Name = "lblWorkingSet"
        Me.lblWorkingSet.Size = New System.Drawing.Size(101, 13)
        Me.lblWorkingSet.TabIndex = 8
        Me.lblWorkingSet.Text = "Working Set (Mem):"
        '
        'txtAssemblyName
        '
        Me.txtAssemblyName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAssemblyName.Location = New System.Drawing.Point(159, 9)
        Me.txtAssemblyName.Name = "txtAssemblyName"
        Me.txtAssemblyName.ReadOnly = True
        Me.txtAssemblyName.Size = New System.Drawing.Size(164, 20)
        Me.txtAssemblyName.TabIndex = 9
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCompanyName.Location = New System.Drawing.Point(159, 35)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.ReadOnly = True
        Me.txtCompanyName.Size = New System.Drawing.Size(164, 20)
        Me.txtCompanyName.TabIndex = 10
        '
        'txtCopyright
        '
        Me.txtCopyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCopyright.Location = New System.Drawing.Point(159, 61)
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.ReadOnly = True
        Me.txtCopyright.Size = New System.Drawing.Size(164, 20)
        Me.txtCopyright.TabIndex = 11
        '
        'txtDirectoryPath
        '
        Me.txtDirectoryPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDirectoryPath.Location = New System.Drawing.Point(159, 87)
        Me.txtDirectoryPath.Name = "txtDirectoryPath"
        Me.txtDirectoryPath.ReadOnly = True
        Me.txtDirectoryPath.Size = New System.Drawing.Size(164, 20)
        Me.txtDirectoryPath.TabIndex = 12
        '
        'txtProductName
        '
        Me.txtProductName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtProductName.Location = New System.Drawing.Point(159, 113)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.Size = New System.Drawing.Size(164, 20)
        Me.txtProductName.TabIndex = 13
        '
        'StackTrace
        '
        Me.StackTrace.Location = New System.Drawing.Point(329, 35)
        Me.StackTrace.Multiline = True
        Me.StackTrace.Name = "StackTrace"
        Me.StackTrace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.StackTrace.Size = New System.Drawing.Size(393, 251)
        Me.StackTrace.TabIndex = 14
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.Location = New System.Drawing.Point(159, 139)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(164, 20)
        Me.txtTitle.TabIndex = 15
        '
        'txtVersion
        '
        Me.txtVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVersion.Location = New System.Drawing.Point(159, 165)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.ReadOnly = True
        Me.txtVersion.Size = New System.Drawing.Size(164, 20)
        Me.txtVersion.TabIndex = 16
        '
        'txtWorkingSet
        '
        Me.txtWorkingSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtWorkingSet.Location = New System.Drawing.Point(159, 191)
        Me.txtWorkingSet.Name = "txtWorkingSet"
        Me.txtWorkingSet.ReadOnly = True
        Me.txtWorkingSet.Size = New System.Drawing.Size(164, 20)
        Me.txtWorkingSet.TabIndex = 17
        '
        'txtCredits
        '
        Me.txtCredits.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCredits.BackColor = System.Drawing.Color.Black
        Me.txtCredits.ForeColor = System.Drawing.Color.Fuchsia
        Me.txtCredits.Location = New System.Drawing.Point(12, 300)
        Me.txtCredits.Multiline = True
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.ReadOnly = True
        Me.txtCredits.Size = New System.Drawing.Size(249, 88)
        Me.txtCredits.TabIndex = 18
        '
        'lblHash
        '
        Me.lblHash.AutoSize = True
        Me.lblHash.Location = New System.Drawing.Point(11, 217)
        Me.lblHash.Name = "lblHash"
        Me.lblHash.Size = New System.Drawing.Size(100, 13)
        Me.lblHash.TabIndex = 19
        Me.lblHash.Text = "Current Hash Code:"
        '
        'txtHash
        '
        Me.txtHash.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtHash.Location = New System.Drawing.Point(159, 217)
        Me.txtHash.Name = "txtHash"
        Me.txtHash.ReadOnly = True
        Me.txtHash.Size = New System.Drawing.Size(164, 20)
        Me.txtHash.TabIndex = 20
        '
        'txtUser
        '
        Me.txtUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUser.Location = New System.Drawing.Point(159, 243)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(164, 20)
        Me.txtUser.TabIndex = 21
        '
        'lblUSer
        '
        Me.lblUSer.AutoSize = True
        Me.lblUSer.Location = New System.Drawing.Point(11, 243)
        Me.lblUSer.Name = "lblUSer"
        Me.lblUSer.Size = New System.Drawing.Size(69, 13)
        Me.lblUSer.TabIndex = 22
        Me.lblUSer.Text = "Current User:"
        '
        'cmdWidth
        '
        Me.cmdWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdWidth.Location = New System.Drawing.Point(267, 299)
        Me.cmdWidth.Name = "cmdWidth"
        Me.cmdWidth.Size = New System.Drawing.Size(57, 64)
        Me.cmdWidth.TabIndex = 23
        Me.cmdWidth.Text = "&Show Stack Trace"
        Me.cmdWidth.UseVisualStyleBackColor = True
        '
        'txtLanguage
        '
        Me.txtLanguage.Location = New System.Drawing.Point(100, 0)
        Me.txtLanguage.Multiline = True
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.Size = New System.Drawing.Size(35, 55)
        Me.txtLanguage.TabIndex = 24
        Me.txtLanguage.Visible = False
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(267, 369)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(57, 19)
        Me.cmdExit.TabIndex = 25
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lblLicense
        '
        Me.lblLicense.AutoSize = True
        Me.lblLicense.Location = New System.Drawing.Point(12, 269)
        Me.lblLicense.Name = "lblLicense"
        Me.lblLicense.Size = New System.Drawing.Size(65, 13)
        Me.lblLicense.TabIndex = 26
        Me.lblLicense.Text = "Licensed to:"
        Me.lblLicense.Visible = False
        '
        'txtLicense
        '
        Me.txtLicense.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLicense.Location = New System.Drawing.Point(159, 266)
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.ReadOnly = True
        Me.txtLicense.Size = New System.Drawing.Size(164, 20)
        Me.txtLicense.TabIndex = 27
        Me.txtLicense.Visible = False
        '
        'frmAbout
        '
        Me.AcceptButton = Me.cmdWidth
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(328, 398)
        Me.Controls.Add(Me.txtLicense)
        Me.Controls.Add(Me.lblLicense)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.txtLanguage)
        Me.Controls.Add(Me.cmdWidth)
        Me.Controls.Add(Me.lblUSer)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtHash)
        Me.Controls.Add(Me.lblHash)
        Me.Controls.Add(Me.txtCredits)
        Me.Controls.Add(Me.txtWorkingSet)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.StackTrace)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtDirectoryPath)
        Me.Controls.Add(Me.txtCopyright)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.txtAssemblyName)
        Me.Controls.Add(Me.lblWorkingSet)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblStackTrace)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblDirectoryPath)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.lblAssemblyName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAbout"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAssemblyName As System.Windows.Forms.Label
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents lblDirectoryPath As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents lblStackTrace As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblWorkingSet As System.Windows.Forms.Label
    Friend WithEvents txtAssemblyName As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents txtCopyright As System.Windows.Forms.TextBox
    Friend WithEvents txtDirectoryPath As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents StackTrace As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtVersion As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkingSet As System.Windows.Forms.TextBox
    Friend WithEvents txtCredits As System.Windows.Forms.TextBox
    Friend WithEvents lblHash As System.Windows.Forms.Label
    Friend WithEvents txtHash As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblUSer As System.Windows.Forms.Label
    Friend WithEvents cmdWidth As System.Windows.Forms.Button
    Friend WithEvents txtLanguage As System.Windows.Forms.TextBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents lblLicense As System.Windows.Forms.Label
    Friend WithEvents txtLicense As System.Windows.Forms.TextBox
End Class
