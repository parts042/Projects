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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.tabSuntron = New System.Windows.Forms.TabPage
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSuntronLastNum = New System.Windows.Forms.TextBox
        Me.txtSuntronFirstNum = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnSuntronOpen = New System.Windows.Forms.Button
        Me.btnSuntronSave = New System.Windows.Forms.Button
        Me.lstSuntronList = New System.Windows.Forms.ListBox
        Me.lblSuntronRecordCount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblSuntronSelectedCount = New System.Windows.Forms.Label
        Me.tabRateProfile = New System.Windows.Forms.TabPage
        Me.lblRateProfRecordCount = New System.Windows.Forms.Label
        Me.lstRateProfSimList = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnRateProfileSave = New System.Windows.Forms.Button
        Me.btnRateProfileOpen = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rdoRateProfRawFile = New System.Windows.Forms.RadioButton
        Me.rdoRateProfQCFile = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdoRateProfDomestic = New System.Windows.Forms.RadioButton
        Me.rdoRateProfInternational = New System.Windows.Forms.RadioButton
        Me.tabActivate = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdoActvInternational = New System.Windows.Forms.RadioButton
        Me.rdoActvDomestic = New System.Windows.Forms.RadioButton
        Me.btnActvOpen = New System.Windows.Forms.Button
        Me.btnActvSave = New System.Windows.Forms.Button
        Me.lstActvSimList = New System.Windows.Forms.ListBox
        Me.lblActvRecordCount = New System.Windows.Forms.Label
        Me.lblTotalRecs = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdoActvQCFile = New System.Windows.Forms.RadioButton
        Me.rdoActvRawFile = New System.Windows.Forms.RadioButton
        Me.XpTabControl1 = New VSControls.XPTabControl
        Me.tabDeactivate = New System.Windows.Forms.TabPage
        Me.btnCreateDeactivationFile = New System.Windows.Forms.Button
        Me.txtDeacOrderNum = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnDeactivateOpen = New System.Windows.Forms.Button
        Me.lstDeacSimList = New System.Windows.Forms.ListBox
        Me.lblDeactivateRecordCount = New System.Windows.Forms.Label
        Me.lblDeacRecsFound = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdoDeacFromQC = New System.Windows.Forms.RadioButton
        Me.rdoDeacFromRaw = New System.Windows.Forms.RadioButton
        Me.StatusStrip1.SuspendLayout()
        Me.tabSuntron.SuspendLayout()
        Me.tabRateProfile.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.tabActivate.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.XpTabControl1.SuspendLayout()
        Me.tabDeactivate.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Title = "Open sim card file"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(11, 38)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(83, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "International"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(11, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Domestic"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(11, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(72, 17)
        Me.RadioButton3.TabIndex = 10
        Me.RadioButton3.Text = "Activation"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(11, 38)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton4.TabIndex = 9
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Suntron"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 581)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(313, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.AutoToolTip = True
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(115, 17)
        Me.ToolStripStatusLabel.Text = "ToolStripStatusLabel"
        '
        'tabSuntron
        '
        Me.tabSuntron.Controls.Add(Me.Label6)
        Me.tabSuntron.Controls.Add(Me.txtSuntronLastNum)
        Me.tabSuntron.Controls.Add(Me.txtSuntronFirstNum)
        Me.tabSuntron.Controls.Add(Me.Label5)
        Me.tabSuntron.Controls.Add(Me.btnSuntronOpen)
        Me.tabSuntron.Controls.Add(Me.btnSuntronSave)
        Me.tabSuntron.Controls.Add(Me.lstSuntronList)
        Me.tabSuntron.Controls.Add(Me.lblSuntronRecordCount)
        Me.tabSuntron.Controls.Add(Me.Label2)
        Me.tabSuntron.Controls.Add(Me.Label3)
        Me.tabSuntron.Controls.Add(Me.lblSuntronSelectedCount)
        Me.tabSuntron.Location = New System.Drawing.Point(4, 4)
        Me.tabSuntron.Name = "tabSuntron"
        Me.tabSuntron.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSuntron.Size = New System.Drawing.Size(306, 540)
        Me.tabSuntron.TabIndex = 1
        Me.tabSuntron.Text = "Suntron File"
        Me.tabSuntron.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(108, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Last Number"
        '
        'txtSuntronLastNum
        '
        Me.txtSuntronLastNum.Location = New System.Drawing.Point(110, 53)
        Me.txtSuntronLastNum.Name = "txtSuntronLastNum"
        Me.txtSuntronLastNum.Size = New System.Drawing.Size(186, 20)
        Me.txtSuntronLastNum.TabIndex = 15
        Me.txtSuntronLastNum.TabStop = False
        '
        'txtSuntronFirstNum
        '
        Me.txtSuntronFirstNum.Location = New System.Drawing.Point(110, 14)
        Me.txtSuntronFirstNum.MaxLength = 21
        Me.txtSuntronFirstNum.Name = "txtSuntronFirstNum"
        Me.txtSuntronFirstNum.Size = New System.Drawing.Size(186, 20)
        Me.txtSuntronFirstNum.TabIndex = 14
        Me.txtSuntronFirstNum.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(108, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "First Number"
        '
        'btnSuntronOpen
        '
        Me.btnSuntronOpen.Location = New System.Drawing.Point(2, 2)
        Me.btnSuntronOpen.Name = "btnSuntronOpen"
        Me.btnSuntronOpen.Size = New System.Drawing.Size(100, 33)
        Me.btnSuntronOpen.TabIndex = 13
        Me.btnSuntronOpen.TabStop = False
        Me.btnSuntronOpen.Text = "Open Sim File"
        Me.btnSuntronOpen.UseVisualStyleBackColor = True
        '
        'btnSuntronSave
        '
        Me.btnSuntronSave.Location = New System.Drawing.Point(2, 41)
        Me.btnSuntronSave.Name = "btnSuntronSave"
        Me.btnSuntronSave.Size = New System.Drawing.Size(100, 33)
        Me.btnSuntronSave.TabIndex = 16
        Me.btnSuntronSave.TabStop = False
        Me.btnSuntronSave.Text = "Save File"
        Me.btnSuntronSave.UseVisualStyleBackColor = True
        '
        'lstSuntronList
        '
        Me.lstSuntronList.FormattingEnabled = True
        Me.lstSuntronList.Location = New System.Drawing.Point(110, 83)
        Me.lstSuntronList.Name = "lstSuntronList"
        Me.lstSuntronList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstSuntronList.Size = New System.Drawing.Size(186, 121)
        Me.lstSuntronList.TabIndex = 17
        Me.lstSuntronList.TabStop = False
        '
        'lblSuntronRecordCount
        '
        Me.lblSuntronRecordCount.AutoSize = True
        Me.lblSuntronRecordCount.Enabled = False
        Me.lblSuntronRecordCount.Location = New System.Drawing.Point(252, 205)
        Me.lblSuntronRecordCount.Name = "lblSuntronRecordCount"
        Me.lblSuntronRecordCount.Size = New System.Drawing.Size(13, 13)
        Me.lblSuntronRecordCount.TabIndex = 19
        Me.lblSuntronRecordCount.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Total records found:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Selected: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSuntronSelectedCount
        '
        Me.lblSuntronSelectedCount.AutoSize = True
        Me.lblSuntronSelectedCount.Enabled = False
        Me.lblSuntronSelectedCount.Location = New System.Drawing.Point(252, 220)
        Me.lblSuntronSelectedCount.Name = "lblSuntronSelectedCount"
        Me.lblSuntronSelectedCount.Size = New System.Drawing.Size(13, 13)
        Me.lblSuntronSelectedCount.TabIndex = 23
        Me.lblSuntronSelectedCount.Text = "0"
        '
        'tabRateProfile
        '
        Me.tabRateProfile.Controls.Add(Me.lblRateProfRecordCount)
        Me.tabRateProfile.Controls.Add(Me.lstRateProfSimList)
        Me.tabRateProfile.Controls.Add(Me.Label4)
        Me.tabRateProfile.Controls.Add(Me.btnRateProfileSave)
        Me.tabRateProfile.Controls.Add(Me.btnRateProfileOpen)
        Me.tabRateProfile.Controls.Add(Me.GroupBox4)
        Me.tabRateProfile.Controls.Add(Me.GroupBox5)
        Me.tabRateProfile.Location = New System.Drawing.Point(4, 4)
        Me.tabRateProfile.Name = "tabRateProfile"
        Me.tabRateProfile.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRateProfile.Size = New System.Drawing.Size(306, 540)
        Me.tabRateProfile.TabIndex = 2
        Me.tabRateProfile.Text = "Rate / Profile Change"
        Me.tabRateProfile.UseVisualStyleBackColor = True
        '
        'lblRateProfRecordCount
        '
        Me.lblRateProfRecordCount.AutoSize = True
        Me.lblRateProfRecordCount.Enabled = False
        Me.lblRateProfRecordCount.Location = New System.Drawing.Point(252, 220)
        Me.lblRateProfRecordCount.Name = "lblRateProfRecordCount"
        Me.lblRateProfRecordCount.Size = New System.Drawing.Size(13, 13)
        Me.lblRateProfRecordCount.TabIndex = 19
        Me.lblRateProfRecordCount.Text = "0"
        '
        'lstRateProfSimList
        '
        Me.lstRateProfSimList.FormattingEnabled = True
        Me.lstRateProfSimList.Location = New System.Drawing.Point(110, 3)
        Me.lstRateProfSimList.Name = "lstRateProfSimList"
        Me.lstRateProfSimList.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstRateProfSimList.Size = New System.Drawing.Size(186, 212)
        Me.lstRateProfSimList.TabIndex = 4
        Me.lstRateProfSimList.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Total records found:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnRateProfileSave
        '
        Me.btnRateProfileSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRateProfileSave.Location = New System.Drawing.Point(2, 183)
        Me.btnRateProfileSave.Name = "btnRateProfileSave"
        Me.btnRateProfileSave.Size = New System.Drawing.Size(100, 33)
        Me.btnRateProfileSave.TabIndex = 12
        Me.btnRateProfileSave.TabStop = False
        Me.btnRateProfileSave.Text = "Create File(s)"
        Me.btnRateProfileSave.UseVisualStyleBackColor = True
        '
        'btnRateProfileOpen
        '
        Me.btnRateProfileOpen.Location = New System.Drawing.Point(2, 2)
        Me.btnRateProfileOpen.Name = "btnRateProfileOpen"
        Me.btnRateProfileOpen.Size = New System.Drawing.Size(100, 33)
        Me.btnRateProfileOpen.TabIndex = 7
        Me.btnRateProfileOpen.TabStop = False
        Me.btnRateProfileOpen.Text = "Open Sim File"
        Me.btnRateProfileOpen.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdoRateProfRawFile)
        Me.GroupBox4.Controls.Add(Me.rdoRateProfQCFile)
        Me.GroupBox4.Location = New System.Drawing.Point(2, 42)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(100, 62)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Source File"
        '
        'rdoRateProfRawFile
        '
        Me.rdoRateProfRawFile.AutoSize = True
        Me.rdoRateProfRawFile.Location = New System.Drawing.Point(9, 38)
        Me.rdoRateProfRawFile.Name = "rdoRateProfRawFile"
        Me.rdoRateProfRawFile.Size = New System.Drawing.Size(66, 17)
        Me.rdoRateProfRawFile.TabIndex = 9
        Me.rdoRateProfRawFile.Text = "Raw File"
        Me.rdoRateProfRawFile.UseVisualStyleBackColor = True
        '
        'rdoRateProfQCFile
        '
        Me.rdoRateProfQCFile.AutoSize = True
        Me.rdoRateProfQCFile.Checked = True
        Me.rdoRateProfQCFile.Location = New System.Drawing.Point(9, 17)
        Me.rdoRateProfQCFile.Name = "rdoRateProfQCFile"
        Me.rdoRateProfQCFile.Size = New System.Drawing.Size(59, 17)
        Me.rdoRateProfQCFile.TabIndex = 8
        Me.rdoRateProfQCFile.TabStop = True
        Me.rdoRateProfQCFile.Text = "QC File"
        Me.rdoRateProfQCFile.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdoRateProfDomestic)
        Me.GroupBox5.Controls.Add(Me.rdoRateProfInternational)
        Me.GroupBox5.Location = New System.Drawing.Point(2, 112)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(100, 62)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Profile"
        '
        'rdoRateProfDomestic
        '
        Me.rdoRateProfDomestic.AutoSize = True
        Me.rdoRateProfDomestic.Location = New System.Drawing.Point(9, 17)
        Me.rdoRateProfDomestic.Name = "rdoRateProfDomestic"
        Me.rdoRateProfDomestic.Size = New System.Drawing.Size(69, 17)
        Me.rdoRateProfDomestic.TabIndex = 10
        Me.rdoRateProfDomestic.Text = "Domestic"
        Me.rdoRateProfDomestic.UseVisualStyleBackColor = True
        '
        'rdoRateProfInternational
        '
        Me.rdoRateProfInternational.AutoSize = True
        Me.rdoRateProfInternational.Checked = True
        Me.rdoRateProfInternational.Location = New System.Drawing.Point(9, 38)
        Me.rdoRateProfInternational.Name = "rdoRateProfInternational"
        Me.rdoRateProfInternational.Size = New System.Drawing.Size(83, 17)
        Me.rdoRateProfInternational.TabIndex = 11
        Me.rdoRateProfInternational.TabStop = True
        Me.rdoRateProfInternational.Text = "International"
        Me.rdoRateProfInternational.UseVisualStyleBackColor = True
        '
        'tabActivate
        '
        Me.tabActivate.Controls.Add(Me.GroupBox2)
        Me.tabActivate.Controls.Add(Me.btnActvOpen)
        Me.tabActivate.Controls.Add(Me.btnActvSave)
        Me.tabActivate.Controls.Add(Me.lstActvSimList)
        Me.tabActivate.Controls.Add(Me.lblActvRecordCount)
        Me.tabActivate.Controls.Add(Me.lblTotalRecs)
        Me.tabActivate.Controls.Add(Me.GroupBox1)
        Me.tabActivate.Location = New System.Drawing.Point(4, 4)
        Me.tabActivate.Name = "tabActivate"
        Me.tabActivate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabActivate.Size = New System.Drawing.Size(306, 540)
        Me.tabActivate.TabIndex = 0
        Me.tabActivate.Text = "Activation"
        Me.tabActivate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoActvInternational)
        Me.GroupBox2.Controls.Add(Me.rdoActvDomestic)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(100, 62)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profile"
        '
        'rdoActvInternational
        '
        Me.rdoActvInternational.AutoSize = True
        Me.rdoActvInternational.Location = New System.Drawing.Point(9, 38)
        Me.rdoActvInternational.Name = "rdoActvInternational"
        Me.rdoActvInternational.Size = New System.Drawing.Size(83, 17)
        Me.rdoActvInternational.TabIndex = 5
        Me.rdoActvInternational.Text = "International"
        Me.rdoActvInternational.UseVisualStyleBackColor = True
        '
        'rdoActvDomestic
        '
        Me.rdoActvDomestic.AutoSize = True
        Me.rdoActvDomestic.Checked = True
        Me.rdoActvDomestic.Location = New System.Drawing.Point(9, 17)
        Me.rdoActvDomestic.Name = "rdoActvDomestic"
        Me.rdoActvDomestic.Size = New System.Drawing.Size(69, 17)
        Me.rdoActvDomestic.TabIndex = 4
        Me.rdoActvDomestic.TabStop = True
        Me.rdoActvDomestic.Text = "Domestic"
        Me.rdoActvDomestic.UseVisualStyleBackColor = True
        '
        'btnActvOpen
        '
        Me.btnActvOpen.Location = New System.Drawing.Point(2, 2)
        Me.btnActvOpen.Name = "btnActvOpen"
        Me.btnActvOpen.Size = New System.Drawing.Size(100, 33)
        Me.btnActvOpen.TabIndex = 1
        Me.btnActvOpen.TabStop = False
        Me.btnActvOpen.Text = "Open Sim File"
        Me.btnActvOpen.UseVisualStyleBackColor = True
        '
        'btnActvSave
        '
        Me.btnActvSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActvSave.Location = New System.Drawing.Point(2, 183)
        Me.btnActvSave.Name = "btnActvSave"
        Me.btnActvSave.Size = New System.Drawing.Size(100, 33)
        Me.btnActvSave.TabIndex = 6
        Me.btnActvSave.TabStop = False
        Me.btnActvSave.Text = "Create" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Activation File(s)"
        Me.btnActvSave.UseVisualStyleBackColor = True
        '
        'lstActvSimList
        '
        Me.lstActvSimList.FormattingEnabled = True
        Me.lstActvSimList.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lstActvSimList.Location = New System.Drawing.Point(110, 3)
        Me.lstActvSimList.Name = "lstActvSimList"
        Me.lstActvSimList.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstActvSimList.Size = New System.Drawing.Size(186, 212)
        Me.lstActvSimList.TabIndex = 0
        Me.lstActvSimList.TabStop = False
        '
        'lblActvRecordCount
        '
        Me.lblActvRecordCount.AutoSize = True
        Me.lblActvRecordCount.Enabled = False
        Me.lblActvRecordCount.Location = New System.Drawing.Point(252, 220)
        Me.lblActvRecordCount.Name = "lblActvRecordCount"
        Me.lblActvRecordCount.Size = New System.Drawing.Size(13, 13)
        Me.lblActvRecordCount.TabIndex = 4
        Me.lblActvRecordCount.Text = "0"
        '
        'lblTotalRecs
        '
        Me.lblTotalRecs.AutoSize = True
        Me.lblTotalRecs.Location = New System.Drawing.Point(138, 220)
        Me.lblTotalRecs.Name = "lblTotalRecs"
        Me.lblTotalRecs.Size = New System.Drawing.Size(102, 13)
        Me.lblTotalRecs.TabIndex = 5
        Me.lblTotalRecs.Text = "Total records found:"
        Me.lblTotalRecs.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoActvQCFile)
        Me.GroupBox1.Controls.Add(Me.rdoActvRawFile)
        Me.GroupBox1.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox1.Location = New System.Drawing.Point(2, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 62)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source File"
        '
        'rdoActvQCFile
        '
        Me.rdoActvQCFile.AutoSize = True
        Me.rdoActvQCFile.Checked = True
        Me.rdoActvQCFile.ForeColor = System.Drawing.SystemColors.WindowText
        Me.rdoActvQCFile.Location = New System.Drawing.Point(9, 17)
        Me.rdoActvQCFile.Name = "rdoActvQCFile"
        Me.rdoActvQCFile.Size = New System.Drawing.Size(59, 17)
        Me.rdoActvQCFile.TabIndex = 2
        Me.rdoActvQCFile.TabStop = True
        Me.rdoActvQCFile.Text = "QC File"
        Me.rdoActvQCFile.UseVisualStyleBackColor = True
        '
        'rdoActvRawFile
        '
        Me.rdoActvRawFile.AutoSize = True
        Me.rdoActvRawFile.ForeColor = System.Drawing.SystemColors.WindowText
        Me.rdoActvRawFile.Location = New System.Drawing.Point(9, 38)
        Me.rdoActvRawFile.Name = "rdoActvRawFile"
        Me.rdoActvRawFile.Size = New System.Drawing.Size(66, 17)
        Me.rdoActvRawFile.TabIndex = 3
        Me.rdoActvRawFile.Text = "Raw File"
        Me.rdoActvRawFile.UseVisualStyleBackColor = True
        '
        'XpTabControl1
        '
        Me.XpTabControl1.Controls.Add(Me.tabActivate)
        Me.XpTabControl1.Controls.Add(Me.tabRateProfile)
        Me.XpTabControl1.Controls.Add(Me.tabSuntron)
        Me.XpTabControl1.Controls.Add(Me.tabDeactivate)
        Me.XpTabControl1.Location = New System.Drawing.Point(1, 2)
        Me.XpTabControl1.Name = "XpTabControl1"
        Me.XpTabControl1.SelectedIndex = 0
        Me.XpTabControl1.Size = New System.Drawing.Size(314, 566)
        Me.XpTabControl1.TabIndex = 17
        Me.XpTabControl1.TabStop = False
        '
        'tabDeactivate
        '
        Me.tabDeactivate.Controls.Add(Me.btnCreateDeactivationFile)
        Me.tabDeactivate.Controls.Add(Me.txtDeacOrderNum)
        Me.tabDeactivate.Controls.Add(Me.Label8)
        Me.tabDeactivate.Controls.Add(Me.btnDeactivateOpen)
        Me.tabDeactivate.Controls.Add(Me.lstDeacSimList)
        Me.tabDeactivate.Controls.Add(Me.lblDeactivateRecordCount)
        Me.tabDeactivate.Controls.Add(Me.lblDeacRecsFound)
        Me.tabDeactivate.Controls.Add(Me.GroupBox3)
        Me.tabDeactivate.Location = New System.Drawing.Point(4, 4)
        Me.tabDeactivate.Name = "tabDeactivate"
        Me.tabDeactivate.Size = New System.Drawing.Size(306, 540)
        Me.tabDeactivate.TabIndex = 3
        Me.tabDeactivate.Text = "Deactivate"
        Me.tabDeactivate.UseVisualStyleBackColor = True
        '
        'btnCreateDeactivationFile
        '
        Me.btnCreateDeactivationFile.Enabled = False
        Me.btnCreateDeactivationFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.btnCreateDeactivationFile.Location = New System.Drawing.Point(3, 182)
        Me.btnCreateDeactivationFile.Name = "btnCreateDeactivationFile"
        Me.btnCreateDeactivationFile.Size = New System.Drawing.Size(100, 33)
        Me.btnCreateDeactivationFile.TabIndex = 20
        Me.btnCreateDeactivationFile.Text = "Create" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deactivation File"
        Me.btnCreateDeactivationFile.UseVisualStyleBackColor = True
        '
        'txtDeacOrderNum
        '
        Me.txtDeacOrderNum.Location = New System.Drawing.Point(3, 123)
        Me.txtDeacOrderNum.Name = "txtDeacOrderNum"
        Me.txtDeacOrderNum.Size = New System.Drawing.Size(100, 20)
        Me.txtDeacOrderNum.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Order #"
        '
        'btnDeactivateOpen
        '
        Me.btnDeactivateOpen.Location = New System.Drawing.Point(3, 3)
        Me.btnDeactivateOpen.Name = "btnDeactivateOpen"
        Me.btnDeactivateOpen.Size = New System.Drawing.Size(100, 33)
        Me.btnDeactivateOpen.TabIndex = 13
        Me.btnDeactivateOpen.TabStop = False
        Me.btnDeactivateOpen.Text = "Open Sim File"
        Me.btnDeactivateOpen.UseVisualStyleBackColor = True
        '
        'lstDeacSimList
        '
        Me.lstDeacSimList.FormattingEnabled = True
        Me.lstDeacSimList.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.lstDeacSimList.Location = New System.Drawing.Point(110, 3)
        Me.lstDeacSimList.Name = "lstDeacSimList"
        Me.lstDeacSimList.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstDeacSimList.Size = New System.Drawing.Size(186, 212)
        Me.lstDeacSimList.TabIndex = 12
        Me.lstDeacSimList.TabStop = False
        '
        'lblDeactivateRecordCount
        '
        Me.lblDeactivateRecordCount.AutoSize = True
        Me.lblDeactivateRecordCount.Enabled = False
        Me.lblDeactivateRecordCount.Location = New System.Drawing.Point(252, 220)
        Me.lblDeactivateRecordCount.Name = "lblDeactivateRecordCount"
        Me.lblDeactivateRecordCount.Size = New System.Drawing.Size(13, 13)
        Me.lblDeactivateRecordCount.TabIndex = 14
        Me.lblDeactivateRecordCount.Text = "0"
        '
        'lblDeacRecsFound
        '
        Me.lblDeacRecsFound.AutoSize = True
        Me.lblDeacRecsFound.Location = New System.Drawing.Point(138, 220)
        Me.lblDeacRecsFound.Name = "lblDeacRecsFound"
        Me.lblDeacRecsFound.Size = New System.Drawing.Size(102, 13)
        Me.lblDeacRecsFound.TabIndex = 15
        Me.lblDeacRecsFound.Text = "Total records found:"
        Me.lblDeacRecsFound.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdoDeacFromQC)
        Me.GroupBox3.Controls.Add(Me.rdoDeacFromRaw)
        Me.GroupBox3.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox3.Location = New System.Drawing.Point(3, 42)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(100, 62)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Source File"
        '
        'rdoDeacFromQC
        '
        Me.rdoDeacFromQC.AutoSize = True
        Me.rdoDeacFromQC.Checked = True
        Me.rdoDeacFromQC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.rdoDeacFromQC.Location = New System.Drawing.Point(9, 17)
        Me.rdoDeacFromQC.Name = "rdoDeacFromQC"
        Me.rdoDeacFromQC.Size = New System.Drawing.Size(59, 17)
        Me.rdoDeacFromQC.TabIndex = 2
        Me.rdoDeacFromQC.TabStop = True
        Me.rdoDeacFromQC.Text = "QC File"
        Me.rdoDeacFromQC.UseVisualStyleBackColor = True
        '
        'rdoDeacFromRaw
        '
        Me.rdoDeacFromRaw.AutoSize = True
        Me.rdoDeacFromRaw.ForeColor = System.Drawing.SystemColors.WindowText
        Me.rdoDeacFromRaw.Location = New System.Drawing.Point(9, 38)
        Me.rdoDeacFromRaw.Name = "rdoDeacFromRaw"
        Me.rdoDeacFromRaw.Size = New System.Drawing.Size(66, 17)
        Me.rdoDeacFromRaw.TabIndex = 3
        Me.rdoDeacFromRaw.Text = "Raw File"
        Me.rdoDeacFromRaw.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(313, 603)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.XpTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sim Management - for EOD sims"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.tabSuntron.ResumeLayout(False)
        Me.tabSuntron.PerformLayout()
        Me.tabRateProfile.ResumeLayout(False)
        Me.tabRateProfile.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.tabActivate.ResumeLayout(False)
        Me.tabActivate.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.XpTabControl1.ResumeLayout(False)
        Me.tabDeactivate.ResumeLayout(False)
        Me.tabDeactivate.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tabSuntron As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSuntronLastNum As System.Windows.Forms.TextBox
    Friend WithEvents txtSuntronFirstNum As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSuntronOpen As System.Windows.Forms.Button
    Friend WithEvents btnSuntronSave As System.Windows.Forms.Button
    Friend WithEvents lstSuntronList As System.Windows.Forms.ListBox
    Friend WithEvents lblSuntronRecordCount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSuntronSelectedCount As System.Windows.Forms.Label
    Friend WithEvents tabRateProfile As System.Windows.Forms.TabPage
    Friend WithEvents lblRateProfRecordCount As System.Windows.Forms.Label
    Friend WithEvents lstRateProfSimList As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRateProfileSave As System.Windows.Forms.Button
    Friend WithEvents btnRateProfileOpen As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoRateProfRawFile As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRateProfQCFile As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoRateProfDomestic As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRateProfInternational As System.Windows.Forms.RadioButton
    Friend WithEvents tabActivate As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoActvInternational As System.Windows.Forms.RadioButton
    Friend WithEvents rdoActvDomestic As System.Windows.Forms.RadioButton
    Friend WithEvents btnActvOpen As System.Windows.Forms.Button
    Friend WithEvents btnActvSave As System.Windows.Forms.Button
    Friend WithEvents lstActvSimList As System.Windows.Forms.ListBox
    Friend WithEvents lblActvRecordCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalRecs As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoActvQCFile As System.Windows.Forms.RadioButton
    Friend WithEvents rdoActvRawFile As System.Windows.Forms.RadioButton
    Friend WithEvents XpTabControl1 As VSControls.XPTabControl
    Friend WithEvents tabDeactivate As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnDeactivateOpen As System.Windows.Forms.Button
    Friend WithEvents lstDeacSimList As System.Windows.Forms.ListBox
    Friend WithEvents lblDeactivateRecordCount As System.Windows.Forms.Label
    Friend WithEvents lblDeacRecsFound As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoDeacFromQC As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDeacFromRaw As System.Windows.Forms.RadioButton
    Friend WithEvents btnCreateDeactivationFile As System.Windows.Forms.Button
    Friend WithEvents txtDeacOrderNum As System.Windows.Forms.TextBox

End Class
