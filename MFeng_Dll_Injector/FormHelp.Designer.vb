<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHelp
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
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHelp))
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PictureLogo = New System.Windows.Forms.PictureBox()
        Me.LabelContent = New System.Windows.Forms.Label()
        Me.LinkLabelPowered = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(288, 18)
        Me.LabelTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(303, 40)
        Me.LabelTitle.TabIndex = 10
        Me.LabelTitle.Text = "MFeng Dll Injector"
        '
        'PictureLogo
        '
        Me.PictureLogo.Image = CType(resources.GetObject("PictureLogo.Image"), System.Drawing.Image)
        Me.PictureLogo.Location = New System.Drawing.Point(26, 18)
        Me.PictureLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureLogo.Name = "PictureLogo"
        Me.PictureLogo.Size = New System.Drawing.Size(233, 252)
        Me.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureLogo.TabIndex = 9
        Me.PictureLogo.TabStop = False
        '
        'LabelContent
        '
        Me.LabelContent.AutoSize = True
        Me.LabelContent.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelContent.Location = New System.Drawing.Point(290, 72)
        Me.LabelContent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelContent.Name = "LabelContent"
        Me.LabelContent.Size = New System.Drawing.Size(326, 24)
        Me.LabelContent.TabIndex = 11
        Me.LabelContent.Text = "歡迎使用MFeng Dll Injector v1.0"
        '
        'LinkLabelPowered
        '
        Me.LinkLabelPowered.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabelPowered.AutoSize = True
        Me.LinkLabelPowered.Location = New System.Drawing.Point(808, 252)
        Me.LinkLabelPowered.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabelPowered.Name = "LinkLabelPowered"
        Me.LinkLabelPowered.Size = New System.Drawing.Size(133, 18)
        Me.LinkLabelPowered.TabIndex = 12
        Me.LinkLabelPowered.TabStop = True
        Me.LinkLabelPowered.Text = "Powered By. Dino"
        '
        'formHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 304)
        Me.Controls.Add(Me.LinkLabelPowered)
        Me.Controls.Add(Me.LabelContent)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formHelp"
        Me.Text = "說明"
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitle As Label
    Friend WithEvents PictureLogo As PictureBox
    Friend WithEvents LabelContent As Label
    Friend WithEvents LinkLabelPowered As LinkLabel
End Class
