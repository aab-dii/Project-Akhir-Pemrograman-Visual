Imports MySql.Data.MySqlClient
Imports System.IO

Public Class tambahProduk
    Dim jenisProduk As String = ""
    Dim gambarPath As String = "" ' Variabel untuk menyimpan path gambar yang dipilih

    Dim idProduk As Integer ' Ubah tipe data idProduk menjadi Integer
    Private Sub SetProductID()
        ' Ambil ID produk terakhir dari database
        CMD = New MySqlCommand("SELECT MAX(idProduk) FROM tbproduk", CONN)
        RD = CMD.ExecuteReader()
        If RD.Read() Then
            ' Jika ada data, maka ambil nilai ID terakhir, tambahkan 1, dan atur sebagai ID produk berikutnya
            If Not IsDBNull(RD(0)) Then
                idProduk = RD.GetInt32(0) + 1
            Else
                ' Jika tidak ada data (tabel kosong), atur ID produk pertama sebagai 1
                idProduk = 1
            End If
        End If
        RD.Close()
    End Sub

    Private Sub btnPilihGambar_Click(sender As Object, e As EventArgs) Handles btnPilihGambar.Click
        ' Tampilkan dialog untuk memilih gambar
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "File Gambar (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif"

        If dialog.ShowDialog() = DialogResult.OK Then
            ' Simpan path gambar yang dipilih dalam variabel
            gambarPath = dialog.FileName
            PictureBox1.Image = Image.FromFile(gambarPath)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub CopyImageToFolder(sourcePath As String, folderName As String)
        Try
            ' Pastikan file gambar sumber ada
            If File.Exists(sourcePath) Then
                ' Mendapatkan path folder tujuan
                Dim destinationFolder As String = Path.Combine(Application.StartupPath, folderName)

                ' Pastikan folder tujuan ada, jika belum, buat folder baru
                If Not Directory.Exists(destinationFolder) Then
                    Directory.CreateDirectory(destinationFolder)
                End If

                ' Mendapatkan nama file dari path sumber
                Dim fileName As String = Path.GetFileName(sourcePath)

                ' Mendapatkan path tujuan
                Dim destinationPath As String = Path.Combine(destinationFolder, fileName)

                ' Melakukan kopi file
                File.Copy(sourcePath, destinationPath, True)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        koneksi()
        ' Lakukan pengecekan jika nama produk dan harga produk telah diisi
        If txtNama.Text = "" OrElse txtHarga.Text = "" OrElse txtMerek.Text = "" OrElse cbKualitas.Text = "" OrElse txtMadeIn.Text = "" OrElse txtStok.Text = "" Then
            MsgBox("Data belum lengkap")
        ElseIf Not (sepatu.Checked Or baju.Checked) Then
            MsgBox("Data Belum Lengkap")
        ElseIf gambarPath <> "" Then
            ' Salin gambar ke folder lokal proyek
            CopyImageToFolder(gambarPath, "GambarProduk")

            ' Simpan data produk ke database
            If sepatu.Checked Then
                jenisProduk = sepatu.Text
            Else
                jenisProduk = baju.Text
            End If

            ' Dapatkan path relatif gambar
            Dim gambarPathRelatif As String = Path.Combine("GambarProduk", Path.GetFileName(gambarPath))

            ' Lakukan penyimpanan produk ke database
            CMD = New MySqlCommand("INSERT INTO tbproduk (nama, jenis, harga, merek, madeIn, kualitas, stok, gambar) VALUES (@nama, @jenis, @harga, @merek, @madeIn, @kualitas, @stok, @gambar)", CONN)
            CMD.Parameters.AddWithValue("@nama", txtNama.Text)
            CMD.Parameters.AddWithValue("@jenis", jenisProduk)
            CMD.Parameters.AddWithValue("@harga", txtHarga.Text)
            CMD.Parameters.AddWithValue("@merek", txtMerek.Text)
            CMD.Parameters.AddWithValue("@madeIn", txtMadeIn.Text)
            CMD.Parameters.AddWithValue("@kualitas", cbKualitas.Text)
            CMD.Parameters.AddWithValue("@stok", txtStok.Text)
            CMD.Parameters.AddWithValue("@gambar", gambarPathRelatif)
            CMD.ExecuteNonQuery()

            MsgBox("Simpan Data Berhasil!")
            manageProduk.LoadProdukToFlowLayoutPanel()
            admin.childform(manageProduk)

            ' Kosongkan textbox setelah penyimpanan
            txtNama.Clear()
            txtHarga.Clear()
            txtMerek.Clear()
            txtMadeIn.Clear()
            txtStok.Clear()
            cbKualitas.SelectedIndex = -1
            gambarPath = ""
        End If
    End Sub

    Private Sub tambahProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        admin.childform(manageProduk)
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        HanyaAngka(e)
    End Sub
End Class
