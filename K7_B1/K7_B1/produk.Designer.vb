<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class produk
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtMadeIn = New System.Windows.Forms.TextBox()
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sepatu = New System.Windows.Forms.RadioButton()
        Me.baju = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbKualitas = New System.Windows.Forms.ComboBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.merek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.madeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kualitas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(27, 76)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(53, 17)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Nama :"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(27, 128)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(49, 17)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Jenis :"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(27, 181)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(55, 17)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Harga :"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(134, 76)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(197, 22)
        Me.txtNama.TabIndex = 3
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(134, 181)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(197, 22)
        Me.txtHarga.TabIndex = 5
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(40, 475)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(103, 42)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "SImpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(197, 475)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(103, 42)
        Me.btnHapus.TabIndex = 7
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(349, 475)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 42)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama, Me.jenis, Me.harga, Me.merek, Me.madeIn, Me.kualitas, Me.stok})
        Me.DataGridView1.Location = New System.Drawing.Point(497, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(464, 240)
        Me.DataGridView1.TabIndex = 9
        '
        'txtMadeIn
        '
        Me.txtMadeIn.Location = New System.Drawing.Point(134, 276)
        Me.txtMadeIn.Name = "txtMadeIn"
        Me.txtMadeIn.Size = New System.Drawing.Size(197, 22)
        Me.txtMadeIn.TabIndex = 14
        '
        'txtMerek
        '
        Me.txtMerek.Location = New System.Drawing.Point(134, 227)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(197, 22)
        Me.txtMerek.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Kualitas :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Made In :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Merk :"
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(134, 378)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(197, 22)
        Me.txtStok.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Stok :"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.baju)
        Me.GroupBox1.Controls.Add(Me.sepatu)
        Me.GroupBox1.Location = New System.Drawing.Point(127, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 37)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'cbKualitas
        '
        Me.cbKualitas.FormattingEnabled = True
        Me.cbKualitas.Items.AddRange(New Object() {"Bagus", "Jelek"})
        Me.cbKualitas.Location = New System.Drawing.Point(134, 332)
        Me.cbKualitas.Name = "cbKualitas"
        Me.cbKualitas.Size = New System.Drawing.Size(197, 24)
        Me.cbKualitas.TabIndex = 21
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Width = 46
        '
        'nama
        '
        Me.nama.HeaderText = "Nama"
        Me.nama.Name = "nama"
        Me.nama.Width = 70
        '
        'jenis
        '
        Me.jenis.HeaderText = "Jenis"
        Me.jenis.Name = "jenis"
        Me.jenis.Width = 66
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.Width = 72
        '
        'merek
        '
        Me.merek.HeaderText = "Merek"
        Me.merek.Name = "merek"
        Me.merek.Width = 72
        '
        'madeIn
        '
        Me.madeIn.HeaderText = "Made In"
        Me.madeIn.Name = "madeIn"
        Me.madeIn.Width = 83
        '
        'kualitas
        '
        Me.kualitas.HeaderText = "Kualitas"
        Me.kualitas.Name = "kualitas"
        Me.kualitas.Width = 83
        '
        'stok
        '
        Me.stok.HeaderText = "Stok"
        Me.stok.Name = "stok"
        Me.stok.Width = 61
        '
        'produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 556)
        Me.Controls.Add(Me.cbKualitas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMadeIn)
        Me.Controls.Add(Me.txtMerek)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "produk"
        Me.Text = "produk"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtMadeIn As System.Windows.Forms.TextBox
    Friend WithEvents txtMerek As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents sepatu As System.Windows.Forms.RadioButton
    Friend WithEvents baju As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbKualitas As System.Windows.Forms.ComboBox
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents merek As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents madeIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kualitas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stok As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
