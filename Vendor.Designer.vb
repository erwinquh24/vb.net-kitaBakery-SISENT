<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendor
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox_KodeVendor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_AVendor = New System.Windows.Forms.TextBox()
        Me.TextBox_nVendor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_CVendor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_Vendor = New System.Windows.Forms.DataGridView()
        Me.RadioButton_NVendor = New System.Windows.Forms.RadioButton()
        Me.RadioButton_KVendor = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_cari = New System.Windows.Forms.TextBox()
        Me.Button_batal = New System.Windows.Forms.Button()
        Me.Button_hapus = New System.Windows.Forms.Button()
        Me.Button_edit = New System.Windows.Forms.Button()
        Me.Button_tambah = New System.Windows.Forms.Button()
        Me.Button_Kembali = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_nMaterial = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Vendor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_KodeVendor
        '
        Me.TextBox_KodeVendor.Enabled = False
        Me.TextBox_KodeVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_KodeVendor.Location = New System.Drawing.Point(110, 14)
        Me.TextBox_KodeVendor.Name = "TextBox_KodeVendor"
        Me.TextBox_KodeVendor.Size = New System.Drawing.Size(138, 20)
        Me.TextBox_KodeVendor.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Kode Vendor"
        '
        'TextBox_AVendor
        '
        Me.TextBox_AVendor.Enabled = False
        Me.TextBox_AVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_AVendor.Location = New System.Drawing.Point(110, 147)
        Me.TextBox_AVendor.Name = "TextBox_AVendor"
        Me.TextBox_AVendor.Size = New System.Drawing.Size(138, 20)
        Me.TextBox_AVendor.TabIndex = 38
        '
        'TextBox_nVendor
        '
        Me.TextBox_nVendor.Enabled = False
        Me.TextBox_nVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_nVendor.Location = New System.Drawing.Point(110, 62)
        Me.TextBox_nVendor.Name = "TextBox_nVendor"
        Me.TextBox_nVendor.Size = New System.Drawing.Size(138, 20)
        Me.TextBox_nVendor.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Contact Vendor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Nama Vendor"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TextBox_nMaterial)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox_CVendor)
        Me.GroupBox3.Controls.Add(Me.TextBox_KodeVendor)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox_AVendor)
        Me.GroupBox3.Controls.Add(Me.TextBox_nVendor)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(519, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(254, 221)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "<<Vendor>>"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Nama Material"
        '
        'TextBox_CVendor
        '
        Me.TextBox_CVendor.Enabled = False
        Me.TextBox_CVendor.Location = New System.Drawing.Point(110, 104)
        Me.TextBox_CVendor.Name = "TextBox_CVendor"
        Me.TextBox_CVendor.Size = New System.Drawing.Size(138, 20)
        Me.TextBox_CVendor.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Alamat Vendor"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(440, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DGV_Vendor)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 358)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "<<Data Vendor>>"
        '
        'DGV_Vendor
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Vendor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_Vendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Vendor.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_Vendor.Location = New System.Drawing.Point(3, 17)
        Me.DGV_Vendor.Name = "DGV_Vendor"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Vendor.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGV_Vendor.Size = New System.Drawing.Size(495, 338)
        Me.DGV_Vendor.TabIndex = 19
        '
        'RadioButton_NVendor
        '
        Me.RadioButton_NVendor.AutoSize = True
        Me.RadioButton_NVendor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_NVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_NVendor.Location = New System.Drawing.Point(112, 17)
        Me.RadioButton_NVendor.Name = "RadioButton_NVendor"
        Me.RadioButton_NVendor.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton_NVendor.TabIndex = 32
        Me.RadioButton_NVendor.TabStop = True
        Me.RadioButton_NVendor.Text = "Nama Vendor"
        Me.RadioButton_NVendor.UseVisualStyleBackColor = True
        '
        'RadioButton_KVendor
        '
        Me.RadioButton_KVendor.AutoSize = True
        Me.RadioButton_KVendor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_KVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_KVendor.Location = New System.Drawing.Point(3, 17)
        Me.RadioButton_KVendor.Name = "RadioButton_KVendor"
        Me.RadioButton_KVendor.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton_KVendor.TabIndex = 31
        Me.RadioButton_KVendor.TabStop = True
        Me.RadioButton_KVendor.Text = "Kode Vendor"
        Me.RadioButton_KVendor.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton_NVendor)
        Me.GroupBox1.Controls.Add(Me.RadioButton_KVendor)
        Me.GroupBox1.Controls.Add(Me.TextBox_cari)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 41)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "<<Pencarian>>"
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
        Me.Button_batal.Location = New System.Drawing.Point(681, 439)
        Me.Button_batal.Name = "Button_batal"
        Me.Button_batal.Size = New System.Drawing.Size(75, 23)
        Me.Button_batal.TabIndex = 41
        Me.Button_batal.Text = "Batal"
        Me.Button_batal.UseVisualStyleBackColor = False
        '
        'Button_hapus
        '
        Me.Button_hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_hapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_hapus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_hapus.Location = New System.Drawing.Point(539, 439)
        Me.Button_hapus.Name = "Button_hapus"
        Me.Button_hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_hapus.TabIndex = 40
        Me.Button_hapus.Text = "Hapus"
        Me.Button_hapus.UseVisualStyleBackColor = False
        '
        'Button_edit
        '
        Me.Button_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_edit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_edit.Location = New System.Drawing.Point(681, 391)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_edit.TabIndex = 39
        Me.Button_edit.Text = "Edit"
        Me.Button_edit.UseVisualStyleBackColor = False
        '
        'Button_tambah
        '
        Me.Button_tambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button_tambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_tambah.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_tambah.Location = New System.Drawing.Point(539, 391)
        Me.Button_tambah.Name = "Button_tambah"
        Me.Button_tambah.Size = New System.Drawing.Size(75, 23)
        Me.Button_tambah.TabIndex = 38
        Me.Button_tambah.Text = "Tambah"
        Me.Button_tambah.UseVisualStyleBackColor = False
        '
        'Button_Kembali
        '
        Me.Button_Kembali.Location = New System.Drawing.Point(421, 428)
        Me.Button_Kembali.Name = "Button_Kembali"
        Me.Button_Kembali.Size = New System.Drawing.Size(75, 23)
        Me.Button_Kembali.TabIndex = 43
        Me.Button_Kembali.Text = "Kembali"
        Me.Button_Kembali.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(346, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 26)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Data Vendor"
        '
        'TextBox_nMaterial
        '
        Me.TextBox_nMaterial.Location = New System.Drawing.Point(110, 186)
        Me.TextBox_nMaterial.Name = "TextBox_nMaterial"
        Me.TextBox_nMaterial.Size = New System.Drawing.Size(138, 20)
        Me.TextBox_nMaterial.TabIndex = 48
        '
        'Vendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(779, 466)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_batal)
        Me.Controls.Add(Me.Button_hapus)
        Me.Controls.Add(Me.Button_edit)
        Me.Controls.Add(Me.Button_tambah)
        Me.Controls.Add(Me.Button_Kembali)
        Me.Name = "Vendor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendor"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_Vendor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_KodeVendor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox_AVendor As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_nVendor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Vendor As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButton_NVendor As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_KVendor As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_cari As System.Windows.Forms.TextBox
    Friend WithEvents Button_batal As System.Windows.Forms.Button
    Friend WithEvents Button_hapus As System.Windows.Forms.Button
    Friend WithEvents Button_edit As System.Windows.Forms.Button
    Friend WithEvents Button_tambah As System.Windows.Forms.Button
    Friend WithEvents Button_Kembali As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox_CVendor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox_nMaterial As System.Windows.Forms.TextBox
End Class
