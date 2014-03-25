Imports System.Windows.Forms
Imports System.Drawing.Printing

Public Class dlgPrinter

    Private Sub dlgPrinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim InstalledPrinters As String

        ' Find all printers installed and add it to the combo box
        For Each InstalledPrinters In PrinterSettings.InstalledPrinters
            cboPrinter.Items.Add(InstalledPrinters)
        Next InstalledPrinters
        cboPrinter.SelectedIndex = 0 ' Puts a default value to show in the un-opened box

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Form1.SelectedPrinter = cboPrinter.Text ' Display the selected printer on the main form
        cboPrinter.Items.Clear() ' Empty the box so that if we re-open it we don't get dupes
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub
End Class
