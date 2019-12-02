Public Class Form1
    Dim rekArthur, rekTim, rekKyle As bankrekening
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eigenrekening As Integer
        Dim bedrag As Decimal
        Dim optellen As Boolean
        Dim andererekening As Integer
        '  Try
        ' eigenrekening = InputBox("Geef uw rekeningnummer (vb: 1)")
        ' MessageBox.Show("U bezit nog over " & geld.GeefAantalrekening(eigenrekening))
        '  bedrag = InputBox("Hoeveel wilt u over schrijven?")
        ' geld.veranderRekening(eigenrekening, bedrag, False)
        '  andererekening = InputBox("Naar welke rekening wilt u " & bedrag & " euro overschrijven?")
        '  geld.veranderRekening(andererekening, bedrag, True)
        ' Catch ex As Exception
        ' MessageBox.Show("Er ging iets mis")
        ' End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rekArthur = New bankrekening(5000, "Arthur")
        rekTim = New bankrekening(5000, "Kyle")
        rekKyle = New bankrekening(5000, "Tim")
        '   geld = New bankrekening
        '  Dim optellen As Boolean = True
        '  geld.veranderRekening(1, 1000, optellen)
        ''  geld.veranderRekening(2, 200, optellen)
        '  geld.veranderRekening(3, 5000, optellen)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rekArthur.toonSaldo()
        ListBox1.Items.Clear()
        '  For teller As Integer = 0 To geld.aantalRekeningen
        ListBox1.Items.Add("Rekening " & rekArthur.VanWie & " bevat " & rekArthur.toonSaldo())
        '  Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '  Try
        'Dim bedrag As Decimal
        ' Dim rekening As Integer
        'bedrag = InputBox("Hoeveel wilt u doneren?")
        'rekening = InputBox("Naar welke rekening wilt u dit bedrag: " & bedrag & " overzetten?")
        'geld.veranderRekening(rekening, bedrag, True)
        ' Catch ex As Exception
        ' MessageBox.Show("Er ging iets mis")
        ' End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '  ListBox1.Items.Add("Rekening" & geld.redimmen & " bevat " & geld.GeefAantalrekening(geld.redimmen))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '   Dim rekDenis As New bankrekening(5000)
    End Sub
End Class
