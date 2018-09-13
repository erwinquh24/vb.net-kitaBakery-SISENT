<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.TextBox_Pass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_uName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_batal = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_login = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_Pass
        '
        Me.TextBox_Pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_Pass.Location = New System.Drawing.Point(259, 133)
        Me.TextBox_Pass.Name = "TextBox_Pass"
        Me.TextBox_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Pass.Size = New System.Drawing.Size(162, 20)
        Me.TextBox_Pass.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'TextBox_uName
        '
        Me.TextBox_uName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_uName.Location = New System.Drawing.Point(258, 85)
        Me.TextBox_uName.Name = "TextBox_uName"
        Me.TextBox_uName.Size = New System.Drawing.Size(162, 20)
        Me.TextBox_uName.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'Button_batal
        '
        Me.Button_batal.BackColor = System.Drawing.Color.Transparent
        Me.Button_batal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_batal.Location = New System.Drawing.Point(346, 171)
        Me.Button_batal.Name = "Button_batal"
        Me.Button_batal.Size = New System.Drawing.Size(75, 23)
        Me.Button_batal.TabIndex = 11
        Me.Button_batal.Text = "Batal"
        Me.Button_batal.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 26)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Login"
        '
        'Button_login
        '
        Me.Button_login.BackColor = System.Drawing.Color.Transparent
        Me.Button_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_login.Location = New System.Drawing.Point(258, 171)
        Me.Button_login.Name = "Button_login"
        Me.Button_login.Size = New System.Drawing.Size(75, 23)
        Me.Button_login.TabIndex = 10
        Me.Button_login.Text = "Login"
        Me.Button_login.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sederhana.My.Resources.Resources.login
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 202)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(433, 206)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_batal)
        Me.Controls.Add(Me.Button_login)
        Me.Controls.Add(Me.TextBox_Pass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_uName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_login As System.Windows.Forms.Button
    Friend WithEvents TextBox_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_uName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_batal As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
