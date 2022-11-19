<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.ListPorts = New System.Windows.Forms.ListBox()
        Me.btnPort = New System.Windows.Forms.Button()
        Me.txtCommand = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_baud = New System.Windows.Forms.ComboBox()
        Me.lbl_portstatus = New System.Windows.Forms.Label()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.lbl_port_selected = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_serial = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RTOutput = New System.Windows.Forms.RichTextBox()
        Me.btn_left_x = New System.Windows.Forms.Button()
        Me.btn_right_x = New System.Windows.Forms.Button()
        Me.panel_ctrl = New System.Windows.Forms.Panel()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lbl_step = New System.Windows.Forms.Label()
        Me.trackStep = New System.Windows.Forms.TrackBar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_z_up = New System.Windows.Forms.Button()
        Me.btn_down_z = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_speed = New System.Windows.Forms.Label()
        Me.trck_speed = New System.Windows.Forms.TrackBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_up_y = New System.Windows.Forms.Button()
        Me.btn_down_y = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_commands = New System.Windows.Forms.Panel()
        Me.btn_grip_off = New System.Windows.Forms.Button()
        Me.btn_grip_on = New System.Windows.Forms.Button()
        Me.btn_curve_speed = New System.Windows.Forms.Button()
        Me.btn_speed_flat = New System.Windows.Forms.Button()
        Me.btnFanOff = New System.Windows.Forms.Button()
        Me.btnFanOn = New System.Windows.Forms.Button()
        Me.btn_relative = New System.Windows.Forms.Button()
        Me.btn_abs = New System.Windows.Forms.Button()
        Me.btn_endStop = New System.Windows.Forms.Button()
        Me.btn_coordinate = New System.Windows.Forms.Button()
        Me.btn_fanoff = New System.Windows.Forms.Button()
        Me.btn_fanon = New System.Windows.Forms.Button()
        Me.btn_stepoff = New System.Windows.Forms.Button()
        Me.btn_stepon = New System.Windows.Forms.Button()
        Me.btn_homing = New System.Windows.Forms.Button()
        Me.panel_commandlist = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.listCmds = New System.Windows.Forms.ListBox()
        Me.btn_addcmd = New System.Windows.Forms.Button()
        Me.btn_execute = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.panel_serial.SuspendLayout()
        Me.panel_ctrl.SuspendLayout()
        CType(Me.trackStep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trck_speed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_commands.SuspendLayout()
        Me.panel_commandlist.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSend
        '
        Me.BtnSend.Location = New System.Drawing.Point(212, 88)
        Me.BtnSend.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(120, 49)
        Me.BtnSend.TabIndex = 0
        Me.BtnSend.Text = "Send"
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'ListPorts
        '
        Me.ListPorts.FormattingEnabled = True
        Me.ListPorts.ItemHeight = 20
        Me.ListPorts.Location = New System.Drawing.Point(10, 49)
        Me.ListPorts.Name = "ListPorts"
        Me.ListPorts.Size = New System.Drawing.Size(202, 144)
        Me.ListPorts.TabIndex = 3
        '
        'btnPort
        '
        Me.btnPort.Location = New System.Drawing.Point(12, 202)
        Me.btnPort.Name = "btnPort"
        Me.btnPort.Size = New System.Drawing.Size(202, 49)
        Me.btnPort.TabIndex = 4
        Me.btnPort.Text = "Check Port"
        Me.btnPort.UseVisualStyleBackColor = True
        '
        'txtCommand
        '
        Me.txtCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommand.Location = New System.Drawing.Point(146, 49)
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.Size = New System.Drawing.Size(354, 30)
        Me.txtCommand.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmb_baud)
        Me.Panel1.Controls.Add(Me.lbl_portstatus)
        Me.Panel1.Controls.Add(Me.btn_connect)
        Me.Panel1.Controls.Add(Me.lbl_port_selected)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ListPorts)
        Me.Panel1.Controls.Add(Me.btnPort)
        Me.Panel1.Location = New System.Drawing.Point(2, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 565)
        Me.Panel1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Port:"
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(116, 417)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(86, 49)
        Me.btn_close.TabIndex = 12
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Baud Rate"
        '
        'cmb_baud
        '
        Me.cmb_baud.FormattingEnabled = True
        Me.cmb_baud.Items.AddRange(New Object() {"1200", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.cmb_baud.Location = New System.Drawing.Point(116, 362)
        Me.cmb_baud.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_baud.Name = "cmb_baud"
        Me.cmb_baud.Size = New System.Drawing.Size(97, 28)
        Me.cmb_baud.TabIndex = 10
        Me.cmb_baud.Text = "115200"
        '
        'lbl_portstatus
        '
        Me.lbl_portstatus.AutoSize = True
        Me.lbl_portstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_portstatus.Location = New System.Drawing.Point(48, 486)
        Me.lbl_portstatus.Name = "lbl_portstatus"
        Me.lbl_portstatus.Size = New System.Drawing.Size(133, 20)
        Me.lbl_portstatus.TabIndex = 9
        Me.lbl_portstatus.Text = "Not Connected"
        '
        'btn_connect
        '
        Me.btn_connect.Location = New System.Drawing.Point(16, 417)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(86, 49)
        Me.btn_connect.TabIndex = 8
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'lbl_port_selected
        '
        Me.lbl_port_selected.AutoSize = True
        Me.lbl_port_selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_port_selected.Location = New System.Drawing.Point(111, 323)
        Me.lbl_port_selected.Name = "lbl_port_selected"
        Me.lbl_port_selected.Size = New System.Drawing.Size(66, 20)
        Me.lbl_port_selected.TabIndex = 7
        Me.lbl_port_selected.Text = "No Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PORTS STATUS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PORTS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_serial
        '
        Me.panel_serial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_serial.Controls.Add(Me.btn_addcmd)
        Me.panel_serial.Controls.Add(Me.Label8)
        Me.panel_serial.Controls.Add(Me.Label7)
        Me.panel_serial.Controls.Add(Me.Label2)
        Me.panel_serial.Controls.Add(Me.RTOutput)
        Me.panel_serial.Controls.Add(Me.txtCommand)
        Me.panel_serial.Controls.Add(Me.BtnSend)
        Me.panel_serial.Location = New System.Drawing.Point(536, 12)
        Me.panel_serial.Name = "panel_serial"
        Me.panel_serial.Size = New System.Drawing.Size(510, 313)
        Me.panel_serial.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Serial Command"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Serial Output"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SERIAL COMMAND"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RTOutput
        '
        Me.RTOutput.Location = New System.Drawing.Point(3, 169)
        Me.RTOutput.Name = "RTOutput"
        Me.RTOutput.Size = New System.Drawing.Size(498, 133)
        Me.RTOutput.TabIndex = 6
        Me.RTOutput.Text = ""
        '
        'btn_left_x
        '
        Me.btn_left_x.Location = New System.Drawing.Point(318, 72)
        Me.btn_left_x.Name = "btn_left_x"
        Me.btn_left_x.Size = New System.Drawing.Size(86, 35)
        Me.btn_left_x.TabIndex = 9
        Me.btn_left_x.Text = "-X"
        Me.btn_left_x.UseVisualStyleBackColor = True
        '
        'btn_right_x
        '
        Me.btn_right_x.Location = New System.Drawing.Point(410, 72)
        Me.btn_right_x.Name = "btn_right_x"
        Me.btn_right_x.Size = New System.Drawing.Size(86, 35)
        Me.btn_right_x.TabIndex = 10
        Me.btn_right_x.Text = "+X"
        Me.btn_right_x.UseVisualStyleBackColor = True
        '
        'panel_ctrl
        '
        Me.panel_ctrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_ctrl.Controls.Add(Me.lblPosition)
        Me.panel_ctrl.Controls.Add(Me.btnHome)
        Me.panel_ctrl.Controls.Add(Me.lbl_step)
        Me.panel_ctrl.Controls.Add(Me.trackStep)
        Me.panel_ctrl.Controls.Add(Me.Label14)
        Me.panel_ctrl.Controls.Add(Me.Label12)
        Me.panel_ctrl.Controls.Add(Me.btn_z_up)
        Me.panel_ctrl.Controls.Add(Me.btn_down_z)
        Me.panel_ctrl.Controls.Add(Me.Label11)
        Me.panel_ctrl.Controls.Add(Me.Label10)
        Me.panel_ctrl.Controls.Add(Me.lbl_speed)
        Me.panel_ctrl.Controls.Add(Me.trck_speed)
        Me.panel_ctrl.Controls.Add(Me.Label9)
        Me.panel_ctrl.Controls.Add(Me.Label3)
        Me.panel_ctrl.Controls.Add(Me.btn_up_y)
        Me.panel_ctrl.Controls.Add(Me.btn_down_y)
        Me.panel_ctrl.Controls.Add(Me.btn_left_x)
        Me.panel_ctrl.Controls.Add(Me.btn_right_x)
        Me.panel_ctrl.Location = New System.Drawing.Point(538, 329)
        Me.panel_ctrl.Name = "panel_ctrl"
        Me.panel_ctrl.Size = New System.Drawing.Size(507, 249)
        Me.panel_ctrl.TabIndex = 11
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(333, 44)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(139, 20)
        Me.lblPosition.TabIndex = 26
        Me.lblPosition.Text = "X:0 Y:120 Z:120"
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(352, 193)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(120, 49)
        Me.btnHome.TabIndex = 25
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'lbl_step
        '
        Me.lbl_step.AutoSize = True
        Me.lbl_step.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_step.Location = New System.Drawing.Point(148, 151)
        Me.lbl_step.Name = "lbl_step"
        Me.lbl_step.Size = New System.Drawing.Size(27, 20)
        Me.lbl_step.TabIndex = 23
        Me.lbl_step.Text = "10"
        '
        'trackStep
        '
        Me.trackStep.LargeChange = 1
        Me.trackStep.Location = New System.Drawing.Point(26, 174)
        Me.trackStep.Maximum = 50
        Me.trackStep.Minimum = 1
        Me.trackStep.Name = "trackStep"
        Me.trackStep.Size = New System.Drawing.Size(189, 69)
        Me.trackStep.TabIndex = 22
        Me.trackStep.TickFrequency = 5
        Me.trackStep.Value = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(81, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 20)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Step"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(242, 162)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 20)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Axis Z"
        '
        'btn_z_up
        '
        Me.btn_z_up.Location = New System.Drawing.Point(412, 154)
        Me.btn_z_up.Name = "btn_z_up"
        Me.btn_z_up.Size = New System.Drawing.Size(86, 35)
        Me.btn_z_up.TabIndex = 19
        Me.btn_z_up.Text = "+Z"
        Me.btn_z_up.UseVisualStyleBackColor = True
        '
        'btn_down_z
        '
        Me.btn_down_z.Location = New System.Drawing.Point(318, 154)
        Me.btn_down_z.Name = "btn_down_z"
        Me.btn_down_z.Size = New System.Drawing.Size(86, 35)
        Me.btn_down_z.TabIndex = 18
        Me.btn_down_z.Text = "-Z"
        Me.btn_down_z.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(238, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 20)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Axis Y"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(238, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Axis X"
        '
        'lbl_speed
        '
        Me.lbl_speed.AutoSize = True
        Me.lbl_speed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_speed.Location = New System.Drawing.Point(148, 62)
        Me.lbl_speed.Name = "lbl_speed"
        Me.lbl_speed.Size = New System.Drawing.Size(27, 20)
        Me.lbl_speed.TabIndex = 15
        Me.lbl_speed.Text = "30"
        '
        'trck_speed
        '
        Me.trck_speed.Location = New System.Drawing.Point(26, 85)
        Me.trck_speed.Maximum = 50
        Me.trck_speed.Minimum = 5
        Me.trck_speed.Name = "trck_speed"
        Me.trck_speed.Size = New System.Drawing.Size(189, 69)
        Me.trck_speed.TabIndex = 14
        Me.trck_speed.TickFrequency = 5
        Me.trck_speed.Value = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(81, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Speed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(130, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "MOVE COMMANDS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_up_y
        '
        Me.btn_up_y.Location = New System.Drawing.Point(410, 112)
        Me.btn_up_y.Name = "btn_up_y"
        Me.btn_up_y.Size = New System.Drawing.Size(86, 35)
        Me.btn_up_y.TabIndex = 12
        Me.btn_up_y.Text = "+Y"
        Me.btn_up_y.UseVisualStyleBackColor = True
        '
        'btn_down_y
        '
        Me.btn_down_y.Location = New System.Drawing.Point(316, 112)
        Me.btn_down_y.Name = "btn_down_y"
        Me.btn_down_y.Size = New System.Drawing.Size(86, 35)
        Me.btn_down_y.TabIndex = 11
        Me.btn_down_y.Text = "-Y"
        Me.btn_down_y.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'panel_commands
        '
        Me.panel_commands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_commands.Controls.Add(Me.btn_grip_off)
        Me.panel_commands.Controls.Add(Me.btn_grip_on)
        Me.panel_commands.Controls.Add(Me.btn_curve_speed)
        Me.panel_commands.Controls.Add(Me.btn_speed_flat)
        Me.panel_commands.Controls.Add(Me.btnFanOff)
        Me.panel_commands.Controls.Add(Me.btnFanOn)
        Me.panel_commands.Controls.Add(Me.btn_relative)
        Me.panel_commands.Controls.Add(Me.btn_abs)
        Me.panel_commands.Controls.Add(Me.btn_endStop)
        Me.panel_commands.Controls.Add(Me.btn_coordinate)
        Me.panel_commands.Controls.Add(Me.btn_fanoff)
        Me.panel_commands.Controls.Add(Me.btn_fanon)
        Me.panel_commands.Controls.Add(Me.btn_stepoff)
        Me.panel_commands.Controls.Add(Me.btn_stepon)
        Me.panel_commands.Controls.Add(Me.btn_homing)
        Me.panel_commands.Location = New System.Drawing.Point(236, 12)
        Me.panel_commands.Name = "panel_commands"
        Me.panel_commands.Size = New System.Drawing.Size(293, 565)
        Me.panel_commands.TabIndex = 12
        '
        'btn_grip_off
        '
        Me.btn_grip_off.Location = New System.Drawing.Point(156, 314)
        Me.btn_grip_off.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_grip_off.Name = "btn_grip_off"
        Me.btn_grip_off.Size = New System.Drawing.Size(120, 49)
        Me.btn_grip_off.TabIndex = 28
        Me.btn_grip_off.Text = "Gripper OFF"
        Me.btn_grip_off.UseVisualStyleBackColor = True
        '
        'btn_grip_on
        '
        Me.btn_grip_on.Location = New System.Drawing.Point(156, 255)
        Me.btn_grip_on.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_grip_on.Name = "btn_grip_on"
        Me.btn_grip_on.Size = New System.Drawing.Size(120, 49)
        Me.btn_grip_on.TabIndex = 27
        Me.btn_grip_on.Text = "Gripper ON"
        Me.btn_grip_on.UseVisualStyleBackColor = True
        '
        'btn_curve_speed
        '
        Me.btn_curve_speed.Location = New System.Drawing.Point(156, 196)
        Me.btn_curve_speed.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_curve_speed.Name = "btn_curve_speed"
        Me.btn_curve_speed.Size = New System.Drawing.Size(120, 49)
        Me.btn_curve_speed.TabIndex = 26
        Me.btn_curve_speed.Text = "Curve Speed"
        Me.btn_curve_speed.UseVisualStyleBackColor = True
        '
        'btn_speed_flat
        '
        Me.btn_speed_flat.Location = New System.Drawing.Point(156, 135)
        Me.btn_speed_flat.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_speed_flat.Name = "btn_speed_flat"
        Me.btn_speed_flat.Size = New System.Drawing.Size(120, 49)
        Me.btn_speed_flat.TabIndex = 25
        Me.btn_speed_flat.Text = "Flat Speed"
        Me.btn_speed_flat.UseVisualStyleBackColor = True
        '
        'btnFanOff
        '
        Me.btnFanOff.Location = New System.Drawing.Point(156, 76)
        Me.btnFanOff.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnFanOff.Name = "btnFanOff"
        Me.btnFanOff.Size = New System.Drawing.Size(120, 49)
        Me.btnFanOff.TabIndex = 24
        Me.btnFanOff.Text = "Fan Off"
        Me.btnFanOff.UseVisualStyleBackColor = True
        '
        'btnFanOn
        '
        Me.btnFanOn.Location = New System.Drawing.Point(156, 17)
        Me.btnFanOn.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnFanOn.Name = "btnFanOn"
        Me.btnFanOn.Size = New System.Drawing.Size(120, 49)
        Me.btnFanOn.TabIndex = 23
        Me.btnFanOn.Text = "Fan On"
        Me.btnFanOn.UseVisualStyleBackColor = True
        '
        'btn_relative
        '
        Me.btn_relative.Location = New System.Drawing.Point(12, 488)
        Me.btn_relative.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_relative.Name = "btn_relative"
        Me.btn_relative.Size = New System.Drawing.Size(120, 49)
        Me.btn_relative.TabIndex = 22
        Me.btn_relative.Text = "Relative"
        Me.btn_relative.UseVisualStyleBackColor = True
        '
        'btn_abs
        '
        Me.btn_abs.Location = New System.Drawing.Point(12, 431)
        Me.btn_abs.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_abs.Name = "btn_abs"
        Me.btn_abs.Size = New System.Drawing.Size(120, 49)
        Me.btn_abs.TabIndex = 21
        Me.btn_abs.Text = "Absolute"
        Me.btn_abs.UseVisualStyleBackColor = True
        '
        'btn_endStop
        '
        Me.btn_endStop.Location = New System.Drawing.Point(12, 372)
        Me.btn_endStop.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_endStop.Name = "btn_endStop"
        Me.btn_endStop.Size = New System.Drawing.Size(120, 49)
        Me.btn_endStop.TabIndex = 20
        Me.btn_endStop.Text = "End Stop"
        Me.btn_endStop.UseVisualStyleBackColor = True
        '
        'btn_coordinate
        '
        Me.btn_coordinate.Location = New System.Drawing.Point(12, 312)
        Me.btn_coordinate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_coordinate.Name = "btn_coordinate"
        Me.btn_coordinate.Size = New System.Drawing.Size(120, 49)
        Me.btn_coordinate.TabIndex = 19
        Me.btn_coordinate.Text = "Coordinate"
        Me.btn_coordinate.UseVisualStyleBackColor = True
        '
        'btn_fanoff
        '
        Me.btn_fanoff.Location = New System.Drawing.Point(12, 254)
        Me.btn_fanoff.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_fanoff.Name = "btn_fanoff"
        Me.btn_fanoff.Size = New System.Drawing.Size(120, 49)
        Me.btn_fanoff.TabIndex = 18
        Me.btn_fanoff.Text = "Fan OFF"
        Me.btn_fanoff.UseVisualStyleBackColor = True
        '
        'btn_fanon
        '
        Me.btn_fanon.Location = New System.Drawing.Point(12, 196)
        Me.btn_fanon.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_fanon.Name = "btn_fanon"
        Me.btn_fanon.Size = New System.Drawing.Size(120, 49)
        Me.btn_fanon.TabIndex = 17
        Me.btn_fanon.Text = "Fan ON"
        Me.btn_fanon.UseVisualStyleBackColor = True
        '
        'btn_stepoff
        '
        Me.btn_stepoff.Location = New System.Drawing.Point(12, 135)
        Me.btn_stepoff.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_stepoff.Name = "btn_stepoff"
        Me.btn_stepoff.Size = New System.Drawing.Size(120, 49)
        Me.btn_stepoff.TabIndex = 16
        Me.btn_stepoff.Text = "Stepper OFF"
        Me.btn_stepoff.UseVisualStyleBackColor = True
        '
        'btn_stepon
        '
        Me.btn_stepon.Location = New System.Drawing.Point(12, 77)
        Me.btn_stepon.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_stepon.Name = "btn_stepon"
        Me.btn_stepon.Size = New System.Drawing.Size(120, 49)
        Me.btn_stepon.TabIndex = 15
        Me.btn_stepon.Text = "Stepper ON"
        Me.btn_stepon.UseVisualStyleBackColor = True
        '
        'btn_homing
        '
        Me.btn_homing.Location = New System.Drawing.Point(12, 17)
        Me.btn_homing.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_homing.Name = "btn_homing"
        Me.btn_homing.Size = New System.Drawing.Size(120, 49)
        Me.btn_homing.TabIndex = 14
        Me.btn_homing.Text = "Homing"
        Me.btn_homing.UseVisualStyleBackColor = True
        '
        'panel_commandlist
        '
        Me.panel_commandlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_commandlist.Controls.Add(Me.btn_clear)
        Me.panel_commandlist.Controls.Add(Me.btn_execute)
        Me.panel_commandlist.Controls.Add(Me.listCmds)
        Me.panel_commandlist.Controls.Add(Me.Label16)
        Me.panel_commandlist.Location = New System.Drawing.Point(1053, 12)
        Me.panel_commandlist.Name = "panel_commandlist"
        Me.panel_commandlist.Size = New System.Drawing.Size(295, 565)
        Me.panel_commandlist.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(31, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(225, 29)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "COMMANDS LIST"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'listCmds
        '
        Me.listCmds.FormattingEnabled = True
        Me.listCmds.ItemHeight = 20
        Me.listCmds.Location = New System.Drawing.Point(10, 55)
        Me.listCmds.Name = "listCmds"
        Me.listCmds.Size = New System.Drawing.Size(275, 444)
        Me.listCmds.TabIndex = 7
        '
        'btn_addcmd
        '
        Me.btn_addcmd.Location = New System.Drawing.Point(354, 87)
        Me.btn_addcmd.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_addcmd.Name = "btn_addcmd"
        Me.btn_addcmd.Size = New System.Drawing.Size(120, 49)
        Me.btn_addcmd.TabIndex = 14
        Me.btn_addcmd.Text = "Add to List"
        Me.btn_addcmd.UseVisualStyleBackColor = True
        '
        'btn_execute
        '
        Me.btn_execute.Location = New System.Drawing.Point(152, 506)
        Me.btn_execute.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_execute.Name = "btn_execute"
        Me.btn_execute.Size = New System.Drawing.Size(120, 49)
        Me.btn_execute.TabIndex = 8
        Me.btn_execute.Text = "Execute"
        Me.btn_execute.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(26, 506)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(120, 49)
        Me.btn_clear.TabIndex = 9
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1353, 582)
        Me.Controls.Add(Me.panel_commandlist)
        Me.Controls.Add(Me.panel_commands)
        Me.Controls.Add(Me.panel_ctrl)
        Me.Controls.Add(Me.panel_serial)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "MainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Robot Arm Controller - slumberjer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panel_serial.ResumeLayout(False)
        Me.panel_serial.PerformLayout()
        Me.panel_ctrl.ResumeLayout(False)
        Me.panel_ctrl.PerformLayout()
        CType(Me.trackStep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trck_speed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_commands.ResumeLayout(False)
        Me.panel_commandlist.ResumeLayout(False)
        Me.panel_commandlist.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSend As Button
    Friend WithEvents ListPorts As ListBox
    Friend WithEvents btnPort As Button
    Friend WithEvents txtCommand As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panel_serial As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_left_x As Button
    Friend WithEvents btn_right_x As Button
    Friend WithEvents panel_ctrl As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_up_y As Button
    Friend WithEvents btn_down_y As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_port_selected As Label
    Friend WithEvents btn_connect As Button
    Friend WithEvents lbl_portstatus As Label
    Friend WithEvents cmb_baud As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_close As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents RTOutput As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents trck_speed As TrackBar
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_speed As Label
    Friend WithEvents panel_commands As Panel
    Friend WithEvents btn_homing As Button
    Friend WithEvents btn_stepoff As Button
    Friend WithEvents btn_stepon As Button
    Friend WithEvents btn_fanoff As Button
    Friend WithEvents btn_fanon As Button
    Friend WithEvents btn_endStop As Button
    Friend WithEvents btn_coordinate As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_z_up As Button
    Friend WithEvents btn_down_z As Button
    Friend WithEvents lbl_step As Label
    Friend WithEvents trackStep As TrackBar
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_relative As Button
    Friend WithEvents btn_abs As Button
    Friend WithEvents btnFanOff As Button
    Friend WithEvents btnFanOn As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents lblPosition As Label
    Friend WithEvents btn_curve_speed As Button
    Friend WithEvents btn_speed_flat As Button
    Friend WithEvents btn_grip_off As Button
    Friend WithEvents btn_grip_on As Button
    Friend WithEvents panel_commandlist As Panel
    Friend WithEvents listCmds As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_addcmd As Button
    Friend WithEvents btn_execute As Button
    Friend WithEvents btn_clear As Button
End Class
