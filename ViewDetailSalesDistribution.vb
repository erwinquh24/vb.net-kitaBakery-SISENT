Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class ViewDetailSalesDistribution
    Dim a, b As String
    Dim save, filter As String
    
    Private Sub isiGrid()
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select sales_order.code_order as CodeOrder, " &
                                     "sales_order.status as Status, " &
                                     "sales_order.produk_name as NameProduct, " &
                                     "sales_order.store_name as StoreName, " &
                                     "sales_order.purchase_date as PurchaseDate, " &
                                     "sales_order.shipping_date as ShippingDate, " &
                                     "sales_order.jumlah_order as JumlahOrder, " &
                                     "sales_order.store_address as StoreAddress, " &
                                     "sales_order.product_price as ProductPrice, " &
                                     "sales_order.price_total as PriceTotal, " &
                                     "sales_order.order_date as OrderDate from sales_order ", conn)
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
        DateTimePicker_order.Enabled = True
        DateTimePicker_pembayaran.Enabled = True
        TextBox_jumlahProduk.Enabled = True
        ComboBox_namaProduk.Enabled = True
        TextBox_namaToko.Enabled = True
        TextBox_alamatToko.Enabled = True
        Button_batal.Enabled = True

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
        TextBox_status.Enabled = False
    End Sub

    Private Sub clear()
        TextBox_kodeOrder.Text = ""
        DateTimePicker_order.Text = ""
        DateTimePicker_pembayaran.Text = ""
        DateTimePicker_TPengiriman.Text = ""
        ComboBox_namaProduk.Text = ""
        TextBox_namaToko.Text = ""
        TextBox_alamatToko.Text = ""
        TextBox_hargaProduct.Text = ""
        TextBox_totalHarga.Text = ""
        TextBox_jumlahProduk.Text = ""
        TextBox_status.Text = ""

    End Sub

    Private Sub HomeSalesDistribution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isiGrid()
        load_combo()
    End Sub

    Private Sub Button_tambah_Click(sender As Object, e As EventArgs) Handles Button_tambah.Click
        If Button_tambah.Text = "Tambah" Then
            Button_tambah.Text = "Request"
            GroupBox3.Text = "Tambah"
            Call enable()
            Call clear()
            auto()
            Button_edit.Enabled = False
            Button_hapus.Enabled = False
            DGV.Enabled = False
            Button_edit.BackColor = Color.White
            Button_hapus.BackColor = Color.White
            Button_pdf.BackColor = Color.White
            PictureBox1.Enabled = False
            TextBox_status.Text = "Request"
            TextBox_kodeOrder.Focus()
        Else
            Try
                If ComboBox_namaProduk.Text = "" Or
                    TextBox_namaToko.Text = "" Or
                    TextBox_alamatToko.Text = "" Or
                    TextBox_hargaProduct.Text = "" Then
                    MsgBox("Entry tidak boleh kosong", MsgBoxStyle.Exclamation, "Peringatan")
                    TextBox_kodeOrder.Focus()
                    Exit Sub
                End If

                Call koneksi()

                oc = New OdbcCommand("Select code_order from sales_order " &
                                     "where code_order = '" & TextBox_kodeOrder.Text & "'", conn)
                dr = oc.ExecuteReader
                dr.Read()

                If dr.HasRows Then
                    MsgBox("Maaf, Produk tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
                    TextBox_kodeOrder.Focus()
                    Exit Sub

                Else

                    Call koneksi()
                    simpan = "INSERT INTO sales_order (`salesorder_id`," &
                        "`code_order`,`order_date`,`purchase_date`,`shipping_date`," &
                        "`jumlah_order`,`produk_name`,`store_name`," &
                        "`store_address`,`product_price`,`price_total`,`status`)" &
                        "VALUES ('" & TextBox_kodeOrder.Text & "'," &
                        "'" & TextBox_kodeOrder.Text & "'," &
                        "'" & DateTimePicker_order.Text & "'," &
                        "'" & DateTimePicker_pembayaran.Text & "'," &
                        "'" & DateTimePicker_TPengiriman.Text & "'," &
                        "'" & TextBox_jumlahProduk.Text & "'," &
                        "'" & ComboBox_namaProduk.Text & "'," &
                        "'" & TextBox_namaToko.Text & "'," &
                        "'" & TextBox_alamatToko.Text & "'," &
                        "'" & TextBox_hargaProduct.Text & "'," &
                        "'" & TextBox_totalHarga.Text & "'," &
                        "'" & TextBox_status.Text & "')"

                    oc = New OdbcCommand(simpan, conn)
                    oc.ExecuteNonQuery()

                    conn.Close()
                    Call isiGrid()
                    Call desable()
                    Call clear()
                    Button_tambah.Text = "Tambah"
                    Button_edit.Enabled = True
                    Button_hapus.Enabled = True
                    Button_pdf.Enabled = True
                    Button_edit.BackColor = Color.MediumSlateBlue
                    Button_hapus.BackColor = Color.MediumSlateBlue
                    Button_pdf.BackColor = Color.MediumSlateBlue
                    DGV.Enabled = True
                    Call isiGrid()

                    Try
                        MsgBox("Data berhasil disimpan", vbInformation, "Informasi")

                    Catch ex As Exception
                        MsgBox("error", MsgBoxStyle.Exclamation)
                    End Try
                End If

            Catch ex As Exception
                MsgBox("error!!!", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub Button_batal_Click(sender As Object, e As EventArgs) Handles Button_batal.Click
        Try
            Button_batal.Text = "Batal"
            Button_tambah.Text = "Tambah"
            Button_edit.Text = "Edit"
            GroupBox3.Text = "<<Order>>"
            Button_tambah.Enabled = True
            Button_edit.Enabled = True
            Button_hapus.Enabled = True
            DGV.Enabled = True
            PictureBox1.Enabled = True
            Button_edit.BackColor = Color.MediumSlateBlue
            Button_hapus.BackColor = Color.MediumSlateBlue
            Button_pdf.BackColor = Color.MediumSlateBlue
            Call isiGrid()
            Call desable()
            Call clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        If TextBox_kodeOrder.Text = "" Then
            MsgBox("Tidak ada data yang akan di edit", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If Button_edit.Text = "Edit" Then
            Button_edit.Text = "Simpan"
            GroupBox3.Text = "Edit"
            Button_hapus.Enabled = False
            Button_tambah.Enabled = False
            PictureBox1.Enabled = False
            Call enable()
            Button_tambah.BackColor = Color.White
            Button_hapus.BackColor = Color.White
            Button_pdf.BackColor = Color.White
            TextBox_kodeOrder.Enabled = False
            TextBox_kodeOrder.Focus()
        Else
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
                    "status = '" & TextBox_status.Text & "'," &
                    "product_price = '" & TextBox_hargaProduct.Text & "' where code_order='" & TextBox_kodeOrder.Text & "'"
                oc = New OdbcCommand(edi_data, conn)
                oc.ExecuteNonQuery()

                MsgBox("Data berhasil diedit", MsgBoxStyle.Information)
                Call desable()
                Call clear()
                Button_edit.Text = "Edit"
                Button_hapus.Enabled = True
                Button_tambah.Enabled = True
                Call isiGrid()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
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
                TextBox_status.Text = row.Cells("Status").Value

            End If
            If TextBox_status.Text = "Dikirim" Or TextBox_status.Text = "Pending" Then
                Button_edit.Enabled = False
                Button_hapus.Enabled = False
                Button_batal.Enabled = True
                Button_batal.Text = "Clear"
                Button_pdf.Enabled = True
                PictureBox1.Enabled = True
            Else
                Button_edit.Enabled = True
                Button_hapus.Enabled = True
                Button_batal.Enabled = False
                Button_batal.Text = "Batal"
                Button_pdf.Enabled = False
                PictureBox1.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message)
        End Try
    End Sub

    Private Sub Button_Kembali_Click(sender As Object, e As EventArgs) Handles Button_Kembali.Click
        HomeSalesDistribution.Show()
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

    Sub auto()
        Try
            kon = New MySqlConnection
            kon.ConnectionString = "server=localhost; uid=root; password=; database=sisent"
            kon.Open()
            myCommand = New MySqlCommand("Select code_order from sales_order where code_order in(select max(code_order) from sales_order)", kon)
            myDataReader = myCommand.ExecuteReader
            myDataReader.Read()
            If myDataReader.HasRows = 0 Then
                TextBox_kodeOrder.Text = "SD" + Date.Now.ToString("yyMMdd") + "0001"
                myDataReader.Close()
            End If
            If Not myDataReader.HasRows Then
                TextBox_kodeOrder.Text = "SD" + Date.Now.ToString("yyMMdd") + "0001"
                myDataReader.Close()
            Else
                TextBox_kodeOrder.Text = Val(Microsoft.VisualBasic.Right(myDataReader.Item("code_order").ToString, 4)) + 1
                If Len(TextBox_kodeOrder.Text) = 1 Then
                    TextBox_kodeOrder.Text = "SD" + Date.Now.ToString("yyMMdd") + "000" & TextBox_kodeOrder.Text & ""
                ElseIf Len(TextBox_kodeOrder.Text) = 2 Then
                    TextBox_kodeOrder.Text = "SD" + Date.Now.ToString("yyMMdd") + "00" & TextBox_kodeOrder.Text & ""
                ElseIf Len(TextBox_kodeOrder.Text) = 3 Then
                    TextBox_kodeOrder.Text = "SD" + Date.Now.ToString("yyMMdd") + "0" & TextBox_kodeOrder.Text & ""
                End If
            End If
            kon.Close()
        Catch ex As Exception

        End Try

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

    Private Sub TextBox_hargaProduct_TextChanged(sender As Object, e As EventArgs) Handles TextBox_hargaProduct.TextChanged
        Try
            If TextBox_hargaProduct.Text = "" Or Not IsNumeric(TextBox_hargaProduct.Text) Then
                Exit Sub
            End If
            Dim f As Double
            f = TextBox_hargaProduct.Text
            TextBox_hargaProduct.Text = Format(f, "#.###")
            TextBox_hargaProduct.SelectionStart = Len(TextBox_hargaProduct.Text)

            a = TextBox_hargaProduct.Text

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBox_jumlahProduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_jumlahProduk.KeyPress
        If Strings.InStr("0123456789," & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
            MsgBox("Masukkan Angka", MsgBoxStyle.Exclamation, "Peringatan")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox_jumlahProduk.TextChanged
        b = TextBox_jumlahProduk.Text
        TextBox_totalHarga.Text = Val(b) * Val(a)
    End Sub

    Private Sub TextBox_totalHarga_TextChanged(sender As Object, e As EventArgs) Handles TextBox_totalHarga.TextChanged
        Try
            If TextBox_totalHarga.Text = "" Or Not IsNumeric(TextBox_totalHarga.Text) Then
                Exit Sub
            End If
            Dim f As Double
            f = TextBox_totalHarga.Text
            TextBox_totalHarga.Text = Format(f, "#,###")
            TextBox_totalHarga.SelectionStart = Len(TextBox_totalHarga.Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_note_Click(sender As Object, e As EventArgs)
        If TextBox_kodeOrder.Text = "" Then
            MsgBox("Kode Order Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Peringatan!!")
        End If
        Try
            koneksi()
            Dim q As String = "select note from sales_order where code_order = '" & TextBox_kodeOrder.Text & "'"
            oc = New OdbcCommand(q, conn)
            dr = oc.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox(dr.Item("note"), MsgBoxStyle.Information, "Note")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Kode Order Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Peringatan!!")
        End Try
    End Sub

    Private Sub Button_pdf_Click(sender As Object, e As EventArgs) Handles Button_pdf.Click
        Try
            If TextBox_kodeOrder.Text = "" Or
                DateTimePicker_order.Text = "" Or
                DateTimePicker_pembayaran.Text = "" Or
                DateTimePicker_TPengiriman.Text = "" Or
                ComboBox_namaProduk.Text = "" Or
                TextBox_namaToko.Text = "" Or
                TextBox_alamatToko.Text = "" Or
                TextBox_hargaProduct.Text = "" Or
                TextBox_totalHarga.Text = "" Or
                TextBox_jumlahProduk.Text = "" Or
                TextBox_status.Text = "" Then
                MsgBox("Isian Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                Dim pdfDoc As New Document
                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(TextBox_kodeOrder.Text + ".pdf", FileMode.Create))
                pdfDoc.Open()
                'pdfDoc.Add(New Paragraph("Test"))
                Dim table As New PdfPTable(2)
                Dim cell As New PdfPCell(New Phrase("Daftar Tagihan"))
                cell.Colspan = 10
                cell.HorizontalAlignment = 1

                table.AddCell(cell)
                table.AddCell(("List"))
                table.AddCell("Nilai")
                table.AddCell("Kode Order")
                table.AddCell(TextBox_kodeOrder.Text)
                table.AddCell("Tanggal Pemesanan")
                table.AddCell(DateTimePicker_order.Text)
                table.AddCell("Tanggal Pembayaran")
                table.AddCell(DateTimePicker_pembayaran.Text)
                table.AddCell("Tanggal Pengiriman")
                table.AddCell(DateTimePicker_TPengiriman.Text)
                table.AddCell("Nama Toko")
                table.AddCell(TextBox_namaToko.Text)
                table.AddCell("Alamat Toko")
                table.AddCell(TextBox_alamatToko.Text)
                table.AddCell("Nama Produk")
                table.AddCell(ComboBox_namaProduk.Text)
                table.AddCell("Harga Produk")
                table.AddCell("Rp " + TextBox_hargaProduct.Text)
                table.AddCell("Jumlah Produk")
                table.AddCell(TextBox_jumlahProduk.Text)
                table.AddCell("Total Harga")
                table.AddCell("Rp " + TextBox_totalHarga.Text)
                table.AddCell("Status Pengiriman")
                table.AddCell(TextBox_status.Text)
                pdfDoc.Add(table)
                pdfDoc.Close()
                MsgBox("Data Telah Disimpan Dengan Nama = " + TextBox_kodeOrder.Text + ".pdf", MsgBoxStyle.Information, "Tersimpan")
            End If
        Catch ex As Exception
            MsgBox("Gagal", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    
    Private Sub RadioButton_namaProduk_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_namaProduk.CheckedChanged
        filter = "produk_name LIKE"
    End Sub

    Private Sub RadioButton_namaToko_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_namaToko.CheckedChanged
        filter = "store_name LIKE"
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If TextBox_kodeOrder.Text = "" Then
            MsgBox("Kode Order Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Peringatan!!")
        End If
        Try
            koneksi()
            Dim q As String = "select note from sales_order where code_order = '" & TextBox_kodeOrder.Text & "'"
            oc = New OdbcCommand(q, conn)
            dr = oc.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If dr.Item("note") = "" Then
                    MsgBox("Catatan Tidak Dilampiran", MsgBoxStyle.Exclamation)
                Else
                    MsgBox(dr.Item("note"), MsgBoxStyle.Information, "Note")
                End If

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Kode Order Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Peringatan!!")
        End Try
    End Sub
End Class