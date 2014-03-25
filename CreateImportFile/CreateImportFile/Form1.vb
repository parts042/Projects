Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    ' format
    ' close and save new file
    ' close original w/o saving
    ' cleanup

    Dim oXLApp As New Excel.Application
    Dim oXLBook As Excel.Workbook
    Dim oXLSheet As Excel.Worksheet
    Dim File_Type As String = ""

    Private Sub Open_QC_File()

        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.AutoUpgradeEnabled = True
        'OpenFileDialog1.Filter = "QC Log File files (*.csv)|*.csv"
        'OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.Title = "Open QC File"
        OpenFileDialog1.RestoreDirectory = False

        oXLApp.Visible = True ' *** Show for now, hide when done coding  ***

        If OpenFileDialog1.ShowDialog() = vbOK Then
            oXLBook = oXLApp.Workbooks.Open(OpenFileDialog1.FileName)
            oXLSheet = oXLBook.Worksheets(1)
        Else
            oXLApp.Quit() 'Close Excel
            oXLApp = Nothing
            End
        End If
    End Sub

    Private Function Determine_File_Type()
        Select Case oXLApp.ActiveSheet.usedrange.columns.count
            Case 68, 73, 77
                File_Type = "GPS"
            Case 5
                File_Type = "Asset"
            Case 4
                File_Type = "Opcard"
            Case 57
                File_Type = "2010"
            Case Else
                File_Type = "Unknown"
                MessageBox.Show(oXLApp.ActiveSheet.usedrange.columns.count & " columns found" & vbCrLf & "Unable to determine file type")
        End Select
        'MsgBox(File_Type)
        Return File_Type
    End Function

    Private Sub Format_For_Import(ByVal file_type)
        Dim i As Integer = 0

        Select Case file_type
            Case "GPS"
                For i = 0 To oXLApp.ActiveSheet.UsedRange.Rows.Count - 1  ' insert dummy value so excel doesnt muck up the columns in the csv file
                    oXLSheet.Cells(i + 1, 1).value = "x"
                Next
                Dim rng As Excel.Range = oXLSheet.Columns("C:BK")
                rng.Clear() ' Erase up to the sim number

                rng = oXLSheet.Columns("BM:BY")
                rng.Delete() ' Erase after the sim number 

                'For i = 0 To oXLApp.ActiveSheet.UsedRange.Rows.Count - 1  ' insert dummy value so excel doesnt muck up the columns in the csv file
                '    oXLSheet.Cells(i + 1, 68).value = "x"
                'Next

            Case "Asset"
                ' Insert a dummy header line at the top because Navision ignore anything in the top row
                Dim rng As Excel.Range = oXLSheet.Rows("1")
                rng.Insert()
                For i = 0 To oXLApp.ActiveSheet.UsedRange.Rows.Count - 1  ' insert dummy value in column A so excel doesnt muck up the columns in the csv file
                    oXLSheet.Cells(i + 1, 1).value = "x"
                Next

                rng = oXLSheet.Columns("C")
                rng.Cut()
                rng = oXLSheet.Columns("B")
                rng.Activate()
                oXLSheet.Paste()

                rng = oXLSheet.Columns("C:BY")
                rng.Delete() ' Erase up to the next to last column

                'For i = 0 To oXLApp.ActiveSheet.UsedRange.Rows.Count - 1  ' insert dummy value at the end so excel doesnt muck up the columns in the csv file
                '    oXLSheet.Cells(i + 1, 68).value = "x"
                'Next

            Case "Opcard"
                ' Insert a dummy header line at the top because Navision ignore anything in the top row
                Dim rng As Excel.Range = oXLSheet.Rows("1")
                rng.Insert()
                For i = 0 To oXLApp.ActiveSheet.UsedRange.Rows.Count - 1  ' insert dummy value in column A so excel doesnt muck up the columns in the csv file
                    oXLSheet.Cells(i + 1, 1).value = "x"
                Next

                rng = oXLSheet.Columns("C")
                rng.Cut()
                rng = oXLSheet.Columns("B")
                rng.Activate()
                oXLSheet.Paste()
                For i = 0 To oXLApp.ActiveSheet.UsedRange.Rows.Count - 1
                    oXLSheet.Cells(i + 1, 2).value = Mid(oXLSheet.Cells(i + 1, 2).value, 2, Len(oXLSheet.Cells(i + 1, 2).value) - 1)
                    MsgBox(Mid(oXLSheet.Cells(i + 1, 2).value, 2, Len(oXLSheet.Cells(i + 1, 2).value) - 1))
                Next

                rng = oXLSheet.Columns("C:BU")
                rng.Clear() ' Erase up to the next to last column

                For i = 0 To oXLApp.ActiveSheet.UsedRange.Rows.Count - 1  ' insert dummy value at the end so excel doesnt muck up the columns in the csv file
                    oXLSheet.Cells(i + 1, 68).value = "x"
                Next

            Case "2010"
                For i = 0 To oXLApp.ActiveSheet.UsedRange.Rows.Count - 1  ' insert dummy value so excel doesnt muck up the columns in the csv file
                    oXLSheet.Cells(i + 1, 1).value = "x"
                Next
                Dim rng As Excel.Range = oXLSheet.Columns("B:H")
                rng.Delete() ' Erase up to the serial number

                rng = oXLSheet.Columns("C:AX")
                rng.Delete() ' Erase after the serial number 

        End Select

    End Sub

    Private Sub Save_Import_File()

        If File_Type = "GPS" Or File_Type = "Asset" Or File_Type = "2010" Then
            oXLApp.DisplayAlerts = False
            oXLBook.SaveAs("z:\Nav_Import.txt", FileFormat:=Microsoft.Office.Interop.Excel.XlFileFormat.xlCSV)
        End If

    End Sub

    Private Sub Cleanup()
        oXLSheet = Nothing  'disconnect from the Worksheet
        oXLBook.Close(SaveChanges:=False) 'Close the Workbook
        oXLBook = Nothing
        oXLApp.Quit() 'Close Excel
        oXLApp = Nothing
        End
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Open_QC_File()
        Determine_File_Type()
        Format_For_Import(File_Type)
        Save_Import_File()
        Cleanup()

    End Sub

End Class
