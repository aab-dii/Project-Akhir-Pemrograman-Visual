Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Products
    Private countProduct As Integer = 0

    Public Sub Tampil()
        ' Kosongkan FlowLayoutPanel sebelum memuat data baru
        PanelProduk.Controls.Clear()
        PanelProduk.AutoScroll = True ' Mengaktifkan scroll bar
        PanelProduk.FlowDirection = FlowDirection.TopDown ' Mengatur flow direction ke vertikal

        Try
            ' Buka koneksi jika belum terbuka

            ' Lakukan koneksi ke database dan eksekusi query untuk mengambil data produk
            Dim query As String = "SELECT * FROM tbproduk"
            Dim cmd As New MySqlCommand(query, CONN)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Loop melalui setiap baris data dan tambahkan ke dalam FlowLayoutPanel
            While reader.Read()
                Dim panelProdukItem As New Panel()
                panelProdukItem.BackColor = Color.White
                panelProdukItem.BorderStyle = BorderStyle.FixedSingle
                panelProdukItem.Size = New Size(400, 150)
                panelProdukItem.Margin = New Padding(10)

                ' Tambahkan label untuk menampilkan informasi produk
                Dim labelNama As New Label()
                labelNama.Text = "Nama: " & reader("nama").ToString()
                labelNama.AutoSize = True
                labelNama.Location = New Point(150, 10)

                Dim labelHarga As New Label()
                labelHarga.Text = "Harga: " & reader("harga").ToString()
                labelHarga.AutoSize = True
                labelHarga.Location = New Point(150, 30)

                ' Tambahkan PictureBox untuk menampilkan gambar
                Dim pictureBox As New PictureBox()
                If Not IsDBNull(reader("gambar")) AndAlso reader("gambar").ToString() <> "" Then
                    ' Dapatkan path relatif dari database
                    Dim gambarPathRelatif As String = reader("gambar").ToString()

                    ' Gabungkan path relatif dengan direktori kerja proyek
                    Dim gambarPathAbsolut As String = Path.Combine(Application.StartupPath, gambarPathRelatif)

                    ' Tampilkan gambar jika file gambar ada
                    If File.Exists(gambarPathAbsolut) Then
                        pictureBox.Image = Image.FromFile(gambarPathAbsolut)
                    End If
                End If
                pictureBox.Size = New Size(100, 100)
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom
                pictureBox.Location = New Point(10, 10)

                ' Tambahkan tombol hapus
                Dim produkBeli As New Button()
                produkBeli.Text = "Beli"
                produkBeli.Tag = reader("idProduk").ToString() ' Simpan ID produk di Tag untuk referensi nanti
                produkBeli.Size = New Size(75, 30)
                produkBeli.Location = New Point(300, 10)
                AddHandler produkBeli.Click, AddressOf ProdukBeli_Click

                ' Tambahkan tombol ubah
                Dim produkKeranjang As New Button()
                produkKeranjang.Text = "Keranjang"
                produkKeranjang.Tag = reader("idProduk").ToString() ' Simpan ID produk di Tag untuk referensi nanti
                produkKeranjang.Size = New Size(75, 30)
                produkKeranjang.Location = New Point(300, 50)
                AddHandler produkKeranjang.Click, AddressOf ProdukKeranjang_Click

                ' Tambahkan kontrol ke dalam panel produk
                panelProdukItem.Controls.Add(produkBeli)
                panelProdukItem.Controls.Add(produkKeranjang)
                panelProdukItem.Controls.Add(pictureBox)
                panelProdukItem.Controls.Add(labelHarga)
                panelProdukItem.Controls.Add(labelNama)

                ' Tambahkan panel produk ke dalam FlowLayoutPanel
                PanelProduk.Controls.Add(panelProdukItem)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Tutup koneksi setelah selesai
        End Try
    End Sub

    Private Sub ProdukBeli_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException
    End Sub

    Private Sub ProdukKeranjang_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException
    End Sub
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Tampil()
    End Sub
End Class