Imports System.IO

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 319
        Me.Height = 326
        XpTabControl1.Width = Me.Width - 7
        XpTabControl1.Height = Me.Height - 58
        ToolStripStatusLabel.Text = ""
    End Sub


#Region " Activation Tab "

    Private Sub btnActvOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActvOpen.Click
        Dim myStream As Stream
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.Title = "Open sim card file"
        openFileDialog1.RestoreDirectory = False

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            myStream = openFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                Using sr As StreamReader = New StreamReader(myStream)
                    Dim SimNum As String
                    Dim StartPos As Integer
                    Dim WholeLine As String
                    Do While sr.Peek > 0
                        If rdoActvQCFile.Checked = True Then
                            WholeLine = sr.ReadLine
                            StartPos = InStr(WholeLine, "'89014")
                            SimNum = WholeLine.Substring(StartPos, 20)
                        Else ' Assumes we are reading from a plain txt file or the download file from AT&T
                            SimNum = Strings.Left(sr.ReadLine, 20)
                        End If
                        If IsNumeric(SimNum) Then lstActvSimList.Items.Add(SimNum)
                    Loop
                    myStream.Close()
                    lblActvRecordCount.Enabled = True
                    lblTotalRecs.Enabled = True
                    lblActvRecordCount.Text = lstActvSimList.Items.Count
                End Using
            End If
        End If
    End Sub

    Private Sub btnActvSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActvSave.Click
        Dim myStream As Stream
        Dim SaveFileDialog1 As New SaveFileDialog()
        Dim SaveFileDialog2 As New SaveFileDialog()
        Dim Rate, Profile As String

        If rdoActvInternational.Checked = True Then
            Rate = "ZSS5"
        Else
            Rate = "ZSS5"
        End If

        Profile = "15"

        SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SaveFileDialog1.FileName = "Activate.txt"
        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.Title = "Activation File Name"

        'SaveFileDialog1.RestoreDirectory = False

        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then ' Write the activation file
            myStream = SaveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                Using sr As StreamWriter = New StreamWriter(myStream)
                    ' Walk through the list box and write it to the file
                    Dim i As Integer
                    For i = 0 To lstActvSimList.Items.Count - 1
                        sr.WriteLine(lstActvSimList.Items(i) & "," & Rate & "~" & Profile & "," & Date.Today.ToString("MM/dd/yyyy") & ",,,,,|2~ZOS-00001001")
                    Next
                End Using
            End If
        End If

        If rdoActvInternational.Checked = True Then ' Write the profile change file for international activation
            SaveFileDialog2.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            SaveFileDialog2.FileName = "Profile.txt"
            SaveFileDialog2.Filter = "txt files (*.txt)|*.txt"
            SaveFileDialog2.FilterIndex = 2
            SaveFileDialog2.Title = "Profile Change File Name"
            SaveFileDialog2.RestoreDirectory = False
            If SaveFileDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                myStream = SaveFileDialog2.OpenFile()

                If (myStream IsNot Nothing) Then
                    Using sr As StreamWriter = New StreamWriter(myStream)
                        ' Walk through the list box and if it is selected then write it to the file
                        Dim i As Integer
                        For i = 0 To lstActvSimList.Items.Count - 1
                            sr.WriteLine(lstActvSimList.Items(i) & ",CHNG~11," & Date.Today.ToString("MM/dd/yyyy"))
                        Next
                    End Using
                End If
            End If
        End If
        ToolStripStatusLabel.Text = "Successfully saved " & lstActvSimList.Items.Count & " sim numbers"
        lstActvSimList.Items.Clear()
        lblActvRecordCount.Text = 0
    End Sub

#End Region

#Region " Rate/Profile Tab "

    Private Sub btnRateProfileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRateProfileOpen.Click
        Dim myStream As Stream
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.Title = "Open sim card file"
        openFileDialog1.RestoreDirectory = False

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            myStream = openFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                Using sr As StreamReader = New StreamReader(myStream)
                    Dim SimNum As String
                    Dim StartPos As Integer
                    Dim WholeLine As String
                    Do While sr.Peek > 0
                        If rdoRateProfQCFile.Checked = True Then
                            WholeLine = sr.ReadLine
                            StartPos = InStr(WholeLine, "'89014")
                            SimNum = WholeLine.Substring(StartPos, 20)
                        Else ' Assumes we are reading from a plain txt file or the download file from AT&T
                            SimNum = Strings.Left(sr.ReadLine, 20)
                        End If
                        If IsNumeric(SimNum) Then lstRateProfSimList.Items.Add(SimNum)
                    Loop
                    myStream.Close()
                    lblRateProfRecordCount.Enabled = True
                    lblTotalRecs.Enabled = True
                    lblRateProfRecordCount.Text = lstRateProfSimList.Items.Count
                End Using
            End If
        End If
    End Sub

    Private Sub btnRateProfileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRateProfileSave.Click
        Dim myStream As Stream
        Dim SaveFileDialog1 As New SaveFileDialog()
        Dim SaveFileDialog2 As New SaveFileDialog()
        Dim Rate As String
        Dim Profile As String

        If rdoRateProfInternational.Checked = True Then
            Rate = "ZSS5"
            Profile = "CHNG~11"
        Else
            Rate = "ZSS5"
            Profile = "CHNG~06"
        End If

        SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SaveFileDialog1.FileName = "Rate.txt"
        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.Title = "Rate Change File Name"
        SaveFileDialog1.RestoreDirectory = False

        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then ' Write the rate change file
            myStream = SaveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                Using sr As StreamWriter = New StreamWriter(myStream)
                    ' Walk through the list box and write it to the file
                    Dim i As Integer
                    For i = 0 To lstRateProfSimList.Items.Count - 1
                        sr.WriteLine(lstRateProfSimList.Items(i) & ",RATE," & Date.Today.ToString("MM/dd/yyyy") & "," & Rate)
                    Next
                End Using
            End If

        End If

        SaveFileDialog2.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SaveFileDialog2.FileName = "Profile.txt"
        SaveFileDialog2.Filter = "txt files (*.txt)|*.txt"
        SaveFileDialog2.FilterIndex = 2
        SaveFileDialog2.Title = "Profile Change File Name"
        SaveFileDialog2.RestoreDirectory = False
        If SaveFileDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then ' Write the profile change file
            myStream = SaveFileDialog2.OpenFile()

            If (myStream IsNot Nothing) Then
                Using sr As StreamWriter = New StreamWriter(myStream)
                    ' Walk through the list box and write it to the file
                    Dim i As Integer
                    For i = 0 To lstRateProfSimList.Items.Count - 1
                        sr.WriteLine(lstRateProfSimList.Items(i) & "," & Profile & "," & Date.Today.ToString("MM/dd/yyyy"))
                    Next
                End Using
            End If
        End If

        ToolStripStatusLabel.Text = "Successfully saved " & lstRateProfSimList.Items.Count & " sim numbers"
        lstRateProfSimList.Items.Clear()
        lblRateProfRecordCount.Text = 0
    End Sub

#End Region

#Region " Suntron Tab "

    Private Sub txtSuntronFirstNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuntronFirstNum.TextChanged
        lstSuntronList.ClearSelected()
        If Len(txtSuntronFirstNum.Text) = 20 Then
            If lstSuntronList.Items.Contains(txtSuntronFirstNum.Text) Then
                Dim i As Integer = lstSuntronList.FindString(txtSuntronFirstNum.Text)
                lstSuntronList.SelectedIndex = i
                txtSuntronLastNum.Focus()
                txtSuntronLastNum.SelectAll()
            End If
        End If

    End Sub

    Private Sub txtSuntronLastNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuntronLastNum.TextChanged
        If Len(txtSuntronLastNum.Text) = 20 Then
            If lstSuntronList.Items.Contains(txtSuntronLastNum.Text) Then
                Dim i As Integer = lstSuntronList.FindString(txtSuntronLastNum.Text)
                lstSuntronList.SelectedIndex = i
                Dim j As Integer
                For j = lstSuntronList.FindString(txtSuntronFirstNum.Text) + 1 To lstSuntronList.FindString(txtSuntronLastNum.Text)
                    lstSuntronList.SelectedIndices.Add(j)
                Next
            End If

        End If
    End Sub

    Private Sub lstSuntronList_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSuntronList.SelectedIndexChanged, lstSuntronList.SelectedValueChanged
        lblSuntronSelectedCount.Text = lstSuntronList.SelectedItems.Count
    End Sub

    Private Sub btnSuntronOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuntronOpen.Click
        Dim myStream As Stream
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "txt files (*.txt)|*.txt"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.Title = "Open sim card file"
        openFileDialog1.RestoreDirectory = False

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            myStream = openFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                Using sr As StreamReader = New StreamReader(myStream)
                    Dim SimNum As String
                    Do While sr.Peek > 0
                        SimNum = Strings.Left(sr.ReadLine, 20)
                        If IsNumeric(SimNum) Then lstSuntronList.Items.Add(SimNum)
                    Loop
                    myStream.Close()
                    lblSuntronRecordCount.Text = lstSuntronList.Items.Count
                End Using
            End If
        End If
    End Sub

    Private Sub btnSuntronSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuntronSave.Click
        Dim myStream As Stream
        Dim SaveFileDialog1 As New SaveFileDialog()

        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.Title = "Suntron File Name"
        SaveFileDialog1.RestoreDirectory = False

        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then ' Write the activation file
            myStream = SaveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                Using sr As StreamWriter = New StreamWriter(myStream)
                    ' Walk through the list box and if it is selected then write it to the file
                    Dim i As Integer
                    For i = 0 To lstSuntronList.Items.Count - 1
                        If lstSuntronList.GetSelected(i) = True Then
                            sr.WriteLine(lstSuntronList.Items(i))
                        End If
                    Next
                End Using
            End If
        End If
        txtSuntronFirstNum.Focus()
        txtSuntronFirstNum.SelectAll()
    End Sub

#End Region

#Region " Deactivation Tab "

    Private Sub txtDeacOrderNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeacOrderNum.TextChanged
        If txtDeacOrderNum.Text = "" Then
            btnCreateDeactivationFile.Enabled = False
        Else
            btnCreateDeactivationFile.Enabled = True
        End If
    End Sub

    Private Sub btnDeactivateOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeactivateOpen.Click
        Dim myStream As Stream
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.Title = "Open sim card file"
        openFileDialog1.RestoreDirectory = False

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            myStream = openFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                Using sr As StreamReader = New StreamReader(myStream)
                    Dim SimNum As String
                    Dim StartPos As Integer
                    Dim WholeLine As String
                    Do While sr.Peek > 0
                        If rdoDeacFromQC.Checked = True Then
                            WholeLine = sr.ReadLine
                            StartPos = InStr(WholeLine, "'89014")
                            SimNum = WholeLine.Substring(StartPos, 20)
                        Else ' Assumes we are reading from a plain txt file or the download file from AT&T
                            SimNum = Strings.Left(sr.ReadLine, 20)
                        End If
                        If IsNumeric(SimNum) Then lstDeacSimList.Items.Add(SimNum)
                    Loop
                    myStream.Close()
                    lblDeacRecsFound.Enabled = True
                    lblDeactivateRecordCount.Enabled = True
                    lblDeactivateRecordCount.Text = lstDeacSimList.Items.Count
                End Using
            End If
        End If
    End Sub

    Private Sub btnCreateDeactivationFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateDeactivationFile.Click
        Dim myStream As Stream
        Dim SaveFileDialog1 As New SaveFileDialog()
        Dim SaveFileDialog2 As New SaveFileDialog()

        SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SaveFileDialog1.FileName = "Deactivate SO " & txtDeacOrderNum.Text & ".txt"
        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.Title = "Deactivation File Name"

        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then ' Write the activation file
            myStream = SaveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                Using sr As StreamWriter = New StreamWriter(myStream)
                    ' Walk through the list box and write it to the file
                    Dim i As Integer
                    For i = 0 To lstDeacSimList.Items.Count - 1
                        sr.WriteLine(lstDeacSimList.Items(i) & "," & "KILL," & Date.Today.ToString("MM/dd/yyyy"))
                    Next
                End Using
            End If
        End If

        ToolStripStatusLabel.Text = "Successfully saved " & lstDeacSimList.Items.Count & " sim numbers"
        lstActvSimList.Items.Clear()
        lblActvRecordCount.Text = 0
    End Sub

#End Region

End Class
