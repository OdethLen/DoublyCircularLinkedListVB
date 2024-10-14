Public Class Node
    Public Value As Int16
    Public Nextt As Node
    Public Prev As Node

    Public Sub New()
        Value = 0
        Nextt = Nothing
        Prev = Nothing
    End Sub
    Public Sub New(Value As Int16)
        Me.Value = Value
        Nextt = Nothing
        Prev = Nothing
    End Sub
    Public Overrides Function ToString() As String
        Return Value.ToString() & ","
    End Function
End Class
