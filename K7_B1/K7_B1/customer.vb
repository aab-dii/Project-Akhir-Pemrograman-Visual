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
        lblHeaderMenu.Text = "Products"
        childform(Products)
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs)
        lblHeaderMenu.Text = "Cart"
        childform(Cart)
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs)
        lblHeaderMenu.Text = "Products"
        childform(Products)
    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs)
        ' Kode untuk event klik tombol Logout
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs)
        lblHeaderMenu.Text = "History Order"
        childform(Riwayatuser)
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        lblHeaderMenu.Text = "Profile"
        childform(Profile)
    End Sub
End Class