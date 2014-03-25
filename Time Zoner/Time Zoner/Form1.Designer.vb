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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HawaiiMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlaskanMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PacificMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ArizonaMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MountainMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CentralMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IndianaMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EasternMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AtlanticMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HawaiiMenuItem, Me.AlaskanMenuItem, Me.PacificMenuItem, Me.ArizonaMenuItem, Me.MountainMenuItem, Me.CentralMenuItem, Me.IndianaMenuItem, Me.EasternMenuItem, Me.AtlanticMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(233, 230)
        '
        'HawaiiMenuItem
        '
        Me.HawaiiMenuItem.CheckOnClick = True
        Me.HawaiiMenuItem.Name = "HawaiiMenuItem"
        Me.HawaiiMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.HawaiiMenuItem.Text = "-10 : Hawaiian Standard Time"
        Me.HawaiiMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AlaskanMenuItem
        '
        Me.AlaskanMenuItem.CheckOnClick = True
        Me.AlaskanMenuItem.Name = "AlaskanMenuItem"
        Me.AlaskanMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.AlaskanMenuItem.Text = "-09 : Alaskan Standard Time"
        Me.AlaskanMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PacificMenuItem
        '
        Me.PacificMenuItem.CheckOnClick = True
        Me.PacificMenuItem.Name = "PacificMenuItem"
        Me.PacificMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.PacificMenuItem.Text = "-08 : Pacific Standard Time"
        Me.PacificMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ArizonaMenuItem
        '
        Me.ArizonaMenuItem.CheckOnClick = True
        Me.ArizonaMenuItem.Name = "ArizonaMenuItem"
        Me.ArizonaMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ArizonaMenuItem.Text = "-07 : Arizona"
        Me.ArizonaMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MountainMenuItem
        '
        Me.MountainMenuItem.CheckOnClick = True
        Me.MountainMenuItem.Name = "MountainMenuItem"
        Me.MountainMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.MountainMenuItem.Text = "-07 : Mountain Standard Time"
        Me.MountainMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CentralMenuItem
        '
        Me.CentralMenuItem.CheckOnClick = True
        Me.CentralMenuItem.Name = "CentralMenuItem"
        Me.CentralMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.CentralMenuItem.Text = "-06 : Central Standard Time"
        Me.CentralMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndianaMenuItem
        '
        Me.IndianaMenuItem.CheckOnClick = True
        Me.IndianaMenuItem.Name = "IndianaMenuItem"
        Me.IndianaMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.IndianaMenuItem.Text = "-05 : Indiana"
        Me.IndianaMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EasternMenuItem
        '
        Me.EasternMenuItem.CheckOnClick = True
        Me.EasternMenuItem.Name = "EasternMenuItem"
        Me.EasternMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.EasternMenuItem.Text = "-05 : Eastern Standard Time"
        Me.EasternMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AtlanticMenuItem
        '
        Me.AtlanticMenuItem.CheckOnClick = True
        Me.AtlanticMenuItem.Name = "AtlanticMenuItem"
        Me.AtlanticMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.AtlanticMenuItem.Text = "-04 : Atlantic Standard Time"
        Me.AtlanticMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(229, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 71)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Time Zoner"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HawaiiMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlaskanMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PacificMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArizonaMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MountainMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CentralMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndianaMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EasternMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtlanticMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
