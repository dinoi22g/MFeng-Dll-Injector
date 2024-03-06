Imports System.IO

Public Class DllListManager
    ' 檔案名稱
    Private Const FILE_NAME = "DllList.txt"

    Private Function FullPath() As String
        Return Application.StartupPath & "\" & FILE_NAME
    End Function

    ''' <summary>
    ''' 儲存檔案
    ''' </summary>
    ''' <param name="StrList"></param>
    Public Sub Save(ByVal StrList As String)
        On Error Resume Next

        Dim Sw As New StreamWriter(Me.FullPath)
        Dim SplitStrList() As String = StrList.Split(Environment.NewLine)

        If Len(StrList) Then
            Sw.Write(StrList)
            Sw.Flush()
            Sw.Close()
        End If
    End Sub

    ''' <summary>
    ''' 讀取檔案
    ''' </summary>
    ''' <returns></returns>
    Public Function Read() As String()
        On Error Resume Next

        Dim LineList As New List(Of String)()

        If IO.File.Exists(Me.FullPath) Then
            Dim Sr As New StreamReader(Me.FullPath, System.Text.Encoding.UTF8)

            Do
                LineList.Add(Sr.ReadLine)
            Loop While Sr.Peek <> -1

            Sr.Close()
        End If
        Return LineList.ToArray()
    End Function
End Class
