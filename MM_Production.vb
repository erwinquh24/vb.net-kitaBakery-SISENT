Imports System.Data.Odbc
Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class MM_Production
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
                                     "p_bahanbaku.note as Note, " &
                                     "p_bahanbaku.jumlah_bahanbaku as JumlahBahanBaku from p_bahanbaku", conn)
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
        DateTimePicker_order.Enabled = True
        ComboBox_status.Enabled = True
        Button_batal.Enabled = True
        TextBox_jumlahProduk.Enabled = True
        TextBox_catatan.Enabled = True

    End Sub

    Private Sub desable()
        TextBox_kodeOrder.Enabled = False
        DateTimePicker_order.Enabled = False
        DateTimePicker_selesai.Enabled = False
        ComboBox_status.Enabled = False
        TextBox_jumlahProduk.Enabled = False
        Button_batal.Enabled = False
        TextBox_namaProduk.Enabled = False
        TextBox_catatan.Enabled = False
    End Sub

    Private Sub clear()
        TextBox_kodeOrder.Text = ""
        ComboBox_status.Text = ""
        TextBox_jumlahProduk.Text = ""
        TextBox_namaProduk.Text = ""
        TextBox_catatan.Text = ""
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
            TextBox_namaProduk.Enabled = False
            TextBox_jumlahProduk.Enabled = False
            TextBox_kodeOrder.Focus()
        Else
            Try
                Call koneksi()
                edi_data = "UPDATE p_bahanbaku SET  tanggal_pemesanan= '" & DateTimePicker_order.Text & "'," &
                    "tanggal_selesai = '" & DateTimePicker_selesai.Text & "'," &
                    "bahanbaku_name = '" & TextBox_namaProduk.Text & "'," &
                    "jumlah_bahanbaku = '" & TextBox_jumlahProduk.Text & "'," &
                    "status = '" & ComboBox_status.Text & "' where p_bahanbaku_code='" & TextBox_kodeOrder.Text & "'"
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
            Button_proses.Text = "Proses"
            GroupBox3.Text = "<<PO Product>>"
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


    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DGV.Rows(e.RowIndex)
            TextBox_kodeOrder.Text = row.Cells("CodePBahanBaku").Value
            DateTimePicker_order.Text = row.Cells("TanggalPemesanan").Value
            DateTimePicker_selesai.Text = row.Cells("TanggalSelesai").Value
            TextBox_namaProduk.Text = row.Cells("NamaBahanBaku").Value
            TextBox_jumlahProduk.Text = row.Cells("JumlahBahanBaku").Value
            ComboBox_status.Text = row.Cells("Status").Value
            TextBox_catatan.Text = row.Cells("Note").Value
        End If

        If TextBox_namaProduk.Text = "Selesai" Or TextBox_namaProduk.Text = "Pending" Then
            Button_hapus.Enabled = False
            Button_batal.Enabled = True
            Button_batal.Text = "Clear"
        Else
            Button_hapus.Enabled = True
            Button_batal.Enabled = False
            Button_batal.Text = "Batal"
        End If
    End Sub

    Private Sub Production_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGrid()

    End Sub


    Private Sub Button_Kembali_Click(sender As Object, e As EventArgs) Handles Button_Kembali.Click
        Me.Close()
        HomeMM.Show()
    End Sub
End Class