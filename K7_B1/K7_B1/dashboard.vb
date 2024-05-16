﻿Imports MySql.Data.MySqlClient
Public Class dashboard

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilkanTotalProduk()
        TampilkanTotalUser()
        TampilkanTotalTerjual()
    End Sub
    Sub TampilkanTotalUser()
        ' Panggil fungsi untuk mengambil total produk dari database
        Dim totalUser As Integer = GetTotalProduk()

        ' Tampilkan total produk di Label4
        Label2.Text = totalUser.ToString()
    End Sub
    Sub TampilkanTotalProduk()
        ' Panggil fungsi untuk mengambil total produk dari database
        Dim totalProduk As Integer = GetTotalProduk()

        ' Tampilkan total produk di Label4
        Label4.Text = totalProduk.ToString()
    End Sub
    Sub TampilkanTotalTerjual()
        ' Panggil fungsi untuk mengambil total produk dari database
        Dim totalTerjual As Integer = GetTotalTerjual()

        ' Tampilkan total produk di Label4
        Label7.Text = totalTerjual.ToString()
    End Sub
    Private Function GetTotalTerjual() As Integer
        Dim total As Integer = 0

        Try
            ' Query untuk menghitung total produk di database
            Dim query As String = "SELECT SUM(jumlah) FROM tbriwayat"

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
            ' Query untuk menghitung total produk di database
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
End Class