Module Util
    ''' <summary>
    ''' 延遲時間 (ms)
    ''' </summary>
    ''' <param name="Interval"></param>
    Public Sub Delay(ByVal Interval As Double)
        Dim Start As Integer = Environment.TickCount()
        Dim TimeLast As Integer = Interval
        Do
            If Environment.TickCount() - Start > TimeLast Then Exit Do
            Application.DoEvents() ' 釋放記憶體
        Loop
    End Sub
End Module
