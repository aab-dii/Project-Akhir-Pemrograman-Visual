Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Cart
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Memuat_Panel()
    End Sub

    Private Sub Memuat_Panel()
        Try
            Dim query As String = "SELECT * FROM tbproduk"
            Dim cmd As New MySqlCommand(query, CONN)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            Dim verticalPanel As New Panel()
            verticalPanel.AutoScroll = True
            verticalPanel.Dock = DockStyle.Fill
            Me.Controls.Add(verticalPanel)

            While reader.Read()
                Dim itemPanel As New Panel()
                itemPanel.Dock = DockStyle.Top
                itemPanel.Height = 160 ' Sesuaikan dengan ukuran item

                ' Buat TableLayoutPanel untuk menempatkan gambar dan tombol
                Dim tablePanel As New TableLayoutPanel()
                tablePanel.Dock = DockStyle.Fill
                tablePanel.ColumnCount = 3 ' 3 kolom untuk gambar, detail, dan tombol
                tablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30)) ' Kolom pertama (gambar) mengambil 30% lebar
                tablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50)) ' Kolom kedua (detail) mengambil 50% lebar
                tablePanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20)) ' Kolom ketiga (tombol) mengambil 20% lebar
                itemPanel.Controls.Add(tablePanel)

                ' PictureBox untuk gambar
                Dim pictureBox As New PictureBox()
                If Not IsDBNull(reader("gambar")) AndAlso reader("gambar").ToString() <> "" Then
                    Dim gambarPathRelatif As String = reader("gambar").ToString()
                    Dim gambarPathAbsolut As String = Path.Combine(Application.StartupPath, gambarPathRelatif)
                    If File.Exists(gambarPathAbsolut) Then
                        pictureBox.Image = Image.FromFile(gambarPathAbsolut)
                    End If
                End If
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                pictureBox.Dock = DockStyle.Fill
                pictureBox.Height = 120 ' Ukuran gambar lebih besar
                tablePanel.Controls.Add(pictureBox, 0, 0)

                ' Label untuk nama item
                Dim labelName As New Label()
                labelName.Text = reader("nama").ToString()
                labelName.Dock = DockStyle.Fill
                labelName.TextAlign = ContentAlignment.MiddleCenter ' Tengah
                tablePanel.Controls.Add(labelName, 1, 0)

                ' Label untuk harga
                Dim labelPrice As New Label()
                labelPrice.Text = "Price: " & reader("harga").ToString()
                labelPrice.Dock = DockStyle.Fill
                labelPrice.TextAlign = ContentAlignment.MiddleCenter ' Tengah
                tablePanel.Controls.Add(labelPrice, 1, 1)

                ' Button untuk detail
                Dim btnDetail As New Button()
                btnDetail.Text = "Detail"
                btnDetail.Anchor = AnchorStyles.None ' Tombol akan di-anchor di tengah parent-nya
                btnDetail.AutoSize = True ' Ukuran tombol akan menyesuaikan dengan teksnya
                btnDetail.FlatStyle = FlatStyle.Flat ' Menghilangkan efek border
                btnDetail.BackColor = Color.LightGray ' Warna latar belakang
                tablePanel.Controls.Add(btnDetail, 2, 0)


                ' Button untuk membeli
                Dim btnBuy As New Button()
                btnBuy.Text = "Buy"
                btnBuy.Anchor = AnchorStyles.None ' Tombol akan di-anchor di tengah parent-nya
                btnBuy.AutoSize = True ' Ukuran tombol akan menyesuaikan dengan teksnya
                btnBuy.FlatStyle = FlatStyle.Flat ' Menghilangkan efek border
                btnBuy.BackColor = Color.LightGray ' Warna latar belakang
                tablePanel.Controls.Add(btnBuy, 2, 1)

                ' Tambahkan panel item ke dalam panel vertikal
                verticalPanel.Controls.Add(itemPanel)
            End While
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
