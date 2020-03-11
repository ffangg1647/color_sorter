<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gb_connect = New System.Windows.Forms.GroupBox()
        Me.lb_port = New System.Windows.Forms.Label()
        Me.btn_discon = New System.Windows.Forms.Button()
        Me.btn_con = New System.Windows.Forms.Button()
        Me.cb_port = New System.Windows.Forms.ComboBox()
        Me.gb_color = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tb_brown = New System.Windows.Forms.TextBox()
        Me.tb_blue = New System.Windows.Forms.TextBox()
        Me.tb_green = New System.Windows.Forms.TextBox()
        Me.tb_yellow = New System.Windows.Forms.TextBox()
        Me.tb_orange = New System.Windows.Forms.TextBox()
        Me.tb_red = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gb_connect.SuspendLayout()
        Me.gb_color.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_connect
        '
        Me.gb_connect.Controls.Add(Me.lb_port)
        Me.gb_connect.Controls.Add(Me.btn_discon)
        Me.gb_connect.Controls.Add(Me.btn_con)
        Me.gb_connect.Controls.Add(Me.cb_port)
        Me.gb_connect.Location = New System.Drawing.Point(12, 12)
        Me.gb_connect.Name = "gb_connect"
        Me.gb_connect.Size = New System.Drawing.Size(362, 71)
        Me.gb_connect.TabIndex = 0
        Me.gb_connect.TabStop = False
        Me.gb_connect.Text = "Connect Arduino"
        '
        'lb_port
        '
        Me.lb_port.AutoSize = True
        Me.lb_port.Location = New System.Drawing.Point(21, 37)
        Me.lb_port.Name = "lb_port"
        Me.lb_port.Size = New System.Drawing.Size(32, 13)
        Me.lb_port.TabIndex = 3
        Me.lb_port.Text = "Port :"
        '
        'btn_discon
        '
        Me.btn_discon.Location = New System.Drawing.Point(264, 32)
        Me.btn_discon.Name = "btn_discon"
        Me.btn_discon.Size = New System.Drawing.Size(75, 23)
        Me.btn_discon.TabIndex = 2
        Me.btn_discon.Text = "Disconnect"
        Me.btn_discon.UseVisualStyleBackColor = True
        '
        'btn_con
        '
        Me.btn_con.Location = New System.Drawing.Point(183, 32)
        Me.btn_con.Name = "btn_con"
        Me.btn_con.Size = New System.Drawing.Size(75, 23)
        Me.btn_con.TabIndex = 1
        Me.btn_con.Text = "Connect"
        Me.btn_con.UseVisualStyleBackColor = True
        '
        'cb_port
        '
        Me.cb_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_port.FormattingEnabled = True
        Me.cb_port.Location = New System.Drawing.Point(59, 34)
        Me.cb_port.Name = "cb_port"
        Me.cb_port.Size = New System.Drawing.Size(118, 21)
        Me.cb_port.TabIndex = 0
        '
        'gb_color
        '
        Me.gb_color.Controls.Add(Me.TextBox1)
        Me.gb_color.Controls.Add(Me.tb_brown)
        Me.gb_color.Controls.Add(Me.tb_blue)
        Me.gb_color.Controls.Add(Me.tb_green)
        Me.gb_color.Controls.Add(Me.tb_yellow)
        Me.gb_color.Controls.Add(Me.tb_orange)
        Me.gb_color.Controls.Add(Me.tb_red)
        Me.gb_color.Controls.Add(Me.PictureBox6)
        Me.gb_color.Controls.Add(Me.PictureBox5)
        Me.gb_color.Controls.Add(Me.PictureBox4)
        Me.gb_color.Controls.Add(Me.PictureBox3)
        Me.gb_color.Controls.Add(Me.PictureBox2)
        Me.gb_color.Controls.Add(Me.PictureBox1)
        Me.gb_color.Location = New System.Drawing.Point(12, 89)
        Me.gb_color.Name = "gb_color"
        Me.gb_color.Size = New System.Drawing.Size(817, 342)
        Me.gb_color.TabIndex = 1
        Me.gb_color.TabStop = False
        Me.gb_color.Text = "Color"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(657, 260)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 45)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_brown
        '
        Me.tb_brown.Enabled = False
        Me.tb_brown.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tb_brown.Location = New System.Drawing.Point(657, 163)
        Me.tb_brown.Multiline = True
        Me.tb_brown.Name = "tb_brown"
        Me.tb_brown.Size = New System.Drawing.Size(100, 45)
        Me.tb_brown.TabIndex = 11
        Me.tb_brown.Text = "0"
        Me.tb_brown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_blue
        '
        Me.tb_blue.Enabled = False
        Me.tb_blue.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tb_blue.Location = New System.Drawing.Point(540, 163)
        Me.tb_blue.Multiline = True
        Me.tb_blue.Name = "tb_blue"
        Me.tb_blue.Size = New System.Drawing.Size(100, 45)
        Me.tb_blue.TabIndex = 10
        Me.tb_blue.Text = "0"
        Me.tb_blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_green
        '
        Me.tb_green.Enabled = False
        Me.tb_green.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tb_green.Location = New System.Drawing.Point(419, 163)
        Me.tb_green.Multiline = True
        Me.tb_green.Name = "tb_green"
        Me.tb_green.Size = New System.Drawing.Size(100, 45)
        Me.tb_green.TabIndex = 9
        Me.tb_green.Text = "0"
        Me.tb_green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_yellow
        '
        Me.tb_yellow.Enabled = False
        Me.tb_yellow.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tb_yellow.Location = New System.Drawing.Point(299, 163)
        Me.tb_yellow.Multiline = True
        Me.tb_yellow.Name = "tb_yellow"
        Me.tb_yellow.Size = New System.Drawing.Size(100, 45)
        Me.tb_yellow.TabIndex = 8
        Me.tb_yellow.Text = "0"
        Me.tb_yellow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_orange
        '
        Me.tb_orange.Enabled = False
        Me.tb_orange.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tb_orange.Location = New System.Drawing.Point(177, 163)
        Me.tb_orange.Multiline = True
        Me.tb_orange.Name = "tb_orange"
        Me.tb_orange.Size = New System.Drawing.Size(100, 45)
        Me.tb_orange.TabIndex = 7
        Me.tb_orange.Text = "0"
        Me.tb_orange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_red
        '
        Me.tb_red.Enabled = False
        Me.tb_red.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tb_red.Location = New System.Drawing.Point(59, 163)
        Me.tb_red.Multiline = True
        Me.tb_red.Name = "tb_red"
        Me.tb_red.Size = New System.Drawing.Size(100, 45)
        Me.tb_red.TabIndex = 6
        Me.tb_red.Text = "0"
        Me.tb_red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Arduino_Color_Sorter.My.Resources.Resources.brown
        Me.PictureBox6.Location = New System.Drawing.Point(657, 48)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(99, 99)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Arduino_Color_Sorter.My.Resources.Resources.blue
        Me.PictureBox5.Location = New System.Drawing.Point(540, 48)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(99, 99)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Arduino_Color_Sorter.My.Resources.Resources.green
        Me.PictureBox4.Location = New System.Drawing.Point(419, 48)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(99, 99)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Arduino_Color_Sorter.My.Resources.Resources.yellow
        Me.PictureBox3.Location = New System.Drawing.Point(299, 48)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(99, 99)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Arduino_Color_Sorter.My.Resources.Resources.orange
        Me.PictureBox2.Location = New System.Drawing.Point(178, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(99, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Arduino_Color_Sorter.My.Resources.Resources.red
        Me.PictureBox1.Location = New System.Drawing.Point(60, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 441)
        Me.Controls.Add(Me.gb_color)
        Me.Controls.Add(Me.gb_connect)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(857, 480)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(857, 480)
        Me.Name = "frm_main"
        Me.Text = "Arduino Color Sorter"
        Me.gb_connect.ResumeLayout(False)
        Me.gb_connect.PerformLayout()
        Me.gb_color.ResumeLayout(False)
        Me.gb_color.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_connect As GroupBox
    Friend WithEvents gb_color As GroupBox
    Friend WithEvents lb_port As Label
    Friend WithEvents btn_discon As Button
    Friend WithEvents btn_con As Button
    Friend WithEvents cb_port As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tb_brown As TextBox
    Friend WithEvents tb_blue As TextBox
    Friend WithEvents tb_green As TextBox
    Friend WithEvents tb_yellow As TextBox
    Friend WithEvents tb_orange As TextBox
    Friend WithEvents tb_red As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
End Class
