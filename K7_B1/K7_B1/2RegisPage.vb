Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class Form2

    Dim username As String
    Dim email As String
    Dim password As String
    Dim query As String
    Private Function UsernameAda(username As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM tbuser WHERE username = @username"
        Dim cmd As New MySqlCommand(query, CONN)
        cmd.Parameters.AddWithValue("@username", username)
        Try
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MessageBox.Show("Error checking username: " & ex.Message)
            Return True ' Mengembalikan true dalam kasus kesalahan untuk mencegah pendaftaran
        End Try
    End Function

    Private Function EmailAda(email As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM tbuser WHERE email = @email"
        Dim cmd As New MySqlCommand(query, CONN)
        cmd.Parameters.AddWithValue("@email", email)

        Try
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MessageBox.Show("Error checking email: " & ex.Message)
            Return True ' Mengembalikan true dalam kasus kesalahan untuk mencegah pendaftaran
        Finally
        End Try
    End Function
    Private Function EmailBenar(email As String) As Boolean
        ' Format email yang valid menggunakan ekspresi reguler
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        username = txtUsername.Text
        email = txtEmail.Text
        password = txtpass.Text
        If txtEmail.Text = "" OrElse txtpass.Text = "" OrElse txtUsername.Text = "" Then
            MsgBox("Data Belum Lengkap")
        ElseIf EmailAda(email) Then
            MessageBox.Show("Email sudah digunakan")
        ElseIf UsernameAda(username) Then
            MsgBox("Username sudah digunakan")
        ElseIf Not EmailBenar(email) Then
            MsgBox("Format email salah")
        Else
            query = "INSERT INTO tbuser (username, email, password) VALUES (@username, @email, @password)"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@username", username)
            CMD.Parameters.AddWithValue("@email", email)
            CMD.Parameters.AddWithValue("@password", password)
            Try
                If CMD.ExecuteNonQuery() Then
                    MessageBox.Show("Registrasi Berhasil Silahkan Login")
                    LoginPage.Show()
                    Me.Hide()
                End If
            Catch ex As Exception
                MsgBox("Error : " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Me.Hide()
    End Sub


End Class