Imports Guna.UI2.WinForms
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class LoginWindow

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim ctrl As Control

        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Guna2TextBox AndAlso InStr(ctrl.Tag, "required") > 0 AndAlso String.IsNullOrEmpty(DirectCast(ctrl, Guna2TextBox).Text.Trim) Then
                Beep()
                Guna2MessageDialog1.Caption = "Warning"
                Guna2MessageDialog1.Text = ctrl.Name & " harus diisi"
                Guna2MessageDialog1.Buttons = MessageDialogButtons.OK
                Guna2MessageDialog1.Show()
                Exit Sub
            End If
        Next

        Dim hashedpassword As String = ""
        For i = 1 To Len(Password.Text)
            hashedpassword = hashedpassword & "[" & Asc(Mid(Password.Text, i, 1)) & "]"
        Next

        Dim conn As New MySqlConnection(connStr)

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM user_accounts WHERE username = @username AND password = @password"
            Dim cmd As New MySqlCommand(query, conn)

            ' Add parameters to the query
            cmd.Parameters.AddWithValue("@username", Username.Text)
            cmd.Parameters.AddWithValue("@password", hashedpassword)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Username.Enabled = False
                    Password.Text = hashedpassword
                    Password.Enabled = False
                    Role.Text = reader("role")
                    Me.Hide()
                    MainWindow.Show()
                End While
            Else
                Guna2MessageDialog1.Caption = "Login Failed"
                Guna2MessageDialog1.Text = "Username atau password tidak ditemukan"
                Guna2MessageDialog1.Buttons = MessageDialogButtons.OK
                Guna2MessageDialog1.Show()
            End If

            reader.Close()
            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show("Error connecting to the database: " & ex.Message)
        End Try

    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Application.Exit()
    End Sub

End Class
