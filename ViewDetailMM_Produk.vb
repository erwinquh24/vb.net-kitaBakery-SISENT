Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

'Imports MySql.Data.MySqlClient

Public Class ViewDetailMM_Produk

    Dim filter As String

    Private Sub isiGrid()
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select product.product_code as KodeProduk," &
                                     "product.product_name as NamaProduk," &
                                     "product.price as Harga, " &
                                     "product.stock as Stok from product ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "product")
            DGV.DataSource = (ds.Tables("product"))
            DGV.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub enable()
        'TextBox_Kode.Enabled = True
        TextBox_nProduk.Enabled = True
        TextBox_Harga.Enabled = True
        NumericUpDown_jumlahProduk.Enabled = True
        Button_batal.Enabled = True
    End Sub

    Private Sub desable()
        TextBox_Kode.Enabled = False
        TextBox_nProduk.Enabled = False
        TextBox_Harga.Enabled = False
        NumericUpDown_jumlahProduk.Enabled = False
        Button_batal.Enabled = False
    End Sub

    Private Sub clear()
        'TextBox_Kode.Text = ""
        TextBox_nProduk.Text = ""
        TextBox_Harga.Text = ""
        NumericUpDown_jumlahProduk.Text = "0"
    End Sub

    Private Sub ViewDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isiGrid()
    End Sub

    Private Sub Button_Kembali_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub Button_tambah_Click(sender As Object, e As EventArgs) Handles Button_tambah.Click
        If Button_tambah.Text = "Tambah" Then
            Button_tambah.Text = "Simpan"
            GroupBox3.Text = "Tambah"
            Call enable()
            Call clear()
            auto()
            Button_edit.Enabled = False
            Button_hapus.Enabled = False
            DGV.Enabled = False
            Button_edit.BackColor = Color.White
            Button_hapus.BackColor = Color.White
            TextBox_Kode.Focus()
        Else
            Try
                If TextBox_Kode.Text = "" Or
                    TextBox_nProduk.Text = "" Or
                    TextBox_Harga.Text = "" Or
                    NumericUpDown_jumlahProduk.Text = "" Then
                    MsgBox("Entry tidak boleh kosong", MsgBoxStyle.Exclamation, "Peringatan")
                    TextBox_Kode.Focus()
                    Exit Sub
                End If

                Call koneksi()
                oc = New OdbcCommand("Select product_code from product where product_name = '" & TextBox_nProduk.Text & "'", conn)
                dr = oc.ExecuteReader
                dr.Read()


                If dr.HasRows Then
                    MsgBox("Maaf, Produk tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
                    TextBox_Kode.Focus()
                    Exit Sub

                Else
                    Call koneksi()
                    simpan = "INSERT INTO product (`product_id`,`product_code`,`product_name`,`price`,`stock`)" &
                        "VALUES ('" & TextBox_Kode.Text & "','" & TextBox_Kode.Text & "','" & TextBox_nProduk.Text & "'," &
                        "'" & TextBox_Harga.Text & "'," &
                        "'" & NumericUpDown_jumlahProduk.Text & "')"

                    oc = New OdbcCommand(simpan, conn)
                    oc.ExecuteNonQuery()

                    Call isiGrid()
                    Call desable()
                    Call clear()
                    Button_tambah.Text = "Tambah"
                    Button_edit.Enabled = True
                    Button_hapus.Enabled = True
                    DGV.Enabled = True
                    TextBox_Kode.Text = ""
                    Call isiGrid()
                    conn.Close()
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



    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        If TextBox_Kode.Text = "" Then
            MsgBox("Tidak ada data yang akan di edit", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If Button_edit.Text = "Edit" Then
            Button_edit.Text = "Simpan"
            GroupBox3.Text = "Edit"
            Button_hapus.Enabled = False
            Button_tambah.Enabled = False
            Button_hapus.BackColor = Color.White
            Button_tambah.BackColor = Color.White
            Call enable()
            TextBox_Kode.Enabled = False
            TextBox_Kode.Focus()
        Else
            Try
                Call koneksi()
                edi_data = "UPDATE product SET product_name = '" & TextBox_nProduk.Text & "'," &
                    "price = '" & TextBox_Harga.Text & "'," &
                    "stock = '" & NumericUpDown_jumlahProduk.Text & "' WHERE product_code='" & TextBox_Kode.Text & "'"
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
        If TextBox_Kode.Text = "" Then
            MsgBox("Tidak ada data yang akan di hapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        Else
            Dim pesan
            pesan = MsgBox("Apakah data ini akan dihapus", MsgBoxStyle.Question + vbYesNo, "Peringatan")
            If pesan = vbYes Then
                Try
                    Call koneksi()
                    hapus = "DELETE FROM product where product_code='" & TextBox_Kode.Text & "'"

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
            Button_tambah.Text = "Tambah"
            Button_edit.Text = "Edit"
            GroupBox3.Text = "<<Produk>>"
            Button_tambah.Enabled = True
            Button_edit.Enabled = True
            Button_hapus.Enabled = True
            DGV.Enabled = True
            TextBox_Kode.Text = ""

            Call isiGrid()
            Call desable()
            Call clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        HomeMM.Show()
    End Sub

    Private Sub TextBox_cari_TextChanged(sender As Object, e As EventArgs) Handles TextBox_cari.TextChanged
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select product.product_id as IdProduk, " &
                                     "product.product_code as KodeProduk," &
                                     "product.product_name as NamaProduk," &
                                     "product.price as Harga, " &
                                     "product.stock as Stok from product where " & filter & "'" & TextBox_cari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "product")
            DGV.DataSource = ds.Tables("product")
            DGV.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Sub auto()
        Try
            kon = New MySqlConnection

            kon.ConnectionString = "server=localhost; uid=root; password=; database=sisent"
            kon.Open()
            myCommand = New MySqlCommand("Select product_code from product where product_code in(select max(product_code) from product)", kon)
            myDataReader = myCommand.ExecuteReader
            myDataReader.Read()
            If myDataReader.HasRows = 0 Then
                TextBox_Kode.Text = "PR" + "0001"
                myDataReader.Close()
            End If
            If Not myDataReader.HasRows Then
                TextBox_Kode.Text = "PR" + "0001"
                myDataReader.Close()
            Else
                TextBox_Kode.Text = Val(Microsoft.VisualBasic.Right(myDataReader.Item("product_code").ToString, 3)) + 1
                If Len(TextBox_Kode.Text) = 1 Then
                    TextBox_Kode.Text = "PR" + "000" & TextBox_Kode.Text & ""
                ElseIf Len(TextBox_Kode.Text) = 2 Then
                    TextBox_Kode.Text = "PR" + "00" & TextBox_Kode.Text & ""
                ElseIf Len(TextBox_Kode.Text) = 3 Then
                    TextBox_Kode.Text = "PR" + "0" & TextBox_Kode.Text & ""
                End If
            End If
            kon.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RadioButton_KProduk_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_KProduk.CheckedChanged
        filter = "product_code LIKE"
        conn.Close()
    End Sub

    Private Sub RadioButton_NProduk_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_NProduk.CheckedChanged
        filter = "product_name LIKE"
        conn.Close()
    End Sub

    Private Sub TextBox_Harga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Harga.KeyPress
        If Strings.InStr("0123456789," & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
            MsgBox("Masukkan Angka", MsgBoxStyle.Exclamation, "Peringatan")
        End If
    End Sub

    Private Sub TextBox_Harga_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Harga.TextChanged
        If Not IsNumeric(TextBox_Harga.Text) Then
            Exit Sub
        End If
        Dim f As Double
        f = TextBox_Harga.Text
        TextBox_Harga.Text = Format(f, "#,###")
        TextBox_Harga.SelectionStart = Len(TextBox_Harga.Text)
    End Sub

    Private Sub DGV_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DGV.Rows(e.RowIndex)
                TextBox_Kode.Text = row.Cells("KodeProduk").Value
                TextBox_nProduk.Text = row.Cells("NamaProduk").Value
                TextBox_Harga.Text = row.Cells("Harga").Value
                NumericUpDown_jumlahProduk.Text = row.Cells("Stok").Value
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("error", MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class