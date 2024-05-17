Imports MySql.Data.MySqlClient

Public Class Riwayatuser

    Dim iduser As Integer = LoginPage.idUser

    Sub tampilData()
        DataGridView1.Rows.Clear()
        CMD = New MySqlCommand("select * from tbriwayat where idUser = @id", CONN)
        CMD.Parameters.AddWithValue("@id", iduser)
        RD = CMD.ExecuteReader()
        While RD.Read()
            Dim row As New DataGridViewRow()
            row.CreateCells(DataGridView1)
            row.Cells(0).Value = RD("id_riwayat")
            row.Cells(1).Value = RD("namaProduk")
            row.Cells(2).Value = RD("jumlah")
            row.Cells(3).Value = RD("tanggal")
            row.Cells(4).Value = RD("total")
            DataGridView1.Rows.Add(row)
        End While
        RD.Close()
    End Sub
    Private Sub Riwayatuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilData()
    End Sub

End Class