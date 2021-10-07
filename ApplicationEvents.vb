Imports System.Text
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.Devices

Namespace My
    'The following events are available For MyApplication
    'Startup: Raised when the application starts, before the startup form Is created.
    'Shutdown: Raised after all application forms are closed.  This Event Is Not raised If the application terminates abnormally.
    'UnhandledException: Raised if the application encounters an unhandled exception.
    'StartupNextInstance: Raised when launching a single-instance application And the application Is already active. 
    'NetworkAvailabilityChanged: Raised when the network connection Is connected Or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            CheckForExcel()
        End Sub

        Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            If Not e.IsNetworkAvailable Then
                Dim sb As New StringBuilder
                sb.AppendLine("A change in your network settings has been detected.")
                sb.AppendLine("You appear to have no network availability.")
                sb.AppendLine("Please check your network connection before proceeding.")
                MsgBox(sb.ToString())
            End If
        End Sub

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            'My.Forms.F_Main.WindowState = FormWindowState.Normal
            e.BringToForeground = True
        End Sub

    End Class

End Namespace
