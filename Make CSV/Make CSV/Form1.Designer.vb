<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chk1120Aux = New System.Windows.Forms.CheckBox
        Me.chk1120Asset = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkScratchExtended = New System.Windows.Forms.CheckBox
        Me.chkScratchAux = New System.Windows.Forms.CheckBox
        Me.chkScratchOp = New System.Windows.Forms.CheckBox
        Me.chkScratchAsset = New System.Windows.Forms.CheckBox
        Me.btnProcess = New System.Windows.Forms.Button
        Me.grpAsset = New System.Windows.Forms.GroupBox
        Me.txtNumAssets = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAssetStartNum = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpOpCards = New System.Windows.Forms.GroupBox
        Me.txtNumOpCards = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOpCardStartNum = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.grpExtAsset = New System.Windows.Forms.GroupBox
        Me.cmbNumTagsPerSet = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNumExtAssetSets = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtExtAssetyStartNum = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpAsset.SuspendLayout()
        CType(Me.txtNumAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOpCards.SuspendLayout()
        CType(Me.txtNumOpCards, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExtAsset.SuspendLayout()
        CType(Me.txtNumExtAssetSets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk1120Aux)
        Me.GroupBox1.Controls.Add(Me.chk1120Asset)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 60)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "From 1120 "
        '
        'chk1120Aux
        '
        Me.chk1120Aux.AutoSize = True
        Me.chk1120Aux.Enabled = False
        Me.chk1120Aux.Location = New System.Drawing.Point(10, 37)
        Me.chk1120Aux.Name = "chk1120Aux"
        Me.chk1120Aux.Size = New System.Drawing.Size(71, 17)
        Me.chk1120Aux.TabIndex = 1
        Me.chk1120Aux.Text = "Aux Tags"
        Me.chk1120Aux.UseVisualStyleBackColor = True
        '
        'chk1120Asset
        '
        Me.chk1120Asset.AutoSize = True
        Me.chk1120Asset.Location = New System.Drawing.Point(10, 18)
        Me.chk1120Asset.Name = "chk1120Asset"
        Me.chk1120Asset.Size = New System.Drawing.Size(52, 17)
        Me.chk1120Asset.TabIndex = 0
        Me.chk1120Asset.Text = "Asset"
        Me.chk1120Asset.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkScratchExtended)
        Me.GroupBox2.Controls.Add(Me.chkScratchAux)
        Me.GroupBox2.Controls.Add(Me.chkScratchOp)
        Me.GroupBox2.Controls.Add(Me.chkScratchAsset)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 94)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "From Scratch"
        '
        'chkScratchExtended
        '
        Me.chkScratchExtended.AutoSize = True
        Me.chkScratchExtended.Location = New System.Drawing.Point(10, 72)
        Me.chkScratchExtended.Name = "chkScratchExtended"
        Me.chkScratchExtended.Size = New System.Drawing.Size(105, 17)
        Me.chkScratchExtended.TabIndex = 3
        Me.chkScratchExtended.Text = "Extended Assets"
        Me.chkScratchExtended.UseVisualStyleBackColor = True
        '
        'chkScratchAux
        '
        Me.chkScratchAux.AutoSize = True
        Me.chkScratchAux.Enabled = False
        Me.chkScratchAux.Location = New System.Drawing.Point(10, 54)
        Me.chkScratchAux.Name = "chkScratchAux"
        Me.chkScratchAux.Size = New System.Drawing.Size(66, 17)
        Me.chkScratchAux.TabIndex = 2
        Me.chkScratchAux.Text = "Aux Tag"
        Me.chkScratchAux.UseVisualStyleBackColor = True
        '
        'chkScratchOp
        '
        Me.chkScratchOp.AutoSize = True
        Me.chkScratchOp.Location = New System.Drawing.Point(10, 36)
        Me.chkScratchOp.Name = "chkScratchOp"
        Me.chkScratchOp.Size = New System.Drawing.Size(92, 17)
        Me.chkScratchOp.TabIndex = 1
        Me.chkScratchOp.Text = "Operator Card"
        Me.chkScratchOp.UseVisualStyleBackColor = True
        '
        'chkScratchAsset
        '
        Me.chkScratchAsset.AutoSize = True
        Me.chkScratchAsset.Checked = True
        Me.chkScratchAsset.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkScratchAsset.Location = New System.Drawing.Point(10, 18)
        Me.chkScratchAsset.Name = "chkScratchAsset"
        Me.chkScratchAsset.Size = New System.Drawing.Size(52, 17)
        Me.chkScratchAsset.TabIndex = 0
        Me.chkScratchAsset.Text = "Asset"
        Me.chkScratchAsset.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnProcess.Location = New System.Drawing.Point(80, 186)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(76, 23)
        Me.btnProcess.TabIndex = 2
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'grpAsset
        '
        Me.grpAsset.Controls.Add(Me.txtNumAssets)
        Me.grpAsset.Controls.Add(Me.Label2)
        Me.grpAsset.Controls.Add(Me.txtAssetStartNum)
        Me.grpAsset.Controls.Add(Me.Label1)
        Me.grpAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAsset.ForeColor = System.Drawing.Color.Red
        Me.grpAsset.Location = New System.Drawing.Point(249, 126)
        Me.grpAsset.Name = "grpAsset"
        Me.grpAsset.Size = New System.Drawing.Size(191, 107)
        Me.grpAsset.TabIndex = 3
        Me.grpAsset.TabStop = False
        Me.grpAsset.Text = "Asset Information"
        '
        'txtNumAssets
        '
        Me.txtNumAssets.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumAssets.Location = New System.Drawing.Point(101, 46)
        Me.txtNumAssets.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtNumAssets.Name = "txtNumAssets"
        Me.txtNumAssets.Size = New System.Drawing.Size(76, 20)
        Me.txtNumAssets.TabIndex = 3
        Me.txtNumAssets.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "How many tags?"
        '
        'txtAssetStartNum
        '
        Me.txtAssetStartNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssetStartNum.Location = New System.Drawing.Point(101, 18)
        Me.txtAssetStartNum.MaxLength = 10
        Me.txtAssetStartNum.Name = "txtAssetStartNum"
        Me.txtAssetStartNum.Size = New System.Drawing.Size(76, 20)
        Me.txtAssetStartNum.TabIndex = 1
        Me.txtAssetStartNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Starting number"
        '
        'grpOpCards
        '
        Me.grpOpCards.Controls.Add(Me.txtNumOpCards)
        Me.grpOpCards.Controls.Add(Me.Label3)
        Me.grpOpCards.Controls.Add(Me.txtOpCardStartNum)
        Me.grpOpCards.Controls.Add(Me.Label4)
        Me.grpOpCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOpCards.ForeColor = System.Drawing.Color.Red
        Me.grpOpCards.Location = New System.Drawing.Point(249, 13)
        Me.grpOpCards.Name = "grpOpCards"
        Me.grpOpCards.Size = New System.Drawing.Size(191, 107)
        Me.grpOpCards.TabIndex = 4
        Me.grpOpCards.TabStop = False
        Me.grpOpCards.Text = "Operator Card Information"
        '
        'txtNumOpCards
        '
        Me.txtNumOpCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOpCards.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNumOpCards.Location = New System.Drawing.Point(101, 46)
        Me.txtNumOpCards.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtNumOpCards.Name = "txtNumOpCards"
        Me.txtNumOpCards.Size = New System.Drawing.Size(76, 20)
        Me.txtNumOpCards.TabIndex = 3
        Me.txtNumOpCards.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "How many cards?"
        '
        'txtOpCardStartNum
        '
        Me.txtOpCardStartNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpCardStartNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtOpCardStartNum.Location = New System.Drawing.Point(101, 18)
        Me.txtOpCardStartNum.MaxLength = 10
        Me.txtOpCardStartNum.Name = "txtOpCardStartNum"
        Me.txtOpCardStartNum.Size = New System.Drawing.Size(76, 20)
        Me.txtOpCardStartNum.TabIndex = 1
        Me.txtOpCardStartNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(17, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Starting number"
        '
        'grpExtAsset
        '
        Me.grpExtAsset.Controls.Add(Me.cmbNumTagsPerSet)
        Me.grpExtAsset.Controls.Add(Me.Label7)
        Me.grpExtAsset.Controls.Add(Me.txtNumExtAssetSets)
        Me.grpExtAsset.Controls.Add(Me.Label5)
        Me.grpExtAsset.Controls.Add(Me.txtExtAssetyStartNum)
        Me.grpExtAsset.Controls.Add(Me.Label6)
        Me.grpExtAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpExtAsset.ForeColor = System.Drawing.Color.Red
        Me.grpExtAsset.Location = New System.Drawing.Point(446, 13)
        Me.grpExtAsset.Name = "grpExtAsset"
        Me.grpExtAsset.Size = New System.Drawing.Size(191, 107)
        Me.grpExtAsset.TabIndex = 5
        Me.grpExtAsset.TabStop = False
        Me.grpExtAsset.Text = "Ext. Asset Tag Information"
        '
        'cmbNumTagsPerSet
        '
        Me.cmbNumTagsPerSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumTagsPerSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbNumTagsPerSet.FormattingEnabled = True
        Me.cmbNumTagsPerSet.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbNumTagsPerSet.Location = New System.Drawing.Point(110, 43)
        Me.cmbNumTagsPerSet.MaxDropDownItems = 4
        Me.cmbNumTagsPerSet.Name = "cmbNumTagsPerSet"
        Me.cmbNumTagsPerSet.Size = New System.Drawing.Size(66, 21)
        Me.cmbNumTagsPerSet.TabIndex = 5
        Me.cmbNumTagsPerSet.Text = "3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(10, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "How many per set?"
        '
        'txtNumExtAssetSets
        '
        Me.txtNumExtAssetSets.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumExtAssetSets.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNumExtAssetSets.Location = New System.Drawing.Point(101, 69)
        Me.txtNumExtAssetSets.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.txtNumExtAssetSets.Name = "txtNumExtAssetSets"
        Me.txtNumExtAssetSets.Size = New System.Drawing.Size(76, 20)
        Me.txtNumExtAssetSets.TabIndex = 3
        Me.txtNumExtAssetSets.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(13, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "How many sets?"
        '
        'txtExtAssetyStartNum
        '
        Me.txtExtAssetyStartNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtAssetyStartNum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtExtAssetyStartNum.Location = New System.Drawing.Point(101, 18)
        Me.txtExtAssetyStartNum.MaxLength = 10
        Me.txtExtAssetyStartNum.Name = "txtExtAssetyStartNum"
        Me.txtExtAssetyStartNum.Size = New System.Drawing.Size(76, 20)
        Me.txtExtAssetyStartNum.TabIndex = 1
        Me.txtExtAssetyStartNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(17, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Starting number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 340)
        Me.Controls.Add(Me.grpExtAsset)
        Me.Controls.Add(Me.grpOpCards)
        Me.Controls.Add(Me.grpAsset)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make CSV"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpAsset.ResumeLayout(False)
        Me.grpAsset.PerformLayout()
        CType(Me.txtNumAssets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOpCards.ResumeLayout(False)
        Me.grpOpCards.PerformLayout()
        CType(Me.txtNumOpCards, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExtAsset.ResumeLayout(False)
        Me.grpExtAsset.PerformLayout()
        CType(Me.txtNumExtAssetSets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk1120Aux As System.Windows.Forms.CheckBox
    Friend WithEvents chk1120Asset As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkScratchAux As System.Windows.Forms.CheckBox
    Friend WithEvents chkScratchOp As System.Windows.Forms.CheckBox
    Friend WithEvents chkScratchAsset As System.Windows.Forms.CheckBox
    Friend WithEvents chkScratchExtended As System.Windows.Forms.CheckBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents grpAsset As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumAssets As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAssetStartNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpOpCards As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumOpCards As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOpCardStartNum As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpExtAsset As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumExtAssetSets As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtExtAssetyStartNum As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbNumTagsPerSet As System.Windows.Forms.ComboBox

End Class
