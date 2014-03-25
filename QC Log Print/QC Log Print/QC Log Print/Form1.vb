'' Cmd line args (optional): /navimport - saves a file to "z:\Nav_Import.txt" to import into Navision.  
''                                        Only works for GPS devices


Imports System.IO
Imports System.Windows.Forms
'Imports System.Math
'Imports Microsoft.Office.Interop.Excel.WorkbookClass
'Imports Microsoft.Office.Interop.Excel.WorksheetClass
'Imports Microsoft.Office.Interop.Excel.ApplicationClass
Imports Excel = Microsoft.Office.Interop.Excel



Public Class Form1
    Dim DoNavImportFile As Boolean = False
    Dim DoActivationFile As Boolean = False
    Dim oXLApp As New Excel.Application
    Dim oXLBook As Excel.Workbook
    Dim oXLSheet As Excel.Worksheet
    Dim Args As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
    Dim FileType As String

    Const GPS_FW = "EGPS-1.2.101"
    Const Ztrak_FW = "REV:21g | APP:131"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False

        Open_QC_File()
        Determine_File_Type() ' Figures out what type of QC file, and formats it to print correctly
        Select Case FileType
            Case "2010"
                Review_2010()
            Case "GPS"
                'If Not oXLSheet.Cells(1, 77).value = "V3" Then 'skip the checks if this is a V3 file, fix later to skip all checks except dupes
                Review_GPS()
                'End If
            Case "2020"
            Case "RVM"
            Case "Evircom"
        End Select

        CheckArgs()
        Print()
        CreateAdditionalFiles()

        Cleanup()

    End Sub

    Private Sub Open_QC_File()

        Dim OpenFileDialog1 As New OpenFileDialog()
        OpenFileDialog1.AutoUpgradeEnabled = True
        OpenFileDialog1.Filter = "QC Log File files (*.csv)|*.csv"
        OpenFileDialog1.FilterIndex = 2
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

    Private Sub Determine_File_Type()
        ' Figure out what type of log file
        ' 2010 has 52 or 50 or 40 or 57 columns, RVM has 11 and EvirCom has 10
        ' GPS has 66 or 68 or 73
        Select Case oXLSheet.UsedRange.Columns.Count

            Case 1 ' 2020
                FileType = "2020"
            Case 52, 50, 40, 57 ' 2010
                FileType = "2010"
                Format_2010()
            Case 66, 68, 73, 77 ' GPS
                FileType = "GPS"
                Format_GPS()
            Case 11 ' RVM
                FileType = "RVM"
                Format_RVM()
            Case 10 ' Evircom
                FileType = "Evircom"
                Format_Evircom()

        End Select
    End Sub

    Private Sub CheckArgs()
        ' Check the cmd line args and see if we should make an activation and import file
        If oXLSheet.UsedRange.Columns.Count = 66 Or oXLSheet.UsedRange.Columns.Count = 68 Or oXLSheet.UsedRange.Columns.Count = 73 Or oXLSheet.UsedRange.Columns.Count = 77 Then ' Only necessary for GPS QC files
            For i As Integer = 0 To Args.Count - 1
                Select Case LCase(Args(i))
                    Case "/navimport"
                        DoNavImportFile = True
                End Select
            Next
        End If

    End Sub

    Private Sub Format_2010()


        ' 11 is a parameter that represents the last cell in the spreadsheet containing data. This
        ' command creates a range that starts in cell A1 and extends through all the cells that contain
        ' data. Then it sorts based on whats in I1 (serial number)
        ' Sometimes the log file is generated without a header, in that case we select row 2 to the end
        oXLSheet.Range("A1").SpecialCells(11).Sort(oXLSheet.Range("I1"), 1, , , , , , 1, , , 1, , , , )

        ' Set column widths to fit
        oXLSheet.Columns(1).ColumnWidth = 15
        oXLSheet.Columns(2).ColumnWidth = 25.57
        oXLSheet.Columns(3).ColumnWidth = 0.33
        oXLSheet.Columns(4).ColumnWidth = 0.33
        oXLSheet.Columns(5).ColumnWidth = 0.33
        oXLSheet.Columns(6).ColumnWidth = 0.33
        oXLSheet.Columns(7).ColumnWidth = 0.33
        oXLSheet.Columns(8).ColumnWidth = 3.86
        With oXLSheet.Columns(9)
            .ColumnWidth = 16.14
            .Font.Bold = True
            .Font.Size = 12
            .HorizontalAlignment = &HFFFFEFF4 ' Centered
            .Interior.ColorIndex = 36 ' Yellow
        End With
        oXLSheet.Columns(10).ColumnWidth = 8.14
        oXLSheet.Columns(11).ColumnWidth = 3.71
        oXLSheet.Columns(12).ColumnWidth = 3.71
        oXLSheet.Columns(13).ColumnWidth = 4.86
        oXLSheet.Columns(14).ColumnWidth = 4.14
        oXLSheet.Columns(15).ColumnWidth = 5
        oXLSheet.Columns(16).ColumnWidth = 6.14
        oXLSheet.Columns(17).ColumnWidth = 2.29
        oXLSheet.Columns(18).ColumnWidth = 6.57

        
    End Sub

    Private Sub Format_GPS()
        ' 11 is a parameter that represents the last cell in the spreadsheet containing data. This
        ' command creates a range that starts in cell A1 and extends through all the cells that contain
        ' data. Then it sorts based on whats in B1 (serial number)
        ' Sometimes the log file is generated without a header, in that case we select row 2 to the end
        'oXLSheet.Range("A1").SpecialCells(11).Sort(oXLSheet.Range("B1"), 1, , , , , , 1, , , 1, , , , )

        ' Figure out if its GSM or 900mhz
        ' Check for a radio address of 0 in the first line, if present we assume this is GPS-GSM
        Select Case oXLSheet.Cells(2, 3).Value
            Case 0 ' GSM
                oXLSheet.Columns(1).ColumnWidth = 7.0
                With oXLSheet.Columns(2)
                    .ColumnWidth = 6.71
                    .Font.Bold = True
                    .Font.Size = 12
                    .Interior.ColorIndex = 36 ' Yellow
                End With
                oXLSheet.Columns(1).ColumnWidth = 0 'A
                oXLSheet.Columns(2).ColumnWidth = 11.43 'B
                oXLSheet.Range("C:M").ColumnWidth = 0
                oXLSheet.Columns(14).ColumnWidth = 3 'N
                oXLSheet.Columns(15).ColumnWidth = 3 'O
                oXLSheet.Columns(16).ColumnWidth = 3 'P
                oXLSheet.Columns(17).ColumnWidth = 3 'Q
                oXLSheet.Columns(18).ColumnWidth = 24.0 'R
                oXLSheet.Range("S:BF").ColumnWidth = 0
                oXLSheet.Columns(59).ColumnWidth = 7.71 'BG
                oXLSheet.Range("BH:BK").ColumnWidth = 0
                oXLSheet.Columns(64).ColumnWidth = 20 'BL
                oXLSheet.Columns(65).ColumnWidth = 14 'BM
                oXLSheet.Columns(66).ColumnWidth = 0 'BN
                oXLSheet.Range("BO:BP").ColumnWidth = 0
                oXLSheet.Columns(69).ColumnWidth = 22.57 'BQ
                oXLSheet.Columns(70).ColumnWidth = 0 'BR
                oXLSheet.Columns(71).ColumnWidth = 1.43 'BS
                oXLSheet.Range("BT:BU").ColumnWidth = 0
            Case Else ' 900mhz
                oXLSheet.Columns(1).ColumnWidth = 7.0
                With oXLSheet.Columns(2)
                    .ColumnWidth = 6.71
                    .Font.Bold = True
                    .Font.Size = 12
                    .Interior.ColorIndex = 36 ' Yellow
                End With
                oXLSheet.Columns(1).ColumnWidth = 0
                oXLSheet.Columns(2).ColumnWidth = 11.43
                oXLSheet.Columns(3).ColumnWidth = 5.43
                oXLSheet.Columns(4).ColumnWidth = 2.57
                oXLSheet.Columns(5).ColumnWidth = 6
                oXLSheet.Columns(6).ColumnWidth = 3
                oXLSheet.Columns(7).ColumnWidth = 5
                oXLSheet.Columns(8).ColumnWidth = 9.14
                oXLSheet.Columns(9).ColumnWidth = 4.57
                oXLSheet.Columns(10).ColumnWidth = 3.57
                oXLSheet.Columns(11).ColumnWidth = 5.0
                oXLSheet.Columns(12).ColumnWidth = 5.86
                oXLSheet.Columns(13).ColumnWidth = 5.57
                oXLSheet.Columns(14).ColumnWidth = 2.86
                oXLSheet.Columns(15).ColumnWidth = 3
                oXLSheet.Columns(16).ColumnWidth = 4.57
                oXLSheet.Columns(17).ColumnWidth = 3
                oXLSheet.Columns(18).ColumnWidth = 10.72
                oXLSheet.Range("S:BF").ColumnWidth = 0
                oXLSheet.Columns(59).ColumnWidth = 0
                oXLSheet.Columns(60).ColumnWidth = 7.29
                oXLSheet.Range("BI:BM").ColumnWidth = 0
                oXLSheet.Columns(66).ColumnWidth = 7.29
                oXLSheet.Range("BO:BP").ColumnWidth = 0
        End Select

    End Sub

    Private Sub Format_RVM()
        ' 11 is a parameter that represents the last cell in the spreadsheet containing data. This
        ' command creates a range that starts in cell A1 and extends through all the cells that contain
        ' data. Then it sorts based on whats in B1 (serial number)
        ' Sometimes the log file is generated without a header, in that case we select row 2 to the end
        oXLSheet.Range("A1").SpecialCells(11).Sort(oXLSheet.Range("B1"), 1, , , , , , 1, , , 1, , , , )

        ' Set column widths to fit
        oXLSheet.Columns(1).ColumnWidth = 15
        With oXLSheet.Columns(2)
            .ColumnWidth = 16.14
            .Font.Bold = True
            .Font.Size = 12
            .HorizontalAlignment = &HFFFFEFF4 ' Centered
            .Interior.ColorIndex = 36 ' Yellow
        End With
        oXLSheet.Columns(3).ColumnWidth = 11.57
        oXLSheet.Columns(4).ColumnWidth = 9
        oXLSheet.Columns(5).ColumnWidth = 8.71
        oXLSheet.Columns(6).ColumnWidth = 8.71
        oXLSheet.Columns(7).ColumnWidth = 9.57
        oXLSheet.Columns(8).ColumnWidth = 9.29
        oXLSheet.Columns(9).ColumnWidth = 4.43
        oXLSheet.Columns(10).ColumnWidth = 3.14
        oXLSheet.Columns(11).ColumnWidth = 14.86


    End Sub

    Private Sub Format_Evircom()
        ' 11 is a parameter that represents the last cell in the spreadsheet containing data. This
        ' command creates a range that starts in cell A1 and extends through all the cells that contain
        ' data. Then it sorts based on whats in D1 (serial number)
        oXLSheet.Range("A1").SpecialCells(11).Sort(oXLSheet.Range("D1"), 1, , , , , , 1, , , 1, , , , )

        ' Set column widths to fit
        oXLSheet.Columns(1).ColumnWidth = 16.71
        oXLSheet.Columns(2).ColumnWidth = 6.86
        oXLSheet.Columns(2).ColumnWidth = 8.86
        With oXLSheet.Columns(4)
            .ColumnWidth = 13.71
            .Font.Bold = True
            .Font.Size = 12
            .HorizontalAlignment = &HFFFFEFF4 ' Centered
            .Interior.ColorIndex = 36 ' Yellow
        End With

        oXLSheet.Columns(5).ColumnWidth = 5
        oXLSheet.Columns(6).ColumnWidth = 8
        oXLSheet.Columns(7).ColumnWidth = 8
        oXLSheet.Columns(8).ColumnWidth = 8
        oXLSheet.Columns(9).ColumnWidth = 8
        oXLSheet.Columns(10).ColumnWidth = 11.29
        oXLSheet.Columns(11).ColumnWidth = 21.57

    End Sub

    Private Sub Review_GPS()

        Dim i As Integer
        Dim GPSID(oXLSheet.UsedRange.Rows.Count - 1) As String
        Dim FW(oXLSheet.UsedRange.Rows.Count - 1) As String
        Dim Invalid_FW As Boolean
        Dim J3FW(oXLSheet.UsedRange.Rows.Count - 1) As String
        Dim J3BL(oXLSheet.UsedRange.Rows.Count - 1) As String
        Dim Sim(oXLSheet.UsedRange.Rows.Count - 1) As String
        Dim APN(oXLSheet.UsedRange.Rows.Count - 1) As String
        Dim GPS_Type(oXLSheet.UsedRange.Rows.Count - 1) As String
        Dim GPS_MFG(oXLSheet.UsedRange.Rows.Count - 1) As String
        Dim GPS_Model(oXLSheet.UsedRange.Rows.Count - 1) As String
        Dim CFG_MGR(oXLSheet.UsedRange.Rows.Count - 1) As String

        Dim UniqueCount As Integer

        For i = 1 To oXLSheet.UsedRange.Rows.Count - 1
            If oXLSheet.Cells(i, 74).value = "" Then
                i = dlgConfigManagerMissing.ShowDialog
                Cleanup()
            End If
            If oXLSheet.Cells(i, 75).value = "" Then
                i = dlgConfigManagerMissing.ShowDialog
                Cleanup()
            End If
            If oXLSheet.Cells(i, 76).value = "" Then
                i = dlgConfigManagerMissing.ShowDialog
                Cleanup()
            End If
            If oXLSheet.Cells(i, 77).value = "" Then
                i = dlgConfigManagerMissing.ShowDialog
                Cleanup()
            End If
        Next

        ' Fill arrays with the values to check
        For i = 1 To oXLSheet.UsedRange.Rows.Count - 1
            GPSID(i) = oXLSheet.Cells(i + 1, 2).value 'GPSID
            FW(i) = oXLSheet.Cells(i + 1, 18).value 'GPS Firmware
            J3FW(i) = oXLSheet.Cells(i + 1, 69).value 'J3 Firmware
            J3BL(i) = oXLSheet.Cells(i + 1, 71).value 'J3 Bootloader
            Sim(i) = oXLSheet.Cells(i + 1, 64).value ' Sim Number
            APN(i) = oXLSheet.Cells(i + 1, 65).value 'APN values
            GPS_Type(i) = oXLSheet.Cells(i + 1, 74).value
            GPS_MFG(i) = oXLSheet.Cells(i + 1, 75).value
            GPS_Model(i) = oXLSheet.Cells(i + 1, 76).value
            CFG_MGR(i) = oXLSheet.Cells(i + 1, 77).value
        Next

        ' Sort the GPSID array and compare the values, increment the unique count for each unique value found
        ' then we'll compare the # of uniques found to the total # of ID's found

        Array.Sort(GPSID)
        UniqueCount = 0
        For i = 1 To UBound(GPSID)
            If Not GPSID(i) = GPSID(i - 1) Then ' first record read will compare to a null value and increment counter by 1
                If Not Int(GPSID) Then

                    MsgBox("FAIL!")
                    Exit Sub
                End If

                UniqueCount = UniqueCount + 1 ' subsequent unique values read will increment counter
            End If
        Next
        If UniqueCount < UBound(GPSID) Then ' if we counted less uniques then there are gps id's then there must be a dupe in there somewhere
            dlgReview_GPS.lblDupeCheck.ForeColor = Color.Red
            dlgReview_GPS.lblDupeCheck.Left = 12
            dlgReview_GPS.lblDupeCheck.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
            dlgReview_GPS.lblDupeCheck.Text = "Duplicate GPSID's found"
        Else
            dlgReview_GPS.lblDupeCheck.ForeColor = Color.Lime
            dlgReview_GPS.lblDupeCheck.Left = 25
            dlgReview_GPS.lblDupeCheck.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
            dlgReview_GPS.lblDupeCheck.Text = "Duplicate GPSID check... OK!"
        End If

        ' Sort the Firmware array and compare the values, increment the unique count for each unique value found
        ' Check the firmware version against the expected value
        Array.Sort(FW)
        UniqueCount = 0
        Invalid_FW = False

        For i = 1 To UBound(FW)
            If Not FW(i) = FW(i - 1) Then ' first record read will compare to a null value and inc. counter by 1
                UniqueCount = UniqueCount + 1 ' subsequent unique values read will inc counter
            End If

            If InStr(FW(i), GPS_FW) = 0 And InStr(FW(i), Ztrak_FW) = 0 Then
                Invalid_FW = True
                'MsgBox("looking for: " & Ztrak_FW & vbCrLf & "found : " & FW(i) & vbCrLf & vbCrLf & InStr(FW(i), Ztrak_FW))
            Else

                'Else
                'MsgBox(InStr(FW(i), GPS_FW))
            End If

        Next
        If UniqueCount > 1 Or Invalid_FW = True Then ' > 1 because the first value read is always unique (less than 1 would be impossible and really bad)
            dlgReview_GPS.lblGPSFW.ForeColor = Color.Red
            dlgReview_GPS.lblGPSFW.Left = 12
            dlgReview_GPS.lblGPSFW.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
            dlgReview_GPS.lblGPSFW.Text = "GPS Firmware error found"
        Else
            dlgReview_GPS.lblGPSFW.ForeColor = Color.Lime
            dlgReview_GPS.lblGPSFW.Left = 25
            dlgReview_GPS.lblGPSFW.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
            dlgReview_GPS.lblGPSFW.Text = "GPS Firmware check... OK!"
        End If

        ' Sort the Firmware array and compare the values, increment the unique count for each unique value found
        Array.Sort(J3FW)
        UniqueCount = 0
        For i = 1 To UBound(J3FW)
            If Not J3FW(i) = J3FW(i - 1) Then ' first record read will compare to a null value and inc. counter by 1
                UniqueCount = UniqueCount + 1 ' subsequent unique values read will inc counter
            End If
        Next
        If UniqueCount > 1 Then ' > 1 because the first value read is always unique (less than 1 would be impossible and really bad)
            dlgReview_GPS.lblJ3FW.ForeColor = Color.Red
            dlgReview_GPS.lblJ3FW.Left = 12
            dlgReview_GPS.lblJ3FW.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
            dlgReview_GPS.lblJ3FW.Text = "Multiple J3 Firmware versions found"
        Else
            dlgReview_GPS.lblJ3FW.ForeColor = Color.Lime
            dlgReview_GPS.lblJ3FW.Left = 25
            dlgReview_GPS.lblJ3FW.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
            dlgReview_GPS.lblJ3FW.Text = "J3 Firmware version check... OK!"
        End If

        ' Sort the Firmware array and compare the values, increment the unique count for each unique value found
        Array.Sort(J3BL)
        UniqueCount = 0
        For i = 1 To UBound(J3BL)
            If Not J3BL(i) = J3BL(i - 1) Then ' first record read will compare to a null value and inc. counter by 1
                UniqueCount = UniqueCount + 1 ' subsequent unique values read will inc counter
            End If
        Next
        If UniqueCount > 1 Then ' > 1 because the first value read is always unique (less than 1 would be impossible and really bad)
            dlgReview_GPS.lblJ3BL.ForeColor = Color.Red
            dlgReview_GPS.lblJ3BL.Left = 12
            dlgReview_GPS.lblJ3BL.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
            dlgReview_GPS.lblJ3BL.Text = "Multiple J3 Bootloader versions found"
        Else
            dlgReview_GPS.lblJ3BL.ForeColor = Color.Lime
            dlgReview_GPS.lblJ3BL.Left = 25
            dlgReview_GPS.lblJ3BL.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
            dlgReview_GPS.lblJ3BL.Text = "J3 Bootloader version check... OK!"
        End If


        For i = 1 To UBound(Sim)
            'MsgBox(InStr(Sim(i), "890165"))
            If InStr(Sim(i), "890165") > 0 Then
                dlgReview_GPS.lblSimNumber.ForeColor = Color.Red
                dlgReview_GPS.lblSimNumber.Left = 12
                dlgReview_GPS.lblSimNumber.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
                dlgReview_GPS.lblSimNumber.Text = "Sim numbers... ERROR FOUND"
            Else
                dlgReview_GPS.lblSimNumber.ForeColor = Color.Lime
                dlgReview_GPS.lblSimNumber.Left = 25
                dlgReview_GPS.lblSimNumber.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
                dlgReview_GPS.lblSimNumber.Text = "Sim numbers... OK!"
            End If
        Next

        ' Sort the Firmware array and compare the values, increment the unique count for each unique value found
        Array.Sort(APN)
        UniqueCount = 0
        For i = 1 To UBound(APN)
            If Not APN(i) = APN(i - 1) Then ' first record read will compare to a null value and inc. counter by 1
                UniqueCount = UniqueCount + 1 ' subsequent unique values read will inc counter
            End If
        Next
        If UniqueCount > 1 Then ' > 1 because the first value read is always unique (less than 1 would be impossible and really bad)
            dlgReview_GPS.lblAPN.ForeColor = Color.Red
            dlgReview_GPS.lblAPN.Left = 12
            dlgReview_GPS.lblAPN.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
            dlgReview_GPS.lblAPN.Text = "Multiple APN values found"
        Else
            dlgReview_GPS.lblAPN.ForeColor = Color.Lime
            dlgReview_GPS.lblAPN.Left = 25
            dlgReview_GPS.lblAPN.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
            dlgReview_GPS.lblAPN.Text = "APN value check... OK!"
        End If

        ' Sort the GPS_Type array, increment the unique count for each unique value found
        Array.Sort(GPS_Type)
        UniqueCount = 0
        For i = 1 To UBound(GPS_Type)
            If Not GPS_Type(i) = GPS_Type(i - 1) Then
                UniqueCount = UniqueCount + 1
            End If
        Next

        If UniqueCount > 1 Then 'more than 1 type found
            dlgReview_GPS.lblGPS_Type.ForeColor = Color.Red
            dlgReview_GPS.lblGPS_Type.Left = 12
            dlgReview_GPS.lblGPS_Type.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
            dlgReview_GPS.lblGPS_Type.Text = "GPS Type...  ERROR"
        Else
            dlgReview_GPS.lblGPS_Type.ForeColor = Color.Lime
            dlgReview_GPS.lblGPS_Type.Left = 25
            dlgReview_GPS.lblGPS_Type.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
            dlgReview_GPS.lblGPS_Type.Text = "GPS Type...  " & GPS_Type(1)
        End If

        ' Sort the GPS_Mfg array, increment the unique count for each unique value found
        Array.Sort(GPS_MFG)
        UniqueCount = 0
        For i = 1 To UBound(GPS_MFG)
            If Not GPS_MFG(i) = GPS_MFG(i - 1) Then
                'MessageBox.Show("what it is: " & GPS_MFG(i) & " = " & "what it was " & GPS_MFG(i - 1))
                UniqueCount = UniqueCount + 1
            End If
        Next
        'MessageBox.Show(UniqueCount)
        If UniqueCount > 1 Then 'more than 1 type found
            dlgReview_GPS.lblGPS_Mfg.ForeColor = Color.Red
            dlgReview_GPS.lblGPS_Mfg.Left = 12
            dlgReview_GPS.lblGPS_Mfg.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
            dlgReview_GPS.lblGPS_Mfg.Text = "GPS MFG...  ERROR"
        Else
            dlgReview_GPS.lblGPS_Mfg.ForeColor = Color.Lime
            dlgReview_GPS.lblGPS_Mfg.Left = 25
            dlgReview_GPS.lblGPS_Mfg.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
            dlgReview_GPS.lblGPS_Mfg.Text = "GPS MFG...  " & GPS_MFG(1)
        End If

        ' Sort the GPS_Model array, increment the unique count for each unique value found
        Array.Sort(GPS_Model)
        UniqueCount = 0
        For i = 1 To UBound(GPS_Model)
            If Not GPS_Model(i) = GPS_Model(i - 1) Then
                UniqueCount = UniqueCount + 1
            End If
        Next

        If UniqueCount > 1 Then 'more than 1 type found
            dlgReview_GPS.lblGPS_Model.ForeColor = Color.Red
            dlgReview_GPS.lblGPS_Model.Left = 12
            dlgReview_GPS.lblGPS_Model.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
            dlgReview_GPS.lblGPS_Model.Text = "GPS Model...  ERROR"
        Else
            dlgReview_GPS.lblGPS_Model.ForeColor = Color.Lime
            dlgReview_GPS.lblGPS_Model.Left = 25
            dlgReview_GPS.lblGPS_Model.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
            dlgReview_GPS.lblGPS_Model.Text = "GPS Model...  " & GPS_Model(1)
        End If

        ' Sort the Cfg_Mgr array, increment the unique count for each unique value found
        Array.Sort(CFG_MGR)
        UniqueCount = 0
        For i = 1 To UBound(CFG_MGR)
            If Not CFG_MGR(i) = CFG_MGR(i - 1) Then
                UniqueCount = UniqueCount + 1
            End If
        Next

        If UniqueCount > 1 Then 'more than 1 type found
            dlgReview_GPS.lblCfg_Mgr.ForeColor = Color.Red
            dlgReview_GPS.lblCfg_Mgr.Left = 12
            dlgReview_GPS.lblCfg_Mgr.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
            dlgReview_GPS.lblCfg_Mgr.Text = "GPS MFG...  ERROR"
        Else
            dlgReview_GPS.lblCfg_Mgr.ForeColor = Color.Lime
            dlgReview_GPS.lblCfg_Mgr.Left = 25
            dlgReview_GPS.lblCfg_Mgr.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
            dlgReview_GPS.lblCfg_Mgr.Text = "GPS MFG...  " & CFG_MGR(1)
        End If

        dlgReview_GPS.lblCount.Text = UBound(GPSID) & " records found"
        dlgReview_GPS.lblRecordType.Text = GPS_Model(1)

        Dim result As String = dlgReview_GPS.ShowDialog()
        If result = 2 Then Cleanup() ' user clicked cancel on the dialog, so we quit

    End Sub

    Private Sub Review_2010()

        Dim i, j As Integer
        Dim Unique_Count As Integer
        Dim FreeReports(oXLSheet.UsedRange.Rows.Count - 1) As String
        Dim FW(oXLSheet.UsedRange.Rows.Count - 1) As String
        Dim Battery(oXLSheet.UsedRange.Rows.Count - 1) As String
        Dim TZ(oXLSheet.UsedRange.Rows.Count - 1) As String
        Dim DST(oXLSheet.UsedRange.Rows.Count - 1) As String

        Dim RowNum As Integer
        Dim LotCodes() As Integer
        Dim Total As Integer


        For i = 1 To oXLSheet.UsedRange.Rows.Count - 1
            FreeReports(i) = oXLSheet.Cells(i + 1, 8).value 'Free report count
            'MsgBox(FreeReports(i))
            FW(i) = oXLSheet.Cells(i + 1, 10).value 'firmware
            'MsgBox(FW(i))
            Battery(i) = oXLSheet.Cells(i + 1, 16).value 'battery level
            TZ(i) = oXLSheet.Cells(i + 1, 17).value 'time zone offset
            DST(i) = oXLSheet.Cells(i + 1, 18).value 'DST on/off
        Next

        ' check free reports
        For i = 1 To UBound(FreeReports)
            Select Case FreeReports(i)
                Case "13"
                    dlgReview_2010.lblFreeReportCheck.ForeColor = Color.Lime
                    dlgReview_2010.lblFreeReportCheck.Left = 25
                    dlgReview_2010.lblFreeReportCheck.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
                    dlgReview_2010.lblFreeReportCheck.Text = "Free Report check... OK!"
                Case "19"
                    dlgReview_2010.lblFreeReportCheck.ForeColor = Color.Lime
                    dlgReview_2010.lblFreeReportCheck.Left = 25
                    dlgReview_2010.lblFreeReportCheck.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
                    dlgReview_2010.lblFreeReportCheck.Text = "Free Report check... OK!"
                Case "20"
                    dlgReview_2010.lblFreeReportCheck.ForeColor = Color.Lime
                    dlgReview_2010.lblFreeReportCheck.Left = 25
                    dlgReview_2010.lblFreeReportCheck.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
                    dlgReview_2010.lblFreeReportCheck.Text = "Free Report check... OK!"
                Case Else
                    MsgBox("not 13,20,19 - " & FreeReports(i))
                    dlgReview_2010.lblFreeReportCheck.ForeColor = Color.Red
                    dlgReview_2010.lblFreeReportCheck.Left = 12
                    dlgReview_2010.lblFreeReportCheck.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
                    dlgReview_2010.lblFreeReportCheck.Text = "Free Report check...  ERROR"
                    Exit For
            End Select
        Next

        ' check fw version
        For i = 1 To UBound(FW)
            Select Case FW(i)
                Case "ZNR-4.2.3"
                    dlgReview_2010.lblFirmwareCheck.ForeColor = Color.Lime
                    dlgReview_2010.lblFirmwareCheck.Left = 25
                    dlgReview_2010.lblFirmwareCheck.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
                    dlgReview_2010.lblFirmwareCheck.Text = "Firmware check... OK!"
                Case "ZNR-20.0.0"
                    dlgReview_2010.lblFirmwareCheck.ForeColor = Color.Lime
                    dlgReview_2010.lblFirmwareCheck.Left = 25
                    dlgReview_2010.lblFirmwareCheck.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
                    dlgReview_2010.lblFirmwareCheck.Text = "Firmware check... OK!"
                Case Else
                    dlgReview_2010.lblFirmwareCheck.ForeColor = Color.Red
                    dlgReview_2010.lblFirmwareCheck.Left = 12
                    dlgReview_2010.lblFirmwareCheck.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
                    dlgReview_2010.lblFirmwareCheck.Text = "Firmware check...  ERROR"
                    Exit For
            End Select
        Next

        ' check battery level
        For i = 1 To UBound(Battery)
            If Not Int(Battery(i)) >= 37500 Then
                dlgReview_2010.lblBatteryCheck.ForeColor = Color.Red
                dlgReview_2010.lblBatteryCheck.Left = 12
                dlgReview_2010.lblBatteryCheck.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
                dlgReview_2010.lblBatteryCheck.Text = "Battery Voltage check...  ERROR"
                Exit For
            Else
                dlgReview_2010.lblBatteryCheck.ForeColor = Color.Lime
                dlgReview_2010.lblBatteryCheck.Left = 25
                dlgReview_2010.lblBatteryCheck.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
                dlgReview_2010.lblBatteryCheck.Text = "Battery check... OK!"
            End If
        Next

        ' check time zone and display on dlg
        Unique_Count = 0
        For i = 1 To UBound(TZ)
            If Not TZ(i) = TZ(i - 1) Then ' if we find multiple values
                Unique_Count = Unique_Count + 1
            End If
        Next
        For i = 1 To UBound(DST)
            If Not DST(i) = DST(i - 1) Then 'if we find multiple values
                Unique_Count = Unique_Count + 1
            End If
        Next
        If Unique_Count > 2 Then
            dlgReview_2010.lblTimeZoneCheck.ForeColor = Color.Red
            dlgReview_2010.lblTimeZoneCheck.Left = 12
            dlgReview_2010.lblTimeZoneCheck.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold)
            dlgReview_2010.lblTimeZoneCheck.Text = "Time Zone check...  ERROR"
        Else
            dlgReview_2010.lblTimeZoneCheck.ForeColor = Color.Lime
            dlgReview_2010.lblTimeZoneCheck.Left = 25
            dlgReview_2010.lblTimeZoneCheck.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
            dlgReview_2010.lblTimeZoneCheck.Text = "Time Zone:  " & TZ(1) & " | " & DST(1)
        End If


        '  Now we figure out lot code totals
        '  Load all lot codes into an array
        If (IsNumeric(oXLSheet.Cells(1, 9))) Then ' Header or no?
            RowNum = 1
        Else
            RowNum = 2
        End If
        i = 0
        ReDim LotCodes(oXLSheet.UsedRange.Rows.Count)
        For i = RowNum To (oXLSheet.UsedRange.Rows.Count)
            LotCodes(i) = oXLSheet.Cells(RowNum, 9).value
            RowNum = RowNum + 1
        Next

        ' Check the serials array and write unique lot codes and their count to a second array

        Dim UniqueLotCodes(UBound(LotCodes), 2)

        UniqueLotCodes(0, 0) = LotCodes(0) ' copy the first value because we know it will always be unique
        UniqueLotCodes(0, 1) = "1"

        j = 0 ' holds our position in the unique array							 

        For i = 2 To UBound(LotCodes)
            If LotCodes(i) = LotCodes(i - 1) Then ' if the value matches the value before it (non unique)
                UniqueLotCodes(j, 1) = UniqueLotCodes(j, 1) + 1 'increment the count
            Else ' unique value
                j = j + 1 ' move to next line in the array
                UniqueLotCodes(j, 0) = LotCodes(i) ' copy new value to the unique array
                UniqueLotCodes(j, 1) = 1 ' Set the count to 1
            End If
        Next

        ' Move to the end of the file to write out lot code totals
        RowNum = oXLSheet.UsedRange.Rows.Count + 2

        oXLSheet.Cells(RowNum, 9).value = "Lot Code"
        oXLSheet.Cells(RowNum, 9).Font.Bold = True
        oXLSheet.Cells(RowNum, 9).Font.Underline = True

        oXLSheet.Cells(RowNum, 10).value = "Qty"
        oXLSheet.Cells(RowNum, 10).HorizontalAlignment = &HFFFFEFF4
        oXLSheet.Cells(RowNum, 10).Font.Size = 12
        oXLSheet.Cells(RowNum, 10).Font.Bold = True
        oXLSheet.Cells(RowNum, 10).Font.Underline = True

        RowNum = RowNum + 1
        Total = 0
        For i = 0 To UBound(UniqueLotCodes) - 1

            If UniqueLotCodes(i, 0) >= 1 Then
                oXLSheet.Cells(RowNum, 9).Value = UniqueLotCodes(i, 0)
                oXLSheet.Cells(RowNum, 9).HorizontalAlignment = &HFFFFEFF4
                oXLSheet.Cells(RowNum, 9).Font.Bold = True
                oXLSheet.Cells(RowNum, 10).Value = UniqueLotCodes(i, 1)
                Total = Total + UniqueLotCodes(i, 1)
                oXLSheet.Cells(RowNum, 10).HorizontalAlignment = &HFFFFEFF4
                oXLSheet.Cells(RowNum, 10).Font.Size = 12
                oXLSheet.Cells(RowNum, 10).Font.Bold = True
                RowNum = RowNum + 1
            Else
            End If
        Next


        oXLSheet.Cells(RowNum, 9).Value = "Total: "
        oXLSheet.Cells(RowNum, 9).Font.Bold = True
        oXLSheet.Cells(RowNum, 10).Value = Total
        oXLSheet.Cells(RowNum, 10).HorizontalAlignment = &HFFFFEFF4
        oXLSheet.Cells(RowNum, 10).Font.Size = 12
        oXLSheet.Cells(RowNum, 10).Font.Bold = True

        dlgReview_2010.lblRecordsFound.Text = Total & " Records found"

        ' Show the review dialog
        Dim result As String = dlgReview_2010.ShowDialog()
        If result = 2 Then Cleanup() ' user clicked cancel on the dialog, so we quit

    End Sub

    Private Sub Print()
        Dim Row As Integer
        Dim LastPage As Integer

        ' Calculate the actual last page to print and to display in the footer
        Row = oXLSheet.UsedRange.Rows.Count ' Count the number of rows
        LastPage = Int(Row / 30) ' Divide by 30 (30 rows per page) to get the number of pages
        If Int(Row Mod 30) > 0 Then ' If it isnt a multiple of 30 then add an extra page
            LastPage = LastPage + 1
        End If

        ' Set the header, footer and layout
        With oXLSheet.PageSetup
            .CenterHeader = "&F" ' Filename
            .CenterFooter = "Page &P of " & LastPage  ' Page 1 of x
            .Orientation = 2 ' Landscape
        End With

        oXLSheet.PrintOut(1, LastPage) ' Print from page 1 to LastPage

    End Sub

    Private Sub CreateAdditionalFiles()
        Dim i As Integer

        If DoNavImportFile = True Then

            oXLSheet.Range("C:BK").Clear() ' Erase up to the sim number
            oXLSheet.Range("BM:BU").Clear() ' Erase after the sim number to the next to last column

            For i = 0 To oXLSheet.UsedRange.Rows.Count - 1  ' insert dummy value so excel doesnt muck up the columns in the csv file
                oXLSheet.Cells(i + 1, 68).value = "x"
            Next

            oXLApp.DisplayAlerts = False

            oXLBook.SaveAs("z:\Nav_Import.txt", FileFormat:=Excel.XlFileFormat.xlCSV)

            oXLApp.DisplayAlerts = True

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

End Class
