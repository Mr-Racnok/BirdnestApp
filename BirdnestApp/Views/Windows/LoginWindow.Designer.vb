<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Login = New Guna.UI2.WinForms.Guna2Button()
        Username = New Guna.UI2.WinForms.Guna2TextBox()
        Password = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Close = New Guna.UI2.WinForms.Guna2Button()
        Label3 = New Label()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2MessageDialog1 = New Guna.UI2.WinForms.Guna2MessageDialog()
        Role = New Guna.UI2.WinForms.Guna2TextBox()
        SuspendLayout()
        ' 
        ' Login
        ' 
        Login.BorderRadius = 6
        Login.Cursor = Cursors.Hand
        Login.CustomizableEdges = CustomizableEdges1
        Login.DisabledState.BorderColor = Color.DarkGray
        Login.DisabledState.CustomBorderColor = Color.DarkGray
        Login.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Login.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Login.Font = New Font("Nunito SemiBold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Login.ForeColor = Color.White
        Login.Location = New Point(54, 343)
        Login.Margin = New Padding(3, 4, 3, 4)
        Login.Name = "Login"
        Login.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Login.Size = New Size(200, 35)
        Login.TabIndex = 0
        Login.TabStop = False
        Login.Text = "Login"
        ' 
        ' Username
        ' 
        Username.BorderRadius = 6
        Username.CustomizableEdges = CustomizableEdges3
        Username.DefaultText = "admina"
        Username.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Username.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Username.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Username.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Username.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Username.Font = New Font("Nunito SemiBold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Username.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Username.Location = New Point(54, 198)
        Username.Margin = New Padding(3, 4, 3, 4)
        Username.Name = "Username"
        Username.PasswordChar = ChrW(0)
        Username.PlaceholderText = "Enter username"
        Username.SelectedText = ""
        Username.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Username.Size = New Size(200, 35)
        Username.TabIndex = 0
        Username.Tag = "_required_"
        ' 
        ' Password
        ' 
        Password.BorderRadius = 6
        Password.CustomizableEdges = CustomizableEdges5
        Password.DefaultText = "akui12"
        Password.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Password.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Password.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Password.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Password.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Password.Font = New Font("Nunito SemiBold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Password.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Password.Location = New Point(54, 271)
        Password.Margin = New Padding(3, 4, 3, 4)
        Password.Name = "Password"
        Password.PasswordChar = "•"c
        Password.PlaceholderText = "Enter password"
        Password.SelectedText = ""
        Password.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Password.Size = New Size(200, 35)
        Password.TabIndex = 1
        Password.Tag = "_required_"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(74), CByte(85))
        Label1.Location = New Point(52, 176)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 18)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(74), CByte(85))
        Label2.Location = New Point(54, 249)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 18)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' Close
        ' 
        Close.Cursor = Cursors.Hand
        Close.CustomizableEdges = CustomizableEdges7
        Close.DisabledState.BorderColor = Color.DarkGray
        Close.DisabledState.CustomBorderColor = Color.DarkGray
        Close.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Close.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Close.FillColor = Color.White
        Close.Font = New Font("Nunito SemiBold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Close.ForeColor = Color.FromArgb(CByte(51), CByte(62), CByte(78))
        Close.HoverState.ForeColor = Color.FromArgb(CByte(187), CByte(45), CByte(59))
        Close.Location = New Point(271, -2)
        Close.Margin = New Padding(3, 4, 3, 4)
        Close.Name = "Close"
        Close.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Close.Size = New Size(33, 26)
        Close.TabIndex = 0
        Close.TabStop = False
        Close.Text = "X"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Nunito", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(74), CByte(85))
        Label3.Location = New Point(114, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 22)
        Label3.TabIndex = 2
        Label3.Text = "BirdApp"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.Animated = True
        Guna2Button2.BorderRadius = 34
        Guna2Button2.Cursor = Cursors.Hand
        Guna2Button2.CustomizableEdges = CustomizableEdges9
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.Font = New Font("Nunito SemiBold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(114, 50)
        Guna2Button2.Margin = New Padding(3, 4, 3, 4)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Button2.Size = New Size(70, 70)
        Guna2Button2.TabIndex = 0
        Guna2Button2.TabStop = False
        Guna2Button2.Text = "Logo"
        ' 
        ' Guna2MessageDialog1
        ' 
        Guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Guna2MessageDialog1.Caption = Nothing
        Guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Guna2MessageDialog1.Parent = Me
        Guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default
        Guna2MessageDialog1.Text = Nothing
        ' 
        ' Role
        ' 
        Role.BorderRadius = 6
        Role.CustomizableEdges = CustomizableEdges11
        Role.DefaultText = ""
        Role.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Role.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Role.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Role.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Role.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Role.Font = New Font("Nunito SemiBold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Role.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Role.Location = New Point(52, 300)
        Role.Margin = New Padding(3, 4, 3, 4)
        Role.Name = "Role"
        Role.PasswordChar = "•"c
        Role.PlaceholderText = ""
        Role.SelectedText = ""
        Role.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Role.Size = New Size(200, 35)
        Role.TabIndex = 1
        Role.Tag = ""
        Role.Visible = False
        ' 
        ' LoginWindow
        ' 
        AutoScaleDimensions = New SizeF(8F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(300, 400)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Role)
        Controls.Add(Password)
        Controls.Add(Username)
        Controls.Add(Close)
        Controls.Add(Guna2Button2)
        Controls.Add(Login)
        DoubleBuffered = True
        Font = New Font("Nunito SemiBold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "LoginWindow"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginWindow"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2MessageDialog1 As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Role As Guna.UI2.WinForms.Guna2TextBox
End Class
