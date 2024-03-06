Imports System.IO
Imports System.Runtime.InteropServices

Public Class FormMain
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Me.Show()
        Delay(0.1) ' 先呼叫視窗後延遲100ms防止視窗未開啟
        GetProcess()
    End Sub

    '取得Process清單
    Private Sub GetProcess()
        ' 清除清單
        ListviewProcesses.Items.Clear()

        ' 設定Small Image List為ImageList1
        Me.ListviewProcesses.SmallImageList = Me.ImageList1

        ' 取得所有Process
        Dim Processes As Process() = Process.GetProcesses()
        Dim LoadCount As Integer = 0

        ' 設定狀態
        ProgressBarLoading.Maximum = Processes.Length
        ' LabelStatus.Text = "載入中..."

        Delay(0.1) ' 先呼叫視窗後延遲100ms防止視窗未更新

        For Each p As Process In Processes
            ' 透過Try Catch將無權限取得的Process排除避免出錯
            Try
                ' 新增Image List
                Dim oIcon As Icon = Icon.ExtractAssociatedIcon(p.MainModule.FileName)
                ImageList1.Images.Add(p.MainModule.FileName, oIcon)

                ' 新增到ListView
                Dim item As New ListViewItem(p.ProcessName, p.MainModule.FileName)
                item.SubItems.Add(p.Id)
                item.SubItems.Add(p.MainModule.FileName)
                Me.ListviewProcesses.Items.Add(item)
            Catch
            Finally
                LoadCount += 1
                ProgressBarLoading.Value = LoadCount
            End Try
        Next

        'LabelStatus.Text = "載入完成 (" & Now.ToString & ")"
    End Sub

#Region "Message Control"
    Private Enum MessageType
        DEBUG
        INFO
        [ERROR]
        WARN
        SUCCESS
    End Enum

    Private Sub AddMessage(ByVal MessageType As MessageType, ByVal Message As String)
        Dim FullMessage As String
        FullMessage = String.Format("[{0}] {1}", MessageType.ToString, Message)
        With RichTextBoxMessage
            .AppendText(FullMessage + Environment.NewLine)

            .Select(.GetFirstCharIndexFromLine(UBound(.Text.Split(vbCrLf.ToCharArray(), StringSplitOptions.RemoveEmptyEntries))), MessageType.ToString.Length + 2)
            Select Case MessageType
                Case MessageType.DEBUG
                    .SelectionColor = Color.White
                Case MessageType.INFO
                    .SelectionColor = Color.Blue
                Case MessageType.ERROR
                    .SelectionColor = Color.Red
                Case MessageType.WARN
                    .SelectionColor = Color.Yellow
                Case MessageType.SUCCESS
                    .SelectionColor = Color.Green
            End Select
            .DeselectAll()
        End With
    End Sub

    Private Sub ClearMessage()
        RichTextBoxMessage.Clear()
    End Sub
#End Region

#Region "ToolStripMenu"
    Private Sub 說明QToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 說明QToolStripMenuItem.Click
        formHelp.Show()
    End Sub

    Private Sub 刷新RToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 刷新RToolStripMenuItem1.Click
        ListviewProcesses.Items.Clear()
        GetProcess()
    End Sub

    Private Sub DLL清單DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DLL清單DToolStripMenuItem.Click
        On Error Resume Next
        FormDllList.Show()
        Me.Enabled = False
    End Sub

    Private Sub 注入IToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 注入IToolStripMenuItem.Click
        注入IToolStripMenuItem.Enabled = False
        ClearMessage()

        ' 讀取Dll清單
        Dim DLManager As New DllListManager
        Dim DllList() As String
        DllList = DLManager.Read()
        ' 判斷列表是否有資料
        If UBound(DllList) = -1 Then
            MsgBox("請先至視窗>DLL清單新增路徑", vbCritical, "錯誤")
            Exit Sub
        End If

        ' 注入Dll (參考https://github.com/aaaddress1/DLL-Injector-In-VB.NET/)
        ' 確認指定處理序名之處理序是否存在.
        Dim NameProcess As String = ListviewProcesses.Items.Item(ListviewProcesses.SelectedIndices(0)).SubItems(0).Text

        AddMessage(MessageType.INFO, String.Format("選擇進程: {0}", NameProcess))
        If (Process.GetProcessesByName(NameProcess).Length = 0) Then
            AddMessage(MessageType.ERROR, "找不到進程(Process)")
            注入IToolStripMenuItem.Enabled = True
            Exit Sub
        End If

        ' 取得當前活動中之指定處理序進程句柄.
        Dim TargetHandle As IntPtr = Process.GetProcessesByName(NameProcess)(0).Handle
        If (TargetHandle.Equals(IntPtr.Zero)) Then
            AddMessage(MessageType.ERROR, "無法取得該進程(Process)的處理句炳(Handle)")
            注入IToolStripMenuItem.Enabled = True
            Exit Sub
        Else
            AddMessage(MessageType.INFO, String.Format("處理句炳: {0}", TargetHandle.ToString))
        End If

        ' 獲取LoadLibraryA的地址(PS: 不同進程但同API, 地址相同).
        Dim GetAdrOfLLBA As IntPtr = GetProcAddress(GetModuleHandle("Kernel32"), "LoadLibraryA")
        If (GetAdrOfLLBA.Equals(IntPtr.Zero)) Then
            AddMessage(MessageType.ERROR, "LoadLibraryA 地址取得失敗")
            注入IToolStripMenuItem.Enabled = True
            Exit Sub
        Else

            AddMessage(MessageType.INFO, String.Format("LoadLibraryA 地址: 0x{0:X}", GetAdrOfLLBA.ToInt64))
        End If


        For i = 0 To UBound(DllList)
            Dim DllPath As String = Trim(DllList(i))


            ' 防止抓到空的路徑
            If DllPath.Length > 0 Then
                AddMessage(MessageType.INFO, String.Format("DLL: {0}", DllPath))

                If Not File.Exists(DllPath) Then
                    AddMessage(MessageType.ERROR, ".Dll檔案不存在")
                    Continue For
                End If

                '將DLL路徑轉為Char()陣列.
                Dim OperaChar As Byte() = System.Text.Encoding.Default.GetBytes(DllPath)

                ' 在目標進程申請一塊空間存放路徑字串.
                Dim DllMemPathAdr As IntPtr = VirtualAllocEx(TargetHandle, 0&, &H64, MEM_COMMIT, PAGE_EXECUTE_READWRITE)
                If (DllMemPathAdr.Equals(IntPtr.Zero)) Then
                    AddMessage(MessageType.ERROR, "無法申請記憶體空間")
                    Continue For
                Else
                    AddMessage(MessageType.INFO, String.Format("記憶體空間地址: 0x{0:X}", DllMemPathAdr.ToInt64))
                End If


                '將申請來的記憶體空間寫入路徑Char()陣列.
                If (WriteProcessMemory(TargetHandle, DllMemPathAdr, OperaChar, OperaChar.Length, 0) = False) Then
                    AddMessage(MessageType.ERROR, "無法寫入記憶體")
                End If

                ' 令目標進程呼叫LoadLibraryA加載Char()陣列中存放的路徑.
                CreateRemoteThread(TargetHandle, 0, 0, GetAdrOfLLBA, DllMemPathAdr, 0, 0)
                AddMessage(MessageType.SUCCESS, "注入完成")
            End If

        Next
        注入IToolStripMenuItem.Enabled = True
    End Sub
#End Region

#Region "ListviewProcesses"
    Private Sub ListviewProcesses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListviewProcesses.SelectedIndexChanged
        注入IToolStripMenuItem.Enabled = (ListviewProcesses.SelectedIndices.Count > 0)
    End Sub

    Private Sub 查看已載入DllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 查看已載入DllToolStripMenuItem.Click
        Try
            Dim ProcessId As Int16 = Convert.ToInt16(ListviewProcesses.Items.Item(ListviewProcesses.SelectedIndices(0)).SubItems(1).Text)
            Dim SelectProcess As Process = Process.GetProcessById(ProcessId)

            Dim SelectProcessModuleCollection As ProcessModuleCollection = SelectProcess.Modules

            FormLoadedDll.ListBoxDll.Items.Clear()
            For Each MyProcessMoudle As ProcessModule In SelectProcessModuleCollection
                FormLoadedDll.ListBoxDll.Items.Add(MyProcessMoudle.FileName)
            Next

            FormLoadedDll.Text = "目前選取進程: " & ListviewProcesses.Items.Item(ListviewProcesses.SelectedIndices(0)).SubItems(0).Text
            FormLoadedDll.Show()
        Catch
        End Try
    End Sub
#End Region
End Class
