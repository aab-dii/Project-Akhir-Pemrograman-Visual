Imports MySql.Data.MySqlClient
Public Class tambah
    Dim idProduk As Integer ' Ubah tipe data idProduk menjadi Integer
    Dim jenisProduk As String = ""
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

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Admin.childform(produk)
    End Sub

    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Lakukan pengecekan jika nama produk dan harga produk telah diisi
        If txtNama.Text = "" OrElse txtHarga.Text = "" OrElse txtMerek.Text = "" OrElse cbKualitas.Text = "" OrElse txtMadeIn.Text = "" OrElse txtStok.Text = "" Then
            MsgBox("Data belum lengkap")
        ElseIf Not (sepatu.Checked Or baju.Checked) Then
            MsgBox("Data Belum Lengkap")
        Else
            If sepatu.Checked Then
                jenisProduk = sepatu.Text
            Else
                jenisProduk = baju.Text
            End If
            ' Lakukan penyimpanan produk ke database
            CMD = New MySqlCommand("INSERT INTO tbproduk (idProduk, nama, jenis, harga,merek,madeIn,kualitas,stok) VALUES ('" & idProduk & "', '" & txtNama.Text & "', '" & jenisProduk & "', '" & txtHarga.Text & "', '" & txtMerek.Text & "', '" & txtMadeIn.Text & "', '" & cbKualitas.Text & "', '" & txtStok.Text & "')", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Simpan Data Berhasil!")
            dashboard.TampilkanTotalProduk()

            ' Setelah berhasil menyimpan produk, panggil fungsi untuk mengatur ID produk berikutnya
            SetProductID()

            ' Kosongkan textbox setelah penyimpanan
            txtNama.Clear()
            txtHarga.Clear()
            txtHarga.Clear()
            txtHarga.Clear()
            txtHarga.Clear()
            txtHarga.Clear()

            ' Refresh tampilan DataGridView setelah penyimpanan
            produk.tampilData()
            Admin.childform(produk)
        End If
    End Sub
End Class