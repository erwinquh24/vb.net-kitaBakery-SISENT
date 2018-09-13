<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MM_Production
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
        Me.Button_batal = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.RadioButton_namaProduk = New System.Windows.Forms.RadioButton()
        Me.TextBox_cari = New System.Windows.Forms.TextBox()
        Me.Button_hapus = New System.Windows.Forms.Button()
        Me.ComboBox_status = New System.Windows.Forms.ComboBox()
        Me.TextBox_namaProduk = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker_selesai = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_jumlahProduk = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_kodeOrder = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker_order = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_Kembali = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox_catatan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_proses = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_batal
        '
        Me.Button_batal.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_batal.Enabled = False
        Me.Button_batal.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_batal.Location = New System.Drawing.Point(714, 446)
        Me.Button_batal.Name = "Button_batal"
        Me.Button_batal.Size = New System.Drawing.Size(75, 23)
        Me.Button_batal.TabIndex = 63
        Me.Button_batal.Text = "Batal"
        Me.Button_batal.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 388)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "<<Daftar P Bahan Baku>>"
        '
        'DGV
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV.Location = New System.Drawing.Point(9, 34)
        Me.DGV.Name = "DGV"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV.Size = New System.Drawing.Size(473, 345)
        Me.DGV.TabIndex = 18
        '
        'RadioButton_namaProduk
        '
        Me.RadioButton_namaProduk.AutoSize = True
        Me.RadioButton_namaProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_namaProduk.Location = New System.Drawing.Point(9, 24)
        Me.RadioButton_namaProduk.Name = "RadioButton_namaProduk"
        Me.RadioButton_namaProduk.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton_namaProduk.TabIndex = 35
        Me.RadioButton_namaProduk.TabStop = True
        Me.RadioButton_namaProduk.Text = "Nama Produk"
        Me.RadioButton_namaProduk.UseVisualStyleBackColor = True
        '
        'TextBox_cari
        '
        Me.TextBox_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_cari.Location = New System.Drawing.Point(278, 23)
        Me.TextBox_cari.Name = "TextBox_cari"
        Me.TextBox_cari.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_cari.TabIndex = 29
        '
        'Button_hapus
        '
        Me.Button_hapus.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_hapus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_hapus.Location = New System.Drawing.Point(613, 446)
        Me.Button_hapus.Name = "Button_hapus"
        Me.Button_hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_hapus.TabIndex = 62
        Me.Button_hapus.Text = "Hapus"
        Me.Button_hapus.UseVisualStyleBackColor = False
        '
        'ComboBox_status
        '
        Me.ComboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_status.Enabled = False
        Me.ComboBox_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_status.FormattingEnabled = True
        Me.ComboBox_status.Items.AddRange(New Object() {"", "Request", "Pending", "Selesai"})
        Me.ComboBox_status.Location = New System.Drawing.Point(126, 201)
        Me.ComboBox_status.Name = "ComboBox_status"
        Me.ComboBox_status.Size = New System.Drawing.Size(162, 21)
        Me.ComboBox_status.TabIndex = 75
        '
        'TextBox_namaProduk
        '
        Me.TextBox_namaProduk.Enabled = False
        Me.TextBox_namaProduk.Location = New System.Drawing.Point(126, 127)
        Me.TextBox_namaProduk.Name = "TextBox_namaProduk"
        Me.TextBox_namaProduk.Size = New System.Drawing.Size(165, 20)
        Me.TextBox_namaProduk.TabIndex = 73
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Status"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker_selesai
        '
        Me.DateTimePicker_selesai.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker_selesai.Enabled = False
        Me.DateTimePicker_selesai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_selesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_selesai.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker_selesai.Location = New System.Drawing.Point(125, 92)
        Me.DateTimePicker_selesai.Name = "DateTimePicker_selesai"
        Me.DateTimePicker_selesai.Size = New System.Drawing.Size(165, 20)
        Me.DateTimePicker_selesai.TabIndex = 71
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Tanggal Selesai"
        '
        'TextBox_jumlahProduk
        '
        Me.TextBox_jumlahProduk.Enabled = False
        Me.TextBox_jumlahProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_jumlahProduk.Location = New System.Drawing.Point(126, 164)
        Me.TextBox_jumlahProduk.Name = "TextBox_jumlahProduk"
        Me.TextBox_jumlahProduk.Size = New System.Drawing.Size(164, 20)
        Me.TextBox_jumlahProduk.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 130)
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton_namaProduk)
        Me.GroupBox1.Controls.Add(Me.TextBox_cari)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 47)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "<<Pencarian>>"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(119, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton1.TabIndex = 36
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Status"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Jumlah Raw Material"
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
        'Button_Kembali
        '
        Me.Button_Kembali.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_Kembali.Location = New System.Drawing.Point(420, 83)
        Me.Button_Kembali.Name = "Button_Kembali"
        Me.Button_Kembali.Size = New System.Drawing.Size(75, 23)
        Me.Button_Kembali.TabIndex = 59
        Me.Button_Kembali.Text = "Kembali"
        Me.Button_Kembali.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TextBox_catatan)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ComboBox_status)
        Me.GroupBox3.Controls.Add(Me.TextBox_namaProduk)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_selesai)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox_jumlahProduk)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox_kodeOrder)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker_order)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(501, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 303)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "<<P Bahan Baku>>"
        '
        'TextBox_catatan
        '
        Me.TextBox_catatan.Enabled = False
        Me.TextBox_catatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_catatan.Location = New System.Drawing.Point(126, 236)
        Me.TextBox_catatan.Multiline = True
        Me.TextBox_catatan.Name = "TextBox_catatan"
        Me.TextBox_catatan.Size = New System.Drawing.Size(164, 55)
        Me.TextBox_catatan.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Catatan"
        '
        'Button_proses
        '
        Me.Button_proses.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button_proses.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_proses.Location = New System.Drawing.Point(515, 446)
        Me.Button_proses.Name = "Button_proses"
        Me.Button_proses.Size = New System.Drawing.Size(75, 23)
        Me.Button_proses.TabIndex = 60
        Me.Button_proses.Text = "Proses"
        Me.Button_proses.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(340, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 26)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Production"
        '
        'Production
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(802, 515)
        Me.Controls.Add(Me.Button_batal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button_hapus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Kembali)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button_proses)
        Me.Controls.Add(Me.Label12)
        Me.Name = "Production"
        Me.Text = "Production"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_batal As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButton_namaProduk As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox_cari As System.Windows.Forms.TextBox
    Friend WithEvents Button_hapus As System.Windows.Forms.Button
    Friend WithEvents ComboBox_status As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_namaProduk As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_selesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox_jumlahProduk As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_kodeOrder As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_order As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button_Kembali As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_proses As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_catatan As System.Windows.Forms.TextBox
End Class
