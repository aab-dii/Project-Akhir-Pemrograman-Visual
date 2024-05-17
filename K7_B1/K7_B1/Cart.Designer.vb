<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cart))
        Me.PanelProduk = New System.Windows.Forms.FlowLayoutPanel()
        Me.Chekout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'PanelProduk
        '
        Me.PanelProduk.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.PanelProduk.Location = New System.Drawing.Point(25, 28)
        Me.PanelProduk.Name = "PanelProduk"
        Me.PanelProduk.Size = New System.Drawing.Size(737, 529)
        Me.PanelProduk.TabIndex = 0
        Me.PanelProduk.WrapContents = False
        '
        'Chekout
        '
        Me.Chekout.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Chekout.Font = New System.Drawing.Font("Visby Round CF Heavy", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chekout.ForeColor = System.Drawing.Color.White
        Me.Chekout.Image = Global.K7_B1.My.Resources.Resources.bayar
        Me.Chekout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Chekout.Location = New System.Drawing.Point(580, 574)
        Me.Chekout.Name = "Chekout"
        Me.Chekout.Size = New System.Drawing.Size(182, 38)
        Me.Chekout.TabIndex = 1
        Me.Chekout.Text = "   Checkout"
        Me.Chekout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Chekout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 587)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Checkout: -"
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
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BackgroundImage = Global.K7_B1.My.Resources.Resources.hexafix7
        Me.ClientSize = New System.Drawing.Size(799, 641)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chekout)
        Me.Controls.Add(Me.PanelProduk)
        Me.Name = "Cart"
        Me.Text = "Cart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelProduk As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Chekout As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
