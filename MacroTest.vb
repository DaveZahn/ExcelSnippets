Sub MacroHideLOLColumns()
    
    Range("A:ZZ").EntireColumn.Hidden = False

    For I = 1 To 100
        columnString = Replace(Split(Columns(I).Address, ":")(0), "$", "")
        'check the value in row 3 of this column and hide the column based on some value
        If Range(columnString & "3").Value = "LOL" Then
            Columns(columnString).Hidden = True
        End If
    Next I

End Sub
