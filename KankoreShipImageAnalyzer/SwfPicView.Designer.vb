<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SwfPicView
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.llbLeft = New System.Windows.Forms.LinkLabel()
        Me.llbRight = New System.Windows.Forms.LinkLabel()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMain
        '
        Me.picMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(150, 150)
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'llbLeft
        '
        Me.llbLeft.ActiveLinkColor = System.Drawing.Color.Black
        Me.llbLeft.AutoSize = True
        Me.llbLeft.BackColor = System.Drawing.Color.Transparent
        Me.llbLeft.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.llbLeft.LinkColor = System.Drawing.Color.Black
        Me.llbLeft.Location = New System.Drawing.Point(13, 9)
        Me.llbLeft.Name = "llbLeft"
        Me.llbLeft.Size = New System.Drawing.Size(12, 12)
        Me.llbLeft.TabIndex = 1
        Me.llbLeft.TabStop = True
        Me.llbLeft.Text = "<"
        Me.llbLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'llbRight
        '
        Me.llbRight.ActiveLinkColor = System.Drawing.Color.Black
        Me.llbRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llbRight.AutoSize = True
        Me.llbRight.BackColor = System.Drawing.Color.Transparent
        Me.llbRight.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.llbRight.LinkColor = System.Drawing.Color.Black
        Me.llbRight.Location = New System.Drawing.Point(126, 9)
        Me.llbRight.Name = "llbRight"
        Me.llbRight.Size = New System.Drawing.Size(12, 12)
        Me.llbRight.TabIndex = 2
        Me.llbRight.TabStop = True
        Me.llbRight.Text = ">"
        Me.llbRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SwfPicView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.llbRight)
        Me.Controls.Add(Me.llbLeft)
        Me.Controls.Add(Me.picMain)
        Me.Name = "SwfPicView"
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMain As PictureBox
    Friend WithEvents llbLeft As LinkLabel
    Friend WithEvents llbRight As LinkLabel
End Class
