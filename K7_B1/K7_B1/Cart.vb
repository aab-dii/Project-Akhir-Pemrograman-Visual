Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Cart
    Private countProduct As Integer = 0
    Dim iduser As Integer = LoginPage.idUser

    Public Sub Tampil()
        ' Kosongkan FlowLayoutPanel sebelum memuat data baru
        PanelProduk.Controls.Clear()
        PanelProduk.AutoScroll = True ' Mengaktifkan scroll bar
        PanelProduk.FlowDirection = FlowDirection.TopDown ' Mengatur flow direction ke vertikal

        Try
            ' Lakukan koneksi ke database
            koneksi()

            ' Query untuk mengambil data dari tbproduk yang sudah ada di tbkeranjang sesuai dengan idUser saat ini
            Dim query As String = "SELECT tbproduk.idProduk, tbproduk.nama, tbproduk.harga, tbproduk.gambar, tbkeranjang.jumlah " &
                                  "FROM tbproduk INNER JOIN tbkeranjang " &
                                  "ON tbproduk.idProduk = tbkeranjang.idProduk " &
                                  "WHERE tbkeranjang.idUser = @idUser"
            Dim cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@idUser", iduser)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Loop melalui setiap baris data hasil query
            While reader.Read()
                ' Buat panel untuk menampilkan informasi produk
                Dim panelProdukItem As New Panel()
                panelProdukItem.BackColor = Color.AliceBlue ' Warna menarik untuk kotak kontainer
                panelProdukItem.BorderStyle = BorderStyle.FixedSingle
                panelProdukItem.Size = New Size(500, 150)
                panelProdukItem.Margin = New Padding(10)
                panelProdukItem.Anchor = AnchorStyles.None

                ' Tambahkan CheckBox untuk memilih produk
                Dim checkBoxPilih As New CheckBox()
                checkBoxPilih.Tag = reader("idProduk").ToString() ' Simpan ID produk di Tag untuk referensi nanti
                checkBoxPilih.Location = New Point(10, 120)

                ' Tambahkan label untuk menampilkan informasi produk
                Dim font As New Font("Visby Round CF Bold", 10.2, FontStyle.Bold)

                Dim labelNama As New Label()
                labelNama.Text = "Nama: " & reader("nama").ToString()
                labelNama.AutoSize = True
                labelNama.Font = font
                labelNama.Location = New Point(150, 10)

                Dim labelHarga As New Label()
                labelHarga.Text = "Harga: " & reader("harga").ToString()
                labelHarga.AutoSize = True
                labelHarga.Font = font
                labelHarga.Location = New Point(150, 30)

                Dim labelJumlah As New Label()
                labelJumlah.Text = "Jumlah: " & reader("jumlah").ToString()
                labelJumlah.AutoSize = True
                labelJumlah.Font = font
                labelJumlah.Location = New Point(150, 50)

                ' Tambahkan PictureBox untuk menampilkan gambar (jika ada)
                Dim pictureBox As New PictureBox()
                If Not IsDBNull(reader("gambar")) AndAlso reader("gambar").ToString() <> "" Then
                    Dim gambarPathRelatif As String = reader("gambar").ToString()
                    Dim gambarPathAbsolut As String = Path.Combine(Application.StartupPath, gambarPathRelatif)
                    If File.Exists(gambarPathAbsolut) Then
                        pictureBox.Image = Image.FromFile(gambarPathAbsolut)
                    End If
                End If
                pictureBox.Size = New Size(100, 100)
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom
                pictureBox.Location = New Point(10, 10)

                ' Tambahkan kontrol ke dalam panel produk
                panelProdukItem.Controls.Add(checkBoxPilih)
                panelProdukItem.Controls.Add(pictureBox)
                panelProdukItem.Controls.Add(labelHarga)
                panelProdukItem.Controls.Add(labelNama)
                panelProdukItem.Controls.Add(labelJumlah)

                ' Tambahkan panel produk ke dalam FlowLayoutPanel
                PanelProduk.Controls.Add(panelProdukItem)
            End While

            reader.Close() ' Tutup DataReader setelah selesai membaca data
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Tutup koneksi setelah selesai
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub

    Private Sub ProdukBeli_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException
    End Sub

    Private Sub ProdukKeranjang_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException
    End Sub

    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Tampil()
    End Sub

    Private Sub Chekout_Click(sender As Object, e As EventArgs) Handles Chekout.Click
        Dim selectedProducts As New List(Of Integer)()

        ' Loop melalui setiap panel dalam FlowLayoutPanel
        For Each panel As Panel In PanelProduk.Controls
            ' Cari CheckBox dalam panel
            For Each control As Control In panel.Controls
                If TypeOf control Is CheckBox Then
                    Dim checkBox As CheckBox = DirectCast(control, CheckBox)
                    ' Jika CheckBox dipilih, tambahkan ID produk ke daftar
                    If checkBox.Checked Then
                        selectedProducts.Add(Convert.ToInt32(checkBox.Tag))
                    End If
                End If
            Next
        Next

        ' Proses barang yang dipilih untuk checkout
        If selectedProducts.Count > 0 Then
            Try
                koneksi() ' Buka koneksi ke database

                For Each idProduk In selectedProducts
                    ' Ambil informasi produk dari tabel tbproduk
                    Dim queryProduk As String = "SELECT nama, harga, stok FROM tbproduk WHERE idProduk = @idProduk"
                    Dim cmdProduk As New MySqlCommand(queryProduk, CONN)
                    cmdProduk.Parameters.AddWithValue("@idProduk", idProduk)
                    Dim readerProduk As MySqlDataReader = cmdProduk.ExecuteReader()

                    If readerProduk.Read() Then
                        Dim namaProduk As String = readerProduk("nama").ToString()
                        Dim stok As Integer = Convert.ToInt32(readerProduk("stok"))
                        Dim jumlah As Integer = 1 ' Atur jumlah sesuai kebutuhan Anda

                        ' Tutup reader sebelum melakukan operasi lain
                        readerProduk.Close()

                        ' Masukkan data ke dalam tabel tbriwayat
                        Dim queryRiwayat As String = "INSERT INTO tbriwayat (idUser, namaProduk, tanggal, jumlah) VALUES (@idUser, @namaProduk, @tanggal, @jumlah)"
                        Dim cmdRiwayat As New MySqlCommand(queryRiwayat, CONN)
                        cmdRiwayat.Parameters.AddWithValue("@idUser", iduser)
                        cmdRiwayat.Parameters.AddWithValue("@namaProduk", namaProduk)
                        cmdRiwayat.Parameters.AddWithValue("@tanggal", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                        cmdRiwayat.Parameters.AddWithValue("@jumlah", jumlah)
                        cmdRiwayat.ExecuteNonQuery()

                        ' Kurangi stok pada tabel tbproduk
                        Dim queryUpdateStok As String = "UPDATE tbproduk SET stok = stok - @jumlah WHERE idProduk = @idProduk"
                        Dim cmdUpdateStok As New MySqlCommand(queryUpdateStok, CONN)
                        cmdUpdateStok.Parameters.AddWithValue("@jumlah", jumlah)
                        cmdUpdateStok.Parameters.AddWithValue("@idProduk", idProduk)
                        cmdUpdateStok.ExecuteNonQuery()
                    Else
                        readerProduk.Close()
                    End If
                Next

                MessageBox.Show("Produk yang dipilih berhasil di-checkout.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Tutup koneksi setelah selesai
                If CONN.State = ConnectionState.Open Then
                    CONN.Close()
                End If
            End Try
        Else
            MessageBox.Show("Silakan pilih produk yang ingin di-checkout.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
