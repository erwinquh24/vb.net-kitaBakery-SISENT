Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Public Class ViewDetailMM_RawMaterial

    Dim filter As String
    

    Private Sub isiGrid()
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select bahanbaku.raw_material_id as IdRawMaterial, " &
                                     "bahanbaku.code_material as KodeMaterial," &
                                     "bahanbaku.name_material as NamaMaterial," &
                                     "bahanbaku.quantity as StokMaterial," &
                                     "bahanbaku.price as HargaMaterial," &
                                     "bahanbaku.vendor_name as NamaVendor from bahanbaku ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "bahanbaku")
            DGV.DataSource = (ds.Tables("bahanbaku"))
            DGV.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub enable()
        'TextBox_Kode.Enabled = True
        TextBox_nMaterial.Enabled = True
        NumericUpDown_jumlahMaterial.Enabled = True
        TextBox_HMaterial.Enabled = True
        ComboBox_NVendor.Enabled = True
        Button_batal.Enabled = True
    End Sub

    Private Sub desable()
        TextBox_Kode.Enabled = False
        TextBox_nMaterial.Enabled = False
        NumericUpDown_jumlahMaterial.Enabled = False
        TextBox_HMaterial.Enabled = False
        ComboBox_NVendor.Enabled = False
        Button_batal.Enabled = False
    End Sub

    Private Sub clear()
        TextBox_Kode.Text = ""
        TextBox_nMaterial.Text = ""
        NumericUpDown_jumlahMaterial.Text = "0"
        TextBox_HMaterial.Text = ""
        ComboBox_NVendor.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        Try
            Call koneksi()
            da = New OdbcDataAdapter("select * from bahanbaku where " & filter & "'" & TextBox_cari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "bahanbaku")
            DGV.DataSource = ds.Tables("bahanbaku")
            DGV.ReadOnly = True
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub load_combo()
        Try
            myKoneksi()
            Dim query As String
            query = "select vendor_name from sisent.vendor "

            myCommand = New MySqlCommand(query, kon)
            myDataReader = myCommand.ExecuteReader
            While myDataReader.Read
                ComboBox_NVendor.Items.Add(myDataReader("vendor_name"))
            End While
            kon.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal : " + ex.Message)
        End Try

    End Sub

    Private Sub ViewDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isiGrid()
        load_combo()
    End Sub

    Private Sub Button_Kembali_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub RadioButton_kodeProduk_CheckedChanged(sender As Object, e As EventArgs)
        filter = "code_material LIKE"
        conn.Close()
    End Sub

    Private Sub RadioButton_namaProduk_CheckedChanged(sender As Object, e As EventArgs)
        filter = "name_material LIKE"
        conn.Close()
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
            TextBox_Kode.Focus()
        Else
            Try
                If TextBox_Kode.Text = "" Or
                    TextBox_nMaterial.Text = "" Or
                    NumericUpDown_jumlahMaterial.Text = "" Then
                    MsgBox("Entry tidak boleh kosong", MsgBoxStyle.Exclamation, "Peringatan")
                    TextBox_Kode.Focus()
                    Exit Sub
                End If

                Call koneksi()
                oc = New OdbcCommand("Select code_material from bahanbaku where name_material = '" & TextBox_nMaterial.Text & "'", conn)
                dr = oc.ExecuteReader
                dr.Read()


                If dr.HasRows Then
                    MsgBox("Maaf, Bahan Baku tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
                    TextBox_Kode.Focus()
                    Exit Sub

                Else
                    Call koneksi()
                    simpan = "INSERT INTO bahanbaku (`raw_material_id`,`code_material`,`name_material`,`quantity`,`price`,`vendor_name`)" &
                        "VALUES ('" & TextBox_Kode.Text & "','" & TextBox_Kode.Text & "','" & TextBox_nMaterial.Text & "'," &
                        "'" & NumericUpDown_jumlahMaterial.Text & "'," &
                        "'" & TextBox_HMaterial.Text & "', '" & ComboBox_NVendor.Text & "')"

                    oc = New OdbcCommand(simpan, conn)
                    oc.ExecuteNonQuery()

                    Call isiGrid()
                    Call desable()
                    Call clear()
                    Button_tambah.Text = "Tambah"
                    Button_edit.Enabled = True
                    Button_hapus.Enabled = True
                    DGV.Enabled = True
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
            Call enable()
            TextBox_Kode.Enabled = False
            TextBox_Kode.Focus()
        Else
            Try
                Call koneksi()
                edi_data = "UPDATE bahanbaku SET name_material = '" & TextBox_nMaterial.Text & "'," &
                    "quantity = '" & NumericUpDown_jumlahMaterial.Text & "'," &
                    "price = '" & TextBox_HMaterial.Text & "'," &
                    "vendor_name = '" & ComboBox_NVendor.Text & "' WHERE code_material ='" & TextBox_Kode.Text & "'"
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
                    hapus = "DELETE FROM bahanbaku where code_material='" & TextBox_Kode.Text & "'"

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
        Button_tambah.Text = "Tambah"
        Button_edit.Text = "Edit"
        GroupBox3.Text = "<<Raw Material>>"
        Button_tambah.Enabled = True
        Button_edit.Enabled = True
        Button_hapus.Enabled = True
        DGV.Enabled = True
        Call isiGrid()
        Call desable()
        Call clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        HomeMM.Show()
    End Sub

    Private Sub TextBox_cari_TextChanged(sender As Object, e As EventArgs) Handles TextBox_cari.TextChanged
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select bahanbaku.raw_material_id as IdRawMaterial, " &
                                     "bahanbaku.code_material as KodeMaterial," &
                                     "bahanbaku.name_material as NamaMaterial," &
                                     "bahanbaku.quantity as StokMaterial," &
                                     "bahanbaku.price as HargaMaterial," &
                                     "bahanbaku.vendor_name as NamaVendor from bahanbaku where " & filter & "'" & TextBox_cari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "bahanbaku")
            DGV.DataSource = ds.Tables("bahanbaku")
            DGV.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub auto()
        Try
            kon = New MySqlConnection

            kon.ConnectionString = "server=localhost; uid=root; password=; database=sisent"
            kon.Open()
            myCommand = New MySqlCommand("Select code_material from bahanbaku where code_material in(select max(code_material) from bahanbaku)", kon)
            myDataReader = myCommand.ExecuteReader
            myDataReader.Read()
            If myDataReader.HasRows = 0 Then
                TextBox_Kode.Text = "RM" + "0001"
                myDataReader.Close()
            End If
            If Not myDataReader.HasRows Then
                TextBox_Kode.Text = "RM" + "0001"
                myDataReader.Close()
            Else
                TextBox_Kode.Text = Val(Microsoft.VisualBasic.Right(myDataReader.Item("code_material").ToString, 3)) + 1
                If Len(TextBox_Kode.Text) = 1 Then
                    TextBox_Kode.Text = "RM" + "000" & TextBox_Kode.Text & ""
                ElseIf Len(TextBox_Kode.Text) = 2 Then
                    TextBox_Kode.Text = "RM" + "00" & TextBox_Kode.Text & ""
                ElseIf Len(TextBox_Kode.Text) = 3 Then
                    TextBox_Kode.Text = "RM" + "0" & TextBox_Kode.Text & ""
                End If
            End If
            kon.Close()
        Catch ex As Exception

        End Try

    End Sub

 
    Private Sub RadioButton_KRMaterial_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_KRMaterial.CheckedChanged
        filter = "code_material LIKE"

    End Sub

    Private Sub RadioButton_NRMaterial_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_NRMaterial.CheckedChanged
        filter = "name_material LIKE"
    End Sub

    Private Sub TextBox_HMaterial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_HMaterial.KeyPress
        If Strings.InStr("0123456789," & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
            MsgBox("Masukkan Angka", MsgBoxStyle.Exclamation, "Peringatan")
        End If
    End Sub

    Private Sub TextBox_HMaterial_TextChanged(sender As Object, e As EventArgs) Handles TextBox_HMaterial.TextChanged
        If TextBox_HMaterial.Text = "" Or Not IsNumeric(TextBox_HMaterial.Text) Then
            Exit Sub
        End If
        Dim f As Double
        f = TextBox_HMaterial.Text
        TextBox_HMaterial.Text = Format(f, "#,###")
        TextBox_HMaterial.SelectionStart = Len(TextBox_HMaterial.Text)
    End Sub

    Private Sub DGV_CellClick1(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DGV.Rows(e.RowIndex)
                TextBox_Kode.Text = row.Cells("KodeMaterial").Value
                TextBox_nMaterial.Text = row.Cells("NamaMaterial").Value
                NumericUpDown_jumlahMaterial.Text = row.Cells("StokMaterial").Value
                TextBox_HMaterial.Text = row.Cells("HargaMaterial").Value
                ComboBox_NVendor.Text = row.Cells("NamaVendor").Value
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("error", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
