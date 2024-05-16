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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCariProduk = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PanelProduk
        '
        Me.PanelProduk.Location = New System.Drawing.Point(12, 95)
        Me.PanelProduk.Name = "PanelProduk"
        Me.PanelProduk.Size = New System.Drawing.Size(851, 446)
        Me.PanelProduk.TabIndex = 0
        Me.PanelProduk.WrapContents = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cari Produk"
        '
        'txtCariProduk
        '
        Me.txtCariProduk.Location = New System.Drawing.Point(109, 35)
        Me.txtCariProduk.Name = "txtCariProduk"
        Me.txtCariProduk.Size = New System.Drawing.Size(497, 22)
        Me.txtCariProduk.TabIndex = 3
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 553)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCariProduk)
        Me.Controls.Add(Me.PanelProduk)
        Me.Name = "Products"
        Me.Text = "Products"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelProduk As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCariProduk As System.Windows.Forms.TextBox
End Class
