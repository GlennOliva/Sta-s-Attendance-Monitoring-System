<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_backlog = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_studentID = New System.Windows.Forms.TextBox()
        Me.image_display = New System.Windows.Forms.PictureBox()
        Me.btn_timeinout = New FontAwesome.Sharp.IconButton()
        Me.lbl_studentname = New System.Windows.Forms.Label()
        Me.lbl_staid = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image_display, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_backlog)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 88)
        Me.Panel1.TabIndex = 0
        '
        'btn_backlog
        '
        Me.btn_backlog.BackColor = System.Drawing.Color.Maroon
        Me.btn_backlog.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backlog.ForeColor = System.Drawing.Color.White
        Me.btn_backlog.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btn_backlog.IconColor = System.Drawing.Color.Black
        Me.btn_backlog.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_backlog.Location = New System.Drawing.Point(1037, 3)
        Me.btn_backlog.Name = "btn_backlog"
        Me.btn_backlog.Size = New System.Drawing.Size(329, 88)
        Me.btn_backlog.TabIndex = 7
        Me.btn_backlog.Text = "BACK TO LOGIN"
        Me.btn_backlog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_backlog.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(553, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STA'S ATENDANCE MONITORING"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(515, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(364, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ENTER STUDENT ID:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_studentID
        '
        Me.txt_studentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_studentID.Location = New System.Drawing.Point(520, 424)
        Me.txt_studentID.Multiline = True
        Me.txt_studentID.Name = "txt_studentID"
        Me.txt_studentID.Size = New System.Drawing.Size(364, 36)
        Me.txt_studentID.TabIndex = 3
        Me.txt_studentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'image_display
        '
        Me.image_display.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.image_display.BackColor = System.Drawing.Color.Transparent
        Me.image_display.Image = CType(resources.GetObject("image_display.Image"), System.Drawing.Image)
        Me.image_display.Location = New System.Drawing.Point(551, 112)
        Me.image_display.Name = "image_display"
        Me.image_display.Size = New System.Drawing.Size(289, 146)
        Me.image_display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.image_display.TabIndex = 5
        Me.image_display.TabStop = False
        '
        'btn_timeinout
        '
        Me.btn_timeinout.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_timeinout.IconChar = FontAwesome.Sharp.IconChar.Clock
        Me.btn_timeinout.IconColor = System.Drawing.Color.Black
        Me.btn_timeinout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_timeinout.IconSize = 43
        Me.btn_timeinout.Location = New System.Drawing.Point(520, 478)
        Me.btn_timeinout.Name = "btn_timeinout"
        Me.btn_timeinout.Size = New System.Drawing.Size(364, 59)
        Me.btn_timeinout.TabIndex = 6
        Me.btn_timeinout.Text = "TIME-IN / OUT"
        Me.btn_timeinout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_timeinout.UseVisualStyleBackColor = True
        '
        'lbl_studentname
        '
        Me.lbl_studentname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_studentname.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studentname.ForeColor = System.Drawing.Color.Gold
        Me.lbl_studentname.Location = New System.Drawing.Point(468, 315)
        Me.lbl_studentname.Name = "lbl_studentname"
        Me.lbl_studentname.Size = New System.Drawing.Size(513, 43)
        Me.lbl_studentname.TabIndex = 7
        Me.lbl_studentname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_staid
        '
        Me.lbl_staid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staid.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staid.ForeColor = System.Drawing.Color.Gold
        Me.lbl_staid.Location = New System.Drawing.Point(428, 274)
        Me.lbl_staid.Name = "lbl_staid"
        Me.lbl_staid.Size = New System.Drawing.Size(518, 41)
        Me.lbl_staid.TabIndex = 8
        Me.lbl_staid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lbl_time)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 615)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1360, 100)
        Me.Panel2.TabIndex = 9
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.White
        Me.lbl_time.Location = New System.Drawing.Point(427, 0)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(102, 35)
        Me.lbl_time.TabIndex = 0
        Me.lbl_time.Text = "Label3"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1360, 715)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbl_staid)
        Me.Controls.Add(Me.lbl_studentname)
        Me.Controls.Add(Me.btn_timeinout)
        Me.Controls.Add(Me.image_display)
        Me.Controls.Add(Me.txt_studentID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main_page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image_display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_studentID As TextBox
    Friend WithEvents image_display As PictureBox
    Friend WithEvents btn_timeinout As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_backlog As FontAwesome.Sharp.IconButton
    Friend WithEvents lbl_studentname As Label
    Friend WithEvents lbl_staid As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_time As Label
    Friend WithEvents Timer1 As Timer
End Class
