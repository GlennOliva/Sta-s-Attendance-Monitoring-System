<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateform
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.le = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_staid = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_dept = New System.Windows.Forms.TextBox()
        Me.txt_course = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.btn_update = New FontAwesome.Sharp.IconButton()
        Me.btn_back = New FontAwesome.Sharp.IconButton()
        Me.txt_doj = New System.Windows.Forms.DateTimePicker()
        Me.txt_dob = New System.Windows.Forms.DateTimePicker()
        Me.update_pic = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.update_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 100)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.project1.My.Resources.Resources.logo_transparent1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(374, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STA'S UPDATE FORM"
        '
        'le
        '
        Me.le.AutoSize = True
        Me.le.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.le.Location = New System.Drawing.Point(12, 154)
        Me.le.Name = "le"
        Me.le.Size = New System.Drawing.Size(38, 23)
        Me.le.TabIndex = 1
        Me.le.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(377, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "STUDENT_ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NAME:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(382, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "DEPARTMENT:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "COURSE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(382, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "USERNAME:"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(145, 147)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(179, 39)
        Me.txt_id.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 23)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "PASSWORD:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(382, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 23)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "DOB:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 23)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "DOJ:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(382, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 23)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "ADDRESS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 391)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 23)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "STATUS:"
        '
        'txt_staid
        '
        Me.txt_staid.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staid.Location = New System.Drawing.Point(545, 144)
        Me.txt_staid.Name = "txt_staid"
        Me.txt_staid.Size = New System.Drawing.Size(179, 39)
        Me.txt_staid.TabIndex = 14
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(145, 195)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(179, 39)
        Me.txt_name.TabIndex = 15
        '
        'txt_dept
        '
        Me.txt_dept.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dept.Location = New System.Drawing.Point(545, 189)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(179, 39)
        Me.txt_dept.TabIndex = 16
        '
        'txt_course
        '
        Me.txt_course.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_course.Location = New System.Drawing.Point(145, 239)
        Me.txt_course.Name = "txt_course"
        Me.txt_course.Size = New System.Drawing.Size(179, 39)
        Me.txt_course.TabIndex = 17
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(545, 236)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(179, 39)
        Me.txt_username.TabIndex = 18
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(145, 292)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(179, 39)
        Me.txt_password.TabIndex = 19
        '
        'txt_address
        '
        Me.txt_address.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(545, 325)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(179, 39)
        Me.txt_address.TabIndex = 22
        '
        'txt_status
        '
        Me.txt_status.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_status.Location = New System.Drawing.Point(145, 384)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(179, 39)
        Me.txt_status.TabIndex = 23
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Maroon
        Me.btn_update.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btn_update.IconColor = System.Drawing.Color.White
        Me.btn_update.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_update.Location = New System.Drawing.Point(754, 445)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(289, 88)
        Me.btn_update.TabIndex = 24
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Maroon
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btn_back.IconColor = System.Drawing.Color.White
        Me.btn_back.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_back.Location = New System.Drawing.Point(12, 445)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(333, 90)
        Me.btn_back.TabIndex = 25
        Me.btn_back.Text = "BACK TO ADMIN"
        Me.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'txt_doj
        '
        Me.txt_doj.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_doj.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_doj.Location = New System.Drawing.Point(145, 341)
        Me.txt_doj.Name = "txt_doj"
        Me.txt_doj.Size = New System.Drawing.Size(179, 34)
        Me.txt_doj.TabIndex = 26
        '
        'txt_dob
        '
        Me.txt_dob.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_dob.Location = New System.Drawing.Point(545, 281)
        Me.txt_dob.Name = "txt_dob"
        Me.txt_dob.Size = New System.Drawing.Size(179, 34)
        Me.txt_dob.TabIndex = 27
        '
        'update_pic
        '
        Me.update_pic.Image = Global.project1.My.Resources.Resources.developer
        Me.update_pic.Location = New System.Drawing.Point(806, 154)
        Me.update_pic.Name = "update_pic"
        Me.update_pic.Size = New System.Drawing.Size(204, 177)
        Me.update_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.update_pic.TabIndex = 28
        Me.update_pic.TabStop = False
        '
        'updateform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1055, 545)
        Me.Controls.Add(Me.update_pic)
        Me.Controls.Add(Me.txt_dob)
        Me.Controls.Add(Me.txt_doj)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_course)
        Me.Controls.Add(Me.txt_dept)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_staid)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.le)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "updateform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "updateform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.update_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents le As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_staid As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_dept As TextBox
    Friend WithEvents txt_course As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_status As TextBox
    Friend WithEvents btn_update As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_back As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_doj As DateTimePicker
    Friend WithEvents txt_dob As DateTimePicker
    Friend WithEvents update_pic As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
