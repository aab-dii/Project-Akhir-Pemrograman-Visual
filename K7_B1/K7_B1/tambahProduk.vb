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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub txtHarga_TextChanged(sender As Object, e As EventArgs) Handles txtHarga.TextChanged

    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click

    End Sub

    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub baju_CheckedChanged(sender As Object, e As EventArgs) Handles baju.CheckedChanged

    End Sub

    Private Sub sepatu_CheckedChanged(sender As Object, e As EventArgs) Handles sepatu.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtMerek_TextChanged(sender As Object, e As EventArgs) Handles txtMerek.TextChanged

    End Sub

    Private Sub txtMadeIn_TextChanged(sender As Object, e As EventArgs) Handles txtMadeIn.TextChanged

    End Sub

    Private Sub cbKualitas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKualitas.SelectedIndexChanged

    End Sub

    Private Sub txtStok_TextChanged(sender As Object, e As EventArgs) Handles txtStok.TextChanged

    End Sub
End Class
