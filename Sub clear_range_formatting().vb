Sub clear_range_formatting()

For Each cellRange In Range("C4:U6")
    cellRange.Interior.ColorIndex = 0
    Range("W" & cellRange.Row).Value = ""
Next cellRange

End Sub