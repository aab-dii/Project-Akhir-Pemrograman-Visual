<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblHeaderMenu = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnManageOrders = New System.Windows.Forms.Button()
        Me.btnManageProducts = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnManageOrders)
        Me.Panel1.Controls.Add(Me.btnManageProducts)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(314, 741)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblCustomer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(314, 100)
        Me.Panel2.TabIndex = 0
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Visby Round CF Heavy", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.ForeColor = System.Drawing.Color.White
        Me.lblCustomer.Location = New System.Drawing.Point(71, 26)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(201, 28)
        Me.lblCustomer.TabIndex = 7
        Me.lblCustomer.Text = "Hello Customer !"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblHeaderMenu)
        Me.Panel3.Location = New System.Drawing.Point(311, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1031, 100)
        Me.Panel3.TabIndex = 8
        '
        'lblHeaderMenu
        '
        Me.lblHeaderMenu.AutoSize = True
        Me.lblHeaderMenu.Font = New System.Drawing.Font("Visby Round CF Heavy", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderMenu.ForeColor = System.Drawing.Color.White
        Me.lblHeaderMenu.Location = New System.Drawing.Point(390, 26)
        Me.lblHeaderMenu.Name = "lblHeaderMenu"
        Me.lblHeaderMenu.Size = New System.Drawing.Size(218, 28)
        Me.lblHeaderMenu.TabIndex = 8
        Me.lblHeaderMenu.Text = "Dashboard Admin"
        Me.lblHeaderMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Visby Round CF Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.K7_B1.My.Resources.Resources.switch1
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 274)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(314, 87)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "    Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnManageOrders
        '
        Me.btnManageOrders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManageOrders.FlatAppearance.BorderSize = 0
        Me.btnManageOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageOrders.Font = New System.Drawing.Font("Visby Round CF Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageOrders.ForeColor = System.Drawing.Color.White
        Me.btnManageOrders.Image = Global.K7_B1.My.Resources.Resources.shopping_cart__2_
        Me.btnManageOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageOrders.Location = New System.Drawing.Point(0, 187)
        Me.btnManageOrders.Name = "btnManageOrders"
        Me.btnManageOrders.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnManageOrders.Size = New System.Drawing.Size(314, 87)
        Me.btnManageOrders.TabIndex = 2
        Me.btnManageOrders.Text = "    Cart"
        Me.btnManageOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManageOrders.UseVisualStyleBackColor = True
        '
        'btnManageProducts
        '
        Me.btnManageProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManageProducts.FlatAppearance.BorderSize = 0
        Me.btnManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageProducts.Font = New System.Drawing.Font("Visby Round CF Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageProducts.ForeColor = System.Drawing.Color.White
        Me.btnManageProducts.Image = Global.K7_B1.My.Resources.Resources.buy
        Me.btnManageProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageProducts.Location = New System.Drawing.Point(0, 100)
        Me.btnManageProducts.Name = "btnManageProducts"
        Me.btnManageProducts.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnManageProducts.Size = New System.Drawing.Size(314, 87)
        Me.btnManageProducts.TabIndex = 1
        Me.btnManageProducts.Text = "    Products"
        Me.btnManageProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManageProducts.UseVisualStyleBackColor = True
        '
        'customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 742)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "customer"
        Me.Text = "customer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnManageOrders As Button
    Friend WithEvents btnManageProducts As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCustomer As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblHeaderMenu As Label
End Class
