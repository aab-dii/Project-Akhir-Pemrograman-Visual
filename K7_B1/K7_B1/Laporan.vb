Imports MySql.Data.MySqlClient

Public Class Laporan
    Sub tampilData()
        DataGridView1.Rows.Clear()
        CMD = New MySqlCommand("select * from tbriwayat", CONN)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView1)
            row.Cells(0).Value = RD("id_riwayat")
            row.Cells(1).Value = RD("namaProduk")
            row.Cells(2).Value = RD("jumlah")
            row.Cells(3).Value = RD("tanggal")
            DataGridView1.Rows.Add(row)
        End While
        RD.Close()
    End Sub

    Private Sub Laporan_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class