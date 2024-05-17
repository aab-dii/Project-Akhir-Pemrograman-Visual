Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Cart
    Private countProduct As Integer = 0
    Dim iduser As Integer = LoginPage.idUser
    Dim totalCheckout As Decimal = 0

    ' Fungsi untuk menampilkan produk yang ada di keranjang
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
                AddHandler checkBoxPilih.CheckedChanged, AddressOf CheckBox_CheckedChanged ' Tambahkan event handler

                ' Tambahkan label untuk menampilkan informasi produk
                Dim font As New Font("Visby Round CF Bold", 10.2, FontStyle.Bold)

                Dim labelNama As New Label()
                labelNama.Text = "Nama: " & reader("nama").ToString()
                labelNama.AutoSize = True
                labelNama.Font = font
                labelNama.Location = New Point(150, 10)

                Dim labelHarga As New Label()
                labelHarga.Text = "Harga: " & reader("harga").ToString()
                labelHarga.Name = "labelHarga"
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

    ' Event handler untuk load Cart
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Tampil()
    End Sub

    ' Event handler untuk proses checkout
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
                    ' Ambil informasi produk dan jumlah dari tabel tbproduk dan tbkeranjang
                    Dim queryProduk As String = "SELECT p.nama, p.harga, p.stok, k.jumlah " &
                                                "FROM tbproduk p " &
                                                "INNER JOIN tbkeranjang k ON p.idProduk = k.idProduk " &
                                                "WHERE k.idProduk = @idProduk AND k.idUser = @idUser"
                    Dim cmdProduk As New MySqlCommand(queryProduk, CONN)
                    cmdProduk.Parameters.AddWithValue("@idProduk", idProduk)
                    cmdProduk.Parameters.AddWithValue("@idUser", iduser)
                    Dim readerProduk As MySqlDataReader = cmdProduk.ExecuteReader()

                    If readerProduk.Read() Then
                        Dim namaProduk As String = readerProduk("nama").ToString()
                        Dim harga As Decimal = Convert.ToDecimal(readerProduk("harga"))
                        Dim stok As Integer = Convert.ToInt32(readerProduk("stok"))
                        Dim jumlah As Integer = Convert.ToInt32(readerProduk("jumlah"))
                        Dim total As Decimal = harga * jumlah

                        ' Tutup reader sebelum melakukan operasi lain
                        readerProduk.Close()

                        ' Masukkan data ke dalam tabel tbriwayat
                        Dim queryRiwayat As String = "INSERT INTO tbriwayat (idUser, namaProduk, tanggal, jumlah, total) VALUES (@idUser, @namaProduk, @tanggal, @jumlah, @total)"
                        Dim cmdRiwayat As New MySqlCommand(queryRiwayat, CONN)
                        cmdRiwayat.Parameters.AddWithValue("@idUser", iduser)
                        cmdRiwayat.Parameters.AddWithValue("@namaProduk", namaProduk)
                        cmdRiwayat.Parameters.AddWithValue("@tanggal", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                        cmdRiwayat.Parameters.AddWithValue("@jumlah", jumlah)
                        cmdRiwayat.Parameters.AddWithValue("@total", total)
                        cmdRiwayat.ExecuteNonQuery()

                        ' Kurangi stok pada tabel tbproduk
                        Dim queryUpdateStok As String = "UPDATE tbproduk SET stok = stok - @jumlah WHERE idProduk = @idProduk"
                        Dim cmdUpdateStok As New MySqlCommand(queryUpdateStok, CONN)
                        cmdUpdateStok.Parameters.AddWithValue("@jumlah", jumlah)
                        cmdUpdateStok.Parameters.AddWithValue("@idProduk", idProduk)
                        cmdUpdateStok.ExecuteNonQuery()

                        ' Hapus produk dari tbkeranjang setelah berhasil di-checkout
                        Dim queryDeleteKeranjang As String = "DELETE FROM tbkeranjang WHERE idProduk = @idProduk AND idUser = @idUser"
                        Dim cmdDeleteKeranjang As New MySqlCommand(queryDeleteKeranjang, CONN)
                        cmdDeleteKeranjang.Parameters.AddWithValue("@idProduk", idProduk)
                        cmdDeleteKeranjang.Parameters.AddWithValue("@idUser", iduser)
                        cmdDeleteKeranjang.ExecuteNonQuery()
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
        Tampil()
    End Sub

    ' Event handler untuk perubahan checkbox
    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        ' Bersihkan total checkout
        totalCheckout = 0

        ' Iterasi melalui setiap item dalam FlowLayoutPanel
        For Each panelProdukItem As Panel In PanelProduk.Controls.OfType(Of Panel)()
            Dim checkBox As CheckBox = panelProdukItem.Controls.OfType(Of CheckBox)().FirstOrDefault()

            ' Jika checkbox diperiksa, tambahkan harga item ke total checkout
            If checkBox IsNot Nothing AndAlso checkBox.Checked Then
                Dim labelHarga As Label = panelProdukItem.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "labelHarga")
                If labelHarga IsNot Nothing Then
                    Dim hargaItem As Decimal
                    If Decimal.TryParse(labelHarga.Text.Replace("Harga: ", ""), hargaItem) Then
                        Dim labelJumlah As Label = panelProdukItem.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Text.StartsWith("Jumlah: "))
                        If labelJumlah IsNot Nothing Then
                            Dim jumlahItem As Integer
                            If Integer.TryParse(labelJumlah.Text.Replace("Jumlah: ", ""), jumlahItem) Then
                                totalCheckout += hargaItem * jumlahItem
                            End If
                        End If
                    End If
                End If
            End If
        Next

        ' Tampilkan total checkout pada Label1
        Label1.Text = "Total Checkout: " & totalCheckout.ToString("C2")
    End Sub
End Class
