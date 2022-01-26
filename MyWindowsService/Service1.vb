Public Class Service1

    Dim tmr As Timers.Timer

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        tmr = New Timers.Timer()
        tmr.Interval = 1000
        AddHandler tmr.Elapsed, AddressOf MyTickHandler
        tmr.Enabled = True
        FileIO.WriteToFile("Service is Started!" + vbNewLine)
    End Sub

    Protected Overrides Sub OnStop()

        tmr.Enabled = False
        FileIO.WriteToFile("Service is Stopped!" + vbNewLine)

    End Sub

    Private Sub MyTickHandler(obj As Object, e As EventArgs)

        FileIO.WriteToFile("1 sec is over!" + vbNewLine)
    End Sub



End Class
