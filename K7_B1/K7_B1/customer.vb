Public Class customer
    Dim namacustomer = LoginPage.user
    Sub childform(ByVal panel As Form)
        Panel4.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel4.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbnamacustomer.Text = namacustomer
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        lblHeaderMenu.Text = "Cart"
        childform(Cart)
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        lblHeaderMenu.Text = "Products"
        childform(Products)
    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Kode untuk event klik tombol Logout
        Form1.Show()
        Me.Hide()
    End Sub
End Class