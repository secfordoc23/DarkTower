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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startPositionForm))
        Me.icelandButton = New System.Windows.Forms.Button()
        Me.forestButton = New System.Windows.Forms.Button()
        Me.plainsButton = New System.Windows.Forms.Button()
        Me.desertButton = New System.Windows.Forms.Button()
        Me.introRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.startLocationGroupBox = New System.Windows.Forms.GroupBox()
        Me.startLocationGroupBox.SuspendLayout
        Me.SuspendLayout
        '
        'icelandButton
        '
        Me.icelandButton.BackColor = System.Drawing.SystemColors.Info
        Me.icelandButton.Font = New System.Drawing.Font("Papyrus", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.icelandButton.Location = New System.Drawing.Point(83, 29)
        Me.icelandButton.Margin = New System.Windows.Forms.Padding(6)
        Me.icelandButton.Name = "icelandButton"
        Me.icelandButton.Size = New System.Drawing.Size(254, 77)
        Me.icelandButton.TabIndex = 0
        Me.icelandButton.Text = "The &Ice Lands of Arisilon"
        Me.icelandButton.UseVisualStyleBackColor = False
        '
        'forestButton
        '
        Me.forestButton.BackColor = System.Drawing.SystemColors.Info
        Me.forestButton.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forestButton.Location = New System.Drawing.Point(455, 29)
        Me.forestButton.Margin = New System.Windows.Forms.Padding(6)
        Me.forestButton.Name = "forestButton"
        Me.forestButton.Size = New System.Drawing.Size(254, 77)
        Me.forestButton.TabIndex = 2
        Me.forestButton.Text = "The &Forests of Brynthia"
        Me.forestButton.UseVisualStyleBackColor = False
        '
        'plainsButton
        '
        Me.plainsButton.BackColor = System.Drawing.SystemColors.Info
        Me.plainsButton.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plainsButton.Location = New System.Drawing.Point(83, 118)
        Me.plainsButton.Margin = New System.Windows.Forms.Padding(6)
        Me.plainsButton.Name = "plainsButton"
        Me.plainsButton.Size = New System.Drawing.Size(254, 77)
        Me.plainsButton.TabIndex = 1
        Me.plainsButton.Text = "The &Plains of Durnin"
        Me.plainsButton.UseVisualStyleBackColor = False
        '
        'desertButton
        '
        Me.desertButton.BackColor = System.Drawing.SystemColors.Info
        Me.desertButton.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desertButton.Location = New System.Drawing.Point(455, 118)
        Me.desertButton.Margin = New System.Windows.Forms.Padding(6)
        Me.desertButton.Name = "desertButton"
        Me.desertButton.Size = New System.Drawing.Size(254, 77)
        Me.desertButton.TabIndex = 3
        Me.desertButton.Text = "The &Desert of Zenon"
        Me.desertButton.UseVisualStyleBackColor = False
        '
        'introRichTextBox
        '
        Me.introRichTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.introRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.introRichTextBox.Location = New System.Drawing.Point(65, 35)
        Me.introRichTextBox.Name = "introRichTextBox"
        Me.introRichTextBox.ReadOnly = True
        Me.introRichTextBox.Size = New System.Drawing.Size(796, 472)
        Me.introRichTextBox.TabIndex = 0
        Me.introRichTextBox.Text = resources.GetString("introRichTextBox.Text")
        '
        'startLocationGroupBox
        '
        Me.startLocationGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.startLocationGroupBox.Controls.Add(Me.forestButton)
        Me.startLocationGroupBox.Controls.Add(Me.icelandButton)
        Me.startLocationGroupBox.Controls.Add(Me.plainsButton)
        Me.startLocationGroupBox.Controls.Add(Me.desertButton)
        Me.startLocationGroupBox.Location = New System.Drawing.Point(65, 514)
        Me.startLocationGroupBox.Name = "startLocationGroupBox"
        Me.startLocationGroupBox.Size = New System.Drawing.Size(796, 204)
        Me.startLocationGroupBox.TabIndex = 1
        Me.startLocationGroupBox.TabStop = false
        Me.startLocationGroupBox.Text = "Select Starting Citadel"
        '
        'startPositionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12!, 25!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DarkTower.My.Resources.Resources.New_Game_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(918, 757)
        Me.Controls.Add(Me.startLocationGroupBox)
        Me.Controls.Add(Me.introRichTextBox)
        Me.Font = New System.Drawing.Font("Papyrus", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "startPositionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.startLocationGroupBox.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents icelandButton As Button
    Friend WithEvents forestButton As Button
    Friend WithEvents plainsButton As Button
    Friend WithEvents desertButton As Button
    Friend WithEvents introRichTextBox As RichTextBox
    Friend WithEvents startLocationGroupBox As GroupBox
End Class
