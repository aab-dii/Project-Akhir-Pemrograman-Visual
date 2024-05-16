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

                Dim labelStok As New Label()
                labelStok.Text = "Stok: " & reader("stok").ToString()
                labelStok.AutoSize = True
                labelStok.Location = New Point(150, 50)

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
                AddHandler produkKeranjang.Click, AddressOf produkKeranjang_Click

                ' Tambahkan kontrol ke dalam panel produk
                panelProdukItem.Controls.Add(produkBeli)
                panelProdukItem.Controls.Add(produkKeranjang)
                panelProdukItem.Controls.Add(pictureBox)
                panelProdukItem.Controls.Add(labelStok)
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


    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Tampil()
    End Sub

    Private Sub txtCariProduk_TextChanged(sender As Object, e As EventArgs) Handles txtCariProduk.TextChanged
        Try
            Dim keyword As String = txtCariProduk.Text.Trim()
            Dim query As String = "SELECT * FROM tbproduk WHERE nama LIKE @keyword"
            Dim cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Kosongkan FlowLayoutPanel sebelum memuat data baru
            PanelProduk.Controls.Clear()
            PanelProduk.AutoScroll = True ' Mengaktifkan scroll bar
            PanelProduk.FlowDirection = FlowDirection.TopDown ' Mengatur flow direction ke vertikal

            ' Loop melalui setiap baris data dan tambahkan ke dalam FlowLayoutPanel
            While reader.Read()
                ' Tambahkan kode untuk menampilkan data produk seperti sebelumnya
                ' ...
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

                Dim labelStok As New Label()
                labelNama.Text = "Stok: " & reader("stok").ToString()
                labelNama.AutoSize = True
                labelNama.Location = New Point(150, 50)

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

                ' Tambahkan tombol beli
                Dim produkBeli As New Button()
                produkBeli.Text = "Beli"
                produkBeli.Tag = reader("idProduk").ToString() ' Simpan ID produk di Tag untuk referensi nanti
                produkBeli.Size = New Size(75, 30)
                produkBeli.Location = New Point(300, 10)
                AddHandler produkBeli.Click, AddressOf ProdukBeli_Click

                ' Tambahkan tombol keranjang
                Dim produkKeranjang As New Button()
                produkKeranjang.Text = "Keranjang"
                produkKeranjang.Tag = reader("idProduk") ' Simpan ID produk di Tag untuk referensi nanti
                produkKeranjang.Size = New Size(75, 30)
                produkKeranjang.Location = New Point(300, 50)
                AddHandler produkKeranjang.Click, AddressOf produkKeranjang_Click

                ' Tambahkan kontrol ke dalam panel produk
                panelProdukItem.Controls.Add(produkBeli)
                panelProdukItem.Controls.Add(produkKeranjang)
                panelProdukItem.Controls.Add(pictureBox)
                panelProdukItem.Controls.Add(labelStok)
                panelProdukItem.Controls.Add(labelHarga)
                panelProdukItem.Controls.Add(labelNama)

                ' Tambahkan panel produk ke dalam FlowLayoutPanel
                PanelProduk.Controls.Add(panelProdukItem)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ProdukBeli_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException
    End Sub

    Dim iduser As Integer
    Private Sub produkKeranjang_Click(sender As Object, e As EventArgs)
        'Throw New NotImplementedException
        iduser = LoginPage.idUser
        Dim btn As Button = CType(sender, Button)
        Dim idProduk As Integer = btn.Tag
        koneksi()

        Try
            ' Buka koneksi jika belum terbuka
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If

            ' Meminta pengguna untuk memasukkan jumlah produk
            Dim jumlahInput As String = InputBox("Masukkan jumlah produk yang akan ditambahkan ke keranjang:", "Tambahkan Produk", "1")

            ' Validasi input
            Dim jumlahProduk As Integer
            If Not Integer.TryParse(jumlahInput, jumlahProduk) OrElse jumlahProduk <= 0 Then
                MessageBox.Show("Masukkan jumlah produk yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Keluar dari sub jika input tidak valid
            End If

            MessageBox.Show("Jumlah produk: " & jumlahProduk)

            ' Cek apakah jumlah produk mencukupi
            Dim stokQuery As String = "SELECT stok FROM tbproduk WHERE idProduk = @idProduk"
            Dim stokCmd As New MySqlCommand(stokQuery, CONN)
            stokCmd.Parameters.AddWithValue("@idProduk", idProduk)
            Dim stok As Integer = Convert.ToInt32(stokCmd.ExecuteScalar())

            If jumlahProduk > stok Then
                MessageBox.Show("Stok tidak cukup untuk jumlah produk yang diminta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Keluar dari sub jika stok tidak cukup
            End If

            ' Cek apakah produk sudah ada di keranjang untuk user yang sama
            Dim checkQuery As String = "SELECT COUNT(*) FROM tbkeranjang WHERE idUser = @idUser AND idProduk = @idProduk"
            Dim checkCmd As New MySqlCommand(checkQuery, CONN)
            checkCmd.Parameters.AddWithValue("@idUser", iduser) ' Ganti dengan ID user yang sesuai
            checkCmd.Parameters.AddWithValue("@idProduk", idProduk)
            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If jumlahProduk >= 0 Then
                ' Update stok produk di tbproduk
                Dim stokBaru As Integer = stok - jumlahProduk
                Dim updateStok As String = "UPDATE tbproduk SET stok = @stokBaru WHERE idProduk = @idProduk"
                Dim updateStokCmd As New MySqlCommand(updateStok, CONN)
                updateStokCmd.Parameters.AddWithValue("@stokBaru", stokBaru)
                updateStokCmd.Parameters.AddWithValue("@idProduk", idProduk)
                updateStokCmd.ExecuteNonQuery()
            Else
                MessageBox.Show("Stok tidak mencukupi untuk jumlah produk yang diminta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Keluar dari sub jika stok tidak cukup
            End If

            If count > 0 Then
                MessageBox.Show("sql 2")
                ' Produk sudah ada di keranjang, tambahkan jumlahnya
                Dim updateQuery As String = "UPDATE tbkeranjang SET jumlah = jumlah + @jumlah WHERE idUser = @idUser AND idProduk = @idProduk"
                Dim updateCmd As New MySqlCommand(updateQuery, CONN)
                updateCmd.Parameters.AddWithValue("@idUser", iduser) ' Ganti dengan ID user yang sesuai
                updateCmd.Parameters.AddWithValue("@idProduk", idProduk)
                updateCmd.Parameters.AddWithValue("@jumlah", jumlahProduk)
                updateCmd.ExecuteNonQuery()
                MessageBox.Show("Jumlah produk berhasil diperbarui di keranjang")
            Else
                ' Produk belum ada di keranjang, tambahkan ke keranjang
                MessageBox.Show("sql 3")
                Dim insertQuery As String = "INSERT INTO tbkeranjang(idProduk, idUser, jumlah) VALUES (@idProduk, @idUser, @jumlah)"
                Dim insertCmd As New MySqlCommand(insertQuery, CONN)
                insertCmd.Parameters.AddWithValue("@idUser", iduser) ' Ganti dengan ID user yang sesuai
                insertCmd.Parameters.AddWithValue("@idProduk", idProduk)
                insertCmd.Parameters.AddWithValue("@jumlah", jumlahProduk)
                insertCmd.ExecuteNonQuery()
                MessageBox.Show("Produk berhasil ditambahkan ke keranjang")
            End If

            Cart.Tampil()
            ' Refresh data setelah melakukan penambahan
            'LoadKeranjang() ' Metode LoadKeranjang() digunakan untuk memuat ulang isi keranjang
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