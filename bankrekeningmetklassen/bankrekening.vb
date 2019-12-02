Public Class bankrekening
    Dim rekening1 As Decimal
    Dim rekening2 As Decimal
    Dim rekening3 As Decimal

    Dim rekeningNummer(3) As Decimal
    Public Function GeefAantalrekening(nummer)
        Return rekeningNummer(nummer - 1)
    End Function

    Public Sub veranderRekening(nummer, bedrag, optellen)
        If optellen = True Then
            rekeningNummer(nummer - 1) += bedrag
        Else
            rekeningNummer(nummer - 1) -= bedrag
            If rekeningNummer(nummer - 1) < 0 Then
                rekeningNummer(nummer - 1) += bedrag
                Throw New System.Exception("")
            End If
        End If

    End Sub
    Public Function redimmen()
        ReDim Preserve rekeningNummer(rekeningNummer.GetUpperBound(0) + 1)
        Return rekeningNummer.GetUpperBound(0)
    End Function
End Class
