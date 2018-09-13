Imports System.Data.Odbc

Public Class HomeAdmin

    Private Sub isiGridSD()
        Try
            Call koneksi()

            da = New OdbcDataAdapter("Select sales_order.code_order as CodeOrder, " &
                                     "sales_order.order_date as OrderDate, " &
                                     "sales_order.purchase_date as PurchaseDate, " &
                                     "sales_order.shipping_date as ShippingDate, " &
                                     "sales_order.jumlah_order as JumlahOrder, " &
                                     "sales_order.produk_name as NameProduct, " &
                                     "sales_order.store_name as StoreName, " &
                                     "sales_order.store_address as StoreAddress, " &
                                     "sales_order.product_price as ProductPrice, " &
                                     "sales_order.price_total as PriceTotal, " &
                                     "sales_order.status as Status from sales_order ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "sales_order")
            DGV_SD.DataSource = (ds.Tables("sales_order"))
            DGV_SD.ReadOnly = True
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub isiGridPO_RM()
        Try
            Call Koneksi()
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
            DGV_PO_bahanBaku.DataSource = (ds.Tables("po_bahan_baku"))
            DGV_PO_bahanBaku.ReadOnly = True
            Conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub isiGrid_Produk()
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select product.product_id as IdProduk, " &
                                     "product.product_code as KodeProduk," &
                                     "product.product_name as NamaProduk," &
                                     "product.price as Harga, " &
                                     "product.stock as Stok from product ", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "product")
            DGV_produk.DataSource = (ds.Tables("product"))
            DGV_produk.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub isiGrid_RM()
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
            DGV_bahanbaku.DataSource = (ds.Tables("bahanbaku"))
            DGV_bahanbaku.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub HomeAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGridSD()
        isiGridPO_RM() '
        isiGrid_Produk()
        isiGrid_RM()
    End Sub

    'Sales Distribution
    Dim filter_SD As String
    Private Sub RadioButton_namaProduk_SD_CheckedChanged(sender As Object, e As EventArgs)
        filter_SD = "produk_name LIKE"
    End Sub

    Private Sub RadioButton_namaToko_SD_CheckedChanged(sender As Object, e As EventArgs)
        filter_SD = "store_name LIKE"
    End Sub

    Private Sub TextBoxCari_TextChanged(sender As Object, e As EventArgs)
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select sales_order.code_order as CodeOrder, " &
                                     "sales_order.order_date as OrderDate, " &
                                     "sales_order.purchase_date as PurchaseDate, " &
                                     "sales_order.shipping_date as ShippingDate, " &
                                     "sales_order.jumlah_order as JumlahOrder, " &
                                     "sales_order.produk_name as NameProduct, " &
                                     "sales_order.store_name as StoreName, " &
                                     "sales_order.store_address as StoreAddress, " &
                                     "sales_order.product_price as ProductPrice, " &
                                     "sales_order.price_total as PriceTotal, " &
                                     "sales_order.status as Status from sales_order where " & filter_SD & "'" & TextBoxCari_SD.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "sales_order")
            DGV_SD.DataSource = ds.Tables("sales_order")
            DGV_SD.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'PO Raw Material
    Dim filter_PO_RM As String
    Private Sub RadioButton_kodePembelian_PO_RM_CheckedChanged(sender As Object, e As EventArgs)
        filter_PO_RM = "po_bahanbaku_code LIKE"
    End Sub

    Private Sub RadioButton_namaVendor_PO_RM_CheckedChanged(sender As Object, e As EventArgs)
        filter_PO_RM = "vendor_name LIKE"
    End Sub

    Private Sub TextBox_cariPOBahanBaku_TextChanged(sender As Object, e As EventArgs)
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select bahanbaku.raw_material_id as IdRawMaterial, " &
                                     "bahanbaku.code_material as KodeMaterial," &
                                     "bahanbaku.name_material as NamaMaterial," &
                                     "bahanbaku.quantity as StokMaterial," &
                                     "bahanbaku.price as HargaMaterial," &
                                     "bahanbaku.vendor_name as NamaVendor from bahanbaku where " & filter_PO_RM & "'" & TextBox_cariPOBahanBaku.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "bahanbaku")
            DGV_PO_bahanBaku.DataSource = ds.Tables("bahanbaku")
            DGV_PO_bahanBaku.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'Produk
    Dim filter_P As String
    Private Sub RadioButton_kodeProduk_P_CheckedChanged(sender As Object, e As EventArgs)
        filter_P = "product_code LIKE"
    End Sub

    Private Sub RadioButton_namaProduk_P_CheckedChanged(sender As Object, e As EventArgs)
        filter_P = "product_name LIKE"
    End Sub

    Private Sub TextBox_cariProduk_TextChanged(sender As Object, e As EventArgs)
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select product.product_id as IdProduk, " &
                                     "product.product_code as KodeProduk," &
                                     "product.product_name as NamaProduk," &
                                     "product.price as Harga, " &
                                     "product.stock as Stok from product where " & filter_P & "'" & TextBox_cariProduk.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "product")
            DGV_produk.DataSource = ds.Tables("product")
            DGV_produk.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Raw Material
    Dim filter_RM As String
    Private Sub RadioButton_KRMaterial_CheckedChanged(sender As Object, e As EventArgs)
        filter_RM = "code_material LIKE"
    End Sub

    Private Sub RadioButton_NRMaterial_CheckedChanged(sender As Object, e As EventArgs)
        filter_RM = "name_material LIKE"
    End Sub

    Private Sub TextBox_cariRM_TextChanged(sender As Object, e As EventArgs)
        Try
            Call koneksi()
            da = New OdbcDataAdapter("Select bahanbaku.raw_material_id as IdRawMaterial, " &
                                     "bahanbaku.code_material as KodeMaterial," &
                                     "bahanbaku.name_material as NamaMaterial," &
                                     "bahanbaku.quantity as StokMaterial," &
                                     "bahanbaku.price as HargaMaterial," &
                                     "bahanbaku.vendor_name as NamaVendor from bahanbaku where " & filter_RM & "'" & TextBox_cariRM.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "bahanbaku")
            DGV_bahanbaku.DataSource = ds.Tables("bahanbaku")
            DGV_bahanbaku.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Login.Show()
    End Sub

  
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        isiGridSD()
        isiGridPO_RM()
        isiGrid_Produk()
        isiGrid_RM()
    End Sub
End Class