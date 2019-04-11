<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashForm
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
        Me.components = New System.ComponentModel.Container()
        Me.copyRightLabe = New System.Windows.Forms.Label()
        Me.splashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.javaPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.javaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'copyRightLabe
        '
        Me.copyRightLabe.AutoSize = True
        Me.copyRightLabe.BackColor = System.Drawing.Color.Transparent
        Me.copyRightLabe.Location = New System.Drawing.Point(141, 359)
        Me.copyRightLabe.Name = "copyRightLabe"
        Me.copyRightLabe.Size = New System.Drawing.Size(134, 20)
        Me.copyRightLabe.TabIndex = 2
        Me.copyRightLabe.Text = "(C) J. Welch 2019"
        '
        'splashTimer
        '
        Me.splashTimer.Enabled = True
        Me.splashTimer.Interval = 3000
        '
        'javaPictureBox
        '
        Me.javaPictureBox.BackgroundImage = Global.DarkTower.My.Resources.Resources.DarkTowerIcon
        Me.javaPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.javaPictureBox.Location = New System.Drawing.Point(45, 29)
        Me.javaPictureBox.Name = "javaPictureBox"
        Me.javaPictureBox.Size = New System.Drawing.Size(321, 327)
        Me.javaPictureBox.TabIndex = 1
        Me.javaPictureBox.TabStop = False
        '
        'splashForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = Global.DarkTower.My.Resources.Resources.New_Game_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(417, 430)
        Me.ControlBox = False
        Me.Controls.Add(Me.copyRightLabe)
        Me.Controls.Add(Me.javaPictureBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "splashForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.javaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents javaPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents copyRightLabe As System.Windows.Forms.Label
    Friend WithEvents splashTimer As System.Windows.Forms.Timer
End Class
