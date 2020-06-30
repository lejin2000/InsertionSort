Public Class InsertionSort
    Public Sub Sort(ByRef array As Integer())
        For i = 0 To array.Length - 1
            Dim current As Integer = array(i)
            Dim j As Integer = i - 1
            While j >= 0
                If array(j) > current Then
                    array(j + 1) = array(j)
                    j = j - 1
                Else
                    Exit While
                End If
            End While
            array(j + 1) = current

        Next
    End Sub
End Class
