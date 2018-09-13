Public Class daftarPesanan

    Private Sub Button_pProduk_Click(sender As Object, e As EventArgs) Handles Button_pProduk.Click
        Me.Close()
        MM_SalesDistribution.Show()
    End Sub

    Private Sub Button_bBaku_Click(sender As Object, e As EventArgs) Handles Button_bBaku.Click
        Me.Close()
        MM_Production.Show()
    End Sub

    Private Sub daftarPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class