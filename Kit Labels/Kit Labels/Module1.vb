
'Imports Microsoft.Office.Interop.Excel

'Module Module1

'    Private Const CustomerColumn As Integer = 1
'    Private Const OrderColumn As Integer = 2
'    Private Const ConfigColumn As Integer = 11
'    Private Const CableColumn As Integer = 8
'    'Private Const Cable2Column As Integer = 5
'    'Private Const Cable3Column As Integer = 6
'    'Private Const Cable4Column As Integer = 7
'    'Private Const Cable5Column As Integer = 8

'    Public LabelArray(,) As String

'    'Dim LabelTable As DataTable




'    Public Sub ProcessInstallDoc(InstallDoc As String)
'        'On Error Resume Next
'        Dim Excel As Application = New Application
'        Excel.Visible = True
'        Dim xlWorkBook As Workbook = Excel.Workbooks.Open(InstallDoc)
'        Dim xlWorkSheet As Worksheet = xlWorkBook.Sheets(1)
'        Dim CableArr As String()
'        Dim j As Integer = 3
'        'MsgBox(InstallDoc)
'        MsgBox(xlWorkSheet.Cells("h1").value)
'        '  Sort the excel sheet based on the cable type first so that the labels print out in the most convient way for shipping
'        xlWorkSheet.Range("A1").SpecialCells(11).Sort("h1", XlSortOrder.xlAscending, , , , , , XlYesNoGuess.xlYes, , , XlSortOrientation.xlSortColumns, , , , )

'        'MsgBox(xlWorkSheet.UsedRange.Rows.Count - 1)
'        ReDim Preserve LabelArray(xlWorkSheet.UsedRange.Rows.Count - 1, 7)

'        For i = 2 To xlWorkSheet.UsedRange.Rows.Count
'            LabelArray(i - 2, 0) = xlWorkSheet.Cells(i, CustomerColumn).value
'            LabelArray(i - 2, 1) = xlWorkSheet.Cells(i, OrderColumn).value
'            LabelArray(i - 2, 2) = xlWorkSheet.Cells(i, ConfigColumn).value
'            CableArr = xlWorkSheet.Cells(i, CableColumn).value.split(",")
'            'For Each s In CableArr
'            '    MsgBox(s)
'            'Next
'            'MsgBox(UBound(CableArr))
'            Select Case UBound(CableArr)
'                Case 0
'                    LabelArray(i - 2, 3) = CableArr(0)
'                Case 1
'                    LabelArray(i - 2, 3) = CableArr(0)
'                    LabelArray(i - 2, 4) = CableArr(1)
'                Case 2
'                    LabelArray(i - 2, 3) = CableArr(0)
'                    LabelArray(i - 2, 4) = CableArr(1)
'                    LabelArray(i - 2, 5) = CableArr(2)
'                Case 3
'                    LabelArray(i - 2, 3) = CableArr(0)
'                    LabelArray(i - 2, 4) = CableArr(1)
'                    LabelArray(i - 2, 5) = CableArr(2)
'                    LabelArray(i - 2, 6) = CableArr(3)
'                Case 4
'                    LabelArray(i - 2, 3) = CableArr(0)
'                    LabelArray(i - 2, 4) = CableArr(1)
'                    LabelArray(i - 2, 5) = CableArr(2)
'                    LabelArray(i - 2, 6) = CableArr(3)
'                    LabelArray(i - 2, 7) = CableArr(4)
'            End Select
'            'MsgBox(LabelArray(i - 2, 0) & " | " & LabelArray(i - 2, 1) & " | " & LabelArray(i - 2, 2) & " | " & LabelArray(i - 2, 3) & " | " & LabelArray(i - 2, 4) & " | " & LabelArray(i - 2, 5) & " | " & LabelArray(i - 2, 6) & " | " & LabelArray(i - 2, 7))
'        Next

'        xlWorkBook.Close(False) ' close it, dont save changes

'        Form1.RecordNumber = 1
'        Form1.lblRecordCount.Text = Form1.RecordNumber & vbCrLf
'        Form1.lblRecordTotal.Text = UBound(LabelArray)
'        UpdatePreview(Form1.RecordNumber)

'        'Excel.Quit()

'    End Sub

'    Public Sub UpdatePreview(RecordNumber As Integer)

'        Form1.lblCustomer.Text = LabelArray(RecordNumber - 1, 0)
'        Form1.lblOrder.Text = LabelArray(RecordNumber - 1, 1)
'        Form1.lblConfig.Text = LabelArray(RecordNumber - 1, 2)
'        Form1.lblCable1.Text = LabelArray(RecordNumber - 1, 3)
'        Form1.lblCable2.Text = LabelArray(RecordNumber - 1, 4)
'        Form1.lblCable3.Text = LabelArray(RecordNumber - 1, 5)
'        Form1.lblCable4.Text = LabelArray(RecordNumber - 1, 6)
'        Form1.lblCable5.Text = LabelArray(RecordNumber - 1, 7)


'    End Sub
'Private Sub PrintLabels()
'    Dim Excel As Application = New Application
'    Excel.Visible = True
'    Dim xlWorkBook As Workbook = Excel.Workbooks.Open()
'    Dim xlWorkSheet As Worksheet = xlWorkBook.Sheets(1)
'End Sub

'End Module