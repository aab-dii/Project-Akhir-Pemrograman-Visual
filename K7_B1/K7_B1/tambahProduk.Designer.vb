<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tambahProduk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cbKualitas = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.baju = New System.Windows.Forms.RadioButton()
        Me.sepatu = New System.Windows.Forms.RadioButton()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMadeIn = New System.Windows.Forms.TextBox()
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPilihGambar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(282, 443)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(103, 42)
        Me.btnBatal.TabIndex = 54
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(148, 443)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(103, 42)
        Me.btnSimpan.TabIndex = 53
        Me.btnSimpan.Text = "SImpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'cbKualitas
        '
        Me.cbKualitas.FormattingEnabled = True
        Me.cbKualitas.Items.AddRange(New Object() {"Bagus", "Jelek"})
        Me.cbKualitas.Location = New System.Drawing.Point(199, 278)
        Me.cbKualitas.Name = "cbKualitas"
        Me.cbKualitas.Size = New System.Drawing.Size(197, 24)
        Me.cbKualitas.TabIndex = 52
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.baju)
        Me.GroupBox1.Controls.Add(Me.sepatu)
        Me.GroupBox1.Location = New System.Drawing.Point(192, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 37)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'baju
        '
        Me.baju.AutoSize = True
        Me.baju.Location = New System.Drawing.Point(125, 10)
        Me.baju.Name = "baju"
        Me.baju.Size = New System.Drawing.Size(54, 20)
        Me.baju.TabIndex = 19
        Me.baju.TabStop = True
        Me.baju.Text = "baju"
        Me.baju.UseVisualStyleBackColor = True
        '
        'sepatu
        '
        Me.sepatu.AutoSize = True
        Me.sepatu.Location = New System.Drawing.Point(24, 10)
        Me.sepatu.Name = "sepatu"
        Me.sepatu.Size = New System.Drawing.Size(69, 20)
        Me.sepatu.TabIndex = 18
        Me.sepatu.TabStop = True
        Me.sepatu.Text = "sepatu"
        Me.sepatu.UseVisualStyleBackColor = True
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(199, 324)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(197, 22)
        Me.txtStok.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Stok :"
        '
        'txtMadeIn
        '
        Me.txtMadeIn.Location = New System.Drawing.Point(199, 222)
        Me.txtMadeIn.Name = "txtMadeIn"
        Me.txtMadeIn.Size = New System.Drawing.Size(197, 22)
        Me.txtMadeIn.TabIndex = 48
        '
        'txtMerek
        '
        Me.txtMerek.Location = New System.Drawing.Point(199, 173)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(197, 22)
        Me.txtMerek.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Kualitas :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Made In :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Merk :"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(199, 127)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(197, 22)
        Me.txtHarga.TabIndex = 43
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(199, 22)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(197, 22)
        Me.txtNama.TabIndex = 42
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(92, 127)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(51, 16)
        Me.label3.TabIndex = 41
        Me.label3.Text = "Harga :"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(92, 74)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 16)
        Me.label2.TabIndex = 40
        Me.label2.Text = "Jenis :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(92, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(50, 16)
        Me.label1.TabIndex = 39
        Me.label1.Text = "Nama :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(592, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 158)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'btnPilihGambar
        '
        Me.btnPilihGambar.Location = New System.Drawing.Point(575, 239)
        Me.btnPilihGambar.Name = "btnPilihGambar"
        Me.btnPilihGambar.Size = New System.Drawing.Size(103, 42)
        Me.btnPilihGambar.TabIndex = 56
        Me.btnPilihGambar.Text = "Browse"
        Me.btnPilihGambar.UseVisualStyleBackColor = True
        '
        'tambahProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 507)
        Me.Controls.Add(Me.btnPilihGambar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cbKualitas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMadeIn)
        Me.Controls.Add(Me.txtMerek)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "tambahProduk"
        Me.Text = "tambahProduk"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents cbKualitas As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents baju As RadioButton
    Friend WithEvents sepatu As RadioButton
    Friend WithEvents txtStok As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMadeIn As TextBox
    Friend WithEvents txtMerek As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents label3 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents btnPilihGambar As Button
    Friend WithEvents txtPathGambar As TextBox
End Class
