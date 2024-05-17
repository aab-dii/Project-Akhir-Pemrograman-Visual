Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class Laporan
    ' Declare the PrintDocument component
    Private WithEvents PrintDocument1 As New PrintDocument()
    Private printData As String

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
        Try
            PictureBoxLogo.Image = Image.FromFile("D:\Coding\Visual Basic\jumat 17mei\Project-Akhir-Pemrograman-Visual\K7_B1\image\logo streetwear.png")
        Catch
            MessageBox.Show("Failed to load image.")
        End Try
    End Sub

    Private Sub btnCetakLaporan_Click(sender As Object, e As EventArgs) Handles btnCetakLaporan.Click
        ' Format the data for printing
        FormatDataForPrinting()
        ' Show the print preview dialog
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub FormatDataForPrinting()
        Dim sb As New System.Text.StringBuilder()

        ' Header
        sb.AppendLine("")
        sb.AppendLine("                  Laporan Riwayat Pembelian StreetWear Store")
        sb.AppendLine("")

        sb.AppendLine("==========================================================================")
        sb.AppendLine(String.Format("{0,-5} {1,-30} {2,-10} {3,-20}", "ID", "Nama Produk", "Jumlah", "Tanggal"))
        sb.AppendLine("==========================================================================")

        ' Body
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                sb.AppendLine(String.Format("{0,-5} {1,-30} {2,-10} {3,-20}", row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value))
            End If
        Next

        ' Store the formatted data
        printData = sb.ToString()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Define the font and brush
        Dim printFont As New Font("Courier New", 12)
        Dim printBrush As New SolidBrush(Color.Black)

        If PictureBoxLogo.Image IsNot Nothing Then
            e.Graphics.DrawImage(PictureBoxLogo.Image, New Rectangle(30, 15, 100, 75))
        End If
        ' Print the formatted data
        e.Graphics.DrawString(printData, printFont, printBrush, 30, 20)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
