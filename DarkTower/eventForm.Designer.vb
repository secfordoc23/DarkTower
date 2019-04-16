<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eventForm
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
        Me.eventPictureBox = New System.Windows.Forms.PictureBox()
        Me.eventRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.okButton = New System.Windows.Forms.Button()
        CType(Me.eventPictureBox,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'eventPictureBox
        '
        Me.eventPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.eventPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.eventPictureBox.Name = "eventPictureBox"
        Me.eventPictureBox.Size = New System.Drawing.Size(170, 162)
        Me.eventPictureBox.TabIndex = 0
        Me.eventPictureBox.TabStop = false
        '
        'eventRichTextBox
        '
        Me.eventRichTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.eventRichTextBox.Font = New System.Drawing.Font("Papyrus", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.eventRichTextBox.Location = New System.Drawing.Point(188, 12)
        Me.eventRichTextBox.Name = "eventRichTextBox"
        Me.eventRichTextBox.ReadOnly = true
        Me.eventRichTextBox.Size = New System.Drawing.Size(448, 162)
        Me.eventRichTextBox.TabIndex = 1
        Me.eventRichTextBox.Text = ""
        '
        'okButton
        '
        Me.okButton.BackColor = System.Drawing.SystemColors.Info
        Me.okButton.Font = New System.Drawing.Font("Papyrus", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.okButton.Location = New System.Drawing.Point(527, 180)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(109, 40)
        Me.okButton.TabIndex = 2
        Me.okButton.Text = "&Close"
        Me.okButton.UseVisualStyleBackColor = false
        '
        'eventForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DarkTower.My.Resources.Resources.GameBackground
        Me.ClientSize = New System.Drawing.Size(644, 232)
        Me.ControlBox = false
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.eventRichTextBox)
        Me.Controls.Add(Me.eventPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "eventForm"
        Me.ShowIcon = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.eventPictureBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents eventPictureBox As PictureBox
    Friend WithEvents eventRichTextBox As RichTextBox
    Friend WithEvents okButton As Button
End Class
