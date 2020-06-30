Imports System

Module Program
    Sub Main(args As String())
        Dim numbers As Integer()
        numbers = {7, 3, 5, 8, 9, 2, 7}
        Dim sorter As InsertionSort = New InsertionSort()
        sorter.Sort(numbers)
        Dim value As String = String.Join(",", numbers)
        Console.WriteLine("[{0}]", value)

    End Sub
End Module
