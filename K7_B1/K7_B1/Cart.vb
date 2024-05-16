Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Cart
    Private countProduct As Integer = 0

    Public Sub Tampil()
        ' Kosongkan FlowLayoutPanel sebelum memuat data baru
        PanelProduk.Controls.Clear()
        PanelProduk.AutoScroll = True ' Mengaktifkan scroll bar
        PanelProduk.FlowDirection = FlowDirection.TopDown ' Mengatur flow direction ke vertikal

        Try
            ' Buka koneksi jika belum terbuka
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If

            ' Lakukan koneksi ke database dan eksekusi query untuk mengambil data produk
            Dim query As String = "SELECT * FROM tbproduk"
            Dim cmd As New MySqlCommand(query, CONN)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Loop melalui setiap baris data dan tambahkan ke dalam FlowLayoutPanel
            While reader.Read()
                Dim panelProdukItem As New Panel()
                panelProdukItem.BackColor = Color.White
                panelProdukItem.BorderStyle = BorderStyle.FixedSingle
                panelProdukItem.Size = New Size(300, 150)
                panelProdukItem.Margin = New Padding(10)

                ' Tambahkan label untuk menampilkan informasi produk
                Dim labelNama As New Label()
                labelNama.Text = reader("nama").ToString()
                labelNama.AutoSize = True
                labelNama.Location = New Point(10, 10)

                Dim labelHarga As New Label()
                labelHarga.Text = "Harga: " & reader("harga").ToString()
                labelHarga.AutoSize = True
                labelHarga.Location = New Point(10, 30)

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
                pictureBox.Location = New Point(150, 10)

                ' Tambahkan tombol hapus
                Dim produkDel As New Button()
                produkDel.Text = "Hapus"
                produkDel.Tag = reader("idProduk").ToString() ' Simpan ID produk di Tag untuk referensi nanti
                produkDel.Size = New Size(75, 30)
                produkDel.Location = New Point(200, 10)
                AddHandler produkDel.Click, AddressOf ProdukDel_Click

                ' Tambahkan tombol ubah
                Dim produkUbah As New Button()
                produkUbah.Text = "Ubah"
                produkUbah.Tag = reader("idProduk").ToString() ' Simpan ID produk di Tag untuk referensi nanti
                produkUbah.Size = New Size(75, 30)
                produkUbah.Location = New Point(200, 50)
                AddHandler produkUbah.Click, AddressOf ProdukUbah_Click

                ' Tambahkan kontrol ke dalam panel produk
                panelProdukItem.Controls.Add(produkDel)
                panelProdukItem.Controls.Add(produkUbah)
                panelProdukItem.Controls.Add(pictureBox)
                panelProdukItem.Controls.Add(labelHarga)
                panelProdukItem.Controls.Add(labelNama)

                ' Tambahkan panel produk ke dalam FlowLayoutPanel
                panelProduk.Controls.Add(panelProdukItem)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Tutup koneksi setelah selesai
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub


End Class
