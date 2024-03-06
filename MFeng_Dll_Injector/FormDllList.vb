Public Class FormDllList
    Private DLManager As New DllListManager

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        On Error Resume Next
        Dim DllFileDialog As New OpenFileDialog
        With DllFileDialog
            .Title = "添加Dynamic Link Library"
            .Filter = "動態連結資料庫 (*.dll)|*.dll"
            .ShowDialog()

        End With

        If DllFileDialog.FileName <> "" Then
            If ListBoxItem.FindStringExact(DllFileDialog.FileName) = -1 Then
                ListBoxItem.Items.Add(DllFileDialog.FileName)
            Else
                MsgBox("該項目已存在", vbCritical, "錯誤")
            End If
        End If

    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        On Error Resume Next
        If ListBoxItem.SelectedIndex > -1 Then ListBoxItem.Items.RemoveAt(ListBoxItem.SelectedIndex)
    End Sub

    Private Sub FormList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' 儲存內容
        If ListBoxItem.Items.Count > 0 Then
            Dim ListToString As String = ""
            For i = 0 To ListBoxItem.Items.Count - 1
                ListToString &= ListBoxItem.Items(i) & Environment.NewLine
            Next
            DLManager.Save(ListToString)
        End If


        Me.Hide()
        FormMain.Enabled = True
    End Sub

    Private Sub FormList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim DllList() As String
        DllList = DLManager.Read()
        For i = 0 To UBound(DllList)
            ListBoxItem.Items.Add(DllList(i))
        Next
    End Sub
End Class