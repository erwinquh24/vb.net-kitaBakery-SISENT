Imports System.Data.Odbc
Imports MySql.Data.MySqlClient

Public Class Vendor

    Dim filter As String

    Private Sub isiGrid()
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select vendor.id_vendor as IdVendor, " &
                                     "vendor.code_vendor as KodeVendor," &
                                     "vendor.vendor_name as NamaVendor," &
                                     "vendor.phone_number_vendor as ContactVendor, " &
                                     "vendor.vendor_address as AlamatVendor, " &
                                     "vendor.name_rawmaterial as NamaMaterial from vendor ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "vendor")
            DGV_Vendor.DataSource = (ds.Tables("vendor"))
            DGV_Vendor.ReadOnly = True
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Vendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGrid()
    End Sub

    Private Sub enable()
        'TextBox_KodeVendor.Enabled = True
        TextBox_nVendor.Enabled = True
        TextBox_CVendor.Enabled = True
        TextBox_AVendor.Enabled = True
        TextBox_nMaterial.Enabled = True
        Button_batal.Enabled = True
    End Sub

    Private Sub desable()
        TextBox_KodeVendor.Enabled = False
        TextBox_nVendor.Enabled = False
        TextBox_CVendor.Enabled = False
        TextBox_AVendor.Enabled = False
        TextBox_nMaterial.Enabled = False
        Button_batal.Enabled = False
    End Sub

    Private Sub clear()
        'TextBox_KodeVendor.Text = ""
        TextBox_nVendor.Text = ""
        TextBox_CVendor.Text = ""
        TextBox_AVendor.Text = ""
        TextBox_nMaterial.Text = ""
    End Sub

    Private Sub Button_tambah_Click(sender As Object, e As EventArgs) Handles Button_tambah.Click
        If Button_tambah.Text = "Tambah" Then
            Button_tambah.Text = "Simpan"
            GroupBox3.Text = "Tambah"
            Call enable()
            Call clear()
            Call auto()
            Button_edit.Enabled = False
            Button_hapus.Enabled = False
            DGV_Vendor.Enabled = False
            TextBox_KodeVendor.Focus()
        Else
            Try
                If TextBox_KodeVendor.Text = "" Or
                    TextBox_nVendor.Text = "" Or
                    TextBox_CVendor.Text = "" Or
                    TextBox_AVendor.Text = "" Or
                    TextBox_nMaterial.Text = "" Then
                    MsgBox("Entry tidak boleh kosong", MsgBoxStyle.Exclamation, "Peringatan")
                    TextBox_KodeVendor.Focus()
                    Exit Sub
                End If

                Call koneksi()
                oc = New OdbcCommand("Select code_vendor from vendor where code_vendor = '" & TextBox_KodeVendor.Text & "'", conn)
                dr = oc.ExecuteReader
                dr.Read()

                If dr.HasRows Then
                    MsgBox("Maaf, Vendor tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
                    TextBox_KodeVendor.Focus()
                    Exit Sub

                Else
                    Call koneksi()
                    simpan = "INSERT INTO vendor (`id_vendor`,`code_vendor`,`vendor_name`,`phone_number_vendor`,`vendor_address`,`name_rawmaterial`)" &
                        "VALUES ('" & TextBox_KodeVendor.Text & "','" & TextBox_KodeVendor.Text & "','" & TextBox_nVendor.Text & "'," &
                        "'" & TextBox_CVendor.Text & "'," &
                        "'" & TextBox_AVendor.Text & "'," &
                        "'" & TextBox_nMaterial.Text & "')"

                    oc = New OdbcCommand(simpan, conn)
                    oc.ExecuteNonQuery()

                    Call isiGrid()
                    Call desable()
                    Call clear()
                    Button_tambah.Text = "Tambah"
                    Button_edit.Enabled = True
                    Button_hapus.Enabled = True
                    DGV_Vendor.Enabled = True
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

    Private Sub Button_batal_Click(sender As Object, e As EventArgs) Handles Button_batal.Click
        Button_tambah.Text = "Tambah"
        TextBox_KodeVendor.Text = ""
        Button_edit.Text = "Edit"
        GroupBox3.Text = "<<Vendor>>"
        Button_tambah.Enabled = True
        Button_edit.Enabled = True
        Button_hapus.Enabled = True
        DGV_Vendor.Enabled = True
        Call isiGrid()
        Call desable()
        Call clear()

    End Sub

    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        If TextBox_KodeVendor.Text = "" Then
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
            TextBox_KodeVendor.Enabled = False
            TextBox_KodeVendor.Focus()
        Else
            Try
                Call koneksi()
                edi_data = "UPDATE vendor SET vendor_name = '" & TextBox_nVendor.Text & "'," &
                    "phone_number_vendor = '" & TextBox_CVendor.Text & "'," &
                    "vendor_address = '" & TextBox_AVendor.Text & "'," &
                    "name_rawmaterial = '" & TextBox_nMaterial.Text & "' WHERE code_vendor='" & TextBox_KodeVendor.Text & "'"
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
        If TextBox_KodeVendor.Text = "" Then
            MsgBox("Tidak ada data yang akan di hapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        Else
            Dim pesan
            pesan = MsgBox("Apakah data ini akan dihapus", MsgBoxStyle.Question + vbYesNo, "Peringatan")
            If pesan = vbYes Then
                Try
                    Call koneksi()
                    hapus = "DELETE FROM vendor where code_vendor='" & TextBox_KodeVendor.Text & "'"

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HomeMM.Show()
        Me.Close()
    End Sub

    Private Sub RadioButton_KVendor_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_KVendor.CheckedChanged
        filter = "code_vendor LIKE"

    End Sub

    Private Sub RadioButton_NVendor_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_NVendor.CheckedChanged
        filter = "vendor_name LIKE"
    End Sub

    Private Sub TextBox_cari_TextChanged(sender As Object, e As EventArgs) Handles TextBox_cari.TextChanged
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select vendor.id_vendor as IdVendor, " &
                                     "vendor.code_vendor as KodeVendor," &
                                     "vendor.vendor_name as NamaVendor," &
                                     "vendor.phone_number_vendor as ContactVendor, " &
                                     "vendor.vendor_address as AlamatVendor, " &
                                     "vendor.name_rawmaterial as NamaMaterial from vendor where " & filter & "'" & TextBox_cari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "vendor")
            DGV_Vendor.DataSource = ds.Tables("vendor")
            DGV_Vendor.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MsgBox("Error!!", MsgBoxStyle.Information, "Peringatan")
        End Try
    End Sub

    Private Sub DGV_Vendor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Vendor.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DGV_Vendor.Rows(e.RowIndex)
                TextBox_KodeVendor.Text = row.Cells("KodeVendor").Value
                TextBox_nVendor.Text = row.Cells("NamaVendor").Value
                TextBox_CVendor.Text = row.Cells("ContactVendor").Value
                TextBox_AVendor.Text = row.Cells("AlamatVendor").Value
                TextBox_nMaterial.Text = row.Cells("NamaMaterial").Value

            End If


            conn.Close()
        Catch ex As Exception
            MsgBox("error", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Sub auto()
        Try
            kon = New MySqlConnection

            kon.ConnectionString = "server=localhost; uid=root; password=; database=sisent"
            kon.Open()
            myCommand = New MySqlCommand("Select code_vendor from vendor where code_vendor in(select max(code_vendor) from vendor)", kon)
            myDataReader = myCommand.ExecuteReader
            myDataReader.Read()
            If myDataReader.HasRows = 0 Then
                TextBox_KodeVendor.Text = "VE" + "0001"
                myDataReader.Close()
            End If
            If Not myDataReader.HasRows Then
                TextBox_KodeVendor.Text = "VE" + "0001"
                myDataReader.Close()
            Else
                TextBox_KodeVendor.Text = Val(Microsoft.VisualBasic.Right(myDataReader.Item("code_vendor").ToString, 3)) + 1
                If Len(TextBox_KodeVendor.Text) = 1 Then
                    TextBox_KodeVendor.Text = "VE" + "000" & TextBox_KodeVendor.Text & ""
                ElseIf Len(TextBox_KodeVendor.Text) = 2 Then
                    TextBox_KodeVendor.Text = "VE" + "00" & TextBox_KodeVendor.Text & ""
                ElseIf Len(TextBox_KodeVendor.Text) = 3 Then
                    TextBox_KodeVendor.Text = "VE" + "0" & TextBox_KodeVendor.Text & ""
                End If
            End If
            kon.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox_CVendor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_CVendor.KeyPress
        If Strings.InStr("0123456789," & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
            MsgBox("Masukkan Angka", MsgBoxStyle.Exclamation, "Peringatan")
        End If
    End Sub


    
End Class