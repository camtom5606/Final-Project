<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ToolStripMain = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonNewPassword = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSearchButton = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBoxSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButtonSearchPassword = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewAccounts = New System.Windows.Forms.DataGridView()
        Me.ColumnURL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCopyPassword = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColumnUpdateButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColumnDeleteButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ToolStripButtonShowAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripMain.SuspendLayout()
        CType(Me.DataGridViewAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripMain
        '
        Me.ToolStripMain.AutoSize = False
        Me.ToolStripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonNewPassword, Me.ToolStripSearchButton, Me.ToolStripTextBoxSearch, Me.ToolStripButtonSearchPassword, Me.ToolStripButtonShowAll})
        Me.ToolStripMain.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMain.Name = "ToolStripMain"
        Me.ToolStripMain.Size = New System.Drawing.Size(1138, 56)
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
        'ToolStripSearchButton
        '
        Me.ToolStripSearchButton.Name = "ToolStripSearchButton"
        Me.ToolStripSearchButton.Size = New System.Drawing.Size(68, 53)
        Me.ToolStripSearchButton.Text = "Search:"
        '
        'ToolStripTextBoxSearch
        '
        Me.ToolStripTextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBoxSearch.Name = "ToolStripTextBoxSearch"
        Me.ToolStripTextBoxSearch.Size = New System.Drawing.Size(225, 56)
        '
        'ToolStripButtonSearchPassword
        '
        Me.ToolStripButtonSearchPassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonSearchPassword.Image = CType(resources.GetObject("ToolStripButtonSearchPassword.Image"), System.Drawing.Image)
        Me.ToolStripButtonSearchPassword.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSearchPassword.Name = "ToolStripButtonSearchPassword"
        Me.ToolStripButtonSearchPassword.Size = New System.Drawing.Size(149, 53)
        Me.ToolStripButtonSearchPassword.Text = "Search Password"
        '
        'DataGridViewAccounts
        '
        Me.DataGridViewAccounts.AllowUserToAddRows = False
        Me.DataGridViewAccounts.AllowUserToDeleteRows = False
        Me.DataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnURL, Me.ColumnUsername, Me.ColumnCopyPassword, Me.ColumnUpdateButton, Me.ColumnDeleteButton})
        Me.DataGridViewAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewAccounts.Location = New System.Drawing.Point(0, 56)
        Me.DataGridViewAccounts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewAccounts.Name = "DataGridViewAccounts"
        Me.DataGridViewAccounts.ReadOnly = True
        Me.DataGridViewAccounts.RowTemplate.Height = 24
        Me.DataGridViewAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewAccounts.Size = New System.Drawing.Size(1138, 578)
        Me.DataGridViewAccounts.TabIndex = 2
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
        'ColumnCopyPassword
        '
        Me.ColumnCopyPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColumnCopyPassword.HeaderText = "Copy Password to Clipboard"
        Me.ColumnCopyPassword.Name = "ColumnCopyPassword"
        Me.ColumnCopyPassword.ReadOnly = True
        Me.ColumnCopyPassword.Text = "Copy Password to Clipboard"
        Me.ColumnCopyPassword.UseColumnTextForButtonValue = True
        '
        'ColumnUpdateButton
        '
        Me.ColumnUpdateButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ColumnUpdateButton.HeaderText = "Update"
        Me.ColumnUpdateButton.Name = "ColumnUpdateButton"
        Me.ColumnUpdateButton.ReadOnly = True
        Me.ColumnUpdateButton.Text = "Update"
        Me.ColumnUpdateButton.UseColumnTextForButtonValue = True
        Me.ColumnUpdateButton.Width = 68
        '
        'ColumnDeleteButton
        '
        Me.ColumnDeleteButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ColumnDeleteButton.HeaderText = "Delete"
        Me.ColumnDeleteButton.Name = "ColumnDeleteButton"
        Me.ColumnDeleteButton.ReadOnly = True
        Me.ColumnDeleteButton.Text = "Delete"
        Me.ColumnDeleteButton.UseColumnTextForButtonValue = True
        Me.ColumnDeleteButton.Width = 62
        '
        'ToolStripButtonShowAll
        '
        Me.ToolStripButtonShowAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButtonShowAll.Image = CType(resources.GetObject("ToolStripButtonShowAll.Image"), System.Drawing.Image)
        Me.ToolStripButtonShowAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonShowAll.Name = "ToolStripButtonShowAll"
        Me.ToolStripButtonShowAll.Size = New System.Drawing.Size(160, 53)
        Me.ToolStripButtonShowAll.Text = "Show all Accounts"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 634)
        Me.Controls.Add(Me.DataGridViewAccounts)
        Me.Controls.Add(Me.ToolStripMain)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Manager"
        Me.ToolStripMain.ResumeLayout(False)
        Me.ToolStripMain.PerformLayout()
        CType(Me.DataGridViewAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripMain As ToolStrip
    Friend WithEvents ToolStripButtonNewPassword As ToolStripButton
    Friend WithEvents ToolStripSearchButton As ToolStripLabel
    Friend WithEvents ToolStripTextBoxSearch As ToolStripTextBox
    Friend WithEvents ToolStripButtonSearchPassword As ToolStripButton
    Friend WithEvents DataGridViewAccounts As DataGridView
    Friend WithEvents ColumnURL As DataGridViewTextBoxColumn
    Friend WithEvents ColumnUsername As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCopyPassword As DataGridViewButtonColumn
    Friend WithEvents ColumnUpdateButton As DataGridViewButtonColumn
    Friend WithEvents ColumnDeleteButton As DataGridViewButtonColumn
    Friend WithEvents ToolStripButtonShowAll As ToolStripButton
End Class
