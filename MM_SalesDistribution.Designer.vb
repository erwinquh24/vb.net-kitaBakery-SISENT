<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MM_SalesDistribution
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button_Kembali = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker_TPengiriman = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_jumlahProduk = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_status = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox_catatan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_totalHarga = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_alamatToko = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_namaToko = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_kodeOrder = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_hargaProduct = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox_namaProduk = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker_pembayaran = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_order = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_cari = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Button_batal = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button_hapus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button_proses = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Kembali
        '
        Me.Button_Kembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_Kembali.Location = New System.Drawing.Point(422, 80)
        Me.Button_Kembali.Name = "Button_Kembali"
        Me.Button_Kembali.Size = New System.Drawing.Size(75, 23)
        Me.Button_Kembali.TabIndex = 48
        Me.Button_Kembali.Text = "Kembali"
        Me.Button_Kembali.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 329)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Status"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker_TPengiriman
        '
        Me.DateTimePicker_TPengiriman.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker_TPengiriman.Enabled = False
        Me.DateTimePicker_TPengiriman.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_TPengiriman.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_TPengiriman.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker_TPengiriman.Location = New System.Drawing.Point(122, 116)
        Me.DateTimePicker_TPengiriman.Name = "DateTimePicker_TPengiriman"
        Me.DateTimePicker_TPengiriman.Size = New System.Drawing.Size(165, 20)
        Me.DateTimePicker_TPengiriman.TabIndex = 71
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Tanggal Pengiriman"
        '
        'TextBox_jumlahProduk
        '
        Me.TextBox_jumlahProduk.Enabled = False
        Me.TextBox_jumlahProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_jumlahProduk.Location = New System.Drawing.Point(228, 259)
        Me.TextBox_jumlahProduk.Name = "TextBox_jumlahProduk"
        Me.TextBox_jumlahProduk.Size = New System.Drawing.Size(59, 20)
        Me.TextBox_jumlahProduk.TabIndex = 69
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.ComboBox_status)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TextBox_catatan)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_TPengiriman)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TextBox_jumlahProduk)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox_totalHarga)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBox_alamatToko)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBox_namaToko)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox_kodeOrder)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBox_hargaProduct)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.ComboBox_namaProduk)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_pembayaran)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_order)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(523, 59)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(291, 416)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "<<Order>>"
        '
        'ComboBox_status
        '
        Me.ComboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_status.Enabled = False
        Me.ComboBox_status.FormattingEnabled = True
        Me.ComboBox_status.Items.AddRange(New Object() {"", "Request", "Pending", "Dikirim"})
        Me.ComboBox_status.Location = New System.Drawing.Point(123, 326)
        Me.ComboBox_status.Name = "ComboBox_status"
        Me.ComboBox_status.Size = New System.Drawing.Size(162, 21)
        Me.ComboBox_status.TabIndex = 75
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 365)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Catatan"
        '
        'TextBox_catatan
        '
        Me.TextBox_catatan.Enabled = False
        Me.TextBox_catatan.Location = New System.Drawing.Point(123, 362)
        Me.TextBox_catatan.Multiline = True
        Me.TextBox_catatan.Name = "TextBox_catatan"
        Me.TextBox_catatan.Size = New System.Drawing.Size(162, 49)
        Me.TextBox_catatan.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Total Harga"
        '
        'TextBox_totalHarga
        '
        Me.TextBox_totalHarga.Enabled = False
        Me.TextBox_totalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_totalHarga.Location = New System.Drawing.Point(123, 292)
        Me.TextBox_totalHarga.Name = "TextBox_totalHarga"
        Me.TextBox_totalHarga.Size = New System.Drawing.Size(164, 20)
        Me.TextBox_totalHarga.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(209, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 16)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "X"
        '
        'TextBox_alamatToko
        '
        Me.TextBox_alamatToko.Enabled = False
        Me.TextBox_alamatToko.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_alamatToko.Location = New System.Drawing.Point(122, 188)
        Me.TextBox_alamatToko.Name = "TextBox_alamatToko"
        Me.TextBox_alamatToko.Size = New System.Drawing.Size(165, 20)
        Me.TextBox_alamatToko.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Alamat Toko"
        '
        'TextBox_namaToko
        '
        Me.TextBox_namaToko.Enabled = False
        Me.TextBox_namaToko.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_namaToko.Location = New System.Drawing.Point(122, 151)
        Me.TextBox_namaToko.Name = "TextBox_namaToko"
        Me.TextBox_namaToko.Size = New System.Drawing.Size(165, 20)
        Me.TextBox_namaToko.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Nama Toko"
        '
        'TextBox_kodeOrder
        '
        Me.TextBox_kodeOrder.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_kodeOrder.Enabled = False
        Me.TextBox_kodeOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_kodeOrder.Location = New System.Drawing.Point(123, 19)
        Me.TextBox_kodeOrder.Name = "TextBox_kodeOrder"
        Me.TextBox_kodeOrder.Size = New System.Drawing.Size(164, 20)
        Me.TextBox_kodeOrder.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Kode Order"
        '
        'TextBox_hargaProduct
        '
        Me.TextBox_hargaProduct.Enabled = False
        Me.TextBox_hargaProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_hargaProduct.Location = New System.Drawing.Point(123, 259)
        Me.TextBox_hargaProduct.Name = "TextBox_hargaProduct"
        Me.TextBox_hargaProduct.Size = New System.Drawing.Size(80, 20)
        Me.TextBox_hargaProduct.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Harga Produk"
        '
        'ComboBox_namaProduk
        '
        Me.ComboBox_namaProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_namaProduk.Enabled = False
        Me.ComboBox_namaProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_namaProduk.FormattingEnabled = True
        Me.ComboBox_namaProduk.Items.AddRange(New Object() {""})
        Me.ComboBox_namaProduk.Location = New System.Drawing.Point(123, 224)
        Me.ComboBox_namaProduk.Name = "ComboBox_namaProduk"
        Me.ComboBox_namaProduk.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox_namaProduk.TabIndex = 53
        '
        'DateTimePicker_pembayaran
        '
        Me.DateTimePicker_pembayaran.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker_pembayaran.Enabled = False
        Me.DateTimePicker_pembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_pembayaran.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_pembayaran.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker_pembayaran.Location = New System.Drawing.Point(123, 86)
        Me.DateTimePicker_pembayaran.Name = "DateTimePicker_pembayaran"
        Me.DateTimePicker_pembayaran.Size = New System.Drawing.Size(164, 20)
        Me.DateTimePicker_pembayaran.TabIndex = 51
        '
        'DateTimePicker_order
        '
        Me.DateTimePicker_order.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker_order.Enabled = False
        Me.DateTimePicker_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_order.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_order.Location = New System.Drawing.Point(123, 52)
        Me.DateTimePicker_order.Name = "DateTimePicker_order"
        Me.DateTimePicker_order.Size = New System.Drawing.Size(164, 20)
        Me.DateTimePicker_order.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Tanggal Pemesanan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Nama Produk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Tanggal Pembayaran"
        '
        'TextBox_cari
        '
        Me.TextBox_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_cari.Location = New System.Drawing.Point(275, 23)
        Me.TextBox_cari.Name = "TextBox_cari"
        Me.TextBox_cari.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_cari.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 388)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "<<Daftar Order>>"
        '
        'DGV
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV.Location = New System.Drawing.Point(6, 34)
        Me.DGV.Name = "DGV"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV.Size = New System.Drawing.Size(476, 345)
        Me.DGV.TabIndex = 18
        '
        'Button_batal
        '
        Me.Button_batal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_batal.Enabled = False
        Me.Button_batal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_batal.Location = New System.Drawing.Point(724, 481)
        Me.Button_batal.Name = "Button_batal"
        Me.Button_batal.Size = New System.Drawing.Size(75, 23)
        Me.Button_batal.TabIndex = 52
        Me.Button_batal.Text = "Batal"
        Me.Button_batal.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(6, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 35
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Nama Produk"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button_hapus
        '
        Me.Button_hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_hapus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_hapus.Location = New System.Drawing.Point(631, 481)
        Me.Button_hapus.Name = "Button_hapus"
        Me.Button_hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_hapus.TabIndex = 51
        Me.Button_hapus.Text = "Hapus"
        Me.Button_hapus.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.TextBox_cari)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 47)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "<<Pencarian>>"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(105, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton2.TabIndex = 36
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Nama Toko"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button_proses
        '
        Me.Button_proses.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_proses.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_proses.Location = New System.Drawing.Point(532, 481)
        Me.Button_proses.Name = "Button_proses"
        Me.Button_proses.Size = New System.Drawing.Size(75, 23)
        Me.Button_proses.TabIndex = 50
        Me.Button_proses.Text = "Proses"
        Me.Button_proses.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(350, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 26)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Daftar Pesanan"
        '
        'MM_SalesDistribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(820, 510)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button_Kembali)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button_batal)
        Me.Controls.Add(Me.Button_hapus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_proses)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "MM_SalesDistribution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MM_SalesDistribution"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Kembali As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_TPengiriman As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox_jumlahProduk As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_totalHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox_alamatToko As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_namaToko As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_kodeOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox_hargaProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_namaProduk As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker_pembayaran As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_order As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_cari As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Button_batal As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button_hapus As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button_proses As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox_catatan As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_status As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
