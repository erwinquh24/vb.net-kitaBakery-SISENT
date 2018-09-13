Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class ViewDetailMM_PORawMaterial
    'Dim b As Double
    Dim filter, a, b As String

    Private Sub isiGrid()
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select po_bahan_baku.po_bahanbaku_code AS KodePembelian," &
                                     "po_bahan_baku.rawmaterial_name AS NamaRawMaterial," &
                                     "po_bahan_baku.vendor_name AS NamaVendor," &
                                     "po_bahan_baku.purchase_date AS TanggalPembelian," &
                                     "po_bahan_baku.delivery_date AS TanggalPengiriman," &
                                     "po_bahan_baku.jumlah_barang AS JumlahBarang ," &
                                     "po_bahan_baku.total_harga AS TotalHarga ," &
                                     "po_bahan_baku.po_bahanbaku_cost AS BiayaPembelian from po_bahan_baku ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "po_bahan_baku")
            DGV_detail.DataSource = (ds.Tables("po_bahan_baku"))
            DGV_detail.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("salah : " + ex.Message)
        End Try
    End Sub

    Private Sub enable()
        'TextBox_kodePembelian.Enabled = True
        'TextBox_namaMaterial.Enabled = True
        ComboBox_namaMaterial.Enabled = True
        DateTimePicker_pembelian.Enabled = True
        DateTimePicker_pengiriman.Enabled = True
        TextBox_qty.Enabled = True
        TextBox_hargaMaterial.Enabled = True
        'TextBox_THarga.Enabled = True

        Button_batal.Enabled = True
    End Sub

    Private Sub desable()
        TextBox_kodePembelian.Enabled = False
        'TextBox_namaMaterial.Enabled = False
        ComboBox_namaMaterial.Enabled = False
        DateTimePicker_pembelian.Enabled = False
        DateTimePicker_pengiriman.Enabled = False
        TextBox_qty.Enabled = False
        TextBox_hargaMaterial.Enabled = False
        TextBox_THarga.Enabled = False
        Button_batal.Enabled = False
    End Sub

    Private Sub clear()
        TextBox_kodePembelian.Text = ""
        TextBox_namaVendor.Text = ""
        ComboBox_namaMaterial.Text = ""
        DateTimePicker_pembelian.Text = ""
        DateTimePicker_pengiriman.Text = ""
        TextBox_qty.Text = "0"
        TextBox_hargaMaterial.Text = ""
        TextBox_THarga.Text = ""
    End Sub

    Private Sub ViewDetailMM_RawMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isiGrid()
        load_combo()
    End Sub

    Private Sub TextBoxCari_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCari.TextChanged
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select po_bahan_baku.po_bahanbaku_code AS KodePembelian," &
                                     "po_bahan_baku.rawmaterial_name AS NamaRawMaterial," &
                                     "po_bahan_baku.vendor_name AS NamaVendor," &
                                     "po_bahan_baku.purchase_date AS TanggalPembelian," &
                                     "po_bahan_baku.delivery_date AS TanggalPengiriman," &
                                     "po_bahan_baku.jumlah_barang AS JumlahBarang ," &
                                     "po_bahan_baku.total_harga AS TotalHarga ," &
                                     "po_bahan_baku.po_bahanbaku_cost AS BiayaPembelian from po_bahan_baku where " & filter & "'" & TextBoxCari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "po_bahan_baku")
            DGV_detail.DataSource = ds.Tables("po_bahan_baku")
            DGV_detail.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MsgBox("Error!!", MsgBoxStyle.Information, "Peringatan")
        End Try
    End Sub

    Private Sub RadioButton_kodeProduk_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_kodeProduk.CheckedChanged
        filter = "po_bahanbaku_code LIKE"
        conn.Close()
    End Sub

    Private Sub RadioButton_namaProduk_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_namaProduk.CheckedChanged
        filter = "rawmaterial_name LIKE"
        conn.Close()
    End Sub

    Private Sub Button_Kembali_Click(sender As Object, e As EventArgs) Handles Button_Kembali.Click
        Me.Close()
        HomeMM.Show()
    End Sub

    Private Sub Button_tambah_Click(sender As Object, e As EventArgs) Handles Button_tambah.Click
        If Button_tambah.Text = "Tambah" Then
            Button_tambah.Text = "Simpan"
            GroupBox3.Text = "Tambah"
            Call enable()
            Call clear()
            Call auto()
            TextBox_hargaMaterial.Enabled = False
            Button_edit.Enabled = False
            Button_hapus.Enabled = False
            DGV_detail.Enabled = False
            Button_edit.BackColor = Color.White
            Button_hapus.BackColor = Color.White
            Button_pdf.BackColor = Color.White
            TextBox_kodePembelian.Focus()
        Else
            Try
                If TextBox_namaVendor.Text = "" Or
                    TextBox_namaVendor.Text = "" Or
                    TextBox_qty.Text = "" Then
                    MsgBox("Entry tidak boleh kosong", MsgBoxStyle.Exclamation, "Peringatan")
                    TextBox_kodePembelian.Focus()
                    Exit Sub
                End If

                Call koneksi()
                oc = New OdbcCommand("Select po_bahanbaku_code from po_bahan_baku where po_bahanbaku_code = '" & TextBox_kodePembelian.Text & "'", conn)
                dr = oc.ExecuteReader
                dr.Read()


                If dr.HasRows Then
                    MsgBox("Maaf, Material tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
                    TextBox_kodePembelian.Focus()
                    Exit Sub

                Else
                    Call koneksi()
                    simpan = "INSERT INTO po_bahan_baku (`po_bahanbaku_code`," &
                        "`rawmaterial_name`,`vendor_name`," &
                        "`purchase_date`,`delivery_date`," &
                        "`jumlah_barang`,`total_harga`,`po_bahanbaku_cost`)" &
                        "VALUES ('" & TextBox_kodePembelian.Text & "'," &
                        "'" & ComboBox_namaMaterial.Text & "'," &
                        "'" & TextBox_namaVendor.Text & "'," &
                        "'" & DateTimePicker_pembelian.Text & "'," &
                        "'" & DateTimePicker_pengiriman.Text & "'," &
                        "'" & TextBox_qty.Text & "'," &
                        "'" & TextBox_THarga.Text & "'," &
                        "'" & TextBox_hargaMaterial.Text & "')"

                    oc = New OdbcCommand(simpan, conn)
                    oc.ExecuteNonQuery()

                    Call isiGrid()
                    Call desable()
                    Call clear()
                    Button_tambah.Text = "Tambah"
                    Button_edit.Enabled = True
                    Button_hapus.Enabled = True
                    DGV_detail.Enabled = True
                    conn.Close()
                    Call isiGrid()
                    Try
                        MsgBox("Data berhasil disimpan", vbInformation, "Informasi")
                    Catch ex As Exception
                        MsgBox("error", MsgBoxStyle.Exclamation)
                    End Try
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DGV_detail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_detail.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DGV_detail.Rows(e.RowIndex)
                TextBox_kodePembelian.Text = row.Cells("KodePembelian").Value
                TextBox_namaVendor.Text = row.Cells("NamaVendor").Value
                ComboBox_namaMaterial.Text = row.Cells("NamaRawMaterial").Value
                DateTimePicker_pembelian.Text = row.Cells("TanggalPembelian").Value
                DateTimePicker_pengiriman.Text = row.Cells("TanggalPengiriman").Value
                TextBox_qty.Text = row.Cells("JumlahBarang").Value
                TextBox_THarga.Text = row.Cells("TotalHarga").Value
                TextBox_hargaMaterial.Text = row.Cells("BiayaPembelian").Value
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("error", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        If TextBox_namaVendor.Text = "" Then
            MsgBox("Tidak ada data yang akan di edit", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If Button_edit.Text = "Edit" Then
            Button_edit.Text = "Simpan"
            GroupBox3.Text = "Edit"
            Button_hapus.Enabled = False
            Button_tambah.Enabled = False
            Button_tambah.BackColor = Color.White
            Button_hapus.BackColor = Color.White
            Button_pdf.BackColor = Color.White
            Call enable()
            TextBox_kodePembelian.Enabled = False
            TextBox_kodePembelian.Focus()
        Else
            Try
                Call koneksi()
                edi_data = "UPDATE po_bahan_baku SET rawmaterial_name = '" & TextBox_namaVendor.Text & "'," &
                    "vendor_name = '" & ComboBox_namaMaterial.Text & "'," &
                    "purchase_date = '" & DateTimePicker_pembelian.Text & "'," &
                    "delivery_date = '" & DateTimePicker_pengiriman.Text & "'," &
                    "jumlah_barang = '" & TextBox_qty.Text & "'," &
                    "total_harga = '" & TextBox_THarga.Text & "'," &
                    "po_bahanbaku_cost = '" & TextBox_hargaMaterial.Text & "' where po_bahanbaku_code = '" & TextBox_kodePembelian.Text & "'"
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
        If TextBox_namaVendor.Text = "" Then
            MsgBox("Tidak ada data yang akan di hapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        Else
            Dim pesan
            pesan = MsgBox("Apakah data ini akan dihapus", MsgBoxStyle.Question + vbYesNo, "Peringatan")
            If pesan = vbYes Then
                Try
                    Call koneksi()
                    hapus = "DELETE FROM po_bahan_baku where po_bahanbaku_code='" & TextBox_kodePembelian.Text & "'"

                    oc = New OdbcCommand(hapus, conn)
                    oc.ExecuteNonQuery()

                    conn.Close()
                    MsgBox("Data berhasil di hapus", MsgBoxStyle.Information, "Informasi")
                    Call isiGrid()

                Catch ex As Exception
                    MsgBox("Data gagal di Hapus", MsgBoxStyle.Exclamation, "Peringatan")
                End Try
            End If
        End If
    End Sub

    Private Sub Button_batal_Click(sender As Object, e As EventArgs) Handles Button_batal.Click
        Button_tambah.Text = "Tambah"
        Button_edit.Text = "Edit"
        GroupBox3.Text = "<<Raw Material>>"
        Button_tambah.Enabled = True
        Button_edit.Enabled = True
        Button_hapus.Enabled = True
        DGV_detail.Enabled = True
        Call isiGrid()
        Call desable()
        TextBox_kodePembelian.Text = ""
        Call clear()
    End Sub

    Private Sub load_combo()
        Try
            myKoneksi()
            Dim query As String
            query = "select name_material from sisent.bahanbaku "

            myCommand = New MySqlCommand(query, kon)
            myDataReader = myCommand.ExecuteReader
            While myDataReader.Read
                ComboBox_namaMaterial.Items.Add(myDataReader("name_material"))
            End While
            kon.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal : " + ex.Message)
        End Try

    End Sub

    Private Sub ComboBox_namaVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_namaMaterial.SelectedIndexChanged
        myKoneksi()
        Dim query As String = "select * from bahanbaku where name_material='" & ComboBox_namaMaterial.Text & "'"
        myCommand = New MySqlCommand(query, kon)
        myDataReader = myCommand.ExecuteReader
        myDataReader.Read()
        If myDataReader.HasRows Then
            TextBox_namaVendor.Text = myDataReader.Item("vendor_name")
            TextBox_hargaMaterial.Text = myDataReader.Item("price")
        End If
    End Sub

   

    Private Sub auto()
        Try
            kon = New MySqlConnection

            kon.ConnectionString = "server=localhost; uid=root; password=; database=sisent"
            kon.Open()
            myCommand = New MySqlCommand("Select po_bahanbaku_code from po_bahan_baku where po_bahanbaku_code in(select max(po_bahanbaku_code) from po_bahan_baku)", kon)
            myDataReader = myCommand.ExecuteReader
            myDataReader.Read()
            If myDataReader.HasRows = 0 Then
                TextBox_kodePembelian.Text = "PORM" + Date.Now.ToString("yyMMdd") + "0001"
                myDataReader.Close()
            End If
            If Not myDataReader.HasRows Then
                TextBox_kodePembelian.Text = "PORM" + Date.Now.ToString("yyMMdd") + "0001"
                myDataReader.Close()
            Else
                TextBox_kodePembelian.Text = Val(Microsoft.VisualBasic.Right(myDataReader.Item("po_bahanbaku_code").ToString, 3)) + 1
                If Len(TextBox_kodePembelian.Text) = 1 Then
                    TextBox_kodePembelian.Text = "PORM" + Date.Now.ToString("yyMMdd") + "000" & TextBox_kodePembelian.Text & ""
                ElseIf Len(TextBox_kodePembelian.Text) = 2 Then
                    TextBox_kodePembelian.Text = "PORM" + Date.Now.ToString("yyMMdd") + "00" & TextBox_kodePembelian.Text & ""
                ElseIf Len(TextBox_kodePembelian.Text) = 3 Then
                    TextBox_kodePembelian.Text = "PORM" + Date.Now.ToString("yyMMdd") + "0" & TextBox_kodePembelian.Text & ""
                End If
            End If
            kon.Close()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub TextBox_hargaMaterial_TextChanged(sender As Object, e As EventArgs) Handles TextBox_hargaMaterial.TextChanged

        Try
            If TextBox_hargaMaterial.Text = "" Or Not IsNumeric(TextBox_hargaMaterial.Text) Then
                Exit Sub
            End If
            Dim f As Double
            f = TextBox_hargaMaterial.Text
            TextBox_hargaMaterial.Text = Format(f, "#.###")
            TextBox_hargaMaterial.SelectionStart = Len(TextBox_hargaMaterial.Text)

            a = TextBox_hargaMaterial.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub TextBox_qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_qty.KeyPress
        If Strings.InStr("0123456789," & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
            MsgBox("Masukkan Angka", MsgBoxStyle.Exclamation, "Peringatan")
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox_qty.TextChanged
        Try
            b = TextBox_qty.Text
            TextBox_THarga.Text = Val(a) * Val(b)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox_THarga_TextChanged(sender As Object, e As EventArgs) Handles TextBox_THarga.TextChanged
        Try
            If TextBox_THarga.Text = "" Or Not IsNumeric(TextBox_THarga.Text) Then
                Exit Sub
            End If
            Dim f As Double
            f = TextBox_THarga.Text
            TextBox_THarga.Text = Format(f, "#,###")
            TextBox_THarga.SelectionStart = Len(TextBox_THarga.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox_kodePembelian_TextChanged(sender As Object, e As EventArgs) Handles TextBox_kodePembelian.TextChanged

    End Sub

    Private Sub Button_pdf_Click(sender As Object, e As EventArgs) Handles Button_pdf.Click
        Try
            If TextBox_kodePembelian.Text = "" Or
                TextBox_namaVendor.Text = "" Or
                ComboBox_namaMaterial.Text = "" Or
                DateTimePicker_pembelian.Text = "" Or
                DateTimePicker_pengiriman.Text = "" Or
                TextBox_qty.Text = "" Or
                TextBox_hargaMaterial.Text = "" Or
                TextBox_THarga.Text = "" Then
                MsgBox("Isian Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                Dim pdfDoc As New Document
                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(TextBox_kodePembelian.Text + ".pdf", FileMode.Create))
                pdfDoc.Open()
                'pdfDoc.Add(New Paragraph("Test"))
                Dim table As New PdfPTable(2)
                Dim cell As New PdfPCell(New Phrase("Daftar Tagihan"))
                cell.Colspan = 10
                cell.HorizontalAlignment = 1

                table.AddCell(cell)
                table.AddCell(("List"))
                table.AddCell("Nilai")
                table.AddCell("Kode Pembelian")
                table.AddCell(TextBox_kodePembelian.Text)
                table.AddCell("Tanggal Pembelian")
                table.AddCell(DateTimePicker_pembelian.Text)
                table.AddCell("Tanggal Pengiriman")
                table.AddCell(DateTimePicker_pengiriman.Text)
                table.AddCell("Nama Material")
                table.AddCell(ComboBox_namaMaterial.Text)
                table.AddCell("Nama Vendor")
                table.AddCell(TextBox_namaVendor.Text)
                table.AddCell("Harga Material")
                table.AddCell("Rp " + TextBox_hargaMaterial.Text)
                table.AddCell("Jumlah Produk")
                table.AddCell(TextBox_qty.Text)
                table.AddCell("Total Harga")
                table.AddCell("Rp " + TextBox_THarga.Text)
                pdfDoc.Add(table)
                pdfDoc.Close()
                MsgBox("Data Telah Disimpan Dengan Nama = " + TextBox_kodePembelian.Text + ".pdf", MsgBoxStyle.Information, "Tersimpan")
            End If
        Catch ex As Exception
            MsgBox("Gagal", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    
End Class