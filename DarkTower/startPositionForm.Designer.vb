<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startPositionForm
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
        Me.icelandButton = New System.Windows.Forms.Button()
        Me.forestButton = New System.Windows.Forms.Button()
        Me.plainsButton = New System.Windows.Forms.Button()
        Me.desertButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'icelandButton
        '
        Me.icelandButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icelandButton.Location = New System.Drawing.Point(46, 45)
        Me.icelandButton.Name = "icelandButton"
        Me.icelandButton.Size = New System.Drawing.Size(127, 40)
        Me.icelandButton.TabIndex = 0
        Me.icelandButton.Text = "Ice Lands"
        Me.icelandButton.UseVisualStyleBackColor = True
        '
        'forestButton
        '
        Me.forestButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forestButton.Location = New System.Drawing.Point(46, 91)
        Me.forestButton.Name = "forestButton"
        Me.forestButton.Size = New System.Drawing.Size(127, 40)
        Me.forestButton.TabIndex = 1
        Me.forestButton.Text = "Forests"
        Me.forestButton.UseVisualStyleBackColor = True
        '
        'plainsButton
        '
        Me.plainsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plainsButton.Location = New System.Drawing.Point(46, 137)
        Me.plainsButton.Name = "plainsButton"
        Me.plainsButton.Size = New System.Drawing.Size(127, 40)
        Me.plainsButton.TabIndex = 2
        Me.plainsButton.Text = "Plains"
        Me.plainsButton.UseVisualStyleBackColor = True
        '
        'desertButton
        '
        Me.desertButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desertButton.Location = New System.Drawing.Point(46, 183)
        Me.desertButton.Name = "desertButton"
        Me.desertButton.Size = New System.Drawing.Size(127, 40)
        Me.desertButton.TabIndex = 3
        Me.desertButton.Text = "Desert"
        Me.desertButton.UseVisualStyleBackColor = True
        '
        'startPositionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 255)
        Me.Controls.Add(Me.desertButton)
        Me.Controls.Add(Me.plainsButton)
        Me.Controls.Add(Me.forestButton)
        Me.Controls.Add(Me.icelandButton)
        Me.Name = "startPositionForm"
        Me.Text = "Select Start Position"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents icelandButton As Button
    Friend WithEvents forestButton As Button
    Friend WithEvents plainsButton As Button
    Friend WithEvents desertButton As Button
End Class
