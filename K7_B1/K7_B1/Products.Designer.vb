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
        Me.SuspendLayout()
        '
        'PanelProduk
        '
        Me.PanelProduk.Location = New System.Drawing.Point(12, 13)
        Me.PanelProduk.Name = "PanelProduk"
        Me.PanelProduk.Size = New System.Drawing.Size(851, 446)
        Me.PanelProduk.TabIndex = 0
        Me.PanelProduk.WrapContents = False
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 467)
        Me.Controls.Add(Me.PanelProduk)
        Me.Name = "Products"
        Me.Text = "Products"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelProduk As System.Windows.Forms.FlowLayoutPanel
End Class
