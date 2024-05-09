Imports MySql.Data.MySqlClient
Public Class produk2
    Dim jenisProduk As String = ""
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        CMD = New MySqlCommand("delete from tbproduk where idProduk = '" & txtId.Text & "'", CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data berhasil dihapus")
        produk.tampilData()
        Me.Close()
    End Sub
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtNama.Text = "" Or txtHarga.Text = "" Then
            MsgBox("Data belum lengkap!")
        Else
            CMD = New MySqlCommand("Select * from tbproduk where idProduk ='" & txtId.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                If sepatu.Checked Then
                    jenisProduk = sepatu.Text
                Else
                    jenisProduk = baju.Text
                End If
                CMD = New MySqlCommand("update tbproduk set nama = '" & txtNama.Text & "', jenis = '" & jenisProduk & "', harga = '" & txtHarga.Text & "', merek = '" & txtMerek.Text & "', madeIn = '" & txtMadeIn.Text & "' , kualitas = '" & cbKualitas.Text & "' , stok = '" & txtStok.Text & "'where idProduk = '" & txtId.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil diubah")
                produk.tampilData()
                Me.Close()
                produk.Show()
            End If
        End If
    End Sub

    Private Sub produk2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class