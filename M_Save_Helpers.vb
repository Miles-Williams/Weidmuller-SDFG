Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Module M_Save_Helpers

    Public Sub SaveToPdf(parExcelData As C_ExcelData, parCells As Excel.Range)
        Dim fileName As String = BuildSaveFileName(parExcelData)
        SaveDocument(fileName, parCells)
    End Sub

    Private Function BuildSaveFileName(parExcelData As C_ExcelData) As String
        Return GetSaveLocationPath(parExcelData) & "\" & GetFileNamePrefix(parExcelData) & "_" & parExcelData.FirstConNumber
    End Function

    Private Function GetSaveLocationPath(parExcelData As C_ExcelData) As String
        Dim destination As String = ""

        Select Case parExcelData.Destination
            Case E_Destination.Domestic
                destination = "Domestic"
            Case E_Destination.International
                destination = "International"
        End Select

        Dim pathPrefix As String
        pathPrefix = parExcelData.SaveDirectoryRoot & "\Security Declaration " & destination & "\"

        If Not Directory.Exists(pathPrefix) Then Directory.CreateDirectory(pathPrefix)

        Dim yearFolderPath As String
        yearFolderPath = pathPrefix & Year(Now)

        If Not Directory.Exists(yearFolderPath) Then Directory.CreateDirectory(yearFolderPath)

        Dim completePath As String
        completePath = yearFolderPath & "\" & MonthName(Month(Now))

        If Not Directory.Exists(completePath) Then Directory.CreateDirectory(completePath)

        Return completePath
    End Function

    Private Function GetFileNamePrefix(parExcelData As C_ExcelData) As String
        Return GetDocumentTypeTla(parExcelData) & "_" & BuildFileNameDateComponent()
    End Function

    Private Function GetDocumentTypeTla(parExcelData As C_ExcelData) As String
        Dim Tla As String = ""

        Select Case parExcelData.Destination
            Case E_Destination.Domestic
                Tla = "SDD"
            Case E_Destination.International
                Tla = "SDI"
        End Select

        Return Tla
    End Function

    Private Function BuildFileNameDateComponent() As String
        Dim iTempDay As Integer
        Dim iTempMonth As Integer
        Dim iTempYear As Integer
        Dim sDay As String
        Dim sMonth As String
        Dim sYear As String

        iTempDay = Microsoft.VisualBasic.Day(Now)
        iTempMonth = Month(Now)
        iTempYear = Year(Now)

        If iTempDay >= 10 Then
            sDay = CStr(iTempDay)
        Else
            sDay = "0" & CStr(iTempDay)
        End If

        If iTempMonth < 10 Then
            sMonth = "0" + CStr(iTempMonth)
        Else
            sMonth = CStr(iTempMonth)
        End If

        sYear = Mid(CStr(iTempYear), 3, 4)
        BuildFileNameDateComponent = sDay & sMonth & sYear
    End Function

    Private Sub SaveDocument(parName As String, parCells As Excel.Range)
        Dim res As MsgBoxResult = MsgBoxResult.Yes

        If File.Exists(parName & ".pdf") Then
            res = MsgBox("The file " & parName & ".pdf already exists. Would you like to overwrite this file?",
                         MsgBoxStyle.YesNo, "Overwrite File?")
        End If

        If res = MsgBoxResult.Yes Then
            parCells.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, parName)
            MsgBox(parName & ".pdf successfully saved.", MsgBoxStyle.OkOnly, "Success")
        Else
            MsgBox("File not saved.", MsgBoxStyle.Critical)
        End If
    End Sub

End Module
