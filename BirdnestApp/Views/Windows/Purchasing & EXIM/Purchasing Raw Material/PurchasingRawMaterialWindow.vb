Imports System.Runtime.Intrinsics
Imports Google.Protobuf
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class PurchasingRawMaterialWindow

    Private Sub PurchasingRawMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InputTabControl.TabMenuVisible = False
        sidenavDashboard.Checked = True
        pgInput_btnFind.Text = ChrW(&HE71E)
        pgInput_btnReset.Text = ChrW(&HE777)
    End Sub

    Private Sub PurchasingRawMaterial_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Mini_Click(sender As Object, e As EventArgs) Handles Mini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Tutup_Click(sender As Object, e As EventArgs) Handles Tutup.Click
        Me.Close()
    End Sub

    Private Sub NavigatePage(clickedButton As Object)
        Dim tPageName As String
        Dim ctrlBtn As Guna2Button

        For Each ctrl In sidenavFlyout.Controls
            For Each ctrlBtn In sidenavFlyout.Controls
                If TypeOf ctrlBtn Is Guna2Button Then
                    tPageName = ctrlBtn.Name.Trim.Replace("sidenav", "")
                    If ctrlBtn.Equals(clickedButton) Then
                        ctrlBtn.FillColor = Color.FromArgb(214, 220, 229)
                        ctrlBtn.Checked = True

                        Dim selectedPage As TabPage = InputTabControl.TabPages.Cast(Of TabPage)().FirstOrDefault(Function(tp) tp.Name = "pg" & tPageName)
                        If selectedPage IsNot Nothing Then
                            InputTabControl.SelectedTab = selectedPage
                        End If
                    Else
                        ctrlBtn.FillColor = Color.FromArgb(255, 255, 255)
                        ctrlBtn.Checked = False
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub sidenavDashboard_Click(sender As Object, e As EventArgs) Handles sidenavDashboard.Click
        NavigatePage(sender)
    End Sub

    Private Sub sidenavInput_Click(sender As Object, e As EventArgs) Handles sidenavInput.Click
        NavigatePage(sender)
    End Sub

    Private Sub sidenavStock_Click(sender As Object, e As EventArgs) Handles sidenavStock.Click
        NavigatePage(sender)
    End Sub

    Private Sub sidenavAdjustment_Click(sender As Object, e As EventArgs) Handles sidenavAdjustment.Click
        NavigatePage(sender)
    End Sub

    Private Sub sidenavOutput_Click(sender As Object, e As EventArgs) Handles sidenavOutput.Click
        NavigatePage(sender)
    End Sub

    Private Sub sidenavTransit_Click(sender As Object, e As EventArgs) Handles sidenavTransit.Click
        NavigatePage(sender)
    End Sub

    Private Sub pgInput_tblData_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles pgInput_tblData.CellFormatting
        Dim column = pgInput_tblData.Columns(e.ColumnIndex)

        If column.Name = "selisih_berat" Then
            If e.Value IsNot Nothing AndAlso IsNumeric(e.Value) Then
                If CDec(e.Value) < 0 Then
                    e.CellStyle.ForeColor = Color.Red
                ElseIf CDec(e.Value) > 0 Then
                    e.CellStyle.ForeColor = Color.Green
                End If
            End If
        End If

        If column.Name = "Nomor" Then
            column.Frozen = True
        End If
        If column.Name = "nomor_transaksi" Then
            column.Visible = False
        End If
        If column.Name = "PRM_delete" Then
            e.Value = ChrW(&HE74D)
        End If
        If column.Name = "PRM_edit" Then
            e.Value = ChrW(&HE70F)
        End If

        If column.DefaultCellStyle.Format = "N2" OrElse column.DefaultCellStyle.Format = "N1" OrElse column.DefaultCellStyle.Format = "N0" Then
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If

        If column.DefaultCellStyle.Format = "N3" AndAlso LoginWindow.Role.Text = "admin" Then
            column.Visible = False
        End If
        If column.DefaultCellStyle.Format = "N3" Then
            column.DefaultCellStyle.Format = "N1"
        End If

        pgInput_tblData.RowTemplate.Height = 35
        pgInput_tblData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'Memindahkan kolom Nomor Batch
        'pgInput_tblData.Columns("nomor_batch").DisplayIndex = pgInput_tblData.Columns("nomor_transaksi").DisplayIndex
        'pgInput_tblData.Columns("nomor_transaksi").DisplayIndex += 1
    End Sub

    Private Sub pgInput_btnReset_Click(sender As Object, e As EventArgs) Handles pgInput_btnReset.Click
        PRM_pgInputView.Reset(Me)
    End Sub

    Private Sub pgInput_btnFind_Click(sender As Object, e As EventArgs) Handles pgInput_btnFind.Click
        PRM_pgInputView.GetSQL(Me)
    End Sub

    Private Sub pgInput_tbSearch_TextChanged(sender As Object, e As EventArgs) Handles pgInput_tbSearch.TextChanged
        PRM_pgInputView.FilterData(Me)
    End Sub

    Private Sub pgInput_btnNew_Click(sender As Object, e As EventArgs) Handles pgInput_btnNew.Click
        PRM_InputWindow.Show()
    End Sub

End Class
