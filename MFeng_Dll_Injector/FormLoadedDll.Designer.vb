<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoadedDll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoadedDll))
        Me.ListBoxDll = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBoxDll
        '
        Me.ListBoxDll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxDll.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListBoxDll.FormattingEnabled = True
        Me.ListBoxDll.ItemHeight = 18
        Me.ListBoxDll.Location = New System.Drawing.Point(0, 0)
        Me.ListBoxDll.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxDll.Name = "ListBoxDll"
        Me.ListBoxDll.Size = New System.Drawing.Size(906, 472)
        Me.ListBoxDll.TabIndex = 0
        '
        'FormLoadedDll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 471)
        Me.Controls.Add(Me.ListBoxDll)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormLoadedDll"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxDll As System.Windows.Forms.ListBox
End Class
