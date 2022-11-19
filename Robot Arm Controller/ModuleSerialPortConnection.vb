Imports System.IO.Ports

Module ModuleSerialPortConnection
    Dim SP As New System.IO.Ports.SerialPort

    Public Sub SP_Open(ByVal P As String, ByVal B As Integer)
        SP.PortName = P
        SP.BaudRate = B
        SP.Parity = IO.Ports.Parity.None
        SP.StopBits = IO.Ports.StopBits.One
        SP.DataBits = 8
        SP.Handshake = IO.Ports.Handshake.None
        SP.Encoding = System.Text.Encoding.Default
        'SP.Encoding = New System.Text.ASCIIEncoding
        SP.Open()
    End Sub

    Public Sub SP_Close()
        SP.Close()
    End Sub

    Public Function SP_Read()
        Dim Result As String = SP.ReadExisting
        Return Result
    End Function

    Public Function SP_Write(ByVal Str As String)
        SP.WriteLine(Str & vbCr)
        Return Str
    End Function

    Private Function UnicodeStringToBytes(
    ByVal str As String) As Byte()

        Return System.Text.Encoding.Unicode.GetBytes(str)
    End Function
End Module
