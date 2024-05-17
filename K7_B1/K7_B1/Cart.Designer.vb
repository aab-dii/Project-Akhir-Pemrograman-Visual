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
        Me.PanelProduk = New System.Windows.Forms.FlowLayoutPanel()
        Me.Chekout = New System.Windows.Forms.Button()
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
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BackgroundImage = Global.K7_B1.My.Resources.Resources.hexafix7
        Me.ClientSize = New System.Drawing.Size(799, 641)
        Me.Controls.Add(Me.Chekout)
        Me.Controls.Add(Me.PanelProduk)
        Me.Name = "Cart"
        Me.Text = "Cart"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelProduk As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Chekout As System.Windows.Forms.Button
End Class
