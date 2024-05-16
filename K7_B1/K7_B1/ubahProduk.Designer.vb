<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ubahProduk
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbKualitas = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.baju = New System.Windows.Forms.RadioButton()
        Me.sepatu = New System.Windows.Forms.RadioButton()
        Me.btnPilihGambar = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtMadeIn = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.K7_B1.My.Resources.Resources.hexafix6
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.btnBatal)
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-4, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1112, 647)
        Me.Panel1.TabIndex = 58
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Red
        Me.btnBatal.Font = New System.Drawing.Font("Visby Round CF Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Image = Global.K7_B1.My.Resources.Resources.Cancel
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(118, 512)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(378, 45)
        Me.btnBatal.TabIndex = 54
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSimpan.Font = New System.Drawing.Font("Visby Round CF Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Image = Global.K7_B1.My.Resources.Resources.checklist1
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(550, 512)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(378, 45)
        Me.btnSimpan.TabIndex = 53
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cbKualitas)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.txtNama)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.btnPilihGambar)
        Me.Panel2.Controls.Add(Me.label1)
        Me.Panel2.Controls.Add(Me.txtStok)
        Me.Panel2.Controls.Add(Me.label2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.label3)
        Me.Panel2.Controls.Add(Me.txtMadeIn)
        Me.Panel2.Controls.Add(Me.txtHarga)
        Me.Panel2.Controls.Add(Me.txtMerek)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(121, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(798, 422)
        Me.Panel2.TabIndex = 57
        '
        'cbKualitas
        '
        Me.cbKualitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKualitas.FormattingEnabled = True
        Me.cbKualitas.Items.AddRange(New Object() {"Bagus", "Jelek"})
        Me.cbKualitas.Location = New System.Drawing.Point(138, 326)
        Me.cbKualitas.Name = "cbKualitas"
        Me.cbKualitas.Size = New System.Drawing.Size(261, 28)
        Me.cbKualitas.TabIndex = 52
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(452, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 243)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(138, 70)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(261, 27)
        Me.txtNama.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.baju)
        Me.GroupBox1.Controls.Add(Me.sepatu)
        Me.GroupBox1.Font = New System.Drawing.Font("Visby Round CF Heavy", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(138, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 37)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'baju
        '
        Me.baju.AutoSize = True
        Me.baju.Font = New System.Drawing.Font("Visby Round CF Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baju.Location = New System.Drawing.Point(125, 10)
        Me.baju.Name = "baju"
        Me.baju.Size = New System.Drawing.Size(60, 22)
        Me.baju.TabIndex = 19
        Me.baju.TabStop = True
        Me.baju.Text = "baju"
        Me.baju.UseVisualStyleBackColor = True
        '
        'sepatu
        '
        Me.sepatu.AutoSize = True
        Me.sepatu.Font = New System.Drawing.Font("Visby Round CF Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepatu.Location = New System.Drawing.Point(24, 10)
        Me.sepatu.Name = "sepatu"
        Me.sepatu.Size = New System.Drawing.Size(78, 22)
        Me.sepatu.TabIndex = 18
        Me.sepatu.TabStop = True
        Me.sepatu.Text = "sepatu"
        Me.sepatu.UseVisualStyleBackColor = True
        '
        'btnPilihGambar
        '
        Me.btnPilihGambar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPilihGambar.Font = New System.Drawing.Font("Visby Round CF Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilihGambar.ForeColor = System.Drawing.Color.White
        Me.btnPilihGambar.Image = Global.K7_B1.My.Resources.Resources.gallery
        Me.btnPilihGambar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPilihGambar.Location = New System.Drawing.Point(452, 328)
        Me.btnPilihGambar.Name = "btnPilihGambar"
        Me.btnPilihGambar.Size = New System.Drawing.Size(288, 67)
        Me.btnPilihGambar.TabIndex = 56
        Me.btnPilihGambar.Text = "Browse Image"
        Me.btnPilihGambar.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.label1.Font = New System.Drawing.Font("Visby Round CF Bold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(31, 70)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(69, 20)
        Me.label1.TabIndex = 39
        Me.label1.Text = "Nama :"
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Location = New System.Drawing.Point(138, 372)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(261, 27)
        Me.txtStok.TabIndex = 50
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("Visby Round CF Bold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(31, 122)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 20)
        Me.label2.TabIndex = 40
        Me.label2.Text = "Jenis :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Visby Round CF Bold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(31, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Stok :"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.label3.Font = New System.Drawing.Font("Visby Round CF Bold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(31, 175)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(69, 20)
        Me.label3.TabIndex = 41
        Me.label3.Text = "Harga :"
        '
        'txtMadeIn
        '
        Me.txtMadeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMadeIn.Location = New System.Drawing.Point(138, 270)
        Me.txtMadeIn.Name = "txtMadeIn"
        Me.txtMadeIn.Size = New System.Drawing.Size(261, 27)
        Me.txtMadeIn.TabIndex = 48
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(138, 175)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(261, 27)
        Me.txtHarga.TabIndex = 43
        '
        'txtMerek
        '
        Me.txtMerek.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMerek.Location = New System.Drawing.Point(138, 221)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(261, 27)
        Me.txtMerek.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Visby Round CF Bold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(31, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Merk :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Visby Round CF Bold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Kualitas :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Visby Round CF Bold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(31, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Made In :"
        '
        'ubahProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 623)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ubahProduk"
        Me.Text = "ubahProduk"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbKualitas As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNama As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents baju As RadioButton
    Friend WithEvents sepatu As RadioButton
    Friend WithEvents btnPilihGambar As Button
    Friend WithEvents label1 As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents txtMadeIn As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtMerek As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
