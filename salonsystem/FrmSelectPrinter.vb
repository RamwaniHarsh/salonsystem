Public Class FrmSelectPrinter
    Private Sub FrmSelectPrinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPrinterName.Text = My.Settings.printer
    End Sub

    Private Sub btnChoosePrinter_Click(sender As Object, e As EventArgs) Handles btnChoosePrinter.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        txtPrinterName.Text = PrintDialog1.PrinterSettings.PrinterName
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        My.Settings.printer = txtPrinterName.Text
        My.Settings.Save()
        Me.Close()
        main.Show()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClearPrinter_Click(sender As Object, e As EventArgs) Handles btnClearPrinter.Click
        txtPrinterName.Text = ""
    End Sub
End Class