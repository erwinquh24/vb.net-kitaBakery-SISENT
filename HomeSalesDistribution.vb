Imports System.Data.Odbc
'Imports MySql.Data.MySqlClient

Public Class HomeSalesDistribution

    Dim filter As String
   
    Private Sub isiGrid()
        Try
            Call Koneksi()
            da = New OdbcDataAdapter("Select sales_order.code_order AS KodeOrder, " &
                                     "sales_order.order_date as TanggalOrder, " &
                                     "sales_order.jumlah_order as JumlahOrder, " &
                                     "sales_order.produk_name as NamaProduk, " &
                                     "sales_order.store_name as NamaToko, " &
                                     "sales_order.product_price as HargaProduk from sales_order ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "sales_order")
            DGV_detail.DataSource = (ds.Tables("sales_order"))
            DGV_detail.ReadOnly = True
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub ViewDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isiGrid()

    End Sub

    Private Sub Button_ViewDetail_Click_1(sender As Object, e As EventArgs) Handles Button_ViewDetail.Click
        ViewDetailSalesDistribution.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        isiGrid()
    End Sub

    Private Sub TextBoxCari_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxCari.TextChanged
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select sales_order.code_order, " &
                                     "sales_order.order_date, " &
                                     "sales_order.jumlah_order, " &
                                     "sales_order.produk_name, " &
                                     "sales_order.store_name, " &
                                     "sales_order.product_price from sales_order WHERE " & filter & "'" & TextBoxCari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "sales_order")
            DGV_detail.DataSource = ds.Tables("sales_order")
            DGV_detail.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton_nProduk_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_nProduk.CheckedChanged
        filter = "produk_name LIKE"
        conn.Close()
    End Sub

    Private Sub RadioButton_namaToko_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_namaToko.CheckedChanged
        filter = "store_name LIKE"
        conn.Close()
    End Sub
End Class