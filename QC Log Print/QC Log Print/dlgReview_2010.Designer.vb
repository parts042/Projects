<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReview_2010
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.lblFreeReportCheck = New System.Windows.Forms.Label()
        Me.lblFirmwareCheck = New System.Windows.Forms.Label()
        Me.lblBatteryCheck = New System.Windows.Forms.Label()
        Me.lblTimeZoneCheck = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRecordsFound = New System.Windows.Forms.Label()
        Me.lblDupeCheck = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(184, 286)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'lblFreeReportCheck
        '
        Me.lblFreeReportCheck.AutoSize = True
        Me.lblFreeReportCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFreeReportCheck.ForeColor = System.Drawing.Color.Purple
        Me.lblFreeReportCheck.Location = New System.Drawing.Point(12, 100)
        Me.lblFreeReportCheck.Name = "lblFreeReportCheck"
        Me.lblFreeReportCheck.Size = New System.Drawing.Size(172, 16)
        Me.lblFreeReportCheck.TabIndex = 24
        Me.lblFreeReportCheck.Text = "Free Report check... OK"
        '
        'lblFirmwareCheck
        '
        Me.lblFirmwareCheck.AutoSize = True
        Me.lblFirmwareCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirmwareCheck.ForeColor = System.Drawing.Color.Purple
        Me.lblFirmwareCheck.Location = New System.Drawing.Point(12, 123)
        Me.lblFirmwareCheck.Name = "lblFirmwareCheck"
        Me.lblFirmwareCheck.Size = New System.Drawing.Size(152, 16)
        Me.lblFirmwareCheck.TabIndex = 25
        Me.lblFirmwareCheck.Text = "Firmware check... OK"
        '
        'lblBatteryCheck
        '
        Me.lblBatteryCheck.AutoSize = True
        Me.lblBatteryCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatteryCheck.ForeColor = System.Drawing.Color.Purple
        Me.lblBatteryCheck.Location = New System.Drawing.Point(12, 146)
        Me.lblBatteryCheck.Name = "lblBatteryCheck"
        Me.lblBatteryCheck.Size = New System.Drawing.Size(151, 16)
        Me.lblBatteryCheck.TabIndex = 26
        Me.lblBatteryCheck.Text = "Battery Voltage... OK"
        '
        'lblTimeZoneCheck
        '
        Me.lblTimeZoneCheck.AutoSize = True
        Me.lblTimeZoneCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeZoneCheck.ForeColor = System.Drawing.Color.Purple
        Me.lblTimeZoneCheck.Location = New System.Drawing.Point(12, 169)
        Me.lblTimeZoneCheck.Name = "lblTimeZoneCheck"
        Me.lblTimeZoneCheck.Size = New System.Drawing.Size(164, 16)
        Me.lblTimeZoneCheck.TabIndex = 27
        Me.lblTimeZoneCheck.Text = "Time Zone:  -7 DSTON"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Please review your QC file for any errors"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 24)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Ready to print"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Click 'OK' to print or 'Cancel' to fix any errors"
        '
        'lblRecordsFound
        '
        Me.lblRecordsFound.AutoSize = True
        Me.lblRecordsFound.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordsFound.Location = New System.Drawing.Point(13, 204)
        Me.lblRecordsFound.Name = "lblRecordsFound"
        Me.lblRecordsFound.Size = New System.Drawing.Size(142, 18)
        Me.lblRecordsFound.TabIndex = 31
        Me.lblRecordsFound.Text = "99 Records found"
        '
        'lblDupeCheck
        '
        Me.lblDupeCheck.AutoSize = True
        Me.lblDupeCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDupeCheck.ForeColor = System.Drawing.Color.Purple
        Me.lblDupeCheck.Location = New System.Drawing.Point(13, 77)
        Me.lblDupeCheck.Name = "lblDupeCheck"
        Me.lblDupeCheck.Size = New System.Drawing.Size(146, 16)
        Me.lblDupeCheck.TabIndex = 32
        Me.lblDupeCheck.Text = "No duplicates found"
        '
        'dlgReview_2010
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(342, 327)
        Me.Controls.Add(Me.lblDupeCheck)
        Me.Controls.Add(Me.lblRecordsFound)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTimeZoneCheck)
        Me.Controls.Add(Me.lblBatteryCheck)
        Me.Controls.Add(Me.lblFirmwareCheck)
        Me.Controls.Add(Me.lblFreeReportCheck)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReview_2010"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblFreeReportCheck As System.Windows.Forms.Label
    Friend WithEvents lblFirmwareCheck As System.Windows.Forms.Label
    Friend WithEvents lblBatteryCheck As System.Windows.Forms.Label
    Friend WithEvents lblTimeZoneCheck As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRecordsFound As System.Windows.Forms.Label
    Friend WithEvents lblDupeCheck As System.Windows.Forms.Label

End Class
