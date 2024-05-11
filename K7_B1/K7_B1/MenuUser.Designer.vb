<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUser
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
        Me.btnLihatBarang = New System.Windows.Forms.Button()
        Me.btnKeranjang = New System.Windows.Forms.Button()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLihatBarang
        '
        Me.btnLihatBarang.Location = New System.Drawing.Point(418, 266)
        Me.btnLihatBarang.Name = "btnLihatBarang"
        Me.btnLihatBarang.Size = New System.Drawing.Size(75, 23)
        Me.btnLihatBarang.TabIndex = 0
        Me.btnLihatBarang.Text = "Lihat Barang"
        Me.btnLihatBarang.UseVisualStyleBackColor = True
        '
        'btnKeranjang
        '
        Me.btnKeranjang.Location = New System.Drawing.Point(418, 367)
        Me.btnKeranjang.Name = "btnKeranjang"
        Me.btnKeranjang.Size = New System.Drawing.Size(75, 23)
        Me.btnKeranjang.TabIndex = 1
        Me.btnKeranjang.Text = "Keranjang"
        Me.btnKeranjang.UseVisualStyleBackColor = True
        '
        'btnBayar
        '
        Me.btnBayar.Location = New System.Drawing.Point(418, 432)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(75, 23)
        Me.btnBayar.TabIndex = 2
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = True
        '
        'MenuUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 605)
        Me.Controls.Add(Me.btnBayar)
        Me.Controls.Add(Me.btnKeranjang)
        Me.Controls.Add(Me.btnLihatBarang)
        Me.Name = "MenuUser"
        Me.Text = "MenuUser"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLihatBarang As System.Windows.Forms.Button
    Friend WithEvents btnKeranjang As System.Windows.Forms.Button
    Friend WithEvents btnBayar As System.Windows.Forms.Button
End Class
