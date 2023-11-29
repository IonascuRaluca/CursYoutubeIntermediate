<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lesson6
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
        Me.BtnWrite = New System.Windows.Forms.Button()
        Me.BtnRead = New System.Windows.Forms.Button()
        Me.BtnReadAll = New System.Windows.Forms.Button()
        Me.BtnReadOne = New System.Windows.Forms.Button()
        Me.BtnWriteArray = New System.Windows.Forms.Button()
        Me.BtnReadArray = New System.Windows.Forms.Button()
        Me.BtnTwoDimensionalArrayW = New System.Windows.Forms.Button()
        Me.BtnTwoDimensionalArrayR = New System.Windows.Forms.Button()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.BtnCopyConditionally = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnWrite
        '
        Me.BtnWrite.Location = New System.Drawing.Point(25, 26)
        Me.BtnWrite.Name = "BtnWrite"
        Me.BtnWrite.Size = New System.Drawing.Size(100, 61)
        Me.BtnWrite.TabIndex = 0
        Me.BtnWrite.Text = "Write"
        Me.BtnWrite.UseVisualStyleBackColor = True
        '
        'BtnRead
        '
        Me.BtnRead.Location = New System.Drawing.Point(151, 26)
        Me.BtnRead.Name = "BtnRead"
        Me.BtnRead.Size = New System.Drawing.Size(100, 61)
        Me.BtnRead.TabIndex = 1
        Me.BtnRead.Text = "Read"
        Me.BtnRead.UseVisualStyleBackColor = True
        '
        'BtnReadAll
        '
        Me.BtnReadAll.Location = New System.Drawing.Point(25, 100)
        Me.BtnReadAll.Name = "BtnReadAll"
        Me.BtnReadAll.Size = New System.Drawing.Size(100, 61)
        Me.BtnReadAll.TabIndex = 2
        Me.BtnReadAll.Text = "Read All"
        Me.BtnReadAll.UseVisualStyleBackColor = True
        '
        'BtnReadOne
        '
        Me.BtnReadOne.Location = New System.Drawing.Point(151, 100)
        Me.BtnReadOne.Name = "BtnReadOne"
        Me.BtnReadOne.Size = New System.Drawing.Size(100, 61)
        Me.BtnReadOne.TabIndex = 3
        Me.BtnReadOne.Text = "Read one character"
        Me.BtnReadOne.UseVisualStyleBackColor = True
        '
        'BtnWriteArray
        '
        Me.BtnWriteArray.Location = New System.Drawing.Point(25, 177)
        Me.BtnWriteArray.Name = "BtnWriteArray"
        Me.BtnWriteArray.Size = New System.Drawing.Size(100, 59)
        Me.BtnWriteArray.TabIndex = 4
        Me.BtnWriteArray.Text = "Write Array"
        Me.BtnWriteArray.UseVisualStyleBackColor = True
        '
        'BtnReadArray
        '
        Me.BtnReadArray.Location = New System.Drawing.Point(151, 177)
        Me.BtnReadArray.Name = "BtnReadArray"
        Me.BtnReadArray.Size = New System.Drawing.Size(100, 59)
        Me.BtnReadArray.TabIndex = 5
        Me.BtnReadArray.Text = "Read Array"
        Me.BtnReadArray.UseVisualStyleBackColor = True
        '
        'BtnTwoDimensionalArrayW
        '
        Me.BtnTwoDimensionalArrayW.Location = New System.Drawing.Point(25, 262)
        Me.BtnTwoDimensionalArrayW.Name = "BtnTwoDimensionalArrayW"
        Me.BtnTwoDimensionalArrayW.Size = New System.Drawing.Size(100, 59)
        Me.BtnTwoDimensionalArrayW.TabIndex = 6
        Me.BtnTwoDimensionalArrayW.Text = "Write Two Dimensional Array"
        Me.BtnTwoDimensionalArrayW.UseVisualStyleBackColor = True
        '
        'BtnTwoDimensionalArrayR
        '
        Me.BtnTwoDimensionalArrayR.Location = New System.Drawing.Point(151, 262)
        Me.BtnTwoDimensionalArrayR.Name = "BtnTwoDimensionalArrayR"
        Me.BtnTwoDimensionalArrayR.Size = New System.Drawing.Size(100, 59)
        Me.BtnTwoDimensionalArrayR.TabIndex = 7
        Me.BtnTwoDimensionalArrayR.Text = "Read Two Dimensional Array"
        Me.BtnTwoDimensionalArrayR.UseVisualStyleBackColor = True
        '
        'BtnCopy
        '
        Me.BtnCopy.Location = New System.Drawing.Point(25, 339)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(100, 59)
        Me.BtnCopy.TabIndex = 8
        Me.BtnCopy.Text = "Copy text from one file to another"
        Me.BtnCopy.UseVisualStyleBackColor = True
        '
        'BtnCopyConditionally
        '
        Me.BtnCopyConditionally.Location = New System.Drawing.Point(151, 339)
        Me.BtnCopyConditionally.Name = "BtnCopyConditionally"
        Me.BtnCopyConditionally.Size = New System.Drawing.Size(100, 59)
        Me.BtnCopyConditionally.TabIndex = 9
        Me.BtnCopyConditionally.Text = "Conditionally Copy text from one file to another"
        Me.BtnCopyConditionally.UseVisualStyleBackColor = True
        '
        'Lesson6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCopyConditionally)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.BtnTwoDimensionalArrayR)
        Me.Controls.Add(Me.BtnTwoDimensionalArrayW)
        Me.Controls.Add(Me.BtnReadArray)
        Me.Controls.Add(Me.BtnWriteArray)
        Me.Controls.Add(Me.BtnReadOne)
        Me.Controls.Add(Me.BtnReadAll)
        Me.Controls.Add(Me.BtnRead)
        Me.Controls.Add(Me.BtnWrite)
        Me.Name = "Lesson6"
        Me.Text = "Lesson6"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnWrite As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnReadAll As Button
    Friend WithEvents BtnReadOne As Button
    Friend WithEvents BtnWriteArray As Button
    Friend WithEvents BtnReadArray As Button
    Friend WithEvents BtnTwoDimensionalArrayW As Button
    Friend WithEvents BtnTwoDimensionalArrayR As Button
    Friend WithEvents BtnCopy As Button
    Friend WithEvents BtnCopyConditionally As Button
End Class
