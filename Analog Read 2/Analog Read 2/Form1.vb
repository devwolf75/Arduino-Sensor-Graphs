Imports System.IO.Ports
Imports System.IO
Imports System.Threading

Public Class TestClass

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        SerialPort1.Open()
        TextBox1.Text = SerialPort1.read()
        SerialPort1.Close()
    End Sub

    

End Class





Public Class Form1
    Shared _continue As Boolean
    Shared _serialPort As SerialPort

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SerialPort1.Close()
        SerialPort1.PortName = "com5" 'change com port to match your Arduino port
        SerialPort1.BaudRate = 9600
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
    End Sub





End Class
