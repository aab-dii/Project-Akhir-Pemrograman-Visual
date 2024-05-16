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
        Me.PanelProduk.Location = New System.Drawing.Point(25, 28)
        Me.PanelProduk.Name = "PanelProduk"
        Me.PanelProduk.Size = New System.Drawing.Size(737, 529)
        Me.PanelProduk.TabIndex = 0
        Me.PanelProduk.WrapContents = False
        '
        'Chekout
        '
        Me.Chekout.Location = New System.Drawing.Point(54, 575)
        Me.Chekout.Name = "Chekout"
        Me.Chekout.Size = New System.Drawing.Size(99, 38)
        Me.Chekout.TabIndex = 1
        Me.Chekout.Text = "Chekout ALL"
        Me.Chekout.UseVisualStyleBackColor = True
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
