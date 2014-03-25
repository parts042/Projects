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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtInstallDoc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdInstallDoc = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SelectPrinterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblNavLeft = New System.Windows.Forms.Label()
        Me.lblNavRight = New System.Windows.Forms.Label()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblConfig = New System.Windows.Forms.Label()
        Me.lblCable1 = New System.Windows.Forms.Label()
        Me.lblCable2 = New System.Windows.Forms.Label()
        Me.lblCable3 = New System.Windows.Forms.Label()
        Me.lblCable4 = New System.Windows.Forms.Label()
        Me.lblCable5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRecordTotal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.radPrintAll = New System.Windows.Forms.RadioButton()
        Me.radPrintSelected = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.SupportMultiDottedExtensions = True
        '
        'txtInstallDoc
        '
        Me.txtInstallDoc.AllowDrop = True
        Me.txtInstallDoc.Location = New System.Drawing.Point(6, 56)
        Me.txtInstallDoc.Name = "txtInstallDoc"
        Me.txtInstallDoc.ShortcutsEnabled = False
        Me.txtInstallDoc.Size = New System.Drawing.Size(281, 20)
        Me.txtInstallDoc.TabIndex = 0
        Me.txtInstallDoc.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Install Doc"
        '
        'cmdInstallDoc
        '
        Me.cmdInstallDoc.Location = New System.Drawing.Point(293, 56)
        Me.cmdInstallDoc.Name = "cmdInstallDoc"
        Me.cmdInstallDoc.Size = New System.Drawing.Size(27, 20)
        Me.cmdInstallDoc.TabIndex = 2
        Me.cmdInstallDoc.Text = "..."
        Me.cmdInstallDoc.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(116, 474)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(93, 27)
        Me.cmdPrint.TabIndex = 6
        Me.cmdPrint.Text = "Print Labels"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        Me.OpenFileDialog2.SupportMultiDottedExtensions = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectPrinterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(324, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SelectPrinterToolStripMenuItem
        '
        Me.SelectPrinterToolStripMenuItem.AutoSize = False
        Me.SelectPrinterToolStripMenuItem.Name = "SelectPrinterToolStripMenuItem"
        Me.SelectPrinterToolStripMenuItem.Size = New System.Drawing.Size(315, 20)
        Me.SelectPrinterToolStripMenuItem.Text = "Selected Printer: "
        Me.SelectPrinterToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(324, 505)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 325
        Me.LineShape1.Y1 = 24
        Me.LineShape1.Y2 = 24
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.CornerRadius = 25
        Me.RectangleShape1.FillColor = System.Drawing.SystemColors.Window
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(10, 1)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(286, 286)
        '
        'lblNavLeft
        '
        Me.lblNavLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNavLeft.Image = CType(resources.GetObject("lblNavLeft.Image"), System.Drawing.Image)
        Me.lblNavLeft.Location = New System.Drawing.Point(87, 310)
        Me.lblNavLeft.Name = "lblNavLeft"
        Me.lblNavLeft.Size = New System.Drawing.Size(24, 24)
        Me.lblNavLeft.TabIndex = 9
        '
        'lblNavRight
        '
        Me.lblNavRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNavRight.Image = CType(resources.GetObject("lblNavRight.Image"), System.Drawing.Image)
        Me.lblNavRight.Location = New System.Drawing.Point(202, 310)
        Me.lblNavRight.Name = "lblNavRight"
        Me.lblNavRight.Size = New System.Drawing.Size(24, 24)
        Me.lblNavRight.TabIndex = 10
        '
        'lblRecordCount
        '
        Me.lblRecordCount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRecordCount.Location = New System.Drawing.Point(122, 316)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(31, 13)
        Me.lblRecordCount.TabIndex = 11
        Me.lblRecordCount.Text = "9999"
        Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(37, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 26)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Customer:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(70, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 26)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Order:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(65, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 26)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Config:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(50, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 26)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cable(s):"
        '
        'lblCustomer
        '
        Me.lblCustomer.BackColor = System.Drawing.SystemColors.Window
        Me.lblCustomer.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.lblCustomer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCustomer.Location = New System.Drawing.Point(144, 37)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(137, 26)
        Me.lblCustomer.TabIndex = 16
        Me.lblCustomer.Text = "lblCustomer"
        '
        'lblOrder
        '
        Me.lblOrder.BackColor = System.Drawing.SystemColors.Window
        Me.lblOrder.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.lblOrder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOrder.Location = New System.Drawing.Point(144, 68)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(137, 26)
        Me.lblOrder.TabIndex = 17
        Me.lblOrder.Text = "lblOrder"
        '
        'lblConfig
        '
        Me.lblConfig.BackColor = System.Drawing.SystemColors.Window
        Me.lblConfig.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.lblConfig.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblConfig.Location = New System.Drawing.Point(144, 99)
        Me.lblConfig.Name = "lblConfig"
        Me.lblConfig.Size = New System.Drawing.Size(137, 26)
        Me.lblConfig.TabIndex = 18
        Me.lblConfig.Text = "lblConfig"
        '
        'lblCable1
        '
        Me.lblCable1.BackColor = System.Drawing.SystemColors.Window
        Me.lblCable1.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.lblCable1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCable1.Location = New System.Drawing.Point(144, 130)
        Me.lblCable1.Name = "lblCable1"
        Me.lblCable1.Size = New System.Drawing.Size(137, 26)
        Me.lblCable1.TabIndex = 19
        Me.lblCable1.Text = "lblCable1"
        '
        'lblCable2
        '
        Me.lblCable2.BackColor = System.Drawing.SystemColors.Window
        Me.lblCable2.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.lblCable2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCable2.Location = New System.Drawing.Point(144, 161)
        Me.lblCable2.Name = "lblCable2"
        Me.lblCable2.Size = New System.Drawing.Size(137, 26)
        Me.lblCable2.TabIndex = 20
        Me.lblCable2.Text = "lblCable2"
        '
        'lblCable3
        '
        Me.lblCable3.BackColor = System.Drawing.SystemColors.Window
        Me.lblCable3.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.lblCable3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCable3.Location = New System.Drawing.Point(144, 192)
        Me.lblCable3.Name = "lblCable3"
        Me.lblCable3.Size = New System.Drawing.Size(137, 26)
        Me.lblCable3.TabIndex = 21
        Me.lblCable3.Text = "lblCable3"
        '
        'lblCable4
        '
        Me.lblCable4.BackColor = System.Drawing.SystemColors.Window
        Me.lblCable4.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.lblCable4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCable4.Location = New System.Drawing.Point(144, 223)
        Me.lblCable4.Name = "lblCable4"
        Me.lblCable4.Size = New System.Drawing.Size(137, 26)
        Me.lblCable4.TabIndex = 22
        Me.lblCable4.Text = "lblCable4"
        '
        'lblCable5
        '
        Me.lblCable5.BackColor = System.Drawing.SystemColors.Window
        Me.lblCable5.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.lblCable5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCable5.Location = New System.Drawing.Point(144, 254)
        Me.lblCable5.Name = "lblCable5"
        Me.lblCable5.Size = New System.Drawing.Size(137, 26)
        Me.lblCable5.TabIndex = 23
        Me.lblCable5.Text = "lblCable5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(149, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "of"
        '
        'lblRecordTotal
        '
        Me.lblRecordTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRecordTotal.Location = New System.Drawing.Point(161, 316)
        Me.lblRecordTotal.Name = "lblRecordTotal"
        Me.lblRecordTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblRecordTotal.TabIndex = 25
        Me.lblRecordTotal.Text = "9999"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radPrintSelected)
        Me.GroupBox1.Controls.Add(Me.radPrintAll)
        Me.GroupBox1.Controls.Add(Me.lblRecordTotal)
        Me.GroupBox1.Controls.Add(Me.lblNavRight)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblRecordCount)
        Me.GroupBox1.Controls.Add(Me.lblNavLeft)
        Me.GroupBox1.Controls.Add(Me.lblCable5)
        Me.GroupBox1.Controls.Add(Me.lblCable4)
        Me.GroupBox1.Controls.Add(Me.lblCable3)
        Me.GroupBox1.Controls.Add(Me.lblCable2)
        Me.GroupBox1.Controls.Add(Me.lblCable1)
        Me.GroupBox1.Controls.Add(Me.lblConfig)
        Me.GroupBox1.Controls.Add(Me.lblOrder)
        Me.GroupBox1.Controls.Add(Me.lblCustomer)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(6, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 364)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(308, 345)
        Me.ShapeContainer2.TabIndex = 24
        Me.ShapeContainer2.TabStop = False
        '
        'radPrintAll
        '
        Me.radPrintAll.AutoSize = True
        Me.radPrintAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radPrintAll.Location = New System.Drawing.Point(81, 341)
        Me.radPrintAll.Name = "radPrintAll"
        Me.radPrintAll.Size = New System.Drawing.Size(60, 17)
        Me.radPrintAll.TabIndex = 26
        Me.radPrintAll.TabStop = True
        Me.radPrintAll.Text = "Print All"
        Me.radPrintAll.UseVisualStyleBackColor = True
        '
        'radPrintSelected
        '
        Me.radPrintSelected.AutoSize = True
        Me.radPrintSelected.ForeColor = System.Drawing.SystemColors.ControlText
        Me.radPrintSelected.Location = New System.Drawing.Point(147, 341)
        Me.radPrintSelected.Name = "radPrintSelected"
        Me.radPrintSelected.Size = New System.Drawing.Size(91, 17)
        Me.radPrintSelected.TabIndex = 27
        Me.radPrintSelected.TabStop = True
        Me.radPrintSelected.Text = "Print Selected"
        Me.radPrintSelected.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 505)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdInstallDoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInstallDoc)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtInstallDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdInstallDoc As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SelectPrinterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblNavLeft As System.Windows.Forms.Label
    Friend WithEvents lblNavRight As System.Windows.Forms.Label
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents lblConfig As System.Windows.Forms.Label
    Friend WithEvents lblCable1 As System.Windows.Forms.Label
    Friend WithEvents lblCable2 As System.Windows.Forms.Label
    Friend WithEvents lblCable3 As System.Windows.Forms.Label
    Friend WithEvents lblCable4 As System.Windows.Forms.Label
    Friend WithEvents lblCable5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRecordTotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents radPrintSelected As System.Windows.Forms.RadioButton
    Friend WithEvents radPrintAll As System.Windows.Forms.RadioButton

End Class
