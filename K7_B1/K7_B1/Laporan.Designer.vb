<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCetakLaporan = New System.Windows.Forms.Button()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.produk, Me.jumlah, Me.tanggal})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(114, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(804, 317)
        Me.DataGridView1.TabIndex = 1
        '
        'btnCetakLaporan
        '
        Me.btnCetakLaporan.Location = New System.Drawing.Point(457, 427)
        Me.btnCetakLaporan.Name = "btnCetakLaporan"
        Me.btnCetakLaporan.Size = New System.Drawing.Size(105, 47)
        Me.btnCetakLaporan.TabIndex = 2
        Me.btnCetakLaporan.Text = "Cetak"
        Me.btnCetakLaporan.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Location = New System.Drawing.Point(44, 42)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(8, 8)
        Me.PictureBoxLogo.TabIndex = 3
        Me.PictureBoxLogo.TabStop = False
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 75
        '
        'produk
        '
        Me.produk.HeaderText = "Nama Produk"
        Me.produk.MinimumWidth = 15
        Me.produk.Name = "produk"
        Me.produk.Width = 210
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.MinimumWidth = 6
        Me.jumlah.Name = "jumlah"
        '
        'tanggal
        '
        Me.tanggal.HeaderText = "Tannggal"
        Me.tanggal.MinimumWidth = 15
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Width = 200
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BackgroundImage = Global.K7_B1.My.Resources.Resources.hexafix3
        Me.ClientSize = New System.Drawing.Size(1027, 514)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.btnCetakLaporan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCetakLaporan As Button
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents produk As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents tanggal As DataGridViewTextBoxColumn
End Class
