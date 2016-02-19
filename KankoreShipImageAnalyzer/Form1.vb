Imports System.Drawing.Imaging
Imports System.IO
Imports DDW.Swf

Public Class MainForm
    Private Const AllGO = 1
    Private Const SkipGO = 2
    Private Const Start = 11
    Private Const Endding = 12
    Private Const AllDown = 3
    Private Const SkipDown = 4
    Private Const TextShipName = 2001
    Private Const TextShipFN = 2002
    Private Const TextShipType = 2003
    Private Const AnaAllDown = 3001
    Private Const AnaAllGO = 3002
    Private Const OutGO = 4001
    Private Const OutDown = 4002

    Dim mFileList As String()
    Dim mSkip As Boolean = False
    Dim ObjThread As Threading.Thread
    Dim Skiped As Boolean = False
#Region "FormChanges"
    Private Sub btnSelectCP_Click(sender As Object, e As EventArgs) Handles btnSelectCP.Click
        Dim mPath As String = Nothing 'Target image pool path
        Using nOpen As New System.Windows.Forms.FolderBrowserDialog
            nOpen.Description = "Select the Folder you want to store your image data."
            nOpen.ShowNewFolderButton = True
            nOpen.ShowDialog()
            If nOpen.SelectedPath IsNot Nothing Then
                If IO.Directory.Exists(nOpen.SelectedPath & "\cache\kcs\Resources\swf\ships") Then
                    mPath = nOpen.SelectedPath & "\cache\kcs\Resources\swf\ships"
                End If
            End If
        End Using
        'mPath = "J:\cache\kcs\resources\swf\ships"
        If Len(mPath) < 1 Then MsgBox("No Folder has been selected!!",, "ERROR") : Exit Sub
        Dim mfiles As String() = Directory.GetFiles(mPath, "*.swf")
        If mfiles.Count < 10 Then MsgBox("Wrong Folder!!",, "ERROR") : Exit Sub
        If txtTarget.Text = "" Then txtTarget.Text = mPath
        txtCP.Text = mPath
        mFileList = mfiles
        lstMes.Items.Add("Found " & mfiles.Count & "Files in " & txtCP.Text)
        btnMain.Enabled = True
    End Sub

    Private Sub btnTarget_Click(sender As Object, e As EventArgs) Handles btnTarget.Click
        Dim mPath As String = Nothing 'Target image pool path
        Using nOpen As New System.Windows.Forms.FolderBrowserDialog
            nOpen.Description = "Select the Folder you want to store your image data."
            nOpen.ShowNewFolderButton = True
            nOpen.ShowDialog()
            If nOpen.SelectedPath IsNot Nothing Then
                mPath = nOpen.SelectedPath
            End If
        End Using
        If Len(mPath) < 1 Then MsgBox("No Folder has been selected!!",, "ERROR") : Exit Sub
        txtTarget.Text = mPath
    End Sub



    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        If ObjThread.IsAlive Then
            'ObjThread.Resume()
            ObjThread.Abort()
            btnMain.Text = "開始する"
        Else
            ObjThread = New Threading.Thread(AddressOf DoStart)
            ObjThread.Start()
        End If
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        Skiped = True
        ObjThread.Resume()
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtName.Enabled = False
        btnMain.Enabled = False
        btnOK.Enabled = False
        btnSkip.Enabled = False
        ObjThread = New Threading.Thread(AddressOf DoStart)
        Prepare()

    End Sub

#End Region
    'Theard Operations
#Region "AllOutputActions"
    Private Sub DoStart()

        ButtonChanges(Start)
        ButtonChanges(AllDown)
        If File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\ShipData.dat") Then
            File.Delete(AppDomain.CurrentDomain.BaseDirectory & "ShipData.dat")
        End If
        PostProcessing(True, 0, mFileList.Count)
        '=====================================Read ShipID and Name===========================
        Dim lsNames As String() = Nothing
        Dim lsIDs As String() = Nothing
        Dim lsTypes As String() = Nothing
        Dim thisFile As String = My.Resources.List_Names
        Dim thisItems = Split(thisFile, vbCrLf)
        For i As Integer = 0 To thisItems.Count - 1
            Dim insStr = Split(thisItems(i), "|")
            ReDim Preserve lsNames(i + 1)
            ReDim Preserve lsIDs(i + 1)
            ReDim Preserve lsTypes(i + 1)
            Try
                lsIDs(i) = insStr(0)
                lsTypes(i) = insStr(2)
                lsNames(i) = insStr(1)
            Catch
            End Try
        Next
        '=====================================================================================
        Dim ii As Integer = 0

        '=====================================Open Swf File===================================
        Do Until ii = mFileList.Count
            Dim thisName As String = Nothing
            Dim reader As SwfReader = New SwfReader(System.IO.File.ReadAllBytes(mFileList(ii)))
            Dim swf As SwfCompilationUnit = New SwfCompilationUnit(reader)
            Dim lst = swf.Tags.FindAll(Function(x) _
               x.TagType = TagType.SymbolClass)

            Dim ShipFound As Boolean = False
            For Each it As ISwfTag In lst

                Dim sme = TryCast(it, SymbolClassTag)
                Dim thisData = Split(sme.Names(0), "_")
                Dim a As String() = Split(mFileList(ii), "\")
                Dim b As String() = Split(a(a.Count - 1), ".")
                PostText(TextShipFN, b(0))
                For ins As Integer = 0 To lsIDs.Count - 1
                    If thisData(1) = lsIDs(ins) Then 'If the ID matchs
                        '------------------------------Show Name and wait for user------------
                        thisName = lsIDs(ins) & "|" & b(0)
                        PostText(TextShipName, lsNames(ins))
                        PostText(TextShipType, lsTypes(ins))
                        ShipFound = True
                    End If
                Next
                If Not ShipFound Then
                    PostText(TextShipName, "Unknown_ID_" & thisData(1))
                    PostText(TextShipType, "Unknown_ID_" & thisData(1))
                End If
                Try
                    Dim lst1 = swf.Tags.FindAll(Function(x) _
                               x.TagType = TagType.DefineBits _
                               OrElse x.TagType = TagType.DefineBitsJPEG3 _
                               OrElse x.TagType = TagType.DefineBitsJPEG2)
                    Dim n As Integer = 1
                    For Each ita As ISwfTag In lst1
                        Dim tag = TryCast(ita, DefineBitsTag)
                        If tag.CharacterId = 17 Or tag.CharacterId = 5 Or tag.CharacterId = 3 Then
                            Dim bmp As Image = tag.ToBitmap
                            If bmp IsNot Nothing Then
                                If lst1.Count < 3 Then
                                    If tag.CharacterId = 3 Then
                                        ImgChage(True, bmp)
                                        ImgChage(False, My.Resources.Big_Err_img)
                                    End If
                                ElseIf lst1.Count > 3 And lst1.Count < 14 Then
                                    If tag.CharacterId = 9 Then ImgChage(False, bmp)
                                    If tag.CharacterId = 1 Then ImgChage(True, bmp)
                                Else
                                    If tag.CharacterId = 17 Then ImgChage(False, bmp)
                                    If tag.CharacterId = 5 Then ImgChage(True, bmp)
                                End If
                            End If
                        End If
                        n += 1
                    Next
                Catch ex As Exception

                End Try
                Skiped = False
                If Not ckbAuto.CheckState = CheckState.Checked Then
                    ButtonChanges(AllGO)
                    ObjThread.Suspend()
                    'Wait for User
                End If
                ButtonChanges(AllDown)
                If Not Skiped Then
                    '------------------------------Start Output Swf Operation-------------
                    Dim Tar As String = txtTarget.Text & "\" & txtName.Text
                    Dim picList = swf.Tags.FindAll(Function(x) _
                               x.TagType = TagType.DefineBits _
                               OrElse x.TagType = TagType.DefineBitsJPEG3 _
                               OrElse x.TagType = TagType.DefineBitsJPEG2)
                    Dim i3 As Integer = 1
                    For Each listTags As ISwfTag In picList
                        Dim thisTag = TryCast(listTags, DefineBitsTag)
                        If Not IO.Directory.Exists(Tar) Then
                            IO.Directory.CreateDirectory(Tar)
                        End If
                        Dim path As String
                        If picList.Count < 14 Then
                            path = String.Format(Tar & "\{0}-SP-{1}.png", b(0), thisTag.CharacterId)
                        Else
                            path = String.Format(Tar & "\{0}.png", thisTag.CharacterId)
                        End If
                        Dim bmp As Image = thisTag.ToBitmap
                        If bmp IsNot Nothing Then
                            bmp.Save(path, ImageFormat.Png)
                        End If

                        PostProcessing(False, i3, picList.Count)
                        i3 += 1
                    Next
                    PostMessage("Output " & i3 & " Files to """ & Tar & """ OK!")
                Else
                    PostMessage("Skiped!" & labName.Text)
                End If
            Next
            If ShipFound Then
                WriteFiles(AppDomain.CurrentDomain.BaseDirectory & "\ShipData.dat", thisName)
                AnaMessagePost(thisName)
            Else
                WriteFiles(AppDomain.CurrentDomain.BaseDirectory & "\ShipData.dat", "Unknown|" & thisName)
                AnaMessagePost("Unknown Ship Data: " & thisName)
            End If
            PostProcessing(True, ii, mFileList.Count)
            ii += 1
        Loop
        '=====================================================================================
        MsgBox("Done!")
        ButtonChanges(Endding)
        ObjThread.Abort()
    End Sub

    'Theard UI control
    Delegate Sub myPostMessage(ByVal Message As String)
    Dim mpm As myPostMessage
    Private Sub PostMessage(ByVal Message As String)
        If Me.InvokeRequired Then
            Me.Invoke(mpm, Message)
        Else
            If Message = "" Then
                lstMes.Items.Add("Unknown Error Occurred")
            ElseIf Message = "cls"
                lstMes.Items.Clear()
            Else
                lstMes.Items.Add(Message)
            End If
        End If
    End Sub
    Delegate Sub myPostProcessing(ByVal dev As Boolean, ByVal Value As Integer, ByVal Max As Integer)
    Dim mpp As myPostProcessing
    Private Sub PostProcessing(ByVal dev As Boolean, ByVal Value As Integer, ByVal Max As Integer)
        If Me.InvokeRequired Then
            Me.Invoke(mpp, dev, Value, Max)
        Else
            If dev Then
                pcbMain.Maximum = Max
                pcbMain.Value = Value
            Else
                pcbDetail.Maximum = Max
                pcbDetail.Value = Value
            End If
        End If
    End Sub 'True is to change big one.
    Delegate Sub myPostText(ByVal dev As Integer, ByVal Message As String)
    Dim mpt As myPostText
    Private Sub PostText(ByVal dev As Integer, ByVal Message As String) ' True is to change TextBox
        If Me.InvokeRequired Then
            Me.Invoke(mpt, dev, Message)
        Else
            If dev = TextShipName Then
                txtName.Text = Message
            ElseIf dev = TextShipFN
                labName.Text = Message
            Else
                labType.Text = Message
            End If
        End If
    End Sub

    Delegate Sub myButtonChanges(ByVal Condi As Integer)
    Dim mbc As myButtonChanges
    Private Sub ButtonChanges(ByVal Condi As Integer)
        If Me.InvokeRequired Then
            Me.Invoke(mbc, Condi)
        Else
            Select Case Condi
                Case AllGO
                    btnOK.Enabled = True
                    btnSkip.Enabled = True
                    txtName.Enabled = True
                Case SkipGO
                    txtName.Enabled = True
                    btnSkip.Enabled = True
                Case SkipDown
                    btnSkip.Enabled = True
                    btnSkip.Enabled = False
                Case Endding
                    btnSOPOutPutNow.Enabled = True
                    btnSOPSelectOutput.Enabled = True
                    btnAna.Enabled = True
                    btnMain.Text = "開始する"
                    btnOK.Enabled = False
                    btnSkip.Enabled = False
                    btnSelectCP.Enabled = True
                    btnTarget.Enabled = True
                    txtCP.Enabled = True
                    txtTarget.Enabled = True
                    txtName.Text = ""
                    labName.Text = "N/A"
                Case Start
                    btnMain.Text = "キャンセル"
                    btnOK.Enabled = True
                    btnSkip.Enabled = True
                    btnSelectCP.Enabled = False
                    btnTarget.Enabled = False
                    txtCP.Enabled = False
                    txtTarget.Enabled = False
                Case AllDown
                    btnOK.Enabled = False
                    btnSkip.Enabled = False
                    btnAna.Enabled = False
                    btnSOPOutPutNow.Enabled = False
                    btnSOPSelectOutput.Enabled = False
                Case AnaAllDown
                    btnSOPOutPutNow.Enabled = False
                    btnSOPSelectOutput.Enabled = False
                    btnMain.Enabled = False
                    btnAna.Enabled = False
                Case AnaAllGO
                    btnMain.Enabled = True
                    btnAna.Enabled = True
                    btnSOPOutPutNow.Enabled = True
                    btnSOPSelectOutput.Enabled = True
                Case OutGO
                    btnMain.Enabled = True
                    btnAna.Enabled = True
                    btnSOPOutPutNow.Enabled = True
                    btnSOPSelectOutput.Enabled = True
                Case OutDown
                    btnSOPOutPutNow.Enabled = False
                    btnSOPSelectOutput.Enabled = False
                    btnMain.Enabled = False
                    btnAna.Enabled = False
            End Select
        End If
    End Sub
    Delegate Sub myImgChage(ByVal dev As Boolean, ByVal bmp As Image)
    Dim mic As myImgChage
    Private Sub ImgChage(ByVal dev As Boolean, ByVal bmp As Image)
        If Me.InvokeRequired Then
            Me.Invoke(mic, dev, bmp)
        Else
            If dev Then
                picMain.Image = bmp
            Else
                picBig.Image = bmp
            End If
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ObjThread.Resume()
    End Sub
#End Region


#Region "Analyze Data"
    Dim objThread_Ana As Threading.Thread

    Private Sub AnalyzeData()
        If File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\ShipData.dat") Then
            If MsgBox("Ships Data Exists, Do you want to Overwrite it?", vbYesNo, "Infomation") = vbNo Then Exit Sub
            File.Delete(AppDomain.CurrentDomain.BaseDirectory & "ShipData.dat")
        End If
#Region "Read Ship Name and ID"
        ButtonChanges(AnaAllDown)
        Dim lsNames As String() = Nothing
        Dim lsIDs As String() = Nothing
        Dim lsTypes As String() = Nothing
        Dim thisFile As String = My.Resources.List_Names
        Dim thisItems = Split(thisFile, vbCrLf)
        For i As Integer = 0 To thisItems.Count - 1
            Dim insStr = Split(thisItems(i), "|")
            ReDim Preserve lsNames(i + 1)
            ReDim Preserve lsIDs(i + 1)
            ReDim Preserve lsTypes(i + 1)
            Try
                lsIDs(i) = insStr(0)
                lsTypes(i) = insStr(3)
                lsNames(i) = insStr(1)
            Catch
            End Try
        Next
#End Region
        Dim ii As Integer = 0
        Do Until ii = mFileList.Count
            Dim reader As SwfReader = New SwfReader(File.ReadAllBytes(mFileList(ii)))
            Dim swf As SwfCompilationUnit = New SwfCompilationUnit(reader)
            Dim lst = swf.Tags.FindAll(Function(x) _
               x.TagType = TagType.SymbolClass)

            Dim thisName As String = Nothing
            Dim ShipFound As Boolean = False
            For Each it As ISwfTag In lst
                Dim sme = TryCast(it, SymbolClassTag)
                Dim thisData = Split(sme.Names(0), "_")
                Dim a As String() = Split(mFileList(ii), "\")
                Dim b As String() = Split(a(a.Count - 1), ".")
                For ins As Integer = 0 To lsIDs.Count - 1
                    If thisData(1) = lsIDs(ins) Then 'If the ID matchs
                        thisName = lsIDs(ins) & "|" & b(0)
                        ShipFound = True
                        Try
                            Dim lst1 = swf.Tags.FindAll(Function(x) _
                                       x.TagType = TagType.DefineBits _
                                       OrElse x.TagType = TagType.DefineBitsJPEG3 _
                                       OrElse x.TagType = TagType.DefineBitsJPEG2)

                            If lst1.Count > 3 And lst1.Count < 14 Then
                                thisName &= "|SP"
                                '=====================================HIT
                            End If
                        Catch ex As Exception
                            '==============================Err
                        End Try
                        Exit For
                    Else
                        thisName = b(0)
                    End If
                Next
            Next

            If ShipFound Then
                WriteFiles(AppDomain.CurrentDomain.BaseDirectory & "\ShipData.dat", thisName)
                AnaMessagePost(thisName)
            Else
                WriteFiles(AppDomain.CurrentDomain.BaseDirectory & "\ShipData.dat", "Unknown|" & thisName)
                AnaMessagePost("Unknown Ship Data: " & thisName)
            End If
            PostProcessing(False, ii, mFileList.Count)
            ii += 1
        Loop
        '=====================================================================================
        MsgBox("Done!!")
        ButtonChanges(AnaAllGO)
        objThread_Ana.Abort()
    End Sub

    Private Sub btnAna_Click(sender As Object, e As EventArgs) Handles btnAna.Click
        If txtCP.Text = "" Or Not Directory.Exists(txtCP.Text) Then
            MsgBox("Select Simakaze GO folder FIRST!!") : Exit Sub
        End If
        objThread_Ana = New Threading.Thread(AddressOf AnalyzeData)
        objThread_Ana.Start()
    End Sub

    Delegate Sub myWriteFiles(ByVal path As String, ByVal Message As String)
    Dim mwf As myWriteFiles
    Private Sub WriteFiles(ByVal path As String, ByVal Message As String)
        If Me.InvokeRequired Then
            Me.Invoke(mwf, path, Message)
        Else
            Dim myWriteStream As IO.StreamWriter = New StreamWriter(path, True)
            myWriteStream.WriteLine(Message)
            myWriteStream.Close()
        End If
    End Sub

    Delegate Sub myAnaMessagePost(ByVal Message As String)
    Dim mamp As myAnaMessagePost
    Private Sub AnaMessagePost(ByVal Message As String)
        If Me.InvokeRequired Then
            Me.Invoke(mamp, Message)
        Else
            lsbAna.Items.Add(Message)
        End If
    End Sub

#End Region
#Region "Out Put One"
    Private Function LoadShipList() As Boolean
        If Not File.Exists(AppDomain.CurrentDomain.BaseDirectory & "\ShipData.dat") Then
            Return False
            Exit Function
        End If
        lsvMain.Items.Clear()
#Region "Read Ship Name and ID"
        Dim lsNames As String() = Nothing
        Dim lsIDs As String() = Nothing
        Dim lsTypes As String() = Nothing
        Dim thisFiletemp As String = My.Resources.List_Names
        Dim thisItems = Split(thisFiletemp, vbCrLf)
        For s As Integer = 0 To thisItems.Count - 1
            Dim insStr = Split(thisItems(s), "|")
            ReDim Preserve lsNames(s + 1)
            ReDim Preserve lsIDs(s + 1)
            ReDim Preserve lsTypes(s + 1)
            Try
                lsIDs(s) = insStr(0)
                lsTypes(s) = insStr(2)
                lsNames(s) = insStr(1)
            Catch
            End Try
        Next
#End Region
        Dim myFileStream As StreamReader = New StreamReader(AppDomain.CurrentDomain.BaseDirectory & "\ShipData.dat")
        Dim thisFile As String = myFileStream.ReadToEnd
        Dim myStrs = Split(thisFile, vbCrLf)
        Dim i As Integer = 0
        Do Until i = myStrs.Count
            Dim thisStr = Split(myStrs(i), "|")
            If thisStr.Count > 1 Then
                For n As Integer = 0 To lsIDs.Count - 1
                    If thisStr(0) = lsIDs(n) Then
                        Dim item As ListViewItem = lsvMain.Items.Add(lsIDs(n))
                        Dim mySubItems(3) As String
                        mySubItems(0) = lsNames(n)
                        mySubItems(1) = lsTypes(n)
                        mySubItems(2) = thisStr(1)
                        item.SubItems.AddRange(mySubItems)
                    End If
                Next
            End If
            i += 1
        Loop

        Return True
    End Function

    Private Sub Prepare()
        lsvMain.Columns.Add(New ColHeader("ID", CInt(lsvMain.Width / 8) - 3, HorizontalAlignment.Left, True))
        lsvMain.Columns.Add(New ColHeader("艦名", CInt(lsvMain.Width / 8) * 3 - 3, HorizontalAlignment.Left, True))
        lsvMain.Columns.Add(New ColHeader("艦種", CInt(lsvMain.Width / 8) * 4 - 3, HorizontalAlignment.Left, True))
        lsvMain.Columns.Add(New ColHeader("", 0, HorizontalAlignment.Left, True))

        mpm = AddressOf PostMessage
        mpp = AddressOf PostProcessing
        mpt = AddressOf PostText
        mbc = AddressOf ButtonChanges
        mic = AddressOf ImgChage
        mwf = AddressOf WriteFiles
        mamp = AddressOf AnaMessagePost
    End Sub

    Private Sub btnSOPRefresh_Click(sender As Object, e As EventArgs) Handles btnSOPRefresh.Click
        LoadShipList()
    End Sub

    Private Sub lsvMain_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lsvMain.ColumnClick
        Dim clickedCol As ColHeader = CType(lsvMain.Columns(e.Column), ColHeader)
        clickedCol.ascending = Not clickedCol.ascending
        Dim numitems As Integer = lsvMain.Items.Count
        lsvMain.BeginUpdate()
        Dim sortArray As New ArrayList
        For i As Integer = 0 To numitems - 1
            sortArray.Add(New SortWrapper(lsvMain.Items(i), e.Column))
        Next i
        sortArray.Sort(0, sortArray.Count, New SortWrapper.SortComparer(clickedCol.ascending))
        lsvMain.Items.Clear()
        For s As Integer = 0 To numitems - 1
            lsvMain.Items.Add(CType(sortArray(s), SortWrapper).sortItem)
        Next s
        lsvMain.EndUpdate()
    End Sub

    Private Sub BtnSOPSearch_Click(sender As Object, e As EventArgs) Handles BtnSOPSearch.Click
        If Not txtSOPName.Text = "" Then
            Dim i As Integer = 0
            Do Until i = lsvMain.Items.Count
                If Not txtSOPName.Text = lsvMain.Items(i).SubItems(1).Text Then
                    lsvMain.Items(i).Remove()
                Else
                    i += 1
                End If
            Loop
        End If
    End Sub

    Private Sub ImageOutput(ByVal FilePath() As String)
        If FilePath(1) = "" Or FilePath(0) = "" Or FilePath Is Nothing Then objTheard_OutPuting.Abort() : Exit Sub
        ButtonChanges(OutDown)
        If cbOnlyThis.CheckState = CheckState.Checked Then
            pcbSOPMain.Image.Save(FilePath(1) & "\" & ViewImages(ThisImageCount).id & ".png")
            MsgBox("Done!")
            objTheard_OutPuting.Abort()
            Exit Sub
        End If
        Dim reader As SwfReader = New SwfReader(File.ReadAllBytes(FilePath(0)))
        Dim swf As SwfCompilationUnit = New SwfCompilationUnit(reader)
        Dim picList = swf.Tags.FindAll(Function(x) _
                               x.TagType = TagType.DefineBits _
                               OrElse x.TagType = TagType.DefineBitsJPEG3 _
                               OrElse x.TagType = TagType.DefineBitsJPEG2)
        Dim i As Integer = 1
        For Each listTags As ISwfTag In picList
            Dim thisTag = TryCast(listTags, DefineBitsTag)
            If Not IO.Directory.Exists(FilePath(1)) Then
                IO.Directory.CreateDirectory(FilePath(1))
            End If
            Dim path As String
            path = String.Format(FilePath(1) & "\{0}.png", thisTag.CharacterId)
            Dim bmp As Image = thisTag.ToBitmap
            If bmp IsNot Nothing Then
                bmp.Save(path, ImageFormat.Png)
            End If
            PostProcessing(False, i, picList.Count)
            i += 1
        Next
        MsgBox("Done!")
        ButtonChanges(OutGO)
        objTheard_OutPuting.Abort()
    End Sub

    Public Structure ImageView
        Public ViewImages As Image
        Public id As String
    End Structure
    Dim ViewImages As ImageView()
    Dim ThisImageCount As Integer
    Private Sub LoadThisImage(ByVal path As String)
        ReDim ViewImages(0)
        Dim reader As SwfReader = New SwfReader(File.ReadAllBytes(path))
        Dim swf As SwfCompilationUnit = New SwfCompilationUnit(reader)
        Dim picList = swf.Tags.FindAll(Function(x) _
                               x.TagType = TagType.DefineBits _
                               OrElse x.TagType = TagType.DefineBitsJPEG3 _
                               OrElse x.TagType = TagType.DefineBitsJPEG2)
        Dim i As Integer = 1
        For Each listTags As ISwfTag In picList
            Dim thisTag = TryCast(listTags, DefineBitsTag)
            Dim bmp As Image = thisTag.ToBitmap
            If bmp IsNot Nothing Then
                If Not (bmp.Width < 10 Or bmp.Height < 10) Then
                    ReDim Preserve ViewImages(ViewImages.Count)
                    ViewImages(ViewImages.Count - 1).ViewImages = bmp
                    ViewImages(ViewImages.Count - 1).id = thisTag.CharacterId
                    ThisImageCount = Nothing
                End If
            End If
            If psbShowLoad.InvokeRequired Then
                psbShowLoad.Invoke(New Action(Sub()
                                                  If i = 1 Then psbShowLoad.Visible = True
                                                  psbShowLoad.Maximum = picList.Count
                                                  psbShowLoad.Value = i
                                                  If i = picList.Count Then psbShowLoad.Visible = False
                                              End Sub))
            End If

            i += 1
        Next
        If psbShowLoad.InvokeRequired Then
            psbShowLoad.Invoke(New Action(Sub()
                                              If ViewImages.Count > 0 Then
                                                  pcbSOPMain.Image = ViewImages(1).ViewImages
                                                  ThisImageCount = 1
                                              End If
                                          End Sub))
        End If
        objTheard_LoadPics.Abort()
    End Sub
    Dim objTheard_LoadPics As Threading.Thread
    Dim objTheard_OutPuting As Threading.Thread
    Private Sub lsvMain_DoubleClick(sender As Object, e As EventArgs) Handles lsvMain.DoubleClick
        Dim thisItem As ListViewItem = lsvMain.SelectedItems.Item(lsvMain.SelectedItems.Count - 1)
        If thisItem.SubItems(3).Text <> "" Then
            Dim path As String = txtCP.Text & "\" & thisItem.SubItems(3).Text & ".swf"
            objTheard_LoadPics = New Threading.Thread(AddressOf LoadThisImage)
            objTheard_LoadPics.Start(path)
            labSOPName.Text = thisItem.SubItems(3).Text
        End If
    End Sub

    Private Sub btnSOPLast_Click(sender As Object, e As EventArgs) Handles btnSOPLast.Click
        If ViewImages Is Nothing Then Exit Sub
        If ViewImages.Count > 0 Then
            If ThisImageCount = 0 Then
                ThisImageCount = ViewImages.Count - 1
                pcbSOPMain.Image = ViewImages(ThisImageCount).ViewImages
            Else
                ThisImageCount -= 1
                pcbSOPMain.Image = ViewImages(ThisImageCount).ViewImages
            End If
        End If
    End Sub

    Private Sub btnSOPNext_Click(sender As Object, e As EventArgs) Handles btnSOPNext.Click
        If ViewImages Is Nothing Then Exit Sub
        If ViewImages.Count > 0 Then
            If ThisImageCount = ViewImages.Count - 1 Then
                ThisImageCount = 0
                pcbSOPMain.Image = ViewImages(ThisImageCount).ViewImages
            Else
                ThisImageCount += 1
                pcbSOPMain.Image = ViewImages(ThisImageCount).ViewImages
            End If
        End If
    End Sub

    Private Sub btnSOPOutPutNow_Click(sender As Object, e As EventArgs) Handles btnSOPOutPutNow.Click
        objTheard_OutPuting = New Threading.Thread(AddressOf ImageOutput)
        Dim thisStr() As String = {txtCP.Text & "\" & labSOPName.Text & ".swf", txtTarget.Text}
        objTheard_OutPuting.Start(thisStr)
    End Sub

    Private Sub btnSOPSelectOutput_Click(sender As Object, e As EventArgs) Handles btnSOPSelectOutput.Click
        Using nOpen As New System.Windows.Forms.FolderBrowserDialog
            nOpen.Description = "出力宛のフォルダーを選択してください。"
            nOpen.ShowNewFolderButton = True
            nOpen.ShowDialog()
            If nOpen.SelectedPath IsNot Nothing Then
                If Len(nOpen.SelectedPath) < 1 Then MsgBox("正常に選択されませんでした！",, "ERROR") : Exit Sub
                objTheard_OutPuting = New Threading.Thread(AddressOf ImageOutput)
                Dim thisStr() As String = {txtCP.Text & "\" & labSOPName.Text & ".swf", nOpen.SelectedPath}
                objTheard_OutPuting.Start(thisStr)
            Else
                MsgBox("正常に選択されませんでした！",, "ERROR")
            End If
        End Using
    End Sub

#End Region
End Class
