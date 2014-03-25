Imports System.Drawing.Printing
Imports Microsoft.Office.Interop.Excel

' May need to add a textbox for customer code and order number if it isnt on the install doc

'

Public Class Form1
    Dim InstallDoc As String
    Public SelectedPrinter As String
    Dim InstallDocOK, GPSQCFileOK As Boolean
    Dim RecordNumber As Integer
    Dim LabelArray(,) As String

    ' Columns not yet finalized
    Const CustomerColumn As Integer = 1
    Const OrderColumn As Integer = 2
    Const ConfigColumn As Integer = 11
    Const CableColumn As Integer = 8

    Const LabelTemplate As String = "P:\Shipping\Shipping Labels\Kit Label Template.xlsx"
    '

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Height = 125
        InstallDocOK = False
        Timer1.Enabled = False
        radPrintAll.Checked = True

        ' MsgBox(My.Settings.Printer)

        If Not My.Settings.Printer = "" Then 'If this is the first time running then display a prompt to select the printer
            MenuStrip1.Items(0).Text = "Selected Printer: " & My.Settings.Printer
        Else
            MenuStrip1.Items(0).Text = "Click here to select a printer"
        End If

    End Sub

    Private Sub cmdInstallDoc_Click(sender As Object, e As EventArgs) Handles cmdInstallDoc.Click

        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.InitialDirectory = "p:\customers"

        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        InstallDoc = OpenFileDialog1.FileName
        txtInstallDoc.Text = OpenFileDialog1.SafeFileName

        Me.Cursor = Cursors.WaitCursor

        Timer1.Enabled = True

        ProcessInstallDoc(InstallDoc)

    End Sub

    Private Sub txtInstallDoc_DragDrop(sender As Object, e As DragEventArgs) Handles txtInstallDoc.DragDrop

        Dim data As Array = DirectCast(e.Data.GetData(DataFormats.FileDrop), Array)
        InstallDoc = data.GetValue(0).ToString
        txtInstallDoc.Text = System.IO.Path.GetFileName(data.GetValue(0).ToString)

        Me.Cursor = Cursors.WaitCursor

        Timer1.Enabled = True

        ProcessInstallDoc(InstallDoc)

    End Sub

    Private Sub txtInstallDoc_DragOver(sender As Object, e As DragEventArgs) Handles txtInstallDoc.DragOver

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then e.Effect = DragDropEffects.Copy

    End Sub

    Private Sub Quit()

        Me.Close()

    End Sub

    Private Sub SelectPrinterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectPrinterToolStripMenuItem.Click

        Dim temp As String = dlgPrinter.ShowDialog
        'MsgBox(SelectedPrinter)
        My.Settings.Printer = SelectedPrinter
        'MsgBox("Settings: " & My.Settings.Printer & vbCrLf & "SelectedPrinter: " & SelectedPrinter)
        MenuStrip1.Items(0).Text = "Selected Printer: " & My.Settings.Printer

    End Sub

    Private Sub Suppress_Focus(sender As Object, e As EventArgs) Handles txtInstallDoc.GotFocus

        ' If the user clicks in the text boxes reset the focus to the browse button

        cmdInstallDoc.Focus()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' Grows the form to shows the label preview and print button
        Do Until Me.Height >= 541
            Me.Height = Me.Height + 2
        Loop
        Timer1.Enabled = False

    End Sub

    Private Sub lblNavLeft_Click(sender As Object, e As EventArgs) Handles lblNavLeft.Click
        If Not RecordNumber = 1 Then
            RecordNumber = RecordNumber - 1
            lblRecordCount.Text = RecordNumber & vbCrLf
            UpdatePreview(RecordNumber)
        End If
    End Sub

    Private Sub lblNavRight_Click(sender As Object, e As EventArgs) Handles lblNavRight.Click
        If Not RecordNumber = UBound(LabelArray) Then
            RecordNumber = RecordNumber + 1
            lblRecordCount.Text = RecordNumber & vbCrLf
            UpdatePreview(RecordNumber)
            Debug.Print(RecordNumber)
        End If
    End Sub

    Public Sub ProcessInstallDoc(InstallDoc As String)
        'On Error Resume Next
        Dim Excel As Application = New Application
        Excel.Visible = False
        Dim xlWorkBook As Workbook = Excel.Workbooks.Open(InstallDoc)
        Dim xlWorkSheet As Worksheet = xlWorkBook.Sheets(1)
        Dim CableArr As String()
        Dim j As Integer = 3
        Dim LastRow As Integer

        ' Sort the sheet by cable type so print out grouped by cable
        LastRow = xlWorkSheet.UsedRange.Rows.Count
        xlWorkSheet.Range("2:" & LastRow).Sort(xlWorkSheet.Range("H1"), 1, , , , , , 0, , , 1, , , , )

        ' Load up the label array to display and print
        ReDim Preserve LabelArray(xlWorkSheet.UsedRange.Rows.Count - 1, 7)

        For i = 2 To xlWorkSheet.UsedRange.Rows.Count
            LabelArray(i - 2, 0) = xlWorkSheet.Cells(i, CustomerColumn).value
            LabelArray(i - 2, 1) = xlWorkSheet.Cells(i, OrderColumn).value
            LabelArray(i - 2, 2) = xlWorkSheet.Cells(i, ConfigColumn).value

            If xlWorkSheet.Cells(i, CableColumn).value.ToString.Split(",") = -1 Then
                CableArr(0) = xlWorkSheet.Cells(i, CableColumn).value
            Else()
                CableArr = xlWorkSheet.Cells(i, CableColumn).value.ToString.Split(",") ' Multiple cable types on 1 line, separated by comma

                Select Case UBound(CableArr)
                    Case 0
                        LabelArray(i - 2, 3) = CableArr(0).Trim
                    Case 1
                        LabelArray(i - 2, 3) = CableArr(0).Trim
                        LabelArray(i - 2, 4) = CableArr(1).Trim
                    Case 2
                        LabelArray(i - 2, 3) = CableArr(0).Trim
                        LabelArray(i - 2, 4) = CableArr(1).Trim
                        LabelArray(i - 2, 5) = CableArr(2).Trim
                    Case 3
                        LabelArray(i - 2, 3) = CableArr(0).Trim
                        LabelArray(i - 2, 4) = CableArr(1).Trim
                        LabelArray(i - 2, 5) = CableArr(2).Trim
                        LabelArray(i - 2, 6) = CableArr(3).Trim
                    Case 4
                        LabelArray(i - 2, 3) = CableArr(0).Trim
                        LabelArray(i - 2, 4) = CableArr(1).Trim
                        LabelArray(i - 2, 5) = CableArr(2).Trim
                        LabelArray(i - 2, 6) = CableArr(3).Trim
                        LabelArray(i - 2, 7) = CableArr(4).Trim
                End Select
            End If
        Next

        ' We're done with Excel, close it and clean up
        xlWorkBook.Close(False) ' close it, dont save changes
        xlWorkSheet = Nothing
        xlWorkBook = Nothing
        Excel.Quit()

        ' Display the first label on the screen
        RecordNumber = 1
        lblRecordCount.Text = RecordNumber & vbCrLf
        lblRecordTotal.Text = UBound(LabelArray)
        UpdatePreview(RecordNumber)

        Me.Cursor = Cursors.Default

    End Sub

    Public Sub UpdatePreview(RecordNumber As Integer)

        ' As the user uses the navigation buttons the RecordNumber changes, and we display the selected record on the screen
        lblCustomer.Text = LabelArray(RecordNumber - 1, 0)
        lblOrder.Text = LabelArray(RecordNumber - 1, 1)
        lblConfig.Text = LabelArray(RecordNumber - 1, 2)
        lblCable1.Text = LabelArray(RecordNumber - 1, 3)
        lblCable2.Text = LabelArray(RecordNumber - 1, 4)
        lblCable3.Text = LabelArray(RecordNumber - 1, 5)
        lblCable4.Text = LabelArray(RecordNumber - 1, 6)
        lblCable5.Text = LabelArray(RecordNumber - 1, 7)

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim Excel As Application = New Application
        Excel.Visible = False
        Dim xlWorkBook As Workbook = Excel.Workbooks.Open(LabelTemplate)
        Dim xlWorkSheet As Worksheet = xlWorkBook.Sheets(1)

        If radPrintAll.Checked = True Then
            For i = 0 To UBound(LabelArray)
                If Not LabelArray(i, 0) = "" Then ' skip this if the cable field is blank (should avoid any extra empty lines at the bottom of the list)
                    ' My assumption is that if there isnt a cable then it really doesnt need a label
                    xlWorkSheet.Cells(3, 2).value = LabelArray(i, 0)
                    xlWorkSheet.Cells(4, 2).value = LabelArray(i, 1)
                    xlWorkSheet.Cells(5, 2).Value = LabelArray(i, 2)
                    xlWorkSheet.Cells(6, 2).Value = LabelArray(i, 3)
                    xlWorkSheet.Cells(7, 2).Value = LabelArray(i, 4)
                    xlWorkSheet.Cells(8, 2).Value = LabelArray(i, 5)
                    xlWorkSheet.Cells(9, 2).Value = LabelArray(i, 6)
                    xlWorkSheet.Cells(10, 2).Value = LabelArray(i, 7)
                    xlWorkSheet.PrintOutEx(, , , , SelectedPrinter, , , , )
                End If
            Next
        End If

        If radPrintSelected.Checked = True Then
            If Not LabelArray(RecordNumber - 1, 0) = "" Then ' skip this if the cable field is blank (should avoid any extra empty lines at the bottom of the list)
                ' My assumption is that if there isnt a cable then it really doesnt need a label
                xlWorkSheet.Cells(3, 2).value = LabelArray(RecordNumber - 1, 0)
                xlWorkSheet.Cells(4, 2).value = LabelArray(RecordNumber - 1, 1)
                xlWorkSheet.Cells(5, 2).Value = LabelArray(RecordNumber - 1, 2)
                xlWorkSheet.Cells(6, 2).Value = LabelArray(RecordNumber - 1, 3)
                xlWorkSheet.Cells(7, 2).Value = LabelArray(RecordNumber - 1, 4)
                xlWorkSheet.Cells(8, 2).Value = LabelArray(RecordNumber - 1, 5)
                xlWorkSheet.Cells(9, 2).Value = LabelArray(RecordNumber - 1, 6)
                xlWorkSheet.Cells(10, 2).Value = LabelArray(RecordNumber - 1, 7)
                xlWorkSheet.PrintOutEx(, , , , SelectedPrinter, , , , )
            End If
        End If
        ' We're done with Excel, close it and clean up
        xlWorkBook.Close(False) ' close it, dont save changes
        xlWorkSheet = Nothing
        xlWorkBook = Nothing
        Excel.Quit()

    End Sub
End Class
