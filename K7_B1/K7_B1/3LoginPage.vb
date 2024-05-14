Imports MySql.Data.MySqlClient

Public Class LoginPage
    Public Shared idUser As Integer ' Variabel public
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Silahkan isi Username Dan Password")
            Return
        End If

        Dim query As String = "SELECT role, id_user FROM tbuser WHERE username = @username AND password = @password"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@username", username)
        CMD.Parameters.AddWithValue("@password", password)
        RD = CMD.ExecuteReader()
        If RD.Read() Then
            Dim role As String = RD.GetString("role")
            idUser = RD.GetInt32("id_user")
            MessageBox.Show("Login Berhasil. Selamat datang, " & username & "!")

            If role = "admin" Then
                ' Masuk ke menu admin
                admin.Show()
                Me.Hide()
            Else
                ' Masuk ke menu user
                MenuUser.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Username atau Password Salah")
        End If
        RD.Close()
    End Sub

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
End Class