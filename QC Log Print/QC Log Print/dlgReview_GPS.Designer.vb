<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReview_GPS
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
        Me.lblCfg_Mgr = New System.Windows.Forms.Label
        Me.lblGPS_Model = New System.Windows.Forms.Label
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.lblGPS_Mfg = New System.Windows.Forms.Label
        Me.lblGPS_Type = New System.Windows.Forms.Label
        Me.lblDupeCheck = New System.Windows.Forms.Label
        Me.lblCount = New System.Windows.Forms.Label
        Me.OK_Button = New System.Windows.Forms.Button
        Me.lblJ3BL = New System.Windows.Forms.Label
        Me.lblJ3FW = New System.Windows.Forms.Label
        Me.lblAPN = New System.Windows.Forms.Label
        Me.lblGPSFW = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lblSimNumber = New System.Windows.Forms.Label
        Me.lblRecordType = New System.Windows.Forms.Label
        Me.lblRecordsFoundText = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCfg_Mgr
        '
        Me.lblCfg_Mgr.AutoSize = True
        Me.lblCfg_Mgr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCfg_Mgr.ForeColor = System.Drawing.Color.Purple
        Me.lblCfg_Mgr.Location = New System.Drawing.Point(25, 285)
        Me.lblCfg_Mgr.Name = "lblCfg_Mgr"
        Me.lblCfg_Mgr.Size = New System.Drawing.Size(175, 16)
        Me.lblCfg_Mgr.TabIndex = 27
        Me.lblCfg_Mgr.Text = "Cfg Mgr Type...  ERROR"
        '
        'lblGPS_Model
        '
        Me.lblGPS_Model.AutoSize = True
        Me.lblGPS_Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPS_Model.ForeColor = System.Drawing.Color.Purple
        Me.lblGPS_Model.Location = New System.Drawing.Point(25, 263)
        Me.lblGPS_Model.Name = "lblGPS_Model"
        Me.lblGPS_Model.Size = New System.Drawing.Size(160, 16)
        Me.lblGPS_Model.TabIndex = 26
        Me.lblGPS_Model.Text = "GPS Model...  ERROR"
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
        'lblGPS_Mfg
        '
        Me.lblGPS_Mfg.AutoSize = True
        Me.lblGPS_Mfg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPS_Mfg.ForeColor = System.Drawing.Color.Purple
        Me.lblGPS_Mfg.Location = New System.Drawing.Point(25, 215)
        Me.lblGPS_Mfg.Name = "lblGPS_Mfg"
        Me.lblGPS_Mfg.Size = New System.Drawing.Size(142, 16)
        Me.lblGPS_Mfg.TabIndex = 25
        Me.lblGPS_Mfg.Text = "GPS Mfg...  ERROR"
        '
        'lblGPS_Type
        '
        Me.lblGPS_Type.AutoSize = True
        Me.lblGPS_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPS_Type.ForeColor = System.Drawing.Color.Purple
        Me.lblGPS_Type.Location = New System.Drawing.Point(25, 239)
        Me.lblGPS_Type.Name = "lblGPS_Type"
        Me.lblGPS_Type.Size = New System.Drawing.Size(153, 16)
        Me.lblGPS_Type.TabIndex = 24
        Me.lblGPS_Type.Text = "GPS Type...  ERROR"
        '
        'lblDupeCheck
        '
        Me.lblDupeCheck.AutoSize = True
        Me.lblDupeCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDupeCheck.ForeColor = System.Drawing.Color.Purple
        Me.lblDupeCheck.Location = New System.Drawing.Point(25, 81)
        Me.lblDupeCheck.Name = "lblDupeCheck"
        Me.lblDupeCheck.Size = New System.Drawing.Size(205, 16)
        Me.lblDupeCheck.TabIndex = 23
        Me.lblDupeCheck.Text = "Duplicate GPSID check... OK"
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(9, 339)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCount.Size = New System.Drawing.Size(57, 18)
        Me.lblCount.TabIndex = 22
        Me.lblCount.Text = "12345"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'lblJ3BL
        '
        Me.lblJ3BL.AutoSize = True
        Me.lblJ3BL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJ3BL.ForeColor = System.Drawing.Color.Purple
        Me.lblJ3BL.Location = New System.Drawing.Point(25, 148)
        Me.lblJ3BL.Name = "lblJ3BL"
        Me.lblJ3BL.Size = New System.Drawing.Size(241, 16)
        Me.lblJ3BL.TabIndex = 21
        Me.lblJ3BL.Text = "J3 Bootloader version check... OK"
        '
        'lblJ3FW
        '
        Me.lblJ3FW.AutoSize = True
        Me.lblJ3FW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJ3FW.ForeColor = System.Drawing.Color.Purple
        Me.lblJ3FW.Location = New System.Drawing.Point(25, 126)
        Me.lblJ3FW.Name = "lblJ3FW"
        Me.lblJ3FW.Size = New System.Drawing.Size(230, 16)
        Me.lblJ3FW.TabIndex = 20
        Me.lblJ3FW.Text = "J3 firmware versions check... OK"
        '
        'lblAPN
        '
        Me.lblAPN.AutoSize = True
        Me.lblAPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAPN.ForeColor = System.Drawing.Color.Purple
        Me.lblAPN.Location = New System.Drawing.Point(25, 192)
        Me.lblAPN.Name = "lblAPN"
        Me.lblAPN.Size = New System.Drawing.Size(120, 16)
        Me.lblAPN.TabIndex = 19
        Me.lblAPN.Text = "APN check... OK"
        '
        'lblGPSFW
        '
        Me.lblGPSFW.AutoSize = True
        Me.lblGPSFW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGPSFW.ForeColor = System.Drawing.Color.Purple
        Me.lblGPSFW.Location = New System.Drawing.Point(25, 104)
        Me.lblGPSFW.Name = "lblGPSFW"
        Me.lblGPSFW.Size = New System.Drawing.Size(237, 16)
        Me.lblGPSFW.TabIndex = 18
        Me.lblGPSFW.Text = "GPS firwmare version check... OK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Click 'OK' to print or 'Cancel' to fix any errors"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Please review your QC file for any errors"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Ready to print"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(162, 441)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'lblSimNumber
        '
        Me.lblSimNumber.AutoSize = True
        Me.lblSimNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimNumber.ForeColor = System.Drawing.Color.Purple
        Me.lblSimNumber.Location = New System.Drawing.Point(25, 170)
        Me.lblSimNumber.Name = "lblSimNumber"
        Me.lblSimNumber.Size = New System.Drawing.Size(208, 16)
        Me.lblSimNumber.TabIndex = 28
        Me.lblSimNumber.Text = "Sim number check...  ERROR"
        '
        'lblRecordType
        '
        Me.lblRecordType.AutoSize = True
        Me.lblRecordType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordType.ForeColor = System.Drawing.Color.Red
        Me.lblRecordType.Location = New System.Drawing.Point(64, 334)
        Me.lblRecordType.Name = "lblRecordType"
        Me.lblRecordType.Size = New System.Drawing.Size(97, 25)
        Me.lblRecordType.TabIndex = 29
        Me.lblRecordType.Text = "Wombat"
        '
        'lblRecordsFoundText
        '
        Me.lblRecordsFoundText.AutoSize = True
        Me.lblRecordsFoundText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordsFoundText.Location = New System.Drawing.Point(116, 339)
        Me.lblRecordsFoundText.Name = "lblRecordsFoundText"
        Me.lblRecordsFoundText.Size = New System.Drawing.Size(125, 18)
        Me.lblRecordsFoundText.TabIndex = 30
        Me.lblRecordsFoundText.Text = "record(s) found"
        '
        'dlgReview_GPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 482)
        Me.Controls.Add(Me.lblRecordsFoundText)
        Me.Controls.Add(Me.lblRecordType)
        Me.Controls.Add(Me.lblSimNumber)
        Me.Controls.Add(Me.lblCfg_Mgr)
        Me.Controls.Add(Me.lblGPS_Model)
        Me.Controls.Add(Me.lblGPS_Mfg)
        Me.Controls.Add(Me.lblGPS_Type)
        Me.Controls.Add(Me.lblDupeCheck)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblJ3BL)
        Me.Controls.Add(Me.lblJ3FW)
        Me.Controls.Add(Me.lblAPN)
        Me.Controls.Add(Me.lblGPSFW)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgReview_GPS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCfg_Mgr As System.Windows.Forms.Label
    Friend WithEvents lblGPS_Model As System.Windows.Forms.Label
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblGPS_Mfg As System.Windows.Forms.Label
    Friend WithEvents lblGPS_Type As System.Windows.Forms.Label
    Friend WithEvents lblDupeCheck As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents lblJ3BL As System.Windows.Forms.Label
    Friend WithEvents lblJ3FW As System.Windows.Forms.Label
    Friend WithEvents lblAPN As System.Windows.Forms.Label
    Friend WithEvents lblGPSFW As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSimNumber As System.Windows.Forms.Label
    Friend WithEvents lblRecordType As System.Windows.Forms.Label
    Friend WithEvents lblRecordsFoundText As System.Windows.Forms.Label

End Class
