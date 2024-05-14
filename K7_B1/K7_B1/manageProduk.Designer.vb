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
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'panelProduk
        '
        Me.panelProduk.AllowDrop = True
        Me.panelProduk.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.panelProduk.Location = New System.Drawing.Point(108, 59)
        Me.panelProduk.Name = "panelProduk"
        Me.panelProduk.Size = New System.Drawing.Size(841, 423)
        Me.panelProduk.TabIndex = 0
        Me.panelProduk.WrapContents = False
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(368, 514)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 1
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(558, 518)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'manageProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 570)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.panelProduk)
        Me.Name = "manageProduk"
        Me.Text = "manageProduk"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelProduk As FlowLayoutPanel
    Friend WithEvents btnTambah As Button
    Friend WithEvents Button2 As Button
End Class
