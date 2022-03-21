' Sorting Algorithm
' Version 1.0
' Last updated on 10.03.2022

Public Class Form1
    Dim arrNumbers() As Integer
    Dim intSwapCount As Int16 = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbn100.Checked = True
        rbnSelectionSort.Checked = True
        lblComment.Text = ""
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Randomize()
        Dim intSampleSize As UInt16
        txtOutput.Clear()
        intSwapCount = 0

        If rbn100.Checked = True Then intSampleSize = 100
        If rbn500.Checked = True Then intSampleSize = 500
        If rbn1000.Checked = True Then intSampleSize = 1000
        If rbn5000.Checked = True Then intSampleSize = 5000

        ReDim arrNumbers(intSampleSize - 1)
        For i = 0 To arrNumbers.Count - 1
            arrNumbers(i) = CInt(Int(Rnd() * intSampleSize))
            txtOutput.Text += Str(arrNumbers(i))
        Next

        lblComment.Text = "Numbers generated."
        btnSort.Enabled = True
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        txtOutput.Clear()

        If rbnSelectionSort.Checked = True Then
            SelectionSort()
        ElseIf rbnQuickSort.Checked = True Then
            QuickSort(arrNumbers, 0, arrNumbers.Count - 1)
        End If

        For i = 0 To arrNumbers.Count - 1
            txtOutput.Text += Str(arrNumbers(i))
        Next

        lblComment.Text = intSwapCount.ToString & " swaps performed."
        btnSort.Enabled = False
    End Sub

    Private Sub SelectionSort()
        ' The selection sort algorithm sorts an array by repeatedly finding the 
        ' minimum element(considering ascending order) from unsorted part and 
        ' putting it at the beginning. The algorithm maintains two subarrays 
        ' In a given array.
        ' 1) The subarray which Is already sorted.
        ' 2) Remaining subarray which Is unsorted.

        Dim minDex, intLoop1, intLoop2 As Int32

        For intLoop2 = 0 To arrNumbers.Count - 2
            minDex = intLoop1
            For intLoop1 = intLoop2 + 1 To arrNumbers.Count - 2
                If arrNumbers(intLoop1) < arrNumbers(minDex) Then minDex = intLoop1
            Next
            Swap(minDex, intLoop2)
        Next
    End Sub

    Private Sub QuickSort(intSubList() As Int32, ByVal intFirst As Int16, ByVal intLast As Int16)
        '   Quick sort algorithm (divide and conquere in-place) recursively 
        '   1. Choose any element in the array array[p..r]. Call this element the pivot q
        '   2. Rearrange the elements in array[p..r] so that all elements in array[p..r] 
        '   that are less than Or equal (<=) To the pivot q are To its left And all 
        '   elements that are greater (<) than the pivot q are To its right
        '   3. call quicksort on subarray array[p..q-1] and call quicksort on subarray 
        '   array[q+1..r] Note item q Is Not part of either of these subarrays 
        '   4. these subarrays are then joined together recursively as each call 
        '   to quicksort ends

        Dim Low, High As Int16
        Dim Pivot As String

        Low = intFirst
        High = intLast
        Pivot = intSubList((intFirst + intLast) \ 2)

        Do
            While intSubList(Low) < Pivot
                Low = Low + 1
            End While

            While intSubList(High) > Pivot
                High = High - 1
            End While

            ' intCompCount += 1
            If Low <= High Then
                Swap(Low, High)
                Low = Low + 1
                High = High - 1
            End If
        Loop While Low <= High

        If intFirst < High Then QuickSort(intSubList, intFirst, High)
        If Low < intLast Then QuickSort(intSubList, Low, intLast)
    End Sub

    Sub Swap(intNdxA As Int32, intNdxB As Int32)
        Dim intTemp As Int32

        intTemp = arrNumbers(intNdxA)
        arrNumbers(intNdxA) = arrNumbers(intNdxB)
        arrNumbers(intNdxB) = intTemp

        intSwapCount += 1
    End Sub
End Class
