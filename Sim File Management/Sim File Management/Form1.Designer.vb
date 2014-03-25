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
        Me.lstSimList = New System.Windows.Forms.ListBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnOpen = New System.Windows.Forms.Button
        Me.lblRecordCount = New System.Windows.Forms.Label
        Me.lblTotalRecs = New System.Windows.Forms.Label
        Me.txtFindNumber = New System.Windows.Forms.TextBox
        Me.lblSelected = New System.Windows.Forms.Label
        Me.lblSelectedCount = New System.Windows.Forms.Label
        Me.rdoSuntron = New System.Windows.Forms.RadioButton
        Me.rdoActivation = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdoInternational = New System.Windows.Forms.RadioButton
        Me.rdoDomestic = New System.Windows.Forms.RadioButton
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnSave = New System.Windows.Forms.Button
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog
        Me.XpTabControl1 = New VSControls.XPTabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.XpTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstSimList
        '
        Me.lstSimList.Enabled = False
        Me.lstSimList.FormattingEnabled = True
        Me.lstSimList.Location = New System.Drawing.Point(111, 40)
        Me.lstSimList.Name = "lstSimList"
        Me.lstSimList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstSimList.Size = New System.Drawing.Size(158, 186)
        Me.lstSimList.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Title = "Open sim card file"
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(6, 6)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(84, 33)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open Sim File"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'lblRecordCount
        '
        Me.lblRecordCount.AutoSize = True
        Me.lblRecordCount.Enabled = False
        Me.lblRecordCount.Location = New System.Drawing.Point(227, 229)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(13, 13)
        Me.lblRecordCount.TabIndex = 4
        Me.lblRecordCount.Text = "0"
        '
        'lblTotalRecs
        '
        Me.lblTotalRecs.AutoSize = True
        Me.lblTotalRecs.Enabled = False
        Me.lblTotalRecs.Location = New System.Drawing.Point(114, 229)
        Me.lblTotalRecs.Name = "lblTotalRecs"
        Me.lblTotalRecs.Size = New System.Drawing.Size(102, 13)
        Me.lblTotalRecs.TabIndex = 5
        Me.lblTotalRecs.Text = "Total records found:"
        Me.lblTotalRecs.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtFindNumber
        '
        Me.txtFindNumber.Enabled = False
        Me.txtFindNumber.Location = New System.Drawing.Point(111, 7)
        Me.txtFindNumber.MaxLength = 21
        Me.txtFindNumber.Name = "txtFindNumber"
        Me.txtFindNumber.Size = New System.Drawing.Size(158, 20)
        Me.txtFindNumber.TabIndex = 6
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Enabled = False
        Me.lblSelected.Location = New System.Drawing.Point(164, 248)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(55, 13)
        Me.lblSelected.TabIndex = 7
        Me.lblSelected.Text = "Selected: "
        Me.lblSelected.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSelectedCount
        '
        Me.lblSelectedCount.AutoSize = True
        Me.lblSelectedCount.Enabled = False
        Me.lblSelectedCount.Location = New System.Drawing.Point(227, 248)
        Me.lblSelectedCount.Name = "lblSelectedCount"
        Me.lblSelectedCount.Size = New System.Drawing.Size(13, 13)
        Me.lblSelectedCount.TabIndex = 8
        Me.lblSelectedCount.Text = "0"
        '
        'rdoSuntron
        '
        Me.rdoSuntron.AutoSize = True
        Me.rdoSuntron.Checked = True
        Me.rdoSuntron.Location = New System.Drawing.Point(11, 38)
        Me.rdoSuntron.Name = "rdoSuntron"
        Me.rdoSuntron.Size = New System.Drawing.Size(62, 17)
        Me.rdoSuntron.TabIndex = 9
        Me.rdoSuntron.TabStop = True
        Me.rdoSuntron.Text = "Suntron"
        Me.rdoSuntron.UseVisualStyleBackColor = True
        '
        'rdoActivation
        '
        Me.rdoActivation.AutoSize = True
        Me.rdoActivation.Location = New System.Drawing.Point(11, 19)
        Me.rdoActivation.Name = "rdoActivation"
        Me.rdoActivation.Size = New System.Drawing.Size(72, 17)
        Me.rdoActivation.TabIndex = 10
        Me.rdoActivation.Text = "Activation"
        Me.rdoActivation.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoActivation)
        Me.GroupBox1.Controls.Add(Me.rdoSuntron)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox1.Location = New System.Drawing.Point(3, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 62)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoInternational)
        Me.GroupBox2.Controls.Add(Me.rdoDomestic)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(3, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(100, 62)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profile"
        '
        'rdoInternational
        '
        Me.rdoInternational.AutoSize = True
        Me.rdoInternational.Location = New System.Drawing.Point(11, 38)
        Me.rdoInternational.Name = "rdoInternational"
        Me.rdoInternational.Size = New System.Drawing.Size(83, 17)
        Me.rdoInternational.TabIndex = 1
        Me.rdoInternational.Text = "International"
        Me.rdoInternational.UseVisualStyleBackColor = True
        '
        'rdoDomestic
        '
        Me.rdoDomestic.AutoSize = True
        Me.rdoDomestic.Checked = True
        Me.rdoDomestic.Location = New System.Drawing.Point(11, 19)
        Me.rdoDomestic.Name = "rdoDomestic"
        Me.rdoDomestic.Size = New System.Drawing.Size(69, 17)
        Me.rdoDomestic.TabIndex = 0
        Me.rdoDomestic.TabStop = True
        Me.rdoDomestic.Text = "Domestic"
        Me.rdoDomestic.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 302)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(287, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = False
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel2.Text = "Raw File Mode Selected"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(152, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(6, 193)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 33)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'XpTabControl1
        '
        Me.XpTabControl1.Controls.Add(Me.TabPage1)
        Me.XpTabControl1.Controls.Add(Me.TabPage2)
        Me.XpTabControl1.Location = New System.Drawing.Point(1, 2)
        Me.XpTabControl1.Name = "XpTabControl1"
        Me.XpTabControl1.SelectedIndex = 0
        Me.XpTabControl1.Size = New System.Drawing.Size(286, 297)
        Me.XpTabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnOpen)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.lstSimList)
        Me.TabPage1.Controls.Add(Me.lblRecordCount)
        Me.TabPage1.Controls.Add(Me.lblTotalRecs)
        Me.TabPage1.Controls.Add(Me.txtFindNumber)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.lblSelected)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.lblSelectedCount)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(278, 271)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(192, 74)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 324)
        Me.Controls.Add(Me.XpTabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sim File Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.XpTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstSimList As System.Windows.Forms.ListBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalRecs As System.Windows.Forms.Label
    Friend WithEvents txtFindNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents lblSelectedCount As System.Windows.Forms.Label
    Friend WithEvents rdoSuntron As System.Windows.Forms.RadioButton
    Friend WithEvents rdoActivation As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoInternational As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDomestic As System.Windows.Forms.RadioButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents XpTabControl1 As VSControls.XPTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage

End Class
