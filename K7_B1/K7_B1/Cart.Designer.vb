﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.SuspendLayout()
        '
        'PanelProduk
        '
        Me.PanelProduk.Location = New System.Drawing.Point(25, 28)
        Me.PanelProduk.Name = "PanelProduk"
        Me.PanelProduk.Size = New System.Drawing.Size(1065, 665)
        Me.PanelProduk.TabIndex = 0
        Me.PanelProduk.WrapContents = False
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 705)
        Me.Controls.Add(Me.PanelProduk)
        Me.Name = "Cart"
        Me.Text = "Cart"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelProduk As System.Windows.Forms.FlowLayoutPanel
End Class