<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewDetailMM_PORawMaterial
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
        Me.DGV_detail = New System.Windows.Forms.DataGridView()
        Me.TextBoxCari = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_namaProduk = New System.Windows.Forms.RadioButton()
        Me.RadioButton_kodeProduk = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_Kembali = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker_pembelian = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker_pengiriman = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox_qty = New System.Windows.Forms.TextBox()
        Me.TextBox_THarga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox_namaMaterial = New System.Windows.Forms.ComboBox()
        Me.TextBox_kodePembelian = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_hargaMaterial = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_namaVendor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_batal = New System.Windows.Forms.Button()
        Me.Button_hapus = New System.Windows.Forms.Button()
        Me.Button_edit = New System.Windows.Forms.Button()
        Me.Button_tambah = New System.Windows.Forms.Button()
        Me.Button_pdf = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DGV_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_detail
        '
        Me.DGV_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_detail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_detail.Location = New System.Drawing.Point(6, 19)
        Me.DGV_detail.Name = "DGV_detail"
        Me.DGV_detail.Size = New System.Drawing.Size(441, 289)
        Me.DGV_detail.TabIndex = 5
        '
        'TextBoxCari
        '
        Me.TextBoxCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCari.Location = New System.Drawing.Point(264, 17)
        Me.TextBoxCari.Name = "TextBoxCari"
        Me.TextBoxCari.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCari.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton_namaProduk)
        Me.GroupBox1.Controls.Add(Me.RadioButton_kodeProduk)
        Me.GroupBox1.Controls.Add(Me.TextBoxCari)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 44)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "<<Cari>>"
        '
        'RadioButton_namaProduk
        '
        Me.RadioButton_namaProduk.AutoSize = True
        Me.RadioButton_namaProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_namaProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_namaProduk.Location = New System.Drawing.Point(133, 18)
        Me.RadioButton_namaProduk.Name = "RadioButton_namaProduk"
        Me.RadioButton_namaProduk.Size = New System.Drawing.Size(93, 17)
        Me.RadioButton_namaProduk.TabIndex = 5
        Me.RadioButton_namaProduk.TabStop = True
        Me.RadioButton_namaProduk.Text = "Nama Material"
        Me.RadioButton_namaProduk.UseVisualStyleBackColor = True
        '
        'RadioButton_kodeProduk
        '
        Me.RadioButton_kodeProduk.AutoSize = True
        Me.RadioButton_kodeProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_kodeProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_kodeProduk.Location = New System.Drawing.Point(9, 18)
        Me.RadioButton_kodeProduk.Name = "RadioButton_kodeProduk"
        Me.RadioButton_kodeProduk.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton_kodeProduk.TabIndex = 4
        Me.RadioButton_kodeProduk.TabStop = True
        Me.RadioButton_kodeProduk.Text = "Kode Material"
        Me.RadioButton_kodeProduk.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DGV_detail)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(453, 314)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "<<Daftar Bahan Baku>>"
        '
        'Button_Kembali
        '
        Me.Button_Kembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_Kembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Kembali.Location = New System.Drawing.Point(385, 69)
        Me.Button_Kembali.Name = "Button_Kembali"
        Me.Button_Kembali.Size = New System.Drawing.Size(75, 23)
        Me.Button_Kembali.TabIndex = 9
        Me.Button_Kembali.Text = "Kembali"
        Me.Button_Kembali.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_pembelian)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_pengiriman)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TextBox_qty)
        Me.GroupBox3.Controls.Add(Me.TextBox_THarga)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.ComboBox_namaMaterial)
        Me.GroupBox3.Controls.Add(Me.TextBox_kodePembelian)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TextBox_hargaMaterial)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox_namaVendor)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(468, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(298, 254)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "<<Raw Material>>"
        '
        'DateTimePicker_pembelian
        '
        Me.DateTimePicker_pembelian.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker_pembelian.Enabled = False
        Me.DateTimePicker_pembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_pembelian.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_pembelian.Location = New System.Drawing.Point(124, 54)
        Me.DateTimePicker_pembelian.Name = "DateTimePicker_pembelian"
        Me.DateTimePicker_pembelian.Size = New System.Drawing.Size(164, 20)
        Me.DateTimePicker_pembelian.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Tanggal Pembelian"
        '
        'DateTimePicker_pengiriman
        '
        Me.DateTimePicker_pengiriman.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker_pengiriman.Enabled = False
        Me.DateTimePicker_pengiriman.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_pengiriman.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_pengiriman.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker_pengiriman.Location = New System.Drawing.Point(124, 88)
        Me.DateTimePicker_pengiriman.Name = "DateTimePicker_pengiriman"
        Me.DateTimePicker_pengiriman.Size = New System.Drawing.Size(164, 20)
        Me.DateTimePicker_pengiriman.TabIndex = 69
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 13)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Tanggal Pengiriman"
        '
        'TextBox_qty
        '
        Me.TextBox_qty.Enabled = False
        Me.TextBox_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_qty.Location = New System.Drawing.Point(216, 192)
        Me.TextBox_qty.Name = "TextBox_qty"
        Me.TextBox_qty.Size = New System.Drawing.Size(72, 20)
        Me.TextBox_qty.TabIndex = 65
        '
        'TextBox_THarga
        '
        Me.TextBox_THarga.Enabled = False
        Me.TextBox_THarga.Location = New System.Drawing.Point(124, 225)
        Me.TextBox_THarga.Name = "TextBox_THarga"
        Me.TextBox_THarga.Size = New System.Drawing.Size(164, 20)
        Me.TextBox_THarga.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "X"
        '
        'ComboBox_namaMaterial
        '
        Me.ComboBox_namaMaterial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox_namaMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_namaMaterial.Enabled = False
        Me.ComboBox_namaMaterial.FormattingEnabled = True
        Me.ComboBox_namaMaterial.Items.AddRange(New Object() {""})
        Me.ComboBox_namaMaterial.Location = New System.Drawing.Point(124, 119)
        Me.ComboBox_namaMaterial.Name = "ComboBox_namaMaterial"
        Me.ComboBox_namaMaterial.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox_namaMaterial.TabIndex = 62
        '
        'TextBox_kodePembelian
        '
        Me.TextBox_kodePembelian.Enabled = False
        Me.TextBox_kodePembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_kodePembelian.Location = New System.Drawing.Point(124, 19)
        Me.TextBox_kodePembelian.Name = "TextBox_kodePembelian"
        Me.TextBox_kodePembelian.Size = New System.Drawing.Size(164, 20)
        Me.TextBox_kodePembelian.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Kode Pembelian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Nama Material"
        '
        'TextBox_hargaMaterial
        '
        Me.TextBox_hargaMaterial.Enabled = False
        Me.TextBox_hargaMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_hargaMaterial.Location = New System.Drawing.Point(124, 192)
        Me.TextBox_hargaMaterial.Name = "TextBox_hargaMaterial"
        Me.TextBox_hargaMaterial.Size = New System.Drawing.Size(72, 20)
        Me.TextBox_hargaMaterial.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Total Harga"
        '
        'TextBox_namaVendor
        '
        Me.TextBox_namaVendor.Enabled = False
        Me.TextBox_namaVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_namaVendor.Location = New System.Drawing.Point(124, 155)
        Me.TextBox_namaVendor.Name = "TextBox_namaVendor"
        Me.TextBox_namaVendor.Size = New System.Drawing.Size(164, 20)
        Me.TextBox_namaVendor.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Harga Material"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Nama Vendor"
        '
        'Button_batal
        '
        Me.Button_batal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_batal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_batal.Enabled = False
        Me.Button_batal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_batal.Location = New System.Drawing.Point(592, 393)
        Me.Button_batal.Name = "Button_batal"
        Me.Button_batal.Size = New System.Drawing.Size(75, 23)
        Me.Button_batal.TabIndex = 33
        Me.Button_batal.Text = "Batal"
        Me.Button_batal.UseVisualStyleBackColor = False
        '
        'Button_hapus
        '
        Me.Button_hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_hapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_hapus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_hapus.Location = New System.Drawing.Point(490, 393)
        Me.Button_hapus.Name = "Button_hapus"
        Me.Button_hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_hapus.TabIndex = 32
        Me.Button_hapus.Text = "Hapus"
        Me.Button_hapus.UseVisualStyleBackColor = False
        '
        'Button_edit
        '
        Me.Button_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_edit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_edit.Location = New System.Drawing.Point(592, 364)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_edit.TabIndex = 31
        Me.Button_edit.Text = "Edit"
        Me.Button_edit.UseVisualStyleBackColor = False
        '
        'Button_tambah
        '
        Me.Button_tambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_tambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_tambah.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_tambah.Location = New System.Drawing.Point(490, 364)
        Me.Button_tambah.Name = "Button_tambah"
        Me.Button_tambah.Size = New System.Drawing.Size(75, 23)
        Me.Button_tambah.TabIndex = 30
        Me.Button_tambah.Text = "Tambah"
        Me.Button_tambah.UseVisualStyleBackColor = False
        '
        'Button_pdf
        '
        Me.Button_pdf.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_pdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_pdf.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_pdf.Location = New System.Drawing.Point(693, 364)
        Me.Button_pdf.Name = "Button_pdf"
        Me.Button_pdf.Size = New System.Drawing.Size(63, 52)
        Me.Button_pdf.TabIndex = 48
        Me.Button_pdf.Text = "Print PDF"
        Me.Button_pdf.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(325, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 26)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "PO Bahan Baku"
        '
        'ViewDetailMM_PORawMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(778, 423)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button_pdf)
        Me.Controls.Add(Me.Button_batal)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button_hapus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_edit)
        Me.Controls.Add(Me.Button_tambah)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button_Kembali)
        Me.Name = "ViewDetailMM_PORawMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order Raw Material"
        CType(Me.DGV_detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV_detail As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxCari As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_namaProduk As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_kodeProduk As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Kembali As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_namaVendor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_batal As System.Windows.Forms.Button
    Friend WithEvents Button_hapus As System.Windows.Forms.Button
    Friend WithEvents Button_edit As System.Windows.Forms.Button
    Friend WithEvents Button_tambah As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_hargaMaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox_kodePembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_namaMaterial As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_THarga As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_qty As System.Windows.Forms.TextBox
    Friend WithEvents Button_pdf As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker_pembelian As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_pengiriman As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
