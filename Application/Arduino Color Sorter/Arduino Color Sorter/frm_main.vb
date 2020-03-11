
Imports System.IO
Imports System.IO.Ports
Public Class frm_main

    Dim myPort As Array
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        For i = 0 To UBound(myPort)
            cb_port.Items.Add(myPort(i))
        Next

        btn_discon.Enabled = False




    End Sub

    Private Sub btn_con_Click(sender As Object, e As EventArgs) Handles btn_con.Click
        tb_red.Text = 0
        tb_orange.Text = 0
        tb_yellow.Text = 0
        tb_green.Text = 0
        tb_blue.Text = 0
        tb_brown.Text = 0
        TextBox1.Text = 0
        numred = 0
        numorange = 0
        numyellow = 0
        numgreen = 0
        numblue = 0
        numbrown = 0
        countnum = 0

        SerialPort1.PortName = cb_port.Text
        SerialPort1.BaudRate = 9600

        SerialPort1.Open()

        Timer1.Interval = 500
        Timer1.Start()
        btn_con.Enabled = False
        btn_discon.Enabled = True


    End Sub

    Private Sub btn_discon_Click(sender As Object, e As EventArgs) Handles btn_discon.Click
        Timer1.Stop()
        SerialPort1.Close()
        btn_con.Enabled = True
        btn_discon.Enabled = False


    End Sub

    Private Sub cb_port_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_port.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.PortName = cb_port.Text
        Else
            MsgBox("This port has already been used.!!", vbCritical, "System Messages")
        End If
    End Sub


    Dim numred As Integer = 0
    Dim numorange As Integer = 0
    Dim numyellow As Integer = 0
    Dim numgreen As Integer = 0
    Dim numblue As Integer = 0
    Dim numbrown As Integer = 0

    Dim countnum As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SerialPort1.BytesToRead > 0 Then  ' ตรวจสอบว่าArduino มีการส่งข้อมูลเข้ามาทาง Port ไหม
            Dim Color() As String = Split(SerialPort1.ReadLine, ",")   ' เก็บค่าที่ Arduino ส่งมา

            If Color(0).Trim = "red" Then
                numred = numred + 1
                tb_red.Text = numred
                countnum = countnum + 1
            ElseIf Color(0).Trim = "orange" Then
                numorange = numorange + 1
                tb_orange.Text = numorange
                countnum = countnum + 1
            ElseIf Color(0).Trim = "yellow" Then
                numyellow = numyellow + 1
                tb_yellow.Text = numyellow
                countnum = countnum + 1
            ElseIf Color(0).Trim = "green" Then
                numgreen = numgreen + 1
                tb_green.Text = numgreen
                countnum = countnum + 1
            ElseIf Color(0).Trim = "blue" Then
                numblue = numblue + 1
                tb_blue.Text = numblue
                countnum = countnum + 1
            ElseIf Color(0).Trim = "brown" Then
                numbrown = numbrown + 1
                tb_brown.Text = numbrown
                countnum = countnum + 1
            End If
            'If NewTemp(0) = 0 Then
            '    numred = numred + 1
            '    tb_red.Text = numred
            '    countnum = countnum + 1
            'ElseIf NewTemp(0) = 1 Then
            '    numorange = numorange + 1
            '    tb_orange.Text = numorange
            '    countnum = countnum + 1
            'End If

            TextBox1.Text = countnum
        End If
    End Sub
End Class
