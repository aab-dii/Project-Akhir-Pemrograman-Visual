Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2_Click(Label2, EventArgs.Empty)
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        resetPanel()
        childform(dashboard)
        Panel3.BackColor = Color.Red
    End Sub
    Sub childform(ByVal panel As Form)
        Panel7.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel7.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        resetPanel()
        childform(produk)
        Panel4.BackColor = Color.Red
    End Sub

    Private Sub resetPanel()
        Panel3.BackColor = Color.Transparent
        Panel4.BackColor = Color.Transparent
    End Sub

 
End Class
