Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class MainWindow

    Private Sub Master_Click(sender As Object, e As EventArgs) Handles Master.Click
        Focused_Topnav(sender)
        TabControl.SelectedTab = PageReport
    End Sub

    Private Sub PNE_Click(sender As Object, e As EventArgs) Handles PNE.Click
        Focused_Topnav(sender)
        TabControl.SelectedTab = PagePNE
    End Sub

    Private Sub PRD_Click(sender As Object, e As EventArgs) Handles PRD.Click
        Focused_Topnav(sender)
        TabControl.SelectedTab = PagePRD
    End Sub

    Private Sub Focused_Topnav(clickedButton As Object)
        Dim ctrl As Control
        For Each ctrl In FlowLayoutPanel1.Controls
            If TypeOf ctrl Is Guna2Button AndAlso InStr(ctrl.Tag, "topnav") > 0 Then
                If ctrl.Equals(clickedButton) Then
                    ctrl.ForeColor = Color.FromArgb(67, 94, 190)
                Else
                    ctrl.ForeColor = Color.FromArgb(136, 139, 142)
                End If
            End If
        Next
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl.TabMenuVisible = False
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Application.Exit()
    End Sub

    Sub OpenWorkbook(sender As Object)
        Dim ctrl As Control = CType(sender, Control)
        If grantedAccess = False Then
            Guna2MessageDialog1.Caption = "Access Denied"
            Guna2MessageDialog1.Text = "Anda tidak memiliki akses " & ctrl.Text
            Guna2MessageDialog1.Buttons = MessageDialogButtons.OK
            Guna2MessageDialog1.Show()
        End If
    End Sub

    Private Sub PurchasingRawMaterial_Click(sender As Object, e As EventArgs) Handles PurchasingRawMaterial.Click
        AccessWorkbooks.OpenWorkbook(sender)
        OpenWorkbook(sender)
    End Sub

    Private Sub PurchasingNonRawMaterial_Click(sender As Object, e As EventArgs) Handles PurchasingNonRawMaterial.Click
        AccessWorkbooks.OpenWorkbook(sender)
        OpenWorkbook(sender)
    End Sub

    Private Sub EximExternal_Click(sender As Object, e As EventArgs) Handles EximExternal.Click
        AccessWorkbooks.OpenWorkbook(sender)
        OpenWorkbook(sender)
    End Sub

    Private Sub EximInternal_Click(sender As Object, e As EventArgs) Handles EximInternal.Click
        AccessWorkbooks.OpenWorkbook(sender)
        OpenWorkbook(sender)
    End Sub

    Private Sub GradingKasar_Click(sender As Object, e As EventArgs) Handles GradingKasar.Click
        AccessWorkbooks.OpenWorkbook(sender)
        OpenWorkbook(sender)
    End Sub
End Class
