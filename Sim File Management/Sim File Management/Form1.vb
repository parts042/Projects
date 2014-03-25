Imports System.IO

Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = " Load a file"

    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim myStream As Stream
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.Title = "Open sim card file"
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = openFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                Using sr As StreamReader = New StreamReader(myStream)
                    Dim SimNum As String
                    Do While sr.Peek > 0
                        SimNum = Strings.Left(sr.ReadLine, 20)
                        If IsNumeric(SimNum) Then lstSimList.Items.Add(SimNum)
                    Loop
                    ToolStripStatusLabel1.Text = " Select sim numbers to process"
                    myStream.Close()
                    lblRecordCount.Enabled = True
                    lblTotalRecs.Enabled = True
                    lblRecordCount.Text = lstSimList.Items.Count
                    lblSelected.Enabled = True
                    lblSelectedCount.Enabled = True
                    btnSave.Enabled = True
                    txtFindNumber.Enabled = True
                    lstSimList.Enabled = True
                    GroupBox1.Enabled = True
                    GroupBox2.Enabled = True

                End Using
            End If
        End If
    End Sub

    Private Sub txtFindNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFindNumber.TextChanged
        If Len(txtFindNumber.Text) = 20 Then
            If lstSimList.Items.Contains(txtFindNumber.Text) Then
                Dim i As Integer = lstSimList.FindString(txtFindNumber.Text)
                lstSimList.SelectedIndex = i
            End If
        End If
    End Sub

    Private Sub lstSimList_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstSimList.SelectedValueChanged
        lblSelectedCount.Text = lstSimList.SelectedItems.Count
        ToolStripStatusLabel1.Text = " Save file"
    End Sub

    Private Sub lstSimList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSimList.SelectedIndexChanged
        lblSelectedCount.Text = lstSimList.SelectedItems.Count
        ToolStripStatusLabel1.Text = " Save file"
    End Sub

    Private Sub rdoActivation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoActivation.CheckedChanged
        If rdoActivation.Checked = True Then
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub rdoSuntron_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoSuntron.CheckedChanged
        If rdoSuntron.Checked = True Then
            GroupBox2.Enabled = False
        Else
            GroupBox2.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim myStream As Stream
        Dim SaveFileDialog1 As New SaveFileDialog()
        Dim SaveFileDialog2 As New SaveFileDialog()
        Dim Rate As String

        If rdoInternational.Checked = True Then
            Rate = "ZOS4"
        Else
            Rate = "ZOSD"
        End If

        SaveFileDialog1.InitialDirectory = "c:\"
        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.Title = "Activation File Name"
        SaveFileDialog1.RestoreDirectory = True

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then ' Write teh activation file
            myStream = SaveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                Using sr As StreamWriter = New StreamWriter(myStream)
                    ' Walk through the list box and if it is selected then write it to the file
                    Dim i As Integer
                    For i = 0 To lstSimList.Items.Count - 1
                        If lstSimList.GetSelected(i) Then
                            sr.WriteLine(lstSimList.Items(i) & "," & Rate & "," & Date.Today.ToString("MM/dd/yyyy") & ",,,,,|2~ZOS-00001002")
                        End If
                    Next
                End Using
            End If
        End If

        If rdoInternational.Checked = True Then ' Write the profile change file for international activation
            SaveFileDialog2.InitialDirectory = SaveFileDialog1.InitialDirectory
            SaveFileDialog2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            SaveFileDialog2.FilterIndex = 2
            SaveFileDialog2.Title = "Profile Change File Name"
            SaveFileDialog2.RestoreDirectory = True
            If SaveFileDialog2.ShowDialog() = DialogResult.OK Then
                myStream = SaveFileDialog2.OpenFile()

                If (myStream IsNot Nothing) Then
                    Using sr As StreamWriter = New StreamWriter(myStream)
                        ' Walk through the list box and if it is selected then write it to the file
                        Dim i As Integer
                        For i = 0 To lstSimList.Items.Count - 1
                            If lstSimList.GetSelected(i) Then
                                sr.WriteLine(lstSimList.Items(i) & ",CHNG~11," & Date.Today.ToString("MM/dd/yyyy"))
                            End If
                        Next
                    End Using
                End If
            End If
        End If
        ToolStripStatusLabel1.Text = " File Saved"
    End Sub

End Class
