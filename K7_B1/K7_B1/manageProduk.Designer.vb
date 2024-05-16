<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageProduk
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
        Me.panelProduk = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'panelProduk
        '
        Me.panelProduk.AllowDrop = True
        Me.panelProduk.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.panelProduk.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.panelProduk.Location = New System.Drawing.Point(108, 59)
        Me.panelProduk.Name = "panelProduk"
        Me.panelProduk.Size = New System.Drawing.Size(841, 423)
        Me.panelProduk.TabIndex = 0
        Me.panelProduk.WrapContents = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Red
        Me.btnBatal.Font = New System.Drawing.Font("Visby Round CF Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Image = Global.K7_B1.My.Resources.Resources.Cancel
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(128, 498)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(378, 45)
        Me.btnBatal.TabIndex = 56
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTambah.Font = New System.Drawing.Font("Visby Round CF Extra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Image = Global.K7_B1.My.Resources.Resources.plus
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(560, 498)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(378, 45)
        Me.btnTambah.TabIndex = 55
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'manageProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BackgroundImage = Global.K7_B1.My.Resources.Resources.hexafix4
        Me.ClientSize = New System.Drawing.Size(1073, 570)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.panelProduk)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "manageProduk"
        Me.Text = "manageProduk"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelProduk As FlowLayoutPanel
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTambah As Button
End Class
