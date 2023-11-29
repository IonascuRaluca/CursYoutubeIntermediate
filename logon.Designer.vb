<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class logon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnLogon = New System.Windows.Forms.Button()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnLogon
        '
        Me.BtnLogon.Location = New System.Drawing.Point(288, 234)
        Me.BtnLogon.Name = "BtnLogon"
        Me.BtnLogon.Size = New System.Drawing.Size(154, 57)
        Me.BtnLogon.TabIndex = 0
        Me.BtnLogon.Text = "Logon"
        Me.BtnLogon.UseVisualStyleBackColor = True
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(346, 118)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(188, 20)
        Me.TxtUserName.TabIndex = 1
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(346, 172)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(188, 20)
        Me.TxtPassword.TabIndex = 2
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(235, 121)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(53, 13)
        Me.LblPassword.TabIndex = 3
        Me.LblPassword.Text = "Password"
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Location = New System.Drawing.Point(235, 179)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(57, 13)
        Me.LblUserName.TabIndex = 4
        Me.LblUserName.Text = "UserName"
        '
        'logon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblUserName)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.BtnLogon)
        Me.Name = "logon"
        Me.Text = "Logon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogon As Button
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUserName As Label
End Class
