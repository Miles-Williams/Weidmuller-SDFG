Imports Microsoft.Office
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Module M_Excel_Helpers

    Public Sub PassToExcel(parExcelData As C_ExcelData)
        Dim Proceed As Boolean = False
        Dim xlApp = New Excel.Application With {
            .DisplayAlerts = False
        }

        Dim tempFile As String = Path.GetTempFileName()
        File.WriteAllBytes(tempFile, My.Resources.SdfTemplate)
        Dim xlWorkBooks = xlApp.Workbooks
        Dim xlWorkBook = xlWorkBooks.Open(Path.GetFullPath(tempFile))
        Dim xlWorkSheets = xlWorkBook.Sheets
        Dim xlWorkSheet As Excel.Worksheet = Nothing
        Dim xlCells = xlApp.Range("A1:B24")
        For x As Integer = 1 To xlWorkSheets.Count
            xlWorkSheet = CType(xlWorkSheets(x), Excel.Worksheet)
            If xlWorkSheet.Name = My.Resources.ExcelSheetName Then
                Proceed = True
                Exit For
            End If
            Runtime.InteropServices.Marshal.FinalReleaseComObject(xlWorkSheet)
            xlWorkSheet = Nothing
        Next

        If Proceed Then
            FillInForm(xlWorkSheet, parExcelData)
            PrintExcelDocument(xlWorkSheet, parExcelData)
            SaveToPdf(parExcelData, xlCells)
        Else
            MessageBox.Show(My.Resources.ExcelSheetName & " not found.")
        End If

        xlWorkBook.Close()
        xlApp.UserControl = True
        xlApp.Quit()

        If Not xlCells Is Nothing Then ReleaseComObject(xlCells)
        If Not xlWorkSheets Is Nothing Then ReleaseComObject(xlWorkSheets)
        If Not xlWorkSheet Is Nothing Then ReleaseComObject(xlWorkSheet)
        If Not xlWorkBook Is Nothing Then ReleaseComObject(xlWorkBook)
        If Not xlWorkBooks Is Nothing Then ReleaseComObject(xlWorkBooks)
        If Not xlApp Is Nothing Then ReleaseComObject(xlApp)
    End Sub

    <CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification:="<Pending>")>
    Private Sub ReleaseComObject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        End Try
    End Sub

    Private Sub FillInForm(ByRef parWorkSheet As Excel.Worksheet, ByRef parExcelData As C_ExcelData)

        parWorkSheet.Range("Consignor").Value = parExcelData.FullName
        parWorkSheet.Range("Contents_Of_Consignment").Value = parExcelData.Contents
        parWorkSheet.Range("Consignment_Number").Value = parExcelData.ConNumbers
        parWorkSheet.Range("Issue_Date").Value = parExcelData.IssuedOn
        parWorkSheet.Range("Known_Consignor_Ref").Value = parExcelData.KnownConsignorRef

        If parExcelData.SigPath <> "" Then
            parWorkSheet.Shapes.AddPicture(parExcelData.SigPath, Core.MsoTriState.msoFalse, Core.MsoTriState.msoCTrue, 130, 900, 300, 100)
        End If

    End Sub

    Private Sub PrintExcelDocument(parWkSht As Excel.Worksheet, parExcelData As C_ExcelData)

        Dim paperCopies As Integer = parExcelData.PaperCopies
        Dim stickerCopies As Integer = parExcelData.StickerCopies

        Select Case parExcelData.PrintMedium
            Case E_PrintMedium.Both
                parWkSht.PrintOutEx(ActivePrinter:=parExcelData.StickerPrinter, Copies:=stickerCopies)
                parWkSht.PrintOutEx(ActivePrinter:=parExcelData.PaperPrinter, Copies:=paperCopies)
            Case E_PrintMedium.Paper
                parWkSht.PrintOutEx(ActivePrinter:=parExcelData.PaperPrinter, Copies:=paperCopies)
            Case E_PrintMedium.Sticker
                parWkSht.PrintOutEx(ActivePrinter:=parExcelData.StickerPrinter, Copies:=stickerCopies)
        End Select

    End Sub

    Public Sub CheckForExcel()
        Dim officeType As Type = Type.GetTypeFromProgID("Excel.Application")
        If officeType Is Nothing Then MsgBox("This application requires Microsoft Excel 2013 or later to function.")
    End Sub

End Module
