<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class combatForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(combatForm))
        Me.combatLogListBox = New System.Windows.Forms.ListBox()
        Me.okButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'combatLogListBox
        '
        Me.combatLogListBox.BackColor = System.Drawing.SystemColors.Info
        Me.combatLogListBox.FormattingEnabled = True
        Me.combatLogListBox.ItemHeight = 25
        Me.combatLogListBox.Location = New System.Drawing.Point(16, 17)
        Me.combatLogListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.combatLogListBox.Name = "combatLogListBox"
        Me.combatLogListBox.Size = New System.Drawing.Size(438, 354)
        Me.combatLogListBox.TabIndex = 0
        '
        'okButton
        '
        Me.okButton.BackColor = System.Drawing.SystemColors.Info
        Me.okButton.Location = New System.Drawing.Point(153, 379)
        Me.okButton.Margin = New System.Windows.Forms.Padding(4)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(156, 58)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "&OK"
        Me.okButton.UseVisualStyleBackColor = False
        '
        'combatForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DarkTower.My.Resources.Resources.GameBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(474, 450)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.combatLogListBox)
        Me.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "combatForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Battle with Brigands!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents combatLogListBox As ListBox
    Friend WithEvents okButton As Button
End Class
