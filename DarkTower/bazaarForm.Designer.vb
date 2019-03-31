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
        Me.consumableGroupBox.SuspendLayout()
        Me.oneTimeBuyGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'buyButton
        '
        Me.buyButton.Location = New System.Drawing.Point(340, 185)
        Me.buyButton.Name = "buyButton"
        Me.buyButton.Size = New System.Drawing.Size(75, 37)
        Me.buyButton.TabIndex = 0
        Me.buyButton.Text = "&Buy"
        Me.buyButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Location = New System.Drawing.Point(437, 185)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 37)
        Me.cancelButton.TabIndex = 1
        Me.cancelButton.Text = "&Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'consumableGroupBox
        '
        Me.consumableGroupBox.Controls.Add(Me.foodLabel)
        Me.consumableGroupBox.Controls.Add(Me.foodComboBox)
        Me.consumableGroupBox.Controls.Add(Me.warriorLabel)
        Me.consumableGroupBox.Controls.Add(Me.warriorComboBox)
        Me.consumableGroupBox.Location = New System.Drawing.Point(13, 13)
        Me.consumableGroupBox.Name = "consumableGroupBox"
        Me.consumableGroupBox.Size = New System.Drawing.Size(321, 166)
        Me.consumableGroupBox.TabIndex = 2
        Me.consumableGroupBox.TabStop = False
        Me.consumableGroupBox.Text = "Consumables"
        '
        'foodLabel
        '
        Me.foodLabel.AutoSize = True
        Me.foodLabel.Location = New System.Drawing.Point(6, 72)
        Me.foodLabel.Name = "foodLabel"
        Me.foodLabel.Size = New System.Drawing.Size(145, 20)
        Me.foodLabel.TabIndex = 3
        Me.foodLabel.Text = "Food - 1 Gold each"
        '
        'foodComboBox
        '
        Me.foodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.foodComboBox.FormattingEnabled = True
        Me.foodComboBox.Location = New System.Drawing.Point(194, 69)
        Me.foodComboBox.Name = "foodComboBox"
        Me.foodComboBox.Size = New System.Drawing.Size(121, 28)
        Me.foodComboBox.TabIndex = 2
        '
        'warriorLabel
        '
        Me.warriorLabel.AutoSize = True
        Me.warriorLabel.Location = New System.Drawing.Point(6, 26)
        Me.warriorLabel.Name = "warriorLabel"
        Me.warriorLabel.Size = New System.Drawing.Size(167, 20)
        Me.warriorLabel.TabIndex = 1
        Me.warriorLabel.Text = "Warriors - 5 Gold each"
        '
        'warriorComboBox
        '
        Me.warriorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.warriorComboBox.FormattingEnabled = True
        Me.warriorComboBox.Location = New System.Drawing.Point(194, 23)
        Me.warriorComboBox.Name = "warriorComboBox"
        Me.warriorComboBox.Size = New System.Drawing.Size(121, 28)
        Me.warriorComboBox.TabIndex = 0
        '
        'oneTimeBuyGroupBox
        '
        Me.oneTimeBuyGroupBox.Controls.Add(Me.beastCheckBox)
        Me.oneTimeBuyGroupBox.Controls.Add(Me.healerCheckBox)
        Me.oneTimeBuyGroupBox.Controls.Add(Me.scoutCheckBox)
        Me.oneTimeBuyGroupBox.Location = New System.Drawing.Point(340, 13)
        Me.oneTimeBuyGroupBox.Name = "oneTimeBuyGroupBox"
        Me.oneTimeBuyGroupBox.Size = New System.Drawing.Size(172, 166)
        Me.oneTimeBuyGroupBox.TabIndex = 3
        Me.oneTimeBuyGroupBox.TabStop = False
        Me.oneTimeBuyGroupBox.Text = "One-Time Buy"
        '
        'beastCheckBox
        '
        Me.beastCheckBox.AutoSize = True
        Me.beastCheckBox.Location = New System.Drawing.Point(14, 117)
        Me.beastCheckBox.Name = "beastCheckBox"
        Me.beastCheckBox.Size = New System.Drawing.Size(139, 24)
        Me.beastCheckBox.TabIndex = 2
        Me.beastCheckBox.Text = "Beast - 20 Gold"
        Me.beastCheckBox.UseVisualStyleBackColor = True
        '
        'healerCheckBox
        '
        Me.healerCheckBox.AutoSize = True
        Me.healerCheckBox.Location = New System.Drawing.Point(14, 71)
        Me.healerCheckBox.Name = "healerCheckBox"
        Me.healerCheckBox.Size = New System.Drawing.Size(144, 24)
        Me.healerCheckBox.TabIndex = 1
        Me.healerCheckBox.Text = "Healer - 20 Gold"
        Me.healerCheckBox.UseVisualStyleBackColor = True
        '
        'scoutCheckBox
        '
        Me.scoutCheckBox.AutoSize = True
        Me.scoutCheckBox.Location = New System.Drawing.Point(14, 25)
        Me.scoutCheckBox.Name = "scoutCheckBox"
        Me.scoutCheckBox.Size = New System.Drawing.Size(139, 24)
        Me.scoutCheckBox.TabIndex = 0
        Me.scoutCheckBox.Text = "Scout - 20 Gold"
        Me.scoutCheckBox.UseVisualStyleBackColor = True
        '
        'bazaarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 236)
        Me.Controls.Add(Me.oneTimeBuyGroupBox)
        Me.Controls.Add(Me.consumableGroupBox)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.buyButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "bazaarForm"
        Me.Text = "Bazaar"
        Me.consumableGroupBox.ResumeLayout(False)
        Me.consumableGroupBox.PerformLayout()
        Me.oneTimeBuyGroupBox.ResumeLayout(False)
        Me.oneTimeBuyGroupBox.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
