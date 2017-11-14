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
        Dim txtGeneratedPassword As System.Windows.Forms.TextBox
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnCreatePassword = New System.Windows.Forms.Button()
        Me.grpPassword = New System.Windows.Forms.GroupBox()
        Me.LabelPasswordLength = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumUpDownPasswordL = New System.Windows.Forms.NumericUpDown()
        Me.ChkUpperCase = New System.Windows.Forms.CheckBox()
        Me.chkLowerCase = New System.Windows.Forms.CheckBox()
        Me.chkNumeric = New System.Windows.Forms.CheckBox()
        Me.chkSpecialChar = New System.Windows.Forms.CheckBox()
        Me.BtnGenerate = New System.Windows.Forms.Button()
        txtGeneratedPassword = New System.Windows.Forms.TextBox()
        Me.grpPassword.SuspendLayout()
        CType(Me.NumUpDownPasswordL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(34, 48)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(110, 20)
        Me.LabelName.TabIndex = 0
        Me.LabelName.Text = "Name or URL:"
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(61, 101)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(87, 20)
        Me.LabelUsername.TabIndex = 0
        Me.LabelUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(66, 159)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(82, 20)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Password:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(154, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(227, 28)
        Me.txtName.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(154, 153)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(227, 28)
        Me.txtPassword.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(154, 95)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(227, 28)
        Me.txtUsername.TabIndex = 2
        '
        'btnCreatePassword
        '
        Me.btnCreatePassword.Location = New System.Drawing.Point(154, 194)
        Me.btnCreatePassword.Name = "btnCreatePassword"
        Me.btnCreatePassword.Size = New System.Drawing.Size(227, 48)
        Me.btnCreatePassword.TabIndex = 4
        Me.btnCreatePassword.Text = "Create Password"
        Me.btnCreatePassword.UseVisualStyleBackColor = True
        '
        'grpPassword
        '
        Me.grpPassword.Controls.Add(txtGeneratedPassword)
        Me.grpPassword.Controls.Add(Me.BtnGenerate)
        Me.grpPassword.Controls.Add(Me.chkSpecialChar)
        Me.grpPassword.Controls.Add(Me.chkNumeric)
        Me.grpPassword.Controls.Add(Me.chkLowerCase)
        Me.grpPassword.Controls.Add(Me.ChkUpperCase)
        Me.grpPassword.Controls.Add(Me.NumUpDownPasswordL)
        Me.grpPassword.Controls.Add(Me.Label2)
        Me.grpPassword.Controls.Add(Me.LabelPasswordLength)
        Me.grpPassword.Location = New System.Drawing.Point(400, 33)
        Me.grpPassword.Name = "grpPassword"
        Me.grpPassword.Size = New System.Drawing.Size(435, 325)
        Me.grpPassword.TabIndex = 0
        Me.grpPassword.TabStop = False
        Me.grpPassword.Text = "Password Generator"
        '
        'LabelPasswordLength
        '
        Me.LabelPasswordLength.AutoSize = True
        Me.LabelPasswordLength.Location = New System.Drawing.Point(28, 45)
        Me.LabelPasswordLength.Name = "LabelPasswordLength"
        Me.LabelPasswordLength.Size = New System.Drawing.Size(136, 20)
        Me.LabelPasswordLength.TabIndex = 0
        Me.LabelPasswordLength.Text = "Password Length:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password Characters:"
        '
        'NumUpDownPasswordL
        '
        Me.NumUpDownPasswordL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumUpDownPasswordL.Location = New System.Drawing.Point(190, 39)
        Me.NumUpDownPasswordL.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumUpDownPasswordL.Name = "NumUpDownPasswordL"
        Me.NumUpDownPasswordL.Size = New System.Drawing.Size(175, 28)
        Me.NumUpDownPasswordL.TabIndex = 5
        Me.NumUpDownPasswordL.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'ChkUpperCase
        '
        Me.ChkUpperCase.AutoSize = True
        Me.ChkUpperCase.Checked = True
        Me.ChkUpperCase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkUpperCase.Location = New System.Drawing.Point(190, 94)
        Me.ChkUpperCase.Name = "ChkUpperCase"
        Me.ChkUpperCase.Size = New System.Drawing.Size(69, 24)
        Me.ChkUpperCase.TabIndex = 6
        Me.ChkUpperCase.Text = "A - Z"
        Me.ChkUpperCase.UseVisualStyleBackColor = True
        '
        'chkLowerCase
        '
        Me.chkLowerCase.AutoSize = True
        Me.chkLowerCase.Checked = True
        Me.chkLowerCase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLowerCase.Location = New System.Drawing.Point(277, 93)
        Me.chkLowerCase.Name = "chkLowerCase"
        Me.chkLowerCase.Size = New System.Drawing.Size(65, 24)
        Me.chkLowerCase.TabIndex = 7
        Me.chkLowerCase.Text = "a - z"
        Me.chkLowerCase.UseVisualStyleBackColor = True
        '
        'chkNumeric
        '
        Me.chkNumeric.AutoSize = True
        Me.chkNumeric.Checked = True
        Me.chkNumeric.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNumeric.Location = New System.Drawing.Point(190, 126)
        Me.chkNumeric.Name = "chkNumeric"
        Me.chkNumeric.Size = New System.Drawing.Size(66, 24)
        Me.chkNumeric.TabIndex = 8
        Me.chkNumeric.Text = "0 - 9"
        Me.chkNumeric.UseVisualStyleBackColor = True
        '
        'chkSpecialChar
        '
        Me.chkSpecialChar.AutoSize = True
        Me.chkSpecialChar.Location = New System.Drawing.Point(277, 126)
        Me.chkSpecialChar.Name = "chkSpecialChar"
        Me.chkSpecialChar.Size = New System.Drawing.Size(78, 24)
        Me.chkSpecialChar.TabIndex = 9
        Me.chkSpecialChar.Text = "!%@#"
        Me.chkSpecialChar.UseVisualStyleBackColor = True
        '
        'BtnGenerate
        '
        Me.BtnGenerate.Location = New System.Drawing.Point(23, 173)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(332, 47)
        Me.BtnGenerate.TabIndex = 10
        Me.BtnGenerate.Text = "Generate Password"
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'txtGeneratedPassword
        '
        txtGeneratedPassword.BackColor = System.Drawing.SystemColors.Control
        txtGeneratedPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtGeneratedPassword.Location = New System.Drawing.Point(23, 236)
        txtGeneratedPassword.Name = "txtGeneratedPassword"
        txtGeneratedPassword.ReadOnly = True
        txtGeneratedPassword.Size = New System.Drawing.Size(332, 44)
        txtGeneratedPassword.TabIndex = 0
        '
        'FormNewOrUpdatePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 370)
        Me.Controls.Add(Me.grpPassword)
        Me.Controls.Add(Me.btnCreatePassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.LabelName)
        Me.Name = "FormNewOrUpdatePassword"
        Me.Text = "FormNewOrUpdatePassword"
        Me.grpPassword.ResumeLayout(False)
        Me.grpPassword.PerformLayout()
        CType(Me.NumUpDownPasswordL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelName As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnCreatePassword As Button
    Friend WithEvents grpPassword As GroupBox
    Friend WithEvents BtnGenerate As Button
    Friend WithEvents chkSpecialChar As CheckBox
    Friend WithEvents chkNumeric As CheckBox
    Friend WithEvents chkLowerCase As CheckBox
    Friend WithEvents ChkUpperCase As CheckBox
    Friend WithEvents NumUpDownPasswordL As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelPasswordLength As Label
End Class
