<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewDetail_PProduct
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button_pdf = New System.Windows.Forms.Button()
        Me.Button_Kembali = New System.Windows.Forms.Button()
        Me.TextBox_status = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_jumlahBahanBaku = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox_namaBahanBaku = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker_selesai = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_kodeOrder = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker_order = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_batal = New System.Windows.Forms.Button()
        Me.TextBox_cari = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.RadioButton_namaProduk = New System.Windows.Forms.RadioButton()
        Me.Button_hapus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button_tambah = New System.Windows.Forms.Button()
        Me.Button_edit = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(342, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(166, 26)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "PO Bahan Baku"
        '
        'Button_pdf
        '
        Me.Button_pdf.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_pdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_pdf.Enabled = False
        Me.Button_pdf.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_pdf.Location = New System.Drawing.Point(726, 447)
        Me.Button_pdf.Name = "Button_pdf"
        Me.Button_pdf.Size = New System.Drawing.Size(63, 52)
        Me.Button_pdf.TabIndex = 57
        Me.Button_pdf.Text = "Print PDF"
        Me.Button_pdf.UseVisualStyleBackColor = False
        '
        'Button_Kembali
        '
        Me.Button_Kembali.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_Kembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Kembali.Location = New System.Drawing.Point(422, 84)
        Me.Button_Kembali.Name = "Button_Kembali"
        Me.Button_Kembali.Size = New System.Drawing.Size(75, 23)
        Me.Button_Kembali.TabIndex = 49
        Me.Button_Kembali.Text = "Kembali"
        Me.Button_Kembali.UseVisualStyleBackColor = False
        '
        'TextBox_status
        '
        Me.TextBox_status.Enabled = False
        Me.TextBox_status.Location = New System.Drawing.Point(125, 199)
        Me.TextBox_status.Name = "TextBox_status"
        Me.TextBox_status.Size = New System.Drawing.Size(165, 20)
        Me.TextBox_status.TabIndex = 73
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Status"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Jumlah Raw Material"
        '
        'TextBox_jumlahBahanBaku
        '
        Me.TextBox_jumlahBahanBaku.Enabled = False
        Me.TextBox_jumlahBahanBaku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_jumlahBahanBaku.Location = New System.Drawing.Point(125, 162)
        Me.TextBox_jumlahBahanBaku.Name = "TextBox_jumlahBahanBaku"
        Me.TextBox_jumlahBahanBaku.Size = New System.Drawing.Size(164, 20)
        Me.TextBox_jumlahBahanBaku.TabIndex = 67
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.ComboBox_namaBahanBaku)
        Me.GroupBox3.Controls.Add(Me.TextBox_status)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_selesai)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox_jumlahBahanBaku)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox_kodeOrder)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_order)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(503, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 265)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "<<P Bahan Baku>>"
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.sederhana.My.Resources.Resources.notif
        Me.PictureBox1.Location = New System.Drawing.Point(246, 225)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'ComboBox_namaBahanBaku
        '
        Me.ComboBox_namaBahanBaku.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox_namaBahanBaku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_namaBahanBaku.Enabled = False
        Me.ComboBox_namaBahanBaku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_namaBahanBaku.FormattingEnabled = True
        Me.ComboBox_namaBahanBaku.Items.AddRange(New Object() {""})
        Me.ComboBox_namaBahanBaku.Location = New System.Drawing.Point(125, 125)
        Me.ComboBox_namaBahanBaku.Name = "ComboBox_namaBahanBaku"
        Me.ComboBox_namaBahanBaku.Size = New System.Drawing.Size(165, 21)
        Me.ComboBox_namaBahanBaku.TabIndex = 75
        '
        'DateTimePicker_selesai
        '
        Me.DateTimePicker_selesai.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker_selesai.Enabled = False
        Me.DateTimePicker_selesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_selesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_selesai.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker_selesai.Location = New System.Drawing.Point(124, 90)
        Me.DateTimePicker_selesai.Name = "DateTimePicker_selesai"
        Me.DateTimePicker_selesai.Size = New System.Drawing.Size(165, 20)
        Me.DateTimePicker_selesai.TabIndex = 71
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Tanggal Selesai"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Nama Raw Material"
        '
        'TextBox_kodeOrder
        '
        Me.TextBox_kodeOrder.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox_kodeOrder.Enabled = False
        Me.TextBox_kodeOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_kodeOrder.Location = New System.Drawing.Point(126, 19)
        Me.TextBox_kodeOrder.Name = "TextBox_kodeOrder"
        Me.TextBox_kodeOrder.Size = New System.Drawing.Size(164, 20)
        Me.TextBox_kodeOrder.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Kode Order"
        '
        'DateTimePicker_order
        '
        Me.DateTimePicker_order.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker_order.Enabled = False
        Me.DateTimePicker_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_order.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_order.Location = New System.Drawing.Point(126, 52)
        Me.DateTimePicker_order.Name = "DateTimePicker_order"
        Me.DateTimePicker_order.Size = New System.Drawing.Size(164, 20)
        Me.DateTimePicker_order.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Tanggal Pemesanan"
        '
        'Button_batal
        '
        Me.Button_batal.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_batal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_batal.Enabled = False
        Me.Button_batal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_batal.Location = New System.Drawing.Point(631, 476)
        Me.Button_batal.Name = "Button_batal"
        Me.Button_batal.Size = New System.Drawing.Size(75, 23)
        Me.Button_batal.TabIndex = 53
        Me.Button_batal.Text = "Batal"
        Me.Button_batal.UseVisualStyleBackColor = False
        '
        'TextBox_cari
        '
        Me.TextBox_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_cari.Location = New System.Drawing.Point(278, 23)
        Me.TextBox_cari.Name = "TextBox_cari"
        Me.TextBox_cari.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_cari.TabIndex = 29
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 388)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "<<Daftar P Bahan Baku>>"
        '
        'DGV
        '
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle11
        Me.DGV.Location = New System.Drawing.Point(9, 34)
        Me.DGV.Name = "DGV"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DGV.Size = New System.Drawing.Size(473, 345)
        Me.DGV.TabIndex = 18
        '
        'RadioButton_namaProduk
        '
        Me.RadioButton_namaProduk.AutoSize = True
        Me.RadioButton_namaProduk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_namaProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_namaProduk.Location = New System.Drawing.Point(9, 24)
        Me.RadioButton_namaProduk.Name = "RadioButton_namaProduk"
        Me.RadioButton_namaProduk.Size = New System.Drawing.Size(115, 17)
        Me.RadioButton_namaProduk.TabIndex = 35
        Me.RadioButton_namaProduk.TabStop = True
        Me.RadioButton_namaProduk.Text = "Nama Bahan Baku"
        Me.RadioButton_namaProduk.UseVisualStyleBackColor = True
        '
        'Button_hapus
        '
        Me.Button_hapus.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_hapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_hapus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_hapus.Location = New System.Drawing.Point(524, 476)
        Me.Button_hapus.Name = "Button_hapus"
        Me.Button_hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_hapus.TabIndex = 52
        Me.Button_hapus.Text = "Hapus"
        Me.Button_hapus.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton_namaProduk)
        Me.GroupBox1.Controls.Add(Me.TextBox_cari)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 47)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "<<Pencarian>>"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(130, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton1.TabIndex = 36
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Status"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button_tambah
        '
        Me.Button_tambah.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_tambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_tambah.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_tambah.Location = New System.Drawing.Point(524, 447)
        Me.Button_tambah.Name = "Button_tambah"
        Me.Button_tambah.Size = New System.Drawing.Size(75, 23)
        Me.Button_tambah.TabIndex = 50
        Me.Button_tambah.Text = "Tambah"
        Me.Button_tambah.UseVisualStyleBackColor = False
        '
        'Button_edit
        '
        Me.Button_edit.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_edit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_edit.Location = New System.Drawing.Point(631, 447)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_edit.TabIndex = 51
        Me.Button_edit.Text = "Edit"
        Me.Button_edit.UseVisualStyleBackColor = False
        '
        'ViewDetail_PProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(802, 515)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button_pdf)
        Me.Controls.Add(Me.Button_Kembali)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button_batal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button_hapus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_tambah)
        Me.Controls.Add(Me.Button_edit)
        Me.Name = "ViewDetail_PProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button_pdf As System.Windows.Forms.Button
    Friend WithEvents Button_Kembali As System.Windows.Forms.Button
    Friend WithEvents TextBox_status As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_jumlahBahanBaku As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker_selesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_kodeOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_order As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button_batal As System.Windows.Forms.Button
    Friend WithEvents TextBox_cari As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButton_namaProduk As System.Windows.Forms.RadioButton
    Friend WithEvents Button_hapus As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_tambah As System.Windows.Forms.Button
    Friend WithEvents Button_edit As System.Windows.Forms.Button
    Friend WithEvents ComboBox_namaBahanBaku As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
