<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class combatForm
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
        Me.combatLogListBox = New System.Windows.Forms.ListBox()
        Me.okButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'combatLogListBox
        '
        Me.combatLogListBox.FormattingEnabled = True
        Me.combatLogListBox.ItemHeight = 18
        Me.combatLogListBox.Location = New System.Drawing.Point(12, 12)
        Me.combatLogListBox.Name = "combatLogListBox"
        Me.combatLogListBox.Size = New System.Drawing.Size(422, 346)
        Me.combatLogListBox.TabIndex = 0
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(174, 364)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(117, 42)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'combatForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 418)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.combatLogListBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "combatForm"
        Me.Text = "Battle with Brigands!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents combatLogListBox As ListBox
    Friend WithEvents okButton As Button
End Class
