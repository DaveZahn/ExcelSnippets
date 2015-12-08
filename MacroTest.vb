Sub MacroHideLOLColumns()
    
    Range("A:ZZ").EntireColumn.Hidden = False

    For I = 1 To 100
        columnString = Replace(Split(Columns(I).Address, ":")(0), "$", "")
        If Range(columnString & "3").Value = "LOL" Then
            Columns(Columns(I).Address).Hidden = True
        End If
    Next I

End Sub
