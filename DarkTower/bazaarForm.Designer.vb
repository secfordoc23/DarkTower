<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bazaarForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bazaarForm))
        Me.buyButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.consumableGroupBox = New System.Windows.Forms.GroupBox()
        Me.foodLabel = New System.Windows.Forms.Label()
        Me.foodComboBox = New System.Windows.Forms.ComboBox()
        Me.warriorLabel = New System.Windows.Forms.Label()
        Me.warriorComboBox = New System.Windows.Forms.ComboBox()
        Me.oneTimeBuyGroupBox = New System.Windows.Forms.GroupBox()
        Me.beastCheckBox = New System.Windows.Forms.CheckBox()
        Me.healerCheckBox = New System.Windows.Forms.CheckBox()
        Me.scoutCheckBox = New System.Windows.Forms.CheckBox()
        Me.purchaseTotalLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.currentGoldLabel = New System.Windows.Forms.Label()
        Me.goldPictureBox = New System.Windows.Forms.PictureBox()
        Me.consumableGroupBox.SuspendLayout()
        Me.oneTimeBuyGroupBox.SuspendLayout()
        CType(Me.goldPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buyButton
        '
        Me.buyButton.BackColor = System.Drawing.SystemColors.Info
        Me.buyButton.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buyButton.Location = New System.Drawing.Point(350, 168)
        Me.buyButton.Margin = New System.Windows.Forms.Padding(4)
        Me.buyButton.Name = "buyButton"
        Me.buyButton.Size = New System.Drawing.Size(100, 46)
        Me.buyButton.TabIndex = 2
        Me.buyButton.Text = "&Buy"
        Me.buyButton.UseVisualStyleBackColor = False
        '
        'cancelButton
        '
        Me.cancelButton.BackColor = System.Drawing.SystemColors.Info
        Me.cancelButton.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.Location = New System.Drawing.Point(458, 168)
        Me.cancelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(100, 46)
        Me.cancelButton.TabIndex = 3
        Me.cancelButton.Text = "&Cancel"
        Me.cancelButton.UseVisualStyleBackColor = False
        '
        'consumableGroupBox
        '
        Me.consumableGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.consumableGroupBox.Controls.Add(Me.foodLabel)
        Me.consumableGroupBox.Controls.Add(Me.foodComboBox)
        Me.consumableGroupBox.Controls.Add(Me.warriorLabel)
        Me.consumableGroupBox.Controls.Add(Me.warriorComboBox)
        Me.consumableGroupBox.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consumableGroupBox.Location = New System.Drawing.Point(17, 16)
        Me.consumableGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.consumableGroupBox.Name = "consumableGroupBox"
        Me.consumableGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.consumableGroupBox.Size = New System.Drawing.Size(325, 144)
        Me.consumableGroupBox.TabIndex = 0
        Me.consumableGroupBox.TabStop = False
        Me.consumableGroupBox.Text = "Consumables"
        '
        'foodLabel
        '
        Me.foodLabel.AutoSize = True
        Me.foodLabel.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodLabel.Location = New System.Drawing.Point(8, 90)
        Me.foodLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.foodLabel.Name = "foodLabel"
        Me.foodLabel.Size = New System.Drawing.Size(168, 25)
        Me.foodLabel.TabIndex = 2
        Me.foodLabel.Text = "Food (1 Gold each)"
        '
        'foodComboBox
        '
        Me.foodComboBox.BackColor = System.Drawing.SystemColors.Info
        Me.foodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.foodComboBox.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodComboBox.FormattingEnabled = True
        Me.foodComboBox.Location = New System.Drawing.Point(214, 82)
        Me.foodComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.foodComboBox.Name = "foodComboBox"
        Me.foodComboBox.Size = New System.Drawing.Size(90, 33)
        Me.foodComboBox.TabIndex = 3
        '
        'warriorLabel
        '
        Me.warriorLabel.AutoSize = True
        Me.warriorLabel.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warriorLabel.Location = New System.Drawing.Point(8, 32)
        Me.warriorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.warriorLabel.Name = "warriorLabel"
        Me.warriorLabel.Size = New System.Drawing.Size(191, 25)
        Me.warriorLabel.TabIndex = 0
        Me.warriorLabel.Text = "Warriors (5 Gold each)"
        '
        'warriorComboBox
        '
        Me.warriorComboBox.BackColor = System.Drawing.SystemColors.Info
        Me.warriorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.warriorComboBox.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warriorComboBox.FormattingEnabled = True
        Me.warriorComboBox.Location = New System.Drawing.Point(214, 29)
        Me.warriorComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.warriorComboBox.Name = "warriorComboBox"
        Me.warriorComboBox.Size = New System.Drawing.Size(90, 33)
        Me.warriorComboBox.TabIndex = 1
        '
        'oneTimeBuyGroupBox
        '
        Me.oneTimeBuyGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.oneTimeBuyGroupBox.Controls.Add(Me.beastCheckBox)
        Me.oneTimeBuyGroupBox.Controls.Add(Me.healerCheckBox)
        Me.oneTimeBuyGroupBox.Controls.Add(Me.scoutCheckBox)
        Me.oneTimeBuyGroupBox.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oneTimeBuyGroupBox.Location = New System.Drawing.Point(350, 16)
        Me.oneTimeBuyGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.oneTimeBuyGroupBox.Name = "oneTimeBuyGroupBox"
        Me.oneTimeBuyGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.oneTimeBuyGroupBox.Size = New System.Drawing.Size(208, 144)
        Me.oneTimeBuyGroupBox.TabIndex = 1
        Me.oneTimeBuyGroupBox.TabStop = False
        Me.oneTimeBuyGroupBox.Text = "One-Time Buy"
        '
        'beastCheckBox
        '
        Me.beastCheckBox.AutoSize = True
        Me.beastCheckBox.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.beastCheckBox.Location = New System.Drawing.Point(19, 105)
        Me.beastCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.beastCheckBox.Name = "beastCheckBox"
        Me.beastCheckBox.Size = New System.Drawing.Size(163, 29)
        Me.beastCheckBox.TabIndex = 2
        Me.beastCheckBox.Text = "Beast (20 Gold)"
        Me.beastCheckBox.UseVisualStyleBackColor = True
        '
        'healerCheckBox
        '
        Me.healerCheckBox.AutoSize = True
        Me.healerCheckBox.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.healerCheckBox.Location = New System.Drawing.Point(19, 68)
        Me.healerCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.healerCheckBox.Name = "healerCheckBox"
        Me.healerCheckBox.Size = New System.Drawing.Size(167, 29)
        Me.healerCheckBox.TabIndex = 1
        Me.healerCheckBox.Text = "Healer (20 Gold)"
        Me.healerCheckBox.UseVisualStyleBackColor = True
        '
        'scoutCheckBox
        '
        Me.scoutCheckBox.AutoSize = True
        Me.scoutCheckBox.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoutCheckBox.Location = New System.Drawing.Point(19, 31)
        Me.scoutCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.scoutCheckBox.Name = "scoutCheckBox"
        Me.scoutCheckBox.Size = New System.Drawing.Size(164, 29)
        Me.scoutCheckBox.TabIndex = 0
        Me.scoutCheckBox.Text = "Scout (20 Gold)"
        Me.scoutCheckBox.UseVisualStyleBackColor = True
        '
        'purchaseTotalLabel
        '
        Me.purchaseTotalLabel.BackColor = System.Drawing.Color.Transparent
        Me.purchaseTotalLabel.Font = New System.Drawing.Font("Papyrus", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchaseTotalLabel.Location = New System.Drawing.Point(206, 174)
        Me.purchaseTotalLabel.Name = "purchaseTotalLabel"
        Me.purchaseTotalLabel.Size = New System.Drawing.Size(38, 25)
        Me.purchaseTotalLabel.TabIndex = 4
        Me.purchaseTotalLabel.Text = "0"
        Me.purchaseTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Papyrus", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(250, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "/"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'currentGoldLabel
        '
        Me.currentGoldLabel.BackColor = System.Drawing.Color.Transparent
        Me.currentGoldLabel.Font = New System.Drawing.Font("Papyrus", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentGoldLabel.Location = New System.Drawing.Point(284, 174)
        Me.currentGoldLabel.Name = "currentGoldLabel"
        Me.currentGoldLabel.Size = New System.Drawing.Size(34, 25)
        Me.currentGoldLabel.TabIndex = 6
        Me.currentGoldLabel.Text = "0"
        Me.currentGoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'goldPictureBox
        '
        Me.goldPictureBox.BackgroundImage = Global.DarkTower.My.Resources.Resources.gold
        Me.goldPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.goldPictureBox.Location = New System.Drawing.Point(104, 167)
        Me.goldPictureBox.Name = "goldPictureBox"
        Me.goldPictureBox.Size = New System.Drawing.Size(89, 60)
        Me.goldPictureBox.TabIndex = 27
        Me.goldPictureBox.TabStop = False
        '
        'bazaarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DarkTower.My.Resources.Resources.GameBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(575, 245)
        Me.Controls.Add(Me.goldPictureBox)
        Me.Controls.Add(Me.currentGoldLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.purchaseTotalLabel)
        Me.Controls.Add(Me.oneTimeBuyGroupBox)
        Me.Controls.Add(Me.consumableGroupBox)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.buyButton)
        Me.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "bazaarForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bazaar"
        Me.consumableGroupBox.ResumeLayout(False)
        Me.consumableGroupBox.PerformLayout()
        Me.oneTimeBuyGroupBox.ResumeLayout(False)
        Me.oneTimeBuyGroupBox.PerformLayout()
        CType(Me.goldPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Friend WithEvents buyButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents consumableGroupBox As GroupBox
    Friend WithEvents foodLabel As Label
    Friend WithEvents foodComboBox As ComboBox
    Friend WithEvents warriorLabel As Label
    Friend WithEvents warriorComboBox As ComboBox
    Friend WithEvents oneTimeBuyGroupBox As GroupBox
    Friend WithEvents beastCheckBox As CheckBox
    Friend WithEvents healerCheckBox As CheckBox
    Friend WithEvents scoutCheckBox As CheckBox
    Friend WithEvents purchaseTotalLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents currentGoldLabel As Label
    Friend WithEvents goldPictureBox As PictureBox
End Class
