<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewDetailMM_Produk
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
        Me.TextBox_cari = New System.Windows.Forms.TextBox()
        Me.Button_batal = New System.Windows.Forms.Button()
        Me.Button_hapus = New System.Windows.Forms.Button()
        Me.Button_edit = New System.Windows.Forms.Button()
        Me.Button_tambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_NProduk = New System.Windows.Forms.RadioButton()
        Me.RadioButton_KProduk = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown_jumlahProduk = New System.Windows.Forms.NumericUpDown()
        Me.TextBox_Kode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Harga = New System.Windows.Forms.TextBox()
        Me.TextBox_nProduk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumericUpDown_jumlahProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_cari
        '
        Me.TextBox_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_cari.Location = New System.Drawing.Point(316, 16)
        Me.TextBox_cari.Name = "TextBox_cari"
        Me.TextBox_cari.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_cari.TabIndex = 30
        '
        'Button_batal
        '
        Me.Button_batal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_batal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_batal.Enabled = False
        Me.Button_batal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_batal.Location = New System.Drawing.Point(681, 447)
        Me.Button_batal.Name = "Button_batal"
        Me.Button_batal.Size = New System.Drawing.Size(75, 23)
        Me.Button_batal.TabIndex = 29
        Me.Button_batal.Text = "Batal"
        Me.Button_batal.UseVisualStyleBackColor = False
        '
        'Button_hapus
        '
        Me.Button_hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_hapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_hapus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_hapus.Location = New System.Drawing.Point(539, 447)
        Me.Button_hapus.Name = "Button_hapus"
        Me.Button_hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_hapus.TabIndex = 28
        Me.Button_hapus.Text = "Hapus"
        Me.Button_hapus.UseVisualStyleBackColor = False
        '
        'Button_edit
        '
        Me.Button_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_edit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_edit.Location = New System.Drawing.Point(681, 399)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_edit.TabIndex = 27
        Me.Button_edit.Text = "Edit"
        Me.Button_edit.UseVisualStyleBackColor = False
        '
        'Button_tambah
        '
        Me.Button_tambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_tambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_tambah.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_tambah.Location = New System.Drawing.Point(539, 399)
        Me.Button_tambah.Name = "Button_tambah"
        Me.Button_tambah.Size = New System.Drawing.Size(75, 23)
        Me.Button_tambah.TabIndex = 26
        Me.Button_tambah.Text = "Tambah"
        Me.Button_tambah.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton_NProduk)
        Me.GroupBox1.Controls.Add(Me.RadioButton_KProduk)
        Me.GroupBox1.Controls.Add(Me.TextBox_cari)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 41)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "<<Pencarian>>"
        '
        'RadioButton_NProduk
        '
        Me.RadioButton_NProduk.AutoSize = True
        Me.RadioButton_NProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_NProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_NProduk.Location = New System.Drawing.Point(112, 17)
        Me.RadioButton_NProduk.Name = "RadioButton_NProduk"
        Me.RadioButton_NProduk.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton_NProduk.TabIndex = 32
        Me.RadioButton_NProduk.TabStop = True
        Me.RadioButton_NProduk.Text = "Nama Produk"
        Me.RadioButton_NProduk.UseVisualStyleBackColor = True
        '
        'RadioButton_KProduk
        '
        Me.RadioButton_KProduk.AutoSize = True
        Me.RadioButton_KProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_KProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_KProduk.Location = New System.Drawing.Point(3, 17)
        Me.RadioButton_KProduk.Name = "RadioButton_KProduk"
        Me.RadioButton_KProduk.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton_KProduk.TabIndex = 31
        Me.RadioButton_KProduk.TabStop = True
        Me.RadioButton_KProduk.Text = "Kode Produk"
        Me.RadioButton_KProduk.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(440, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.NumericUpDown_jumlahProduk)
        Me.GroupBox3.Controls.Add(Me.TextBox_Kode)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox_Harga)
        Me.GroupBox3.Controls.Add(Me.TextBox_nProduk)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(519, 115)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(254, 196)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "<<Produk>>"
        '
        'NumericUpDown_jumlahProduk
        '
        Me.NumericUpDown_jumlahProduk.Enabled = False
        Me.NumericUpDown_jumlahProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown_jumlahProduk.Location = New System.Drawing.Point(110, 104)
        Me.NumericUpDown_jumlahProduk.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.NumericUpDown_jumlahProduk.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_jumlahProduk.Name = "NumericUpDown_jumlahProduk"
        Me.NumericUpDown_jumlahProduk.Size = New System.Drawing.Size(70, 20)
        Me.NumericUpDown_jumlahProduk.TabIndex = 42
        Me.NumericUpDown_jumlahProduk.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TextBox_Kode
        '
        Me.TextBox_Kode.Enabled = False
        Me.TextBox_Kode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Kode.Location = New System.Drawing.Point(110, 14)
        Me.TextBox_Kode.Name = "TextBox_Kode"
        Me.TextBox_Kode.Size = New System.Drawing.Size(138, 20)
        Me.TextBox_Kode.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Kode Produk"
        '
        'TextBox_Harga
        '
        Me.TextBox_Harga.Enabled = False
        Me.TextBox_Harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Harga.Location = New System.Drawing.Point(110, 147)
        Me.TextBox_Harga.Name = "TextBox_Harga"
        Me.TextBox_Harga.Size = New System.Drawing.Size(138, 20)
        Me.TextBox_Harga.TabIndex = 38
        '
        'TextBox_nProduk
        '
        Me.TextBox_nProduk.Enabled = False
        Me.TextBox_nProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_nProduk.Location = New System.Drawing.Point(110, 62)
        Me.TextBox_nProduk.Name = "TextBox_nProduk"
        Me.TextBox_nProduk.Size = New System.Drawing.Size(138, 20)
        Me.TextBox_nProduk.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Jumlah Produk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Harga Produk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Nama Produk"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 358)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "<<Data Produk>>"
        '
        'DGV
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Location = New System.Drawing.Point(3, 20)
        Me.DGV.Name = "DGV"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV.Size = New System.Drawing.Size(495, 338)
        Me.DGV.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(338, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 26)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Daftar Produk"
        '
        'ViewDetailMM_Produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(779, 479)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_batal)
        Me.Controls.Add(Me.Button_hapus)
        Me.Controls.Add(Me.Button_edit)
        Me.Controls.Add(Me.Button_tambah)
        Me.Name = "ViewDetailMM_Produk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produk"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NumericUpDown_jumlahProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_cari As System.Windows.Forms.TextBox
    Friend WithEvents Button_batal As System.Windows.Forms.Button
    Friend WithEvents Button_hapus As System.Windows.Forms.Button
    Friend WithEvents Button_edit As System.Windows.Forms.Button
    Friend WithEvents Button_tambah As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_NProduk As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_KProduk As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Kode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Harga As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_nProduk As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown_jumlahProduk As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
