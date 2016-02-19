<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.tccMain = New System.Windows.Forms.TabControl()
        Me.tabAll = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labType = New System.Windows.Forms.Label()
        Me.ckbAuto = New System.Windows.Forms.CheckBox()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.labName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstMes = New System.Windows.Forms.ListBox()
        Me.picBig = New System.Windows.Forms.PictureBox()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.tabAnalyze = New System.Windows.Forms.TabPage()
        Me.lsbAna = New System.Windows.Forms.ListBox()
        Me.btnAna = New System.Windows.Forms.Button()
        Me.tabOutputSelected = New System.Windows.Forms.TabPage()
        Me.psbShowLoad = New System.Windows.Forms.ProgressBar()
        Me.cbOnlyThis = New System.Windows.Forms.CheckBox()
        Me.lsvMain = New System.Windows.Forms.ListView()
        Me.labSOPName = New System.Windows.Forms.Label()
        Me.btnSOPRefresh = New System.Windows.Forms.Button()
        Me.btnSOPOutPutNow = New System.Windows.Forms.Button()
        Me.btnSOPSelectOutput = New System.Windows.Forms.Button()
        Me.btnSOPNext = New System.Windows.Forms.Button()
        Me.btnSOPLast = New System.Windows.Forms.Button()
        Me.pcbSOPMain = New System.Windows.Forms.PictureBox()
        Me.BtnSOPSearch = New System.Windows.Forms.Button()
        Me.txtSOPName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pcbDetail = New System.Windows.Forms.ProgressBar()
        Me.pcbMain = New System.Windows.Forms.ProgressBar()
        Me.btnTarget = New System.Windows.Forms.Button()
        Me.txtTarget = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelectCP = New System.Windows.Forms.Button()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.lab_Cache = New System.Windows.Forms.Label()
        Me.tccMain.SuspendLayout()
        Me.tabAll.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picBig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAnalyze.SuspendLayout()
        Me.tabOutputSelected.SuspendLayout()
        CType(Me.pcbSOPMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tccMain
        '
        Me.tccMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tccMain.Controls.Add(Me.tabAll)
        Me.tccMain.Controls.Add(Me.tabAnalyze)
        Me.tccMain.Controls.Add(Me.tabOutputSelected)
        Me.tccMain.Location = New System.Drawing.Point(1, 70)
        Me.tccMain.Name = "tccMain"
        Me.tccMain.SelectedIndex = 0
        Me.tccMain.Size = New System.Drawing.Size(909, 481)
        Me.tccMain.TabIndex = 24
        '
        'tabAll
        '
        Me.tabAll.Controls.Add(Me.Panel1)
        Me.tabAll.Location = New System.Drawing.Point(4, 22)
        Me.tabAll.Name = "tabAll"
        Me.tabAll.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAll.Size = New System.Drawing.Size(901, 455)
        Me.tabAll.TabIndex = 0
        Me.tabAll.Text = "すべてのデータを出力"
        Me.tabAll.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.labType)
        Me.Panel1.Controls.Add(Me.ckbAuto)
        Me.Panel1.Controls.Add(Me.btnMain)
        Me.Panel1.Controls.Add(Me.labName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Controls.Add(Me.btnSkip)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lstMes)
        Me.Panel1.Controls.Add(Me.picBig)
        Me.Panel1.Controls.Add(Me.picMain)
        Me.Panel1.Location = New System.Drawing.Point(3, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 446)
        Me.Panel1.TabIndex = 1
        '
        'labType
        '
        Me.labType.AutoSize = True
        Me.labType.Font = New System.Drawing.Font("ＭＳ 明朝", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.labType.Location = New System.Drawing.Point(144, 128)
        Me.labType.Name = "labType"
        Me.labType.Size = New System.Drawing.Size(0, 12)
        Me.labType.TabIndex = 21
        Me.labType.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ckbAuto
        '
        Me.ckbAuto.AutoSize = True
        Me.ckbAuto.Location = New System.Drawing.Point(192, 7)
        Me.ckbAuto.Name = "ckbAuto"
        Me.ckbAuto.Size = New System.Drawing.Size(127, 16)
        Me.ckbAuto.TabIndex = 20
        Me.ckbAuto.Text = "データを自動出力する"
        Me.ckbAuto.UseVisualStyleBackColor = True
        '
        'btnMain
        '
        Me.btnMain.Location = New System.Drawing.Point(341, 3)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(100, 45)
        Me.btnMain.TabIndex = 19
        Me.btnMain.Text = "開始する"
        Me.btnMain.UseVisualStyleBackColor = True
        '
        'labName
        '
        Me.labName.AutoSize = True
        Me.labName.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labName.Location = New System.Drawing.Point(87, 26)
        Me.labName.Name = "labName"
        Me.labName.Size = New System.Drawing.Size(57, 24)
        Me.labName.TabIndex = 18
        Me.labName.Text = "N/A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 12)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "今のファイル:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(341, 66)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(98, 28)
        Me.btnOK.TabIndex = 16
        Me.btnOK.Text = "あってる"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnSkip
        '
        Me.btnSkip.Location = New System.Drawing.Point(341, 100)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(98, 28)
        Me.btnSkip.TabIndex = 15
        Me.btnSkip.Text = "いらない"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtName.Location = New System.Drawing.Point(11, 67)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(308, 31)
        Me.txtName.TabIndex = 14
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 12)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "この名前は下に表示する図にあっていますか"
        '
        'lstMes
        '
        Me.lstMes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstMes.FormattingEnabled = True
        Me.lstMes.ItemHeight = 12
        Me.lstMes.Location = New System.Drawing.Point(461, 7)
        Me.lstMes.Name = "lstMes"
        Me.lstMes.Size = New System.Drawing.Size(424, 436)
        Me.lstMes.TabIndex = 12
        '
        'picBig
        '
        Me.picBig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picBig.ErrorImage = Global.KankoreShipImageAnalyzer.My.Resources.Resources.Big_Err_img
        Me.picBig.Image = Global.KankoreShipImageAnalyzer.My.Resources.Resources.Big_Err_img
        Me.picBig.InitialImage = Global.KankoreShipImageAnalyzer.My.Resources.Resources.Big_Err_img
        Me.picBig.Location = New System.Drawing.Point(237, 143)
        Me.picBig.Name = "picBig"
        Me.picBig.Size = New System.Drawing.Size(218, 300)
        Me.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBig.TabIndex = 1
        Me.picBig.TabStop = False
        '
        'picMain
        '
        Me.picMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picMain.ErrorImage = Global.KankoreShipImageAnalyzer.My.Resources.Resources.Main_Err_img
        Me.picMain.Image = Global.KankoreShipImageAnalyzer.My.Resources.Resources.Main_Err_img
        Me.picMain.InitialImage = Global.KankoreShipImageAnalyzer.My.Resources.Resources.Main_Err_img
        Me.picMain.Location = New System.Drawing.Point(13, 143)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(218, 300)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'tabAnalyze
        '
        Me.tabAnalyze.Controls.Add(Me.lsbAna)
        Me.tabAnalyze.Controls.Add(Me.btnAna)
        Me.tabAnalyze.Location = New System.Drawing.Point(4, 22)
        Me.tabAnalyze.Name = "tabAnalyze"
        Me.tabAnalyze.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAnalyze.Size = New System.Drawing.Size(901, 455)
        Me.tabAnalyze.TabIndex = 1
        Me.tabAnalyze.Text = "データアナライズ"
        Me.tabAnalyze.UseVisualStyleBackColor = True
        '
        'lsbAna
        '
        Me.lsbAna.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsbAna.FormattingEnabled = True
        Me.lsbAna.ItemHeight = 12
        Me.lsbAna.Location = New System.Drawing.Point(13, 78)
        Me.lsbAna.Name = "lsbAna"
        Me.lsbAna.Size = New System.Drawing.Size(878, 364)
        Me.lsbAna.TabIndex = 1
        '
        'btnAna
        '
        Me.btnAna.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAna.Location = New System.Drawing.Point(14, 18)
        Me.btnAna.Name = "btnAna"
        Me.btnAna.Size = New System.Drawing.Size(878, 48)
        Me.btnAna.TabIndex = 0
        Me.btnAna.Text = "アナライズする"
        Me.btnAna.UseVisualStyleBackColor = True
        '
        'tabOutputSelected
        '
        Me.tabOutputSelected.Controls.Add(Me.psbShowLoad)
        Me.tabOutputSelected.Controls.Add(Me.cbOnlyThis)
        Me.tabOutputSelected.Controls.Add(Me.lsvMain)
        Me.tabOutputSelected.Controls.Add(Me.labSOPName)
        Me.tabOutputSelected.Controls.Add(Me.btnSOPRefresh)
        Me.tabOutputSelected.Controls.Add(Me.btnSOPOutPutNow)
        Me.tabOutputSelected.Controls.Add(Me.btnSOPSelectOutput)
        Me.tabOutputSelected.Controls.Add(Me.btnSOPNext)
        Me.tabOutputSelected.Controls.Add(Me.btnSOPLast)
        Me.tabOutputSelected.Controls.Add(Me.pcbSOPMain)
        Me.tabOutputSelected.Controls.Add(Me.BtnSOPSearch)
        Me.tabOutputSelected.Controls.Add(Me.txtSOPName)
        Me.tabOutputSelected.Location = New System.Drawing.Point(4, 22)
        Me.tabOutputSelected.Name = "tabOutputSelected"
        Me.tabOutputSelected.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOutputSelected.Size = New System.Drawing.Size(901, 455)
        Me.tabOutputSelected.TabIndex = 2
        Me.tabOutputSelected.Text = "データを選択して出力"
        Me.tabOutputSelected.UseVisualStyleBackColor = True
        '
        'psbShowLoad
        '
        Me.psbShowLoad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.psbShowLoad.Location = New System.Drawing.Point(528, 424)
        Me.psbShowLoad.Name = "psbShowLoad"
        Me.psbShowLoad.Size = New System.Drawing.Size(330, 20)
        Me.psbShowLoad.TabIndex = 14
        Me.psbShowLoad.Visible = False
        '
        'cbOnlyThis
        '
        Me.cbOnlyThis.AutoSize = True
        Me.cbOnlyThis.Location = New System.Drawing.Point(342, 89)
        Me.cbOnlyThis.Name = "cbOnlyThis"
        Me.cbOnlyThis.Size = New System.Drawing.Size(156, 16)
        Me.cbOnlyThis.TabIndex = 13
        Me.cbOnlyThis.Text = "表示されるイメージだけ出力"
        Me.cbOnlyThis.UseVisualStyleBackColor = True
        '
        'lsvMain
        '
        Me.lsvMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lsvMain.FullRowSelect = True
        Me.lsvMain.Location = New System.Drawing.Point(7, 77)
        Me.lsvMain.MultiSelect = False
        Me.lsvMain.Name = "lsvMain"
        Me.lsvMain.Size = New System.Drawing.Size(329, 337)
        Me.lsvMain.TabIndex = 12
        Me.lsvMain.UseCompatibleStateImageBehavior = False
        Me.lsvMain.View = System.Windows.Forms.View.Details
        '
        'labSOPName
        '
        Me.labSOPName.AutoSize = True
        Me.labSOPName.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 18.0!, System.Drawing.FontStyle.Bold)
        Me.labSOPName.Location = New System.Drawing.Point(10, 50)
        Me.labSOPName.Name = "labSOPName"
        Me.labSOPName.Size = New System.Drawing.Size(57, 24)
        Me.labSOPName.TabIndex = 10
        Me.labSOPName.Text = "N/A"
        '
        'btnSOPRefresh
        '
        Me.btnSOPRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSOPRefresh.Location = New System.Drawing.Point(7, 424)
        Me.btnSOPRefresh.Name = "btnSOPRefresh"
        Me.btnSOPRefresh.Size = New System.Drawing.Size(330, 25)
        Me.btnSOPRefresh.TabIndex = 9
        Me.btnSOPRefresh.Text = "リストをリフレッシュする"
        Me.btnSOPRefresh.UseVisualStyleBackColor = True
        '
        'btnSOPOutPutNow
        '
        Me.btnSOPOutPutNow.Location = New System.Drawing.Point(343, 176)
        Me.btnSOPOutPutNow.Name = "btnSOPOutPutNow"
        Me.btnSOPOutPutNow.Size = New System.Drawing.Size(147, 41)
        Me.btnSOPOutPutNow.TabIndex = 8
        Me.btnSOPOutPutNow.Text = "このまま出力する"
        Me.btnSOPOutPutNow.UseVisualStyleBackColor = True
        '
        'btnSOPSelectOutput
        '
        Me.btnSOPSelectOutput.Location = New System.Drawing.Point(343, 129)
        Me.btnSOPSelectOutput.Name = "btnSOPSelectOutput"
        Me.btnSOPSelectOutput.Size = New System.Drawing.Size(147, 41)
        Me.btnSOPSelectOutput.TabIndex = 7
        Me.btnSOPSelectOutput.Text = "出力宛を選択して出力する"
        Me.btnSOPSelectOutput.UseVisualStyleBackColor = True
        '
        'btnSOPNext
        '
        Me.btnSOPNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSOPNext.Location = New System.Drawing.Point(864, 414)
        Me.btnSOPNext.Name = "btnSOPNext"
        Me.btnSOPNext.Size = New System.Drawing.Size(37, 38)
        Me.btnSOPNext.TabIndex = 6
        Me.btnSOPNext.Text = "＞"
        Me.btnSOPNext.UseVisualStyleBackColor = True
        '
        'btnSOPLast
        '
        Me.btnSOPLast.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSOPLast.Location = New System.Drawing.Point(485, 414)
        Me.btnSOPLast.Name = "btnSOPLast"
        Me.btnSOPLast.Size = New System.Drawing.Size(37, 38)
        Me.btnSOPLast.TabIndex = 4
        Me.btnSOPLast.Text = "＜"
        Me.btnSOPLast.UseVisualStyleBackColor = True
        '
        'pcbSOPMain
        '
        Me.pcbSOPMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbSOPMain.Image = Global.KankoreShipImageAnalyzer.My.Resources.Resources.Big_Err_img
        Me.pcbSOPMain.Location = New System.Drawing.Point(496, 6)
        Me.pcbSOPMain.Name = "pcbSOPMain"
        Me.pcbSOPMain.Size = New System.Drawing.Size(396, 443)
        Me.pcbSOPMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbSOPMain.TabIndex = 3
        Me.pcbSOPMain.TabStop = False
        '
        'BtnSOPSearch
        '
        Me.BtnSOPSearch.Location = New System.Drawing.Point(332, 7)
        Me.BtnSOPSearch.Name = "BtnSOPSearch"
        Me.BtnSOPSearch.Size = New System.Drawing.Size(132, 41)
        Me.BtnSOPSearch.TabIndex = 2
        Me.BtnSOPSearch.Text = "サーチ"
        Me.BtnSOPSearch.UseVisualStyleBackColor = True
        '
        'txtSOPName
        '
        Me.txtSOPName.Font = New System.Drawing.Font("ＭＳ Ｐ明朝", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtSOPName.Location = New System.Drawing.Point(7, 14)
        Me.txtSOPName.Name = "txtSOPName"
        Me.txtSOPName.Size = New System.Drawing.Size(319, 31)
        Me.txtSOPName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 590)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 12)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "今やっているファイルの進度"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 554)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "総進度"
        '
        'pcbDetail
        '
        Me.pcbDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbDetail.Location = New System.Drawing.Point(14, 605)
        Me.pcbDetail.Name = "pcbDetail"
        Me.pcbDetail.Size = New System.Drawing.Size(883, 18)
        Me.pcbDetail.TabIndex = 26
        '
        'pcbMain
        '
        Me.pcbMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbMain.Location = New System.Drawing.Point(14, 569)
        Me.pcbMain.Name = "pcbMain"
        Me.pcbMain.Size = New System.Drawing.Size(883, 18)
        Me.pcbMain.TabIndex = 25
        '
        'btnTarget
        '
        Me.btnTarget.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTarget.Location = New System.Drawing.Point(798, 43)
        Me.btnTarget.Name = "btnTarget"
        Me.btnTarget.Size = New System.Drawing.Size(75, 23)
        Me.btnTarget.TabIndex = 34
        Me.btnTarget.Text = "選択"
        Me.btnTarget.UseVisualStyleBackColor = True
        '
        'txtTarget
        '
        Me.txtTarget.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTarget.Location = New System.Drawing.Point(132, 45)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(659, 19)
        Me.txtTarget.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 12)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "データ保存フォルダー"
        '
        'btnSelectCP
        '
        Me.btnSelectCP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectCP.Location = New System.Drawing.Point(798, 10)
        Me.btnSelectCP.Name = "btnSelectCP"
        Me.btnSelectCP.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectCP.TabIndex = 31
        Me.btnSelectCP.Text = "選択"
        Me.btnSelectCP.UseVisualStyleBackColor = True
        '
        'txtCP
        '
        Me.txtCP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCP.Location = New System.Drawing.Point(132, 12)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(660, 19)
        Me.txtCP.TabIndex = 30
        '
        'lab_Cache
        '
        Me.lab_Cache.AutoSize = True
        Me.lab_Cache.Location = New System.Drawing.Point(17, 16)
        Me.lab_Cache.Name = "lab_Cache"
        Me.lab_Cache.Size = New System.Drawing.Size(90, 12)
        Me.lab_Cache.TabIndex = 29
        Me.lab_Cache.Text = "島風GOフォルダー"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 629)
        Me.Controls.Add(Me.btnTarget)
        Me.Controls.Add(Me.txtTarget)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelectCP)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.lab_Cache)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pcbDetail)
        Me.Controls.Add(Me.pcbMain)
        Me.Controls.Add(Me.tccMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(925, 667)
        Me.Name = "MainForm"
        Me.Text = "艦これ図鑑イメージ出力装置"
        Me.tccMain.ResumeLayout(False)
        Me.tabAll.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picBig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAnalyze.ResumeLayout(False)
        Me.tabOutputSelected.ResumeLayout(False)
        Me.tabOutputSelected.PerformLayout()
        CType(Me.pcbSOPMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tccMain As TabControl
    Friend WithEvents tabAll As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labType As Label
    Friend WithEvents ckbAuto As CheckBox
    Friend WithEvents btnMain As Button
    Friend WithEvents labName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnSkip As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lstMes As ListBox
    Friend WithEvents picBig As PictureBox
    Friend WithEvents picMain As PictureBox
    Friend WithEvents tabAnalyze As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pcbDetail As ProgressBar
    Friend WithEvents pcbMain As ProgressBar
    Friend WithEvents tabOutputSelected As TabPage
    Friend WithEvents btnTarget As Button
    Friend WithEvents txtTarget As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSelectCP As Button
    Friend WithEvents txtCP As TextBox
    Friend WithEvents lab_Cache As Label
    Friend WithEvents btnAna As Button
    Friend WithEvents labSOPName As Label
    Friend WithEvents BtnSOPSearch As Button
    Friend WithEvents txtSOPName As TextBox
    Friend WithEvents btnSOPRefresh As Button
    Friend WithEvents btnSOPOutPutNow As Button
    Friend WithEvents btnSOPSelectOutput As Button
    Friend WithEvents btnSOPNext As Button
    Friend WithEvents btnSOPLast As Button
    Friend WithEvents pcbSOPMain As PictureBox
    Friend WithEvents lsbAna As ListBox
    Friend WithEvents lsvMain As ListView
    Friend WithEvents cbOnlyThis As CheckBox
    Friend WithEvents psbShowLoad As ProgressBar
End Class
