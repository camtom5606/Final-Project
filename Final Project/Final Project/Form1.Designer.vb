<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolStripMain = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonNewPassword = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBoxSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.DataGridViewAccounts = New System.Windows.Forms.DataGridView()
        Me.ColumnURL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnUpdateButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColumnDeleteButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ToolStripMain.SuspendLayout()
        CType(Me.DataGridViewAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripMain
        '
        Me.ToolStripMain.AutoSize = False
        Me.ToolStripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNewPassword, Me.ToolStripLabel1, Me.ToolStripTextBoxSearch})
        Me.ToolStripMain.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMain.Name = "ToolStripMain"
        Me.ToolStripMain.Size = New System.Drawing.Size(899, 56)
        Me.ToolStripMain.TabIndex = 0
        Me.ToolStripMain.Text = "ToolStrip1"
        '
        'ToolStripButtonNewPassword
        '
        Me.ToolStripButtonNewPassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonNewPassword.Image = CType(resources.GetObject("ToolStripButtonNewPassword.Image"), System.Drawing.Image)
        Me.ToolStripButtonNewPassword.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNewPassword.Name = "ToolStripButtonNewPassword"
        Me.ToolStripButtonNewPassword.Size = New System.Drawing.Size(132, 53)
        Me.ToolStripButtonNewPassword.Text = "New Password"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(68, 53)
        Me.ToolStripLabel1.Text = "Search:"
        '
        'ToolStripTextBoxSearch
        '
        Me.ToolStripTextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBoxSearch.Name = "ToolStripTextBoxSearch"
        Me.ToolStripTextBoxSearch.Size = New System.Drawing.Size(112, 56)
        '
        'DataGridViewAccounts
        '
        Me.DataGridViewAccounts.AllowUserToAddRows = False
        Me.DataGridViewAccounts.AllowUserToDeleteRows = False
        Me.DataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnURL, Me.ColumnUsername, Me.ColumnPassword, Me.ColumnUpdateButton, Me.ColumnDeleteButton})
        Me.DataGridViewAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewAccounts.Location = New System.Drawing.Point(0, 56)
        Me.DataGridViewAccounts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewAccounts.Name = "DataGridViewAccounts"
        Me.DataGridViewAccounts.ReadOnly = True
        Me.DataGridViewAccounts.RowTemplate.Height = 28
        Me.DataGridViewAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewAccounts.Size = New System.Drawing.Size(899, 578)
        Me.DataGridViewAccounts.TabIndex = 1
        '
        'ColumnURL
        '
        Me.ColumnURL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnURL.HeaderText = "URL or Name"
        Me.ColumnURL.Name = "ColumnURL"
        Me.ColumnURL.ReadOnly = True
        '
        'ColumnUsername
        '
        Me.ColumnUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnUsername.HeaderText = "Username"
        Me.ColumnUsername.Name = "ColumnUsername"
        Me.ColumnUsername.ReadOnly = True
        '
        'ColumnPassword
        '
        Me.ColumnPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnPassword.HeaderText = "Password"
        Me.ColumnPassword.Name = "ColumnPassword"
        Me.ColumnPassword.ReadOnly = True
        '
        'ColumnUpdateButton
        '
        Me.ColumnUpdateButton.HeaderText = "Update"
        Me.ColumnUpdateButton.Name = "ColumnUpdateButton"
        Me.ColumnUpdateButton.ReadOnly = True
        Me.ColumnUpdateButton.Text = "Update"
        Me.ColumnUpdateButton.UseColumnTextForButtonValue = True
        '
        'ColumnDeleteButton
        '
        Me.ColumnDeleteButton.HeaderText = "Delete"
        Me.ColumnDeleteButton.Name = "ColumnDeleteButton"
        Me.ColumnDeleteButton.ReadOnly = True
        Me.ColumnDeleteButton.Text = "Delete"
        Me.ColumnDeleteButton.UseColumnTextForButtonValue = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 634)
        Me.Controls.Add(Me.DataGridViewAccounts)
        Me.Controls.Add(Me.ToolStripMain)
        Me.Name = "frmMain"
        Me.Text = "Password Manager"
        Me.ToolStripMain.ResumeLayout(False)
        Me.ToolStripMain.PerformLayout()
        CType(Me.DataGridViewAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripMain As ToolStrip
    Friend WithEvents ToolStripButtonNewPassword As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripTextBoxSearch As ToolStripTextBox
    Friend WithEvents DataGridViewAccounts As DataGridView
    Friend WithEvents ColumnURL As DataGridViewTextBoxColumn
    Friend WithEvents ColumnUsername As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPassword As DataGridViewTextBoxColumn
    Friend WithEvents ColumnUpdateButton As DataGridViewButtonColumn
    Friend WithEvents ColumnDeleteButton As DataGridViewButtonColumn
End Class
