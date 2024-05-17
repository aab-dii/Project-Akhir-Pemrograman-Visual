Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO

Public Class Cart
    Private countProduct As Integer = 0
    Dim iduser As Integer = LoginPage.idUser
    Dim totalCheckout As Decimal = 0
    Private strukData As String = String.Empty


    ' Fungsi untuk menampilkan produk yang ada di keranjang
    Public Sub Tampil()
        ' Kosongkan FlowLayoutPanel sebelum memuat data baru
        PanelProduk.Controls.Clear()
        PanelProduk.AutoScroll = True ' Mengaktifkan scroll bar
        PanelProduk.FlowDirection = FlowDirection.TopDown ' Mengatur flow direction ke vertikal

        Try
            ' Lakukan koneksi ke database
            koneksi()

            ' Query untuk mengambil data dari tbproduk yang sudah ada di tbkeranjang sesuai dengan idUser saat ini
            Dim query As String = "SELECT tbproduk.idProduk, tbproduk.nama, tbproduk.harga, tbproduk.gambar, tbkeranjang.jumlah " &
                                  "FROM tbproduk INNER JOIN tbkeranjang " &
                                  "ON tbproduk.idProduk = tbkeranjang.idProduk " &
                                  "WHERE tbkeranjang.idUser = @idUser"
            Dim cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@idUser", iduser)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Loop melalui setiap baris data hasil query
            While reader.Read()
                ' Buat panel untuk menampilkan informasi produk
                Dim panelProdukItem As New Panel()
                panelProdukItem.BackColor = Color.AliceBlue ' Warna menarik untuk kotak kontainer
                panelProdukItem.BorderStyle = BorderStyle.FixedSingle
                panelProdukItem.Size = New Size(500, 150)
                panelProdukItem.Margin = New Padding(10)
                panelProdukItem.Anchor = AnchorStyles.None

                ' Tambahkan CheckBox untuk memilih produk
                Dim checkBoxPilih As New CheckBox()
                checkBoxPilih.Tag = reader("idProduk").ToString() ' Simpan ID produk di Tag untuk referensi nanti
                checkBoxPilih.Location = New Point(10, 120)
                AddHandler checkBoxPilih.CheckedChanged, AddressOf CheckBox_CheckedChanged ' Tambahkan event handler

                ' Tambahkan label untuk menampilkan informasi produk
                Dim font As New Font("Visby Round CF Bold", 10.2, FontStyle.Bold)

                Dim labelNama As New Label()
                labelNama.Text = "Nama: " & reader("nama").ToString()
                labelNama.AutoSize = True
                labelNama.Font = font
                labelNama.Location = New Point(150, 10)

                Dim labelHarga As New Label()
                labelHarga.Text = "Harga: " & reader("harga").ToString()
                labelHarga.Name = "labelHarga"
                labelHarga.AutoSize = True
                labelHarga.Font = font
                labelHarga.Location = New Point(150, 30)

                Dim labelJumlah As New Label()
                labelJumlah.Text = "Jumlah: " & reader("jumlah").ToString()
                labelJumlah.AutoSize = True
                labelJumlah.Font = font
                labelJumlah.Location = New Point(150, 50)

                ' Tambahkan PictureBox untuk menampilkan gambar (jika ada)
                Dim pictureBox As New PictureBox()
                If Not IsDBNull(reader("gambar")) AndAlso reader("gambar").ToString() <> "" Then
                    Dim gambarPathRelatif As String = reader("gambar").ToString()
                    Dim gambarPathAbsolut As String = Path.Combine(Application.StartupPath, gambarPathRelatif)
                    If File.Exists(gambarPathAbsolut) Then
                        pictureBox.Image = Image.FromFile(gambarPathAbsolut)
                    End If
                End If
                pictureBox.Size = New Size(100, 100)
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom
                pictureBox.Location = New Point(10, 10)

                ' Tambahkan kontrol ke dalam panel produk
                panelProdukItem.Controls.Add(checkBoxPilih)
                panelProdukItem.Controls.Add(pictureBox)
                panelProdukItem.Controls.Add(labelHarga)
                panelProdukItem.Controls.Add(labelNama)
                panelProdukItem.Controls.Add(labelJumlah)

                ' Tambahkan panel produk ke dalam FlowLayoutPanel
                PanelProduk.Controls.Add(panelProdukItem)
            End While

            reader.Close() ' Tutup DataReader setelah selesai membaca data
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handler untuk load Cart
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Tampil()
        cekdata()
        AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintDocumentStruk
    End Sub

    Private Function cekdata() As Boolean
        Dim query As String = "SELECT alamat, notelp FROM tbuser WHERE id_user = @iduser"

        Try
            ' Create a MySqlCommand object with the SQL query and connection
            Dim cmd As New MySqlCommand(query, CONN)
            ' Add parameter to prevent SQL injection
            cmd.Parameters.AddWithValue("@iduser", iduser)

            ' Execute the SQL command and get the MySqlDataReader
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Check if there are rows returned
            If reader.Read() Then
                ' Read the values from the reader and assign them to variables
                Dim alamat As String = reader("alamat").ToString()
                Dim notelp As String = reader("notelp").ToString()

                ' Check if the address or phone number is empty or zero
                If String.IsNullOrEmpty(alamat) OrElse notelp = "0" Then
                    MsgBox("Mohon lengkapi data alamat dan nomor telepon Anda.")
                    reader.Close()
                    Return False
                End If
            End If
            ' Close the reader
            reader.Close()
            Return True
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    ' Event handler untuk proses checkout
    Private Sub Chekout_Click(sender As Object, e As EventArgs) Handles Chekout.Click
        koneksi()
        If cekdata() Then
            ' Lakukan proses checkout jika data lengkap
            Dim selectedProducts As New List(Of Integer)()
            Dim totalCheckout As Decimal = 0
            Dim strukData As String = "Struk Pembelian" & vbCrLf & "===================" & vbCrLf
            strukData &= String.Format("{0,-5} {1,-20} {2,-10} {3,10}", "No", "Nama Produk", "Jumlah", "Total") & vbCrLf
            strukData &= "===================================================" & vbCrLf

            ' Loop through each panel in FlowLayoutPanel
            For Each panel As Panel In PanelProduk.Controls
                ' Search for CheckBox within the panel
                For Each control As Control In panel.Controls
                    If TypeOf control Is CheckBox Then
                        Dim checkBox As CheckBox = DirectCast(control, CheckBox)
                        ' If CheckBox is checked, add product ID to the list
                        If checkBox.Checked Then
                            selectedProducts.Add(Convert.ToInt32(checkBox.Tag))
                        End If
                    End If
                Next
            Next

            ' Process selected products for checkout
            If selectedProducts.Count > 0 Then
                Try
                    koneksi() ' Open connection to the database
                    Dim itemNo As Integer = 1
                    For Each idProduk In selectedProducts
                        ' Get product information and quantity from tbproduk and tbkeranjang tables
                        Dim queryProduk As String = "SELECT p.nama, p.harga, p.stok, k.jumlah " &
                                                "FROM tbproduk p " &
                                                "INNER JOIN tbkeranjang k ON p.idProduk = k.idProduk " &
                                                "WHERE k.idProduk = @idProduk AND k.idUser = @idUser"
                        Dim cmdProduk As New MySqlCommand(queryProduk, CONN)
                        cmdProduk.Parameters.AddWithValue("@idProduk", idProduk)
                        cmdProduk.Parameters.AddWithValue("@idUser", iduser)
                        Dim readerProduk As MySqlDataReader = cmdProduk.ExecuteReader()

                        If readerProduk.Read() Then
                            Dim namaProduk As String = readerProduk("nama").ToString()
                            Dim harga As Decimal = Convert.ToDecimal(readerProduk("harga"))
                            Dim stok As Integer = Convert.ToInt32(readerProduk("stok"))
                            Dim jumlah As Integer = Convert.ToInt32(readerProduk("jumlah"))
                            Dim total As Decimal = harga * jumlah
                            totalCheckout += total

                            ' Add product details to strukData
                            strukData &= String.Format("{0,-5} {1,-20} {2,-10} {3,10:C2}", itemNo, namaProduk, jumlah, total) & vbCrLf
                            itemNo += 1

                            ' Close reader before performing other operations
                            readerProduk.Close()

                            ' Insert data into tbriwayat table
                            Dim queryRiwayat As String = "INSERT INTO tbriwayat (idUser, namaProduk, tanggal, jumlah, total) VALUES (@idUser, @namaProduk, @tanggal, @jumlah, @total)"
                            Dim cmdRiwayat As New MySqlCommand(queryRiwayat, CONN)
                            cmdRiwayat.Parameters.AddWithValue("@idUser", iduser)
                            cmdRiwayat.Parameters.AddWithValue("@namaProduk", namaProduk)
                            cmdRiwayat.Parameters.AddWithValue("@tanggal", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                            cmdRiwayat.Parameters.AddWithValue("@jumlah", jumlah)
                            cmdRiwayat.Parameters.AddWithValue("@total", total)
                            cmdRiwayat.ExecuteNonQuery()

                            ' Reduce stock in tbproduk table
                            Dim queryUpdateStok As String = "UPDATE tbproduk SET stok = stok - @jumlah WHERE idProduk = @idProduk"
                            Dim cmdUpdateStok As New MySqlCommand(queryUpdateStok, CONN)
                            cmdUpdateStok.Parameters.AddWithValue("@jumlah", jumlah)
                            cmdUpdateStok.Parameters.AddWithValue("@idProduk", idProduk)
                            cmdUpdateStok.ExecuteNonQuery()

                            ' Remove product from tbkeranjang after successful checkout
                            Dim queryDeleteKeranjang As String = "DELETE FROM tbkeranjang WHERE idProduk = @idProduk AND idUser = @idUser"
                            Dim cmdDeleteKeranjang As New MySqlCommand(queryDeleteKeranjang, CONN)
                            cmdDeleteKeranjang.Parameters.AddWithValue("@idProduk", idProduk)
                            cmdDeleteKeranjang.Parameters.AddWithValue("@idUser", iduser)
                            cmdDeleteKeranjang.ExecuteNonQuery()
                        Else
                            readerProduk.Close()
                        End If
                    Next

                    strukData &= "===================================================" & vbCrLf
                    strukData &= String.Format("{0,-35} {1,10:C2}", "Total", totalCheckout)

                    ' Store the formatted receipt data for printing
                    Me.strukDataToPrint = strukData

                    ' Trigger the print
                    'PrintDocument1.Print()

                    MessageBox.Show("Produk yang dipilih berhasil di-checkout.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowPrintPreview()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Close connection after completion
                    If CONN.State = ConnectionState.Open Then
                        CONN.Close()
                    End If
                End Try
            Else
                MessageBox.Show("Silakan pilih produk yang ingin di-checkout.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            Tampil()
            Products.Tampil()
        Else
            ' Jika data tidak lengkap
            MessageBox.Show("Mohon lengkapi data alamat dan nomor telepon Anda.", "Data Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Class-level variable to hold the receipt data for printing
    Private strukDataToPrint As String

    Private Sub PrintDocumentStruk(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs)
        ' Define font and brush for printing
        Dim printFont As New Font("Courier New", 15)
        Dim printBrush As New SolidBrush(Color.Black)

        ' Print the receipt data
        e.Graphics.DrawString(Me.strukDataToPrint, printFont, printBrush, 0, 0)
    End Sub


    ' Event handler untuk perubahan checkbox
    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        ' Bersihkan total checkout
        totalCheckout = 0

        ' Iterasi melalui setiap item dalam FlowLayoutPanel
        For Each panelProdukItem As Panel In PanelProduk.Controls.OfType(Of Panel)()
            Dim checkBox As CheckBox = panelProdukItem.Controls.OfType(Of CheckBox)().FirstOrDefault()

            ' Jika checkbox diperiksa, tambahkan harga item ke total checkout
            If checkBox IsNot Nothing AndAlso checkBox.Checked Then
                Dim labelHarga As Label = panelProdukItem.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "labelHarga")
                If labelHarga IsNot Nothing Then
                    Dim hargaItem As Decimal
                    If Decimal.TryParse(labelHarga.Text.Replace("Harga: ", ""), hargaItem) Then
                        Dim labelJumlah As Label = panelProdukItem.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Text.StartsWith("Jumlah: "))
                        If labelJumlah IsNot Nothing Then
                            Dim jumlahItem As Integer
                            If Integer.TryParse(labelJumlah.Text.Replace("Jumlah: ", ""), jumlahItem) Then
                                totalCheckout += hargaItem * jumlahItem
                            End If
                        End If
                    End If
                End If
            End If
        Next

        ' Tampilkan total checkout pada Label1
        Label1.Text = "Total Checkout: " & totalCheckout.ToString("C2")
    End Sub
    ' Class-level variable to hold the data to print

    Private Sub ShowPrintPreview()
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub


End Class
