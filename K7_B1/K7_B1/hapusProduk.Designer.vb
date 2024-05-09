<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class produk2
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
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbKualitas = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.baju = New System.Windows.Forms.RadioButton()
        Me.sepatu = New System.Windows.Forms.RadioButton()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMadeIn = New System.Windows.Forms.TextBox()
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(47, 559)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(103, 42)
        Me.btnHapus.TabIndex = 17
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(192, 559)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(103, 42)
        Me.btnUbah.TabIndex = 18
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(330, 559)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(103, 42)
        Me.btnBatal.TabIndex = 19
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(155, 88)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(197, 22)
        Me.txtId.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Id :"
        '
        'cbKualitas
        '
        Me.cbKualitas.FormattingEnabled = True
        Me.cbKualitas.Items.AddRange(New Object() {"Bagus", "Jelek"})
        Me.cbKualitas.Location = New System.Drawing.Point(155, 393)
        Me.cbKualitas.Name = "cbKualitas"
        Me.cbKualitas.Size = New System.Drawing.Size(197, 24)
        Me.cbKualitas.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.baju)
        Me.GroupBox1.Controls.Add(Me.sepatu)
        Me.GroupBox1.Location = New System.Drawing.Point(148, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 37)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'baju
        '
        Me.baju.AutoSize = True
        Me.baju.Location = New System.Drawing.Point(125, 10)
        Me.baju.Name = "baju"
        Me.baju.Size = New System.Drawing.Size(56, 21)
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
        Me.sepatu.Size = New System.Drawing.Size(72, 21)
        Me.sepatu.TabIndex = 18
        Me.sepatu.TabStop = True
        Me.sepatu.Text = "sepatu"
        Me.sepatu.UseVisualStyleBackColor = True
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(155, 439)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(197, 22)
        Me.txtStok.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 439)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Stok :"
        '
        'txtMadeIn
        '
        Me.txtMadeIn.Location = New System.Drawing.Point(155, 337)
        Me.txtMadeIn.Name = "txtMadeIn"
        Me.txtMadeIn.Size = New System.Drawing.Size(197, 22)
        Me.txtMadeIn.TabIndex = 31
        '
        'txtMerek
        '
        Me.txtMerek.Location = New System.Drawing.Point(155, 288)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(197, 22)
        Me.txtMerek.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 393)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Kualitas :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Made In :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Merk :"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(155, 242)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(197, 22)
        Me.txtHarga.TabIndex = 26
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(155, 137)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(197, 22)
        Me.txtNama.TabIndex = 25
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(48, 242)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(55, 17)
        Me.label3.TabIndex = 24
        Me.label3.Text = "Harga :"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(48, 189)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(49, 17)
        Me.label2.TabIndex = 23
        Me.label2.Text = "Jenis :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Nama :"
        '
        'produk2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 682)
        Me.Controls.Add(Me.cbKualitas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMadeIn)
        Me.Controls.Add(Me.txtMerek)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnHapus)
        Me.Name = "produk2"
        Me.Text = "produk2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbKualitas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents baju As System.Windows.Forms.RadioButton
    Friend WithEvents sepatu As System.Windows.Forms.RadioButton
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMadeIn As System.Windows.Forms.TextBox
    Friend WithEvents txtMerek As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
