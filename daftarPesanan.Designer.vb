<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftarPesanan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_pProduk = New System.Windows.Forms.Button()
        Me.Button_bBaku = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Daftar Pesanan"
        '
        'Button_pProduk
        '
        Me.Button_pProduk.Location = New System.Drawing.Point(54, 69)
        Me.Button_pProduk.Name = "Button_pProduk"
        Me.Button_pProduk.Size = New System.Drawing.Size(151, 53)
        Me.Button_pProduk.TabIndex = 1
        Me.Button_pProduk.Text = "Daftar Pesanan Produk"
        Me.Button_pProduk.UseVisualStyleBackColor = True
        '
        'Button_bBaku
        '
        Me.Button_bBaku.Location = New System.Drawing.Point(232, 69)
        Me.Button_bBaku.Name = "Button_bBaku"
        Me.Button_bBaku.Size = New System.Drawing.Size(161, 53)
        Me.Button_bBaku.TabIndex = 2
        Me.Button_bBaku.Text = "Daftar Pesanan Bahanbaku"
        Me.Button_bBaku.UseVisualStyleBackColor = True
        '
        'daftarPesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(448, 184)
        Me.Controls.Add(Me.Button_bBaku)
        Me.Controls.Add(Me.Button_pProduk)
        Me.Controls.Add(Me.Label1)
        Me.Name = "daftarPesanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "daftarPesanan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_pProduk As System.Windows.Forms.Button
    Friend WithEvents Button_bBaku As System.Windows.Forms.Button
End Class
