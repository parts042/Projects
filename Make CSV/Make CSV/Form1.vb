Imports System.IO
Imports System.Windows.Forms
Imports System.Math
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Drawing.Printing
Imports Microsoft.Office.Interop.Excel.WorkbookClass
Imports Microsoft.Office.Interop.Excel.WorksheetClass
Imports Microsoft.Office.Interop.Excel.ApplicationClass
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Dim oXLApp As New Excel.Application
    Dim oXLBook As Excel.Workbook
    Dim oXLSheet As Excel.Worksheet
    Dim TagArray As Integer
    Dim TagColName As String = "tag id"
    Dim AssetSheet As String = "customer assets"
    Dim FileType As String
    Dim Args As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 242
        Me.Height = 254
        HideGroupBoxes()
        grpAsset.Left = 229
        grpAsset.Top = 12
        Me.Width = 439
    End Sub

    Private Sub Main(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        If chk1120Asset.Checked = True Then
            Open1120()
            Process1120Assets(TagColName)
        End If

        If chk1120Aux.Checked = True Then

        End If

        If chkScratchAsset.Checked = True Then
            ScratchAssets()
        End If

        If chkScratchOp.Checked = True Then
            ScratchOp()
        End If

        If chkScratchAux.Checked = True Then

        End If

        If chkScratchExtended.Checked = True Then
            ScratchExtended()
        End If

        Cleanup()
    End Sub

    Public Sub HideGroupBoxes()
        grpAsset.Left = 463
        grpAsset.Top = 125
        grpOpCards.Left = 463
        grpOpCards.Top = 12
        grpExtAsset.Left = 660
        grpExtAsset.Top = 12
        Me.Width = 242
    End Sub

    Private Sub Open1120()

        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.Title = "Open 1120"
        OpenFileDialog1.RestoreDirectory = False

        oXLApp.Visible = True ' *** Show for now, hide when done coding  ***

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            oXLBook = oXLApp.Workbooks.Open(OpenFileDialog1.FileName)
            oXLSheet = oXLBook.Worksheets(1)
        Else
            End
        End If
    End Sub

    Private Sub Process1120Assets(ByVal TagColName)
        ' Walk down the first row looking for "Tag ID"
        Dim TagNumColumn As Integer
        Dim TagNumColumnFound As Boolean = False
        Dim x As Integer = oXLBook.Sheets.Count
        Dim p As Integer

        If oXLBook.Sheets.Count > 1 Then
            For p = 1 To oXLBook.Sheets.Count
                'MessageBox.Show(" looking for: " & LCase(AssetSheet) & " | found: " & LCase(oXLBook.Sheets(p).name))
                If LCase(oXLBook.Sheets(p).name) = AssetSheet Then
                    oXLBook.Sheets(p).range("a1").value = "blah blah"
                    'MessageBox.Show("found the sheet!")
                    Exit For
                End If
            Next
        End If

        For TagNumColumn = 1 To oXLSheet.UsedRange.Columns.Count ' walk through each column until we find the one with the header we are looking for
            'MessageBox.Show("2,2 = " & oXLBook.Sheets(p).Cells(2, 2).value)
            If LCase(oXLSheet.Cells(1, TagNumColumn).value) = LCase(TagColName) Then 'making everything lowercase, just in case
                TagNumColumnFound = True
                'MessageBox.Show("found the column!!")
                Exit For
            Else
                'MessageBox.Show("looking for column: " & TagColName & " in 1," & TagNumColumn & " | found: " & LCase(oXLSheet.Cells(1, TagNumColumn).value))
            End If
        Next

        ' This whole part is a mess, but it only gets touched if we dont find the header name, hopefully we can settle on a standard name and code for it
        If TagNumColumnFound = False Then
            TagColName = Microsoft.VisualBasic.InputBox("Unable to find the column containing the tag numbers." & vbCrLf & _
                                  "Please type the name of the column header above the 9 digit tag numbers", "Column Name", "Tag ID")
            If TagColName <> "" Then
                'MessageBox.Show(TagColName)
                ' god this is ugly, we basically have to restart the sub and give it the new header name to look for, someday I'll figure out something more elegant
                Process1120Assets(TagColName)
                Exit Sub
            End If
        End If

        ' *** Uncomment to check the column we think the tag numbers are in
        'MessageBox.Show(TagNumColumn)

        ' Read assets from 1120 into array
        Dim TagNumRow As Integer
        Dim TagArray(oXLSheet.UsedRange.Rows.Count - 1) As Integer
        Dim TagNum As String
        For TagNumRow = 2 To oXLSheet.UsedRange.Rows.Count
            TagNum = oXLSheet.Cells(TagNumRow, TagNumColumn).value

            TagArray(TagNumRow - 2) = TagNum

            ' *** Uncomment to verify the tag numbers are being read correctly into the array
            'MessageBox.Show("TagArray(" & (TagNumRow - 2) & ") = " & TagArray(TagNumRow - 2))
        Next

        oXLBook.Close(SaveChanges:=False) ' Close the workbook, we're done with it now
        oXLBook = oXLApp.Workbooks.Add ' Create the new sheet to write the asset file
        oXLSheet = oXLBook.Worksheets(1)

        Dim InsertDummyHeader As Boolean = False 'Suntron requires a header
        For j As Integer = 0 To Args.Count - 1
            Select Case LCase(Args(j))
                Case "/suntron"
                    InsertDummyHeader = True
            End Select
        Next

        ' Write the asset file
        Dim i As Integer

        oXLSheet.Columns("A:D").ColumnWidth = 10
        For i = 0 To UBound(TagArray) - 1
            oXLSheet.Cells(i + 1, 1).Value = "1"
            oXLSheet.Cells(i + 1, 2).value = TagArray(i)
            ' Calculate short tag num
            Select Case Len(oXLSheet.Cells(i + 1, 2).Value.ToString)
                Case Is = 7
                    oXLSheet.Cells(i + 1, 3).value = Mid(TagArray(i), 3, 7)
                Case Is = 8
                    oXLSheet.Cells(i + 1, 3).value = Mid(TagArray(i), 4, 6)
                Case Is = 9
                    If Mid(TagArray(i), 1, 3) = "138" Then
                        oXLSheet.Cells(i + 1, 3).value = Mid(TagArray(i), 4, 6)
                    Else
                        oXLSheet.Cells(i + 1, 3).value = Mid(TagArray(i), 5, 5)
                    End If
            End Select
            oXLSheet.Cells(i + 1, 4).value = "Asset #"
        Next

        If InsertDummyHeader = True Then
            oXLSheet.Range("1:1").EntireRow.Insert()
            oXLSheet.Cells(1, 1).value = "..."
        End If

        ' save the file
        SaveFile("Asset")

    End Sub

    Private Sub SaveFile(ByVal FileType)
        Dim saveFileDialog1 As New SaveFileDialog
        saveFileDialog1.Filter = "csv files (*.csv)|*.csv"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.Title = FileType & " File Name"
        saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        saveFileDialog1.RestoreDirectory = False
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            oXLBook.SaveAs(saveFileDialog1.FileName, FileFormat:=Excel.XlFileFormat.xlCSV)
        End If
        MsgBox("--" & UCase(FileType) & "-- file saved.")
    End Sub

    Private Sub ScratchAssets()
        oXLApp.Visible = True
        oXLBook = oXLApp.Workbooks.Add ' Create the new sheet to write the asset file
        oXLSheet = oXLBook.Worksheets(1)
        Dim NumAssets As String
        Dim FirstNum As Integer
        Dim StartNum As String 'we pass firstnum to startnum to do a len on it because if we leave it as int things get wonky
        Dim i As Integer
        FirstNum = Int(txtAssetStartNum.Text) 'Microsoft.VisualBasic.InputBox("Please enter the starting number", "Starting Number", 0)
        If FirstNum > 0 Then
            If Not FirstNum = CType(FirstNum, Integer) Then
                MessageBox.Show("Invalid number entered")
                Cleanup()
            End If
        Else
            MessageBox.Show("Invalid number entered")
            Cleanup()
        End If

        'NumAssets = Microsoft.VisualBasic.InputBox("How many tags to create?", "Number of tags", 0)
        NumAssets = Int(txtNumAssets.Text)
        If NumAssets > 0 Then

            If Not NumAssets = CType(NumAssets, Integer) Then
                MessageBox.Show("Invalid number entered")
                Cleanup()
            End If
        Else
            MessageBox.Show("Invalid number entered")
            Cleanup()
        End If

        StartNum = FirstNum.ToString

        For i = 0 To NumAssets - 1
            oXLSheet.Cells(i + 1, 1).Value = "1"
            oXLSheet.Cells(i + 1, 2).Value = FirstNum + i
            ' Calculate short tag num
            Select Case Len(StartNum)
                Case Is = 7
                    oXLSheet.Cells(i + 1, 3).value = Mid((StartNum + i), 3, 7)
                Case Is = 8
                    oXLSheet.Cells(i + 1, 3).value = Mid((StartNum + i), 4, 6)
                Case Is = 9
                    If Mid(FirstNum, 1, 3) = "138" Then
                        oXLSheet.Cells(i + 1, 3).value = Mid((StartNum + i), 4, 6)
                    Else
                        oXLSheet.Cells(i + 1, 3).value = Mid((StartNum + i), 5, 5)
                    End If
            End Select
            oXLSheet.Cells(i + 1, 4).Value = "Asset #"
        Next
        ' save the file
        SaveFile("Asset")

    End Sub

    Private Sub ScratchOp()
        oXLApp.Visible = True
        oXLBook = oXLApp.Workbooks.Add ' Create the new sheet to write the asset file
        oXLSheet = oXLBook.Worksheets(1)
        Dim NumCards As String
        Dim FirstNum As Integer
        Dim i As Integer

        FirstNum = Int(txtOpCardStartNum.Text) 'Microsoft.VisualBasic.InputBox("Please enter the starting number", "Starting Number", 0)
        If FirstNum > 0 Then
            If Not FirstNum = CType(FirstNum, Integer) Then
                MessageBox.Show("Invalid number entered")
                Cleanup()
            End If
        Else
            MessageBox.Show("Invalid number entered")
            Cleanup()
        End If

        NumCards = Int(txtNumOpCards.Text) 'Microsoft.VisualBasic.InputBox("How many cards to create?", "Number of cards", 0)
        If NumCards > 0 Then
            If Not NumCards = CType(NumCards, Integer) Then
                MessageBox.Show("Invalid number entered")
                Cleanup()
            End If
        Else
            MessageBox.Show("Invalid number entered")
            Cleanup()
        End If

        For i = 0 To NumCards - 1 ' start at 0 so we dont increment the first num
            oXLSheet.Cells(i + 1, 1).Value = "2"
            oXLSheet.Cells(i + 1, 2).Value = FirstNum + i ' first time through we add 0
            oXLSheet.Cells(i + 1, 3).Value = " "
            oXLSheet.Cells(i + 1, 4).Value = " "
        Next
        ' save the file
        SaveFile("Operator")

    End Sub

    Private Sub ScratchExtended()
        oXLApp.Visible = True
        oXLBook = oXLApp.Workbooks.Add ' Create the new sheet to write the asset file
        oXLSheet = oXLBook.Worksheets(1)
        Dim NumSets As Integer
        Dim NumPerSet As Integer
        Dim FirstNum As Integer
        Dim TagNum As Integer
        Dim TrailerType As String = ""
        Dim TagLoc(5) As String
        Dim RowNum As Integer
        Dim i, j As Integer

        FirstNum = Int(txtExtAssetyStartNum.Text) 'Microsoft.VisualBasic.InputBox("Please enter the starting number", "Starting Number", 0)
        If FirstNum > 0 Then
            If Not FirstNum = CType(FirstNum, Integer) Then
                MessageBox.Show("Invalid number entered")
                Cleanup()
            End If
        Else
            MessageBox.Show("Invalid number entered")
            Cleanup()
        End If

        NumSets = Int(txtNumExtAssetSets.Text) 'Microsoft.VisualBasic.InputBox("How many tag sets to create?", "Number of sets", 0)
        If NumSets > 0 Then
            If Not NumSets = CType(NumSets, Integer) Then
                MessageBox.Show("Invalid number entered")
                Cleanup()
            End If
        Else
            MessageBox.Show("Invalid number entered")
            Cleanup()
        End If

        NumPerSet = Int(cmbNumTagsPerSet.Text) 'Microsoft.VisualBasic.InputBox("How many tags per set? (2,3 or 4)", "Number per set", 3)
        If NumPerSet = 1 Or NumPerSet = 2 Or NumPerSet = 3 Or NumPerSet = 4 Or NumPerSet = 5 Then
            If Not NumPerSet = CType(NumPerSet, Integer) Then
                MessageBox.Show("Invalid number entered")
                Cleanup()
            End If
        Else
            MessageBox.Show("Invalid number entered")
            Cleanup()
        End If

        Select Case NumPerSet
            Case "2"
                TrailerType = "Dolly"
                TagLoc(1) = "Left Side"
                TagLoc(2) = "Right Side"
            Case "3"
                TrailerType = "Trailer"
                TagLoc(1) = "Front"
                TagLoc(2) = "Left Side"
                TagLoc(3) = "Right Side"
            Case "4"
                TrailerType = "Trailer"
                TagLoc(1) = "Front"
                TagLoc(2) = "Right Side"
                TagLoc(3) = "Left Side"
                TagLoc(4) = "Rear"
            Case Else
                MessageBox.Show("Invalid number entered")
                Cleanup()
        End Select

        RowNum = 1
        TagNum = FirstNum
        For i = 1 To NumSets ' Loop until we reach the max number of sets
            For j = 1 To NumPerSet
                oXLSheet.Cells(RowNum, 1).value = "C"
                oXLSheet.Cells(RowNum, 2).value = TagNum
                oXLSheet.Cells(RowNum, 3).value = j
                oXLSheet.Cells(RowNum, 4).value = "1"
                oXLSheet.Cells(RowNum, 5).value = TrailerType
                oXLSheet.Cells(RowNum, 6).value = TagLoc(j)
                oXLSheet.Cells(RowNum, 7).value = "-"
                oXLSheet.Cells(RowNum, 8).value = "Ext. Asset #"
                RowNum = RowNum + 1
            Next
            TagNum = TagNum + 1
        Next

        SaveFile("Extended Asset")

    End Sub

    Private Sub Cleanup()
        oXLSheet = Nothing  'disconnect from the Worksheet
        oXLBook.Close(SaveChanges:=False) 'Close the Workbook
        oXLBook = Nothing
        oXLApp.Quit() 'Close Excel
        oXLApp = Nothing
        End
    End Sub

    Private Sub chkScratchAsset_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkScratchAsset.CheckedChanged

        Dim ChangeFont As System.Drawing.Font
        Select Case chkScratchAsset.Checked
            Case True
                ChangeFont = New System.Drawing.Font("Arial", 12, FontStyle.Bold)
                chkScratchAsset.Font = ChangeFont
                chkScratchAsset.ForeColor = Color.Red
                chkScratchOp.Checked = False
                chkScratchAux.Checked = False
                chkScratchExtended.Checked = False
                chk1120Asset.Checked = False
                chk1120Aux.Checked = False
                HideGroupBoxes()
                grpAsset.Left = 229
                grpAsset.Top = 12
                Me.Width = 439
            Case False
                ChangeFont = New System.Drawing.Font("Arial", 8, FontStyle.Regular)
                chkScratchAsset.Font = ChangeFont
                chkScratchAsset.ForeColor = Color.Black
                HideGroupBoxes()
        End Select
    End Sub

    Private Sub chkScratchOp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkScratchOp.CheckedChanged
        Dim ChangeFont As System.Drawing.Font
        Select Case chkScratchOp.Checked
            Case True
                ChangeFont = New System.Drawing.Font("Arial", 12, FontStyle.Bold)
                chkScratchOp.Font = ChangeFont
                chkScratchOp.ForeColor = Color.Red
                chkScratchAsset.Checked = False
                chkScratchAux.Checked = False
                chkScratchExtended.Checked = False
                chk1120Asset.Checked = False
                chk1120Aux.Checked = False
                HideGroupBoxes()
                grpOpCards.Left = 229
                grpOpCards.Top = 12
                Me.Width = 439
            Case False
                ChangeFont = New System.Drawing.Font("Arial", 8, FontStyle.Regular)
                chkScratchOp.Font = ChangeFont
                chkScratchOp.ForeColor = Color.Black
                HideGroupBoxes()
        End Select
    End Sub

    Private Sub chkScratchAux_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkScratchAux.CheckedChanged
        Dim ChangeFont As System.Drawing.Font
        Select Case chkScratchAux.Checked
            Case True
                ChangeFont = New System.Drawing.Font("Arial", 12, FontStyle.Bold)
                chkScratchAux.Font = ChangeFont
                chkScratchAux.ForeColor = Color.Red
                chkScratchOp.Checked = False
                chkScratchAsset.Checked = False
                chkScratchExtended.Checked = False
                chk1120Asset.Checked = False
                chk1120Aux.Checked = False
                HideGroupBoxes()
            Case False
                ChangeFont = New System.Drawing.Font("Arial", 8, FontStyle.Regular)
                chkScratchAux.Font = ChangeFont
                chkScratchAux.ForeColor = Color.Black
                HideGroupBoxes()
        End Select
    End Sub

    Private Sub chkScratchExtended_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkScratchExtended.CheckedChanged
        Dim ChangeFont As System.Drawing.Font
        Select Case chkScratchExtended.Checked
            Case True
                ChangeFont = New System.Drawing.Font("Arial", 12, FontStyle.Bold)
                chkScratchExtended.Font = ChangeFont
                chkScratchExtended.ForeColor = Color.Red
                chkScratchOp.Checked = False
                chkScratchAux.Checked = False
                chkScratchAsset.Checked = False
                chk1120Asset.Checked = False
                chk1120Aux.Checked = False
                HideGroupBoxes()
                grpExtAsset.Left = 229
                grpExtAsset.Top = 12
                Me.Width = 439
            Case False
                ChangeFont = New System.Drawing.Font("Arial", 8, FontStyle.Regular)
                chkScratchExtended.Font = ChangeFont
                chkScratchExtended.ForeColor = Color.Black
                HideGroupBoxes()
        End Select
    End Sub

    Private Sub chk1120Asset_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1120Asset.CheckedChanged
        Select Case chk1120Asset.Checked
            Case True
                chkScratchOp.Checked = False
                chkScratchAux.Checked = False
                chkScratchAsset.Checked = False
                chkScratchExtended.Checked = False
                chk1120Aux.Checked = False
                HideGroupBoxes()
                Me.Width = 242
            Case False
                HideGroupBoxes()
        End Select
    End Sub

    Private Sub chk1120Aux_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1120Aux.CheckedChanged
        Select Case chk1120Aux.Checked
            Case True
                chkScratchOp.Checked = False
                chkScratchAux.Checked = False
                chkScratchAsset.Checked = False
                chk1120Asset.Checked = False
                chkScratchExtended.Checked = False
                HideGroupBoxes()
                Me.Width = 242
            Case False
                HideGroupBoxes()
        End Select
    End Sub

    Private Sub txtNumAssets_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumAssets.KeyPress

        If Not (Char.IsNumber(e.KeyChar) OrElse AscW(e.KeyChar) = 8) Then e.Handled = True

    End Sub

    Private Sub txtNumOpCards_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumOpCards.KeyPress

        If Not (Char.IsNumber(e.KeyChar) OrElse AscW(e.KeyChar) = 8) Then e.Handled = True

    End Sub

    Private Sub txtNumExtAssetSets_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumExtAssetSets.KeyPress

        If Not (Char.IsNumber(e.KeyChar) OrElse AscW(e.KeyChar) = 8) Then e.Handled = True

    End Sub

End Class
