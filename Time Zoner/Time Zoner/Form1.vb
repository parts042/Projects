Public Class Form1

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If Me.WindowState = FormWindowState.Normal Then
            e.Cancel = True
            Me.Hide()
            Me.WindowState = FormWindowState.Minimized
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case TimeZone.CurrentTimeZone.StandardName
            Case "Hawaiian Standard Time"
                HawaiiMenuItem.Checked = True
            Case "Alaskan Standard Time"
                AlaskanMenuItem.Checked = True
            Case "Pacific Standard Time"
                PacificMenuItem.Checked = True
            Case "US Mountain Standard Time" ' Arizona
                ArizonaMenuItem.Checked = True
            Case "Mountain Standard Time"
                MountainMenuItem.Checked = True
            Case "Central Standard Time"
                CentralMenuItem.Checked = True
            Case "US Eastern Standard Time" ' Indiana
                IndianaMenuItem.Checked = True
            Case "Eastern Standard Time"
                EasternMenuItem.Checked = True
            Case "Atlantic Standard Time"
                AtlanticMenuItem.Checked = True
        End Select

        Me.Hide()
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub UncheckAll()

        HawaiiMenuItem.Checked = False
        AlaskanMenuItem.Checked = False
        PacificMenuItem.Checked = False
        ArizonaMenuItem.Checked = False
        MountainMenuItem.Checked = False
        CentralMenuItem.Checked = False
        IndianaMenuItem.Checked = False
        EasternMenuItem.Checked = False
        AtlanticMenuItem.Checked = False

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        Me.Close()
    End Sub

    Private Sub HawaiiMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HawaiiMenuItem.Click
        Shell("tzutil.exe /s ""Hawaiian Standard Time""")
        UncheckAll()
        HawaiiMenuItem.Checked = True
    End Sub

    Private Sub AlaskanMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlaskanMenuItem.Click
        Shell("tzutil.exe /s ""Alaskan Standard Time""")
        UncheckAll()
        AlaskanMenuItem.Checked = True
    End Sub

    Private Sub PacificMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacificMenuItem.Click
        Shell("tzutil.exe /s ""Pacific Standard Time""")
        UncheckAll()
        PacificMenuItem.Checked = True
    End Sub

    Private Sub ArizonaMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArizonaMenuItem.Click
        Shell("tzutil.exe /s ""US Mountain Standard Time_dstoff""")
        UncheckAll()
        ArizonaMenuItem.Checked = True
    End Sub

    Private Sub MountainMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MountainMenuItem.Click
        Shell("tzutil.exe /s ""Mountain Standard Time""")
        UncheckAll()
        MountainMenuItem.Checked = True
    End Sub

    Private Sub CentralMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CentralMenuItem.Click
        Shell("tzutil.exe /s ""Central Standard Time""")
        UncheckAll()
        CentralMenuItem.Checked = True
    End Sub

    Private Sub IndianaMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndianaMenuItem.Click
        Shell("tzutil.exe /s ""US Eastern Standard Time_dstoff""")
        UncheckAll()
        IndianaMenuItem.Checked = True
    End Sub

    Private Sub EasternMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EasternMenuItem.Click
        Shell("tzutil.exe /s ""Eastern Standard Time""")
        UncheckAll()
        EasternMenuItem.Checked = True
    End Sub

    Private Sub AtlanticMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtlanticMenuItem.Click
        Shell("tzutil.exe /s ""Atlantic Standard Time""")
        UncheckAll()
        AtlanticMenuItem.Checked = True
    End Sub

End Class
