Imports MySql.Data.MySqlClient

Public Class Profile
    Dim iduser As Integer = LoginPage.idUser

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        ' Define the SQL command to fetch user data
        Dim query As String = "SELECT * FROM tbuser WHERE id_user = @iduser"

        Try
            ' Create a MySqlCommand object with the SQL command and connection
            Dim cmd As New MySqlCommand(query, CONN)
            ' Add parameter to prevent SQL injection
            cmd.Parameters.AddWithValue("@iduser", iduser)

            ' Execute the SQL command and get the MySqlDataReader
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Check if there are rows returned
            If reader.Read() Then
                ' Read the values from the reader and assign them to variables
                Dim username As String = reader("username").ToString()
                Dim password As String = reader("password").ToString()
                Dim email As String = reader("email").ToString()
                Dim alamat As String = reader("alamat").ToString()
                Dim notelp As String = reader("notelp").ToString()

                ' Display the values in appropriate controls (assuming you have text boxes named txtUsername, txtPassword, txtEmail, txtAlamat, and txtNoTelp)
                txtUsername.Text = username
                txtPass.Text = password
                txtEmail.Text = email
                txtAlamat.Text = alamat
                txtTelp.Text = notelp
            End If

            ' Close the reader
            reader.Close()
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            koneksi()
            Dim query As String = "UPDATE tbuser SET username = @username, password = @password, email = @email, alamat = @alamat, notelp = @notelp WHERE id_user = @iduser"
            Dim cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@iduser", iduser)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPass.Text)
            cmd.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            cmd.Parameters.AddWithValue("@notelp", txtTelp.Text)

            ' Check if any of the fields are empty
            If txtUsername.Text = "" Or txtPass.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Or txtTelp.Text = "" Then
                MsgBox("Data tidak boleh kosong")
            Else
                cmd.ExecuteNonQuery()
                MessageBox.Show("Profile berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CONN.Close()
        End Try
    End Sub

End Class
