Imports System.Data.Odbc
Public Class HomeMM
    Dim filterProduct As String
    Dim filterPOBahanbaku As String
    Dim filterRMaterial As String

    Private Sub isiGridPoduk()
        Try

            Call koneksi()

            da = New OdbcDataAdapter("Select product.product_code as CodeProduk, product.product_name as NamaProduk, product.price as Harga, product.stock as Stok from product ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "product")
            DGV_produk.DataSource = (ds.Tables("product"))
            DGV_produk.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MsgBox("Error!!", MsgBoxStyle.Information, "Peringatan")
        End Try
    End Sub

    Private Sub isiGrid_PO_bahanBaku()
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select po_bahan_baku.po_bahanbaku_code as KodePOBahanBaku," &
                                     "po_bahan_baku.vendor_name as NamaVendor," &
                                     "po_bahan_baku.jumlah_barang as JumlahBarang," &
                                     "po_bahan_baku.po_bahanbaku_cost as BiayaPembelian from po_bahan_baku ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "po_bahan_baku")
            DGV_PO_bahanBaku.DataSource = (ds.Tables("po_bahan_baku"))
            DGV_PO_bahanBaku.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MsgBox("Error!!", MsgBoxStyle.Information, "Peringatan")
        End Try
    End Sub

    Private Sub isiGrid_bahanBaku()
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select bahanbaku.code_material as KodeMaterial," &
                                     "bahanbaku.name_material as NamaMaterial," &
                                     "bahanbaku.quantity as StokMaterial from bahanbaku", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "bahanbaku")
            DGV_bahanbaku.DataSource = (ds.Tables("bahanbaku"))
            DGV_bahanbaku.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MsgBox("Error!!", MsgBoxStyle.Information, "Peringatan")
        End Try
    End Sub



    Private Sub HomeMM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call isiGrid_bahanBaku()
        Call isiGridPoduk()
        Call isiGrid_PO_bahanBaku()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ViewDetailMM_Produk.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ViewDetailMM_PORawMaterial.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ViewDetailMM_RawMaterial.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Vendor.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        daftarPesanan.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        Login.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        isiGridPoduk()
        isiGrid_PO_bahanBaku()
        isiGrid_bahanBaku()
    End Sub

    Private Sub RadioButton_kodeProduk_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton_kodeProduk.CheckedChanged
        filterProduct = "product_code LIKE"
    End Sub

    Private Sub RadioButton_namaProduk_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton_namaProduk.CheckedChanged
        filterProduct = "product_name LIKE"
    End Sub

    Private Sub TextBox_cariProduk_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox_cariProduk.TextChanged
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select product.product_code as CodeProduk, product.product_name as NamaProduk, product.price as Harga, product.stock as Stok from product WHERE " & filterProduct & "'" & TextBox_cariProduk.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "product")
            DGV_produk.DataSource = ds.Tables("product")
            DGV_produk.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MsgBox("Error!!", MsgBoxStyle.Information, "Peringatan")
        End Try
    End Sub


    Private Sub TextBox_cariPOBahanBaku_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox_cariPOBahanBaku.TextChanged
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select po_bahan_baku.po_bahanbaku_code as KodePOBahanBaku," &
                                     "po_bahan_baku.vendor_name as NamaVendor," &
                                     "po_bahan_baku.jumlah_barang as JumlahBarang," &
                                     "po_bahan_baku.po_bahanbaku_cost as BiayaPembelian from po_bahan_baku WHERE " & filterPOBahanbaku & "'" & TextBox_cariPOBahanBaku.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "po_bahan_baku")
            DGV_PO_bahanBaku.DataSource = ds.Tables("po_bahan_baku")
            DGV_PO_bahanBaku.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Peringatan")
        End Try
    End Sub

    Private Sub RadioButton_kodePembelian_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_kodePembelian.CheckedChanged
        filterPOBahanbaku = "po_bahanbaku_code LIKE"
    End Sub

    Private Sub RadioButton_namaVendor_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_namaVendor.CheckedChanged
        filterPOBahanbaku = "vendor_name LIKE"
    End Sub

    Private Sub RadioButton_KRMAterial_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton_KRMAterial.CheckedChanged
        filterRMaterial = "code_material LIKE"
    End Sub

    Private Sub RadioButton_NRMaterial_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton_NRMaterial.CheckedChanged
        filterRMaterial = "name_material LIKE"
    End Sub

    Private Sub TextBox_cariRM_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox_cariRM.TextChanged
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select bahanbaku.code_material as KodeMaterial," &
                                     "bahanbaku.name_material as NamaMaterial," &
                                     "bahanbaku.quantity as StokMaterial from bahanbaku WHERE " & filterRMaterial & "'" & TextBox_cariRM.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "bahanbaku")
            DGV_bahanbaku.DataSource = ds.Tables("bahanbaku")
            DGV_bahanbaku.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Peringatan")
        End Try
    End Sub
End Class