Imports System.Drawing.Printing

<Serializable()>
Public Class C_State
    Public Property CurrentDestination As E_Destination
    Public Property AddTollPrefix As Boolean
    Public Property PrintMedium As E_PrintMedium
    Public Property StickerCopies As Integer
    Public Property PaperCopies As Integer
    Public Property Contents As String
    Public Property VolatileState As C_VolatileState
    Public Property Configuration As C_Configuration
    Public Property Users() As List(Of C_User)

    Public Sub New()
        Dim p As New PrinterSettings

        If Users Is Nothing Then
            Users = New List(Of C_User)
        End If

        If Configuration Is Nothing Then Configuration = New C_Configuration With {
            .CurrentPaperPrinter = p.PrinterName,
            .CurrentStickerPrinter = p.PrinterName,
            .DefaultPaperCopies = 1,
            .DefaultStickerCopies = 1,
            .SaveDirectoryRoot = My.Computer.FileSystem.SpecialDirectories.Desktop.ToString(),
            .DefaultsToDomestic = True,
            .DefaultsToInternational = False,
            .TollPrefixDefault = False,
            .DefaultContents = "Electrical/Electronic Components",
            .KnownConsignorRef = "KNOWN CONSIGNOR: AU-KC/01327-01"
        }

        If VolatileState Is Nothing Then
            VolatileState = New C_VolatileState With {
                .ConNumbers = "",
                .FirstConNumber = ""
            }
            If VolatileState.CurrentUser Is Nothing Then VolatileState.CurrentUser = New C_User("", "Guest", "", "")
        End If

        Contents = Configuration.DefaultContents
        PaperCopies = 1
        StickerCopies = 1
        PrintMedium = E_PrintMedium.Both
        AddTollPrefix = False
        CurrentDestination = E_Destination.Domestic
    End Sub

    <Serializable()>
    Public Class C_VolatileState
        Public Property FirstConNumber As String
        Public Property ConNumbers As String
        Public Property CurrentUser As C_User
    End Class

End Class
