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
            produk2.txtMerek.Text = selectedCustomer.Cells(4).Value.ToString()
            produk2.txtMadeIn.Text = selectedCustomer.Cells(5).Value.ToString()
            produk2.cbKualitas.Text = selectedCustomer.Cells(6).Value.ToString()
            produk2.txtStok.Text = selectedCustomer.Cells(7).Value.ToString()
            Admin.childform(produk2)
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
            row.Cells(4).Value = RD("Merek")
            row.Cells(5).Value = RD("MadeIn")
            row.Cells(6).Value = RD("Kualitas")
            row.Cells(7).Value = RD("Stok")
            DataGridView1.Rows.Add(row)
        End While
        RD.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Admin.childform(tambah)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
