Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Module AccessWorkbooks

    Public Sub OpenWorkbook(sender As Object)
        Dim ctrl As Control = CType(sender, Control)

        Dim conn As New MySqlConnection(connStr)
        Try
            conn.Open()
            Dim query As String = "SELECT window FROM user_control_windows WHERE username = @username AND password = @password AND window = @window"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@username", LoginWindow.Username.Text)
            cmd.Parameters.AddWithValue("@password", LoginWindow.Password.Text)
            cmd.Parameters.AddWithValue("@window", ctrl.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    grantedAccess = True
                    Select Case ctrl.Text
                        Case "Purchasing Raw Material"
                            PurchasingRawMaterialWindow.Show()
                        Case "Purchasing Non Raw Material"
                            PurchasingNonRawMaterial.Show()
                    End Select
                End While
            Else
                grantedAccess = False
            End If

            reader.Close()
            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show("Error connecting to the database: " & ex.Message)
        End Try
    End Sub
End Module
