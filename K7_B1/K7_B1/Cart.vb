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

                Dim labelJumlah As New Label()
                labelJumlah.Text = "Jumlah: " & reader("jumlah").ToString()
                labelJumlah.AutoSize = True
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

    End Sub
End Class
