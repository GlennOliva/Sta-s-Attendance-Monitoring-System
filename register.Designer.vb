<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_backad = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.reg_pic = New System.Windows.Forms.PictureBox()
        Me.txt_staid = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_registersubmit = New FontAwesome.Sharp.IconButton()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.datetime1 = New System.Windows.Forms.DateTimePicker()
        Me.datetime = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_course = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_dept = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reg_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STA'S REGISTRATION PAGE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_backad)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1353, 81)
        Me.Panel1.TabIndex = 1
        '
        'btn_backad
        '
        Me.btn_backad.BackColor = System.Drawing.Color.Maroon
        Me.btn_backad.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backad.ForeColor = System.Drawing.Color.White
        Me.btn_backad.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btn_backad.IconColor = System.Drawing.Color.Black
        Me.btn_backad.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_backad.Location = New System.Drawing.Point(1022, -1)
        Me.btn_backad.Name = "btn_backad"
        Me.btn_backad.Size = New System.Drawing.Size(331, 82)
        Me.btn_backad.TabIndex = 6
        Me.btn_backad.Text = "BACK TO ADMIN"
        Me.btn_backad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_backad.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'reg_pic
        '
        Me.reg_pic.BackColor = System.Drawing.Color.Transparent
        Me.reg_pic.Image = CType(resources.GetObject("reg_pic.Image"), System.Drawing.Image)
        Me.reg_pic.Location = New System.Drawing.Point(276, 3)
        Me.reg_pic.Name = "reg_pic"
        Me.reg_pic.Size = New System.Drawing.Size(150, 111)
        Me.reg_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.reg_pic.TabIndex = 2
        Me.reg_pic.TabStop = False
        '
        'txt_staid
        '
        Me.txt_staid.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staid.Location = New System.Drawing.Point(107, 152)
        Me.txt_staid.Name = "txt_staid"
        Me.txt_staid.Size = New System.Drawing.Size(219, 39)
        Me.txt_staid.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.btn_registersubmit)
        Me.Panel2.Controls.Add(Me.txt_password)
        Me.Panel2.Controls.Add(Me.txt_username)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txt_address)
        Me.Panel2.Controls.Add(Me.datetime1)
        Me.Panel2.Controls.Add(Me.datetime)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txt_course)
        Me.Panel2.Controls.Add(Me.txt_name)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_staid)
        Me.Panel2.Controls.Add(Me.reg_pic)
        Me.Panel2.Controls.Add(Me.txt_dept)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.SystemColors.Control
        Me.Panel2.Location = New System.Drawing.Point(330, 116)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(716, 641)
        Me.Panel2.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(401, 339)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "DATE OF JOIN:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(103, 339)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "DATE OF BIRTH:"
        '
        'btn_registersubmit
        '
        Me.btn_registersubmit.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registersubmit.ForeColor = System.Drawing.Color.Maroon
        Me.btn_registersubmit.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btn_registersubmit.IconColor = System.Drawing.Color.Black
        Me.btn_registersubmit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_registersubmit.Location = New System.Drawing.Point(155, 507)
        Me.btn_registersubmit.Name = "btn_registersubmit"
        Me.btn_registersubmit.Size = New System.Drawing.Size(384, 54)
        Me.btn_registersubmit.TabIndex = 7
        Me.btn_registersubmit.Text = "SUBMIT REGISTRATION"
        Me.btn_registersubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_registersubmit.UseVisualStyleBackColor = True
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(405, 294)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(211, 39)
        Me.txt_password.TabIndex = 21
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(107, 294)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(219, 39)
        Me.txt_username.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(401, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "PASSWORD:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(103, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "USERNAME:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(151, 420)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "STA'S ADDRESS:"
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(155, 446)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(384, 44)
        Me.txt_address.TabIndex = 15
        '
        'datetime1
        '
        Me.datetime1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetime1.Location = New System.Drawing.Point(405, 362)
        Me.datetime1.Name = "datetime1"
        Me.datetime1.Size = New System.Drawing.Size(211, 39)
        Me.datetime1.TabIndex = 14
        '
        'datetime
        '
        Me.datetime.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetime.Location = New System.Drawing.Point(107, 362)
        Me.datetime.Name = "datetime"
        Me.datetime.Size = New System.Drawing.Size(219, 39)
        Me.datetime.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(401, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "COURSE:"
        '
        'txt_course
        '
        Me.txt_course.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_course.Location = New System.Drawing.Point(405, 222)
        Me.txt_course.Name = "txt_course"
        Me.txt_course.Size = New System.Drawing.Size(211, 39)
        Me.txt_course.TabIndex = 11
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(405, 152)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(211, 39)
        Me.txt_name.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "STA'S DEPARTMENT:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(401, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "STA'S ID:"
        '
        'txt_dept
        '
        Me.txt_dept.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dept.Location = New System.Drawing.Point(107, 222)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(219, 39)
        Me.txt_dept.TabIndex = 4
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1355, 826)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reg_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents reg_pic As PictureBox
    Friend WithEvents txt_staid As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_dept As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents datetime1 As DateTimePicker
    Friend WithEvents datetime As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_course As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_backad As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_registersubmit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
