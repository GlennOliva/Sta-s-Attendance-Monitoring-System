<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_page
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btn_back = New FontAwesome.Sharp.IconButton()
        Me.btn_record = New FontAwesome.Sharp.IconButton()
        Me.btn_registersta = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1260, 91)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.project1.My.Resources.Resources.png_administration_1_removebg_preview
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(151, 91)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(197, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMINISTRATOR PAGE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.IconButton1)
        Me.Panel2.Controls.Add(Me.btn_back)
        Me.Panel2.Controls.Add(Me.btn_record)
        Me.Panel2.Controls.Add(Me.btn_registersta)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(295, 594)
        Me.Panel2.TabIndex = 1
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Maroon
        Me.IconButton1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(0, 463)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(295, 127)
        Me.IconButton1.TabIndex = 6
        Me.IconButton1.Text = "STA'S INFO"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Maroon
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btn_back.IconColor = System.Drawing.Color.Black
        Me.btn_back.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_back.Location = New System.Drawing.Point(3, 340)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(289, 127)
        Me.btn_back.TabIndex = 5
        Me.btn_back.Text = "BACK TO LOGIN"
        Me.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_record
        '
        Me.btn_record.BackColor = System.Drawing.Color.Maroon
        Me.btn_record.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_record.ForeColor = System.Drawing.Color.White
        Me.btn_record.IconChar = FontAwesome.Sharp.IconChar.File
        Me.btn_record.IconColor = System.Drawing.Color.Black
        Me.btn_record.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_record.Location = New System.Drawing.Point(0, 230)
        Me.btn_record.Name = "btn_record"
        Me.btn_record.Size = New System.Drawing.Size(292, 119)
        Me.btn_record.TabIndex = 4
        Me.btn_record.Text = "STA'S RECORD"
        Me.btn_record.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_record.UseVisualStyleBackColor = False
        '
        'btn_registersta
        '
        Me.btn_registersta.BackColor = System.Drawing.Color.Maroon
        Me.btn_registersta.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registersta.ForeColor = System.Drawing.Color.White
        Me.btn_registersta.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.btn_registersta.IconColor = System.Drawing.Color.Black
        Me.btn_registersta.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_registersta.Location = New System.Drawing.Point(0, 124)
        Me.btn_registersta.Name = "btn_registersta"
        Me.btn_registersta.Size = New System.Drawing.Size(292, 109)
        Me.btn_registersta.TabIndex = 3
        Me.btn_registersta.Text = "STA'S REGISTER"
        Me.btn_registersta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_registersta.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Image = Global.project1.My.Resources.Resources.logo_transparent2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Admin_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = Global.project1.My.Resources.Resources.University_of_Mindanao_Aerial_Tour_Project_LUPAD_JPG_safeimagekit__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1260, 685)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_back As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_record As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_registersta As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
