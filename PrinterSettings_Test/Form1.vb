Imports System.Drawing.Printing
Imports System.Reflection
Imports System.Text

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtPrinterSettings As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnPrint = New System.Windows.Forms.Button
        Me.txtPrinterSettings = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(8, 8)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(152, 40)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Edit PrinterSettings"
        '
        'txtPrinterSettings
        '
        Me.txtPrinterSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrinterSettings.BackColor = System.Drawing.SystemColors.Info
        Me.txtPrinterSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrinterSettings.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrinterSettings.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtPrinterSettings.Location = New System.Drawing.Point(8, 56)
        Me.txtPrinterSettings.Multiline = True
        Me.txtPrinterSettings.Name = "txtPrinterSettings"
        Me.txtPrinterSettings.ReadOnly = True
        Me.txtPrinterSettings.Size = New System.Drawing.Size(372, 212)
        Me.txtPrinterSettings.TabIndex = 1
        Me.txtPrinterSettings.Text = ""
        Me.txtPrinterSettings.WordWrap = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 278)
        Me.Controls.Add(Me.txtPrinterSettings)
        Me.Controls.Add(Me.btnPrint)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private m_PS As PrinterSettings = Nothing

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim tmpPD As New PrintDialog

        If Not m_PS Is Nothing Then
            tmpPD.PrinterSettings = m_PS
        Else
            tmpPD.PrinterSettings = New PrinterSettings
        End If

        If tmpPD.ShowDialog() = DialogResult.OK Then
            Dim sb As New StringBuilder
            Dim newLine As String = Environment.NewLine

            m_PS = tmpPD.PrinterSettings
            sb.Append("PrinterName:  ")
            sb.Append(m_PS.PrinterName)
            sb.Append(newLine)

            Dim type As Type = GetType(PrinterSettings)
            Dim fi As FieldInfo = type.GetField("outputPort", BindingFlags.Instance Or BindingFlags.NonPublic)

            sb.Append("Port:         ")
            sb.Append(CType(fi.GetValue(m_PS), String))
            sb.Append(newLine)

            fi = type.GetField("driverName", BindingFlags.Instance Or BindingFlags.NonPublic)

            sb.Append("DriverName:   ")
            sb.Append(CType(fi.GetValue(m_PS), String))

            txtPrinterSettings.Text = sb.ToString()
        Else
            m_PS = Nothing
            txtPrinterSettings.Text = ""
        End If
    End Sub
End Class
