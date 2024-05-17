<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Me.PanelProduk = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtCariProduk = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelProduk
        '
        Me.PanelProduk.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.PanelProduk.Location = New System.Drawing.Point(12, 95)
        Me.PanelProduk.Name = "PanelProduk"
        Me.PanelProduk.Size = New System.Drawing.Size(851, 446)
        Me.PanelProduk.TabIndex = 0
        Me.PanelProduk.WrapContents = False
        '
        'txtCariProduk
        '
        Me.txtCariProduk.Location = New System.Drawing.Point(109, 35)
        Me.txtCariProduk.Name = "txtCariProduk"
        Me.txtCariProduk.Size = New System.Drawing.Size(497, 22)
        Me.txtCariProduk.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.K7_B1.My.Resources.Resources.search
        Me.PictureBox2.Location = New System.Drawing.Point(71, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BackgroundImage = Global.K7_B1.My.Resources.Resources.hexafix8
        Me.ClientSize = New System.Drawing.Size(870, 553)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtCariProduk)
        Me.Controls.Add(Me.PanelProduk)
        Me.Name = "Products"
        Me.Text = "Products"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelProduk As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtCariProduk As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
