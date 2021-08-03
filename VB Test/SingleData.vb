Public Class SingleData

    Public Amount As String
    Public Cost As String
    Public Total As String
    Public Extra As String

    Public Sub calculate()
        Dim intAmount As Decimal
        Dim intCost As Decimal
        If IsNumeric(Amount) And IsNumeric(Cost) Then

            intAmount = Convert.ToDecimal(Amount)
            intCost = Convert.ToDecimal(Cost)

            Total = (intAmount * intCost).ToString
            Extra = (intAmount * intCost * 0.1)
        End If

    End Sub

End Class
