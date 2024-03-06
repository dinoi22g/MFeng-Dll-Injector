<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ListviewProcesses = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuProcesses = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.查看已載入DllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.操作OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.注入IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.刷新RToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.刷新RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DLL清單DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.說明QToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProgressBarLoading = New System.Windows.Forms.ToolStripProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxMessage = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuProcesses.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListviewProcesses
        '
        Me.ListviewProcesses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListviewProcesses.BackColor = System.Drawing.SystemColors.Window
        Me.ListviewProcesses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListviewProcesses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListviewProcesses.ContextMenuStrip = Me.ContextMenuProcesses
        Me.ListviewProcesses.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ListviewProcesses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListviewProcesses.FullRowSelect = True
        Me.ListviewProcesses.HideSelection = False
        Me.ListviewProcesses.Location = New System.Drawing.Point(1, 37)
        Me.ListviewProcesses.Margin = New System.Windows.Forms.Padding(4)
        Me.ListviewProcesses.MultiSelect = False
        Me.ListviewProcesses.Name = "ListviewProcesses"
        Me.ListviewProcesses.Size = New System.Drawing.Size(898, 850)
        Me.ListviewProcesses.TabIndex = 0
        Me.ListviewProcesses.UseCompatibleStateImageBehavior = False
        Me.ListviewProcesses.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "名稱"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "PID"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "路徑"
        Me.ColumnHeader3.Width = 300
        '
        'ContextMenuProcesses
        '
        Me.ContextMenuProcesses.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuProcesses.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.查看已載入DllToolStripMenuItem})
        Me.ContextMenuProcesses.Name = "ContextMenuProcesses"
        Me.ContextMenuProcesses.Size = New System.Drawing.Size(241, 67)
        '
        '查看已載入DllToolStripMenuItem
        '
        Me.查看已載入DllToolStripMenuItem.Name = "查看已載入DllToolStripMenuItem"
        Me.查看已載入DllToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
        Me.查看已載入DllToolStripMenuItem.Text = "查看已載入Dll"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.操作OToolStripMenuItem, Me.刷新RToolStripMenuItem, Me.說明QToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(898, 31)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '操作OToolStripMenuItem
        '
        Me.操作OToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.注入IToolStripMenuItem, Me.刷新RToolStripMenuItem1})
        Me.操作OToolStripMenuItem.Name = "操作OToolStripMenuItem"
        Me.操作OToolStripMenuItem.Size = New System.Drawing.Size(89, 27)
        Me.操作OToolStripMenuItem.Text = "操作(&O)"
        '
        '注入IToolStripMenuItem
        '
        Me.注入IToolStripMenuItem.Enabled = False
        Me.注入IToolStripMenuItem.Name = "注入IToolStripMenuItem"
        Me.注入IToolStripMenuItem.Size = New System.Drawing.Size(170, 34)
        Me.注入IToolStripMenuItem.Text = "注入(&I)"
        '
        '刷新RToolStripMenuItem1
        '
        Me.刷新RToolStripMenuItem1.Name = "刷新RToolStripMenuItem1"
        Me.刷新RToolStripMenuItem1.Size = New System.Drawing.Size(170, 34)
        Me.刷新RToolStripMenuItem1.Text = "刷新(&R)"
        '
        '刷新RToolStripMenuItem
        '
        Me.刷新RToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DLL清單DToolStripMenuItem})
        Me.刷新RToolStripMenuItem.Name = "刷新RToolStripMenuItem"
        Me.刷新RToolStripMenuItem.Size = New System.Drawing.Size(92, 27)
        Me.刷新RToolStripMenuItem.Text = "視窗(&W)"
        '
        'DLL清單DToolStripMenuItem
        '
        Me.DLL清單DToolStripMenuItem.Name = "DLL清單DToolStripMenuItem"
        Me.DLL清單DToolStripMenuItem.Size = New System.Drawing.Size(204, 34)
        Me.DLL清單DToolStripMenuItem.Text = "DLL清單(&D)"
        '
        '說明QToolStripMenuItem
        '
        Me.說明QToolStripMenuItem.Name = "說明QToolStripMenuItem"
        Me.說明QToolStripMenuItem.Size = New System.Drawing.Size(88, 27)
        Me.說明QToolStripMenuItem.Text = "說明(&H)"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Window
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBarLoading})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1097)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(898, 30)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProgressBarLoading
        '
        Me.ProgressBarLoading.Name = "ProgressBarLoading"
        Me.ProgressBarLoading.Size = New System.Drawing.Size(300, 22)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RichTextBoxMessage)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(1, 894)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(897, 200)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "結果輸出"
        '
        'RichTextBoxMessage
        '
        Me.RichTextBoxMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxMessage.BackColor = System.Drawing.SystemColors.Window
        Me.RichTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBoxMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RichTextBoxMessage.Location = New System.Drawing.Point(-1, 26)
        Me.RichTextBoxMessage.Name = "RichTextBoxMessage"
        Me.RichTextBoxMessage.ReadOnly = True
        Me.RichTextBoxMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBoxMessage.Size = New System.Drawing.Size(898, 174)
        Me.RichTextBoxMessage.TabIndex = 17
        Me.RichTextBoxMessage.Text = ""
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(898, 1127)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ListviewProcesses)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMain"
        Me.Text = "MFeng Dll Injector v1.0"
        Me.ContextMenuProcesses.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListviewProcesses As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 說明QToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 刷新RToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 操作OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 注入IToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 刷新RToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DLL清單DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ProgressBarLoading As ToolStripProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBoxMessage As RichTextBox
    Friend WithEvents ContextMenuProcesses As ContextMenuStrip
    Friend WithEvents 查看已載入DllToolStripMenuItem As ToolStripMenuItem
End Class
