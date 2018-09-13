<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeAdmin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBoxCari_SD = New System.Windows.Forms.TextBox()
        Me.RadioButton_namaToko_SD = New System.Windows.Forms.RadioButton()
        Me.RadioButton_namaProduk_SD = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_SD = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RadioButton_namaVendor_PO_RM = New System.Windows.Forms.RadioButton()
        Me.TextBox_cariPOBahanBaku = New System.Windows.Forms.TextBox()
        Me.RadioButton_kodePembelian_PO_RM = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DGV_PO_bahanBaku = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.RadioButton_namaProduk_P = New System.Windows.Forms.RadioButton()
        Me.RadioButton_kodeProduk_P = New System.Windows.Forms.RadioButton()
        Me.TextBox_cariProduk = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGV_produk = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.RadioButton_NRMaterial = New System.Windows.Forms.RadioButton()
        Me.RadioButton_KRMaterial = New System.Windows.Forms.RadioButton()
        Me.TextBox_cariRM = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DGV_bahanbaku = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_SD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DGV_PO_bahanBaku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_produk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DGV_bahanbaku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.Location = New System.Drawing.Point(-3, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(720, 462)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.TextBoxCari_SD)
        Me.TabPage1.Controls.Add(Me.RadioButton_namaToko_SD)
        Me.TabPage1.Controls.Add(Me.RadioButton_namaProduk_SD)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(712, 436)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sales Distribution"
        '
        'TextBoxCari_SD
        '
        Me.TextBoxCari_SD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBoxCari_SD.Location = New System.Drawing.Point(270, 19)
        Me.TextBoxCari_SD.Name = "TextBoxCari_SD"
        Me.TextBoxCari_SD.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCari_SD.TabIndex = 6
        '
        'RadioButton_namaToko_SD
        '
        Me.RadioButton_namaToko_SD.AutoSize = True
        Me.RadioButton_namaToko_SD.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_namaToko_SD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_namaToko_SD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_namaToko_SD.Location = New System.Drawing.Point(130, 20)
        Me.RadioButton_namaToko_SD.Name = "RadioButton_namaToko_SD"
        Me.RadioButton_namaToko_SD.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton_namaToko_SD.TabIndex = 8
        Me.RadioButton_namaToko_SD.TabStop = True
        Me.RadioButton_namaToko_SD.Text = "Nama Toko"
        Me.RadioButton_namaToko_SD.UseVisualStyleBackColor = False
        '
        'RadioButton_namaProduk_SD
        '
        Me.RadioButton_namaProduk_SD.AutoSize = True
        Me.RadioButton_namaProduk_SD.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_namaProduk_SD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_namaProduk_SD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_namaProduk_SD.Location = New System.Drawing.Point(11, 20)
        Me.RadioButton_namaProduk_SD.Name = "RadioButton_namaProduk_SD"
        Me.RadioButton_namaProduk_SD.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton_namaProduk_SD.TabIndex = 7
        Me.RadioButton_namaProduk_SD.TabStop = True
        Me.RadioButton_namaProduk_SD.Text = "Nama Produk"
        Me.RadioButton_namaProduk_SD.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_SD)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(666, 365)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "<<Daftar Order>>"
        '
        'DGV_SD
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_SD.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_SD.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_SD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_SD.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_SD.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_SD.Location = New System.Drawing.Point(6, 19)
        Me.DGV_SD.Name = "DGV_SD"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_SD.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_SD.Size = New System.Drawing.Size(654, 340)
        Me.DGV_SD.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.RadioButton_namaVendor_PO_RM)
        Me.TabPage2.Controls.Add(Me.TextBox_cariPOBahanBaku)
        Me.TabPage2.Controls.Add(Me.RadioButton_kodePembelian_PO_RM)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(712, 436)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PO Raw Material"
        '
        'RadioButton_namaVendor_PO_RM
        '
        Me.RadioButton_namaVendor_PO_RM.AutoSize = True
        Me.RadioButton_namaVendor_PO_RM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_namaVendor_PO_RM.Location = New System.Drawing.Point(148, 18)
        Me.RadioButton_namaVendor_PO_RM.Name = "RadioButton_namaVendor_PO_RM"
        Me.RadioButton_namaVendor_PO_RM.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton_namaVendor_PO_RM.TabIndex = 39
        Me.RadioButton_namaVendor_PO_RM.TabStop = True
        Me.RadioButton_namaVendor_PO_RM.Text = "Nama Vendor"
        Me.RadioButton_namaVendor_PO_RM.UseVisualStyleBackColor = True
        '
        'TextBox_cariPOBahanBaku
        '
        Me.TextBox_cariPOBahanBaku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox_cariPOBahanBaku.Location = New System.Drawing.Point(280, 17)
        Me.TextBox_cariPOBahanBaku.Name = "TextBox_cariPOBahanBaku"
        Me.TextBox_cariPOBahanBaku.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_cariPOBahanBaku.TabIndex = 37
        '
        'RadioButton_kodePembelian_PO_RM
        '
        Me.RadioButton_kodePembelian_PO_RM.AutoSize = True
        Me.RadioButton_kodePembelian_PO_RM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_kodePembelian_PO_RM.Location = New System.Drawing.Point(11, 18)
        Me.RadioButton_kodePembelian_PO_RM.Name = "RadioButton_kodePembelian_PO_RM"
        Me.RadioButton_kodePembelian_PO_RM.Size = New System.Drawing.Size(102, 17)
        Me.RadioButton_kodePembelian_PO_RM.TabIndex = 38
        Me.RadioButton_kodePembelian_PO_RM.TabStop = True
        Me.RadioButton_kodePembelian_PO_RM.Text = "Kode Pembelian"
        Me.RadioButton_kodePembelian_PO_RM.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DGV_PO_bahanBaku)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 50)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(663, 371)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "<<Daftar PO Bahan Baku>>"
        '
        'DGV_PO_bahanBaku
        '
        Me.DGV_PO_bahanBaku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PO_bahanBaku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_PO_bahanBaku.Location = New System.Drawing.Point(6, 20)
        Me.DGV_PO_bahanBaku.Name = "DGV_PO_bahanBaku"
        Me.DGV_PO_bahanBaku.Size = New System.Drawing.Size(651, 352)
        Me.DGV_PO_bahanBaku.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.Controls.Add(Me.RadioButton_namaProduk_P)
        Me.TabPage3.Controls.Add(Me.RadioButton_kodeProduk_P)
        Me.TabPage3.Controls.Add(Me.TextBox_cariProduk)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(712, 436)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Produk"
        '
        'RadioButton_namaProduk_P
        '
        Me.RadioButton_namaProduk_P.AutoSize = True
        Me.RadioButton_namaProduk_P.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_namaProduk_P.Location = New System.Drawing.Point(133, 18)
        Me.RadioButton_namaProduk_P.Name = "RadioButton_namaProduk_P"
        Me.RadioButton_namaProduk_P.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton_namaProduk_P.TabIndex = 40
        Me.RadioButton_namaProduk_P.TabStop = True
        Me.RadioButton_namaProduk_P.Text = "Nama Produk"
        Me.RadioButton_namaProduk_P.UseVisualStyleBackColor = True
        '
        'RadioButton_kodeProduk_P
        '
        Me.RadioButton_kodeProduk_P.AutoSize = True
        Me.RadioButton_kodeProduk_P.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_kodeProduk_P.Location = New System.Drawing.Point(11, 18)
        Me.RadioButton_kodeProduk_P.Name = "RadioButton_kodeProduk_P"
        Me.RadioButton_kodeProduk_P.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton_kodeProduk_P.TabIndex = 39
        Me.RadioButton_kodeProduk_P.TabStop = True
        Me.RadioButton_kodeProduk_P.Text = "Kode Produk"
        Me.RadioButton_kodeProduk_P.UseVisualStyleBackColor = True
        '
        'TextBox_cariProduk
        '
        Me.TextBox_cariProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox_cariProduk.Location = New System.Drawing.Point(274, 17)
        Me.TextBox_cariProduk.Name = "TextBox_cariProduk"
        Me.TextBox_cariProduk.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_cariProduk.TabIndex = 38
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGV_produk)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 50)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(663, 371)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "<<Daftar Produk>>"
        '
        'DGV_produk
        '
        Me.DGV_produk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_produk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_produk.Location = New System.Drawing.Point(6, 19)
        Me.DGV_produk.Name = "DGV_produk"
        Me.DGV_produk.Size = New System.Drawing.Size(651, 342)
        Me.DGV_produk.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Transparent
        Me.TabPage4.Controls.Add(Me.RadioButton_NRMaterial)
        Me.TabPage4.Controls.Add(Me.RadioButton_KRMaterial)
        Me.TabPage4.Controls.Add(Me.TextBox_cariRM)
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(712, 436)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Raw Material"
        '
        'RadioButton_NRMaterial
        '
        Me.RadioButton_NRMaterial.AutoSize = True
        Me.RadioButton_NRMaterial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_NRMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_NRMaterial.Location = New System.Drawing.Point(149, 15)
        Me.RadioButton_NRMaterial.Name = "RadioButton_NRMaterial"
        Me.RadioButton_NRMaterial.Size = New System.Drawing.Size(118, 17)
        Me.RadioButton_NRMaterial.TabIndex = 54
        Me.RadioButton_NRMaterial.TabStop = True
        Me.RadioButton_NRMaterial.Text = "Nama Raw Material"
        Me.RadioButton_NRMaterial.UseVisualStyleBackColor = True
        '
        'RadioButton_KRMaterial
        '
        Me.RadioButton_KRMaterial.AutoSize = True
        Me.RadioButton_KRMaterial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_KRMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_KRMaterial.Location = New System.Drawing.Point(12, 15)
        Me.RadioButton_KRMaterial.Name = "RadioButton_KRMaterial"
        Me.RadioButton_KRMaterial.Size = New System.Drawing.Size(115, 17)
        Me.RadioButton_KRMaterial.TabIndex = 53
        Me.RadioButton_KRMaterial.TabStop = True
        Me.RadioButton_KRMaterial.Text = "Kode Raw Material"
        Me.RadioButton_KRMaterial.UseVisualStyleBackColor = True
        '
        'TextBox_cariRM
        '
        Me.TextBox_cariRM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox_cariRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_cariRM.Location = New System.Drawing.Point(305, 14)
        Me.TextBox_cariRM.Name = "TextBox_cariRM"
        Me.TextBox_cariRM.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_cariRM.TabIndex = 52
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DGV_bahanbaku)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(6, 53)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(663, 368)
        Me.GroupBox7.TabIndex = 50
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "<<Daftar Raw Material>>"
        '
        'DGV_bahanbaku
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_bahanbaku.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_bahanbaku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_bahanbaku.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_bahanbaku.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_bahanbaku.Location = New System.Drawing.Point(6, 17)
        Me.DGV_bahanbaku.Name = "DGV_bahanbaku"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_bahanbaku.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_bahanbaku.Size = New System.Drawing.Size(651, 345)
        Me.DGV_bahanbaku.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Admin"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(623, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Log Out"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(545, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hello Admin"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.sederhana.My.Resources.Resources.refresh
        Me.PictureBox1.Location = New System.Drawing.Point(650, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'HomeAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.sederhana.My.Resources.Resources.napoleon_cake
        Me.ClientSize = New System.Drawing.Size(710, 531)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "HomeAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Admin"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_SD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DGV_PO_bahanBaku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGV_produk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DGV_bahanbaku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_produk As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_SD As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_PO_bahanBaku As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_bahanbaku As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCari_SD As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton_namaToko_SD As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_namaProduk_SD As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_namaVendor_PO_RM As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_kodePembelian_PO_RM As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox_cariPOBahanBaku As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton_namaProduk_P As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_kodeProduk_P As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox_cariProduk As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton_NRMaterial As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_KRMaterial As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox_cariRM As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
