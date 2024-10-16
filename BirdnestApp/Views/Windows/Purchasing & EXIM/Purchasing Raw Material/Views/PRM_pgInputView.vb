Imports MySql.Data.MySqlClient

Module PRM_pgInputView

    Public dt_pgInput As New DataTable()

    Sub GetSQL(frm As PurchasingRawMaterialWindow)

        Dim dt_pgInput As New DataTable()
        dt_pgInput.Columns.Add("Nomor", GetType(Integer))

        Dim query As String = "SELECT * FROM prm_input WHERE created_at BETWEEN @tanggal1 AND @tanggal2"
        Using conn As New MySqlConnection(connStr)
            Using cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@tanggal1", frm.pgInput_btnTanggal1.Value.AddDays(-1))
                cmd.Parameters.AddWithValue("@tanggal2", frm.pgInput_btnTanggal2.Value.AddDays(+0.99))

                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt_pgInput.Load(reader)
                End Using
                conn.Close()
            End Using
        End Using

        For i As Integer = 0 To dt_pgInput.Rows.Count - 1
            dt_pgInput.Rows(i)("Nomor") = i + 1
        Next

        frm.pgInput_tblData.DataSource = dt_pgInput

        For Each column As DataGridViewColumn In frm.pgInput_tblData.Columns
            Select Case column.Name
                Case "Nomor"
                    column.HeaderText = "Nomor"
                    column.DefaultCellStyle.Format = "N0"
                Case "nomor_transaksi"
                    column.HeaderText = "Nomor Transaksi"
                    column.Name = "nomor_transaksi"
                    column.DefaultCellStyle.Format = "N0"
                Case "nomor_nota_supplier"
                    column.HeaderText = "Nomor Nota Supplier"
                    column.Name = "nomor_nota_supplier"
                Case "nomor_nota_internal"
                    column.HeaderText = "Nomor Nota Internal"
                    column.Name = "nomor_nota_internal"
                Case "nomor_batch"
                    column.HeaderText = "Nomor Batch"
                    column.Name = "nomor_batch"
                Case "nama_supplier"
                    column.HeaderText = "Nama Supplier"
                    column.Name = "nama_supplier"
                Case "jenis_raw_material"
                    column.HeaderText = "Jenis Raw Material"
                    column.Name = "jenis_raw_material"
                Case "berat_nota"
                    column.HeaderText = "Berat Nota"
                    column.Name = "berat_nota"
                    column.DefaultCellStyle.Format = "N0"
                Case "berat_kotor"
                    column.HeaderText = "Berat Kotor"
                    column.Name = "berat_kotor"
                    column.DefaultCellStyle.Format = "N0"
                Case "berat_bersih"
                    column.HeaderText = "Berat Bersih"
                    column.Name = "berat_bersih"
                    column.DefaultCellStyle.Format = "N0"
                Case "selisih_berat"
                    column.HeaderText = "Selisih Berat"
                    column.Name = "selisih_berat"
                    column.DefaultCellStyle.Format = "N0"
                Case "kadar_air"
                    column.HeaderText = "Kadar Air"
                    column.Name = "kadar_air"
                    column.DefaultCellStyle.Format = "N2"
                Case "id_box_raw_material"
                    column.HeaderText = "ID Box Raw Material"
                    column.Name = "id_box_raw_material"
                Case "harga_nota"
                    column.HeaderText = "Harga Nota"
                    column.Name = "harga_nota"
                    column.DefaultCellStyle.Format = "N3"
                Case "total_harga_nota"
                    column.HeaderText = "Total Harga Nota"
                    column.Name = "total_harga_nota"
                    column.DefaultCellStyle.Format = "N3"
                Case "harga_deal"
                    column.HeaderText = "Harga Deal"
                    column.Name = "harga_deal"
                    column.DefaultCellStyle.Format = "N3"
                Case "fix_harga_deal"
                    column.HeaderText = "Fix Harga Deal"
                    column.Name = "fix_harga_deal"
                    column.DefaultCellStyle.Format = "N3"
                Case "keterangan"
                    column.HeaderText = "Keterangan"
                    column.Name = "keterangan"
                Case "created_by"
                    column.HeaderText = "Created By"
                    column.Name = "created_by"
                Case "created_at"
                    column.HeaderText = "Created At"
                    column.Name = "created_at"
                Case "updated_by"
                    column.HeaderText = "Updated By"
                    column.Name = "updated_by"
                Case "updated_at"
                    column.HeaderText = "Updated At"
                    column.Name = "updated_at"
            End Select
        Next
    End Sub

    Sub FilterData(frm As PurchasingRawMaterialWindow)
        ' Pastikan DataSource tidak null
        If frm.pgInput_tblData.DataSource Is Nothing Then
            Return
        End If

        ' Coba ambil DataView dari DataSource
        Dim dv As DataView = TryCast(frm.pgInput_tblData.DataSource, DataView)

        ' Jika DataSource adalah DataTable, buat DataView darinya
        If dv Is Nothing Then
            Dim dt As DataTable = TryCast(frm.pgInput_tblData.DataSource, DataTable)
            If dt IsNot Nothing Then
                dv = New DataView(dt)
            Else
                MessageBox.Show("DataSource bukan DataTable atau DataView.")
                Return
            End If
        End If

        ' Terapkan filter pada DataView
        'dv.RowFilter = "nomor_batch LIKE '%" & pgInput_tbSearch.Text & "%'"
        If dv IsNot Nothing Then
            Dim searchText As String = frm.pgInput_tbSearch.Text
            Dim filterString As String = String.Join(" OR ", dv.Table.Columns.Cast(Of DataColumn).Select(Function(col) _
            String.Format("CONVERT([{0}], System.String) LIKE '%{1}%'", col.ColumnName, searchText)))
            dv.RowFilter = filterString
            frm.pgInput_tblData.DataSource = dv
        End If

        frm.pgInput_tblData.DataSource = dv
    End Sub

    Sub Reset(frm As PurchasingRawMaterialWindow)
        frm.pgInput_btnTanggal1.Value = DateTime.Now.AddDays(-1)
        frm.pgInput_btnTanggal2.Value = DateTime.Now
        frm.pgInput_tbSearch.Clear()
        frm.pgInput_tblData.DataSource = Nothing

        For Each column As DataGridViewColumn In frm.pgInput_tblData.Columns
            If column.Name <> "PRM_delete" AndAlso column.Name <> "PRM_edit" Then
                frm.pgInput_tblData.DataSource = Nothing
            End If
        Next
        frm.pgInput_tblData.Rows.Clear()

        GetSQL(frm)
    End Sub

End Module
