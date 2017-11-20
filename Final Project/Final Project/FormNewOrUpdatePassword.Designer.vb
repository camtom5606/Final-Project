<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewOrUpdatePassword
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
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.grpPasswordGenerator = New System.Windows.Forms.GroupBox()
        Me.txtGenerated = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.LabelPasswordChars = New System.Windows.Forms.Label()
        Me.chkSpecial = New System.Windows.Forms.CheckBox()
        Me.chkDigits = New System.Windows.Forms.CheckBox()
        Me.chkLowerAZ = New System.Windows.Forms.CheckBox()
        Me.chkUpperAZ = New System.Windows.Forms.CheckBox()
        Me.LabelPasswordLength = New System.Windows.Forms.Label()
        Me.NumericUpDownPasswordLength = New System.Windows.Forms.NumericUpDown()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelNameOrUrl = New System.Windows.Forms.Label()
        Me.txtNameOrUrl = New System.Windows.Forms.TextBox()
        Me.grpPasswordGenerator.SuspendLayout()
        CType(Me.NumericUpDownPasswordLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPassword
        '
        Me.btnPassword.Location = New System.Drawing.Point(178, 192)
        Me.btnPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(235, 45)
        Me.btnPassword.TabIndex = 4
        Me.btnPassword.Text = "Create Password"
        Me.btnPassword.UseVisualStyleBackColor = True
        '
        'grpPasswordGenerator
        '
        Me.grpPasswordGenerator.Controls.Add(Me.txtGenerated)
        Me.grpPasswordGenerator.Controls.Add(Me.btnGenerate)
        Me.grpPasswordGenerator.Controls.Add(Me.LabelPasswordChars)
        Me.grpPasswordGenerator.Controls.Add(Me.chkSpecial)
        Me.grpPasswordGenerator.Controls.Add(Me.chkDigits)
        Me.grpPasswordGenerator.Controls.Add(Me.chkLowerAZ)
        Me.grpPasswordGenerator.Controls.Add(Me.chkUpperAZ)
        Me.grpPasswordGenerator.Controls.Add(Me.LabelPasswordLength)
        Me.grpPasswordGenerator.Controls.Add(Me.NumericUpDownPasswordLength)
        Me.grpPasswordGenerator.Location = New System.Drawing.Point(420, 58)
        Me.grpPasswordGenerator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpPasswordGenerator.Name = "grpPasswordGenerator"
        Me.grpPasswordGenerator.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpPasswordGenerator.Size = New System.Drawing.Size(375, 254)
        Me.grpPasswordGenerator.TabIndex = 0
        Me.grpPasswordGenerator.TabStop = False
        Me.grpPasswordGenerator.Text = "Password Generator"
        '
        'txtGenerated
        '
        Me.txtGenerated.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenerated.Location = New System.Drawing.Point(22, 186)
        Me.txtGenerated.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtGenerated.Name = "txtGenerated"
        Me.txtGenerated.ReadOnly = True
        Me.txtGenerated.Size = New System.Drawing.Size(321, 44)
        Me.txtGenerated.TabIndex = 6
        Me.txtGenerated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(22, 134)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(322, 45)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate Password"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'LabelPasswordChars
        '
        Me.LabelPasswordChars.AutoSize = True
        Me.LabelPasswordChars.Location = New System.Drawing.Point(19, 65)
        Me.LabelPasswordChars.Name = "LabelPasswordChars"
        Me.LabelPasswordChars.Size = New System.Drawing.Size(161, 20)
        Me.LabelPasswordChars.TabIndex = 0
        Me.LabelPasswordChars.Text = "Password characters:"
        '
        'chkSpecial
        '
        Me.chkSpecial.AutoSize = True
        Me.chkSpecial.Location = New System.Drawing.Point(279, 92)
        Me.chkSpecial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkSpecial.Name = "chkSpecial"
        Me.chkSpecial.Size = New System.Drawing.Size(78, 24)
        Me.chkSpecial.TabIndex = 0
        Me.chkSpecial.Text = "!%@#"
        Me.chkSpecial.UseVisualStyleBackColor = True
        '
        'chkDigits
        '
        Me.chkDigits.AutoSize = True
        Me.chkDigits.Checked = True
        Me.chkDigits.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDigits.Location = New System.Drawing.Point(194, 92)
        Me.chkDigits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkDigits.Name = "chkDigits"
        Me.chkDigits.Size = New System.Drawing.Size(66, 24)
        Me.chkDigits.TabIndex = 0
        Me.chkDigits.Text = "0 - 9"
        Me.chkDigits.UseVisualStyleBackColor = True
        '
        'chkLowerAZ
        '
        Me.chkLowerAZ.AutoSize = True
        Me.chkLowerAZ.Checked = True
        Me.chkLowerAZ.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLowerAZ.Location = New System.Drawing.Point(279, 64)
        Me.chkLowerAZ.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkLowerAZ.Name = "chkLowerAZ"
        Me.chkLowerAZ.Size = New System.Drawing.Size(65, 24)
        Me.chkLowerAZ.TabIndex = 0
        Me.chkLowerAZ.Text = "a - z"
        Me.chkLowerAZ.UseVisualStyleBackColor = True
        '
        'chkUpperAZ
        '
        Me.chkUpperAZ.AutoSize = True
        Me.chkUpperAZ.Checked = True
        Me.chkUpperAZ.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUpperAZ.Location = New System.Drawing.Point(194, 64)
        Me.chkUpperAZ.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkUpperAZ.Name = "chkUpperAZ"
        Me.chkUpperAZ.Size = New System.Drawing.Size(69, 24)
        Me.chkUpperAZ.TabIndex = 0
        Me.chkUpperAZ.Text = "A - Z"
        Me.chkUpperAZ.UseVisualStyleBackColor = True
        '
        'LabelPasswordLength
        '
        Me.LabelPasswordLength.AutoSize = True
        Me.LabelPasswordLength.Location = New System.Drawing.Point(45, 31)
        Me.LabelPasswordLength.Name = "LabelPasswordLength"
        Me.LabelPasswordLength.Size = New System.Drawing.Size(136, 20)
        Me.LabelPasswordLength.TabIndex = 0
        Me.LabelPasswordLength.Text = "Password Length:"
        '
        'NumericUpDownPasswordLength
        '
        Me.NumericUpDownPasswordLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDownPasswordLength.Location = New System.Drawing.Point(194, 26)
        Me.NumericUpDownPasswordLength.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumericUpDownPasswordLength.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumericUpDownPasswordLength.Name = "NumericUpDownPasswordLength"
        Me.NumericUpDownPasswordLength.Size = New System.Drawing.Size(151, 28)
        Me.NumericUpDownPasswordLength.TabIndex = 0
        Me.NumericUpDownPasswordLength.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(178, 151)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(235, 31)
        Me.txtPassword.TabIndex = 3
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(90, 158)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(82, 20)
        Me.LabelPassword.TabIndex = 0
        Me.LabelPassword.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(178, 109)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(235, 31)
        Me.txtUsername.TabIndex = 2
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(85, 117)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(87, 20)
        Me.LabelUsername.TabIndex = 0
        Me.LabelUsername.Text = "Username:"
        '
        'LabelNameOrUrl
        '
        Me.LabelNameOrUrl.AutoSize = True
        Me.LabelNameOrUrl.Location = New System.Drawing.Point(62, 74)
        Me.LabelNameOrUrl.Name = "LabelNameOrUrl"
        Me.LabelNameOrUrl.Size = New System.Drawing.Size(110, 20)
        Me.LabelNameOrUrl.TabIndex = 0
        Me.LabelNameOrUrl.Text = "Name or URL:"
        '
        'txtNameOrUrl
        '
        Me.txtNameOrUrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameOrUrl.Location = New System.Drawing.Point(178, 68)
        Me.txtNameOrUrl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNameOrUrl.Name = "txtNameOrUrl"
        Me.txtNameOrUrl.Size = New System.Drawing.Size(235, 31)
        Me.txtNameOrUrl.TabIndex = 1
        '
        'FormNewOrUpdatePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 370)
        Me.Controls.Add(Me.btnPassword)
        Me.Controls.Add(Me.grpPasswordGenerator)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.txtNameOrUrl)
        Me.Controls.Add(Me.LabelNameOrUrl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormNewOrUpdatePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Password"
        Me.grpPasswordGenerator.ResumeLayout(False)
        Me.grpPasswordGenerator.PerformLayout()
        CType(Me.NumericUpDownPasswordLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPassword As Button
    Friend WithEvents grpPasswordGenerator As GroupBox
    Friend WithEvents txtGenerated As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents LabelPasswordChars As Label
    Friend WithEvents chkSpecial As CheckBox
    Friend WithEvents chkDigits As CheckBox
    Friend WithEvents chkLowerAZ As CheckBox
    Friend WithEvents chkUpperAZ As CheckBox
    Friend WithEvents LabelPasswordLength As Label
    Friend WithEvents NumericUpDownPasswordLength As NumericUpDown
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelNameOrUrl As Label
    Friend WithEvents txtNameOrUrl As TextBox
End Class
