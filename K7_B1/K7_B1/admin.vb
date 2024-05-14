Public Class admin

    Sub childform(ByVal panel As Form)
        panelOutput.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        panelOutput.Controls.Add(panel)
        panel.Show()

    End Sub
    ' Event handler untuk tombol Manage Products
    Private Sub btnManageProducts_Click(sender As Object, e As EventArgs) Handles btnManageProducts.Click
        ' Kode untuk event klik tombol Manage Products
        lblHeaderMenu.Text = "Manage Products"
        childform(manageProduk)
    End Sub

    ' Event handler untuk tombol Manage Orders
    Private Sub btnManageOrders_Click(sender As Object, e As EventArgs) Handles btnManageOrders.Click
        ' Kode untuk event klik tombol Manage Orders
        lblHeaderMenu.Text = "Manage Orders"
    End Sub

    ' Event handler untuk tombol Invoice
    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        ' Kode untuk event klik tombol Invoice
        lblHeaderMenu.Text = "Invoice"
    End Sub

    ' Event handler untuk tombol Logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Kode untuk event klik tombol Logout
        Form1.Show()
        Me.Hide()
    End Sub

    ' Event handler untuk efek hover saat kursor masuk ke tombol Manage Products
    Private Sub btnManageProducts_MouseEnter(sender As Object, e As EventArgs) Handles btnManageProducts.MouseEnter
        btnManageProducts.BackColor = ColorTranslator.FromHtml("#B12642") ' Mengubah warna latar belakang tombol menjadi #B12642 saat kursor masuk
    End Sub

    ' Event handler untuk efek hover saat kursor keluar dari tombol Manage Products
    Private Sub btnManageProducts_MouseLeave(sender As Object, e As EventArgs) Handles btnManageProducts.MouseLeave
        btnManageProducts.BackColor = Color.Transparent ' Mengembalikan warna latar belakang tombol menjadi transparan saat kursor keluar
    End Sub

    ' Event handler untuk efek hover saat kursor masuk ke tombol Manage Orders
    Private Sub btnManageOrders_MouseEnter(sender As Object, e As EventArgs) Handles btnManageOrders.MouseEnter
        btnManageOrders.BackColor = ColorTranslator.FromHtml("#B12642") ' Mengubah warna latar belakang tombol menjadi #B12642 saat kursor masuk
    End Sub

    ' Event handler untuk efek hover saat kursor keluar dari tombol Manage Orders
    Private Sub btnManageOrders_MouseLeave(sender As Object, e As EventArgs) Handles btnManageOrders.MouseLeave
        btnManageOrders.BackColor = Color.Transparent ' Mengembalikan warna latar belakang tombol menjadi transparan saat kursor keluar
    End Sub

    ' Event handler untuk efek hover saat kursor masuk ke tombol Invoice
    Private Sub btnInvoice_MouseEnter(sender As Object, e As EventArgs) Handles btnInvoice.MouseEnter
        btnInvoice.BackColor = ColorTranslator.FromHtml("#B12642") ' Mengubah warna latar belakang tombol menjadi #B12642 saat kursor masuk
    End Sub

    ' Event handler untuk efek hover saat kursor keluar dari tombol Invoice
    Private Sub btnInvoice_MouseLeave(sender As Object, e As EventArgs) Handles btnInvoice.MouseLeave
        btnInvoice.BackColor = Color.Transparent ' Mengembalikan warna latar belakang tombol menjadi transparan saat kursor keluar
    End Sub

    ' Event handler untuk efek hover saat kursor masuk ke tombol Logout
    Private Sub btnLogout_MouseEnter(sender As Object, e As EventArgs) Handles btnLogout.MouseEnter
        btnLogout.BackColor = ColorTranslator.FromHtml("#B12642") ' Mengubah warna latar belakang tombol menjadi #B12642 saat kursor masuk
    End Sub

    ' Event handler untuk efek hover saat kursor keluar dari tombol Logout
    Private Sub btnLogout_MouseLeave(sender As Object, e As EventArgs) Handles btnLogout.MouseLeave
        btnLogout.BackColor = Color.Transparent ' Mengembalikan warna latar belakang tombol menjadi transparan saat kursor keluar
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
