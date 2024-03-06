<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDllList
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDllList))
        Me.ListBoxItem = New System.Windows.Forms.ListBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxItem
        '
        Me.ListBoxItem.BackColor = System.Drawing.Color.White
        Me.ListBoxItem.FormattingEnabled = True
        Me.ListBoxItem.ItemHeight = 18
        Me.ListBoxItem.Location = New System.Drawing.Point(9, 9)
        Me.ListBoxItem.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxItem.Name = "ListBoxItem"
        Me.ListBoxItem.Size = New System.Drawing.Size(404, 454)
        Me.ListBoxItem.TabIndex = 0
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(171, 474)
        Me.ButtonAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(112, 38)
        Me.ButtonAdd.TabIndex = 1
        Me.ButtonAdd.Text = "新增"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(292, 474)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(118, 38)
        Me.ButtonDelete.TabIndex = 2
        Me.ButtonDelete.Text = "刪除"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'FormDllList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(425, 525)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ListBoxItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDllList"
        Me.Text = "DLL清單列表"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxItem As System.Windows.Forms.ListBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
End Class
