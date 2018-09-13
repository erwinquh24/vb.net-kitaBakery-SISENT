Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Public Class MM_SalesDistribution

    Dim a, b As String
    Dim save, filter As String

    Private Sub isiGrid()
        Try
            Call koneksi()

            da = New OdbcDataAdapter("Select sales_order.code_order as CodeOrder, " &
                                     "sales_order.status as Status, " &
                                     "sales_order.order_date as OrderDate, " &
                                     "sales_order.purchase_date as PurchaseDate, " &
                                     "sales_order.shipping_date as ShippingDate, " &
                                     "sales_order.jumlah_order as JumlahOrder, " &
                                     "sales_order.produk_name as NameProduct, " &
                                     "sales_order.store_name as StoreName, " &
                                     "sales_order.store_address as StoreAddress, " &
                                     "sales_order.product_price as ProductPrice, " &
                                     "sales_order.price_total as PriceTotal, " &
                                     "sales_order.note as Note from sales_order ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "sales_order")
            DGV.DataSource = (ds.Tables("sales_order"))
            DGV.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub enable()
        'TextBox_kodeOrder.Enabled = True
        'DateTimePicker_order.Enabled = True
        'DateTimePicker_pembayaran.Enabled = True
        DateTimePicker_TPengiriman.Enabled = True
        TextBox_jumlahProduk.Enabled = True
        'ComboBox_namaProduk.Enabled = True
        'TextBox_namaToko.Enabled = True
        'TextBox_alamatToko.Enabled = True
        'TextBox_hargaProduct.Enabled = True
        Button_batal.Enabled = True
        ComboBox_status.Enabled = True
        TextBox_catatan.Enabled = True

    End Sub

    Private Sub desable()
        TextBox_kodeOrder.Enabled = False
        DateTimePicker_order.Enabled = False
        DateTimePicker_pembayaran.Enabled = False
        DateTimePicker_TPengiriman.Enabled = False
        TextBox_jumlahProduk.Enabled = False
        ComboBox_namaProduk.Enabled = False
        TextBox_namaToko.Enabled = False
        TextBox_alamatToko.Enabled = False
        TextBox_totalHarga.Enabled = False
        'TextBox_hargaProduct.Enabled = False
        Button_batal.Enabled = False
        ComboBox_status.Enabled = False
        TextBox_catatan.Enabled = False
    End Sub

    Private Sub clear()
        TextBox_kodeOrder.Text = ""
        DateTimePicker_order.Text = ""
        DateTimePicker_pembayaran.Text = ""
        ComboBox_namaProduk.Text = ""
        TextBox_namaToko.Text = ""
        TextBox_alamatToko.Text = ""
        TextBox_hargaProduct.Text = ""
        TextBox_totalHarga.Text = ""
        TextBox_jumlahProduk.Text = ""
        ComboBox_status.Text = ""
        TextBox_catatan.Text = ""
    End Sub


    Private Sub load_combo()
        Try
            myKoneksi()
            Dim query As String
            query = "select product_name from sisent.product"

            myCommand = New MySqlCommand(query, kon)
            myDataReader = myCommand.ExecuteReader
            While myDataReader.Read
                ComboBox_namaProduk.Items.Add(myDataReader("product_name"))
            End While
            kon.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal : " + ex.Message)
        End Try
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DGV.Rows(e.RowIndex)
                TextBox_kodeOrder.Text = row.Cells("CodeOrder").Value
                DateTimePicker_order.Text = row.Cells("OrderDate").Value
                DateTimePicker_pembayaran.Text = row.Cells("PurchaseDate").Value
                DateTimePicker_TPengiriman.Text = row.Cells("ShippingDate").Value
                TextBox_jumlahProduk.Text = row.Cells("JumlahOrder").Value
                ComboBox_namaProduk.Text = row.Cells("NameProduct").Value
                TextBox_namaToko.Text = row.Cells("StoreName").Value
                TextBox_alamatToko.Text = row.Cells("StoreAddress").Value
                TextBox_hargaProduct.Text = row.Cells("ProductPrice").Value
                TextBox_totalHarga.Text = row.Cells("PriceTotal").Value
                ComboBox_status.Text = row.Cells("Status").Value
                TextBox_catatan.Text = row.Cells("Note").Value
            End If
            If ComboBox_status.Text = "Pending" Or ComboBox_status.Text = "Request" Then
                Button_proses.Enabled = True
                Button_batal.Enabled = True
                Button_hapus.Enabled = False
            Else
                Button_proses.Enabled = True
                Button_proses.Enabled = False
                Button_hapus.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button_proses_Click(sender As Object, e As EventArgs) Handles Button_proses.Click
        If TextBox_kodeOrder.Text = "" Then
            MsgBox("Tidak ada data yang akan di proses", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If Button_proses.Text = "Proses" Then
            Button_proses.Text = "Simpan"
            GroupBox3.Text = "<<Proses>>"
            Button_hapus.Enabled = False
            Call enable()
            TextBox_kodeOrder.Enabled = False
            TextBox_kodeOrder.Focus()

        Else
            Try
                Dim produk As Integer = Integer.Parse(TextBox_jumlahProduk.Text)
                Dim p_name As String = ComboBox_namaProduk.SelectedItem()
                Dim stok As Integer = get_stock(p_name)
                Dim query As String = "update product set stock=@stock where product_name=@p_name"
                myKoneksi()
                If stok < produk Then
                    MsgBox("Jumlah Produk Tidak Cukup, produk sisa '" & stok & "'", MsgBoxStyle.Exclamation, "Peringatan")
                    Exit Sub
                Else
                    myCommand = New MySqlCommand(query, kon)
                    myCommand.Parameters.AddWithValue("@stock", stok - produk)
                    myCommand.Parameters.AddWithValue("@p_name", p_name)
                    myCommand.ExecuteNonQuery()
                End If
                kon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Try
                Call koneksi()
                edi_data = "UPDATE sales_order SET order_date = '" & DateTimePicker_order.Text & "'," &
                    "purchase_date = '" & DateTimePicker_pembayaran.Text & "'," &
                    "shipping_date = '" & DateTimePicker_TPengiriman.Text & "'," &
                    "jumlah_order = '" & TextBox_jumlahProduk.Text & "'," &
                    "produk_name = '" & ComboBox_namaProduk.Text & "'," &
                    "store_name = '" & TextBox_namaToko.Text & "'," &
                    "store_address = '" & TextBox_alamatToko.Text & "'," &
                    "price_total = '" & TextBox_totalHarga.Text & "'," &
                    "status = '" & ComboBox_status.Text & "'," &
                    "note = '" & TextBox_catatan.Text & "'," &
                    "product_price = '" & TextBox_hargaProduct.Text & "' where code_order='" & TextBox_kodeOrder.Text & "'"
                oc = New OdbcCommand(edi_data, conn)
                oc.ExecuteNonQuery()

                MsgBox("Data berhasil di proses", MsgBoxStyle.Information)
                Call desable()
                Call clear()
                Button_proses.Text = "Proses"
                Button_hapus.Enabled = True
                Call isiGrid()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub MM_SalesDistribution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGrid()
        load_combo()
    End Sub

    Private Sub ComboBox_namaProduk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_namaProduk.SelectedIndexChanged
        myKoneksi()
        Dim query As String = "select * from product where product_name='" & ComboBox_namaProduk.Text & "'"
        myCommand = New MySqlCommand(query, kon)
        myDataReader = myCommand.ExecuteReader
        myDataReader.Read()
        If myDataReader.HasRows Then
            TextBox_hargaProduct.Text = myDataReader.Item("price")
        End If
    End Sub

    Function get_stock(ByVal p_name As String) As Integer
        Dim stock As Integer
        Dim query As String = "select stock from product where product_name=@p_name"
        myKoneksi()
        myCommand = New MySqlCommand(query, kon)
        myCommand.Parameters.AddWithValue("@p_name", p_name)
        myDataReader = myCommand.ExecuteReader()
        While myDataReader.Read()
            stock = myDataReader("stock")
        End While
        kon.Close()
        Return stock
    End Function



    Private Sub Button_batal_Click(sender As Object, e As EventArgs) Handles Button_batal.Click
        Try
            Button_batal.Text = "Batal"
            Button_proses.Text = "Proses"
            GroupBox3.Text = "<<Order>>"
            Button_proses.Enabled = True
            Button_hapus.Enabled = True
            DGV.Enabled = True
            Call isiGrid()
            Call desable()
            Call clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button_hapus_Click(sender As Object, e As EventArgs) Handles Button_hapus.Click
        If TextBox_kodeOrder.Text = "" Then
            MsgBox("Tidak ada data yang akan di hapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        Else
            Dim pesan
            pesan = MsgBox("Apakah data ini akan dihapus", MsgBoxStyle.Question + vbYesNo, "Peringatan")
            If pesan = vbYes Then
                Try
                    Call koneksi()
                    hapus = "DELETE FROM sales_order where code_order='" & TextBox_kodeOrder.Text & "'"

                    oc = New OdbcCommand(hapus, conn)
                    oc.ExecuteNonQuery()


                    MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
                    Call isiGrid()
                    conn.Close()
                Catch ex As Exception
                    MsgBox("Data gagal di Hapus", MsgBoxStyle.Exclamation, "Peringatan")
                End Try
            End If
        End If
    End Sub

    Private Sub Button_Kembali_Click(sender As Object, e As EventArgs) Handles Button_Kembali.Click
        HomeMM.Show()
        Me.Close()
    End Sub

    Private Sub TextBox_cari_TextChanged(sender As Object, e As EventArgs) Handles TextBox_cari.TextChanged
        Try
            Call koneksi()
            da = New OdbcDataAdapter("select sales_order.code_order as CodeOrder, " &
                                     "sales_order.status as Status, " &
                                     "sales_order.produk_name as NameProduct, " &
                                     "sales_order.store_name as StoreName, " &
                                     "sales_order.purchase_date as PurchaseDate, " &
                                     "sales_order.shipping_date as ShippingDate, " &
                                     "sales_order.jumlah_order as JumlahOrder, " &
                                     "sales_order.store_address as StoreAddress, " &
                                     "sales_order.product_price as ProductPrice, " &
                                     "sales_order.price_total as PriceTotal, " &
                                     "sales_order.order_date as OrderDate from sales_order where " & filter & "'" & TextBox_cari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "sales_order")
            DGV.DataSource = ds.Tables("sales_order")
            DGV.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        filter = "produk_name LIKE"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        filter = "store_name LIKE"
    End Sub
End Class