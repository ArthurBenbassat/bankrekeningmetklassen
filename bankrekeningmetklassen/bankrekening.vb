Public Class bankrekening

    Private saldo As Decimal
    Private eigenaar As String


    Public Function toonSaldo()
        Return saldo
    End Function

    Public Sub New(ByVal begin As Decimal, ByVal e As String)
        saldo = begin
        eigenaar = e
    End Sub

    Public Function VanWie()
        Return eigenaar
    End Function
    '  Dim rekeningNummer(2) As Decimal
    ' Public Function GeefAantalrekening(nummer)
    ' Return rekeningNummer(nummer - 1)
    ' End Function

    '  Public Sub veranderRekening(nummer, bedrag, optellen)
    '  If optellen = True Then
    '       rekeningNummer(nummer - 1) += bedrag
    '     Else
    '      rekeningNummer(nummer - 1) -= bedrag
    'rekeningNummer(nummer - 1) < 0 Then
    '           rekeningNummer(nummer - 1) += bedrag
    'Throw New System.Exception("")
    'End If
    'End If
    '  End Sub

    '  Public Function redimmen()
    '  ReDim Preserve rekeningNummer(rekeningNummer.GetUpperBound(0) + 1)
    'Return rekeningNummer.GetUpperBound(0)
    '   End Function

    ' Public Function aantalRekeningen()
    ' Return rekeningNummer.GetUpperBound(0)
    '  End Function
End Class
