Sub compare_two_cells()

Dim cellRange As Range

    For Each cellRange In Range("C4:U6")
        v1 = cellRange.Value
        v2 = cellRange.Offset(0, 1).Value
        a1 = cellRange.Address
        a2 = cellRange.Offset(0, 1).Address
        
        If v1 = 0 And v2 = 0 Then
        ElseIf v1 > v2 And v2 = 0 Then
        ElseIf v1 < v2 And v1 = 0 Then
        Else:
            cellRange.Interior.ColorIndex = 42
            cellRange.Offset(0, 1).Interior.ColorIndex = 42
            Range("W" & cellRange.Row).Value = "Error"
        End If
    Next cellRange

End Sub