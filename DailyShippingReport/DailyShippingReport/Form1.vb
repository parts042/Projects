Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Dim oXLApp As New Excel.Application
    Dim oXLBook As Excel.Workbook
    Dim oXLSheet As Excel.Worksheet


    Private Sub Open_Report(ReportName As String)


        oXLApp.Visible = True ' *** Show for now, hide when done coding  ***
        oXLBook = oXLApp.Workbooks.Open(ReportName)
        oXLSheet = oXLBook.Worksheets(1)


    End Sub

    Private Sub Form1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter, Label23.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        oXLApp.Quit() 'Close Excel
        oXLApp = Nothing

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'bleh
        Me.Width = 420
        Me.Height = 317
        Label23.Left = 113
        Label23.Top = 121
        StatusStrip1.Visible = False
        lstLog.Items.Clear()

    End Sub

    Private Sub Form1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop, Label23.DragDrop

        Me.Cursor = Cursors.WaitCursor

        Dim theFiles() As String = CType(e.Data.GetData("FileDrop", True), String())
        For Each theFile As String In theFiles
            If Path.GetFileName(theFile) = "Daily Shipping Report.xls" Then
                ' Reformat the form to show the results
                Label23.Visible = False

                GroupBox1.Left = 12
                GroupBox2.Left = 12
                GroupBox3.Left = 12
                GroupBox4.Left = 12
                GroupBox5.Left = 12
                StatusStrip1.Visible = True
                lstLog.Left = GroupBox1.Left + 164

                Me.Width = 420
                Me.Height = 651
                'Me.Left = Me.Left + 94
                Me.Top = Me.Top - 34
                ' Me.Text = ""

                Open_Report(theFile)
                Process_Report()

                lblStatus.Text = "Done"

            End If
        Next


        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Process_Report()

        Dim TotalPackages As Integer = oXLSheet.UsedRange.Rows.Count

        ' Create an array to hold all the internal custoemrs so that we can ignore them later
        ' Need to figure out how to keep this updated as new internal customers are created
        Dim InternalCustomers() As String = New String() {"BONNINGTON", "BOONE", "BOROFF", "BRUNY", "BRYANT", "BURK", "CARL", "CC2020", "CHAPMAN", "CLIFFORD", _
                                                          "COHILL", "CRUMPTON", "ELKINGTON", "ELLINGSON", "FANTICH", "FORREST", "GOUDY", "HEISLER", "HERRERA", _
                                                          "HUTCHIN", "INSTALL", "KJ", "MACH", "MATTS", "MIKETRASK", "NANTKES", "OCONNELL", "PHILLIPS", "RUSSELL", _
                                                          "RWEIMER", "SOMMA", "STONE", "WEIMER", "ZONAR SUPPORT", "ZZZ0001"}

        ' Create arrays to hold the kits for each product type
        Dim V3_Kits() As String = New String() {"H40010", "H40010-P", "INSP US", "PILOT INSP US", "HPV2J03", "HRV2J02", "HSV2J06", "H40000", "H40001", "H40001-P", _
                                                "H40001R", "H40006", "H40008", "H40009", "V3001-H", "H40003", "H40003P", "H40003R", "H40300", "H40015", "H40029", _
                                                "H40016", "H40020", "H40021", "H40025", "H40314", "H40315", "H40316", "H40317", "H40030", "H40037", "10079"}

        Dim V3A_Kits() As String = New String() {"10086"}

        Dim Evir_Kits() As String = New String() {"EVIR001-H", "H40005", "H40005-P", "HREVI01", "HSEVI01", "P40010", "HSHAN10", "HSEVI02", "H40010", "H40010-P", _
                                                 "INSP US", "PILOT INSP US", "EVIR002-H", "H40010E", "H40005-N", "H40016", "20001"}
        Dim Tablet_Kits() As String = New String() {"20048", "H40031", "MOB001-H"}

        Dim V3R_Kits() As String = New String() {"10083", "H40036", "V3R001-H", "V3R002-H"}

        Dim ZPASS_Kits() As String = New String() {"H40012", "HPZPA02", "HSZPA02", "H40026", "H40028", "ZPASS001-H", "ZPASS002-H", "30013", "30025"}

        Dim ZTRAK_Kits() As String = New String() {"H40014", "H40014-P", "ZTRAK001-H", "10076", "10082"}

        Dim VTHU_Kits() As String = New String() {"10080", "10081"}

        Dim ZCON_Truck() As String = New String() {"80510", "H40301", "H40302", "H40303", "H40304", "H40305", "H40306", "H40307", "H40308", "H40309", "H40310", _
                                                   "H40311", "H40312", "H40313", "H40314", "H40315", "H40316", "H40317"}

        Dim ZCON_Pump() As String = New String() {"80476", "80521"}



        For i = 4 To oXLSheet.UsedRange.Rows.Count 'Skip the header lines

            Dim OrderType As String = (oXLSheet.Cells(i, 8).value).substring(0, 1)
            Dim Customer As String = "Direct"
            Dim Product_Type As String = ""

            ' Look through each product array and see if the part number is in there
            If V3_Kits.Contains(oXLSheet.Cells(i, 17).value) Then
                Product_Type = "V3"
            ElseIf V3A_Kits.Contains(oXLSheet.Cells(i, 17).value) Then
                Product_Type = "V3A"
            ElseIf Evir_Kits.Contains(oXLSheet.Cells(i, 17).value) Then
                Product_Type = "EVIR"
            ElseIf Tablet_Kits.Contains(oXLSheet.Cells(i, 17).value) Then
                Product_Type = "Tablet"
            ElseIf V3R_Kits.Contains(oXLSheet.Cells(i, 17).value) Then
                Product_Type = "V3R"
            ElseIf ZPASS_Kits.Contains(oXLSheet.Cells(i, 17).value) Then
                Product_Type = "ZPASS"
            ElseIf ZTRAK_Kits.Contains(oXLSheet.Cells(i, 17).value) Then
                Product_Type = "ZTRAK"
            ElseIf VTHU_Kits.Contains(oXLSheet.Cells(i, 17).value) Then
                Product_Type = "VTHU"
            ElseIf ZCON_Truck.Contains(oXLSheet.Cells(i, 17).value) Then
                Product_Type = "ZCON_TRUCK"
            ElseIf ZCON_Pump.Contains(oXLSheet.Cells(i, 17).value) Then
                Product_Type = "ZCON_PUMP"
            End If

            ' Caluclate if this is a direct sale or large account
            If (oXLSheet.Cells(i, 15).value).substring(0, 3) = "FIR" Then Customer = "FS"
            If (oXLSheet.Cells(i, 15).value).substring(0, 3) = "FTB" Then Customer = "FS"
            If (oXLSheet.Cells(i, 15).value) = "THOMAS BUILT BUSES" Then Customer = "FS" ' Might be an issue if Thomas starts building for someone else
            If (oXLSheet.Cells(i, 15).value).substring(0, 3) = "DUR" Then Customer = "NEC"
            If (oXLSheet.Cells(i, 15).value).substring(0, 3) = "STK" Then Customer = "NEC"
            If (oXLSheet.Cells(i, 15).value) = "MACQUARIE" Then Customer = "NEC"
            If (oXLSheet.Cells(i, 15).value).substring(0, 3) = "PFJ" Then Customer = "ZCON"
            If (oXLSheet.Cells(i, 15).value).substring(0, 3) = "TCH" Then Customer = "ZCON"
            If (oXLSheet.Cells(i, 15).value).substring(0, 3) = "ZVT" Then Customer = "DTNA"
            ' There are a couple fringe accounts the might get lumped in with NEC
            If (oXLSheet.Cells(i, 15).value) = "DUR1708" Then Customer = "Direct"
            If (oXLSheet.Cells(i, 15).value) = "DUR2370" Then Customer = "Direct"


            If OrderType = "S" Then 'Ignore RMA's

                If Not InternalCustomers.Contains(oXLSheet.Cells(i, 15).value) Then 'ignore internal sales

                    Select Case Product_Type

                        Case "V3"
                            Select Case Customer
                                Case "FS"
                                    lblFSGPS.Text = lblFSGPS.Text + oXLSheet.Cells(i, 19).value
                                    'lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - FS GPS")
                                Case "NEC"
                                    lblNECGPS.Text = lblNECGPS.Text + oXLSheet.Cells(i, 19).value
                                    'lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - NEC GPS")
                                Case "Direct"
                                    lblDirectGPS.Text = lblDirectGPS.Text + oXLSheet.Cells(i, 19).value
                                    lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - Direct GPS")
                            End Select

                        Case "V3A"
                            Select Case Customer
                                Case "FS"
                                    lblFSV3A.Text = lblFSV3A.Text + oXLSheet.Cells(i, 19).value
                                    'lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - FS V3A")
                                Case "NEC"
                                    lblNECV3A.Text = lblNECV3A.Text + oXLSheet.Cells(i, 19).value
                                    'lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - NEC V3A")
                                Case "Direct"
                                    lblDirectV3A.Text = lblDirectV3A.Text + oXLSheet.Cells(i, 19).value
                                    'lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - Direct V3A")
                            End Select

                        Case "EVIR"
                            Select Case Customer
                                Case "FS"
                                    LBLFSEVIR.Text = LBLFSEVIR.Text + oXLSheet.Cells(i, 19).value
                                    'lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - FS Evir")
                                Case "NEC"
                                    lblNECEVIR.Text = lblNECEVIR.Text + oXLSheet.Cells(i, 19).value
                                    ' lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - nec Evir")
                                Case "Direct"
                                    lblDirectEVIR.Text = lblDirectEVIR.Text + oXLSheet.Cells(i, 19).value
                                    'lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - Direct Evir")
                            End Select

                        Case "TABLET"
                            Select Case Customer
                                Case "FS"
                                    lblFS2020.Text = lblFS2020.Text + oXLSheet.Cells(i, 19).value
                                    'lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - FS 2020")
                                Case "NEC"
                                    lblNEC2020.Text = lblNEC2020.Text + oXLSheet.Cells(i, 19).value
                                    ' lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - NEC 2020")
                                Case "ZCON"
                                    lblZCON2020.Text = lblZCON2020.Text + oXLSheet.Cells(i, 19).value
                                    ' lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - ZCON 2020")
                                Case "DTNA"
                                    lblDTNA2020.Text = lblDTNA2020.Text + oXLSheet.Cells(i, 19).value
                                    ' lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - DTNA 2020")
                                Case "Direct"
                                    lblDirect2020.Text = lblDirect2020.Text + oXLSheet.Cells(i, 19).value
                                    ' lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - Direct 2020")
                            End Select

                        Case "V3R"
                            lblDirectV3R.Text = lblDirectV3R.Text + oXLSheet.Cells(i, 19).value
                            ' lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - Direct V3R")

                        Case "ZPASS"
                            Select Case Customer
                                Case "FS"
                                    lblFSZPASS.Text = lblFSZPASS.Text + oXLSheet.Cells(i, 19).value
                                    ' lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - FS ZPASS")
                                Case "NEC"
                                    lblNECZPASS.Text = lblNECZPASS.Text + oXLSheet.Cells(i, 19).value
                                    '  lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - NEC ZPASS")
                                Case "Direct"
                                    lblDirectZPASS.Text = lblDirectZPASS.Text + oXLSheet.Cells(i, 19).value
                                    ' lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - Direct ZPASS")
                            End Select

                        Case "ZTRAK"
                            lblDirectZTRAK.Text = lblDirectZTRAK.Text + oXLSheet.Cells(i, 19).value
                            '  lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - Direct ZTRAK")

                        Case "VTHU"
                            lblDTNAGPS.Text = lblDTNAGPS.Text + oXLSheet.Cells(i, 19).value
                            ' lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - DTNAGPS")

                        Case "ZCON_TRUCK"
                            lblZCONTruck.Text = lblZCONTruck.Text + oXLSheet.Cells(i, 19).value
                            'lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - ZCON Truck")

                        Case "ZCON_PUMP"
                            lblZCONPump.Text = lblZCONPump.Text + oXLSheet.Cells(i, 19).value
                            ' lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - ZCON Pump")

                        Case Else
                            'lstLog.Items.Add(oXLSheet.Cells(i, 2).value & " - QTY " & oXLSheet.Cells(i, 19).value & " - " & oXLSheet.Cells(i, 17).value & " - UNKNOWN")
                    End Select

                End If
            End If






        Next

        lstLog.Items.Add(" ")
        lstLog.Items.Add(" ** COMPLETE **")

    End Sub

End Class
