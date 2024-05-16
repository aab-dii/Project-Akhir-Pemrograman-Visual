Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ubahProduk
    Dim idProduk As String
    Private gambarPath As String ' Variabel untuk menyimpan path gambar yang dipilih
    Private gambarPathLama As String ' Variabel untuk menyimpan path gambar yang lama

    Public Sub New(idProduk As String)
        Me.idProduk = idProduk
        InitializeComponent()
        LoadProduk()
    End Sub

    Private Sub LoadProduk()
        Try
            koneksi()
            Dim query As String = "SELECT * FROM tbproduk WHERE idProduk = @idProduk"
            Dim cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@idProduk", idProduk)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                txtNama.Text = reader("nama").ToString()
                If reader("jenis").ToString() = "sepatu" Then
                    sepatu.Checked = True
                Else
                    baju.Checked = True
                End If
                txtHarga.Text = reader("harga").ToString()
                txtMerek.Text = reader("merek").ToString()
                txtMadeIn.Text = reader("madeIn").ToString()
                cbKualitas.Text = reader("kualitas").ToString()
                txtStok.Text = reader("stok").ToString()

                gambarPathLama = reader("gambar").ToString() ' Simpan path gambar yang lama
                If File.Exists(Path.Combine(Application.StartupPath, gambarPathLama)) Then
                    PictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, gambarPathLama))
                End If
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub btnPilihGambar_Click(sender As Object, e As EventArgs)
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
            gambarPath = openFileDialog.FileName ' Menyimpan path gambar yang baru dipilih
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

                ' Simpan path relatif
                gambarPath = Path.Combine(folderName, fileName)

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs)
        If txtNama.Text = "" Or txtHarga.Text = "" Then
            MsgBox("Data belum lengkap!")
        Else
            Try
                koneksi()
                Dim jenisProduk As String
                If sepatu.Checked Then
                    jenisProduk = sepatu.Text
                Else
                    jenisProduk = baju.Text
                End If

                ' Salin gambar ke folder lokal proyek jika ada gambar baru dipilih
                If Not String.IsNullOrEmpty(gambarPath) AndAlso Not gambarPath.StartsWith(Application.StartupPath) Then
                    CopyImageToFolder(gambarPath, "GambarProduk")
                End If

                Dim query As String = "UPDATE tbproduk SET nama = @nama, jenis = @jenis, harga = @harga, merek = @merek, madeIn = @madeIn, kualitas = @kualitas, stok = @stok, gambar = @gambar WHERE idProduk = @idProduk"
                Dim cmd As New MySqlCommand(query, CONN)
                cmd.Parameters.AddWithValue("@idProduk", idProduk)
                cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                cmd.Parameters.AddWithValue("@jenis", jenisProduk)
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
                cmd.Parameters.AddWithValue("@merek", txtMerek.Text)
                cmd.Parameters.AddWithValue("@madeIn", txtMadeIn.Text)
                cmd.Parameters.AddWithValue("@kualitas", cbKualitas.Text)
                cmd.Parameters.AddWithValue("@stok", txtStok.Text)
                cmd.Parameters.AddWithValue("@gambar", gambarPath)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Data berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CONN.Close()
            End Try
        End If
    End Sub

    Private Sub btnBatal_Click_1(sender As Object, e As EventArgs) Handles btnBatal.Click
        admin.childform(manageProduk)
    End Sub

    Private Sub btnPilihGambar_Click_1(sender As Object, e As EventArgs) Handles btnPilihGambar.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
            gambarPath = openFileDialog.FileName ' Menyimpan path gambar yang baru dipilih
        End If
    End Sub

    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text = "" Or txtHarga.Text = "" Then
            MsgBox("Data belum lengkap!")
        Else
            Try
                koneksi()
                Dim jenisProduk As String
                If sepatu.Checked Then
                    jenisProduk = sepatu.Text
                Else
                    jenisProduk = baju.Text
                End If

                ' Salin gambar ke folder lokal proyek jika ada gambar baru dipilih
                If Not String.IsNullOrEmpty(gambarPath) AndAlso Not gambarPath.StartsWith(Application.StartupPath) Then
                    CopyImageToFolder(gambarPath, "GambarProduk")
                End If

                Dim query As String = "UPDATE tbproduk SET nama = @nama, jenis = @jenis, harga = @harga, merek = @merek, madeIn = @madeIn, kualitas = @kualitas, stok = @stok, gambar = @gambar WHERE idProduk = @idProduk"
                Dim cmd As New MySqlCommand(query, CONN)
                cmd.Parameters.AddWithValue("@idProduk", idProduk)
                cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                cmd.Parameters.AddWithValue("@jenis", jenisProduk)
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
                cmd.Parameters.AddWithValue("@merek", txtMerek.Text)
                cmd.Parameters.AddWithValue("@madeIn", txtMadeIn.Text)
                cmd.Parameters.AddWithValue("@kualitas", cbKualitas.Text)
                cmd.Parameters.AddWithValue("@stok", txtStok.Text)
                cmd.Parameters.AddWithValue("@gambar", gambarPath)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Data berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                admin.childform(manageProduk)
                manageProduk.LoadProdukToFlowLayoutPanel()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CONN.Close()
            End Try
        End If
    End Sub


End Class
