Imports MySql.Data.MySqlClient

Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        ' Update labels with appropriate data
        TampilkanTotalProduk()
        TampilkanTotalUser()
        TampilkanTotalTerjual()
        TampilkanTotalHargaPenjualan()
    End Sub

    Sub TampilkanTotalUser()
        ' Panggil fungsi untuk mengambil total user dari database
        Dim totalUser As Integer = GetTotalUser()

        ' Tampilkan total user di Label2
        Label2.Text = totalUser.ToString()
    End Sub

    Sub TampilkanTotalProduk()
        ' Panggil fungsi untuk mengambil total produk dari database
        Dim totalProduk As Integer = GetTotalProduk()

        ' Tampilkan total produk di Label4
        Label4.Text = totalProduk.ToString()
    End Sub

    Sub TampilkanTotalTerjual()
        ' Panggil fungsi untuk mengambil total terjual dari database
        Dim totalTerjual As Integer = GetTotalTerjual()

        ' Tampilkan total terjual di Label7
        Label7.Text = totalTerjual.ToString()
    End Sub

    Sub TampilkanTotalHargaPenjualan()
        ' Panggil fungsi untuk mengambil total harga penjualan dari database
        Dim totalHargaPenjualan As Decimal = GetTotalHargaPenjualan()

        ' Tampilkan total harga penjualan di Label11
        Label11.Text = totalHargaPenjualan.ToString("C2")
    End Sub

    Private Function GetTotalTerjual() As Integer
        Dim total As Integer = 0

        Try
            ' Query untuk menghitung total terjual di database
            Dim query As String = "SELECT SUM(jumlah) FROM tbriwayat"

            ' Membuat command dengan koneksi yang sudah ada
            Using command As New MySqlCommand(query, CONN)
                ' Membuka koneksi jika belum terbuka
                If CONN.State = ConnectionState.Closed Then
                    CONN.Open()
                End If

                ' Eksekusi query dan ambil hasilnya
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    total = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return total
    End Function

    Private Function GetTotalProduk() As Integer
        Dim total As Integer = 0

        Try
            ' Query untuk menghitung total produk di database
            Dim query As String = "SELECT COUNT(*) FROM tbproduk"

            ' Membuat command dengan koneksi yang sudah ada
            Using command As New MySqlCommand(query, CONN)
                ' Membuka koneksi jika belum terbuka
                If CONN.State = ConnectionState.Closed Then
                    CONN.Open()
                End If

                ' Eksekusi query dan ambil hasilnya
                total = Convert.ToInt32(command.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return total
    End Function

    Private Function GetTotalUser() As Integer
        Dim total As Integer = 0

        Try
            ' Query untuk menghitung total user di database
            Dim query As String = "SELECT COUNT(*) FROM tbuser"

            ' Membuat command dengan koneksi yang sudah ada
            Using command As New MySqlCommand(query, CONN)
                ' Membuka koneksi jika belum terbuka
                If CONN.State = ConnectionState.Closed Then
                    CONN.Open()
                End If

                ' Eksekusi query dan ambil hasilnya
                total = Convert.ToInt32(command.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return total
    End Function

    Private Function GetTotalHargaPenjualan() As Decimal
        Dim total As Decimal = 0

        Try
            ' Query untuk menghitung total harga penjualan di database
            Dim query As String = "SELECT SUM(total) FROM tbriwayat"

            ' Membuat command dengan koneksi yang sudah ada
            Using command As New MySqlCommand(query, CONN)
                ' Membuka koneksi jika belum terbuka
                If CONN.State = ConnectionState.Closed Then
                    CONN.Open()
                End If

                ' Eksekusi query dan ambil hasilnya
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    total = Convert.ToDecimal(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return total
    End Function
End Class
