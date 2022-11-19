Imports System.IO.Ports
Imports System.Threading

Public Class MainScreen
    Dim x = 0, y = 120, z = 120
    '[X:198.50 Y:194.00 Z:140.00 
    Sub GetSerialPortNames()
        ' Show all available COM ports.
        ListPorts.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ListPorts.Items.Add(sp)
        Next
    End Sub
    Sub SendSerialData(ByVal data As String)
        Try
            SP_Write(data)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try

    End Sub


    Private Sub ListPorts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPorts.SelectedIndexChanged
        lbl_port_selected.Text = ListPorts.GetItemText(ListPorts.SelectedItem)
    End Sub


    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        Dim portSelected = lbl_port_selected.Text
        Dim baud = cmb_baud.Text
        If portSelected = "No Port" Or String.IsNullOrEmpty(portSelected) Then
            MsgBox("No Port ", MsgBoxStyle.Critical, "Information Message")
            Exit Sub
        End If
        lbl_portstatus.Text = "Connecting..."
        Try
            SP_Open(portSelected, baud)
            MsgBox("Connection successful", MsgBoxStyle.Information, "Information Message")
            btn_connect.Enabled = False
            btn_close.Enabled = True
            PanelOn()
            Timer1.Enabled = True
            Timer1.Start()
        Catch ex As Exception
            btn_connect.Enabled = True
            btn_close.Enabled = False
            PanelOff()
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try

        lbl_portstatus.Text = "Connected"


    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Dim data = txtCommand.Text
        Try
            SP_Write(data)
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try
            Dim msj = SP_Read()
            If msj = "" Or String.IsNullOrEmpty(msj) Then

            Else
                RTOutput.Text = msj
            End If
            btn_connect.Enabled = False
            btn_close.Enabled = True
        Catch ex As Exception
            SP_Close()
            PanelOff()
            Timer1.Stop()
            btn_connect.Enabled = True
            btn_close.Enabled = False
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub PanelOn()
        panel_commands.Enabled = True
        panel_serial.Enabled = True
        panel_ctrl.Enabled = True
        panel_commandlist.Enabled = True
    End Sub

    Private Sub PanelOff()
        panel_commands.Enabled = False
        panel_serial.Enabled = False
        panel_ctrl.Enabled = False
        panel_commandlist.Enabled = False
    End Sub
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Try
            SP_Close()
            Timer1.Enabled = False
            Timer1.Stop()
            btn_connect.Enabled = True
            btn_close.Enabled = False
            PanelOff()
            MsgBox("Connection close", MsgBoxStyle.Information, "Information Message")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try

        lbl_portstatus.Text = "Not Connected"
    End Sub

    Private Sub btnPort_Click(sender As Object, e As EventArgs) Handles btnPort.Click
        GetSerialPortNames()
    End Sub

    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_close.Enabled = False
        btn_connect.Enabled = True
        PanelOff()
        GetSerialPortNames()
        loadFile()
    End Sub
    Private Sub loadFile()
        If System.IO.File.Exists("C://Users/DELL/source/repos/Robot Arm Controller/commands.txt") Then
            Dim lines() As String = IO.File.ReadAllLines("C://Users/DELL/source/repos/Robot Arm Controller/commands.txt")
            listCmds.Items.AddRange(lines)
        End If

    End Sub
    Private Sub trck_speed_Scroll(sender As Object, e As EventArgs) Handles trck_speed.Scroll
        lbl_speed.Text = trck_speed.Value

    End Sub



    Private Sub btn_stepon_Click(sender As Object, e As EventArgs) Handles btn_stepon.Click
        Try
            SP_Write("M17")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btn_stepoff_Click(sender As Object, e As EventArgs) Handles btn_stepoff.Click
        Try
            SP_Write("M18")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btn_fanon_Click(sender As Object, e As EventArgs) Handles btn_fanon.Click
        Try
            SP_Write("M106")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btn_fanoff_Click(sender As Object, e As EventArgs) Handles btn_fanoff.Click
        Try
            SP_Write("M17")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub


    Private Sub btn_left_x_Click(sender As Object, e As EventArgs) Handles btn_left_x.Click
        Try
            Dim steps = lbl_step.Text
            'limit 262 to - 262
            x = x - steps
            ' y = y + steps
            ' z = z + steps
            'Or (y <= 100 Or y >= 270) Or (z <= 80 Or z >= 170) 

            If (x <= -262 Or x >= 262) Then
                x = -262
                MsgBox("Out of Range", MsgBoxStyle.Critical, "Error Message")
                Exit Sub
            End If

            Dim speed = lbl_speed.Text
            Dim cmd = "G0X" & x & "Y" & y & "Z" & z & "F" & speed
            lblPosition.Text = "X:" & x & " Y:" & y & " Z:" & z
            txtCommand.Text = cmd
            SP_Write(cmd)
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub
    Private Sub btn_right_x_Click(sender As Object, e As EventArgs) Handles btn_right_x.Click
        Try
            Dim steps = lbl_step.Text
            x = x + steps
            ' y = y - steps
            '  z = z - steps
            'Or (y <= 100 Or y >= 270) Or (z <= 80 Or z >= 170) 
            If (x <= -262 Or x >= 262) Then
                x = 262
                MsgBox("Out of Range", MsgBoxStyle.Critical, "Error Message")
                Exit Sub
            End If

            Dim speed = lbl_speed.Text
            Dim cmd = "G0X" & x & "Y" & y & "Z" & z & "F" & speed
            lblPosition.Text = "X:" & x & " Y:" & y & " Z:" & z
            txtCommand.Text = cmd
            SP_Write(cmd)
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub




    Private Sub btn_down_y_Click(sender As Object, e As EventArgs) Handles btn_down_y.Click
        Try
            Dim steps = lbl_step.Text
            y = y - steps
            If (y <= -288 Or y >= 288) Then
                y = -288
                MsgBox("Out of Range", MsgBoxStyle.Critical, "Error Message")
                Exit Sub
            End If

            Dim speed = lbl_speed.Text
            Dim cmd = "G0X" & x & "Y" & y & "Z" & z & "F" & speed
            lblPosition.Text = "X:" & x & " Y:" & y & " Z:" & z
            txtCommand.Text = cmd
            SP_Write(cmd)
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btn_up_y_Click(sender As Object, e As EventArgs) Handles btn_up_y.Click
        Try
            Dim steps = lbl_step.Text
            y = y + steps
            If (y <= -288 Or y >= 288) Then
                y = 288
                MsgBox("Out of Range", MsgBoxStyle.Critical, "Error Message")
                Exit Sub
            End If

            Dim speed = lbl_speed.Text
            Dim cmd = "G0X" & x & "Y" & y & "Z" & z & "F" & speed
            lblPosition.Text = "X:" & x & " Y:" & y & " Z:" & z
            txtCommand.Text = cmd
            SP_Write(cmd)
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub


    Private Sub btn_z_up_Click(sender As Object, e As EventArgs) Handles btn_z_up.Click
        Try
            Dim steps = lbl_step.Text
            z = z + steps
            'If (z <= 62 Or z >= 170) Then
            '    z = 62
            '    MsgBox("Out of Range", MsgBoxStyle.Critical, "Error Message")
            '    Exit Sub
            'End If

            Dim speed = lbl_speed.Text
            Dim cmd = "G0X" & x & "Y" & y & "Z" & z & "F" & speed
            lblPosition.Text = "X:" & x & " Y:" & y & " Z:" & z
            txtCommand.Text = cmd
            SP_Write(cmd)
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub
    Private Sub btn_down_z_Click(sender As Object, e As EventArgs) Handles btn_down_z.Click
        Try
            Dim steps = lbl_step.Text
            z = z - steps
            'If (z <= 62 Or z >= 170) Then
            '    z = -170
            '    MsgBox("out of range", MsgBoxStyle.Critical, "error message")
            '    Exit Sub
            'End If

            Dim speed = lbl_speed.Text
            Dim cmd = "G0X" & x & "Y" & y & "Z" & z & "F" & speed
            lblPosition.Text = "X:" & x & " Y:" & y & " Z:" & z
            txtCommand.Text = cmd
            SP_Write(cmd)
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub
    Private Sub trackStep_Scroll(sender As Object, e As EventArgs) Handles trackStep.Scroll
        lbl_step.Text = trackStep.Value
    End Sub

    Private Sub btn_abs_Click(sender As Object, e As EventArgs) Handles btn_abs.Click
        Try
            SP_Write("G90")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btn_relative_Click(sender As Object, e As EventArgs) Handles btn_relative.Click
        Try
            SP_Write("G91")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btnFanOn_Click(sender As Object, e As EventArgs) Handles btnFanOn.Click
        Try
            SP_Write("M106")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btnFanOff_Click(sender As Object, e As EventArgs) Handles btnFanOff.Click
        Try
            SP_Write("M107")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btn_homing_Click(sender As Object, e As EventArgs) Handles btn_homing.Click
        Try
            SP_Write("G28")
            MsgBox("Homing Completed", MsgBoxStyle.Information, "Information")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        x = 0
        y = 120
        z = 120

        Try
            Dim speed = lbl_speed.Text
            Dim cmd = "G0X0Y120Z120F" & speed
            lblPosition.Text = "X:0 Y:120 Z:120"
            txtCommand.Text = cmd
            SP_Write(cmd)
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btn_speed_flat_Click(sender As Object, e As EventArgs) Handles btn_speed_flat.Click
        Try
            SP_Write("M205S0")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btn_curve_speed_Click(sender As Object, e As EventArgs) Handles btn_curve_speed.Click
        Try
            SP_Write("M205S2")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btn_grip_on_Click(sender As Object, e As EventArgs) Handles btn_grip_on.Click
        Try
            SP_Write("M3")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btn_grip_off_Click(sender As Object, e As EventArgs) Handles btn_grip_off.Click
        Try
            SP_Write("M5")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btn_addcmd_Click(sender As Object, e As EventArgs) Handles btn_addcmd.Click
        If (txtCommand.Text = "" Or String.IsNullOrEmpty(txtCommand.Text)) Then
            MsgBox("Command not available", MsgBoxStyle.Critical, "Error Message")
            Exit Sub
        End If
        listCmds.Items.Add(txtCommand.Text)
        My.Computer.FileSystem.WriteAllText("C://Users/DELL/source/repos/Robot Arm Controller/commands.txt", txtCommand.Text & vbNewLine, True)

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        If listCmds.Items.Count = 0 Then
            Exit Sub
        End If
        Dim Msg, Style, Title, Response
        Msg = "Do you want to remove all commands?"    ' Define message.
        Style = vbYesNo Or vbCritical Or vbDefaultButton2    ' Define buttons.
        Title = "Confirmation"    ' Define title.

        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then    ' User chose Yes.
            listCmds.Items.Clear()
            My.Computer.FileSystem.DeleteFile("C://Users/DELL/source/repos/Robot Arm Controller/commands.txt")
        Else    ' User chose No.


        End If



    End Sub

    Private Sub btn_execute_Click(sender As Object, e As EventArgs) Handles btn_execute.Click
        For Each item In listCmds.Items
            Try
                SP_Write(item.ToString)
            Catch ex As Exception
                Timer1.Enabled = False
                Timer1.Stop()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
            End Try
            Thread.Sleep(200)
        Next


    End Sub

    Private Sub btn_coordinate_Click(sender As Object, e As EventArgs) Handles btn_coordinate.Click
        Try
            SP_Write("M114")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub

    Private Sub btn_endStop_Click(sender As Object, e As EventArgs) Handles btn_endStop.Click
        Try
            SP_Write("M119")
        Catch ex As Exception
            Timer1.Enabled = False
            Timer1.Stop()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Message")
        End Try
    End Sub
End Class
