Imports MySql.Data.MySqlClient

Public Class produk
    Dim idProduk As Integer ' Ubah tipe data idProduk menjadi Integer
    Dim jenisProduk As String = ""

    Private Sub produk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        ' Panggil fungsi untuk mengatur ID produk saat form dimuat
        SetProductID()

        ' Tampilkan data produk saat form dimuat
        TampilData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
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
            tampilData()
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedCustomer As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            Dim produk2 As produk2 = New produk2()

            produk2.txtId.Text = selectedCustomer.Cells(0).Value.ToString()
            produk2.txtNama.Text = selectedCustomer.Cells(1).Value.ToString()
            Dim jenisProduk As String = selectedCustomer.Cells(2).Value.ToString()
            If jenisProduk = "sepatu" Then
                produk2.sepatu.Checked = True
            ElseIf jenisProduk = "baju" Then
                produk2.baju.Checked = True
            End If
            produk2.txtHarga.Text = selectedCustomer.Cells(3).Value.ToString()
            produk2.Show()
        End If
    End Sub
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
    Sub tampilData()
        DataGridView1.Rows.Clear()
        CMD = New MySqlCommand("select * from tbproduk", CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView1)
            row.Cells(0).Value = RD("idProduk")
            row.Cells(1).Value = RD("Nama")
            row.Cells(2).Value = RD("Jenis")
            row.Cells(3).Value = RD("Harga")
            DataGridView1.Rows.Add(row)
        End While
        RD.Close()
    End Sub
End Class
