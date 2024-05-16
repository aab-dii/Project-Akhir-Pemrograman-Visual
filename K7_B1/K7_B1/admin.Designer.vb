<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnInvoice = New System.Windows.Forms.Button()
        Me.btnManageOrders = New System.Windows.Forms.Button()
        Me.btnManageProducts = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblHeaderMenu = New System.Windows.Forms.Label()
        Me.panelOutput = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnInvoice)
        Me.Panel1.Controls.Add(Me.btnManageOrders)
        Me.Panel1.Controls.Add(Me.btnManageProducts)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 741)
        Me.Panel1.TabIndex = 5
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.K7_B1.My.Resources.Resources.switch1
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 448)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(316, 87)
        Me.btnLogout.TabIndex = 12
        Me.btnLogout.Text = "    Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnInvoice
        '
        Me.btnInvoice.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInvoice.FlatAppearance.BorderSize = 0
        Me.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvoice.ForeColor = System.Drawing.Color.White
        Me.btnInvoice.Image = Global.K7_B1.My.Resources.Resources.slip
        Me.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInvoice.Location = New System.Drawing.Point(0, 361)
        Me.btnInvoice.Name = "btnInvoice"
        Me.btnInvoice.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnInvoice.Size = New System.Drawing.Size(316, 87)
        Me.btnInvoice.TabIndex = 11
        Me.btnInvoice.Text = "    Invoice"
        Me.btnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInvoice.UseVisualStyleBackColor = True
        '
        'btnManageOrders
        '
        Me.btnManageOrders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManageOrders.FlatAppearance.BorderSize = 0
        Me.btnManageOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageOrders.ForeColor = System.Drawing.Color.White
        Me.btnManageOrders.Image = Global.K7_B1.My.Resources.Resources.checklist
        Me.btnManageOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageOrders.Location = New System.Drawing.Point(0, 274)
        Me.btnManageOrders.Name = "btnManageOrders"
        Me.btnManageOrders.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnManageOrders.Size = New System.Drawing.Size(316, 87)
        Me.btnManageOrders.TabIndex = 10
        Me.btnManageOrders.Text = "    Manage Orders"
        Me.btnManageOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManageOrders.UseVisualStyleBackColor = True
        '
        'btnManageProducts
        '
        Me.btnManageProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnManageProducts.FlatAppearance.BorderSize = 0
        Me.btnManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageProducts.ForeColor = System.Drawing.Color.White
        Me.btnManageProducts.Image = Global.K7_B1.My.Resources.Resources.delivery_box1
        Me.btnManageProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageProducts.Location = New System.Drawing.Point(0, 187)
        Me.btnManageProducts.Name = "btnManageProducts"
        Me.btnManageProducts.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnManageProducts.Size = New System.Drawing.Size(316, 87)
        Me.btnManageProducts.TabIndex = 5
        Me.btnManageProducts.Text = "    Manage Products"
        Me.btnManageProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManageProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManageProducts.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = Global.K7_B1.My.Resources.Resources.dashboard
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 100)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(316, 87)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "    Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(316, 100)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(71, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Hello Admin !"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblHeaderMenu)
        Me.Panel3.Location = New System.Drawing.Point(314, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1031, 100)
        Me.Panel3.TabIndex = 6
        '
        'lblHeaderMenu
        '
        Me.lblHeaderMenu.AutoSize = True
        Me.lblHeaderMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderMenu.ForeColor = System.Drawing.Color.White
        Me.lblHeaderMenu.Location = New System.Drawing.Point(390, 37)
        Me.lblHeaderMenu.Name = "lblHeaderMenu"
        Me.lblHeaderMenu.Size = New System.Drawing.Size(0, 29)
        Me.lblHeaderMenu.TabIndex = 8
        Me.lblHeaderMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'panelOutput
        '
        Me.panelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelOutput.Location = New System.Drawing.Point(314, 100)
        Me.panelOutput.Name = "panelOutput"
        Me.panelOutput.Size = New System.Drawing.Size(1031, 638)
        Me.panelOutput.TabIndex = 0
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 738)
        Me.Controls.Add(Me.panelOutput)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "admin"
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHeaderMenu As Label
    Friend WithEvents panelOutput As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnInvoice As Button
    Friend WithEvents btnManageOrders As Button
    Friend WithEvents btnManageProducts As Button
End Class
