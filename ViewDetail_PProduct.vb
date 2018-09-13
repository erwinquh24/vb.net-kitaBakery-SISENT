Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class ViewDetail_PProduct
    Dim a, b As String
    Dim save, filter As String

    Private Sub isiGrid()
        Try
            Call koneksi()

            da = New OdbcDataAdapter("Select p_bahanbaku.p_bahanbaku_code as CodePBahanBaku, " &
                                     "p_bahanbaku.status as Status, " &
                                     "p_bahanbaku.bahanbaku_name as NamaBahanBaku, " &
                                     "p_bahanbaku.tanggal_pemesanan as TanggalPemesanan, " &
                                     "p_bahanbaku.tanggal_selesai as TanggalSelesai, " &
                                     "p_bahanbaku.jumlah_bahanbaku as JumlahBahanBaku from p_bahanbaku ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "p_bahanbaku")
            DGV.DataSource = (ds.Tables("p_bahanbaku"))
            DGV.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub enable()
        'TextBox_kodeOrder.Enabled = True
        DateTimePicker_order.Enabled = True
        'DateTimePicker_TPengiriman.Enabled = True
        ComboBox_namaBahanBaku.Enabled = True
        'TextBox_hargaProduct.Enabled = True
        Button_batal.Enabled = True
        PictureBox1.Enabled = True
        TextBox_jumlahBahanBaku.Enabled = True
        'TextBox_status.Enabled = True

    End Sub

    Private Sub desable()
        TextBox_kodeOrder.Enabled = False
        DateTimePicker_order.Enabled = False
        DateTimePicker_selesai.Enabled = False
        ComboBox_namaBahanBaku.Enabled = False
        TextBox_jumlahBahanBaku.Enabled = False
        'TextBox_hargaProduct.Enabled = False
        Button_batal.Enabled = False
        PictureBox1.Enabled = False
        TextBox_status.Enabled = False
    End Sub

    Private Sub clear()
        TextBox_kodeOrder.Text = ""
        ComboBox_namaBahanBaku.Text = ""
        TextBox_jumlahBahanBaku.Text = ""
        TextBox_status.Text = ""

    End Sub

    Sub auto()
        Try
            kon = New MySqlConnection

            kon.ConnectionString = "server=localhost; uid=root; password=; database=sisent"
            kon.Open()
            myCommand = New MySqlCommand("Select p_bahanbaku_code from p_bahanbaku where p_bahanbaku_code in(select max(p_bahanbaku_code) from p_bahanbaku)", kon)
            myDataReader = myCommand.ExecuteReader
            myDataReader.Read()
            If myDataReader.HasRows = 0 Then
                TextBox_kodeOrder.Text = "PP" + Date.Now.ToString("yyMMdd") + "0001"
                myDataReader.Close()
            End If
            If Not myDataReader.HasRows Then
                TextBox_kodeOrder.Text = "PP" + Date.Now.ToString("yyMMdd") + "0001"
                myDataReader.Close()
            Else
                TextBox_kodeOrder.Text = Val(Microsoft.VisualBasic.Right(myDataReader.Item("p_bahanbaku_code").ToString, 4)) + 1
                If Len(TextBox_kodeOrder.Text) = 1 Then
                    TextBox_kodeOrder.Text = "PP" + Date.Now.ToString("yyMMdd") + "000" & TextBox_kodeOrder.Text & ""
                ElseIf Len(TextBox_kodeOrder.Text) = 2 Then
                    TextBox_kodeOrder.Text = "PP" + Date.Now.ToString("yyMMdd") + "00" & TextBox_kodeOrder.Text & ""
                ElseIf Len(TextBox_kodeOrder.Text) = 3 Then
                    TextBox_kodeOrder.Text = "PP" + Date.Now.ToString("yyMMdd") + "0" & TextBox_kodeOrder.Text & ""
                End If
            End If
            kon.Close()
        Catch ex As Exception

        End Try
    End Sub

    Function get_stock(ByVal m_name As String) As Integer
        Dim stock As Integer
        Dim query As String = "select quantity from bahanbaku where name_material=@m_name"
        myKoneksi()
        myCommand = New MySqlCommand(query, kon)
        myCommand.Parameters.AddWithValue("@m_name", m_name)
        myDataReader = myCommand.ExecuteReader()
        While myDataReader.Read()
            stock = myDataReader("quantity")
        End While
        kon.Close()
        Return stock
    End Function

    Dim m_name As String


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
            DateTimePicker_order.Enabled = False
            PictureBox1.Enabled = False
            TextBox_status.Text = "Request"
            TextBox_kodeOrder.Focus()
        Else
            Try
                If TextBox_jumlahBahanBaku.Text = "" Or
                    ComboBox_namaBahanBaku.Text = "" Then
                    MsgBox("Entry tidak boleh kosong", MsgBoxStyle.Exclamation, "Peringatan")
                    TextBox_kodeOrder.Focus()
                    Exit Sub
                End If

                Call koneksi()

                oc = New OdbcCommand("Select p_bahanbaku_code from p_bahanbaku " &
                                     "where p_bahanbaku_code = '" & TextBox_kodeOrder.Text & "'", conn)
                dr = oc.ExecuteReader
                dr.Read()

                If dr.HasRows Then
                    MsgBox("Maaf, Produk tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
                    TextBox_kodeOrder.Focus()
                    Exit Sub

                Else

                    Call koneksi()
                    simpan = "INSERT INTO p_bahanbaku (`p_bahanbaku_id`," &
                        "`p_bahanbaku_code`,`tanggal_pemesanan`,`tanggal_selesai`," &
                        "`bahanbaku_name`,`jumlah_bahanbaku`,`status`)" &
                        "VALUES ('" & TextBox_kodeOrder.Text & "'," &
                        "'" & TextBox_kodeOrder.Text & "'," &
                        "'" & DateTimePicker_order.Text & "'," &
                        "'" & DateTimePicker_selesai.Text & "'," &
                        "'" & ComboBox_namaBahanBaku.Text & "'," &
                        "'" & TextBox_jumlahBahanBaku.Text & "'," &
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

    Private Sub CreateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_combo()
        isiGrid()
    End Sub

    Private Sub load_combo()
        Try
            myKoneksi()
            Dim query As String
            query = "select name_material from sisent.bahanbaku"

            myCommand = New MySqlCommand(query, kon)
            myDataReader = myCommand.ExecuteReader
            While myDataReader.Read
                ComboBox_namaBahanBaku.Items.Add(myDataReader("name_material"))
            End While
            kon.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal : " + ex.Message)
        End Try
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DGV.Rows(e.RowIndex)
            TextBox_kodeOrder.Text = row.Cells("CodePBahanBaku").Value
            DateTimePicker_order.Text = row.Cells("TanggalPemesanan").Value
            DateTimePicker_selesai.Text = row.Cells("TanggalSelesai").Value
            ComboBox_namaBahanBaku.Text = row.Cells("NamaBahanBaku").Value
            TextBox_jumlahBahanBaku.Text = row.Cells("JumlahBahanBaku").Value
            TextBox_status.Text = row.Cells("Status").Value
        End If

        If TextBox_status.Text = "Selesai" Or TextBox_status.Text = "Pending" Then
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
                edi_data = "UPDATE p_bahanbaku SET  tanggal_pemesanan= '" & DateTimePicker_order.Text & "'," &
                    "tanggal_selesai = '" & DateTimePicker_selesai.Text & "'," &
                    "bahanbaku_name = '" & ComboBox_namaBahanBaku.Text & "'," &
                    "jumlah_bahanbaku = '" & TextBox_jumlahBahanBaku.Text & "'," &
                    "status = '" & TextBox_status.Text & "' where p_bahanbaku_code='" & TextBox_kodeOrder.Text & "'"
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
            Button_tambah.BackColor = Color.MediumSlateBlue
            Button_hapus.BackColor = Color.MediumSlateBlue
            Button_pdf.BackColor = Color.MediumSlateBlue
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
                    hapus = "DELETE FROM p_bahanbaku where p_bahanbaku_code='" & TextBox_kodeOrder.Text & "'"

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

    Private Sub Button_batal_Click(sender As Object, e As EventArgs) Handles Button_batal.Click
        Try
            Button_batal.Text = "Batal"
            Button_tambah.Text = "Tambah"
            Button_edit.Text = "Edit"
            GroupBox3.Text = "<<P Bahan Baku>>"
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If TextBox_kodeOrder.Text = "" Then
            MsgBox("Kode Order Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Peringatan!!")

        End If
        Try
            koneksi()
            Dim q As String = "select note from p_bahanbaku where p_bahanbaku_code = '" & TextBox_kodeOrder.Text & "'"
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

    Private Sub Button_pdf_Click(sender As Object, e As EventArgs) Handles Button_pdf.Click
        Try
            If TextBox_kodeOrder.Text = "" Or
                DateTimePicker_order.Text = "" Or
                DateTimePicker_selesai.Text = "" Or
                ComboBox_namaBahanBaku.Text = "" Or
                TextBox_jumlahBahanBaku.Text = "" Then
                MsgBox("Isian Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Else
                Dim pdfDoc As New Document
                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(TextBox_kodeOrder.Text + ".pdf", FileMode.Create))
                pdfDoc.Open()
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
                table.AddCell("Tanggal Selesai")
                table.AddCell(DateTimePicker_selesai.Text)
                table.AddCell("Nama Raw Material")
                table.AddCell(ComboBox_namaBahanBaku.Text)
                table.AddCell("Jumlah Raw Material")
                table.AddCell(TextBox_jumlahBahanBaku.Text)
                table.AddCell("Status")
                table.AddCell(TextBox_status.Text)
                pdfDoc.Add(table)
                pdfDoc.Close()
                MsgBox("Data Telah Disimpan Dengan Nama = " + TextBox_kodeOrder.Text + ".pdf", MsgBoxStyle.Information, "Tersimpan")
            End If
        Catch ex As Exception
            MsgBox("Gagal", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button_Kembali_Click(sender As Object, e As EventArgs) Handles Button_Kembali.Click

    End Sub
End Class