<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lesson8_9
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
        Me.BtnLesson8 = New System.Windows.Forms.Button()
        Me.BtnLesson9 = New System.Windows.Forms.Button()
        Me.TxtNr1 = New System.Windows.Forms.TextBox()
        Me.TxtNr2 = New System.Windows.Forms.TextBox()
        Me.TxtAge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnLesson8
        '
        Me.BtnLesson8.Location = New System.Drawing.Point(160, 118)
        Me.BtnLesson8.Name = "BtnLesson8"
        Me.BtnLesson8.Size = New System.Drawing.Size(165, 108)
        Me.BtnLesson8.TabIndex = 0
        Me.BtnLesson8.Text = "Lesson 8"
        Me.BtnLesson8.UseVisualStyleBackColor = True
        '
        'BtnLesson9
        '
        Me.BtnLesson9.Location = New System.Drawing.Point(475, 210)
        Me.BtnLesson9.Name = "BtnLesson9"
        Me.BtnLesson9.Size = New System.Drawing.Size(165, 65)
        Me.BtnLesson9.TabIndex = 1
        Me.BtnLesson9.Text = "Lesson 9"
        Me.BtnLesson9.UseVisualStyleBackColor = True
        '
        'TxtNr1
        '
        Me.TxtNr1.Location = New System.Drawing.Point(527, 76)
        Me.TxtNr1.Name = "TxtNr1"
        Me.TxtNr1.Size = New System.Drawing.Size(100, 20)
        Me.TxtNr1.TabIndex = 2
        '
        'TxtNr2
        '
        Me.TxtNr2.Location = New System.Drawing.Point(527, 118)
        Me.TxtNr2.Name = "TxtNr2"
        Me.TxtNr2.Size = New System.Drawing.Size(100, 20)
        Me.TxtNr2.TabIndex = 3
        '
        'TxtAge
        '
        Me.TxtAge.Location = New System.Drawing.Point(527, 163)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(100, 20)
        Me.TxtAge.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(485, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nr1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(485, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nr2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(488, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Age"
        '
        'Lesson8_9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAge)
        Me.Controls.Add(Me.TxtNr2)
        Me.Controls.Add(Me.TxtNr1)
        Me.Controls.Add(Me.BtnLesson9)
        Me.Controls.Add(Me.BtnLesson8)
        Me.Name = "Lesson8_9"
        Me.Text = "Lesson8_9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLesson8 As Button
    Friend WithEvents BtnLesson9 As Button
    Friend WithEvents TxtNr1 As TextBox
    Friend WithEvents TxtNr2 As TextBox
    Friend WithEvents TxtAge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
